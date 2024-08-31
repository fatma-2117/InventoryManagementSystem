namespace InventoryManagementSystem
{
	partial class TransactionManagment
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
			productList = new ComboBox();
			QuantityText = new TextBox();
			NoteText = new RichTextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 40);
			label1.Name = "label1";
			label1.Size = new Size(293, 39);
			label1.TabIndex = 0;
			label1.Text = "Transaction Data";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(53, 140);
			label2.Name = "label2";
			label2.Size = new Size(93, 22);
			label2.TabIndex = 1;
			label2.Text = "Product :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(53, 211);
			label3.Name = "label3";
			label3.Size = new Size(167, 21);
			label3.TabIndex = 2;
			label3.Text = "Product Quantity :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(53, 286);
			label4.Name = "label4";
			label4.Size = new Size(62, 21);
			label4.TabIndex = 3;
			label4.Text = "Note :";
			// 
			// productList
			// 
			productList.FormattingEnabled = true;
			productList.Location = new Point(243, 134);
			productList.Name = "productList";
			productList.Size = new Size(151, 28);
			productList.TabIndex = 4;
			// 
			// QuantityText
			// 
			QuantityText.Location = new Point(243, 205);
			QuantityText.Name = "QuantityText";
			QuantityText.Size = new Size(151, 27);
			QuantityText.TabIndex = 5;
			// 
			// NoteText
			// 
			NoteText.AcceptsTab = true;
			NoteText.BorderStyle = BorderStyle.FixedSingle;
			NoteText.Location = new Point(243, 286);
			NoteText.Name = "NoteText";
			NoteText.Size = new Size(151, 67);
			NoteText.TabIndex = 6;
			NoteText.Text = "";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(124, 147, 195);
			button1.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(159, 390);
			button1.Name = "button1";
			button1.Size = new Size(94, 38);
			button1.TabIndex = 7;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = false;
			button1.Click += btnSave_Click;
			// 
			// TransactionManagment
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(85, 103, 156);
			ClientSize = new Size(462, 450);
			Controls.Add(button1);
			Controls.Add(NoteText);
			Controls.Add(QuantityText);
			Controls.Add(productList);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "TransactionManagment";
			Text = "Transaction Managment";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private ComboBox productList;
		private TextBox QuantityText;
		private RichTextBox NoteText;
		private Button button1;
	}
}