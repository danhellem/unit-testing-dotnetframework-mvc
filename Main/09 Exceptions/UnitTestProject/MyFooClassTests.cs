using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyTestClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class MyFooClassTests
    {
        [TestMethod()]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void CreateNewFoo_Divide_DivideByZeroException()
        {
            //arrange
            MyFooClass foo = new MyFooClass();
            int numerator = 4;
            int denominator = 0;
            int actual;
            
            //act
            actual = foo.Divide(numerator, denominator);
            
            //assert           
           
        }

        [TestMethod()]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void CreateNewFoo_IndexOutOfRangeException()
        {
            //arrange
            MyFooClass foo = new MyFooClass();
            
            //act
            var result = foo.CreateNewFoo("IndexOutOfRangeException");

            //assert
        }

        [TestMethod()]
        [ExpectedException(typeof(System.Exception))]
        public void CreateNewFoo_Default_Exception()
        {
            //arrange
            MyFooClass foo = new MyFooClass();

            //act
            var result = foo.CreateNewFoo("default");

            //assert
        }

    }
}
