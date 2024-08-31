using Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
	public partial class MainInventory : Form
	{
		AppDbContext db = new AppDbContext();
		bool sort = false;
		bool low = false;
		public MainInventory()
		{
			InitializeComponent();
			this.Shown += MainInventory_Shown;

			BindingSource bindingSource = new BindingSource();
			Inventory inventory = new Inventory();
			bindingSource.DataSource = inventory;
			QuantityLoad();
			StockList.ComboBox.DataBindings.Add("SelectedValue", bindingSource, nameof(inventory.ProductId));

		}

		private void MainInventory_Shown(object? sender, EventArgs e)
		{
			InventoryTable.DataSource = SetDataTable();
		}

		public List<object> SetDataTable()
		{
			var product = db.Product;
			var inventory = db.Inventory;
			var data = from i in inventory
					   join p in product on i.ProductId equals p.ProductId
					   join c in db.Category on p.CategoryId equals c.CategoryId
					   select new
					   {
						   i.InventoryId,
						   i.ProductId,
						   p.Name,
						   i.QuantityInStock,
						   p.CategoryId
					   };

			if (sort)
			{
				data = data.OrderBy(i => i.QuantityInStock);
				sort = false;
			}
			if (low)
			{
				data = data.Where(i => i.QuantityInStock <= 20);
				low = false;
			}
			if (StockList.ComboBox.SelectedIndex != -1)
			{
				int categoryId = Convert.ToInt32(StockList.ComboBox.SelectedValue);
				data = data.Where(i => i.CategoryId == categoryId);
			}

			return data.Cast<object>().ToList();

		}
		public void QuantityLoad()
		{
			var categoryFiltration = db.Category.Distinct().ToList();
			StockList.ComboBox.DataSource = categoryFiltration;
			StockList.ComboBox.DisplayMember = "CategoryName";
			StockList.ComboBox.ValueMember = "CategoryId";
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			sort = true;
			InventoryTable.DataSource = SetDataTable();
			

		}
		private void btnLowStock_Click(object sender, EventArgs e)
		{
			low = true;
			InventoryTable.DataSource = SetDataTable();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			InventoryTable.DataSource = SetDataTable();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{

			StockList.ComboBox.SelectedIndex = -1;
			StockList.ComboBox.SelectedIndex = -1;
			InventoryTable.DataSource = SetDataTable();

		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form HomeForm = new Main();
			HomeForm.Show();
			this.Hide();

		}
	}
}
