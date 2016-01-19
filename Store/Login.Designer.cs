using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Store
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtusername = new DevExpress.XtraEditors.TextEdit();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.EnterMoveNextControl = true;
            this.txtusername.Location = new System.Drawing.Point(297, 182);
            this.txtusername.Name = "txtusername";
            this.txtusername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtusername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Properties.Appearance.Options.UseBackColor = true;
            this.txtusername.Properties.Appearance.Options.UseFont = true;
            this.txtusername.Properties.Appearance.Options.UseForeColor = true;
            this.txtusername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtusername.Properties.NullText = "Username";
            this.txtusername.Properties.NullValuePrompt = "Username";
            this.txtusername.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtusername.Size = new System.Drawing.Size(239, 18);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.EnterMoveNextControl = true;
            this.txtpassword.Location = new System.Drawing.Point(297, 232);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtpassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtpassword.Properties.Appearance.Options.UseFont = true;
            this.txtpassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtpassword.Properties.MaxLength = 10;
            this.txtpassword.Properties.NullText = "Password";
            this.txtpassword.Properties.NullValuePrompt = "Password";
            this.txtpassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtpassword.Size = new System.Drawing.Size(239, 18);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.Enter += new System.EventHandler(this.textEdit2_Enter);
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit2_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Store.Properties.Resources.lgnbtn;
            this.button2.Location = new System.Drawing.Point(475, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Image = global::Store.Properties.Resources.error;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelControl1.AutoEllipsis = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(380, 259);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(190, 20);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Username and password not match";
            this.labelControl1.Visible = false;
            // 
            // checkEdit1
            // 
            this.checkEdit1.AutoSizeInLayoutControl = true;
            this.checkEdit1.Location = new System.Drawing.Point(288, 260);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Remember me";
            this.checkEdit1.Size = new System.Drawing.Size(92, 19);
            this.checkEdit1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Store.Properties.Resources.lgnbtn;
            this.button1.Location = new System.Drawing.Point(374, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = global::Store.Properties.Resources.loginscreen123;
            this.ClientSize = new System.Drawing.Size(609, 369);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Sharp Plus";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit txtusername;
        private TextEdit txtpassword;
        private Button button2;
        private LabelControl labelControl1;
        private CheckEdit checkEdit1;
        private Button button1;
    }
}