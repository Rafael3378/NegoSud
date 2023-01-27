using System;
using Microsoft.EntityFrameworkCore;

namespace NegoSud.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)// construct
			: base(options)
		{

		}

		//public virtual DbSet<Customer> Customers => Set<Customer>();// créer la BDD avec les entités de customer

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlite("Data Source=negosuddb.db");
		}

		public DbSet<Customer> Customers { get; set; }
	}
}

