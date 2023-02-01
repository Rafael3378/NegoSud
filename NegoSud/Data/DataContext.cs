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

        // créer la BDD avec les entités
		public DbSet<User> Users { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categorys { get; set; }
        public DbSet<Order> Orders { get; set; }
		public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}

