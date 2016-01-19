using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptPromotionSalesRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptPromotionSalesRpt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.sTOREMASTDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblpwd = new DevExpress.XtraEditors.LabelControl();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.cOMMISIONMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getSalesTargetDetFSelStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFrm_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMISIONMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesTargetDetFSelStoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lookUpEdit3);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.comboBoxEdit1);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.lookUpEdit2);
            this.panel1.Controls.Add(this.lblpwd);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 80);
            this.panel1.TabIndex = 0;
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(84, 10);
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
            this.lookUpEdit3.TabIndex = 14;
            this.lookUpEdit3.Visible = false;
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
            this.labelControl5.Visible = false;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(378, 12);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Insurance"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(134, 20);
            this.comboBoxEdit1.TabIndex = 12;
            this.comboBoxEdit1.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(303, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Sales Type :";
            this.labelControl4.Visible = false;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.EnterMoveNextControl = true;
            this.lookUpEdit2.Location = new System.Drawing.Point(84, 32);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERID", "USERID", 60, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERNAME", "USERNAME", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNO", "EMPNO", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PASSWORD", "PASSWORD", 67, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.uSERINFOBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "USERNAME";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit2.Properties.ValueMember = "USERID";
            this.lookUpEdit2.Size = new System.Drawing.Size(213, 20);
            this.lookUpEdit2.TabIndex = 0;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // uSERINFOBindingSource
            // 
            this.uSERINFOBindingSource.DataMember = "USERINFO";
            this.uSERINFOBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // lblpwd
            // 
            this.lblpwd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpwd.Location = new System.Drawing.Point(11, 58);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(64, 16);
            this.lblpwd.TabIndex = 9;
            this.lblpwd.Text = "Password :";
            // 
            // txtpassword
            // 
            this.txtpassword.EnterMoveNextControl = true;
            this.txtpassword.Location = new System.Drawing.Point(84, 55);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtpassword.Properties.Appearance.Options.UseFont = true;
            this.txtpassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtpassword.Properties.MaxLength = 10;
            this.txtpassword.Properties.NullText = "Enter Password";
            this.txtpassword.Properties.NullValuePrompt = "Password";
            this.txtpassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtpassword.Properties.PasswordChar = '*';
            this.txtpassword.Properties.UseSystemPasswordChar = true;
            this.txtpassword.Properties.ValidateOnEnterKey = true;
            this.txtpassword.Size = new System.Drawing.Size(213, 22);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.EditValueChanged += new System.EventHandler(this.txtpassword_EditValueChanged);
            this.txtpassword.Validated += new System.EventHandler(this.txtpassword_Validated);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(11, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "User name :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton2.Location = new System.Drawing.Point(726, 53);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(58, 21);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Print";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton1.Location = new System.Drawing.Point(658, 53);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(62, 21);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Show";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(350, 54);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMID", "COMID", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PROMONAME", "PROMONAME", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRMOFRM", "PRMOFRM", 60, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRMOTO", "PRMOTO", 53, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STATUS", "STATUS", 48, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNO", "EMPNO", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STOREID", "STOREID", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERID", "USERID", 47, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UDATE", "UDATE", 43, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EUSERID", "EUSERID", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EDATE", "EDATE", 42, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UPLOAD", "UPLOAD", 50, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.cOMMISIONMASTBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "PROMONAME";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.PopupWidth = 650;
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "COMID";
            this.lookUpEdit1.Size = new System.Drawing.Size(302, 20);
            this.lookUpEdit1.TabIndex = 2;
            // 
            // cOMMISIONMASTBindingSource
            // 
            this.cOMMISIONMASTBindingSource.DataMember = "COMMISIONMAST";
            this.cOMMISIONMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(302, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Period :";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.getSalesTargetDetFSelStoreBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 80);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(786, 315);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // getSalesTargetDetFSelStoreBindingSource
            // 
            this.getSalesTargetDetFSelStoreBindingSource.DataMember = "GetSalesTargetDetFSelStore";
            this.getSalesTargetDetFSelStoreBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemno,
            this.colItemname,
            this.colEmpNo,
            this.colTarget,
            this.gridColumn1,
            this.colSaleQty,
            this.colFrm_Date,
            this.colToDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEmpNo, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.ViewCaption = "Grid Caption";
            // 
            // colItemno
            // 
            this.colItemno.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemno.AppearanceCell.Options.UseFont = true;
            this.colItemno.AppearanceCell.Options.UseTextOptions = true;
            this.colItemno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemno.AppearanceHeader.Options.UseFont = true;
            this.colItemno.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemno.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.FieldName = "Item no";
            this.colItemno.Name = "colItemno";
            this.colItemno.OptionsColumn.AllowEdit = false;
            this.colItemno.Visible = true;
            this.colItemno.VisibleIndex = 0;
            this.colItemno.Width = 134;
            // 
            // colItemname
            // 
            this.colItemname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemname.AppearanceCell.Options.UseFont = true;
            this.colItemname.AppearanceCell.Options.UseTextOptions = true;
            this.colItemname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemname.AppearanceHeader.Options.UseFont = true;
            this.colItemname.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.FieldName = "Item name";
            this.colItemname.Name = "colItemname";
            this.colItemname.OptionsColumn.AllowEdit = false;
            this.colItemname.Visible = true;
            this.colItemname.VisibleIndex = 1;
            this.colItemname.Width = 305;
            // 
            // colEmpNo
            // 
            this.colEmpNo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmpNo.AppearanceCell.Options.UseFont = true;
            this.colEmpNo.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmpNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmpNo.AppearanceHeader.Options.UseFont = true;
            this.colEmpNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmpNo.FieldName = "Emp No";
            this.colEmpNo.Name = "colEmpNo";
            this.colEmpNo.OptionsColumn.AllowEdit = false;
            this.colEmpNo.Visible = true;
            this.colEmpNo.VisibleIndex = 2;
            // 
            // colTarget
            // 
            this.colTarget.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTarget.AppearanceCell.Options.UseFont = true;
            this.colTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colTarget.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTarget.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTarget.AppearanceHeader.Options.UseFont = true;
            this.colTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarget.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTarget.FieldName = "Target";
            this.colTarget.Name = "colTarget";
            this.colTarget.OptionsColumn.AllowEdit = false;
            this.colTarget.Visible = true;
            this.colTarget.VisibleIndex = 2;
            this.colTarget.Width = 64;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Sales Type";
            this.gridColumn1.FieldName = "SalesType";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // colSaleQty
            // 
            this.colSaleQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSaleQty.AppearanceCell.Options.UseFont = true;
            this.colSaleQty.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSaleQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSaleQty.AppearanceHeader.Options.UseFont = true;
            this.colSaleQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaleQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSaleQty.FieldName = "Sale Qty";
            this.colSaleQty.Name = "colSaleQty";
            this.colSaleQty.OptionsColumn.AllowEdit = false;
            this.colSaleQty.Visible = true;
            this.colSaleQty.VisibleIndex = 3;
            this.colSaleQty.Width = 102;
            // 
            // colFrm_Date
            // 
            this.colFrm_Date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFrm_Date.AppearanceCell.Options.UseFont = true;
            this.colFrm_Date.AppearanceCell.Options.UseTextOptions = true;
            this.colFrm_Date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFrm_Date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFrm_Date.AppearanceHeader.Options.UseFont = true;
            this.colFrm_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.colFrm_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFrm_Date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFrm_Date.FieldName = "Frm_Date";
            this.colFrm_Date.Name = "colFrm_Date";
            this.colFrm_Date.OptionsColumn.AllowEdit = false;
            this.colFrm_Date.Width = 81;
            // 
            // colToDate
            // 
            this.colToDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colToDate.AppearanceCell.Options.UseFont = true;
            this.colToDate.AppearanceCell.Options.UseTextOptions = true;
            this.colToDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colToDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colToDate.AppearanceHeader.Options.UseFont = true;
            this.colToDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colToDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colToDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colToDate.FieldName = "To Date";
            this.colToDate.Name = "colToDate";
            this.colToDate.OptionsColumn.AllowEdit = false;
            this.colToDate.Width = 82;
            // 
            // RptPromotionSalesRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 395);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptPromotionSalesRpt";
            this.Text = "Target Sales Report";
            this.Load += new System.EventHandler(this.PromotionSalesRpt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMISIONMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesTargetDetFSelStoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private LabelControl labelControl1;
        private LookUpEdit lookUpEdit1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private BindingSource cOMMISIONMASTBindingSource;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource getSalesTargetDetFSelStoreBindingSource;
        private GridColumn colItemno;
        private GridColumn colItemname;
        private GridColumn colEmpNo;
        private GridColumn colTarget;
        private GridColumn colSaleQty;
        private GridColumn colFrm_Date;
        private GridColumn colToDate;
        private LabelControl lblpwd;
        private TextEdit txtpassword;
        private LabelControl labelControl3;
        private LookUpEdit lookUpEdit2;
        private BindingSource uSERINFOBindingSource;
        private ComboBoxEdit comboBoxEdit1;
        private LabelControl labelControl4;
        private GridColumn gridColumn1;
        private LookUpEdit lookUpEdit3;
        private LabelControl labelControl5;
        private BindingSource sTOREMASTDBBindingSource;
    }
}