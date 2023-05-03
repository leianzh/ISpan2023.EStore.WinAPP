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
			this.btnSearchProducts = new System.Windows.Forms.Button();
			this.btnAddNews = new System.Windows.Forms.Button();
			this.btnEditNews = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNewsId = new System.Windows.Forms.TextBox();
			this.btnDeleteNews = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddCategories = new System.Windows.Forms.Button();
			this.btnUpdateCategory = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnDeletCategories = new System.Windows.Forms.Button();
			this.btnSearchCategory = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(34, 24);
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
			this.buttonCategory.Location = new System.Drawing.Point(20, 31);
			this.buttonCategory.Name = "buttonCategory";
			this.buttonCategory.Size = new System.Drawing.Size(126, 23);
			this.buttonCategory.TabIndex = 5;
			this.buttonCategory.Text = "讀取一筆Category";
			this.buttonCategory.UseVisualStyleBackColor = true;
			this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
			// 
			// textBoxCategory
			// 
			this.textBoxCategory.Location = new System.Drawing.Point(245, 75);
			this.textBoxCategory.Name = "textBoxCategory";
			this.textBoxCategory.Size = new System.Drawing.Size(100, 22);
			this.textBoxCategory.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(172, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "CategoriesId:";
			// 
			// btnSearchProducts
			// 
			this.btnSearchProducts.Location = new System.Drawing.Point(34, 210);
			this.btnSearchProducts.Name = "btnSearchProducts";
			this.btnSearchProducts.Size = new System.Drawing.Size(107, 23);
			this.btnSearchProducts.TabIndex = 8;
			this.btnSearchProducts.Text = "取得所有商品";
			this.btnSearchProducts.UseVisualStyleBackColor = true;
			this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
			// 
			// btnAddNews
			// 
			this.btnAddNews.Location = new System.Drawing.Point(16, 21);
			this.btnAddNews.Name = "btnAddNews";
			this.btnAddNews.Size = new System.Drawing.Size(75, 23);
			this.btnAddNews.TabIndex = 9;
			this.btnAddNews.Text = "新增News";
			this.btnAddNews.UseVisualStyleBackColor = true;
			this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
			// 
			// btnEditNews
			// 
			this.btnEditNews.Location = new System.Drawing.Point(16, 61);
			this.btnEditNews.Name = "btnEditNews";
			this.btnEditNews.Size = new System.Drawing.Size(75, 23);
			this.btnEditNews.TabIndex = 10;
			this.btnEditNews.Text = "Edit News";
			this.btnEditNews.UseVisualStyleBackColor = true;
			this.btnEditNews.Click += new System.EventHandler(this.btnEditNews_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(106, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "NewsId";
			// 
			// txtNewsId
			// 
			this.txtNewsId.Location = new System.Drawing.Point(152, 61);
			this.txtNewsId.Name = "txtNewsId";
			this.txtNewsId.Size = new System.Drawing.Size(100, 22);
			this.txtNewsId.TabIndex = 12;
			// 
			// btnDeleteNews
			// 
			this.btnDeleteNews.Location = new System.Drawing.Point(16, 103);
			this.btnDeleteNews.Name = "btnDeleteNews";
			this.btnDeleteNews.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteNews.TabIndex = 13;
			this.btnDeleteNews.Text = "Delete News";
			this.btnDeleteNews.UseVisualStyleBackColor = true;
			this.btnDeleteNews.Click += new System.EventHandler(this.btnDeleteNews_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddNews);
			this.groupBox1.Controls.Add(this.btnDeleteNews);
			this.groupBox1.Controls.Add(this.btnEditNews);
			this.groupBox1.Controls.Add(this.txtNewsId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(34, 269);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(353, 155);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "維護News";
			// 
			// btnAddCategories
			// 
			this.btnAddCategories.Location = new System.Drawing.Point(20, 66);
			this.btnAddCategories.Name = "btnAddCategories";
			this.btnAddCategories.Size = new System.Drawing.Size(106, 23);
			this.btnAddCategories.TabIndex = 15;
			this.btnAddCategories.Text = "新增Categories";
			this.btnAddCategories.UseVisualStyleBackColor = true;
			this.btnAddCategories.Click += new System.EventHandler(this.btnAddCategories_Click);
			// 
			// btnUpdateCategory
			// 
			this.btnUpdateCategory.Location = new System.Drawing.Point(20, 95);
			this.btnUpdateCategory.Name = "btnUpdateCategory";
			this.btnUpdateCategory.Size = new System.Drawing.Size(107, 23);
			this.btnUpdateCategory.TabIndex = 16;
			this.btnUpdateCategory.Text = "更新Categories";
			this.btnUpdateCategory.UseVisualStyleBackColor = true;
			this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnSearchCategory);
			this.groupBox2.Controls.Add(this.btnDeletCategories);
			this.groupBox2.Controls.Add(this.buttonCategory);
			this.groupBox2.Controls.Add(this.btnUpdateCategory);
			this.groupBox2.Controls.Add(this.btnAddCategories);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.textBoxCategory);
			this.groupBox2.Location = new System.Drawing.Point(413, 255);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(384, 169);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "維護Category";
			// 
			// btnDeletCategories
			// 
			this.btnDeletCategories.Location = new System.Drawing.Point(20, 124);
			this.btnDeletCategories.Name = "btnDeletCategories";
			this.btnDeletCategories.Size = new System.Drawing.Size(106, 23);
			this.btnDeletCategories.TabIndex = 17;
			this.btnDeletCategories.Text = "刪除Categories";
			this.btnDeletCategories.UseVisualStyleBackColor = true;
			this.btnDeletCategories.Click += new System.EventHandler(this.btnDeletCategories_Click);
			// 
			// btnSearchCategory
			// 
			this.btnSearchCategory.Location = new System.Drawing.Point(164, 31);
			this.btnSearchCategory.Name = "btnSearchCategory";
			this.btnSearchCategory.Size = new System.Drawing.Size(130, 23);
			this.btnSearchCategory.TabIndex = 18;
			this.btnSearchCategory.Text = "取得所有Categories";
			this.btnSearchCategory.UseVisualStyleBackColor = true;
			this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSearchProducts);
			this.Controls.Add(this.btnUsing);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.checkBoxpooling);
			this.Controls.Add(this.labelConnStr);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
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
		private System.Windows.Forms.Button btnSearchProducts;
		private System.Windows.Forms.Button btnAddNews;
		private System.Windows.Forms.Button btnEditNews;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNewsId;
		private System.Windows.Forms.Button btnDeleteNews;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddCategories;
		private System.Windows.Forms.Button btnUpdateCategory;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnDeletCategories;
		private System.Windows.Forms.Button btnSearchCategory;
	}
}

