namespace ISPan.MultiLayers.WinApp
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
			this.components = new System.ComponentModel.Container();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDO = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUPDATE = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnDELETE = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "Display Order";
			// 
			// textBoxDO
			// 
			this.textBoxDO.Location = new System.Drawing.Point(113, 79);
			this.textBoxDO.Name = "textBoxDO";
			this.textBoxDO.Size = new System.Drawing.Size(100, 22);
			this.textBoxDO.TabIndex = 6;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(101, 26);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 22);
			this.textBoxName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name";
			// 
			// btnUPDATE
			// 
			this.btnUPDATE.Location = new System.Drawing.Point(39, 132);
			this.btnUPDATE.Name = "btnUPDATE";
			this.btnUPDATE.Size = new System.Drawing.Size(75, 23);
			this.btnUPDATE.TabIndex = 8;
			this.btnUPDATE.Text = "UPDATE";
			this.btnUPDATE.UseVisualStyleBackColor = true;
			this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnDELETE
			// 
			this.btnDELETE.Location = new System.Drawing.Point(153, 132);
			this.btnDELETE.Name = "btnDELETE";
			this.btnDELETE.Size = new System.Drawing.Size(83, 23);
			this.btnDELETE.TabIndex = 9;
			this.btnDELETE.Text = "DELETE";
			this.btnDELETE.UseVisualStyleBackColor = true;
			this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
			// 
			// FormEditCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDELETE);
			this.Controls.Add(this.btnUPDATE);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxDO);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Name = "FormEditCategory";
			this.Text = "FormEditCategory";
			this.Load += new System.EventHandler(this.FormEditCategory_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxDO;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUPDATE;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnDELETE;
	}
}