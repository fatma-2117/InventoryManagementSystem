namespace InventoryManagementSystem
{
	partial class CategoriesManagement
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
			nameText = new TextBox();
			label3 = new Label();
			IdText = new TextBox();
			btnSave = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(41, 37);
			label1.Name = "label1";
			label1.Size = new Size(132, 32);
			label1.TabIndex = 0;
			label1.Text = "Category";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(12, 174);
			label2.Name = "label2";
			label2.Size = new Size(161, 22);
			label2.TabIndex = 1;
			label2.Text = "Category Name :";
			// 
			// nameText
			// 
			nameText.Location = new Point(173, 171);
			nameText.Name = "nameText";
			nameText.Size = new Size(163, 27);
			nameText.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(12, 117);
			label3.Name = "label3";
			label3.Size = new Size(131, 22);
			label3.TabIndex = 3;
			label3.Text = "Category ID :";
			// 
			// IdText
			// 
			IdText.ForeColor = SystemColors.WindowFrame;
			IdText.Location = new Point(173, 117);
			IdText.Name = "IdText";
			IdText.Size = new Size(163, 27);
			IdText.TabIndex = 4;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.FromArgb(124, 147, 195);
			btnSave.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			btnSave.Location = new Point(139, 223);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(94, 33);
			btnSave.TabIndex = 5;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			// 
			// CategoriesManagement
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(85, 103, 156);
			ClientSize = new Size(393, 276);
			Controls.Add(btnSave);
			Controls.Add(IdText);
			Controls.Add(label3);
			Controls.Add(nameText);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CategoriesManagement";
			Text = "CategoriesManagement";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox nameText;
		private Label label3;
		private TextBox IdText;
		private Button btnSave;
	}
}