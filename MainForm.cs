/*
 * 由SharpDevelop创建。
 * 用户： Dengyong
 * 日期: 2018-4-30
 * 时间: 9:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace WareHouseAnalysis
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void 项目信息ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//打开新页面
			

			FormProjectInfo tNewForm=new FormProjectInfo();
						
			if (HaveOpened(this, tNewForm.Name))
			{
				Debug.WriteLine("打开窗口："+tNewForm.Text);
				
				tNewForm.MdiParent = this;
				tNewForm.Show();
			}
		}
		
		private bool HaveOpened(Form fParent, string fChildName)
        {
            //查看窗口是否已经被打开
            bool bReturn = true;
            for (int i = 0; i < fParent.MdiChildren.Length; i++)
            {
                if (fParent.MdiChildren[i].Name == fChildName)
                {
                    fParent.MdiChildren[i].BringToFront();
                    bReturn = false;
                    break;
                }
            }
            return bReturn;
        }
	}
}
