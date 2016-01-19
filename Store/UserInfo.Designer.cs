using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Store
{
    partial class UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProfile = new DevExpress.XtraEditors.LookUpEdit();
            this.pROFILENAMEMASTBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textpassword1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoginname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullname = new DevExpress.XtraEditors.TextEdit();
            this.txtEmpno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProfile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFILENAMEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textpassword1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(676, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.cmbProfile);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.textpassword1);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtLoginname);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtFullname);
            this.panel1.Controls.Add(this.txtEmpno);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 206);
            this.panel1.TabIndex = 3;
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(192, 142);
            this.cmbRole.MenuManager = this.ribbon;
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.Properties.Appearance.Options.UseFont = true;
            this.cmbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRole.Properties.Items.AddRange(new object[] {
            "Pharmacist",
            "Cashier",
            "Manager",
            "Admin",
            "Pharmacist & Cashier"});
            this.cmbRole.Size = new System.Drawing.Size(166, 20);
            this.cmbRole.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(89, 170);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 14);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Profile :";
            // 
            // cmbProfile
            // 
            this.cmbProfile.Location = new System.Drawing.Point(192, 168);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfile.Properties.Appearance.Options.UseFont = true;
            this.cmbProfile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProfile.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PROFILEID", "PROFILEID", 81, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PROFILENAME", "PROFILENAME", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbProfile.Properties.DataSource = this.pROFILENAMEMASTBindingSource;
            this.cmbProfile.Properties.DisplayMember = "PROFILENAME";
            this.cmbProfile.Properties.NullText = "";
            this.cmbProfile.Properties.ShowHeader = false;
            this.cmbProfile.Properties.ValueMember = "PROFILEID";
            this.cmbProfile.Size = new System.Drawing.Size(166, 20);
            this.cmbProfile.TabIndex = 6;
            // 
            // pROFILENAMEMASTBindingSource
            // 
            this.pROFILENAMEMASTBindingSource.DataMember = "PROFILENAMEMAST";
            this.pROFILENAMEMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(89, 144);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 14);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Role :";
            // 
            // textpassword1
            // 
            this.textpassword1.Location = new System.Drawing.Point(192, 116);
            this.textpassword1.Name = "textpassword1";
            this.textpassword1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword1.Properties.Appearance.Options.UseFont = true;
            this.textpassword1.Properties.MaxLength = 10;
            this.textpassword1.Properties.UseSystemPasswordChar = true;
            this.textpassword1.Size = new System.Drawing.Size(166, 20);
            this.textpassword1.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(89, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 14);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "cofirm password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.MaxLength = 10;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(89, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 14);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Password :";
            // 
            // txtLoginname
            // 
            this.txtLoginname.Location = new System.Drawing.Point(192, 64);
            this.txtLoginname.Name = "txtLoginname";
            this.txtLoginname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginname.Properties.Appearance.Options.UseFont = true;
            this.txtLoginname.Properties.MaxLength = 20;
            this.txtLoginname.Size = new System.Drawing.Size(166, 20);
            this.txtLoginname.TabIndex = 2;
            this.txtLoginname.Validated += new System.EventHandler(this.txtLoginname_Validated);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(89, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 14);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Login name :";
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(341, 12);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Active ";
            this.checkEdit1.Size = new System.Drawing.Size(82, 19);
            this.checkEdit1.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(89, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 14);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Full name :";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(192, 38);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Properties.Appearance.Options.UseFont = true;
            this.txtFullname.Properties.MaxLength = 150;
            this.txtFullname.Size = new System.Drawing.Size(329, 20);
            this.txtFullname.TabIndex = 1;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(192, 12);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpno.Properties.Appearance.Options.UseFont = true;
            this.txtEmpno.Properties.MaxLength = 6;
            this.txtEmpno.Size = new System.Drawing.Size(142, 20);
            this.txtEmpno.TabIndex = 0;
            this.txtEmpno.Validated += new System.EventHandler(this.txtEmpno_Validated);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(89, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Employee No. :";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // UserInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 389);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProfile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFILENAMEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textpassword1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private LookUpEdit cmbProfile;
        private LabelControl labelControl6;
        private TextEdit textpassword1;
        private LabelControl labelControl5;
        private TextEdit txtPassword;
        private LabelControl labelControl4;
        private TextEdit txtLoginname;
        private LabelControl labelControl3;
        private CheckEdit checkEdit1;
        private LabelControl labelControl2;
        private TextEdit txtFullname;
        private TextEdit txtEmpno;
        private LabelControl labelControl1;
        private ComboBoxEdit cmbRole;
        private LabelControl labelControl7;
        private BindingSource bindingSource1;
        protected DXErrorProvider dxErrorProvider1;
        private BindingSource pROFILENAMEMASTBindingSource;


    }
}