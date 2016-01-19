using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class SalesInvList
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvList));
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.salesInvListBindingSource = new System.Windows.Forms.BindingSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLINETOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALESTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTALAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUNDOFF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNETAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECDAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHITFCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVAMTTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvListBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            this.SuspendLayout();
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
            this.colQTY.Caption = "Qty";
            this.colQTY.DisplayFormat.FormatString = "n2";
            this.colQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 5;
            this.colQTY.Width = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.simpleButton5);
            this.panel2.Controls.Add(this.textEdit2);
            this.panel2.Controls.Add(this.simpleButton4);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.textEdit1);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 31);
            this.panel2.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(233, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "No - B.G";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton5.Location = new System.Drawing.Point(307, 5);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(123, 25);
            this.simpleButton5.TabIndex = 8;
            this.simpleButton5.Text = "F4 - Print UCAF";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(83, 7);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.NullText = "Enter invoice no";
            this.textEdit2.Size = new System.Drawing.Size(138, 20);
            this.textEdit2.TabIndex = 7;
            this.textEdit2.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = global::Store.Properties.Resources.arrowreturn;
            this.simpleButton4.Location = new System.Drawing.Point(453, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(95, 25);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "F8 - Return";
            this.simpleButton4.Visible = false;
            this.simpleButton4.Click += new System.EventHandler(this.SimpleButton4Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(3, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Invoice  No. :";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = global::Store.Properties.Resources.arrowreturn;
            this.simpleButton3.Location = new System.Drawing.Point(829, 1);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(49, 22);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "F8 - Return";
            this.simpleButton3.Visible = false;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(669, 3);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.NullText = "Enter invoice no";
            this.textEdit1.Size = new System.Drawing.Size(108, 20);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(554, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Return full invoice  :";
            this.labelControl3.Visible = false;
            // 
            // salesInvListBindingSource
            // 
            this.salesInvListBindingSource.DataMember = "SalesInvList";
            this.salesInvListBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.textEdit3);
            this.panel1.Controls.Add(this.imageComboBoxEdit1);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 33);
            this.panel1.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(411, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Customer :";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(484, 8);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(164, 20);
            this.textEdit3.TabIndex = 6;
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(654, 8);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("LASER", ((short)(0)), -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("SLIP", ((short)(1)), -1)});
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(95, 20);
            this.imageComboBoxEdit1.TabIndex = 5;
            this.imageComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton1.Location = new System.Drawing.Point(755, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(123, 25);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "F4 - Print Invoice";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.date_magnify;
            this.simpleButton2.Location = new System.Drawing.Point(321, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 25);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "F10 - Filter";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = new System.DateTime(2012, 12, 19, 10, 46, 18, 260);
            this.dateEdit2.Location = new System.Drawing.Point(226, 6);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(83, 20);
            this.dateEdit2.TabIndex = 2;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2012, 12, 19, 10, 46, 9, 831);
            this.dateEdit1.Location = new System.Drawing.Point(80, 6);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(86, 20);
            this.dateEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(168, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Date To :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Date From :";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.salesInvListBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2});
            this.gridControl1.Size = new System.Drawing.Size(891, 439);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSINVNO,
            this.colITEMNO,
            this.colTRANDATE,
            this.colQTY,
            this.colINVRATE,
            this.colLINETOTAL,
            this.colCUSTNAME,
            this.colcardno,
            this.colSALESTYPE,
            this.colTOTALAMT,
            this.colROUNDOFF,
            this.colNETAMT,
            this.colRECDAMT,
            this.colSHITFCODE,
            this.colINVAMTTYPE,
            this.colDISC,
            this.colITEMNAME,
            this.colSPRICE,
            this.gridColumn1,
            this.gridColumn2});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colQTY;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = ((short)(0));
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "LINETOTAL", this.colLINETOTAL, "{0:###,###,###.00}", ((short)(1))),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "ITEMNAME", this.colITEMNAME, "", ((short)(2)))});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowHeight = 24;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRANDATE, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gridView1_CustomSummaryCalculate);
            this.gridView1.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gridView1_CustomColumnSort);
            // 
            // colSINVNO
            // 
            this.colSINVNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSINVNO.AppearanceCell.Options.UseFont = true;
            this.colSINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSINVNO.AppearanceHeader.Options.UseFont = true;
            this.colSINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.Caption = "Invoice No.";
            this.colSINVNO.FieldName = "SINVNO";
            this.colSINVNO.Name = "colSINVNO";
            this.colSINVNO.OptionsColumn.AllowEdit = false;
            this.colSINVNO.OptionsColumn.ReadOnly = true;
            this.colSINVNO.Visible = true;
            this.colSINVNO.VisibleIndex = 1;
            this.colSINVNO.Width = 90;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceCell.Options.UseFont = true;
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Barcode";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.MaxWidth = 90;
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.ReadOnly = true;
            this.colITEMNO.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 3;
            this.colITEMNO.Width = 65;
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
            this.colTRANDATE.Caption = "Inv.Date";
            this.colTRANDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.colTRANDATE.MinWidth = 100;
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.OptionsColumn.ReadOnly = true;
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 1;
            this.colTRANDATE.Width = 143;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceCell.Options.UseFont = true;
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceHeader.Options.UseFont = true;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.Caption = "Price";
            this.colINVRATE.DisplayFormat.FormatString = "n2";
            this.colINVRATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVRATE.FieldName = "INVRATE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.OptionsColumn.AllowEdit = false;
            this.colINVRATE.OptionsColumn.ReadOnly = true;
            this.colINVRATE.Visible = true;
            this.colINVRATE.VisibleIndex = 6;
            this.colINVRATE.Width = 40;
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
            this.colLINETOTAL.Caption = "Line Total";
            this.colLINETOTAL.DisplayFormat.FormatString = "n2";
            this.colLINETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLINETOTAL.FieldName = "LINETOTAL";
            this.colLINETOTAL.Name = "colLINETOTAL";
            this.colLINETOTAL.OptionsColumn.AllowEdit = false;
            this.colLINETOTAL.OptionsColumn.ReadOnly = true;
            this.colLINETOTAL.Visible = true;
            this.colLINETOTAL.VisibleIndex = 8;
            this.colLINETOTAL.Width = 149;
            // 
            // colCUSTNAME
            // 
            this.colCUSTNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCUSTNAME.AppearanceCell.Options.UseFont = true;
            this.colCUSTNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCUSTNAME.AppearanceHeader.Options.UseFont = true;
            this.colCUSTNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNAME.Caption = "Customer name";
            this.colCUSTNAME.FieldName = "CUSTNAME";
            this.colCUSTNAME.Name = "colCUSTNAME";
            this.colCUSTNAME.OptionsColumn.AllowEdit = false;
            this.colCUSTNAME.OptionsColumn.ReadOnly = true;
            this.colCUSTNAME.Visible = true;
            this.colCUSTNAME.VisibleIndex = 2;
            this.colCUSTNAME.Width = 89;
            // 
            // colcardno
            // 
            this.colcardno.Caption = "Card No.";
            this.colcardno.FieldName = "CARDNO";
            this.colcardno.MaxWidth = 60;
            this.colcardno.Name = "colcardno";
            this.colcardno.OptionsColumn.AllowEdit = false;
            this.colcardno.OptionsColumn.ReadOnly = true;
            this.colcardno.Width = 52;
            // 
            // colSALESTYPE
            // 
            this.colSALESTYPE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSALESTYPE.AppearanceCell.Options.UseFont = true;
            this.colSALESTYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colSALESTYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSALESTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSALESTYPE.AppearanceHeader.Options.UseFont = true;
            this.colSALESTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSALESTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSALESTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSALESTYPE.FieldName = "SALESTYPE";
            this.colSALESTYPE.Name = "colSALESTYPE";
            this.colSALESTYPE.OptionsColumn.AllowEdit = false;
            this.colSALESTYPE.OptionsColumn.ReadOnly = true;
            this.colSALESTYPE.Width = 32;
            // 
            // colTOTALAMT
            // 
            this.colTOTALAMT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTALAMT.AppearanceCell.Options.UseFont = true;
            this.colTOTALAMT.AppearanceCell.Options.UseTextOptions = true;
            this.colTOTALAMT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTALAMT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTALAMT.AppearanceHeader.Options.UseFont = true;
            this.colTOTALAMT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOTALAMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOTALAMT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTALAMT.FieldName = "TOTALAMT";
            this.colTOTALAMT.Name = "colTOTALAMT";
            this.colTOTALAMT.OptionsColumn.AllowEdit = false;
            this.colTOTALAMT.OptionsColumn.ReadOnly = true;
            this.colTOTALAMT.Width = 32;
            // 
            // colROUNDOFF
            // 
            this.colROUNDOFF.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colROUNDOFF.AppearanceCell.Options.UseFont = true;
            this.colROUNDOFF.AppearanceCell.Options.UseTextOptions = true;
            this.colROUNDOFF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colROUNDOFF.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colROUNDOFF.AppearanceHeader.Options.UseFont = true;
            this.colROUNDOFF.AppearanceHeader.Options.UseTextOptions = true;
            this.colROUNDOFF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROUNDOFF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colROUNDOFF.FieldName = "ROUNDOFF";
            this.colROUNDOFF.Name = "colROUNDOFF";
            this.colROUNDOFF.OptionsColumn.AllowEdit = false;
            this.colROUNDOFF.OptionsColumn.ReadOnly = true;
            this.colROUNDOFF.Width = 66;
            // 
            // colNETAMT
            // 
            this.colNETAMT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNETAMT.AppearanceCell.Options.UseFont = true;
            this.colNETAMT.AppearanceCell.Options.UseTextOptions = true;
            this.colNETAMT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNETAMT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNETAMT.AppearanceHeader.Options.UseFont = true;
            this.colNETAMT.AppearanceHeader.Options.UseTextOptions = true;
            this.colNETAMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNETAMT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNETAMT.FieldName = "NETAMT";
            this.colNETAMT.Name = "colNETAMT";
            this.colNETAMT.OptionsColumn.AllowEdit = false;
            this.colNETAMT.OptionsColumn.ReadOnly = true;
            this.colNETAMT.Width = 24;
            // 
            // colRECDAMT
            // 
            this.colRECDAMT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRECDAMT.AppearanceCell.Options.UseFont = true;
            this.colRECDAMT.AppearanceCell.Options.UseTextOptions = true;
            this.colRECDAMT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRECDAMT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRECDAMT.AppearanceHeader.Options.UseFont = true;
            this.colRECDAMT.AppearanceHeader.Options.UseTextOptions = true;
            this.colRECDAMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRECDAMT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRECDAMT.FieldName = "RECDAMT";
            this.colRECDAMT.Name = "colRECDAMT";
            this.colRECDAMT.OptionsColumn.AllowEdit = false;
            this.colRECDAMT.OptionsColumn.ReadOnly = true;
            this.colRECDAMT.Width = 24;
            // 
            // colSHITFCODE
            // 
            this.colSHITFCODE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSHITFCODE.AppearanceCell.Options.UseFont = true;
            this.colSHITFCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colSHITFCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSHITFCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSHITFCODE.AppearanceHeader.Options.UseFont = true;
            this.colSHITFCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSHITFCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSHITFCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSHITFCODE.FieldName = "SHITFCODE";
            this.colSHITFCODE.Name = "colSHITFCODE";
            this.colSHITFCODE.OptionsColumn.AllowEdit = false;
            this.colSHITFCODE.OptionsColumn.ReadOnly = true;
            this.colSHITFCODE.Width = 24;
            // 
            // colINVAMTTYPE
            // 
            this.colINVAMTTYPE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVAMTTYPE.AppearanceCell.Options.UseFont = true;
            this.colINVAMTTYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVAMTTYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVAMTTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVAMTTYPE.AppearanceHeader.Options.UseFont = true;
            this.colINVAMTTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVAMTTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVAMTTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVAMTTYPE.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colINVAMTTYPE.FieldName = "INVAMTTYPE";
            this.colINVAMTTYPE.Name = "colINVAMTTYPE";
            this.colINVAMTTYPE.OptionsColumn.AllowEdit = false;
            this.colINVAMTTYPE.OptionsColumn.ReadOnly = true;
            this.colINVAMTTYPE.Width = 20;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Credit", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colDISC
            // 
            this.colDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceCell.Options.UseFont = true;
            this.colDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceHeader.Options.UseFont = true;
            this.colDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.Caption = "Disc.";
            this.colDISC.FieldName = "DISC";
            this.colDISC.Name = "colDISC";
            this.colDISC.OptionsColumn.AllowEdit = false;
            this.colDISC.OptionsColumn.ReadOnly = true;
            this.colDISC.Visible = true;
            this.colDISC.VisibleIndex = 7;
            this.colDISC.Width = 40;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNAME.AppearanceCell.Options.UseFont = true;
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
            this.colITEMNAME.VisibleIndex = 4;
            this.colITEMNAME.Width = 181;
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
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.OptionsColumn.ReadOnly = true;
            this.colSPRICE.Width = 45;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.ColumnEdit = this.repositoryItemImageComboBox2;
            this.gridColumn1.FieldName = "INVAMTTYPE";
            this.gridColumn1.MaxWidth = 20;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsColumn.ShowCaption = false;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 39;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", 1, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Credit", 2, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Card", 3, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Return", 4, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mix", 5, 2)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "coins.png");
            this.imageList1.Images.SetKeyName(1, "currencycad.png");
            this.imageList1.Images.SetKeyName(2, "creditplus.png");
            this.imageList1.Images.SetKeyName(3, "creditcards.png");
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "SDISC";
            this.gridColumn2.FieldName = "SDISC";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // SalesInvList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 503);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Sharp Plus";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "SalesInvList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales Invoice List";
            this.Load += new System.EventHandler(this.SalesInvListLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesInvListKeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvListBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private BindingSource salesInvListBindingSource;
        private Panel panel1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colSINVNO;
        private GridColumn colITEMNO;
        private GridColumn colTRANDATE;
        private GridColumn colQTY;
        private GridColumn colINVRATE;
        private GridColumn colLINETOTAL;
        private GridColumn colCUSTNAME;
        private GridColumn colcardno;
        private GridColumn colSALESTYPE;
        private GridColumn colTOTALAMT;
        private GridColumn colROUNDOFF;
        private GridColumn colNETAMT;
        private GridColumn colRECDAMT;
        private GridColumn colSHITFCODE;
        private GridColumn colINVAMTTYPE;
        private RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private GridColumn colDISC;
        private GridColumn colITEMNAME;
        private GridColumn colSPRICE;
        private SimpleButton simpleButton2;
        private DateEdit dateEdit2;
        private DateEdit dateEdit1;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton4;
        private GridColumn gridColumn1;
        private RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private ImageList imageList1;
        private LabelControl labelControl3;
        private SimpleButton simpleButton3;
        private TextEdit textEdit1;
        private TextEdit textEdit2;
        private LabelControl labelControl4;
        private GridColumn gridColumn2;
        private ImageComboBoxEdit imageComboBoxEdit1;
        private LabelControl labelControl5;
        private TextEdit textEdit3;
        private SimpleButton simpleButton5;
        private CheckBox checkBox1;
    }
}