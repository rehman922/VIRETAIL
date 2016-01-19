using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptInventoryTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptInventoryTransfer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LookuptoStore = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGROUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumSprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumCprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvgBonus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvgSprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvgCprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookuptoStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LookuptoStore);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 60);
            this.panel1.TabIndex = 0;
            // 
            // LookuptoStore
            // 
            this.LookuptoStore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookuptoStore.EnterMoveNextControl = true;
            this.LookuptoStore.Location = new System.Drawing.Point(136, 10);
            this.LookuptoStore.Name = "LookuptoStore";
            this.LookuptoStore.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookuptoStore.Properties.Appearance.Options.UseFont = true;
            this.LookuptoStore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookuptoStore.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "STORECODE", 92, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LookuptoStore.Properties.DisplayMember = "STORENAME";
            this.LookuptoStore.Properties.NullText = "";
            this.LookuptoStore.Properties.ShowFooter = false;
            this.LookuptoStore.Properties.ShowHeader = false;
            this.LookuptoStore.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookuptoStore.Properties.ValueMember = "STORECODE";
            this.LookuptoStore.Size = new System.Drawing.Size(310, 20);
            this.LookuptoStore.TabIndex = 8;
            this.LookuptoStore.EditValueChanged += new System.EventHandler(this.LookuptoStore_EditValueChanged);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton3.Location = new System.Drawing.Point(534, 28);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 25);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton4.Location = new System.Drawing.Point(454, 28);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 25);
            this.simpleButton4.TabIndex = 6;
            this.simpleButton4.Text = "Show";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(331, 33);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(115, 20);
            this.dateEdit2.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(272, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "To Date :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(38, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "From Date :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(38, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "To Store Name :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(136, 33);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(119, 20);
            this.dateEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(859, 471);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGROUPNAME,
            this.colQty,
            this.colSumSprice,
            this.colSumCprice,
            this.colAvgBonus,
            this.colAvgSprice,
            this.colAvgCprice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsPrint.UsePrintStyles = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colGROUPNAME
            // 
            this.colGROUPNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGROUPNAME.AppearanceCell.Options.UseFont = true;
            this.colGROUPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colGROUPNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGROUPNAME.AppearanceHeader.Options.UseFont = true;
            this.colGROUPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colGROUPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGROUPNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPNAME.Caption = "Item Type";
            this.colGROUPNAME.FieldName = "ITEMNAME";
            this.colGROUPNAME.Name = "colGROUPNAME";
            this.colGROUPNAME.Visible = true;
            this.colGROUPNAME.VisibleIndex = 0;
            this.colGROUPNAME.Width = 301;
            // 
            // colQty
            // 
            this.colQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQty.AppearanceCell.Options.UseFont = true;
            this.colQty.AppearanceCell.Options.UseTextOptions = true;
            this.colQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQty.AppearanceHeader.Options.UseFont = true;
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.Caption = "Total Qty.";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.ReadOnly = true;
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 1;
            this.colQty.Width = 68;
            // 
            // colSumSprice
            // 
            this.colSumSprice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSumSprice.AppearanceCell.Options.UseFont = true;
            this.colSumSprice.AppearanceCell.Options.UseTextOptions = true;
            this.colSumSprice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSumSprice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSumSprice.AppearanceHeader.Options.UseFont = true;
            this.colSumSprice.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumSprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumSprice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSumSprice.Caption = "Sales Value";
            this.colSumSprice.FieldName = "SumSprice";
            this.colSumSprice.Name = "colSumSprice";
            this.colSumSprice.OptionsColumn.ReadOnly = true;
            this.colSumSprice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumSprice", "{0:##,##.00}")});
            this.colSumSprice.Visible = true;
            this.colSumSprice.VisibleIndex = 2;
            this.colSumSprice.Width = 68;
            // 
            // colSumCprice
            // 
            this.colSumCprice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSumCprice.AppearanceCell.Options.UseFont = true;
            this.colSumCprice.AppearanceCell.Options.UseTextOptions = true;
            this.colSumCprice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSumCprice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSumCprice.AppearanceHeader.Options.UseFont = true;
            this.colSumCprice.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumCprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumCprice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSumCprice.Caption = "Cost Value";
            this.colSumCprice.FieldName = "SumCprice";
            this.colSumCprice.Name = "colSumCprice";
            this.colSumCprice.OptionsColumn.ReadOnly = true;
            this.colSumCprice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumCprice", "{0:##,##.00}")});
            this.colSumCprice.Visible = true;
            this.colSumCprice.VisibleIndex = 3;
            this.colSumCprice.Width = 74;
            // 
            // colAvgBonus
            // 
            this.colAvgBonus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAvgBonus.AppearanceCell.Options.UseFont = true;
            this.colAvgBonus.AppearanceCell.Options.UseTextOptions = true;
            this.colAvgBonus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAvgBonus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAvgBonus.AppearanceHeader.Options.UseFont = true;
            this.colAvgBonus.AppearanceHeader.Options.UseTextOptions = true;
            this.colAvgBonus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvgBonus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAvgBonus.Caption = "Avg.Bonus";
            this.colAvgBonus.FieldName = "AvgBonus";
            this.colAvgBonus.Name = "colAvgBonus";
            this.colAvgBonus.OptionsColumn.ReadOnly = true;
            this.colAvgBonus.Visible = true;
            this.colAvgBonus.VisibleIndex = 4;
            this.colAvgBonus.Width = 72;
            // 
            // colAvgSprice
            // 
            this.colAvgSprice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAvgSprice.AppearanceCell.Options.UseFont = true;
            this.colAvgSprice.AppearanceCell.Options.UseTextOptions = true;
            this.colAvgSprice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAvgSprice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAvgSprice.AppearanceHeader.Options.UseFont = true;
            this.colAvgSprice.AppearanceHeader.Options.UseTextOptions = true;
            this.colAvgSprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvgSprice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAvgSprice.Caption = "Avg. S.Price";
            this.colAvgSprice.FieldName = "AvgSprice";
            this.colAvgSprice.Name = "colAvgSprice";
            this.colAvgSprice.OptionsColumn.ReadOnly = true;
            this.colAvgSprice.Visible = true;
            this.colAvgSprice.VisibleIndex = 5;
            this.colAvgSprice.Width = 74;
            // 
            // colAvgCprice
            // 
            this.colAvgCprice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAvgCprice.AppearanceCell.Options.UseFont = true;
            this.colAvgCprice.AppearanceCell.Options.UseTextOptions = true;
            this.colAvgCprice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAvgCprice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAvgCprice.AppearanceHeader.Options.UseFont = true;
            this.colAvgCprice.AppearanceHeader.Options.UseTextOptions = true;
            this.colAvgCprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvgCprice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAvgCprice.Caption = "Avg. C.Price";
            this.colAvgCprice.FieldName = "AvgCprice";
            this.colAvgCprice.Name = "colAvgCprice";
            this.colAvgCprice.OptionsColumn.ReadOnly = true;
            this.colAvgCprice.Visible = true;
            this.colAvgCprice.VisibleIndex = 6;
            this.colAvgCprice.Width = 76;
            // 
            // RptInventoryTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 531);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptInventoryTransfer";
            this.Text = "Inventory Transfer Report";
            this.Load += new System.EventHandler(this.RptInventoryTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookuptoStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DateEdit dateEdit1;
        private DateEdit dateEdit2;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton4;
        protected LookUpEdit LookuptoStore;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colGROUPNAME;
        private GridColumn colQty;
        private GridColumn colSumSprice;
        private GridColumn colSumCprice;
        private GridColumn colAvgBonus;
        private GridColumn colAvgSprice;
        private GridColumn colAvgCprice;
    }
}