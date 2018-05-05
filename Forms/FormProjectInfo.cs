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
using System.Text.RegularExpressions;

namespace WareHouseAnalysis
{
	/// <summary>
	/// Description of FormProjectInfo.
	/// </summary>
	public partial class FormProjectInfo : Form
	{
		
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
			FillListBox1();
			
			
			//2、
	
		}
		
		//填充ListBox
		void FillListBox1()
		{	
			listBox1.Items.Clear();
			DataSet tds = new DataSet();
			tds = CProjectInfoBLL.GetProjectInfos();
//			listBox1.DataSource = tds.Tables[0];
//			listBox1.DisplayMember = "ProjectName";
			
			foreach (DataRow dr in tds.Tables[0].Rows) {  
				Debug.WriteLine(dr[1].ToString());
				//string ts = dr[0].ToString() + "," + dr[1].ToString();
				ListItem tlt = new ListItem(dr[1].ToString(), dr[0].ToString());
				listBox1.Items.Add(tlt);
			}
			




			//要求listBox重绘

		}
		
		//自绘，原来行距太小了
		void ListBox1DrawItem(object sender, DrawItemEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);  
			if (e.Index >= 0) {  
				StringFormat sStringFormat = new StringFormat();  
				sStringFormat.LineAlignment = StringAlignment.Center; 
				string tText = ((ListItem)((ListBox)sender).Items[e.Index]).Text;
				Debug.WriteLine("重绘：" + tText);
				e.Graphics.DrawString(tText, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
			}  
			e.DrawFocusRectangle(); 
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (((ListBox)sender).SelectedItem == null) {
				return;
			}
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
			//检测输入合理性
			if (CheckFillOK()) {
				CProjectInfo tp = new CProjectInfo();
				tp.ProjectID = i_LastProjectID + 1;
				tp.ProjectName = textBoxProjectName.Text.Trim();
				if (textBoxBuildArea.Text != "") {
					tp.BuildArea = Convert.ToInt32(textBoxBuildArea.Text);
				} else {
					tp.BuildArea = 0;
				}
				tp.Contractor = textBoxContractor.Text.Trim();
				if (textBoxProjectDays.Text != "") {
					tp.ProjectDays = Convert.ToInt32(textBoxProjectDays.Text);
				} else {
					tp.ProjectDays = 0;
				}
				tp.Memo = textBoxMomo.Text.Trim();
				
				//添加到数据库中
				CProjectInfoBLL.AddProjectInfo(tp);
				//刷新listbox
				FillListBox1();
				listBox1.Refresh();
//				listBox1.Invalidate();
//				listBox1.Update();
			}
		}
		
		//检查填写内容是否合理
		bool CheckFillOK()
		{
			Regex reg;
			string tStr;
			string pattern;

			//文本测试
			if (textBoxProjectName.Text.Trim() == "") {
				MessageBox.Show("项目名称必修填写！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			//int测试
			tStr = textBoxBuildArea.Text.Trim();
			pattern = @"^[0-9]+([0-9]+)?$|^[0-9]*$";
			reg = new Regex(pattern);
			if (!reg.IsMatch(tStr)) {
				MessageBox.Show("建筑面积输入错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			//int测试
			tStr = textBoxProjectDays.Text.Trim();
			pattern = @"^[0-9]+([0-9]+)?$|^[0-9]*$";
			reg = new Regex(pattern);
			if (!reg.IsMatch(tStr)) {
				MessageBox.Show("工程总工期输入错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			return true;
		}
		
		//删除
		void ButtonDelClick(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null) {
				return;
			}
			DialogResult result;
			int iProjectID = Convert.ToInt32(((ListItem)listBox1.SelectedItem).Value);
			string sProjectName = ((ListItem)listBox1.SelectedItem).Text;
               
			result = MessageBox.Show("您确认删除当前选中的【" + sProjectName + "】项目吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == System.Windows.Forms.DialogResult.Yes) {
				CProjectInfoBLL.DelProjectInfo(iProjectID);
			}
			//刷新listbox
			FillListBox1();
			
		}
		
		//修改
		void ButtonModifyClick(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null) {
				return;
			}
			if (CheckFillOK()) {
				CProjectInfo tp = new CProjectInfo();
				tp.ProjectID = Convert.ToInt32(((ListItem)listBox1.SelectedItem).Value);
				tp.ProjectName = textBoxProjectName.Text;
				if (textBoxBuildArea.Text == "") {
					tp.BuildArea = 0;
				} else {
					tp.BuildArea = Convert.ToInt32(textBoxBuildArea.Text);
				}
				tp.Contractor = textBoxContractor.Text;
				if (textBoxProjectDays.Text == "") {
					tp.ProjectDays = 0;
				} else {
					tp.ProjectDays = Convert.ToInt32(textBoxProjectDays.Text);
				}
				tp.Memo = textBoxMomo.Text;
				
				CProjectInfoBLL.UpdateProjectInfo(tp);
				
				//刷新listbox
				FillListBox1();
			}
			
		}

		//内部类，列表项
		private class ListItem
		{
			private string _Text;
			public string Text {
				get { return _Text; }
				set { _Text = value; }
			}

			private string _Value;
			public string Value {
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
