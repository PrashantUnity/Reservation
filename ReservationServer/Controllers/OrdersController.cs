﻿using CommonClass;
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
        public ActionResult<Order> GetOrder([FromBody] string id)
        {
            var order = repository.GetOrder(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }
		[HttpGet("AllOrders/{id}")]
		public ActionResult<Order> GetAllOrder([FromBody] string id)
		{
			var order = repository.GetAllOrders(id);

			if (order == null)
			{
				return NotFound();
			}

			return Ok(order);
		}
		// POST api/<OrdersController>
		[HttpPost]
		public ActionResult<Order> Post([FromQuery] Order order)
		{
			var orderReturn = repository.AddOrder(order);
            return CreatedAtAction(nameof(GetOrder), new { id = orderReturn.Id }, orderReturn);
        } 
	}
}
