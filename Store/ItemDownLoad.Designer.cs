using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;
using VIRETAILENTITIES;

namespace Store
{
    partial class ItemDownLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDownLoad));
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iTEMTRANSFERDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventory1 = new VIRETAILENTITIES.DsInventory();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnbrowse = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.barstatus = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerBottom = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.dataDownLoadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hideContainerTop = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.iTEMTRANSFERMAINLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRANID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookupto = new DevExpress.XtraEditors.LookUpEdit();
            this.lookupfrom = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRANID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLINETOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.hideContainerBottom.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDownLoadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.hideContainerTop.SuspendLayout();
            this.dockPanel4.SuspendLayout();
            this.dockPanel4_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERMAINLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupfrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pml";
            this.openFileDialog1.Filter = "pmlfiles|*.pml";
            // 
            // iTEMTRANSFERDETAILBindingSource
            // 
            this.iTEMTRANSFERDETAILBindingSource.DataMember = "TranferItemListWithItemname";
            this.iTEMTRANSFERDETAILBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // dsInventory1
            // 
            this.dsInventory1.DataSetName = "DsInventory";
            this.dsInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnbrowse,
            this.barButtonItem2,
            this.btnsave,
            this.barEditItem3,
            this.barstatus,
            this.barButtonItem1,
            this.barEditItem1,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemComboBox1,
            this.repositoryItemCheckedComboBoxEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barEditItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnbrowse, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barstatus, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Download From :";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 7;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 104;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Remote Server",
            "From File"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Caption = "Get Data";
            this.btnbrowse.Glyph = global::Store.Properties.Resources.folder1;
            this.btnbrowse.Id = 0;
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Print";
            this.barButtonItem2.Glyph = global::Store.Properties.Resources.printer1;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnsave
            // 
            this.btnsave.Caption = "Save";
            this.btnsave.Glyph = global::Store.Properties.Resources.Save16;
            this.btnsave.Id = 2;
            this.btnsave.Name = "btnsave";
            this.btnsave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barstatus
            // 
            this.barstatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barstatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barstatus.Glyph = global::Store.Properties.Resources.error;
            this.barstatus.Id = 5;
            this.barstatus.Name = "barstatus";
            this.barstatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barstatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barstatus.Width = 32;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "History";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.date_magnify;
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(810, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 520);
            this.barDockControlBottom.Size = new System.Drawing.Size(810, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(810, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerBottom,
            this.hideContainerTop});
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2,
            this.dockPanel3});
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerBottom
            // 
            this.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.hideContainerBottom.Controls.Add(this.dockPanel1);
            this.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hideContainerBottom.Location = new System.Drawing.Point(0, 497);
            this.hideContainerBottom.Name = "hideContainerBottom";
            this.hideContainerBottom.Size = new System.Drawing.Size(810, 23);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel1.ID = new System.Guid("fc82468f-2496-48c0-b8e9-d4a9aefc43fb");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.AllowFloating = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(810, 200);
            this.dockPanel1.Text = "Received Documents";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gridControl2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(802, 173);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.dataDownLoadsBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(802, 173);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dataDownLoadsBindingSource
            // 
            this.dataDownLoadsBindingSource.DataMember = "DataDownLoads";
            this.dataDownLoadsBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocno,
            this.colDocDate,
            this.colFromStore,
            this.colStatus});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDocno, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDocno
            // 
            this.colDocno.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDocno.AppearanceCell.Options.UseFont = true;
            this.colDocno.AppearanceCell.Options.UseTextOptions = true;
            this.colDocno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDocno.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDocno.AppearanceHeader.Options.UseFont = true;
            this.colDocno.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocno.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDocno.Caption = "Doc No.";
            this.colDocno.FieldName = "Docno";
            this.colDocno.Name = "colDocno";
            this.colDocno.Visible = true;
            this.colDocno.VisibleIndex = 0;
            this.colDocno.Width = 91;
            // 
            // colDocDate
            // 
            this.colDocDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDocDate.AppearanceCell.Options.UseFont = true;
            this.colDocDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDocDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDocDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDocDate.AppearanceHeader.Options.UseFont = true;
            this.colDocDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 1;
            this.colDocDate.Width = 99;
            // 
            // colFromStore
            // 
            this.colFromStore.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFromStore.AppearanceCell.Options.UseFont = true;
            this.colFromStore.AppearanceCell.Options.UseTextOptions = true;
            this.colFromStore.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFromStore.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFromStore.AppearanceHeader.Options.UseFont = true;
            this.colFromStore.AppearanceHeader.Options.UseTextOptions = true;
            this.colFromStore.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFromStore.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFromStore.FieldName = "FromStore";
            this.colFromStore.Name = "colFromStore";
            this.colFromStore.Visible = true;
            this.colFromStore.VisibleIndex = 2;
            this.colFromStore.Width = 142;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStatus.AppearanceCell.Options.UseFont = true;
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStatus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStatus.AppearanceHeader.Options.UseFont = true;
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 452;
            // 
            // hideContainerTop
            // 
            this.hideContainerTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.hideContainerTop.Controls.Add(this.dockPanel4);
            this.hideContainerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.hideContainerTop.Location = new System.Drawing.Point(0, 31);
            this.hideContainerTop.Name = "hideContainerTop";
            this.hideContainerTop.Size = new System.Drawing.Size(810, 23);
            this.hideContainerTop.Visible = false;
            this.hideContainerTop.Click += new System.EventHandler(this.hideContainerTop_Click);
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel4.ID = new System.Guid("2384451e-c010-4107-bf50-d59fc0502769");
            this.dockPanel4.Location = new System.Drawing.Point(0, 0);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.Options.AllowDockAsTabbedDocument = false;
            this.dockPanel4.Options.AllowDockBottom = false;
            this.dockPanel4.Options.AllowDockLeft = false;
            this.dockPanel4.Options.AllowDockRight = false;
            this.dockPanel4.Options.AllowFloating = false;
            this.dockPanel4.Options.FloatOnDblClick = false;
            this.dockPanel4.Options.ShowCloseButton = false;
            this.dockPanel4.Options.ShowMaximizeButton = false;
            this.dockPanel4.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel4.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel4.SavedIndex = 0;
            this.dockPanel4.Size = new System.Drawing.Size(810, 200);
            this.dockPanel4.Text = "History";
            this.dockPanel4.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Controls.Add(this.gridControl3);
            this.dockPanel4_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(802, 171);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.iTEMTRANSFERMAINLISTBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.MenuManager = this.barManager1;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(802, 171);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gridControl3.DoubleClick += new System.EventHandler(this.gridControl3_DoubleClick);
            // 
            // iTEMTRANSFERMAINLISTBindingSource
            // 
            this.iTEMTRANSFERMAINLISTBindingSource.DataMember = "ITEMTRANSFERMAINLIST";
            this.iTEMTRANSFERMAINLISTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView3.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(183)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView3.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Empty.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView3.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(126)))));
            this.gridView3.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(128)))), ((int)(((byte)(88)))));
            this.gridView3.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView3.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView3.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView3.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView3.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView3.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView3.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(126)))));
            this.gridView3.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView3.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView3.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseFont = true;
            this.gridView3.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView3.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(170)))));
            this.gridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView3.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(168)))), ((int)(((byte)(128)))));
            this.gridView3.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView3.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.gridView3.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView3.Appearance.Preview.Options.UseBackColor = true;
            this.gridView3.Appearance.Preview.Options.UseForeColor = true;
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Appearance.Row.Options.UseForeColor = true;
            this.gridView3.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(133)))));
            this.gridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView3.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.gridView3.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANID1,
            this.colTRANDATE,
            this.colFRMNAME,
            this.colTONAME,
            this.colTOTVALUE,
            this.colTOSTOREID,
            this.colFRMSTOREID,
            this.colNOTE});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.PreviewLineCount = 1;
            // 
            // colTRANID1
            // 
            this.colTRANID1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANID1.AppearanceCell.Options.UseFont = true;
            this.colTRANID1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANID1.AppearanceHeader.Options.UseFont = true;
            this.colTRANID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANID1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID1.Caption = "File No.";
            this.colTRANID1.FieldName = "TRANID";
            this.colTRANID1.MaxWidth = 90;
            this.colTRANID1.Name = "colTRANID1";
            this.colTRANID1.OptionsColumn.AllowEdit = false;
            this.colTRANID1.OptionsColumn.ReadOnly = true;
            this.colTRANID1.Visible = true;
            this.colTRANID1.VisibleIndex = 0;
            this.colTRANID1.Width = 90;
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceCell.Options.UseFont = true;
            this.colTRANDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceHeader.Options.UseFont = true;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Date";
            this.colTRANDATE.DisplayFormat.FormatString = "dd MMM,yyyy";
            this.colTRANDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.MaxWidth = 90;
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.OptionsColumn.ReadOnly = true;
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 1;
            this.colTRANDATE.Width = 90;
            // 
            // colFRMNAME
            // 
            this.colFRMNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMNAME.AppearanceCell.Options.UseFont = true;
            this.colFRMNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMNAME.AppearanceHeader.Options.UseFont = true;
            this.colFRMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colFRMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFRMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMNAME.Caption = "From Store";
            this.colFRMNAME.FieldName = "FRMNAME";
            this.colFRMNAME.Name = "colFRMNAME";
            this.colFRMNAME.OptionsColumn.AllowEdit = false;
            this.colFRMNAME.OptionsColumn.ReadOnly = true;
            this.colFRMNAME.Visible = true;
            this.colFRMNAME.VisibleIndex = 2;
            this.colFRMNAME.Width = 244;
            // 
            // colTONAME
            // 
            this.colTONAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTONAME.AppearanceCell.Options.UseFont = true;
            this.colTONAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTONAME.AppearanceHeader.Options.UseFont = true;
            this.colTONAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colTONAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTONAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTONAME.Caption = "To Store";
            this.colTONAME.FieldName = "TONAME";
            this.colTONAME.Name = "colTONAME";
            this.colTONAME.OptionsColumn.AllowEdit = false;
            this.colTONAME.OptionsColumn.ReadOnly = true;
            this.colTONAME.Visible = true;
            this.colTONAME.VisibleIndex = 3;
            this.colTONAME.Width = 240;
            // 
            // colTOTVALUE
            // 
            this.colTOTVALUE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTVALUE.AppearanceCell.Options.UseFont = true;
            this.colTOTVALUE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTVALUE.AppearanceHeader.Options.UseFont = true;
            this.colTOTVALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOTVALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOTVALUE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTVALUE.Caption = "Total Value";
            this.colTOTVALUE.DisplayFormat.FormatString = "N2";
            this.colTOTVALUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTVALUE.FieldName = "TOTVALUE";
            this.colTOTVALUE.MaxWidth = 100;
            this.colTOTVALUE.Name = "colTOTVALUE";
            this.colTOTVALUE.OptionsColumn.AllowEdit = false;
            this.colTOTVALUE.OptionsColumn.ReadOnly = true;
            this.colTOTVALUE.Visible = true;
            this.colTOTVALUE.VisibleIndex = 4;
            this.colTOTVALUE.Width = 100;
            // 
            // colTOSTOREID
            // 
            this.colTOSTOREID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOSTOREID.AppearanceCell.Options.UseFont = true;
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
            // colFRMSTOREID
            // 
            this.colFRMSTOREID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMSTOREID.AppearanceCell.Options.UseFont = true;
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
            // colNOTE
            // 
            this.colNOTE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOTE.AppearanceCell.Options.UseFont = true;
            this.colNOTE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOTE.AppearanceHeader.Options.UseFont = true;
            this.colNOTE.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOTE.Caption = "Note";
            this.colNOTE.FieldName = "NOTE";
            this.colNOTE.MaxWidth = 200;
            this.colNOTE.Name = "colNOTE";
            this.colNOTE.OptionsColumn.AllowEdit = false;
            this.colNOTE.OptionsColumn.ReadOnly = true;
            this.colNOTE.Visible = true;
            this.colNOTE.VisibleIndex = 5;
            this.colNOTE.Width = 20;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel2.FloatLocation = new System.Drawing.Point(311, 353);
            this.dockPanel2.ID = new System.Guid("fc08b3b1-e3e9-4fac-8c6b-8c44b2974574");
            this.dockPanel2.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedIndex = 0;
            this.dockPanel2.Size = new System.Drawing.Size(200, 200);
            this.dockPanel2.Text = "dockPanel2";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(192, 171);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel3.ID = new System.Guid("450660f7-5c09-475f-845c-6809caa72a81");
            this.dockPanel3.Location = new System.Drawing.Point(523, 31);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.OriginalSize = new System.Drawing.Size(287, 200);
            this.dockPanel3.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel3.SavedIndex = 0;
            this.dockPanel3.Size = new System.Drawing.Size(287, 466);
            this.dockPanel3.Text = "Negative Stock";
            this.dockPanel3.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(279, 437);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "Down From :";
            this.barEditItem3.Edit = this.repositoryItemComboBox1;
            this.barEditItem3.Id = 4;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Width = 131;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(314, 215);
            this.progressPanel1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(197, 44);
            this.progressPanel1.TabIndex = 41;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lookupto);
            this.groupControl1.Controls.Add(this.lookupfrom);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.memoEdit1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 54);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(810, 83);
            this.groupControl1.TabIndex = 48;
            this.groupControl1.Text = "Download Information";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(596, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 14);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "File Path :";
            this.labelControl1.Visible = false;
            // 
            // lookupto
            // 
            this.lookupto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookupto.Location = new System.Drawing.Point(393, 26);
            this.lookupto.Name = "lookupto";
            this.lookupto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupto.Properties.Appearance.Options.UseFont = true;
            this.lookupto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.lookupto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.lookupto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "STORECODE", 92, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORETYPE", "STORETYPE", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMM", "COMM", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPANY", "COMPANY")});
            this.lookupto.Properties.DisplayMember = "STORENAME";
            this.lookupto.Properties.NullText = "";
            this.lookupto.Properties.ReadOnly = true;
            this.lookupto.Properties.ShowFooter = false;
            this.lookupto.Properties.ShowHeader = false;
            this.lookupto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupto.Properties.ValueMember = "STORECODE";
            this.lookupto.Size = new System.Drawing.Size(193, 20);
            this.lookupto.TabIndex = 42;
            // 
            // lookupfrom
            // 
            this.lookupfrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookupfrom.Location = new System.Drawing.Point(107, 26);
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
            this.lookupfrom.Size = new System.Drawing.Size(193, 20);
            this.lookupfrom.TabIndex = 41;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(596, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 14);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Issue for sale :";
            this.labelControl4.Visible = false;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(681, 62);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Size = new System.Drawing.Size(23, 19);
            this.checkEdit1.TabIndex = 39;
            this.checkEdit1.Visible = false;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(690, 26);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Size = new System.Drawing.Size(99, 20);
            this.textEdit2.TabIndex = 38;
            this.textEdit2.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(642, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 14);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Doc # :";
            this.labelControl3.Visible = false;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(107, 53);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.memoEdit1.Properties.Appearance.Options.UseFont = true;
            this.memoEdit1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.memoEdit1.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.memoEdit1.Properties.ReadOnly = true;
            this.memoEdit1.Size = new System.Drawing.Size(479, 25);
            this.memoEdit1.TabIndex = 35;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(17, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 14);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Note :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(314, 29);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 14);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "To Location :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(17, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 14);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "From Location :";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(748, 61);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textEdit1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(41, 20);
            this.textEdit1.TabIndex = 32;
            this.textEdit1.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.iTEMTRANSFERDETAILBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 137);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(810, 360);
            this.gridControl1.TabIndex = 49;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANID,
            this.colBARCODE,
            this.colQTY,
            this.gridColumn1,
            this.colSPRICE,
            this.colEXPDATE,
            this.colLINETOTAL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ITEMNO", this.colBARCODE, "Count {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", this.colLINETOTAL, "{0:###,###,###.00}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRANID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colTRANID.Caption = "File No.";
            this.colTRANID.FieldName = "TRANID";
            this.colTRANID.Name = "colTRANID";
            this.colTRANID.OptionsColumn.AllowEdit = false;
            this.colTRANID.Visible = true;
            this.colTRANID.VisibleIndex = 0;
            this.colTRANID.Width = 89;
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
            this.colBARCODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 0;
            this.colBARCODE.Width = 141;
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
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 37;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Item name";
            this.gridColumn1.FieldName = "ITEMNAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 330;
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
            this.colSPRICE.Caption = "Price";
            this.colSPRICE.DisplayFormat.FormatString = "N2";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 4;
            this.colSPRICE.Width = 52;
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
            this.colEXPDATE.OptionsColumn.AllowEdit = false;
            this.colEXPDATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.VisibleIndex = 2;
            this.colEXPDATE.Width = 58;
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
            this.colLINETOTAL.Caption = "Total";
            this.colLINETOTAL.DisplayFormat.FormatString = "N2";
            this.colLINETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLINETOTAL.FieldName = "LINETOTAL";
            this.colLINETOTAL.Name = "colLINETOTAL";
            this.colLINETOTAL.OptionsColumn.AllowEdit = false;
            this.colLINETOTAL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLINETOTAL.Visible = true;
            this.colLINETOTAL.VisibleIndex = 5;
            this.colLINETOTAL.Width = 85;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // ItemDownLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 541);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.hideContainerTop);
            this.Controls.Add(this.hideContainerBottom);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemDownLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemDownLoad_Load);
            this.Resize += new System.EventHandler(this.ItemDownLoad_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.hideContainerBottom.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDownLoadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.hideContainerTop.ResumeLayout(false);
            this.dockPanel4.ResumeLayout(false);
            this.dockPanel4_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERMAINLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupfrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private BindingSource iTEMTRANSFERDETAILBindingSource;
        private DsInventory dsInventory1;
        private BarManager barManager1;
        private Bar bar1;
        private BarButtonItem btnbrowse;
        private BarButtonItem barButtonItem2;
        private BarButtonItem btnsave;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private BarEditItem barEditItem3;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private DockManager dockManager1;
        private BindingSource dataDownLoadsBindingSource;
        private DockPanel dockPanel1;
        private ControlContainer dockPanel1_Container;
        private ProgressPanel progressPanel1;
        private BarStaticItem barstatus;
        private AutoHideContainer hideContainerBottom;
        private GridControl gridControl2;
        private GridView gridView2;
        private GridColumn colDocno;
        private GridColumn colDocDate;
        private GridColumn colFromStore;
        private GridColumn colStatus;
        private BarEditItem barEditItem1;
        private RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private BarButtonItem barButtonItem1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colTRANID;
        private GridColumn colBARCODE;
        private GridColumn colQTY;
        private GridColumn colSPRICE;
        private GridColumn colEXPDATE;
        private GridColumn colLINETOTAL;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private GroupControl groupControl1;
        private LabelControl labelControl1;
        protected LookUpEdit lookupto;
        protected LookUpEdit lookupfrom;
        private LabelControl labelControl4;
        private CheckEdit checkEdit1;
        private TextEdit textEdit2;
        private LabelControl labelControl3;
        private MemoEdit memoEdit1;
        private LabelControl labelControl2;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private TextEdit textEdit1;
        private DockPanel dockPanel3;
        private ControlContainer dockPanel3_Container;
        private DockPanel dockPanel2;
        private ControlContainer dockPanel2_Container;
        private BarButtonItem barButtonItem3;
        private GridColumn gridColumn1;
        private DockPanel dockPanel4;
        private ControlContainer dockPanel4_Container;
        private GridControl gridControl3;
        private GridView gridView3;
        private BindingSource iTEMTRANSFERMAINLISTBindingSource;
        private GridColumn colTRANID1;
        private GridColumn colTRANDATE;
        private GridColumn colFRMNAME;
        private GridColumn colTONAME;
        private GridColumn colTOTVALUE;
        private GridColumn colTOSTOREID;
        private GridColumn colFRMSTOREID;
        private GridColumn colNOTE;
        private AutoHideContainer hideContainerTop;

    }
}