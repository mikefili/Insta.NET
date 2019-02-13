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

        public async Task<List<Image>> GetImagesAsync()
        {
            return await _context.Images.ToListAsync();
        }

        public async Task SaveAsync(Image image)
        {
            Image img = await _context.Images.FirstOrDefaultAsync(m => m.ID == image.ID);
            if (await _context.Images.FirstOrDefaultAsync(m => m.ID == image.ID) == null)
            {
                _context.Images.Add(image);
            }
            else
            {
                _context.Images.Update(img);
            }
            await _context.SaveChangesAsync();
        }
    }
}
