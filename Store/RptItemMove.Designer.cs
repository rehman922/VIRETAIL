using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace Store
{
    partial class RptItemMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptItemMove));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.getItemMoveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colItemname1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colitemno1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltrandate1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOpening = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPurQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRecdQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRQty1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSQty1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTQty1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPurRetQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAvailable = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getItemMoveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 33);
            this.panel1.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton1.Location = new System.Drawing.Point(378, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(66, 22);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Print";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(461, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Press F10 to add items";
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
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.getItemMoveBindingSource1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 33);
            this.gridControl2.MainView = this.bandedGridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(832, 391);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // getItemMoveBindingSource1
            // 
            this.getItemMoveBindingSource1.DataMember = "GetItemMove";
            this.getItemMoveBindingSource1.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.bandedGridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand3,
            this.gridBand2,
            this.gridBand4});
            this.bandedGridView1.ColumnPanelRowHeight = 35;
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colItemname1,
            this.colitemno1,
            this.colOpening,
            this.coltrandate1,
            this.colSQty1,
            this.colRQty1,
            this.colTQty1,
            this.colRecdQty,
            this.colPurQty,
            this.colPurRetQty,
            this.colAvailable,
            this.bandedGridColumn1});
            this.bandedGridView1.GridControl = this.gridControl2;
            this.bandedGridView1.GroupCount = 1;
            this.bandedGridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PurQty", this.colPurQty, "{0:###,###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PurRetQty", this.colPurRetQty, "{0:###,###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RecdQty", this.colRecdQty, "{0:###,###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RQty", this.colRQty1, "{0:###,###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SQty", this.colSQty1, "{0:###,###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TQty", this.colTQty1, "{0:###,###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Available", this.colAvailable, "{0:###,###}", ((short)(1))),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Opening", this.colOpening, "", "4")});
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.bandedGridView1.OptionsBehavior.ReadOnly = true;
            this.bandedGridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colItemname1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bandedGridView1.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.bandedGridView1_CustomSummaryCalculate);
            this.bandedGridView1.DoubleClick += new System.EventHandler(this.bandedGridView1_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridBand1.Columns.Add(this.colItemname1);
            this.gridBand1.Columns.Add(this.colitemno1);
            this.gridBand1.Columns.Add(this.coltrandate1);
            this.gridBand1.Columns.Add(this.colOpening);
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 386;
            // 
            // colItemname1
            // 
            this.colItemname1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colItemname1.AppearanceCell.Options.UseFont = true;
            this.colItemname1.AppearanceCell.Options.UseTextOptions = true;
            this.colItemname1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colItemname1.AppearanceHeader.Options.UseFont = true;
            this.colItemname1.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemname1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemname1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colItemname1.Caption = "Item name";
            this.colItemname1.FieldName = "Itemname";
            this.colItemname1.Name = "colItemname1";
            this.colItemname1.OptionsColumn.AllowEdit = false;
            this.colItemname1.OptionsColumn.ReadOnly = true;
            this.colItemname1.Width = 114;
            // 
            // colitemno1
            // 
            this.colitemno1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colitemno1.AppearanceCell.Options.UseFont = true;
            this.colitemno1.AppearanceCell.Options.UseTextOptions = true;
            this.colitemno1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colitemno1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colitemno1.AppearanceHeader.Options.UseFont = true;
            this.colitemno1.AppearanceHeader.Options.UseTextOptions = true;
            this.colitemno1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colitemno1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colitemno1.Caption = "Our Barcode";
            this.colitemno1.FieldName = "itemno";
            this.colitemno1.Name = "colitemno1";
            this.colitemno1.OptionsColumn.AllowEdit = false;
            this.colitemno1.OptionsColumn.ReadOnly = true;
            this.colitemno1.Visible = true;
            this.colitemno1.Width = 134;
            // 
            // coltrandate1
            // 
            this.coltrandate1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.coltrandate1.AppearanceCell.Options.UseFont = true;
            this.coltrandate1.AppearanceCell.Options.UseTextOptions = true;
            this.coltrandate1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coltrandate1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.coltrandate1.AppearanceHeader.Options.UseFont = true;
            this.coltrandate1.AppearanceHeader.Options.UseTextOptions = true;
            this.coltrandate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrandate1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.coltrandate1.Caption = "Date";
            this.coltrandate1.FieldName = "trandate";
            this.coltrandate1.Name = "coltrandate1";
            this.coltrandate1.OptionsColumn.AllowEdit = false;
            this.coltrandate1.OptionsColumn.ReadOnly = true;
            this.coltrandate1.Visible = true;
            this.coltrandate1.Width = 116;
            // 
            // colOpening
            // 
            this.colOpening.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colOpening.AppearanceCell.Options.UseFont = true;
            this.colOpening.AppearanceCell.Options.UseTextOptions = true;
            this.colOpening.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOpening.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colOpening.AppearanceHeader.Options.UseFont = true;
            this.colOpening.AppearanceHeader.Options.UseTextOptions = true;
            this.colOpening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOpening.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colOpening.Caption = "Opening";
            this.colOpening.FieldName = "Opening";
            this.colOpening.Name = "colOpening";
            this.colOpening.OptionsColumn.AllowEdit = false;
            this.colOpening.OptionsColumn.ReadOnly = true;
            this.colOpening.Visible = true;
            this.colOpening.Width = 67;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedGridColumn1.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn1.Caption = "Adjust";
            this.bandedGridColumn1.FieldName = "Aqty";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.Width = 69;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridBand3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridBand3.Caption = "In Flow";
            this.gridBand3.Columns.Add(this.colPurQty);
            this.gridBand3.Columns.Add(this.colRecdQty);
            this.gridBand3.Columns.Add(this.colRQty1);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 1;
            this.gridBand3.Width = 189;
            // 
            // colPurQty
            // 
            this.colPurQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPurQty.AppearanceCell.Options.UseFont = true;
            this.colPurQty.AppearanceCell.Options.UseTextOptions = true;
            this.colPurQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPurQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPurQty.AppearanceHeader.Options.UseFont = true;
            this.colPurQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colPurQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPurQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPurQty.Caption = "Purchase";
            this.colPurQty.FieldName = "PurQty";
            this.colPurQty.Name = "colPurQty";
            this.colPurQty.OptionsColumn.AllowEdit = false;
            this.colPurQty.OptionsColumn.ReadOnly = true;
            this.colPurQty.Visible = true;
            this.colPurQty.Width = 62;
            // 
            // colRecdQty
            // 
            this.colRecdQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colRecdQty.AppearanceCell.Options.UseFont = true;
            this.colRecdQty.AppearanceCell.Options.UseTextOptions = true;
            this.colRecdQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRecdQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colRecdQty.AppearanceHeader.Options.UseFont = true;
            this.colRecdQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colRecdQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRecdQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRecdQty.Caption = "Stock Received";
            this.colRecdQty.FieldName = "RecdQty";
            this.colRecdQty.Name = "colRecdQty";
            this.colRecdQty.OptionsColumn.AllowEdit = false;
            this.colRecdQty.OptionsColumn.ReadOnly = true;
            this.colRecdQty.Visible = true;
            this.colRecdQty.Width = 63;
            // 
            // colRQty1
            // 
            this.colRQty1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colRQty1.AppearanceCell.Options.UseFont = true;
            this.colRQty1.AppearanceCell.Options.UseTextOptions = true;
            this.colRQty1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRQty1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colRQty1.AppearanceHeader.Options.UseFont = true;
            this.colRQty1.AppearanceHeader.Options.UseTextOptions = true;
            this.colRQty1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRQty1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRQty1.Caption = "Sales Return";
            this.colRQty1.FieldName = "RQty";
            this.colRQty1.Name = "colRQty1";
            this.colRQty1.OptionsColumn.AllowEdit = false;
            this.colRQty1.OptionsColumn.ReadOnly = true;
            this.colRQty1.Visible = true;
            this.colRQty1.Width = 64;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Out Flow";
            this.gridBand2.Columns.Add(this.colSQty1);
            this.gridBand2.Columns.Add(this.colTQty1);
            this.gridBand2.Columns.Add(this.colPurRetQty);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 184;
            // 
            // colSQty1
            // 
            this.colSQty1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSQty1.AppearanceCell.Options.UseFont = true;
            this.colSQty1.AppearanceCell.Options.UseTextOptions = true;
            this.colSQty1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSQty1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSQty1.AppearanceHeader.Options.UseFont = true;
            this.colSQty1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSQty1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSQty1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSQty1.Caption = "Sold";
            this.colSQty1.FieldName = "SQty";
            this.colSQty1.Name = "colSQty1";
            this.colSQty1.OptionsColumn.AllowEdit = false;
            this.colSQty1.OptionsColumn.ReadOnly = true;
            this.colSQty1.Visible = true;
            this.colSQty1.Width = 39;
            // 
            // colTQty1
            // 
            this.colTQty1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTQty1.AppearanceCell.Options.UseFont = true;
            this.colTQty1.AppearanceCell.Options.UseTextOptions = true;
            this.colTQty1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTQty1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTQty1.AppearanceHeader.Options.UseFont = true;
            this.colTQty1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTQty1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTQty1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTQty1.Caption = "Stock Transfer";
            this.colTQty1.FieldName = "TQty";
            this.colTQty1.Name = "colTQty1";
            this.colTQty1.OptionsColumn.AllowEdit = false;
            this.colTQty1.OptionsColumn.ReadOnly = true;
            this.colTQty1.Visible = true;
            this.colTQty1.Width = 58;
            // 
            // colPurRetQty
            // 
            this.colPurRetQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPurRetQty.AppearanceCell.Options.UseFont = true;
            this.colPurRetQty.AppearanceCell.Options.UseTextOptions = true;
            this.colPurRetQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPurRetQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPurRetQty.AppearanceHeader.Options.UseFont = true;
            this.colPurRetQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colPurRetQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPurRetQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPurRetQty.Caption = "Purchase Return";
            this.colPurRetQty.FieldName = "PurRetQty";
            this.colPurRetQty.Name = "colPurRetQty";
            this.colPurRetQty.OptionsColumn.AllowEdit = false;
            this.colPurRetQty.OptionsColumn.ReadOnly = true;
            this.colPurRetQty.Visible = true;
            this.colPurRetQty.Width = 87;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridBand4.Columns.Add(this.colAvailable);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 55;
            // 
            // colAvailable
            // 
            this.colAvailable.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colAvailable.AppearanceCell.Options.UseFont = true;
            this.colAvailable.AppearanceCell.Options.UseTextOptions = true;
            this.colAvailable.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAvailable.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colAvailable.AppearanceHeader.Options.UseFont = true;
            this.colAvailable.AppearanceHeader.Options.UseTextOptions = true;
            this.colAvailable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvailable.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAvailable.Caption = "Balance";
            this.colAvailable.FieldName = "Available";
            this.colAvailable.Name = "colAvailable";
            this.colAvailable.OptionsColumn.AllowEdit = false;
            this.colAvailable.OptionsColumn.ReadOnly = true;
            this.colAvailable.Visible = true;
            this.colAvailable.Width = 55;
            // 
            // RptItemMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 424);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "RptItemMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Move Report";
            this.Load += new System.EventHandler(this.RptItemMove_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RptItemMove_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getItemMoveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DateEdit dateEdit2;
        private LabelControl labelControl2;
        private DateEdit dateEdit1;
        private LabelControl labelControl1;
        private LabelControl labelControl3;
        private SimpleButton simpleButton1;
        private GridControl gridControl2;
        private BindingSource getItemMoveBindingSource1;
        private BandedGridView bandedGridView1;
        private BandedGridColumn colItemname1;
        private BandedGridColumn colitemno1;
        private BandedGridColumn coltrandate1;
        private BandedGridColumn colOpening;
        private BandedGridColumn colSQty1;
        private BandedGridColumn colTQty1;
        private BandedGridColumn colPurRetQty;
        private BandedGridColumn colPurQty;
        private BandedGridColumn colRecdQty;
        private BandedGridColumn colRQty1;
        private BandedGridColumn colAvailable;
        private GridBand gridBand1;
        private BandedGridColumn bandedGridColumn1;
        private GridBand gridBand3;
        private GridBand gridBand2;
        private GridBand gridBand4;

    }
}