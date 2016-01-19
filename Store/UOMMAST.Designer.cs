using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class UOMMAST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UOMMAST));
            this.uOMMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster = new VIRETAILENTITIES.DsMaster();
            this.uOMMASTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.uOMMASTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.uOMMASTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUNITID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNITDESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNITVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uOMMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uOMMASTBindingNavigator)).BeginInit();
            this.uOMMASTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uOMMASTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uOMMASTBindingSource
            // 
            this.uOMMASTBindingSource.DataMember = "UOMMAST";
            this.uOMMASTBindingSource.DataSource = this.dsMaster;
            // 
            // dsMaster
            // 
            this.dsMaster.DataSetName = "DsMaster";
            this.dsMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uOMMASTBindingNavigator
            // 
            this.uOMMASTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uOMMASTBindingNavigator.BindingSource = this.uOMMASTBindingSource;
            this.uOMMASTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uOMMASTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uOMMASTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.uOMMASTBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.uOMMASTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uOMMASTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uOMMASTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uOMMASTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uOMMASTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uOMMASTBindingNavigator.Name = "uOMMASTBindingNavigator";
            this.uOMMASTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uOMMASTBindingNavigator.Size = new System.Drawing.Size(469, 25);
            this.uOMMASTBindingNavigator.TabIndex = 0;
            this.uOMMASTBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // uOMMASTBindingNavigatorSaveItem
            // 
            this.uOMMASTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uOMMASTBindingNavigatorSaveItem.Enabled = false;
            this.uOMMASTBindingNavigatorSaveItem.Image = global::Store.Properties.Resources.Save16;
            this.uOMMASTBindingNavigatorSaveItem.Name = "uOMMASTBindingNavigatorSaveItem";
            this.uOMMASTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uOMMASTBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // uOMMASTGridControl
            // 
            this.uOMMASTGridControl.DataSource = this.uOMMASTBindingSource;
            this.uOMMASTGridControl.Location = new System.Drawing.Point(0, 28);
            this.uOMMASTGridControl.MainView = this.gridView1;
            this.uOMMASTGridControl.Name = "uOMMASTGridControl";
            this.uOMMASTGridControl.Size = new System.Drawing.Size(467, 234);
            this.uOMMASTGridControl.TabIndex = 1;
            this.uOMMASTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUNITID,
            this.colUNITDESC,
            this.colUNITVALUE,
            this.colUCODE});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(488, 249, 216, 185);
            this.gridView1.GridControl = this.uOMMASTGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUNITID
            // 
            this.colUNITID.FieldName = "UNITID";
            this.colUNITID.Name = "colUNITID";
            this.colUNITID.OptionsColumn.ReadOnly = true;
            // 
            // colUNITDESC
            // 
            this.colUNITDESC.Caption = "Description";
            this.colUNITDESC.FieldName = "UNITDESC";
            this.colUNITDESC.Name = "colUNITDESC";
            this.colUNITDESC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colUNITDESC.OptionsColumn.AllowMove = false;
            this.colUNITDESC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUNITDESC.OptionsColumn.ShowInCustomizationForm = false;
            this.colUNITDESC.OptionsColumn.ShowInExpressionEditor = false;
            this.colUNITDESC.Visible = true;
            this.colUNITDESC.VisibleIndex = 1;
            this.colUNITDESC.Width = 320;
            // 
            // colUNITVALUE
            // 
            this.colUNITVALUE.Caption = "Unit Value";
            this.colUNITVALUE.FieldName = "UNITVALUE";
            this.colUNITVALUE.Name = "colUNITVALUE";
            this.colUNITVALUE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colUNITVALUE.OptionsColumn.AllowMove = false;
            this.colUNITVALUE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUNITVALUE.OptionsColumn.ShowInCustomizationForm = false;
            this.colUNITVALUE.OptionsColumn.ShowInExpressionEditor = false;
            this.colUNITVALUE.Visible = true;
            this.colUNITVALUE.VisibleIndex = 2;
            this.colUNITVALUE.Width = 58;
            // 
            // colUCODE
            // 
            this.colUCODE.Caption = "Code";
            this.colUCODE.FieldName = "UCODE";
            this.colUCODE.Name = "colUCODE";
            this.colUCODE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colUCODE.OptionsColumn.AllowMove = false;
            this.colUCODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUCODE.OptionsColumn.ShowInCustomizationForm = false;
            this.colUCODE.OptionsColumn.ShowInExpressionEditor = false;
            this.colUCODE.Visible = true;
            this.colUCODE.VisibleIndex = 0;
            this.colUCODE.Width = 71;
            // 
            // UOMMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 265);
            this.Controls.Add(this.uOMMASTGridControl);
            this.Controls.Add(this.uOMMASTBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UOMMAST";
            this.Text = "Unit of Measure";
            this.Load += new System.EventHandler(this.UOMMAST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uOMMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uOMMASTBindingNavigator)).EndInit();
            this.uOMMASTBindingNavigator.ResumeLayout(false);
            this.uOMMASTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uOMMASTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource uOMMASTBindingSource;
        private BindingNavigator uOMMASTBindingNavigator;
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
        private ToolStripButton uOMMASTBindingNavigatorSaveItem;
        private GridControl uOMMASTGridControl;
        private GridView gridView1;
        private GridColumn colUNITID;
        private GridColumn colUNITDESC;
        private GridColumn colUNITVALUE;
        private GridColumn colUCODE;
        private DsMaster dsMaster;


    }
}