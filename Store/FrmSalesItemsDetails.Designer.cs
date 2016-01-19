using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class FrmSalesItemsDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesItemsDetails));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getSalesTargetItemDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRMOFRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRMOTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesTargetItemDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(848, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Store.Properties.Resources.printer1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "Print";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.getSalesTargetItemDetailsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(848, 321);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // getSalesTargetItemDetailsBindingSource
            // 
            this.getSalesTargetItemDetailsBindingSource.DataMember = "GetSalesTargetItemDetails";
            this.getSalesTargetItemDetailsBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.gridColumn1,
            this.colTRANDATE,
            this.colItemno,
            this.colItemname,
            this.colSaleQty,
            this.colSalesType,
            this.colPRMOFRM,
            this.colPRMOTO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sale Qty", this.colSaleQty, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEmpNo, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colItemno, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRANDATE, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colEmpNo
            // 
            this.colEmpNo.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmpNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmpNo.FieldName = "Emp No";
            this.colEmpNo.Name = "colEmpNo";
            this.colEmpNo.OptionsColumn.AllowEdit = false;
            this.colEmpNo.Visible = true;
            this.colEmpNo.VisibleIndex = 0;
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Sale Date";
            this.colTRANDATE.DisplayFormat.FormatString = "dd-MMM-yyyy HH:mm:ss.fff";
            this.colTRANDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 1;
            this.colTRANDATE.Width = 162;
            // 
            // colItemno
            // 
            this.colItemno.AppearanceCell.Options.UseTextOptions = true;
            this.colItemno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemno.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.FieldName = "Item no";
            this.colItemno.Name = "colItemno";
            this.colItemno.OptionsColumn.AllowEdit = false;
            this.colItemno.Visible = true;
            this.colItemno.VisibleIndex = 1;
            this.colItemno.Width = 124;
            // 
            // colItemname
            // 
            this.colItemname.AppearanceCell.Options.UseTextOptions = true;
            this.colItemname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.FieldName = "Item name";
            this.colItemname.Name = "colItemname";
            this.colItemname.OptionsColumn.AllowEdit = false;
            this.colItemname.Visible = true;
            this.colItemname.VisibleIndex = 2;
            this.colItemname.Width = 270;
            // 
            // colSaleQty
            // 
            this.colSaleQty.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSaleQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaleQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSaleQty.FieldName = "Sale Qty";
            this.colSaleQty.Name = "colSaleQty";
            this.colSaleQty.OptionsColumn.AllowEdit = false;
            this.colSaleQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colSaleQty.Visible = true;
            this.colSaleQty.VisibleIndex = 3;
            this.colSaleQty.Width = 57;
            // 
            // colSalesType
            // 
            this.colSalesType.AppearanceCell.Options.UseTextOptions = true;
            this.colSalesType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSalesType.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSalesType.FieldName = "SalesType";
            this.colSalesType.Name = "colSalesType";
            this.colSalesType.OptionsColumn.AllowEdit = false;
            this.colSalesType.OptionsColumn.ReadOnly = true;
            this.colSalesType.Visible = true;
            this.colSalesType.VisibleIndex = 4;
            this.colSalesType.Width = 82;
            // 
            // colPRMOFRM
            // 
            this.colPRMOFRM.AppearanceCell.Options.UseTextOptions = true;
            this.colPRMOFRM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRMOFRM.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRMOFRM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRMOFRM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRMOFRM.Caption = "Promotion From";
            this.colPRMOFRM.FieldName = "PRMOFRM";
            this.colPRMOFRM.Name = "colPRMOFRM";
            this.colPRMOFRM.OptionsColumn.AllowEdit = false;
            this.colPRMOFRM.Visible = true;
            this.colPRMOFRM.VisibleIndex = 5;
            this.colPRMOFRM.Width = 86;
            // 
            // colPRMOTO
            // 
            this.colPRMOTO.AppearanceCell.Options.UseTextOptions = true;
            this.colPRMOTO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRMOTO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRMOTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRMOTO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRMOTO.Caption = "Promotion To";
            this.colPRMOTO.FieldName = "PRMOTO";
            this.colPRMOTO.Name = "colPRMOTO";
            this.colPRMOTO.OptionsColumn.AllowEdit = false;
            this.colPRMOTO.Visible = true;
            this.colPRMOTO.VisibleIndex = 6;
            this.colPRMOTO.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Inv No";
            this.gridColumn1.FieldName = "SINVNO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 79;
            // 
            // FrmSalesItemsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 346);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSalesItemsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales Target Item Details";
            this.Load += new System.EventHandler(this.FrmSalesItemsDetails_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesTargetItemDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private GridControl gridControl1;
        private BindingSource getSalesTargetItemDetailsBindingSource;
        private GridView gridView1;
        private GridColumn colEmpNo;
        private GridColumn colTRANDATE;
        private GridColumn colItemno;
        private GridColumn colItemname;
        private GridColumn colSaleQty;
        private GridColumn colSalesType;
        private GridColumn colPRMOFRM;
        private GridColumn colPRMOTO;
        private GridColumn gridColumn1;
    }
}