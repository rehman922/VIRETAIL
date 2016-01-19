using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace Store
{
    partial class DataSyncForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSyncForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.txtstatus = new DevExpress.XtraBars.BarStaticItem();
            this.BtnUploadPromotions = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDownloadPromotions = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataDownLoadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDownLoadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.txtstatus,
            this.BtnUploadPromotions,
            this.BtnDownloadPromotions});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(531, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Download Commision Items && Customers";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = global::Store.Properties.Resources.ddown;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Upload";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.LargeGlyph = global::Store.Properties.Resources.dataup;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Settings";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.LargeGlyph = global::Store.Properties.Resources.tools;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Receive History";
            this.barButtonItem5.Glyph = global::Store.Properties.Resources.download;
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Transfer History";
            this.barButtonItem6.Glyph = global::Store.Properties.Resources.upreport;
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // txtstatus
            // 
            this.txtstatus.Id = 8;
            this.txtstatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.ItemAppearance.Normal.Options.UseFont = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // BtnUploadPromotions
            // 
            this.BtnUploadPromotions.Caption = "Upload Promotions";
            this.BtnUploadPromotions.Glyph = ((System.Drawing.Image)(resources.GetObject("BtnUploadPromotions.Glyph")));
            this.BtnUploadPromotions.Id = 9;
            this.BtnUploadPromotions.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnUploadPromotions.LargeGlyph")));
            this.BtnUploadPromotions.Name = "BtnUploadPromotions";
            this.BtnUploadPromotions.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.BtnUploadPromotions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // BtnDownloadPromotions
            // 
            this.BtnDownloadPromotions.Caption = "Download Promotions";
            this.BtnDownloadPromotions.Glyph = ((System.Drawing.Image)(resources.GetObject("BtnDownloadPromotions.Glyph")));
            this.BtnDownloadPromotions.Id = 10;
            this.BtnDownloadPromotions.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnDownloadPromotions.LargeGlyph")));
            this.BtnDownloadPromotions.Name = "BtnDownloadPromotions";
            this.BtnDownloadPromotions.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.BtnDownloadPromotions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Data Sync";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUploadPromotions, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDownloadPromotions, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Action";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Options";
            this.ribbonPageGroup2.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Reports";
            this.ribbonPageGroup3.Visible = false;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtstatus);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 458);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(531, 31);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataDownLoadsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(531, 314);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataDownLoadsBindingSource
            // 
            this.dataDownLoadsBindingSource.DataMember = "DataDownLoads";
            this.dataDownLoadsBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocno,
            this.colDocDate,
            this.colFromStore,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFromStore, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDocno
            // 
            this.colDocno.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocno.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDocno.Caption = "Doc #";
            this.colDocno.FieldName = "Docno";
            this.colDocno.Name = "colDocno";
            this.colDocno.Visible = true;
            this.colDocno.VisibleIndex = 0;
            this.colDocno.Width = 146;
            // 
            // colDocDate
            // 
            this.colDocDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 1;
            this.colDocDate.Width = 107;
            // 
            // colFromStore
            // 
            this.colFromStore.AppearanceHeader.Options.UseTextOptions = true;
            this.colFromStore.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFromStore.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFromStore.Caption = "Transfer Type";
            this.colFromStore.FieldName = "FromStore";
            this.colFromStore.Name = "colFromStore";
            this.colFromStore.Visible = true;
            this.colFromStore.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 329;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(19, 167);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(200, 56);
            this.progressPanel1.TabIndex = 5;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // DataSyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 489);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataSyncForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Data Sync";
            this.Load += new System.EventHandler(this.DataSyncForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDownLoadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbon;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private RibbonStatusBar ribbonStatusBar;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem barButtonItem4;
        private RibbonPageGroup ribbonPageGroup3;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem6;
        private RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource dataDownLoadsBindingSource;
        private GridColumn colDocno;
        private GridColumn colDocDate;
        private GridColumn colFromStore;
        private GridColumn colStatus;
        private BarStaticItem txtstatus;
        private ProgressPanel progressPanel1;
        private BarButtonItem BtnUploadPromotions;
        private BarButtonItem BtnDownloadPromotions;
    }
}