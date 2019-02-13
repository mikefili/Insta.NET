using System;
using Xunit;
using InstaDOTNET;
using InstaDOTNET.Models;

namespace UnitTests_Insta.NET
{
    public class ImageUnitTests
    {
        [Fact]
        public void CanGetImageName()
        {
            Image testImage = new Image();
            testImage.Name = "Test Name";
            Assert.Equal("Test Name", testImage.Name);
        }

        [Fact]
        public void CanSetImageName()
        {
            Image testImage = new Image();
            testImage.Name = "Test Image";
            testImage.Name = "Test Image One";
            Assert.Equal("Test Image One", testImage.Name);
        }

        [Fact]
        public void CanGetImageAuthor()
        {
            Image testImage = new Image();
            testImage.Author = "Test Author";
            Assert.Equal("Test Author", testImage.Author);
        }

        [Fact]
        public void CanSetImageAuthor()
        {
            Image testImage = new Image();
            testImage.Author = "Test Author";
            testImage.Author = "Test Author One";
            Assert.Equal("Test Author One", testImage.Author);
        }
    }
}
