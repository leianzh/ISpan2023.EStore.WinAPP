﻿using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinAPP
{
	public partial class FormEditNews : Form
	{
		private int _newsId;
		public FormEditNews(int newsId)
		{
			InitializeComponent();
			this._newsId = newsId;
		}

		

		private void FormEditNews_Load(object sender, EventArgs e)
		{
			NewsEditDto news = new NewsRepository().Get(this._newsId);
			if (news == null)
			{
				MessageBox.Show("Record not found.");
				this.DialogResult = DialogResult.Cancel; // 會關閉表單
				return;
			}

			// bind data
			txtTitle.Text = news.Title;
			txtDescription.Text = news.Description;
			lblModifiedTime.Text = news.ModifiedTime.ToString("yyyy/MM/dd HH:mm:ss");



		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var news = new NewsEditDto
			{
				Id = this._newsId,
				Title = txtTitle.Text,
				Description = txtDescription.Text,
				ModifiedTime = DateTime.Now,
			};
            
			int rowsAffected = new NewsRepository().Update(news);
			//如果傳回筆數是1,表示有正確更新一筆
			if (rowsAffected > 0) 
			{
				MessageBox.Show("紀錄已更新");
			}
			else 
			{
				MessageBox.Show("紀錄沒有被異動，可能紀錄已經被刪除");
			}
			FormEditNews_Load(this,EventArgs.Empty);
		}
	}
}
