using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;
using VIRETAILENTITIES;

namespace Store
{
    partial class RetailSales1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetailSales1));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.staticdoctor = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.two = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barcomp = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.txtinvoiceno = new DevExpress.XtraBars.BarStaticItem();
            this.lookupcashier = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtcustomer = new DevExpress.XtraEditors.TextEdit();
            this.txtbarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelnormalcustomer = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtcrlimit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtfixdis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtavailble = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.panelinsurance = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtpatname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.cutomerpayment = new DevExpress.XtraEditors.TextEdit();
            this.cmbclass = new DevExpress.XtraEditors.LookUpEdit();
            this.iNSURANCEDISCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtvisitno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtfileno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lookupcustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtqty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblmutilpleprice = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelmaxdisc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtnetins = new DevExpress.XtraEditors.TextEdit();
            this.txtreturnamt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtrounding = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtdiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.subtotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtdiscper = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtnetamt = new DevExpress.XtraEditors.TextEdit();
            this.lblcustomeronhold = new DevExpress.XtraWaitForm.ProgressPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sALESINVDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventory1 = new VIRETAILENTITIES.DsInventory();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colLINETOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISRETURN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBONUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXTDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOCTORID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISCONSALE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.iTEMMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).BeginInit();
            this.panelnormalcustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcrlimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfixdis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtavailble.Properties)).BeginInit();
            this.panelinsurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpatname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutomerpayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbclass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSURANCEDISCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvisitno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfileno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupcustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnetins.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtreturnamt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrounding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiscper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnetamt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESINVDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceCell.Options.UseFont = true;
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Qty";
            this.colQTY.ColumnEdit = this.repositoryItemTextEdit1;
            this.colQTY.CustomizationCaption = "Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQTY.OptionsFilter.AllowAutoFilter = false;
            this.colQTY.OptionsFilter.AllowFilter = false;
            this.colQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 2;
            this.colQTY.Width = 37;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.MaxLength = 3;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.staticdoctor,
            this.barStaticItem2,
            this.barStaticItem3,
            this.two,
            this.barStaticItem4,
            this.barcomp,
            this.barStaticItem5,
            this.txtinvoiceno,
            this.lookupcashier,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 28;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(840, 123);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Disc";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = global::Store.Properties.Resources.F1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "List";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = global::Store.Properties.Resources.F2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Clear";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.LargeGlyph = global::Store.Properties.Resources.F3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Print";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.LargeGlyph = global::Store.Properties.Resources.F4;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Qty";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.LargeGlyph = global::Store.Properties.Resources.F5;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Hold";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.LargeGlyph = global::Store.Properties.Resources.F6;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Charges";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.LargeGlyph = global::Store.Properties.Resources.F7;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Sale";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.LargeGlyph = global::Store.Properties.Resources.F9;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Find Item";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.LargeGlyph = global::Store.Properties.Resources.F10;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Customer";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.LargeGlyph = global::Store.Properties.Resources.F11;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Rounding";
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.LargeGlyph = global::Store.Properties.Resources.F12;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Return";
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.LargeGlyph = global::Store.Properties.Resources.F8;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FunctionKeys);
            // 
            // staticdoctor
            // 
            this.staticdoctor.Caption = "Click to Login";
            this.staticdoctor.Glyph = global::Store.Properties.Resources.doctor;
            this.staticdoctor.Id = 13;
            this.staticdoctor.Name = "staticdoctor";
            this.staticdoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.staticdoctor_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Lines";
            this.barStaticItem2.Id = 16;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barStaticItem3.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.barStaticItem3.Glyph = global::Store.Properties.Resources.One;
            this.barStaticItem3.Id = 17;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // two
            // 
            this.two.Glyph = global::Store.Properties.Resources.Two;
            this.two.Id = 18;
            this.two.Name = "two";
            this.two.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem4.Caption = "Store Code :";
            this.barStaticItem4.Id = 19;
            this.barStaticItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barcomp
            // 
            this.barcomp.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barcomp.Id = 20;
            this.barcomp.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcomp.ItemAppearance.Normal.Options.UseFont = true;
            this.barcomp.Name = "barcomp";
            this.barcomp.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barcomp.Width = 30;
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem5.Caption = "Invoice No. :";
            this.barStaticItem5.Id = 21;
            this.barStaticItem5.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem5.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem5.Name = "barStaticItem5";
            this.barStaticItem5.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtinvoiceno.Id = 22;
            this.txtinvoiceno.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoiceno.ItemAppearance.Normal.Options.UseFont = true;
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtinvoiceno.Width = 90;
            // 
            // lookupcashier
            // 
            this.lookupcashier.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lookupcashier.Caption = "Cashier :";
            this.lookupcashier.Edit = this.repositoryItemLookUpEdit1;
            this.lookupcashier.Id = 24;
            this.lookupcashier.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupcashier.ItemAppearance.Normal.Options.UseFont = true;
            this.lookupcashier.Name = "lookupcashier";
            this.lookupcashier.Width = 120;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERID", "USERID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME")});
            this.repositoryItemLookUpEdit1.DisplayMember = "FULLNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ReadOnly = true;
            this.repositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.repositoryItemLookUpEdit1.ShowFooter = false;
            this.repositoryItemLookUpEdit1.ShowHeader = false;
            this.repositoryItemLookUpEdit1.ValueMember = "USERID";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Receipt";
            this.barButtonItem13.Id = 25;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem14.Caption = "Shift Code :";
            this.barButtonItem14.Glyph = global::Store.Properties.Resources.grayball;
            this.barButtonItem14.Id = 26;
            this.barButtonItem14.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem14.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick_1);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Receipt";
            this.barButtonItem15.Glyph = global::Store.Properties.Resources.coins;
            this.barButtonItem15.Id = 27;
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "POS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem7, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem12, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem8, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem9, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem10, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem11, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Menu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.staticdoctor);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Doctor";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem3, true);
            this.ribbonStatusBar.ItemLinks.Add(this.two);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem14, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem4, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barcomp);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem5, true);
            this.ribbonStatusBar.ItemLinks.Add(this.txtinvoiceno);
            this.ribbonStatusBar.ItemLinks.Add(this.lookupcashier, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem15, true);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 535);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(840, 31);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtcustomer);
            this.panelControl1.Controls.Add(this.txtbarcode);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.panelnormalcustomer);
            this.panelControl1.Controls.Add(this.panelinsurance);
            this.panelControl1.Controls.Add(this.lookupcustomer);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 123);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(840, 96);
            this.panelControl1.TabIndex = 2;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(72, 5);
            this.txtcustomer.MenuManager = this.ribbon;
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(343, 20);
            this.txtcustomer.TabIndex = 108;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(72, 65);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtbarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtbarcode.Properties.Appearance.Options.UseBackColor = true;
            this.txtbarcode.Properties.Appearance.Options.UseFont = true;
            this.txtbarcode.Properties.Appearance.Options.UseForeColor = true;
            this.txtbarcode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtbarcode.Size = new System.Drawing.Size(343, 26);
            this.txtbarcode.TabIndex = 1;
            this.txtbarcode.EditValueChanged += new System.EventHandler(this.txtbarcode_EditValueChanged);
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(7, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 14);
            this.labelControl1.TabIndex = 107;
            this.labelControl1.Text = "Barcode :";
            // 
            // panelnormalcustomer
            // 
            this.panelnormalcustomer.BackColor = System.Drawing.Color.Transparent;
            this.panelnormalcustomer.Controls.Add(this.simpleButton2);
            this.panelnormalcustomer.Controls.Add(this.txtcrlimit);
            this.panelnormalcustomer.Controls.Add(this.labelControl21);
            this.panelnormalcustomer.Controls.Add(this.txtfixdis);
            this.panelnormalcustomer.Controls.Add(this.labelControl22);
            this.panelnormalcustomer.Controls.Add(this.labelControl17);
            this.panelnormalcustomer.Controls.Add(this.txtavailble);
            this.panelnormalcustomer.Controls.Add(this.labelControl18);
            this.panelnormalcustomer.Location = new System.Drawing.Point(4, 30);
            this.panelnormalcustomer.Name = "panelnormalcustomer";
            this.panelnormalcustomer.Size = new System.Drawing.Size(411, 31);
            this.panelnormalcustomer.TabIndex = 105;
            this.panelnormalcustomer.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(4, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(63, 22);
            this.simpleButton2.TabIndex = 61;
            this.simpleButton2.Text = "Points :";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtcrlimit
            // 
            this.txtcrlimit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcrlimit.Location = new System.Drawing.Point(351, 4);
            this.txtcrlimit.Name = "txtcrlimit";
            this.txtcrlimit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtcrlimit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrlimit.Properties.Appearance.Options.UseBackColor = true;
            this.txtcrlimit.Properties.Appearance.Options.UseFont = true;
            this.txtcrlimit.Properties.Appearance.Options.UseTextOptions = true;
            this.txtcrlimit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcrlimit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcrlimit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtcrlimit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtcrlimit.Properties.DisplayFormat.FormatString = "N2";
            this.txtcrlimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcrlimit.Properties.ReadOnly = true;
            this.txtcrlimit.Size = new System.Drawing.Size(56, 22);
            this.txtcrlimit.TabIndex = 60;
            this.txtcrlimit.TabStop = false;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Location = new System.Drawing.Point(294, 7);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(55, 14);
            this.labelControl21.TabIndex = 59;
            this.labelControl21.Text = "Cr Limit :";
            // 
            // txtfixdis
            // 
            this.txtfixdis.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtfixdis.Location = new System.Drawing.Point(237, 4);
            this.txtfixdis.Name = "txtfixdis";
            this.txtfixdis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfixdis.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtfixdis.Properties.Appearance.Options.UseFont = true;
            this.txtfixdis.Properties.Appearance.Options.UseForeColor = true;
            this.txtfixdis.Properties.Appearance.Options.UseTextOptions = true;
            this.txtfixdis.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtfixdis.Properties.DisplayFormat.FormatString = "##.00";
            this.txtfixdis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtfixdis.Properties.EditFormat.FormatString = "##.00";
            this.txtfixdis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtfixdis.Properties.NullText = "0";
            this.txtfixdis.Properties.NullValuePrompt = "0";
            this.txtfixdis.Size = new System.Drawing.Size(39, 22);
            this.txtfixdis.TabIndex = 58;
            this.txtfixdis.TabStop = false;
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Location = new System.Drawing.Point(152, 7);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(82, 14);
            this.labelControl22.TabIndex = 57;
            this.labelControl22.Text = "Fix Discount :";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(279, 8);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(12, 14);
            this.labelControl17.TabIndex = 56;
            this.labelControl17.Text = "%";
            // 
            // txtavailble
            // 
            this.txtavailble.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtavailble.Location = new System.Drawing.Point(68, 4);
            this.txtavailble.Name = "txtavailble";
            this.txtavailble.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtavailble.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavailble.Properties.Appearance.Options.UseBackColor = true;
            this.txtavailble.Properties.Appearance.Options.UseFont = true;
            this.txtavailble.Properties.Appearance.Options.UseTextOptions = true;
            this.txtavailble.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtavailble.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtavailble.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtavailble.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtavailble.Properties.DisplayFormat.FormatString = "n2";
            this.txtavailble.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtavailble.Properties.ReadOnly = true;
            this.txtavailble.Size = new System.Drawing.Size(69, 22);
            this.txtavailble.TabIndex = 51;
            this.txtavailble.TabStop = false;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(56, 3);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(0, 14);
            this.labelControl18.TabIndex = 50;
            // 
            // panelinsurance
            // 
            this.panelinsurance.BackColor = System.Drawing.Color.Transparent;
            this.panelinsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelinsurance.Controls.Add(this.simpleButton1);
            this.panelinsurance.Controls.Add(this.txtpatname);
            this.panelinsurance.Controls.Add(this.labelControl12);
            this.panelinsurance.Controls.Add(this.labelControl16);
            this.panelinsurance.Controls.Add(this.cutomerpayment);
            this.panelinsurance.Controls.Add(this.cmbclass);
            this.panelinsurance.Controls.Add(this.txtvisitno);
            this.panelinsurance.Controls.Add(this.labelControl19);
            this.panelinsurance.Controls.Add(this.labelControl15);
            this.panelinsurance.Controls.Add(this.txtfileno);
            this.panelinsurance.Controls.Add(this.labelControl10);
            this.panelinsurance.Location = new System.Drawing.Point(419, 5);
            this.panelinsurance.Name = "panelinsurance";
            this.panelinsurance.Size = new System.Drawing.Size(419, 86);
            this.panelinsurance.TabIndex = 65;
            this.panelinsurance.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(225, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(56, 20);
            this.simpleButton1.TabIndex = 62;
            this.simpleButton1.Text = "NEW";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtpatname
            // 
            this.txtpatname.Location = new System.Drawing.Point(72, 58);
            this.txtpatname.Name = "txtpatname";
            this.txtpatname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtpatname.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtpatname.Properties.Appearance.Options.UseBackColor = true;
            this.txtpatname.Properties.Appearance.Options.UseForeColor = true;
            this.txtpatname.Properties.MaxLength = 100;
            this.txtpatname.Size = new System.Drawing.Size(340, 20);
            this.txtpatname.TabIndex = 8;
            this.txtpatname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpatname_KeyDown);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Location = new System.Drawing.Point(2, 55);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(54, 32);
            this.labelControl12.TabIndex = 61;
            this.labelControl12.Text = "Patient name :";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl16.Location = new System.Drawing.Point(272, 24);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(71, 32);
            this.labelControl16.TabIndex = 56;
            this.labelControl16.Text = "Customer Share % :";
            this.labelControl16.Click += new System.EventHandler(this.labelControl16_Click);
            // 
            // cutomerpayment
            // 
            this.cutomerpayment.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cutomerpayment.EnterMoveNextControl = true;
            this.cutomerpayment.Location = new System.Drawing.Point(349, 28);
            this.cutomerpayment.Name = "cutomerpayment";
            this.cutomerpayment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutomerpayment.Properties.Appearance.Options.UseFont = true;
            this.cutomerpayment.Properties.Appearance.Options.UseTextOptions = true;
            this.cutomerpayment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cutomerpayment.Properties.DisplayFormat.FormatString = "##.00";
            this.cutomerpayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cutomerpayment.Properties.EditFormat.FormatString = "##.00";
            this.cutomerpayment.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cutomerpayment.Properties.NullText = "0";
            this.cutomerpayment.Properties.NullValuePrompt = "0";
            this.cutomerpayment.Size = new System.Drawing.Size(62, 22);
            this.cutomerpayment.TabIndex = 7;
            this.cutomerpayment.EditValueChanged += new System.EventHandler(this.cutomerpayment_EditValueChanged);
            this.cutomerpayment.Validated += new System.EventHandler(this.cutomerpayment_Validated);
            // 
            // cmbclass
            // 
            this.cmbclass.EnterMoveNextControl = true;
            this.cmbclass.Location = new System.Drawing.Point(349, 3);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclass.Properties.Appearance.Options.UseFont = true;
            this.cmbclass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbclass.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRADE", "GRADE", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DISC", "DISC", 5, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPDISC", "COMPDISC", 5, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTNO", "CUSTNO", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbclass.Properties.DataSource = this.iNSURANCEDISCBindingSource;
            this.cmbclass.Properties.DisplayMember = "GRADE";
            this.cmbclass.Properties.NullText = "";
            this.cmbclass.Properties.ValueMember = "GRADE";
            this.cmbclass.Size = new System.Drawing.Size(62, 20);
            this.cmbclass.TabIndex = 5;
            this.cmbclass.EditValueChanged += new System.EventHandler(this.cmbclass_EditValueChanged);
            // 
            // iNSURANCEDISCBindingSource
            // 
            this.iNSURANCEDISCBindingSource.DataMember = "INSURANCEDISC";
            this.iNSURANCEDISCBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // txtvisitno
            // 
            this.txtvisitno.EnterMoveNextControl = true;
            this.txtvisitno.Location = new System.Drawing.Point(72, 31);
            this.txtvisitno.Name = "txtvisitno";
            this.txtvisitno.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtvisitno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtvisitno.Properties.Appearance.Options.UseBackColor = true;
            this.txtvisitno.Properties.Appearance.Options.UseForeColor = true;
            this.txtvisitno.Properties.MaxLength = 10;
            this.txtvisitno.Size = new System.Drawing.Size(148, 20);
            this.txtvisitno.TabIndex = 6;
            this.txtvisitno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvisitno_KeyDown);
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Location = new System.Drawing.Point(2, 33);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(70, 14);
            this.labelControl19.TabIndex = 51;
            this.labelControl19.Text = "Member # :";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(305, 6);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(38, 14);
            this.labelControl15.TabIndex = 43;
            this.labelControl15.Text = "Class :";
            // 
            // txtfileno
            // 
            this.txtfileno.EnterMoveNextControl = true;
            this.txtfileno.Location = new System.Drawing.Point(72, 5);
            this.txtfileno.Name = "txtfileno";
            this.txtfileno.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtfileno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtfileno.Properties.Appearance.Options.UseBackColor = true;
            this.txtfileno.Properties.Appearance.Options.UseForeColor = true;
            this.txtfileno.Properties.MaxLength = 10;
            this.txtfileno.Size = new System.Drawing.Size(147, 20);
            this.txtfileno.TabIndex = 4;
            this.txtfileno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfileno_KeyDown);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(2, 7);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 14);
            this.labelControl10.TabIndex = 38;
            this.labelControl10.Text = "File # :";
            // 
            // lookupcustomer
            // 
            this.lookupcustomer.Location = new System.Drawing.Point(72, 5);
            this.lookupcustomer.Name = "lookupcustomer";
            this.lookupcustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupcustomer.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lookupcustomer.Properties.Appearance.Options.UseFont = true;
            this.lookupcustomer.Properties.Appearance.Options.UseForeColor = true;
            this.lookupcustomer.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.lookupcustomer.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupcustomer.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.lookupcustomer.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lookupcustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupcustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTNO", "CUSTNO", 64, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMERID", "Customer id", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMERNAME", "Customer Name", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMERTYPE", "CUSTOMERTYPE", 89, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTCOMP", "CUSTCOMP", 65, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PHONE", "PHONE", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mobile", "Mobile", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMAIL", "EMAIL", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOTE", "NOTE", 37, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FIXDISC", "FIXDISC", 50, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FIXDISCAMTPER", "FIXDISCAMTPER", 90, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CREDITLIMIT", "CREDITLIMIT", 74, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPANY", "COMPANY", 59, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BINID", "BINID", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSERID", "CUSERID", 54, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDATE", "CDATE", 43, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EUSERID", "EUSERID", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EDATE", "EDATE", 42, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SERVERPOINTS", "SERVERPOINTS", 96, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LASTREDIMINV", "LASTREDIMINV", 83, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYTYPE", "PAYTYPE", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lookupcustomer.Properties.DataSource = this.cUSTOMERBindingSource;
            this.lookupcustomer.Properties.DisplayMember = "CUSTOMERNAME";
            this.lookupcustomer.Properties.NullText = "";
            this.lookupcustomer.Properties.ReadOnly = true;
            this.lookupcustomer.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.lookupcustomer.Properties.ValueMember = "CUSTNO";
            this.lookupcustomer.Size = new System.Drawing.Size(343, 20);
            this.lookupcustomer.TabIndex = 3;
            this.lookupcustomer.EditValueChanged += new System.EventHandler(this.lookupcustomer_EditValueChanged);
            this.lookupcustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookupcustomer_KeyDown);
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(4, 8);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(67, 14);
            this.labelControl13.TabIndex = 104;
            this.labelControl13.Text = "Customer :";
            // 
            // txtqty
            // 
            this.txtqty.EditValue = "";
            this.txtqty.Location = new System.Drawing.Point(456, 24);
            this.txtqty.Name = "txtqty";
            this.txtqty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtqty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 17.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Properties.Appearance.Options.UseBackColor = true;
            this.txtqty.Properties.Appearance.Options.UseFont = true;
            this.txtqty.Properties.Appearance.Options.UseTextOptions = true;
            this.txtqty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtqty.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtqty.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtqty.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtqty.Properties.DisplayFormat.FormatString = "N2";
            this.txtqty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtqty.Properties.Mask.EditMask = "n0";
            this.txtqty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtqty.Size = new System.Drawing.Size(20, 34);
            this.txtqty.TabIndex = 109;
            this.txtqty.Visible = false;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(420, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 14);
            this.labelControl2.TabIndex = 108;
            this.labelControl2.Text = "Qty :";
            this.labelControl2.Visible = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtqty);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.lblmutilpleprice);
            this.panelControl3.Controls.Add(this.panel1);
            this.panelControl3.Controls.Add(this.lblcustomeronhold);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 420);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(840, 115);
            this.panelControl3.TabIndex = 7;
            // 
            // lblmutilpleprice
            // 
            this.lblmutilpleprice.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblmutilpleprice.Appearance.Options.UseBackColor = true;
            this.lblmutilpleprice.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmutilpleprice.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.lblmutilpleprice.AppearanceCaption.Options.UseFont = true;
            this.lblmutilpleprice.AppearanceCaption.Options.UseForeColor = true;
            this.lblmutilpleprice.AppearanceDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmutilpleprice.AppearanceDescription.ForeColor = System.Drawing.Color.Black;
            this.lblmutilpleprice.AppearanceDescription.Options.UseFont = true;
            this.lblmutilpleprice.AppearanceDescription.Options.UseForeColor = true;
            this.lblmutilpleprice.Caption = "Price difference found";
            this.lblmutilpleprice.Description = "[To check please press down arrow]";
            this.lblmutilpleprice.Location = new System.Drawing.Point(12, 8);
            this.lblmutilpleprice.LookAndFeel.SkinName = "McSkin";
            this.lblmutilpleprice.Name = "lblmutilpleprice";
            this.lblmutilpleprice.Size = new System.Drawing.Size(355, 48);
            this.lblmutilpleprice.TabIndex = 8;
            this.lblmutilpleprice.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Store.Properties.Resources.subtlemosaicpattern;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelmaxdisc);
            this.panel1.Controls.Add(this.labelControl20);
            this.panel1.Controls.Add(this.txtnetins);
            this.panel1.Controls.Add(this.txtreturnamt);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.txtrounding);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.subtotal);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtdiscper);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtnetamt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(492, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 111);
            this.panel1.TabIndex = 1;
            // 
            // labelmaxdisc
            // 
            this.labelmaxdisc.Appearance.BackColor = System.Drawing.Color.Black;
            this.labelmaxdisc.Appearance.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmaxdisc.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelmaxdisc.Location = new System.Drawing.Point(3, 50);
            this.labelmaxdisc.Name = "labelmaxdisc";
            this.labelmaxdisc.Size = new System.Drawing.Size(0, 10);
            this.labelmaxdisc.TabIndex = 23;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl20.LineColor = System.Drawing.Color.Silver;
            this.labelControl20.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl20.Location = new System.Drawing.Point(107, 85);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(127, 20);
            this.labelControl20.TabIndex = 22;
            this.labelControl20.Text = "Customer Payment :";
            this.labelControl20.Visible = false;
            // 
            // txtnetins
            // 
            this.txtnetins.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtnetins.Location = new System.Drawing.Point(238, 84);
            this.txtnetins.Name = "txtnetins";
            this.txtnetins.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetins.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtnetins.Properties.Appearance.Options.UseFont = true;
            this.txtnetins.Properties.Appearance.Options.UseForeColor = true;
            this.txtnetins.Properties.Appearance.Options.UseTextOptions = true;
            this.txtnetins.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtnetins.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtnetins.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtnetins.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetins.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtnetins.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtnetins.Properties.DisplayFormat.FormatString = "N2";
            this.txtnetins.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnetins.Properties.EditFormat.FormatString = "N2";
            this.txtnetins.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnetins.Properties.NullText = "0";
            this.txtnetins.Properties.ReadOnly = true;
            this.txtnetins.Size = new System.Drawing.Size(101, 24);
            this.txtnetins.TabIndex = 21;
            this.txtnetins.TabStop = false;
            this.txtnetins.Visible = false;
            // 
            // txtreturnamt
            // 
            this.txtreturnamt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtreturnamt.Location = new System.Drawing.Point(238, 29);
            this.txtreturnamt.Name = "txtreturnamt";
            this.txtreturnamt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreturnamt.Properties.Appearance.Options.UseFont = true;
            this.txtreturnamt.Properties.Appearance.Options.UseTextOptions = true;
            this.txtreturnamt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtreturnamt.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtreturnamt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Red;
            this.txtreturnamt.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreturnamt.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtreturnamt.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtreturnamt.Properties.DisplayFormat.FormatString = "N2";
            this.txtreturnamt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtreturnamt.Properties.EditFormat.FormatString = "N2";
            this.txtreturnamt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtreturnamt.Properties.NullText = "0";
            this.txtreturnamt.Properties.ReadOnly = true;
            this.txtreturnamt.Size = new System.Drawing.Size(101, 24);
            this.txtreturnamt.TabIndex = 20;
            this.txtreturnamt.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineColor = System.Drawing.Color.Silver;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl7.Location = new System.Drawing.Point(150, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(84, 14);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Return Amt.:";
            // 
            // txtrounding
            // 
            this.txtrounding.EditValue = "0.00";
            this.txtrounding.Location = new System.Drawing.Point(76, 59);
            this.txtrounding.Name = "txtrounding";
            this.txtrounding.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrounding.Properties.Appearance.Options.UseFont = true;
            this.txtrounding.Properties.Appearance.Options.UseTextOptions = true;
            this.txtrounding.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtrounding.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtrounding.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightYellow;
            this.txtrounding.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtrounding.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtrounding.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtrounding.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtrounding.Properties.DisplayFormat.FormatString = "N2";
            this.txtrounding.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtrounding.Properties.EditFormat.FormatString = "N2";
            this.txtrounding.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtrounding.Properties.NullText = "0";
            this.txtrounding.Size = new System.Drawing.Size(71, 24);
            this.txtrounding.TabIndex = 18;
            this.txtrounding.TabStop = false;
            this.txtrounding.EditValueChanged += new System.EventHandler(this.txtrounding_EditValueChanged);
            this.txtrounding.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtrounding_EditValueChanging);
            this.txtrounding.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrounding_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Location = new System.Drawing.Point(5, 65);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 14);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Rounding :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.LineColor = System.Drawing.Color.Silver;
            this.labelControl8.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl8.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl8.LineVisible = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 10);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Discount :";
            // 
            // txtdiscount
            // 
            this.txtdiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtdiscount.Location = new System.Drawing.Point(76, 4);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtdiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Properties.Appearance.Options.UseBackColor = true;
            this.txtdiscount.Properties.Appearance.Options.UseFont = true;
            this.txtdiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtdiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtdiscount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtdiscount.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtdiscount.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtdiscount.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtdiscount.Properties.DisplayFormat.FormatString = "###.00";
            this.txtdiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtdiscount.Properties.NullText = "0";
            this.txtdiscount.Properties.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(71, 24);
            this.txtdiscount.TabIndex = 15;
            this.txtdiscount.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineColor = System.Drawing.Color.Silver;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(164, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 14);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Sub Total :";
            // 
            // subtotal
            // 
            this.subtotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.subtotal.Location = new System.Drawing.Point(238, 3);
            this.subtotal.Name = "subtotal";
            this.subtotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.subtotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Properties.Appearance.Options.UseBackColor = true;
            this.subtotal.Properties.Appearance.Options.UseFont = true;
            this.subtotal.Properties.Appearance.Options.UseTextOptions = true;
            this.subtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.subtotal.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.subtotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.subtotal.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.subtotal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.subtotal.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.subtotal.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.subtotal.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.subtotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.subtotal.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.subtotal.Properties.DisplayFormat.FormatString = "N2";
            this.subtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.subtotal.Properties.EditFormat.FormatString = "N2";
            this.subtotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.subtotal.Properties.NullText = "0";
            this.subtotal.Properties.ReadOnly = true;
            this.subtotal.Size = new System.Drawing.Size(101, 24);
            this.subtotal.TabIndex = 13;
            this.subtotal.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(5, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Disc %:";
            // 
            // txtdiscper
            // 
            this.txtdiscper.EditValue = "0";
            this.txtdiscper.Location = new System.Drawing.Point(76, 32);
            this.txtdiscper.Name = "txtdiscper";
            this.txtdiscper.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscper.Properties.Appearance.Options.UseFont = true;
            this.txtdiscper.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscper.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtdiscper.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtdiscper.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtdiscper.Properties.DisplayFormat.FormatString = "N2";
            this.txtdiscper.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtdiscper.Properties.EditFormat.FormatString = "N2";
            this.txtdiscper.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtdiscper.Properties.Mask.EditMask = "P2";
            this.txtdiscper.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtdiscper.Properties.ReadOnly = true;
            this.txtdiscper.Size = new System.Drawing.Size(71, 24);
            this.txtdiscper.TabIndex = 11;
            this.txtdiscper.EditValueChanged += new System.EventHandler(this.txtdiscper_EditValueChanged);
            this.txtdiscper.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtdiscper_EditValueChanging);
            this.txtdiscper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscper_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineColor = System.Drawing.Color.Silver;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(164, 62);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 14);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Net Value :";
            // 
            // txtnetamt
            // 
            this.txtnetamt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtnetamt.Location = new System.Drawing.Point(238, 57);
            this.txtnetamt.Name = "txtnetamt";
            this.txtnetamt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtnetamt.Properties.Appearance.Options.UseFont = true;
            this.txtnetamt.Properties.Appearance.Options.UseForeColor = true;
            this.txtnetamt.Properties.Appearance.Options.UseTextOptions = true;
            this.txtnetamt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtnetamt.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtnetamt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtnetamt.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtnetamt.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtnetamt.Properties.DisplayFormat.FormatString = "N2";
            this.txtnetamt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnetamt.Properties.EditFormat.FormatString = "N2";
            this.txtnetamt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnetamt.Properties.NullText = "0";
            this.txtnetamt.Properties.ReadOnly = true;
            this.txtnetamt.Size = new System.Drawing.Size(101, 24);
            this.txtnetamt.TabIndex = 5;
            this.txtnetamt.EditValueChanged += new System.EventHandler(this.txtnetamt_EditValueChanged);
            // 
            // lblcustomeronhold
            // 
            this.lblcustomeronhold.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblcustomeronhold.Appearance.Options.UseBackColor = true;
            this.lblcustomeronhold.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomeronhold.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.lblcustomeronhold.AppearanceCaption.Options.UseFont = true;
            this.lblcustomeronhold.AppearanceCaption.Options.UseForeColor = true;
            this.lblcustomeronhold.AppearanceDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomeronhold.AppearanceDescription.ForeColor = System.Drawing.Color.Black;
            this.lblcustomeronhold.AppearanceDescription.Options.UseFont = true;
            this.lblcustomeronhold.AppearanceDescription.Options.UseForeColor = true;
            this.lblcustomeronhold.Caption = "Customer on hold";
            this.lblcustomeronhold.Description = "Press F6 to recall";
            this.lblcustomeronhold.Location = new System.Drawing.Point(12, 66);
            this.lblcustomeronhold.LookAndFeel.SkinName = "High Contrast";
            this.lblcustomeronhold.Name = "lblcustomeronhold";
            this.lblcustomeronhold.Size = new System.Drawing.Size(334, 42);
            this.lblcustomeronhold.TabIndex = 9;
            this.lblcustomeronhold.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sALESINVDETAILBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 219);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.gridControl1.Size = new System.Drawing.Size(840, 201);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl1_ProcessGridKey);
            // 
            // sALESINVDETAILBindingSource
            // 
            this.sALESINVDETAILBindingSource.DataMember = "SALESINVDETAIL";
            this.sALESINVDETAILBindingSource.DataSource = this.dsInventory1;
            // 
            // dsInventory1
            // 
            this.dsInventory1.DataSetName = "DsInventory";
            this.dsInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colSINVNO,
            this.colBARCODE,
            this.colITEMNO,
            this.colITEMNAME,
            this.colSTOCK,
            this.colQTY,
            this.colINVRATE,
            this.colSPRICE,
            this.colCPRICE,
            this.colEXPDATE,
            this.colDISC,
            this.colLINETOTAL,
            this.colSTOCKID,
            this.colISRETURN,
            this.colBONUS,
            this.colEXTDISC,
            this.colDOCTORID,
            this.colDISCONSALE,
            this.colASTOCK,
            this.colEXPDATE1});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colQTY;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = 0;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 26;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GridView1CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceCell.Options.UseFont = true;
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceHeader.Options.UseFont = true;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTID.OptionsColumn.ReadOnly = true;
            this.colTID.OptionsFilter.AllowAutoFilter = false;
            this.colTID.OptionsFilter.AllowFilter = false;
            // 
            // colSINVNO
            // 
            this.colSINVNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSINVNO.AppearanceCell.Options.UseFont = true;
            this.colSINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSINVNO.AppearanceHeader.Options.UseFont = true;
            this.colSINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.FieldName = "SINVNO";
            this.colSINVNO.Name = "colSINVNO";
            this.colSINVNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSINVNO.OptionsFilter.AllowAutoFilter = false;
            this.colSINVNO.OptionsFilter.AllowFilter = false;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceCell.Options.UseFont = true;
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceHeader.Options.UseFont = true;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBARCODE.OptionsFilter.AllowAutoFilter = false;
            this.colBARCODE.OptionsFilter.AllowFilter = false;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceCell.Options.UseFont = true;
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Barcode";
            this.colITEMNO.CustomizationCaption = "Barcode";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNO.OptionsColumn.ReadOnly = true;
            this.colITEMNO.OptionsFilter.AllowAutoFilter = false;
            this.colITEMNO.OptionsFilter.AllowFilter = false;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 0;
            this.colITEMNO.Width = 139;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNAME.AppearanceCell.Options.UseFont = true;
            this.colITEMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNAME.AppearanceHeader.Options.UseFont = true;
            this.colITEMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.Caption = "Item name";
            this.colITEMNAME.FieldName = "ITEMNAME";
            this.colITEMNAME.Name = "colITEMNAME";
            this.colITEMNAME.OptionsColumn.AllowEdit = false;
            this.colITEMNAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNAME.OptionsColumn.ReadOnly = true;
            this.colITEMNAME.OptionsFilter.AllowAutoFilter = false;
            this.colITEMNAME.OptionsFilter.AllowFilter = false;
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 1;
            this.colITEMNAME.Width = 342;
            // 
            // colSTOCK
            // 
            this.colSTOCK.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCK.AppearanceCell.Options.UseFont = true;
            this.colSTOCK.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCK.AppearanceHeader.Options.UseFont = true;
            this.colSTOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOCK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCK.Caption = "Stock";
            this.colSTOCK.FieldName = "STOCK";
            this.colSTOCK.Name = "colSTOCK";
            this.colSTOCK.OptionsColumn.AllowEdit = false;
            this.colSTOCK.OptionsColumn.AllowFocus = false;
            this.colSTOCK.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCK.OptionsColumn.ReadOnly = true;
            this.colSTOCK.OptionsFilter.AllowAutoFilter = false;
            this.colSTOCK.OptionsFilter.AllowFilter = false;
            this.colSTOCK.Visible = true;
            this.colSTOCK.VisibleIndex = 7;
            this.colSTOCK.Width = 51;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceCell.Options.UseFont = true;
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceHeader.Options.UseFont = true;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.Caption = "Price";
            this.colINVRATE.ColumnEdit = this.repositoryItemTextEdit2;
            this.colINVRATE.DisplayFormat.FormatString = "N2";
            this.colINVRATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVRATE.FieldName = "INVRATE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colINVRATE.OptionsFilter.AllowAutoFilter = false;
            this.colINVRATE.OptionsFilter.AllowFilter = false;
            this.colINVRATE.Visible = true;
            this.colINVRATE.VisibleIndex = 3;
            this.colINVRATE.Width = 52;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.DisplayFormat.FormatString = "N2";
            this.repositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit2.EditFormat.FormatString = "N2";
            this.repositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceCell.Options.UseFont = true;
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceHeader.Options.UseFont = true;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSPRICE.OptionsFilter.AllowAutoFilter = false;
            this.colSPRICE.OptionsFilter.AllowFilter = false;
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceCell.Options.UseFont = true;
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceHeader.Options.UseFont = true;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCPRICE.OptionsFilter.AllowAutoFilter = false;
            this.colCPRICE.OptionsFilter.AllowFilter = false;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceCell.Options.UseFont = true;
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceHeader.Options.UseFont = true;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.Caption = "Expiry";
            this.colEXPDATE.DisplayFormat.FormatString = "MM-yy";
            this.colEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.AllowEdit = false;
            this.colEXPDATE.OptionsColumn.AllowFocus = false;
            this.colEXPDATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPDATE.OptionsFilter.AllowAutoFilter = false;
            this.colEXPDATE.OptionsFilter.AllowFilter = false;
            this.colEXPDATE.Width = 54;
            // 
            // colDISC
            // 
            this.colDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceCell.Options.UseFont = true;
            this.colDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceHeader.Options.UseFont = true;
            this.colDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.Caption = "Disc %";
            this.colDISC.ColumnEdit = this.repositoryItemTextEdit4;
            this.colDISC.DisplayFormat.FormatString = "N2";
            this.colDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDISC.FieldName = "DISC";
            this.colDISC.Name = "colDISC";
            this.colDISC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDISC.OptionsFilter.AllowAutoFilter = false;
            this.colDISC.OptionsFilter.AllowFilter = false;
            this.colDISC.Visible = true;
            this.colDISC.VisibleIndex = 5;
            this.colDISC.Width = 50;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.EditFormat.FormatString = "N";
            this.repositoryItemTextEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // colLINETOTAL
            // 
            this.colLINETOTAL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLINETOTAL.AppearanceCell.Options.UseFont = true;
            this.colLINETOTAL.AppearanceCell.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colLINETOTAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLINETOTAL.AppearanceHeader.Options.UseFont = true;
            this.colLINETOTAL.AppearanceHeader.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.Caption = "Total";
            this.colLINETOTAL.DisplayFormat.FormatString = "N2";
            this.colLINETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLINETOTAL.FieldName = "LINETOTAL";
            this.colLINETOTAL.Name = "colLINETOTAL";
            this.colLINETOTAL.OptionsColumn.AllowEdit = false;
            this.colLINETOTAL.OptionsColumn.AllowFocus = false;
            this.colLINETOTAL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLINETOTAL.OptionsColumn.ReadOnly = true;
            this.colLINETOTAL.OptionsFilter.AllowAutoFilter = false;
            this.colLINETOTAL.OptionsFilter.AllowFilter = false;
            this.colLINETOTAL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", "{0:###,###,###.00}")});
            this.colLINETOTAL.Visible = true;
            this.colLINETOTAL.VisibleIndex = 6;
            this.colLINETOTAL.Width = 78;
            // 
            // colSTOCKID
            // 
            this.colSTOCKID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCKID.AppearanceCell.Options.UseFont = true;
            this.colSTOCKID.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCKID.AppearanceHeader.Options.UseFont = true;
            this.colSTOCKID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOCKID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.FieldName = "STOCKID";
            this.colSTOCKID.Name = "colSTOCKID";
            this.colSTOCKID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCKID.OptionsFilter.AllowAutoFilter = false;
            this.colSTOCKID.OptionsFilter.AllowFilter = false;
            // 
            // colISRETURN
            // 
            this.colISRETURN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISRETURN.AppearanceCell.Options.UseFont = true;
            this.colISRETURN.AppearanceCell.Options.UseTextOptions = true;
            this.colISRETURN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISRETURN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISRETURN.AppearanceHeader.Options.UseFont = true;
            this.colISRETURN.AppearanceHeader.Options.UseTextOptions = true;
            this.colISRETURN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colISRETURN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISRETURN.FieldName = "ISRETURN";
            this.colISRETURN.Name = "colISRETURN";
            this.colISRETURN.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colISRETURN.OptionsFilter.AllowAutoFilter = false;
            this.colISRETURN.OptionsFilter.AllowFilter = false;
            // 
            // colBONUS
            // 
            this.colBONUS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBONUS.AppearanceCell.Options.UseFont = true;
            this.colBONUS.AppearanceCell.Options.UseTextOptions = true;
            this.colBONUS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBONUS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBONUS.AppearanceHeader.Options.UseFont = true;
            this.colBONUS.AppearanceHeader.Options.UseTextOptions = true;
            this.colBONUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBONUS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBONUS.FieldName = "BONUS";
            this.colBONUS.Name = "colBONUS";
            this.colBONUS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBONUS.OptionsFilter.AllowAutoFilter = false;
            this.colBONUS.OptionsFilter.AllowFilter = false;
            // 
            // colEXTDISC
            // 
            this.colEXTDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXTDISC.AppearanceCell.Options.UseFont = true;
            this.colEXTDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colEXTDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXTDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXTDISC.AppearanceHeader.Options.UseFont = true;
            this.colEXTDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXTDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXTDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXTDISC.FieldName = "EXTDISC";
            this.colEXTDISC.Name = "colEXTDISC";
            this.colEXTDISC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXTDISC.OptionsFilter.AllowAutoFilter = false;
            this.colEXTDISC.OptionsFilter.AllowFilter = false;
            // 
            // colDOCTORID
            // 
            this.colDOCTORID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDOCTORID.AppearanceCell.Options.UseFont = true;
            this.colDOCTORID.AppearanceCell.Options.UseTextOptions = true;
            this.colDOCTORID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOCTORID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDOCTORID.AppearanceHeader.Options.UseFont = true;
            this.colDOCTORID.AppearanceHeader.Options.UseTextOptions = true;
            this.colDOCTORID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDOCTORID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOCTORID.FieldName = "DOCTORID";
            this.colDOCTORID.Name = "colDOCTORID";
            this.colDOCTORID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDOCTORID.OptionsFilter.AllowAutoFilter = false;
            this.colDOCTORID.OptionsFilter.AllowFilter = false;
            // 
            // colDISCONSALE
            // 
            this.colDISCONSALE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISCONSALE.AppearanceCell.Options.UseFont = true;
            this.colDISCONSALE.AppearanceCell.Options.UseTextOptions = true;
            this.colDISCONSALE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCONSALE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISCONSALE.AppearanceHeader.Options.UseFont = true;
            this.colDISCONSALE.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISCONSALE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISCONSALE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCONSALE.FieldName = "DISCONSALE";
            this.colDISCONSALE.Name = "colDISCONSALE";
            this.colDISCONSALE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDISCONSALE.OptionsFilter.AllowAutoFilter = false;
            this.colDISCONSALE.OptionsFilter.AllowFilter = false;
            // 
            // colASTOCK
            // 
            this.colASTOCK.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colASTOCK.AppearanceCell.Options.UseFont = true;
            this.colASTOCK.Caption = "ASTOCK";
            this.colASTOCK.FieldName = "ASTOCK";
            this.colASTOCK.Name = "colASTOCK";
            this.colASTOCK.OptionsColumn.AllowEdit = false;
            this.colASTOCK.OptionsColumn.AllowFocus = false;
            // 
            // colEXPDATE1
            // 
            this.colEXPDATE1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE1.AppearanceCell.Options.UseFont = true;
            this.colEXPDATE1.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE1.AppearanceHeader.Options.UseFont = true;
            this.colEXPDATE1.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE1.Caption = "Expiry";
            this.colEXPDATE1.ColumnEdit = this.repositoryItemTextEdit3;
            this.colEXPDATE1.FieldName = "EXPDATE1";
            this.colEXPDATE1.Name = "colEXPDATE1";
            this.colEXPDATE1.Visible = true;
            this.colEXPDATE1.VisibleIndex = 4;
            this.colEXPDATE1.Width = 59;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // iTEMMASTBindingSource
            // 
            this.iTEMMASTBindingSource.DataMember = "ITEMMAST";
            this.iTEMMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.gridControl2);
            this.popupControlContainer1.Location = new System.Drawing.Point(95, 274);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbon;
            this.popupControlContainer1.Size = new System.Drawing.Size(241, 102);
            this.popupControlContainer1.TabIndex = 20;
            this.popupControlContainer1.Visible = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(4, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(235, 98);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl2_KeyDown);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.IndicatorWidth = 20;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GridView2CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Barcode";
            this.gridColumn1.FieldName = "ITEMNO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Width = 160;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "Stock";
            this.gridColumn3.FieldName = "QTY";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 59;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "Price";
            this.gridColumn4.DisplayFormat.FormatString = "N2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "SPRICE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 71;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.FieldName = "CPRICE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.Caption = "Expiry";
            this.gridColumn6.DisplayFormat.FormatString = "MM-yy";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "EXPDATE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 81;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Qty.";
            this.gridColumn7.FieldName = "DQNTY";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Width = 61;
            // 
            // RetailSales1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 566);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "RetailSales1";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Retail Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RetailSales_FormClosing);
            this.Load += new System.EventHandler(this.RetailSales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RetailSales1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).EndInit();
            this.panelnormalcustomer.ResumeLayout(false);
            this.panelnormalcustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcrlimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfixdis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtavailble.Properties)).EndInit();
            this.panelinsurance.ResumeLayout(false);
            this.panelinsurance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpatname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutomerpayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbclass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSURANCEDISCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvisitno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfileno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupcustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnetins.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtreturnamt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrounding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiscper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnetamt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESINVDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbon;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private RibbonStatusBar ribbonStatusBar;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private BarButtonItem barButtonItem8;
        private BarButtonItem barButtonItem9;
        private BarButtonItem barButtonItem10;
        private BarButtonItem barButtonItem11;
        private BarButtonItem barButtonItem12;
        private RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem staticdoctor;
        private PanelControl panelControl1;
        private TextEdit txtbarcode;
        private LabelControl labelControl1;
        private Panel panelnormalcustomer;
        private TextEdit txtcrlimit;
        private LabelControl labelControl21;
        private TextEdit txtfixdis;
        private LabelControl labelControl22;
        private LabelControl labelControl17;
        private TextEdit txtavailble;
        private LabelControl labelControl18;
        private Panel panelinsurance;
        private TextEdit txtpatname;
        private LabelControl labelControl12;
        private LabelControl labelControl16;
        private TextEdit cutomerpayment;
        private LookUpEdit cmbclass;
        private TextEdit txtvisitno;
        private LabelControl labelControl19;
        private LabelControl labelControl15;
        private TextEdit txtfileno;
        private LabelControl labelControl10;
        private LookUpEdit lookupcustomer;
        private LabelControl labelControl13;
        private PanelControl panelControl3;
        private ProgressPanel lblmutilpleprice;
        private Panel panel1;
        private LabelControl labelControl20;
        private TextEdit txtnetins;
        private TextEdit txtreturnamt;
        private LabelControl labelControl7;
        private TextEdit txtrounding;
        private LabelControl labelControl6;
        private LabelControl labelControl8;
        private TextEdit txtdiscount;
        private LabelControl labelControl4;
        private TextEdit subtotal;
        private LabelControl labelControl3;
        private TextEdit txtdiscper;
        private LabelControl labelControl5;
        private TextEdit txtnetamt;
        private ProgressPanel lblcustomeronhold;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colTID;
        private GridColumn colSINVNO;
        private GridColumn colBARCODE;
        private GridColumn colITEMNO;
        private GridColumn colITEMNAME;
        private GridColumn colSTOCK;
        private GridColumn colQTY;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private GridColumn colINVRATE;
        private RepositoryItemTextEdit repositoryItemTextEdit2;
        private GridColumn colSPRICE;
        private GridColumn colCPRICE;
        private GridColumn colEXPDATE;
        private GridColumn colDISC;
        private RepositoryItemTextEdit repositoryItemTextEdit4;
        private GridColumn colLINETOTAL;
        private GridColumn colSTOCKID;
        private GridColumn colISRETURN;
        private GridColumn colBONUS;
        private GridColumn colEXTDISC;
        private GridColumn colDOCTORID;
        private GridColumn colDISCONSALE;
        private GridColumn colASTOCK;
        private GridColumn colEXPDATE1;
        private RepositoryItemTextEdit repositoryItemTextEdit3;
        private BarStaticItem barStaticItem2;
        private BarStaticItem barStaticItem3;
        private BarStaticItem two;
        private BarStaticItem barStaticItem4;
        private BarStaticItem barcomp;
        private BarStaticItem barStaticItem5;
        private BarStaticItem txtinvoiceno;
        private BarEditItem lookupcashier;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BindingSource sALESINVDETAILBindingSource;
        private DsInventory dsInventory1;
        private BindingSource cUSTOMERBindingSource;
        private DsMaster dsMaster1;
        private BindingSource iTEMMASTBindingSource;
        private BindingSource iNSURANCEDISCBindingSource;
        private BarButtonItem barButtonItem13;
        private BarButtonItem barButtonItem14;
        private PopupControlContainer popupControlContainer1;
        private GridControl gridControl2;
        private GridView gridView2;
        private GridColumn gridColumn1;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
        private GridColumn gridColumn7;
        private LabelControl labelmaxdisc;
        private TextEdit txtqty;
        private LabelControl labelControl2;
        private BarButtonItem barButtonItem15;
        private TextEdit txtcustomer;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
    }
}