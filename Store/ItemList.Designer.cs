using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.itemsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPPLIERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGROUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISCONSALE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALEDISCOUNTPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 35);
            this.panel1.TabIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = global::Store.Properties.Resources.addicon;
            this.simpleButton2.Location = new System.Drawing.Point(22, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(84, 24);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Add Item";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton1.Location = new System.Drawing.Point(112, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 24);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Print";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.itemsListBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(941, 519);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // itemsListBindingSource
            // 
            this.itemsListBindingSource.DataMember = "ItemsList";
            this.itemsListBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEMNO,
            this.colBARCODE,
            this.colITEMNAME,
            this.colSUPPLIERNAME,
            this.colGROUPNAME,
            this.colDISCONSALE,
            this.colSALEDISCOUNTPER,
            this.colREORDER,
            this.colStock});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGROUPNAME, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colITEMNO.MaxWidth = 110;
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.ReadOnly = true;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 0;
            this.colITEMNO.Width = 112;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceCell.Options.UseFont = true;
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceHeader.Options.UseFont = true;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.Caption = "Manf.Code";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.MaxWidth = 120;
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.ReadOnly = true;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 1;
            this.colBARCODE.Width = 120;
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
            this.colITEMNAME.VisibleIndex = 2;
            this.colITEMNAME.Width = 320;
            // 
            // colSUPPLIERNAME
            // 
            this.colSUPPLIERNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPPLIERNAME.AppearanceCell.Options.UseFont = true;
            this.colSUPPLIERNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPPLIERNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPPLIERNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPPLIERNAME.AppearanceHeader.Options.UseFont = true;
            this.colSUPPLIERNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPPLIERNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPPLIERNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPPLIERNAME.Caption = "Supplier";
            this.colSUPPLIERNAME.FieldName = "SUPPLIERNAME";
            this.colSUPPLIERNAME.Name = "colSUPPLIERNAME";
            this.colSUPPLIERNAME.OptionsColumn.AllowEdit = false;
            this.colSUPPLIERNAME.OptionsColumn.ReadOnly = true;
            this.colSUPPLIERNAME.Visible = true;
            this.colSUPPLIERNAME.VisibleIndex = 3;
            this.colSUPPLIERNAME.Width = 219;
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
            this.colGROUPNAME.Caption = "Group";
            this.colGROUPNAME.FieldName = "GROUPNAME";
            this.colGROUPNAME.Name = "colGROUPNAME";
            this.colGROUPNAME.OptionsColumn.AllowEdit = false;
            this.colGROUPNAME.OptionsColumn.ReadOnly = true;
            this.colGROUPNAME.Visible = true;
            this.colGROUPNAME.VisibleIndex = 4;
            // 
            // colDISCONSALE
            // 
            this.colDISCONSALE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISCONSALE.AppearanceCell.Options.UseFont = true;
            this.colDISCONSALE.AppearanceCell.Options.UseTextOptions = true;
            this.colDISCONSALE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCONSALE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISCONSALE.AppearanceHeader.Options.UseFont = true;
            this.colDISCONSALE.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISCONSALE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISCONSALE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCONSALE.Caption = "Disc. On Sale";
            this.colDISCONSALE.FieldName = "DISCONSALE";
            this.colDISCONSALE.Name = "colDISCONSALE";
            this.colDISCONSALE.OptionsColumn.AllowEdit = false;
            this.colDISCONSALE.OptionsColumn.ReadOnly = true;
            this.colDISCONSALE.Width = 71;
            // 
            // colSALEDISCOUNTPER
            // 
            this.colSALEDISCOUNTPER.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSALEDISCOUNTPER.AppearanceCell.Options.UseFont = true;
            this.colSALEDISCOUNTPER.AppearanceCell.Options.UseTextOptions = true;
            this.colSALEDISCOUNTPER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSALEDISCOUNTPER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSALEDISCOUNTPER.AppearanceHeader.Options.UseFont = true;
            this.colSALEDISCOUNTPER.AppearanceHeader.Options.UseTextOptions = true;
            this.colSALEDISCOUNTPER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSALEDISCOUNTPER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSALEDISCOUNTPER.Caption = "Sales Disc %";
            this.colSALEDISCOUNTPER.FieldName = "SALEDISCOUNTPER";
            this.colSALEDISCOUNTPER.MaxWidth = 70;
            this.colSALEDISCOUNTPER.Name = "colSALEDISCOUNTPER";
            this.colSALEDISCOUNTPER.OptionsColumn.AllowEdit = false;
            this.colSALEDISCOUNTPER.OptionsColumn.ReadOnly = true;
            this.colSALEDISCOUNTPER.Visible = true;
            this.colSALEDISCOUNTPER.VisibleIndex = 4;
            this.colSALEDISCOUNTPER.Width = 70;
            // 
            // colREORDER
            // 
            this.colREORDER.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREORDER.AppearanceCell.Options.UseFont = true;
            this.colREORDER.AppearanceCell.Options.UseTextOptions = true;
            this.colREORDER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREORDER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREORDER.AppearanceHeader.Options.UseFont = true;
            this.colREORDER.AppearanceHeader.Options.UseTextOptions = true;
            this.colREORDER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREORDER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREORDER.Caption = "Re-Order";
            this.colREORDER.FieldName = "REORDER";
            this.colREORDER.MaxWidth = 60;
            this.colREORDER.Name = "colREORDER";
            this.colREORDER.OptionsColumn.AllowEdit = false;
            this.colREORDER.OptionsColumn.ReadOnly = true;
            this.colREORDER.Visible = true;
            this.colREORDER.VisibleIndex = 5;
            this.colREORDER.Width = 60;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceCell.Options.UseFont = true;
            this.colStock.AppearanceCell.Options.UseTextOptions = true;
            this.colStock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceHeader.Options.UseFont = true;
            this.colStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            this.colStock.OptionsColumn.ReadOnly = true;
            this.colStock.Width = 54;
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 554);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemList";
            this.Text = "Item List";
            this.Load += new System.EventHandler(this.ItemList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource itemsListBindingSource;
        private GridColumn colITEMNO;
        private GridColumn colBARCODE;
        private GridColumn colITEMNAME;
        private GridColumn colSUPPLIERNAME;
        private GridColumn colGROUPNAME;
        private GridColumn colDISCONSALE;
        private GridColumn colSALEDISCOUNTPER;
        private GridColumn colREORDER;
        private GridColumn colStock;
    }
}