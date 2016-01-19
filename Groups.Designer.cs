namespace VIRETAILSTORE
{
    partial class Groups
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
            System.Windows.Forms.Label gROUPIDLabel;
            System.Windows.Forms.Label gROUPNAMELabel;
            System.Windows.Forms.Label cUSSUPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            this.dSPOSSTORE = new VIRETAILSTORE.DSPOSSTORE();
            this.cUSTSUPGROUPSBindingSource = new System.Windows.Forms.BindingSource();
            this.cUSTSUPGROUPSTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.CUSTSUPGROUPSTableAdapter();
            this.tableAdapterManager = new VIRETAILSTORE.DSPOSSTORETableAdapters.TableAdapterManager();
            this.gROUPTYPEMASTTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.GROUPTYPEMASTTableAdapter();
            this.cUSTSUPGROUPSBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cUSTSUPGROUPSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gROUPIDTextBox = new System.Windows.Forms.TextBox();
            this.gROUPNAMETextBox = new System.Windows.Forms.TextBox();
            this.gROUPTYPEMASTBindingSource = new System.Windows.Forms.BindingSource();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            gROUPIDLabel = new System.Windows.Forms.Label();
            gROUPNAMELabel = new System.Windows.Forms.Label();
            cUSSUPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTSUPGROUPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTSUPGROUPSBindingNavigator)).BeginInit();
            this.cUSTSUPGROUPSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPTYPEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            this.SuspendLayout();
            // 
            // gROUPIDLabel
            // 
            gROUPIDLabel.AutoSize = true;
            gROUPIDLabel.Location = new System.Drawing.Point(77, 169);
            gROUPIDLabel.Name = "gROUPIDLabel";
            gROUPIDLabel.Size = new System.Drawing.Size(62, 14);
            gROUPIDLabel.TabIndex = 1;
            gROUPIDLabel.Text = "GROUPID:";
            gROUPIDLabel.Visible = false;
            // 
            // gROUPNAMELabel
            // 
            gROUPNAMELabel.AutoSize = true;
            gROUPNAMELabel.Location = new System.Drawing.Point(28, 57);
            gROUPNAMELabel.Name = "gROUPNAMELabel";
            gROUPNAMELabel.Size = new System.Drawing.Size(78, 14);
            gROUPNAMELabel.TabIndex = 3;
            gROUPNAMELabel.Text = "Group name:";
            // 
            // cUSSUPLabel
            // 
            cUSSUPLabel.AutoSize = true;
            cUSSUPLabel.Location = new System.Drawing.Point(28, 85);
            cUSSUPLabel.Name = "cUSSUPLabel";
            cUSSUPLabel.Size = new System.Drawing.Size(111, 14);
            cUSSUPLabel.TabIndex = 5;
            cUSSUPLabel.Text = "Customer/Supplier:";
            // 
            // dSPOSSTORE
            // 
            this.dSPOSSTORE.DataSetName = "DSPOSSTORE";
            this.dSPOSSTORE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTSUPGROUPSBindingSource
            // 
            this.cUSTSUPGROUPSBindingSource.DataMember = "CUSTSUPGROUPS";
            this.cUSTSUPGROUPSBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // cUSTSUPGROUPSTableAdapter
            // 
            this.cUSTSUPGROUPSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSMASTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSTYPESTableAdapter = null;
            this.tableAdapterManager.COMPANYTableAdapter = null;
            this.tableAdapterManager.CONTACTMASTTableAdapter = null;
            this.tableAdapterManager.CURRENCYNAMESTableAdapter = null;
            this.tableAdapterManager.CUSTSUPGROUPSTableAdapter = this.cUSTSUPGROUPSTableAdapter;
            this.tableAdapterManager.GROUPTYPEMASTTableAdapter = this.gROUPTYPEMASTTableAdapter;
            this.tableAdapterManager.PAYMENTONMASTTableAdapter = null;
            this.tableAdapterManager.PAYTYPEMASTTableAdapter = null;
            this.tableAdapterManager.SHIPPINGMASTTableAdapter = null;
            this.tableAdapterManager.SUPPLIERTableAdapter = null;
            this.tableAdapterManager.TERMSDETAILMASTTableAdapter = null;
            this.tableAdapterManager.TERMSMASTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIRETAILSTORE.DSPOSSTORETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gROUPTYPEMASTTableAdapter
            // 
            this.gROUPTYPEMASTTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTSUPGROUPSBindingNavigator
            // 
            this.cUSTSUPGROUPSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cUSTSUPGROUPSBindingNavigator.BindingSource = this.cUSTSUPGROUPSBindingSource;
            this.cUSTSUPGROUPSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cUSTSUPGROUPSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cUSTSUPGROUPSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cUSTSUPGROUPSBindingNavigatorSaveItem,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.cUSTSUPGROUPSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cUSTSUPGROUPSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cUSTSUPGROUPSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cUSTSUPGROUPSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cUSTSUPGROUPSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cUSTSUPGROUPSBindingNavigator.Name = "cUSTSUPGROUPSBindingNavigator";
            this.cUSTSUPGROUPSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cUSTSUPGROUPSBindingNavigator.Size = new System.Drawing.Size(457, 25);
            this.cUSTSUPGROUPSBindingNavigator.TabIndex = 0;
            this.cUSTSUPGROUPSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::VIRETAILSTORE.Properties.Resources.NewAdd16;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::VIRETAILSTORE.Properties.Resources.Delete16;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cUSTSUPGROUPSBindingNavigatorSaveItem
            // 
            this.cUSTSUPGROUPSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cUSTSUPGROUPSBindingNavigatorSaveItem.Image = global::VIRETAILSTORE.Properties.Resources.Save16;
            this.cUSTSUPGROUPSBindingNavigatorSaveItem.Name = "cUSTSUPGROUPSBindingNavigatorSaveItem";
            this.cUSTSUPGROUPSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cUSTSUPGROUPSBindingNavigatorSaveItem.Text = "Save Data";
            this.cUSTSUPGROUPSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cUSTSUPGROUPSBindingNavigatorSaveItem_Click_3);
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
            // gROUPIDTextBox
            // 
            this.gROUPIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTSUPGROUPSBindingSource, "GROUPID", true));
            this.gROUPIDTextBox.Location = new System.Drawing.Point(170, 166);
            this.gROUPIDTextBox.Name = "gROUPIDTextBox";
            this.gROUPIDTextBox.Size = new System.Drawing.Size(140, 22);
            this.gROUPIDTextBox.TabIndex = 2;
            this.gROUPIDTextBox.Visible = false;
            // 
            // gROUPNAMETextBox
            // 
            this.gROUPNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTSUPGROUPSBindingSource, "GROUPNAME", true));
            this.gROUPNAMETextBox.Location = new System.Drawing.Point(150, 54);
            this.gROUPNAMETextBox.Name = "gROUPNAMETextBox";
            this.gROUPNAMETextBox.Size = new System.Drawing.Size(292, 22);
            this.gROUPNAMETextBox.TabIndex = 4;
            // 
            // gROUPTYPEMASTBindingSource
            // 
            this.gROUPTYPEMASTBindingSource.DataMember = "GROUPTYPEMAST";
            this.gROUPTYPEMASTBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 17;
            this.c1Combo1.ColumnFooterHeight = 17;
            this.c1Combo1.ColumnHeaders = false;
            this.c1Combo1.ContentHeight = 15;
            this.c1Combo1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTSUPGROUPSBindingSource, "CUSSUP", true));
            this.c1Combo1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gROUPTYPEMASTBindingSource, "GROUPTYPE", true));
            this.c1Combo1.DataSource = this.gROUPTYPEMASTBindingSource;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.DisplayMember = "GROUPTYPE";
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Tahoma", 8F);
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 15;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(150, 82);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(293, 21);
            this.c1Combo1.TabIndex = 7;
            this.c1Combo1.Text = "c1Combo1";
            this.c1Combo1.ValueMember = "GROUPTYPE";
            this.c1Combo1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // Groups
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 123);
            this.Controls.Add(this.c1Combo1);
            this.Controls.Add(gROUPIDLabel);
            this.Controls.Add(this.gROUPIDTextBox);
            this.Controls.Add(gROUPNAMELabel);
            this.Controls.Add(this.gROUPNAMETextBox);
            this.Controls.Add(cUSSUPLabel);
            this.Controls.Add(this.cUSTSUPGROUPSBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groups Master";
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTSUPGROUPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTSUPGROUPSBindingNavigator)).EndInit();
            this.cUSTSUPGROUPSBindingNavigator.ResumeLayout(false);
            this.cUSTSUPGROUPSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPTYPEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSPOSSTORE dSPOSSTORE;
        private System.Windows.Forms.BindingSource cUSTSUPGROUPSBindingSource;
        private DSPOSSTORETableAdapters.CUSTSUPGROUPSTableAdapter cUSTSUPGROUPSTableAdapter;
        private DSPOSSTORETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cUSTSUPGROUPSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cUSTSUPGROUPSBindingNavigatorSaveItem;
        private DSPOSSTORETableAdapters.GROUPTYPEMASTTableAdapter gROUPTYPEMASTTableAdapter;
        private System.Windows.Forms.TextBox gROUPIDTextBox;
        private System.Windows.Forms.TextBox gROUPNAMETextBox;
        private System.Windows.Forms.BindingSource gROUPTYPEMASTBindingSource;
        private C1.Win.C1List.C1Combo c1Combo1;



    }
}