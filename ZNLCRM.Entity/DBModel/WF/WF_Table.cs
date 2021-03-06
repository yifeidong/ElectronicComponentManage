﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: Administrator
//     Date:    2015/1/14
//     Time:    15:08
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
    /// 表名：WF_Table 主键列：WF_TableID
    /// </summary>
    [SerializableAttribute()]
    public partial class WF_Table : BaseEntity
    {
        #region Private Properties

        private Int32 _WF_TableID;
        private String _WF_TableChsName;
        private String _WF_TableEngName;
        private String _BillPath;
        private String _GetMethodName;
        private String _GetParamPath;
        private String _UpdateMethodName;
        private String _AddEditEntityPath;
        private String _TriggerStatus;
        private String _AfterAuditMethodPath;
        private String _AfterAuditMethodName;
        private String _BelongEmpIDFld;
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
        /// ID.
        /// </summary>
        public Int32 WF_TableID
        {
            get
            {
                return _WF_TableID;
            }
            set
            {
                this.OnPropertyValueChange(_.WF_TableID, _WF_TableID, value);
                this._WF_TableID = value;
            }
        }

        /// <summary>
        /// 表中文名.
        /// </summary>
        public String WF_TableChsName
        {
            get
            {
                return this._WF_TableChsName;
            }
            set
            {
                this.OnPropertyValueChange(_.WF_TableChsName, _WF_TableChsName, value);
                this._WF_TableChsName = value.SubStr(200);
            }
        }

        /// <summary>
        /// 表英文名.
        /// </summary>
        public String WF_TableEngName
        {
            get
            {
                return this._WF_TableEngName;
            }
            set
            {
                this.OnPropertyValueChange(_.WF_TableEngName, _WF_TableEngName, value);
                this._WF_TableEngName = value.SubStr(200);
            }
        }

        /// <summary>
        /// 逻辑路径.
        /// </summary>
        public String BillPath
        {
            get
            {
                return this._BillPath;
            }
            set
            {
                this.OnPropertyValueChange(_.BillPath, _BillPath, value);
                this._BillPath = value.SubStr(200);
            }
        }

        /// <summary>
        /// 获取实体方法.
        /// </summary>
        public String GetMethodName
        {
            get
            {
                return this._GetMethodName;
            }
            set
            {
                this.OnPropertyValueChange(_.GetMethodName, _GetMethodName, value);
                this._GetMethodName = value.SubStr(100);
            }
        }

        /// <summary>
        /// 参数实体路径.
        /// </summary>
        public String GetParamPath
        {
            get
            {
                return this._GetParamPath;
            }
            set
            {
                this.OnPropertyValueChange(_.GetParamPath, _GetParamPath, value);
                this._GetParamPath = value.SubStr(300);
            }
        }

        /// <summary>
        /// 修改方法名称.
        /// </summary>
        public String UpdateMethodName
        {
            get
            {
                return this._UpdateMethodName;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdateMethodName, _UpdateMethodName, value);
                this._UpdateMethodName = value.SubStr(100);
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public String AddEditEntityPath
        {
            get
            {
                return this._AddEditEntityPath;
            }
            set
            {
                this.OnPropertyValueChange(_.AddEditEntityPath, _AddEditEntityPath, value);
                this._AddEditEntityPath = value.SubStr(200);
            }
        }

        /// <summary>
        /// 调用审核后执行的方法的触发状态.
        /// </summary>
        public String TriggerStatus
        {
            get
            {
                return this._TriggerStatus;
            }
            set
            {
                this.OnPropertyValueChange(_.TriggerStatus, _TriggerStatus, value);
                this._TriggerStatus = value.SubStr(30);
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public String AfterAuditMethodPath
        {
            get
            {
                return this._AfterAuditMethodPath;
            }
            set
            {
                this.OnPropertyValueChange(_.AfterAuditMethodPath, _AfterAuditMethodPath, value);
                this._AfterAuditMethodPath = value.SubStr(200);
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public String AfterAuditMethodName
        {
            get
            {
                return this._AfterAuditMethodName;
            }
            set
            {
                this.OnPropertyValueChange(_.AfterAuditMethodName, _AfterAuditMethodName, value);
                this._AfterAuditMethodName = value.SubStr(100);
            }
        }

        /// <summary>
        /// 员工ID字段名称.
        /// </summary>
        public String BelongEmpIDFld
        {
            get
            {
                return this._BelongEmpIDFld;
            }
            set
            {
                this.OnPropertyValueChange(_.BelongEmpIDFld, _BelongEmpIDFld, value);
                this._BelongEmpIDFld = value.SubStr(60);
            }
        }

        /// <summary>
        /// 创建人.
        /// </summary>
        public Int32? CreatedEmpID
        {
            get
            {
                return this._CreatedEmpID;
            }
            set
            {
                this.OnPropertyValueChange(_.CreatedEmpID, _CreatedEmpID, value);
                this._CreatedEmpID = value;
            }
        }

        /// <summary>
        /// 创建人姓名.
        /// </summary>
        public String CreatedEmpName
        {
            get
            {
                return this._CreatedEmpName;
            }
            set
            {
                this.OnPropertyValueChange(_.CreatedEmpName, _CreatedEmpName, value);
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
                this.OnPropertyValueChange(_.CreatedTime, _CreatedTime, value);
                this._CreatedTime = value;
            }
        }

        /// <summary>
        /// 更新人.
        /// </summary>
        public Int32? UpdatedEmpID
        {
            get
            {
                return this._UpdatedEmpID;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdatedEmpID, _UpdatedEmpID, value);
                this._UpdatedEmpID = value;
            }
        }

        /// <summary>
        /// 更新人.
        /// </summary>
        public String UpdatedEmpName
        {
            get
            {
                return this._UpdatedEmpName;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdatedEmpName, _UpdatedEmpName, value);
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
                this.OnPropertyValueChange(_.UpdatedTime, _UpdatedTime, value);
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
                this.OnPropertyValueChange(_.IsDeleted, _IsDeleted, value);
                this._IsDeleted = value;
            }
        }

        #endregion
        /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable()
        {
            return new Table<WF_Table>("WF_Table");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.WF_TableID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.WF_TableID
			};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
				_.WF_TableID,		
				_.WF_TableChsName,		
				_.WF_TableEngName,		
				_.BillPath,		
				_.GetMethodName,		
				_.GetParamPath,		
				_.UpdateMethodName,		
				_.AddEditEntityPath,		
				_.TriggerStatus,		
				_.AfterAuditMethodPath,		
				_.AfterAuditMethodName,		
				_.BelongEmpIDFld,		
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
        protected override object[] GetValues()
        {
            return new object[] {
				this._WF_TableID,		
				this._WF_TableChsName,		
				this._WF_TableEngName,		
				this._BillPath,		
				this._GetMethodName,		
				this._GetParamPath,		
				this._UpdateMethodName,		
				this._AddEditEntityPath,		
				this._TriggerStatus,		
				this._AfterAuditMethodPath,		
				this._AfterAuditMethodName,		
				this._BelongEmpIDFld,		
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
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.WF_TableID)))
            {
                this._WF_TableID = reader.GetInt32(_.WF_TableID);
            }
            if ((false == reader.IsDBNull(_.WF_TableChsName)))
            {
                this._WF_TableChsName = reader.GetString(_.WF_TableChsName);
            }
            if ((false == reader.IsDBNull(_.WF_TableEngName)))
            {
                this._WF_TableEngName = reader.GetString(_.WF_TableEngName);
            }
            if ((false == reader.IsDBNull(_.BillPath)))
            {
                this._BillPath = reader.GetString(_.BillPath);
            }
            if ((false == reader.IsDBNull(_.GetMethodName)))
            {
                this._GetMethodName = reader.GetString(_.GetMethodName);
            }
            if ((false == reader.IsDBNull(_.GetParamPath)))
            {
                this._GetParamPath = reader.GetString(_.GetParamPath);
            }
            if ((false == reader.IsDBNull(_.UpdateMethodName)))
            {
                this._UpdateMethodName = reader.GetString(_.UpdateMethodName);
            }
            if ((false == reader.IsDBNull(_.AddEditEntityPath)))
            {
                this._AddEditEntityPath = reader.GetString(_.AddEditEntityPath);
            }
            if ((false == reader.IsDBNull(_.TriggerStatus)))
            {
                this._TriggerStatus = reader.GetString(_.TriggerStatus);
            }
            if ((false == reader.IsDBNull(_.AfterAuditMethodPath)))
            {
                this._AfterAuditMethodPath = reader.GetString(_.AfterAuditMethodPath);
            }
            if ((false == reader.IsDBNull(_.AfterAuditMethodName)))
            {
                this._AfterAuditMethodName = reader.GetString(_.AfterAuditMethodName);
            }
            if ((false == reader.IsDBNull(_.BelongEmpIDFld)))
            {
                this._BelongEmpIDFld = reader.GetString(_.BelongEmpIDFld);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpID)))
            {
                this._CreatedEmpID = reader.GetInt32(_.CreatedEmpID);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpName)))
            {
                this._CreatedEmpName = reader.GetString(_.CreatedEmpName);
            }
            if ((false == reader.IsDBNull(_.CreatedTime)))
            {
                this._CreatedTime = reader.GetDateTime(_.CreatedTime);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpID)))
            {
                this._UpdatedEmpID = reader.GetInt32(_.UpdatedEmpID);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpName)))
            {
                this._UpdatedEmpName = reader.GetString(_.UpdatedEmpName);
            }
            if ((false == reader.IsDBNull(_.UpdatedTime)))
            {
                this._UpdatedTime = reader.GetDateTime(_.UpdatedTime);
            }
            if ((false == reader.IsDBNull(_.IsDeleted)))
            {
                this._IsDeleted = reader.GetBoolean(_.IsDeleted);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null))
            {
                return false;
            }
            if ((false == typeof(WF_Table).IsAssignableFrom(obj.GetType())))
            {
                return false;
            }
            if ((((object)(this)) == ((object)(obj))))
            {
                return true;
            }
            return false;
        }

        public class _
        {

            /// <summary>
            /// 表示选择所有列，与*等同
            /// </summary>
            public static AllField All = new AllField<WF_Table>();

            /// <summary>
            /// ID - 字段名：WF_TableID - 数据类型：Int32?
            /// </summary>
            public static Field WF_TableID = new Field<WF_Table>("WF_TableID");
            /// <summary>
            /// 表中文名 - 字段名：WF_TableChsName - 数据类型：String
            /// </summary>
            public static Field WF_TableChsName = new Field<WF_Table>("WF_TableChsName");
            /// <summary>
            /// 表英文名 - 字段名：WF_TableEngName - 数据类型：String
            /// </summary>
            public static Field WF_TableEngName = new Field<WF_Table>("WF_TableEngName");
            /// <summary>
            /// 逻辑路径 - 字段名：BillPath - 数据类型：String
            /// </summary>
            public static Field BillPath = new Field<WF_Table>("BillPath");
            /// <summary>
            /// 获取实体方法 - 字段名：GetMethodName - 数据类型：String
            /// </summary>
            public static Field GetMethodName = new Field<WF_Table>("GetMethodName");
            /// <summary>
            /// 参数实体路径 - 字段名：GetParamPath - 数据类型：String
            /// </summary>
            public static Field GetParamPath = new Field<WF_Table>("GetParamPath");
            /// <summary>
            /// 修改方法名称 - 字段名：UpdateMethodName - 数据类型：String
            /// </summary>
            public static Field UpdateMethodName = new Field<WF_Table>("UpdateMethodName");
            /// <summary>
            ///  - 字段名：AddEditEntityPath - 数据类型：String
            /// </summary>
            public static Field AddEditEntityPath = new Field<WF_Table>("AddEditEntityPath");
            /// <summary>
            /// 调用审核后执行的方法的触发状态 - 字段名：TriggerStatus - 数据类型：String
            /// </summary>
            public static Field TriggerStatus = new Field<WF_Table>("TriggerStatus");
            /// <summary>
            ///  - 字段名：AfterAuditMethodPath - 数据类型：String
            /// </summary>
            public static Field AfterAuditMethodPath = new Field<WF_Table>("AfterAuditMethodPath");
            /// <summary>
            ///  - 字段名：AfterAuditMethodName - 数据类型：String
            /// </summary>
            public static Field AfterAuditMethodName = new Field<WF_Table>("AfterAuditMethodName");
            /// <summary>
            /// 员工ID字段名称 - 字段名：BelongEmpIDFld - 数据类型：String
            /// </summary>
            public static Field BelongEmpIDFld = new Field<WF_Table>("BelongEmpIDFld");
            /// <summary>
            /// 创建人 - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field<WF_Table>("CreatedEmpID");
            /// <summary>
            /// 创建人姓名 - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field<WF_Table>("CreatedEmpName");
            /// <summary>
            /// 创建时间 - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field<WF_Table>("CreatedTime");
            /// <summary>
            /// 更新人 - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field<WF_Table>("UpdatedEmpID");
            /// <summary>
            /// 更新人 - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field<WF_Table>("UpdatedEmpName");
            /// <summary>
            /// 更新时间 - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field<WF_Table>("UpdatedTime");
            /// <summary>
            /// 是否删除 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field<WF_Table>("IsDeleted");
        }
    }
}
