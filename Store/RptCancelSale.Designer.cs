using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptCancelSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptCancelSale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sALESINVDETAILDELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOCTORID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBINID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colISRETURN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESINVDETAILDELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 35);
            this.panel1.TabIndex = 4;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton3.Location = new System.Drawing.Point(463, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 25);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton4.Location = new System.Drawing.Point(383, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 25);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Show";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(207, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "To Date :";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(264, 8);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(104, 20);
            this.dateEdit2.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "From Date :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(97, 8);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(104, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sALESINVDETAILDELBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(925, 454);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sALESINVDETAILDELBindingSource
            // 
            this.sALESINVDETAILDELBindingSource.DataMember = "SALESINVDETAIL_DEL";
            this.sALESINVDETAILDELBindingSource.DataSource = typeof(VIRETAILENTITIES.DsInventory);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colTRANDATE,
            this.colSINVNO,
            this.colITEMNO,
            this.colBARCODE,
            this.colQTY,
            this.colINVRATE,
            this.colSPRICE,
            this.colCPRICE,
            this.colEXPDATE,
            this.colSTOCKID,
            this.colSTOCK,
            this.colDOCTORID,
            this.colITEMNAME,
            this.colCOMPANY,
            this.colBINID,
            this.colUSERID,
            this.colISRETURN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRANDATE, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.AllowEdit = false;
            this.colTID.OptionsColumn.ReadOnly = true;
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Inv.Date";
            this.colTRANDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.OptionsColumn.ReadOnly = true;
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 1;
            this.colTRANDATE.Width = 171;
            // 
            // colSINVNO
            // 
            this.colSINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.Caption = "Invoice No.";
            this.colSINVNO.FieldName = "SINVNO";
            this.colSINVNO.Name = "colSINVNO";
            this.colSINVNO.OptionsColumn.AllowEdit = false;
            this.colSINVNO.OptionsColumn.ReadOnly = true;
            this.colSINVNO.Visible = true;
            this.colSINVNO.VisibleIndex = 0;
            this.colSINVNO.Width = 167;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Our Code";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.ReadOnly = true;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 2;
            this.colITEMNO.Width = 149;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.Caption = "Manf.Code";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.ReadOnly = true;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 3;
            this.colBARCODE.Width = 165;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Qty.";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 4;
            this.colQTY.Width = 45;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.FieldName = "INVRATE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.OptionsColumn.AllowEdit = false;
            this.colINVRATE.OptionsColumn.ReadOnly = true;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.Caption = "Price";
            this.colSPRICE.DisplayFormat.FormatString = "n2";
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.OptionsColumn.ReadOnly = true;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 5;
            this.colSPRICE.Width = 40;
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
            this.colCPRICE.OptionsColumn.ReadOnly = true;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.AllowEdit = false;
            this.colEXPDATE.OptionsColumn.ReadOnly = true;
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
            // colSTOCK
            // 
            this.colSTOCK.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOCK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCK.Caption = "Stock";
            this.colSTOCK.FieldName = "STOCK";
            this.colSTOCK.Name = "colSTOCK";
            this.colSTOCK.OptionsColumn.AllowEdit = false;
            this.colSTOCK.OptionsColumn.ReadOnly = true;
            this.colSTOCK.Visible = true;
            this.colSTOCK.VisibleIndex = 6;
            this.colSTOCK.Width = 57;
            // 
            // colDOCTORID
            // 
            this.colDOCTORID.AppearanceCell.Options.UseTextOptions = true;
            this.colDOCTORID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOCTORID.AppearanceHeader.Options.UseTextOptions = true;
            this.colDOCTORID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDOCTORID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOCTORID.FieldName = "DOCTORID";
            this.colDOCTORID.Name = "colDOCTORID";
            this.colDOCTORID.OptionsColumn.AllowEdit = false;
            this.colDOCTORID.OptionsColumn.ReadOnly = true;
            this.colDOCTORID.Width = 167;
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
            this.colITEMNAME.OptionsColumn.ReadOnly = true;
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 1;
            this.colITEMNAME.Width = 139;
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
            this.colCOMPANY.OptionsColumn.ReadOnly = true;
            // 
            // colBINID
            // 
            this.colBINID.AppearanceCell.Options.UseTextOptions = true;
            this.colBINID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBINID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBINID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.FieldName = "BINID";
            this.colBINID.Name = "colBINID";
            this.colBINID.OptionsColumn.AllowEdit = false;
            this.colBINID.OptionsColumn.ReadOnly = true;
            // 
            // colUSERID
            // 
            this.colUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.Caption = "Cashier";
            this.colUSERID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            this.colUSERID.OptionsColumn.AllowEdit = false;
            this.colUSERID.OptionsColumn.ReadOnly = true;
            this.colUSERID.Visible = true;
            this.colUSERID.VisibleIndex = 7;
            this.colUSERID.Width = 199;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.uSERINFOBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "USERNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "USERID";
            // 
            // uSERINFOBindingSource
            // 
            this.uSERINFOBindingSource.DataMember = "USERINFO";
            this.uSERINFOBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // colISRETURN
            // 
            this.colISRETURN.AppearanceCell.Options.UseTextOptions = true;
            this.colISRETURN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISRETURN.AppearanceHeader.Options.UseTextOptions = true;
            this.colISRETURN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colISRETURN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISRETURN.FieldName = "ISRETURN";
            this.colISRETURN.Name = "colISRETURN";
            this.colISRETURN.OptionsColumn.AllowEdit = false;
            this.colISRETURN.OptionsColumn.ReadOnly = true;
            // 
            // RptCancelSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 489);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptCancelSale";
            this.Text = "Sale Cancel Reprot";
            this.Load += new System.EventHandler(this.RptCancelSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESINVDETAILDELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton4;
        private LabelControl labelControl2;
        private DateEdit dateEdit2;
        private LabelControl labelControl1;
        private DateEdit dateEdit1;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource sALESINVDETAILDELBindingSource;
        private GridColumn colTID;
        private GridColumn colSINVNO;
        private GridColumn colITEMNO;
        private GridColumn colBARCODE;
        private GridColumn colQTY;
        private GridColumn colINVRATE;
        private GridColumn colSPRICE;
        private GridColumn colCPRICE;
        private GridColumn colEXPDATE;
        private GridColumn colSTOCKID;
        private GridColumn colSTOCK;
        private GridColumn colDOCTORID;
        private GridColumn colITEMNAME;
        private GridColumn colCOMPANY;
        private GridColumn colBINID;
        private GridColumn colTRANDATE;
        private GridColumn colUSERID;
        private GridColumn colISRETURN;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BindingSource uSERINFOBindingSource;
    }
}