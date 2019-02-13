using InstaDOTNET.Data;
using InstaDOTNET.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task DeleteAsync(int id)
        {
            Image image = await _context.Images.FindAsync(id);
            if (image != null)
            {
                _context.Remove(image);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Image> FindImageAsync(int id)
        {
            Image image = await _context.Images.FirstOrDefaultAsync(img => img.ID == id);
            return image;
        }

        public Task<List<Image>> GetImagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
