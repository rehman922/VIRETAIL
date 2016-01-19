using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class Customer
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.customertype = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txtmemno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.custnote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.custemail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.custmobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.custphone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.customerid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.customername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.custcomp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.custcreditlimit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.custfixdiscperc = new DevExpress.XtraEditors.TextEdit();
            this.custfixdisc = new DevExpress.XtraEditors.CheckEdit();
            this.grouplevels = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.iNSURANCEDISCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRADE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customertype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmemno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custnote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custmobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custphone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custcomp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custcreditlimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custfixdiscperc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custfixdisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouplevels)).BeginInit();
            this.grouplevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSURANCEDISCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(782, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.customertype);
            this.groupControl1.Controls.Add(this.txtmemno);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.custnote);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.custemail);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.custmobile);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.custphone);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.customerid);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.customername);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.custcomp);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 145);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(782, 157);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Customer Info";
            // 
            // customertype
            // 
            this.customertype.Location = new System.Drawing.Point(121, 27);
            this.customertype.MenuManager = this.ribbon;
            this.customertype.Name = "customertype";
            this.customertype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customertype.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Members", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Insurance", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Credit", 2, -1)});
            this.customertype.Size = new System.Drawing.Size(154, 20);
            this.customertype.TabIndex = 36;
            this.customertype.EditValueChanged += new System.EventHandler(this.customertype_EditValueChanged);
            // 
            // txtmemno
            // 
            this.txtmemno.Location = new System.Drawing.Point(121, 50);
            this.txtmemno.MenuManager = this.ribbon;
            this.txtmemno.Name = "txtmemno";
            this.txtmemno.Size = new System.Drawing.Size(213, 20);
            this.txtmemno.TabIndex = 35;
            this.txtmemno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmemno_KeyDown);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(10, 54);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(81, 14);
            this.labelControl15.TabIndex = 34;
            this.labelControl15.Text = "Mem Card No :";
            // 
            // custnote
            // 
            this.custnote.Location = new System.Drawing.Point(121, 129);
            this.custnote.MenuManager = this.ribbon;
            this.custnote.Name = "custnote";
            this.custnote.Properties.MaxLength = 250;
            this.custnote.Size = new System.Drawing.Size(639, 20);
            this.custnote.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(12, 132);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 14);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "Note :";
            // 
            // custemail
            // 
            this.custemail.Location = new System.Drawing.Point(556, 101);
            this.custemail.MenuManager = this.ribbon;
            this.custemail.Name = "custemail";
            this.custemail.Properties.MaxLength = 50;
            this.custemail.Size = new System.Drawing.Size(202, 20);
            this.custemail.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(475, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 14);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "E-Mail :";
            // 
            // custmobile
            // 
            this.custmobile.Location = new System.Drawing.Point(121, 103);
            this.custmobile.MenuManager = this.ribbon;
            this.custmobile.Name = "custmobile";
            this.custmobile.Properties.MaxLength = 10;
            this.custmobile.Size = new System.Drawing.Size(202, 20);
            this.custmobile.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(10, 107);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 14);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "Mobile :";
            // 
            // custphone
            // 
            this.custphone.Location = new System.Drawing.Point(556, 76);
            this.custphone.MenuManager = this.ribbon;
            this.custphone.Name = "custphone";
            this.custphone.Properties.MaxLength = 15;
            this.custphone.Size = new System.Drawing.Size(202, 20);
            this.custphone.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(475, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 14);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Phone :";
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(556, 26);
            this.customerid.MenuManager = this.ribbon;
            this.customerid.Name = "customerid";
            this.customerid.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.customerid.Properties.Appearance.Options.UseBackColor = true;
            this.customerid.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.customerid.Properties.MaxLength = 10;
            this.customerid.Properties.ReadOnly = true;
            this.customerid.Size = new System.Drawing.Size(148, 20);
            this.customerid.TabIndex = 26;
            this.customerid.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(475, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 14);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Customer Id :";
            this.labelControl4.Visible = false;
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(121, 77);
            this.customername.MenuManager = this.ribbon;
            this.customername.Name = "customername";
            this.customername.Properties.MaxLength = 150;
            this.customername.Size = new System.Drawing.Size(311, 20);
            this.customername.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(10, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 14);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Customer name :";
            // 
            // custcomp
            // 
            this.custcomp.Location = new System.Drawing.Point(556, 51);
            this.custcomp.MenuManager = this.ribbon;
            this.custcomp.Name = "custcomp";
            this.custcomp.Properties.MaxLength = 30;
            this.custcomp.Size = new System.Drawing.Size(201, 20);
            this.custcomp.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(475, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 14);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Company :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(10, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 14);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Customer Type :";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.comboBoxEdit1);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.textEdit11);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.textEdit10);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.custcreditlimit);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.custfixdiscperc);
            this.groupControl2.Controls.Add(this.custfixdisc);
            this.groupControl2.Location = new System.Drawing.Point(3, 306);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(381, 177);
            this.groupControl2.TabIndex = 20;
            this.groupControl2.Text = "Discount / Credit Info";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl14.Location = new System.Drawing.Point(29, 37);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(292, 14);
            this.labelControl14.TabIndex = 37;
            this.labelControl14.Text = "Apply a fixed percentage discount on invoice amount";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(270, 61);
            this.comboBoxEdit1.MenuManager = this.ribbon;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Company",
            "Personnel"});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(94, 20);
            this.comboBoxEdit1.TabIndex = 1;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(168, 63);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(59, 14);
            this.labelControl13.TabIndex = 31;
            this.labelControl13.Text = "Pay Type :";
            // 
            // textEdit11
            // 
            this.textEdit11.Location = new System.Drawing.Point(270, 136);
            this.textEdit11.MenuManager = this.ribbon;
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Size = new System.Drawing.Size(94, 20);
            this.textEdit11.TabIndex = 4;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(168, 139);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(90, 14);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "Available Credit :";
            // 
            // textEdit10
            // 
            this.textEdit10.Location = new System.Drawing.Point(270, 110);
            this.textEdit10.MenuManager = this.ribbon;
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Size = new System.Drawing.Size(94, 20);
            this.textEdit10.TabIndex = 3;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(168, 112);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(99, 14);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "Account Balance :";
            // 
            // custcreditlimit
            // 
            this.custcreditlimit.Location = new System.Drawing.Point(270, 85);
            this.custcreditlimit.MenuManager = this.ribbon;
            this.custcreditlimit.Name = "custcreditlimit";
            this.custcreditlimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.custcreditlimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.custcreditlimit.Size = new System.Drawing.Size(94, 20);
            this.custcreditlimit.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(168, 87);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(69, 14);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Credit Limit :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(366, 45);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(11, 13);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "%";
            // 
            // custfixdiscperc
            // 
            this.custfixdiscperc.Location = new System.Drawing.Point(326, 35);
            this.custfixdiscperc.MenuManager = this.ribbon;
            this.custfixdiscperc.Name = "custfixdiscperc";
            this.custfixdiscperc.Properties.DisplayFormat.FormatString = "n";
            this.custfixdiscperc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.custfixdiscperc.Properties.Mask.EditMask = "P0";
            this.custfixdiscperc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.custfixdiscperc.Properties.MaxLength = 2;
            this.custfixdiscperc.Size = new System.Drawing.Size(37, 20);
            this.custfixdiscperc.TabIndex = 23;
            // 
            // custfixdisc
            // 
            this.custfixdisc.Location = new System.Drawing.Point(8, 35);
            this.custfixdisc.MenuManager = this.ribbon;
            this.custfixdisc.Name = "custfixdisc";
            this.custfixdisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custfixdisc.Properties.Appearance.Options.UseFont = true;
            this.custfixdisc.Properties.Caption = "";
            this.custfixdisc.Size = new System.Drawing.Size(315, 19);
            this.custfixdisc.TabIndex = 0;
            // 
            // grouplevels
            // 
            this.grouplevels.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplevels.Appearance.Options.UseFont = true;
            this.grouplevels.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplevels.AppearanceCaption.Options.UseFont = true;
            this.grouplevels.Controls.Add(this.gridControl1);
            this.grouplevels.Location = new System.Drawing.Point(389, 307);
            this.grouplevels.Name = "grouplevels";
            this.grouplevels.Size = new System.Drawing.Size(392, 176);
            this.grouplevels.TabIndex = 21;
            this.grouplevels.Text = "Insurance discount levels";
            this.grouplevels.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.iNSURANCEDISCBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(388, 152);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // iNSURANCEDISCBindingSource
            // 
            this.iNSURANCEDISCBindingSource.DataMember = "INSURANCEDISC";
            this.iNSURANCEDISCBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colGRADE,
            this.colDISC,
            this.colCOMPDISC,
            this.colCUSTNO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colID.AppearanceCell.Options.UseFont = true;
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colID.OptionsFilter.AllowFilter = false;
            this.colID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colGRADE
            // 
            this.colGRADE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGRADE.AppearanceCell.Options.UseFont = true;
            this.colGRADE.AppearanceCell.Options.UseTextOptions = true;
            this.colGRADE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGRADE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGRADE.AppearanceHeader.Options.UseFont = true;
            this.colGRADE.AppearanceHeader.Options.UseTextOptions = true;
            this.colGRADE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGRADE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGRADE.Caption = "Grade";
            this.colGRADE.FieldName = "GRADE";
            this.colGRADE.Name = "colGRADE";
            this.colGRADE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGRADE.OptionsFilter.AllowFilter = false;
            this.colGRADE.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colGRADE.Visible = true;
            this.colGRADE.VisibleIndex = 0;
            this.colGRADE.Width = 59;
            // 
            // colDISC
            // 
            this.colDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceCell.Options.UseFont = true;
            this.colDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceHeader.Options.UseFont = true;
            this.colDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.Caption = "Customer Payment %";
            this.colDISC.DisplayFormat.FormatString = "###.00";
            this.colDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDISC.FieldName = "DISC";
            this.colDISC.Name = "colDISC";
            this.colDISC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDISC.OptionsFilter.AllowFilter = false;
            this.colDISC.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colDISC.Visible = true;
            this.colDISC.VisibleIndex = 1;
            this.colDISC.Width = 115;
            // 
            // colCOMPDISC
            // 
            this.colCOMPDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPDISC.AppearanceCell.Options.UseFont = true;
            this.colCOMPDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPDISC.AppearanceHeader.Options.UseFont = true;
            this.colCOMPDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPDISC.Caption = "Company Discount %";
            this.colCOMPDISC.DisplayFormat.FormatString = "###.00";
            this.colCOMPDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCOMPDISC.FieldName = "COMPDISC";
            this.colCOMPDISC.Name = "colCOMPDISC";
            this.colCOMPDISC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCOMPDISC.OptionsFilter.AllowFilter = false;
            this.colCOMPDISC.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colCOMPDISC.Visible = true;
            this.colCOMPDISC.VisibleIndex = 2;
            this.colCOMPDISC.Width = 111;
            // 
            // colCUSTNO
            // 
            this.colCUSTNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCUSTNO.AppearanceCell.Options.UseFont = true;
            this.colCUSTNO.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCUSTNO.AppearanceHeader.Options.UseFont = true;
            this.colCUSTNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNO.FieldName = "CUSTNO";
            this.colCUSTNO.Name = "colCUSTNO";
            this.colCUSTNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCUSTNO.OptionsFilter.AllowFilter = false;
            this.colCUSTNO.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colCUSTNO.Width = 78;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // Customer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.grouplevels);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.grouplevels, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customertype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmemno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custnote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custmobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custphone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custcomp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custcreditlimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custfixdiscperc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custfixdisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouplevels)).EndInit();
            this.grouplevels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSURANCEDISCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupControl groupControl1;
        private TextEdit custnote;
        private LabelControl labelControl8;
        private TextEdit custemail;
        private LabelControl labelControl7;
        private TextEdit custmobile;
        private LabelControl labelControl6;
        private TextEdit custphone;
        private LabelControl labelControl5;
        private TextEdit customerid;
        private LabelControl labelControl4;
        private TextEdit customername;
        private LabelControl labelControl2;
        private TextEdit custcomp;
        private LabelControl labelControl3;
        private LabelControl labelControl1;
        private GroupControl groupControl2;
        private LabelControl labelControl9;
        private TextEdit custfixdiscperc;
        private CheckEdit custfixdisc;
        private TextEdit custcreditlimit;
        private LabelControl labelControl10;
        private TextEdit textEdit11;
        private LabelControl labelControl12;
        private TextEdit textEdit10;
        private LabelControl labelControl11;
        private GroupControl grouplevels;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colID;
        private GridColumn colGRADE;
        private GridColumn colDISC;
        private GridColumn colCOMPDISC;
        private GridColumn colCUSTNO;
        private BindingSource iNSURANCEDISCBindingSource;
        private DsMaster dsMaster1;
        private DXErrorProvider dxErrorProvider1;
        private BindingSource bindingSource1;
        private ComboBoxEdit comboBoxEdit1;
        private LabelControl labelControl13;
        private LabelControl labelControl14;
        private LabelControl labelControl15;
        private TextEdit txtmemno;
        private ImageComboBoxEdit customertype;

    }
}