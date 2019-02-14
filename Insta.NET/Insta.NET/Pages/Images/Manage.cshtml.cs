using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstaDOTNET.Models;
using InstaDOTNET.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InstaDOTNET.Pages.Images
{
    public class ManageModel : PageModel
    {
        private readonly IImage _image;

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Image Image { get; set; }

        public ManageModel (IImage image)
        {
            _image = image;
        }

        public async Task OnGetAsync()
        {
            Image = await _image.FindImageAsync(ID.GetValueOrDefault()) ?? new Image();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // make call to db w/ ID or create new if ID does not exist
            var img = await _image.FindImageAsync(ID.GetValueOrDefault()) ?? new Image();

            // set the data from the db to the new data from Image/user input
            img.Name = Image.Name;
            img.Author = Image.Author;
            img.Caption = Image.Caption;
            img.URL = Image.URL;

            // save the image in the db
            await _image.SaveAsync(img);
            return RedirectToPage("/Images/Index", new { id = img.ID });
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await _image.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");
        }
    }
}