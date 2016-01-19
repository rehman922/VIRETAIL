using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptItemExpiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptItemExpiry));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.itemWiseExpiryReportBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGROUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWiseExpiryReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 33);
            this.panel1.TabIndex = 9;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.funnelicon;
            this.simpleButton2.Location = new System.Drawing.Point(378, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(26, 22);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton1.Location = new System.Drawing.Point(410, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(26, 22);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(262, 6);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Properties.DisplayFormat.FormatString = "MM-yyyy";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.EditFormat.FormatString = "MM-yyyy";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.Mask.EditMask = "MM-yyyy";
            this.dateEdit1.Size = new System.Drawing.Size(110, 20);
            this.dateEdit1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(222, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Date :";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.itemWiseExpiryReportBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2,
            this.repositoryItemHyperLinkEdit3,
            this.repositoryItemHyperLinkEdit4});
            this.gridControl1.Size = new System.Drawing.Size(686, 411);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // itemWiseExpiryReportBindingSource
            // 
            this.itemWiseExpiryReportBindingSource.DataMember = "ItemWiseExpiryReport";
            this.itemWiseExpiryReportBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGROUPNAME,
            this.colColumn1,
            this.colexpdate,
            this.colITEMNO,
            this.colBARCODE,
            this.colItemname});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 24;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGROUPNAME, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colItemname, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colGROUPNAME
            // 
            this.colGROUPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colGROUPNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colGROUPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGROUPNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPNAME.FieldName = "GROUPNAME";
            this.colGROUPNAME.Name = "colGROUPNAME";
            this.colGROUPNAME.Width = 145;
            // 
            // colColumn1
            // 
            this.colColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colColumn1.AppearanceCell.Options.UseFont = true;
            this.colColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.colColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.colColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colColumn1.Caption = "STOCK";
            this.colColumn1.FieldName = "Expr1";
            this.colColumn1.Name = "colColumn1";
            this.colColumn1.OptionsColumn.ReadOnly = true;
            this.colColumn1.Visible = true;
            this.colColumn1.VisibleIndex = 3;
            this.colColumn1.Width = 85;
            // 
            // colexpdate
            // 
            this.colexpdate.AppearanceCell.Options.UseTextOptions = true;
            this.colexpdate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colexpdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colexpdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colexpdate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colexpdate.Caption = "EXPIRY";
            this.colexpdate.DisplayFormat.FormatString = "MM-yyyy";
            this.colexpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colexpdate.FieldName = "EXPDATE";
            this.colexpdate.Name = "colexpdate";
            this.colexpdate.Width = 76;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 0;
            this.colITEMNO.Width = 146;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 1;
            this.colBARCODE.Width = 124;
            // 
            // colItemname
            // 
            this.colItemname.AppearanceCell.Options.UseTextOptions = true;
            this.colItemname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.Caption = "ITEM NAME";
            this.colItemname.FieldName = "ITEMNAME";
            this.colItemname.Name = "colItemname";
            this.colItemname.Visible = true;
            this.colItemname.VisibleIndex = 2;
            this.colItemname.Width = 237;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // repositoryItemHyperLinkEdit2
            // 
            this.repositoryItemHyperLinkEdit2.AutoHeight = false;
            this.repositoryItemHyperLinkEdit2.Name = "repositoryItemHyperLinkEdit2";
            // 
            // repositoryItemHyperLinkEdit3
            // 
            this.repositoryItemHyperLinkEdit3.AutoHeight = false;
            this.repositoryItemHyperLinkEdit3.Name = "repositoryItemHyperLinkEdit3";
            // 
            // repositoryItemHyperLinkEdit4
            // 
            this.repositoryItemHyperLinkEdit4.AutoHeight = false;
            this.repositoryItemHyperLinkEdit4.Name = "repositoryItemHyperLinkEdit4";
            // 
            // RptItemExpiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 444);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptItemExpiry";
            this.Text = "Item Expiry Report";
            this.Load += new System.EventHandler(this.RptItemExpiry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWiseExpiryReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private DateEdit dateEdit1;
        private LabelControl labelControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit3;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit4;
        private BindingSource itemWiseExpiryReportBindingSource;
        private GridColumn colGROUPNAME;
        private GridColumn colColumn1;
        private GridColumn colexpdate;
        private GridColumn colITEMNO;
        private GridColumn colBARCODE;
        private GridColumn colItemname;
    }
}