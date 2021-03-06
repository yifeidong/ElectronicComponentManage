//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2015/3/12
//     Time:    12:08
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
    /// 表名：STK_Stock 主键列：ItemCode
    /// </summary>
    [SerializableAttribute()]
	public partial class STK_Stock : BaseEntity
	{
		#region Private Properties
		
		private Int32? _StockID;
		private Guid? _ItemCode;
		private Guid? _TItemCode;
		private Guid? _GCompanyID;
		private String _SourceType;
		private Guid? _POGuid;
		private String _POBillNo;
		private Guid? _POLineGuid;
		private Guid? _StkInGuid;
		private String _StkInBillNo;
		private Guid? _StkInLineGuid;
		private Int32? _BuyerID;
		private String _BuyerName;
		private String _Model;
		private String _Brand;
		private String _Batch;
		private String _Package;
		private String _Quality;
		private String _MPQ;
		private String _MarkCode;
		private String _Description;
		private String _Remark;
		private String _Warehouse;
		private String _Location;
		private String _InvType;
		private String _InBatchNo;
		private Int32? _InvQty;
		private Int32? _BookedQty;
		private Int32? _UsableQty;
		private String _Unit;
		private String _Currency;
		private Decimal? _BuyPrice;
		private Decimal? _BuyPriceRMB;
		private Decimal? _BuyAveragePrice;
		private Decimal? _FollowPrice;
		private Decimal? _SalePrice;
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
		/// 库存ID.
		/// </summary>
		public Guid? ItemCode
		{
			get 
			{
				return _ItemCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.ItemCode, _ItemCode , value);
				this._ItemCode = value;
			}
		}
		
		/// <summary>
		/// 库存表自增ID（用于排序）.
		/// </summary>
		public Int32? StockID
		{
			get 
			{
				return this._StockID;
			}
			set 
			{
				this.OnPropertyValueChange(_.StockID, _StockID , value);
				this._StockID = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Guid? TItemCode
		{
			get 
			{
				return this._TItemCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.TItemCode, _TItemCode , value);
				this._TItemCode = value;
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
		/// 库存来源（ 采购入库，销售退货入库）.
		/// </summary>
		public String SourceType
		{
			get 
			{
				return this._SourceType;
			}
			set 
			{
				this.OnPropertyValueChange(_.SourceType, _SourceType , value);
				this._SourceType = value.SubStr(10);
			}
		}

		/// <summary>
		/// 采购主单Guid.
		/// </summary>
		public Guid? POGuid
		{
			get 
			{
				return this._POGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.POGuid, _POGuid , value);
				this._POGuid = value;
			}
		}

		/// <summary>
		/// 采购单号.
		/// </summary>
		public String POBillNo
		{
			get 
			{
				return this._POBillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.POBillNo, _POBillNo , value);
				this._POBillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 采购明细Guid.
		/// </summary>
		public Guid? POLineGuid
		{
			get 
			{
				return this._POLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.POLineGuid, _POLineGuid , value);
				this._POLineGuid = value;
			}
		}

		/// <summary>
		/// 入库主单Guid.
		/// </summary>
		public Guid? StkInGuid
		{
			get 
			{
				return this._StkInGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInGuid, _StkInGuid , value);
				this._StkInGuid = value;
			}
		}

		/// <summary>
		/// 入库单号.
		/// </summary>
		public String StkInBillNo
		{
			get 
			{
				return this._StkInBillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInBillNo, _StkInBillNo , value);
				this._StkInBillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 入库明细Guid.
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
		/// 采购员ID.
		/// </summary>
		public Int32? BuyerID
		{
			get 
			{
				return this._BuyerID;
			}
			set 
			{
				this.OnPropertyValueChange(_.BuyerID, _BuyerID , value);
				this._BuyerID = value;
			}
		}

		/// <summary>
		/// 采购员.
		/// </summary>
		public String BuyerName
		{
			get 
			{
				return this._BuyerName;
			}
			set 
			{
				this.OnPropertyValueChange(_.BuyerName, _BuyerName , value);
				this._BuyerName = value.SubStr(50);
			}
		}

		/// <summary>
		/// 型号.
		/// </summary>
		public String Model
		{
			get 
			{
				return this._Model;
			}
			set 
			{
				this.OnPropertyValueChange(_.Model, _Model , value);
				this._Model = value.SubStr(50);
			}
		}

		/// <summary>
		/// 品牌.
		/// </summary>
		public String Brand
		{
			get 
			{
				return this._Brand;
			}
			set 
			{
				this.OnPropertyValueChange(_.Brand, _Brand , value);
				this._Brand = value.SubStr(50);
			}
		}

		/// <summary>
		/// 批号/年份.
		/// </summary>
		public String Batch
		{
			get 
			{
				return this._Batch;
			}
			set 
			{
				this.OnPropertyValueChange(_.Batch, _Batch , value);
				this._Batch = value.SubStr(50);
			}
		}

		/// <summary>
		/// 封装.
		/// </summary>
		public String Package
		{
			get 
			{
				return this._Package;
			}
			set 
			{
				this.OnPropertyValueChange(_.Package, _Package , value);
				this._Package = value.SubStr(50);
			}
		}

		/// <summary>
		/// 品质.
		/// </summary>
		public String Quality
		{
			get 
			{
				return this._Quality;
			}
			set 
			{
				this.OnPropertyValueChange(_.Quality, _Quality , value);
				this._Quality = value.SubStr(50);
			}
		}

		/// <summary>
		/// 包装.
		/// </summary>
		public String MPQ
		{
			get 
			{
				return this._MPQ;
			}
			set 
			{
				this.OnPropertyValueChange(_.MPQ, _MPQ , value);
				this._MPQ = value.SubStr(50);
			}
		}

		/// <summary>
		/// 标识码.
		/// </summary>
		public String MarkCode
		{
			get 
			{
				return this._MarkCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.MarkCode, _MarkCode , value);
				this._MarkCode = value.SubStr(50);
			}
		}

		/// <summary>
		/// 描述.
		/// </summary>
		public String Description
		{
			get 
			{
				return this._Description;
			}
			set 
			{
				this.OnPropertyValueChange(_.Description, _Description , value);
				this._Description = value.SubStr(50);
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
		/// 仓库.
		/// </summary>
		public String Warehouse
		{
			get 
			{
				return this._Warehouse;
			}
			set 
			{
				this.OnPropertyValueChange(_.Warehouse, _Warehouse , value);
				this._Warehouse = value.SubStr(10);
			}
		}

		/// <summary>
		/// 位置.
		/// </summary>
		public String Location
		{
			get 
			{
				return this._Location;
			}
			set 
			{
				this.OnPropertyValueChange(_.Location, _Location , value);
				this._Location = value.SubStr(10);
			}
		}

		/// <summary>
		/// 库存类型(1.现货库存,2.补货库存,3.备货库存).
		/// </summary>
		public String InvType
		{
			get 
			{
				return this._InvType;
			}
			set 
			{
				this.OnPropertyValueChange(_.InvType, _InvType , value);
				this._InvType = value.SubStr(10);
			}
		}

		/// <summary>
		/// 入库批次.
		/// </summary>
		public String InBatchNo
		{
			get 
			{
				return this._InBatchNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.InBatchNo, _InBatchNo , value);
				this._InBatchNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 库存量.
		/// </summary>
		public Int32? InvQty
		{
			get 
			{
				return this._InvQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.InvQty, _InvQty , value);
				this._InvQty = value;
			}
		}

		/// <summary>
		/// 预留量.
		/// </summary>
		public Int32? BookedQty
		{
			get 
			{
				return this._BookedQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.BookedQty, _BookedQty , value);
				this._BookedQty = value;
			}
		}

		/// <summary>
		/// 可用量.
		/// </summary>
		public Int32? UsableQty
		{
			get 
			{
				return this._UsableQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.UsableQty, _UsableQty , value);
				this._UsableQty = value;
			}
		}

		/// <summary>
		/// 单位.
		/// </summary>
		public String Unit
		{
			get 
			{
				return this._Unit;
			}
			set 
			{
				this.OnPropertyValueChange(_.Unit, _Unit , value);
				this._Unit = value.SubStr(10);
			}
		}

		/// <summary>
		/// 入库币种.
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
		/// 入库进价(按入库币种).
		/// </summary>
		public Decimal? BuyPrice
		{
			get 
			{
				return this._BuyPrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.BuyPrice, _BuyPrice , value);
				this._BuyPrice = value;
			}
		}

		/// <summary>
		/// 入库进价(按RMB).
		/// </summary>
		public Decimal? BuyPriceRMB
		{
			get 
			{
				return this._BuyPriceRMB;
			}
			set 
			{
				this.OnPropertyValueChange(_.BuyPriceRMB, _BuyPriceRMB , value);
				this._BuyPriceRMB = value;
			}
		}

		/// <summary>
		/// 平均入库进价（按人民币）.
		/// </summary>
		public Decimal? BuyAveragePrice
		{
			get 
			{
				return this._BuyAveragePrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.BuyAveragePrice, _BuyAveragePrice , value);
				this._BuyAveragePrice = value;
			}
		}

		/// <summary>
		/// 销售指导价(按RMB).
		/// </summary>
		public Decimal? FollowPrice
		{
			get 
			{
				return this._FollowPrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.FollowPrice, _FollowPrice , value);
				this._FollowPrice = value;
			}
		}

		/// <summary>
		/// 销售定价(按RMB).
		/// </summary>
		public Decimal? SalePrice
		{
			get 
			{
				return this._SalePrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.SalePrice, _SalePrice , value);
				this._SalePrice = value;
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
            return new Table< STK_Stock >("STK_Stock");
        }
		
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField() {
            return _.StockID;
        }  			
		
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields() {
            return new Field[] {
				_.ItemCode
			};
        }
			
	    /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields() {
            return new Field[] {
				_.StockID,		
				_.ItemCode,		
				_.TItemCode,		
				_.GCompanyID,		
				_.SourceType,		
				_.POGuid,		
				_.POBillNo,		
				_.POLineGuid,		
				_.StkInGuid,		
				_.StkInBillNo,		
				_.StkInLineGuid,		
				_.BuyerID,		
				_.BuyerName,		
				_.Model,		
				_.Brand,		
				_.Batch,		
				_.Package,		
				_.Quality,		
				_.MPQ,		
				_.MarkCode,		
				_.Description,		
				_.Remark,		
				_.Warehouse,		
				_.Location,		
				_.InvType,		
				_.InBatchNo,		
				_.InvQty,		
				_.BookedQty,		
				_.UsableQty,		
				_.Unit,		
				_.Currency,		
				_.BuyPrice,		
				_.BuyPriceRMB,		
				_.BuyAveragePrice,		
				_.FollowPrice,		
				_.SalePrice,		
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
				this._StockID,		
				this._ItemCode,		
				this._TItemCode,		
				this._GCompanyID,		
				this._SourceType,		
				this._POGuid,		
				this._POBillNo,		
				this._POLineGuid,		
				this._StkInGuid,		
				this._StkInBillNo,		
				this._StkInLineGuid,		
				this._BuyerID,		
				this._BuyerName,		
				this._Model,		
				this._Brand,		
				this._Batch,		
				this._Package,		
				this._Quality,		
				this._MPQ,		
				this._MarkCode,		
				this._Description,		
				this._Remark,		
				this._Warehouse,		
				this._Location,		
				this._InvType,		
				this._InBatchNo,		
				this._InvQty,		
				this._BookedQty,		
				this._UsableQty,		
				this._Unit,		
				this._Currency,		
				this._BuyPrice,		
				this._BuyPriceRMB,		
				this._BuyAveragePrice,		
				this._FollowPrice,		
				this._SalePrice,		
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
            if ((false == reader.IsDBNull(_.StockID))) {
                this._StockID = reader.GetInt32(_.StockID);
            }
            if ((false == reader.IsDBNull(_.ItemCode))) {
                this._ItemCode = reader.GetGuid(_.ItemCode);
            }
            if ((false == reader.IsDBNull(_.TItemCode))) {
                this._TItemCode = reader.GetGuid(_.TItemCode);
            }
            if ((false == reader.IsDBNull(_.GCompanyID))) {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.SourceType))) {
                this._SourceType = reader.GetString(_.SourceType);
            }
            if ((false == reader.IsDBNull(_.POGuid))) {
                this._POGuid = reader.GetGuid(_.POGuid);
            }
            if ((false == reader.IsDBNull(_.POBillNo))) {
                this._POBillNo = reader.GetString(_.POBillNo);
            }
            if ((false == reader.IsDBNull(_.POLineGuid))) {
                this._POLineGuid = reader.GetGuid(_.POLineGuid);
            }
            if ((false == reader.IsDBNull(_.StkInGuid))) {
                this._StkInGuid = reader.GetGuid(_.StkInGuid);
            }
            if ((false == reader.IsDBNull(_.StkInBillNo))) {
                this._StkInBillNo = reader.GetString(_.StkInBillNo);
            }
            if ((false == reader.IsDBNull(_.StkInLineGuid))) {
                this._StkInLineGuid = reader.GetGuid(_.StkInLineGuid);
            }
            if ((false == reader.IsDBNull(_.BuyerID))) {
                this._BuyerID = reader.GetInt32(_.BuyerID);
            }
            if ((false == reader.IsDBNull(_.BuyerName))) {
                this._BuyerName = reader.GetString(_.BuyerName);
            }
            if ((false == reader.IsDBNull(_.Model))) {
                this._Model = reader.GetString(_.Model);
            }
            if ((false == reader.IsDBNull(_.Brand))) {
                this._Brand = reader.GetString(_.Brand);
            }
            if ((false == reader.IsDBNull(_.Batch))) {
                this._Batch = reader.GetString(_.Batch);
            }
            if ((false == reader.IsDBNull(_.Package))) {
                this._Package = reader.GetString(_.Package);
            }
            if ((false == reader.IsDBNull(_.Quality))) {
                this._Quality = reader.GetString(_.Quality);
            }
            if ((false == reader.IsDBNull(_.MPQ))) {
                this._MPQ = reader.GetString(_.MPQ);
            }
            if ((false == reader.IsDBNull(_.MarkCode))) {
                this._MarkCode = reader.GetString(_.MarkCode);
            }
            if ((false == reader.IsDBNull(_.Description))) {
                this._Description = reader.GetString(_.Description);
            }
            if ((false == reader.IsDBNull(_.Remark))) {
                this._Remark = reader.GetString(_.Remark);
            }
            if ((false == reader.IsDBNull(_.Warehouse))) {
                this._Warehouse = reader.GetString(_.Warehouse);
            }
            if ((false == reader.IsDBNull(_.Location))) {
                this._Location = reader.GetString(_.Location);
            }
            if ((false == reader.IsDBNull(_.InvType))) {
                this._InvType = reader.GetString(_.InvType);
            }
            if ((false == reader.IsDBNull(_.InBatchNo))) {
                this._InBatchNo = reader.GetString(_.InBatchNo);
            }
            if ((false == reader.IsDBNull(_.InvQty))) {
                this._InvQty = reader.GetInt32(_.InvQty);
            }
            if ((false == reader.IsDBNull(_.BookedQty))) {
                this._BookedQty = reader.GetInt32(_.BookedQty);
            }
            if ((false == reader.IsDBNull(_.UsableQty))) {
                this._UsableQty = reader.GetInt32(_.UsableQty);
            }
            if ((false == reader.IsDBNull(_.Unit))) {
                this._Unit = reader.GetString(_.Unit);
            }
            if ((false == reader.IsDBNull(_.Currency))) {
                this._Currency = reader.GetString(_.Currency);
            }
            if ((false == reader.IsDBNull(_.BuyPrice))) {
                this._BuyPrice = reader.GetDecimal(_.BuyPrice);
            }
            if ((false == reader.IsDBNull(_.BuyPriceRMB))) {
                this._BuyPriceRMB = reader.GetDecimal(_.BuyPriceRMB);
            }
            if ((false == reader.IsDBNull(_.BuyAveragePrice))) {
                this._BuyAveragePrice = reader.GetDecimal(_.BuyAveragePrice);
            }
            if ((false == reader.IsDBNull(_.FollowPrice))) {
                this._FollowPrice = reader.GetDecimal(_.FollowPrice);
            }
            if ((false == reader.IsDBNull(_.SalePrice))) {
                this._SalePrice = reader.GetDecimal(_.SalePrice);
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
            if ((false == typeof(STK_Stock).IsAssignableFrom(obj.GetType()))) {
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
            public static AllField All = new AllField< STK_Stock >();
			
		    /// <summary>
            /// 库存表自增ID（用于排序） - 字段名：StockID - 数据类型：Int32?
            /// </summary>
            public static Field StockID = new Field< STK_Stock >("StockID");
		    /// <summary>
            /// 库存ID - 字段名：ItemCode - 数据类型：Guid?
            /// </summary>
            public static Field ItemCode = new Field< STK_Stock >("ItemCode");
		    /// <summary>
            ///  - 字段名：TItemCode - 数据类型：Guid?
            /// </summary>
            public static Field TItemCode = new Field< STK_Stock >("TItemCode");
		    /// <summary>
            ///  - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field< STK_Stock >("GCompanyID");
		    /// <summary>
            /// 库存来源（ 采购入库，销售退货入库） - 字段名：SourceType - 数据类型：String
            /// </summary>
            public static Field SourceType = new Field< STK_Stock >("SourceType");
		    /// <summary>
            /// 采购主单Guid - 字段名：POGuid - 数据类型：Guid?
            /// </summary>
            public static Field POGuid = new Field< STK_Stock >("POGuid");
		    /// <summary>
            /// 采购单号 - 字段名：POBillNo - 数据类型：String
            /// </summary>
            public static Field POBillNo = new Field< STK_Stock >("POBillNo");
		    /// <summary>
            /// 采购明细Guid - 字段名：POLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field POLineGuid = new Field< STK_Stock >("POLineGuid");
		    /// <summary>
            /// 入库主单Guid - 字段名：StkInGuid - 数据类型：Guid?
            /// </summary>
            public static Field StkInGuid = new Field< STK_Stock >("StkInGuid");
		    /// <summary>
            /// 入库单号 - 字段名：StkInBillNo - 数据类型：String
            /// </summary>
            public static Field StkInBillNo = new Field< STK_Stock >("StkInBillNo");
		    /// <summary>
            /// 入库明细Guid - 字段名：StkInLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field StkInLineGuid = new Field< STK_Stock >("StkInLineGuid");
		    /// <summary>
            /// 采购员ID - 字段名：BuyerID - 数据类型：Int32?
            /// </summary>
            public static Field BuyerID = new Field< STK_Stock >("BuyerID");
		    /// <summary>
            /// 采购员 - 字段名：BuyerName - 数据类型：String
            /// </summary>
            public static Field BuyerName = new Field< STK_Stock >("BuyerName");
		    /// <summary>
            /// 型号 - 字段名：Model - 数据类型：String
            /// </summary>
            public static Field Model = new Field< STK_Stock >("Model");
		    /// <summary>
            /// 品牌 - 字段名：Brand - 数据类型：String
            /// </summary>
            public static Field Brand = new Field< STK_Stock >("Brand");
		    /// <summary>
            /// 批号/年份 - 字段名：Batch - 数据类型：String
            /// </summary>
            public static Field Batch = new Field< STK_Stock >("Batch");
		    /// <summary>
            /// 封装 - 字段名：Package - 数据类型：String
            /// </summary>
            public static Field Package = new Field< STK_Stock >("Package");
		    /// <summary>
            /// 品质 - 字段名：Quality - 数据类型：String
            /// </summary>
            public static Field Quality = new Field< STK_Stock >("Quality");
		    /// <summary>
            /// 包装 - 字段名：MPQ - 数据类型：String
            /// </summary>
            public static Field MPQ = new Field< STK_Stock >("MPQ");
		    /// <summary>
            /// 标识码 - 字段名：MarkCode - 数据类型：String
            /// </summary>
            public static Field MarkCode = new Field< STK_Stock >("MarkCode");
		    /// <summary>
            /// 描述 - 字段名：Description - 数据类型：String
            /// </summary>
            public static Field Description = new Field< STK_Stock >("Description");
		    /// <summary>
            /// 备注 - 字段名：Remark - 数据类型：String
            /// </summary>
            public static Field Remark = new Field< STK_Stock >("Remark");
		    /// <summary>
            /// 仓库 - 字段名：Warehouse - 数据类型：String
            /// </summary>
            public static Field Warehouse = new Field< STK_Stock >("Warehouse");
		    /// <summary>
            /// 位置 - 字段名：Location - 数据类型：String
            /// </summary>
            public static Field Location = new Field< STK_Stock >("Location");
		    /// <summary>
            /// 库存类型(1.现货库存,2.补货库存,3.备货库存) - 字段名：InvType - 数据类型：String
            /// </summary>
            public static Field InvType = new Field< STK_Stock >("InvType");
		    /// <summary>
            /// 入库批次 - 字段名：InBatchNo - 数据类型：String
            /// </summary>
            public static Field InBatchNo = new Field< STK_Stock >("InBatchNo");
		    /// <summary>
            /// 库存量 - 字段名：InvQty - 数据类型：Int32?
            /// </summary>
            public static Field InvQty = new Field< STK_Stock >("InvQty");
		    /// <summary>
            /// 预留量 - 字段名：BookedQty - 数据类型：Int32?
            /// </summary>
            public static Field BookedQty = new Field< STK_Stock >("BookedQty");
		    /// <summary>
            /// 可用量 - 字段名：UsableQty - 数据类型：Int32?
            /// </summary>
            public static Field UsableQty = new Field< STK_Stock >("UsableQty");
		    /// <summary>
            /// 单位 - 字段名：Unit - 数据类型：String
            /// </summary>
            public static Field Unit = new Field< STK_Stock >("Unit");
		    /// <summary>
            /// 入库币种 - 字段名：Currency - 数据类型：String
            /// </summary>
            public static Field Currency = new Field< STK_Stock >("Currency");
		    /// <summary>
            /// 入库进价(按入库币种) - 字段名：BuyPrice - 数据类型：Decimal?
            /// </summary>
            public static Field BuyPrice = new Field< STK_Stock >("BuyPrice");
		    /// <summary>
            /// 入库进价(按RMB) - 字段名：BuyPriceRMB - 数据类型：Decimal?
            /// </summary>
            public static Field BuyPriceRMB = new Field< STK_Stock >("BuyPriceRMB");
		    /// <summary>
            /// 平均入库进价（按人民币） - 字段名：BuyAveragePrice - 数据类型：Decimal?
            /// </summary>
            public static Field BuyAveragePrice = new Field< STK_Stock >("BuyAveragePrice");
		    /// <summary>
            /// 销售指导价(按RMB) - 字段名：FollowPrice - 数据类型：Decimal?
            /// </summary>
            public static Field FollowPrice = new Field< STK_Stock >("FollowPrice");
		    /// <summary>
            /// 销售定价(按RMB) - 字段名：SalePrice - 数据类型：Decimal?
            /// </summary>
            public static Field SalePrice = new Field< STK_Stock >("SalePrice");
		    /// <summary>
            ///  - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field< STK_Stock >("CreatedEmpID");
		    /// <summary>
            ///  - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field< STK_Stock >("CreatedEmpName");
		    /// <summary>
            ///  - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field< STK_Stock >("CreatedTime");
		    /// <summary>
            ///  - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field< STK_Stock >("UpdatedEmpID");
		    /// <summary>
            ///  - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field< STK_Stock >("UpdatedEmpName");
		    /// <summary>
            ///  - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field< STK_Stock >("UpdatedTime");
		    /// <summary>
            /// 是否删除 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field< STK_Stock >("IsDeleted");
		}
	}
}
