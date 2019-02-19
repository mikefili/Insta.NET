using InstaDOTNET.Data;
using InstaDOTNET.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDOTNET.Models.Services
{
    public class CommentManager : IComment
    {
        // Properties
        private readonly InstaDOTNETDbContext _context;

        /// <summary>
        /// Bring in DbContext
        /// </summary>
        /// <param name="context">DbContext</param>
        public CommentManager(InstaDOTNETDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Delete a comment asynchronously
        /// </summary>
        /// <param name="id">ID of comment to be deleted</param>
        /// <returns>Task</returns>
        public async Task DeleteAsync(int id)
        {
            Comment comment = _context.Comments.FirstOrDefault(c => c.ID == id);
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Get a list of comments asynchronously
        /// </summary>
        /// <returns>List of comments</returns>
        public async Task<List<Comment>> GetCommentsAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        /// <summary>
        /// Save a comment asynchronously
        /// </summary>
        /// <param name="comment">Comment to be saved</param>
        /// <returns>Task</returns>
        public async Task SaveAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }
    }
}
