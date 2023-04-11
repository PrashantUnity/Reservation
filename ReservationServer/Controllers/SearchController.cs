using CommonClass;
using Microsoft.AspNetCore.Mvc;
using ReservationServer.Database; 

namespace ReservationServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SearchController : ControllerBase
	{
		private readonly IRepository repository;

		public SearchController(IRepository repository)
		{
			this.repository = repository;
		}

		// GET api/Search/
		[HttpGet]
		public ActionResult<IEnumerable<AvailableVehicle>> Get(SearchVehicle searchVehicle)
		{
			return Ok( repository.GetAvailableVehicle(searchVehicle));
		}
	}
}
