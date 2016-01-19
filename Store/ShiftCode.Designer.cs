using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Store
{
    partial class ShiftCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftCode));
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // checkButton2
            // 
            this.checkButton2.Location = new System.Drawing.Point(191, 93);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.Size = new System.Drawing.Size(200, 46);
            this.checkButton2.TabIndex = 1;
            this.checkButton2.Tag = "2";
            this.checkButton2.Text = "Shift 2";
            this.checkButton2.CheckedChanged += new System.EventHandler(this.checkButton2_CheckedChanged);
            // 
            // checkButton3
            // 
            this.checkButton3.Location = new System.Drawing.Point(191, 145);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(200, 46);
            this.checkButton3.TabIndex = 2;
            this.checkButton3.Tag = "3";
            this.checkButton3.Text = "Shift 3";
            this.checkButton3.CheckedChanged += new System.EventHandler(this.checkButton3_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(23, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Current Shift :";
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(191, 41);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(200, 46);
            this.checkButton1.TabIndex = 0;
            this.checkButton1.Tag = "1";
            this.checkButton1.Text = "Shift 1";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Location = new System.Drawing.Point(144, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 19);
            this.labelControl2.TabIndex = 4;
            // 
            // ShiftCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 205);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.checkButton3);
            this.Controls.Add(this.checkButton2);
            this.Controls.Add(this.checkButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShiftCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Code";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftCode_FormClosed);
            this.Load += new System.EventHandler(this.ShiftCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckButton checkButton1;
        private CheckButton checkButton2;
        private CheckButton checkButton3;
        private LabelControl labelControl1;
        private LabelControl labelControl2;

    }
}