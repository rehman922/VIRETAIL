using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Store
{
    partial class DailyClosing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyClosing));
            this.txtcash = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtcashtrans = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtclosing = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txttotalcash = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.txtlastclosing = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtcashdiff = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtcash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcashtrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtclosing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotalcash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlastclosing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcashdiff.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcash
            // 
            this.txtcash.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcash.EnterMoveNextControl = true;
            this.txtcash.Location = new System.Drawing.Point(379, 34);
            this.txtcash.Name = "txtcash";
            this.txtcash.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtcash.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcash.Properties.Appearance.Options.UseBackColor = true;
            this.txtcash.Properties.Appearance.Options.UseFont = true;
            this.txtcash.Properties.Appearance.Options.UseForeColor = true;
            this.txtcash.Properties.Appearance.Options.UseTextOptions = true;
            this.txtcash.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcash.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcash.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcash.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtcash.Properties.ReadOnly = true;
            this.txtcash.Size = new System.Drawing.Size(119, 30);
            this.txtcash.TabIndex = 2;
            this.txtcash.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Location = new System.Drawing.Point(307, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 14);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Sale Cash :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(555, 15);
            this.labelControl1.TabIndex = 48;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(34, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 14);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Cash transferred :";
            // 
            // txtcashtrans
            // 
            this.txtcashtrans.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcashtrans.EnterMoveNextControl = true;
            this.txtcashtrans.Location = new System.Drawing.Point(156, 84);
            this.txtcashtrans.Name = "txtcashtrans";
            this.txtcashtrans.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtcashtrans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashtrans.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcashtrans.Properties.Appearance.Options.UseBackColor = true;
            this.txtcashtrans.Properties.Appearance.Options.UseFont = true;
            this.txtcashtrans.Properties.Appearance.Options.UseForeColor = true;
            this.txtcashtrans.Properties.Appearance.Options.UseTextOptions = true;
            this.txtcashtrans.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcashtrans.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcashtrans.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightYellow;
            this.txtcashtrans.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashtrans.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtcashtrans.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtcashtrans.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtcashtrans.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcashtrans.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcashtrans.Properties.DisplayFormat.FormatString = "N2";
            this.txtcashtrans.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcashtrans.Properties.EditFormat.FormatString = "N2";
            this.txtcashtrans.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcashtrans.Properties.Mask.BeepOnError = true;
            this.txtcashtrans.Properties.Mask.EditMask = "n2";
            this.txtcashtrans.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtcashtrans.Properties.NullText = "0";
            this.txtcashtrans.Size = new System.Drawing.Size(119, 30);
            this.txtcashtrans.TabIndex = 0;
            this.txtcashtrans.EditValueChanged += new System.EventHandler(this.txtcashtrans_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(556, 19);
            this.labelControl4.TabIndex = 51;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(70, 31);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Properties.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm:ss tt";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.EditFormat.FormatString = "dd-MM-yyyy hh:mm:ss tt";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Size = new System.Drawing.Size(171, 22);
            this.dateEdit1.TabIndex = 2;
            // 
            // txtclosing
            // 
            this.txtclosing.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtclosing.EnterMoveNextControl = true;
            this.txtclosing.Location = new System.Drawing.Point(71, 58);
            this.txtclosing.Name = "txtclosing";
            this.txtclosing.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtclosing.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclosing.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtclosing.Properties.Appearance.Options.UseBackColor = true;
            this.txtclosing.Properties.Appearance.Options.UseFont = true;
            this.txtclosing.Properties.Appearance.Options.UseForeColor = true;
            this.txtclosing.Properties.Appearance.Options.UseTextOptions = true;
            this.txtclosing.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtclosing.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtclosing.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightYellow;
            this.txtclosing.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclosing.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtclosing.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtclosing.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtclosing.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtclosing.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtclosing.Properties.DisplayFormat.FormatString = "N2";
            this.txtclosing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtclosing.Properties.EditFormat.FormatString = "N2";
            this.txtclosing.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtclosing.Properties.Mask.BeepOnError = true;
            this.txtclosing.Properties.Mask.EditMask = "n2";
            this.txtclosing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtclosing.Properties.NullText = "0";
            this.txtclosing.Properties.ReadOnly = true;
            this.txtclosing.Size = new System.Drawing.Size(170, 30);
            this.txtclosing.TabIndex = 55;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Location = new System.Drawing.Point(34, 44);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 14);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "Cash on hand :";
            // 
            // txttotalcash
            // 
            this.txttotalcash.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txttotalcash.EnterMoveNextControl = true;
            this.txttotalcash.Location = new System.Drawing.Point(156, 34);
            this.txttotalcash.Name = "txttotalcash";
            this.txttotalcash.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txttotalcash.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcash.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txttotalcash.Properties.Appearance.Options.UseBackColor = true;
            this.txttotalcash.Properties.Appearance.Options.UseFont = true;
            this.txttotalcash.Properties.Appearance.Options.UseForeColor = true;
            this.txttotalcash.Properties.Appearance.Options.UseTextOptions = true;
            this.txttotalcash.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txttotalcash.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txttotalcash.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttotalcash.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcash.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txttotalcash.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txttotalcash.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txttotalcash.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txttotalcash.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txttotalcash.Properties.DisplayFormat.FormatString = "N2";
            this.txttotalcash.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txttotalcash.Properties.EditFormat.FormatString = "N2";
            this.txttotalcash.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txttotalcash.Properties.Mask.BeepOnError = true;
            this.txttotalcash.Properties.Mask.EditMask = "n2";
            this.txttotalcash.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txttotalcash.Properties.NullText = "0";
            this.txttotalcash.Properties.ReadOnly = true;
            this.txttotalcash.Size = new System.Drawing.Size(119, 30);
            this.txttotalcash.TabIndex = 59;
            this.txttotalcash.TabStop = false;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(74, 31);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(173, 22);
            this.dateEdit2.TabIndex = 62;
            // 
            // txtlastclosing
            // 
            this.txtlastclosing.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtlastclosing.EnterMoveNextControl = true;
            this.txtlastclosing.Location = new System.Drawing.Point(74, 58);
            this.txtlastclosing.Name = "txtlastclosing";
            this.txtlastclosing.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtlastclosing.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastclosing.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtlastclosing.Properties.Appearance.Options.UseBackColor = true;
            this.txtlastclosing.Properties.Appearance.Options.UseFont = true;
            this.txtlastclosing.Properties.Appearance.Options.UseForeColor = true;
            this.txtlastclosing.Properties.Appearance.Options.UseTextOptions = true;
            this.txtlastclosing.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtlastclosing.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtlastclosing.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightYellow;
            this.txtlastclosing.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastclosing.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtlastclosing.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtlastclosing.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtlastclosing.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtlastclosing.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtlastclosing.Properties.DisplayFormat.FormatString = "N2";
            this.txtlastclosing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtlastclosing.Properties.EditFormat.FormatString = "N2";
            this.txtlastclosing.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtlastclosing.Properties.Mask.BeepOnError = true;
            this.txtlastclosing.Properties.Mask.EditMask = "n2";
            this.txtlastclosing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtlastclosing.Properties.NullText = "0";
            this.txtlastclosing.Properties.ReadOnly = true;
            this.txtlastclosing.Size = new System.Drawing.Size(173, 30);
            this.txtlastclosing.TabIndex = 63;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.dateEdit1);
            this.groupControl1.Controls.Add(this.txtclosing);
            this.groupControl1.Location = new System.Drawing.Point(34, 140);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(254, 93);
            this.groupControl1.TabIndex = 65;
            this.groupControl1.Text = "Closing";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Location = new System.Drawing.Point(5, 63);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(60, 16);
            this.labelControl12.TabIndex = 57;
            this.labelControl12.Text = "Amount :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.Location = new System.Drawing.Point(5, 35);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(40, 16);
            this.labelControl11.TabIndex = 56;
            this.labelControl11.Text = "Date :";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtlastclosing);
            this.groupControl2.Controls.Add(this.dateEdit2);
            this.groupControl2.Location = new System.Drawing.Point(307, 140);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(254, 93);
            this.groupControl2.TabIndex = 66;
            this.groupControl2.Text = "Last Closing";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Location = new System.Drawing.Point(5, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 16);
            this.labelControl6.TabIndex = 65;
            this.labelControl6.Text = "Amount :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Location = new System.Drawing.Point(5, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 16);
            this.labelControl5.TabIndex = 64;
            this.labelControl5.Text = "Date :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Location = new System.Drawing.Point(310, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 14);
            this.labelControl7.TabIndex = 67;
            this.labelControl7.Text = "Cash Diff :";
            // 
            // txtcashdiff
            // 
            this.txtcashdiff.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcashdiff.EnterMoveNextControl = true;
            this.txtcashdiff.Location = new System.Drawing.Point(379, 85);
            this.txtcashdiff.Name = "txtcashdiff";
            this.txtcashdiff.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtcashdiff.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashdiff.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcashdiff.Properties.Appearance.Options.UseBackColor = true;
            this.txtcashdiff.Properties.Appearance.Options.UseFont = true;
            this.txtcashdiff.Properties.Appearance.Options.UseForeColor = true;
            this.txtcashdiff.Properties.Appearance.Options.UseTextOptions = true;
            this.txtcashdiff.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcashdiff.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcashdiff.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightCoral;
            this.txtcashdiff.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashdiff.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtcashdiff.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtcashdiff.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtcashdiff.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtcashdiff.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtcashdiff.Properties.DisplayFormat.FormatString = "N2";
            this.txtcashdiff.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcashdiff.Properties.EditFormat.FormatString = "N2";
            this.txtcashdiff.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtcashdiff.Properties.Mask.BeepOnError = true;
            this.txtcashdiff.Properties.Mask.EditMask = "n2";
            this.txtcashdiff.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtcashdiff.Properties.NullText = "0";
            this.txtcashdiff.Size = new System.Drawing.Size(119, 30);
            this.txtcashdiff.TabIndex = 1;
            this.txtcashdiff.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.Delete16;
            this.simpleButton2.Location = new System.Drawing.Point(283, 248);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(104, 32);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "ESC - Close";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.OK16;
            this.simpleButton1.Location = new System.Drawing.Point(173, 248);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 32);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "F4 - Close Sale";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DailyClosing
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 292);
            this.Controls.Add(this.txtcashdiff);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txttotalcash);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtcashtrans);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtcash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DailyClosing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of sales - End of day process ";
            this.Load += new System.EventHandler(this.DailyClosing_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DailyClosing_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtcash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcashtrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtclosing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotalcash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlastclosing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcashdiff.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit txtcash;
        private LabelControl labelControl3;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private TextEdit txtcashtrans;
        private LabelControl labelControl4;
        private DateEdit dateEdit1;
        private TextEdit txtclosing;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private LabelControl labelControl8;
        private TextEdit txttotalcash;
        private DateEdit dateEdit2;
        private TextEdit txtlastclosing;
        private GroupControl groupControl1;
        private LabelControl labelControl12;
        private LabelControl labelControl11;
        private GroupControl groupControl2;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private LabelControl labelControl7;
        private TextEdit txtcashdiff;
    }
}