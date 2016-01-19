using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class CustomerPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtbalance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtappliedamt = new DevExpress.XtraEditors.TextEdit();
            this.txtoutstanding = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookupcustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelcards = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.aPARMAINBindingSource = new System.Windows.Forms.BindingSource();
            this.ledgers1 = new VIRETAILENTITIES.Ledgers();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRANID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVOUCHERNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAIDAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBALANCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBINID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOURCEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISCOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtappliedamt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtoutstanding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupcustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.panelcards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPARMAINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textEdit3);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.txtbalance);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtappliedamt);
            this.panel1.Controls.Add(this.txtoutstanding);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lookupcustomer);
            this.panel1.Controls.Add(this.labelControl13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 56);
            this.panel1.TabIndex = 0;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(702, 6);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(113, 20);
            this.textEdit3.TabIndex = 56;
            this.textEdit3.TabStop = false;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(534, 6);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(114, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // txtbalance
            // 
            this.txtbalance.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtbalance.Location = new System.Drawing.Point(323, 32);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtbalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtbalance.Properties.Appearance.Options.UseBackColor = true;
            this.txtbalance.Properties.Appearance.Options.UseFont = true;
            this.txtbalance.Properties.Appearance.Options.UseForeColor = true;
            this.txtbalance.Properties.Appearance.Options.UseTextOptions = true;
            this.txtbalance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtbalance.Properties.DisplayFormat.FormatString = "n2";
            this.txtbalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtbalance.Properties.EditFormat.FormatString = "n2";
            this.txtbalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtbalance.Properties.Mask.EditMask = "n2";
            this.txtbalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtbalance.Size = new System.Drawing.Size(113, 20);
            this.txtbalance.TabIndex = 53;
            this.txtbalance.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(268, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 14);
            this.labelControl5.TabIndex = 54;
            this.labelControl5.Text = "Balance :";
            this.labelControl5.Visible = false;
            // 
            // txtappliedamt
            // 
            this.txtappliedamt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtappliedamt.EnterMoveNextControl = true;
            this.txtappliedamt.Location = new System.Drawing.Point(702, 30);
            this.txtappliedamt.Name = "txtappliedamt";
            this.txtappliedamt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtappliedamt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtappliedamt.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtappliedamt.Properties.Appearance.Options.UseBackColor = true;
            this.txtappliedamt.Properties.Appearance.Options.UseFont = true;
            this.txtappliedamt.Properties.Appearance.Options.UseForeColor = true;
            this.txtappliedamt.Properties.Appearance.Options.UseTextOptions = true;
            this.txtappliedamt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtappliedamt.Properties.DisplayFormat.FormatString = "n2";
            this.txtappliedamt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtappliedamt.Properties.EditFormat.FormatString = "n2";
            this.txtappliedamt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtappliedamt.Properties.Mask.EditMask = "n2";
            this.txtappliedamt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtappliedamt.Size = new System.Drawing.Size(113, 20);
            this.txtappliedamt.TabIndex = 1;
            this.txtappliedamt.EditValueChanged += new System.EventHandler(this.txtappliedamt_EditValueChanged);
            this.txtappliedamt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit2_KeyDown);
            this.txtappliedamt.Validated += new System.EventHandler(this.txtappliedamt_Validated);
            // 
            // txtoutstanding
            // 
            this.txtoutstanding.Location = new System.Drawing.Point(92, 30);
            this.txtoutstanding.Name = "txtoutstanding";
            this.txtoutstanding.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoutstanding.Properties.Appearance.Options.UseFont = true;
            this.txtoutstanding.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoutstanding.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtoutstanding.Properties.DisplayFormat.FormatString = "n2";
            this.txtoutstanding.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtoutstanding.Properties.ReadOnly = true;
            this.txtoutstanding.Size = new System.Drawing.Size(127, 20);
            this.txtoutstanding.TabIndex = 53;
            this.txtoutstanding.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(587, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(109, 13);
            this.labelControl4.TabIndex = 52;
            this.labelControl4.Text = "Amount  Received :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(3, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 14);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Out Standing :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(654, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 14);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Doc # :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(494, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 14);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Date :";
            // 
            // lookupcustomer
            // 
            this.lookupcustomer.EnterMoveNextControl = true;
            this.lookupcustomer.Location = new System.Drawing.Point(92, 6);
            this.lookupcustomer.Name = "lookupcustomer";
            this.lookupcustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupcustomer.Properties.Appearance.Options.UseFont = true;
            this.lookupcustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupcustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTNO", "CUSTNO", 64, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMERID", "Customer id", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMERNAME", "Customer Name", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMERTYPE", "CUSTOMERTYPE", 89, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTCOMP", "CUSTCOMP", 65, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PHONE", "PHONE", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mobile", "Mobile", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMAIL", "EMAIL", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOTE", "NOTE", 37, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FIXDISC", "FIXDISC", 50, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FIXDISCAMTPER", "FIXDISCAMTPER", 90, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CREDITLIMIT", "CREDITLIMIT", 74, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("COMPANY", "COMPANY", 59, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BINID", "BINID", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSERID", "CUSERID", 54, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDATE", "CDATE", 43, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EUSERID", "EUSERID", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EDATE", "EDATE", 42, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMERPOINT", "CUSTOMERPOINT", 96, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LASTREDIMINV", "LASTREDIMINV", 83, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYTYPE", "PAYTYPE", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lookupcustomer.Properties.DataSource = this.cUSTOMERBindingSource;
            this.lookupcustomer.Properties.DisplayMember = "CUSTOMERID";
            this.lookupcustomer.Properties.NullText = "";
            this.lookupcustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupcustomer.Properties.ValueMember = "CUSTNO";
            this.lookupcustomer.Size = new System.Drawing.Size(344, 20);
            this.lookupcustomer.TabIndex = 0;
            this.lookupcustomer.EditValueChanged += new System.EventHandler(this.lookupcustomer_EditValueChanged);
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(3, 8);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(83, 14);
            this.labelControl13.TabIndex = 47;
            this.labelControl13.Text = "Customer No. :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelcards);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 70);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Store.Properties.Resources.creditcards;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Store.Properties.Resources.F2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(362, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 62);
            this.button2.TabIndex = 11;
            this.button2.Text = "Card";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Store.Properties.Resources.Cash;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Store.Properties.Resources.F1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(190, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textEdit1);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Location = new System.Drawing.Point(638, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 64);
            this.panel3.TabIndex = 61;
            this.panel3.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Store.Properties.Resources.F9;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(101, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "OK";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EnterMoveNextControl = true;
            this.textEdit1.Location = new System.Drawing.Point(61, 3);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(113, 20);
            this.textEdit1.TabIndex = 4;
            this.textEdit1.TabStop = false;
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(3, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 14);
            this.labelControl6.TabIndex = 61;
            this.labelControl6.Text = "Card # :";
            // 
            // panelcards
            // 
            this.panelcards.Controls.Add(this.button8);
            this.panelcards.Controls.Add(this.button7);
            this.panelcards.Controls.Add(this.button6);
            this.panelcards.Controls.Add(this.button5);
            this.panelcards.Location = new System.Drawing.Point(153, 2);
            this.panelcards.Name = "panelcards";
            this.panelcards.Size = new System.Drawing.Size(440, 65);
            this.panelcards.TabIndex = 57;
            this.panelcards.Visible = false;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::Store.Properties.Resources.amex;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = global::Store.Properties.Resources.B4;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button8.Location = new System.Drawing.Point(331, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 62);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Store.Properties.Resources.visa48;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::Store.Properties.Resources.B3;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button7.Location = new System.Drawing.Point(221, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 60);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Store.Properties.Resources.mastercard;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::Store.Properties.Resources.B2;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button6.Location = new System.Drawing.Point(112, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 59);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Store.Properties.Resources.B1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 59);
            this.button5.TabIndex = 4;
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.aPARMAINBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(818, 275);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // aPARMAINBindingSource
            // 
            this.aPARMAINBindingSource.DataMember = "APARMAIN";
            this.aPARMAINBindingSource.DataSource = this.ledgers1;
            // 
            // ledgers1
            // 
            this.ledgers1.DataSetName = "Ledgers";
            this.ledgers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANID,
            this.colTYPE,
            this.colREFNO,
            this.colTRANDATE,
            this.colINVOICEDATE,
            this.colVOUCHERNO,
            this.colINVOICENO,
            this.colINVAMOUNT,
            this.colPAIDAMOUNT,
            this.colBALANCE,
            this.colCOMPANY,
            this.colBINID,
            this.colSOURCEID,
            this.colUSERID,
            this.colDISCOUNT,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colTRANID
            // 
            this.colTRANID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANID.AppearanceCell.Options.UseFont = true;
            this.colTRANID.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANID.AppearanceHeader.Options.UseFont = true;
            this.colTRANID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.FieldName = "TRANID";
            this.colTRANID.Name = "colTRANID";
            this.colTRANID.OptionsColumn.AllowEdit = false;
            // 
            // colTYPE
            // 
            this.colTYPE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTYPE.AppearanceCell.Options.UseFont = true;
            this.colTYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colTYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTYPE.AppearanceHeader.Options.UseFont = true;
            this.colTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.OptionsColumn.AllowEdit = false;
            // 
            // colREFNO
            // 
            this.colREFNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREFNO.AppearanceCell.Options.UseFont = true;
            this.colREFNO.AppearanceCell.Options.UseTextOptions = true;
            this.colREFNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREFNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREFNO.AppearanceHeader.Options.UseFont = true;
            this.colREFNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.OptionsColumn.AllowEdit = false;
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceCell.Options.UseFont = true;
            this.colTRANDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceHeader.Options.UseFont = true;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Date";
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 0;
            this.colTRANDATE.Width = 108;
            // 
            // colINVOICEDATE
            // 
            this.colINVOICEDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVOICEDATE.AppearanceCell.Options.UseFont = true;
            this.colINVOICEDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVOICEDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVOICEDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVOICEDATE.AppearanceHeader.Options.UseFont = true;
            this.colINVOICEDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVOICEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVOICEDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVOICEDATE.FieldName = "INVOICEDATE";
            this.colINVOICEDATE.Name = "colINVOICEDATE";
            this.colINVOICEDATE.OptionsColumn.AllowEdit = false;
            // 
            // colVOUCHERNO
            // 
            this.colVOUCHERNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colVOUCHERNO.AppearanceCell.Options.UseFont = true;
            this.colVOUCHERNO.AppearanceCell.Options.UseTextOptions = true;
            this.colVOUCHERNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colVOUCHERNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colVOUCHERNO.AppearanceHeader.Options.UseFont = true;
            this.colVOUCHERNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colVOUCHERNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVOUCHERNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colVOUCHERNO.FieldName = "VOUCHERNO";
            this.colVOUCHERNO.Name = "colVOUCHERNO";
            this.colVOUCHERNO.OptionsColumn.AllowEdit = false;
            this.colVOUCHERNO.Width = 61;
            // 
            // colINVOICENO
            // 
            this.colINVOICENO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVOICENO.AppearanceCell.Options.UseFont = true;
            this.colINVOICENO.AppearanceCell.Options.UseTextOptions = true;
            this.colINVOICENO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVOICENO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVOICENO.AppearanceHeader.Options.UseFont = true;
            this.colINVOICENO.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVOICENO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVOICENO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVOICENO.Caption = "Inv No.";
            this.colINVOICENO.FieldName = "INVOICENO";
            this.colINVOICENO.Name = "colINVOICENO";
            this.colINVOICENO.OptionsColumn.AllowEdit = false;
            this.colINVOICENO.Visible = true;
            this.colINVOICENO.VisibleIndex = 1;
            this.colINVOICENO.Width = 103;
            // 
            // colINVAMOUNT
            // 
            this.colINVAMOUNT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVAMOUNT.AppearanceCell.Options.UseFont = true;
            this.colINVAMOUNT.AppearanceCell.Options.UseTextOptions = true;
            this.colINVAMOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVAMOUNT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVAMOUNT.AppearanceHeader.Options.UseFont = true;
            this.colINVAMOUNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVAMOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVAMOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVAMOUNT.Caption = "Inv Amount";
            this.colINVAMOUNT.DisplayFormat.FormatString = "n2";
            this.colINVAMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVAMOUNT.FieldName = "INVAMOUNT";
            this.colINVAMOUNT.Name = "colINVAMOUNT";
            this.colINVAMOUNT.OptionsColumn.AllowEdit = false;
            this.colINVAMOUNT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "INVAMOUNT", "{0:###,###,###.00}")});
            this.colINVAMOUNT.Visible = true;
            this.colINVAMOUNT.VisibleIndex = 2;
            this.colINVAMOUNT.Width = 116;
            // 
            // colPAIDAMOUNT
            // 
            this.colPAIDAMOUNT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPAIDAMOUNT.AppearanceCell.Options.UseFont = true;
            this.colPAIDAMOUNT.AppearanceCell.Options.UseTextOptions = true;
            this.colPAIDAMOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPAIDAMOUNT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPAIDAMOUNT.AppearanceHeader.Options.UseFont = true;
            this.colPAIDAMOUNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colPAIDAMOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPAIDAMOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPAIDAMOUNT.Caption = "Paid Amount";
            this.colPAIDAMOUNT.DisplayFormat.FormatString = "n2";
            this.colPAIDAMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPAIDAMOUNT.FieldName = "PAIDAMOUNT";
            this.colPAIDAMOUNT.Name = "colPAIDAMOUNT";
            this.colPAIDAMOUNT.OptionsColumn.AllowEdit = false;
            this.colPAIDAMOUNT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PAIDAMOUNT", "{0:###,###,###.00}")});
            this.colPAIDAMOUNT.Visible = true;
            this.colPAIDAMOUNT.VisibleIndex = 3;
            this.colPAIDAMOUNT.Width = 110;
            // 
            // colBALANCE
            // 
            this.colBALANCE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBALANCE.AppearanceCell.Options.UseFont = true;
            this.colBALANCE.AppearanceCell.Options.UseTextOptions = true;
            this.colBALANCE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBALANCE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBALANCE.AppearanceHeader.Options.UseFont = true;
            this.colBALANCE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBALANCE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBALANCE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBALANCE.Caption = "Balance";
            this.colBALANCE.DisplayFormat.FormatString = "n2";
            this.colBALANCE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBALANCE.FieldName = "BALANCE";
            this.colBALANCE.Name = "colBALANCE";
            this.colBALANCE.OptionsColumn.AllowEdit = false;
            this.colBALANCE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BALANCE", "{0:###,###,###.00}")});
            this.colBALANCE.Visible = true;
            this.colBALANCE.VisibleIndex = 4;
            this.colBALANCE.Width = 108;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceCell.Options.UseFont = true;
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceHeader.Options.UseFont = true;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.OptionsColumn.AllowEdit = false;
            this.colCOMPANY.Width = 66;
            // 
            // colBINID
            // 
            this.colBINID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBINID.AppearanceCell.Options.UseFont = true;
            this.colBINID.AppearanceCell.Options.UseTextOptions = true;
            this.colBINID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBINID.AppearanceHeader.Options.UseFont = true;
            this.colBINID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBINID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBINID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.FieldName = "BINID";
            this.colBINID.Name = "colBINID";
            this.colBINID.OptionsColumn.AllowEdit = false;
            this.colBINID.OptionsColumn.ReadOnly = true;
            this.colBINID.Width = 66;
            // 
            // colSOURCEID
            // 
            this.colSOURCEID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOURCEID.AppearanceCell.Options.UseFont = true;
            this.colSOURCEID.AppearanceCell.Options.UseTextOptions = true;
            this.colSOURCEID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOURCEID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOURCEID.AppearanceHeader.Options.UseFont = true;
            this.colSOURCEID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOURCEID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOURCEID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOURCEID.FieldName = "SOURCEID";
            this.colSOURCEID.Name = "colSOURCEID";
            this.colSOURCEID.OptionsColumn.AllowEdit = false;
            this.colSOURCEID.Width = 66;
            // 
            // colUSERID
            // 
            this.colUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceCell.Options.UseFont = true;
            this.colUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceHeader.Options.UseFont = true;
            this.colUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            this.colUSERID.OptionsColumn.AllowEdit = false;
            this.colUSERID.Width = 66;
            // 
            // colDISCOUNT
            // 
            this.colDISCOUNT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISCOUNT.AppearanceCell.Options.UseFont = true;
            this.colDISCOUNT.AppearanceCell.Options.UseTextOptions = true;
            this.colDISCOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCOUNT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISCOUNT.AppearanceHeader.Options.UseFont = true;
            this.colDISCOUNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISCOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISCOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISCOUNT.Caption = "Discount";
            this.colDISCOUNT.DisplayFormat.FormatString = "n2";
            this.colDISCOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDISCOUNT.FieldName = "DISCOUNT";
            this.colDISCOUNT.Name = "colDISCOUNT";
            this.colDISCOUNT.OptionsColumn.AllowEdit = false;
            this.colDISCOUNT.Visible = true;
            this.colDISCOUNT.VisibleIndex = 5;
            this.colDISCOUNT.Width = 70;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Amount Applied";
            this.gridColumn1.DisplayFormat.FormatString = "N2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "AmtApplied";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmtApplied", "{0:###,###,###.00}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 150;
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 401);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CustomerPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Payment";
            this.Load += new System.EventHandler(this.CustomerPayment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerPayment_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtappliedamt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtoutstanding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupcustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.panelcards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPARMAINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private LookUpEdit lookupcustomer;
        private LabelControl labelControl13;
        private TextEdit txtappliedamt;
        private TextEdit txtoutstanding;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextEdit textEdit3;
        private DateEdit dateEdit1;
        private Panel panel2;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource aPARMAINBindingSource;
        private GridColumn colTRANID;
        private GridColumn colTYPE;
        private GridColumn colREFNO;
        private GridColumn colTRANDATE;
        private GridColumn colINVOICEDATE;
        private GridColumn colVOUCHERNO;
        private GridColumn colINVOICENO;
        private GridColumn colINVAMOUNT;
        private GridColumn colPAIDAMOUNT;
        private GridColumn colBALANCE;
        private GridColumn colCOMPANY;
        private GridColumn colBINID;
        private GridColumn colSOURCEID;
        private GridColumn colUSERID;
        private GridColumn colDISCOUNT;
        private GridColumn gridColumn1;
        private BindingSource cUSTOMERBindingSource;
        private Ledgers ledgers1;
        private TextEdit txtbalance;
        private LabelControl labelControl5;
        private Panel panelcards;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Panel panel3;
        private Button button3;
        private TextEdit textEdit1;
        private LabelControl labelControl6;
        private Button button1;
        private Button button2;
    }
}