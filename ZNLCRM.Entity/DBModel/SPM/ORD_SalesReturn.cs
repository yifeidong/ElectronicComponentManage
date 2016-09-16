//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2015/3/4
//     Time:    14:58
//     Version: 4.0.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

/// <summary>
/// CodeSmith自动生成的实体
/// </summary>
namespace ZNLCRM.Entity.DBModel
{	
	using System;
	using MySoft.Data;
	using ZNLCRM.Utility;
    using ZNLFrame.Entity;
    /// <summary>
    /// 表名：ORD_SalesReturn 主键列：SRGuid
    /// </summary>
    [SerializableAttribute()]
	public partial class ORD_SalesReturn : BaseEntity
	{
		#region Private Properties
		
		private Int32? _SRID;
		private Guid? _SRGuid;
		private String _BillNo;
		private Guid? _GCompanyID;
		private Guid? _SOGuid;
		private String _SOBillNo;
		private Int32? _CustomerID;
		private String _CustomerName;
		private DateTime? _ReturnDate;
		private Int32? _OperOrgID;
		private Int32? _OperDeptID;
		private Int32? _OperEmpID;
		private String _OperEmpName;
		private String _Currency;
		private Decimal? _Amount;
		private String _FreightClearForm;
		private String _TransportCompany;
		private String _ShippingNo;
		private Decimal? _Freight;
		private String _Explain;
		private String _Remark;
		private String _StkInOccStatus;
		private String _StkInStatus;
		private String _ApproveStatus;
		private String _Status;
		private Int32? _CreatedEmpID;
		private String _CreatedEmpName;
		private DateTime? _CreatedTime;
		private Int32? _UpdatedEmpID;
		private String _UpdatedEmpName;
		private DateTime? _UpdatedTime;
		private Boolean? _IsDeleted;
		
		#endregion
		
		#region Public Properties
		
		/// <summary>
		/// 退货guid.
		/// </summary>
		public Guid? SRGuid
		{
			get 
			{
				return _SRGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SRGuid, _SRGuid , value);
				this._SRGuid = value;
			}
		}
		
		/// <summary>
		/// .
		/// </summary>
		public Int32? SRID
		{
			get 
			{
				return this._SRID;
			}
			set 
			{
				this.OnPropertyValueChange(_.SRID, _SRID , value);
				this._SRID = value;
			}
		}

		/// <summary>
		/// 退货单号.
		/// </summary>
		public String BillNo
		{
			get 
			{
				return this._BillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.BillNo, _BillNo , value);
				this._BillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Guid? GCompanyID
		{
			get 
			{
				return this._GCompanyID;
			}
			set 
			{
				this.OnPropertyValueChange(_.GCompanyID, _GCompanyID , value);
				this._GCompanyID = value;
			}
		}

		/// <summary>
		/// 销售单guid.
		/// </summary>
		public Guid? SOGuid
		{
			get 
			{
				return this._SOGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOGuid, _SOGuid , value);
				this._SOGuid = value;
			}
		}

		/// <summary>
		/// 销售单号.
		/// </summary>
		public String SOBillNo
		{
			get 
			{
				return this._SOBillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOBillNo, _SOBillNo , value);
				this._SOBillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 客户ID.
		/// </summary>
		public Int32? CustomerID
		{
			get 
			{
				return this._CustomerID;
			}
			set 
			{
				this.OnPropertyValueChange(_.CustomerID, _CustomerID , value);
				this._CustomerID = value;
			}
		}

		/// <summary>
		/// 客户名称.
		/// </summary>
		public String CustomerName
		{
			get 
			{
				return this._CustomerName;
			}
			set 
			{
				this.OnPropertyValueChange(_.CustomerName, _CustomerName , value);
				this._CustomerName = value.SubStr(100);
			}
		}

		/// <summary>
		/// 退货日期.
		/// </summary>
		public DateTime? ReturnDate
		{
			get 
			{
				return this._ReturnDate;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReturnDate, _ReturnDate , value);
				this._ReturnDate = value;
			}
		}

