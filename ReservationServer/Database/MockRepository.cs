﻿using CommonClass;
using System.Text;

namespace ReservationServer.Database
{
    public class MockRepository : IRepository
    {
		#region Mock Database For Testing
		public List<Order> orders = new List<Order>();

        public List<Customer> customers = new List<Customer>();

        public List<AvailableVehicle> lsOfAvailableVehicle = new List<AvailableVehicle>();
		private bool MockUpdate(Order order)
		{
			var check = orders.Select(x=>x).FirstOrDefault(x=>x.Id == order.Id);
            if(check != null) { return false; }

            orders = orders.Where(x=>x.Id != order.Id).ToList();
            orders.Add(order);
            return true;
		}
		private Order MockAddOrder(Order order)
        {
            orders.Add(order);
            return order;
        }
		private Customer MockAddCustomer(Customer customer)
		{
			customers.Add(customer);
			return customer;
		}
        private IEnumerable<Order> MockAllOrders(string id) 
        {
			return orders.Where(x => x.CustomerData.PhoneNumber == id);
		}
        private Order? Mockorder(string id)
        {
            return orders.Select(x=>x).FirstOrDefault(x=>x.CustomerData.PhoneNumber==id);
        }
		Random random = new Random();
		public VechileType RandomVechileType()
		{
			var n = random.Next(0, 5);
			if (n == 0) return VechileType.X;
			if (n == 1) return VechileType.SELECT;
			if (n == 2) return VechileType.SUV;
			if (n == 3) return VechileType.XL;
			return VechileType.BLACK;
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
		private IEnumerable<AvailableVehicle> MockGetAvailableVehicle(SearchVehicle searchVehicle)
        {
            var count = random.Next(6, 16);
            var mindistance = random.Next(3, 10);
            var startTime = DateTime.Now;
            int numLength = 7;
            for (int i = 0; i < count; i++)
            {
                var costPerkm = 1 + random.Next(0, 5);
                var distance = mindistance + random.Next(0, 20);
                var endTime = startTime.AddHours(distance); 

                var vehicle = new AvailableVehicle();
                vehicle.VehicleNumber = GenerateNumber(numLength);
                vehicle.VechileTypes = RandomVechileType();
                vehicle.Id = new Guid();
                vehicle.StartTime = startTime.ToString();
                vehicle.ReachTime = endTime.ToString();
                vehicle.TotalCost = distance * costPerkm;
                vehicle.TotalDistance = distance;
                vehicle.CostPerKm = costPerkm;


                lsOfAvailableVehicle.Add(vehicle);
            }
            return lsOfAvailableVehicle;
        }
		#endregion
		public Order? GetOrder(string id)
        {
            return Mockorder(id);
        }
        public Order AddOrder(Order order)
        {

            return MockAddOrder(order);
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public IEnumerable<Order> GetAllOrders(string id)
        {
            return MockAllOrders(id);

		}

        public IEnumerable<AvailableVehicle> GetAvailableVehicle(SearchVehicle searchVehicle)
        {
            return MockGetAvailableVehicle(searchVehicle);
        }

        public bool UpdateOrder(Order order)
        {
            return MockUpdate(order);
        } 
	}
}
