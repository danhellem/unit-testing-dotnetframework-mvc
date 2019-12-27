using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestDrivenDevelopment.Code;

namespace TestDrivenDevelopment.UnitTests
{
    [TestClass]
    public class TestDrivenDevelopmentTests
    {       
        
        [TestMethod]
        public void ColorCordinator_Shirt_Red_Result_Is_Pink()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("red");
            var result = objColorCordinator.shirtColor;
          
            //Assert
            Assert.AreEqual("pink", result, "red pants should suggest pink shirt");

            objColorCordinator = null;                       
        }

        [TestMethod]
        public void ColorCordinator_Shoes_Red_Result_Is_BrownAndBlack()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("red");
            var result = objColorCordinator.ListShoes;

            //Assert
            Assert.IsInstanceOfType(result, typeof(IList<string>));
            Assert.IsTrue(result.Contains("black"), "shoe color must contain black");
            Assert.IsTrue(result.Contains("brown"), "shoe color must contain brown");
            Assert.IsTrue((result.Count == 2), "only two results should be returned");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shirt_Blue_Result_Is_Green()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("blue");
            var result = objColorCordinator.shirtColor;

            //Assert
            Assert.AreEqual("green", result, "blue pants should suggest green shirt");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shoes_Blue_Result_Is_WhiteAndBlack()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("blue");
            var result = objColorCordinator.ListShoes;

            //Assert
            Assert.IsInstanceOfType(result, typeof(IList<string>));
            Assert.IsTrue(result.Contains("white"), "shoe color must contain white");
            Assert.IsTrue(result.Contains("black"), "shoe color must contain black");
            Assert.IsTrue((result.Count == 2), "only two results should be returned");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shirt_Green_Result_Is_Blue()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("green");
            var result = objColorCordinator.shirtColor;

            //Assert
            Assert.AreEqual("blue", result, "green pants should suggest blue shirt");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shoes_Green_Result_Is_Black()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("green");
            var result = objColorCordinator.ListShoes;

            //Assert
            Assert.IsInstanceOfType(result, typeof(IList<string>));
            Assert.IsTrue(result.Contains("black"), "shoe color must contain black");
            Assert.IsTrue((result.Count == 1), "only one result should be returned");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shirt_Pink_Result_Is_Yellow()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("pink");
            var result = objColorCordinator.shirtColor;

            //Assert
            Assert.AreEqual("yellow", result, "pink pants should suggest yellow shirt");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shoes_Pink_Result_Is_Black()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("pink");
            var result = objColorCordinator.ListShoes;

            //Assert
            Assert.IsInstanceOfType(result, typeof(IList<string>));
            Assert.IsTrue(result.Contains("black"), "shoe color must contain black");
            Assert.IsTrue((result.Count == 1), "only one result should be returned");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shirt_Black_Result_Is_White()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("black");
            var result = objColorCordinator.shirtColor;

            //Assert
            Assert.AreEqual("white", result, "black pants should suggest white shirt");
            
            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shoes_Black_Result_Is_White()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("black");
            var result = objColorCordinator.ListShoes;

            //Assert
            Assert.IsInstanceOfType(result, typeof(IList<string>));
            Assert.IsTrue(result.Contains("black"), "shoe color must contain black");
            Assert.IsTrue((result.Count == 1), "only one result should be returned");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shirt_Empty_Result_Is_Error()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("");
            var result = objColorCordinator.shirtColor;

            //Assert
            Assert.AreEqual("error", result, "empty pants should suggest error shirt");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shoes_Empty_Result_Is_White()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("");
            var result = objColorCordinator.ListShoes;

            //Assert
            Assert.IsInstanceOfType(result, typeof(IList<string>));
            Assert.IsTrue(result.Contains("black"), "shoe color must contain black");
            Assert.IsTrue((result.Count == 1), "only one result should be returned");

            objColorCordinator = null;
        }

        [TestMethod]
        public void ColorCordinator_Shirt_Default_Result_Is_Black()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.RunColorCordinatorForPants("other");
            var result = objColorCordinator.shirtColor;

            //Assert
            Assert.AreEqual("black", result, "other color of pants should suggest black shirt");

            objColorCordinator = null;
        }
    }
}
