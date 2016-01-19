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
    partial class PaymentSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentSelection));
            this.colINVAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.btnprint = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnpost = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.aRAPRECEIPTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.aRAPRECEIPTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemPopupContainerEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit5 = new DevExpress.XtraEditors.CheckEdit();
            this.LookupSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lookupbankname = new DevExpress.XtraEditors.LookUpEdit();
            this.bANKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.aRAPRECEIPTSDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ledgers1 = new VIRETAILENTITIES.Ledgers();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARAPTRANID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUEDAYS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAIDAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBALANCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISCOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppliedAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.lookupbatch = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRAPRECEIPTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRAPRECEIPTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupbankname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRAPRECEIPTSDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupbatch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colINVAMOUNT
            // 
            this.colINVAMOUNT.AppearanceCell.Options.UseTextOptions = true;
            this.colINVAMOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVAMOUNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVAMOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVAMOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVAMOUNT.Caption = "Invoice Amt.";
            this.colINVAMOUNT.DisplayFormat.FormatString = "###,###,###,###.##";
            this.colINVAMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVAMOUNT.FieldName = "INVAMOUNT";
            this.colINVAMOUNT.Name = "colINVAMOUNT";
            this.colINVAMOUNT.OptionsColumn.AllowEdit = false;
            this.colINVAMOUNT.OptionsColumn.ReadOnly = true;
            this.colINVAMOUNT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "INVAMOUNT", "{0:#,0.00}")});
            this.colINVAMOUNT.Visible = true;
            this.colINVAMOUNT.VisibleIndex = 3;
            this.colINVAMOUNT.Width = 72;
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
            this.btnsave,
            this.barButtonItem3,
            this.btnpost,
            this.btnprint,
            this.barButtonItem5,
            this.barEditItem1,
            this.barEditItem2,
            this.btndelete,
            this.barButtonItem1,
            this.barStaticItem1,
            this.barStaticItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 21;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemLookUpEdit4,
            this.repositoryItemPopupContainerEdit2,
            this.repositoryItemLookUpEdit5});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnprint, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnpost, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "New";
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.page_white_star16;
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // btnsave
            // 
            this.btnsave.Caption = "&Batch";
            this.btnsave.Glyph = global::Store.Properties.Resources.tag;
            this.btnsave.Id = 0;
            this.btnsave.Name = "btnsave";
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnprint
            // 
            this.btnprint.Caption = "&Print";
            this.btnprint.Glyph = global::Store.Properties.Resources.printer1;
            this.btnprint.Id = 4;
            this.btnprint.Name = "btnprint";
            this.btnprint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnprint_ItemClick);
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Revese - Invoices";
            this.btndelete.Enabled = false;
            this.btndelete.Glyph = global::Store.Properties.Resources.Delete16;
            this.btndelete.Id = 16;
            this.btndelete.Name = "btndelete";
            this.btndelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndelete_ItemClick);
            // 
            // btnpost
            // 
            this.btnpost.Caption = "Reverse - Batch";
            this.btnpost.Enabled = false;
            this.btnpost.Glyph = global::Store.Properties.Resources.arrowreturn;
            this.btnpost.Id = 3;
            this.btnpost.Name = "btnpost";
            this.btnpost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnpost_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Paid List";
            this.barStaticItem2.Id = 19;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Batch Nos";
            this.barEditItem1.Edit = this.repositoryItemLookUpEdit2;
            this.barEditItem1.Id = 7;
            this.barEditItem1.ItemAppearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.barEditItem1.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 100;
            this.barEditItem1.EditValueChanged += new System.EventHandler(this.barEditItem1_EditValueChanged);
            this.barEditItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem1_ItemClick);
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.repositoryItemLookUpEdit2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemLookUpEdit2.Appearance.Options.UseBackColor = true;
            this.repositoryItemLookUpEdit2.Appearance.Options.UseFont = true;
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARAPTRANID", "Batch No.", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TDATE", "Date", 42, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AMOUNT", "Amount", 53, DevExpress.Utils.FormatType.Numeric, "N2", true, DevExpress.Utils.HorzAlignment.Far)});
            this.repositoryItemLookUpEdit2.DataSource = this.aRAPRECEIPTSBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "ARAPTRANID";
            this.repositoryItemLookUpEdit2.DropDownRows = 15;
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "Paid List";
            this.repositoryItemLookUpEdit2.ShowFooter = false;
            this.repositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit2.ValueMember = "ARAPTRANID";
            // 
            // aRAPRECEIPTSBindingSource
            // 
            this.aRAPRECEIPTSBindingSource.DataMember = "ARAPRECEIPTS";
            this.aRAPRECEIPTSBindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Postee Batch";
            this.barEditItem2.Edit = this.repositoryItemLookUpEdit5;
            this.barEditItem2.Id = 15;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barEditItem2.Width = 10;
            this.barEditItem2.EditValueChanged += new System.EventHandler(this.barEditItem2_EditValueChanged);
            this.barEditItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem2_ItemClick);
            // 
            // repositoryItemLookUpEdit5
            // 
            this.repositoryItemLookUpEdit5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.repositoryItemLookUpEdit5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemLookUpEdit5.Appearance.Options.UseBackColor = true;
            this.repositoryItemLookUpEdit5.Appearance.Options.UseFont = true;
            this.repositoryItemLookUpEdit5.AutoHeight = false;
            this.repositoryItemLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit5.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARAPTRANID", "Batch No.", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TDATE", "Date", 42, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AMOUNT", "Amount", 53, DevExpress.Utils.FormatType.Numeric, "N2", true, DevExpress.Utils.HorzAlignment.Far)});
            this.repositoryItemLookUpEdit5.DataSource = this.aRAPRECEIPTSBindingSource1;
            this.repositoryItemLookUpEdit5.DisplayMember = "ARAPTRANID";
            this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
            this.repositoryItemLookUpEdit5.NullText = "Posted Batch No\'s";
            this.repositoryItemLookUpEdit5.ShowFooter = false;
            this.repositoryItemLookUpEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit5.ValueMember = "ARAPTRANID";
            // 
            // aRAPRECEIPTSBindingSource1
            // 
            this.aRAPRECEIPTSBindingSource1.DataMember = "ARAPRECEIPTS";
            this.aRAPRECEIPTSBindingSource1.DataSource = typeof(VIRETAILENTITIES.Ledgers);
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
            this.barDockControlTop.Size = new System.Drawing.Size(785, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 451);
            this.barDockControlBottom.Size = new System.Drawing.Size(785, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(785, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "&List";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.viewlist16;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Batch Nos";
            this.barButtonItem5.Glyph = global::Store.Properties.Resources.Report;
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Paid List";
            this.barStaticItem1.Id = 18;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            // 
            // repositoryItemPopupContainerEdit2
            // 
            this.repositoryItemPopupContainerEdit2.AutoHeight = false;
            this.repositoryItemPopupContainerEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit2.Name = "repositoryItemPopupContainerEdit2";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNAME", "SUPPLIERNAME", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit3.DataSource = this.sUPPLIERBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "SUPPLIERNAME";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit3.ValueMember = "SUPPLIERNO";
            this.repositoryItemLookUpEdit3.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataMember = "SUPPLIER";
            this.sUPPLIERBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkEdit5);
            this.groupControl1.Controls.Add(this.LookupSupplier);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.checkEdit2);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(785, 49);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Filter";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // checkEdit5
            // 
            this.checkEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit5.Location = new System.Drawing.Point(707, 25);
            this.checkEdit5.MenuManager = this.barManager1;
            this.checkEdit5.Name = "checkEdit5";
            this.checkEdit5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit5.Properties.Appearance.Options.UseFont = true;
            this.checkEdit5.Properties.Caption = "Check All";
            this.checkEdit5.Size = new System.Drawing.Size(75, 19);
            this.checkEdit5.TabIndex = 7;
            this.checkEdit5.CheckedChanged += new System.EventHandler(this.checkEdit5_CheckedChanged);
            // 
            // LookupSupplier
            // 
            this.LookupSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookupSupplier.Enabled = false;
            this.LookupSupplier.EnterMoveNextControl = true;
            this.LookupSupplier.Location = new System.Drawing.Point(210, 24);
            this.LookupSupplier.Name = "LookupSupplier";
            this.LookupSupplier.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.LookupSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LookupSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.LookupSupplier.Properties.Appearance.Options.UseFont = true;
            this.LookupSupplier.Properties.Appearance.Options.UseForeColor = true;
            this.LookupSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNAME", "SUPPLIERNAME", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUEDAYS", "DUEDAYS", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.LookupSupplier.Properties.DisplayMember = "SUPPLIERNAME";
            this.LookupSupplier.Properties.NullText = "";
            this.LookupSupplier.Properties.ShowHeader = false;
            this.LookupSupplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupSupplier.Properties.ValueMember = "SUPPLIERNO";
            this.LookupSupplier.Size = new System.Drawing.Size(427, 20);
            this.LookupSupplier.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.funnelicon;
            this.simpleButton1.Location = new System.Drawing.Point(644, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(59, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "&Show";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "90";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(96, 23);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Mask.EditMask = "n0";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Size = new System.Drawing.Size(25, 20);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(124, 24);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "By Supplier :";
            this.checkEdit2.Size = new System.Drawing.Size(86, 19);
            this.checkEdit2.TabIndex = 1;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(8, 24);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "By Due Date";
            this.checkEdit1.Size = new System.Drawing.Size(84, 19);
            this.checkEdit1.TabIndex = 0;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lookupbankname);
            this.panel1.Controls.Add(this.textEdit2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 29);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank name :";
            this.label2.Visible = false;
            // 
            // lookupbankname
            // 
            this.lookupbankname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupbankname.Location = new System.Drawing.Point(526, 4);
            this.lookupbankname.MenuManager = this.barManager1;
            this.lookupbankname.Name = "lookupbankname";
            this.lookupbankname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupbankname.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BANKID", "BANKID", 60, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BANKNAME", "BANKNAME", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookupbankname.Properties.DataSource = this.bANKSBindingSource;
            this.lookupbankname.Properties.DisplayMember = "BANKNAME";
            this.lookupbankname.Properties.NullText = "";
            this.lookupbankname.Properties.ShowFooter = false;
            this.lookupbankname.Properties.ShowHeader = false;
            this.lookupbankname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupbankname.Properties.ValueMember = "BANKID";
            this.lookupbankname.Size = new System.Drawing.Size(255, 20);
            this.lookupbankname.TabIndex = 2;
            this.lookupbankname.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.lookupbankname_ProcessNewValue);
            // 
            // bANKSBindingSource
            // 
            this.bANKSBindingSource.DataMember = "BANKS";
            this.bANKSBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(90, 3);
            this.textEdit2.MenuManager = this.barManager1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Mask.EditMask = "n";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Size = new System.Drawing.Size(142, 20);
            this.textEdit2.TabIndex = 1;
            this.textEdit2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance After :";
            this.label1.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.aRAPRECEIPTSDETAILSBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 73);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit3,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(785, 349);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // aRAPRECEIPTSDETAILSBindingSource
            // 
            this.aRAPRECEIPTSDETAILSBindingSource.DataMember = "ARAPRECEIPTSDETAILS";
            this.aRAPRECEIPTSDETAILSBindingSource.DataSource = this.ledgers1;
            // 
            // ledgers1
            // 
            this.ledgers1.DataSetName = "Ledgers";
            this.ledgers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colARAPTRANID,
            this.colTRANID,
            this.colDUEDAYS,
            this.colREFNO,
            this.colINVOICEDATE,
            this.colINVOICENO,
            this.colINVAMOUNT,
            this.colPAIDAMOUNT,
            this.colBALANCE,
            this.colDISCOUNT,
            this.colAppliedAmt,
            this.colSEL});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colINVAMOUNT;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AppliedAmt", this.colAppliedAmt, "{0:#,0.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BALANCE", this.colBALANCE, "{0:#,0.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "INVAMOUNT", this.colINVAMOUNT, "{0:#,0.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PAIDAMOUNT", this.colPAIDAMOUNT, "{0:#,0.00}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colREFNO, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
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
            // colARAPTRANID
            // 
            this.colARAPTRANID.AppearanceCell.Options.UseTextOptions = true;
            this.colARAPTRANID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colARAPTRANID.AppearanceHeader.Options.UseTextOptions = true;
            this.colARAPTRANID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colARAPTRANID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colARAPTRANID.FieldName = "ARAPTRANID";
            this.colARAPTRANID.Name = "colARAPTRANID";
            this.colARAPTRANID.OptionsColumn.AllowEdit = false;
            this.colARAPTRANID.OptionsColumn.ReadOnly = true;
            // 
            // colTRANID
            // 
            this.colTRANID.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.FieldName = "TRANID";
            this.colTRANID.Name = "colTRANID";
            this.colTRANID.OptionsColumn.AllowEdit = false;
            this.colTRANID.OptionsColumn.ReadOnly = true;
            // 
            // colDUEDAYS
            // 
            this.colDUEDAYS.AppearanceCell.Options.UseTextOptions = true;
            this.colDUEDAYS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDUEDAYS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDUEDAYS.AppearanceHeader.Options.UseTextOptions = true;
            this.colDUEDAYS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDUEDAYS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDUEDAYS.Caption = "Due Days";
            this.colDUEDAYS.FieldName = "DUEDAYS";
            this.colDUEDAYS.MaxWidth = 70;
            this.colDUEDAYS.Name = "colDUEDAYS";
            this.colDUEDAYS.OptionsColumn.AllowEdit = false;
            this.colDUEDAYS.OptionsColumn.ReadOnly = true;
            this.colDUEDAYS.Visible = true;
            this.colDUEDAYS.VisibleIndex = 0;
            this.colDUEDAYS.Width = 54;
            // 
            // colREFNO
            // 
            this.colREFNO.AppearanceCell.Options.UseTextOptions = true;
            this.colREFNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREFNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREFNO.Caption = "Supplier name :";
            this.colREFNO.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.OptionsColumn.AllowEdit = false;
            this.colREFNO.OptionsColumn.ReadOnly = true;
            this.colREFNO.Visible = true;
            this.colREFNO.VisibleIndex = 0;
            // 
            // colINVOICEDATE
            // 
            this.colINVOICEDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVOICEDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVOICEDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVOICEDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVOICEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVOICEDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVOICEDATE.Caption = "Invoice Date";
            this.colINVOICEDATE.DisplayFormat.FormatString = "dd MMM, yyyy";
            this.colINVOICEDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colINVOICEDATE.FieldName = "INVOICEDATE";
            this.colINVOICEDATE.MaxWidth = 100;
            this.colINVOICEDATE.Name = "colINVOICEDATE";
            this.colINVOICEDATE.OptionsColumn.AllowEdit = false;
            this.colINVOICEDATE.OptionsColumn.ReadOnly = true;
            this.colINVOICEDATE.Visible = true;
            this.colINVOICEDATE.VisibleIndex = 1;
            this.colINVOICEDATE.Width = 90;
            // 
            // colINVOICENO
            // 
            this.colINVOICENO.AppearanceCell.Options.UseTextOptions = true;
            this.colINVOICENO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVOICENO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVOICENO.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVOICENO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVOICENO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVOICENO.Caption = "Invoice No.";
            this.colINVOICENO.FieldName = "INVOICENO";
            this.colINVOICENO.Name = "colINVOICENO";
            this.colINVOICENO.OptionsColumn.AllowEdit = false;
            this.colINVOICENO.OptionsColumn.ReadOnly = true;
            this.colINVOICENO.Visible = true;
            this.colINVOICENO.VisibleIndex = 2;
            this.colINVOICENO.Width = 94;
            // 
            // colPAIDAMOUNT
            // 
            this.colPAIDAMOUNT.AppearanceCell.Options.UseTextOptions = true;
            this.colPAIDAMOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPAIDAMOUNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colPAIDAMOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPAIDAMOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPAIDAMOUNT.Caption = "Paid Amt.";
            this.colPAIDAMOUNT.DisplayFormat.FormatString = "###,###,###,###.##";
            this.colPAIDAMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPAIDAMOUNT.FieldName = "PAIDAMOUNT";
            this.colPAIDAMOUNT.Name = "colPAIDAMOUNT";
            this.colPAIDAMOUNT.OptionsColumn.AllowEdit = false;
            this.colPAIDAMOUNT.OptionsColumn.ReadOnly = true;
            this.colPAIDAMOUNT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PAIDAMOUNT", "{0:#,0.00}")});
            this.colPAIDAMOUNT.Visible = true;
            this.colPAIDAMOUNT.VisibleIndex = 4;
            this.colPAIDAMOUNT.Width = 72;
            // 
            // colBALANCE
            // 
            this.colBALANCE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBALANCE.AppearanceCell.Options.UseFont = true;
            this.colBALANCE.AppearanceCell.Options.UseTextOptions = true;
            this.colBALANCE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBALANCE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBALANCE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBALANCE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBALANCE.Caption = "Balance";
            this.colBALANCE.DisplayFormat.FormatString = "###,###,###,###.##";
            this.colBALANCE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBALANCE.FieldName = "BALANCE";
            this.colBALANCE.Name = "colBALANCE";
            this.colBALANCE.OptionsColumn.AllowEdit = false;
            this.colBALANCE.OptionsColumn.ReadOnly = true;
            this.colBALANCE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BALANCE", "{0:#,0.00}")});
            this.colBALANCE.Visible = true;
            this.colBALANCE.VisibleIndex = 5;
            this.colBALANCE.Width = 72;
            // 
            // colDISCOUNT
            // 
            this.colDISCOUNT.AppearanceCell.Options.UseTextOptions = true;
            this.colDISCOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCOUNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISCOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISCOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCOUNT.Caption = "Discount";
            this.colDISCOUNT.DisplayFormat.FormatString = "###,###,###,###.##";
            this.colDISCOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDISCOUNT.FieldName = "DISCOUNT";
            this.colDISCOUNT.MaxWidth = 60;
            this.colDISCOUNT.Name = "colDISCOUNT";
            this.colDISCOUNT.OptionsColumn.AllowEdit = false;
            this.colDISCOUNT.OptionsColumn.ReadOnly = true;
            this.colDISCOUNT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDISCOUNT.Visible = true;
            this.colDISCOUNT.VisibleIndex = 6;
            this.colDISCOUNT.Width = 59;
            // 
            // colAppliedAmt
            // 
            this.colAppliedAmt.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAppliedAmt.AppearanceCell.Options.UseFont = true;
            this.colAppliedAmt.AppearanceCell.Options.UseTextOptions = true;
            this.colAppliedAmt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAppliedAmt.AppearanceHeader.Options.UseTextOptions = true;
            this.colAppliedAmt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAppliedAmt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAppliedAmt.Caption = "Applied Amt.";
            this.colAppliedAmt.ColumnEdit = this.repositoryItemTextEdit1;
            this.colAppliedAmt.DisplayFormat.FormatString = "###,###,###,###.##";
            this.colAppliedAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAppliedAmt.FieldName = "AppliedAmt";
            this.colAppliedAmt.Name = "colAppliedAmt";
            this.colAppliedAmt.OptionsColumn.AllowEdit = false;
            this.colAppliedAmt.OptionsColumn.ReadOnly = true;
            this.colAppliedAmt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AppliedAmt", "{0:#,0.00}")});
            this.colAppliedAmt.Visible = true;
            this.colAppliedAmt.VisibleIndex = 7;
            this.colAppliedAmt.Width = 105;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "###,###,###.##";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colSEL
            // 
            this.colSEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colSEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSEL.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSEL.FieldName = "SEL";
            this.colSEL.Name = "colSEL";
            this.colSEL.Visible = true;
            this.colSEL.VisibleIndex = 8;
            this.colSEL.Width = 35;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            // 
            // checkEdit3
            // 
            this.checkEdit3.EditValue = true;
            this.checkEdit3.Location = new System.Drawing.Point(19, 11);
            this.checkEdit3.MenuManager = this.barManager1;
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "New Batch";
            this.checkEdit3.Size = new System.Drawing.Size(150, 19);
            this.checkEdit3.TabIndex = 0;
            this.checkEdit3.CheckedChanged += new System.EventHandler(this.checkEdit3_CheckedChanged);
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(19, 36);
            this.checkEdit4.MenuManager = this.barManager1;
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "Existing Batch";
            this.checkEdit4.Size = new System.Drawing.Size(150, 19);
            this.checkEdit4.TabIndex = 1;
            this.checkEdit4.CheckedChanged += new System.EventHandler(this.checkEdit4_CheckedChanged);
            // 
            // lookupbatch
            // 
            this.lookupbatch.Enabled = false;
            this.lookupbatch.Location = new System.Drawing.Point(35, 65);
            this.lookupbatch.MenuManager = this.barManager1;
            this.lookupbatch.Name = "lookupbatch";
            this.lookupbatch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupbatch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARAPTRANID", "Batch No.", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TDATE", "Date", 42, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AMOUNT", "Amount", 53, DevExpress.Utils.FormatType.Numeric, "N2", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lookupbatch.Properties.DataSource = this.aRAPRECEIPTSBindingSource1;
            this.lookupbatch.Properties.DisplayMember = "ARAPTRANID";
            this.lookupbatch.Properties.NullText = "";
            this.lookupbatch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupbatch.Properties.ValueMember = "ARAPTRANID";
            this.lookupbatch.Size = new System.Drawing.Size(203, 20);
            this.lookupbatch.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.Save16;
            this.simpleButton2.Location = new System.Drawing.Point(88, 93);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(79, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "&Save";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.CloseOnLostFocus = false;
            this.popupControlContainer1.CloseOnOuterMouseClick = false;
            this.popupControlContainer1.Controls.Add(this.simpleButton2);
            this.popupControlContainer1.Controls.Add(this.checkEdit3);
            this.popupControlContainer1.Controls.Add(this.lookupbatch);
            this.popupControlContainer1.Controls.Add(this.checkEdit4);
            this.popupControlContainer1.Location = new System.Drawing.Point(35, 155);
            this.popupControlContainer1.LookAndFeel.SkinName = "Caramel";
            this.popupControlContainer1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.popupControlContainer1.Manager = this.barManager1;
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.ShowCloseButton = true;
            this.popupControlContainer1.ShowSizeGrip = true;
            this.popupControlContainer1.Size = new System.Drawing.Size(253, 125);
            this.popupControlContainer1.TabIndex = 14;
            this.popupControlContainer1.Visible = false;
            // 
            // PaymentSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 474);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentSelection";
            this.Text = "Payment Selection";
            this.Load += new System.EventHandler(this.PaymentSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRAPRECEIPTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRAPRECEIPTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupbankname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRAPRECEIPTSDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupbatch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BarManager barManager1;
        private Bar bar2;
        private BarButtonItem btnsave;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private GroupControl groupControl1;
        private SimpleButton simpleButton1;
        private TextEdit textEdit1;
        private CheckEdit checkEdit2;
        private CheckEdit checkEdit1;
        private BarButtonItem barButtonItem3;
        private BarButtonItem btnprint;
        private BarButtonItem btnpost;
        private BarButtonItem barButtonItem5;
        private BarEditItem barEditItem1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridControl gridControl1;
        private GridView gridView1;
        private Panel panel1;
        protected LookUpEdit LookupSupplier;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private Label label1;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BindingSource sUPPLIERBindingSource;
        private TextEdit textEdit2;
        private Label label2;
        private LookUpEdit lookupbankname;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit2;
        private CheckEdit checkEdit4;
        private CheckEdit checkEdit3;
        private SimpleButton simpleButton2;
        private LookUpEdit lookupbatch;
        private PopupControlContainer popupControlContainer1;
        private BarEditItem barEditItem2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
        private BarButtonItem btndelete;
        private BindingSource aRAPRECEIPTSDETAILSBindingSource;
        private GridColumn colTID;
        private GridColumn colARAPTRANID;
        private GridColumn colTRANID;
        private GridColumn colDUEDAYS;
        private GridColumn colREFNO;
        private GridColumn colINVOICEDATE;
        private GridColumn colINVOICENO;
        private GridColumn colINVAMOUNT;
        private GridColumn colPAIDAMOUNT;
        private GridColumn colBALANCE;
        private GridColumn colDISCOUNT;
        private GridColumn colAppliedAmt;
        private GridColumn colSEL;
        private BindingSource aRAPRECEIPTSBindingSource;
        private BindingSource aRAPRECEIPTSBindingSource1;
        private Ledgers ledgers1;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem barButtonItem1;
        private CheckEdit checkEdit5;
        private DsMaster dsMaster1;
        private BindingSource bANKSBindingSource;
        private BarStaticItem barStaticItem2;
        private BarStaticItem barStaticItem1;


    }
}