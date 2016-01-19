using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;

namespace Store
{
    partial class OpeningComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningComp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.iTEMGROUPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yearEndInventory1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStkDiff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.openingvariationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEMNO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockvalue1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearEndInventory1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openingvariationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.marqueeProgressBarControl1);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 33);
            this.panel1.TabIndex = 0;
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(3, 2);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(76, 28);
            this.marqueeProgressBarControl1.TabIndex = 2;
            this.marqueeProgressBarControl1.Visible = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(702, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(148, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = " Print Items Not Scanned";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "2013";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(554, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(142, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Print Stock Difference";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(490, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Run";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // iTEMGROUPBindingSource1
            // 
            this.iTEMGROUPBindingSource1.DataMember = "ITEMGROUP";
            this.iTEMGROUPBindingSource1.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // yearEndInventory1BindingSource
            // 
            this.yearEndInventory1BindingSource.DataMember = "YearEndInventory1";
            this.yearEndInventory1BindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 33);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(855, 394);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(849, 366);
            this.xtraTabPage1.Text = "Stock Difference";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.yearEndInventory1BindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(849, 366);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemno,
            this.colbarcode,
            this.colitemname,
            this.colInStock,
            this.colActual,
            this.colStkDiff,
            this.colSprice,
            this.colSTOCKVALUE,
            this.colGroupid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "itemno", this.colitemno, "Count {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "StkDiff", this.colStkDiff, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "STOCKVALUE", this.colSTOCKVALUE, "{0:###,###,###.00}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroupid, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colInStock, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colitemno
            // 
            this.colitemno.AppearanceCell.Options.UseTextOptions = true;
            this.colitemno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colitemno.AppearanceHeader.Options.UseTextOptions = true;
            this.colitemno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colitemno.Caption = "Itemno";
            this.colitemno.FieldName = "itemno";
            this.colitemno.Name = "colitemno";
            this.colitemno.OptionsColumn.ReadOnly = true;
            this.colitemno.Visible = true;
            this.colitemno.VisibleIndex = 0;
            this.colitemno.Width = 103;
            // 
            // colbarcode
            // 
            this.colbarcode.AppearanceCell.Options.UseTextOptions = true;
            this.colbarcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbarcode.AppearanceHeader.Options.UseTextOptions = true;
            this.colbarcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbarcode.Caption = "Manf.Barcode";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.ReadOnly = true;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 1;
            this.colbarcode.Width = 160;
            // 
            // colitemname
            // 
            this.colitemname.AppearanceCell.Options.UseTextOptions = true;
            this.colitemname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colitemname.AppearanceHeader.Options.UseTextOptions = true;
            this.colitemname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colitemname.Caption = "Item name";
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.ReadOnly = true;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 2;
            this.colitemname.Width = 310;
            // 
            // colInStock
            // 
            this.colInStock.AppearanceCell.Options.UseTextOptions = true;
            this.colInStock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colInStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colInStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInStock.Caption = "System Stock";
            this.colInStock.FieldName = "InStock";
            this.colInStock.Name = "colInStock";
            this.colInStock.OptionsColumn.ReadOnly = true;
            this.colInStock.Visible = true;
            this.colInStock.VisibleIndex = 3;
            this.colInStock.Width = 52;
            // 
            // colActual
            // 
            this.colActual.AppearanceCell.Options.UseTextOptions = true;
            this.colActual.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colActual.AppearanceHeader.Options.UseTextOptions = true;
            this.colActual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActual.Caption = "Physical Stock";
            this.colActual.FieldName = "Actual";
            this.colActual.Name = "colActual";
            this.colActual.OptionsColumn.ReadOnly = true;
            this.colActual.Visible = true;
            this.colActual.VisibleIndex = 4;
            this.colActual.Width = 52;
            // 
            // colStkDiff
            // 
            this.colStkDiff.AppearanceCell.Options.UseTextOptions = true;
            this.colStkDiff.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStkDiff.AppearanceHeader.Options.UseTextOptions = true;
            this.colStkDiff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStkDiff.Caption = "Diff Qty.";
            this.colStkDiff.FieldName = "StkDiff";
            this.colStkDiff.Name = "colStkDiff";
            this.colStkDiff.OptionsColumn.ReadOnly = true;
            this.colStkDiff.Visible = true;
            this.colStkDiff.VisibleIndex = 5;
            this.colStkDiff.Width = 51;
            // 
            // colSprice
            // 
            this.colSprice.AppearanceCell.Options.UseTextOptions = true;
            this.colSprice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSprice.AppearanceHeader.Options.UseTextOptions = true;
            this.colSprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSprice.Caption = "C.Price";
            this.colSprice.DisplayFormat.FormatString = "n2";
            this.colSprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSprice.FieldName = "Sprice";
            this.colSprice.Name = "colSprice";
            this.colSprice.OptionsColumn.ReadOnly = true;
            this.colSprice.Visible = true;
            this.colSprice.VisibleIndex = 6;
            this.colSprice.Width = 44;
            // 
            // colSTOCKVALUE
            // 
            this.colSTOCKVALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCKVALUE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKVALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOCKVALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOCKVALUE.Caption = "Value";
            this.colSTOCKVALUE.FieldName = "STOCKVALUE";
            this.colSTOCKVALUE.Name = "colSTOCKVALUE";
            this.colSTOCKVALUE.OptionsColumn.ReadOnly = true;
            this.colSTOCKVALUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "STOCKVALUE", "{0:###,###,###.00}")});
            this.colSTOCKVALUE.Visible = true;
            this.colSTOCKVALUE.VisibleIndex = 7;
            this.colSTOCKVALUE.Width = 53;
            // 
            // colGroupid
            // 
            this.colGroupid.AppearanceCell.Options.UseTextOptions = true;
            this.colGroupid.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGroupid.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroupid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroupid.Caption = "Group";
            this.colGroupid.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colGroupid.FieldName = "Groupid";
            this.colGroupid.Name = "colGroupid";
            this.colGroupid.OptionsColumn.ReadOnly = true;
            this.colGroupid.Visible = true;
            this.colGroupid.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.iTEMGROUPBindingSource1;
            this.repositoryItemLookUpEdit1.DisplayMember = "GROUPNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "GROUPID";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(849, 366);
            this.xtraTabPage2.Text = "Items not scanned";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.openingvariationBindingSource1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2});
            this.gridControl2.Size = new System.Drawing.Size(849, 366);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // openingvariationBindingSource1
            // 
            this.openingvariationBindingSource1.DataMember = "Openingvariation";
            this.openingvariationBindingSource1.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEMNO1,
            this.colBARCODE1,
            this.colITEMNAME1,
            this.colQTY,
            this.colStockvalue1,
            this.colGroupName});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "itemno", null, "Count {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "StkDiff", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "STOCKVALUE", this.colStockvalue1, "{0:###,###,###,###.00}")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroupName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colITEMNO1
            // 
            this.colITEMNO1.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO1.Caption = "Item no";
            this.colITEMNO1.FieldName = "ITEMNO";
            this.colITEMNO1.Name = "colITEMNO1";
            this.colITEMNO1.Visible = true;
            this.colITEMNO1.VisibleIndex = 0;
            this.colITEMNO1.Width = 166;
            // 
            // colBARCODE1
            // 
            this.colBARCODE1.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE1.Caption = "Barcode";
            this.colBARCODE1.FieldName = "BARCODE";
            this.colBARCODE1.Name = "colBARCODE1";
            this.colBARCODE1.Visible = true;
            this.colBARCODE1.VisibleIndex = 1;
            this.colBARCODE1.Width = 116;
            // 
            // colITEMNAME1
            // 
            this.colITEMNAME1.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME1.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNAME1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNAME1.Caption = "Item name";
            this.colITEMNAME1.FieldName = "ITEMNAME";
            this.colITEMNAME1.Name = "colITEMNAME1";
            this.colITEMNAME1.Visible = true;
            this.colITEMNAME1.VisibleIndex = 2;
            this.colITEMNAME1.Width = 399;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.Caption = "Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 40;
            // 
            // colStockvalue1
            // 
            this.colStockvalue1.AppearanceCell.Options.UseTextOptions = true;
            this.colStockvalue1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStockvalue1.AppearanceHeader.Options.UseTextOptions = true;
            this.colStockvalue1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStockvalue1.Caption = "StockValue";
            this.colStockvalue1.FieldName = "Stockvalue";
            this.colStockvalue1.Name = "colStockvalue1";
            this.colStockvalue1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Stockvalue", "{0:###,###,###.00}")});
            this.colStockvalue1.Visible = true;
            this.colStockvalue1.VisibleIndex = 4;
            this.colStockvalue1.Width = 110;
            // 
            // colGroupName
            // 
            this.colGroupName.AppearanceCell.Options.UseTextOptions = true;
            this.colGroupName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGroupName.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.iTEMGROUPBindingSource1;
            this.repositoryItemLookUpEdit2.DisplayMember = "GROUPNAME";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "GROUPID";
            // 
            // OpeningComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 427);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpeningComp";
            this.Text = "Opening Comparision";
            this.Load += new System.EventHandler(this.OpeningComp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearEndInventory1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openingvariationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private TextBox textBox1;
        private SimpleButton simpleButton3;
        private BindingSource yearEndInventory1BindingSource;
        private BindingSource iTEMGROUPBindingSource1;
        private MarqueeProgressBarControl marqueeProgressBarControl1;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colitemno;
        private GridColumn colbarcode;
        private GridColumn colitemname;
        private GridColumn colInStock;
        private GridColumn colActual;
        private GridColumn colStkDiff;
        private GridColumn colSprice;
        private GridColumn colSTOCKVALUE;
        private GridColumn colGroupid;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridControl gridControl2;
        private BindingSource openingvariationBindingSource1;
        private GridView gridView2;
        private GridColumn colITEMNO1;
        private GridColumn colBARCODE1;
        private GridColumn colITEMNAME1;
        private GridColumn colQTY;
        private GridColumn colStockvalue1;
        private GridColumn colGroupName;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    }
}