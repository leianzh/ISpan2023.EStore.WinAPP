﻿namespace ISpan2023.EStore.WinAPP
{
	partial class FormEditCategory
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxDO = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(94, 44);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 22);
			this.textBoxName.TabIndex = 1;
			// 
			// textBoxDO
			// 
			this.textBoxDO.Location = new System.Drawing.Point(106, 97);
			this.textBoxDO.Name = "textBoxDO";
			this.textBoxDO.Size = new System.Drawing.Size(100, 22);
			this.textBoxDO.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Display Order";
			// 
			// FormEditCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxDO);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Name = "FormEditCategory";
			this.Text = "FormEditCategory";
			this.Load += new System.EventHandler(this.FormEditCategory_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxDO;
		private System.Windows.Forms.Label label2;
	}
}