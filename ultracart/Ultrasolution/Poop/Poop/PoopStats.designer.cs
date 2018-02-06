﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POOP
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="pooptesst")]
	public partial class PoopStatsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public PoopStatsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["pooptesstConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PoopStatsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PoopStatsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PoopStatsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PoopStatsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetOrgName")]
		public ISingleResult<GetOrgNameResult> GetOrgName([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ORGID", DbType="NChar(10)")] string oRGID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), oRGID);
			return ((ISingleResult<GetOrgNameResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetGiftTotal")]
		public ISingleResult<GetGiftTotalResult> GetGiftTotal([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ORGID", DbType="NChar(10)")] string oRGID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), oRGID);
			return ((ISingleResult<GetGiftTotalResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetOrgNameResult
	{
		
		private string _ORGname;
		
		public GetOrgNameResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ORGname", DbType="NChar(300)")]
		public string ORGname
		{
			get
			{
				return this._ORGname;
			}
			set
			{
				if ((this._ORGname != value))
				{
					this._ORGname = value;
				}
			}
		}
	}
	
	public partial class GetGiftTotalResult
	{
		
		private decimal _total;
		
		public GetGiftTotalResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total", DbType="Money NOT NULL")]
		public decimal total
		{
			get
			{
				return this._total;
			}
			set
			{
				if ((this._total != value))
				{
					this._total = value;
				}
			}
		}
	}
}
#pragma warning restore 1591