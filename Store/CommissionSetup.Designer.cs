using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class CommissionSetup
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label cOMPNAMELabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommissionSetup));
            this.cOMMISIONDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ledgers1 = new VIRETAILENTITIES.Ledgers();
            this.iTEMMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Todate = new DevExpress.XtraEditors.DateEdit();
            this.lookupsalesman = new DevExpress.XtraEditors.LookUpEdit();
            this.LookuptoStore = new DevExpress.XtraEditors.LookUpEdit();
            this.Frmdate = new DevExpress.XtraEditors.DateEdit();
            this.Promoname = new DevExpress.XtraEditors.TextEdit();
            this.txtdocno = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSTDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTODATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARGET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.cOMMISIONMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROMONAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRMOFRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRMOTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sTOREMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cOMPNAMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMISIONDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Todate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Todate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupsalesman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookuptoStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frmdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frmdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promoname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocno.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMISIONMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(814, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(9, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 14);
            label3.TabIndex = 98;
            label3.Text = "To Date: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(9, 3);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 14);
            label4.TabIndex = 83;
            label4.Text = "From Date: ";
            // 
            // cOMPNAMELabel
            // 
            cOMPNAMELabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cOMPNAMELabel.AutoSize = true;
            cOMPNAMELabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOMPNAMELabel.Location = new System.Drawing.Point(9, 51);
            cOMPNAMELabel.Name = "cOMPNAMELabel";
            cOMPNAMELabel.Size = new System.Drawing.Size(100, 14);
            cOMPNAMELabel.TabIndex = 81;
            cOMPNAMELabel.Text = "Promation name:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(492, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 14);
            label1.TabIndex = 24;
            label1.Text = "Doc # :";
            // 
            // cOMMISIONDETAILBindingSource
            // 
            this.cOMMISIONDETAILBindingSource.DataMember = "COMMISIONDETAIL";
            this.cOMMISIONDETAILBindingSource.DataSource = this.ledgers1;
            // 
            // ledgers1
            // 
            this.ledgers1.DataSetName = "Ledgers";
            this.ledgers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMMASTBindingSource
            // 
            this.iTEMMASTBindingSource.DataMember = "ITEMMAST";
            this.iTEMMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.popupControlContainer1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Todate);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.lookupsalesman);
            this.panel1.Controls.Add(this.LookuptoStore);
            this.panel1.Controls.Add(this.Frmdate);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.Promoname);
            this.panel1.Controls.Add(cOMPNAMELabel);
            this.panel1.Controls.Add(this.txtdocno);
            this.panel1.Controls.Add(label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 75);
            this.panel1.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(259, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(211, 23);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Data Uploaded To Server";
            this.labelControl1.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 96;
            this.label5.Text = "Salesman :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = "Store name:";
            // 
            // Todate
            // 
            this.Todate.EditValue = new System.DateTime(2012, 7, 17, 0, 0, 0, 0);
            this.Todate.EnterMoveNextControl = true;
            this.Todate.Location = new System.Drawing.Point(118, 26);
            this.Todate.Name = "Todate";
            this.Todate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todate.Properties.Appearance.Options.UseFont = true;
            this.Todate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Todate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Todate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.Todate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Todate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.Todate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Todate.Size = new System.Drawing.Size(104, 20);
            this.Todate.TabIndex = 1;
            // 
            // lookupsalesman
            // 
            this.lookupsalesman.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookupsalesman.Location = new System.Drawing.Point(573, 52);
            this.lookupsalesman.Name = "lookupsalesman";
            this.lookupsalesman.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupsalesman.Properties.Appearance.Options.UseFont = true;
            this.lookupsalesman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupsalesman.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNO", "EMPNO"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERNAME", "USERNAME")});
            this.lookupsalesman.Properties.DisplayMember = "USERNAME";
            this.lookupsalesman.Properties.NullText = "";
            this.lookupsalesman.Properties.ShowFooter = false;
            this.lookupsalesman.Properties.ShowHeader = false;
            this.lookupsalesman.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupsalesman.Properties.ValueMember = "EMPNO";
            this.lookupsalesman.Size = new System.Drawing.Size(235, 20);
            this.lookupsalesman.TabIndex = 4;
            // 
            // LookuptoStore
            // 
            this.LookuptoStore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookuptoStore.Location = new System.Drawing.Point(573, 29);
            this.LookuptoStore.Name = "LookuptoStore";
            this.LookuptoStore.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookuptoStore.Properties.Appearance.Options.UseFont = true;
            this.LookuptoStore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookuptoStore.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "STORECODE", 92, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LookuptoStore.Properties.DisplayMember = "STORENAME";
            this.LookuptoStore.Properties.NullText = "";
            this.LookuptoStore.Properties.ShowFooter = false;
            this.LookuptoStore.Properties.ShowHeader = false;
            this.LookuptoStore.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookuptoStore.Properties.ValueMember = "STORECODE";
            this.LookuptoStore.Size = new System.Drawing.Size(235, 20);
            this.LookuptoStore.TabIndex = 3;
            // 
            // Frmdate
            // 
            this.Frmdate.EditValue = new System.DateTime(2012, 7, 17, 0, 0, 0, 0);
            this.Frmdate.EnterMoveNextControl = true;
            this.Frmdate.Location = new System.Drawing.Point(118, 3);
            this.Frmdate.Name = "Frmdate";
            this.Frmdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frmdate.Properties.Appearance.Options.UseFont = true;
            this.Frmdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Frmdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Frmdate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.Frmdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Frmdate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.Frmdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Frmdate.Size = new System.Drawing.Size(104, 20);
            this.Frmdate.TabIndex = 0;
            // 
            // Promoname
            // 
            this.Promoname.EnterMoveNextControl = true;
            this.Promoname.Location = new System.Drawing.Point(118, 49);
            this.Promoname.Name = "Promoname";
            this.Promoname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Promoname.Properties.Appearance.Options.UseFont = true;
            this.Promoname.Properties.Appearance.Options.UseTextOptions = true;
            this.Promoname.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Promoname.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Promoname.Size = new System.Drawing.Size(305, 20);
            this.Promoname.TabIndex = 2;
            // 
            // txtdocno
            // 
            this.txtdocno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdocno.Location = new System.Drawing.Point(573, 6);
            this.txtdocno.Name = "txtdocno";
            this.txtdocno.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtdocno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocno.Properties.Appearance.Options.UseBackColor = true;
            this.txtdocno.Properties.Appearance.Options.UseFont = true;
            this.txtdocno.Properties.Appearance.Options.UseTextOptions = true;
            this.txtdocno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtdocno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtdocno.Properties.ReadOnly = true;
            this.txtdocno.Size = new System.Drawing.Size(84, 20);
            this.txtdocno.TabIndex = 25;
            this.txtdocno.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.standaloneBarDockControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 34);
            this.panel2.TabIndex = 9;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(814, 34);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.cOMMISIONDETAILBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 254);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(814, 200);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colCOMID,
            this.colITEMID,
            this.colSTDATE,
            this.colTODATE,
            this.colTARGET});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 25;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 24;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceCell.Options.UseFont = true;
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceHeader.Options.UseFont = true;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            // 
            // colCOMID
            // 
            this.colCOMID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMID.AppearanceCell.Options.UseFont = true;
            this.colCOMID.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMID.AppearanceHeader.Options.UseFont = true;
            this.colCOMID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMID.FieldName = "COMID";
            this.colCOMID.Name = "colCOMID";
            // 
            // colITEMID
            // 
            this.colITEMID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMID.AppearanceCell.Options.UseFont = true;
            this.colITEMID.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMID.AppearanceHeader.Options.UseFont = true;
            this.colITEMID.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMID.Caption = "Item name";
            this.colITEMID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colITEMID.FieldName = "ITEMNO";
            this.colITEMID.Name = "colITEMID";
            this.colITEMID.Visible = true;
            this.colITEMID.VisibleIndex = 0;
            this.colITEMID.Width = 493;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNO", "ITEMNO", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BARCODE", "BARCODE", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "ITEMNAME", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMTYPE", "ITEMTYPE", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OWNBARCODE", "OWNBARCODE", 83, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARITEMNAME", "ARITEMNAME", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BASEUOM", "BASEUOM", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 72, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANFNAME", "MANFNAME", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("REORDER", "REORDER", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UOM", "UOM", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRINTBARCODE", "PRINTBARCODE", 88, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EXPDATEREQ", "EXPDATEREQ", 75, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACTIVE", "ACTIVE", 46, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CATEGORY", "CATEGORY", 64, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GENERICID", "GENERICID", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARGIN", "MARGIN", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARKUP", "MARKUP", 51, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DISCOUNT", "DISCOUNT", 62, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FASTMOVING", "FASTMOVING", 75, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOCATION", "LOCATION", 62, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEMPRATURE", "TEMPRATURE", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPRICE", "SPRICE", 46, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CPRICE", "CPRICE", 47, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BQNTY", "BQNTY", 43, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FSTOCK", "FSTOCK", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AVGQTY", "AVGQTY", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CREATEDBY", "CREATEDBY", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDATE", "CDATE", 43, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("editedby", "editedby", 52, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("editeddate", "editeddate", 62, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("updt", "updt", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UPD", "UPD", 30, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STAX", "STAX", 35, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SEL", "SEL", 27, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MINQTY", "MINQTY", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAXQTY", "MAXQTY", 51, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMDEM", "ITEMDEM", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COLOR", "COLOR", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WEIGHT", "WEIGHT", 50, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PICPATH", "PICPATH", 53, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("POMINQTY", "POMINQTY", 63, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("POMAXQTY", "POMAXQTY", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BINID", "BINID", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPANY", "COMPANY", 59, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DISCONSALE", "DISCONSALE", 73, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALEDISCOUNTPER", "SALEDISCOUNTPER", 105, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.repositoryItemLookUpEdit1.DataSource = this.iTEMMASTBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // colSTDATE
            // 
            this.colSTDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTDATE.AppearanceCell.Options.UseFont = true;
            this.colSTDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colSTDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTDATE.AppearanceHeader.Options.UseFont = true;
            this.colSTDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTDATE.Caption = "Date From";
            this.colSTDATE.FieldName = "STDATE";
            this.colSTDATE.Name = "colSTDATE";
            this.colSTDATE.Visible = true;
            this.colSTDATE.VisibleIndex = 2;
            this.colSTDATE.Width = 91;
            // 
            // colTODATE
            // 
            this.colTODATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTODATE.AppearanceCell.Options.UseFont = true;
            this.colTODATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTODATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTODATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTODATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTODATE.AppearanceHeader.Options.UseFont = true;
            this.colTODATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTODATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTODATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTODATE.Caption = "Date To";
            this.colTODATE.FieldName = "TODATE";
            this.colTODATE.Name = "colTODATE";
            this.colTODATE.Visible = true;
            this.colTODATE.VisibleIndex = 3;
            this.colTODATE.Width = 90;
            // 
            // colTARGET
            // 
            this.colTARGET.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTARGET.AppearanceCell.Options.UseFont = true;
            this.colTARGET.AppearanceCell.Options.UseTextOptions = true;
            this.colTARGET.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTARGET.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTARGET.AppearanceHeader.Options.UseFont = true;
            this.colTARGET.AppearanceHeader.Options.UseTextOptions = true;
            this.colTARGET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTARGET.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTARGET.Caption = "Target";
            this.colTARGET.FieldName = "TARGET";
            this.colTARGET.Name = "colTARGET";
            this.colTARGET.Visible = true;
            this.colTARGET.VisibleIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 5;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager1.UseAltKeyForMenu = false;
            this.barManager1.UseF10KeyForMenu = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Find Item - F10";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Copy From - F5";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.page_copy;
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete Line - F4";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(814, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 486);
            this.barDockControlBottom.Size = new System.Drawing.Size(814, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 486);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(814, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 486);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "Barcode / Name";
            this.repositoryItemTextEdit1.NullValuePrompt = "Barcode / Name";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.gridControl2);
            this.popupControlContainer1.Location = new System.Drawing.Point(18, 40);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbon;
            this.popupControlContainer1.Size = new System.Drawing.Size(549, 269);
            this.popupControlContainer1.TabIndex = 15;
            this.popupControlContainer1.Visible = false;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.cOMMISIONMASTBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.ribbon;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl2.Size = new System.Drawing.Size(543, 263);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // cOMMISIONMASTBindingSource
            // 
            this.cOMMISIONMASTBindingSource.DataMember = "COMMISIONMAST";
            this.cOMMISIONMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMID1,
            this.colPROMONAME,
            this.colPRMOFRM,
            this.colPRMOTO,
            this.gridColumn1,
            this.colEMPNO,
            this.colSTOREID,
            this.colUSERID,
            this.colUDATE,
            this.colEUSERID,
            this.colEDATE});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowHeight = 24;
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // colCOMID1
            // 
            this.colCOMID1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMID1.AppearanceCell.Options.UseFont = true;
            this.colCOMID1.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMID1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMID1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMID1.AppearanceHeader.Options.UseFont = true;
            this.colCOMID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMID1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMID1.Caption = "Doc #";
            this.colCOMID1.FieldName = "COMID";
            this.colCOMID1.Name = "colCOMID1";
            this.colCOMID1.OptionsColumn.AllowEdit = false;
            this.colCOMID1.OptionsColumn.AllowFocus = false;
            this.colCOMID1.Visible = true;
            this.colCOMID1.VisibleIndex = 0;
            this.colCOMID1.Width = 85;
            // 
            // colPROMONAME
            // 
            this.colPROMONAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPROMONAME.AppearanceCell.Options.UseFont = true;
            this.colPROMONAME.AppearanceCell.Options.UseTextOptions = true;
            this.colPROMONAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPROMONAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPROMONAME.AppearanceHeader.Options.UseFont = true;
            this.colPROMONAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colPROMONAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPROMONAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPROMONAME.FieldName = "PROMONAME";
            this.colPROMONAME.Name = "colPROMONAME";
            this.colPROMONAME.OptionsColumn.AllowEdit = false;
            this.colPROMONAME.OptionsColumn.AllowFocus = false;
            // 
            // colPRMOFRM
            // 
            this.colPRMOFRM.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRMOFRM.AppearanceCell.Options.UseFont = true;
            this.colPRMOFRM.AppearanceCell.Options.UseTextOptions = true;
            this.colPRMOFRM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRMOFRM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRMOFRM.AppearanceHeader.Options.UseFont = true;
            this.colPRMOFRM.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRMOFRM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRMOFRM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRMOFRM.Caption = "From Date";
            this.colPRMOFRM.FieldName = "PRMOFRM";
            this.colPRMOFRM.Name = "colPRMOFRM";
            this.colPRMOFRM.OptionsColumn.AllowEdit = false;
            this.colPRMOFRM.OptionsColumn.AllowFocus = false;
            this.colPRMOFRM.Visible = true;
            this.colPRMOFRM.VisibleIndex = 1;
            this.colPRMOFRM.Width = 79;
            // 
            // colPRMOTO
            // 
            this.colPRMOTO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRMOTO.AppearanceCell.Options.UseFont = true;
            this.colPRMOTO.AppearanceCell.Options.UseTextOptions = true;
            this.colPRMOTO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRMOTO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRMOTO.AppearanceHeader.Options.UseFont = true;
            this.colPRMOTO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRMOTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRMOTO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRMOTO.Caption = "To Date";
            this.colPRMOTO.FieldName = "PRMOTO";
            this.colPRMOTO.Name = "colPRMOTO";
            this.colPRMOTO.OptionsColumn.AllowEdit = false;
            this.colPRMOTO.OptionsColumn.AllowFocus = false;
            this.colPRMOTO.Visible = true;
            this.colPRMOTO.VisibleIndex = 2;
            this.colPRMOTO.Width = 61;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Status";
            this.gridColumn1.FieldName = "STATUS";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 52;
            // 
            // colEMPNO
            // 
            this.colEMPNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEMPNO.AppearanceCell.Options.UseFont = true;
            this.colEMPNO.AppearanceCell.Options.UseTextOptions = true;
            this.colEMPNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEMPNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEMPNO.AppearanceHeader.Options.UseFont = true;
            this.colEMPNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMPNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMPNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEMPNO.Caption = "Emp";
            this.colEMPNO.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colEMPNO.FieldName = "EMPNO";
            this.colEMPNO.Name = "colEMPNO";
            this.colEMPNO.OptionsColumn.AllowEdit = false;
            this.colEMPNO.OptionsColumn.AllowFocus = false;
            this.colEMPNO.Visible = true;
            this.colEMPNO.VisibleIndex = 3;
            this.colEMPNO.Width = 150;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.uSERINFOBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "USERNAME";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "EMPNO";
            // 
            // uSERINFOBindingSource
            // 
            this.uSERINFOBindingSource.DataMember = "USERINFO";
            this.uSERINFOBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // colSTOREID
            // 
            this.colSTOREID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOREID.AppearanceCell.Options.UseFont = true;
            this.colSTOREID.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOREID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOREID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOREID.AppearanceHeader.Options.UseFont = true;
            this.colSTOREID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOREID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOREID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOREID.Caption = "Store ";
            this.colSTOREID.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colSTOREID.FieldName = "STOREID";
            this.colSTOREID.Name = "colSTOREID";
            this.colSTOREID.OptionsColumn.AllowEdit = false;
            this.colSTOREID.OptionsColumn.AllowFocus = false;
            this.colSTOREID.Visible = true;
            this.colSTOREID.VisibleIndex = 4;
            this.colSTOREID.Width = 98;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.sTOREMASTBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "STORENAME";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "STORECODE";
            // 
            // sTOREMASTBindingSource
            // 
            this.sTOREMASTBindingSource.DataMember = "STOREMAST";
            this.sTOREMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
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
            this.colUSERID.OptionsColumn.AllowEdit = false;
            this.colUSERID.OptionsColumn.AllowFocus = false;
            // 
            // colUDATE
            // 
            this.colUDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUDATE.AppearanceCell.Options.UseFont = true;
            this.colUDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colUDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUDATE.AppearanceHeader.Options.UseFont = true;
            this.colUDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colUDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUDATE.FieldName = "UDATE";
            this.colUDATE.Name = "colUDATE";
            this.colUDATE.OptionsColumn.AllowEdit = false;
            this.colUDATE.OptionsColumn.AllowFocus = false;
            // 
            // colEUSERID
            // 
            this.colEUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEUSERID.AppearanceCell.Options.UseFont = true;
            this.colEUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEUSERID.AppearanceHeader.Options.UseFont = true;
            this.colEUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.FieldName = "EUSERID";
            this.colEUSERID.Name = "colEUSERID";
            this.colEUSERID.OptionsColumn.AllowEdit = false;
            this.colEUSERID.OptionsColumn.AllowFocus = false;
            // 
            // colEDATE
            // 
            this.colEDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEDATE.AppearanceCell.Options.UseFont = true;
            this.colEDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEDATE.AppearanceHeader.Options.UseFont = true;
            this.colEDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.FieldName = "EDATE";
            this.colEDATE.Name = "colEDATE";
            this.colEDATE.OptionsColumn.AllowEdit = false;
            this.colEDATE.OptionsColumn.AllowFocus = false;
            // 
            // CommissionSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 486);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CommissionSetup";
            this.Text = "Sales Target Setup";
            this.Load += new System.EventHandler(this.CommionSetup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommissionSetup_KeyDown);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMISIONDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Todate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Todate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupsalesman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookuptoStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frmdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frmdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promoname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocno.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMISIONMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ledgers ledgers1;
        private BindingSource iTEMMASTBindingSource;
        private BindingSource cOMMISIONDETAILBindingSource;
       
        private Bar bar1;
        private Panel panel1;
        private Label label5;
        private Label label2;
        protected DateEdit Todate;
        protected LookUpEdit lookupsalesman;
        protected LookUpEdit LookuptoStore;
        protected DateEdit Frmdate;
        protected TextEdit Promoname;
        protected TextEdit txtdocno;
        private Panel panel2;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colTID;
        private GridColumn colCOMID;
        private GridColumn colITEMID;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridColumn colSTDATE;
        private GridColumn colTODATE;
        private GridColumn colSTATUS;
        private GridColumn colTARGET;
        private StandaloneBarDockControl standaloneBarDockControl1;
        private BarManager barManager1;
        private Bar bar2;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarStaticItem barStaticItem1;
        private BarButtonItem barButtonItem3;
        private PopupControlContainer popupControlContainer1;
        private GridControl gridControl2;
        private BindingSource cOMMISIONMASTBindingSource;
        private GridView gridView2;
        private GridColumn colCOMID1;
        private GridColumn colPROMONAME;
        private GridColumn colPRMOFRM;
        private GridColumn colPRMOTO;
        private GridColumn gridColumn1;
        private GridColumn colEMPNO;
        private GridColumn colSTOREID;
        private GridColumn colUSERID;
        private GridColumn colUDATE;
        private GridColumn colEUSERID;
        private GridColumn colEDATE;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private BindingSource uSERINFOBindingSource;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private BindingSource sTOREMASTBindingSource;
        private LabelControl labelControl1;
    }
}