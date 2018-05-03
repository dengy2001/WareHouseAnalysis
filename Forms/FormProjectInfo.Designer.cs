/*
 * 由SharpDevelop创建。
 * 用户： Dengyong
 * 日期: 2018-4-30
 * 时间: 12:36
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WareHouseAnalysis
{
	partial class FormProjectInfo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxMomo;
		private System.Windows.Forms.TextBox textBoxProjectDays;
		private System.Windows.Forms.TextBox textBoxContractor;
		private System.Windows.Forms.TextBox textBoxBuildArea;
		private System.Windows.Forms.TextBox textBoxProjectName;
		private System.Windows.Forms.TextBox textBoxProjectID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonModify;
		private System.Windows.Forms.Button buttonAdd;
		
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxMomo = new System.Windows.Forms.TextBox();
			this.textBoxProjectDays = new System.Windows.Forms.TextBox();
			this.textBoxContractor = new System.Windows.Forms.TextBox();
			this.textBoxBuildArea = new System.Windows.Forms.TextBox();
			this.textBoxProjectName = new System.Windows.Forms.TextBox();
			this.textBoxProjectID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonModify = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.ItemHeight = 30;
			this.listBox1.Location = new System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(183, 292);
			this.listBox1.TabIndex = 0;
			this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox1DrawItem);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxMomo);
			this.groupBox1.Controls.Add(this.textBoxProjectDays);
			this.groupBox1.Controls.Add(this.textBoxContractor);
			this.groupBox1.Controls.Add(this.textBoxBuildArea);
			this.groupBox1.Controls.Add(this.textBoxProjectName);
			this.groupBox1.Controls.Add(this.textBoxProjectID);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(231, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(370, 258);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// textBoxMomo
			// 
			this.textBoxMomo.Location = new System.Drawing.Point(95, 143);
			this.textBoxMomo.Multiline = true;
			this.textBoxMomo.Name = "textBoxMomo";
			this.textBoxMomo.Size = new System.Drawing.Size(269, 109);
			this.textBoxMomo.TabIndex = 1;
			// 
			// textBoxProjectDays
			// 
			this.textBoxProjectDays.Location = new System.Drawing.Point(95, 118);
			this.textBoxProjectDays.Name = "textBoxProjectDays";
			this.textBoxProjectDays.Size = new System.Drawing.Size(269, 21);
			this.textBoxProjectDays.TabIndex = 1;
			// 
			// textBoxContractor
			// 
			this.textBoxContractor.Location = new System.Drawing.Point(95, 93);
			this.textBoxContractor.Name = "textBoxContractor";
			this.textBoxContractor.Size = new System.Drawing.Size(269, 21);
			this.textBoxContractor.TabIndex = 1;
			// 
			// textBoxBuildArea
			// 
			this.textBoxBuildArea.Location = new System.Drawing.Point(95, 68);
			this.textBoxBuildArea.Name = "textBoxBuildArea";
			this.textBoxBuildArea.Size = new System.Drawing.Size(269, 21);
			this.textBoxBuildArea.TabIndex = 1;
			// 
			// textBoxProjectName
			// 
			this.textBoxProjectName.Location = new System.Drawing.Point(95, 43);
			this.textBoxProjectName.Name = "textBoxProjectName";
			this.textBoxProjectName.Size = new System.Drawing.Size(269, 21);
			this.textBoxProjectName.TabIndex = 1;
			// 
			// textBoxProjectID
			// 
			this.textBoxProjectID.Location = new System.Drawing.Point(95, 18);
			this.textBoxProjectID.Name = "textBoxProjectID";
			this.textBoxProjectID.ReadOnly = true;
			this.textBoxProjectID.Size = new System.Drawing.Size(269, 21);
			this.textBoxProjectID.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "补充信息：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "建设总工期：";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "承建商：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "建筑面积：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "项目名称(*)：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "项目ID(*)：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonDel
			// 
			this.buttonDel.Location = new System.Drawing.Point(526, 281);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(75, 23);
			this.buttonDel.TabIndex = 2;
			this.buttonDel.Text = "删除";
			this.buttonDel.UseVisualStyleBackColor = true;
			// 
			// buttonModify
			// 
			this.buttonModify.Location = new System.Drawing.Point(445, 281);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(75, 23);
			this.buttonModify.TabIndex = 2;
			this.buttonModify.Text = "修改";
			this.buttonModify.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(364, 281);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// FormProjectInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 315);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonModify);
			this.Controls.Add(this.buttonDel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listBox1);
			this.Name = "FormProjectInfo";
			this.Text = "工程项目设置";
			this.Load += new System.EventHandler(this.FormProjectInfoLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
