using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Store
{
    partial class Storemast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storemast));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.address = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.storename = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.storetype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.quotafrm = new DevExpress.XtraEditors.CalcEdit();
            this.quotato = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.lookupcompany = new DevExpress.XtraEditors.LookUpEdit();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource();
            this.storecode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storetype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotafrm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupcompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storecode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(818, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineColor = System.Drawing.Color.Silver;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(1, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(420, 22);
            this.labelControl2.TabIndex = 94;
            this.labelControl2.Text = "Store";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(263, 177);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 14);
            this.labelControl3.TabIndex = 96;
            this.labelControl3.Text = "Store code:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 260);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 14);
            this.labelControl4.TabIndex = 97;
            this.labelControl4.Text = "Store name:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineColor = System.Drawing.Color.Silver;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(1, 278);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(409, 22);
            this.labelControl5.TabIndex = 98;
            this.labelControl5.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(86, 300);
            this.address.MaxLength = 1000;
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(325, 78);
            this.address.TabIndex = 2;
            // 
            // fax
            // 
            this.fax.Location = new System.Drawing.Point(85, 438);
            this.fax.MaxLength = 15;
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(325, 22);
            this.fax.TabIndex = 4;
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(85, 410);
            this.phoneno.MaxLength = 15;
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(325, 22);
            this.phoneno.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 103;
            this.label5.Text = "Fax # :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 102;
            this.label6.Text = "Phone #:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineColor = System.Drawing.Color.Silver;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(1, 384);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(409, 20);
            this.labelControl6.TabIndex = 101;
            this.labelControl6.Text = "Phone and fax numbers";
            // 
            // storename
            // 
            this.storename.Location = new System.Drawing.Point(85, 257);
            this.storename.MaxLength = 250;
            this.storename.Name = "storename";
            this.storename.Size = new System.Drawing.Size(325, 22);
            this.storename.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineColor = System.Drawing.Color.Silver;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(453, 150);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(350, 22);
            this.labelControl7.TabIndex = 108;
            this.labelControl7.Text = "Communication Method";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(462, 190);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Removable Media"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Network"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Email Client"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Local Transfer")});
            this.radioGroup1.Size = new System.Drawing.Size(232, 102);
            this.radioGroup1.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.LineColor = System.Drawing.Color.Silver;
            this.labelControl8.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl8.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl8.LineVisible = true;
            this.labelControl8.Location = new System.Drawing.Point(453, 300);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(363, 22);
            this.labelControl8.TabIndex = 110;
            this.labelControl8.Text = "Purchase Information";
            this.labelControl8.Visible = false;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(533, 328);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Can Purchase and Sell";
            this.checkEdit1.Size = new System.Drawing.Size(161, 19);
            this.checkEdit1.TabIndex = 111;
            this.checkEdit1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 113;
            this.label1.Text = "Quota From:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 114;
            this.label2.Text = "Quota To:";
            this.label2.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 234);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 14);
            this.labelControl1.TabIndex = 95;
            this.labelControl1.Text = "Store type:";
            // 
            // storetype
            // 
            this.storetype.Location = new System.Drawing.Point(85, 231);
            this.storetype.Name = "storetype";
            this.storetype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.storetype.Properties.Items.AddRange(new object[] {
            "WH",
            "SS",
            "PS"});
            this.storetype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.storetype.Size = new System.Drawing.Size(120, 20);
            this.storetype.TabIndex = 0;
            // 
            // quotafrm
            // 
            this.quotafrm.Location = new System.Drawing.Point(535, 353);
            this.quotafrm.Name = "quotafrm";
            this.quotafrm.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotafrm.Properties.Appearance.Options.UseFont = true;
            this.quotafrm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quotafrm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quotafrm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quotafrm.Properties.NullText = "0";
            this.quotafrm.Size = new System.Drawing.Size(245, 20);
            this.quotafrm.TabIndex = 126;
            this.quotafrm.Visible = false;
            // 
            // quotato
            // 
            this.quotato.Location = new System.Drawing.Point(535, 381);
            this.quotato.Name = "quotato";
            this.quotato.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotato.Properties.Appearance.Options.UseFont = true;
            this.quotato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quotato.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quotato.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quotato.Properties.NullText = "0";
            this.quotato.Size = new System.Drawing.Size(245, 20);
            this.quotato.TabIndex = 127;
            this.quotato.Visible = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(12, 304);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 14);
            this.labelControl9.TabIndex = 128;
            this.labelControl9.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 129;
            this.label3.Text = "Company :";
            // 
            // lookupcompany
            // 
            this.lookupcompany.Location = new System.Drawing.Point(85, 204);
            this.lookupcompany.MenuManager = this.ribbon;
            this.lookupcompany.Name = "lookupcompany";
            this.lookupcompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupcompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPID", "COMPID", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPNAME", "COMPNAME", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPADD", "COMPADD", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CITY", "CITY", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COUNTRY", "COUNTRY", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TELEPHONE", "TELEPHONE", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FAX", "FAX", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMAIL", "EMAIL", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WEB", "WEB", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BUSTYPEID", "BUSTYPEID", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CURRID", "CURRID", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CCODE", "CCODE", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ISDEFAULT", "ISDEFAULT", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSERID", "CUSERID", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDATE", "CDATE", 5, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EUSERID", "EUSERID", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EDATE", "EDATE", 5, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookupcompany.Properties.DataSource = this.cOMPANYBindingSource;
            this.lookupcompany.Properties.DisplayMember = "COMPNAME";
            this.lookupcompany.Properties.NullText = "";
            this.lookupcompany.Properties.ValueMember = "CCODE";
            this.lookupcompany.Size = new System.Drawing.Size(325, 20);
            this.lookupcompany.TabIndex = 130;
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // storecode
            // 
            this.storecode.Location = new System.Drawing.Point(334, 175);
            this.storecode.MenuManager = this.ribbon;
            this.storecode.Name = "storecode";
            this.storecode.Properties.MaxLength = 2;
            this.storecode.Properties.ReadOnly = true;
            this.storecode.Size = new System.Drawing.Size(76, 20);
            this.storecode.TabIndex = 131;
            // 
            // Storemast
            // 
            this.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 504);
            this.Controls.Add(this.storecode);
            this.Controls.Add(this.lookupcompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.quotato);
            this.Controls.Add(this.quotafrm);
            this.Controls.Add(this.storetype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.storename);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Storemast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Store ";
            this.Load += new System.EventHandler(this.Storemast_Load);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.address, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.phoneno, 0);
            this.Controls.SetChildIndex(this.fax, 0);
            this.Controls.SetChildIndex(this.storename, 0);
            this.Controls.SetChildIndex(this.radioGroup1, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.checkEdit1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.storetype, 0);
            this.Controls.SetChildIndex(this.quotafrm, 0);
            this.Controls.SetChildIndex(this.quotato, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lookupcompany, 0);
            this.Controls.SetChildIndex(this.storecode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storetype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotafrm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupcompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storecode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private TextBox address;
        private TextBox fax;
        private TextBox phoneno;
        private Label label5;
        private Label label6;
        private LabelControl labelControl6;
        private TextBox storename;
        private LabelControl labelControl7;
        private RadioGroup radioGroup1;
        private LabelControl labelControl8;
        private CheckEdit checkEdit1;
        private Label label1;
        private Label label2;
        private LabelControl labelControl1;
        private ComboBoxEdit storetype;
        private CalcEdit quotafrm;
        private CalcEdit quotato;
        private LabelControl labelControl9;
        private Label label3;
        private LookUpEdit lookupcompany;
        private TextEdit storecode;
        private BindingSource cOMPANYBindingSource;
    }
}