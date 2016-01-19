using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Store
{
    partial class FrmPatInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatInfo));
            this.txtmemno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtcompname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtfno = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.cutomerpayment = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmemno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcompname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutomerpayment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmemno
            // 
            this.txtmemno.EnterMoveNextControl = true;
            this.txtmemno.Location = new System.Drawing.Point(154, 53);
            this.txtmemno.Name = "txtmemno";
            this.txtmemno.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmemno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmemno.Properties.Appearance.Options.UseBackColor = true;
            this.txtmemno.Properties.Appearance.Options.UseForeColor = true;
            this.txtmemno.Properties.MaxLength = 10;
            this.txtmemno.Size = new System.Drawing.Size(134, 20);
            this.txtmemno.TabIndex = 1;
            this.txtmemno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmemno_KeyDown);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(23, 55);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(81, 14);
            this.labelControl10.TabIndex = 40;
            this.labelControl10.Text = "Member No. :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 14);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Member Name :";
            // 
            // txtname
            // 
            this.txtname.EnterMoveNextControl = true;
            this.txtname.Location = new System.Drawing.Point(154, 111);
            this.txtname.Name = "txtname";
            this.txtname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtname.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtname.Properties.Appearance.Options.UseBackColor = true;
            this.txtname.Properties.Appearance.Options.UseForeColor = true;
            this.txtname.Properties.MaxLength = 10;
            this.txtname.Size = new System.Drawing.Size(345, 20);
            this.txtname.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(23, 140);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 14);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Company Name :";
            // 
            // txtcompname
            // 
            this.txtcompname.EnterMoveNextControl = true;
            this.txtcompname.Location = new System.Drawing.Point(154, 139);
            this.txtcompname.Name = "txtcompname";
            this.txtcompname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtcompname.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcompname.Properties.Appearance.Options.UseBackColor = true;
            this.txtcompname.Properties.Appearance.Options.UseForeColor = true;
            this.txtcompname.Properties.MaxLength = 10;
            this.txtcompname.Size = new System.Drawing.Size(345, 20);
            this.txtcompname.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(23, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 14);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "File No. :";
            // 
            // txtfno
            // 
            this.txtfno.EnterMoveNextControl = true;
            this.txtfno.Location = new System.Drawing.Point(154, 25);
            this.txtfno.Name = "txtfno";
            this.txtfno.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtfno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtfno.Properties.Appearance.Options.UseBackColor = true;
            this.txtfno.Properties.Appearance.Options.UseForeColor = true;
            this.txtfno.Properties.MaxLength = 10;
            this.txtfno.Size = new System.Drawing.Size(134, 20);
            this.txtfno.TabIndex = 0;
            this.txtfno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfno_KeyDown);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(167, 172);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(76, 37);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "SAVE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(249, 172);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(76, 37);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "CLOSE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl16.Location = new System.Drawing.Point(23, 84);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(124, 14);
            this.labelControl16.TabIndex = 58;
            this.labelControl16.Text = "Customer Share % :";
            // 
            // cutomerpayment
            // 
            this.cutomerpayment.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cutomerpayment.EnterMoveNextControl = true;
            this.cutomerpayment.Location = new System.Drawing.Point(154, 81);
            this.cutomerpayment.Name = "cutomerpayment";
            this.cutomerpayment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutomerpayment.Properties.Appearance.Options.UseFont = true;
            this.cutomerpayment.Properties.Appearance.Options.UseTextOptions = true;
            this.cutomerpayment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cutomerpayment.Properties.DisplayFormat.FormatString = "##.00";
            this.cutomerpayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cutomerpayment.Properties.EditFormat.FormatString = "##.00";
            this.cutomerpayment.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cutomerpayment.Properties.NullText = "0";
            this.cutomerpayment.Properties.NullValuePrompt = "0";
            this.cutomerpayment.Size = new System.Drawing.Size(62, 22);
            this.cutomerpayment.TabIndex = 2;
            // 
            // FrmPatInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 221);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.cutomerpayment);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.txtfno);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtcompname);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtmemno);
            this.Controls.Add(this.labelControl10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPatInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Information";
            ((System.ComponentModel.ISupportInitialize)(this.txtmemno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcompname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutomerpayment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit txtmemno;
        private LabelControl labelControl10;
        private LabelControl labelControl1;
        private TextEdit txtname;
        private LabelControl labelControl2;
        private TextEdit txtcompname;
        private LabelControl labelControl3;
        private TextEdit txtfno;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton1;
        private LabelControl labelControl16;
        private TextEdit cutomerpayment;
    }
}