using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDOTNET.Models.Interfaces
{
    public interface IImage
    {
        // Delete
        Task DeleteAsync(int id);

        // Find
        Task<Image> FindImage(int id);

        // GetAll
        Task<List<Image>> GetImages();

        // Save
        Task SaveAsync(Image image);
    }
}
