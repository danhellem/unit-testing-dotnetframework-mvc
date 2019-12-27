using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;

using Diablo.DataAccessLayer.Data;
using Diablo.DataAccessLayer.Models;
using Diablo.MvcWebApp.Controllers;

using Moq;

namespace Diablo.MoqUnitTests
{
    [TestClass]
    public class DepartmentControllerTest
    {           
        
        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Index_Successfull()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();

            var data = new List<DataAccessLayer.Models.Department>
            {
                new Department { Address = "131 West Ave", City = "Boston", DepartmentId = 1, Description = "Description of Department", IsActive = true, IsDeleted = false, Name = "Media Department", PostalCode = "49655", State = "MA" },
                new Department { Address = "XYX East Ave", City = "San Francisco", DepartmentId = 2, Description = "Description of Department 2", IsActive = true, IsDeleted = false, Name = "HR Department", PostalCode = "49655", State = "CA" }
            };

            repositoryMock.Setup(x => x.List).Returns(data);
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act
            var result = objController.Index();

            ViewResult _viewresult = (ViewResult)result;
            IList<Department> _list = (IList<Department>)_viewresult.Model;

            //assert
            repositoryMock.Verify(x => x.List, Times.Once());
            Assert.IsInstanceOfType(((ViewResult)result).Model, typeof(IList<Department>));
            Assert.AreEqual(_list.Count, 2, "");

            result = null;
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Details_Successfull()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();
            var data = new Department { Address = "131 West Ave", City = "Boston", DepartmentId = 1, Description = "Description of Department", IsActive = true, IsDeleted = false, Name = "Media Department", PostalCode = "49655", State = "MA" };

            repositoryMock.Setup(x => x.Find(1)).Returns(data);
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act
            var result = objController.Details(1);
            ViewResult _viewresult = (ViewResult)result;
            
            //assert
            repositoryMock.Verify(x => x.Find(1), Times.Once());                        
            Assert.IsInstanceOfType(((ViewResult)result).Model, typeof(Department));
            Assert.AreEqual(_viewresult.Model, data);
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Details_ID_LessThanOne()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();
            var data = new Department { Address = "131 West Ave", City = "Boston", DepartmentId = 1, Description = "Description of Department", IsActive = true, IsDeleted = false, Name = "Media Department", PostalCode = "49655", State = "MA" };

            repositoryMock.Setup(x => x.Find(0)).Returns(data);
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act
            var result = objController.Details(0);
           
            //assert
            repositoryMock.Verify(x => x.Find(0), Times.Never());
            Assert.AreEqual(((ViewResult)result).ViewData["Message"], "Missing id value");          
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Details_ID_Not_Found()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();
            Department data = null;

            repositoryMock.Setup(x => x.Find(1)).Returns(data);
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act
            var result = objController.Details(1);
         
            //assert
            repositoryMock.Verify(x => x.Find(1), Times.Once());                       
            Assert.IsInstanceOfType(result, typeof(System.Web.Mvc.HttpNotFoundResult));
            Assert.IsNotInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Create_Get_Successfull()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();
                       
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act
            var result = objController.Create();

            //assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));

            result = null;
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Create_Post_Successfull()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();
            var department = new Department { DepartmentId = 7, Name = "CleanUp", Description = "This place is a mess", Address = "4445 East Lansing Road", City = "Salt Lake City", State = "UT", PostalCode = "29854", IsActive = true, IsDeleted = false };

            repositoryMock.Setup(x => x.Store(department));
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act
            var result = objController.Create(department);

            //assert
            repositoryMock.Verify(x => x.Store(department), Times.Once());     
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));

            result = null;
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Create_Post_NullDepartment()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();
            Department department = null;

            repositoryMock.Setup(x => x.Store(department));
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act            
            var result = objController.Create(department);

            //assert
            repositoryMock.Verify(x => x.Store(department), Times.Never()); 
            Assert.IsInstanceOfType(result, typeof(System.Web.Mvc.HttpNotFoundResult));

            result = null;
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Create_Post_ModelStateInvalid()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();
            var department = new Department { DepartmentId = 7, Name = "CleanUp", Description = "This place is a mess", Address = "4445 East Lansing Road", City = "Salt Lake City", State = "UT", PostalCode = "29854", IsActive = true, IsDeleted = false };

            repositoryMock.Setup(x => x.Store(department));
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            // you add this value on ModelState to force the error
            objController.ModelState.AddModelError("", "mock error message");

            //act            
            var result = objController.Create(department);

            //assert
            repositoryMock.Verify(x => x.Store(department), Times.Never()); 
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.IsInstanceOfType(((ViewResult)result).Model, typeof(Department));

            result = null;
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_Delete_Successfull()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();
            var data = new Department { Address = "131 West Ave", City = "Boston", DepartmentId = 1, Description = "Description of Department", IsActive = true, IsDeleted = false, Name = "Media Department", PostalCode = "49655", State = "MA" };

            repositoryMock.Setup(x => x.Find(1)).Returns(data);
            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act
            var result = objController.Delete(1);
            ViewResult _viewresult = (ViewResult)result;

            //assert
            repositoryMock.Verify(x => x.Find(1), Times.Once());
            Assert.IsInstanceOfType(((ViewResult)result).Model, typeof(Department));
            Assert.AreEqual(_viewresult.Model, data);
        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        [TestProperty("Controller", "Department")]
        public void DepartmentController_DeleteConfirmed_Successfull()
        {
            //arrange
            var repositoryMock = new Mock<IDepartmentRepository>();

            DepartmentController objController = new DepartmentController(repositoryMock.Object);

            //act
            var result = (RedirectToRouteResult)objController.DeleteConfirmed(1);
            
            //assert
            repositoryMock.Verify(x => x.Delete(1), Times.Once());
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
            Assert.AreEqual("Index", result.RouteValues["action"]);              
        }
    }
}
