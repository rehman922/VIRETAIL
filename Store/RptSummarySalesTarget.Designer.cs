using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Store
{
    partial class RptSummarySalesTarget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptSummarySalesTarget));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.sTOREMASTDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cOMMISIONMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.salesTargetFrmDtToDtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstdat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colendat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gETSALESTARGETBYDATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEMPSALTARGETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMISIONMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTargetFrmDtToDtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETSALESTARGETBYDATEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEMPSALTARGETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.lookUpEdit3);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.lookUpEdit2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 59);
            this.panel1.TabIndex = 1;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(487, 8);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(121, 20);
            this.dateEdit2.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(433, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 14);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "From  :";
            this.labelControl4.Visible = false;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(487, 33);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(121, 20);
            this.dateEdit1.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(433, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 14);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "To  :";
            this.labelControl2.Visible = false;
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(90, 10);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBNAME", "DBNAME", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit3.Properties.DataSource = this.sTOREMASTDBBindingSource;
            this.lookUpEdit3.Properties.DisplayMember = "STORENAME";
            this.lookUpEdit3.Properties.NullText = "";
            this.lookUpEdit3.Properties.ShowHeader = false;
            this.lookUpEdit3.Properties.ValueMember = "DBNAME";
            this.lookUpEdit3.Size = new System.Drawing.Size(212, 20);
            this.lookUpEdit3.TabIndex = 0;
            this.lookUpEdit3.EditValueChanged += new System.EventHandler(this.lookUpEdit3_EditValueChanged);
            // 
            // sTOREMASTDBBindingSource
            // 
            this.sTOREMASTDBBindingSource.DataMember = "STOREMASTDB";
            this.sTOREMASTDBBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(12, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 14);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Store :";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.EnterMoveNextControl = true;
            this.lookUpEdit2.Location = new System.Drawing.Point(90, 33);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERID", "USERID", 60, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERNAME", "USERNAME", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNO", "EMPNO", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.uSERINFOBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "USERNAME";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit2.Properties.ValueMember = "USERID";
            this.lookUpEdit2.Size = new System.Drawing.Size(212, 20);
            this.lookUpEdit2.TabIndex = 0;
            // 
            // uSERINFOBindingSource
            // 
            this.uSERINFOBindingSource.DataMember = "USERINFO";
            this.uSERINFOBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "User name :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton2.Location = new System.Drawing.Point(683, 32);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(58, 21);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Print";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton1.Location = new System.Drawing.Point(619, 32);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(62, 21);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Show";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cOMMISIONMASTBindingSource
            // 
            this.cOMMISIONMASTBindingSource.DataMember = "COMMISIONMAST";
            this.cOMMISIONMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.salesTargetFrmDtToDtBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 377);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // salesTargetFrmDtToDtBindingSource
            // 
            this.salesTargetFrmDtToDtBindingSource.DataMember = "SalesTargetFrmDtToDt";
            this.salesTargetFrmDtToDtBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEMNO,
            this.colITEMNAME,
            this.colEmpname,
            this.colQty,
            this.colstdat,
            this.colendat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEmpname, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Item No.";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 0;
            this.colITEMNO.Width = 154;
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
            this.colITEMNAME.Width = 352;
            // 
            // colEmpname
            // 
            this.colEmpname.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmpname.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmpname.Caption = "Empname";
            this.colEmpname.FieldName = "Empname";
            this.colEmpname.Name = "colEmpname";
            this.colEmpname.OptionsColumn.ReadOnly = true;
            this.colEmpname.Visible = true;
            this.colEmpname.VisibleIndex = 2;
            // 
            // colQty
            // 
            this.colQty.AppearanceCell.Options.UseTextOptions = true;
            this.colQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.Caption = "Qty";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.ReadOnly = true;
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 2;
            // 
            // colstdat
            // 
            this.colstdat.AppearanceCell.Options.UseTextOptions = true;
            this.colstdat.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colstdat.AppearanceHeader.Options.UseTextOptions = true;
            this.colstdat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colstdat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colstdat.Caption = "From Date";
            this.colstdat.FieldName = "stdat";
            this.colstdat.Name = "colstdat";
            this.colstdat.OptionsColumn.ReadOnly = true;
            this.colstdat.Visible = true;
            this.colstdat.VisibleIndex = 3;
            // 
            // colendat
            // 
            this.colendat.AppearanceCell.Options.UseTextOptions = true;
            this.colendat.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colendat.AppearanceHeader.Options.UseTextOptions = true;
            this.colendat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colendat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colendat.Caption = "To Date";
            this.colendat.FieldName = "endat";
            this.colendat.Name = "colendat";
            this.colendat.OptionsColumn.ReadOnly = true;
            this.colendat.Visible = true;
            this.colendat.VisibleIndex = 4;
            this.colendat.Width = 116;
            // 
            // gETSALESTARGETBYDATEBindingSource
            // 
            this.gETSALESTARGETBYDATEBindingSource.DataMember = "GETSALESTARGETBYDATE";
            this.gETSALESTARGETBYDATEBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // tEMPSALTARGETBindingSource
            // 
            this.tEMPSALTARGETBindingSource.DataMember = "TEMPSALTARGET";
            this.tEMPSALTARGETBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "INSURANCE"});
            this.comboBox1.Location = new System.Drawing.Point(340, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // RptSummarySalesTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 436);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptSummarySalesTarget";
            this.Text = "Summary Sales Target";
            this.Load += new System.EventHandler(this.RptSummarySalesTarget_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMISIONMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTargetFrmDtToDtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETSALESTARGETBYDATEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEMPSALTARGETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private LookUpEdit lookUpEdit3;
        private LabelControl labelControl5;
        private LookUpEdit lookUpEdit2;
        private LabelControl labelControl3;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private BindingSource cOMMISIONMASTBindingSource;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource tEMPSALTARGETBindingSource;
        private BindingSource sTOREMASTDBBindingSource;
        private BindingSource uSERINFOBindingSource;
        private LabelControl labelControl2;
        private BindingSource salesTargetFrmDtToDtBindingSource;
        private GridColumn colITEMNO;
        private GridColumn colITEMNAME;
        private GridColumn colEmpname;
        private GridColumn colQty;
        private GridColumn colstdat;
        private GridColumn colendat;
        private DateEdit dateEdit2;
        private LabelControl labelControl4;
        private DateEdit dateEdit1;
        private BindingSource gETSALESTARGETBYDATEBindingSource;
        private ComboBox comboBox1;
    }
}