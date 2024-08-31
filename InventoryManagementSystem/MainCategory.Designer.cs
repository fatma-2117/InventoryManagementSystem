namespace InventoryManagementSystem
{
	partial class MainCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCategory));
			categoryTable = new DataGridView();
			toolStrip2 = new ToolStrip();
			btnAdd = new ToolStripButton();
			btnEdite = new ToolStripButton();
			btnDelete = new ToolStripButton();
			label1 = new Label();
			btnHome = new ToolStripButton();
			((System.ComponentModel.ISupportInitialize)categoryTable).BeginInit();
			toolStrip2.SuspendLayout();
			SuspendLayout();
			// 
			// categoryTable
			// 
			categoryTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			categoryTable.BackgroundColor = Color.FromArgb(124, 147, 195);
			categoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			categoryTable.Location = new Point(12, 85);
			categoryTable.Name = "categoryTable";
			categoryTable.RowHeadersWidth = 51;
			categoryTable.Size = new Size(301, 353);
			categoryTable.TabIndex = 0;
			// 
			// toolStrip2
			// 
			toolStrip2.BackColor = Color.FromArgb(225, 215, 183);
			toolStrip2.ImageScalingSize = new Size(30, 30);
			toolStrip2.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdite, btnDelete, btnHome });
			toolStrip2.Location = new Point(0, 0);
			toolStrip2.Name = "toolStrip2";
			toolStrip2.Size = new Size(583, 37);
			toolStrip2.TabIndex = 2;
			toolStrip2.Text = "toolStrip2";
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
			btnAdd.ImageTransparentColor = Color.Magenta;
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(74, 34);
			btnAdd.Text = "Add";
			btnAdd.Click += btnAdd_Click;
			// 
			// btnEdite
			// 
			btnEdite.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnEdite.Image = (Image)resources.GetObject("btnEdite.Image");
			btnEdite.ImageTransparentColor = Color.Magenta;
			btnEdite.Name = "btnEdite";
			btnEdite.Size = new Size(83, 34);
			btnEdite.Text = "Edite";
			btnEdite.Click += btnEdite_Click;
			// 
			// btnDelete
			// 
			btnDelete.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
			btnDelete.ImageTransparentColor = Color.Magenta;
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(97, 34);
			btnDelete.Text = "Delete";
			btnDelete.Click += btnDelete_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 56);
			label1.Name = "label1";
			label1.Size = new Size(152, 26);
			label1.TabIndex = 3;
			label1.Text = "Categories :";
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
			// MainCategory
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(85, 103, 156);
			ClientSize = new Size(583, 450);
			Controls.Add(label1);
			Controls.Add(toolStrip2);
			Controls.Add(categoryTable);
			Name = "MainCategory";
			Text = "MainCategory";
			((System.ComponentModel.ISupportInitialize)categoryTable).EndInit();
			toolStrip2.ResumeLayout(false);
			toolStrip2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView categoryTable;
		private ToolStrip toolStrip2;
		private ToolStripButton btnAdd;
		private Label label1;
		private ToolStripButton btnEdite;
		private ToolStripButton btnDelete;
		private ToolStripButton btnHome;
	}
}