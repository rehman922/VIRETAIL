using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class HoldPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoldPurchase));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPURINVID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUEDAYS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPDISCOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADJVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.wAREHOUSEMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNETVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANSTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBINID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rETURNMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURINVMAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPurchase1 = new VIRETAILENTITIES.DsPurchase();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURINVMAINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Store.Properties.Resources.folder_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Store.Properties.Resources.Delete16;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItemClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(895, 391);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPURINVID,
            this.colSUPID,
            this.colSUPNAME,
            this.colINVNO,
            this.colINVDATE,
            this.colDUEDAYS,
            this.colSPDISCOUNT,
            this.colADJVALUE,
            this.colHOLD,
            this.colWHID,
            this.colUSERID,
            this.colEUSERID,
            this.colEDATE,
            this.colNETVALUE,
            this.colCOMPANY,
            this.colTRANSTYPE,
            this.colBINID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPURINVID
            // 
            this.colPURINVID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPURINVID.AppearanceCell.Options.UseFont = true;
            this.colPURINVID.AppearanceCell.Options.UseTextOptions = true;
            this.colPURINVID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURINVID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPURINVID.AppearanceHeader.Options.UseFont = true;
            this.colPURINVID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPURINVID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPURINVID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURINVID.Caption = "Doc. No.";
            this.colPURINVID.FieldName = "PURINVID";
            this.colPURINVID.Name = "colPURINVID";
            this.colPURINVID.OptionsColumn.AllowEdit = false;
            this.colPURINVID.OptionsColumn.ReadOnly = true;
            this.colPURINVID.Visible = true;
            this.colPURINVID.VisibleIndex = 0;
            // 
            // colSUPID
            // 
            this.colSUPID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPID.AppearanceCell.Options.UseFont = true;
            this.colSUPID.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPID.AppearanceHeader.Options.UseFont = true;
            this.colSUPID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPID.FieldName = "SUPID";
            this.colSUPID.Name = "colSUPID";
            this.colSUPID.OptionsColumn.AllowEdit = false;
            this.colSUPID.OptionsColumn.ReadOnly = true;
            // 
            // colSUPNAME
            // 
            this.colSUPNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPNAME.AppearanceCell.Options.UseFont = true;
            this.colSUPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPNAME.AppearanceHeader.Options.UseFont = true;
            this.colSUPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPNAME.Caption = "Supplier name";
            this.colSUPNAME.FieldName = "SUPNAME";
            this.colSUPNAME.Name = "colSUPNAME";
            this.colSUPNAME.OptionsColumn.AllowEdit = false;
            this.colSUPNAME.OptionsColumn.ReadOnly = true;
            this.colSUPNAME.Visible = true;
            this.colSUPNAME.VisibleIndex = 3;
            this.colSUPNAME.Width = 334;
            // 
            // colINVNO
            // 
            this.colINVNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVNO.AppearanceCell.Options.UseFont = true;
            this.colINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVNO.AppearanceHeader.Options.UseFont = true;
            this.colINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVNO.Caption = "Inv. No.";
            this.colINVNO.FieldName = "INVNO";
            this.colINVNO.Name = "colINVNO";
            this.colINVNO.OptionsColumn.AllowEdit = false;
            this.colINVNO.OptionsColumn.ReadOnly = true;
            this.colINVNO.Visible = true;
            this.colINVNO.VisibleIndex = 2;
            this.colINVNO.Width = 116;
            // 
            // colINVDATE
            // 
            this.colINVDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVDATE.AppearanceCell.Options.UseFont = true;
            this.colINVDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVDATE.AppearanceHeader.Options.UseFont = true;
            this.colINVDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVDATE.Caption = "Inv.Date";
            this.colINVDATE.FieldName = "INVDATE";
            this.colINVDATE.Name = "colINVDATE";
            this.colINVDATE.OptionsColumn.AllowEdit = false;
            this.colINVDATE.OptionsColumn.ReadOnly = true;
            this.colINVDATE.Visible = true;
            this.colINVDATE.VisibleIndex = 1;
            this.colINVDATE.Width = 127;
            // 
            // colDUEDAYS
            // 
            this.colDUEDAYS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDUEDAYS.AppearanceCell.Options.UseFont = true;
            this.colDUEDAYS.AppearanceCell.Options.UseTextOptions = true;
            this.colDUEDAYS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDUEDAYS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDUEDAYS.AppearanceHeader.Options.UseFont = true;
            this.colDUEDAYS.AppearanceHeader.Options.UseTextOptions = true;
            this.colDUEDAYS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDUEDAYS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDUEDAYS.FieldName = "DUEDAYS";
            this.colDUEDAYS.Name = "colDUEDAYS";
            this.colDUEDAYS.OptionsColumn.AllowEdit = false;
            this.colDUEDAYS.OptionsColumn.ReadOnly = true;
            // 
            // colSPDISCOUNT
            // 
            this.colSPDISCOUNT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPDISCOUNT.AppearanceCell.Options.UseFont = true;
            this.colSPDISCOUNT.AppearanceCell.Options.UseTextOptions = true;
            this.colSPDISCOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPDISCOUNT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPDISCOUNT.AppearanceHeader.Options.UseFont = true;
            this.colSPDISCOUNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPDISCOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPDISCOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPDISCOUNT.FieldName = "SPDISCOUNT";
            this.colSPDISCOUNT.Name = "colSPDISCOUNT";
            this.colSPDISCOUNT.OptionsColumn.AllowEdit = false;
            this.colSPDISCOUNT.OptionsColumn.ReadOnly = true;
            // 
            // colADJVALUE
            // 
            this.colADJVALUE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colADJVALUE.AppearanceCell.Options.UseFont = true;
            this.colADJVALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colADJVALUE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADJVALUE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colADJVALUE.AppearanceHeader.Options.UseFont = true;
            this.colADJVALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colADJVALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colADJVALUE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADJVALUE.FieldName = "ADJVALUE";
            this.colADJVALUE.Name = "colADJVALUE";
            this.colADJVALUE.OptionsColumn.AllowEdit = false;
            this.colADJVALUE.OptionsColumn.ReadOnly = true;
            // 
            // colHOLD
            // 
            this.colHOLD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOLD.AppearanceCell.Options.UseFont = true;
            this.colHOLD.AppearanceCell.Options.UseTextOptions = true;
            this.colHOLD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOLD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOLD.AppearanceHeader.Options.UseFont = true;
            this.colHOLD.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOLD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOLD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOLD.FieldName = "HOLD";
            this.colHOLD.Name = "colHOLD";
            this.colHOLD.OptionsColumn.AllowEdit = false;
            this.colHOLD.OptionsColumn.ReadOnly = true;
            // 
            // colWHID
            // 
            this.colWHID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colWHID.AppearanceCell.Options.UseFont = true;
            this.colWHID.AppearanceCell.Options.UseTextOptions = true;
            this.colWHID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colWHID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colWHID.AppearanceHeader.Options.UseFont = true;
            this.colWHID.AppearanceHeader.Options.UseTextOptions = true;
            this.colWHID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWHID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colWHID.Caption = "Warehouse";
            this.colWHID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colWHID.FieldName = "WHID";
            this.colWHID.Name = "colWHID";
            this.colWHID.OptionsColumn.AllowEdit = false;
            this.colWHID.OptionsColumn.ReadOnly = true;
            this.colWHID.Visible = true;
            this.colWHID.VisibleIndex = 4;
            this.colWHID.Width = 162;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.wAREHOUSEMASTBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "WHNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "WHID";
            // 
            // wAREHOUSEMASTBindingSource
            // 
            this.wAREHOUSEMASTBindingSource.DataMember = "WAREHOUSEMAST1";
            this.wAREHOUSEMASTBindingSource.DataSource = typeof(VIRETAILENTITIES.DsInventory);
            // 
            // colUSERID
            // 
            this.colUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceCell.Options.UseFont = true;
            this.colUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceHeader.Options.UseFont = true;
            this.colUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.Caption = "User";
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            this.colUSERID.OptionsColumn.AllowEdit = false;
            this.colUSERID.OptionsColumn.ReadOnly = true;
            this.colUSERID.Width = 138;
            // 
            // colEUSERID
            // 
            this.colEUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEUSERID.AppearanceCell.Options.UseFont = true;
            this.colEUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEUSERID.AppearanceHeader.Options.UseFont = true;
            this.colEUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.FieldName = "EUSERID";
            this.colEUSERID.Name = "colEUSERID";
            this.colEUSERID.OptionsColumn.AllowEdit = false;
            this.colEUSERID.OptionsColumn.ReadOnly = true;
            // 
            // colEDATE
            // 
            this.colEDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEDATE.AppearanceCell.Options.UseFont = true;
            this.colEDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEDATE.AppearanceHeader.Options.UseFont = true;
            this.colEDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.FieldName = "EDATE";
            this.colEDATE.Name = "colEDATE";
            this.colEDATE.OptionsColumn.AllowEdit = false;
            this.colEDATE.OptionsColumn.ReadOnly = true;
            // 
            // colNETVALUE
            // 
            this.colNETVALUE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNETVALUE.AppearanceCell.Options.UseFont = true;
            this.colNETVALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colNETVALUE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNETVALUE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNETVALUE.AppearanceHeader.Options.UseFont = true;
            this.colNETVALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colNETVALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNETVALUE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNETVALUE.FieldName = "NETVALUE";
            this.colNETVALUE.Name = "colNETVALUE";
            this.colNETVALUE.OptionsColumn.AllowEdit = false;
            this.colNETVALUE.OptionsColumn.ReadOnly = true;
            this.colNETVALUE.Width = 137;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceCell.Options.UseFont = true;
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceHeader.Options.UseFont = true;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.OptionsColumn.AllowEdit = false;
            this.colCOMPANY.OptionsColumn.ReadOnly = true;
            // 
            // colTRANSTYPE
            // 
            this.colTRANSTYPE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANSTYPE.AppearanceCell.Options.UseFont = true;
            this.colTRANSTYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANSTYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANSTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANSTYPE.AppearanceHeader.Options.UseFont = true;
            this.colTRANSTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANSTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANSTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANSTYPE.FieldName = "TRANSTYPE";
            this.colTRANSTYPE.Name = "colTRANSTYPE";
            this.colTRANSTYPE.OptionsColumn.AllowEdit = false;
            this.colTRANSTYPE.OptionsColumn.ReadOnly = true;
            // 
            // colBINID
            // 
            this.colBINID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBINID.AppearanceCell.Options.UseFont = true;
            this.colBINID.AppearanceCell.Options.UseTextOptions = true;
            this.colBINID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBINID.AppearanceHeader.Options.UseFont = true;
            this.colBINID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBINID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBINID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.FieldName = "BINID";
            this.colBINID.Name = "colBINID";
            this.colBINID.OptionsColumn.AllowEdit = false;
            this.colBINID.OptionsColumn.ReadOnly = true;
            // 
            // rETURNMASTBindingSource
            // 
            this.rETURNMASTBindingSource.DataMember = "RETURNMAST";
            this.rETURNMASTBindingSource.DataSource = this.dsPurchase1;
            // 
            // pURINVMAINBindingSource
            // 
            this.pURINVMAINBindingSource.DataMember = "PURINVMAIN";
            this.pURINVMAINBindingSource.DataSource = this.dsPurchase1;
            // 
            // dsPurchase1
            // 
            this.dsPurchase1.DataSetName = "DsPurchase";
            this.dsPurchase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoldPurchase
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 415);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HoldPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hold Invoices List";
            this.Load += new System.EventHandler(this.HoldPurchaseLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURINVMAINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private GridControl gridControl1;
        private BindingSource rETURNMASTBindingSource;
        private GridView gridView1;
        private GridColumn colPURINVID;
        private GridColumn colSUPID;
        private GridColumn colSUPNAME;
        private GridColumn colINVNO;
        private GridColumn colINVDATE;
        private GridColumn colDUEDAYS;
        private GridColumn colSPDISCOUNT;
        private GridColumn colADJVALUE;
        private GridColumn colHOLD;
        private GridColumn colWHID;
        private GridColumn colUSERID;
        private GridColumn colEUSERID;
        private GridColumn colEDATE;
        private GridColumn colNETVALUE;
        private GridColumn colCOMPANY;
        private GridColumn colTRANSTYPE;
        private GridColumn colBINID;
        private BindingSource pURINVMAINBindingSource;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BindingSource wAREHOUSEMASTBindingSource;
        private DsPurchase dsPurchase1;
    }
}