using Inventory_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace InventoryManagementSystem
{
	internal class AppDbContext : DbContext
	{
		public DbSet<Product> Product { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<Inventory> Inventory { get; set; }
		public DbSet<Transactions> Transactions { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = .; Database = InventoryManagmentSystem ; Trusted_Connection = True ; Encrypt = false ; TrustServerCertificate = True");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Primary Key 
			modelBuilder.Entity<Product>().HasKey(i => i.ProductId);
			modelBuilder.Entity<Category>().HasKey(i => i.CategoryId);
			modelBuilder.Entity<Inventory>().HasKey(i => i.InventoryId);
			modelBuilder.Entity<Transactions>().HasKey(i => i.TransactionId);

			//Handling String
			modelBuilder.Entity<Product>()
				.Property(p => p.Name).HasColumnType("VARCHAR")
				.HasMaxLength(50);

			modelBuilder.Entity<Product>()
				.Property(p => p.Description).HasColumnType("VARCHAR")
				.HasMaxLength(100);

			modelBuilder.Entity<Category>()
				.Property(p => p.CategoryName).HasColumnType("VARCHAR")
				.HasMaxLength(50);

			modelBuilder.Entity<Transactions>()
				.Property(p => p.Notes).HasColumnType("VARCHAR")
				.HasMaxLength(150);


			//Relations
			modelBuilder.Entity<Product>()
				.HasOne(p => p.Category)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryId)
				.IsRequired();

			modelBuilder.Entity<Product>()
				.HasOne(p => p.Inventory)
				.WithOne(i => i.Product)
				.HasForeignKey<Inventory>(i => i.ProductId)
				.IsRequired();

			modelBuilder.Entity<Transactions>()
				.HasOne(i => i.Product)
				.WithMany(p => p.Transactions)
				.HasForeignKey(i => i.ProductId)
				.IsRequired();

			
		}
	}
}
