using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Store
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblmaxdisc = new DevExpress.XtraEditors.LabelControl();
            this.maxdisc = new DevExpress.XtraEditors.TextEdit();
            this.c1 = new DevExpress.XtraEditors.CheckEdit();
            this.c2 = new DevExpress.XtraEditors.CheckEdit();
            this.c3 = new DevExpress.XtraEditors.CheckEdit();
            this.c4 = new DevExpress.XtraEditors.CheckEdit();
            this.c5 = new DevExpress.XtraEditors.CheckEdit();
            this.c6 = new DevExpress.XtraEditors.CheckEdit();
            this.c7 = new DevExpress.XtraEditors.CheckEdit();
            this.c8 = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.timeedit = new DevExpress.XtraEditors.TimeEdit();
            this.lblsttime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.runevery = new DevExpress.XtraEditors.SpinEdit();
            this.lblrunevery = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblfreq = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxdisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runevery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.groupControl1.Controls.Add(this.lblmaxdisc);
            this.groupControl1.Controls.Add(this.maxdisc);
            this.groupControl1.Controls.Add(this.c1);
            this.groupControl1.Controls.Add(this.c2);
            this.groupControl1.Controls.Add(this.c3);
            this.groupControl1.Controls.Add(this.c4);
            this.groupControl1.Controls.Add(this.c5);
            this.groupControl1.Controls.Add(this.c6);
            this.groupControl1.Controls.Add(this.c7);
            this.groupControl1.Controls.Add(this.c8);
            this.groupControl1.Location = new System.Drawing.Point(13, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(301, 320);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Options";
            // 
            // lblmaxdisc
            // 
            this.lblmaxdisc.Location = new System.Drawing.Point(141, 60);
            this.lblmaxdisc.Name = "lblmaxdisc";
            this.lblmaxdisc.Size = new System.Drawing.Size(95, 13);
            this.lblmaxdisc.TabIndex = 34;
            this.lblmaxdisc.Text = "Maximum Discount :";
            this.lblmaxdisc.Visible = false;
            // 
            // maxdisc
            // 
            this.maxdisc.EditValue = "10";
            this.maxdisc.Location = new System.Drawing.Point(239, 57);
            this.maxdisc.Name = "maxdisc";
            this.maxdisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxdisc.Properties.Appearance.Options.UseFont = true;
            this.maxdisc.Properties.Appearance.Options.UseTextOptions = true;
            this.maxdisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maxdisc.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.maxdisc.Properties.Mask.EditMask = "P0";
            this.maxdisc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maxdisc.Size = new System.Drawing.Size(57, 20);
            this.maxdisc.TabIndex = 33;
            this.maxdisc.Visible = false;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(17, 40);
            this.c1.Name = "c1";
            this.c1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Properties.Appearance.Options.UseFont = true;
            this.c1.Properties.Caption = "1.Allow Manual Discount";
            this.c1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.c1.Size = new System.Drawing.Size(218, 20);
            this.c1.TabIndex = 32;
            this.c1.CheckedChanged += new System.EventHandler(this.c1_CheckedChanged);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(15, 72);
            this.c2.Name = "c2";
            this.c2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Properties.Appearance.Options.UseFont = true;
            this.c2.Properties.Caption = "2.Allow Negative Inventory";
            this.c2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.c2.Size = new System.Drawing.Size(218, 20);
            this.c2.TabIndex = 31;
            // 
            // c3
            // 
            this.c3.EditValue = true;
            this.c3.Enabled = false;
            this.c3.Location = new System.Drawing.Point(17, 104);
            this.c3.Name = "c3";
            this.c3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Properties.Appearance.Options.UseFont = true;
            this.c3.Properties.Caption = "3.Upload Daily Sales Report";
            this.c3.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.c3.Size = new System.Drawing.Size(218, 20);
            this.c3.TabIndex = 30;
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(17, 136);
            this.c4.Name = "c4";
            this.c4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Properties.Appearance.Options.UseFont = true;
            this.c4.Properties.Caption = "4.Upload Purchase";
            this.c4.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.c4.Size = new System.Drawing.Size(218, 20);
            this.c4.TabIndex = 29;
            // 
            // c5
            // 
            this.c5.Location = new System.Drawing.Point(17, 168);
            this.c5.Name = "c5";
            this.c5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c5.Properties.Appearance.Options.UseFont = true;
            this.c5.Properties.Caption = "5.Upload  Sales";
            this.c5.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.c5.Size = new System.Drawing.Size(218, 20);
            this.c5.TabIndex = 28;
            // 
            // c6
            // 
            this.c6.Location = new System.Drawing.Point(15, 200);
            this.c6.Name = "c6";
            this.c6.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c6.Properties.Appearance.Options.UseFont = true;
            this.c6.Properties.Caption = "6.Upload  Item Master";
            this.c6.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.c6.Size = new System.Drawing.Size(218, 20);
            this.c6.TabIndex = 27;
            // 
            // c7
            // 
            this.c7.Location = new System.Drawing.Point(15, 232);
            this.c7.Name = "c7";
            this.c7.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c7.Properties.Appearance.Options.UseFont = true;
            this.c7.Properties.Caption = "7.Upload Supplier Master";
            this.c7.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.c7.Size = new System.Drawing.Size(218, 20);
            this.c7.TabIndex = 26;
            // 
            // c8
            // 
            this.c8.EditValue = true;
            this.c8.Enabled = false;
            this.c8.Location = new System.Drawing.Point(15, 264);
            this.c8.Name = "c8";
            this.c8.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c8.Properties.Appearance.Options.UseFont = true;
            this.c8.Properties.Caption = "8.Upload/Downlaod Transfer";
            this.c8.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.c8.Size = new System.Drawing.Size(218, 20);
            this.c8.TabIndex = 25;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.timeedit);
            this.groupControl2.Controls.Add(this.lblsttime);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.runevery);
            this.groupControl2.Controls.Add(this.lblrunevery);
            this.groupControl2.Controls.Add(this.comboBoxEdit1);
            this.groupControl2.Controls.Add(this.lblfreq);
            this.groupControl2.Controls.Add(this.radioGroup1);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(328, 36);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(295, 319);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Schedule";
            // 
            // timeedit
            // 
            this.timeedit.EditValue = new System.DateTime(2013, 7, 8, 0, 0, 0, 0);
            this.timeedit.Location = new System.Drawing.Point(118, 256);
            this.timeedit.Name = "timeedit";
            this.timeedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeedit.Size = new System.Drawing.Size(99, 20);
            this.timeedit.TabIndex = 4;
            this.timeedit.Visible = false;
            // 
            // lblsttime
            // 
            this.lblsttime.Location = new System.Drawing.Point(42, 259);
            this.lblsttime.Name = "lblsttime";
            this.lblsttime.Size = new System.Drawing.Size(54, 13);
            this.lblsttime.TabIndex = 7;
            this.lblsttime.Text = "Start time :";
            this.lblsttime.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(224, 221);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "hour(s)";
            // 
            // runevery
            // 
            this.runevery.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.runevery.Enabled = false;
            this.runevery.Location = new System.Drawing.Point(118, 218);
            this.runevery.Name = "runevery";
            this.runevery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.runevery.Size = new System.Drawing.Size(100, 20);
            this.runevery.TabIndex = 3;
            // 
            // lblrunevery
            // 
            this.lblrunevery.Location = new System.Drawing.Point(42, 224);
            this.lblrunevery.Name = "lblrunevery";
            this.lblrunevery.Size = new System.Drawing.Size(57, 13);
            this.lblrunevery.TabIndex = 4;
            this.lblrunevery.Text = "Run every :";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Enabled = false;
            this.comboBoxEdit1.Location = new System.Drawing.Point(118, 180);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "--Select frequency--",
            "Hours",
            "Daily"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(159, 20);
            this.comboBoxEdit1.TabIndex = 2;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // lblfreq
            // 
            this.lblfreq.Location = new System.Drawing.Point(42, 183);
            this.lblfreq.Name = "lblfreq";
            this.lblfreq.Size = new System.Drawing.Size(58, 13);
            this.lblfreq.TabIndex = 2;
            this.lblfreq.Text = "Frequency :";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(21, 68);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Automatically"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Manually"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("3", "By Schedule")});
            this.radioGroup1.Size = new System.Drawing.Size(91, 92);
            this.radioGroup1.TabIndex = 1;
            this.radioGroup1.EditValueChanged += new System.EventHandler(this.radioGroup1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(269, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Run Mode";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.Save16;
            this.simpleButton1.Location = new System.Drawing.Point(230, 377);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 30);
            this.simpleButton1.TabIndex = 62;
            this.simpleButton1.Text = "&Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.Delete16;
            this.simpleButton2.Location = new System.Drawing.Point(320, 377);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(84, 30);
            this.simpleButton2.TabIndex = 61;
            this.simpleButton2.Text = "Close";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 421);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxdisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runevery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControl1;
        private GroupControl groupControl2;
        private RadioGroup radioGroup1;
        private LabelControl labelControl1;
        private LabelControl lblfreq;
        private ComboBoxEdit comboBoxEdit1;
        private LabelControl lblrunevery;
        private LabelControl lblsttime;
        private LabelControl labelControl4;
        private SpinEdit runevery;
        private TimeEdit timeedit;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private CheckEdit c8;
        private CheckEdit c7;
        private CheckEdit c6;
        private CheckEdit c5;
        private CheckEdit c4;
        private CheckEdit c3;
        private CheckEdit c2;
        private CheckEdit c1;
        private LabelControl lblmaxdisc;
        private TextEdit maxdisc;
    }
}