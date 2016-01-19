namespace VIRETAILSTORE
{
    partial class Frmcurrency
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
            System.Windows.Forms.Label cCODELabel;
            System.Windows.Forms.Label cURRENCYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcurrency));
            this.dSPOSSTORE = new VIRETAILSTORE.DSPOSSTORE();
            this.cURRENCYNAMESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cURRENCYNAMESTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.CURRENCYNAMESTableAdapter();
            this.tableAdapterManager = new VIRETAILSTORE.DSPOSSTORETableAdapters.TableAdapterManager();
            this.cURRENCYNAMESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cURRENCYNAMESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cCODETextBox = new System.Windows.Forms.TextBox();
            this.cURRENCYTextBox = new System.Windows.Forms.TextBox();
            cCODELabel = new System.Windows.Forms.Label();
            cURRENCYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYNAMESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYNAMESBindingNavigator)).BeginInit();
            this.cURRENCYNAMESBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cCODELabel
            // 
            cCODELabel.AutoSize = true;
            cCODELabel.Location = new System.Drawing.Point(28, 48);
            cCODELabel.Name = "cCODELabel";
            cCODELabel.Size = new System.Drawing.Size(91, 14);
            cCODELabel.TabIndex = 1;
            cCODELabel.Text = "Currency Code:";
            // 
            // cURRENCYLabel
            // 
            cURRENCYLabel.AutoSize = true;
            cURRENCYLabel.Location = new System.Drawing.Point(26, 76);
            cURRENCYLabel.Name = "cURRENCYLabel";
            cURRENCYLabel.Size = new System.Drawing.Size(94, 14);
            cURRENCYLabel.TabIndex = 3;
            cURRENCYLabel.Text = "Currency Name:";
            // 
            // dSPOSSTORE
            // 
            this.dSPOSSTORE.DataSetName = "DSPOSSTORE";
            this.dSPOSSTORE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cURRENCYNAMESBindingSource
            // 
            this.cURRENCYNAMESBindingSource.DataMember = "CURRENCYNAMES";
            this.cURRENCYNAMESBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // cURRENCYNAMESTableAdapter
            // 
            this.cURRENCYNAMESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSMASTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSTYPESTableAdapter = null;
            this.tableAdapterManager.COMPANYTableAdapter = null;
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
            // cURRENCYNAMESBindingNavigator
            // 
            this.cURRENCYNAMESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cURRENCYNAMESBindingNavigator.BindingSource = this.cURRENCYNAMESBindingSource;
            this.cURRENCYNAMESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cURRENCYNAMESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cURRENCYNAMESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.cURRENCYNAMESBindingNavigatorSaveItem,
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
            this.cURRENCYNAMESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cURRENCYNAMESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cURRENCYNAMESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cURRENCYNAMESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cURRENCYNAMESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cURRENCYNAMESBindingNavigator.Name = "cURRENCYNAMESBindingNavigator";
            this.cURRENCYNAMESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cURRENCYNAMESBindingNavigator.Size = new System.Drawing.Size(456, 25);
            this.cURRENCYNAMESBindingNavigator.TabIndex = 0;
            this.cURRENCYNAMESBindingNavigator.Text = "bindingNavigator1";
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
            // 
            // cURRENCYNAMESBindingNavigatorSaveItem
            // 
            this.cURRENCYNAMESBindingNavigatorSaveItem.Image = global::VIRETAILSTORE.Properties.Resources.Save16;
            this.cURRENCYNAMESBindingNavigatorSaveItem.Name = "cURRENCYNAMESBindingNavigatorSaveItem";
            this.cURRENCYNAMESBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.cURRENCYNAMESBindingNavigatorSaveItem.Text = "Save Data";
            this.cURRENCYNAMESBindingNavigatorSaveItem.Click += new System.EventHandler(this.cURRENCYNAMESBindingNavigatorSaveItem_Click_3);
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
            // cCODETextBox
            // 
            this.cCODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURRENCYNAMESBindingSource, "CCODE", true));
            this.cCODETextBox.Location = new System.Drawing.Point(126, 45);
            this.cCODETextBox.Name = "cCODETextBox";
            this.cCODETextBox.Size = new System.Drawing.Size(116, 22);
            this.cCODETextBox.TabIndex = 2;
            // 
            // cURRENCYTextBox
            // 
            this.cURRENCYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURRENCYNAMESBindingSource, "CURRENCY", true));
            this.cURRENCYTextBox.Location = new System.Drawing.Point(126, 73);
            this.cURRENCYTextBox.Name = "cURRENCYTextBox";
            this.cURRENCYTextBox.Size = new System.Drawing.Size(313, 22);
            this.cURRENCYTextBox.TabIndex = 4;
            // 
            // Frmcurrency
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 107);
            this.Controls.Add(cCODELabel);
            this.Controls.Add(this.cCODETextBox);
            this.Controls.Add(cURRENCYLabel);
            this.Controls.Add(this.cURRENCYTextBox);
            this.Controls.Add(this.cURRENCYNAMESBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmcurrency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Set up";
            this.Load += new System.EventHandler(this.Frmcurrency_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmcurrency_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYNAMESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYNAMESBindingNavigator)).EndInit();
            this.cURRENCYNAMESBindingNavigator.ResumeLayout(false);
            this.cURRENCYNAMESBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSPOSSTORE dSPOSSTORE;
        private System.Windows.Forms.BindingSource cURRENCYNAMESBindingSource;
        private DSPOSSTORETableAdapters.CURRENCYNAMESTableAdapter cURRENCYNAMESTableAdapter;
        private DSPOSSTORETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cURRENCYNAMESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cURRENCYNAMESBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cCODETextBox;
        private System.Windows.Forms.TextBox cURRENCYTextBox;




    }
}