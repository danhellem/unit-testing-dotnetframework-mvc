using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;
using System.Threading.Tasks;

using WebAPIApplication.Api;
using WebAPIApplication.Models;

using Moq;

namespace WebAPIApplication.UnitTests.Api
{
    [TestClass]
    public class ToDoItemsControllerTest
    {
        [TestMethod]
        public async Task GetToDoItems_Successfull()
        {
            //arrange
            Mock<IToDoItemRepo> repoMock = new Mock<IToDoItemRepo>();
            //HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            List<ToDoItem> data = new List<ToDoItem>()
            { 
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 1", Subject="Subject 1", Title="To-do Item Number 1" },
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 2", Subject="Subject 2", Title="To-do Item Number 2" },
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 3", Subject="Subject 3", Title="To-do Item Number 3" },
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 4", Subject="Subject 4", Title="To-do Item Number 4" },
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 5", Subject="Subject 5", Title="To-do Item Number 5" }
            };

            repoMock.Setup(x => x.List()).Returns(Task.FromResult<IList<ToDoItem>>(data));

            ToDoItemsController controller = new ToDoItemsController(repoMock.Object);
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            //act
            var result = await controller.GetToDoItems();
            var content = await result.Content.ReadAsAsync<List<ToDoItem>>();
            
            //assert
            repoMock.Verify(x => x.List(), Times.Once());
            Assert.IsInstanceOfType(result, typeof(HttpResponseMessage), "'result' type must be a HttpResponseMessage");
            Assert.IsInstanceOfType(content, typeof(IList<ToDoItem>), "'content' type must be of IList<ToDoItem>");
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
    }
}
