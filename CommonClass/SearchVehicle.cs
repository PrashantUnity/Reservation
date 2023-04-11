using System.ComponentModel.DataAnnotations;

namespace CommonClass
{
	public class SearchVehicle
	{
		[Key]
		public Guid Id { get; set; }
		public DateTime OnWhichDate = DateTime.Now;

		[Required]
		public string LocationFrom { get; set; } = "";
		[Required]
		public string LocationTo { get; set; } = "";
	}
}