		/// <summary>
		/// 归属机构ID.
		/// </summary>
		public Int32? OperOrgID
		{
			get 
			{
				return this._OperOrgID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperOrgID, _OperOrgID , value);
				this._OperOrgID = value;
			}
		}

		/// <summary>
		/// 归属部门ID.
		/// </summary>
		public Int32? OperDeptID
		{
			get 
			{
				return this._OperDeptID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperDeptID, _OperDeptID , value);
				this._OperDeptID = value;
			}
		}

		/// <summary>
		/// 归属人ID.
		/// </summary>
		public Int32? OperEmpID
		{
			get 
			{
				return this._OperEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperEmpID, _OperEmpID , value);
				this._OperEmpID = value;
			}
		}

		/// <summary>
		/// 归属人员.
		/// </summary>
		public String OperEmpName
		{
			get 
			{
				return this._OperEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperEmpName, _OperEmpName , value);
				this._OperEmpName = value.SubStr(50);
			}
		}

		/// <summary>
		/// 币种.
		/// </summary>
		public String Currency
		{
			get 
			{
				return this._Currency;
			}
			set 
			{
				this.OnPropertyValueChange(_.Currency, _Currency , value);
				this._Currency = value.SubStr(10);
			}
		}

		/// <summary>
		/// 金额.
		/// </summary>
		public Decimal? Amount
		{
			get 
			{
				return this._Amount;
			}
			set 
			{
				this.OnPropertyValueChange(_.Amount, _Amount , value);
				this._Amount = value;
			}
		}

		/// <summary>
		/// 运费结算方式.
		/// </summary>
		public String FreightClearForm
		{
			get 
			{
				return this._FreightClearForm;
			}
			set 
			{
				this.OnPropertyValueChange(_.FreightClearForm, _FreightClearForm , value);
				this._FreightClearForm = value.SubStr(50);
			}
		}

		/// <summary>
		/// 货运公司.
		/// </summary>
		public String TransportCompany
		{
			get 
			{
				return this._TransportCompany;
			}
			set 
			{
				this.OnPropertyValueChange(_.TransportCompany, _TransportCompany , value);
				this._TransportCompany = value.SubStr(50);
			}
		}

		/// <summary>
		/// 货运单号.
		/// </summary>
		public String ShippingNo
		{
			get 
			{
				return this._ShippingNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.ShippingNo, _ShippingNo , value);
				this._ShippingNo = value.SubStr(50);
			}
		}

		/// <summary>
		/// 运费金额.
		/// </summary>
		public Decimal? Freight
		{
			get 
			{
				return this._Freight;
			}
			set 
			{
				this.OnPropertyValueChange(_.Freight, _Freight , value);
				this._Freight = value;
			}
		}

		/// <summary>
		/// 退货原因.
		/// </summary>
		public String Explain
		{
			get 
			{
				return this._Explain;
			}
			set 
			{
				this.OnPropertyValueChange(_.Explain, _Explain , value);
				this._Explain = value.SubStr(100);
			}
		}

		/// <summary>
		/// 备注.
		/// </summary>
		public String Remark
		{
			get 
			{
				return this._Remark;
			}
			set 
			{
				this.OnPropertyValueChange(_.Remark, _Remark , value);
				this._Remark = value.SubStr(100);
			}
		}

		/// <summary>
		/// 入库占有状态.
		/// </summary>
		public String StkInOccStatus
		{
			get 
			{
				return this._StkInOccStatus;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInOccStatus, _StkInOccStatus , value);
				this._StkInOccStatus = value.SubStr(10);
			}
		}

		/// <summary>
		/// 入库状态.
		/// </summary>
		public String StkInStatus
		{
			get 
			{
				return this._StkInStatus;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInStatus, _StkInStatus , value);
				this._StkInStatus = value.SubStr(10);
			}
		}

		/// <summary>
		/// 审核状态.
		/// </summary>
		public String ApproveStatus
		{
			get 
			{
				return this._ApproveStatus;
			}
			set 
			{
				this.OnPropertyValueChange(_.ApproveStatus, _ApproveStatus , value);
				this._ApproveStatus = value.SubStr(20);
			}
		}

		/// <summary>
		/// 单据状态.
		/// </summary>
		public String Status
		{
			get 
			{
				return this._Status;
			}
			set 
			{
				this.OnPropertyValueChange(_.Status, _Status , value);
				this._Status = value.SubStr(10);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Int32? CreatedEmpID
		{
			get 
			{
				return this._CreatedEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedEmpID, _CreatedEmpID , value);
				this._CreatedEmpID = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String CreatedEmpName
		{
			get 
			{
				return this._CreatedEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedEmpName, _CreatedEmpName , value);
				this._CreatedEmpName = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public DateTime? CreatedTime
		{
			get 
			{
				return this._CreatedTime;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedTime, _CreatedTime , value);
				this._CreatedTime = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Int32? UpdatedEmpID
		{
			get 
			{
				return this._UpdatedEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedEmpID, _UpdatedEmpID , value);
				this._UpdatedEmpID = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String UpdatedEmpName
		{
			get 
			{
				return this._UpdatedEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedEmpName, _UpdatedEmpName , value);
				this._UpdatedEmpName = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public DateTime? UpdatedTime
		{
			get 
			{
				return this._UpdatedTime;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedTime, _UpdatedTime , value);
				this._UpdatedTime = value;
			}
		}

		/// <summary>
		/// 删除标记.
		/// </summary>
		public Boolean? IsDeleted
		{
			get 
			{
				return this._IsDeleted;
			}
			set 
			{
				this.OnPropertyValueChange(_.IsDeleted, _IsDeleted , value);
				this._IsDeleted = value;
			}
		}
		
		#endregion
	    /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable() {
            return new Table< ORD_SalesReturn >("ORD_SalesReturn");
        }
		
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField() {
            return _.SRID;
        }  			
		
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields() {
            return new Field[] {
				_.SRGuid
			};
        }
			
	    /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields() {
            return new Field[] {
				_.SRID,		
				_.SRGuid,		
				_.BillNo,		
				_.GCompanyID,		
				_.SOGuid,		
				_.SOBillNo,		
				_.CustomerID,		
				_.CustomerName,		
				_.ReturnDate,		
				_.OperOrgID,		
				_.OperDeptID,		
				_.OperEmpID,		
				_.OperEmpName,		
				_.Currency,		
				_.Amount,		
				_.FreightClearForm,		
				_.TransportCompany,		
				_.ShippingNo,		
				_.Freight,		
				_.Explain,		
				_.Remark,		
				_.StkInOccStatus,		
				_.StkInStatus,		
				_.ApproveStatus,		
				_.Status,		
				_.CreatedEmpID,		
				_.CreatedEmpName,		
				_.CreatedTime,		
				_.UpdatedEmpID,		
				_.UpdatedEmpName,		
				_.UpdatedTime,		
				_.IsDeleted		
			};
		}
		
	    /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues() {
            return new object[] {
				this._SRID,		
				this._SRGuid,		
				this._BillNo,		
				this._GCompanyID,		
				this._SOGuid,		
				this._SOBillNo,		
				this._CustomerID,		
				this._CustomerName,		
				this._ReturnDate,		
				this._OperOrgID,		
				this._OperDeptID,		
				this._OperEmpID,		
				this._OperEmpName,		
				this._Currency,		
				this._Amount,		
				this._FreightClearForm,		
				this._TransportCompany,		
				this._ShippingNo,		
				this._Freight,		
				this._Explain,		
				this._Remark,		
				this._StkInOccStatus,		
				this._StkInStatus,		
				this._ApproveStatus,		
				this._Status,		
				this._CreatedEmpID,		
				this._CreatedEmpName,		
				this._CreatedTime,		
				this._UpdatedEmpID,		
				this._UpdatedEmpName,		
				this._UpdatedTime,		
				this._IsDeleted		
			};
		}
		
	    /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader) {
            if ((false == reader.IsDBNull(_.SRID))) {
                this._SRID = reader.GetInt32(_.SRID);
            }
            if ((false == reader.IsDBNull(_.SRGuid))) {
                this._SRGuid = reader.GetGuid(_.SRGuid);
            }
            if ((false == reader.IsDBNull(_.BillNo))) {
                this._BillNo = reader.GetString(_.BillNo);
            }
            if ((false == reader.IsDBNull(_.GCompanyID))) {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.SOGuid))) {
                this._SOGuid = reader.GetGuid(_.SOGuid);
            }
            if ((false == reader.IsDBNull(_.SOBillNo))) {
                this._SOBillNo = reader.GetString(_.SOBillNo);
            }
            if ((false == reader.IsDBNull(_.CustomerID))) {
                this._CustomerID = reader.GetInt32(_.CustomerID);
            }
            if ((false == reader.IsDBNull(_.CustomerName))) {
                this._CustomerName = reader.GetString(_.CustomerName);
            }
            if ((false == reader.IsDBNull(_.ReturnDate))) {
                this._ReturnDate = reader.GetDateTime(_.ReturnDate);
            }
            if ((false == reader.IsDBNull(_.OperOrgID))) {
                this._OperOrgID = reader.GetInt32(_.OperOrgID);
            }
            if ((false == reader.IsDBNull(_.OperDeptID))) {
                this._OperDeptID = reader.GetInt32(_.OperDeptID);
            }
            if ((false == reader.IsDBNull(_.OperEmpID))) {
                this._OperEmpID = reader.GetInt32(_.OperEmpID);
            }
            if ((false == reader.IsDBNull(_.OperEmpName))) {
                this._OperEmpName = reader.GetString(_.OperEmpName);
            }
            if ((false == reader.IsDBNull(_.Currency))) {
                this._Currency = reader.GetString(_.Currency);
            }
            if ((false == reader.IsDBNull(_.Amount))) {
                this._Amount = reader.GetDecimal(_.Amount);
            }
            if ((false == reader.IsDBNull(_.FreightClearForm))) {
                this._FreightClearForm = reader.GetString(_.FreightClearForm);
            }
            if ((false == reader.IsDBNull(_.TransportCompany))) {
                this._TransportCompany = reader.GetString(_.TransportCompany);
            }
            if ((false == reader.IsDBNull(_.ShippingNo))) {
                this._ShippingNo = reader.GetString(_.ShippingNo);
            }
            if ((false == reader.IsDBNull(_.Freight))) {
                this._Freight = reader.GetDecimal(_.Freight);
            }
            if ((false == reader.IsDBNull(_.Explain))) {
                this._Explain = reader.GetString(_.Explain);
            }
            if ((false == reader.IsDBNull(_.Remark))) {
                this._Remark = reader.GetString(_.Remark);
            }
            if ((false == reader.IsDBNull(_.StkInOccStatus))) {
                this._StkInOccStatus = reader.GetString(_.StkInOccStatus);
            }
            if ((false == reader.IsDBNull(_.StkInStatus))) {
                this._StkInStatus = reader.GetString(_.StkInStatus);
            }
            if ((false == reader.IsDBNull(_.ApproveStatus))) {
                this._ApproveStatus = reader.GetString(_.ApproveStatus);
            }
            if ((false == reader.IsDBNull(_.Status))) {
                this._Status = reader.GetString(_.Status);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpID))) {
                this._CreatedEmpID = reader.GetInt32(_.CreatedEmpID);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpName))) {
                this._CreatedEmpName = reader.GetString(_.CreatedEmpName);
            }
            if ((false == reader.IsDBNull(_.CreatedTime))) {
                this._CreatedTime = reader.GetDateTime(_.CreatedTime);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpID))) {
                this._UpdatedEmpID = reader.GetInt32(_.UpdatedEmpID);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpName))) {
                this._UpdatedEmpName = reader.GetString(_.UpdatedEmpName);
            }
            if ((false == reader.IsDBNull(_.UpdatedTime))) {
                this._UpdatedTime = reader.GetDateTime(_.UpdatedTime);
            }
            if ((false == reader.IsDBNull(_.IsDeleted))) {
                this._IsDeleted = reader.GetBoolean(_.IsDeleted);
            }
		}
		
	    public override int GetHashCode() {
            return base.GetHashCode();
        }
        
        public override bool Equals(object obj) {
            if ((obj == null)) {
                return false;
            }
            if ((false == typeof(ORD_SalesReturn).IsAssignableFrom(obj.GetType()))) {
                return false;
            }
            if ((((object)(this)) == ((object)(obj)))) {
                return true;
            }
            return false;
        }
		
        public class _ {
                
            /// <summary>
            /// 表示选择所有列，与*等同
            /// </summary>
            public static AllField All = new AllField< ORD_SalesReturn >();
			
		    /// <summary>
            ///  - 字段名：SRID - 数据类型：Int32?
            /// </summary>
            public static Field SRID = new Field< ORD_SalesReturn >("SRID");
		    /// <summary>
            /// 退货guid - 字段名：SRGuid - 数据类型：Guid?
            /// </summary>
            public static Field SRGuid = new Field< ORD_SalesReturn >("SRGuid");
		    /// <summary>
            /// 退货单号 - 字段名：BillNo - 数据类型：String
            /// </summary>
            public static Field BillNo = new Field< ORD_SalesReturn >("BillNo");
		    /// <summary>
            ///  - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field< ORD_SalesReturn >("GCompanyID");
		    /// <summary>
            /// 销售单guid - 字段名：SOGuid - 数据类型：Guid?
            /// </summary>
            public static Field SOGuid = new Field< ORD_SalesReturn >("SOGuid");
		    /// <summary>
            /// 销售单号 - 字段名：SOBillNo - 数据类型：String
            /// </summary>
            public static Field SOBillNo = new Field< ORD_SalesReturn >("SOBillNo");
		    /// <summary>
            /// 客户ID - 字段名：CustomerID - 数据类型：Int32?
            /// </summary>
            public static Field CustomerID = new Field< ORD_SalesReturn >("CustomerID");
		    /// <summary>
            /// 客户名称 - 字段名：CustomerName - 数据类型：String
            /// </summary>
            public static Field CustomerName = new Field< ORD_SalesReturn >("CustomerName");
		    /// <summary>
            /// 退货日期 - 字段名：ReturnDate - 数据类型：DateTime?
            /// </summary>
            public static Field ReturnDate = new Field< ORD_SalesReturn >("ReturnDate");
		    /// <summary>
            /// 归属机构ID - 字段名：OperOrgID - 数据类型：Int32?
            /// </summary>
            public static Field OperOrgID = new Field< ORD_SalesReturn >("OperOrgID");
		    /// <summary>
            /// 归属部门ID - 字段名：OperDeptID - 数据类型：Int32?
            /// </summary>
            public static Field OperDeptID = new Field< ORD_SalesReturn >("OperDeptID");
		    /// <summary>
            /// 归属人ID - 字段名：OperEmpID - 数据类型：Int32?
            /// </summary>
            public static Field OperEmpID = new Field< ORD_SalesReturn >("OperEmpID");
		    /// <summary>
            /// 归属人员 - 字段名：OperEmpName - 数据类型：String
            /// </summary>
            public static Field OperEmpName = new Field< ORD_SalesReturn >("OperEmpName");
		    /// <summary>
            /// 币种 - 字段名：Currency - 数据类型：String
            /// </summary>
            public static Field Currency = new Field< ORD_SalesReturn >("Currency");
		    /// <summary>
            /// 金额 - 字段名：Amount - 数据类型：Decimal?
            /// </summary>
            public static Field Amount = new Field< ORD_SalesReturn >("Amount");
		    /// <summary>
            /// 运费结算方式 - 字段名：FreightClearForm - 数据类型：String
            /// </summary>
            public static Field FreightClearForm = new Field< ORD_SalesReturn >("FreightClearForm");
		    /// <summary>
            /// 货运公司 - 字段名：TransportCompany - 数据类型：String
            /// </summary>
            public static Field TransportCompany = new Field< ORD_SalesReturn >("TransportCompany");
		    /// <summary>
            /// 货运单号 - 字段名：ShippingNo - 数据类型：String
            /// </summary>
            public static Field ShippingNo = new Field< ORD_SalesReturn >("ShippingNo");
		    /// <summary>
            /// 运费金额 - 字段名：Freight - 数据类型：Decimal?
            /// </summary>
            public static Field Freight = new Field< ORD_SalesReturn >("Freight");
		    /// <summary>
            /// 退货原因 - 字段名：Explain - 数据类型：String
            /// </summary>
            public static Field Explain = new Field< ORD_SalesReturn >("Explain");
		    /// <summary>
            /// 备注 - 字段名：Remark - 数据类型：String
            /// </summary>
            public static Field Remark = new Field< ORD_SalesReturn >("Remark");
		    /// <summary>
            /// 入库占有状态 - 字段名：StkInOccStatus - 数据类型：String
            /// </summary>
            public static Field StkInOccStatus = new Field< ORD_SalesReturn >("StkInOccStatus");
		    /// <summary>
            /// 入库状态 - 字段名：StkInStatus - 数据类型：String
            /// </summary>
            public static Field StkInStatus = new Field< ORD_SalesReturn >("StkInStatus");
		    /// <summary>
            /// 审核状态 - 字段名：ApproveStatus - 数据类型：String
            /// </summary>
            public static Field ApproveStatus = new Field< ORD_SalesReturn >("ApproveStatus");
		    /// <summary>
            /// 单据状态 - 字段名：Status - 数据类型：String
            /// </summary>
            public static Field Status = new Field< ORD_SalesReturn >("Status");
		    /// <summary>
            ///  - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field< ORD_SalesReturn >("CreatedEmpID");
		    /// <summary>
            ///  - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field< ORD_SalesReturn >("CreatedEmpName");
		    /// <summary>
            ///  - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field< ORD_SalesReturn >("CreatedTime");
		    /// <summary>
            ///  - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field< ORD_SalesReturn >("UpdatedEmpID");
		    /// <summary>
            ///  - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field< ORD_SalesReturn >("UpdatedEmpName");
		    /// <summary>
            ///  - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field< ORD_SalesReturn >("UpdatedTime");
		    /// <summary>
            /// 删除标记 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field< ORD_SalesReturn >("IsDeleted");
		}
	}
}