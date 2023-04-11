using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonClass
{
	public class Order
	{
        [Key]
        public Guid Id { get; set; } 
		public Guid CustomerId { get; set; }
		public Guid SearchVehicleId { get; set; }
		
		[ForeignKey("CustomerId")]
		public Customer CustomerData { get; set; }

		[ForeignKey("SearchVehicleId")]
		public SearchVehicle SearchVehicles { get; set; }
		public bool IsCancelled { get; set; } = false;

		public AvailableVehicle AvailableVehicles { get; set; }

	}
}
