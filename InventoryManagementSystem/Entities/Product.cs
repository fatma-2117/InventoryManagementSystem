using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Entities
{
	public class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int SellingPrice { get; set; }

		// Foreign Key for Category
		public int CategoryId { get; set; }
		public Category Category { get; set; } = null;

		// Navigation property for Inventory
		public Inventory? Inventory { get; set; }

		// Navigation property for Transactions
		public ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();
	}
}
