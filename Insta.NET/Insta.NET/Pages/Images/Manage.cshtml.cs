using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using InstaDOTNET.Models;
using InstaDOTNET.Models.Interfaces;
using InstaDOTNET.Models.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;

namespace InstaDOTNET.Pages.Images
{
    public class ManageModel : PageModel
    {
        private readonly IImage _image;

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Image Image { get; set; }

        [BindProperty]
        public IFormFile ImageFile { get; set; }

        public Blob BlobImage { get; set; }

        public ManageModel (IImage image, IConfiguration configuration)
        {
            _image = image;
            // Blob Storage Account ref
            BlobImage = new Blob(configuration);
        }

        public async Task OnGetAsync()
        {
            Image = await _image.FindImageAsync(ID.GetValueOrDefault()) ?? new Image();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // make call to db w/ ID or create new if ID does not exist
            Image img = await _image.FindImageAsync(ID.GetValueOrDefault()) ?? new Image();

            // set the data from the db to the new data from Image/user input
            img.Name = Image.Name;
            img.Author = Image.Author;
            img.Caption = Image.Caption;

            if (ImageFile != null)
            {
                // Do all of our Azure Blob stuff:
                // Get file path & get image on server
                var filePath = Path.GetTempFileName();
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(stream);
                }

                // Get container
                var container = await BlobImage.GetContainer("images");

                // Upload the image
                BlobImage.UploadFile(container, ImageFile.FileName, filePath);

                // Get the image we just uploaded
                CloudBlob blob = await BlobImage.GetBlob(ImageFile.FileName, container.Name);

                // Update the db image for the image
                img.URL = blob.Uri.ToString();
            }

            // save the image in the db
            await _image.SaveAsync(img);
            return RedirectToPage("/Index", new { id = img.ID });
        }

        public async Task<IActionResult> OnPostDeleteAsync()
        {
            await _image.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");
        }
    }
}