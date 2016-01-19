using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class RptSupplierwiseshorting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptSupplierwiseshorting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LookupSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.pURCHASEREQUESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPurchase1 = new VIRETAILENTITIES.DsPurchase();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPPLIERNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.iTEMMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getSupplierWiseShortageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dsReports1 = new VIRETAILENTITIES.DsReports();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEREQUESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSupplierWiseShortageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxEdit1);
            this.panel1.Controls.Add(this.LookupSupplier);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 31);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(102, 5);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Supplier",
            "Item Category"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(105, 20);
            this.comboBoxEdit1.TabIndex = 7;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            this.comboBoxEdit1.EditValueChanged += new System.EventHandler(this.comboBoxEdit1_EditValueChanged);
            // 
            // LookupSupplier
            // 
            this.LookupSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookupSupplier.EnterMoveNextControl = true;
            this.LookupSupplier.Location = new System.Drawing.Point(215, 5);
            this.LookupSupplier.Name = "LookupSupplier";
            this.LookupSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupSupplier.Properties.Appearance.Options.UseFont = true;
            this.LookupSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNAME", "SUPPLIERNAME", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUEDAYS", "DUEDAYS", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.LookupSupplier.Properties.DisplayMember = "SUPPLIERNAME";
            this.LookupSupplier.Properties.NullText = "";
            this.LookupSupplier.Properties.ShowHeader = false;
            this.LookupSupplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupSupplier.Properties.ValueMember = "SUPPLIERNO";
            this.LookupSupplier.Size = new System.Drawing.Size(324, 20);
            this.LookupSupplier.TabIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton2.Location = new System.Drawing.Point(621, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(74, 25);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Print";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton1.Location = new System.Drawing.Point(545, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(74, 25);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Show";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Controls.Add(this.panel3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 258);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(786, 196);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Purchase Request";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.pURCHASEREQUESTBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 48);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl2.Size = new System.Drawing.Size(782, 146);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // pURCHASEREQUESTBindingSource
            // 
            this.pURCHASEREQUESTBindingSource.DataMember = "PURCHASEREQUEST";
            this.pURCHASEREQUESTBindingSource.DataSource = this.dsPurchase1;
            // 
            // dsPurchase1
            // 
            this.dsPurchase1.DataSetName = "DsPurchase";
            this.dsPurchase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRNO,
            this.colCOMPANY,
            this.colSUPPLIERNO,
            this.colITEMNO1,
            this.colQTY,
            this.colREQDATE,
            this.colUSERID,
            this.colINORDER});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowHeight = 24;
            // 
            // colPRNO
            // 
            this.colPRNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRNO.AppearanceCell.Options.UseFont = true;
            this.colPRNO.AppearanceCell.Options.UseTextOptions = true;
            this.colPRNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRNO.AppearanceHeader.Options.UseFont = true;
            this.colPRNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRNO.Caption = "P.R No.";
            this.colPRNO.FieldName = "PRNO";
            this.colPRNO.MaxWidth = 80;
            this.colPRNO.Name = "colPRNO";
            this.colPRNO.Visible = true;
            this.colPRNO.VisibleIndex = 0;
            this.colPRNO.Width = 40;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceCell.Options.UseFont = true;
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceHeader.Options.UseFont = true;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            // 
            // colSUPPLIERNO
            // 
            this.colSUPPLIERNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPPLIERNO.AppearanceCell.Options.UseFont = true;
            this.colSUPPLIERNO.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPPLIERNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPPLIERNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPPLIERNO.AppearanceHeader.Options.UseFont = true;
            this.colSUPPLIERNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPPLIERNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPPLIERNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPPLIERNO.FieldName = "SUPPLIERNO";
            this.colSUPPLIERNO.Name = "colSUPPLIERNO";
            // 
            // colITEMNO1
            // 
            this.colITEMNO1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO1.AppearanceCell.Options.UseFont = true;
            this.colITEMNO1.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO1.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO1.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.Caption = "Item name";
            this.colITEMNO1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colITEMNO1.FieldName = "ITEMNO";
            this.colITEMNO1.Name = "colITEMNO1";
            this.colITEMNO1.Visible = true;
            this.colITEMNO1.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.iTEMMASTBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // iTEMMASTBindingSource
            // 
            this.iTEMMASTBindingSource.DataMember = "ITEMMAST";
            this.iTEMMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceCell.Options.UseFont = true;
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Req.Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.MaxWidth = 80;
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 2;
            // 
            // colREQDATE
            // 
            this.colREQDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREQDATE.AppearanceCell.Options.UseFont = true;
            this.colREQDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colREQDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREQDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREQDATE.AppearanceHeader.Options.UseFont = true;
            this.colREQDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colREQDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREQDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREQDATE.Caption = "Req. Date";
            this.colREQDATE.FieldName = "REQDATE";
            this.colREQDATE.MaxWidth = 90;
            this.colREQDATE.Name = "colREQDATE";
            this.colREQDATE.Visible = true;
            this.colREQDATE.VisibleIndex = 3;
            // 
            // colUSERID
            // 
            this.colUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceCell.Options.UseFont = true;
            this.colUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceHeader.Options.UseFont = true;
            this.colUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            // 
            // colINORDER
            // 
            this.colINORDER.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINORDER.AppearanceCell.Options.UseFont = true;
            this.colINORDER.AppearanceCell.Options.UseTextOptions = true;
            this.colINORDER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINORDER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINORDER.AppearanceHeader.Options.UseFont = true;
            this.colINORDER.AppearanceHeader.Options.UseTextOptions = true;
            this.colINORDER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINORDER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINORDER.FieldName = "INORDER";
            this.colINORDER.Name = "colINORDER";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 27);
            this.panel3.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = global::Store.Properties.Resources.Save16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton1.Text = "&Save Request";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton2.Image = global::Store.Properties.Resources.printer1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "&Print";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton3.Image = global::Store.Properties.Resources.document_list;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton3.Text = "&List";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 13);
            this.labelControl3.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(786, 227);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Shorting items ";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.getSupplierWiseShortageBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(782, 172);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // getSupplierWiseShortageBindingSource
            // 
            this.getSupplierWiseShortageBindingSource.DataMember = "GetSupplierWiseShortage";
            this.getSupplierWiseShortageBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemno,
            this.colBarcode,
            this.colItemname,
            this.colMinQty,
            this.colStock,
            this.colSel});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 24;
            // 
            // colItemno
            // 
            this.colItemno.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemno.AppearanceCell.Options.UseFont = true;
            this.colItemno.AppearanceCell.Options.UseTextOptions = true;
            this.colItemno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemno.AppearanceHeader.Options.UseFont = true;
            this.colItemno.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemno.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.Caption = "Barcode";
            this.colItemno.FieldName = "Item no";
            this.colItemno.Name = "colItemno";
            this.colItemno.OptionsColumn.AllowEdit = false;
            this.colItemno.OptionsColumn.AllowFocus = false;
            this.colItemno.Visible = true;
            this.colItemno.VisibleIndex = 1;
            this.colItemno.Width = 101;
            // 
            // colBarcode
            // 
            this.colBarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBarcode.AppearanceCell.Options.UseFont = true;
            this.colBarcode.AppearanceCell.Options.UseTextOptions = true;
            this.colBarcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBarcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBarcode.AppearanceHeader.Options.UseFont = true;
            this.colBarcode.AppearanceHeader.Options.UseTextOptions = true;
            this.colBarcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBarcode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBarcode.Caption = "Manf.Barcode";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.OptionsColumn.AllowEdit = false;
            this.colBarcode.OptionsColumn.AllowFocus = false;
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 2;
            this.colBarcode.Width = 163;
            // 
            // colItemname
            // 
            this.colItemname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemname.AppearanceCell.Options.UseFont = true;
            this.colItemname.AppearanceCell.Options.UseTextOptions = true;
            this.colItemname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemname.AppearanceHeader.Options.UseFont = true;
            this.colItemname.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.FieldName = "Item name";
            this.colItemname.Name = "colItemname";
            this.colItemname.OptionsColumn.AllowEdit = false;
            this.colItemname.OptionsColumn.AllowFocus = false;
            this.colItemname.Visible = true;
            this.colItemname.VisibleIndex = 3;
            this.colItemname.Width = 350;
            // 
            // colMinQty
            // 
            this.colMinQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMinQty.AppearanceCell.Options.UseFont = true;
            this.colMinQty.AppearanceCell.Options.UseTextOptions = true;
            this.colMinQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMinQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMinQty.AppearanceHeader.Options.UseFont = true;
            this.colMinQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colMinQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMinQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMinQty.FieldName = "Min Qty";
            this.colMinQty.Name = "colMinQty";
            this.colMinQty.OptionsColumn.AllowEdit = false;
            this.colMinQty.OptionsColumn.AllowFocus = false;
            this.colMinQty.OptionsColumn.ReadOnly = true;
            this.colMinQty.Visible = true;
            this.colMinQty.VisibleIndex = 4;
            this.colMinQty.Width = 59;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceCell.Options.UseFont = true;
            this.colStock.AppearanceCell.Options.UseTextOptions = true;
            this.colStock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStock.AppearanceHeader.Options.UseFont = true;
            this.colStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            this.colStock.OptionsColumn.AllowFocus = false;
            this.colStock.OptionsColumn.ReadOnly = true;
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 5;
            this.colStock.Width = 66;
            // 
            // colSel
            // 
            this.colSel.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSel.AppearanceCell.Options.UseFont = true;
            this.colSel.AppearanceCell.Options.UseTextOptions = true;
            this.colSel.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSel.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSel.AppearanceHeader.Options.UseFont = true;
            this.colSel.AppearanceHeader.Options.UseTextOptions = true;
            this.colSel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSel.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSel.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSel.FieldName = "Sel";
            this.colSel.Name = "colSel";
            this.colSel.Visible = true;
            this.colSel.VisibleIndex = 0;
            this.colSel.Width = 33;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            this.repositoryItemCheckEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemCheckEdit1_EditValueChanging);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 32);
            this.panel2.TabIndex = 1;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(3, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 25);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Add Item";
            this.simpleButton3.ToolTip = " ";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(682, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "F1 - Item movement";
            // 
            // dsReports1
            // 
            this.dsReports1.DataSetName = "DsReports";
            this.dsReports1.EnforceConstraints = false;
            this.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RptSupplierwiseshorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 454);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptSupplierwiseshorting";
            this.Text = "Supplier wise shorting";
            this.Load += new System.EventHandler(this.Supplierwiseshorting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Supplierwiseshorting_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEREQUESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSupplierWiseShortageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private GroupControl groupControl2;
        protected LookUpEdit LookupSupplier;
        private Panel panel3;
        private LabelControl labelControl3;
        private GroupControl groupControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private Panel panel2;
        private BindingSource getSupplierWiseShortageBindingSource;
        private GridColumn colItemno;
        private GridColumn colBarcode;
        private GridColumn colItemname;
        private GridColumn colMinQty;
        private GridColumn colStock;
        private GridColumn colSel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private GridControl gridControl2;
        private BindingSource pURCHASEREQUESTBindingSource;
        private GridView gridView2;
        private GridColumn colPRNO;
        private GridColumn colCOMPANY;
        private GridColumn colSUPPLIERNO;
        private GridColumn colITEMNO1;
        private GridColumn colQTY;
        private GridColumn colREQDATE;
        private GridColumn colUSERID;
        private GridColumn colINORDER;
        private DsPurchase dsPurchase1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BindingSource iTEMMASTBindingSource;
        private LabelControl labelControl4;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator2;
        private SimpleButton simpleButton3;
        private ComboBoxEdit comboBoxEdit1;
        private DsReports dsReports1;
    }
}