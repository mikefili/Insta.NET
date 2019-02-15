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
    public class CommentsModel : PageModel
    {
        private readonly IComment _comment;

        public CommentsModel(IComment comment)
        {
            _comment = comment;
        }

        [FromRoute]
        public int ID { get; set; }

        [BindProperty]
        public Comment Comment { get; set; }

        public void OnGet()
        {
            Comment = new Comment();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // create new comment
            var com = new Comment();

            // set the comment data to the db
            com.ImageID = ID;
            com.CommentString = Comment.CommentString;
            com.CommentAuthor = Comment.CommentAuthor;

            // save the comment in the db
            await _comment.SaveAsync(com);
            return RedirectToPage("/Images/Index", ID);
        }
    }
}