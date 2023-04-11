using System.ComponentModel.DataAnnotations;

namespace CommonClass
{
	public class Order
	{
        [Key]
        public Guid Id { get; set; }
		public Customer CustomerData { get; set; }

		public SearchVehicle SearchVehicles { get; set; }

		public AvailableVehicle AvailableVehicles { get; set; }

		public bool IsCancelled { get; set; } = false;
	}
}
