using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptItemWiseSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptItemWiseSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.itemWiseSalesSummaryNewBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGROUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.itemWiseSalesSummaryBindingSource = new System.Windows.Forms.BindingSource();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWiseSalesSummaryNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWiseSalesSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 33);
            this.panel1.TabIndex = 7;
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
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(255, 7);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(117, 20);
            this.dateEdit2.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(196, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Date To :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(80, 7);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(110, 20);
            this.dateEdit1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(10, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Date From :";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.itemWiseSalesSummaryNewBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2,
            this.repositoryItemHyperLinkEdit3,
            this.repositoryItemHyperLinkEdit4});
            this.gridControl1.Size = new System.Drawing.Size(635, 461);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // itemWiseSalesSummaryNewBindingSource
            // 
            this.itemWiseSalesSummaryNewBindingSource.DataMember = "ItemWiseSalesSummaryNew";
            this.itemWiseSalesSummaryNewBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
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
            this.colITEMNO,
            this.colITEMNAME,
            this.colGROUPNAME,
            this.colTRANDATE,
            this.colQty,
            this.gridColumn2,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL", this.gridColumn1, "{0:###,###,###.00}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.RowHeight = 24;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGROUPNAME, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Item No.";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 2;
            this.colITEMNO.Width = 107;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.Caption = "Item name";
            this.colITEMNAME.FieldName = "ITEMNAME";
            this.colITEMNAME.Name = "colITEMNAME";
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 1;
            this.colITEMNAME.Width = 195;
            // 
            // colGROUPNAME
            // 
            this.colGROUPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colGROUPNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colGROUPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGROUPNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPNAME.Caption = "Group name";
            this.colGROUPNAME.FieldName = "GROUPNAME";
            this.colGROUPNAME.Name = "colGROUPNAME";
            this.colGROUPNAME.Visible = true;
            this.colGROUPNAME.VisibleIndex = 0;
            this.colGROUPNAME.Width = 81;
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Tran Date";
            this.colTRANDATE.DisplayFormat.FormatString = "dd MMM, yyyy";
            this.colTRANDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.MaxWidth = 120;
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 3;
            this.colTRANDATE.Width = 112;
            // 
            // colQty
            // 
            this.colQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQty.AppearanceCell.Options.UseFont = true;
            this.colQty.AppearanceCell.Options.UseTextOptions = true;
            this.colQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.Caption = "Qty";
            this.colQty.FieldName = "Qty";
            this.colQty.MaxWidth = 50;
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.ReadOnly = true;
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 4;
            this.colQty.Width = 46;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "S.Price";
            this.gridColumn2.FieldName = "SPRICE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Total";
            this.gridColumn1.DisplayFormat.FormatString = "###,###,###,###.##";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "TOTAL";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL", "{0:###,###,###.00}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 76;
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
            // itemWiseSalesSummaryBindingSource
            // 
            this.itemWiseSalesSummaryBindingSource.DataMember = "ItemWiseSalesSummary";
            this.itemWiseSalesSummaryBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // RptItemWiseSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 494);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptItemWiseSales";
            this.Text = "Item Wise Sales Summary Report";
            this.Load += new System.EventHandler(this.RptItemWiseSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWiseSalesSummaryNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWiseSalesSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private DateEdit dateEdit2;
        private LabelControl labelControl2;
        private DateEdit dateEdit1;
        private LabelControl labelControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit3;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit4;
        private BindingSource itemWiseSalesSummaryBindingSource;
        private BindingSource itemWiseSalesSummaryNewBindingSource;
        private GridColumn colITEMNO;
        private GridColumn colITEMNAME;
        private GridColumn colGROUPNAME;
        private GridColumn colTRANDATE;
        private GridColumn colQty;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;

    }
}