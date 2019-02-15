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
        private readonly InstaDOTNETDbContext _context;

        public CommentManager(InstaDOTNETDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            Comment comment = _context.Comments.FirstOrDefault(c => c.ID == id);
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Comment>> GetCommentsAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task SaveAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }
    }
}
