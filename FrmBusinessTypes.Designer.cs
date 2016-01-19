namespace VIRETAILSTORE
{
    partial class FrmBusinessTypes
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
            System.Windows.Forms.Label bUSTYPEIDLabel;
            System.Windows.Forms.Label nAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusinessTypes));
            this.dSPOSSTORE = new VIRETAILSTORE.DSPOSSTORE();
            this.bUSINESSTYPESBindingSource = new System.Windows.Forms.BindingSource();
            this.bUSINESSTYPESTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.BUSINESSTYPESTableAdapter();
            this.tableAdapterManager = new VIRETAILSTORE.DSPOSSTORETableAdapters.TableAdapterManager();
            this.bUSTYPEIDTextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bUSINESSTYPESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bUSINESSTYPESBindingNavigator = new System.Windows.Forms.BindingNavigator();
            bUSTYPEIDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSINESSTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSINESSTYPESBindingNavigator)).BeginInit();
            this.bUSINESSTYPESBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bUSTYPEIDLabel
            // 
            bUSTYPEIDLabel.AutoSize = true;
            bUSTYPEIDLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bUSTYPEIDLabel.Location = new System.Drawing.Point(41, 41);
            bUSTYPEIDLabel.Name = "bUSTYPEIDLabel";
            bUSTYPEIDLabel.Size = new System.Drawing.Size(49, 14);
            bUSTYPEIDLabel.TabIndex = 1;
            bUSTYPEIDLabel.Text = "Auto Id:";
            bUSTYPEIDLabel.Visible = false;
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMELabel.Location = new System.Drawing.Point(41, 69);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(87, 14);
            nAMELabel.TabIndex = 3;
            nAMELabel.Text = "Business Type:";
            // 
            // dSPOSSTORE
            // 
            this.dSPOSSTORE.DataSetName = "DSPOSSTORE";
            this.dSPOSSTORE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bUSINESSTYPESBindingSource
            // 
            this.bUSINESSTYPESBindingSource.DataMember = "BUSINESSTYPES";
            this.bUSINESSTYPESBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // bUSINESSTYPESTableAdapter
            // 
            this.bUSINESSTYPESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSMASTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSTYPESTableAdapter = this.bUSINESSTYPESTableAdapter;
            this.tableAdapterManager.COMPANYTableAdapter = null;
            this.tableAdapterManager.CONTACTMASTTableAdapter = null;
            this.tableAdapterManager.CURRENCYNAMESTableAdapter = null;
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
            // bUSTYPEIDTextBox
            // 
            this.bUSTYPEIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bUSINESSTYPESBindingSource, "BUSTYPEID", true));
            this.bUSTYPEIDTextBox.Location = new System.Drawing.Point(129, 37);
            this.bUSTYPEIDTextBox.Name = "bUSTYPEIDTextBox";
            this.bUSTYPEIDTextBox.Size = new System.Drawing.Size(80, 22);
            this.bUSTYPEIDTextBox.TabIndex = 2;
            this.bUSTYPEIDTextBox.Visible = false;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bUSINESSTYPESBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(129, 65);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(285, 22);
            this.nAMETextBox.TabIndex = 4;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::VIRETAILSTORE.Properties.Resources.NewAdd16;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bUSINESSTYPESBindingNavigatorSaveItem
            // 
            this.bUSINESSTYPESBindingNavigatorSaveItem.Image = global::VIRETAILSTORE.Properties.Resources.Save16;
            this.bUSINESSTYPESBindingNavigatorSaveItem.Name = "bUSINESSTYPESBindingNavigatorSaveItem";
            this.bUSINESSTYPESBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.bUSINESSTYPESBindingNavigatorSaveItem.Text = "Save Data";
            this.bUSINESSTYPESBindingNavigatorSaveItem.Click += new System.EventHandler(this.bUSINESSTYPESBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::VIRETAILSTORE.Properties.Resources.Delete16;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bUSINESSTYPESBindingNavigator
            // 
            this.bUSINESSTYPESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bUSINESSTYPESBindingNavigator.BindingSource = this.bUSINESSTYPESBindingSource;
            this.bUSINESSTYPESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bUSINESSTYPESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bUSINESSTYPESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bUSINESSTYPESBindingNavigatorSaveItem,
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
            this.bUSINESSTYPESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bUSINESSTYPESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bUSINESSTYPESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bUSINESSTYPESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bUSINESSTYPESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bUSINESSTYPESBindingNavigator.Name = "bUSINESSTYPESBindingNavigator";
            this.bUSINESSTYPESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bUSINESSTYPESBindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.bUSINESSTYPESBindingNavigator.TabIndex = 0;
            this.bUSINESSTYPESBindingNavigator.Text = "bindingNavigator1";
            // 
            // FrmBusinessTypes
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 99);
            this.Controls.Add(bUSTYPEIDLabel);
            this.Controls.Add(this.bUSTYPEIDTextBox);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(this.bUSINESSTYPESBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "FrmBusinessTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusinessTypes";
            this.Load += new System.EventHandler(this.FrmBusinessTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSINESSTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSINESSTYPESBindingNavigator)).EndInit();
            this.bUSINESSTYPESBindingNavigator.ResumeLayout(false);
            this.bUSINESSTYPESBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSPOSSTORE dSPOSSTORE;
        private System.Windows.Forms.BindingSource bUSINESSTYPESBindingSource;
        private DSPOSSTORETableAdapters.BUSINESSTYPESTableAdapter bUSINESSTYPESTableAdapter;
        private DSPOSSTORETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox bUSTYPEIDTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bUSINESSTYPESBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bUSINESSTYPESBindingNavigator;
    }
}