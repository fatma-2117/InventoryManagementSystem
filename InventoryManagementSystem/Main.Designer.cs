namespace InventoryManagementSystem
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			toolStrip1 = new ToolStrip();
			btnProductM = new ToolStripButton();
			btnTransaction = new ToolStripButton();
			btnInventoryM = new ToolStripButton();
			btnCategoryM = new ToolStripButton();
			contextMenuStrip1 = new ContextMenuStrip(components);
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripSeparator3 = new ToolStripSeparator();
			toolStripSeparator4 = new ToolStripSeparator();
			toolStripSeparator5 = new ToolStripSeparator();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = Color.FromArgb(124, 147, 195);
			toolStrip1.GripMargin = new Padding(2, 10, 2, 10);
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.ImageScalingSize = new Size(45, 45);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator5, btnProductM, toolStripSeparator1, btnTransaction, toolStripSeparator2, btnInventoryM, toolStripSeparator3, btnCategoryM, toolStripSeparator4 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0, 10, 2, 10);
			toolStrip1.Size = new Size(800, 92);
			toolStrip1.Stretch = true;
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// btnProductM
			// 
			btnProductM.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnProductM.Image = (Image)resources.GetObject("btnProductM.Image");
			btnProductM.ImageTransparentColor = Color.Magenta;
			btnProductM.Name = "btnProductM";
			btnProductM.RightToLeft = RightToLeft.No;
			btnProductM.Size = new Size(177, 69);
			btnProductM.Text = "Product Managment";
			btnProductM.TextDirection = ToolStripTextDirection.Horizontal;
			btnProductM.TextImageRelation = TextImageRelation.ImageAboveText;
			btnProductM.Click += btnProductM_Click;
			// 
			// btnTransaction
			// 
			btnTransaction.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnTransaction.Image = (Image)resources.GetObject("btnTransaction.Image");
			btnTransaction.ImageTransparentColor = Color.Magenta;
			btnTransaction.Name = "btnTransaction";
			btnTransaction.Size = new Size(195, 69);
			btnTransaction.Text = "Transaction Recording";
			btnTransaction.TextImageRelation = TextImageRelation.ImageAboveText;
			btnTransaction.Click += btnTransaction_Click;
			// 
			// btnInventoryM
			// 
			btnInventoryM.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnInventoryM.Image = (Image)resources.GetObject("btnInventoryM.Image");
			btnInventoryM.ImageTransparentColor = Color.Magenta;
			btnInventoryM.Name = "btnInventoryM";
			btnInventoryM.Size = new Size(185, 69);
			btnInventoryM.Text = "    Inventory Status     ";
			btnInventoryM.TextImageRelation = TextImageRelation.ImageAboveText;
			btnInventoryM.Click += btnInventoryM_Click;
			// 
			// btnCategoryM
			// 
			btnCategoryM.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCategoryM.Image = (Image)resources.GetObject("btnCategoryM.Image");
			btnCategoryM.ImageTransparentColor = Color.Magenta;
			btnCategoryM.Name = "btnCategoryM";
			btnCategoryM.Size = new Size(192, 69);
			btnCategoryM.Text = "Category Managment";
			btnCategoryM.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCategoryM.Click += btnCategoryM_Click;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 72);
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 72);
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 72);
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(6, 72);
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(6, 72);
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(toolStrip1);
			Name = "Main";
			Text = "Form1";
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripButton btnProductM;
		private ToolStripButton btnTransaction;
		private ToolStripButton btnInventoryM;
		private ToolStripButton btnCategoryM;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripSeparator toolStripSeparator4;
	}
}
