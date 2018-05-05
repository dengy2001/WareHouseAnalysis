/*
 * 由SharpDevelop创建。
 * 用户： Dengyong
 * 日期: 2018-4-30
 * 时间: 11:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using WareHouseAnalysis.Domain;
using NHibernate;
using WareHouseAnalysis.DAL;
using System.Diagnostics;
using System.Data;

namespace WareHouseAnalysis.BLL
{
	/// <summary>
	/// Description of CProjectInfoBLL.
	/// </summary>
	public class CProjectInfoBLL
	{
		public CProjectInfoBLL()
		{
		}
		
		//添加项目信息
		public static void AddProjectInfo(CProjectInfo t_add)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			ITransaction tx = session.BeginTransaction();
			try
			{
				session.Save(t_add);
				tx.Commit();
				session.Close();				
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
			}
		}
		
		//修改
		public static void UpdateProjectInfo(CProjectInfo t_modify)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{				
				ITransaction tx = session.BeginTransaction();
				CProjectInfo tResult = session.Get<CProjectInfo>(t_modify.ProjectID);
				tResult.ProjectName = t_modify.ProjectName;
				tResult.BuildArea = t_modify.BuildArea;
				tResult.Contractor = t_modify.Contractor;
				tResult.ProjectDays = t_modify.ProjectDays;
				tResult.Memo = t_modify.Memo;
				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		
		//删除
		public static void DelProjectInfo(int  iProjectID)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			CProjectInfo toDelete = session.Get<CProjectInfo>(iProjectID);			
				
			try
			{
				session.Delete(toDelete);
				tx.Commit();
				session.Close();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
			}
		}
		
		//查询全部ProjectInfo,用SQL直接获取
		public static DataSet GetProjectInfos()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT ProjectID,ProjectName,BuildArea,Contractor,ProjectDays,Memo FROM ProjectInfo");
			return ds;				
		}
		
		//查询最大的ProjectID
		public static int GetMaxProjectID()
		{
			int i_rtn = 0;
			object tO = SQLiteHelper.ExecuteScalar("SELECT max(ProjectID) FROM ProjectInfo");
			if(tO != DBNull.Value)
			{
				i_rtn = Convert.ToInt32(tO);
			}			
			return i_rtn;
		}
		
		//获取指定ProjectID的对象
		public static CProjectInfo GetProjectInfo(int i_ProjectID)
		{
			ISession session = NHibernateHelper.OpenSession();
			CProjectInfo tClass = new CProjectInfo();
			try
			{
				tClass = session.Get<CProjectInfo>(i_ProjectID);
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
			return tClass;
		}
		
		
	}
}
