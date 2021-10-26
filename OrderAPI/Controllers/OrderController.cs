using Microsoft.AspNetCore.Mvc;
using OrderAPI.Business;
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
        private readonly IOrderManagement _orderManagement;

        public OrderController(IOrderManagement orderManagement)
        {
            _orderManagement = orderManagement;
        }

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

        /// <summary>
        /// Creates an Order in the system
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="order">Order Object</param>
        /// <returns>ID of created order</returns>
        /// <response code="200">Order Created Successfully</response>
        /// <response code="400">If Order fails creation</response>  
        [HttpPost]
        public ActionResult<int> Post([FromBody] Order order)
        {
            try
            {
                return Ok(_orderManagement.CreateOrder(order));
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
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
