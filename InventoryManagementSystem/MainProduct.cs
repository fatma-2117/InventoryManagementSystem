using Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
	public partial class MainProduct : Form
	{
		AppDbContext db = new AppDbContext();

		public MainProduct()
		{
			InitializeComponent();
			this.Shown += MainProduct_Shown;
			BindingSource bindingSource = new BindingSource();
			Product product = new Product();
			bindingSource.DataSource = product;
			LoadCategory();
			CategoryList.ComboBox.DataBindings.Add("SelectedValue", bindingSource, nameof(product.CategoryId));
		}



		private void btnAdd_Click(object sender, EventArgs e)
		{
			ProductManagement productManagement = new ProductManagement();
			productManagement.DataSet += ProductManagement_DataSet;
			productManagement.Show();
		}
		private void btnEdite_Click(object sender, EventArgs e)
		{
			var selectedRow = productTable.CurrentRow.DataBoundItem;
			var Productid = selectedRow.GetType().GetProperty("ProductId");
			int id = (int)Productid.GetValue(selectedRow);
			ProductManagement productManagement = new ProductManagement(id);
			productManagement.DataSet += ProductManagement_DataSet;
			productManagement.Show();
			RefreshProductTable();


		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var selectedRow = productTable.CurrentRow.DataBoundItem;
			var Productid = selectedRow.GetType().GetProperty("ProductId");
			int id = (int)Productid.GetValue(selectedRow);
			ProductManagement productManagement = new ProductManagement(id);
			productManagement.DeleteData(id);
			productManagement.DataSet += ProductManagement_DataSet;
			RefreshProductTable();

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			RefreshProductTable();
			NameText.Text = string.Empty;
			DescText.Text = string.Empty;
			CategoryList.ComboBox.SelectedIndex = -1;
		}
		private void MainProduct_Shown(object? sender, EventArgs e)
		{
			RefreshProductTable();
		}

		private void RefreshProductTable()
		{
			productTable.DataSource = SetDataTable();
		}

		public void LoadCategory()
		{
			var category = db.Category.ToList();
			CategoryList.ComboBox.DataSource = category;
			CategoryList.ComboBox.DisplayMember = "CategoryName";
			CategoryList.ComboBox.ValueMember = "CategoryId";
		}
		public List<object> SetDataTable()
		{
			var data = db.Product.Select(p => new
			{
				p.ProductId,
				p.Name,
				p.Description,
				p.SellingPrice,
				p.CategoryId
			}).ToList();

			string name = NameText.Text;
			string Description = DescText.Text;

			if (!string.IsNullOrWhiteSpace(name))
			{

				data = data.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
			}
			if (!string.IsNullOrWhiteSpace(Description))
			{

				data = data.Where(p => p.Description.Contains(Description, StringComparison.OrdinalIgnoreCase)).ToList();
			}
			if (CategoryList.ComboBox.SelectedIndex != -1)
			{
				int Categoryid = Convert.ToInt32(CategoryList.ComboBox.SelectedValue);
				data = data.Where(p => p.CategoryId == Categoryid).ToList();
			}

			return data.Cast<object>().ToList();
		}
		private void ProductManagement_DataSet()
		{
			RefreshProductTable();

		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form homeform = new Main();
			homeform.Show();
			this.Hide();

		}
	}
}
