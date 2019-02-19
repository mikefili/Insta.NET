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
        // Properties
        private readonly InstaDOTNETDbContext _context;

        /// <summary>
        /// Bring in DbContext
        /// </summary>
        /// <param name="context">DbContext</param>
        public ImageManager(InstaDOTNETDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Delete an image asynchronously
        /// </summary>
        /// <param name="id">ID of image to delete</param>
        /// <returns>Task</returns>
        public async Task DeleteAsync(int id)
        {
            Image image = await _context.Images.FindAsync(id);
            if (image != null)
            {
                _context.Remove(image);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Find an image asynchronously
        /// </summary>
        /// <param name="id">ID of image to find</param>
        /// <returns></returns>
        public async Task<Image> FindImageAsync(int id)
        {
            Image image = await _context.Images.FirstOrDefaultAsync(img => img.ID == id);
            return image;
        }

        /// <summary>
        /// Get a list of all images asynchronously
        /// </summary>
        /// <returns>List of images</returns>
        public async Task<List<Image>> GetImagesAsync()
        {
            return await _context.Images.ToListAsync();
        }

        /// <summary>
        /// Save an image asynchronously
        /// </summary>
        /// <param name="image">Image to be saved</param>
        /// <returns>Task</returns>
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
