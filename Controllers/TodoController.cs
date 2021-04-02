using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Demo.Models;

namespace Todo.Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        // GET: api/Todo
        /// <summary>
        /// This is the API which will return a list of customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }
        
        // GET: api/Todo/5
        /// <summary>
        /// This is the API which will return a customer based on id
        /// </summary>
        /// <remarks>
        /// How to call:
        ///     GET /api/todo/1
        /// </remarks>
        /// <param name="id"></param>
        /// <response code="200">A valid customer</response>
        /// <response code="400">Invalid customer id</response>
        /// <returns>A Customer</returns>
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return new Customer();
        }
        
        // POST: api/Todo
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }
        
        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int d)
        {
            
        }
    }
}