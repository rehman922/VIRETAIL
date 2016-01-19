using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;

namespace Store
{
    partial class PivotSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.sTOREMASTDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotDailySalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldShift1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAMOUNT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCLOSEDATE1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTrandate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCashName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDailySalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 33);
            this.panel1.TabIndex = 5;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(119, 6);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBNAME", "DBNAME", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookUpEdit1.Properties.DataSource = this.sTOREMASTDBBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "STORENAME";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.ValueMember = "DBNAME";
            this.lookUpEdit1.Size = new System.Drawing.Size(143, 20);
            this.lookUpEdit1.TabIndex = 12;
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
            this.labelControl3.Location = new System.Drawing.Point(77, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 14);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Store :";
            this.labelControl3.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton1.Location = new System.Drawing.Point(663, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(74, 25);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Print List";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton3.Location = new System.Drawing.Point(746, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(113, 25);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "Print Daily Sales";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton4.Location = new System.Drawing.Point(583, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 25);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Show";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = new System.DateTime(2012, 12, 19, 10, 46, 18, 260);
            this.dateEdit2.Location = new System.Drawing.Point(487, 6);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(89, 20);
            this.dateEdit2.TabIndex = 2;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2012, 12, 19, 10, 46, 9, 831);
            this.dateEdit1.Location = new System.Drawing.Point(336, 6);
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
            this.labelControl2.Location = new System.Drawing.Point(428, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Date To :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(268, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Date From :";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pivotGridControl1.DataSource = this.pivotDailySalesBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldShift1,
            this.fieldAMOUNT1,
            this.fieldCLOSEDATE1,
            this.fieldTrandate1,
            this.fieldCashName1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 33);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsBehavior.CopyToClipboardWithFieldValues = true;
            this.pivotGridControl1.OptionsCustomization.AllowCustomizationForm = false;
            this.pivotGridControl1.OptionsCustomization.AllowDragInCustomizationForm = false;
            this.pivotGridControl1.OptionsCustomization.AllowEdit = false;
            this.pivotGridControl1.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never;
            this.pivotGridControl1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterSeparatorBar = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(932, 466);
            this.pivotGridControl1.TabIndex = 6;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            this.pivotGridControl1.CustomCellValue += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellValueEventArgs>(this.pivotGridControl1_CustomCellValue);
            // 
            // pivotDailySalesBindingSource
            // 
            this.pivotDailySalesBindingSource.DataMember = "PivotDailySales";
            this.pivotDailySalesBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // fieldShift1
            // 
            this.fieldShift1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShift1.AreaIndex = 0;
            this.fieldShift1.Caption = "Shift";
            this.fieldShift1.FieldName = "Shift";
            this.fieldShift1.Name = "fieldShift1";
            // 
            // fieldAMOUNT1
            // 
            this.fieldAMOUNT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAMOUNT1.AreaIndex = 0;
            this.fieldAMOUNT1.Caption = "AMOUNT";
            this.fieldAMOUNT1.CellFormat.FormatString = "###,###,###.##";
            this.fieldAMOUNT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAMOUNT1.FieldName = "AMOUNT";
            this.fieldAMOUNT1.GrandTotalCellFormat.FormatString = "###,###,###.##";
            this.fieldAMOUNT1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAMOUNT1.Name = "fieldAMOUNT1";
            this.fieldAMOUNT1.TotalCellFormat.FormatString = "###,###,###.##";
            this.fieldAMOUNT1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAMOUNT1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals;
            this.fieldAMOUNT1.TotalValueFormat.FormatString = "###,###,###.##";
            this.fieldAMOUNT1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAMOUNT1.ValueFormat.FormatString = "###,###,###.##";
            this.fieldAMOUNT1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCLOSEDATE1
            // 
            this.fieldCLOSEDATE1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCLOSEDATE1.AreaIndex = 0;
            this.fieldCLOSEDATE1.Caption = "Close Date";
            this.fieldCLOSEDATE1.FieldName = "CLOSEDATE";
            this.fieldCLOSEDATE1.Name = "fieldCLOSEDATE1";
            this.fieldCLOSEDATE1.Width = 160;
            // 
            // fieldTrandate1
            // 
            this.fieldTrandate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldTrandate1.AreaIndex = 1;
            this.fieldTrandate1.Caption = "Sold Date";
            this.fieldTrandate1.ExpandedInFieldsGroup = false;
            this.fieldTrandate1.FieldName = "Trandate";
            this.fieldTrandate1.Name = "fieldTrandate1";
            this.fieldTrandate1.Visible = false;
            // 
            // fieldCashName1
            // 
            this.fieldCashName1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldCashName1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCashName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCashName1.AreaIndex = 1;
            this.fieldCashName1.Caption = "Cash Name";
            this.fieldCashName1.FieldName = "CashName";
            this.fieldCashName1.Name = "fieldCashName1";
            // 
            // PivotSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 499);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PivotSales";
            this.Text = "PivotSales";
            this.Load += new System.EventHandler(this.PivotSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDailySalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DateEdit dateEdit2;
        private DateEdit dateEdit1;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private PivotGridControl pivotGridControl1;
        private BindingSource pivotDailySalesBindingSource;
        private PivotGridField fieldShift1;
        private PivotGridField fieldAMOUNT1;
        private PivotGridField fieldCLOSEDATE1;
        private PivotGridField fieldTrandate1;
        private PivotGridField fieldCashName1;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton4;
        private SimpleButton simpleButton1;
        private LookUpEdit lookUpEdit1;
        private LabelControl labelControl3;
        private BindingSource sTOREMASTDBBindingSource;
    }
}