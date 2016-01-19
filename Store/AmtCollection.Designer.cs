using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Store
{
    partial class AmtCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmtCollection));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblbalance = new DevExpress.XtraEditors.LabelControl();
            this.txtcard1 = new DevExpress.XtraEditors.TextEdit();
            this.txtcash = new DevExpress.XtraEditors.TextEdit();
            this.txtcredit = new DevExpress.XtraEditors.TextEdit();
            this.txtspan = new DevExpress.XtraEditors.TextEdit();
            this.txtaccount = new DevExpress.XtraEditors.TextEdit();
            this.txtrounding = new DevExpress.XtraEditors.TextEdit();
            this.lblcash = new DevExpress.XtraEditors.LabelControl();
            this.lblcardno = new DevExpress.XtraEditors.LabelControl();
            this.txtnetamt = new DevExpress.XtraEditors.TextEdit();
            this.txtbal = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblspan = new DevExpress.XtraEditors.LabelControl();
            this.lblaccount = new DevExpress.XtraEditors.LabelControl();
            this.lblcreditcard = new DevExpress.XtraEditors.LabelControl();
            this.btnok = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtcard1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtspan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrounding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnetamt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbal.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(109, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(179, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Invoice Amount :";
            // 
            // lblbalance
            // 
            this.lblbalance.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblbalance.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblbalance.Location = new System.Drawing.Point(109, 333);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(169, 25);
            this.lblbalance.TabIndex = 18;
            this.lblbalance.Text = "Balance to Pay :";
            this.lblbalance.Visible = false;
            // 
            // txtcard1
            // 
            this.txtcard1.Location = new System.Drawing.Point(487, 96);
            this.txtcard1.Name = "txtcard1";
            this.txtcard1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcard1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcard1.Properties.Appearance.Options.UseFont = true;
            this.txtcard1.Properties.Appearance.Options.UseForeColor = true;
            this.txtcard1.Properties.MaxLength = 4;
            this.txtcard1.Size = new System.Drawing.Size(100, 46);
            this.txtcard1.TabIndex = 3;
            this.txtcard1.Visible = false;
            this.txtcard1.Enter += new System.EventHandler(this.txtcard1_Enter);
            this.txtcard1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcash_KeyDown);
            // 
            // txtcash
            // 
            this.txtcash.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcash.Location = new System.Drawing.Point(294, 97);
            this.txtcash.Name = "txtcash";
            this.txtcash.Properties.AllowMouseWheel = false;
            this.txtcash.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.txtcash.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcash.Properties.Appearance.Options.UseBackColor = true;
            this.txtcash.Properties.Appearance.Options.UseFont = true;
            this.txtcash.Properties.Appearance.Options.UseForeColor = true;
            this.txtcash.Properties.Appearance.Options.UseTextOptions = true;
            this.txtcash.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcash.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcash.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightYellow;
            this.txtcash.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtcash.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtcash.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtcash.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcash.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcash.Properties.DisplayFormat.FormatString = "N2";
            this.txtcash.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcash.Properties.EditFormat.FormatString = "N2";
            this.txtcash.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcash.Properties.Mask.BeepOnError = true;
            this.txtcash.Properties.Mask.EditMask = "n2";
            this.txtcash.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtcash.Properties.NullText = "0";
            this.txtcash.Size = new System.Drawing.Size(179, 46);
            this.txtcash.TabIndex = 0;
            this.txtcash.EditValueChanged += new System.EventHandler(this.txtcash_EditValueChanged);
            this.txtcash.Enter += new System.EventHandler(this.txtcash_Enter);
            this.txtcash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcash_KeyDown);
            // 
            // txtcredit
            // 
            this.txtcredit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcredit.Location = new System.Drawing.Point(293, 205);
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.txtcredit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcredit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcredit.Properties.Appearance.Options.UseBackColor = true;
            this.txtcredit.Properties.Appearance.Options.UseFont = true;
            this.txtcredit.Properties.Appearance.Options.UseForeColor = true;
            this.txtcredit.Properties.Appearance.Options.UseTextOptions = true;
            this.txtcredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcredit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcredit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Yellow;
            this.txtcredit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcredit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtcredit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtcredit.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtcredit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcredit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcredit.Properties.DisplayFormat.FormatString = "N2";
            this.txtcredit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcredit.Properties.EditFormat.FormatString = "N2";
            this.txtcredit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcredit.Properties.Mask.EditMask = "n2";
            this.txtcredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtcredit.Properties.NullText = "0";
            this.txtcredit.Size = new System.Drawing.Size(180, 46);
            this.txtcredit.TabIndex = 2;
            this.txtcredit.Visible = false;
            this.txtcredit.EditValueChanged += new System.EventHandler(this.txtcash_EditValueChanged);
            this.txtcredit.Enter += new System.EventHandler(this.txtcredit_Enter);
            this.txtcredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcash_KeyDown);
            // 
            // txtspan
            // 
            this.txtspan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtspan.Location = new System.Drawing.Point(293, 151);
            this.txtspan.Name = "txtspan";
            this.txtspan.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.txtspan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtspan.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtspan.Properties.Appearance.Options.UseBackColor = true;
            this.txtspan.Properties.Appearance.Options.UseFont = true;
            this.txtspan.Properties.Appearance.Options.UseForeColor = true;
            this.txtspan.Properties.Appearance.Options.UseTextOptions = true;
            this.txtspan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtspan.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtspan.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Yellow;
            this.txtspan.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtspan.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtspan.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtspan.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtspan.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtspan.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtspan.Properties.DisplayFormat.FormatString = "N2";
            this.txtspan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtspan.Properties.EditFormat.FormatString = "N2";
            this.txtspan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtspan.Properties.Mask.EditMask = "n2";
            this.txtspan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtspan.Properties.NullText = "0";
            this.txtspan.Size = new System.Drawing.Size(180, 46);
            this.txtspan.TabIndex = 1;
            this.txtspan.Visible = false;
            this.txtspan.EditValueChanged += new System.EventHandler(this.txtcash_EditValueChanged);
            this.txtspan.Enter += new System.EventHandler(this.txtspan_Enter);
            this.txtspan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcash_KeyDown);
            // 
            // txtaccount
            // 
            this.txtaccount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtaccount.Location = new System.Drawing.Point(293, 259);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.txtaccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtaccount.Properties.Appearance.Options.UseBackColor = true;
            this.txtaccount.Properties.Appearance.Options.UseFont = true;
            this.txtaccount.Properties.Appearance.Options.UseForeColor = true;
            this.txtaccount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtaccount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtaccount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtaccount.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Yellow;
            this.txtaccount.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtaccount.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtaccount.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtaccount.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtaccount.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtaccount.Properties.DisplayFormat.FormatString = "N2";
            this.txtaccount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtaccount.Properties.EditFormat.FormatString = "N2";
            this.txtaccount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtaccount.Properties.Mask.EditMask = "n2";
            this.txtaccount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtaccount.Properties.NullText = "0";
            this.txtaccount.Size = new System.Drawing.Size(180, 46);
            this.txtaccount.TabIndex = 4;
            this.txtaccount.Visible = false;
            this.txtaccount.EditValueChanged += new System.EventHandler(this.txtcash_EditValueChanged);
            this.txtaccount.Enter += new System.EventHandler(this.txtaccount_Enter);
            this.txtaccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcash_KeyDown);
            // 
            // txtrounding
            // 
            this.txtrounding.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtrounding.Location = new System.Drawing.Point(500, 12);
            this.txtrounding.Name = "txtrounding";
            this.txtrounding.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtrounding.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrounding.Properties.Appearance.Options.UseBackColor = true;
            this.txtrounding.Properties.Appearance.Options.UseFont = true;
            this.txtrounding.Properties.Appearance.Options.UseTextOptions = true;
            this.txtrounding.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtrounding.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtrounding.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightYellow;
            this.txtrounding.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrounding.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtrounding.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtrounding.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtrounding.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtrounding.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtrounding.Properties.DisplayFormat.FormatString = "N2";
            this.txtrounding.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtrounding.Properties.EditFormat.FormatString = "N2";
            this.txtrounding.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtrounding.Properties.Mask.EditMask = "n2";
            this.txtrounding.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtrounding.Properties.NullText = "0";
            this.txtrounding.Size = new System.Drawing.Size(127, 32);
            this.txtrounding.TabIndex = 4;
            this.txtrounding.TabStop = false;
            this.txtrounding.Visible = false;
            this.txtrounding.EditValueChanged += new System.EventHandler(this.txtrounding_EditValueChanged);
            this.txtrounding.Enter += new System.EventHandler(this.textEdit4_Enter);
            // 
            // lblcash
            // 
            this.lblcash.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblcash.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblcash.Location = new System.Drawing.Point(109, 104);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(65, 25);
            this.lblcash.TabIndex = 46;
            this.lblcash.Text = "Cash :";
            // 
            // lblcardno
            // 
            this.lblcardno.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblcardno.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcardno.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblcardno.Location = new System.Drawing.Point(497, 71);
            this.lblcardno.Name = "lblcardno";
            this.lblcardno.Size = new System.Drawing.Size(70, 19);
            this.lblcardno.TabIndex = 40;
            this.lblcardno.Text = "Card No ";
            this.lblcardno.Visible = false;
            // 
            // txtnetamt
            // 
            this.txtnetamt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtnetamt.Location = new System.Drawing.Point(294, 30);
            this.txtnetamt.Name = "txtnetamt";
            this.txtnetamt.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtnetamt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Properties.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.txtnetamt.Properties.Appearance.Options.UseBackColor = true;
            this.txtnetamt.Properties.Appearance.Options.UseFont = true;
            this.txtnetamt.Properties.Appearance.Options.UseForeColor = true;
            this.txtnetamt.Properties.Appearance.Options.UseTextOptions = true;
            this.txtnetamt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtnetamt.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtnetamt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightYellow;
            this.txtnetamt.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtnetamt.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtnetamt.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtnetamt.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtnetamt.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtnetamt.Properties.DisplayFormat.FormatString = "N2";
            this.txtnetamt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnetamt.Properties.EditFormat.FormatString = "N2";
            this.txtnetamt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnetamt.Properties.Mask.EditMask = "n2";
            this.txtnetamt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtnetamt.Properties.NullText = "0";
            this.txtnetamt.Size = new System.Drawing.Size(179, 46);
            this.txtnetamt.TabIndex = 59;
            this.txtnetamt.TabStop = false;
            // 
            // txtbal
            // 
            this.txtbal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtbal.Location = new System.Drawing.Point(293, 325);
            this.txtbal.Name = "txtbal";
            this.txtbal.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtbal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbal.Properties.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.txtbal.Properties.Appearance.Options.UseBackColor = true;
            this.txtbal.Properties.Appearance.Options.UseFont = true;
            this.txtbal.Properties.Appearance.Options.UseForeColor = true;
            this.txtbal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtbal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtbal.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtbal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightYellow;
            this.txtbal.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtbal.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtbal.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtbal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtbal.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtbal.Properties.DisplayFormat.FormatString = "N2";
            this.txtbal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtbal.Properties.EditFormat.FormatString = "N2";
            this.txtbal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtbal.Properties.Mask.EditMask = "n2";
            this.txtbal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtbal.Properties.NullText = "0";
            this.txtbal.Size = new System.Drawing.Size(180, 46);
            this.txtbal.TabIndex = 60;
            this.txtbal.TabStop = false;
            this.txtbal.Visible = false;
            this.txtbal.EditValueChanged += new System.EventHandler(this.txtbal_EditValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.simpleButton4);
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Location = new System.Drawing.Point(13, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 60);
            this.panel2.TabIndex = 65;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = global::Store.Properties.Resources.editclear;
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton4.Location = new System.Drawing.Point(463, 9);
            this.simpleButton4.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(145, 43);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Clear - F3";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton3.Image = global::Store.Properties.Resources.goback;
            this.simpleButton3.Location = new System.Drawing.Point(315, 9);
            this.simpleButton3.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(145, 43);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "ESC - Back to receipt";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton2.Image = global::Store.Properties.Resources.printer;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton2.Location = new System.Drawing.Point(156, 9);
            this.simpleButton2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(153, 43);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "F4 - Take Payment and print invoice";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = global::Store.Properties.Resources.payment;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(7, 9);
            this.simpleButton1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 43);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "F9 -Take Payment";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblspan
            // 
            this.lblspan.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblspan.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspan.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblspan.Location = new System.Drawing.Point(109, 163);
            this.lblspan.Name = "lblspan";
            this.lblspan.Size = new System.Drawing.Size(115, 25);
            this.lblspan.TabIndex = 66;
            this.lblspan.Text = "Span Card:";
            this.lblspan.Visible = false;
            // 
            // lblaccount
            // 
            this.lblaccount.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblaccount.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccount.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblaccount.Location = new System.Drawing.Point(109, 275);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(71, 25);
            this.lblaccount.TabIndex = 67;
            this.lblaccount.Text = "Credit:";
            this.lblaccount.Visible = false;
            // 
            // lblcreditcard
            // 
            this.lblcreditcard.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblcreditcard.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreditcard.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblcreditcard.Location = new System.Drawing.Point(109, 219);
            this.lblcreditcard.Name = "lblcreditcard";
            this.lblcreditcard.Size = new System.Drawing.Size(149, 25);
            this.lblcreditcard.TabIndex = 68;
            this.lblcreditcard.Text = "Master / Visa:";
            this.lblcreditcard.Visible = false;
            // 
            // btnok
            // 
            this.btnok.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Appearance.Options.UseFont = true;
            this.btnok.Image = global::Store.Properties.Resources.tick32;
            this.btnok.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnok.Location = new System.Drawing.Point(294, 386);
            this.btnok.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnok.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(145, 43);
            this.btnok.TabIndex = 69;
            this.btnok.Text = "Sale complete";
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // AmtCollection
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblcreditcard);
            this.Controls.Add(this.lblaccount);
            this.Controls.Add(this.lblspan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtbal);
            this.Controls.Add(this.txtnetamt);
            this.Controls.Add(this.lblcardno);
            this.Controls.Add(this.lblcash);
            this.Controls.Add(this.txtrounding);
            this.Controls.Add(this.txtaccount);
            this.Controls.Add(this.txtspan);
            this.Controls.Add(this.txtcredit);
            this.Controls.Add(this.txtcash);
            this.Controls.Add(this.txtcard1);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Sharp Plus";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AmtCollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Payment";
            this.Load += new System.EventHandler(this.AmtCollection_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AmtCollection_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtcard1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtspan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrounding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnetamt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbal.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private LabelControl lblbalance;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton3;
        private TextEdit txtcard1;
        private SimpleButton simpleButton4;
        private TextEdit txtcash;
        private TextEdit txtcredit;
        private TextEdit txtspan;
        private TextEdit txtaccount;
        private TextEdit txtrounding;
        private LabelControl lblcash;
        private LabelControl lblcardno;
        private TextEdit txtnetamt;
        private TextEdit txtbal;
        private Panel panel2;
        private LabelControl lblspan;
        private LabelControl lblaccount;
        private LabelControl lblcreditcard;
        private SimpleButton btnok;
    }
}