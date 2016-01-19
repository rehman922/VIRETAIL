using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Store
{
    partial class FrmCompany
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cOMPNAMELabel;
            System.Windows.Forms.Label cOMPADDLabel;
            System.Windows.Forms.Label cITYLabel;
            System.Windows.Forms.Label cOUNTRYLabel;
            System.Windows.Forms.Label tELEPHONELabel;
            System.Windows.Forms.Label fAXLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label wEBLabel;
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            label1 = new System.Windows.Forms.Label();
            cOMPNAMELabel = new System.Windows.Forms.Label();
            cOMPADDLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            cOUNTRYLabel = new System.Windows.Forms.Label();
            tELEPHONELabel = new System.Windows.Forms.Label();
            fAXLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            wEBLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(648, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(148, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 14);
            label1.TabIndex = 34;
            label1.Text = "Code:";
            // 
            // cOMPNAMELabel
            // 
            cOMPNAMELabel.AutoSize = true;
            cOMPNAMELabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOMPNAMELabel.Location = new System.Drawing.Point(148, 42);
            cOMPNAMELabel.Name = "cOMPNAMELabel";
            cOMPNAMELabel.Size = new System.Drawing.Size(96, 14);
            cOMPNAMELabel.TabIndex = 24;
            cOMPNAMELabel.Text = "Company Name:";
            // 
            // cOMPADDLabel
            // 
            cOMPADDLabel.AutoSize = true;
            cOMPADDLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOMPADDLabel.Location = new System.Drawing.Point(148, 97);
            cOMPADDLabel.Name = "cOMPADDLabel";
            cOMPADDLabel.Size = new System.Drawing.Size(87, 14);
            cOMPADDLabel.TabIndex = 25;
            cOMPADDLabel.Text = "Company Add:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cITYLabel.Location = new System.Drawing.Point(148, 148);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(31, 14);
            cITYLabel.TabIndex = 26;
            cITYLabel.Text = "City:";
            // 
            // cOUNTRYLabel
            // 
            cOUNTRYLabel.AutoSize = true;
            cOUNTRYLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOUNTRYLabel.Location = new System.Drawing.Point(148, 175);
            cOUNTRYLabel.Name = "cOUNTRYLabel";
            cOUNTRYLabel.Size = new System.Drawing.Size(54, 14);
            cOUNTRYLabel.TabIndex = 27;
            cOUNTRYLabel.Text = "Country:";
            // 
            // tELEPHONELabel
            // 
            tELEPHONELabel.AutoSize = true;
            tELEPHONELabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEPHONELabel.Location = new System.Drawing.Point(148, 203);
            tELEPHONELabel.Name = "tELEPHONELabel";
            tELEPHONELabel.Size = new System.Drawing.Size(93, 14);
            tELEPHONELabel.TabIndex = 28;
            tELEPHONELabel.Text = "Telephone No.:";
            // 
            // fAXLabel
            // 
            fAXLabel.AutoSize = true;
            fAXLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fAXLabel.Location = new System.Drawing.Point(148, 230);
            fAXLabel.Name = "fAXLabel";
            fAXLabel.Size = new System.Drawing.Size(29, 14);
            fAXLabel.TabIndex = 29;
            fAXLabel.Text = "Fax:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.Location = new System.Drawing.Point(148, 257);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(41, 14);
            eMAILLabel.TabIndex = 30;
            eMAILLabel.Text = "E-Mail:";
            // 
            // wEBLabel
            // 
            wEBLabel.AutoSize = true;
            wEBLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            wEBLabel.Location = new System.Drawing.Point(148, 283);
            wEBLabel.Name = "wEBLabel";
            wEBLabel.Size = new System.Drawing.Size(37, 14);
            wEBLabel.TabIndex = 31;
            wEBLabel.Text = "Web:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textEdit3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.memoEdit1);
            this.panel1.Controls.Add(this.textEdit9);
            this.panel1.Controls.Add(this.textEdit8);
            this.panel1.Controls.Add(this.textEdit7);
            this.panel1.Controls.Add(this.textEdit6);
            this.panel1.Controls.Add(this.textEdit5);
            this.panel1.Controls.Add(this.textEdit4);
            this.panel1.Controls.Add(this.textEdit2);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(cOMPNAMELabel);
            this.panel1.Controls.Add(cOMPADDLabel);
            this.panel1.Controls.Add(cITYLabel);
            this.panel1.Controls.Add(cOUNTRYLabel);
            this.panel1.Controls.Add(tELEPHONELabel);
            this.panel1.Controls.Add(fAXLabel);
            this.panel1.Controls.Add(eMAILLabel);
            this.panel1.Controls.Add(wEBLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 308);
            this.panel1.TabIndex = 2;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(250, 100);
            this.memoEdit1.MenuManager = this.ribbon;
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 1500;
            this.memoEdit1.Size = new System.Drawing.Size(300, 40);
            this.memoEdit1.TabIndex = 44;
            // 
            // textEdit9
            // 
            this.textEdit9.Location = new System.Drawing.Point(250, 281);
            this.textEdit9.MenuManager = this.ribbon;
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Size = new System.Drawing.Size(149, 20);
            this.textEdit9.TabIndex = 43;
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(250, 254);
            this.textEdit8.MenuManager = this.ribbon;
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.MaxLength = 50;
            this.textEdit8.Size = new System.Drawing.Size(149, 20);
            this.textEdit8.TabIndex = 42;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(250, 227);
            this.textEdit7.MenuManager = this.ribbon;
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.MaxLength = 50;
            this.textEdit7.Size = new System.Drawing.Size(149, 20);
            this.textEdit7.TabIndex = 41;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(250, 200);
            this.textEdit6.MenuManager = this.ribbon;
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.MaxLength = 15;
            this.textEdit6.Size = new System.Drawing.Size(149, 20);
            this.textEdit6.TabIndex = 40;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(250, 173);
            this.textEdit5.MenuManager = this.ribbon;
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.MaxLength = 50;
            this.textEdit5.Size = new System.Drawing.Size(149, 20);
            this.textEdit5.TabIndex = 39;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(250, 146);
            this.textEdit4.MenuManager = this.ribbon;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.MaxLength = 50;
            this.textEdit4.Size = new System.Drawing.Size(149, 20);
            this.textEdit4.TabIndex = 38;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(250, 40);
            this.textEdit2.MenuManager = this.ribbon;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.MaxLength = 50;
            this.textEdit2.Size = new System.Drawing.Size(300, 20);
            this.textEdit2.TabIndex = 36;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(250, 13);
            this.textEdit1.MenuManager = this.ribbon;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.MaxLength = 2;
            this.textEdit1.Size = new System.Drawing.Size(63, 20);
            this.textEdit1.TabIndex = 35;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(250, 66);
            this.textEdit3.MenuManager = this.ribbon;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.MaxLength = 50;
            this.textEdit3.Size = new System.Drawing.Size(300, 20);
            this.textEdit3.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(148, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 14);
            label2.TabIndex = 45;
            label2.Text = "Arabic Name :";
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 489);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCompany";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextEdit textEdit9;
        private TextEdit textEdit8;
        private TextEdit textEdit7;
        private TextEdit textEdit6;
        private TextEdit textEdit5;
        private TextEdit textEdit4;
        private TextEdit textEdit2;
        private TextEdit textEdit1;
        private MemoEdit memoEdit1;
        private TextEdit textEdit3;
    }
}