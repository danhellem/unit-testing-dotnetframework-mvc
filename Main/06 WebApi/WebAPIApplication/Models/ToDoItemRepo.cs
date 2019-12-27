using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace WebAPIApplication.Models
{

    public class ToDoItemRepo : IDisposable, IToDoItemRepo
    {
        private List<ToDoItem> dataSet;
        
        public ToDoItemRepo()
        {
            dataSet = new List<ToDoItem>()
            { 
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 1", Subject="Subject 1", Title="To-do Item Number 1" },
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 2", Subject="Subject 2", Title="To-do Item Number 2" },
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 3", Subject="Subject 3", Title="To-do Item Number 3" },
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 4", Subject="Subject 4", Title="To-do Item Number 4" },
                new ToDoItem { Id = 1, AssignedToEmail="dahellem@microsoft.com", DateDue=DateTime.Now.AddDays(2), Description="Description of to-do item 5", Subject="Subject 5", Title="To-do Item Number 5" }
            };   
        }

        public ToDoItem Get(int i)
        {
            ToDoItem item;

            if (dataSet.Count > 0)
            {
                item = dataSet[i];
            }
            else
            {
                item = new ToDoItem();
            }              

            return item;
        }

        public async Task<IList<ToDoItem>> List()
        {
            IList<ToDoItem> items;

            if (dataSet.Count > 0)
            {
                items = dataSet;
            }
            else
            {
                items = new List<ToDoItem> { new ToDoItem() };
            }

            return items;
        }              

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ToDoItemRepo()
        {
            // Finalizer calls Dispose(false)
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                if (dataSet != null)
                {
                    dataSet = null;
                }
            }           
        }
    }
}