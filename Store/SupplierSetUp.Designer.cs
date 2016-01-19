using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using VIRETAILENTITIES;

namespace Store
{
    partial class SupplierSetUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierSetUp));
            this.cONTACTMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.c1Shipping = new DevExpress.XtraEditors.LookUpEdit();
            this.sHIPPINGMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.c1Payment = new DevExpress.XtraEditors.LookUpEdit();
            this.pAYTYPEMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1Grouping = new DevExpress.XtraEditors.LookUpEdit();
            this.cUSTSUPGROUPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duedays = new DevExpress.XtraEditors.TextEdit();
            this.creditlimit = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.c1Terms = new DevExpress.XtraEditors.LookUpEdit();
            this.tERMSMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1Expense = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.label12 = new System.Windows.Forms.Label();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.balance = new DevExpress.XtraEditors.CalcEdit();
            this.vendorsince = new DevExpress.XtraEditors.DateEdit();
            this.balanceasof = new DevExpress.XtraEditors.DateEdit();
            this.label30 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.CheckBox();
            this.accountno = new System.Windows.Forms.TextBox();
            this.lblvendorsince = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.webpage = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCONTACTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISPRIMARY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCONTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTITLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBUSINESSPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.faxno = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.address = new System.Windows.Forms.TextBox();
            this.aliasname = new System.Windows.Forms.TextBox();
            this.vendorname = new System.Windows.Forms.TextBox();
            this.vendorno = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblvendorno = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label19 = new System.Windows.Forms.Label();
            this.lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit5 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.label20 = new System.Windows.Forms.Label();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTACTMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Shipping.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHIPPINGMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Payment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTYPEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Grouping.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTSUPGROUPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditlimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Terms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tERMSMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Expense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsince.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceasof.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceasof.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(933, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // cONTACTMASTBindingSource
            // 
            this.cONTACTMASTBindingSource.DataMember = "CONTACTMAST";
            this.cONTACTMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.c1Shipping);
            this.xtraTabPage2.Controls.Add(this.label17);
            this.xtraTabPage2.Controls.Add(this.c1Payment);
            this.xtraTabPage2.Controls.Add(this.c1Grouping);
            this.xtraTabPage2.Controls.Add(this.duedays);
            this.xtraTabPage2.Controls.Add(this.creditlimit);
            this.xtraTabPage2.Controls.Add(this.label14);
            this.xtraTabPage2.Controls.Add(this.c1Terms);
            this.xtraTabPage2.Controls.Add(this.c1Expense);
            this.xtraTabPage2.Controls.Add(this.labelControl10);
            this.xtraTabPage2.Controls.Add(this.labelControl9);
            this.xtraTabPage2.Controls.Add(this.label12);
            this.xtraTabPage2.Controls.Add(this.labelControl8);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Controls.Add(this.label16);
            this.xtraTabPage2.Controls.Add(this.label15);
            this.xtraTabPage2.Controls.Add(this.label13);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(904, 433);
            // 
            // c1Shipping
            // 
            this.c1Shipping.Location = new System.Drawing.Point(146, 258);
            this.c1Shipping.Name = "c1Shipping";
            this.c1Shipping.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Shipping.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHIPID", "SHIPID", 57, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHIPTYPE", "SHIPTYPE", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SE", "SE", 22, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.c1Shipping.Properties.DataSource = this.sHIPPINGMASTBindingSource;
            this.c1Shipping.Properties.DisplayMember = "SHIPTYPE";
            this.c1Shipping.Properties.NullText = "";
            this.c1Shipping.Properties.ShowHeader = false;
            this.c1Shipping.Properties.ValueMember = "SHIPID";
            this.c1Shipping.Size = new System.Drawing.Size(255, 20);
            this.c1Shipping.TabIndex = 5;
            // 
            // sHIPPINGMASTBindingSource
            // 
            this.sHIPPINGMASTBindingSource.DataMember = "SHIPPINGMAST";
            this.sHIPPINGMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(31, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 36);
            this.label17.TabIndex = 145;
            // 
            // c1Payment
            // 
            this.c1Payment.Location = new System.Drawing.Point(146, 227);
            this.c1Payment.Name = "c1Payment";
            this.c1Payment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Payment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYTYPE", "PAYTYPE", 66, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYNAME", "PAYNAME", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.c1Payment.Properties.DataSource = this.pAYTYPEMASTBindingSource;
            this.c1Payment.Properties.DisplayMember = "PAYNAME";
            this.c1Payment.Properties.NullText = "";
            this.c1Payment.Properties.ShowHeader = false;
            this.c1Payment.Properties.ValueMember = "PAYTYPE";
            this.c1Payment.Size = new System.Drawing.Size(255, 20);
            this.c1Payment.TabIndex = 4;
            // 
            // pAYTYPEMASTBindingSource
            // 
            this.pAYTYPEMASTBindingSource.DataMember = "PAYTYPEMAST";
            this.pAYTYPEMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // c1Grouping
            // 
            this.c1Grouping.Location = new System.Drawing.Point(629, 53);
            this.c1Grouping.Name = "c1Grouping";
            this.c1Grouping.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Grouping.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPNAME", "GROUPNAME", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSSUP", "CUSSUP", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.c1Grouping.Properties.DataSource = this.cUSTSUPGROUPSBindingSource;
            this.c1Grouping.Properties.DisplayMember = "GROUPNAME";
            this.c1Grouping.Properties.NullText = "";
            this.c1Grouping.Properties.ShowHeader = false;
            this.c1Grouping.Properties.ValueMember = "GROUPID";
            this.c1Grouping.Size = new System.Drawing.Size(255, 20);
            this.c1Grouping.TabIndex = 6;
            // 
            // cUSTSUPGROUPSBindingSource
            // 
            this.cUSTSUPGROUPSBindingSource.DataMember = "CUSTSUPGROUPS";
            this.cUSTSUPGROUPSBindingSource.DataSource = this.dsMaster1;
            // 
            // duedays
            // 
            this.duedays.EditValue = "30";
            this.duedays.Location = new System.Drawing.Point(146, 196);
            this.duedays.Name = "duedays";
            this.duedays.Properties.Mask.EditMask = "f0";
            this.duedays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.duedays.Properties.MaxLength = 3;
            this.duedays.Size = new System.Drawing.Size(255, 20);
            this.duedays.TabIndex = 3;
            // 
            // creditlimit
            // 
            this.creditlimit.Location = new System.Drawing.Point(146, 134);
            this.creditlimit.Name = "creditlimit";
            this.creditlimit.Properties.Mask.EditMask = "n";
            this.creditlimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.creditlimit.Size = new System.Drawing.Size(255, 20);
            this.creditlimit.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(559, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 14);
            this.label14.TabIndex = 139;
            // 
            // c1Terms
            // 
            this.c1Terms.Location = new System.Drawing.Point(146, 165);
            this.c1Terms.Name = "c1Terms";
            this.c1Terms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Terms.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TERMCODE", "TERMCODE", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYNAME", "PAYNAME", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.c1Terms.Properties.DataSource = this.tERMSMASTBindingSource;
            this.c1Terms.Properties.DisplayMember = "PAYNAME";
            this.c1Terms.Properties.NullText = "";
            this.c1Terms.Properties.ShowHeader = false;
            this.c1Terms.Properties.ValueMember = "TERMCODE";
            this.c1Terms.Size = new System.Drawing.Size(255, 20);
            this.c1Terms.TabIndex = 2;
            // 
            // tERMSMASTBindingSource
            // 
            this.tERMSMASTBindingSource.DataMember = "TERMSMAST";
            this.tERMSMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // c1Expense
            // 
            this.c1Expense.Location = new System.Drawing.Point(146, 54);
            this.c1Expense.Name = "c1Expense";
            this.c1Expense.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Expense.Properties.NullText = "";
            this.c1Expense.Properties.ShowHeader = false;
            this.c1Expense.Size = new System.Drawing.Size(255, 20);
            this.c1Expense.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.LineColor = System.Drawing.Color.Silver;
            this.labelControl10.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl10.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl10.LineVisible = true;
            this.labelControl10.Location = new System.Drawing.Point(547, 17);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(350, 20);
            this.labelControl10.TabIndex = 135;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.LineColor = System.Drawing.Color.Silver;
            this.labelControl9.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl9.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl9.LineVisible = true;
            this.labelControl9.Location = new System.Drawing.Point(24, 97);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(377, 20);
            this.labelControl9.TabIndex = 134;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 14);
            this.label12.TabIndex = 133;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.LineColor = System.Drawing.Color.Silver;
            this.labelControl8.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl8.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl8.LineVisible = true;
            this.labelControl8.Location = new System.Drawing.Point(24, 17);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(377, 20);
            this.labelControl8.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 131;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 14);
            this.label16.TabIndex = 130;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 32);
            this.label15.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 14);
            this.label13.TabIndex = 128;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(924, 461);
            this.xtraTabControl1.TabIndex = 14;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 145);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage5;
            this.xtraTabControl2.Size = new System.Drawing.Size(933, 468);
            this.xtraTabControl2.TabIndex = 2;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage5,
            this.xtraTabPage6});
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.label9);
            this.xtraTabPage5.Controls.Add(this.balance);
            this.xtraTabPage5.Controls.Add(this.vendorsince);
            this.xtraTabPage5.Controls.Add(this.balanceasof);
            this.xtraTabPage5.Controls.Add(this.label30);
            this.xtraTabPage5.Controls.Add(this.label25);
            this.xtraTabPage5.Controls.Add(this.notes);
            this.xtraTabPage5.Controls.Add(this.label11);
            this.xtraTabPage5.Controls.Add(this.status);
            this.xtraTabPage5.Controls.Add(this.accountno);
            this.xtraTabPage5.Controls.Add(this.lblvendorsince);
            this.xtraTabPage5.Controls.Add(this.label10);
            this.xtraTabPage5.Controls.Add(this.labelControl5);
            this.xtraTabPage5.Controls.Add(this.webpage);
            this.xtraTabPage5.Controls.Add(this.email);
            this.xtraTabPage5.Controls.Add(this.label7);
            this.xtraTabPage5.Controls.Add(this.label8);
            this.xtraTabPage5.Controls.Add(this.labelControl4);
            this.xtraTabPage5.Controls.Add(this.labelControl6);
            this.xtraTabPage5.Controls.Add(this.gridControl1);
            this.xtraTabPage5.Controls.Add(this.contact);
            this.xtraTabPage5.Controls.Add(this.label4);
            this.xtraTabPage5.Controls.Add(this.faxno);
            this.xtraTabPage5.Controls.Add(this.phoneno);
            this.xtraTabPage5.Controls.Add(this.label5);
            this.xtraTabPage5.Controls.Add(this.label6);
            this.xtraTabPage5.Controls.Add(this.labelControl7);
            this.xtraTabPage5.Controls.Add(this.address);
            this.xtraTabPage5.Controls.Add(this.aliasname);
            this.xtraTabPage5.Controls.Add(this.vendorname);
            this.xtraTabPage5.Controls.Add(this.vendorno);
            this.xtraTabPage5.Controls.Add(this.labelControl1);
            this.xtraTabPage5.Controls.Add(this.label3);
            this.xtraTabPage5.Controls.Add(this.label2);
            this.xtraTabPage5.Controls.Add(this.lblvendorno);
            this.xtraTabPage5.Controls.Add(this.labelControl2);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(927, 440);
            this.xtraTabPage5.Text = "General";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.lookUpEdit1);
            this.xtraTabPage6.Controls.Add(this.label18);
            this.xtraTabPage6.Controls.Add(this.lookUpEdit2);
            this.xtraTabPage6.Controls.Add(this.lookUpEdit3);
            this.xtraTabPage6.Controls.Add(this.textEdit1);
            this.xtraTabPage6.Controls.Add(this.textEdit2);
            this.xtraTabPage6.Controls.Add(this.label19);
            this.xtraTabPage6.Controls.Add(this.lookUpEdit4);
            this.xtraTabPage6.Controls.Add(this.lookUpEdit5);
            this.xtraTabPage6.Controls.Add(this.labelControl3);
            this.xtraTabPage6.Controls.Add(this.labelControl11);
            this.xtraTabPage6.Controls.Add(this.label20);
            this.xtraTabPage6.Controls.Add(this.labelControl12);
            this.xtraTabPage6.Controls.Add(this.label21);
            this.xtraTabPage6.Controls.Add(this.label22);
            this.xtraTabPage6.Controls.Add(this.label23);
            this.xtraTabPage6.Controls.Add(this.label24);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(927, 440);
            this.xtraTabPage6.Text = "Detail";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 14);
            this.label9.TabIndex = 235;
            this.label9.Text = "Note:";
            // 
            // balance
            // 
            this.balance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.balance.Location = new System.Drawing.Point(649, 230);
            this.balance.Name = "balance";
            this.balance.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Properties.Appearance.Options.UseFont = true;
            this.balance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.balance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.balance.Size = new System.Drawing.Size(117, 20);
            this.balance.TabIndex = 211;
            // 
            // vendorsince
            // 
            this.vendorsince.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vendorsince.EditValue = null;
            this.vendorsince.Location = new System.Drawing.Point(649, 176);
            this.vendorsince.Name = "vendorsince";
            this.vendorsince.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.vendorsince.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.vendorsince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vendorsince.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.vendorsince.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.vendorsince.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.vendorsince.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.vendorsince.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.vendorsince.Size = new System.Drawing.Size(117, 20);
            this.vendorsince.TabIndex = 209;
            // 
            // balanceasof
            // 
            this.balanceasof.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.balanceasof.EditValue = null;
            this.balanceasof.Location = new System.Drawing.Point(649, 256);
            this.balanceasof.Name = "balanceasof";
            this.balanceasof.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.balanceasof.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.balanceasof.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.balanceasof.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.balanceasof.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.balanceasof.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.balanceasof.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.balanceasof.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.balanceasof.Size = new System.Drawing.Size(117, 20);
            this.balanceasof.TabIndex = 212;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(546, 258);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(82, 14);
            this.label30.TabIndex = 234;
            this.label30.Text = "Balance as of:";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(546, 232);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 14);
            this.label25.TabIndex = 233;
            this.label25.Text = "Balance:";
            // 
            // notes
            // 
            this.notes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.notes.Location = new System.Drawing.Point(649, 282);
            this.notes.MaxLength = 1500;
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notes.Size = new System.Drawing.Size(238, 39);
            this.notes.TabIndex = 213;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(546, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 232;
            this.label11.Text = "Account #:";
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.status.AutoSize = true;
            this.status.Checked = true;
            this.status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(649, 149);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 18);
            this.status.TabIndex = 208;
            this.status.Text = "Active";
            this.status.UseVisualStyleBackColor = true;
            // 
            // accountno
            // 
            this.accountno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountno.Location = new System.Drawing.Point(649, 202);
            this.accountno.Name = "accountno";
            this.accountno.Size = new System.Drawing.Size(117, 21);
            this.accountno.TabIndex = 210;
            // 
            // lblvendorsince
            // 
            this.lblvendorsince.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblvendorsince.AutoSize = true;
            this.lblvendorsince.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendorsince.Location = new System.Drawing.Point(546, 179);
            this.lblvendorsince.Name = "lblvendorsince";
            this.lblvendorsince.Size = new System.Drawing.Size(86, 14);
            this.lblvendorsince.TabIndex = 231;
            this.lblvendorsince.Text = "Vendor since :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(546, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 14);
            this.label10.TabIndex = 230;
            this.label10.Text = "Status:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineColor = System.Drawing.Color.Silver;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(539, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(349, 10);
            this.labelControl5.TabIndex = 229;
            this.labelControl5.Text = "Account information";
            // 
            // webpage
            // 
            this.webpage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.webpage.Location = new System.Drawing.Point(649, 68);
            this.webpage.MaxLength = 100;
            this.webpage.Name = "webpage";
            this.webpage.Size = new System.Drawing.Size(239, 21);
            this.webpage.TabIndex = 207;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email.Location = new System.Drawing.Point(649, 40);
            this.email.MaxLength = 100;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(239, 21);
            this.email.TabIndex = 206;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 14);
            this.label7.TabIndex = 228;
            this.label7.Text = "Web Page :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 227;
            this.label8.Text = "E-mail:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineColor = System.Drawing.Color.Silver;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(539, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(349, 10);
            this.labelControl4.TabIndex = 226;
            this.labelControl4.Text = "E mail and Internet";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineColor = System.Drawing.Color.Silver;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 308);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(503, 20);
            this.labelControl6.TabIndex = 225;
            this.labelControl6.Text = "Contacts";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.cONTACTMASTBindingSource;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(6, 333);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(915, 93);
            this.gridControl1.TabIndex = 214;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCONTACTID,
            this.colREFID,
            this.colCONTTYPE,
            this.colISPRIMARY,
            this.colCONTNAME,
            this.colTITLE,
            this.colBUSINESSPHONE,
            this.colEMAIL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow_1);
            // 
            // colCONTACTID
            // 
            this.colCONTACTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCONTACTID.AppearanceCell.Options.UseFont = true;
            this.colCONTACTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCONTACTID.AppearanceHeader.Options.UseFont = true;
            this.colCONTACTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCONTACTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCONTACTID.FieldName = "CONTACTID";
            this.colCONTACTID.Name = "colCONTACTID";
            this.colCONTACTID.OptionsColumn.ReadOnly = true;
            // 
            // colREFID
            // 
            this.colREFID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREFID.AppearanceCell.Options.UseFont = true;
            this.colREFID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREFID.AppearanceHeader.Options.UseFont = true;
            this.colREFID.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            // 
            // colCONTTYPE
            // 
            this.colCONTTYPE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCONTTYPE.AppearanceCell.Options.UseFont = true;
            this.colCONTTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCONTTYPE.AppearanceHeader.Options.UseFont = true;
            this.colCONTTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCONTTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCONTTYPE.FieldName = "CONTTYPE";
            this.colCONTTYPE.Name = "colCONTTYPE";
            // 
            // colISPRIMARY
            // 
            this.colISPRIMARY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISPRIMARY.AppearanceCell.Options.UseFont = true;
            this.colISPRIMARY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISPRIMARY.AppearanceHeader.Options.UseFont = true;
            this.colISPRIMARY.AppearanceHeader.Options.UseTextOptions = true;
            this.colISPRIMARY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colISPRIMARY.Caption = "Primary";
            this.colISPRIMARY.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colISPRIMARY.FieldName = "ISPRIMARY";
            this.colISPRIMARY.Name = "colISPRIMARY";
            this.colISPRIMARY.Visible = true;
            this.colISPRIMARY.VisibleIndex = 0;
            this.colISPRIMARY.Width = 59;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colCONTNAME
            // 
            this.colCONTNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCONTNAME.AppearanceCell.Options.UseFont = true;
            this.colCONTNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCONTNAME.AppearanceHeader.Options.UseFont = true;
            this.colCONTNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colCONTNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCONTNAME.Caption = "Contact name";
            this.colCONTNAME.FieldName = "CONTNAME";
            this.colCONTNAME.Name = "colCONTNAME";
            this.colCONTNAME.Visible = true;
            this.colCONTNAME.VisibleIndex = 1;
            this.colCONTNAME.Width = 166;
            // 
            // colTITLE
            // 
            this.colTITLE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTITLE.AppearanceCell.Options.UseFont = true;
            this.colTITLE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTITLE.AppearanceHeader.Options.UseFont = true;
            this.colTITLE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTITLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTITLE.Caption = "Title";
            this.colTITLE.FieldName = "TITLE";
            this.colTITLE.Name = "colTITLE";
            this.colTITLE.Visible = true;
            this.colTITLE.VisibleIndex = 2;
            this.colTITLE.Width = 124;
            // 
            // colBUSINESSPHONE
            // 
            this.colBUSINESSPHONE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBUSINESSPHONE.AppearanceCell.Options.UseFont = true;
            this.colBUSINESSPHONE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBUSINESSPHONE.AppearanceHeader.Options.UseFont = true;
            this.colBUSINESSPHONE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBUSINESSPHONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBUSINESSPHONE.Caption = "Business Phone";
            this.colBUSINESSPHONE.FieldName = "BUSINESSPHONE";
            this.colBUSINESSPHONE.Name = "colBUSINESSPHONE";
            this.colBUSINESSPHONE.Visible = true;
            this.colBUSINESSPHONE.VisibleIndex = 3;
            this.colBUSINESSPHONE.Width = 103;
            // 
            // colEMAIL
            // 
            this.colEMAIL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEMAIL.AppearanceCell.Options.UseFont = true;
            this.colEMAIL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEMAIL.AppearanceHeader.Options.UseFont = true;
            this.colEMAIL.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMAIL.Caption = "E-mail";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 4;
            this.colEMAIL.Width = 298;
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem()});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(127, 226);
            this.contact.MaxLength = 250;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(235, 21);
            this.contact.TabIndex = 203;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 224;
            this.label4.Text = "Contact:";
            // 
            // faxno
            // 
            this.faxno.Location = new System.Drawing.Point(127, 282);
            this.faxno.MaxLength = 15;
            this.faxno.Name = "faxno";
            this.faxno.Size = new System.Drawing.Size(235, 21);
            this.faxno.TabIndex = 205;
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(127, 254);
            this.phoneno.MaxLength = 30;
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(235, 21);
            this.phoneno.TabIndex = 204;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 223;
            this.label5.Text = "Fax # :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 222;
            this.label6.Text = "Phone #:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineColor = System.Drawing.Color.Silver;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(14, 200);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(349, 20);
            this.labelControl7.TabIndex = 221;
            this.labelControl7.Text = "Phone and fax numbers";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(127, 140);
            this.address.MaxLength = 1500;
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(235, 53);
            this.address.TabIndex = 202;
            // 
            // aliasname
            // 
            this.aliasname.Location = new System.Drawing.Point(127, 92);
            this.aliasname.MaxLength = 200;
            this.aliasname.Name = "aliasname";
            this.aliasname.Size = new System.Drawing.Size(344, 21);
            this.aliasname.TabIndex = 201;
            // 
            // vendorname
            // 
            this.vendorname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vendorname.Location = new System.Drawing.Point(127, 64);
            this.vendorname.MaxLength = 200;
            this.vendorname.Name = "vendorname";
            this.vendorname.Size = new System.Drawing.Size(344, 21);
            this.vendorname.TabIndex = 200;
            // 
            // vendorno
            // 
            this.vendorno.Location = new System.Drawing.Point(127, 38);
            this.vendorno.Name = "vendorno";
            this.vendorno.Size = new System.Drawing.Size(165, 21);
            this.vendorno.TabIndex = 215;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineColor = System.Drawing.Color.Silver;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 120);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(376, 20);
            this.labelControl1.TabIndex = 220;
            this.labelControl1.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 219;
            this.label3.Text = "Payee name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 218;
            this.label2.Text = "Vendor name:";
            // 
            // lblvendorno
            // 
            this.lblvendorno.AutoSize = true;
            this.lblvendorno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendorno.Location = new System.Drawing.Point(19, 43);
            this.lblvendorno.Name = "lblvendorno";
            this.lblvendorno.Size = new System.Drawing.Size(64, 14);
            this.lblvendorno.TabIndex = 217;
            this.lblvendorno.Text = "Vendor #:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineColor = System.Drawing.Color.Silver;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(363, 20);
            this.labelControl2.TabIndex = 216;
            this.labelControl2.Text = "Supplier";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(144, 264);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHIPID", "SHIPID", 57, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHIPTYPE", "SHIPTYPE", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SE", "SE", 22, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.sHIPPINGMASTBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "SHIPTYPE";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.ValueMember = "SHIPID";
            this.lookUpEdit1.Size = new System.Drawing.Size(255, 20);
            this.lookUpEdit1.TabIndex = 151;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(29, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 36);
            this.label18.TabIndex = 162;
            this.label18.Text = "Prefered shipping method:";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(144, 233);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYTYPE", "PAYTYPE", 66, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYNAME", "PAYNAME", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.pAYTYPEMASTBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "PAYNAME";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.ShowHeader = false;
            this.lookUpEdit2.Properties.ValueMember = "PAYTYPE";
            this.lookUpEdit2.Size = new System.Drawing.Size(255, 20);
            this.lookUpEdit2.TabIndex = 150;
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(627, 59);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPNAME", "GROUPNAME", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSSUP", "CUSSUP", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEdit3.Properties.DataSource = this.cUSTSUPGROUPSBindingSource;
            this.lookUpEdit3.Properties.DisplayMember = "GROUPNAME";
            this.lookUpEdit3.Properties.NullText = "";
            this.lookUpEdit3.Properties.ShowHeader = false;
            this.lookUpEdit3.Properties.ValueMember = "GROUPID";
            this.lookUpEdit3.Size = new System.Drawing.Size(255, 20);
            this.lookUpEdit3.TabIndex = 152;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "30";
            this.textEdit1.Location = new System.Drawing.Point(144, 202);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "f0";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Properties.MaxLength = 3;
            this.textEdit1.Size = new System.Drawing.Size(255, 20);
            this.textEdit1.TabIndex = 149;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(144, 140);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Mask.EditMask = "n";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Size = new System.Drawing.Size(255, 20);
            this.textEdit2.TabIndex = 147;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(557, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 14);
            this.label19.TabIndex = 161;
            this.label19.Text = "Grouping :";
            // 
            // lookUpEdit4
            // 
            this.lookUpEdit4.Location = new System.Drawing.Point(144, 171);
            this.lookUpEdit4.Name = "lookUpEdit4";
            this.lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TERMCODE", "TERMCODE", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYNAME", "PAYNAME", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit4.Properties.DataSource = this.tERMSMASTBindingSource;
            this.lookUpEdit4.Properties.DisplayMember = "PAYNAME";
            this.lookUpEdit4.Properties.NullText = "";
            this.lookUpEdit4.Properties.ShowHeader = false;
            this.lookUpEdit4.Properties.ValueMember = "TERMCODE";
            this.lookUpEdit4.Size = new System.Drawing.Size(255, 20);
            this.lookUpEdit4.TabIndex = 148;
            // 
            // lookUpEdit5
            // 
            this.lookUpEdit5.Location = new System.Drawing.Point(144, 60);
            this.lookUpEdit5.Name = "lookUpEdit5";
            this.lookUpEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit5.Properties.NullText = "";
            this.lookUpEdit5.Properties.ShowHeader = false;
            this.lookUpEdit5.Size = new System.Drawing.Size(255, 20);
            this.lookUpEdit5.TabIndex = 146;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineColor = System.Drawing.Color.Silver;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(545, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(350, 20);
            this.labelControl3.TabIndex = 160;
            this.labelControl3.Text = "Grouping";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.LineColor = System.Drawing.Color.Silver;
            this.labelControl11.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl11.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl11.LineVisible = true;
            this.labelControl11.Location = new System.Drawing.Point(22, 103);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(377, 20);
            this.labelControl11.TabIndex = 159;
            this.labelControl11.Text = "Terms";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(29, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 14);
            this.label20.TabIndex = 158;
            this.label20.Text = "Expense account :";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.LineColor = System.Drawing.Color.Silver;
            this.labelControl12.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl12.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl12.LineVisible = true;
            this.labelControl12.Location = new System.Drawing.Point(22, 23);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(377, 20);
            this.labelControl12.TabIndex = 157;
            this.labelControl12.Text = "Expense  account";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(29, 204);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 14);
            this.label21.TabIndex = 156;
            this.label21.Text = "Due Days:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(29, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 14);
            this.label22.TabIndex = 155;
            this.label22.Text = "Payment Terms :";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(29, 235);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 32);
            this.label23.TabIndex = 154;
            this.label23.Text = "Prefered payment method :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(29, 143);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 14);
            this.label24.TabIndex = 153;
            this.label24.Text = "Credit limit :";
            // 
            // SupplierSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 645);
            this.Controls.Add(this.xtraTabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "SupplierSetUp";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.SupplierSetUp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupplierSetUp_KeyDown);
            this.Resize += new System.EventHandler(this.SupplierSetup_Resize);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.xtraTabControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTACTMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Shipping.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHIPPINGMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Payment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTYPEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Grouping.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTSUPGROUPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditlimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Terms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tERMSMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Expense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage5.PerformLayout();
            this.xtraTabPage6.ResumeLayout(false);
            this.xtraTabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsince.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceasof.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceasof.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;
        private Label label1;
        private Label label16;
        private Label label15;
        private Label label13;
        private LabelControl labelControl9;
        private Label label12;
        private LabelControl labelControl8;
        private LabelControl labelControl10;
        private LookUpEdit c1Terms;
        private LookUpEdit c1Expense;
        private Label label14;
        private TextEdit duedays;
        private TextEdit creditlimit;
        private LookUpEdit c1Grouping;
        private LookUpEdit c1Payment;
        private LookUpEdit c1Shipping;
        private Label label17;
        private BindingSource cONTACTMASTBindingSource;
        private BindingSource tERMSMASTBindingSource;
        private BindingSource cUSTSUPGROUPSBindingSource;
        private BindingSource sHIPPINGMASTBindingSource;
        private BindingSource pAYTYPEMASTBindingSource;
        private DsMaster dsMaster1;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage3;
        private XtraTabPage xtraTabPage4;
        private XtraTabControl xtraTabControl2;
        private XtraTabPage xtraTabPage5;
        private XtraTabPage xtraTabPage6;
        private Label label9;
        private CalcEdit balance;
        private DateEdit vendorsince;
        private DateEdit balanceasof;
        private Label label30;
        private Label label25;
        private TextBox notes;
        private Label label11;
        private CheckBox status;
        private TextBox accountno;
        public Label lblvendorsince;
        private Label label10;
        private LabelControl labelControl5;
        private TextBox webpage;
        private TextBox email;
        private Label label7;
        private Label label8;
        private LabelControl labelControl4;
        private LabelControl labelControl6;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colCONTACTID;
        private GridColumn colREFID;
        private GridColumn colCONTTYPE;
        private GridColumn colISPRIMARY;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private GridColumn colCONTNAME;
        private GridColumn colTITLE;
        private GridColumn colBUSINESSPHONE;
        private GridColumn colEMAIL;
        private RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private TextBox contact;
        private Label label4;
        private TextBox faxno;
        private TextBox phoneno;
        private Label label5;
        private Label label6;
        private LabelControl labelControl7;
        private TextBox address;
        private TextBox aliasname;
        private TextBox vendorname;
        private TextBox vendorno;
        private LabelControl labelControl1;
        private Label label3;
        private Label label2;
        public Label lblvendorno;
        private LabelControl labelControl2;
        private LookUpEdit lookUpEdit1;
        private Label label18;
        private LookUpEdit lookUpEdit2;
        private LookUpEdit lookUpEdit3;
        private TextEdit textEdit1;
        private TextEdit textEdit2;
        private Label label19;
        private LookUpEdit lookUpEdit4;
        private LookUpEdit lookUpEdit5;
        private LabelControl labelControl3;
        private LabelControl labelControl11;
        private Label label20;
        private LabelControl labelControl12;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;

    }
}