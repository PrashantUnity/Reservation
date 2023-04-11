using CommonClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationServer.Database;

namespace ReservationServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
        private readonly IRepository repository;

        public OrdersController( IRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(Guid id)
        {
            var order = repository.GetOrder(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }
        // POST api/<OrdersController>
        [HttpPost]
		public ActionResult<Order> Post([FromBody] Order order)
		{
			var orderReturn = repository.AddOrder(order);
            return CreatedAtAction(nameof(GetOrder), new { id = orderReturn.Id }, orderReturn);
        } 
	}
}
