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
    partial class FrmStockComparision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockComparision));
            this.colSTORE01 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.progressBar1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.sTOREMASTDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPPLIERNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colITEMNO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRGEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPURQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.pURCHASEREQUESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPurchase1 = new VIRETAILENTITIES.DsPurchase();
            this.iTEMMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEREQUESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colSTORE01
            // 
            this.colSTORE01.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE01.AppearanceCell.Options.UseFont = true;
            this.colSTORE01.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE01.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE01.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE01.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE01.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE01.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE01.Caption = "Qty";
            this.colSTORE01.FieldName = "Qty";
            this.colSTORE01.MaxWidth = 60;
            this.colSTORE01.Name = "colSTORE01";
            this.colSTORE01.OptionsColumn.AllowEdit = false;
            this.colSTORE01.OptionsColumn.ReadOnly = true;
            this.colSTORE01.Visible = true;
            this.colSTORE01.VisibleIndex = 6;
            this.colSTORE01.Width = 60;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem6,
            this.barButtonItem7,
            this.progressBar1,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem11,
            this.barButtonItem12});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 16;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem8, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Print";
            this.barButtonItem2.Glyph = global::Store.Properties.Resources.printer1;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Show Purchase History - F8";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.date_magnify;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Collapse all";
            this.barButtonItem8.Glyph = global::Store.Properties.Resources.listadd;
            this.barButtonItem8.Id = 11;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem12, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.progressBar1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Save Purchase Request";
            this.barButtonItem6.Glyph = global::Store.Properties.Resources.Save16;
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Print P.R List";
            this.barButtonItem12.Id = 15;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.progressBar1.Caption = "barEditItem1";
            this.progressBar1.Edit = this.repositoryItemProgressBar1;
            this.progressBar1.Id = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Width = 550;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.LookAndFeel.SkinName = "Office 2013";
            this.repositoryItemProgressBar1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(919, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 395);
            this.barDockControlBottom.Size = new System.Drawing.Size(919, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 371);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(919, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 371);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Generate P.O";
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 12;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barButtonItem11.Caption = "barButtonItem11";
            this.barButtonItem11.Id = 14;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lookUpEdit2);
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 31);
            this.panel1.TabIndex = 13;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(273, 7);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBNAME", "DBNAME", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookUpEdit2.Properties.DataSource = this.sTOREMASTDBBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "STORENAME";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.ShowHeader = false;
            this.lookUpEdit2.Properties.ValueMember = "DBNAME";
            this.lookUpEdit2.Size = new System.Drawing.Size(143, 20);
            this.lookUpEdit2.TabIndex = 25;
            // 
            // sTOREMASTDBBindingSource
            // 
            this.sTOREMASTDBBindingSource.DataMember = "STOREMASTDB";
            this.sTOREMASTDBBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(53, 7);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBNAME", "DBNAME", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookUpEdit1.Properties.DataSource = this.sTOREMASTDBBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "STORENAME";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.ValueMember = "DBNAME";
            this.lookUpEdit1.Size = new System.Drawing.Size(129, 20);
            this.lookUpEdit1.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Store :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(189, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Compare Store :";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::Store.Properties.Resources.run;
            this.simpleButton4.Location = new System.Drawing.Point(422, 6);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(83, 23);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Create";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 106);
            this.panel2.TabIndex = 28;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(3, 6);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl2.Size = new System.Drawing.Size(919, 100);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRNO,
            this.colCOMPANY,
            this.colSUPPLIERNO,
            this.colITEMNO1,
            this.colQTY,
            this.colREQDATE,
            this.colUSERID,
            this.colINORDER});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowHeight = 24;
            // 
            // colPRNO
            // 
            this.colPRNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRNO.AppearanceCell.Options.UseFont = true;
            this.colPRNO.AppearanceCell.Options.UseTextOptions = true;
            this.colPRNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRNO.AppearanceHeader.Options.UseFont = true;
            this.colPRNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRNO.Caption = "P.R No.";
            this.colPRNO.FieldName = "PRNO";
            this.colPRNO.MaxWidth = 80;
            this.colPRNO.Name = "colPRNO";
            this.colPRNO.Visible = true;
            this.colPRNO.VisibleIndex = 0;
            this.colPRNO.Width = 80;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceCell.Options.UseFont = true;
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceHeader.Options.UseFont = true;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            // 
            // colSUPPLIERNO
            // 
            this.colSUPPLIERNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPPLIERNO.AppearanceCell.Options.UseFont = true;
            this.colSUPPLIERNO.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPPLIERNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPPLIERNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPPLIERNO.AppearanceHeader.Options.UseFont = true;
            this.colSUPPLIERNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPPLIERNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPPLIERNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPPLIERNO.Caption = "Supplier name";
            this.colSUPPLIERNO.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colSUPPLIERNO.FieldName = "SUPPLIERNO";
            this.colSUPPLIERNO.Name = "colSUPPLIERNO";
            this.colSUPPLIERNO.Visible = true;
            this.colSUPPLIERNO.VisibleIndex = 1;
            this.colSUPPLIERNO.Width = 280;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "SUPPLIERNAME";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "SUPPLIERNO";
            // 
            // colITEMNO1
            // 
            this.colITEMNO1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO1.AppearanceCell.Options.UseFont = true;
            this.colITEMNO1.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO1.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO1.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.Caption = "Item no";
            this.colITEMNO1.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colITEMNO1.FieldName = "ITEMNO";
            this.colITEMNO1.Name = "colITEMNO1";
            this.colITEMNO1.Visible = true;
            this.colITEMNO1.VisibleIndex = 2;
            this.colITEMNO1.Width = 360;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "ITEMNO";
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
            this.colQTY.Caption = "Req.Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.MaxWidth = 80;
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 80;
            // 
            // colREQDATE
            // 
            this.colREQDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREQDATE.AppearanceCell.Options.UseFont = true;
            this.colREQDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colREQDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREQDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREQDATE.AppearanceHeader.Options.UseFont = true;
            this.colREQDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colREQDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREQDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREQDATE.Caption = "Req. Date";
            this.colREQDATE.FieldName = "REQDATE";
            this.colREQDATE.MaxWidth = 90;
            this.colREQDATE.Name = "colREQDATE";
            this.colREQDATE.Visible = true;
            this.colREQDATE.VisibleIndex = 4;
            this.colREQDATE.Width = 90;
            // 
            // colUSERID
            // 
            this.colUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceCell.Options.UseFont = true;
            this.colUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceHeader.Options.UseFont = true;
            this.colUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            // 
            // colINORDER
            // 
            this.colINORDER.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINORDER.AppearanceCell.Options.UseFont = true;
            this.colINORDER.AppearanceCell.Options.UseTextOptions = true;
            this.colINORDER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINORDER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINORDER.AppearanceHeader.Options.UseFont = true;
            this.colINORDER.AppearanceHeader.Options.UseTextOptions = true;
            this.colINORDER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINORDER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINORDER.FieldName = "INORDER";
            this.colINORDER.Name = "colINORDER";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(919, 234);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCategory,
            this.colSuppliername,
            this.colPRGEN,
            this.colItemname,
            this.colItemno,
            this.colbarcode,
            this.colPURQTY,
            this.colSTORE01});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colItemCategory, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colItemname, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colItemCategory
            // 
            this.colItemCategory.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemCategory.AppearanceCell.Options.UseFont = true;
            this.colItemCategory.AppearanceCell.Options.UseTextOptions = true;
            this.colItemCategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemCategory.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemCategory.FieldName = "GROUPNAME";
            this.colItemCategory.Name = "colItemCategory";
            this.colItemCategory.OptionsColumn.AllowEdit = false;
            this.colItemCategory.OptionsColumn.ReadOnly = true;
            this.colItemCategory.Visible = true;
            this.colItemCategory.VisibleIndex = 1;
            // 
            // colSuppliername
            // 
            this.colSuppliername.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSuppliername.AppearanceCell.Options.UseFont = true;
            this.colSuppliername.AppearanceCell.Options.UseTextOptions = true;
            this.colSuppliername.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSuppliername.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuppliername.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliername.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSuppliername.FieldName = "SUPPLIERNAME";
            this.colSuppliername.Name = "colSuppliername";
            this.colSuppliername.OptionsColumn.AllowEdit = false;
            this.colSuppliername.OptionsColumn.ReadOnly = true;
            this.colSuppliername.Visible = true;
            this.colSuppliername.VisibleIndex = 1;
            // 
            // colPRGEN
            // 
            this.colPRGEN.Caption = "In. P.R";
            this.colPRGEN.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colPRGEN.FieldName = "PRGEN";
            this.colPRGEN.MaxWidth = 25;
            this.colPRGEN.Name = "colPRGEN";
            this.colPRGEN.Visible = true;
            this.colPRGEN.VisibleIndex = 0;
            this.colPRGEN.Width = 41;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            // 
            // colItemname
            // 
            this.colItemname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemname.AppearanceCell.Options.UseFont = true;
            this.colItemname.AppearanceCell.Options.UseTextOptions = true;
            this.colItemname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.Caption = "Item Name";
            this.colItemname.FieldName = "ITEMNAME";
            this.colItemname.MaxWidth = 350;
            this.colItemname.Name = "colItemname";
            this.colItemname.OptionsColumn.AllowEdit = false;
            this.colItemname.OptionsColumn.ReadOnly = true;
            this.colItemname.Visible = true;
            this.colItemname.VisibleIndex = 2;
            this.colItemname.Width = 350;
            // 
            // colItemno
            // 
            this.colItemno.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemno.AppearanceCell.Options.UseFont = true;
            this.colItemno.AppearanceCell.Options.UseTextOptions = true;
            this.colItemno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemno.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.Caption = "Item No.";
            this.colItemno.FieldName = "ITEMNO";
            this.colItemno.MaxWidth = 150;
            this.colItemno.Name = "colItemno";
            this.colItemno.OptionsColumn.AllowEdit = false;
            this.colItemno.OptionsColumn.ReadOnly = true;
            this.colItemno.Visible = true;
            this.colItemno.VisibleIndex = 3;
            this.colItemno.Width = 150;
            // 
            // colbarcode
            // 
            this.colbarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbarcode.AppearanceCell.Options.UseFont = true;
            this.colbarcode.AppearanceCell.Options.UseTextOptions = true;
            this.colbarcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbarcode.AppearanceHeader.Options.UseTextOptions = true;
            this.colbarcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbarcode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbarcode.Caption = "Barcode";
            this.colbarcode.FieldName = "BARCODE";
            this.colbarcode.MaxWidth = 150;
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.OptionsColumn.ReadOnly = true;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 4;
            this.colbarcode.Width = 150;
            // 
            // colPURQTY
            // 
            this.colPURQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPURQTY.AppearanceCell.Options.UseFont = true;
            this.colPURQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colPURQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPURQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colPURQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPURQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURQTY.Caption = "P.R Qty";
            this.colPURQTY.FieldName = "PURQTY";
            this.colPURQTY.MaxWidth = 50;
            this.colPURQTY.Name = "colPURQTY";
            this.colPURQTY.Visible = true;
            this.colPURQTY.VisibleIndex = 5;
            this.colPURQTY.Width = 50;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pURCHASEREQUESTBindingSource
            // 
            this.pURCHASEREQUESTBindingSource.DataMember = "PURCHASEREQUEST";
            this.pURCHASEREQUESTBindingSource.DataSource = this.dsPurchase1;
            // 
            // dsPurchase1
            // 
            this.dsPurchase1.DataSetName = "DsPurchase";
            this.dsPurchase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMMASTBindingSource
            // 
            this.iTEMMASTBindingSource.DataMember = "ITEMMAST";
            this.iTEMMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // FrmStockComparision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 422);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStockComparision";
            this.Text = "Stock Comparision";
            this.Load += new System.EventHandler(this.FrmStockComparision_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStockComparision_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEREQUESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BarManager barManager1;
        private Bar bar2;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem8;
        private Bar bar3;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem12;
        private BarEditItem progressBar1;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem7;
        private BarButtonItem barButtonItem9;
        private BarButtonItem barButtonItem11;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private Panel panel1;
        private LabelControl labelControl1;
        private SimpleButton simpleButton4;
        private Panel panel2;
        private GridControl gridControl2;
        private GridView gridView2;
        private GridColumn colPRNO;
        private GridColumn colCOMPANY;
        private GridColumn colSUPPLIERNO;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private GridColumn colITEMNO1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private GridColumn colQTY;
        private GridColumn colREQDATE;
        private GridColumn colUSERID;
        private GridColumn colINORDER;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colItemCategory;
        private GridColumn colSuppliername;
        private GridColumn colPRGEN;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private GridColumn colItemname;
        private GridColumn colItemno;
        private GridColumn colbarcode;
        private GridColumn colPURQTY;
        private GridColumn colSTORE01;
        private DsMaster dsMaster1;
        private BindingSource sTOREMASTDBBindingSource;
        private BindingSource pURCHASEREQUESTBindingSource;
        private DsPurchase dsPurchase1;
        private BindingSource iTEMMASTBindingSource;
        private LabelControl labelControl2;
        private LookUpEdit lookUpEdit2;
        private LookUpEdit lookUpEdit1;
    }
}