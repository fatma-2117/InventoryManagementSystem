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
	public partial class CategoriesManagement : Form
	{
		AppDbContext db = new AppDbContext();
		BindingSource bindingSource;
		public event Action DataSet;

		public CategoriesManagement(int id) : this()
		{
			bindingSource.DataSource = db.Category.FirstOrDefault(i => i.CategoryId == id);
		}
		public CategoriesManagement()
		{
			InitializeComponent();

			bindingSource = new BindingSource();
			Category category = new Category();
			bindingSource.DataSource = category;

			nameText.DataBindings.Add("Text", bindingSource, "CategoryName");
			IdText.DataBindings.Add("Text", bindingSource, nameof(category.CategoryId), true, DataSourceUpdateMode.Never);
		}
		 private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(nameText.Text))
			{
				MessageBox.Show("Please enter a valid category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Category category = bindingSource.Current as Category;
				if (category.CategoryId == 0)
				{
					InsertData(category);
				}
				else
				{
					UpdateData(category);
				}
				DataSet?.Invoke();
				this.Hide();

			}
		}

		public void InsertData(Category category)
		{
			db.Category.Add(category);
			db.SaveChanges();
			IdText.Refresh();
			MessageBox.Show("The Category has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public void UpdateData(Category category)
		{
			db.Category.Update(category);
			db.SaveChanges();
			MessageBox.Show("The Category has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void DeleteData(int id)
		{
			Category selectedRow = db.Category.FirstOrDefault(i => i.CategoryId == id);
			db.Category.Remove(selectedRow);
			db.SaveChanges();
		}
	}
}
