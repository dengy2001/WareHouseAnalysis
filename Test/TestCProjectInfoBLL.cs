/*
 * 由SharpDevelop创建。
 * 用户： Dengyong
 * 日期: 2018-5-1
 * 时间: 15:59
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using NUnit.Framework;
using WareHouseAnalysis.Domain;
using WareHouseAnalysis.BLL;

namespace WareHouseAnalysis.Test
{
	[TestFixture]
	public class TestCProjectInfoBLL
	{
		
		[Test]
		public void TestProjectAdd1()
		{
			// TODO: Add your test.
			CProjectInfo tp = new CProjectInfo();
			tp.ProjectName = "测试添加，不包含projectID";
			CProjectInfoBLL.AddProjectInfo(tp);
		}
		[Test]
		public void TestProjectAdd2()
		{
			// TODO: Add your test.
			CProjectInfo tp = new CProjectInfo();
			tp.ProjectID = 1;
			tp.ProjectName = "测试添加，包含指定的projectID";
			CProjectInfoBLL.AddProjectInfo(tp);
		}
	}
}
