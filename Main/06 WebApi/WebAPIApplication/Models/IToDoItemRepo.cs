using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPIApplication.Models
{
    public interface IToDoItemRepo
    {
        ToDoItem Get(int i);
        Task<IList<ToDoItem>> List();
    }
}
