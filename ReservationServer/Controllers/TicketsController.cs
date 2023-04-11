using CommonClass;
using Microsoft.AspNetCore.Mvc;
using ReservationServer.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReservationServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TicketsController : ControllerBase
	{
        private readonly IRepository repository;

        public TicketsController(IRepository repository)
        {
            this.repository = repository;
        }
        // GET api/<TicketsController>/5
        [HttpGet("{id}")]
		public ActionResult<IEnumerable<Order>> Get(Guid id)
		{
			var ls = repository.GetAllOrders(id);
			return Ok(ls) ;
		}
	}
}
