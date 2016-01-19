using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptItemPurchaseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptItemPurchaseDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rptItemPurchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBONUSQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptItemPurchaseDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Controls.Add(this.textEdit2);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 64);
            this.panel1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(408, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(59, 20);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "Key F10";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(534, 8);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(189, 20);
            this.textEdit1.TabIndex = 1;
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // textEdit2
            // 
            this.textEdit2.EnterMoveNextControl = true;
            this.textEdit2.Location = new System.Drawing.Point(84, 8);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(318, 20);
            this.textEdit2.TabIndex = 0;
            this.textEdit2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit2_KeyDown);
            this.textEdit2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit2_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(476, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 14);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Barcode :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 14);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Item name :";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton3.Location = new System.Drawing.Point(728, 33);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(62, 25);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton4.Location = new System.Drawing.Point(729, 8);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(61, 23);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Show";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(239, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "To Date :";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(298, 35);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(104, 20);
            this.dateEdit2.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(13, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "From Date :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(84, 35);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(104, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.rptItemPurchaseDetailsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(814, 343);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // rptItemPurchaseDetailsBindingSource
            // 
            this.rptItemPurchaseDetailsBindingSource.DataMember = "RptItemPurchaseDetails";
            this.rptItemPurchaseDetailsBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSUPNAME,
            this.colINVNO,
            this.colINVDATE,
            this.colQTY,
            this.colBONUSQTY,
            this.colSPRICE,
            this.colCPRICE,
            this.colDISC,
            this.colSPDISC,
            this.colEXPDATE,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsPrint.UsePrintStyles = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colSUPNAME
            // 
            this.colSUPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPNAME.AppearanceHeader.Options.UseFont = true;
            this.colSUPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colSUPNAME.Caption = "Supplier name";
            this.colSUPNAME.FieldName = "SUPNAME";
            this.colSUPNAME.Name = "colSUPNAME";
            this.colSUPNAME.OptionsColumn.AllowEdit = false;
            this.colSUPNAME.OptionsColumn.ReadOnly = true;
            this.colSUPNAME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SUPNAME", "Count={0}")});
            this.colSUPNAME.Visible = true;
            this.colSUPNAME.VisibleIndex = 0;
            this.colSUPNAME.Width = 248;
            // 
            // colINVNO
            // 
            this.colINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colINVNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVNO.AppearanceHeader.Options.UseFont = true;
            this.colINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colINVNO.Caption = "Invoice No.";
            this.colINVNO.FieldName = "INVNO";
            this.colINVNO.Name = "colINVNO";
            this.colINVNO.OptionsColumn.AllowEdit = false;
            this.colINVNO.OptionsColumn.ReadOnly = true;
            this.colINVNO.Visible = true;
            this.colINVNO.VisibleIndex = 1;
            this.colINVNO.Width = 73;
            // 
            // colINVDATE
            // 
            this.colINVDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVDATE.AppearanceHeader.Options.UseFont = true;
            this.colINVDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colINVDATE.Caption = "Invoice Dt.";
            this.colINVDATE.FieldName = "INVDATE";
            this.colINVDATE.Name = "colINVDATE";
            this.colINVDATE.OptionsColumn.AllowEdit = false;
            this.colINVDATE.OptionsColumn.ReadOnly = true;
            this.colINVDATE.Visible = true;
            this.colINVDATE.VisibleIndex = 2;
            this.colINVDATE.Width = 69;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colQTY.Caption = "Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 40;
            // 
            // colBONUSQTY
            // 
            this.colBONUSQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colBONUSQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBONUSQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBONUSQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBONUSQTY.AppearanceHeader.Options.UseFont = true;
            this.colBONUSQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colBONUSQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBONUSQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colBONUSQTY.Caption = "Bonus";
            this.colBONUSQTY.DisplayFormat.FormatString = "N2";
            this.colBONUSQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBONUSQTY.FieldName = "BONUSQTY";
            this.colBONUSQTY.Name = "colBONUSQTY";
            this.colBONUSQTY.OptionsColumn.AllowEdit = false;
            this.colBONUSQTY.OptionsColumn.ReadOnly = true;
            this.colBONUSQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colBONUSQTY.Visible = true;
            this.colBONUSQTY.VisibleIndex = 4;
            this.colBONUSQTY.Width = 52;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceHeader.Options.UseFont = true;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colSPRICE.Caption = "S.Price";
            this.colSPRICE.DisplayFormat.FormatString = "###,###,###.00";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.OptionsColumn.ReadOnly = true;
            this.colSPRICE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SPRICE", "{0:###,###,###.00)")});
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 5;
            this.colSPRICE.Width = 67;
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceHeader.Options.UseFont = true;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colCPRICE.Caption = "C.Price";
            this.colCPRICE.DisplayFormat.FormatString = "###,###,###.00";
            this.colCPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.OptionsColumn.AllowEdit = false;
            this.colCPRICE.OptionsColumn.ReadOnly = true;
            this.colCPRICE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CPRICE", "{0:###,###,###.00)")});
            this.colCPRICE.Visible = true;
            this.colCPRICE.VisibleIndex = 6;
            this.colCPRICE.Width = 50;
            // 
            // colDISC
            // 
            this.colDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colDISC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceHeader.Options.UseFont = true;
            this.colDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colDISC.Caption = "Disc.";
            this.colDISC.DisplayFormat.FormatString = "N2";
            this.colDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDISC.FieldName = "DISC";
            this.colDISC.Name = "colDISC";
            this.colDISC.OptionsColumn.AllowEdit = false;
            this.colDISC.OptionsColumn.ReadOnly = true;
            this.colDISC.Visible = true;
            this.colDISC.VisibleIndex = 7;
            this.colDISC.Width = 39;
            // 
            // colSPDISC
            // 
            this.colSPDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colSPDISC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPDISC.AppearanceHeader.Options.UseFont = true;
            this.colSPDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colSPDISC.Caption = "Sp.Disc";
            this.colSPDISC.DisplayFormat.FormatString = "N2";
            this.colSPDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPDISC.FieldName = "SPDISC";
            this.colSPDISC.Name = "colSPDISC";
            this.colSPDISC.OptionsColumn.AllowEdit = false;
            this.colSPDISC.OptionsColumn.ReadOnly = true;
            this.colSPDISC.Visible = true;
            this.colSPDISC.VisibleIndex = 8;
            this.colSPDISC.Width = 46;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceHeader.Options.UseFont = true;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colEXPDATE.Caption = "Expiry";
            this.colEXPDATE.DisplayFormat.FormatString = "MM-yyyy";
            this.colEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.AllowEdit = false;
            this.colEXPDATE.OptionsColumn.ReadOnly = true;
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.VisibleIndex = 9;
            this.colEXPDATE.Width = 68;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Doc #";
            this.gridColumn1.FieldName = "PURINVID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // RptItemPurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 407);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "RptItemPurchaseDetails";
            this.Text = "Item Purchase Details";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RptItemPurchaseDetails_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptItemPurchaseDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextEdit textEdit2;
        private LabelControl labelControl4;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton4;
        private LabelControl labelControl2;
        private DateEdit dateEdit2;
        private LabelControl labelControl1;
        private DateEdit dateEdit1;
        private LabelControl labelControl3;
        private GridControl gridControl1;
        private GridView gridView1;
        private TextEdit textEdit1;
        private BindingSource rptItemPurchaseDetailsBindingSource;
        private GridColumn colSUPNAME;
        private GridColumn colINVNO;
        private GridColumn colINVDATE;
        private GridColumn colQTY;
        private GridColumn colBONUSQTY;
        private GridColumn colSPRICE;
        private GridColumn colCPRICE;
        private GridColumn colDISC;
        private GridColumn colSPDISC;
        private GridColumn colEXPDATE;
        private SimpleButton simpleButton1;
        private GridColumn gridColumn1;
    }
}