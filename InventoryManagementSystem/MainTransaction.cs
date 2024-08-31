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
	public partial class MainTransaction : Form
	{
		AppDbContext db = new AppDbContext();
		public MainTransaction()
		{
			InitializeComponent();
			this.Shown += MainTransaction_Shown;
		}

		private void MainTransaction_Shown(object? sender, EventArgs e)
		{
			TransactionTable.DataSource = SetDataTable();
		}

		public List<object> SetDataTable()
		{
			var transaction = db.Transactions;
			var product = db.Product;

			var data = from trans in transaction
					   join pro in product
					   on trans.ProductId equals pro.ProductId
					   select new
					   {
						   trans.TransactionId,
						   trans.ProductId,
						   pro.Name,
						   trans.TransactionDate,
						   trans.Quantity,
						   trans.Notes
					   };
			return data.Cast<object>().ToList();
		}

		private void btnSale_Click(object sender, EventArgs e)
		{
			TransactionManagment transactionManagment = new TransactionManagment(true);
			transactionManagment.DataSet += TransactionManagment_DataSet;
			transactionManagment.Show();
		}
		private void btnPurchase_Click(object sender, EventArgs e)
		{
			TransactionManagment transactionManagment = new TransactionManagment(false);
			transactionManagment.DataSet += TransactionManagment_DataSet;
			transactionManagment.Show();
		}

		private void TransactionManagment_DataSet()
		{
			TransactionTable.DataSource = SetDataTable();

		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form homeForm = new Main();
			homeForm.Show();
			this.Hide();

		}
	}
}
