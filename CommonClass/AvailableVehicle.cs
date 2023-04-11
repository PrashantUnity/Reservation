using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClass
{
	public class AvailableVehicle
	{
        [Key]
        public Guid Id { get; set; } 
        public VechileType VechileTypes { get; set; }
		public string StartTime { get; set; }
		public string ReachTime { get; set; }
		public string VehicleNumber { get; set; }
		public float TotalDistance { get; set; }
		public double CostPerKm { get; set; }
		public double TotalCost { get; set; }
	}
}
