using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class Dosages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dosages));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dOSAGESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDNAMEAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDNAMEEN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSAGESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dOSAGESBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(603, 452);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dOSAGESBindingSource
            // 
            this.dOSAGESBindingSource.DataMember = "DOSAGES";
            this.dOSAGESBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colDDNAMEAR,
            this.colDDNAMEEN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTID
            // 
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.Width = 29;
            // 
            // colDDNAMEAR
            // 
            this.colDDNAMEAR.AppearanceCell.Options.UseTextOptions = true;
            this.colDDNAMEAR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDDNAMEAR.AppearanceHeader.Options.UseTextOptions = true;
            this.colDDNAMEAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDDNAMEAR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDDNAMEAR.Caption = "Arabic";
            this.colDDNAMEAR.FieldName = "DDNAMEAR";
            this.colDDNAMEAR.Name = "colDDNAMEAR";
            this.colDDNAMEAR.Visible = true;
            this.colDDNAMEAR.VisibleIndex = 0;
            this.colDDNAMEAR.Width = 294;
            // 
            // colDDNAMEEN
            // 
            this.colDDNAMEEN.AppearanceCell.Options.UseTextOptions = true;
            this.colDDNAMEEN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDDNAMEEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colDDNAMEEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDDNAMEEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDDNAMEEN.Caption = "English";
            this.colDDNAMEEN.FieldName = "DDNAMEEN";
            this.colDDNAMEEN.Name = "colDDNAMEEN";
            this.colDDNAMEEN.Visible = true;
            this.colDDNAMEEN.VisibleIndex = 1;
            this.colDDNAMEEN.Width = 291;
            // 
            // Dosages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 452);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dosages";
            this.Text = "Dosages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dosages_FormClosing);
            this.Load += new System.EventHandler(this.Dosages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSAGESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource dOSAGESBindingSource;
        private GridColumn colTID;
        private GridColumn colDDNAMEAR;
        private GridColumn colDDNAMEEN;
        private DsMaster dsMaster1;
    }
}