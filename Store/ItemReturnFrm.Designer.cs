using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Store
{
    partial class ItemReturnFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemReturnFrm));
            this.txtsalesprice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtentered = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblname = new DevExpress.XtraEditors.LabelControl();
            this.lblbarcode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtexpdate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalesprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtentered.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtexpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsalesprice
            // 
            this.txtsalesprice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtsalesprice.EnterMoveNextControl = true;
            this.txtsalesprice.Location = new System.Drawing.Point(281, 156);
            this.txtsalesprice.Name = "txtsalesprice";
            this.txtsalesprice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesprice.Properties.Appearance.Options.UseFont = true;
            this.txtsalesprice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtsalesprice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtsalesprice.Properties.DisplayFormat.FormatString = "N2";
            this.txtsalesprice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsalesprice.Size = new System.Drawing.Size(73, 20);
            this.txtsalesprice.TabIndex = 18;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl8.Location = new System.Drawing.Point(144, 159);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(97, 14);
            this.labelControl8.TabIndex = 28;
            this.labelControl8.Text = "Enter sales price :";
            // 
            // txtentered
            // 
            this.txtentered.EditValue = "1";
            this.txtentered.EnterMoveNextControl = true;
            this.txtentered.Location = new System.Drawing.Point(281, 130);
            this.txtentered.Name = "txtentered";
            this.txtentered.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentered.Properties.Appearance.Options.UseFont = true;
            this.txtentered.Properties.Appearance.Options.UseTextOptions = true;
            this.txtentered.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtentered.Size = new System.Drawing.Size(73, 20);
            this.txtentered.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.Location = new System.Drawing.Point(144, 132);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(127, 14);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Enter sales return qty :";
            // 
            // lblname
            // 
            this.lblname.Appearance.BackColor = System.Drawing.Color.White;
            this.lblname.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblname.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lblname.Location = new System.Drawing.Point(96, 89);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(348, 24);
            this.lblname.TabIndex = 25;
            this.lblname.Text = "Barcode :";
            // 
            // lblbarcode
            // 
            this.lblbarcode.Appearance.BackColor = System.Drawing.Color.White;
            this.lblbarcode.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblbarcode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblbarcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lblbarcode.Location = new System.Drawing.Point(96, 56);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(215, 24);
            this.lblbarcode.TabIndex = 24;
            this.lblbarcode.Text = "Barcode :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(6, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 14);
            this.labelControl4.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(15, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 14);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Item name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(15, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Barcode :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Image = global::Store.Properties.Resources.error;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(160, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 20);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "     Return Item Details";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(144, 185);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 14);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Enter expiry date :";
            // 
            // txtexpdate
            // 
            this.txtexpdate.Location = new System.Drawing.Point(281, 183);
            this.txtexpdate.Name = "txtexpdate";
            this.txtexpdate.Properties.MaxLength = 5;
            this.txtexpdate.Size = new System.Drawing.Size(73, 20);
            this.txtexpdate.TabIndex = 31;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.Location = new System.Drawing.Point(360, 185);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 14);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "MM-yy";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.Delete16;
            this.simpleButton2.Location = new System.Drawing.Point(239, 220);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(99, 27);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "ESC - Cancel ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.OK16;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(134, 220);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(99, 27);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "F4 - OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ItemReturnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 258);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtexpdate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtsalesprice);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtentered);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblbarcode);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemReturnFrm";
            this.Text = "Item Return Details";
            this.Load += new System.EventHandler(this.ItemReturnFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemReturnFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtsalesprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtentered.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtexpdate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit txtsalesprice;
        private LabelControl labelControl8;
        private TextEdit txtentered;
        private LabelControl labelControl7;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private LabelControl lblname;
        private LabelControl lblbarcode;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private LabelControl labelControl5;
        private TextEdit txtexpdate;
        private LabelControl labelControl6;

    }
}