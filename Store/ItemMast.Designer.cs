using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraTab;
using VIRETAILENTITIES;

namespace Store
{
    partial class ItemMast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemMast));
            this.iTEMMASTBindingSource = new System.Windows.Forms.BindingSource();
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.dsInventory1 = new VIRETAILENTITIES.DsInventory();
            this.expdatereq = new System.Windows.Forms.CheckBox();
            this.printbarcode = new System.Windows.Forms.CheckBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.active = new System.Windows.Forms.CheckBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.ownbarcode = new System.Windows.Forms.CheckBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.itemname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.barcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.aritemname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.itemcat = new DevExpress.XtraEditors.LookUpEdit();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource();
            this.itemgroup = new DevExpress.XtraEditors.LookUpEdit();
            this.iTEMGROUPBindingSource = new System.Windows.Forms.BindingSource();
            this.genname = new DevExpress.XtraEditors.LookUpEdit();
            this.gENERICMASTBindingSource = new System.Windows.Forms.BindingSource();
            this.itemtype = new DevExpress.XtraEditors.LookUpEdit();
            this.iTEMTYPEBindingSource = new System.Windows.Forms.BindingSource();
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource();
            this.buom = new DevExpress.XtraEditors.LookUpEdit();
            this.uOMMASTBindingSource = new System.Windows.Forms.BindingSource();
            this.reorder = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.discount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.minpoqty = new DevExpress.XtraEditors.TextEdit();
            this.maxpoqty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.uom = new DevExpress.XtraEditors.LookUpEdit();
            this.supplier = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.manfact = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.SALEDISCOUNTPER = new DevExpress.XtraEditors.TextEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.ORDERCOST = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.REGULARPRICE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.markup = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.margin = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.temprature = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.location = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.COLOR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.WEIGHT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ITEMDEM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.fastmoving = new System.Windows.Forms.CheckBox();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.minqty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.maxqty = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.lblstock = new DevExpress.XtraEditors.TextEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.txtourcode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aritemname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemgroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENERICMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uOMMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minpoqty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxpoqty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manfact.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SALEDISCOUNTPER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERCOST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGULARPRICE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margin.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temprature.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.location.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COLOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WEIGHT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMDEM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minqty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxqty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblstock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtourcode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(795, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // iTEMMASTBindingSource
            // 
            this.iTEMMASTBindingSource.DataMember = "ITEMMAST";
            this.iTEMMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsInventory1
            // 
            this.dsInventory1.DataSetName = "DsInventory";
            this.dsInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expdatereq
            // 
            this.expdatereq.AutoSize = true;
            this.expdatereq.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expdatereq.Location = new System.Drawing.Point(545, 278);
            this.expdatereq.Name = "expdatereq";
            this.expdatereq.Size = new System.Drawing.Size(140, 18);
            this.expdatereq.TabIndex = 13;
            this.expdatereq.Text = "Expiry Date Required";
            this.expdatereq.UseVisualStyleBackColor = true;
            // 
            // printbarcode
            // 
            this.printbarcode.AutoSize = true;
            this.printbarcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbarcode.Location = new System.Drawing.Point(545, 254);
            this.printbarcode.Name = "printbarcode";
            this.printbarcode.Size = new System.Drawing.Size(99, 18);
            this.printbarcode.TabIndex = 12;
            this.printbarcode.Text = "Print Barcode";
            this.printbarcode.UseVisualStyleBackColor = true;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(8, 324);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(59, 14);
            this.labelControl12.TabIndex = 114;
            this.labelControl12.Text = "Base UOM:";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.active.Checked = true;
            this.active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.active.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active.Location = new System.Drawing.Point(94, 220);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(64, 18);
            this.active.TabIndex = 1;
            this.active.Text = "Active:";
            this.active.UseVisualStyleBackColor = true;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(462, 220);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 14);
            this.labelControl9.TabIndex = 107;
            this.labelControl9.Text = "Generic name:";
            // 
            // ownbarcode
            // 
            this.ownbarcode.AutoSize = true;
            this.ownbarcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownbarcode.Location = new System.Drawing.Point(275, 220);
            this.ownbarcode.Name = "ownbarcode";
            this.ownbarcode.Size = new System.Drawing.Size(100, 18);
            this.ownbarcode.TabIndex = 1;
            this.ownbarcode.Text = "Own Barcode";
            this.ownbarcode.UseVisualStyleBackColor = true;
            this.ownbarcode.CheckedChanged += new System.EventHandler(this.ownbarcode_CheckedChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(462, 196);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 14);
            this.labelControl7.TabIndex = 104;
            this.labelControl7.Text = "Group:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(462, 171);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 14);
            this.labelControl6.TabIndex = 102;
            this.labelControl6.Text = "Category:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineColor = System.Drawing.Color.Silver;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(10, 144);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(391, 20);
            this.labelControl5.TabIndex = 100;
            this.labelControl5.Text = "Item Information";
            // 
            // itemname
            // 
            this.itemname.EditValue = "";
            this.itemname.EnterMoveNextControl = true;
            this.itemname.Location = new System.Drawing.Point(93, 269);
            this.itemname.Name = "itemname";
            this.itemname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.itemname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.itemname.Properties.Appearance.Options.UseBackColor = true;
            this.itemname.Properties.Appearance.Options.UseFont = true;
            this.itemname.Properties.Appearance.Options.UseForeColor = true;
            this.itemname.Properties.MaxLength = 250;
            this.itemname.Size = new System.Drawing.Size(281, 20);
            this.itemname.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(8, 272);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 14);
            this.labelControl4.TabIndex = 98;
            this.labelControl4.Text = "Name:";
            // 
            // barcode
            // 
            this.barcode.EnterMoveNextControl = true;
            this.barcode.Location = new System.Drawing.Point(93, 244);
            this.barcode.Name = "barcode";
            this.barcode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.barcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.barcode.Properties.Appearance.Options.UseBackColor = true;
            this.barcode.Properties.Appearance.Options.UseFont = true;
            this.barcode.Properties.Appearance.Options.UseForeColor = true;
            this.barcode.Properties.MaxLength = 16;
            this.barcode.Size = new System.Drawing.Size(281, 20);
            this.barcode.TabIndex = 2;
            this.barcode.Validating += new System.ComponentModel.CancelEventHandler(this.BarcodeValidating);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(8, 246);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 14);
            this.labelControl3.TabIndex = 96;
            this.labelControl3.Text = "Manf Bar Code:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(9, 196);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 14);
            this.labelControl1.TabIndex = 95;
            this.labelControl1.Text = "Type:";
            // 
            // aritemname
            // 
            this.aritemname.EditValue = "";
            this.aritemname.EnterMoveNextControl = true;
            this.aritemname.Location = new System.Drawing.Point(93, 295);
            this.aritemname.Name = "aritemname";
            this.aritemname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.aritemname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aritemname.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.aritemname.Properties.Appearance.Options.UseBackColor = true;
            this.aritemname.Properties.Appearance.Options.UseFont = true;
            this.aritemname.Properties.Appearance.Options.UseForeColor = true;
            this.aritemname.Properties.MaxLength = 250;
            this.aritemname.Size = new System.Drawing.Size(281, 20);
            this.aritemname.TabIndex = 4;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Location = new System.Drawing.Point(8, 298);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(82, 14);
            this.labelControl23.TabIndex = 137;
            this.labelControl23.Text = "Name (Arabic):";
            // 
            // itemcat
            // 
            this.itemcat.EnterMoveNextControl = true;
            this.itemcat.Location = new System.Drawing.Point(545, 170);
            this.itemcat.Name = "itemcat";
            this.itemcat.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.itemcat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemcat.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.itemcat.Properties.Appearance.Options.UseBackColor = true;
            this.itemcat.Properties.Appearance.Options.UseFont = true;
            this.itemcat.Properties.Appearance.Options.UseForeColor = true;
            this.itemcat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemcat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CATID", "CATID", 54, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CATNAME", "Category name", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCATNAME", "ARCATNAME", 72, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.itemcat.Properties.DataSource = this.cATEGORYBindingSource;
            this.itemcat.Properties.DisplayMember = "CATNAME";
            this.itemcat.Properties.NullText = "";
            this.itemcat.Properties.ShowHeader = false;
            this.itemcat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.itemcat.Properties.ValueMember = "CATID";
            this.itemcat.Size = new System.Drawing.Size(247, 20);
            this.itemcat.TabIndex = 9;
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.dsMaster1;
            // 
            // itemgroup
            // 
            this.itemgroup.EnterMoveNextControl = true;
            this.itemgroup.Location = new System.Drawing.Point(545, 193);
            this.itemgroup.Name = "itemgroup";
            this.itemgroup.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.itemgroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemgroup.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.itemgroup.Properties.Appearance.Options.UseBackColor = true;
            this.itemgroup.Properties.Appearance.Options.UseFont = true;
            this.itemgroup.Properties.Appearance.Options.UseForeColor = true;
            this.itemgroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemgroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPNAME", "Group name", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARGROUPNAME", "ARGROUPNAME", 87, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.itemgroup.Properties.DataSource = this.iTEMGROUPBindingSource;
            this.itemgroup.Properties.DisplayMember = "GROUPNAME";
            this.itemgroup.Properties.NullText = "";
            this.itemgroup.Properties.ShowHeader = false;
            this.itemgroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.itemgroup.Properties.ValueMember = "GROUPID";
            this.itemgroup.Size = new System.Drawing.Size(247, 20);
            this.itemgroup.TabIndex = 10;
            // 
            // iTEMGROUPBindingSource
            // 
            this.iTEMGROUPBindingSource.DataMember = "ITEMGROUP";
            this.iTEMGROUPBindingSource.DataSource = this.dsMaster1;
            // 
            // genname
            // 
            this.genname.EnterMoveNextControl = true;
            this.genname.Location = new System.Drawing.Point(545, 218);
            this.genname.Name = "genname";
            this.genname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.genname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genname.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.genname.Properties.Appearance.Options.UseBackColor = true;
            this.genname.Properties.Appearance.Options.UseFont = true;
            this.genname.Properties.Appearance.Options.UseForeColor = true;
            this.genname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.genname.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GENERICID", "GENERICID", 78, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GNAME", "GNAME", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.genname.Properties.DataSource = this.gENERICMASTBindingSource;
            this.genname.Properties.DisplayMember = "GNAME";
            this.genname.Properties.NullText = "";
            this.genname.Properties.ShowHeader = false;
            this.genname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.genname.Properties.ValueMember = "GENERICID";
            this.genname.Size = new System.Drawing.Size(247, 20);
            this.genname.TabIndex = 11;
            // 
            // gENERICMASTBindingSource
            // 
            this.gENERICMASTBindingSource.DataMember = "GENERICMAST";
            this.gENERICMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // itemtype
            // 
            this.itemtype.EnterMoveNextControl = true;
            this.itemtype.Location = new System.Drawing.Point(94, 194);
            this.itemtype.Name = "itemtype";
            this.itemtype.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.itemtype.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtype.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.itemtype.Properties.Appearance.Options.UseBackColor = true;
            this.itemtype.Properties.Appearance.Options.UseFont = true;
            this.itemtype.Properties.Appearance.Options.UseForeColor = true;
            this.itemtype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemtype.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TYPEID", "TYPEID", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TYPENAME", "Item Type", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.itemtype.Properties.DataSource = this.iTEMTYPEBindingSource;
            this.itemtype.Properties.DisplayMember = "TYPENAME";
            this.itemtype.Properties.NullText = "";
            this.itemtype.Properties.ShowFooter = false;
            this.itemtype.Properties.ShowHeader = false;
            this.itemtype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.itemtype.Properties.ValueMember = "TYPEID";
            this.itemtype.Size = new System.Drawing.Size(281, 20);
            this.itemtype.TabIndex = 0;
            this.itemtype.EditValueChanged += new System.EventHandler(this.LookUpEdit4EditValueChanged);
            // 
            // iTEMTYPEBindingSource
            // 
            this.iTEMTYPEBindingSource.DataMember = "ITEMTYPE";
            this.iTEMTYPEBindingSource.DataSource = this.dsMaster1;
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataMember = "SUPPLIER";
            this.sUPPLIERBindingSource.DataSource = this.dsInventory1;
            // 
            // buom
            // 
            this.buom.EnterMoveNextControl = true;
            this.buom.Location = new System.Drawing.Point(93, 322);
            this.buom.Name = "buom";
            this.buom.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.buom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buom.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.buom.Properties.Appearance.Options.UseBackColor = true;
            this.buom.Properties.Appearance.Options.UseFont = true;
            this.buom.Properties.Appearance.Options.UseForeColor = true;
            this.buom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.buom.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITID", "UNITID", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITDESC", "UNITDESC", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITVALUE", "UNITVALUE", 65, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.buom.Properties.DataSource = this.uOMMASTBindingSource;
            this.buom.Properties.DisplayMember = "UNITDESC";
            this.buom.Properties.NullText = "";
            this.buom.Properties.ShowHeader = false;
            this.buom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.buom.Properties.ValueMember = "UNITID";
            this.buom.Size = new System.Drawing.Size(97, 20);
            this.buom.TabIndex = 5;
            this.buom.EditValueChanged += new System.EventHandler(this.BuomEditValueChanged);
            // 
            // uOMMASTBindingSource
            // 
            this.uOMMASTBindingSource.DataMember = "UOMMAST";
            this.uOMMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // reorder
            // 
            this.reorder.EnterMoveNextControl = true;
            this.reorder.Location = new System.Drawing.Point(310, 321);
            this.reorder.MenuManager = this.ribbon;
            this.reorder.Name = "reorder";
            this.reorder.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.reorder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorder.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.reorder.Properties.Appearance.Options.UseBackColor = true;
            this.reorder.Properties.Appearance.Options.UseFont = true;
            this.reorder.Properties.Appearance.Options.UseForeColor = true;
            this.reorder.Properties.Appearance.Options.UseTextOptions = true;
            this.reorder.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.reorder.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.reorder.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.reorder.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.reorder.Properties.Mask.EditMask = "n0";
            this.reorder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.reorder.Properties.MaxLength = 3;
            this.reorder.Properties.NullText = "0";
            this.reorder.Properties.ValidateOnEnterKey = true;
            this.reorder.Size = new System.Drawing.Size(64, 20);
            this.reorder.TabIndex = 7;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl25.Location = new System.Drawing.Point(225, 324);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(79, 14);
            this.labelControl25.TabIndex = 141;
            this.labelControl25.Text = "Reorder Point:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 383);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(795, 159);
            this.xtraTabControl1.TabIndex = 16;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage4,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.discount);
            this.xtraTabPage1.Controls.Add(this.labelControl28);
            this.xtraTabPage1.Controls.Add(this.minpoqty);
            this.xtraTabPage1.Controls.Add(this.maxpoqty);
            this.xtraTabPage1.Controls.Add(this.labelControl24);
            this.xtraTabPage1.Controls.Add(this.uom);
            this.xtraTabPage1.Controls.Add(this.supplier);
            this.xtraTabPage1.Controls.Add(this.labelControl15);
            this.xtraTabPage1.Controls.Add(this.labelControl14);
            this.xtraTabPage1.Controls.Add(this.manfact);
            this.xtraTabPage1.Controls.Add(this.labelControl11);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(789, 131);
            this.xtraTabPage1.Text = "Purchase Information";
            // 
            // discount
            // 
            this.discount.EnterMoveNextControl = true;
            this.discount.Location = new System.Drawing.Point(182, 95);
            this.discount.MenuManager = this.ribbon;
            this.discount.Name = "discount";
            this.discount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Properties.Appearance.Options.UseFont = true;
            this.discount.Properties.Appearance.Options.UseTextOptions = true;
            this.discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.discount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.discount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.discount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.discount.Properties.Mask.EditMask = "P2";
            this.discount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.discount.Properties.MaxLength = 2;
            this.discount.Properties.NullText = "0";
            this.discount.Size = new System.Drawing.Size(91, 20);
            this.discount.TabIndex = 3;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Location = new System.Drawing.Point(24, 97);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(152, 14);
            this.labelControl28.TabIndex = 158;
            this.labelControl28.Text = "Item has fixed discount % :";
            // 
            // minpoqty
            // 
            this.minpoqty.EnterMoveNextControl = true;
            this.minpoqty.Location = new System.Drawing.Point(397, 67);
            this.minpoqty.MenuManager = this.ribbon;
            this.minpoqty.Name = "minpoqty";
            this.minpoqty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minpoqty.Properties.Appearance.Options.UseFont = true;
            this.minpoqty.Properties.Appearance.Options.UseTextOptions = true;
            this.minpoqty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.minpoqty.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.minpoqty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.minpoqty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.minpoqty.Properties.Mask.EditMask = "n0";
            this.minpoqty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.minpoqty.Properties.MaxLength = 3;
            this.minpoqty.Properties.NullText = "0";
            this.minpoqty.Size = new System.Drawing.Size(66, 20);
            this.minpoqty.TabIndex = 4;
            this.minpoqty.Visible = false;
            // 
            // maxpoqty
            // 
            this.maxpoqty.EnterMoveNextControl = true;
            this.maxpoqty.Location = new System.Drawing.Point(397, 93);
            this.maxpoqty.MenuManager = this.ribbon;
            this.maxpoqty.Name = "maxpoqty";
            this.maxpoqty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxpoqty.Properties.Appearance.Options.UseFont = true;
            this.maxpoqty.Properties.Appearance.Options.UseTextOptions = true;
            this.maxpoqty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.maxpoqty.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.maxpoqty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.maxpoqty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.maxpoqty.Properties.Mask.EditMask = "n0";
            this.maxpoqty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maxpoqty.Properties.MaxLength = 3;
            this.maxpoqty.Properties.NullText = "0";
            this.maxpoqty.Size = new System.Drawing.Size(66, 20);
            this.maxpoqty.TabIndex = 5;
            this.maxpoqty.Visible = false;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Location = new System.Drawing.Point(300, 95);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(73, 14);
            this.labelControl24.TabIndex = 151;
            this.labelControl24.Text = "P.O Max.Qty:";
            this.labelControl24.Visible = false;
            // 
            // uom
            // 
            this.uom.EnterMoveNextControl = true;
            this.uom.Location = new System.Drawing.Point(182, 67);
            this.uom.Name = "uom";
            this.uom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uom.Properties.Appearance.Options.UseFont = true;
            this.uom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uom.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITID", "UNITID", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITDESC", "Unit", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITVALUE", "Unit Value", 65, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.uom.Properties.DataSource = this.uOMMASTBindingSource;
            this.uom.Properties.DisplayMember = "UNITDESC";
            this.uom.Properties.NullText = "";
            this.uom.Properties.ShowHeader = false;
            this.uom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.uom.Properties.ValueMember = "UNITID";
            this.uom.Size = new System.Drawing.Size(91, 20);
            this.uom.TabIndex = 2;
            // 
            // supplier
            // 
            this.supplier.EnterMoveNextControl = true;
            this.supplier.Location = new System.Drawing.Point(182, 11);
            this.supplier.Name = "supplier";
            this.supplier.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.supplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.supplier.Properties.Appearance.Options.UseBackColor = true;
            this.supplier.Properties.Appearance.Options.UseFont = true;
            this.supplier.Properties.Appearance.Options.UseForeColor = true;
            this.supplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.supplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNAME", "Supplier Name", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.supplier.Properties.DataSource = this.sUPPLIERBindingSource;
            this.supplier.Properties.DisplayMember = "SUPPLIERNAME";
            this.supplier.Properties.NullText = "";
            this.supplier.Properties.ShowHeader = false;
            this.supplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.supplier.Properties.ValueMember = "SUPPLIERNO";
            this.supplier.Size = new System.Drawing.Size(281, 20);
            this.supplier.TabIndex = 0;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(24, 70);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(30, 14);
            this.labelControl15.TabIndex = 150;
            this.labelControl15.Text = "UOM:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(300, 69);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(74, 14);
            this.labelControl14.TabIndex = 149;
            this.labelControl14.Text = "P.O Min.Qty :";
            this.labelControl14.Visible = false;
            // 
            // manfact
            // 
            this.manfact.EditValue = "";
            this.manfact.EnterMoveNextControl = true;
            this.manfact.Location = new System.Drawing.Point(182, 39);
            this.manfact.Name = "manfact";
            this.manfact.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.manfact.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manfact.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.manfact.Properties.Appearance.Options.UseBackColor = true;
            this.manfact.Properties.Appearance.Options.UseFont = true;
            this.manfact.Properties.Appearance.Options.UseForeColor = true;
            this.manfact.Properties.MaxLength = 250;
            this.manfact.Size = new System.Drawing.Size(281, 20);
            this.manfact.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(24, 41);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(113, 14);
            this.labelControl11.TabIndex = 148;
            this.labelControl11.Text = "Supplier Item Code :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(24, 13);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 14);
            this.labelControl10.TabIndex = 147;
            this.labelControl10.Text = "Supplier:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.SALEDISCOUNTPER);
            this.xtraTabPage2.Controls.Add(this.labelControl30);
            this.xtraTabPage2.Controls.Add(this.ORDERCOST);
            this.xtraTabPage2.Controls.Add(this.labelControl19);
            this.xtraTabPage2.Controls.Add(this.REGULARPRICE);
            this.xtraTabPage2.Controls.Add(this.labelControl13);
            this.xtraTabPage2.Controls.Add(this.labelControl27);
            this.xtraTabPage2.Controls.Add(this.labelControl26);
            this.xtraTabPage2.Controls.Add(this.markup);
            this.xtraTabPage2.Controls.Add(this.labelControl17);
            this.xtraTabPage2.Controls.Add(this.margin);
            this.xtraTabPage2.Controls.Add(this.labelControl16);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(789, 131);
            this.xtraTabPage2.Text = "Sales  && Cost Price";
            // 
            // SALEDISCOUNTPER
            // 
            this.SALEDISCOUNTPER.EnterMoveNextControl = true;
            this.SALEDISCOUNTPER.Location = new System.Drawing.Point(128, 96);
            this.SALEDISCOUNTPER.MenuManager = this.ribbon;
            this.SALEDISCOUNTPER.Name = "SALEDISCOUNTPER";
            this.SALEDISCOUNTPER.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALEDISCOUNTPER.Properties.Appearance.Options.UseFont = true;
            this.SALEDISCOUNTPER.Properties.Appearance.Options.UseTextOptions = true;
            this.SALEDISCOUNTPER.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SALEDISCOUNTPER.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SALEDISCOUNTPER.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SALEDISCOUNTPER.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SALEDISCOUNTPER.Properties.Mask.EditMask = "P2";
            this.SALEDISCOUNTPER.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SALEDISCOUNTPER.Properties.MaxLength = 3;
            this.SALEDISCOUNTPER.Properties.NullText = "0";
            this.SALEDISCOUNTPER.Size = new System.Drawing.Size(63, 20);
            this.SALEDISCOUNTPER.TabIndex = 161;
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Location = new System.Drawing.Point(25, 99);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(97, 14);
            this.labelControl30.TabIndex = 160;
            this.labelControl30.Text = "Sale Discount % :";
            // 
            // ORDERCOST
            // 
            this.ORDERCOST.EnterMoveNextControl = true;
            this.ORDERCOST.Location = new System.Drawing.Point(128, 67);
            this.ORDERCOST.MenuManager = this.ribbon;
            this.ORDERCOST.Name = "ORDERCOST";
            this.ORDERCOST.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDERCOST.Properties.Appearance.Options.UseFont = true;
            this.ORDERCOST.Properties.Appearance.Options.UseTextOptions = true;
            this.ORDERCOST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ORDERCOST.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ORDERCOST.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ORDERCOST.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ORDERCOST.Properties.Mask.EditMask = "n";
            this.ORDERCOST.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ORDERCOST.Properties.MaxLength = 3;
            this.ORDERCOST.Properties.NullText = "0";
            this.ORDERCOST.Size = new System.Drawing.Size(63, 20);
            this.ORDERCOST.TabIndex = 159;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Location = new System.Drawing.Point(25, 69);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(67, 14);
            this.labelControl19.TabIndex = 158;
            this.labelControl19.Text = "Order Cost :";
            // 
            // REGULARPRICE
            // 
            this.REGULARPRICE.EnterMoveNextControl = true;
            this.REGULARPRICE.Location = new System.Drawing.Point(128, 39);
            this.REGULARPRICE.MenuManager = this.ribbon;
            this.REGULARPRICE.Name = "REGULARPRICE";
            this.REGULARPRICE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGULARPRICE.Properties.Appearance.Options.UseFont = true;
            this.REGULARPRICE.Properties.Appearance.Options.UseTextOptions = true;
            this.REGULARPRICE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.REGULARPRICE.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.REGULARPRICE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.REGULARPRICE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.REGULARPRICE.Properties.Mask.EditMask = "n";
            this.REGULARPRICE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.REGULARPRICE.Properties.MaxLength = 3;
            this.REGULARPRICE.Properties.NullText = "0";
            this.REGULARPRICE.Size = new System.Drawing.Size(63, 20);
            this.REGULARPRICE.TabIndex = 157;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(25, 41);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(78, 14);
            this.labelControl13.TabIndex = 156;
            this.labelControl13.Text = "Regular Price :";
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Location = new System.Drawing.Point(349, 70);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(93, 14);
            this.labelControl27.TabIndex = 152;
            this.labelControl27.Text = "(Price-Cost)/Cost";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Location = new System.Drawing.Point(349, 41);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(95, 14);
            this.labelControl26.TabIndex = 151;
            this.labelControl26.Text = "(Price-Cost)/Price";
            // 
            // markup
            // 
            this.markup.EnterMoveNextControl = true;
            this.markup.Location = new System.Drawing.Point(275, 67);
            this.markup.Name = "markup";
            this.markup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markup.Properties.Appearance.Options.UseFont = true;
            this.markup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.markup.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.markup.Properties.NullText = "0";
            this.markup.Size = new System.Drawing.Size(68, 20);
            this.markup.TabIndex = 146;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(208, 69);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(63, 14);
            this.labelControl17.TabIndex = 149;
            this.labelControl17.Text = "Markup % :";
            // 
            // margin
            // 
            this.margin.EnterMoveNextControl = true;
            this.margin.Location = new System.Drawing.Point(275, 38);
            this.margin.Name = "margin";
            this.margin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.margin.Properties.Appearance.Options.UseFont = true;
            this.margin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.margin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.margin.Properties.NullText = "0";
            this.margin.Size = new System.Drawing.Size(68, 20);
            this.margin.TabIndex = 145;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(208, 41);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(59, 14);
            this.labelControl16.TabIndex = 148;
            this.labelControl16.Text = "Margin % :";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.temprature);
            this.xtraTabPage4.Controls.Add(this.labelControl22);
            this.xtraTabPage4.Controls.Add(this.location);
            this.xtraTabPage4.Controls.Add(this.labelControl21);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(789, 131);
            this.xtraTabPage4.Text = "Storage";
            // 
            // temprature
            // 
            this.temprature.EditValue = "";
            this.temprature.EnterMoveNextControl = true;
            this.temprature.Location = new System.Drawing.Point(100, 63);
            this.temprature.Name = "temprature";
            this.temprature.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temprature.Properties.Appearance.Options.UseFont = true;
            this.temprature.Properties.MaxLength = 5;
            this.temprature.Size = new System.Drawing.Size(281, 20);
            this.temprature.TabIndex = 136;
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Location = new System.Drawing.Point(19, 65);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(76, 14);
            this.labelControl22.TabIndex = 138;
            this.labelControl22.Text = "Temperature:";
            // 
            // location
            // 
            this.location.EditValue = "";
            this.location.EnterMoveNextControl = true;
            this.location.Location = new System.Drawing.Point(100, 27);
            this.location.Name = "location";
            this.location.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Properties.Appearance.Options.UseFont = true;
            this.location.Properties.MaxLength = 150;
            this.location.Size = new System.Drawing.Size(281, 20);
            this.location.TabIndex = 135;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Location = new System.Drawing.Point(22, 30);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(74, 14);
            this.labelControl21.TabIndex = 137;
            this.labelControl21.Text = "Self Location:";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.pictureBox1);
            this.xtraTabPage3.Controls.Add(this.COLOR);
            this.xtraTabPage3.Controls.Add(this.labelControl20);
            this.xtraTabPage3.Controls.Add(this.WEIGHT);
            this.xtraTabPage3.Controls.Add(this.labelControl8);
            this.xtraTabPage3.Controls.Add(this.ITEMDEM);
            this.xtraTabPage3.Controls.Add(this.labelControl2);
            this.xtraTabPage3.Controls.Add(this.simpleButton1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(789, 131);
            this.xtraTabPage3.Text = "Other Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 123);
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // COLOR
            // 
            this.COLOR.EnterMoveNextControl = true;
            this.COLOR.Location = new System.Drawing.Point(325, 67);
            this.COLOR.Name = "COLOR";
            this.COLOR.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COLOR.Properties.Appearance.Options.UseFont = true;
            this.COLOR.Properties.MaxLength = 10;
            this.COLOR.Size = new System.Drawing.Size(143, 20);
            this.COLOR.TabIndex = 102;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Location = new System.Drawing.Point(226, 69);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(35, 14);
            this.labelControl20.TabIndex = 101;
            this.labelControl20.Text = "Color :";
            // 
            // WEIGHT
            // 
            this.WEIGHT.EnterMoveNextControl = true;
            this.WEIGHT.Location = new System.Drawing.Point(325, 40);
            this.WEIGHT.Name = "WEIGHT";
            this.WEIGHT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WEIGHT.Properties.Appearance.Options.UseFont = true;
            this.WEIGHT.Properties.MaxLength = 10;
            this.WEIGHT.Size = new System.Drawing.Size(143, 20);
            this.WEIGHT.TabIndex = 100;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(226, 42);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 99;
            this.labelControl8.Text = "Weight :";
            // 
            // ITEMDEM
            // 
            this.ITEMDEM.EnterMoveNextControl = true;
            this.ITEMDEM.Location = new System.Drawing.Point(325, 13);
            this.ITEMDEM.Name = "ITEMDEM";
            this.ITEMDEM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITEMDEM.Properties.Appearance.Options.UseFont = true;
            this.ITEMDEM.Properties.MaxLength = 10;
            this.ITEMDEM.Size = new System.Drawing.Size(143, 20);
            this.ITEMDEM.TabIndex = 98;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(226, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 14);
            this.labelControl2.TabIndex = 97;
            this.labelControl2.Text = "Item Dimension :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(226, 104);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Choose Image";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // fastmoving
            // 
            this.fastmoving.AutoSize = true;
            this.fastmoving.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastmoving.Location = new System.Drawing.Point(545, 302);
            this.fastmoving.Name = "fastmoving";
            this.fastmoving.Size = new System.Drawing.Size(98, 18);
            this.fastmoving.TabIndex = 14;
            this.fastmoving.Text = "Fast Moving  ";
            this.fastmoving.UseVisualStyleBackColor = true;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(8, 351);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(50, 14);
            this.labelControl18.TabIndex = 154;
            this.labelControl18.Text = "Min Qty.:";
            // 
            // minqty
            // 
            this.minqty.EnterMoveNextControl = true;
            this.minqty.Location = new System.Drawing.Point(93, 348);
            this.minqty.MenuManager = this.ribbon;
            this.minqty.Name = "minqty";
            this.minqty.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.minqty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minqty.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.minqty.Properties.Appearance.Options.UseBackColor = true;
            this.minqty.Properties.Appearance.Options.UseFont = true;
            this.minqty.Properties.Appearance.Options.UseForeColor = true;
            this.minqty.Properties.Appearance.Options.UseTextOptions = true;
            this.minqty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.minqty.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.minqty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.minqty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.minqty.Properties.Mask.EditMask = "n0";
            this.minqty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.minqty.Properties.MaxLength = 3;
            this.minqty.Properties.NullText = "0";
            this.minqty.Size = new System.Drawing.Size(66, 20);
            this.minqty.TabIndex = 6;
            this.minqty.EditValueChanged += new System.EventHandler(this.minqty_EditValueChanged);
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Location = new System.Drawing.Point(254, 351);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(53, 14);
            this.labelControl29.TabIndex = 156;
            this.labelControl29.Text = "Max Qty.:";
            // 
            // maxqty
            // 
            this.maxqty.EnterMoveNextControl = true;
            this.maxqty.Location = new System.Drawing.Point(310, 348);
            this.maxqty.MenuManager = this.ribbon;
            this.maxqty.Name = "maxqty";
            this.maxqty.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.maxqty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxqty.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.maxqty.Properties.Appearance.Options.UseBackColor = true;
            this.maxqty.Properties.Appearance.Options.UseFont = true;
            this.maxqty.Properties.Appearance.Options.UseForeColor = true;
            this.maxqty.Properties.Appearance.Options.UseTextOptions = true;
            this.maxqty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.maxqty.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.maxqty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.maxqty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.maxqty.Properties.Mask.EditMask = "n0";
            this.maxqty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maxqty.Properties.MaxLength = 3;
            this.maxqty.Properties.NullText = "0";
            this.maxqty.Size = new System.Drawing.Size(64, 20);
            this.maxqty.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(545, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 18);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "No discount on sale";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl31.Location = new System.Drawing.Point(462, 357);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(39, 14);
            this.labelControl31.TabIndex = 157;
            this.labelControl31.Text = "Stock :";
            // 
            // lblstock
            // 
            this.lblstock.EnterMoveNextControl = true;
            this.lblstock.Location = new System.Drawing.Point(545, 353);
            this.lblstock.MenuManager = this.ribbon;
            this.lblstock.Name = "lblstock";
            this.lblstock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Properties.Appearance.Options.UseFont = true;
            this.lblstock.Properties.Appearance.Options.UseTextOptions = true;
            this.lblstock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblstock.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblstock.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.lblstock.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.lblstock.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.lblstock.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lblstock.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.lblstock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lblstock.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lblstock.Properties.MaxLength = 2;
            this.lblstock.Properties.NullText = "0";
            this.lblstock.Properties.ReadOnly = true;
            this.lblstock.Size = new System.Drawing.Size(56, 22);
            this.lblstock.TabIndex = 159;
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Location = new System.Drawing.Point(9, 170);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(60, 14);
            this.labelControl32.TabIndex = 160;
            this.labelControl32.Text = "Our Code :";
            // 
            // txtourcode
            // 
            this.txtourcode.EnterMoveNextControl = true;
            this.txtourcode.Location = new System.Drawing.Point(94, 167);
            this.txtourcode.Name = "txtourcode";
            this.txtourcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtourcode.Properties.Appearance.Options.UseFont = true;
            this.txtourcode.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtourcode.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtourcode.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtourcode.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtourcode.Properties.MaxLength = 16;
            this.txtourcode.Properties.ReadOnly = true;
            this.txtourcode.Size = new System.Drawing.Size(281, 20);
            this.txtourcode.TabIndex = 161;
            this.txtourcode.TabStop = false;
            // 
            // ItemMast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 573);
            this.Controls.Add(this.txtourcode);
            this.Controls.Add(this.labelControl32);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.labelControl31);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.maxqty);
            this.Controls.Add(this.labelControl29);
            this.Controls.Add(this.minqty);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.labelControl25);
            this.Controls.Add(this.buom);
            this.Controls.Add(this.fastmoving);
            this.Controls.Add(this.reorder);
            this.Controls.Add(this.itemtype);
            this.Controls.Add(this.genname);
            this.Controls.Add(this.itemgroup);
            this.Controls.Add(this.itemcat);
            this.Controls.Add(this.aritemname);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.expdatereq);
            this.Controls.Add(this.printbarcode);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.active);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.ownbarcode);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ItemMast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Master";
            this.Load += new System.EventHandler(this.ItemMastLoad);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.barcode, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.itemname, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.ownbarcode, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.active, 0);
            this.Controls.SetChildIndex(this.labelControl12, 0);
            this.Controls.SetChildIndex(this.printbarcode, 0);
            this.Controls.SetChildIndex(this.expdatereq, 0);
            this.Controls.SetChildIndex(this.labelControl23, 0);
            this.Controls.SetChildIndex(this.aritemname, 0);
            this.Controls.SetChildIndex(this.itemcat, 0);
            this.Controls.SetChildIndex(this.itemgroup, 0);
            this.Controls.SetChildIndex(this.genname, 0);
            this.Controls.SetChildIndex(this.itemtype, 0);
            this.Controls.SetChildIndex(this.reorder, 0);
            this.Controls.SetChildIndex(this.fastmoving, 0);
            this.Controls.SetChildIndex(this.buom, 0);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.labelControl25, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.labelControl18, 0);
            this.Controls.SetChildIndex(this.minqty, 0);
            this.Controls.SetChildIndex(this.labelControl29, 0);
            this.Controls.SetChildIndex(this.maxqty, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.labelControl31, 0);
            this.Controls.SetChildIndex(this.lblstock, 0);
            this.Controls.SetChildIndex(this.labelControl32, 0);
            this.Controls.SetChildIndex(this.txtourcode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aritemname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemgroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENERICMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uOMMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minpoqty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxpoqty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manfact.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SALEDISCOUNTPER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERCOST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGULARPRICE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margin.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temprature.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.location.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COLOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WEIGHT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMDEM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minqty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxqty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblstock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtourcode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox expdatereq;
        private CheckBox printbarcode;
        private LabelControl labelControl12;
        private CheckBox active;
        private LabelControl labelControl9;
        private CheckBox ownbarcode;
        private LabelControl labelControl7;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private TextEdit itemname;
        private LabelControl labelControl4;
        private TextEdit barcode;
        private LabelControl labelControl3;
        private LabelControl labelControl1;
        private TextEdit aritemname;
        private LabelControl labelControl23;
        private LookUpEdit itemcat;
        private LookUpEdit itemgroup;
        private LookUpEdit genname;
        private LookUpEdit itemtype;
        private DsInventory dsInventory1;
        private BindingSource cATEGORYBindingSource;
        private BindingSource iTEMGROUPBindingSource;
        private BindingSource gENERICMASTBindingSource;
        private BindingSource iTEMTYPEBindingSource;
        private BindingSource sUPPLIERBindingSource;
        private LookUpEdit buom;
        private BindingSource iTEMMASTBindingSource;
        private TextEdit reorder;
        private BindingSource bindingSource1;
        private DXErrorProvider dxErrorProvider1;
        private LabelControl labelControl25;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private TextEdit minpoqty;
        private TextEdit maxpoqty;
        private LabelControl labelControl24;
        private LookUpEdit uom;
        private LookUpEdit supplier;
        private LabelControl labelControl15;
        private LabelControl labelControl14;
        private TextEdit manfact;
        private LabelControl labelControl11;
        private XtraTabPage xtraTabPage2;
        private CheckBox fastmoving;
        private LabelControl labelControl27;
        private LabelControl labelControl26;
        private CalcEdit markup;
        private LabelControl labelControl17;
        private CalcEdit margin;
        private LabelControl labelControl16;
        private XtraTabPage xtraTabPage3;
        private XtraTabPage xtraTabPage4;
        private TextEdit temprature;
        private LabelControl labelControl22;
        private TextEdit location;
        private LabelControl labelControl21;
        private SimpleButton simpleButton1;
        private TextEdit WEIGHT;
        private LabelControl labelControl8;
        private TextEdit ITEMDEM;
        private LabelControl labelControl2;
        private TextEdit COLOR;
        private LabelControl labelControl20;
        private TextEdit REGULARPRICE;
        private LabelControl labelControl13;
        private TextEdit discount;
        private LabelControl labelControl28;
        private LabelControl labelControl10;
        private TextEdit ORDERCOST;
        private LabelControl labelControl19;
        private TextEdit maxqty;
        private LabelControl labelControl29;
        private TextEdit minqty;
        private LabelControl labelControl18;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private DsMaster dsMaster1;
        private CheckBox checkBox1;
        private TextEdit SALEDISCOUNTPER;
        private LabelControl labelControl30;
        private BindingSource uOMMASTBindingSource;
        private LabelControl labelControl31;
        private TextEdit lblstock;
        private LabelControl labelControl32;
        private TextEdit txtourcode;



    }
}