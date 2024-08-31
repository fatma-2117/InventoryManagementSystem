﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }

		// Navigation property for Products
		public ICollection<Product> Products { get; set; } = new List<Product>();

	}
}
