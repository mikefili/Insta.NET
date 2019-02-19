using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using InstaDOTNET.Data;
using InstaDOTNET.Models.Services;
using Microsoft.EntityFrameworkCore;
using InstaDOTNET.Models;

namespace UnitTests_InstaDOTNET
{
    public class UnitTests_Services
    {
        [Fact]
        public async void CanPostImage()
        {
            DbContextOptions<InstaDOTNETDbContext> options = new DbContextOptionsBuilder<InstaDOTNETDbContext>().UseInMemoryDatabase("SaveAsync").Options;

            using (InstaDOTNETDbContext context = new InstaDOTNETDbContext(options))
            {
                Image image = new Image();
                image.ID = 1;
                image.Name = "Test Image";
                image.Author = "Test Author";
                image.Caption = "Test Caption";
                image.URL = "www.testURL.com/test-image.png";

                ImageManager imageManager = new ImageManager(context);
                await imageManager.SaveAsync(image);
                var result = await context.Images.FirstOrDefaultAsync(i => i.ID == image.ID);
                Assert.Equal(image, result);
            }
        }
    }
}
