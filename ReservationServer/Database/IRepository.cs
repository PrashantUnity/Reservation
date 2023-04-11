
using CommonClass; 
namespace ReservationServer.Database
{
	public interface IRepository
	{
		void AddCustomer(Customer customer);
		IEnumerable<AvailableVehicle>  GetAvailableVehicle(SearchVehicle searchVehicle);
		Order AddOrder(Order order);
		bool UpdateOrder(Order order);
		Order GetOrder(string id);
		IEnumerable<Order>  GetAllOrders(string id);
	}
}
