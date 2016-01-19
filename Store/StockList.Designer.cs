using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class StockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockList));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.getStockListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReports1 = new VIRETAILENTITIES.DsReports();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.getStockListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(315, 342);
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // getStockListBindingSource
            // 
            this.getStockListBindingSource.DataMember = "GetStockItemsForTransfer";
            this.getStockListBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // dsReports1
            // 
            this.dsReports1.DataSetName = "DsReports";
            this.dsReports1.EnforceConstraints = false;
            this.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 32);
            this.panel1.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "F1 - Bar Code Selection";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(136, 6);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.NullText = "Enter Item name";
            this.textEdit1.Properties.NullValuePrompt = "Enter Item name";
            this.textEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit1.Size = new System.Drawing.Size(600, 20);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.getStockListBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 32);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(770, 379);
            this.gridControl1.TabIndex = 24;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSEL,
            this.colSTOCKID,
            this.colITEMNO,
            this.colITEMNAME,
            this.colBARCODE,
            this.colQTY,
            this.colINVRATE,
            this.colSPRICE,
            this.colCPRICE,
            this.colEXPDATE,
            this.colWHID,
            this.colCOMPANY});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 24;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colSEL
            // 
            this.colSEL.AppearanceCell.Options.UseTextOptions = true;
            this.colSEL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colSEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSEL.FieldName = "SEL";
            this.colSEL.Name = "colSEL";
            this.colSEL.OptionsColumn.ShowCaption = false;
            this.colSEL.Visible = true;
            this.colSEL.VisibleIndex = 0;
            this.colSEL.Width = 33;
            // 
            // colSTOCKID
            // 
            this.colSTOCKID.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOCKID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.FieldName = "STOCKID";
            this.colSTOCKID.Name = "colSTOCKID";
            this.colSTOCKID.OptionsColumn.AllowEdit = false;
            this.colSTOCKID.OptionsColumn.ReadOnly = true;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.Caption = "Item name";
            this.colITEMNAME.FieldName = "ITEMNAME";
            this.colITEMNAME.Name = "colITEMNAME";
            this.colITEMNAME.OptionsColumn.AllowEdit = false;
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 1;
            this.colITEMNAME.Width = 292;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.Caption = "Barcode";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 2;
            this.colBARCODE.Width = 155;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 48;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.Caption = "Price";
            this.colINVRATE.DisplayFormat.FormatString = "n2";
            this.colINVRATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVRATE.FieldName = "CPRICE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.OptionsColumn.AllowEdit = false;
            this.colINVRATE.Visible = true;
            this.colINVRATE.VisibleIndex = 4;
            this.colINVRATE.Width = 55;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.Caption = "S.Price";
            this.colSPRICE.DisplayFormat.FormatString = "n2";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 5;
            this.colSPRICE.Width = 58;
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.OptionsColumn.AllowEdit = false;
            this.colCPRICE.Width = 48;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.Caption = "Exp.Date";
            this.colEXPDATE.DisplayFormat.FormatString = "MM-yy";
            this.colEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.AllowEdit = false;
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.VisibleIndex = 6;
            this.colEXPDATE.Width = 71;
            // 
            // colWHID
            // 
            this.colWHID.AppearanceCell.Options.UseTextOptions = true;
            this.colWHID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colWHID.AppearanceHeader.Options.UseTextOptions = true;
            this.colWHID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWHID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colWHID.FieldName = "WHID";
            this.colWHID.Name = "colWHID";
            this.colWHID.OptionsColumn.AllowEdit = false;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "ITEMNAME", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BARCODE", "BARCODE", 58, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNO", "ITEMNO", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SEL", "SEL", 27, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EXPDATEREQ", "EXPDATEREQ", 75, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DISCOUNT", "DISCOUNT", 62, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "SUPPLIERNAME";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "SUPPLIERNO";
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 411);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "StockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock  List";
            this.Load += new System.EventHandler(this.StockList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockListKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.getStockListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bar bar1;
        private DsReports dsReports1;
        private BindingSource getStockListBindingSource;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colSEL;
        private GridColumn colSTOCKID;
        private GridColumn colITEMNO;
        private GridColumn colITEMNAME;
        private GridColumn colBARCODE;
        private GridColumn colQTY;
        private GridColumn colINVRATE;
        private GridColumn colSPRICE;
        private GridColumn colCPRICE;
        private GridColumn colEXPDATE;
        private GridColumn colWHID;
        private GridColumn colCOMPANY;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private Panel panel1;
        private LabelControl labelControl1;
        private TextEdit textEdit1;
    }
}