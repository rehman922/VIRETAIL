using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class FrmNegativeStockReplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNegativeStockReplace));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.negativeStockBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Negative Stock Replacement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 33);
            this.panel1.TabIndex = 10;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton3.Image = global::Store.Properties.Resources.Delete16;
            this.simpleButton3.Location = new System.Drawing.Point(563, 3);
            this.simpleButton3.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(109, 27);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "ESC - Close";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.negativeStockBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(681, 282);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // negativeStockBindingSource
            // 
            this.negativeStockBindingSource.DataMember = "NegativeStock";
            this.negativeStockBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 40;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemno,
            this.colStock,
            this.colNewStock,
            this.colBalance});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemno
            // 
            this.colItemno.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemno.AppearanceCell.Options.UseFont = true;
            this.colItemno.AppearanceCell.Options.UseTextOptions = true;
            this.colItemno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemno.AppearanceHeader.Options.UseFont = true;
            this.colItemno.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemno.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colItemno.Caption = "Item name";
            this.colItemno.FieldName = "Itemno";
            this.colItemno.Name = "colItemno";
            this.colItemno.OptionsColumn.AllowEdit = false;
            this.colItemno.OptionsColumn.ReadOnly = true;
            this.colItemno.Visible = true;
            this.colItemno.VisibleIndex = 0;
            this.colItemno.Width = 426;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colStock.AppearanceCell.Options.UseFont = true;
            this.colStock.AppearanceCell.Options.UseForeColor = true;
            this.colStock.AppearanceCell.Options.UseTextOptions = true;
            this.colStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceHeader.Options.UseFont = true;
            this.colStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStock.Caption = "Stock Before Received";
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            this.colStock.OptionsColumn.ReadOnly = true;
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 1;
            this.colStock.Width = 80;
            // 
            // colNewStock
            // 
            this.colNewStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNewStock.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colNewStock.AppearanceCell.Options.UseFont = true;
            this.colNewStock.AppearanceCell.Options.UseForeColor = true;
            this.colNewStock.AppearanceCell.Options.UseTextOptions = true;
            this.colNewStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNewStock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNewStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNewStock.AppearanceHeader.Options.UseFont = true;
            this.colNewStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colNewStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNewStock.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNewStock.Caption = "Stock Received";
            this.colNewStock.FieldName = "NewStock";
            this.colNewStock.Name = "colNewStock";
            this.colNewStock.OptionsColumn.AllowEdit = false;
            this.colNewStock.OptionsColumn.ReadOnly = true;
            this.colNewStock.Visible = true;
            this.colNewStock.VisibleIndex = 2;
            this.colNewStock.Width = 78;
            // 
            // colBalance
            // 
            this.colBalance.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBalance.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colBalance.AppearanceCell.Options.UseFont = true;
            this.colBalance.AppearanceCell.Options.UseForeColor = true;
            this.colBalance.AppearanceCell.Options.UseTextOptions = true;
            this.colBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBalance.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBalance.AppearanceHeader.Options.UseFont = true;
            this.colBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBalance.Caption = "Available Stock";
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowEdit = false;
            this.colBalance.OptionsColumn.ReadOnly = true;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 3;
            this.colBalance.Width = 79;
            // 
            // FrmNegativeStockReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 342);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmNegativeStockReplace";
            this.Text = "Negative Stock Replacement";
            this.Load += new System.EventHandler(this.FrmNegativeStockReplace_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNegativeStockReplace_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private SimpleButton simpleButton3;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource negativeStockBindingSource;
        private GridColumn colItemno;
        private GridColumn colStock;
        private GridColumn colNewStock;
        private GridColumn colBalance;

    }
}