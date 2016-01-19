using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace Store
{
    partial class RptStockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptStockReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lookupwarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.btnshowall = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.iTEMGROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnshow = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stockReportAsOfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMacf_Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportAsOfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lookupwarehouse);
            this.panel1.Controls.Add(this.btnshowall);
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.btnshow);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 35);
            this.panel1.TabIndex = 3;
            // 
            // Lookupwarehouse
            // 
            this.Lookupwarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lookupwarehouse.Location = new System.Drawing.Point(157, 7);
            this.Lookupwarehouse.Name = "Lookupwarehouse";
            this.Lookupwarehouse.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Lookupwarehouse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lookupwarehouse.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lookupwarehouse.Properties.Appearance.Options.UseBackColor = true;
            this.Lookupwarehouse.Properties.Appearance.Options.UseFont = true;
            this.Lookupwarehouse.Properties.Appearance.Options.UseForeColor = true;
            this.Lookupwarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lookupwarehouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "STORECODE", 92, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORETYPE", "STORETYPE")});
            this.Lookupwarehouse.Properties.DisplayMember = "STORENAME";
            this.Lookupwarehouse.Properties.NullText = "";
            this.Lookupwarehouse.Properties.ShowFooter = false;
            this.Lookupwarehouse.Properties.ShowHeader = false;
            this.Lookupwarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Lookupwarehouse.Properties.ValueMember = "STORECODE";
            this.Lookupwarehouse.Size = new System.Drawing.Size(161, 20);
            this.Lookupwarehouse.TabIndex = 10;
            this.Lookupwarehouse.Visible = false;
            // 
            // btnshowall
            // 
            this.btnshowall.Appearance.Options.UseTextOptions = true;
            this.btnshowall.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnshowall.Image = global::Store.Properties.Resources.page_white_magnify;
            this.btnshowall.Location = new System.Drawing.Point(714, 6);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(74, 26);
            this.btnshowall.TabIndex = 9;
            this.btnshowall.Text = "Show all";
            this.btnshowall.Visible = false;
            this.btnshowall.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(387, 7);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPNAME", "GROUPNAME", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARGROUPNAME", "ARGROUPNAME", 87, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FIXDISC", "FIXDISC", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UPD", "UPD", 30, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.iTEMGROUPBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "GROUPNAME";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "GROUPID";
            this.lookUpEdit1.Size = new System.Drawing.Size(320, 20);
            this.lookUpEdit1.TabIndex = 8;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.LookupSupplier_EditValueChanged);
            // 
            // iTEMGROUPBindingSource
            // 
            this.iTEMGROUPBindingSource.DataMember = "ITEMGROUP";
            this.iTEMGROUPBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(344, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Group :";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton3.Location = new System.Drawing.Point(792, 6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 25);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.SimpleButton3Click);
            // 
            // btnshow
            // 
            this.btnshow.Image = global::Store.Properties.Resources.page_white_magnify;
            this.btnshow.Location = new System.Drawing.Point(714, 6);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(74, 25);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(113, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Store :";
            this.labelControl1.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stockReportAsOfBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(869, 491);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stockReportAsOfBindingSource
            // 
            this.stockReportAsOfBindingSource.DataMember = "StockReportAsOf";
            this.stockReportAsOfBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarcode,
            this.colMacf_Barcode,
            this.colItemname,
            this.colGroupname,
            this.colStock});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroupname, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colBarcode
            // 
            this.colBarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBarcode.AppearanceCell.Options.UseFont = true;
            this.colBarcode.AppearanceCell.Options.UseTextOptions = true;
            this.colBarcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBarcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBarcode.AppearanceHeader.Options.UseFont = true;
            this.colBarcode.AppearanceHeader.Options.UseTextOptions = true;
            this.colBarcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBarcode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.OptionsColumn.AllowEdit = false;
            this.colBarcode.OptionsColumn.ReadOnly = true;
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 0;
            this.colBarcode.Width = 149;
            // 
            // colMacf_Barcode
            // 
            this.colMacf_Barcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMacf_Barcode.AppearanceCell.Options.UseFont = true;
            this.colMacf_Barcode.AppearanceCell.Options.UseTextOptions = true;
            this.colMacf_Barcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMacf_Barcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMacf_Barcode.AppearanceHeader.Options.UseFont = true;
            this.colMacf_Barcode.AppearanceHeader.Options.UseTextOptions = true;
            this.colMacf_Barcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMacf_Barcode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMacf_Barcode.Caption = "Manf Barcode";
            this.colMacf_Barcode.FieldName = "Macf_Barcode";
            this.colMacf_Barcode.Name = "colMacf_Barcode";
            this.colMacf_Barcode.OptionsColumn.AllowEdit = false;
            this.colMacf_Barcode.OptionsColumn.ReadOnly = true;
            this.colMacf_Barcode.Visible = true;
            this.colMacf_Barcode.VisibleIndex = 1;
            this.colMacf_Barcode.Width = 232;
            // 
            // colItemname
            // 
            this.colItemname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemname.AppearanceCell.Options.UseFont = true;
            this.colItemname.AppearanceCell.Options.UseTextOptions = true;
            this.colItemname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemname.AppearanceHeader.Options.UseFont = true;
            this.colItemname.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.FieldName = "Item name";
            this.colItemname.Name = "colItemname";
            this.colItemname.OptionsColumn.AllowEdit = false;
            this.colItemname.OptionsColumn.ReadOnly = true;
            this.colItemname.Visible = true;
            this.colItemname.VisibleIndex = 2;
            this.colItemname.Width = 393;
            // 
            // colGroupname
            // 
            this.colGroupname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGroupname.AppearanceCell.Options.UseFont = true;
            this.colGroupname.AppearanceCell.Options.UseTextOptions = true;
            this.colGroupname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGroupname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGroupname.AppearanceHeader.Options.UseFont = true;
            this.colGroupname.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroupname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroupname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGroupname.FieldName = "Group name";
            this.colGroupname.Name = "colGroupname";
            this.colGroupname.OptionsColumn.AllowEdit = false;
            this.colGroupname.OptionsColumn.ReadOnly = true;
            this.colGroupname.Visible = true;
            this.colGroupname.VisibleIndex = 3;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceCell.Options.UseFont = true;
            this.colStock.AppearanceCell.Options.UseTextOptions = true;
            this.colStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colStock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceHeader.Options.UseFont = true;
            this.colStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            this.colStock.OptionsColumn.ReadOnly = true;
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 3;
            this.colStock.Width = 77;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(282, 244);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(269, 68);
            this.progressPanel1.TabIndex = 5;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // RptStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 526);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptStockReport";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.RptStockReport_Load);
            this.Resize += new System.EventHandler(this.RptStockReportResize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportAsOfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton3;
        private SimpleButton btnshow;
        private LabelControl labelControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private ProgressPanel progressPanel1;
        private BindingSource stockReportAsOfBindingSource;
        private GridColumn colBarcode;
        private GridColumn colMacf_Barcode;
        private GridColumn colItemname;
        private GridColumn colGroupname;
        private GridColumn colStock;
        private LabelControl labelControl3;
        private LookUpEdit lookUpEdit1;
        private BindingSource iTEMGROUPBindingSource;
        private SimpleButton btnshowall;
        protected LookUpEdit Lookupwarehouse;
    }
}