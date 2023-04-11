﻿using CommonClass;
using Microsoft.EntityFrameworkCore; 

namespace ReservationServer.Database
{
	public class ReservationContext:DbContext
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Orders { get; set; }

		public DbSet<SearchVehicle> Vehicles { get; set; }

		public ReservationContext() 
        {
			
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;");
		}
		 

	}
}
