﻿namespace ZNLCRM.UI.STK
{
    partial class frmSelectStkOutLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectStkOutLine));
            this.dgvStkOutLine = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.txtStkOutBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModel = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtSourceBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgStkOutLine = new ZNLCRM.Controls.UcPager();
            this.colStkOutGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colSourceBillGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStkOutLine)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStkOutLine
            // 
            this.dgvStkOutLine.AllowUserToAddRows = false;
            this.dgvStkOutLine.AllowUserToDeleteRows = false;
            this.dgvStkOutLine.AllowUserToOrderColumns = true;
            this.dgvStkOutLine.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStkOutLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStkOutLine.ColumnHeadersHeight = 30;
            this.dgvStkOutLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStkOutGuid,
            this.colStkOutLineGuid,
            this.colStkOutBillNo,
            this.colBillType,
            this.colSourceBillGuid,
            this.colSourceBillLineGuid,
            this.colSourceBillNo,
            this.colItemCode,
            this.colModel,
            this.colBrand,
            this.colPackage,
            this.colBatch,
            this.colInvType,
            this.colWarehouse,
            this.colLocation,
            this.colQty,
            this.colReturnQty,
            this.colUnitPrice,
            this.colAmount,
            this.colRemark,
            this.colQuality,
            this.colMPQ,
            this.colMarkCode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStkOutLine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStkOutLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStkOutLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStkOutLine.HighlightSelectedColumnHeaders = false;
            this.dgvStkOutLine.Location = new System.Drawing.Point(0, 0);
            this.dgvStkOutLine.Name = "dgvStkOutLine";
            this.dgvStkOutLine.PaintEnhancedSelection = false;
            this.dgvStkOutLine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStkOutLine.RowTemplate.Height = 23;
            this.dgvStkOutLine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStkOutLine.SelectAllSignVisible = false;
            this.dgvStkOutLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStkOutLine.Size = new System.Drawing.Size(940, 348);
            this.dgvStkOutLine.TabIndex = 17;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Controls.Add(this.txtStkOutBillNo);
            this.grpSearch.Controls.Add(this.ucLabel3);
            this.grpSearch.Controls.Add(this.txtModel);
            this.grpSearch.Controls.Add(this.ucLabel2);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.UcLabel1);
            this.grpSearch.Controls.Add(this.txtSourceBillNo);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(940, 30);
            this.grpSearch.TabIndex = 18;
            // 
            // chkAll
            // 
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(770, 7);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(64, 17);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 9;
            this.chkAll.Text = "全选";
            // 
            // txtStkOutBillNo
            // 
            // 
            // 
            // 
            this.txtStkOutBillNo.Border.Class = "TextBoxBorder";
            this.txtStkOutBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStkOutBillNo.EnterToNextControl = false;
            this.txtStkOutBillNo.Location = new System.Drawing.Point(327, 6);
            this.txtStkOutBillNo.Name = "txtStkOutBillNo";
            this.txtStkOutBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtStkOutBillNo.TabIndex = 8;
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(256, 9);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(65, 12);
            this.ucLabel3.TabIndex = 7;
            this.ucLabel3.Text = "出库单号：";
            // 
            // txtModel
            // 
            // 
            // 
            // 
            this.txtModel.Border.Class = "TextBoxBorder";
            this.txtModel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModel.EnterToNextControl = false;
            this.txtModel.Location = new System.Drawing.Point(533, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 21);
            this.txtModel.TabIndex = 6;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(486, 9);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(41, 12);
            this.ucLabel2.TabIndex = 5;
            this.ucLabel2.Text = "型号：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(689, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UcLabel1
            // 
            this.UcLabel1.AutoSize = true;
            this.UcLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.UcLabel1.ForeColor = System.Drawing.Color.Gray;
            this.UcLabel1.Location = new System.Drawing.Point(29, 9);
            this.UcLabel1.Name = "UcLabel1";
            this.UcLabel1.Size = new System.Drawing.Size(65, 12);
            this.UcLabel1.TabIndex = 2;
            this.UcLabel1.Text = "关联单号：";
            // 
            // txtSourceBillNo
            // 
            // 
            // 
            // 
            this.txtSourceBillNo.Border.Class = "TextBoxBorder";
            this.txtSourceBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSourceBillNo.EnterToNextControl = false;
            this.txtSourceBillNo.Location = new System.Drawing.Point(100, 5);
            this.txtSourceBillNo.Name = "txtSourceBillNo";
            this.txtSourceBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtSourceBillNo.TabIndex = 3;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOK);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 417);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(940, 47);
            this.panBottom.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(497, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(387, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.dgvStkOutLine);
            this.ucPanel1.Controls.Add(this.ucPanel2);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 30);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(940, 387);
            this.ucPanel1.TabIndex = 20;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.pgStkOutLine);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel2.Location = new System.Drawing.Point(0, 348);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(940, 39);
            this.ucPanel2.TabIndex = 18;
            // 
            // pgStkOutLine
            // 
            this.pgStkOutLine.BackColor = System.Drawing.Color.Transparent;
            this.pgStkOutLine.Location = new System.Drawing.Point(12, 13);
            this.pgStkOutLine.Name = "pgStkOutLine";
            this.pgStkOutLine.RecordCount = 0;
            this.pgStkOutLine.Size = new System.Drawing.Size(346, 15);
            this.pgStkOutLine.TabIndex = 0;
            this.pgStkOutLine.PageIndexChanged += new System.EventHandler(this.pgStkOutLine_PageIndexChanged);
            // 
            // colStkOutGuid
            // 
            this.colStkOutGuid.DataPropertyName = "StkOutGuid";
            this.colStkOutGuid.HeaderText = "StkOutGuid";
            this.colStkOutGuid.Name = "colStkOutGuid";
            this.colStkOutGuid.Visible = false;
            // 
            // colStkOutLineGuid
            // 
            this.colStkOutLineGuid.DataPropertyName = "StkOutLineGuid";
            this.colStkOutLineGuid.HeaderText = "StkOutLineGuid";
            this.colStkOutLineGuid.Name = "colStkOutLineGuid";
            this.colStkOutLineGuid.Visible = false;
            // 
            // colStkOutBillNo
            // 
            this.colStkOutBillNo.DataPropertyName = "StkOutBillNo";
            this.colStkOutBillNo.HeaderText = "出库单号";
            this.colStkOutBillNo.Name = "colStkOutBillNo";
            // 
            // colBillType
            // 
            this.colBillType.DataPropertyName = "BillType";
            this.colBillType.DropDownHeight = 106;
            this.colBillType.DropDownWidth = 121;
            this.colBillType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colBillType.HeaderText = "出库类型";
            this.colBillType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colBillType.IntegralHeight = false;
            this.colBillType.ItemHeight = 16;
            this.colBillType.Name = "colBillType";
            this.colBillType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colSourceBillGuid
            // 
            this.colSourceBillGuid.DataPropertyName = "SourceBillGuid";
            this.colSourceBillGuid.HeaderText = "SourceBillGuid";
            this.colSourceBillGuid.Name = "colSourceBillGuid";
            this.colSourceBillGuid.Visible = false;
            // 
            // colSourceBillLineGuid
            // 
            this.colSourceBillLineGuid.DataPropertyName = "SourceBillLineGuid";
            this.colSourceBillLineGuid.HeaderText = "SourceBillLineGuid";
            this.colSourceBillLineGuid.Name = "colSourceBillLineGuid";
            this.colSourceBillLineGuid.Visible = false;
            // 
            // colSourceBillNo
            // 
            this.colSourceBillNo.DataPropertyName = "SourceBillNo";
            this.colSourceBillNo.HeaderText = "关联单号";
            this.colSourceBillNo.Name = "colSourceBillNo";
            // 
            // colItemCode
            // 
            this.colItemCode.DataPropertyName = "ItemCode";
            this.colItemCode.HeaderText = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = false;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "型号";
            this.colModel.Name = "colModel";
            this.colModel.Width = 150;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "品牌";
            this.colBrand.Name = "colBrand";
            this.colBrand.Width = 80;
            // 
            // colPackage
            // 
            this.colPackage.DataPropertyName = "Package";
            this.colPackage.HeaderText = "封装";
            this.colPackage.Name = "colPackage";
            this.colPackage.Width = 80;
            // 
            // colBatch
            // 
            this.colBatch.DataPropertyName = "Batch";
            this.colBatch.HeaderText = "批号";
            this.colBatch.Name = "colBatch";
            this.colBatch.Visible = false;
            this.colBatch.Width = 80;
            // 
            // colInvType
            // 
            this.colInvType.DataPropertyName = "InvType";
            this.colInvType.HeaderText = "库存类型";
            this.colInvType.Name = "colInvType";
            // 
            // colWarehouse
            // 
            this.colWarehouse.DataPropertyName = "Warehouse";
            this.colWarehouse.HeaderText = "仓库";
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Width = 80;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "位置";
            this.colLocation.Name = "colLocation";
            this.colLocation.Width = 80;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "出库数量";
            this.colQty.Name = "colQty";
            this.colQty.Width = 80;
            // 
            // colReturnQty
            // 
            this.colReturnQty.DataPropertyName = "ReturnQty";
            this.colReturnQty.HeaderText = "退货数量";
            this.colReturnQty.Name = "colReturnQty";
            this.colReturnQty.Width = 80;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "出库单价";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 80;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "小计金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 80;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            // 
            // colQuality
            // 
            this.colQuality.DataPropertyName = "Quality";
            this.colQuality.HeaderText = "品质";
            this.colQuality.Name = "colQuality";
            this.colQuality.Width = 80;
            // 
            // colMPQ
            // 
            this.colMPQ.DataPropertyName = "MPQ";
            this.colMPQ.HeaderText = "包装";
            this.colMPQ.Name = "colMPQ";
            this.colMPQ.Width = 80;
            // 
            // colMarkCode
            // 
            this.colMarkCode.DataPropertyName = "MarkCode";
            this.colMarkCode.HeaderText = "标记码";
            this.colMarkCode.Name = "colMarkCode";
            this.colMarkCode.Width = 80;
            // 
            // frmSelectStkOutLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 464);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectStkOutLine";
            this.Text = "选择出库单明细";
            this.Load += new System.EventHandler(this.frmSelectStkOutLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStkOutLine)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDataGridView dgvStkOutLine;
        private Controls.UcPanel grpSearch;
        private Controls.UcTextBox txtModel;
        private Controls.UcLabel ucLabel2;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel UcLabel1;
        private Controls.UcTextBox txtSourceBillNo;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOK;
        private Controls.UcTextBox txtStkOutBillNo;
        private Controls.UcLabel ucLabel3;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPager pgStkOutLine;
        private Controls.UcCheckBox chkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutBillNo;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colBillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarkCode;
    }
}