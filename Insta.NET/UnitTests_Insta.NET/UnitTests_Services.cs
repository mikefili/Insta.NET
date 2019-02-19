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
        // IMAGE UNIT TESTS

        [Fact]
        public async void CanDeleteImageAsync()
        {
            DbContextOptions<InstaDOTNETDbContext> options = new DbContextOptionsBuilder<InstaDOTNETDbContext>().UseInMemoryDatabase("DeleteAsync").Options;

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
                await imageManager.DeleteAsync(image.ID);

                Image result = await context.Images.FirstOrDefaultAsync(i => i.ID == image.ID);

                Assert.Null(result);
            }
        }

        [Fact]
        public async void CanFindImageAsync()
        {
            DbContextOptions<InstaDOTNETDbContext> options = new DbContextOptionsBuilder<InstaDOTNETDbContext>().UseInMemoryDatabase("FindImageAsync").Options;

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

                Image result = await imageManager.FindImageAsync(image.ID);

                Assert.Equal(image, result);
            }
        }

        [Fact]
        public async void CanGetAllImagesAsync()
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
        public async void CanSaveImageAsync()
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

        // COMMENT UNIT TESTS

        [Fact]
        public async void CanGetAllCommentsAsync()
        {
            DbContextOptions<InstaDOTNETDbContext> options = new DbContextOptionsBuilder<InstaDOTNETDbContext>().UseInMemoryDatabase("GetCommentsAsync").Options;

            using (InstaDOTNETDbContext context = new InstaDOTNETDbContext(options))
            {
                Comment comment = new Comment();
                comment.ID = 1;
                comment.ImageID = 1;
                comment.CommentString = "Test Comment";
                comment.CommentAuthor = "Test Author";

                Comment comment2 = new Comment();
                comment2.ID = 2;
                comment2.ImageID = 1;
                comment2.CommentString = "Test Comment 2";
                comment2.CommentAuthor = "Test Author 2";

                CommentManager commentManager = new CommentManager(context);
                await commentManager.SaveAsync(comment);
                await commentManager.SaveAsync(comment2);
                List<Comment> comments = new List<Comment>();
                comments.Add(comment);
                comments.Add(comment2);

                List<Comment> result = await commentManager.GetCommentsAsync();

                Assert.Equal(comments, result);
            }
        }

        [Fact]
        public async void CanSaveCommentAsync()
        {
            DbContextOptions<InstaDOTNETDbContext> options = new DbContextOptionsBuilder<InstaDOTNETDbContext>().UseInMemoryDatabase("SaveAsync").Options;

            using (InstaDOTNETDbContext context = new InstaDOTNETDbContext(options))
            {
                Comment comment = new Comment();
                comment.ID = 1;
                comment.ImageID = 1;
                comment.CommentString = "Test Comment";
                comment.CommentAuthor = "Test Author";

                CommentManager commentManager = new CommentManager(context);
                await commentManager.SaveAsync(comment);

                Comment result = await context.Comments.FirstOrDefaultAsync(c => c.ID == comment.ID);

                Assert.Equal(comment, result);
            }
        }
    }
}
