namespace VIRETAILSTORE
{
    partial class Shipping
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
            System.Windows.Forms.Label sHIPIDLabel;
            System.Windows.Forms.Label sHIPTYPELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shipping));
            this.dSPOSSTORE = new VIRETAILSTORE.DSPOSSTORE();
            this.sHIPPINGMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sHIPPINGMASTTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.SHIPPINGMASTTableAdapter();
            this.tableAdapterManager = new VIRETAILSTORE.DSPOSSTORETableAdapters.TableAdapterManager();
            this.sHIPPINGMASTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sHIPPINGMASTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sHIPIDTextBox = new System.Windows.Forms.TextBox();
            this.sHIPTYPETextBox = new System.Windows.Forms.TextBox();
            sHIPIDLabel = new System.Windows.Forms.Label();
            sHIPTYPELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHIPPINGMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHIPPINGMASTBindingNavigator)).BeginInit();
            this.sHIPPINGMASTBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sHIPIDLabel
            // 
            sHIPIDLabel.AutoSize = true;
            sHIPIDLabel.Location = new System.Drawing.Point(42, 93);
            sHIPIDLabel.Name = "sHIPIDLabel";
            sHIPIDLabel.Size = new System.Drawing.Size(49, 14);
            sHIPIDLabel.TabIndex = 1;
            sHIPIDLabel.Text = "SHIPID:";
            sHIPIDLabel.Visible = false;
            // 
            // sHIPTYPELabel
            // 
            sHIPTYPELabel.AutoSize = true;
            sHIPTYPELabel.Location = new System.Drawing.Point(26, 47);
            sHIPTYPELabel.Name = "sHIPTYPELabel";
            sHIPTYPELabel.Size = new System.Drawing.Size(89, 14);
            sHIPTYPELabel.TabIndex = 3;
            sHIPTYPELabel.Text = "Shipping Type:";
            // 
            // dSPOSSTORE
            // 
            this.dSPOSSTORE.DataSetName = "DSPOSSTORE";
            this.dSPOSSTORE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sHIPPINGMASTBindingSource
            // 
            this.sHIPPINGMASTBindingSource.DataMember = "SHIPPINGMAST";
            this.sHIPPINGMASTBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // sHIPPINGMASTTableAdapter
            // 
            this.sHIPPINGMASTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSMASTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSTYPESTableAdapter = null;
            this.tableAdapterManager.COMPANYTableAdapter = null;
            this.tableAdapterManager.CONTACTMASTTableAdapter = null;
            this.tableAdapterManager.CURRENCYNAMESTableAdapter = null;
            this.tableAdapterManager.CUSTSUPGROUPSTableAdapter = null;
            this.tableAdapterManager.GROUPTYPEMASTTableAdapter = null;
            this.tableAdapterManager.PAYMENTONMASTTableAdapter = null;
            this.tableAdapterManager.PAYTYPEMASTTableAdapter = null;
            this.tableAdapterManager.SHIPPINGMASTTableAdapter = this.sHIPPINGMASTTableAdapter;
            this.tableAdapterManager.SUPPLIERTableAdapter = null;
            this.tableAdapterManager.TERMSDETAILMASTTableAdapter = null;
            this.tableAdapterManager.TERMSMASTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIRETAILSTORE.DSPOSSTORETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sHIPPINGMASTBindingNavigator
            // 
            this.sHIPPINGMASTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sHIPPINGMASTBindingNavigator.BindingSource = this.sHIPPINGMASTBindingSource;
            this.sHIPPINGMASTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sHIPPINGMASTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sHIPPINGMASTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sHIPPINGMASTBindingNavigatorSaveItem,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.sHIPPINGMASTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sHIPPINGMASTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sHIPPINGMASTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sHIPPINGMASTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sHIPPINGMASTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sHIPPINGMASTBindingNavigator.Name = "sHIPPINGMASTBindingNavigator";
            this.sHIPPINGMASTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sHIPPINGMASTBindingNavigator.Size = new System.Drawing.Size(476, 25);
            this.sHIPPINGMASTBindingNavigator.TabIndex = 0;
            this.sHIPPINGMASTBindingNavigator.Text = "bindingNavigator1";
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
            // sHIPPINGMASTBindingNavigatorSaveItem
            // 
            this.sHIPPINGMASTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sHIPPINGMASTBindingNavigatorSaveItem.Image = global::VIRETAILSTORE.Properties.Resources.Save16;
            this.sHIPPINGMASTBindingNavigatorSaveItem.Name = "sHIPPINGMASTBindingNavigatorSaveItem";
            this.sHIPPINGMASTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sHIPPINGMASTBindingNavigatorSaveItem.Text = "Save Data";
            this.sHIPPINGMASTBindingNavigatorSaveItem.Click += new System.EventHandler(this.sHIPPINGMASTBindingNavigatorSaveItem_Click);
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
            // sHIPIDTextBox
            // 
            this.sHIPIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHIPPINGMASTBindingSource, "SHIPID", true));
            this.sHIPIDTextBox.Location = new System.Drawing.Point(117, 89);
            this.sHIPIDTextBox.Name = "sHIPIDTextBox";
            this.sHIPIDTextBox.Size = new System.Drawing.Size(116, 22);
            this.sHIPIDTextBox.TabIndex = 2;
            this.sHIPIDTextBox.Visible = false;
            // 
            // sHIPTYPETextBox
            // 
            this.sHIPTYPETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHIPPINGMASTBindingSource, "SHIPTYPE", true));
            this.sHIPTYPETextBox.Location = new System.Drawing.Point(132, 44);
            this.sHIPTYPETextBox.Name = "sHIPTYPETextBox";
            this.sHIPTYPETextBox.Size = new System.Drawing.Size(331, 22);
            this.sHIPTYPETextBox.TabIndex = 4;
            // 
            // Shipping
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 157);
            this.Controls.Add(sHIPIDLabel);
            this.Controls.Add(this.sHIPIDTextBox);
            this.Controls.Add(sHIPTYPELabel);
            this.Controls.Add(this.sHIPTYPETextBox);
            this.Controls.Add(this.sHIPPINGMASTBindingNavigator);
            this.Name = "Shipping";
            this.Text = "Shipping";
            this.Load += new System.EventHandler(this.Shipping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHIPPINGMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHIPPINGMASTBindingNavigator)).EndInit();
            this.sHIPPINGMASTBindingNavigator.ResumeLayout(false);
            this.sHIPPINGMASTBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSPOSSTORE dSPOSSTORE;
        private System.Windows.Forms.BindingSource sHIPPINGMASTBindingSource;
        private DSPOSSTORETableAdapters.SHIPPINGMASTTableAdapter sHIPPINGMASTTableAdapter;
        private DSPOSSTORETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sHIPPINGMASTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sHIPPINGMASTBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sHIPIDTextBox;
        private System.Windows.Forms.TextBox sHIPTYPETextBox;
    }
}