using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Entities
{
	public class Transactions
	{
		public int TransactionId { get; set; }
		public DateTime TransactionDate { get; set; }
		// Foreign Key for Product
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public string? Notes { get; set; }
		public Product Product { get; set; } = null;
	}
}
