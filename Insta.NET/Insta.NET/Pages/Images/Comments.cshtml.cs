using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstaDOTNET.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InstaDOTNET.Pages.Images
{
    public class CommentsModel : PageModel
    {
        private readonly IComment _comment;

        public CommentsModel(IComment comment)
        {
            _comment = comment;
        }

        public void OnGet()
        {

        }
    }
}