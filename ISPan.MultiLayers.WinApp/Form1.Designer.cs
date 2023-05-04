namespace ISPan.MultiLayers.WinApp
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonList = new System.Windows.Forms.Button();
			this.textBoxCategoryId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(48, 44);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "AddNew";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(48, 89);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 23);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			// 
			// buttonList
			// 
			this.buttonList.Location = new System.Drawing.Point(48, 142);
			this.buttonList.Name = "buttonList";
			this.buttonList.Size = new System.Drawing.Size(75, 23);
			this.buttonList.TabIndex = 2;
			this.buttonList.Text = "Categories";
			this.buttonList.UseVisualStyleBackColor = true;
			// 
			// textBoxCategoryId
			// 
			this.textBoxCategoryId.Location = new System.Drawing.Point(163, 89);
			this.textBoxCategoryId.Name = "textBoxCategoryId";
			this.textBoxCategoryId.Size = new System.Drawing.Size(100, 22);
			this.textBoxCategoryId.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxCategoryId);
			this.Controls.Add(this.buttonList);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonList;
		private System.Windows.Forms.TextBox textBoxCategoryId;
	}
}

