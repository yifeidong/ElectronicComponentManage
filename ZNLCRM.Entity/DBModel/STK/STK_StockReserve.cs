//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2015/3/14
//     Time:    13:42
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
    /// 表名：STK_StockReserve 主键列：SRGuid
    /// </summary>
    [SerializableAttribute()]
	public partial class STK_StockReserve : BaseEntity
	{
		#region Private Properties
		
		private Int32? _SRID;
		private Guid? _SRGuid;
		private Guid? _GCompanyID;
		private Guid? _SourceBillGuid;
		private String _SourceBillNo;
		private Guid? _SourceBillLineGuid;
		private String _SourceBillType;
		private Guid? _StkInLineGuid;
		private Guid? _ItemCode;
		private Int32? _ReserveQty;
		private Int32? _UsedQty;
		private Boolean? _OperType;
		private Int32? _ReserveType;
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
		/// .
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
		/// 预留自增ID.
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
		/// 归属公司ID.
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
		/// 关联单据GUID (例如，销售单,采购退货单,销售退货单).
		/// </summary>
		public Guid? SourceBillGuid
		{
			get 
			{
				return this._SourceBillGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SourceBillGuid, _SourceBillGuid , value);
				this._SourceBillGuid = value;
			}
		}

		/// <summary>
		/// 关联单据编号.
		/// </summary>
		public String SourceBillNo
		{
			get 
			{
				return this._SourceBillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.SourceBillNo, _SourceBillNo , value);
				this._SourceBillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 关联单据明细GUID（销售明细Guid,采购退货明细Guid,销售退货明细Guid）.
		/// </summary>
		public Guid? SourceBillLineGuid
		{
			get 
			{
				return this._SourceBillLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SourceBillLineGuid, _SourceBillLineGuid , value);
				this._SourceBillLineGuid = value;
			}
		}

		/// <summary>
		/// 单据类型（销售出库，采购退货出库，销售退货入库）.
		/// </summary>
		public String SourceBillType
		{
			get 
			{
				return this._SourceBillType;
			}
			set 
			{
				this.OnPropertyValueChange(_.SourceBillType, _SourceBillType , value);
				this._SourceBillType = value.SubStr(50);
			}
		}

		/// <summary>
		/// 入库明细guid（本次入库时入库明细的guid）.
		/// </summary>
		public Guid? StkInLineGuid
		{
			get 
			{
				return this._StkInLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInLineGuid, _StkInLineGuid , value);
				this._StkInLineGuid = value;
			}
		}

		/// <summary>
		/// 库存ID.
		/// </summary>
		public Guid? ItemCode
		{
			get 
			{
				return this._ItemCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.ItemCode, _ItemCode , value);
				this._ItemCode = value;
			}
		}

		/// <summary>
		/// 预留数量.
		/// </summary>
		public Int32? ReserveQty
		{
			get 
			{
				return this._ReserveQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReserveQty, _ReserveQty , value);
				this._ReserveQty = value;
			}
		}

		/// <summary>
		/// 使用数量（使用数量不能大于预留数量，销售出库提交，采购退货出库提交，采购退货提交时需汇总回写此数量).
		/// </summary>
		public Int32? UsedQty
		{
			get 
			{
				return this._UsedQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.UsedQty, _UsedQty , value);
				this._UsedQty = value;
			}
		}

		/// <summary>
		/// 操作类型（0，系统预留，1，手工预留）.
		/// </summary>
		public Boolean? OperType
		{
			get 
			{
				return this._OperType;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperType, _OperType , value);
				this._OperType = value;
			}
		}

		/// <summary>
		/// 预留类型（0，借调预留，1，采购预留，2，占位预留，3，退货预留）.
		/// </summary>
		public Int32? ReserveType
		{
			get 
			{
				return this._ReserveType;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReserveType, _ReserveType , value);
				this._ReserveType = value;
			}
		}

		/// <summary>
		/// 创建人员ID.
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
		/// 创建人员.
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
		/// 创建时间.
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
		/// 更新人员ID.
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
		/// 更新人员.
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
		/// 更新时间.
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
		/// 是否删除.
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
            return new Table< STK_StockReserve >("STK_StockReserve");
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
				_.GCompanyID,		
				_.SourceBillGuid,		
				_.SourceBillNo,		
				_.SourceBillLineGuid,		
				_.SourceBillType,		
				_.StkInLineGuid,		
				_.ItemCode,		
				_.ReserveQty,		
				_.UsedQty,		
				_.OperType,		
				_.ReserveType,		
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
				this._GCompanyID,		
				this._SourceBillGuid,		
				this._SourceBillNo,		
				this._SourceBillLineGuid,		
				this._SourceBillType,		
				this._StkInLineGuid,		
				this._ItemCode,		
				this._ReserveQty,		
				this._UsedQty,		
				this._OperType,		
				this._ReserveType,		
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
            if ((false == reader.IsDBNull(_.GCompanyID))) {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.SourceBillGuid))) {
                this._SourceBillGuid = reader.GetGuid(_.SourceBillGuid);
            }
            if ((false == reader.IsDBNull(_.SourceBillNo))) {
                this._SourceBillNo = reader.GetString(_.SourceBillNo);
            }
            if ((false == reader.IsDBNull(_.SourceBillLineGuid))) {
                this._SourceBillLineGuid = reader.GetGuid(_.SourceBillLineGuid);
            }
            if ((false == reader.IsDBNull(_.SourceBillType))) {
                this._SourceBillType = reader.GetString(_.SourceBillType);
            }
            if ((false == reader.IsDBNull(_.StkInLineGuid))) {
                this._StkInLineGuid = reader.GetGuid(_.StkInLineGuid);
            }
            if ((false == reader.IsDBNull(_.ItemCode))) {
                this._ItemCode = reader.GetGuid(_.ItemCode);
            }
            if ((false == reader.IsDBNull(_.ReserveQty))) {
                this._ReserveQty = reader.GetInt32(_.ReserveQty);
            }
            if ((false == reader.IsDBNull(_.UsedQty))) {
                this._UsedQty = reader.GetInt32(_.UsedQty);
            }
            if ((false == reader.IsDBNull(_.OperType))) {
                this._OperType = reader.GetBoolean(_.OperType);
            }
            if ((false == reader.IsDBNull(_.ReserveType))) {
                this._ReserveType = reader.GetInt32(_.ReserveType);
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
            if ((false == typeof(STK_StockReserve).IsAssignableFrom(obj.GetType()))) {
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
            public static AllField All = new AllField< STK_StockReserve >();
			
		    /// <summary>
            /// 预留自增ID - 字段名：SRID - 数据类型：Int32?
            /// </summary>
            public static Field SRID = new Field< STK_StockReserve >("SRID");
		    /// <summary>
            ///  - 字段名：SRGuid - 数据类型：Guid?
            /// </summary>
            public static Field SRGuid = new Field< STK_StockReserve >("SRGuid");
		    /// <summary>
            /// 归属公司ID - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field< STK_StockReserve >("GCompanyID");
		    /// <summary>
            /// 关联单据GUID (例如，销售单,采购退货单,销售退货单) - 字段名：SourceBillGuid - 数据类型：Guid?
            /// </summary>
            public static Field SourceBillGuid = new Field< STK_StockReserve >("SourceBillGuid");
		    /// <summary>
            /// 关联单据编号 - 字段名：SourceBillNo - 数据类型：String
            /// </summary>
            public static Field SourceBillNo = new Field< STK_StockReserve >("SourceBillNo");
		    /// <summary>
            /// 关联单据明细GUID（销售明细Guid,采购退货明细Guid,销售退货明细Guid） - 字段名：SourceBillLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field SourceBillLineGuid = new Field< STK_StockReserve >("SourceBillLineGuid");
		    /// <summary>
            /// 单据类型（销售出库，采购退货出库，销售退货入库） - 字段名：SourceBillType - 数据类型：String
            /// </summary>
            public static Field SourceBillType = new Field< STK_StockReserve >("SourceBillType");
		    /// <summary>
            /// 入库明细guid（本次入库时入库明细的guid） - 字段名：StkInLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field StkInLineGuid = new Field< STK_StockReserve >("StkInLineGuid");
		    /// <summary>
            /// 库存ID - 字段名：ItemCode - 数据类型：Guid?
            /// </summary>
            public static Field ItemCode = new Field< STK_StockReserve >("ItemCode");
		    /// <summary>
            /// 预留数量 - 字段名：ReserveQty - 数据类型：Int32?
            /// </summary>
            public static Field ReserveQty = new Field< STK_StockReserve >("ReserveQty");
		    /// <summary>
            /// 使用数量（使用数量不能大于预留数量，销售出库提交，采购退货出库提交，采购退货提交时需汇总回写此数量) - 字段名：UsedQty - 数据类型：Int32?
            /// </summary>
            public static Field UsedQty = new Field< STK_StockReserve >("UsedQty");
		    /// <summary>
            /// 操作类型（0，系统预留，1，手工预留） - 字段名：OperType - 数据类型：Boolean?
            /// </summary>
            public static Field OperType = new Field< STK_StockReserve >("OperType");
		    /// <summary>
            /// 预留类型（0，借调预留，1，采购预留，2，占位预留，3，退货预留） - 字段名：ReserveType - 数据类型：Int32?
            /// </summary>
            public static Field ReserveType = new Field< STK_StockReserve >("ReserveType");
		    /// <summary>
            /// 创建人员ID - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field< STK_StockReserve >("CreatedEmpID");
		    /// <summary>
            /// 创建人员 - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field< STK_StockReserve >("CreatedEmpName");
		    /// <summary>
            /// 创建时间 - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field< STK_StockReserve >("CreatedTime");
		    /// <summary>
            /// 更新人员ID - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field< STK_StockReserve >("UpdatedEmpID");
		    /// <summary>
            /// 更新人员 - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field< STK_StockReserve >("UpdatedEmpName");
		    /// <summary>
            /// 更新时间 - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field< STK_StockReserve >("UpdatedTime");
		    /// <summary>
            /// 是否删除 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field< STK_StockReserve >("IsDeleted");
		}
	}
}
