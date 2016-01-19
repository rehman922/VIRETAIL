using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace Store
{
    partial class YearEndProcess
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearEndProcess));
            this.colNOMASTER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.errorflg = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.txtitemsnomaster = new DevExpress.XtraBars.BarButtonItem();
            this.txtitemsnosprice = new DevExpress.XtraBars.BarButtonItem();
            this.txtitemsnocprice = new DevExpress.XtraBars.BarButtonItem();
            this.txtstockdifference = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgrpid = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtexpdate = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.txxitemname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.sPCPRICEFROMHISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lookupfrom = new DevExpress.XtraEditors.LookUpEdit();
            this.yearEndInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMGROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHYSICALSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACHINENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANSFERED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colINVENTORYYEAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridISADDED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrpid.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtexpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCPRICEFROMHISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupfrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearEndInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colNOMASTER
            // 
            this.colNOMASTER.AppearanceCell.Options.UseTextOptions = true;
            this.colNOMASTER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOMASTER.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOMASTER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOMASTER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOMASTER.FieldName = "NOMASTER";
            this.colNOMASTER.Name = "colNOMASTER";
            this.colNOMASTER.OptionsColumn.AllowEdit = false;
            this.colNOMASTER.OptionsColumn.ReadOnly = true;
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.Caption = "C.Price";
            this.colCPRICE.DisplayFormat.FormatString = "###,###.00";
            this.colCPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.Visible = true;
            this.colCPRICE.VisibleIndex = 7;
            this.colCPRICE.Width = 50;
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
            this.barButtonItem3,
            this.barButtonItem4,
            this.barEditItem1,
            this.txtitemsnomaster,
            this.txtitemsnosprice,
            this.txtitemsnocprice,
            this.txtstockdifference,
            this.barButtonItem1,
            this.errorflg,
            this.barButtonItem2,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 23;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem8, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.errorflg, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Read Stock File";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.document_list;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Get Prices From Hist.";
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.run;
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Validate Data";
            this.barButtonItem4.Glyph = global::Store.Properties.Resources.OK16;
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Upload Stock";
            this.barButtonItem5.Enabled = false;
            this.barButtonItem5.Glyph = global::Store.Properties.Resources.upreport;
            this.barButtonItem5.Id = 14;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Update Opening";
            this.barButtonItem8.Glyph = global::Store.Properties.Resources.grayball;
            this.barButtonItem8.Id = 18;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // errorflg
            // 
            this.errorflg.Caption = "***Please Fix the issues***";
            this.errorflg.Glyph = global::Store.Properties.Resources.error1;
            this.errorflg.Id = 12;
            this.errorflg.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.errorflg.ItemAppearance.Normal.Options.UseForeColor = true;
            this.errorflg.Name = "errorflg";
            this.errorflg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.errorflg_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Update Grid";
            this.barButtonItem10.Id = 20;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Clear All";
            this.barButtonItem9.Id = 19;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "GetQtyExpFrm";
            this.barButtonItem11.Id = 21;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.txtitemsnomaster, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtitemsnosprice, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtitemsnocprice, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtstockdifference, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem12, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem7, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // txtitemsnomaster
            // 
            this.txtitemsnomaster.Caption = "Items with out master";
            this.txtitemsnomaster.Id = 5;
            this.txtitemsnomaster.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemsnomaster.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.txtitemsnomaster.ItemAppearance.Normal.Options.UseFont = true;
            this.txtitemsnomaster.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtitemsnomaster.Name = "txtitemsnomaster";
            this.txtitemsnomaster.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.txtitemsnomaster_ItemClick);
            // 
            // txtitemsnosprice
            // 
            this.txtitemsnosprice.Caption = "Items with out S.Price";
            this.txtitemsnosprice.Id = 6;
            this.txtitemsnosprice.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemsnosprice.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.txtitemsnosprice.ItemAppearance.Normal.Options.UseFont = true;
            this.txtitemsnosprice.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtitemsnosprice.Name = "txtitemsnosprice";
            this.txtitemsnosprice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.txtitemsnosprice_ItemClick);
            // 
            // txtitemsnocprice
            // 
            this.txtitemsnocprice.Caption = "Items with out C.Price";
            this.txtitemsnocprice.Id = 7;
            this.txtitemsnocprice.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemsnocprice.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Teal;
            this.txtitemsnocprice.ItemAppearance.Normal.Options.UseFont = true;
            this.txtitemsnocprice.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtitemsnocprice.Name = "txtitemsnocprice";
            this.txtitemsnocprice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.txtitemsnocprice_ItemClick);
            // 
            // txtstockdifference
            // 
            this.txtstockdifference.Caption = "Stock differences ";
            this.txtstockdifference.Id = 9;
            this.txtstockdifference.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockdifference.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtstockdifference.ItemAppearance.Normal.Options.UseFont = true;
            this.txtstockdifference.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtstockdifference.Name = "txtstockdifference";
            this.txtstockdifference.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.txtstockdifference_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Manually added";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Show all";
            this.barButtonItem6.Id = 16;
            this.barButtonItem6.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem6.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Purple;
            this.barButtonItem6.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem6.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Zero Qty";
            this.barButtonItem12.Id = 22;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Print";
            this.barButtonItem7.Glyph = global::Store.Properties.Resources.printer1;
            this.barButtonItem7.Id = 17;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemProgressBar1;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 150;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1088, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
            this.barDockControlBottom.Size = new System.Drawing.Size(1088, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 457);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1088, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 457);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtgrpid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lookupfrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 55);
            this.panel1.TabIndex = 9;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(54, 30);
            this.dateEdit1.MenuManager = this.barManager1;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Properties.Mask.EditMask = "g";
            this.dateEdit1.Size = new System.Drawing.Size(92, 20);
            this.dateEdit1.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Opening :";
            // 
            // txtgrpid
            // 
            this.txtgrpid.Location = new System.Drawing.Point(161, 30);
            this.txtgrpid.MenuManager = this.barManager1;
            this.txtgrpid.Name = "txtgrpid";
            this.txtgrpid.Properties.Mask.EditMask = "n0";
            this.txtgrpid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtgrpid.Properties.Mask.ShowPlaceHolders = false;
            this.txtgrpid.Properties.MaxLength = 4;
            this.txtgrpid.Size = new System.Drawing.Size(56, 20);
            this.txtgrpid.TabIndex = 48;
            this.txtgrpid.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.textEdit1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtexpdate);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txxitemname);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtbarcode);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lookUpEdit1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtstock);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(220, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 52);
            this.panel2.TabIndex = 46;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(794, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 28);
            this.button3.TabIndex = 60;
            this.button3.Text = "Price Diff";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(672, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "(DD-YYYY)";
            // 
            // txtexpdate
            // 
            this.txtexpdate.EnterMoveNextControl = true;
            this.txtexpdate.Location = new System.Drawing.Point(581, 3);
            this.txtexpdate.MenuManager = this.barManager1;
            this.txtexpdate.Name = "txtexpdate";
            this.txtexpdate.Properties.Mask.EditMask = "d";
            this.txtexpdate.Properties.Mask.ShowPlaceHolders = false;
            this.txtexpdate.Properties.MaxLength = 7;
            this.txtexpdate.Size = new System.Drawing.Size(88, 20);
            this.txtexpdate.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Image = global::Store.Properties.Resources.page_white_star16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(256, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Clear";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txxitemname
            // 
            this.txxitemname.Location = new System.Drawing.Point(60, 27);
            this.txxitemname.Name = "txxitemname";
            this.txxitemname.Size = new System.Drawing.Size(229, 20);
            this.txxitemname.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(401, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Manf no :";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(455, 27);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(214, 20);
            this.txtbarcode.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Name . :";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EnterMoveNextControl = true;
            this.lookUpEdit1.Location = new System.Drawing.Point(455, 3);
            this.lookUpEdit1.MenuManager = this.barManager1;
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPRICE", "S.Price", 59, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CPRICE", "C.Price", 47, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("INVDT", "Inv.Dt.", 23, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.sPCPRICEFROMHISTBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "SPRICE";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ShowFooter = false;
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "SPRICE";
            this.lookUpEdit1.Size = new System.Drawing.Size(88, 20);
            this.lookUpEdit1.TabIndex = 2;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // sPCPRICEFROMHISTBindingSource
            // 
            this.sPCPRICEFROMHISTBindingSource.DataMember = "SPCPRICEFROMHIST";
            this.sPCPRICEFROMHISTBindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(401, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "S.Price :";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(726, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(542, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Exp Dt:";
            // 
            // txtstock
            // 
            this.txtstock.EnterMoveNextControl = true;
            this.txtstock.Location = new System.Drawing.Point(351, 4);
            this.txtstock.MenuManager = this.barManager1;
            this.txtstock.Name = "txtstock";
            this.txtstock.Properties.Mask.EditMask = "n0";
            this.txtstock.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtstock.Properties.Mask.ShowPlaceHolders = false;
            this.txtstock.Properties.MaxLength = 4;
            this.txtstock.Size = new System.Drawing.Size(48, 20);
            this.txtstock.TabIndex = 1;
            this.txtstock.EditValueChanged += new System.EventHandler(this.txtstock_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(307, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Stock :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Item no. :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Store :";
            // 
            // lookupfrom
            // 
            this.lookupfrom.Location = new System.Drawing.Point(44, 6);
            this.lookupfrom.Name = "lookupfrom";
            this.lookupfrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupfrom.Properties.Appearance.Options.UseFont = true;
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
            this.lookupfrom.Size = new System.Drawing.Size(173, 20);
            this.lookupfrom.TabIndex = 42;
            // 
            // yearEndInventoryBindingSource
            // 
            this.yearEndInventoryBindingSource.DataMember = "YearEndInventory";
            this.yearEndInventoryBindingSource.DataSource = typeof(VIRETAILENTITIES.DsInventory);
            // 
            // iTEMGROUPBindingSource
            // 
            this.iTEMGROUPBindingSource.DataMember = "ITEMGROUP";
            this.iTEMGROUPBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.yearEndInventoryBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1088, 402);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colITEMNO,
            this.colBARCODE,
            this.colITEMNAME,
            this.colINSTOCK,
            this.colPHYSICALSTOCK,
            this.colEXPDATE,
            this.colSPRICE,
            this.colCPRICE,
            this.colCDATE,
            this.colNOMASTER,
            this.colMACHINENO,
            this.colMUSER,
            this.colTRANSFERED,
            this.colGroupid,
            this.colINVENTORYYEAR,
            this.gridISADDED});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colNOMASTER;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colCPRICE;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = 0D;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Teal;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colCPRICE;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ITEMNO", this.colITEMNO, "Count {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PHYSICALSTOCK", this.colPHYSICALSTOCK, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SPRICE", this.colSPRICE, "{0:###,####,###.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CPRICE", this.colCPRICE, "{0:###,####,###.00}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroupid, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gridView1_CustomSummaryCalculate);
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
            this.colTID.Visible = true;
            this.colTID.VisibleIndex = 10;
            this.colTID.Width = 108;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Item No.";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.ReadOnly = true;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 0;
            this.colITEMNO.Width = 115;
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
            this.colBARCODE.OptionsColumn.ReadOnly = true;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 1;
            this.colBARCODE.Width = 186;
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
            this.colITEMNAME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "ITEMNAME", "", "1")});
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 2;
            this.colITEMNAME.Width = 265;
            // 
            // colINSTOCK
            // 
            this.colINSTOCK.AppearanceCell.Options.UseTextOptions = true;
            this.colINSTOCK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINSTOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.colINSTOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINSTOCK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINSTOCK.Caption = "In Stock";
            this.colINSTOCK.FieldName = "INSTOCK";
            this.colINSTOCK.Name = "colINSTOCK";
            this.colINSTOCK.OptionsColumn.AllowEdit = false;
            this.colINSTOCK.OptionsColumn.ReadOnly = true;
            this.colINSTOCK.Visible = true;
            this.colINSTOCK.VisibleIndex = 3;
            this.colINSTOCK.Width = 52;
            // 
            // colPHYSICALSTOCK
            // 
            this.colPHYSICALSTOCK.AppearanceCell.Options.UseTextOptions = true;
            this.colPHYSICALSTOCK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHYSICALSTOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHYSICALSTOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHYSICALSTOCK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHYSICALSTOCK.Caption = "Actual";
            this.colPHYSICALSTOCK.FieldName = "PHYSICALSTOCK";
            this.colPHYSICALSTOCK.Name = "colPHYSICALSTOCK";
            this.colPHYSICALSTOCK.Visible = true;
            this.colPHYSICALSTOCK.VisibleIndex = 4;
            this.colPHYSICALSTOCK.Width = 42;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.Caption = "Exp.Dt.";
            this.colEXPDATE.DisplayFormat.FormatString = "MM-yyyy";
            this.colEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.VisibleIndex = 5;
            this.colEXPDATE.Width = 49;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.Caption = "S.Price";
            this.colSPRICE.DisplayFormat.FormatString = "###,###.00";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 6;
            this.colSPRICE.Width = 59;
            // 
            // colCDATE
            // 
            this.colCDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colCDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCDATE.FieldName = "CDATE";
            this.colCDATE.Name = "colCDATE";
            this.colCDATE.OptionsColumn.AllowEdit = false;
            this.colCDATE.OptionsColumn.ReadOnly = true;
            // 
            // colMACHINENO
            // 
            this.colMACHINENO.AppearanceCell.Options.UseTextOptions = true;
            this.colMACHINENO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMACHINENO.AppearanceHeader.Options.UseTextOptions = true;
            this.colMACHINENO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMACHINENO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMACHINENO.Caption = "Mach.No.";
            this.colMACHINENO.FieldName = "MACHINENO";
            this.colMACHINENO.Name = "colMACHINENO";
            this.colMACHINENO.OptionsColumn.AllowEdit = false;
            this.colMACHINENO.OptionsColumn.ReadOnly = true;
            this.colMACHINENO.Width = 56;
            // 
            // colMUSER
            // 
            this.colMUSER.AppearanceCell.Options.UseTextOptions = true;
            this.colMUSER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMUSER.AppearanceHeader.Options.UseTextOptions = true;
            this.colMUSER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMUSER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMUSER.Caption = "Taken By";
            this.colMUSER.FieldName = "MUSER";
            this.colMUSER.Name = "colMUSER";
            this.colMUSER.OptionsColumn.AllowEdit = false;
            this.colMUSER.OptionsColumn.ReadOnly = true;
            this.colMUSER.Visible = true;
            this.colMUSER.VisibleIndex = 8;
            this.colMUSER.Width = 84;
            // 
            // colTRANSFERED
            // 
            this.colTRANSFERED.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANSFERED.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANSFERED.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANSFERED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANSFERED.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANSFERED.Caption = "Transfered";
            this.colTRANSFERED.FieldName = "TRANSFERED";
            this.colTRANSFERED.MaxWidth = 60;
            this.colTRANSFERED.Name = "colTRANSFERED";
            this.colTRANSFERED.OptionsColumn.AllowEdit = false;
            this.colTRANSFERED.OptionsColumn.ReadOnly = true;
            this.colTRANSFERED.Visible = true;
            this.colTRANSFERED.VisibleIndex = 9;
            this.colTRANSFERED.Width = 60;
            // 
            // colGroupid
            // 
            this.colGroupid.AppearanceCell.Options.UseTextOptions = true;
            this.colGroupid.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGroupid.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroupid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroupid.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGroupid.Caption = "Group";
            this.colGroupid.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colGroupid.FieldName = "Groupid";
            this.colGroupid.Name = "colGroupid";
            this.colGroupid.OptionsColumn.AllowEdit = false;
            this.colGroupid.OptionsColumn.ReadOnly = true;
            this.colGroupid.Visible = true;
            this.colGroupid.VisibleIndex = 14;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.iTEMGROUPBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "GROUPNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "GROUPID";
            // 
            // colINVENTORYYEAR
            // 
            this.colINVENTORYYEAR.AppearanceCell.Options.UseTextOptions = true;
            this.colINVENTORYYEAR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVENTORYYEAR.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVENTORYYEAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVENTORYYEAR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVENTORYYEAR.FieldName = "INVENTORYYEAR";
            this.colINVENTORYYEAR.Name = "colINVENTORYYEAR";
            this.colINVENTORYYEAR.OptionsColumn.AllowEdit = false;
            this.colINVENTORYYEAR.OptionsColumn.ReadOnly = true;
            // 
            // gridISADDED
            // 
            this.gridISADDED.FieldName = "ISADDED";
            this.gridISADDED.Name = "gridISADDED";
            this.gridISADDED.OptionsColumn.AllowEdit = false;
            this.gridISADDED.OptionsColumn.ShowCaption = false;
            this.gridISADDED.Width = 41;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(353, 155);
            this.progressPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(283, 70);
            this.progressPanel1.TabIndex = 20;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(288, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Old Stock :";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "0";
            this.textEdit1.Enabled = false;
            this.textEdit1.EnterMoveNextControl = true;
            this.textEdit1.Location = new System.Drawing.Point(351, 28);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "n0";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit1.Properties.MaxLength = 4;
            this.textEdit1.Properties.NullText = "0";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(48, 20);
            this.textEdit1.TabIndex = 62;
            // 
            // YearEndProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 508);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YearEndProcess";
            this.Text = "Year End Process";
            this.Load += new System.EventHandler(this.YearEndProcess_Load);
            this.Resize += new System.EventHandler(this.YearEndProcess_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrpid.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtexpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCPRICEFROMHISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupfrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearEndInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BarManager barManager1;
        private Bar bar2;
        private BarButtonItem barButtonItem3;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem4;
        private BarEditItem barEditItem1;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private BindingSource yearEndInventoryBindingSource;
        private BindingSource iTEMGROUPBindingSource;
        private BarButtonItem txtitemsnomaster;
        private BarButtonItem txtitemsnosprice;
        private BarButtonItem txtitemsnocprice;
        private BarButtonItem txtstockdifference;
        private Label label2;
        protected LookUpEdit lookupfrom;
        private BarButtonItem barButtonItem1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colTID;
        private GridColumn colITEMNO;
        private GridColumn colBARCODE;
        private GridColumn colITEMNAME;
        private GridColumn colINSTOCK;
        private GridColumn colPHYSICALSTOCK;
        private GridColumn colEXPDATE;
        private GridColumn colSPRICE;
        private GridColumn colCPRICE;
        private GridColumn colCDATE;
        private GridColumn colNOMASTER;
        private GridColumn colMACHINENO;
        private GridColumn colMUSER;
        private GridColumn colTRANSFERED;
        private GridColumn colGroupid;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridColumn colINVENTORYYEAR;
        private Button button1;
        private Panel panel2;
        private BarButtonItem errorflg;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextEdit txtstock;
        private Label label4;
        private Label label5;
        private LookUpEdit lookUpEdit1;
        private BindingSource sPCPRICEFROMHISTBindingSource;
        private TextBox txxitemname;
        private Label label7;
        private TextBox txtbarcode;
        private Label label6;
        private Button button2;
        private TextEdit txtgrpid;
        private GridColumn gridISADDED;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private BarButtonItem barButtonItem8;
        private ProgressPanel progressPanel1;
        private DateEdit dateEdit1;
        private Label label8;
        private Label label9;
        private TextEdit txtexpdate;
        private BarButtonItem barButtonItem9;
        private BarButtonItem barButtonItem10;
        private BarButtonItem barButtonItem11;
        private BarButtonItem barButtonItem12;
        private Button button3;
        private TextEdit textEdit1;
        private Label label10;
    }
}