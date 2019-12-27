using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ExerciseOne.Code;
using System.Diagnostics.CodeAnalysis;

namespace ExerciseOne.UnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ColorCordinatorTest
    {
        private ColorCordinator objColorCordinator;

        [TestInitialize]
        public void TestInitialize()
        {
            //Arrange
            objColorCordinator = new ColorCordinator();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            objColorCordinator = null;
        }

        //[TestCategory("Unit Test")]
        //[Owner("Team Blue")]
        //[Priority(1)]
        //[TestProperty("My New Test Name", "Hot")]

        [TestMethod]       
        public void ColorCordinator_SuggestMyShirtColor_Red_Equals_Pink()
        {
            //Arrange
            //ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.suggestMyShirtColor("red");

            //Assert
            Assert.AreEqual("pink", objColorCordinator.shirtColor);
        }

        [TestMethod]
        public void ColorCordinator_SuggestMyShirtColor_Blue_Equals_Green()
        {
            //Arrange
            //ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.suggestMyShirtColor("blue");

            //Assert
            Assert.AreEqual("green", objColorCordinator.shirtColor);
        }

        [TestMethod]
        public void ColorCordinator_SuggestMyShirtColor_Green_Equals_Blue()
        {
            //Arrange
            //ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.suggestMyShirtColor("green");

            //Assert
            Assert.AreEqual("blue", objColorCordinator.shirtColor);
        }


        [TestMethod]
        [Ignore]
        public void ColorCordinator_SuggestMyShirtColor_Pink_Equals_Yellow()
        {
            //Arrange
            //ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.suggestMyShirtColor("pink");

            //Assert
            Assert.AreEqual("yellow", objColorCordinator.shirtColor);
        }

        [TestMethod]        
        public void ColorCordinator_SuggestMyShirtColor_Gray_Equals_Black()
        {
            //Arrange
            //ColorCordinator objColorCordinator = new ColorCordinator();

            //Act
            objColorCordinator.suggestMyShirtColor("gray");

            //Assert
            Assert.AreEqual("error", objColorCordinator.shirtColor);
        }     

    }
}
