using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Entities
{
	public class Inventory
	{
		public int InventoryId { get; set; }
		public int ProductId { get; set; }
		public int QuantityInStock { get; set; }

		// Navigation property for Product
		public Product Product { get; set; } = null;

	}
}
