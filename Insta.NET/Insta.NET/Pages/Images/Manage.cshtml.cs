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

        public async Task OnGet()
        {
            Image = await _image.FindImageAsync(ID.GetValueOrDefault()) ?? new Image();
        }
    }
}