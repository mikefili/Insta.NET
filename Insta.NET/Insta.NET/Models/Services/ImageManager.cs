using InstaDOTNET.Data;
using InstaDOTNET.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDOTNET.Models.Services
{
    public class ImageManager : IImage
    {
        private readonly InstaDOTNETDbContext _context;

        public ImageManager(InstaDOTNETDbContext context)
        {
            _context = context;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Image> FindImage(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Image>> GetImages()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
