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
    partial class ItemMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemMove));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookupto = new DevExpress.XtraEditors.LookUpEdit();
            this.lookupfrom = new DevExpress.XtraEditors.LookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtpurno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.iTEMTRANSFERDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventory1 = new VIRETAILENTITIES.DsInventory();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGROUPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLINETOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBATCHNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.iTEMGROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mastMoveTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupfrom.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastMoveTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(831, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.lookupto);
            this.panel1.Controls.Add(this.lookupfrom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtpurno);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.memoEdit1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 103);
            this.panel1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(287, 35);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 21);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "From M.R";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookupto
            // 
            this.lookupto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookupto.Location = new System.Drawing.Point(93, 34);
            this.lookupto.Name = "lookupto";
            this.lookupto.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookupto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lookupto.Properties.Appearance.Options.UseBackColor = true;
            this.lookupto.Properties.Appearance.Options.UseFont = true;
            this.lookupto.Properties.Appearance.Options.UseForeColor = true;
            this.lookupto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "Name26"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "Name27"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMM", "Name28", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPANY", "Name29")});
            this.lookupto.Properties.DisplayMember = "STORENAME";
            this.lookupto.Properties.NullText = "";
            this.lookupto.Properties.ShowFooter = false;
            this.lookupto.Properties.ShowHeader = false;
            this.lookupto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupto.Properties.ValueMember = "STORECODE";
            this.lookupto.Size = new System.Drawing.Size(190, 20);
            this.lookupto.TabIndex = 1;
            this.lookupto.EditValueChanged += new System.EventHandler(this.lookupto_EditValueChanged);
            // 
            // lookupfrom
            // 
            this.lookupfrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookupfrom.Location = new System.Drawing.Point(93, 9);
            this.lookupfrom.Name = "lookupfrom";
            this.lookupfrom.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookupfrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupfrom.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lookupfrom.Properties.Appearance.Options.UseBackColor = true;
            this.lookupfrom.Properties.Appearance.Options.UseFont = true;
            this.lookupfrom.Properties.Appearance.Options.UseForeColor = true;
            this.lookupfrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupfrom.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "Name2")});
            this.lookupfrom.Properties.DisplayMember = "STORENAME";
            this.lookupfrom.Properties.NullText = "";
            this.lookupfrom.Properties.ShowFooter = false;
            this.lookupfrom.Properties.ShowHeader = false;
            this.lookupfrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupfrom.Properties.ValueMember = "STORECODE";
            this.lookupfrom.Size = new System.Drawing.Size(249, 20);
            this.lookupfrom.TabIndex = 0;
            this.lookupfrom.EditValueChanged += new System.EventHandler(this.LookupfromEditValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.standaloneBarDockControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 27);
            this.panel2.TabIndex = 16;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(831, 27);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Location = new System.Drawing.Point(5, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 14);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "To Store :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Location = new System.Drawing.Point(5, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 14);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "From Store :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(690, 33);
            this.dateEdit1.MenuManager = this.ribbon;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(111, 20);
            this.dateEdit1.TabIndex = 3;
            this.dateEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateEdit1KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Location = new System.Drawing.Point(628, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Date :";
            // 
            // txtpurno
            // 
            this.txtpurno.Location = new System.Drawing.Point(689, 8);
            this.txtpurno.MenuManager = this.ribbon;
            this.txtpurno.Name = "txtpurno";
            this.txtpurno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtpurno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtpurno.Properties.Appearance.Options.UseFont = true;
            this.txtpurno.Properties.Appearance.Options.UseForeColor = true;
            this.txtpurno.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtpurno.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurno.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtpurno.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtpurno.Properties.ReadOnly = true;
            this.txtpurno.Size = new System.Drawing.Size(111, 20);
            this.txtpurno.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(627, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 14);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Doc. No. :";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(389, 6);
            this.memoEdit1.MenuManager = this.ribbon;
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.memoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.Appearance.Options.UseFont = true;
            this.memoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.memoEdit1.Size = new System.Drawing.Size(217, 65);
            this.memoEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(348, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Note :";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.iTEMTRANSFERDETAILBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 248);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(831, 297);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControl1EditorKeyDown);
            this.gridControl1.Click += new System.EventHandler(this.GridControl1Click);
            // 
            // iTEMTRANSFERDETAILBindingSource
            // 
            this.iTEMTRANSFERDETAILBindingSource.DataMember = "ITEMTRANSFERDETAIL";
            this.iTEMTRANSFERDETAILBindingSource.DataSource = this.dsInventory1;
            // 
            // dsInventory1
            // 
            this.dsInventory1.DataSetName = "DsInventory";
            this.dsInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colTRANID,
            this.colITEMNO,
            this.colBARCODE,
            this.colGROUPID,
            this.colWHID,
            this.colSTOCK,
            this.colQTY,
            this.colINVRATE,
            this.colSPRICE,
            this.colCPRICE,
            this.colEXPDATE,
            this.colLINETOTAL,
            this.colEXPR,
            this.colSTOCKID,
            this.colSUPID,
            this.colBATCHNO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", null, "{###,###,###.##:0}")});
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GridView1CustomDrawRowIndicator);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridView1CellValueChanged);
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceCell.Options.UseFont = true;
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceHeader.Options.UseFont = true;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.AllowFocus = false;
            this.colTID.OptionsColumn.AllowIncrementalSearch = false;
            this.colTID.OptionsColumn.AllowMove = false;
            this.colTID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTID.OptionsColumn.ReadOnly = true;
            this.colTID.OptionsFilter.AllowAutoFilter = false;
            this.colTID.OptionsFilter.AllowFilter = false;
            this.colTID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colTRANID
            // 
            this.colTRANID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANID.AppearanceCell.Options.UseFont = true;
            this.colTRANID.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANID.AppearanceHeader.Options.UseFont = true;
            this.colTRANID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.FieldName = "TRANID";
            this.colTRANID.Name = "colTRANID";
            this.colTRANID.OptionsColumn.AllowFocus = false;
            this.colTRANID.OptionsColumn.AllowIncrementalSearch = false;
            this.colTRANID.OptionsColumn.AllowMove = false;
            this.colTRANID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTRANID.OptionsColumn.ReadOnly = true;
            this.colTRANID.OptionsFilter.AllowAutoFilter = false;
            this.colTRANID.OptionsFilter.AllowFilter = false;
            this.colTRANID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceCell.Options.UseFont = true;
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Item Name";
            this.colITEMNO.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.AllowFocus = false;
            this.colITEMNO.OptionsColumn.AllowIncrementalSearch = false;
            this.colITEMNO.OptionsColumn.AllowMove = false;
            this.colITEMNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNO.OptionsColumn.ReadOnly = true;
            this.colITEMNO.OptionsFilter.AllowAutoFilter = false;
            this.colITEMNO.OptionsFilter.AllowFilter = false;
            this.colITEMNO.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 1;
            this.colITEMNO.Width = 296;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNO", "Name7"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "Name8")});
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceCell.Options.UseFont = true;
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceHeader.Options.UseFont = true;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.Caption = "Barcode";
            this.colBARCODE.FieldName = "ITEMNO";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.AllowFocus = false;
            this.colBARCODE.OptionsColumn.AllowIncrementalSearch = false;
            this.colBARCODE.OptionsColumn.AllowMove = false;
            this.colBARCODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBARCODE.OptionsColumn.ReadOnly = true;
            this.colBARCODE.OptionsFilter.AllowAutoFilter = false;
            this.colBARCODE.OptionsFilter.AllowFilter = false;
            this.colBARCODE.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 0;
            this.colBARCODE.Width = 136;
            // 
            // colGROUPID
            // 
            this.colGROUPID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGROUPID.AppearanceCell.Options.UseFont = true;
            this.colGROUPID.AppearanceCell.Options.UseTextOptions = true;
            this.colGROUPID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGROUPID.AppearanceHeader.Options.UseFont = true;
            this.colGROUPID.AppearanceHeader.Options.UseTextOptions = true;
            this.colGROUPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGROUPID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPID.FieldName = "GROUPID";
            this.colGROUPID.Name = "colGROUPID";
            this.colGROUPID.OptionsColumn.AllowFocus = false;
            this.colGROUPID.OptionsColumn.AllowIncrementalSearch = false;
            this.colGROUPID.OptionsColumn.AllowMove = false;
            this.colGROUPID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGROUPID.OptionsColumn.ReadOnly = true;
            this.colGROUPID.OptionsFilter.AllowAutoFilter = false;
            this.colGROUPID.OptionsFilter.AllowFilter = false;
            this.colGROUPID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colWHID
            // 
            this.colWHID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colWHID.AppearanceCell.Options.UseFont = true;
            this.colWHID.AppearanceCell.Options.UseTextOptions = true;
            this.colWHID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colWHID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colWHID.AppearanceHeader.Options.UseFont = true;
            this.colWHID.AppearanceHeader.Options.UseTextOptions = true;
            this.colWHID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWHID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colWHID.FieldName = "WHID";
            this.colWHID.Name = "colWHID";
            this.colWHID.OptionsColumn.AllowFocus = false;
            this.colWHID.OptionsColumn.AllowIncrementalSearch = false;
            this.colWHID.OptionsColumn.AllowMove = false;
            this.colWHID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colWHID.OptionsColumn.ReadOnly = true;
            this.colWHID.OptionsFilter.AllowAutoFilter = false;
            this.colWHID.OptionsFilter.AllowFilter = false;
            this.colWHID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSTOCK
            // 
            this.colSTOCK.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCK.AppearanceCell.Options.UseFont = true;
            this.colSTOCK.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCK.AppearanceHeader.Options.UseFont = true;
            this.colSTOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOCK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCK.Caption = "Stock";
            this.colSTOCK.FieldName = "STOCK";
            this.colSTOCK.Name = "colSTOCK";
            this.colSTOCK.OptionsColumn.AllowEdit = false;
            this.colSTOCK.OptionsColumn.AllowFocus = false;
            this.colSTOCK.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCK.OptionsColumn.AllowIncrementalSearch = false;
            this.colSTOCK.OptionsColumn.AllowMove = false;
            this.colSTOCK.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCK.OptionsColumn.ReadOnly = true;
            this.colSTOCK.OptionsFilter.AllowAutoFilter = false;
            this.colSTOCK.OptionsFilter.AllowFilter = false;
            this.colSTOCK.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCK.Visible = true;
            this.colSTOCK.VisibleIndex = 2;
            this.colSTOCK.Width = 42;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceCell.Options.UseFont = true;
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Qty.";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowIncrementalSearch = false;
            this.colQTY.OptionsColumn.AllowMove = false;
            this.colQTY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQTY.OptionsFilter.AllowAutoFilter = false;
            this.colQTY.OptionsFilter.AllowFilter = false;
            this.colQTY.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 49;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceCell.Options.UseFont = true;
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceHeader.Options.UseFont = true;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.Caption = "Rate";
            this.colINVRATE.FieldName = "INVRATE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.OptionsColumn.AllowFocus = false;
            this.colINVRATE.OptionsColumn.AllowIncrementalSearch = false;
            this.colINVRATE.OptionsColumn.AllowMove = false;
            this.colINVRATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colINVRATE.OptionsColumn.ReadOnly = true;
            this.colINVRATE.OptionsFilter.AllowAutoFilter = false;
            this.colINVRATE.OptionsFilter.AllowFilter = false;
            this.colINVRATE.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colINVRATE.Width = 41;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceCell.Options.UseFont = true;
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceHeader.Options.UseFont = true;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.Caption = "S.Price";
            this.colSPRICE.DisplayFormat.FormatString = "N2";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowFocus = false;
            this.colSPRICE.OptionsColumn.AllowIncrementalSearch = false;
            this.colSPRICE.OptionsColumn.AllowMove = false;
            this.colSPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSPRICE.OptionsColumn.ReadOnly = true;
            this.colSPRICE.OptionsFilter.AllowAutoFilter = false;
            this.colSPRICE.OptionsFilter.AllowFilter = false;
            this.colSPRICE.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 4;
            this.colSPRICE.Width = 57;
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceCell.Options.UseFont = true;
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceHeader.Options.UseFont = true;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.OptionsColumn.AllowFocus = false;
            this.colCPRICE.OptionsColumn.AllowIncrementalSearch = false;
            this.colCPRICE.OptionsColumn.AllowMove = false;
            this.colCPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCPRICE.OptionsColumn.ReadOnly = true;
            this.colCPRICE.OptionsFilter.AllowAutoFilter = false;
            this.colCPRICE.OptionsFilter.AllowFilter = false;
            this.colCPRICE.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colCPRICE.Width = 48;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceCell.Options.UseFont = true;
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceHeader.Options.UseFont = true;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.Caption = "Exp.Dt.";
            this.colEXPDATE.DisplayFormat.FormatString = "MM-yy";
            this.colEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.AllowFocus = false;
            this.colEXPDATE.OptionsColumn.AllowIncrementalSearch = false;
            this.colEXPDATE.OptionsColumn.AllowMove = false;
            this.colEXPDATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPDATE.OptionsColumn.ReadOnly = true;
            this.colEXPDATE.OptionsFilter.AllowAutoFilter = false;
            this.colEXPDATE.OptionsFilter.AllowFilter = false;
            this.colEXPDATE.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.VisibleIndex = 5;
            this.colEXPDATE.Width = 54;
            // 
            // colLINETOTAL
            // 
            this.colLINETOTAL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLINETOTAL.AppearanceCell.Options.UseFont = true;
            this.colLINETOTAL.AppearanceCell.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLINETOTAL.AppearanceHeader.Options.UseFont = true;
            this.colLINETOTAL.AppearanceHeader.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.Caption = "Total Value";
            this.colLINETOTAL.DisplayFormat.FormatString = "N2";
            this.colLINETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLINETOTAL.FieldName = "LINETOTAL";
            this.colLINETOTAL.Name = "colLINETOTAL";
            this.colLINETOTAL.OptionsColumn.AllowFocus = false;
            this.colLINETOTAL.OptionsColumn.AllowIncrementalSearch = false;
            this.colLINETOTAL.OptionsColumn.AllowMove = false;
            this.colLINETOTAL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLINETOTAL.OptionsColumn.ReadOnly = true;
            this.colLINETOTAL.OptionsFilter.AllowAutoFilter = false;
            this.colLINETOTAL.OptionsFilter.AllowFilter = false;
            this.colLINETOTAL.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colLINETOTAL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", "{0:###,###,###.00}")});
            this.colLINETOTAL.Visible = true;
            this.colLINETOTAL.VisibleIndex = 6;
            this.colLINETOTAL.Width = 80;
            // 
            // colEXPR
            // 
            this.colEXPR.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPR.AppearanceCell.Options.UseFont = true;
            this.colEXPR.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPR.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPR.AppearanceHeader.Options.UseFont = true;
            this.colEXPR.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPR.FieldName = "EXPR";
            this.colEXPR.Name = "colEXPR";
            this.colEXPR.OptionsColumn.AllowFocus = false;
            this.colEXPR.OptionsColumn.AllowIncrementalSearch = false;
            this.colEXPR.OptionsColumn.AllowMove = false;
            this.colEXPR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPR.OptionsColumn.ReadOnly = true;
            this.colEXPR.OptionsFilter.AllowAutoFilter = false;
            this.colEXPR.OptionsFilter.AllowFilter = false;
            this.colEXPR.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSTOCKID
            // 
            this.colSTOCKID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCKID.AppearanceCell.Options.UseFont = true;
            this.colSTOCKID.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCKID.AppearanceHeader.Options.UseFont = true;
            this.colSTOCKID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOCKID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.FieldName = "STOCKID";
            this.colSTOCKID.Name = "colSTOCKID";
            this.colSTOCKID.OptionsColumn.AllowFocus = false;
            this.colSTOCKID.OptionsColumn.AllowIncrementalSearch = false;
            this.colSTOCKID.OptionsColumn.AllowMove = false;
            this.colSTOCKID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCKID.OptionsColumn.ReadOnly = true;
            this.colSTOCKID.OptionsFilter.AllowAutoFilter = false;
            this.colSTOCKID.OptionsFilter.AllowFilter = false;
            this.colSTOCKID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSUPID
            // 
            this.colSUPID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPID.AppearanceCell.Options.UseFont = true;
            this.colSUPID.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPID.AppearanceHeader.Options.UseFont = true;
            this.colSUPID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPID.FieldName = "SUPID";
            this.colSUPID.Name = "colSUPID";
            this.colSUPID.OptionsColumn.AllowFocus = false;
            this.colSUPID.OptionsColumn.AllowIncrementalSearch = false;
            this.colSUPID.OptionsColumn.AllowMove = false;
            this.colSUPID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSUPID.OptionsColumn.ReadOnly = true;
            this.colSUPID.OptionsFilter.AllowAutoFilter = false;
            this.colSUPID.OptionsFilter.AllowFilter = false;
            this.colSUPID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colBATCHNO
            // 
            this.colBATCHNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBATCHNO.AppearanceCell.Options.UseFont = true;
            this.colBATCHNO.AppearanceCell.Options.UseTextOptions = true;
            this.colBATCHNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBATCHNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBATCHNO.AppearanceHeader.Options.UseFont = true;
            this.colBATCHNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colBATCHNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBATCHNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBATCHNO.Caption = "Batch No.";
            this.colBATCHNO.FieldName = "BATCHNO";
            this.colBATCHNO.Name = "colBATCHNO";
            this.colBATCHNO.OptionsColumn.AllowIncrementalSearch = false;
            this.colBATCHNO.OptionsColumn.AllowMove = false;
            this.colBATCHNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBATCHNO.OptionsFilter.AllowAutoFilter = false;
            this.colBATCHNO.OptionsFilter.AllowFilter = false;
            this.colBATCHNO.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colBATCHNO.Width = 67;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barEditItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barEditItem2,
            this.barEditItem3});
            this.barManager1.MaxItemId = 7;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.barManager1.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.BarManager1EditorKeyDown);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem3, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // barEditItem1
            // 
            this.barEditItem1.AutoFillWidth = true;
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 1;
            this.barEditItem1.ItemAppearance.Normal.BackColor = System.Drawing.Color.White;
            this.barEditItem1.ItemAppearance.Normal.Options.UseBackColor = true;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 15;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.BackColor = System.Drawing.Color.White;
            this.repositoryItemTextEdit1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.repositoryItemTextEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemTextEdit1.Appearance.Options.UseForeColor = true;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "Barcode / Name";
            this.repositoryItemTextEdit1.NullValuePrompt = "Barcode / Name";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Find Item - F10";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete Line - F4";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemLookUpEdit3;
            this.barEditItem3.Id = 6;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Width = 140;
            this.barEditItem3.EditValueChanged += new System.EventHandler(this.barEditItem3_EditValueChanged);
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPNAME", "GROUPNAME", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit3.DataSource = this.iTEMGROUPBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "GROUPNAME";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "-ALL-";
            this.repositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit3.ValueMember = "GROUPNAME";
            // 
            // iTEMGROUPBindingSource
            // 
            this.iTEMGROUPBindingSource.DataMember = "ITEMGROUP";
            this.iTEMGROUPBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.ActAsDropDown = true;
            this.barButtonItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem3.Caption = "By Category";
            this.barButtonItem3.DropDownControl = this.popupMenu1;
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(831, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Size = new System.Drawing.Size(831, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 577);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(831, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 577);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemLookUpEdit2;
            this.barEditItem2.Id = 5;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // mastMoveTypesBindingSource
            // 
            this.mastMoveTypesBindingSource.DataMember = "MastMoveTypes";
            this.mastMoveTypesBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // ItemMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 577);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "ItemMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ITEM TRANSFER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemMoveFormClosing);
            this.Load += new System.EventHandler(this.ItemMoveLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemMoveKeyDown);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupfrom.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastMoveTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private DateEdit dateEdit1;
        private LabelControl labelControl4;
        private TextEdit txtpurno;
        private LabelControl labelControl3;
        private MemoEdit memoEdit1;
        private LabelControl labelControl2;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colTID;
        private GridColumn colTRANID;
        private GridColumn colITEMNO;
        private GridColumn colBARCODE;
        private GridColumn colGROUPID;
        private GridColumn colWHID;
        private GridColumn colSTOCK;
        private GridColumn colQTY;
        private GridColumn colINVRATE;
        private GridColumn colSPRICE;
        private GridColumn colCPRICE;
        private GridColumn colEXPDATE;
        private GridColumn colLINETOTAL;
        private GridColumn colEXPR;
        private GridColumn colSTOCKID;
        private GridColumn colSUPID;
        private GridColumn colBATCHNO;
        private Panel panel2;
        private StandaloneBarDockControl standaloneBarDockControl1;
        private BarManager barManager1;
        private Bar bar1;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarEditItem barEditItem1;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarStaticItem barStaticItem1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DsInventory dsInventory1;
        private BindingSource iTEMTRANSFERDETAILBindingSource;
        protected LookUpEdit lookupto;
        protected LookUpEdit lookupfrom;
        private BindingSource mastMoveTypesBindingSource;
        private BarButtonItem barButtonItem3;
        private SimpleButton simpleButton1;
        private PopupMenu popupMenu1;
        private BarEditItem barEditItem2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private BarEditItem barEditItem3;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private BindingSource iTEMGROUPBindingSource;

    }
}