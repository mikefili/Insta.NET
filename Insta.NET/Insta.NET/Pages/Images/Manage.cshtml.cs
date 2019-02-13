using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstaDOTNET.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InstaDOTNET.Pages.Images
{
    public class ManageModel : PageModel
    {
        private readonly IImage _image;

        public ManageModel (IImage image)
        {
            _image = image;
        }

        public void OnGet()
        {

        }
    }
}