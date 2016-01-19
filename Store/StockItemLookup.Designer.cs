using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class StockItemLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockItemLookup));
            this.txtbarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sTOCKMASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKMASTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(136, 22);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Properties.Appearance.Options.UseFont = true;
            this.txtbarcode.Size = new System.Drawing.Size(281, 22);
            this.txtbarcode.TabIndex = 0;
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(43, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Item No. :";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(136, 59);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(450, 22);
            this.textEdit2.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(43, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Item Name :";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Store.Properties.Resources.viewlist16;
            this.simpleButton3.Location = new System.Drawing.Point(531, 9);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(84, 30);
            this.simpleButton3.TabIndex = 64;
            this.simpleButton3.Text = "&Clear";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.sTOCKMASTERBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 87);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(622, 281);
            this.gridControl1.TabIndex = 65;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sTOCKMASTERBindingSource
            // 
            this.sTOCKMASTERBindingSource.DataMember = "STOCKMASTER";
            this.sTOCKMASTERBindingSource.DataSource = typeof(VIRETAILENTITIES.DsInventory);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQTY,
            this.colSPRICE,
            this.colCPRICE,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 0;
            this.colQTY.Width = 81;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.Caption = "S.Price";
            this.colSPRICE.DisplayFormat.FormatString = "n2";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 1;
            this.colSPRICE.Width = 98;
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.Caption = "C.Price";
            this.colCPRICE.DisplayFormat.FormatString = "n2";
            this.colCPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.OptionsColumn.AllowEdit = false;
            this.colCPRICE.Visible = true;
            this.colCPRICE.VisibleIndex = 2;
            this.colCPRICE.Width = 95;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Item No.";
            this.gridColumn1.FieldName = "ITEMNO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 156;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Barcode";
            this.gridColumn2.FieldName = "BARCODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 174;
            // 
            // StockItemLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 380);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtbarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "StockItemLookup";
            this.Text = "Item ";
            this.Load += new System.EventHandler(this.StockFixtb_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockItemLookup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKMASTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit txtbarcode;
        private LabelControl labelControl1;
        private TextEdit textEdit2;
        private LabelControl labelControl2;
        private SimpleButton simpleButton3;
        private GridControl gridControl1;
        private BindingSource sTOCKMASTERBindingSource;
        private GridView gridView1;
        private GridColumn colQTY;
        private GridColumn colSPRICE;
        private GridColumn colCPRICE;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
    }
}