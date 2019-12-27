using System;
using Xunit;

using XUnitExample.Code;

namespace XUnitExample.UnitTest
{
    
    public class XUnitExampleTest
    {
        [Fact]
        public void MyTest()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Fact]
        public void ColorCordinator_SuggestMyShirtColor_White()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.suggestMyShirtColor("white");

            //Assert
            Assert.Equal("error", objColorCordinator.shirtColor);

        }
    }
}
