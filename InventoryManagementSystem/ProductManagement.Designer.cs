namespace InventoryManagementSystem
{
	partial class ProductManagement
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			IdText = new TextBox();
			NameText = new TextBox();
			DescText = new TextBox();
			priceText = new TextBox();
			CategoryList = new ComboBox();
			btnSave = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bauhaus 93", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(28, 35);
			label1.Name = "label1";
			label1.Size = new Size(204, 53);
			label1.TabIndex = 0;
			label1.Text = "Product ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(82, 129);
			label2.Name = "label2";
			label2.Size = new Size(116, 22);
			label2.TabIndex = 1;
			label2.Text = "ProductID :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(82, 195);
			label3.Name = "label3";
			label3.Size = new Size(75, 22);
			label3.TabIndex = 2;
			label3.Text = "Name :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(82, 256);
			label4.Name = "label4";
			label4.Size = new Size(125, 22);
			label4.TabIndex = 3;
			label4.Text = "Description :";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(82, 387);
			label5.Name = "label5";
			label5.Size = new Size(68, 22);
			label5.TabIndex = 4;
			label5.Text = "Price :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(82, 325);
			label6.Name = "label6";
			label6.Size = new Size(103, 22);
			label6.TabIndex = 5;
			label6.Text = "Category :";
			// 
			// IdText
			// 
			IdText.ForeColor = SystemColors.WindowFrame;
			IdText.Location = new Point(299, 125);
			IdText.Name = "IdText";
			IdText.Size = new Size(169, 26);
			IdText.TabIndex = 6;
			// 
			// NameText
			// 
			NameText.Location = new Point(299, 191);
			NameText.Name = "NameText";
			NameText.Size = new Size(169, 26);
			NameText.TabIndex = 7;
			// 
			// DescText
			// 
			DescText.Location = new Point(299, 256);
			DescText.Name = "DescText";
			DescText.Size = new Size(169, 26);
			DescText.TabIndex = 8;
			// 
			// priceText
			// 
			priceText.Location = new Point(299, 387);
			priceText.Name = "priceText";
			priceText.Size = new Size(169, 26);
			priceText.TabIndex = 9;
			// 
			// CategoryList
			// 
			CategoryList.FormattingEnabled = true;
			CategoryList.Location = new Point(299, 321);
			CategoryList.Name = "CategoryList";
			CategoryList.Size = new Size(169, 26);
			CategoryList.TabIndex = 10;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.FromArgb(124, 147, 195);
			btnSave.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnSave.Location = new Point(183, 446);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(128, 48);
			btnSave.TabIndex = 11;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			// 
			// ProductManagement
			// 
			AutoScaleDimensions = new SizeF(9F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(85, 103, 156);
			ClientSize = new Size(533, 506);
			Controls.Add(btnSave);
			Controls.Add(CategoryList);
			Controls.Add(priceText);
			Controls.Add(DescText);
			Controls.Add(NameText);
			Controls.Add(IdText);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Name = "ProductManagement";
			Text = "ProductManagement";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox IdText;
		private TextBox NameText;
		private TextBox DescText;
		private TextBox priceText;
		private ComboBox CategoryList;
		private Button btnSave;
	}
}