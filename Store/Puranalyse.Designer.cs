using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class Puranalyse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puranalyse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.purchaseAnalyseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPurchase1 = new VIRETAILENTITIES.DsPurchase();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBONUSQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseAnalyseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 25);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(318, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "*** Data Not Found***";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.purchaseAnalyseBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(798, 352);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purchaseAnalyseBindingSource
            // 
            this.purchaseAnalyseBindingSource.DataMember = "PurchaseAnalyse";
            this.purchaseAnalyseBindingSource.DataSource = this.dsPurchase1;
            // 
            // dsPurchase1
            // 
            this.dsPurchase1.DataSetName = "DsPurchase";
            this.dsPurchase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSUPNAME,
            this.colINVNO,
            this.colINVDATE,
            this.colQTY,
            this.colBONUSQTY,
            this.colINVRATE,
            this.colCPRICE,
            this.colSPRICE,
            this.colEXPDATE,
            this.colITEMID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.colSUPNAME.Caption = "Supplier Name";
            this.colSUPNAME.FieldName = "SUPNAME";
            this.colSUPNAME.Name = "colSUPNAME";
            this.colSUPNAME.Visible = true;
            this.colSUPNAME.VisibleIndex = 0;
            this.colSUPNAME.Width = 278;
            // 
            // colINVNO
            // 
            this.colINVNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVNO.AppearanceCell.Options.UseFont = true;
            this.colINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colINVNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVNO.AppearanceHeader.Options.UseFont = true;
            this.colINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVNO.Caption = "Inv. No.";
            this.colINVNO.FieldName = "INVNO";
            this.colINVNO.Name = "colINVNO";
            this.colINVNO.OptionsColumn.ReadOnly = true;
            this.colINVNO.Visible = true;
            this.colINVNO.VisibleIndex = 1;
            this.colINVNO.Width = 68;
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
            this.colINVDATE.Caption = "Inv.Date";
            this.colINVDATE.DisplayFormat.FormatString = "MMM dd, yyyy";
            this.colINVDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colINVDATE.FieldName = "INVDATE";
            this.colINVDATE.Name = "colINVDATE";
            this.colINVDATE.OptionsColumn.ReadOnly = true;
            this.colINVDATE.Visible = true;
            this.colINVDATE.VisibleIndex = 2;
            this.colINVDATE.Width = 87;
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
            this.colQTY.Caption = "Qty.";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 31;
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
            this.colBONUSQTY.OptionsColumn.ReadOnly = true;
            this.colBONUSQTY.Visible = true;
            this.colBONUSQTY.VisibleIndex = 4;
            this.colBONUSQTY.Width = 64;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceCell.Options.UseFont = true;
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceHeader.Options.UseFont = true;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.Caption = "Inv.Rate";
            this.colINVRATE.DisplayFormat.FormatString = "N2";
            this.colINVRATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVRATE.FieldName = "INVRATE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.OptionsColumn.ReadOnly = true;
            this.colINVRATE.Visible = true;
            this.colINVRATE.VisibleIndex = 5;
            this.colINVRATE.Width = 65;
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceCell.Options.UseFont = true;
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceHeader.Options.UseFont = true;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.Caption = "Cost Price";
            this.colCPRICE.DisplayFormat.FormatString = "N2";
            this.colCPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.OptionsColumn.ReadOnly = true;
            this.colCPRICE.Visible = true;
            this.colCPRICE.VisibleIndex = 6;
            this.colCPRICE.Width = 61;
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
            this.colSPRICE.OptionsColumn.ReadOnly = true;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 7;
            this.colSPRICE.Width = 60;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceCell.Options.UseFont = true;
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceHeader.Options.UseFont = true;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.Caption = "Exp.Date";
            this.colEXPDATE.DisplayFormat.FormatString = "MM-yy";
            this.colEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.ReadOnly = true;
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.VisibleIndex = 8;
            this.colEXPDATE.Width = 66;
            // 
            // colITEMID
            // 
            this.colITEMID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMID.AppearanceCell.Options.UseFont = true;
            this.colITEMID.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMID.AppearanceHeader.Options.UseFont = true;
            this.colITEMID.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMID.FieldName = "ITEMID";
            this.colITEMID.Name = "colITEMID";
            this.colITEMID.OptionsColumn.ReadOnly = true;
            // 
            // Puranalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Puranalyse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Puranalyse";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Puranalyse_KeyDown);
            this.Resize += new System.EventHandler(this.Puranalyse_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseAnalyseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colSUPNAME;
        private GridColumn colINVNO;
        private GridColumn colINVDATE;
        private GridColumn colQTY;
        private GridColumn colBONUSQTY;
        private GridColumn colINVRATE;
        private GridColumn colCPRICE;
        private GridColumn colSPRICE;
        private GridColumn colEXPDATE;
        private GridColumn colITEMID;
        private Label label1;
        private BindingSource purchaseAnalyseBindingSource;
        private DsPurchase dsPurchase1;
    }
}