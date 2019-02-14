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
        private readonly IImage _image;

        public IndexModel(IImage image)
        {
            _image = image;
        }

        [FromRoute]
        public int ID { get; set; }

        public Image Image { get; set; }

        public async Task OnGetAsync()
        {
            Image = await _image.FindImageAsync(ID);
        }
    }
}