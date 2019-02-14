//using InstaDOTNET.Data;
//using InstaDOTNET.Models.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace InstaDOTNET.Models.Services
//{
//    public class CommentManager : IComment
//    {
//        private readonly InstaDOTNETDbContext _context;

//        public CommentManager(InstaDOTNETDbContext context)
//        {
//            _context = context;
//        }

//        public async Task CreateComment(Comment comment)
//        {
//            _context.Comments.Add(comment);
//            await _context.SaveChangesAsync();
//        }

//        public async Task DeleteAsync(int id)
//        {
//            Comment comment = _context.Comments.FirstOrDefault(c => c.ID == id);
//            _context.Comments.Remove(comment);
//            await _context.SaveChangesAsync();
//        }

//        public Task<Comment> FindCommentAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<List<Comment>> GetCommentsAsync()
//        {
//            throw new NotImplementedException();
//        }

//        public Task SaveAsync(Comment comment)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
