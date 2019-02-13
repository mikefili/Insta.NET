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

        [Fact]
        public void CanGetImageCaption()
        {
            Image testImage = new Image();
            testImage.Caption = "Test Caption";
            Assert.Equal("Test Caption", testImage.Caption);
        }

        [Fact]
        public void CanSetImageCaption()
        {
            Image testImage = new Image();
            testImage.Caption = "Test Caption";
            testImage.Caption = "Test Caption One";
            Assert.Equal("Test Caption One", testImage.Caption);
        }

        [Fact]
        public void CanGetImageURL()
        {
            Image testImage = new Image();
            testImage.URL = "www.test.com";
            Assert.Equal("www.test.com", testImage.URL);
        }

        [Fact]
        public void CanSetImageURL()
        {
            Image testImage = new Image();
            testImage.URL = "www.test.com";
            testImage.URL = "www.test.net";
            Assert.Equal("www.test.net", testImage.URL);
        }
    }
}
