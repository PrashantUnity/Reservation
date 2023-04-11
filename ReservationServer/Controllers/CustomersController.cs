using CommonClass;
using Microsoft.AspNetCore.Mvc;
using ReservationServer.Database;

namespace ReservationServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private readonly IRepository _repository;

		public CustomersController(IRepository repository)
        {
			_repository = repository;
		}  

		// POST api/<CustomersController>
		[HttpPost]
		public void Post([FromQuery] Customer customer)
		{

		}

		// PUT api/<CustomersController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromQuery] string value)
		{
		}

		// DELETE api/<CustomersController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
