namespace InventoryManagementSystem
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void btnCategoryM_Click(object sender, EventArgs e)
		{
			Form Categoryform = new MainCategory();
			Categoryform.Show();
			this.Hide();
		}

		private void btnProductM_Click(object sender, EventArgs e)
		{
			Form Productform = new MainProduct();
			Productform.Show();
			this.Hide();

		}

		private void btnInventoryM_Click(object sender, EventArgs e)
		{
			Form Inventoryform = new MainInventory();
			Inventoryform.Show();
			this.Hide();

		}

		private void btnTransaction_Click(object sender, EventArgs e)
		{
			Form Transactionform = new MainTransaction();
			Transactionform.Show();
			this.Hide();
		}
	}
}
