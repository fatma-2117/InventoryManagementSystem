
namespace InventoryManagementSystem
{
	partial class MainTransaction
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTransaction));
			TransactionTable = new DataGridView();
			label1 = new Label();
			toolStrip1 = new ToolStrip();
			btnPurchase = new ToolStripButton();
			btnSale = new ToolStripButton();
			btnHome = new ToolStripButton();
			((System.ComponentModel.ISupportInitialize)TransactionTable).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// TransactionTable
			// 
			TransactionTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			TransactionTable.BackgroundColor = Color.FromArgb(124, 147, 195);
			TransactionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TransactionTable.Location = new Point(12, 122);
			TransactionTable.Name = "TransactionTable";
			TransactionTable.RowHeadersWidth = 51;
			TransactionTable.Size = new Size(776, 316);
			TransactionTable.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bauhaus 93", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 85);
			label1.Name = "label1";
			label1.Size = new Size(195, 34);
			label1.TabIndex = 1;
			label1.Text = "Transactions";
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = Color.FromArgb(225, 215, 183);
			toolStrip1.ImageScalingSize = new Size(30, 30);
			toolStrip1.Items.AddRange(new ToolStripItem[] { btnPurchase, btnSale, btnHome });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 37);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "toolStrip1";
			// 
			// btnPurchase
			// 
			btnPurchase.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnPurchase.Image = (Image)resources.GetObject("btnPurchase.Image");
			btnPurchase.ImageTransparentColor = Color.Magenta;
			btnPurchase.Name = "btnPurchase";
			btnPurchase.Size = new Size(138, 34);
			btnPurchase.Text = "purchase";
			btnPurchase.Click += btnPurchase_Click;
			// 
			// btnSale
			// 
			btnSale.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnSale.Image = (Image)resources.GetObject("btnSale.Image");
			btnSale.ImageTransparentColor = Color.Magenta;
			btnSale.Name = "btnSale";
			btnSale.Size = new Size(88, 34);
			btnSale.Text = "sale";
			btnSale.Click += btnSale_Click;
			// 
			// btnHome
			// 
			btnHome.Alignment = ToolStripItemAlignment.Right;
			btnHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnHome.Image = (Image)resources.GetObject("btnHome.Image");
			btnHome.ImageTransparentColor = Color.Magenta;
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(34, 34);
			btnHome.Text = "toolStripButton1";
			btnHome.Click += btnHome_Click;
			// 
			// MainTransaction
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(85, 103, 156);
			ClientSize = new Size(800, 450);
			Controls.Add(toolStrip1);
			Controls.Add(label1);
			Controls.Add(TransactionTable);
			Name = "MainTransaction";
			Text = "Transactions";
			((System.ComponentModel.ISupportInitialize)TransactionTable).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}


		#endregion

		private DataGridView TransactionTable;
		private Label label1;
		private ToolStrip toolStrip1;
		private ToolStripButton btnPurchase;
		private ToolStripButton btnSale;
		private ToolStripButton btnHome;
	}
}