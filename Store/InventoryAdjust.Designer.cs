namespace Store
{
    partial class InventoryAdjust
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryAdjust));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.warehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.wAREHOUSEMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Store.DataSet1();
            this.invdate = new DevExpress.XtraEditors.DateEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.aDJDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltool = new System.Windows.Forms.Label();
            this.reason = new DevExpress.XtraEditors.LookUpEdit();
            this.aDJREASONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cprice = new DevExpress.XtraEditors.TextEdit();
            this.sprice = new DevExpress.XtraEditors.TextEdit();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.expdate = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iTEMMAST1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.wAREHOUSEMASTTableAdapter = new Store.DataSet1TableAdapters.WAREHOUSEMASTTableAdapter();
            this.iTEMMAST1TableAdapter = new Store.DataSet1TableAdapters.ITEMMAST1TableAdapter();
            this.aDJDETAILTableAdapter = new Store.DataSet1TableAdapters.ADJDETAILTableAdapter();
            this.aDJREASONSTableAdapter = new Store.DataSet1TableAdapters.ADJREASONSTableAdapter();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJDETAILBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJREASONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expdate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMAST1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(614, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 14);
            label3.TabIndex = 87;
            label3.Text = "Tran Date:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(614, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 14);
            label2.TabIndex = 85;
            label2.Text = "Doc #:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse:";
            // 
            // warehouse
            // 
            this.warehouse.Location = new System.Drawing.Point(107, 33);
            this.warehouse.Name = "warehouse";
            this.warehouse.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouse.Properties.Appearance.Options.UseFont = true;
            this.warehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.warehouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WHID", "WHID", 51, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WHNAME", "WHNAME", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SEL", "SEL", 27, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PER", "PER", 29, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.warehouse.Properties.DataSource = this.wAREHOUSEMASTBindingSource;
            this.warehouse.Properties.DisplayMember = "WHNAME";
            this.warehouse.Properties.NullText = "";
            this.warehouse.Properties.ShowFooter = false;
            this.warehouse.Properties.ShowHeader = false;
            this.warehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.warehouse.Properties.ValueMember = "WHID";
            this.warehouse.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lookUpEdit1_Properties_ButtonClick);
            this.warehouse.Size = new System.Drawing.Size(430, 22);
            this.warehouse.TabIndex = 0;
            this.warehouse.Validating += new System.ComponentModel.CancelEventHandler(this.warehouse_Validating);
            // 
            // wAREHOUSEMASTBindingSource
            // 
            this.wAREHOUSEMASTBindingSource.DataMember = "WAREHOUSEMAST";
            this.wAREHOUSEMASTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invdate
            // 
            this.invdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invdate.EditValue = null;
            this.invdate.Location = new System.Drawing.Point(686, 28);
            this.invdate.Name = "invdate";
            this.invdate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invdate.Properties.Appearance.Options.UseFont = true;
            this.invdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.invdate.Size = new System.Drawing.Size(142, 22);
            this.invdate.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(686, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 89;
            this.label4.Text = "Item name:";
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.CaptionHeight = 17;
            this.c1TrueDBGrid1.DataSource = this.aDJDETAILBindingSource;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(3, 89);
            this.c1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell;
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            this.c1TrueDBGrid1.RowHeight = 23;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(825, 298);
            this.c1TrueDBGrid1.TabIndex = 91;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.c1TrueDBGrid1_RowColChange);
            this.c1TrueDBGrid1.Click += new System.EventHandler(this.c1TrueDBGrid1_Click);
            this.c1TrueDBGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1TrueDBGrid1_KeyDown);
            // 
            // aDJDETAILBindingSource
            // 
            this.aDJDETAILBindingSource.DataMember = "ADJDETAIL";
            this.aDJDETAILBindingSource.DataSource = this.dataSet1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltool);
            this.panel1.Controls.Add(this.reason);
            this.panel1.Controls.Add(this.cprice);
            this.panel1.Controls.Add(this.sprice);
            this.panel1.Controls.Add(this.qty);
            this.panel1.Controls.Add(this.expdate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 60);
            this.panel1.TabIndex = 92;
            // 
            // lbltool
            // 
            this.lbltool.AutoSize = true;
            this.lbltool.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltool.ForeColor = System.Drawing.Color.Red;
            this.lbltool.Location = new System.Drawing.Point(601, 30);
            this.lbltool.Name = "lbltool";
            this.lbltool.Size = new System.Drawing.Size(0, 18);
            this.lbltool.TabIndex = 9;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(70, 32);
            this.reason.Name = "reason";
            this.reason.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.Properties.Appearance.Options.UseFont = true;
            this.reason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.reason.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WHID", "WHID", 51, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WHNAME", "WHNAME", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SEL", "SEL", 27, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PER", "PER", 29, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.reason.Properties.DataSource = this.aDJREASONSBindingSource;
            this.reason.Properties.DisplayMember = "RESON";
            this.reason.Properties.NullText = "";
            this.reason.Properties.ShowFooter = false;
            this.reason.Properties.ShowHeader = false;
            this.reason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.reason.Properties.ValueMember = "RID";
            this.reason.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lookUpEdit1_Properties_ButtonClick);
            this.reason.Size = new System.Drawing.Size(448, 22);
            this.reason.TabIndex = 8;
            // 
            // aDJREASONSBindingSource
            // 
            this.aDJREASONSBindingSource.DataMember = "ADJREASONS";
            this.aDJREASONSBindingSource.DataSource = this.dataSet1;
            // 
            // cprice
            // 
            this.cprice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cprice.Enabled = false;
            this.cprice.Location = new System.Drawing.Point(604, 5);
            this.cprice.Name = "cprice";
            this.cprice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cprice.Properties.Appearance.Options.UseFont = true;
            this.cprice.Properties.Appearance.Options.UseTextOptions = true;
            this.cprice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cprice.Properties.DisplayFormat.FormatString = "###,###.00";
            this.cprice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cprice.Properties.EditFormat.FormatString = "###,###.00";
            this.cprice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cprice.Properties.NullText = "0";
            this.cprice.Size = new System.Drawing.Size(118, 22);
            this.cprice.TabIndex = 7;
            this.cprice.EditValueChanged += new System.EventHandler(this.cprice_EditValueChanged);
            // 
            // sprice
            // 
            this.sprice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sprice.Enabled = false;
            this.sprice.Location = new System.Drawing.Point(400, 4);
            this.sprice.Name = "sprice";
            this.sprice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprice.Properties.Appearance.Options.UseFont = true;
            this.sprice.Properties.Appearance.Options.UseTextOptions = true;
            this.sprice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.sprice.Properties.DisplayFormat.FormatString = "###,###.00";
            this.sprice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.sprice.Properties.EditFormat.FormatString = "###,###.00";
            this.sprice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.sprice.Properties.NullText = "0";
            this.sprice.Size = new System.Drawing.Size(118, 22);
            this.sprice.TabIndex = 6;
            this.sprice.EditValueChanged += new System.EventHandler(this.sprice_EditValueChanged);
            // 
            // qty
            // 
            this.qty.Enabled = false;
            this.qty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(247, 5);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(66, 23);
            this.qty.TabIndex = 5;
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expdate
            // 
            this.expdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expdate.EditValue = null;
            this.expdate.Enabled = false;
            this.expdate.Location = new System.Drawing.Point(70, 6);
            this.expdate.Name = "expdate";
            this.expdate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expdate.Properties.Appearance.Options.UseFont = true;
            this.expdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.expdate.Properties.DisplayFormat.FormatString = "MM-yy";
            this.expdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.expdate.Properties.EditFormat.FormatString = "MM-yy";
            this.expdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.expdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.expdate.Size = new System.Drawing.Size(104, 22);
            this.expdate.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "Reason:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cost Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sales Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Expiry Dt:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnew,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 25);
            this.toolStrip1.TabIndex = 93;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnew
            // 
            this.btnnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(77, 22);
            this.btnnew.Text = "F1-&Add New";
            this.btnnew.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton2.Text = "F2-Edit &Expiry";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton3.Text = "F3-Edit &All";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton4.Text = "F4-Change &Order";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton5.Text = "F6-&Save";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton6.Text = "F7-S&tock";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(430, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = global::Store.Properties.Resources.viewlist16;
            this.button1.Location = new System.Drawing.Point(540, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iTEMMAST1BindingSource
            // 
            this.iTEMMAST1BindingSource.DataMember = "ITEMMAST1";
            this.iTEMMAST1BindingSource.DataSource = this.dataSet1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 14);
            this.label10.TabIndex = 97;
            this.label10.Text = "(Press F10)";
            // 
            // wAREHOUSEMASTTableAdapter
            // 
            this.wAREHOUSEMASTTableAdapter.ClearBeforeFill = true;
            // 
            // iTEMMAST1TableAdapter
            // 
            this.iTEMMAST1TableAdapter.ClearBeforeFill = true;
            // 
            // aDJDETAILTableAdapter
            // 
            this.aDJDETAILTableAdapter.ClearBeforeFill = true;
            // 
            // aDJREASONSTableAdapter
            // 
            this.aDJREASONSTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 453);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.invdate);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.warehouse);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "InventoryAdjust";
            this.Load += new System.EventHandler(this.InventoryAdjust_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InventoryAdjust_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.warehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJDETAILBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJREASONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expdate.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMAST1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit warehouse;
        private DevExpress.XtraEditors.DateEdit invdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnew;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private DevExpress.XtraEditors.DateEdit expdate;
        private System.Windows.Forms.NumericUpDown qty;
        private DevExpress.XtraEditors.TextEdit cprice;
        private DevExpress.XtraEditors.TextEdit sprice;
        private DevExpress.XtraEditors.LookUpEdit reason;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource wAREHOUSEMASTBindingSource;
        private DataSet1TableAdapters.WAREHOUSEMASTTableAdapter wAREHOUSEMASTTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource iTEMMAST1BindingSource;
        private DataSet1TableAdapters.ITEMMAST1TableAdapter iTEMMAST1TableAdapter;
        private System.Windows.Forms.BindingSource aDJDETAILBindingSource;
        private DataSet1TableAdapters.ADJDETAILTableAdapter aDJDETAILTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource aDJREASONSBindingSource;
        private DataSet1TableAdapters.ADJREASONSTableAdapter aDJREASONSTableAdapter;
        private System.Windows.Forms.Label lbltool;
    }
}