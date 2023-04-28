namespace ISpan2023.EStore.WinAPP
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.labelConnStr = new System.Windows.Forms.Label();
			this.checkBoxpooling = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.btnUsing = new System.Windows.Forms.Button();
			this.buttonCategory = new System.Windows.Forms.Button();
			this.textBoxCategory = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(34, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "取得連線字串";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelConnStr
			// 
			this.labelConnStr.AutoSize = true;
			this.labelConnStr.Location = new System.Drawing.Point(32, 60);
			this.labelConnStr.Name = "labelConnStr";
			this.labelConnStr.Size = new System.Drawing.Size(66, 12);
			this.labelConnStr.TabIndex = 1;
			this.labelConnStr.Text = "labelConnStr";
			// 
			// checkBoxpooling
			// 
			this.checkBoxpooling.AutoSize = true;
			this.checkBoxpooling.Location = new System.Drawing.Point(127, 109);
			this.checkBoxpooling.Name = "checkBoxpooling";
			this.checkBoxpooling.Size = new System.Drawing.Size(60, 16);
			this.checkBoxpooling.TabIndex = 2;
			this.checkBoxpooling.Text = "pooling";
			this.checkBoxpooling.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(34, 105);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "連線到Db";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnUsing
			// 
			this.btnUsing.Location = new System.Drawing.Point(34, 149);
			this.btnUsing.Name = "btnUsing";
			this.btnUsing.Size = new System.Drawing.Size(75, 23);
			this.btnUsing.TabIndex = 4;
			this.btnUsing.Text = "Using";
			this.btnUsing.UseVisualStyleBackColor = true;
			this.btnUsing.Click += new System.EventHandler(this.btnUsing_Click);
			// 
			// buttonCategory
			// 
			this.buttonCategory.Location = new System.Drawing.Point(34, 189);
			this.buttonCategory.Name = "buttonCategory";
			this.buttonCategory.Size = new System.Drawing.Size(126, 23);
			this.buttonCategory.TabIndex = 5;
			this.buttonCategory.Text = "讀取一筆Category";
			this.buttonCategory.UseVisualStyleBackColor = true;
			this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
			// 
			// textBoxCategory
			// 
			this.textBoxCategory.Location = new System.Drawing.Point(211, 190);
			this.textBoxCategory.Name = "textBoxCategory";
			this.textBoxCategory.Size = new System.Drawing.Size(100, 22);
			this.textBoxCategory.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "Id:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxCategory);
			this.Controls.Add(this.buttonCategory);
			this.Controls.Add(this.btnUsing);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.checkBoxpooling);
			this.Controls.Add(this.labelConnStr);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelConnStr;
		private System.Windows.Forms.CheckBox checkBoxpooling;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnUsing;
		private System.Windows.Forms.Button buttonCategory;
		private System.Windows.Forms.TextBox textBoxCategory;
		private System.Windows.Forms.Label label1;
	}
}

