using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class DataDisk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataDisk));
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem5 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.targetloc = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mastMoveTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.iTEMTRANSFERMAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRANID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTITEMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISREC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOWNFILENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFILENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastMoveTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERMAINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "DISKCREATED";
            this.gridColumn3.FieldName = "DISKCREATED";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barEditItem2,
            this.barButtonItem1,
            this.barStaticItem2,
            this.barStaticItem4,
            this.barEditItem5,
            this.barStaticItem1,
            this.barButtonItem3,
            this.targetloc,
            this.barButtonItem2,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barEditItem1,
            this.barEditItem3,
            this.barEditItem4,
            this.barButtonItem9,
            this.barButtonItem10});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 46;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemProgressBar1,
            this.repositoryItemRadioGroup1,
            this.repositoryItemButtonEdit2,
            this.repositoryItemButtonEdit3,
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemLookUpEdit5,
            this.repositoryItemTextEdit2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(753, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Created Date :";
            this.barEditItem2.Edit = this.repositoryItemDateEdit1;
            this.barEditItem2.Id = 3;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 100;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Generate";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.run;
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Double click to add to list";
            this.barStaticItem2.Id = 8;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem4.Caption = "Double click on grid to remove";
            this.barStaticItem4.Id = 10;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem5
            // 
            this.barEditItem5.Caption = "Last File No. :  ";
            this.barEditItem5.Edit = this.repositoryItemLookUpEdit2;
            this.barEditItem5.Id = 11;
            this.barEditItem5.Name = "barEditItem5";
            this.barEditItem5.Width = 100;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Click to view the voucher";
            this.barStaticItem1.Id = 12;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 25;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // targetloc
            // 
            this.targetloc.Caption = "File Location :";
            this.targetloc.Edit = this.repositoryItemComboBox1;
            this.targetloc.Id = 27;
            this.targetloc.Name = "targetloc";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem2.Caption = "Create File";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Glyph = global::Store.Properties.Resources.Process_Accept;
            this.barButtonItem2.Id = 28;
            this.barButtonItem2.LargeGlyph = global::Store.Properties.Resources.Process_Accept1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "New";
            this.barButtonItem4.Id = 32;
            this.barButtonItem4.LargeGlyph = global::Store.Properties.Resources.page_white_star;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem5.Caption = "Send";
            this.barButtonItem5.Glyph = global::Store.Properties.Resources.mailsend;
            this.barButtonItem5.Id = 33;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Removable Media";
            this.barButtonItem6.Id = 35;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Network";
            this.barButtonItem7.Id = 36;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Email Client";
            this.barButtonItem8.Id = 37;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Transfer Type :  ";
            this.barEditItem1.Edit = this.repositoryItemCheckedComboBoxEdit1;
            this.barEditItem1.Id = 38;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 120;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(0, "Removable Media"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(1, "Network"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2, "Email Client")});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            this.repositoryItemCheckedComboBoxEdit1.SelectAllItemVisible = false;
            this.repositoryItemCheckedComboBoxEdit1.ShowButtons = false;
            this.repositoryItemCheckedComboBoxEdit1.ShowPopupCloseButton = false;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "File No.";
            this.barEditItem3.Edit = this.repositoryItemLookUpEdit5;
            this.barEditItem3.Id = 39;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Width = 30;
            // 
            // repositoryItemLookUpEdit5
            // 
            this.repositoryItemLookUpEdit5.AutoHeight = false;
            this.repositoryItemLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
            this.repositoryItemLookUpEdit5.NullText = "";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "File No.               ";
            this.barEditItem4.Edit = this.repositoryItemTextEdit2;
            this.barEditItem4.Id = 40;
            this.barEditItem4.Name = "barEditItem4";
            this.barEditItem4.Width = 100;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Refresh";
            this.barButtonItem9.Id = 42;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Refresh";
            this.barButtonItem10.Id = 45;
            this.barButtonItem10.LargeGlyph = global::Store.Properties.Resources.gtkrefresh;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Data Disk";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.targetloc, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "File";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Transfer";
            this.ribbonPageGroup1.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "History";
            this.ribbonPageGroup3.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Refresh";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.mastMoveTypesBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "MoveType";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "MoveTypeid";
            // 
            // mastMoveTypesBindingSource
            // 
            this.mastMoveTypesBindingSource.DataMember = "MastMoveTypes";
            this.mastMoveTypesBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.EnableFocusRect = true;
            this.repositoryItemRadioGroup1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "On Line"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Create File"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Both")});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.NullText = "";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem4, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1, true);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 484);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(753, 31);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 144);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.AutoScroll = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(753, 340);
            this.splitContainerControl1.SplitterPosition = 504;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.iTEMTRANSFERMAINBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(504, 340);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // iTEMTRANSFERMAINBindingSource
            // 
            this.iTEMTRANSFERMAINBindingSource.DataMember = "ITEMTRANSFERMAIN";
            this.iTEMTRANSFERMAINBindingSource.DataSource = typeof(VIRETAILENTITIES.DsInventory);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANID,
            this.colTOSTOREID,
            this.colTRANDATE,
            this.colUSERID,
            this.colUDATE,
            this.colHOLD,
            this.colEUSERID,
            this.colEDATE,
            this.colTOTVALUE,
            this.colTOTITEMS,
            this.colNOTE,
            this.colTTYPE,
            this.colCOMPANY,
            this.colFRMSTOREID,
            this.colFRMNAME,
            this.colTONAME,
            this.colISREC,
            this.colDOWNFILENO,
            this.colAFILENO,
            this.gridColumn3});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gridColumn3;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowPreview = true;
            this.gridView1.PreviewFieldName = "NOTE";
            this.gridView1.SynchronizeClones = false;
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
            this.colTRANID.Caption = "Doc #";
            this.colTRANID.FieldName = "TRANID";
            this.colTRANID.Name = "colTRANID";
            this.colTRANID.OptionsColumn.AllowEdit = false;
            this.colTRANID.OptionsColumn.ReadOnly = true;
            this.colTRANID.Visible = true;
            this.colTRANID.VisibleIndex = 0;
            this.colTRANID.Width = 93;
            // 
            // colTOSTOREID
            // 
            this.colTOSTOREID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOSTOREID.AppearanceCell.Options.UseFont = true;
            this.colTOSTOREID.AppearanceCell.Options.UseTextOptions = true;
            this.colTOSTOREID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOSTOREID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOSTOREID.AppearanceHeader.Options.UseFont = true;
            this.colTOSTOREID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOSTOREID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOSTOREID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOSTOREID.FieldName = "TOSTOREID";
            this.colTOSTOREID.Name = "colTOSTOREID";
            this.colTOSTOREID.OptionsColumn.AllowEdit = false;
            this.colTOSTOREID.OptionsColumn.ReadOnly = true;
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceCell.Options.UseFont = true;
            this.colTRANDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceHeader.Options.UseFont = true;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Tran.Dt.";
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.OptionsColumn.ReadOnly = true;
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 1;
            this.colTRANDATE.Width = 105;
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
            this.colUSERID.OptionsColumn.AllowEdit = false;
            this.colUSERID.OptionsColumn.ReadOnly = true;
            // 
            // colUDATE
            // 
            this.colUDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUDATE.AppearanceCell.Options.UseFont = true;
            this.colUDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colUDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUDATE.AppearanceHeader.Options.UseFont = true;
            this.colUDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colUDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUDATE.FieldName = "UDATE";
            this.colUDATE.Name = "colUDATE";
            this.colUDATE.OptionsColumn.AllowEdit = false;
            this.colUDATE.OptionsColumn.ReadOnly = true;
            // 
            // colHOLD
            // 
            this.colHOLD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOLD.AppearanceCell.Options.UseFont = true;
            this.colHOLD.AppearanceCell.Options.UseTextOptions = true;
            this.colHOLD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOLD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOLD.AppearanceHeader.Options.UseFont = true;
            this.colHOLD.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOLD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOLD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOLD.FieldName = "HOLD";
            this.colHOLD.Name = "colHOLD";
            this.colHOLD.OptionsColumn.AllowEdit = false;
            this.colHOLD.OptionsColumn.ReadOnly = true;
            // 
            // colEUSERID
            // 
            this.colEUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEUSERID.AppearanceCell.Options.UseFont = true;
            this.colEUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEUSERID.AppearanceHeader.Options.UseFont = true;
            this.colEUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.FieldName = "EUSERID";
            this.colEUSERID.Name = "colEUSERID";
            this.colEUSERID.OptionsColumn.AllowEdit = false;
            this.colEUSERID.OptionsColumn.ReadOnly = true;
            // 
            // colEDATE
            // 
            this.colEDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEDATE.AppearanceCell.Options.UseFont = true;
            this.colEDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEDATE.AppearanceHeader.Options.UseFont = true;
            this.colEDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.FieldName = "EDATE";
            this.colEDATE.Name = "colEDATE";
            this.colEDATE.OptionsColumn.AllowEdit = false;
            this.colEDATE.OptionsColumn.ReadOnly = true;
            // 
            // colTOTVALUE
            // 
            this.colTOTVALUE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTVALUE.AppearanceCell.Options.UseFont = true;
            this.colTOTVALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colTOTVALUE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTVALUE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTVALUE.AppearanceHeader.Options.UseFont = true;
            this.colTOTVALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOTVALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOTVALUE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTVALUE.FieldName = "TOTVALUE";
            this.colTOTVALUE.Name = "colTOTVALUE";
            this.colTOTVALUE.OptionsColumn.AllowEdit = false;
            this.colTOTVALUE.OptionsColumn.ReadOnly = true;
            // 
            // colTOTITEMS
            // 
            this.colTOTITEMS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTITEMS.AppearanceCell.Options.UseFont = true;
            this.colTOTITEMS.AppearanceCell.Options.UseTextOptions = true;
            this.colTOTITEMS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTITEMS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTITEMS.AppearanceHeader.Options.UseFont = true;
            this.colTOTITEMS.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOTITEMS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOTITEMS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTITEMS.FieldName = "TOTITEMS";
            this.colTOTITEMS.Name = "colTOTITEMS";
            this.colTOTITEMS.OptionsColumn.AllowEdit = false;
            this.colTOTITEMS.OptionsColumn.ReadOnly = true;
            // 
            // colNOTE
            // 
            this.colNOTE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOTE.AppearanceCell.Options.UseFont = true;
            this.colNOTE.AppearanceCell.Options.UseTextOptions = true;
            this.colNOTE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOTE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOTE.AppearanceHeader.Options.UseFont = true;
            this.colNOTE.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOTE.FieldName = "NOTE";
            this.colNOTE.Name = "colNOTE";
            this.colNOTE.OptionsColumn.AllowEdit = false;
            this.colNOTE.OptionsColumn.ReadOnly = true;
            // 
            // colTTYPE
            // 
            this.colTTYPE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTTYPE.AppearanceCell.Options.UseFont = true;
            this.colTTYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colTTYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTTYPE.AppearanceHeader.Options.UseFont = true;
            this.colTTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTTYPE.FieldName = "TTYPE";
            this.colTTYPE.Name = "colTTYPE";
            this.colTTYPE.OptionsColumn.AllowEdit = false;
            this.colTTYPE.OptionsColumn.ReadOnly = true;
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
            this.colCOMPANY.OptionsColumn.AllowEdit = false;
            this.colCOMPANY.OptionsColumn.ReadOnly = true;
            // 
            // colFRMSTOREID
            // 
            this.colFRMSTOREID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMSTOREID.AppearanceCell.Options.UseFont = true;
            this.colFRMSTOREID.AppearanceCell.Options.UseTextOptions = true;
            this.colFRMSTOREID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMSTOREID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMSTOREID.AppearanceHeader.Options.UseFont = true;
            this.colFRMSTOREID.AppearanceHeader.Options.UseTextOptions = true;
            this.colFRMSTOREID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFRMSTOREID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMSTOREID.FieldName = "FRMSTOREID";
            this.colFRMSTOREID.Name = "colFRMSTOREID";
            this.colFRMSTOREID.OptionsColumn.AllowEdit = false;
            this.colFRMSTOREID.OptionsColumn.ReadOnly = true;
            // 
            // colFRMNAME
            // 
            this.colFRMNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMNAME.AppearanceCell.Options.UseFont = true;
            this.colFRMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colFRMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMNAME.AppearanceHeader.Options.UseFont = true;
            this.colFRMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colFRMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFRMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMNAME.Caption = "From Loc.";
            this.colFRMNAME.FieldName = "FRMNAME";
            this.colFRMNAME.Name = "colFRMNAME";
            this.colFRMNAME.OptionsColumn.AllowEdit = false;
            this.colFRMNAME.OptionsColumn.ReadOnly = true;
            this.colFRMNAME.Visible = true;
            this.colFRMNAME.VisibleIndex = 2;
            this.colFRMNAME.Width = 137;
            // 
            // colTONAME
            // 
            this.colTONAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTONAME.AppearanceCell.Options.UseFont = true;
            this.colTONAME.AppearanceCell.Options.UseTextOptions = true;
            this.colTONAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTONAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTONAME.AppearanceHeader.Options.UseFont = true;
            this.colTONAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colTONAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTONAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTONAME.Caption = "To Loc.";
            this.colTONAME.FieldName = "TONAME";
            this.colTONAME.Name = "colTONAME";
            this.colTONAME.OptionsColumn.AllowEdit = false;
            this.colTONAME.OptionsColumn.ReadOnly = true;
            this.colTONAME.Visible = true;
            this.colTONAME.VisibleIndex = 3;
            this.colTONAME.Width = 157;
            // 
            // colISREC
            // 
            this.colISREC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISREC.AppearanceCell.Options.UseFont = true;
            this.colISREC.AppearanceCell.Options.UseTextOptions = true;
            this.colISREC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISREC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISREC.AppearanceHeader.Options.UseFont = true;
            this.colISREC.AppearanceHeader.Options.UseTextOptions = true;
            this.colISREC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colISREC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISREC.FieldName = "ISREC";
            this.colISREC.Name = "colISREC";
            this.colISREC.OptionsColumn.AllowEdit = false;
            this.colISREC.OptionsColumn.ReadOnly = true;
            // 
            // colDOWNFILENO
            // 
            this.colDOWNFILENO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDOWNFILENO.AppearanceCell.Options.UseFont = true;
            this.colDOWNFILENO.AppearanceCell.Options.UseTextOptions = true;
            this.colDOWNFILENO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOWNFILENO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDOWNFILENO.AppearanceHeader.Options.UseFont = true;
            this.colDOWNFILENO.AppearanceHeader.Options.UseTextOptions = true;
            this.colDOWNFILENO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDOWNFILENO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOWNFILENO.FieldName = "DOWNFILENO";
            this.colDOWNFILENO.Name = "colDOWNFILENO";
            this.colDOWNFILENO.OptionsColumn.AllowEdit = false;
            this.colDOWNFILENO.OptionsColumn.ReadOnly = true;
            // 
            // colAFILENO
            // 
            this.colAFILENO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAFILENO.AppearanceCell.Options.UseFont = true;
            this.colAFILENO.AppearanceCell.Options.UseTextOptions = true;
            this.colAFILENO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAFILENO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAFILENO.AppearanceHeader.Options.UseFont = true;
            this.colAFILENO.AppearanceHeader.Options.UseTextOptions = true;
            this.colAFILENO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAFILENO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAFILENO.FieldName = "AFILENO";
            this.colAFILENO.Name = "colAFILENO";
            this.colAFILENO.OptionsColumn.AllowEdit = false;
            this.colAFILENO.OptionsColumn.ReadOnly = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.ribbon;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(244, 340);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.GridControl2DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.PreviewFieldName = "NOTE";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Doc #";
            this.gridColumn1.FieldName = "TRANID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 113;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "Tran.Dt.";
            this.gridColumn2.FieldName = "TRANDATE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 137;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DataDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 515);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataDisk";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Data Disk";
            this.Activated += new System.EventHandler(this.DataDisk_Activated);
            this.Load += new System.EventHandler(this.DataDisk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastMoveTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERMAINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbon;
        private RibbonPage ribbonPage1;
        private RibbonStatusBar ribbonStatusBar;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarEditItem barEditItem2;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private RibbonPageGroup ribbonPageGroup2;
        private RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private BarButtonItem barButtonItem1;
        private SplitContainerControl splitContainerControl1;
        private BarStaticItem barStaticItem2;
        private BarStaticItem barStaticItem4;
        private BarEditItem barEditItem5;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private BarStaticItem barStaticItem1;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource iTEMTRANSFERMAINBindingSource;
        private GridColumn colTRANID;
        private GridColumn colTOSTOREID;
        private GridColumn colTRANDATE;
        private GridColumn colUSERID;
        private GridColumn colUDATE;
        private GridColumn colHOLD;
        private GridColumn colEUSERID;
        private GridColumn colEDATE;
        private GridColumn colTOTVALUE;
        private GridColumn colTOTITEMS;
        private GridColumn colNOTE;
        private GridColumn colTTYPE;
        private GridColumn colCOMPANY;
        private GridColumn colFRMSTOREID;
        private GridColumn colFRMNAME;
        private GridColumn colTONAME;
        private GridColumn colISREC;
        private GridColumn colDOWNFILENO;
        private GridColumn colAFILENO;
        private GridControl gridControl2;
        private GridView gridView2;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private BindingSource mastMoveTypesBindingSource;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private OpenFileDialog openFileDialog1;
        private BarButtonItem barButtonItem3;
        private BarEditItem targetloc;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private BarButtonItem barButtonItem2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private BarButtonItem barButtonItem4;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private BarButtonItem barButtonItem8;
        private BarEditItem barEditItem1;
        private RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private RibbonPageGroup ribbonPageGroup3;
        private BarEditItem barEditItem3;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
        private BarEditItem barEditItem4;
        private RepositoryItemTextEdit repositoryItemTextEdit2;
        private GridColumn gridColumn3;
        private BarButtonItem barButtonItem9;
        private BarButtonItem barButtonItem10;
        private RibbonPageGroup ribbonPageGroup4;
    }
}