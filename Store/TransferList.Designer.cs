using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraWaitForm;

namespace Store
{
    partial class TransferList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.sTOREMASTDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.d2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.d1 = new DevExpress.XtraEditors.DateEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.iTEMTRANSFERMAINLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRANID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.inventoryTransferDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRANDATE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLINETOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERMAINLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTransferDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.d2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.d1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 34);
            this.panel1.TabIndex = 1;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(165, 9);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBNAME", "DBNAME", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.sTOREMASTDBBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "STORENAME";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.ValueMember = "DBNAME";
            this.lookUpEdit1.Size = new System.Drawing.Size(143, 20);
            this.lookUpEdit1.TabIndex = 7;
            this.lookUpEdit1.Visible = false;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // sTOREMASTDBBindingSource
            // 
            this.sTOREMASTDBBindingSource.DataMember = "STOREMASTDB";
            this.sTOREMASTDBBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(123, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Store :";
            this.labelControl3.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = global::Store.Properties.Resources.addicon;
            this.simpleButton1.Location = new System.Drawing.Point(3, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 25);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "New Transfer";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton3.Location = new System.Drawing.Point(743, 6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 25);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton4.Location = new System.Drawing.Point(664, 6);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 25);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "Show";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(495, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "To Date :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // d2
            // 
            this.d2.EditValue = null;
            this.d2.Location = new System.Drawing.Point(554, 9);
            this.d2.Name = "d2";
            this.d2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Properties.Appearance.Options.UseFont = true;
            this.d2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.d2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.d2.Size = new System.Drawing.Size(104, 20);
            this.d2.TabIndex = 1;
            this.d2.EditValueChanged += new System.EventHandler(this.d2_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(314, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "From Date :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // d1
            // 
            this.d1.EditValue = null;
            this.d1.Location = new System.Drawing.Point(385, 9);
            this.d1.Name = "d1";
            this.d1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Properties.Appearance.Options.UseFont = true;
            this.d1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.d1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.d1.Size = new System.Drawing.Size(104, 20);
            this.d1.TabIndex = 0;
            this.d1.EditValueChanged += new System.EventHandler(this.d1_EditValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 34);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(829, 509);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            this.xtraTabControl1.Selected += new DevExpress.XtraTab.TabPageEventHandler(this.xtraTabControl1_Selected);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.Header.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xtraTabPage1.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage1.Appearance.HeaderHotTracked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xtraTabPage1.Appearance.HeaderHotTracked.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.HeaderHotTracked.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.HeaderHotTracked.Options.UseFont = true;
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.progressPanel1);
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(823, 481);
            this.xtraTabPage1.Text = "Out Going Inventory";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(266, 0);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(311, 60);
            this.progressPanel1.TabIndex = 2;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.iTEMTRANSFERMAINLISTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(823, 481);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // iTEMTRANSFERMAINLISTBindingSource
            // 
            this.iTEMTRANSFERMAINLISTBindingSource.DataMember = "ITEMTRANSFERMAINLIST";
            this.iTEMTRANSFERMAINLISTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANID1,
            this.colTRANDATE,
            this.colFRMNAME,
            this.colTONAME,
            this.colTOTVALUE,
            this.colTOSTOREID,
            this.colFRMSTOREID,
            this.colNOTE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTVALUE", this.colTOTVALUE, "{0:###,###,###.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TRANID", this.colTRANID1, "Count {0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.PreviewLineCount = 1;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRANDATE, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
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
            this.colTRANID1.Name = "colTRANID1";
            this.colTRANID1.OptionsColumn.AllowEdit = false;
            this.colTRANID1.OptionsColumn.ReadOnly = true;
            this.colTRANID1.Visible = true;
            this.colTRANID1.VisibleIndex = 0;
            this.colTRANID1.Width = 93;
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
            this.colTRANDATE.GroupFormat.FormatString = "dd MMM,yyyy";
            this.colTRANDATE.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
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
            this.colFRMNAME.VisibleIndex = 1;
            this.colFRMNAME.Width = 233;
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
            this.colTONAME.VisibleIndex = 2;
            this.colTONAME.Width = 222;
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
            this.colTOTVALUE.Caption = "Total S.Value";
            this.colTOTVALUE.DisplayFormat.FormatString = "N2";
            this.colTOTVALUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTVALUE.FieldName = "TOTVALUE";
            this.colTOTVALUE.MaxWidth = 150;
            this.colTOTVALUE.Name = "colTOTVALUE";
            this.colTOTVALUE.OptionsColumn.AllowEdit = false;
            this.colTOTVALUE.OptionsColumn.ReadOnly = true;
            this.colTOTVALUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTVALUE", "{0:###,###,###,###.00}")});
            this.colTOTVALUE.Visible = true;
            this.colTOTVALUE.VisibleIndex = 3;
            this.colTOTVALUE.Width = 131;
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
            this.colNOTE.MaxWidth = 150;
            this.colNOTE.Name = "colNOTE";
            this.colNOTE.OptionsColumn.AllowEdit = false;
            this.colNOTE.OptionsColumn.ReadOnly = true;
            this.colNOTE.Visible = true;
            this.colNOTE.VisibleIndex = 4;
            this.colNOTE.Width = 126;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xtraTabPage2.Appearance.Header.BackColor2 = System.Drawing.Color.White;
            this.xtraTabPage2.Appearance.Header.BorderColor = System.Drawing.Color.Teal;
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage2.Appearance.Header.Options.UseBackColor = true;
            this.xtraTabPage2.Appearance.Header.Options.UseBorderColor = true;
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xtraTabPage2.Appearance.HeaderActive.BackColor2 = System.Drawing.Color.White;
            this.xtraTabPage2.Appearance.HeaderActive.BorderColor = System.Drawing.Color.Teal;
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseBorderColor = true;
            this.xtraTabPage2.Appearance.HeaderHotTracked.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage2.Appearance.HeaderHotTracked.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(823, 481);
            this.xtraTabPage2.Text = "In Comming Inventory";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.iTEMTRANSFERMAINLISTBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(823, 481);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(183)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(126)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(128)))), ((int)(((byte)(88)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(126)))));
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(146)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(170)))));
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(168)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(133)))));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTVALUE", this.gridColumn5, "{0:###,###,###.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TRANID", this.gridColumn1, "Count {0}")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.PreviewLineCount = 1;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView2.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView2_CustomUnboundColumnData);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "File No.";
            this.gridColumn1.FieldName = "TRANID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 93;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "Date";
            this.gridColumn2.DisplayFormat.FormatString = "dd MMM,yyyy";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "TRANDATE";
            this.gridColumn2.GroupFormat.FormatString = "dd MMM,yyyy";
            this.gridColumn2.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.MaxWidth = 90;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 90;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "From Store";
            this.gridColumn3.FieldName = "FRMNAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 233;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "To Store";
            this.gridColumn4.FieldName = "TONAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 222;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "Total S.Value";
            this.gridColumn5.DisplayFormat.FormatString = "N2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "TOTVALUE";
            this.gridColumn5.MaxWidth = 150;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTVALUE", "{0:###,###,###,###.00}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 131;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.FieldName = "TOSTOREID";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.FieldName = "FRMSTOREID";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn8.Caption = "Note";
            this.gridColumn8.FieldName = "NOTE";
            this.gridColumn8.MaxWidth = 150;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 126;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xtraTabPage3.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage3.Appearance.Header.Options.UseBackColor = true;
            this.xtraTabPage3.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage3.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xtraTabPage3.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage3.Controls.Add(this.gridControl3);
            this.xtraTabPage3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(823, 481);
            this.xtraTabPage3.Text = "Out Going Item details";
            // 
            // gridControl3
            // 
            this.gridControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl3.DataSource = this.inventoryTransferDetailsBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(823, 481);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // inventoryTransferDetailsBindingSource
            // 
            this.inventoryTransferDetailsBindingSource.DataMember = "InventoryTransferDetails";
            this.inventoryTransferDetailsBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANDATE1,
            this.colTRANID,
            this.colITEMNO,
            this.colBARCODE,
            this.colITEMNAME,
            this.colCOMPANY,
            this.colQTY,
            this.colSPRICE,
            this.colCPRICE,
            this.colLINETOTAL,
            this.colEXPDATE,
            this.colFRMNAME1,
            this.colTONAME1});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.GroupCount = 2;
            this.gridView3.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", this.colLINETOTAL, "{0:###,###,###.00}")});
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRANDATE1, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTONAME1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTRANDATE1
            // 
            this.colTRANDATE1.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE1.Caption = "Date";
            this.colTRANDATE1.FieldName = "TRANDATE";
            this.colTRANDATE1.Name = "colTRANDATE1";
            this.colTRANDATE1.OptionsColumn.AllowEdit = false;
            this.colTRANDATE1.OptionsColumn.ReadOnly = true;
            this.colTRANDATE1.OptionsFilter.AllowAutoFilter = false;
            this.colTRANDATE1.Visible = true;
            this.colTRANDATE1.VisibleIndex = 0;
            // 
            // colTRANID
            // 
            this.colTRANID.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.Caption = "Tran id";
            this.colTRANID.FieldName = "TRANID";
            this.colTRANID.Name = "colTRANID";
            this.colTRANID.OptionsColumn.AllowEdit = false;
            this.colTRANID.OptionsColumn.ReadOnly = true;
            this.colTRANID.OptionsFilter.AllowAutoFilter = false;
            this.colTRANID.Visible = true;
            this.colTRANID.VisibleIndex = 0;
            this.colTRANID.Width = 76;
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
            this.colITEMNO.OptionsFilter.AllowAutoFilter = false;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 1;
            this.colITEMNO.Width = 102;
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
            this.colBARCODE.OptionsFilter.AllowAutoFilter = false;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 2;
            this.colBARCODE.Width = 101;
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
            this.colITEMNAME.OptionsFilter.AllowAutoFilter = false;
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 3;
            this.colITEMNAME.Width = 218;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.OptionsColumn.AllowEdit = false;
            this.colCOMPANY.OptionsColumn.ReadOnly = true;
            this.colCOMPANY.OptionsFilter.AllowAutoFilter = false;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.OptionsFilter.AllowAutoFilter = false;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 4;
            this.colQTY.Width = 32;
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
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.OptionsColumn.ReadOnly = true;
            this.colSPRICE.OptionsFilter.AllowAutoFilter = false;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 5;
            this.colSPRICE.Width = 44;
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
            this.colCPRICE.OptionsColumn.AllowEdit = false;
            this.colCPRICE.OptionsColumn.ReadOnly = true;
            this.colCPRICE.OptionsFilter.AllowAutoFilter = false;
            this.colCPRICE.Visible = true;
            this.colCPRICE.VisibleIndex = 6;
            this.colCPRICE.Width = 46;
            // 
            // colLINETOTAL
            // 
            this.colLINETOTAL.AppearanceCell.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.Caption = "Total";
            this.colLINETOTAL.DisplayFormat.FormatString = "###,###.00";
            this.colLINETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLINETOTAL.FieldName = "LINETOTAL";
            this.colLINETOTAL.Name = "colLINETOTAL";
            this.colLINETOTAL.OptionsColumn.AllowEdit = false;
            this.colLINETOTAL.OptionsColumn.ReadOnly = true;
            this.colLINETOTAL.OptionsFilter.AllowAutoFilter = false;
            this.colLINETOTAL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", "{0:###,###,###.00}")});
            this.colLINETOTAL.Visible = true;
            this.colLINETOTAL.VisibleIndex = 7;
            this.colLINETOTAL.Width = 55;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.Caption = "Exp.Dt";
            this.colEXPDATE.DisplayFormat.FormatString = "dd-yy";
            this.colEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.AllowEdit = false;
            this.colEXPDATE.OptionsColumn.ReadOnly = true;
            this.colEXPDATE.OptionsFilter.AllowAutoFilter = false;
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.VisibleIndex = 8;
            this.colEXPDATE.Width = 42;
            // 
            // colFRMNAME1
            // 
            this.colFRMNAME1.AppearanceCell.Options.UseTextOptions = true;
            this.colFRMNAME1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMNAME1.AppearanceHeader.Options.UseTextOptions = true;
            this.colFRMNAME1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFRMNAME1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMNAME1.FieldName = "FRMNAME";
            this.colFRMNAME1.Name = "colFRMNAME1";
            this.colFRMNAME1.OptionsColumn.AllowEdit = false;
            this.colFRMNAME1.OptionsColumn.ReadOnly = true;
            this.colFRMNAME1.OptionsFilter.AllowAutoFilter = false;
            // 
            // colTONAME1
            // 
            this.colTONAME1.AppearanceCell.Options.UseTextOptions = true;
            this.colTONAME1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTONAME1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTONAME1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTONAME1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTONAME1.Caption = "To Store";
            this.colTONAME1.FieldName = "TONAME";
            this.colTONAME1.Name = "colTONAME1";
            this.colTONAME1.OptionsColumn.AllowEdit = false;
            this.colTONAME1.OptionsColumn.ReadOnly = true;
            this.colTONAME1.OptionsFilter.AllowAutoFilter = false;
            this.colTONAME1.Visible = true;
            this.colTONAME1.VisibleIndex = 9;
            this.colTONAME1.Width = 89;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xtraTabPage4.Appearance.Header.BorderColor = System.Drawing.Color.Thistle;
            this.xtraTabPage4.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage4.Appearance.Header.Options.UseBackColor = true;
            this.xtraTabPage4.Appearance.Header.Options.UseBorderColor = true;
            this.xtraTabPage4.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage4.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xtraTabPage4.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage4.Controls.Add(this.gridControl4);
            this.xtraTabPage4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(823, 481);
            this.xtraTabPage4.Text = "In Comming Item details";
            // 
            // gridControl4
            // 
            this.gridControl4.DataSource = this.inventoryTransferDetailsBindingSource;
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.Location = new System.Drawing.Point(0, 0);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(823, 481);
            this.gridControl4.TabIndex = 1;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.GroupCount = 2;
            this.gridView4.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", this.gridColumn18, "{0:###,###,###.00}")});
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowFooter = true;
            this.gridView4.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn9, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn21, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.Caption = "Date";
            this.gridColumn9.FieldName = "TRANDATE";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.Caption = "Tran id";
            this.gridColumn10.FieldName = "TRANID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 76;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn11.Caption = "Item No.";
            this.gridColumn11.FieldName = "ITEMNO";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 102;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn12.Caption = "Barcode";
            this.gridColumn12.FieldName = "BARCODE";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 101;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn13.Caption = "Item name";
            this.gridColumn13.FieldName = "ITEMNAME";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 218;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn14.FieldName = "COMPANY";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            this.gridColumn14.OptionsFilter.AllowAutoFilter = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn15.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn15.Caption = "Qty";
            this.gridColumn15.FieldName = "QTY";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.OptionsColumn.ReadOnly = true;
            this.gridColumn15.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 32;
            // 
            // gridColumn16
            // 
            this.gridColumn16.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn16.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn16.Caption = "S.Price";
            this.gridColumn16.DisplayFormat.FormatString = "###,###.00";
            this.gridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn16.FieldName = "SPRICE";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.OptionsColumn.ReadOnly = true;
            this.gridColumn16.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 5;
            this.gridColumn16.Width = 44;
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn17.Caption = "C.Price";
            this.gridColumn17.DisplayFormat.FormatString = "###,###.00";
            this.gridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn17.FieldName = "CPRICE";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.OptionsColumn.ReadOnly = true;
            this.gridColumn17.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 6;
            this.gridColumn17.Width = 46;
            // 
            // gridColumn18
            // 
            this.gridColumn18.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn18.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn18.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn18.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn18.Caption = "Total";
            this.gridColumn18.DisplayFormat.FormatString = "###,###.00";
            this.gridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn18.FieldName = "LINETOTAL";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.OptionsColumn.ReadOnly = true;
            this.gridColumn18.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", "{0:###,###,###.00}")});
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 7;
            this.gridColumn18.Width = 55;
            // 
            // gridColumn19
            // 
            this.gridColumn19.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn19.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn19.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn19.Caption = "Exp.Dt";
            this.gridColumn19.DisplayFormat.FormatString = "dd-yy";
            this.gridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn19.FieldName = "EXPDATE";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.OptionsColumn.ReadOnly = true;
            this.gridColumn19.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 8;
            this.gridColumn19.Width = 42;
            // 
            // gridColumn20
            // 
            this.gridColumn20.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn20.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn20.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn20.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn20.FieldName = "FRMNAME";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.OptionsColumn.ReadOnly = true;
            this.gridColumn20.OptionsFilter.AllowAutoFilter = false;
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn21.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn21.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn21.Caption = "From Store";
            this.gridColumn21.FieldName = "FRMNAME";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.OptionsColumn.ReadOnly = true;
            this.gridColumn21.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 9;
            this.gridColumn21.Width = 89;
            // 
            // TransferList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 543);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer List";
            this.Load += new System.EventHandler(this.TransferList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERMAINLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTransferDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton4;
        private LabelControl labelControl2;
        private DateEdit d2;
        private LabelControl labelControl1;
        private DateEdit d1;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;
        private BindingSource iTEMTRANSFERMAINLISTBindingSource;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colTRANID1;
        private GridColumn colTRANDATE;
        private GridColumn colFRMNAME;
        private GridColumn colTONAME;
        private GridColumn colTOTVALUE;
        private GridColumn colTOSTOREID;
        private GridColumn colFRMSTOREID;
        private GridColumn colNOTE;
        private GridControl gridControl2;
        private GridView gridView2;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
        private GridColumn gridColumn7;
        private GridColumn gridColumn8;
        private SimpleButton simpleButton1;
        private XtraTabPage xtraTabPage3;
        private XtraTabPage xtraTabPage4;
        private GridControl gridControl3;
        private GridView gridView3;
        private BindingSource inventoryTransferDetailsBindingSource;
        private GridColumn colTRANDATE1;
        private GridColumn colTRANID;
        private GridColumn colITEMNO;
        private GridColumn colBARCODE;
        private GridColumn colITEMNAME;
        private GridColumn colCOMPANY;
        private GridColumn colQTY;
        private GridColumn colSPRICE;
        private GridColumn colCPRICE;
        private GridColumn colLINETOTAL;
        private GridColumn colEXPDATE;
        private GridColumn colFRMNAME1;
        private GridColumn colTONAME1;
        private GridControl gridControl4;
        private GridView gridView4;
        private GridColumn gridColumn9;
        private GridColumn gridColumn10;
        private GridColumn gridColumn11;
        private GridColumn gridColumn12;
        private GridColumn gridColumn13;
        private GridColumn gridColumn14;
        private GridColumn gridColumn15;
        private GridColumn gridColumn16;
        private GridColumn gridColumn17;
        private GridColumn gridColumn18;
        private GridColumn gridColumn19;
        private GridColumn gridColumn20;
        private GridColumn gridColumn21;
        private LabelControl labelControl3;
        private LookUpEdit lookUpEdit1;
        private BindingSource sTOREMASTDBBindingSource;
        private ProgressPanel progressPanel1;
    }
}