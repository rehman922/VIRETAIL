using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptBonusReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptBonusReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.purchaseBonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBONUSQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBonusAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 34);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton3.Location = new System.Drawing.Point(585, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 25);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton4.Location = new System.Drawing.Point(506, 5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 25);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "Show";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(337, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "To Date :";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(396, 8);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(104, 20);
            this.dateEdit2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(156, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "From Date :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(227, 8);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(104, 20);
            this.dateEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.purchaseBonusBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 34);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 355);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purchaseBonusBindingSource
            // 
            this.purchaseBonusBindingSource.DataMember = "PurchaseBonus";
            this.purchaseBonusBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
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
            this.colBonusAmt,
            this.colITEMNAME});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsPrint.UsePrintStyles = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colITEMNAME, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSUPNAME
            // 
            this.colSUPNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPNAME.AppearanceCell.Options.UseFont = true;
            this.colSUPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPNAME.AppearanceHeader.Options.UseFont = true;
            this.colSUPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPNAME.Caption = "Supplier name";
            this.colSUPNAME.FieldName = "SUPNAME";
            this.colSUPNAME.Name = "colSUPNAME";
            this.colSUPNAME.OptionsColumn.AllowEdit = false;
            this.colSUPNAME.OptionsColumn.ReadOnly = true;
            this.colSUPNAME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SUPNAME", "(Count ={0})")});
            this.colSUPNAME.Visible = true;
            this.colSUPNAME.VisibleIndex = 0;
            this.colSUPNAME.Width = 306;
            // 
            // colINVNO
            // 
            this.colINVNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVNO.AppearanceCell.Options.UseFont = true;
            this.colINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVNO.AppearanceHeader.Options.UseFont = true;
            this.colINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVNO.Caption = "Invoice No.";
            this.colINVNO.FieldName = "INVNO";
            this.colINVNO.Name = "colINVNO";
            this.colINVNO.OptionsColumn.AllowEdit = false;
            this.colINVNO.OptionsColumn.ReadOnly = true;
            this.colINVNO.Visible = true;
            this.colINVNO.VisibleIndex = 1;
            this.colINVNO.Width = 92;
            // 
            // colINVDATE
            // 
            this.colINVDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVDATE.AppearanceCell.Options.UseFont = true;
            this.colINVDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVDATE.AppearanceHeader.Options.UseFont = true;
            this.colINVDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVDATE.Caption = "Invoice Dt.";
            this.colINVDATE.FieldName = "INVDATE";
            this.colINVDATE.Name = "colINVDATE";
            this.colINVDATE.OptionsColumn.AllowEdit = false;
            this.colINVDATE.OptionsColumn.ReadOnly = true;
            this.colINVDATE.Visible = true;
            this.colINVDATE.VisibleIndex = 2;
            this.colINVDATE.Width = 90;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceCell.Options.UseFont = true;
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 42;
            // 
            // colBONUSQTY
            // 
            this.colBONUSQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBONUSQTY.AppearanceCell.Options.UseFont = true;
            this.colBONUSQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colBONUSQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBONUSQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBONUSQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBONUSQTY.AppearanceHeader.Options.UseFont = true;
            this.colBONUSQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colBONUSQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBONUSQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBONUSQTY.Caption = "Bonus";
            this.colBONUSQTY.FieldName = "BONUSQTY";
            this.colBONUSQTY.Name = "colBONUSQTY";
            this.colBONUSQTY.OptionsColumn.AllowEdit = false;
            this.colBONUSQTY.OptionsColumn.ReadOnly = true;
            this.colBONUSQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colBONUSQTY.Visible = true;
            this.colBONUSQTY.VisibleIndex = 4;
            this.colBONUSQTY.Width = 59;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceCell.Options.UseFont = true;
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceHeader.Options.UseFont = true;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.Caption = "Sale Price";
            this.colSPRICE.DisplayFormat.FormatString = "N2";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.OptionsColumn.ReadOnly = true;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 5;
            this.colSPRICE.Width = 76;
            // 
            // colBonusAmt
            // 
            this.colBonusAmt.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBonusAmt.AppearanceCell.Options.UseFont = true;
            this.colBonusAmt.AppearanceCell.Options.UseTextOptions = true;
            this.colBonusAmt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBonusAmt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBonusAmt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBonusAmt.AppearanceHeader.Options.UseFont = true;
            this.colBonusAmt.AppearanceHeader.Options.UseTextOptions = true;
            this.colBonusAmt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBonusAmt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBonusAmt.Caption = "Bonus Value";
            this.colBonusAmt.DisplayFormat.FormatString = "N2";
            this.colBonusAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBonusAmt.FieldName = "BonusAmt";
            this.colBonusAmt.Name = "colBonusAmt";
            this.colBonusAmt.OptionsColumn.AllowEdit = false;
            this.colBonusAmt.OptionsColumn.ReadOnly = true;
            this.colBonusAmt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BonusAmt", "{0:###,###,###,###.00}")});
            this.colBonusAmt.Visible = true;
            this.colBonusAmt.VisibleIndex = 6;
            this.colBonusAmt.Width = 83;
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
            this.colITEMNAME.VisibleIndex = 7;
            // 
            // RptBonusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 389);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptBonusReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private LabelControl labelControl2;
        private DateEdit dateEdit2;
        private LabelControl labelControl1;
        private DateEdit dateEdit1;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton4;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource purchaseBonusBindingSource;
        private GridColumn colSUPNAME;
        private GridColumn colINVNO;
        private GridColumn colINVDATE;
        private GridColumn colQTY;
        private GridColumn colBONUSQTY;
        private GridColumn colSPRICE;
        private GridColumn colBonusAmt;
        private GridColumn colITEMNAME;

    }
}