using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class CustomerCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCenter));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCUSTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMERTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCUSTOMERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTCOMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIXDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIXDISCAMTPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREDITLIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBINID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMERPOINT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLASTREDIMINV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAYTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCUSTOMERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMBERNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVERPOINTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(920, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Store.Properties.Resources.page_white_star16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "NEW";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::Store.Properties.Resources.gtkrefresh;
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel1.Text = "Refresh";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.cUSTOMERBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2});
            this.gridControl1.Size = new System.Drawing.Size(920, 394);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCUSTNO,
            this.colCUSTOMERTYPE,
            this.colCUSTOMERID,
            this.colCUSTCOMP,
            this.colPHONE,
            this.colMobile,
            this.colEMAIL,
            this.colNOTE,
            this.colFIXDISC,
            this.colFIXDISCAMTPER,
            this.colCREDITLIMIT,
            this.colCOMPANY,
            this.colBINID,
            this.colCUSERID,
            this.colCDATE,
            this.colEUSERID,
            this.colEDATE,
            this.colCUSTOMERPOINT,
            this.colLASTREDIMINV,
            this.colPAYTYPE,
            this.colCUSTOMERNAME,
            this.colMEMBERNO,
            this.colSERVERPOINTS});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCUSTNO
            // 
            this.colCUSTNO.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNO.FieldName = "CUSTNO";
            this.colCUSTNO.Name = "colCUSTNO";
            this.colCUSTNO.OptionsColumn.AllowEdit = false;
            this.colCUSTNO.OptionsColumn.ReadOnly = true;
            this.colCUSTNO.Width = 62;
            // 
            // colCUSTOMERTYPE
            // 
            this.colCUSTOMERTYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTOMERTYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERTYPE.Caption = "TYPE";
            this.colCUSTOMERTYPE.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colCUSTOMERTYPE.FieldName = "CUSTOMERTYPE";
            this.colCUSTOMERTYPE.Name = "colCUSTOMERTYPE";
            this.colCUSTOMERTYPE.OptionsColumn.AllowEdit = false;
            this.colCUSTOMERTYPE.OptionsColumn.ReadOnly = true;
            this.colCUSTOMERTYPE.Visible = true;
            this.colCUSTOMERTYPE.VisibleIndex = 0;
            this.colCUSTOMERTYPE.Width = 78;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Members", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Insurance", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Credit", 2, -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colCUSTOMERID
            // 
            this.colCUSTOMERID.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTOMERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERID.FieldName = "CUSTOMERID";
            this.colCUSTOMERID.Name = "colCUSTOMERID";
            this.colCUSTOMERID.OptionsColumn.AllowEdit = false;
            this.colCUSTOMERID.OptionsColumn.ReadOnly = true;
            this.colCUSTOMERID.Width = 80;
            // 
            // colCUSTCOMP
            // 
            this.colCUSTCOMP.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTCOMP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTCOMP.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTCOMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTCOMP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTCOMP.FieldName = "CUSTCOMP";
            this.colCUSTCOMP.Name = "colCUSTCOMP";
            this.colCUSTCOMP.OptionsColumn.AllowEdit = false;
            this.colCUSTCOMP.OptionsColumn.ReadOnly = true;
            this.colCUSTCOMP.Visible = true;
            this.colCUSTCOMP.VisibleIndex = 2;
            this.colCUSTCOMP.Width = 114;
            // 
            // colPHONE
            // 
            this.colPHONE.AppearanceCell.Options.UseTextOptions = true;
            this.colPHONE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHONE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHONE.FieldName = "PHONE";
            this.colPHONE.Name = "colPHONE";
            this.colPHONE.OptionsColumn.AllowEdit = false;
            this.colPHONE.OptionsColumn.ReadOnly = true;
            this.colPHONE.Visible = true;
            this.colPHONE.VisibleIndex = 3;
            this.colPHONE.Width = 53;
            // 
            // colMobile
            // 
            this.colMobile.AppearanceCell.Options.UseTextOptions = true;
            this.colMobile.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMobile.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.OptionsColumn.AllowEdit = false;
            this.colMobile.OptionsColumn.ReadOnly = true;
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 4;
            this.colMobile.Width = 53;
            // 
            // colEMAIL
            // 
            this.colEMAIL.AppearanceCell.Options.UseTextOptions = true;
            this.colEMAIL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEMAIL.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMAIL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.OptionsColumn.AllowEdit = false;
            this.colEMAIL.OptionsColumn.ReadOnly = true;
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 5;
            this.colEMAIL.Width = 53;
            // 
            // colNOTE
            // 
            this.colNOTE.AppearanceCell.Options.UseTextOptions = true;
            this.colNOTE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOTE.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOTE.FieldName = "NOTE";
            this.colNOTE.Name = "colNOTE";
            this.colNOTE.OptionsColumn.AllowEdit = false;
            this.colNOTE.OptionsColumn.ReadOnly = true;
            this.colNOTE.Width = 51;
            // 
            // colFIXDISC
            // 
            this.colFIXDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colFIXDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFIXDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colFIXDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFIXDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFIXDISC.FieldName = "FIXDISC";
            this.colFIXDISC.Name = "colFIXDISC";
            this.colFIXDISC.OptionsColumn.AllowEdit = false;
            this.colFIXDISC.OptionsColumn.ReadOnly = true;
            // 
            // colFIXDISCAMTPER
            // 
            this.colFIXDISCAMTPER.AppearanceCell.Options.UseTextOptions = true;
            this.colFIXDISCAMTPER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFIXDISCAMTPER.AppearanceHeader.Options.UseTextOptions = true;
            this.colFIXDISCAMTPER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFIXDISCAMTPER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFIXDISCAMTPER.FieldName = "FIXDISCAMTPER";
            this.colFIXDISCAMTPER.Name = "colFIXDISCAMTPER";
            this.colFIXDISCAMTPER.OptionsColumn.AllowEdit = false;
            this.colFIXDISCAMTPER.OptionsColumn.ReadOnly = true;
            // 
            // colCREDITLIMIT
            // 
            this.colCREDITLIMIT.AppearanceCell.Options.UseTextOptions = true;
            this.colCREDITLIMIT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCREDITLIMIT.AppearanceHeader.Options.UseTextOptions = true;
            this.colCREDITLIMIT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCREDITLIMIT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCREDITLIMIT.FieldName = "CREDITLIMIT";
            this.colCREDITLIMIT.Name = "colCREDITLIMIT";
            this.colCREDITLIMIT.OptionsColumn.AllowEdit = false;
            this.colCREDITLIMIT.OptionsColumn.ReadOnly = true;
            this.colCREDITLIMIT.Visible = true;
            this.colCREDITLIMIT.VisibleIndex = 6;
            this.colCREDITLIMIT.Width = 84;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.OptionsColumn.AllowEdit = false;
            this.colCOMPANY.OptionsColumn.ReadOnly = true;
            // 
            // colBINID
            // 
            this.colBINID.AppearanceCell.Options.UseTextOptions = true;
            this.colBINID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBINID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBINID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.FieldName = "BINID";
            this.colBINID.Name = "colBINID";
            this.colBINID.OptionsColumn.AllowEdit = false;
            this.colBINID.OptionsColumn.ReadOnly = true;
            // 
            // colCUSERID
            // 
            this.colCUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSERID.FieldName = "CUSERID";
            this.colCUSERID.Name = "colCUSERID";
            this.colCUSERID.OptionsColumn.AllowEdit = false;
            this.colCUSERID.OptionsColumn.ReadOnly = true;
            // 
            // colCDATE
            // 
            this.colCDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colCDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCDATE.FieldName = "CDATE";
            this.colCDATE.Name = "colCDATE";
            this.colCDATE.OptionsColumn.AllowEdit = false;
            this.colCDATE.OptionsColumn.ReadOnly = true;
            // 
            // colEUSERID
            // 
            this.colEUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.FieldName = "EUSERID";
            this.colEUSERID.Name = "colEUSERID";
            this.colEUSERID.OptionsColumn.AllowEdit = false;
            this.colEUSERID.OptionsColumn.ReadOnly = true;
            // 
            // colEDATE
            // 
            this.colEDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.FieldName = "EDATE";
            this.colEDATE.Name = "colEDATE";
            this.colEDATE.OptionsColumn.AllowEdit = false;
            this.colEDATE.OptionsColumn.ReadOnly = true;
            // 
            // colCUSTOMERPOINT
            // 
            this.colCUSTOMERPOINT.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTOMERPOINT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERPOINT.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERPOINT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERPOINT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERPOINT.Caption = "POINTS";
            this.colCUSTOMERPOINT.FieldName = "CUSTOMERPOINT";
            this.colCUSTOMERPOINT.Name = "colCUSTOMERPOINT";
            this.colCUSTOMERPOINT.OptionsColumn.AllowEdit = false;
            this.colCUSTOMERPOINT.OptionsColumn.ReadOnly = true;
            this.colCUSTOMERPOINT.Visible = true;
            this.colCUSTOMERPOINT.VisibleIndex = 7;
            this.colCUSTOMERPOINT.Width = 56;
            // 
            // colLASTREDIMINV
            // 
            this.colLASTREDIMINV.AppearanceCell.Options.UseTextOptions = true;
            this.colLASTREDIMINV.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLASTREDIMINV.AppearanceHeader.Options.UseTextOptions = true;
            this.colLASTREDIMINV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLASTREDIMINV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLASTREDIMINV.Caption = "LAST REDIM";
            this.colLASTREDIMINV.FieldName = "LASTREDIMINV";
            this.colLASTREDIMINV.Name = "colLASTREDIMINV";
            this.colLASTREDIMINV.OptionsColumn.AllowEdit = false;
            this.colLASTREDIMINV.OptionsColumn.ReadOnly = true;
            this.colLASTREDIMINV.Visible = true;
            this.colLASTREDIMINV.VisibleIndex = 8;
            this.colLASTREDIMINV.Width = 73;
            // 
            // colPAYTYPE
            // 
            this.colPAYTYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colPAYTYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPAYTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPAYTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPAYTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPAYTYPE.ColumnEdit = this.repositoryItemImageComboBox2;
            this.colPAYTYPE.FieldName = "PAYTYPE";
            this.colPAYTYPE.Name = "colPAYTYPE";
            this.colPAYTYPE.OptionsColumn.AllowEdit = false;
            this.colPAYTYPE.OptionsColumn.ReadOnly = true;
            this.colPAYTYPE.Visible = true;
            this.colPAYTYPE.VisibleIndex = 9;
            this.colPAYTYPE.Width = 59;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Company", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Personnel", 1, -1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // colCUSTOMERNAME
            // 
            this.colCUSTOMERNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTOMERNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERNAME.FieldName = "CUSTOMERNAME";
            this.colCUSTOMERNAME.Name = "colCUSTOMERNAME";
            this.colCUSTOMERNAME.OptionsColumn.AllowEdit = false;
            this.colCUSTOMERNAME.OptionsColumn.ReadOnly = true;
            this.colCUSTOMERNAME.Visible = true;
            this.colCUSTOMERNAME.VisibleIndex = 1;
            this.colCUSTOMERNAME.Width = 192;
            // 
            // colMEMBERNO
            // 
            this.colMEMBERNO.AppearanceCell.Options.UseTextOptions = true;
            this.colMEMBERNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMEMBERNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colMEMBERNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMEMBERNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMEMBERNO.FieldName = "MEMBERNO";
            this.colMEMBERNO.Name = "colMEMBERNO";
            this.colMEMBERNO.OptionsColumn.AllowEdit = false;
            this.colMEMBERNO.OptionsColumn.ReadOnly = true;
            this.colMEMBERNO.Visible = true;
            this.colMEMBERNO.VisibleIndex = 10;
            this.colMEMBERNO.Width = 87;
            // 
            // colSERVERPOINTS
            // 
            this.colSERVERPOINTS.AppearanceCell.Options.UseTextOptions = true;
            this.colSERVERPOINTS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSERVERPOINTS.AppearanceHeader.Options.UseTextOptions = true;
            this.colSERVERPOINTS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSERVERPOINTS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSERVERPOINTS.FieldName = "SERVERPOINTS";
            this.colSERVERPOINTS.Name = "colSERVERPOINTS";
            this.colSERVERPOINTS.OptionsColumn.AllowEdit = false;
            this.colSERVERPOINTS.OptionsColumn.ReadOnly = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Store.Properties.Resources.printer1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "Print";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // CustomerCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 419);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerCenter";
            this.Text = "Customer Center";
            this.Load += new System.EventHandler(this.CustomerCenter_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private GridControl gridControl1;
        private BindingSource cUSTOMERBindingSource;
        private GridView gridView1;
        private GridColumn colCUSTNO;
        private GridColumn colCUSTOMERTYPE;
        private GridColumn colCUSTOMERID;
        private GridColumn colCUSTCOMP;
        private GridColumn colPHONE;
        private GridColumn colMobile;
        private GridColumn colEMAIL;
        private GridColumn colNOTE;
        private GridColumn colFIXDISC;
        private GridColumn colFIXDISCAMTPER;
        private GridColumn colCREDITLIMIT;
        private GridColumn colCOMPANY;
        private GridColumn colBINID;
        private GridColumn colCUSERID;
        private GridColumn colCDATE;
        private GridColumn colEUSERID;
        private GridColumn colEDATE;
        private GridColumn colCUSTOMERPOINT;
        private GridColumn colLASTREDIMINV;
        private GridColumn colPAYTYPE;
        private GridColumn colCUSTOMERNAME;
        private GridColumn colMEMBERNO;
        private GridColumn colSERVERPOINTS;
        private RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton2;
    }
}