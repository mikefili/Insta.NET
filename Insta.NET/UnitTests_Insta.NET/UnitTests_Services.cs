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
        // IMAGES
        [Fact]
        public async void CanGetAllImages()
        {
            DbContextOptions<InstaDOTNETDbContext> options = new DbContextOptionsBuilder<InstaDOTNETDbContext>().UseInMemoryDatabase("GetImagesAsync").Options;

            using (InstaDOTNETDbContext context = new InstaDOTNETDbContext(options))
            {
                Image image = new Image();
                image.ID = 1;
                image.Name = "Test Image";
                image.Author = "Test Author";
                image.Caption = "Test Caption";
                image.URL = "www.testURL.com/test-image.png";

                Image image2 = new Image();
                image2.ID = 2;
                image2.Name = "Test Image 2";
                image2.Author = "Test Author 2";
                image2.Caption = "Test Caption 2";
                image2.URL = "www.testURL.com/test-image-2.png";

                ImageManager imageManager = new ImageManager(context);
                await imageManager.SaveAsync(image);
                await imageManager.SaveAsync(image2);
                List<Image> images = new List<Image>();
                images.Add(image);
                images.Add(image2);

                List<Image> result = await imageManager.GetImagesAsync();

                Assert.Equal(images, result);
            }
        }

        [Fact]
        public async void CanSaveImage()
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

                Image result = await context.Images.FirstOrDefaultAsync(i => i.ID == image.ID);

                Assert.Equal(image, result);
            }
        }
    }
}
