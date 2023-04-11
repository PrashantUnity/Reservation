using CommonClass;
using System.Text;

namespace ReservationServer.Database
{
    public class MockRepository : IRepository
    {
        public Order GetOrder(Guid id)
        {
            throw new NotImplementedException();
        }
        public Order AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrders(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AvailableVehicle> GetAvailableVehicle(SearchVehicle searchVehicle)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
        Random random = new Random();
        public VechileType RandonVechile()
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

        
    }
}
