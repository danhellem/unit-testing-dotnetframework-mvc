using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataDriven.Code;

namespace DataDriven.UnitTests
{
    [TestClass]
    public class ColorCordinatorTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        
        [TestMethod]
        [DeploymentItem("SuggestMyShirtColorData.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"|DataDirectory|\SuggestMyShirtColorData.csv", "SuggestMyShirtColorData#csv", DataAccessMethod.Sequential)]
        public void DataDriven_Code_ColorCordinator_SuggestMyShirtColor_FromDataSource()
        {
            //Arrange
            ColorCordinator objColorCordinator = new ColorCordinator();
                        
            string inputVal = testContextInstance.DataRow["Input1"].ToString();
            string expectedResultVal = testContextInstance.DataRow["ExpectedResult"].ToString();

            //Act
            objColorCordinator.suggestMyShirtColor(inputVal);    

            var result = objColorCordinator.shirtColor;

            //Assert
            Assert.AreEqual(result, expectedResultVal, "Data says: for pant color input of '" + inputVal + "' the shirt color should have been '" + expectedResultVal + "'");
        }
    }
}
