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
    partial class FrmItemLookUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemLookUp));
            this.colSEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemPopupContainerEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.iTEMMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGROUPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATEREQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISCOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colSEL
            // 
            this.colSEL.AppearanceCell.Options.UseTextOptions = true;
            this.colSEL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSEL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSEL.AppearanceHeader.Options.UseFont = true;
            this.colSEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colSEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSEL.FieldName = "SEL";
            this.colSEL.Name = "colSEL";
            this.colSEL.OptionsColumn.AllowEdit = false;
            this.colSEL.OptionsColumn.ShowCaption = false;
            this.colSEL.Visible = true;
            this.colSEL.VisibleIndex = 0;
            this.colSEL.Width = 33;
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem3,
            this.barButtonItem7,
            this.barEditItem2,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager2.MaxItemId = 15;
            this.barManager2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemPopupContainerEdit2});
            this.barManager2.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.BarManager2EditorKeyDown);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(315, 342);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barEditItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Item Setup ";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.NewAdd16;
            this.barButtonItem3.Id = 0;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem2ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "F1 - Bar Code Selection";
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.barcode;
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "F2- Our Barcode";
            this.barButtonItem4.Glyph = global::Store.Properties.Resources.barcode;
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "ESC - CLOSE";
            this.barButtonItem5.Glyph = global::Store.Properties.Resources.Delete16;
            this.barButtonItem5.Id = 14;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barEditItem2
            // 
            this.barEditItem2.AutoFillWidth = true;
            this.barEditItem2.Caption = "Enter Item :";
            this.barEditItem2.Edit = this.repositoryItemTextEdit1;
            this.barEditItem2.Id = 8;
            this.barEditItem2.IEBehavior = true;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "Barcode / Name";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Show Filter";
            this.barButtonItem2.Glyph = global::Store.Properties.Resources.funnelicon;
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(632, 29);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(632, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 440);
            this.barDockControl2.Size = new System.Drawing.Size(632, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 440);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(632, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 440);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Merge Rows";
            this.barButtonItem7.Id = 5;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemPopupContainerEdit2
            // 
            this.repositoryItemPopupContainerEdit2.AutoHeight = false;
            this.repositoryItemPopupContainerEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit2.Name = "repositoryItemPopupContainerEdit2";
            // 
            // iTEMMASTBindingSource
            // 
            this.iTEMMASTBindingSource.DataMember = "ITEMMAST";
            this.iTEMMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit1.Location = new System.Drawing.Point(0, 29);
            this.textEdit1.MenuManager = this.barManager2;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.NullText = "Enter Item name";
            this.textEdit1.Properties.NullValuePrompt = "Enter Item name";
            this.textEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit1.Size = new System.Drawing.Size(632, 20);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.iTEMMASTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(632, 391);
            this.gridControl1.TabIndex = 24;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSEL,
            this.colITEMNAME,
            this.colBARCODE,
            this.colITEMNO,
            this.colGROUPID,
            this.colEXPDATEREQ,
            this.colDISCOUNT});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colSEL;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            styleFormatCondition1.Value2 = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 24;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNAME.AppearanceHeader.Options.UseFont = true;
            this.colITEMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.Caption = "Item name";
            this.colITEMNAME.FieldName = "ITEMNAME";
            this.colITEMNAME.Name = "colITEMNAME";
            this.colITEMNAME.OptionsColumn.AllowEdit = false;
            this.colITEMNAME.OptionsColumn.ReadOnly = true;
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 1;
            this.colITEMNAME.Width = 350;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceHeader.Options.UseFont = true;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.Caption = "Manf .Barcode";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.ReadOnly = true;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 2;
            this.colBARCODE.Width = 101;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Our Barcode";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.ReadOnly = true;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 3;
            this.colITEMNO.Width = 123;
            // 
            // colGROUPID
            // 
            this.colGROUPID.AppearanceCell.Options.UseTextOptions = true;
            this.colGROUPID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGROUPID.AppearanceHeader.Options.UseFont = true;
            this.colGROUPID.AppearanceHeader.Options.UseTextOptions = true;
            this.colGROUPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGROUPID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPID.FieldName = "GROUPID";
            this.colGROUPID.Name = "colGROUPID";
            this.colGROUPID.OptionsColumn.AllowEdit = false;
            this.colGROUPID.OptionsColumn.ReadOnly = true;
            this.colGROUPID.Width = 124;
            // 
            // colEXPDATEREQ
            // 
            this.colEXPDATEREQ.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATEREQ.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATEREQ.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATEREQ.AppearanceHeader.Options.UseFont = true;
            this.colEXPDATEREQ.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATEREQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATEREQ.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATEREQ.FieldName = "EXPDATEREQ";
            this.colEXPDATEREQ.Name = "colEXPDATEREQ";
            this.colEXPDATEREQ.OptionsColumn.AllowEdit = false;
            this.colEXPDATEREQ.OptionsColumn.ReadOnly = true;
            this.colEXPDATEREQ.Width = 124;
            // 
            // colDISCOUNT
            // 
            this.colDISCOUNT.AppearanceCell.Options.UseTextOptions = true;
            this.colDISCOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCOUNT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISCOUNT.AppearanceHeader.Options.UseFont = true;
            this.colDISCOUNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISCOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISCOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCOUNT.FieldName = "DISCOUNT";
            this.colDISCOUNT.Name = "colDISCOUNT";
            this.colDISCOUNT.OptionsColumn.AllowEdit = false;
            this.colDISCOUNT.OptionsColumn.ReadOnly = true;
            this.colDISCOUNT.Width = 139;
            // 
            // FrmItemLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 440);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2013";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmItemLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Lookup";
            this.Load += new System.EventHandler(this.FrmItemLookUp_Load);
            this.Shown += new System.EventHandler(this.FrmItemLookUpShown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmItemLookUp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BarManager barManager2;
        private Bar bar1;
        private BarEditItem barEditItem2;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem barButtonItem3;
        private StandaloneBarDockControl standaloneBarDockControl1;
        private BarDockControl barDockControl1;
        private BarDockControl barDockControl2;
        private BarDockControl barDockControl3;
        private BarDockControl barDockControl4;
        private BarButtonItem barButtonItem7;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit2;
        private BarButtonItem barButtonItem1;
        private TextEdit textEdit1;
        private BindingSource iTEMMASTBindingSource;
        private BarButtonItem barButtonItem2;
        private DsMaster dsMaster1;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colSEL;
        private GridColumn colITEMNAME;
        private GridColumn colBARCODE;
        private GridColumn colITEMNO;
        private GridColumn colGROUPID;
        private GridColumn colEXPDATEREQ;
        private GridColumn colDISCOUNT;
    }
}