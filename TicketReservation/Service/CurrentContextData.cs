using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using CommonClass;

namespace TicketReservation.Service
{
	public class CurrentContextData
	{
		private readonly HttpClient httpClient;
		public Customer Customers { get; set; } =
			new Customer()
			{
				FirstName = "Prashant",
				LastName = "Priyadarshi",
				CountryCode = "91",
				PhoneNumber = "1234567890"
			};
		public CurrentContextData(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}
		public async Task<IEnumerable<AvailableVehicle>> GetAvailableVehiclesAsync(SearchVehicle searchVehicle)
		{
			var vehicleList = await httpClient.GetFromJsonAsync<List<AvailableVehicle>>($"api/search/{searchVehicle}"); 
			return vehicleList;
		}
		public async void ReserveVehicleAsync(Order order)
		{
			var result = await httpClient.PostAsJsonAsync("api/Reserve", order);

		}

		public async Task<IEnumerable<Order>> GetOrdersAsync()
		{
			var orders = await httpClient.GetFromJsonAsync<List<Order>>("api/orders");
			return orders;
		}
		public string GenerateNumber(int length)
		{
			const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
			StringBuilder res = new StringBuilder();
			Random rnd = new Random();
			while (0 < length--)
			{
				res.Append(valid[rnd.Next(valid.Length)]);
			}
			return res.ToString();
		}
	}
}
