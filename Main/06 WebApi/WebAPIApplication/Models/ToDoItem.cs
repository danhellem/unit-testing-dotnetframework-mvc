using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIApplication.Models
{
    public class ToDoItem
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string AssignedToEmail { get; set; }
        public DateTime DateDue { get; set; }
    }
}