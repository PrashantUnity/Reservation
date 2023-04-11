
using System.Text;
using System;
using CommonClass;

namespace ReservationServer.Database
{
	public class Repository : IRepository
	{ 
		

        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AvailableVehicle> GetAvailableVehicle(SearchVehicle searchVehicle)
        {
            throw new NotImplementedException();
        }
        public Order GetOrder(Guid id)
        {
            throw new NotImplementedException();
        }
        public Order AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrders(Guid id)
        {
            throw new NotImplementedException();
        }
    }
	
}
