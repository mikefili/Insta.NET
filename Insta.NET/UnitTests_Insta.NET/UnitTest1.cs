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
    }
}
