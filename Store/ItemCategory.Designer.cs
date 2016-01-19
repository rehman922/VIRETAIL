using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILENTITIES;

namespace Store
{
    partial class ItemCategory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cATIDLabel;
            System.Windows.Forms.Label aRCATNAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCategory));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cATEGORYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cATEGORYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cATIDTextBox = new System.Windows.Forms.TextBox();
            this.cATNAMETextBox = new System.Windows.Forms.TextBox();
            this.aRCATNAMETextBox = new System.Windows.Forms.TextBox();
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            cATIDLabel = new System.Windows.Forms.Label();
            aRCATNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingNavigator)).BeginInit();
            this.cATEGORYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            this.SuspendLayout();
            // 
            // cATIDLabel
            // 
            cATIDLabel.AutoSize = true;
            cATIDLabel.Location = new System.Drawing.Point(182, 126);
            cATIDLabel.Name = "cATIDLabel";
            cATIDLabel.Size = new System.Drawing.Size(46, 14);
            cATIDLabel.TabIndex = 3;
            cATIDLabel.Text = "CATID:";
            cATIDLabel.Visible = false;
            // 
            // aRCATNAMELabel
            // 
            aRCATNAMELabel.AutoSize = true;
            aRCATNAMELabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aRCATNAMELabel.Location = new System.Drawing.Point(9, 81);
            aRCATNAMELabel.Name = "aRCATNAMELabel";
            aRCATNAMELabel.Size = new System.Drawing.Size(141, 14);
            aRCATNAMELabel.TabIndex = 6;
            aRCATNAMELabel.Text = "Category name (Arabic):";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(9, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Category name:";
            // 
            // cATEGORYBindingNavigator
            // 
            this.cATEGORYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cATEGORYBindingNavigator.BindingSource = this.cATEGORYBindingSource;
            this.cATEGORYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cATEGORYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cATEGORYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.cATEGORYBindingNavigatorSaveItem,
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
            this.cATEGORYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cATEGORYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cATEGORYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cATEGORYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cATEGORYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cATEGORYBindingNavigator.Name = "cATEGORYBindingNavigator";
            this.cATEGORYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cATEGORYBindingNavigator.Size = new System.Drawing.Size(543, 25);
            this.cATEGORYBindingNavigator.TabIndex = 3;
            this.cATEGORYBindingNavigator.Text = "bindingNavigator1";
            this.cATEGORYBindingNavigator.RefreshItems += new System.EventHandler(this.cATEGORYBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Store.Properties.Resources.NewAdd16;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
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
            this.bindingNavigatorDeleteItem.Image = global::Store.Properties.Resources.Delete16;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cATEGORYBindingNavigatorSaveItem
            // 
            this.cATEGORYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cATEGORYBindingNavigatorSaveItem.Image = global::Store.Properties.Resources.Save16;
            this.cATEGORYBindingNavigatorSaveItem.Name = "cATEGORYBindingNavigatorSaveItem";
            this.cATEGORYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cATEGORYBindingNavigatorSaveItem.Text = "Save Data";
            this.cATEGORYBindingNavigatorSaveItem.Click += new System.EventHandler(this.cATEGORYBindingNavigatorSaveItem_Click);
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
            // cATIDTextBox
            // 
            this.cATIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATEGORYBindingSource, "CATID", true));
            this.cATIDTextBox.Location = new System.Drawing.Point(258, 123);
            this.cATIDTextBox.Name = "cATIDTextBox";
            this.cATIDTextBox.Size = new System.Drawing.Size(116, 22);
            this.cATIDTextBox.TabIndex = 4;
            this.cATIDTextBox.Visible = false;
            // 
            // cATNAMETextBox
            // 
            this.cATNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATEGORYBindingSource, "CATNAME", true));
            this.cATNAMETextBox.Location = new System.Drawing.Point(156, 50);
            this.cATNAMETextBox.Name = "cATNAMETextBox";
            this.cATNAMETextBox.Size = new System.Drawing.Size(346, 22);
            this.cATNAMETextBox.TabIndex = 6;
            // 
            // aRCATNAMETextBox
            // 
            this.aRCATNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATEGORYBindingSource, "ARCATNAME", true));
            this.aRCATNAMETextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aRCATNAMETextBox.Location = new System.Drawing.Point(156, 78);
            this.aRCATNAMETextBox.Name = "aRCATNAMETextBox";
            this.aRCATNAMETextBox.Size = new System.Drawing.Size(346, 21);
            this.aRCATNAMETextBox.TabIndex = 7;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemCategory
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 116);
            this.Controls.Add(aRCATNAMELabel);
            this.Controls.Add(this.aRCATNAMETextBox);
            this.Controls.Add(cATIDLabel);
            this.Controls.Add(this.cATIDTextBox);
            this.Controls.Add(this.cATNAMETextBox);
            this.Controls.Add(this.cATEGORYBindingNavigator);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemCategory";
            this.Text = "Item Category";
            this.Load += new System.EventHandler(this.ItemCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingNavigator)).EndInit();
            this.cATEGORYBindingNavigator.ResumeLayout(false);
            this.cATEGORYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private BindingSource cATEGORYBindingSource;
        private BindingNavigator cATEGORYBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton cATEGORYBindingNavigatorSaveItem;
        private TextBox cATIDTextBox;
        private TextBox cATNAMETextBox;
        private TextBox aRCATNAMETextBox;
     
        private DsMaster dsMaster1;
    }
}