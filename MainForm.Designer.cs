/*
 * 由SharpDevelop创建。
 * 用户： Dengyong
 * 日期: 2018-4-30
 * 时间: 9:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WareHouseAnalysis
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 数据导入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 通用记录导入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 租赁数据导入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 项目信息ToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.数据导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.通用记录导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.租赁数据导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.项目信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.文件ToolStripMenuItem,
			this.工具ToolStripMenuItem,
			this.系统设置ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.数据导入ToolStripMenuItem,
			this.toolStripMenuItem1,
			this.退出ToolStripMenuItem});
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.文件ToolStripMenuItem.Text = "文件";
			// 
			// 数据导入ToolStripMenuItem
			// 
			this.数据导入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.通用记录导入ToolStripMenuItem,
			this.租赁数据导入ToolStripMenuItem});
			this.数据导入ToolStripMenuItem.Name = "数据导入ToolStripMenuItem";
			this.数据导入ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.数据导入ToolStripMenuItem.Text = "数据导入";
			// 
			// 通用记录导入ToolStripMenuItem
			// 
			this.通用记录导入ToolStripMenuItem.Name = "通用记录导入ToolStripMenuItem";
			this.通用记录导入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.通用记录导入ToolStripMenuItem.Text = "通用记录导入";
			// 
			// 租赁数据导入ToolStripMenuItem
			// 
			this.租赁数据导入ToolStripMenuItem.Name = "租赁数据导入ToolStripMenuItem";
			this.租赁数据导入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.租赁数据导入ToolStripMenuItem.Text = "租赁数据导入";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.退出ToolStripMenuItem.Text = "退出";
			// 
			// 工具ToolStripMenuItem
			// 
			this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
			this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.工具ToolStripMenuItem.Text = "工具";
			// 
			// 系统设置ToolStripMenuItem
			// 
			this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.项目信息ToolStripMenuItem});
			this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
			this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.系统设置ToolStripMenuItem.Text = "系统设置";
			// 
			// 项目信息ToolStripMenuItem
			// 
			this.项目信息ToolStripMenuItem.Name = "项目信息ToolStripMenuItem";
			this.项目信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.项目信息ToolStripMenuItem.Text = "项目信息";
			this.项目信息ToolStripMenuItem.Click += new System.EventHandler(this.项目信息ToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "材料使用分析系统";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
