/*
 * 由SharpDevelop创建。
 * 用户： Dengyong
 * 日期: 2018-4-30
 * 时间: 12:36
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using WareHouseAnalysis.BLL;
using WareHouseAnalysis.DAL;
using WareHouseAnalysis.Domain;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;

namespace WareHouseAnalysis
{
	/// <summary>
	/// Description of FormProjectInfo.
	/// </summary>
	public partial class FormProjectInfo : Form
	{
		private List<ListItem> list = new List<ListItem>();	//项目列表
		
		public FormProjectInfo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

		}
		void FormProjectInfoLoad(object sender, EventArgs e)
		{
			//界面打开
			//1、填充List并根据缺省选项显示详细信息
			listBox1.MultiColumn = true;			
			FillListBox1();
			
			listBox1.DisplayMember = "Text";
			listBox1.ValueMember = "Value";
			listBox1.DataSource = list;
			//2、
	
		}
		
		//填充ListBox
		void FillListBox1()
		{
			
			
			DataSet tds = new DataSet();
			tds = CProjectInfoBLL.GetProjectInfos();
//			listBox1.DataSource = tds.Tables[0];
//			listBox1.DisplayMember = "ProjectName";
			
			foreach(DataRow dr in tds.Tables[0].Rows)
  			{  
				Debug.WriteLine(dr[1].ToString());
				//string ts = dr[0].ToString() + "," + dr[1].ToString();
				list.Add(new ListItem(dr[1].ToString(),dr[0].ToString()));			
  			}
			
			

		}
		
		//自绘，原来行距太小了
		void ListBox1DrawItem(object sender, DrawItemEventArgs e)
		{
			Rectangle re = new Rectangle();
			re.X = e.Bounds.X;
			re.Y = e.Bounds.Y;
			re.Width = listBox1.Width;
			re.Height = e.Bounds.Height;
			e.Graphics.FillRectangle(new SolidBrush(e.BackColor), re);  
			if (e.Index >= 0) {  
				StringFormat sStringFormat = new StringFormat();  
				sStringFormat.LineAlignment = StringAlignment.Center;  
				e.Graphics.DrawString(((ListItem)((ListBox)sender).Items[e.Index]).Text, e.Font, new SolidBrush(e.ForeColor), re, sStringFormat);
			}  
			e.DrawFocusRectangle(); 
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			Debug.WriteLine("当前选择：" + ((ListItem)((ListBox)sender).SelectedItem).Value);
			CProjectInfo tp = CProjectInfoBLL.GetProjectInfo(Convert.ToInt32(((ListItem)((ListBox)sender).SelectedItem).Value));
			
			textBoxProjectID.Text = tp.ProjectID.ToString();
			textBoxProjectName.Text = tp.ProjectName;
			textBoxBuildArea.Text = tp.BuildArea.ToString();
			textBoxContractor.Text = tp.Contractor;
			textBoxMomo.Text = tp.Memo;
		}
		
		//添加新项目
		void ButtonAddClick(object sender, EventArgs e)
		{
			int i_LastProjectID;
			i_LastProjectID = CProjectInfoBLL.GetMaxProjectID();
			Debug.WriteLine("最大ProjectID=" + i_LastProjectID.ToString());
		}

		//内部类，列表项
		private class ListItem
		{
			private string _Text;
	        public string Text
	        {
	            get { return _Text; }
	            set { _Text = value; }
	        }

	        private string _Value;
	        public string Value
	        {
	            get { return _Value; }
	            set { _Value = value; }
	        }
	
	        public ListItem(string text, string value)
	        {
	            _Text = text;
	            _Value = value;
	        }
		}
		
	}
}
