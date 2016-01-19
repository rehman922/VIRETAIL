using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class BarCodePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarCodePrint));
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnstopprinting = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tEMPBCODEPRINTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEMPBCODEPRINTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.LookAndFeel.SkinName = "Office 2010 Blue";
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barEditItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnstopprinting,
            this.barEditItem2,
            this.barEditItem3,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barEditItem4,
            this.barButtonItem8});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemProgressBar1,
            this.repositoryItemComboBox1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(876, 117);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Purchase Doc No. :";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 1;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 120;
            this.barEditItem1.EditValueChanged += new System.EventHandler(this.barEditItem1_EditValueChanged);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "From Purhase Docs.";
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.invoice6;
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Print Labels";
            this.barButtonItem2.Glyph = global::Store.Properties.Resources.printer1;
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem2.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "From Inventory";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.page_white_magnify;
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnstopprinting
            // 
            this.btnstopprinting.Caption = "Pause Printing";
            this.btnstopprinting.Enabled = false;
            this.btnstopprinting.Id = 6;
            this.btnstopprinting.LargeGlyph = global::Store.Properties.Resources.printpause;
            this.btnstopprinting.Name = "btnstopprinting";
            this.btnstopprinting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnstopprinting_ItemClick);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem2.Edit = this.repositoryItemProgressBar1;
            this.barEditItem2.Id = 9;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 250;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "Transfer Doc No. :";
            this.barEditItem3.Edit = this.repositoryItemTextEdit3;
            this.barEditItem3.Id = 11;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Width = 120;
            this.barEditItem3.EditValueChanged += new System.EventHandler(this.barEditItem3_EditValueChanged);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "From Transfer Docs.";
            this.barButtonItem6.Glyph = global::Store.Properties.Resources.rec24;
            this.barButtonItem6.Id = 14;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "From Item Master";
            this.barButtonItem7.Glyph = global::Store.Properties.Resources.viewlist16;
            this.barButtonItem7.Id = 15;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "Printer :";
            this.barEditItem4.Edit = this.repositoryItemComboBox1;
            this.barEditItem4.Id = 16;
            this.barEditItem4.Name = "barEditItem4";
            this.barEditItem4.Width = 200;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "New";
            this.barButtonItem8.Id = 17;
            this.barButtonItem8.LargeGlyph = global::Store.Properties.Resources.page_white_star;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Barcode Printing";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem1, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem4, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnstopprinting, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Menu";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barEditItem2);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 488);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(876, 27);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tEMPBCODEPRINTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 117);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit4});
            this.gridControl1.Size = new System.Drawing.Size(876, 398);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tEMPBCODEPRINTBindingSource
            // 
            this.tEMPBCODEPRINTBindingSource.DataMember = "TEMPBCODEPRINT";
            this.tEMPBCODEPRINTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colITEMCODE,
            this.colITEMNAME,
            this.colQTY,
            this.colPQTY,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceHeader.Options.UseFont = true;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.ReadOnly = true;
            // 
            // colITEMCODE
            // 
            this.colITEMCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMCODE.AppearanceHeader.Options.UseFont = true;
            this.colITEMCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMCODE.Caption = "BarCode";
            this.colITEMCODE.FieldName = "ITEMCODE";
            this.colITEMCODE.Name = "colITEMCODE";
            this.colITEMCODE.OptionsColumn.AllowEdit = false;
            this.colITEMCODE.Visible = true;
            this.colITEMCODE.VisibleIndex = 0;
            this.colITEMCODE.Width = 142;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNAME.AppearanceHeader.Options.UseFont = true;
            this.colITEMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.Caption = "Itemname";
            this.colITEMNAME.FieldName = "ITEMNAME";
            this.colITEMNAME.Name = "colITEMNAME";
            this.colITEMNAME.OptionsColumn.AllowEdit = false;
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 1;
            this.colITEMNAME.Width = 442;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Qty.";
            this.colQTY.DisplayFormat.FormatString = "N";
            this.colQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 65;
            // 
            // colPQTY
            // 
            this.colPQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colPQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPQTY.AppearanceHeader.Options.UseFont = true;
            this.colPQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colPQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPQTY.Caption = "Printed";
            this.colPQTY.FieldName = "PQTY";
            this.colPQTY.Name = "colPQTY";
            this.colPQTY.OptionsColumn.AllowEdit = false;
            this.colPQTY.Visible = true;
            this.colPQTY.VisibleIndex = 4;
            this.colPQTY.Width = 62;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Price";
            this.gridColumn1.ColumnEdit = this.repositoryItemTextEdit4;
            this.gridColumn1.DisplayFormat.FormatString = "N2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "PRICE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 44;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.DisplayFormat.FormatString = "N2";
            this.repositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit4.EditFormat.FormatString = "N2";
            this.repositoryItemTextEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit4.Mask.EditMask = "n2";
            this.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Select Transfer Docs.";
            this.barButtonItem4.Glyph = global::Store.Properties.Resources.rec24;
            this.barButtonItem4.Id = -1;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = -1;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // BarCodePrint
            // 
            this.ClientSize = new System.Drawing.Size(876, 515);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarCodePrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarCode Printing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarCodePrint_FormClosing);
            this.Load += new System.EventHandler(this.BarCodePrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEMPBCODEPRINTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarEditItem barEditItem1;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private GridControl gridControl1;
        private GridView gridView1;
        private BarButtonItem btnstopprinting;
        private BindingSource tEMPBCODEPRINTBindingSource;
        private GridColumn colTID;
        private GridColumn colITEMCODE;
        private GridColumn colITEMNAME;
        private GridColumn colQTY;
        private GridColumn colPQTY;
        private PrintDialog printDialog1;
        private GridColumn gridColumn1;
        private RibbonStatusBar ribbonStatusBar1;
        private BarEditItem barEditItem2;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private BarEditItem barEditItem3;
        private BarButtonItem barButtonItem6;
        private RepositoryItemTextEdit repositoryItemTextEdit2;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem7;
        private RepositoryItemTextEdit repositoryItemTextEdit3;
        private BarEditItem barEditItem4;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private RepositoryItemTextEdit repositoryItemTextEdit4;
        private BarButtonItem barButtonItem8;



    }
}