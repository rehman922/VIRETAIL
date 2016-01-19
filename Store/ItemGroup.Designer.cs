using System.ComponentModel;
using System.Windows.Forms;
using VIRETAILENTITIES;

namespace Store
{
    partial class ItemGroup
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
            System.Windows.Forms.Label gROUPIDLabel;
            System.Windows.Forms.Label gROUPNAMELabel;
            System.Windows.Forms.Label aRGROUPNAMELabel;
            System.Windows.Forms.Label fIXDISCLabel;
            System.Windows.Forms.Label uPDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemGroup));
            this.iTEMGROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMGROUPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.iTEMGROUPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.aRGROUPNAMETextBox = new System.Windows.Forms.TextBox();
            this.fIXDISCTextBox = new System.Windows.Forms.TextBox();
            this.uPDCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsMaster = new VIRETAILENTITIES.DsMaster();
            gROUPIDLabel = new System.Windows.Forms.Label();
            gROUPNAMELabel = new System.Windows.Forms.Label();
            aRGROUPNAMELabel = new System.Windows.Forms.Label();
            fIXDISCLabel = new System.Windows.Forms.Label();
            uPDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingNavigator)).BeginInit();
            this.iTEMGROUPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // gROUPIDLabel
            // 
            gROUPIDLabel.AutoSize = true;
            gROUPIDLabel.Location = new System.Drawing.Point(100, 186);
            gROUPIDLabel.Name = "gROUPIDLabel";
            gROUPIDLabel.Size = new System.Drawing.Size(62, 14);
            gROUPIDLabel.TabIndex = 1;
            gROUPIDLabel.Text = "GROUPID:";
            gROUPIDLabel.Visible = false;
            // 
            // gROUPNAMELabel
            // 
            gROUPNAMELabel.AutoSize = true;
            gROUPNAMELabel.Location = new System.Drawing.Point(63, 42);
            gROUPNAMELabel.Name = "gROUPNAMELabel";
            gROUPNAMELabel.Size = new System.Drawing.Size(78, 14);
            gROUPNAMELabel.TabIndex = 3;
            gROUPNAMELabel.Text = "Group name:";
            // 
            // aRGROUPNAMELabel
            // 
            aRGROUPNAMELabel.AutoSize = true;
            aRGROUPNAMELabel.Location = new System.Drawing.Point(63, 70);
            aRGROUPNAMELabel.Name = "aRGROUPNAMELabel";
            aRGROUPNAMELabel.Size = new System.Drawing.Size(94, 14);
            aRGROUPNAMELabel.TabIndex = 5;
            aRGROUPNAMELabel.Text = "Ar Group name:";
            // 
            // fIXDISCLabel
            // 
            fIXDISCLabel.AutoSize = true;
            fIXDISCLabel.Location = new System.Drawing.Point(63, 98);
            fIXDISCLabel.Name = "fIXDISCLabel";
            fIXDISCLabel.Size = new System.Drawing.Size(50, 14);
            fIXDISCLabel.TabIndex = 7;
            fIXDISCLabel.Text = "Fix Disc:";
            // 
            // uPDLabel
            // 
            uPDLabel.AutoSize = true;
            uPDLabel.Location = new System.Drawing.Point(63, 128);
            uPDLabel.Name = "uPDLabel";
            uPDLabel.Size = new System.Drawing.Size(98, 14);
            uPDLabel.TabIndex = 9;
            uPDLabel.Text = "Remote Update:";
            // 
            // iTEMGROUPBindingSource
            // 
            this.iTEMGROUPBindingSource.DataMember = "ITEMGROUP";
            this.iTEMGROUPBindingSource.DataSource = this.dsMaster;
            // 
            // iTEMGROUPBindingNavigator
            // 
            this.iTEMGROUPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTEMGROUPBindingNavigator.BindingSource = this.iTEMGROUPBindingSource;
            this.iTEMGROUPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTEMGROUPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTEMGROUPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.iTEMGROUPBindingNavigatorSaveItem,
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
            this.iTEMGROUPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTEMGROUPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTEMGROUPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTEMGROUPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTEMGROUPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTEMGROUPBindingNavigator.Name = "iTEMGROUPBindingNavigator";
            this.iTEMGROUPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTEMGROUPBindingNavigator.Size = new System.Drawing.Size(520, 25);
            this.iTEMGROUPBindingNavigator.TabIndex = 0;
            this.iTEMGROUPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Store.Properties.Resources.NewAdd16;
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
            this.bindingNavigatorDeleteItem.Image = global::Store.Properties.Resources.Delete16;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // iTEMGROUPBindingNavigatorSaveItem
            // 
            this.iTEMGROUPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTEMGROUPBindingNavigatorSaveItem.Enabled = false;
            this.iTEMGROUPBindingNavigatorSaveItem.Image = global::Store.Properties.Resources.Save16;
            this.iTEMGROUPBindingNavigatorSaveItem.Name = "iTEMGROUPBindingNavigatorSaveItem";
            this.iTEMGROUPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTEMGROUPBindingNavigatorSaveItem.Text = "Save Data";
            this.iTEMGROUPBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTEMGROUPBindingNavigatorSaveItem_Click);
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
            this.gROUPIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMGROUPBindingSource, "GROUPID", true));
            this.gROUPIDTextBox.Location = new System.Drawing.Point(215, 183);
            this.gROUPIDTextBox.Name = "gROUPIDTextBox";
            this.gROUPIDTextBox.Size = new System.Drawing.Size(121, 22);
            this.gROUPIDTextBox.TabIndex = 2;
            this.gROUPIDTextBox.Visible = false;
            // 
            // gROUPNAMETextBox
            // 
            this.gROUPNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMGROUPBindingSource, "GROUPNAME", true));
            this.gROUPNAMETextBox.Location = new System.Drawing.Point(177, 39);
            this.gROUPNAMETextBox.Name = "gROUPNAMETextBox";
            this.gROUPNAMETextBox.Size = new System.Drawing.Size(318, 22);
            this.gROUPNAMETextBox.TabIndex = 4;
            // 
            // aRGROUPNAMETextBox
            // 
            this.aRGROUPNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMGROUPBindingSource, "ARGROUPNAME", true));
            this.aRGROUPNAMETextBox.Location = new System.Drawing.Point(177, 67);
            this.aRGROUPNAMETextBox.Name = "aRGROUPNAMETextBox";
            this.aRGROUPNAMETextBox.Size = new System.Drawing.Size(318, 22);
            this.aRGROUPNAMETextBox.TabIndex = 6;
            // 
            // fIXDISCTextBox
            // 
            this.fIXDISCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMGROUPBindingSource, "FIXDISC", true));
            this.fIXDISCTextBox.Location = new System.Drawing.Point(177, 95);
            this.fIXDISCTextBox.Name = "fIXDISCTextBox";
            this.fIXDISCTextBox.Size = new System.Drawing.Size(121, 22);
            this.fIXDISCTextBox.TabIndex = 8;
            // 
            // uPDCheckBox
            // 
            this.uPDCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.iTEMGROUPBindingSource, "UPD", true));
            this.uPDCheckBox.Location = new System.Drawing.Point(177, 123);
            this.uPDCheckBox.Name = "uPDCheckBox";
            this.uPDCheckBox.Size = new System.Drawing.Size(19, 24);
            this.uPDCheckBox.TabIndex = 10;
            this.uPDCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "%";
            // 
            // dsMaster
            // 
            this.dsMaster.DataSetName = "DsMaster";
            this.dsMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemGroup
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(gROUPIDLabel);
            this.Controls.Add(this.gROUPIDTextBox);
            this.Controls.Add(gROUPNAMELabel);
            this.Controls.Add(this.gROUPNAMETextBox);
            this.Controls.Add(aRGROUPNAMELabel);
            this.Controls.Add(this.aRGROUPNAMETextBox);
            this.Controls.Add(fIXDISCLabel);
            this.Controls.Add(this.fIXDISCTextBox);
            this.Controls.Add(uPDLabel);
            this.Controls.Add(this.uPDCheckBox);
            this.Controls.Add(this.iTEMGROUPBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Group";
            this.Load += new System.EventHandler(this.ItemGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingNavigator)).EndInit();
            this.iTEMGROUPBindingNavigator.ResumeLayout(false);
            this.iTEMGROUPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource iTEMGROUPBindingSource;
        private BindingNavigator iTEMGROUPBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton iTEMGROUPBindingNavigatorSaveItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private TextBox gROUPIDTextBox;
        private TextBox gROUPNAMETextBox;
        private TextBox aRGROUPNAMETextBox;
        private TextBox fIXDISCTextBox;
        private CheckBox uPDCheckBox;
        private Label label1;
        private DsMaster dsMaster;


    }
}