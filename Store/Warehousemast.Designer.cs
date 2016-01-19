using System.ComponentModel;
using System.Windows.Forms;
using VIRETAILDAL.DsMasterTableAdapters;
using VIRETAILENTITIES;

namespace Store
{
    partial class Warehousemast
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
            System.Windows.Forms.Label wHNAMELabel;
            System.Windows.Forms.Label sELLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehousemast));
            this.wAREHOUSEMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wAREHOUSEMASTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.wAREHOUSEMASTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.wHIDTextBox = new System.Windows.Forms.TextBox();
            this.wHNAMETextBox = new System.Windows.Forms.TextBox();
            this.sELCheckBox = new System.Windows.Forms.CheckBox();
            this.pERTextBox = new System.Windows.Forms.TextBox();
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.tableAdapterManager = new VIRETAILDAL.DsMasterTableAdapters.TableAdapterManager();
            this.warehousemastTableAdapter = new VIRETAILDAL.DsMasterTableAdapters.WAREHOUSEMASTTableAdapter();
            wHNAMELabel = new System.Windows.Forms.Label();
            sELLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingNavigator)).BeginInit();
            this.wAREHOUSEMASTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            this.SuspendLayout();
            // 
            // wHNAMELabel
            // 
            wHNAMELabel.AutoSize = true;
            wHNAMELabel.Location = new System.Drawing.Point(35, 37);
            wHNAMELabel.Name = "wHNAMELabel";
            wHNAMELabel.Size = new System.Drawing.Size(107, 14);
            wHNAMELabel.TabIndex = 3;
            wHNAMELabel.Text = "Warehouse name:";
            // 
            // sELLabel
            // 
            sELLabel.AutoSize = true;
            sELLabel.Location = new System.Drawing.Point(35, 62);
            sELLabel.Name = "sELLabel";
            sELLabel.Size = new System.Drawing.Size(45, 14);
            sELLabel.TabIndex = 5;
            sELLabel.Text = "Active:";
            sELLabel.Visible = false;
            // 
            // wAREHOUSEMASTBindingSource
            // 
            this.wAREHOUSEMASTBindingSource.DataMember = "WAREHOUSEMAST";
            this.wAREHOUSEMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // wAREHOUSEMASTBindingNavigator
            // 
            this.wAREHOUSEMASTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.wAREHOUSEMASTBindingNavigator.BindingSource = this.wAREHOUSEMASTBindingSource;
            this.wAREHOUSEMASTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.wAREHOUSEMASTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.wAREHOUSEMASTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.wAREHOUSEMASTBindingNavigatorSaveItem,
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
            this.wAREHOUSEMASTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.wAREHOUSEMASTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.wAREHOUSEMASTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.wAREHOUSEMASTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.wAREHOUSEMASTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.wAREHOUSEMASTBindingNavigator.Name = "wAREHOUSEMASTBindingNavigator";
            this.wAREHOUSEMASTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.wAREHOUSEMASTBindingNavigator.Size = new System.Drawing.Size(535, 25);
            this.wAREHOUSEMASTBindingNavigator.TabIndex = 0;
            this.wAREHOUSEMASTBindingNavigator.Text = "bindingNavigator1";
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
            // wAREHOUSEMASTBindingNavigatorSaveItem
            // 
            this.wAREHOUSEMASTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wAREHOUSEMASTBindingNavigatorSaveItem.Image = global::Store.Properties.Resources.Save16;
            this.wAREHOUSEMASTBindingNavigatorSaveItem.Name = "wAREHOUSEMASTBindingNavigatorSaveItem";
            this.wAREHOUSEMASTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.wAREHOUSEMASTBindingNavigatorSaveItem.Text = "Save Data";
            this.wAREHOUSEMASTBindingNavigatorSaveItem.Click += new System.EventHandler(this.wAREHOUSEMASTBindingNavigatorSaveItem_Click);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // wHIDTextBox
            // 
            this.wHIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wAREHOUSEMASTBindingSource, "WHID", true));
            this.wHIDTextBox.Location = new System.Drawing.Point(94, 120);
            this.wHIDTextBox.Name = "wHIDTextBox";
            this.wHIDTextBox.Size = new System.Drawing.Size(121, 22);
            this.wHIDTextBox.TabIndex = 2;
            // 
            // wHNAMETextBox
            // 
            this.wHNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wAREHOUSEMASTBindingSource, "WHNAME", true));
            this.wHNAMETextBox.Location = new System.Drawing.Point(153, 34);
            this.wHNAMETextBox.Name = "wHNAMETextBox";
            this.wHNAMETextBox.Size = new System.Drawing.Size(359, 22);
            this.wHNAMETextBox.TabIndex = 4;
            // 
            // sELCheckBox
            // 
            this.sELCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.wAREHOUSEMASTBindingSource, "SEL", true));
            this.sELCheckBox.Location = new System.Drawing.Point(153, 57);
            this.sELCheckBox.Name = "sELCheckBox";
            this.sELCheckBox.Size = new System.Drawing.Size(21, 26);
            this.sELCheckBox.TabIndex = 6;
            this.sELCheckBox.UseVisualStyleBackColor = true;
            this.sELCheckBox.Visible = false;
            // 
            // pERTextBox
            // 
            this.pERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wAREHOUSEMASTBindingSource, "PER", true));
            this.pERTextBox.Location = new System.Drawing.Point(223, 120);
            this.pERTextBox.Name = "pERTextBox";
            this.pERTextBox.Size = new System.Drawing.Size(121, 22);
            this.pERTextBox.TabIndex = 8;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACTIVESESSIONTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOMMASTTableAdapter = null;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.COMPANYTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.DISCOUNTNAMESTableAdapter = null;
            this.tableAdapterManager.DOCTORSESSIONTableAdapter = null;
            this.tableAdapterManager.GENERICMASTTableAdapter = null;
            this.tableAdapterManager.GROUPTYPEMASTTableAdapter = null;
            this.tableAdapterManager.INSCUSTOMERSTableAdapter = null;
            this.tableAdapterManager.INSURANCEDISCTableAdapter = null;
            this.tableAdapterManager.ITEMGROUPTableAdapter = null;
            this.tableAdapterManager.ITEMMASTTableAdapter = null;
            this.tableAdapterManager.ITEMTYPETableAdapter = null;
            this.tableAdapterManager.MAINMENUTableAdapter = null;
            this.tableAdapterManager.MastMoveTypesTableAdapter = null;
            this.tableAdapterManager.NOTESMASTTableAdapter = null;
            this.tableAdapterManager.PAYTYPEMASTTableAdapter = null;
            this.tableAdapterManager.PRICEMASTERTableAdapter = null;
            this.tableAdapterManager.PRINTERSTableAdapter = null;
            this.tableAdapterManager.PROFILENAMEMASTTableAdapter = null;
            this.tableAdapterManager.PROFILESTableAdapter = null;
            this.tableAdapterManager.STOREMASTTableAdapter = null;
            this.tableAdapterManager.SUPPLIERTableAdapter = null;
            this.tableAdapterManager.Syscfg1TableAdapter = null;
            this.tableAdapterManager.UOMMASTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIRETAILDAL.DsMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINFOTableAdapter = null;
            this.tableAdapterManager.WAREHOUSEMASTTableAdapter = null;
            // 
            // warehousemastTableAdapter
            // 
            this.warehousemastTableAdapter.ClearBeforeFill = true;
            // 
            // Warehousemast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 103);
            this.Controls.Add(this.wHIDTextBox);
            this.Controls.Add(wHNAMELabel);
            this.Controls.Add(this.wHNAMETextBox);
            this.Controls.Add(sELLabel);
            this.Controls.Add(this.sELCheckBox);
            this.Controls.Add(this.pERTextBox);
            this.Controls.Add(this.wAREHOUSEMASTBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Warehousemast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warehouse Master";
            this.Load += new System.EventHandler(this.Warehousemast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingNavigator)).EndInit();
            this.wAREHOUSEMASTBindingNavigator.ResumeLayout(false);
            this.wAREHOUSEMASTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource wAREHOUSEMASTBindingSource;
        private BindingNavigator wAREHOUSEMASTBindingNavigator;
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
        private ToolStripButton wAREHOUSEMASTBindingNavigatorSaveItem;
        private TextBox wHIDTextBox;
        private TextBox wHNAMETextBox;
        private CheckBox sELCheckBox;
        private TextBox pERTextBox;
        private DsMaster dsMaster1;
        private TableAdapterManager tableAdapterManager;
        private WAREHOUSEMASTTableAdapter warehousemastTableAdapter;
    }
}