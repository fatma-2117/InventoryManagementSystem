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
	public partial class MainCategory : Form
	{
		AppDbContext db = new AppDbContext();
		public MainCategory()
		{
			InitializeComponent();
			this.Shown += MainCategory_Shown;
		}

		private void MainCategory_Shown(object? sender, EventArgs e)
		{
			categoryTable.DataSource = SetDataTable();
		}

		public List<object> SetDataTable()
		{
			var data = db.Category.Select(c => new
			{
				Category_ID = c.CategoryId,
				Category_Name = c.CategoryName,
			}).ToList<object>();

			return data;

		}
		private void Format_Table()
		{
			categoryTable.DataSource = SetDataTable();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			CategoriesManagement categoriesManagement = new CategoriesManagement();
			categoriesManagement.DataSet += Format_Table;
			categoriesManagement.Show();
		}

		private void btnEdite_Click(object sender, EventArgs e)
		{
			var selectedRow = categoryTable.CurrentRow.DataBoundItem;
			var categoryIdProperty = selectedRow.GetType().GetProperty("Category_ID");
			int categoryId = (int)categoryIdProperty.GetValue(selectedRow);
			CategoriesManagement categoriesManagement = new CategoriesManagement(categoryId);
			categoriesManagement.DataSet += Format_Table;
			categoriesManagement.Show();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var selectedRow = categoryTable.CurrentRow.DataBoundItem;
			var categoryIdProperty = selectedRow.GetType().GetProperty("Category_ID");
			int categoryId = (int)categoryIdProperty.GetValue(selectedRow);
			CategoriesManagement categoriesManagement = new CategoriesManagement(categoryId);
			categoriesManagement.DeleteData(categoryId);
			categoriesManagement.DataSet += Format_Table;
			categoryTable.DataSource = SetDataTable();


		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form homeForm = new Main();
			homeForm.Show();
			this.Hide();

		}
	}
}
