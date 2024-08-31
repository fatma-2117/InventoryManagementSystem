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

	public partial class ProductManagement : Form
	{
		AppDbContext db = new AppDbContext();
		BindingSource bindingSource;
		public event Action DataSet;

		public ProductManagement(int id) : this()
		{
			bindingSource.DataSource = db.Product.FirstOrDefault(i=>i.ProductId == id);
		}
		public ProductManagement()
		{
			InitializeComponent();

			bindingSource = new BindingSource();
			Product product = new Product();
			bindingSource.DataSource = product;

			IdText.DataBindings.Add("Text", bindingSource, nameof(product.ProductId), true, DataSourceUpdateMode.Never);
			NameText.DataBindings.Add("Text", bindingSource, "Name");
			DescText.DataBindings.Add("Text", bindingSource, "Description");
			priceText.DataBindings.Add("Text", bindingSource, "SellingPrice");
			LoadCategory();
			CategoryList.DataBindings.Add("SelectedValue", bindingSource, nameof(product.CategoryId));
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateForm())
			{
				MessageBox.Show("Please fill out all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Product product = bindingSource.Current as Product;
				if (product.ProductId == 0)
				{
					InsertData(product);
				}
				else
				{
					UpdateData(product);
				}
				DataSet?.Invoke();
				this.Hide();

			}
		}
		public void LoadCategory()
		{
			var category = db.Category.ToList();
			CategoryList.DataSource = category;
			CategoryList.DisplayMember = "CategoryName";
			CategoryList.ValueMember = "CategoryId";
		}

		public void InsertData(Product product)
		{
			db.Product.Add(product);
			db.SaveChanges();
			IdText.Refresh();
			MessageBox.Show("The Product has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
		public void UpdateData(Product product)
		{
			db.Product.Update(product);
			db.SaveChanges();
			MessageBox.Show("The Product has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
		public void DeleteData(int id)
		{
			Product selectedRow = db.Product.FirstOrDefault(i => i.ProductId == id);
			db.Product.Remove(selectedRow);
			db.SaveChanges();
		}
		private bool ValidateForm()
		{
			// Ensure that name, description, price, and category fields are correctly filled out
			if (string.IsNullOrEmpty(NameText.Text) ||
				string.IsNullOrEmpty(DescText.Text) ||
				!decimal.TryParse(priceText.Text, out decimal price) ||
				price <= 0 ||
				CategoryList.SelectedValue == null)
			{
				return false;
			}

			return true;
		}
	}
}
