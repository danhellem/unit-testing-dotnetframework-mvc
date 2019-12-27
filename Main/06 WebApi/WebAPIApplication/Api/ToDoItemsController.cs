using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPIApplication.Models;

namespace WebAPIApplication.Api
{
    public class ToDoItemsController : ApiController
    {
        private IToDoItemRepo repo;
        private HttpResponseMessage httpResponseMessage;
        
        public ToDoItemsController()
        {
            repo = new ToDoItemRepo();           
        }

        public ToDoItemsController(IToDoItemRepo repoMock)
        {
            repo = repoMock;                  
        }

        // GET: api/ToDoItems
        public async Task<HttpResponseMessage> GetToDoItems()
        {
            IList<ToDoItem> items;

            items = await repo.List();
           
            httpResponseMessage = Request.CreateResponse<IList<ToDoItem>>(HttpStatusCode.OK, items);

            return httpResponseMessage;
        }

        // GET: api/ToDoItems/5
        [ResponseType(typeof(ToDoItem))]
        public IHttpActionResult GetToDoItem(int i)
        {
            ToDoItem toDoItem = repo.Get(i);

            if (toDoItem == null)
            {
                return NotFound();
            }

            return Ok(toDoItem);
        }
        
        //// PUT: api/ToDoItems/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutToDoItem(int id, ToDoItem toDoItem)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != toDoItem.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(toDoItem).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ToDoItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/ToDoItems
        //[ResponseType(typeof(ToDoItem))]
        //public async Task<IHttpActionResult> PostToDoItem(ToDoItem toDoItem)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.ToDoItems.Add(toDoItem);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = toDoItem.Id }, toDoItem);
        //}

        //// DELETE: api/ToDoItems/5
        //[ResponseType(typeof(ToDoItem))]
        //public async Task<IHttpActionResult> DeleteToDoItem(int id)
        //{
        //    ToDoItem toDoItem = await db.ToDoItems.FindAsync(id);
        //    if (toDoItem == null)
        //    {
        //        return NotFound();
        //    }

        //    db.ToDoItems.Remove(toDoItem);
        //    await db.SaveChangesAsync();

        //    return Ok(toDoItem);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo = null;
            }
            base.Dispose(disposing);
        }
       
    }
}