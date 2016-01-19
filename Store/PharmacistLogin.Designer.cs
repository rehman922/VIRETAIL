using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Store
{
    partial class PharmacistLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.txtusername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(34, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "User name :";
            // 
            // txtpassword
            // 
            this.txtpassword.EnterMoveNextControl = true;
            this.txtpassword.Location = new System.Drawing.Point(106, 67);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtpassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtpassword.Properties.Appearance.Options.UseFont = true;
            this.txtpassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtpassword.Properties.MaxLength = 10;
            this.txtpassword.Properties.NullText = "Enter Password";
            this.txtpassword.Properties.NullValuePrompt = "Password";
            this.txtpassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtpassword.Size = new System.Drawing.Size(273, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.EnterMoveNextControl = true;
            this.txtusername.Location = new System.Drawing.Point(106, 43);
            this.txtusername.Name = "txtusername";
            this.txtusername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtusername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Properties.Appearance.Options.UseBackColor = true;
            this.txtusername.Properties.Appearance.Options.UseFont = true;
            this.txtusername.Properties.Appearance.Options.UseForeColor = true;
            this.txtusername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtusername.Properties.NullText = "Enter Username";
            this.txtusername.Properties.NullValuePrompt = "Username";
            this.txtusername.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtusername.Size = new System.Drawing.Size(273, 20);
            this.txtusername.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(37, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Pass word :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(144, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 19);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Pharmacist Login";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Image = global::Store.Properties.Resources.error;
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelControl4.AutoEllipsis = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(106, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(190, 20);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Username and password not match";
            this.labelControl4.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.Delete16;
            this.simpleButton2.Location = new System.Drawing.Point(220, 126);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(74, 25);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.OK16;
            this.simpleButton1.Location = new System.Drawing.Point(140, 126);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(74, 25);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Login";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PharmacistLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 162);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PharmacistLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist Login";
            this.Load += new System.EventHandler(this.PharmacistLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PharmacistLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private TextEdit txtpassword;
        private TextEdit txtusername;
        private LabelControl labelControl2;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
    }
}