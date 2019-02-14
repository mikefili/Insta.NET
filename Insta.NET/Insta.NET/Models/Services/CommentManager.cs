using InstaDOTNET.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDOTNET.Models.Services
{
    public class CommentManager : IComment
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> FindCommentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetCommentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
