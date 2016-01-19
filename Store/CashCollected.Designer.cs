using System.ComponentModel;
using System.Windows.Forms;

namespace Store
{
    partial class CashCollected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashCollected));
            this.panelcards = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btncredit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelcards.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcards
            // 
            this.panelcards.Controls.Add(this.button8);
            this.panelcards.Controls.Add(this.button7);
            this.panelcards.Controls.Add(this.button6);
            this.panelcards.Controls.Add(this.button5);
            this.panelcards.Location = new System.Drawing.Point(30, 14);
            this.panelcards.Name = "panelcards";
            this.panelcards.Size = new System.Drawing.Size(172, 277);
            this.panelcards.TabIndex = 7;
            this.panelcards.Visible = false;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::Store.Properties.Resources.amex;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::Store.Properties.Resources.B4;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button8.Location = new System.Drawing.Point(31, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 62);
            this.button8.TabIndex = 6;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Store.Properties.Resources.visa48;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::Store.Properties.Resources.B3;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button7.Location = new System.Drawing.Point(31, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 60);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btncredit_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Store.Properties.Resources.mastercard;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::Store.Properties.Resources.B2;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button6.Location = new System.Drawing.Point(31, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 62);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Store.Properties.Resources.B1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.Location = new System.Drawing.Point(31, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 62);
            this.button5.TabIndex = 3;
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncredit
            // 
            this.btncredit.BackgroundImage = global::Store.Properties.Resources.invoice6;
            this.btncredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncredit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredit.Image = global::Store.Properties.Resources.B3;
            this.btncredit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btncredit.Location = new System.Drawing.Point(32, 155);
            this.btncredit.Name = "btncredit";
            this.btncredit.Size = new System.Drawing.Size(166, 62);
            this.btncredit.TabIndex = 2;
            this.btncredit.Text = "Credit";
            this.btncredit.UseVisualStyleBackColor = true;
            this.btncredit.Click += new System.EventHandler(this.btncredit_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Store.Properties.Resources.creditcards;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Store.Properties.Resources.B2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(32, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Card";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Store.Properties.Resources.Cash;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Store.Properties.Resources.B1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(32, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Store.Properties.Resources._48bg;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Store.Properties.Resources.B4;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(32, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 62);
            this.button3.TabIndex = 7;
            this.button3.Text = "ALL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CashCollected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 325);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncredit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelcards);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Metropolis";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "CashCollected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collection type";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashCollected_KeyDown);
            this.panelcards.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button2;
        private Button button1;
        private Button btncredit;
        private Panel panelcards;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
    }
}