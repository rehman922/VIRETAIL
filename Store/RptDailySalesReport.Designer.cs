using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace Store
{
    partial class RptDailySalesReport
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptDailySalesReport));
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.dailySalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtcashonhand = new DevExpress.XtraEditors.TextEdit();
            this.txtinitialcash = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtsalevalue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtcostvalue = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barstorecaption = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sTOREMASTDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerBottom = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.dAILYCLOSINGDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShift1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShift2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShift3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailySalesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcashonhand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinitialcash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalevalue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcostvalue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.hideContainerBottom.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAILYCLOSINGDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Credit Type";
            this.gridColumn1.ColumnEdit = this.repositoryItemImageComboBox2;
            this.gridColumn1.FieldName = "Ctype";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 184;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Credit/ Debit Card", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Credit Customer", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Companies", 3, -1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // colType
            // 
            this.colType.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colType.AppearanceCell.Options.UseFont = true;
            this.colType.AppearanceCell.Options.UseTextOptions = true;
            this.colType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colType.AppearanceHeader.Options.UseFont = true;
            this.colType.AppearanceHeader.Options.UseTextOptions = true;
            this.colType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colType.Caption = "Description";
            this.colType.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colType.FieldName = "Ctype";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowEdit = false;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 0;
            this.colType.Width = 184;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Card Sales", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Credit Sales", 3, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sale Totals", 4, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash return", 5, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Return goods", 6, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Discount", 7, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rounding off", 8, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Profit Value", 9, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Profit %", 10, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cost Value", 11, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sale Value", 12, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Initial Cash", 13, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash on hand", 14, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Closing Diffrence", 16, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Invoice Count", 20, -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // dailySalesBindingSource
            // 
            this.dailySalesBindingSource.DataMember = "DailySales";
            this.dailySalesBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl7);
            this.panel2.Controls.Add(this.labelControl6);
            this.panel2.Controls.Add(this.txtcashonhand);
            this.panel2.Controls.Add(this.txtinitialcash);
            this.panel2.Controls.Add(this.labelControl5);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.txtsalevalue);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.txtcostvalue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(173, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 10);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineColor = System.Drawing.Color.LightSteelBlue;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(3, 40);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(142, 14);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Cash Details:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(384, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(88, 14);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Cash on hand:";
            // 
            // txtcashonhand
            // 
            this.txtcashonhand.Location = new System.Drawing.Point(478, 36);
            this.txtcashonhand.Name = "txtcashonhand";
            this.txtcashonhand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashonhand.Properties.Appearance.Options.UseFont = true;
            this.txtcashonhand.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtcashonhand.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashonhand.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtcashonhand.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtcashonhand.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtcashonhand.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcashonhand.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcashonhand.Properties.DisplayFormat.FormatString = "N2";
            this.txtcashonhand.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcashonhand.Properties.EditFormat.FormatString = "N2";
            this.txtcashonhand.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcashonhand.Properties.ReadOnly = true;
            this.txtcashonhand.Size = new System.Drawing.Size(153, 20);
            this.txtcashonhand.TabIndex = 7;
            // 
            // txtinitialcash
            // 
            this.txtinitialcash.Location = new System.Drawing.Point(228, 37);
            this.txtinitialcash.Name = "txtinitialcash";
            this.txtinitialcash.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinitialcash.Properties.Appearance.Options.UseFont = true;
            this.txtinitialcash.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtinitialcash.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinitialcash.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtinitialcash.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtinitialcash.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtinitialcash.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtinitialcash.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtinitialcash.Properties.DisplayFormat.FormatString = "N2";
            this.txtinitialcash.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtinitialcash.Properties.EditFormat.FormatString = "N2";
            this.txtinitialcash.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtinitialcash.Properties.ReadOnly = true;
            this.txtinitialcash.Size = new System.Drawing.Size(153, 20);
            this.txtinitialcash.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineColor = System.Drawing.Color.LightSteelBlue;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(3, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(142, 14);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Stock Value :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(146, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 14);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Initial Cash :";
            // 
            // txtsalevalue
            // 
            this.txtsalevalue.Location = new System.Drawing.Point(478, 6);
            this.txtsalevalue.Name = "txtsalevalue";
            this.txtsalevalue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalevalue.Properties.Appearance.Options.UseFont = true;
            this.txtsalevalue.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtsalevalue.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalevalue.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtsalevalue.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtsalevalue.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtsalevalue.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtsalevalue.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtsalevalue.Properties.DisplayFormat.FormatString = "N2";
            this.txtsalevalue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsalevalue.Properties.EditFormat.FormatString = "N2";
            this.txtsalevalue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsalevalue.Properties.ReadOnly = true;
            this.txtsalevalue.Size = new System.Drawing.Size(153, 20);
            this.txtsalevalue.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(386, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Sales Value :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(149, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Cost Value :";
            // 
            // txtcostvalue
            // 
            this.txtcostvalue.Location = new System.Drawing.Point(228, 6);
            this.txtcostvalue.Name = "txtcostvalue";
            this.txtcostvalue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcostvalue.Properties.Appearance.Options.UseFont = true;
            this.txtcostvalue.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcostvalue.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcostvalue.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtcostvalue.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtcostvalue.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtcostvalue.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcostvalue.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcostvalue.Properties.DisplayFormat.FormatString = "N2";
            this.txtcostvalue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcostvalue.Properties.EditFormat.FormatString = "N2";
            this.txtcostvalue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcostvalue.Properties.ReadOnly = true;
            this.txtcostvalue.Size = new System.Drawing.Size(153, 20);
            this.txtcostvalue.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barEditItem1,
            this.barButtonItem3,
            this.barEditItem2,
            this.barStaticItem1,
            this.barstorecaption,
            this.barEditItem4,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit2});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem2),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barstorecaption, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem4)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Print";
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.printer1;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Date :";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemDateEdit1;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 150;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "To :";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "To Date :";
            this.barEditItem2.Edit = this.repositoryItemDateEdit2;
            this.barEditItem2.Id = 4;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 150;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Show Report";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.date_magnify;
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barstorecaption
            // 
            this.barstorecaption.Caption = "Store";
            this.barstorecaption.Id = 6;
            this.barstorecaption.Name = "barstorecaption";
            this.barstorecaption.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barstorecaption.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barstorecaption.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barstorecaption_ItemClick);
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "barEditItem4";
            this.barEditItem4.Edit = this.repositoryItemLookUpEdit2;
            this.barEditItem4.Id = 9;
            this.barEditItem4.Name = "barEditItem4";
            this.barEditItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barEditItem4.Width = 150;
            this.barEditItem4.EditValueChanged += new System.EventHandler(this.barEditItem4_EditValueChanged);
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBNAME", "DBNAME", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.sTOREMASTDBBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "STORENAME";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ShowHeader = false;
            this.repositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit2.ValueMember = "DBNAME";
            // 
            // sTOREMASTDBBindingSource
            // 
            this.sTOREMASTDBBindingSource.DataMember = "STOREMASTDB";
            this.sTOREMASTDBBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lapses";
            this.barButtonItem4.Id = 10;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(879, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 448);
            this.barDockControlBottom.Size = new System.Drawing.Size(879, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 424);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(879, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 424);
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerBottom});
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerBottom
            // 
            this.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.hideContainerBottom.Controls.Add(this.dockPanel2);
            this.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hideContainerBottom.Location = new System.Drawing.Point(0, 429);
            this.hideContainerBottom.Name = "hideContainerBottom";
            this.hideContainerBottom.Size = new System.Drawing.Size(879, 19);
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel2.ID = new System.Guid("7a9c8a16-214e-48c1-9038-2bfc3647a5e1");
            this.dockPanel2.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel2.SavedIndex = 0;
            this.dockPanel2.Size = new System.Drawing.Size(769, 200);
            this.dockPanel2.Text = "Credit sales details";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.panelControl1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(761, 171);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(761, 171);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox2});
            this.gridControl2.Size = new System.Drawing.Size(757, 167);
            this.gridControl2.TabIndex = 13;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseTextOptions = true;
            styleFormatCondition1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            styleFormatCondition1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gridColumn1;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 11;
            styleFormatCondition1.Value2 = 13;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition2.Appearance.Options.HighPriority = true;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseTextOptions = true;
            styleFormatCondition2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            styleFormatCondition2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.gridColumn1;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = 4;
            this.gridView2.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsPrint.UsePrintStyles = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.RowHeight = 26;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.DisplayFormat.FormatString = "###,###,###,###.00";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "Shift1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 105;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.DisplayFormat.FormatString = "###,###,###,###.00";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "Shift2";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 105;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.DisplayFormat.FormatString = "###,###,###,###.00";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Shift3";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 93;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.DisplayFormat.FormatString = "###,###,###,###.00";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Total";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 129;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("2efaff86-c96a-4a3f-ae12-bc31c4ca5d9a");
            this.dockPanel1.Location = new System.Drawing.Point(0, 24);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(173, 200);
            this.dockPanel1.Size = new System.Drawing.Size(173, 405);
            this.dockPanel1.Text = "Closing History";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.panelControl2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(165, 378);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(165, 378);
            this.panelControl2.TabIndex = 0;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.dAILYCLOSINGDatesBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 2);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.MenuManager = this.barManager1;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(161, 374);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gridControl3.Click += new System.EventHandler(this.gridControl3_Click);
            this.gridControl3.DoubleClick += new System.EventHandler(this.gridControl3_DoubleClick);
            // 
            // dAILYCLOSINGDatesBindingSource
            // 
            this.dAILYCLOSINGDatesBindingSource.DataMember = "DAILYCLOSINGDates";
            this.dAILYCLOSINGDatesBindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCDATE});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsCustomization.AllowGroup = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCDATE, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colCDATE
            // 
            this.colCDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCDATE.AppearanceCell.Options.UseFont = true;
            this.colCDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colCDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCDATE.AppearanceHeader.Options.UseFont = true;
            this.colCDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCDATE.Caption = "Close Date";
            this.colCDATE.FieldName = "CDATE";
            this.colCDATE.Name = "colCDATE";
            this.colCDATE.OptionsColumn.AllowEdit = false;
            this.colCDATE.OptionsColumn.ReadOnly = true;
            this.colCDATE.Visible = true;
            this.colCDATE.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dailySalesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(173, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(706, 405);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 26;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colType,
            this.colShift1,
            this.colShift2,
            this.colShift3,
            this.colTotal});
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition3.Appearance.Options.HighPriority = true;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Appearance.Options.UseTextOptions = true;
            styleFormatCondition3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            styleFormatCondition3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colType;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = 11;
            styleFormatCondition3.Value2 = 13;
            styleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            styleFormatCondition4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition4.Appearance.Options.HighPriority = true;
            styleFormatCondition4.Appearance.Options.UseBackColor = true;
            styleFormatCondition4.Appearance.Options.UseFont = true;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.Appearance.Options.UseTextOptions = true;
            styleFormatCondition4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            styleFormatCondition4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.colType;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = 4;
            styleFormatCondition5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition5.Appearance.Options.UseFont = true;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.ApplyToRow = true;
            styleFormatCondition5.Column = this.colType;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition5.Value1 = 5;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3,
            styleFormatCondition4,
            styleFormatCondition5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.UsePrintStyles = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.RowHeight = 26;
            // 
            // colShift1
            // 
            this.colShift1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colShift1.AppearanceCell.Options.UseFont = true;
            this.colShift1.AppearanceCell.Options.UseTextOptions = true;
            this.colShift1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colShift1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colShift1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colShift1.AppearanceHeader.Options.UseFont = true;
            this.colShift1.AppearanceHeader.Options.UseTextOptions = true;
            this.colShift1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShift1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colShift1.DisplayFormat.FormatString = "###,###,###,###.00";
            this.colShift1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colShift1.FieldName = "Shift1";
            this.colShift1.Name = "colShift1";
            this.colShift1.OptionsColumn.AllowEdit = false;
            this.colShift1.Visible = true;
            this.colShift1.VisibleIndex = 1;
            this.colShift1.Width = 105;
            // 
            // colShift2
            // 
            this.colShift2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colShift2.AppearanceCell.Options.UseFont = true;
            this.colShift2.AppearanceCell.Options.UseTextOptions = true;
            this.colShift2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colShift2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colShift2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colShift2.AppearanceHeader.Options.UseFont = true;
            this.colShift2.AppearanceHeader.Options.UseTextOptions = true;
            this.colShift2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShift2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colShift2.DisplayFormat.FormatString = "###,###,###,###.00";
            this.colShift2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colShift2.FieldName = "Shift2";
            this.colShift2.Name = "colShift2";
            this.colShift2.OptionsColumn.AllowEdit = false;
            this.colShift2.Visible = true;
            this.colShift2.VisibleIndex = 2;
            this.colShift2.Width = 105;
            // 
            // colShift3
            // 
            this.colShift3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colShift3.AppearanceCell.Options.UseFont = true;
            this.colShift3.AppearanceCell.Options.UseTextOptions = true;
            this.colShift3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colShift3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colShift3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colShift3.AppearanceHeader.Options.UseFont = true;
            this.colShift3.AppearanceHeader.Options.UseTextOptions = true;
            this.colShift3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShift3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colShift3.DisplayFormat.FormatString = "###,###,###,###.00";
            this.colShift3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colShift3.FieldName = "Shift3";
            this.colShift3.Name = "colShift3";
            this.colShift3.OptionsColumn.AllowEdit = false;
            this.colShift3.Visible = true;
            this.colShift3.VisibleIndex = 3;
            this.colShift3.Width = 93;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotal.AppearanceCell.Options.UseFont = true;
            this.colTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotal.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotal.AppearanceHeader.Options.UseFont = true;
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotal.DisplayFormat.FormatString = "###,###,###,###.00";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 4;
            this.colTotal.Width = 129;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(364, 110);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(281, 61);
            this.progressPanel1.TabIndex = 19;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemComboBox1;
            this.barEditItem3.Id = 8;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barEditItem3.Width = 120;
            this.barEditItem3.EditValueChanged += new System.EventHandler(this.barEditItem3_EditValueChanged);
            this.barEditItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem3_ItemClick);
            // 
            // RptDailySalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 471);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.hideContainerBottom);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptDailySalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Sales Report";
            this.Load += new System.EventHandler(this.DailySalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailySalesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcashonhand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinitialcash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalevalue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcostvalue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.hideContainerBottom.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAILYCLOSINGDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource dailySalesBindingSource;
        private Panel panel2;
        private LabelControl labelControl7;
        private LabelControl labelControl6;
        private TextEdit txtcashonhand;
        private TextEdit txtinitialcash;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
        private TextEdit txtsalevalue;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private TextEdit txtcostvalue;
        private BarManager barManager1;
        private Bar bar2;
        private BarButtonItem barButtonItem1;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem2;
        private BarEditItem barEditItem1;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private BarButtonItem barButtonItem3;
        private DockManager dockManager1;
        private DockPanel dockPanel1;
        private ControlContainer dockPanel1_Container;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colType;
        private RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private GridColumn colShift1;
        private GridColumn colShift2;
        private GridColumn colShift3;
        private GridColumn colTotal;
        private DockPanel dockPanel2;
        private ControlContainer dockPanel2_Container;
        private PanelControl panelControl1;
        private GridControl gridControl2;
        private GridView gridView2;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private AutoHideContainer hideContainerBottom;
        private PanelControl panelControl2;
        private GridControl gridControl3;
        private GridView gridView3;
        private BindingSource dAILYCLOSINGDatesBindingSource;
        private GridColumn colCDATE;
        private BarStaticItem barStaticItem1;
        private BarEditItem barEditItem2;
        private RepositoryItemDateEdit repositoryItemDateEdit2;
        private BarStaticItem barstorecaption;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private ProgressPanel progressPanel1;
        private BarEditItem barEditItem4;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private BarEditItem barEditItem3;
        private BindingSource sTOREMASTDBBindingSource;
        private BarButtonItem barButtonItem4;

    }
}