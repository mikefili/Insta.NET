using System;
using Xunit; t
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
    }
}
