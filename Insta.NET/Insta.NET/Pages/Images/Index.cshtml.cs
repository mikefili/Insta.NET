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
    public class IndexModel : PageModel
    {
        // Properties
        private readonly IImage _image;

        [FromRoute]
        public int ID { get; set; }

        public Image Image { get; set; }

        /// <summary>
        /// Image dependency injection
        /// </summary>
        /// <param name="image">Image "context"</param>
        public IndexModel(IImage image)
        {
            _image = image;
        }

        /// <summary>
        /// Get an image by ID
        /// </summary>
        /// <returns>Image</returns>
        public async Task OnGetAsync()
        {
            Image = await _image.FindImageAsync(ID);
        }
    }
}