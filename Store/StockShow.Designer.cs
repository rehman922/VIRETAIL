using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Store
{
    partial class StockShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockShow));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblbarcode = new DevExpress.XtraEditors.LabelControl();
            this.lblname = new DevExpress.XtraEditors.LabelControl();
            this.lblqtyonhand = new DevExpress.XtraEditors.LabelControl();
            this.lblqtyonorder = new DevExpress.XtraEditors.LabelControl();
            this.lblqtyavailable = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtentered = new DevExpress.XtraEditors.TextEdit();
            this.txtsalesprice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtentered.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalesprice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Image = global::Store.Properties.Resources.error;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(93, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(323, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "     You don\'t have sufficient stock to this item";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Barcode :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Item name :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 136);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Qty on hand :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 269);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Qty on order :";
            this.labelControl5.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 302);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Qty Available :";
            this.labelControl6.Visible = false;
            // 
            // lblbarcode
            // 
            this.lblbarcode.Appearance.BackColor = System.Drawing.Color.White;
            this.lblbarcode.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblbarcode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblbarcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lblbarcode.Location = new System.Drawing.Point(93, 66);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(215, 24);
            this.lblbarcode.TabIndex = 6;
            this.lblbarcode.Text = "Barcode :";
            // 
            // lblname
            // 
            this.lblname.Appearance.BackColor = System.Drawing.Color.White;
            this.lblname.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblname.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lblname.Location = new System.Drawing.Point(93, 99);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(348, 24);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "Barcode :";
            // 
            // lblqtyonhand
            // 
            this.lblqtyonhand.Appearance.BackColor = System.Drawing.Color.White;
            this.lblqtyonhand.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtyonhand.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblqtyonhand.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblqtyonhand.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lblqtyonhand.Location = new System.Drawing.Point(93, 132);
            this.lblqtyonhand.Name = "lblqtyonhand";
            this.lblqtyonhand.Size = new System.Drawing.Size(73, 24);
            this.lblqtyonhand.TabIndex = 8;
            this.lblqtyonhand.Text = "Barcode :";
            // 
            // lblqtyonorder
            // 
            this.lblqtyonorder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtyonorder.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblqtyonorder.Location = new System.Drawing.Point(84, 264);
            this.lblqtyonorder.Name = "lblqtyonorder";
            this.lblqtyonorder.Size = new System.Drawing.Size(307, 24);
            this.lblqtyonorder.TabIndex = 9;
            this.lblqtyonorder.Text = "Barcode :";
            this.lblqtyonorder.Visible = false;
            // 
            // lblqtyavailable
            // 
            this.lblqtyavailable.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtyavailable.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblqtyavailable.Location = new System.Drawing.Point(84, 297);
            this.lblqtyavailable.Name = "lblqtyavailable";
            this.lblqtyavailable.Size = new System.Drawing.Size(307, 24);
            this.lblqtyavailable.TabIndex = 10;
            this.lblqtyavailable.Text = "Barcode :";
            this.lblqtyavailable.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.Location = new System.Drawing.Point(137, 165);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(131, 14);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Enter sales receipt qty :";
            // 
            // txtentered
            // 
            this.txtentered.EditValue = 0;
            this.txtentered.EnterMoveNextControl = true;
            this.txtentered.Location = new System.Drawing.Point(274, 163);
            this.txtentered.Name = "txtentered";
            this.txtentered.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentered.Properties.Appearance.Options.UseFont = true;
            this.txtentered.Properties.Appearance.Options.UseTextOptions = true;
            this.txtentered.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtentered.Properties.Mask.BeepOnError = true;
            this.txtentered.Properties.Mask.EditMask = "n0";
            this.txtentered.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtentered.Properties.MaxLength = 3;
            this.txtentered.Size = new System.Drawing.Size(57, 20);
            this.txtentered.TabIndex = 0;
            // 
            // txtsalesprice
            // 
            this.txtsalesprice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtsalesprice.EnterMoveNextControl = true;
            this.txtsalesprice.Location = new System.Drawing.Point(274, 194);
            this.txtsalesprice.Name = "txtsalesprice";
            this.txtsalesprice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesprice.Properties.Appearance.Options.UseFont = true;
            this.txtsalesprice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtsalesprice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtsalesprice.Properties.DisplayFormat.FormatString = "N2";
            this.txtsalesprice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsalesprice.Properties.Mask.EditMask = "n2";
            this.txtsalesprice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtsalesprice.Properties.MaxLength = 6;
            this.txtsalesprice.Size = new System.Drawing.Size(57, 20);
            this.txtsalesprice.TabIndex = 1;
            this.txtsalesprice.EditValueChanged += new System.EventHandler(this.txtsalesprice_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl8.Location = new System.Drawing.Point(137, 197);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(97, 14);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Enter sales price :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.Delete16;
            this.simpleButton2.Location = new System.Drawing.Point(236, 235);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(99, 27);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "ESC - Cancel ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.OK16;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(131, 235);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(99, 27);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "F4 - OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // StockShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 271);
            this.Controls.Add(this.txtsalesprice);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtentered);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblqtyavailable);
            this.Controls.Add(this.lblqtyonorder);
            this.Controls.Add(this.lblqtyonhand);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblbarcode);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insufficient Quantity";
            this.Load += new System.EventHandler(this.StockShow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockShow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtentered.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalesprice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private LabelControl lblbarcode;
        private LabelControl lblname;
        private LabelControl lblqtyonhand;
        private LabelControl lblqtyonorder;
        private LabelControl lblqtyavailable;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private LabelControl labelControl7;
        private TextEdit txtentered;
        private TextEdit txtsalesprice;
        private LabelControl labelControl8;
    }
}