namespace InventoryManagementSystem
{
	partial class MainProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProduct));
			productTable = new DataGridView();
			toolStrip1 = new ToolStrip();
			btnAdd = new ToolStripButton();
			btnEdite = new ToolStripButton();
			btnDelete = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			btnSearch = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripLabel1 = new ToolStripLabel();
			NameText = new ToolStripTextBox();
			toolStripLabel2 = new ToolStripLabel();
			DescText = new ToolStripTextBox();
			toolStripLabel3 = new ToolStripLabel();
			CategoryList = new ToolStripComboBox();
			btnHome = new ToolStripButton();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)productTable).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// productTable
			// 
			productTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			productTable.BackgroundColor = Color.FromArgb(124, 147, 195);
			productTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			productTable.GridColor = Color.FromArgb(124, 147, 195);
			productTable.Location = new Point(12, 123);
			productTable.Name = "productTable";
			productTable.RowHeadersWidth = 51;
			productTable.Size = new Size(664, 315);
			productTable.TabIndex = 0;
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = Color.FromArgb(225, 215, 183);
			toolStrip1.ImageScalingSize = new Size(30, 30);
			toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdite, btnDelete, toolStripSeparator2, btnSearch, toolStripSeparator1, toolStripLabel1, NameText, toolStripLabel2, DescText, toolStripLabel3, CategoryList, btnHome });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1010, 37);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Bauhaus 93", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
			btnAdd.ImageTransparentColor = Color.Magenta;
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(73, 34);
			btnAdd.Text = "Add";
			btnAdd.Click += btnAdd_Click;
			// 
			// btnEdite
			// 
			btnEdite.Font = new Font("Bauhaus 93", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnEdite.Image = (Image)resources.GetObject("btnEdite.Image");
			btnEdite.ImageTransparentColor = Color.Magenta;
			btnEdite.Name = "btnEdite";
			btnEdite.Size = new Size(81, 34);
			btnEdite.Text = "Edite";
			btnEdite.Click += btnEdite_Click;
			// 
			// btnDelete
			// 
			btnDelete.Font = new Font("Bauhaus 93", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
			btnDelete.ImageTransparentColor = Color.Magenta;
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(93, 34);
			btnDelete.Text = "Delete";
			btnDelete.Click += btnDelete_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 37);
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
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 37);
			// 
			// toolStripLabel1
			// 
			toolStripLabel1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolStripLabel1.Name = "toolStripLabel1";
			toolStripLabel1.Size = new Size(60, 34);
			toolStripLabel1.Text = "Name :";
			// 
			// NameText
			// 
			NameText.Name = "NameText";
			NameText.Size = new Size(100, 37);
			// 
			// toolStripLabel2
			// 
			toolStripLabel2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolStripLabel2.Name = "toolStripLabel2";
			toolStripLabel2.Size = new Size(103, 34);
			toolStripLabel2.Text = "Description :";
			// 
			// DescText
			// 
			DescText.Name = "DescText";
			DescText.Size = new Size(100, 37);
			// 
			// toolStripLabel3
			// 
			toolStripLabel3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolStripLabel3.Name = "toolStripLabel3";
			toolStripLabel3.Size = new Size(85, 34);
			toolStripLabel3.Text = "Category :";
			// 
			// CategoryList
			// 
			CategoryList.Name = "CategoryList";
			CategoryList.Size = new Size(121, 37);
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
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(12, 88);
			label1.Name = "label1";
			label1.Size = new Size(149, 32);
			label1.TabIndex = 2;
			label1.Text = "Products :";
			// 
			// MainProduct
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(85, 103, 156);
			ClientSize = new Size(1010, 450);
			Controls.Add(label1);
			Controls.Add(toolStrip1);
			Controls.Add(productTable);
			Name = "MainProduct";
			Text = "Products";
			((System.ComponentModel.ISupportInitialize)productTable).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView productTable;
		private ToolStrip toolStrip1;
		private ToolStripButton btnAdd;
		private Label label1;
		private ToolStripButton btnEdite;
		private ToolStripButton btnDelete;
		private ToolStripButton btnSearch;
		private ToolStripLabel toolStripLabel1;
		private ToolStripTextBox NameText;
		private ToolStripLabel toolStripLabel2;
		private ToolStripTextBox DescText;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripLabel toolStripLabel3;
		private ToolStripComboBox CategoryList;
		private ToolStripButton btnHome;
	}
}