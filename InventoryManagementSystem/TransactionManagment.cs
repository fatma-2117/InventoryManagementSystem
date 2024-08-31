using Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
	public partial class TransactionManagment : Form
	{
		AppDbContext db = new AppDbContext();
		BindingSource bindingSource;
		public event Action DataSet;
		bool sale = false;

		public TransactionManagment(bool s) :this()
		{
			sale = s;
			bindingSource = new BindingSource();
			Transactions transactions = new Transactions();
			bindingSource.DataSource = transactions;

			ProductLoad(sale);

			productList.DataBindings.Add("SelectedValue", bindingSource, nameof(transactions.ProductId));
			QuantityText.DataBindings.Add("Text", bindingSource, "Quantity");
			NoteText.DataBindings.Add("Text", bindingSource, "Notes");
		}
		public TransactionManagment()
		{
			InitializeComponent();

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
				Transactions transactions = bindingSource.Current as Transactions;
				transactions.TransactionDate = DateTime.Now;
				var inventory = db.Inventory
								.FirstOrDefault(i => i.ProductId == transactions.ProductId);
				if (sale)
				{
					
					if (inventory.QuantityInStock >= transactions.Quantity)
					{
						inventory.QuantityInStock -= transactions.Quantity;
						InsertData(transactions);
						db.SaveChanges();
						MessageBox.Show("The sale has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else
					{
						MessageBox.Show("The range larger than the quantity in stock", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Hide();

					}
				}
				else
				{
					InsertData(transactions);
					if (inventory != null)
					{
						inventory.QuantityInStock += transactions.Quantity;
					}
					else
					{
						db.Inventory.Add(new Inventory
						{
							ProductId = transactions.ProductId,
							QuantityInStock = transactions.Quantity,
						});
					}

					db.SaveChanges();
					MessageBox.Show("The purchase has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				DataSet?.Invoke();
				this.Hide();
			}


		}
		public void ProductLoad(bool sale)
		{
			if (sale)
			{
				var data = (from inventory in db.Inventory
							join product in db.Product
							on inventory.ProductId equals product.ProductId
							where inventory.QuantityInStock > 0
							select new
							{
								inventory.ProductId,
								product.Name
							}).ToList();

				productList.DataSource = data;
				productList.DisplayMember = "Name";
				productList.ValueMember = "ProductId";

			}
			else {
				var data = db.Product.ToList();
				productList.DataSource = data;
				productList.DisplayMember = "Name";
				productList.ValueMember = "ProductId";
			}
		}
		public void InsertData(Transactions transaction)
		{
			db.Transactions.Add(transaction);
			db.SaveChanges();

		}
		private bool ValidateForm()
		{
			if (productList.SelectedIndex == -1 || string.IsNullOrEmpty(QuantityText.Text) || !int.TryParse(QuantityText.Text, out int quantity) || quantity <= 0)
			{
				return false;
			}

			return true;
		}


	}
}
