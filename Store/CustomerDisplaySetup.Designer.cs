using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Store
{
    partial class CustomerDisplaySetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDisplaySetup));
            this.btnHello = new System.Windows.Forms.Button();
            this.btnPortState = new System.Windows.Forms.Button();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.cboHandShaking = new System.Windows.Forms.ComboBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(36, 98);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 22;
            this.btnHello.Text = "Send Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnPortState
            // 
            this.btnPortState.Location = new System.Drawing.Point(36, 69);
            this.btnPortState.Name = "btnPortState";
            this.btnPortState.Size = new System.Drawing.Size(75, 23);
            this.btnPortState.TabIndex = 21;
            this.btnPortState.Text = "Closed";
            this.btnPortState.UseVisualStyleBackColor = true;
            this.btnPortState.Click += new System.EventHandler(this.btnPortState_Click);
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(126, 150);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(121, 21);
            this.cboParity.TabIndex = 20;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(126, 123);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(121, 21);
            this.cboStopBits.TabIndex = 19;
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(126, 96);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(121, 21);
            this.cboDataBits.TabIndex = 18;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(126, 69);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 17;
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(126, 42);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 16;
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(36, 40);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetSerialPorts.TabIndex = 15;
            this.btnGetSerialPorts.Text = "Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // cboHandShaking
            // 
            this.cboHandShaking.FormattingEnabled = true;
            this.cboHandShaking.Location = new System.Drawing.Point(126, 177);
            this.cboHandShaking.Name = "cboHandShaking";
            this.cboHandShaking.Size = new System.Drawing.Size(121, 21);
            this.cboHandShaking.TabIndex = 23;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(140, 208);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(76, 37);
            this.simpleButton3.TabIndex = 24;
            this.simpleButton3.Text = "SAVE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // CustomerDisplaySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 253);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.cboHandShaking);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnPortState);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.cboDataBits);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerDisplaySetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Display Setup";
            this.Load += new System.EventHandler(this.CustomerDisplaySetup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHello;
        private Button btnPortState;
        private ComboBox cboParity;
        private ComboBox cboStopBits;
        private ComboBox cboDataBits;
        private ComboBox cboBaudRate;
        private ComboBox cboPorts;
        private Button btnGetSerialPorts;
        private ComboBox cboHandShaking;
        private SimpleButton simpleButton3;
    }
}