
using CommonClass; 
namespace ReservationServer.Database
{
	public interface IRepository
	{
		void AddCustomer(Customer customer);
		IEnumerable<AvailableVehicle>  GetAvailableVehicle(SearchVehicle searchVehicle);
		Order AddOrder(Order order);
		Order GetOrder(Guid id);
		bool UpdateOrder(Order order);
		IEnumerable<Order>  GetAllOrders(Guid id);
	}
}
