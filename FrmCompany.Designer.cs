namespace VIRETAILSTORE
{
    partial class FrmCompany
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
            System.Windows.Forms.Label tIDLabel;
            System.Windows.Forms.Label cOMPNAMELabel;
            System.Windows.Forms.Label cOMPADDLabel;
            System.Windows.Forms.Label cITYLabel;
            System.Windows.Forms.Label cOUNTRYLabel;
            System.Windows.Forms.Label tELEPHONELabel;
            System.Windows.Forms.Label fAXLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label wEBLabel;
            System.Windows.Forms.Label bUSTYPEIDLabel;
            System.Windows.Forms.Label cURRIDLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompany));
            this.dSPOSSTORE = new VIRETAILSTORE.DSPOSSTORE();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource();
            this.cOMPANYTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.COMPANYTableAdapter();
            this.tableAdapterManager = new VIRETAILSTORE.DSPOSSTORETableAdapters.TableAdapterManager();
            this.bUSINESSTYPESTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.BUSINESSTYPESTableAdapter();
            this.cURRENCYNAMESTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.CURRENCYNAMESTableAdapter();
            this.cOMPANYBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cOMPANYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tIDTextBox = new System.Windows.Forms.TextBox();
            this.cOMPNAMETextBox = new System.Windows.Forms.TextBox();
            this.cOMPADDTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            this.cOUNTRYTextBox = new System.Windows.Forms.TextBox();
            this.tELEPHONETextBox = new System.Windows.Forms.TextBox();
            this.fAXTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.wEBTextBox = new System.Windows.Forms.TextBox();
            this.bUSTYPEIDComboBox = new System.Windows.Forms.ComboBox();
            this.bUSINESSTYPESBindingSource = new System.Windows.Forms.BindingSource();
            this.cURRIDComboBox = new System.Windows.Forms.ComboBox();
            this.cURRENCYNAMESBindingSource = new System.Windows.Forms.BindingSource();
            this.cOMPANYBindingSource1 = new System.Windows.Forms.BindingSource();
            this.CCODEtextBox = new System.Windows.Forms.TextBox();
            tIDLabel = new System.Windows.Forms.Label();
            cOMPNAMELabel = new System.Windows.Forms.Label();
            cOMPADDLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            cOUNTRYLabel = new System.Windows.Forms.Label();
            tELEPHONELabel = new System.Windows.Forms.Label();
            fAXLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            wEBLabel = new System.Windows.Forms.Label();
            bUSTYPEIDLabel = new System.Windows.Forms.Label();
            cURRIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingNavigator)).BeginInit();
            this.cOMPANYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bUSINESSTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYNAMESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tIDLabel
            // 
            tIDLabel.AutoSize = true;
            tIDLabel.Location = new System.Drawing.Point(371, 444);
            tIDLabel.Name = "tIDLabel";
            tIDLabel.Size = new System.Drawing.Size(31, 14);
            tIDLabel.TabIndex = 1;
            tIDLabel.Text = "TID:";
            tIDLabel.Visible = false;
            // 
            // cOMPNAMELabel
            // 
            cOMPNAMELabel.AutoSize = true;
            cOMPNAMELabel.Location = new System.Drawing.Point(22, 72);
            cOMPNAMELabel.Name = "cOMPNAMELabel";
            cOMPNAMELabel.Size = new System.Drawing.Size(96, 14);
            cOMPNAMELabel.TabIndex = 3;
            cOMPNAMELabel.Text = "Company Name:";
            // 
            // cOMPADDLabel
            // 
            cOMPADDLabel.AutoSize = true;
            cOMPADDLabel.Location = new System.Drawing.Point(22, 97);
            cOMPADDLabel.Name = "cOMPADDLabel";
            cOMPADDLabel.Size = new System.Drawing.Size(87, 14);
            cOMPADDLabel.TabIndex = 5;
            cOMPADDLabel.Text = "Company Add:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Location = new System.Drawing.Point(22, 164);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(31, 14);
            cITYLabel.TabIndex = 7;
            cITYLabel.Text = "City:";
            // 
            // cOUNTRYLabel
            // 
            cOUNTRYLabel.AutoSize = true;
            cOUNTRYLabel.Location = new System.Drawing.Point(22, 192);
            cOUNTRYLabel.Name = "cOUNTRYLabel";
            cOUNTRYLabel.Size = new System.Drawing.Size(54, 14);
            cOUNTRYLabel.TabIndex = 9;
            cOUNTRYLabel.Text = "Country:";
            // 
            // tELEPHONELabel
            // 
            tELEPHONELabel.AutoSize = true;
            tELEPHONELabel.Location = new System.Drawing.Point(22, 220);
            tELEPHONELabel.Name = "tELEPHONELabel";
            tELEPHONELabel.Size = new System.Drawing.Size(83, 14);
            tELEPHONELabel.TabIndex = 11;
            tELEPHONELabel.Text = "Telephone #:";
            // 
            // fAXLabel
            // 
            fAXLabel.AutoSize = true;
            fAXLabel.Location = new System.Drawing.Point(22, 249);
            fAXLabel.Name = "fAXLabel";
            fAXLabel.Size = new System.Drawing.Size(29, 14);
            fAXLabel.TabIndex = 13;
            fAXLabel.Text = "Fax:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(22, 277);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(41, 14);
            eMAILLabel.TabIndex = 15;
            eMAILLabel.Text = "E-Mail:";
            // 
            // wEBLabel
            // 
            wEBLabel.AutoSize = true;
            wEBLabel.Location = new System.Drawing.Point(22, 304);
            wEBLabel.Name = "wEBLabel";
            wEBLabel.Size = new System.Drawing.Size(37, 14);
            wEBLabel.TabIndex = 17;
            wEBLabel.Text = "Web:";
            // 
            // bUSTYPEIDLabel
            // 
            bUSTYPEIDLabel.AutoSize = true;
            bUSTYPEIDLabel.Location = new System.Drawing.Point(22, 332);
            bUSTYPEIDLabel.Name = "bUSTYPEIDLabel";
            bUSTYPEIDLabel.Size = new System.Drawing.Size(90, 14);
            bUSTYPEIDLabel.TabIndex = 19;
            bUSTYPEIDLabel.Text = "Businees Type:";
            // 
            // cURRIDLabel
            // 
            cURRIDLabel.AutoSize = true;
            cURRIDLabel.Location = new System.Drawing.Point(22, 360);
            cURRIDLabel.Name = "cURRIDLabel";
            cURRIDLabel.Size = new System.Drawing.Size(59, 14);
            cURRIDLabel.TabIndex = 21;
            cURRIDLabel.Text = "Currency:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 14);
            label1.TabIndex = 23;
            label1.Text = "Code:";
            // 
            // dSPOSSTORE
            // 
            this.dSPOSSTORE.DataSetName = "DSPOSSTORE";
            this.dSPOSSTORE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // cOMPANYTableAdapter
            // 
            this.cOMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSMASTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSTYPESTableAdapter = this.bUSINESSTYPESTableAdapter;
            this.tableAdapterManager.COMPANYTableAdapter = this.cOMPANYTableAdapter;
            this.tableAdapterManager.CONTACTMASTTableAdapter = null;
            this.tableAdapterManager.CURRENCYNAMESTableAdapter = this.cURRENCYNAMESTableAdapter;
            this.tableAdapterManager.CUSTSUPGROUPSTableAdapter = null;
            this.tableAdapterManager.GROUPTYPEMASTTableAdapter = null;
            this.tableAdapterManager.PAYMENTONMASTTableAdapter = null;
            this.tableAdapterManager.PAYTYPEMASTTableAdapter = null;
            this.tableAdapterManager.SHIPPINGMASTTableAdapter = null;
            this.tableAdapterManager.SUPPLIERTableAdapter = null;
            this.tableAdapterManager.TERMSDETAILMASTTableAdapter = null;
            this.tableAdapterManager.TERMSMASTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIRETAILSTORE.DSPOSSTORETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bUSINESSTYPESTableAdapter
            // 
            this.bUSINESSTYPESTableAdapter.ClearBeforeFill = true;
            // 
            // cURRENCYNAMESTableAdapter
            // 
            this.cURRENCYNAMESTableAdapter.ClearBeforeFill = true;
            // 
            // cOMPANYBindingNavigator
            // 
            this.cOMPANYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cOMPANYBindingNavigator.BindingSource = this.cOMPANYBindingSource;
            this.cOMPANYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cOMPANYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cOMPANYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.cOMPANYBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.cOMPANYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cOMPANYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cOMPANYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cOMPANYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cOMPANYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cOMPANYBindingNavigator.Name = "cOMPANYBindingNavigator";
            this.cOMPANYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cOMPANYBindingNavigator.Size = new System.Drawing.Size(496, 25);
            this.cOMPANYBindingNavigator.TabIndex = 0;
            this.cOMPANYBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::VIRETAILSTORE.Properties.Resources.NewAdd16;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::VIRETAILSTORE.Properties.Resources.Delete16;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // cOMPANYBindingNavigatorSaveItem
            // 
            this.cOMPANYBindingNavigatorSaveItem.Image = global::VIRETAILSTORE.Properties.Resources.Save16;
            this.cOMPANYBindingNavigatorSaveItem.Name = "cOMPANYBindingNavigatorSaveItem";
            this.cOMPANYBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.cOMPANYBindingNavigatorSaveItem.Text = "Save Data";
            this.cOMPANYBindingNavigatorSaveItem.Click += new System.EventHandler(this.cOMPANYBindingNavigatorSaveItem_Click_1);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tIDTextBox
            // 
            this.tIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "TID", true));
            this.tIDTextBox.Location = new System.Drawing.Point(461, 441);
            this.tIDTextBox.Name = "tIDTextBox";
            this.tIDTextBox.Size = new System.Drawing.Size(72, 22);
            this.tIDTextBox.TabIndex = 2;
            this.tIDTextBox.Visible = false;
            // 
            // cOMPNAMETextBox
            // 
            this.cOMPNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "COMPNAME", true));
            this.cOMPNAMETextBox.Location = new System.Drawing.Point(129, 69);
            this.cOMPNAMETextBox.Name = "cOMPNAMETextBox";
            this.cOMPNAMETextBox.Size = new System.Drawing.Size(353, 22);
            this.cOMPNAMETextBox.TabIndex = 4;
            // 
            // cOMPADDTextBox
            // 
            this.cOMPADDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "COMPADD", true));
            this.cOMPADDTextBox.Location = new System.Drawing.Point(129, 97);
            this.cOMPADDTextBox.Multiline = true;
            this.cOMPADDTextBox.Name = "cOMPADDTextBox";
            this.cOMPADDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cOMPADDTextBox.Size = new System.Drawing.Size(353, 58);
            this.cOMPADDTextBox.TabIndex = 6;
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "CITY", true));
            this.cITYTextBox.Location = new System.Drawing.Point(129, 161);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(353, 22);
            this.cITYTextBox.TabIndex = 8;
            // 
            // cOUNTRYTextBox
            // 
            this.cOUNTRYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "COUNTRY", true));
            this.cOUNTRYTextBox.Location = new System.Drawing.Point(129, 189);
            this.cOUNTRYTextBox.Name = "cOUNTRYTextBox";
            this.cOUNTRYTextBox.Size = new System.Drawing.Size(353, 22);
            this.cOUNTRYTextBox.TabIndex = 10;
            // 
            // tELEPHONETextBox
            // 
            this.tELEPHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "TELEPHONE", true));
            this.tELEPHONETextBox.Location = new System.Drawing.Point(129, 217);
            this.tELEPHONETextBox.Name = "tELEPHONETextBox";
            this.tELEPHONETextBox.Size = new System.Drawing.Size(353, 22);
            this.tELEPHONETextBox.TabIndex = 12;
            // 
            // fAXTextBox
            // 
            this.fAXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "FAX", true));
            this.fAXTextBox.Location = new System.Drawing.Point(129, 245);
            this.fAXTextBox.Name = "fAXTextBox";
            this.fAXTextBox.Size = new System.Drawing.Size(353, 22);
            this.fAXTextBox.TabIndex = 14;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(129, 273);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(353, 22);
            this.eMAILTextBox.TabIndex = 16;
            // 
            // wEBTextBox
            // 
            this.wEBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "WEB", true));
            this.wEBTextBox.Location = new System.Drawing.Point(129, 301);
            this.wEBTextBox.Name = "wEBTextBox";
            this.wEBTextBox.Size = new System.Drawing.Size(353, 22);
            this.wEBTextBox.TabIndex = 18;
            // 
            // bUSTYPEIDComboBox
            // 
            this.bUSTYPEIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "BUSTYPEID", true));
            this.bUSTYPEIDComboBox.DataSource = this.bUSINESSTYPESBindingSource;
            this.bUSTYPEIDComboBox.DisplayMember = "NAME";
            this.bUSTYPEIDComboBox.FormattingEnabled = true;
            this.bUSTYPEIDComboBox.Location = new System.Drawing.Point(129, 329);
            this.bUSTYPEIDComboBox.Name = "bUSTYPEIDComboBox";
            this.bUSTYPEIDComboBox.Size = new System.Drawing.Size(194, 22);
            this.bUSTYPEIDComboBox.TabIndex = 20;
            this.bUSTYPEIDComboBox.ValueMember = "BUSTYPEID";
            // 
            // bUSINESSTYPESBindingSource
            // 
            this.bUSINESSTYPESBindingSource.DataMember = "BUSINESSTYPES";
            this.bUSINESSTYPESBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // cURRIDComboBox
            // 
            this.cURRIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "CURRID", true));
            this.cURRIDComboBox.DataSource = this.cURRENCYNAMESBindingSource;
            this.cURRIDComboBox.DisplayMember = "CURRENCY";
            this.cURRIDComboBox.FormattingEnabled = true;
            this.cURRIDComboBox.Location = new System.Drawing.Point(129, 357);
            this.cURRIDComboBox.Name = "cURRIDComboBox";
            this.cURRIDComboBox.Size = new System.Drawing.Size(194, 22);
            this.cURRIDComboBox.TabIndex = 22;
            this.cURRIDComboBox.ValueMember = "CCODE";
            // 
            // cURRENCYNAMESBindingSource
            // 
            this.cURRENCYNAMESBindingSource.DataMember = "CURRENCYNAMES";
            this.cURRENCYNAMESBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // cOMPANYBindingSource1
            // 
            this.cOMPANYBindingSource1.DataMember = "COMPANY";
            this.cOMPANYBindingSource1.DataSource = this.dSPOSSTORE;
            // 
            // CCODEtextBox
            // 
            this.CCODEtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPANYBindingSource, "CCODE", true));
            this.CCODEtextBox.Location = new System.Drawing.Point(129, 41);
            this.CCODEtextBox.MaxLength = 2;
            this.CCODEtextBox.Name = "CCODEtextBox";
            this.CCODEtextBox.Size = new System.Drawing.Size(58, 22);
            this.CCODEtextBox.TabIndex = 24;
            // 
            // FrmCompany
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 393);
            this.Controls.Add(this.CCODEtextBox);
            this.Controls.Add(label1);
            this.Controls.Add(tIDLabel);
            this.Controls.Add(this.tIDTextBox);
            this.Controls.Add(cOMPNAMELabel);
            this.Controls.Add(this.cOMPNAMETextBox);
            this.Controls.Add(cOMPADDLabel);
            this.Controls.Add(this.cOMPADDTextBox);
            this.Controls.Add(cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Controls.Add(cOUNTRYLabel);
            this.Controls.Add(this.cOUNTRYTextBox);
            this.Controls.Add(tELEPHONELabel);
            this.Controls.Add(this.tELEPHONETextBox);
            this.Controls.Add(fAXLabel);
            this.Controls.Add(this.fAXTextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(wEBLabel);
            this.Controls.Add(this.wEBTextBox);
            this.Controls.Add(bUSTYPEIDLabel);
            this.Controls.Add(this.bUSTYPEIDComboBox);
            this.Controls.Add(cURRIDLabel);
            this.Controls.Add(this.cURRIDComboBox);
            this.Controls.Add(this.cOMPANYBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "FrmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Setup";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingNavigator)).EndInit();
            this.cOMPANYBindingNavigator.ResumeLayout(false);
            this.cOMPANYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bUSINESSTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYNAMESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSPOSSTORE dSPOSSTORE;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private DSPOSSTORETableAdapters.COMPANYTableAdapter cOMPANYTableAdapter;
        private DSPOSSTORETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cOMPANYBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cOMPANYBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tIDTextBox;
        private System.Windows.Forms.TextBox cOMPNAMETextBox;
        private System.Windows.Forms.TextBox cOMPADDTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
        private System.Windows.Forms.TextBox cOUNTRYTextBox;
        private System.Windows.Forms.TextBox tELEPHONETextBox;
        private System.Windows.Forms.TextBox fAXTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox wEBTextBox;
        private System.Windows.Forms.ComboBox bUSTYPEIDComboBox;
        private System.Windows.Forms.ComboBox cURRIDComboBox;
        private DSPOSSTORETableAdapters.BUSINESSTYPESTableAdapter bUSINESSTYPESTableAdapter;
        private System.Windows.Forms.BindingSource bUSINESSTYPESBindingSource;
        private DSPOSSTORETableAdapters.CURRENCYNAMESTableAdapter cURRENCYNAMESTableAdapter;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource1;
        private System.Windows.Forms.BindingSource cURRENCYNAMESBindingSource;
        private System.Windows.Forms.TextBox CCODEtextBox;


    }
}