using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDOTNET.Models.Interfaces
{
    public interface IComment
    {
        // Find
        //Task<Comment> FindCommentAsync(int id);

        // GetAll
        Task<List<Comment>> GetCommentsAsync();

        // Save
        Task SaveAsync(Comment comment);
    }
}
