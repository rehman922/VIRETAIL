using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraWaitForm;

namespace Store
{
    partial class FetchData
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.c1Shipping = new DevExpress.XtraEditors.LookUpEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.c1Payment = new DevExpress.XtraEditors.LookUpEdit();
            this.c1Grouping = new DevExpress.XtraEditors.LookUpEdit();
            this.duedays = new DevExpress.XtraEditors.TextEdit();
            this.creditlimit = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.c1Terms = new DevExpress.XtraEditors.LookUpEdit();
            this.c1Expense = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.label12 = new System.Windows.Forms.Label();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Shipping.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Payment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Grouping.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditlimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Terms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Expense.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data Path (Stock):";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(130, 13);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(332, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(131, 56);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(331, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data Path (Item mast) :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(219, 100);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 27);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Start Updating";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(468, 53);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(71, 24);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Stock File";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(468, 10);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(71, 24);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Item Mast";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Count :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.ImageHorzOffset = 20;
            this.progressPanel1.Location = new System.Drawing.Point(167, 135);
            this.progressPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(246, 39);
            this.progressPanel1.TabIndex = 12;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(442, 100);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(97, 24);
            this.simpleButton4.TabIndex = 13;
            this.simpleButton4.Text = "Update Avg Cost";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.c1Shipping);
            this.xtraTabPage2.Controls.Add(this.label17);
            this.xtraTabPage2.Controls.Add(this.c1Payment);
            this.xtraTabPage2.Controls.Add(this.c1Grouping);
            this.xtraTabPage2.Controls.Add(this.duedays);
            this.xtraTabPage2.Controls.Add(this.creditlimit);
            this.xtraTabPage2.Controls.Add(this.label14);
            this.xtraTabPage2.Controls.Add(this.c1Terms);
            this.xtraTabPage2.Controls.Add(this.c1Expense);
            this.xtraTabPage2.Controls.Add(this.labelControl10);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.label12);
            this.xtraTabPage2.Controls.Add(this.labelControl12);
            this.xtraTabPage2.Controls.Add(this.label13);
            this.xtraTabPage2.Controls.Add(this.label16);
            this.xtraTabPage2.Controls.Add(this.label15);
            this.xtraTabPage2.Controls.Add(this.label18);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(918, 433);
            // 
            // c1Shipping
            // 
            this.c1Shipping.Location = new System.Drawing.Point(146, 258);
            this.c1Shipping.Name = "c1Shipping";
            this.c1Shipping.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Shipping.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHIPID", "SHIPID", 57, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHIPTYPE", "SHIPTYPE", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SE", "SE", 22, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.c1Shipping.Properties.DisplayMember = "SHIPTYPE";
            this.c1Shipping.Properties.NullText = "";
            this.c1Shipping.Properties.ShowHeader = false;
            this.c1Shipping.Properties.ValueMember = "SHIPID";
            this.c1Shipping.Size = new System.Drawing.Size(255, 20);
            this.c1Shipping.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(31, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 36);
            this.label17.TabIndex = 145;
            // 
            // c1Payment
            // 
            this.c1Payment.Location = new System.Drawing.Point(146, 227);
            this.c1Payment.Name = "c1Payment";
            this.c1Payment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Payment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYTYPE", "PAYTYPE", 66, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYNAME", "PAYNAME", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.c1Payment.Properties.DisplayMember = "PAYNAME";
            this.c1Payment.Properties.NullText = "";
            this.c1Payment.Properties.ShowHeader = false;
            this.c1Payment.Properties.ValueMember = "PAYTYPE";
            this.c1Payment.Size = new System.Drawing.Size(255, 20);
            this.c1Payment.TabIndex = 4;
            // 
            // c1Grouping
            // 
            this.c1Grouping.Location = new System.Drawing.Point(629, 53);
            this.c1Grouping.Name = "c1Grouping";
            this.c1Grouping.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Grouping.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPNAME", "GROUPNAME", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSSUP", "CUSSUP", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.c1Grouping.Properties.DisplayMember = "GROUPNAME";
            this.c1Grouping.Properties.NullText = "";
            this.c1Grouping.Properties.ShowHeader = false;
            this.c1Grouping.Properties.ValueMember = "GROUPID";
            this.c1Grouping.Size = new System.Drawing.Size(255, 20);
            this.c1Grouping.TabIndex = 6;
            // 
            // duedays
            // 
            this.duedays.EditValue = "30";
            this.duedays.Location = new System.Drawing.Point(146, 196);
            this.duedays.Name = "duedays";
            this.duedays.Properties.Mask.EditMask = "f0";
            this.duedays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.duedays.Properties.MaxLength = 3;
            this.duedays.Size = new System.Drawing.Size(255, 20);
            this.duedays.TabIndex = 3;
            // 
            // creditlimit
            // 
            this.creditlimit.Location = new System.Drawing.Point(146, 134);
            this.creditlimit.Name = "creditlimit";
            this.creditlimit.Properties.Mask.EditMask = "n";
            this.creditlimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.creditlimit.Size = new System.Drawing.Size(255, 20);
            this.creditlimit.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(559, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 14);
            this.label14.TabIndex = 139;
            // 
            // c1Terms
            // 
            this.c1Terms.Location = new System.Drawing.Point(146, 165);
            this.c1Terms.Name = "c1Terms";
            this.c1Terms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Terms.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TERMCODE", "TERMCODE", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYNAME", "PAYNAME", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.c1Terms.Properties.DisplayMember = "PAYNAME";
            this.c1Terms.Properties.NullText = "";
            this.c1Terms.Properties.ShowHeader = false;
            this.c1Terms.Properties.ValueMember = "TERMCODE";
            this.c1Terms.Size = new System.Drawing.Size(255, 20);
            this.c1Terms.TabIndex = 2;
            // 
            // c1Expense
            // 
            this.c1Expense.Location = new System.Drawing.Point(146, 54);
            this.c1Expense.Name = "c1Expense";
            this.c1Expense.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.c1Expense.Properties.NullText = "";
            this.c1Expense.Properties.ShowHeader = false;
            this.c1Expense.Size = new System.Drawing.Size(255, 20);
            this.c1Expense.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.LineColor = System.Drawing.Color.Silver;
            this.labelControl10.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl10.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl10.LineVisible = true;
            this.labelControl10.Location = new System.Drawing.Point(547, 17);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(350, 20);
            this.labelControl10.TabIndex = 135;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.LineColor = System.Drawing.Color.Silver;
            this.labelControl11.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl11.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl11.LineVisible = true;
            this.labelControl11.Location = new System.Drawing.Point(24, 97);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(377, 20);
            this.labelControl11.TabIndex = 134;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 14);
            this.label12.TabIndex = 133;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.LineColor = System.Drawing.Color.Silver;
            this.labelControl12.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl12.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl12.LineVisible = true;
            this.labelControl12.Location = new System.Drawing.Point(24, 17);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(377, 20);
            this.labelControl12.TabIndex = 132;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 14);
            this.label13.TabIndex = 131;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 14);
            this.label16.TabIndex = 130;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 32);
            this.label15.TabIndex = 129;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(31, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 14);
            this.label18.TabIndex = 128;
            // 
            // FetchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 194);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FetchData";
            this.Text = "Fetch Data";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Shipping.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Payment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Grouping.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditlimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Terms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Expense.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private TextEdit textEdit1;
        private TextEdit textEdit2;
        private LabelControl labelControl2;
        private SimpleButton simpleButton1;
        private OpenFileDialog openFileDialog1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton3;
        private LabelControl labelControl3;
        private Label label1;
        private ProgressPanel progressPanel1;
        private SimpleButton simpleButton4;
        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;
        private LookUpEdit c1Shipping;
        private Label label17;
        private LookUpEdit c1Payment;
        private LookUpEdit c1Grouping;
        private TextEdit duedays;
        private TextEdit creditlimit;
        private Label label14;
        private LookUpEdit c1Terms;
        private LookUpEdit c1Expense;
        private LabelControl labelControl10;
        private LabelControl labelControl11;
        private Label label12;
        private LabelControl labelControl12;
        private Label label13;
        private Label label16;
        private Label label15;
        private Label label18;
    }
}