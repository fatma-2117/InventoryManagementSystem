namespace InventoryManagementSystem
{
	partial class MainInventory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInventory));
			InventoryTable = new DataGridView();
			label1 = new Label();
			toolStrip1 = new ToolStrip();
			btnSort = new ToolStripButton();
			btnLowStock = new ToolStripButton();
			btnSearch = new ToolStripButton();
			StockList = new ToolStripComboBox();
			btnReset = new ToolStripButton();
			btnHome = new ToolStripButton();
			((System.ComponentModel.ISupportInitialize)InventoryTable).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// InventoryTable
			// 
			InventoryTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			InventoryTable.BackgroundColor = Color.FromArgb(124, 147, 195);
			InventoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			InventoryTable.Location = new Point(12, 134);
			InventoryTable.Name = "InventoryTable";
			InventoryTable.RowHeadersWidth = 51;
			InventoryTable.Size = new Size(551, 304);
			InventoryTable.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 89);
			label1.Name = "label1";
			label1.Size = new Size(179, 42);
			label1.TabIndex = 1;
			label1.Text = "Inventory";
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = Color.FromArgb(225, 215, 183);
			toolStrip1.ImageScalingSize = new Size(30, 30);
			toolStrip1.Items.AddRange(new ToolStripItem[] { btnSort, btnLowStock, btnSearch, StockList, btnReset, btnHome });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 37);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "toolStrip1";
			// 
			// btnSort
			// 
			btnSort.Font = new Font("Bauhaus 93", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnSort.Image = (Image)resources.GetObject("btnSort.Image");
			btnSort.ImageTransparentColor = Color.Magenta;
			btnSort.Name = "btnSort";
			btnSort.Size = new Size(169, 34);
			btnSort.Text = "Sort the Quantity";
			btnSort.Click += btnSort_Click;
			// 
			// btnLowStock
			// 
			btnLowStock.Font = new Font("Bauhaus 93", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnLowStock.Image = (Image)resources.GetObject("btnLowStock.Image");
			btnLowStock.ImageTransparentColor = Color.Magenta;
			btnLowStock.Name = "btnLowStock";
			btnLowStock.Size = new Size(115, 34);
			btnLowStock.Text = "low Stock";
			btnLowStock.Click += btnLowStock_Click;
			// 
			// btnSearch
			// 
			btnSearch.Font = new Font("Bauhaus 93", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
			btnSearch.ImageTransparentColor = Color.Magenta;
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(93, 34);
			btnSearch.Text = "Search";
			btnSearch.Click += btnSearch_Click;
			// 
			// StockList
			// 
			StockList.Name = "StockList";
			StockList.Size = new Size(121, 37);
			// 
			// btnReset
			// 
			btnReset.Font = new Font("Bauhaus 93", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnReset.Image = (Image)resources.GetObject("btnReset.Image");
			btnReset.ImageTransparentColor = Color.Magenta;
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(130, 34);
			btnReset.Text = "Reset Table";
			btnReset.Click += btnReset_Click;
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
			// MainInventory
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(85, 103, 156);
			ClientSize = new Size(800, 450);
			Controls.Add(toolStrip1);
			Controls.Add(label1);
			Controls.Add(InventoryTable);
			Name = "MainInventory";
			Text = "MainInventory";
			((System.ComponentModel.ISupportInitialize)InventoryTable).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView InventoryTable;
		private Label label1;
		private ToolStrip toolStrip1;
		private ToolStripButton btnSort;
		private ToolStripButton btnLowStock;
		private ToolStripButton btnSearch;
		private ToolStripComboBox StockList;
		private ToolStripButton btnReset;
		private ToolStripButton btnHome;
	}
}