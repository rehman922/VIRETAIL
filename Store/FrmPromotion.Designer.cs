using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class FrmPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromotion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.pROMOITEMS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.pROMOITEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ledgers1 = new VIRETAILENTITIES.Ledgers();
            this.iTEMMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTODATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBATCHNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colOLDPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNEWPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPLOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROMOITEMS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROMOITEMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textEdit2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 44);
            this.panel1.TabIndex = 0;
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit2.EditValue = "0";
            this.textEdit2.Location = new System.Drawing.Point(688, 14);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.textEdit2.Properties.Mask.EditMask = "n0";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Size = new System.Drawing.Size(45, 20);
            this.textEdit2.TabIndex = 14;
            this.textEdit2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit2_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(739, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "%";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lookUpEdit1.Location = new System.Drawing.Point(591, 14);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BATCHNO", "BATCHNO", 35, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEdit1.Properties.DataSource = this.pROMOITEMS1BindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "BATCHNO";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "BATCHNO";
            this.lookUpEdit1.Size = new System.Drawing.Size(74, 20);
            this.lookUpEdit1.TabIndex = 2;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // pROMOITEMS1BindingSource
            // 
            this.pROMOITEMS1BindingSource.DataMember = "PROMOITEMS1";
            this.pROMOITEMS1BindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit1.Location = new System.Drawing.Point(508, 14);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(77, 20);
            this.textEdit1.TabIndex = 11;
            // 
            // dateEdit2
            // 
            this.dateEdit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(325, 14);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 1;
            // 
            // dateEdit1
            // 
            this.dateEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(117, 13);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(432, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Batch No. :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(758, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 34);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Select Items - F10";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(223, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promotion End :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promotion Start :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton4);
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 46);
            this.panel2.TabIndex = 1;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(807, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(91, 37);
            this.simpleButton4.TabIndex = 5;
            this.simpleButton4.Text = "PRINT";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(710, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(91, 37);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "SAVE";
            this.simpleButton3.Visible = false;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // pROMOITEMSBindingSource
            // 
            this.pROMOITEMSBindingSource.DataMember = "PROMOITEMS";
            this.pROMOITEMSBindingSource.DataSource = this.ledgers1;
            // 
            // ledgers1
            // 
            this.ledgers1.DataSetName = "Ledgers";
            this.ledgers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMMASTBindingSource
            // 
            this.iTEMMASTBindingSource.DataMember = "ITEMMAST";
            this.iTEMMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.pROMOITEMSBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(901, 355);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colSTDATE,
            this.colTODATE,
            this.colBATCHNO,
            this.colITEMNO,
            this.gridColumn1,
            this.colOLDPRICE,
            this.colNEWPRICE,
            this.gridColumn2,
            this.colUPLOAD,
            this.colCDATE,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", null, "{###,###,###.##:0}")});
            this.gridView1.IndicatorWidth = 24;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colTID
            // 
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.ReadOnly = true;
            this.colTID.Width = 29;
            // 
            // colSTDATE
            // 
            this.colSTDATE.FieldName = "STDATE";
            this.colSTDATE.Name = "colSTDATE";
            // 
            // colTODATE
            // 
            this.colTODATE.FieldName = "TODATE";
            this.colTODATE.Name = "colTODATE";
            // 
            // colBATCHNO
            // 
            this.colBATCHNO.FieldName = "BATCHNO";
            this.colBATCHNO.Name = "colBATCHNO";
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.Caption = "ITEM NO";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 0;
            this.colITEMNO.Width = 107;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "ITEM NAME";
            this.gridColumn1.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.gridColumn1.FieldName = "ITEMNO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 438;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNO", "ITEMNO", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BARCODE", "BARCODE", 58, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "ITEMNAME", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.iTEMMASTBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.repositoryItemLookUpEdit2.ShowFooter = false;
            this.repositoryItemLookUpEdit2.ShowHeader = false;
            this.repositoryItemLookUpEdit2.ValueMember = "ITEMNO";
            // 
            // colOLDPRICE
            // 
            this.colOLDPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colOLDPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOLDPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colOLDPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOLDPRICE.Caption = "S.PRICE";
            this.colOLDPRICE.DisplayFormat.FormatString = "n2";
            this.colOLDPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOLDPRICE.FieldName = "OLDPRICE";
            this.colOLDPRICE.Name = "colOLDPRICE";
            this.colOLDPRICE.OptionsColumn.AllowEdit = false;
            this.colOLDPRICE.Visible = true;
            this.colOLDPRICE.VisibleIndex = 2;
            this.colOLDPRICE.Width = 66;
            // 
            // colNEWPRICE
            // 
            this.colNEWPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colNEWPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNEWPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colNEWPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNEWPRICE.Caption = "PRO.PRICE";
            this.colNEWPRICE.DisplayFormat.FormatString = "n2";
            this.colNEWPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNEWPRICE.FieldName = "NEWPRICE";
            this.colNEWPRICE.Name = "colNEWPRICE";
            this.colNEWPRICE.Visible = true;
            this.colNEWPRICE.VisibleIndex = 4;
            this.colNEWPRICE.Width = 74;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "POSTED";
            this.gridColumn2.FieldName = "POSTED";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 81;
            // 
            // colUPLOAD
            // 
            this.colUPLOAD.AppearanceCell.Options.UseTextOptions = true;
            this.colUPLOAD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUPLOAD.AppearanceHeader.Options.UseTextOptions = true;
            this.colUPLOAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUPLOAD.Caption = "UPLOAD";
            this.colUPLOAD.FieldName = "UPLOAD";
            this.colUPLOAD.Name = "colUPLOAD";
            this.colUPLOAD.OptionsColumn.AllowEdit = false;
            this.colUPLOAD.OptionsColumn.AllowFocus = false;
            this.colUPLOAD.Visible = true;
            this.colUPLOAD.VisibleIndex = 5;
            this.colUPLOAD.Width = 62;
            // 
            // colCDATE
            // 
            this.colCDATE.FieldName = "CDATE";
            this.colCDATE.Name = "colCDATE";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "% Disc";
            this.gridColumn3.DisplayFormat.FormatString = "##";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "PERC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 51;
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
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNO", "Name7"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "Name8")});
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // FrmPromotion
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 445);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPromotion";
            this.Text = "Promotion Price";
            this.Load += new System.EventHandler(this.FrmPromotion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPromotion_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROMOITEMS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pROMOITEMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton4;
        private Label label3;
        private BindingSource pROMOITEMSBindingSource;
        private Ledgers ledgers1;
        private BindingSource pROMOITEMS1BindingSource;
        private TextEdit textEdit1;
        private DateEdit dateEdit2;
        private DateEdit dateEdit1;
        private LookUpEdit lookUpEdit1;
        private BindingSource iTEMMASTBindingSource;
        private LabelControl labelControl1;
        private TextEdit textEdit2;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colTID;
        private GridColumn colSTDATE;
        private GridColumn colTODATE;
        private GridColumn colBATCHNO;
        private GridColumn colITEMNO;
        private GridColumn gridColumn1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private GridColumn colOLDPRICE;
        private GridColumn colNEWPRICE;
        private GridColumn gridColumn2;
        private GridColumn colUPLOAD;
        private GridColumn colCDATE;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridColumn gridColumn3;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}