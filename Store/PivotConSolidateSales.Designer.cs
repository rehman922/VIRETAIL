using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;

namespace Store
{
    partial class PivotConSolidateSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotConSolidateSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.consolidatePivotDailySalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldStore = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAMOUNT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCLOSEDATE1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTrandate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCashName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.getAllDataBasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consolidatePivotDailySalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDataBasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 33);
            this.panel1.TabIndex = 6;
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton1.Location = new System.Drawing.Point(412, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 25);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Print List";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton4.Location = new System.Drawing.Point(332, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 25);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Show";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = new System.DateTime(2012, 12, 19, 10, 46, 18, 260);
            this.dateEdit2.Location = new System.Drawing.Point(231, 6);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(95, 20);
            this.dateEdit2.TabIndex = 2;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2012, 12, 19, 10, 46, 9, 831);
            this.dateEdit1.Location = new System.Drawing.Point(80, 6);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(86, 20);
            this.dateEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(172, 9);
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
            // pivotGridControl1
            // 
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pivotGridControl1.DataSource = this.consolidatePivotDailySalesBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldStore,
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
            this.pivotGridControl1.Size = new System.Drawing.Size(881, 399);
            this.pivotGridControl1.TabIndex = 7;
            // 
            // consolidatePivotDailySalesBindingSource
            // 
            this.consolidatePivotDailySalesBindingSource.DataMember = "ConsolidatePivotDailySales";
            this.consolidatePivotDailySalesBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // fieldStore
            // 
            this.fieldStore.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldStore.AreaIndex = 0;
            this.fieldStore.Caption = "Store";
            this.fieldStore.FieldName = "Store";
            this.fieldStore.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldStore.Name = "fieldStore";
            this.fieldStore.RunningTotal = true;
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
            // getAllDataBasesBindingSource
            // 
            this.getAllDataBasesBindingSource.DataMember = "GetAllDataBases";
            this.getAllDataBasesBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // PivotConSolidateSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 432);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PivotConSolidateSales";
            this.Text = "ConSolidate Sales";
            this.Load += new System.EventHandler(this.PivotConSolidateSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consolidatePivotDailySalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDataBasesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton4;
        private DateEdit dateEdit2;
        private DateEdit dateEdit1;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private PivotGridControl pivotGridControl1;
        private PivotGridField fieldStore;
        private PivotGridField fieldAMOUNT1;
        private PivotGridField fieldCLOSEDATE1;
        private PivotGridField fieldTrandate1;
        private PivotGridField fieldCashName1;
        private BindingSource consolidatePivotDailySalesBindingSource;
        private BindingSource getAllDataBasesBindingSource;
        private BindingSource cOMPANYBindingSource;
    }
}