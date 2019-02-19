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
        // Properties
        private readonly IComment _comment;

        [FromRoute]
        public int ID { get; set; }

        [BindProperty]
        public Comment Comment { get; set; }

        /// <summary>
        /// Comment dependency injection
        /// </summary>
        /// <param name="comment">Comment "context"</param>
        public CommentsModel(IComment comment)
        {
            _comment = comment;
        }

        /// <summary>
        /// Create new comment
        /// </summary>
        public void OnGet()
        {
            Comment = new Comment();
        }

        /// <summary>
        /// Post user input to new comment
        /// </summary>
        /// <returns>Redirect to Image Index page</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            // create new comment
            Comment com = new Comment();

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