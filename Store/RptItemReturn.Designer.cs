using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptItemReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptItemReturn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.salesReturnListBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLINETOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReturnListBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 33);
            this.panel1.TabIndex = 6;
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
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
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
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
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
            this.gridControl1.DataSource = this.salesReturnListBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2,
            this.repositoryItemHyperLinkEdit3,
            this.repositoryItemHyperLinkEdit4});
            this.gridControl1.Size = new System.Drawing.Size(918, 404);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // salesReturnListBindingSource
            // 
            this.salesReturnListBindingSource.DataMember = "SalesReturnList";
            this.salesReturnListBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANDATE,
            this.colTDate,
            this.colSINVNO,
            this.colBARCODE,
            this.colITEMNAME,
            this.colQty,
            this.colINVRATE,
            this.colLINETOTAL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", this.colQty, "{0:####}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "INVRATE", this.colINVRATE, "{0:###,###.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LINETOTAL", this.colLINETOTAL, "{0:###,###,###.00}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 24;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRANDATE, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceCell.Options.UseFont = true;
            this.colTRANDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceHeader.Options.UseFont = true;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Date";
            this.colTRANDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.OptionsColumn.ReadOnly = true;
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 0;
            // 
            // colTDate
            // 
            this.colTDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTDate.AppearanceCell.Options.UseFont = true;
            this.colTDate.AppearanceCell.Options.UseTextOptions = true;
            this.colTDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTDate.AppearanceHeader.Options.UseFont = true;
            this.colTDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colTDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTDate.Caption = "Date";
            this.colTDate.DisplayFormat.FormatString = "d";
            this.colTDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTDate.FieldName = "TDate";
            this.colTDate.Name = "colTDate";
            this.colTDate.OptionsColumn.AllowEdit = false;
            this.colTDate.OptionsColumn.ReadOnly = true;
            this.colTDate.Visible = true;
            this.colTDate.VisibleIndex = 0;
            this.colTDate.Width = 99;
            // 
            // colSINVNO
            // 
            this.colSINVNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSINVNO.AppearanceCell.Options.UseFont = true;
            this.colSINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSINVNO.AppearanceHeader.Options.UseFont = true;
            this.colSINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.Caption = "Inv No.";
            this.colSINVNO.FieldName = "SINVNO";
            this.colSINVNO.MaxWidth = 80;
            this.colSINVNO.Name = "colSINVNO";
            this.colSINVNO.OptionsColumn.AllowEdit = false;
            this.colSINVNO.OptionsColumn.ReadOnly = true;
            this.colSINVNO.Visible = true;
            this.colSINVNO.VisibleIndex = 1;
            this.colSINVNO.Width = 80;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceCell.Options.UseFont = true;
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceHeader.Options.UseFont = true;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.Caption = "Barcode";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.MaxWidth = 110;
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.ReadOnly = true;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 2;
            this.colBARCODE.Width = 110;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNAME.AppearanceCell.Options.UseFont = true;
            this.colITEMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colITEMNAME.VisibleIndex = 3;
            this.colITEMNAME.Width = 370;
            // 
            // colQty
            // 
            this.colQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQty.AppearanceCell.Options.UseFont = true;
            this.colQty.AppearanceCell.Options.UseTextOptions = true;
            this.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQty.AppearanceHeader.Options.UseFont = true;
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.Caption = "Qty";
            this.colQty.DisplayFormat.FormatString = "N";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.AllowEdit = false;
            this.colQty.OptionsColumn.ReadOnly = true;
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 4;
            this.colQty.Width = 56;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceCell.Options.UseFont = true;
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceHeader.Options.UseFont = true;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.Caption = "Price";
            this.colINVRATE.DisplayFormat.FormatString = "N2";
            this.colINVRATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVRATE.FieldName = "INVRATE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.OptionsColumn.AllowEdit = false;
            this.colINVRATE.OptionsColumn.ReadOnly = true;
            this.colINVRATE.Visible = true;
            this.colINVRATE.VisibleIndex = 5;
            this.colINVRATE.Width = 63;
            // 
            // colLINETOTAL
            // 
            this.colLINETOTAL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLINETOTAL.AppearanceCell.Options.UseFont = true;
            this.colLINETOTAL.AppearanceCell.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINETOTAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLINETOTAL.AppearanceHeader.Options.UseFont = true;
            this.colLINETOTAL.AppearanceHeader.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.Caption = "Total";
            this.colLINETOTAL.DisplayFormat.FormatString = "N2";
            this.colLINETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLINETOTAL.FieldName = "LINETOTAL";
            this.colLINETOTAL.Name = "colLINETOTAL";
            this.colLINETOTAL.OptionsColumn.AllowEdit = false;
            this.colLINETOTAL.OptionsColumn.ReadOnly = true;
            this.colLINETOTAL.Visible = true;
            this.colLINETOTAL.VisibleIndex = 6;
            this.colLINETOTAL.Width = 85;
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
            // RptItemReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 437);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptItemReturn";
            this.Text = "Sales Return List";
            this.Load += new System.EventHandler(this.RptItemReturn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReturnListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton1;
        private DateEdit dateEdit2;
        private LabelControl labelControl2;
        private DateEdit dateEdit1;
        private LabelControl labelControl1;
        private SimpleButton simpleButton2;
        private GridControl gridControl1;
        private GridView gridView1;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit3;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit4;
        private BindingSource salesReturnListBindingSource;
        private GridColumn colTRANDATE;
        private GridColumn colTDate;
        private GridColumn colSINVNO;
        private GridColumn colBARCODE;
        private GridColumn colITEMNAME;
        private GridColumn colQty;
        private GridColumn colINVRATE;
        private GridColumn colLINETOTAL;
    }
}