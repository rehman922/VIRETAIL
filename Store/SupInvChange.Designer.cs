using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Store
{
    partial class SupInvChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupInvChange));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtinvno = new DevExpress.XtraEditors.TextEdit();
            this.invdate = new DevExpress.XtraEditors.DateEdit();
            this.txtduedays = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtinvamt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.looksupid = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtinvno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtduedays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinvamt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.looksupid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(16, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "New Supplier Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(16, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Invoice Amount :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(16, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 14);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Invoice Date:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(16, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 14);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Due Days :";
            // 
            // txtinvno
            // 
            this.txtinvno.Location = new System.Drawing.Point(135, 96);
            this.txtinvno.Name = "txtinvno";
            this.txtinvno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvno.Properties.Appearance.Options.UseFont = true;
            this.txtinvno.Size = new System.Drawing.Size(108, 20);
            this.txtinvno.TabIndex = 5;
            // 
            // invdate
            // 
            this.invdate.EditValue = null;
            this.invdate.Location = new System.Drawing.Point(135, 128);
            this.invdate.Name = "invdate";
            this.invdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invdate.Properties.Appearance.Options.UseFont = true;
            this.invdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.invdate.Size = new System.Drawing.Size(108, 20);
            this.invdate.TabIndex = 6;
            // 
            // txtduedays
            // 
            this.txtduedays.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtduedays.Location = new System.Drawing.Point(135, 157);
            this.txtduedays.Name = "txtduedays";
            this.txtduedays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduedays.Properties.Appearance.Options.UseFont = true;
            this.txtduedays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtduedays.Size = new System.Drawing.Size(108, 20);
            this.txtduedays.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(16, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 14);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Supplier Name :";
            // 
            // txtinvamt
            // 
            this.txtinvamt.Enabled = false;
            this.txtinvamt.Location = new System.Drawing.Point(135, 67);
            this.txtinvamt.Name = "txtinvamt";
            this.txtinvamt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvamt.Properties.Appearance.Options.UseFont = true;
            this.txtinvamt.Size = new System.Drawing.Size(108, 20);
            this.txtinvamt.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(16, 99);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 14);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Invoice No. :";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpEdit2.Enabled = false;
            this.lookUpEdit2.EnterMoveNextControl = true;
            this.lookUpEdit2.Location = new System.Drawing.Point(135, 10);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.lookUpEdit2.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNAME", "SUPPLIERNAME", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUEDAYS", "DUEDAYS", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEdit2.Properties.DisplayMember = "SUPPLIERNAME";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.ShowHeader = false;
            this.lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit2.Properties.ValueMember = "SUPPLIERNO";
            this.lookUpEdit2.Size = new System.Drawing.Size(372, 20);
            this.lookUpEdit2.TabIndex = 15;
            // 
            // looksupid
            // 
            this.looksupid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.looksupid.EnterMoveNextControl = true;
            this.looksupid.Location = new System.Drawing.Point(135, 39);
            this.looksupid.Name = "looksupid";
            this.looksupid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.looksupid.Properties.Appearance.Options.UseFont = true;
            this.looksupid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.looksupid.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNAME", "SUPPLIERNAME", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUEDAYS", "DUEDAYS", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.looksupid.Properties.DisplayMember = "SUPPLIERNAME";
            this.looksupid.Properties.NullText = "";
            this.looksupid.Properties.ShowHeader = false;
            this.looksupid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.looksupid.Properties.ValueMember = "SUPPLIERNO";
            this.looksupid.Size = new System.Drawing.Size(372, 20);
            this.looksupid.TabIndex = 16;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = global::Store.Properties.Resources.page_white_save16;
            this.simpleButton1.Location = new System.Drawing.Point(221, 198);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(78, 25);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Update";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SupInvChange
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 235);
            this.Controls.Add(this.looksupid);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.txtinvamt);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtduedays);
            this.Controls.Add(this.invdate);
            this.Controls.Add(this.txtinvno);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SupInvChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Purchase Invoice Details";
            this.Load += new System.EventHandler(this.SupInvChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtinvno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtduedays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinvamt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.looksupid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private TextEdit txtinvno;
        private DateEdit invdate;
        private SpinEdit txtduedays;
        private SimpleButton simpleButton1;
        private LabelControl labelControl5;
        private TextEdit txtinvamt;
        private LabelControl labelControl6;
        protected LookUpEdit lookUpEdit2;
        protected LookUpEdit looksupid;
    }
}