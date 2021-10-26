using Microsoft.AspNetCore.Mvc;
using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        /// <summary>
        /// Retrieves an order by ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="id">ID of Order</param>
        /// <returns>Returns an Order</returns>
        /// <response code="200">Returns the order retrieved</response>
        /// <response code="400">If the order does not exist</response>  
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            var order = DummyData.DummyData.DummyOrders.FirstOrDefault(x => x.ID == id);
            if (order is null)
                return NotFound();

            return Ok(order);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
