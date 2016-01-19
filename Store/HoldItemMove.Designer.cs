using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class HoldItemMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoldItemMove));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.iTEMTRANSFERMAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRANID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTITEMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mastMoveTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMSTOREID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISREC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOWNFILENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFILENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERMAINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastMoveTypesBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Store.Properties.Resources.folder_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Store.Properties.Resources.Delete16;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.iTEMTRANSFERMAINBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(736, 344);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // iTEMTRANSFERMAINBindingSource
            // 
            this.iTEMTRANSFERMAINBindingSource.DataMember = "ITEMTRANSFERMAIN";
            this.iTEMTRANSFERMAINBindingSource.DataSource = typeof(VIRETAILENTITIES.DsInventory);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANID,
            this.colTOSTOREID,
            this.colTRANDATE,
            this.colUSERID,
            this.colUDATE,
            this.colHOLD,
            this.colEUSERID,
            this.colEDATE,
            this.colTOTVALUE,
            this.colTOTITEMS,
            this.colNOTE,
            this.colTTYPE,
            this.colCOMPANY,
            this.colFRMSTOREID,
            this.colFRMNAME,
            this.colTONAME,
            this.colISREC,
            this.colDOWNFILENO,
            this.colAFILENO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTRANID
            // 
            this.colTRANID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANID.AppearanceCell.Options.UseFont = true;
            this.colTRANID.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANID.AppearanceHeader.Options.UseFont = true;
            this.colTRANID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANID.Caption = "Doc No.";
            this.colTRANID.FieldName = "TRANID";
            this.colTRANID.Name = "colTRANID";
            this.colTRANID.OptionsColumn.AllowEdit = false;
            this.colTRANID.OptionsColumn.ReadOnly = true;
            this.colTRANID.Visible = true;
            this.colTRANID.VisibleIndex = 0;
            this.colTRANID.Width = 100;
            // 
            // colTOSTOREID
            // 
            this.colTOSTOREID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOSTOREID.AppearanceCell.Options.UseFont = true;
            this.colTOSTOREID.AppearanceCell.Options.UseTextOptions = true;
            this.colTOSTOREID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOSTOREID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOSTOREID.AppearanceHeader.Options.UseFont = true;
            this.colTOSTOREID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOSTOREID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOSTOREID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOSTOREID.FieldName = "TOSTOREID";
            this.colTOSTOREID.Name = "colTOSTOREID";
            this.colTOSTOREID.OptionsColumn.AllowEdit = false;
            this.colTOSTOREID.OptionsColumn.ReadOnly = true;
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceCell.Options.UseFont = true;
            this.colTRANDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANDATE.AppearanceHeader.Options.UseFont = true;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Doc.Dt.";
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.OptionsColumn.ReadOnly = true;
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 1;
            this.colTRANDATE.Width = 84;
            // 
            // colUSERID
            // 
            this.colUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceCell.Options.UseFont = true;
            this.colUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceHeader.Options.UseFont = true;
            this.colUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.Caption = "User";
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            this.colUSERID.OptionsColumn.AllowEdit = false;
            this.colUSERID.OptionsColumn.ReadOnly = true;
            this.colUSERID.Width = 141;
            // 
            // colUDATE
            // 
            this.colUDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUDATE.AppearanceCell.Options.UseFont = true;
            this.colUDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colUDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUDATE.AppearanceHeader.Options.UseFont = true;
            this.colUDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colUDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUDATE.FieldName = "UDATE";
            this.colUDATE.Name = "colUDATE";
            this.colUDATE.OptionsColumn.AllowEdit = false;
            this.colUDATE.OptionsColumn.ReadOnly = true;
            // 
            // colHOLD
            // 
            this.colHOLD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOLD.AppearanceCell.Options.UseFont = true;
            this.colHOLD.AppearanceCell.Options.UseTextOptions = true;
            this.colHOLD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOLD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOLD.AppearanceHeader.Options.UseFont = true;
            this.colHOLD.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOLD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOLD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOLD.FieldName = "HOLD";
            this.colHOLD.Name = "colHOLD";
            this.colHOLD.OptionsColumn.AllowEdit = false;
            this.colHOLD.OptionsColumn.ReadOnly = true;
            // 
            // colEUSERID
            // 
            this.colEUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEUSERID.AppearanceCell.Options.UseFont = true;
            this.colEUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colEDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEDATE.AppearanceHeader.Options.UseFont = true;
            this.colEDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.FieldName = "EDATE";
            this.colEDATE.Name = "colEDATE";
            this.colEDATE.OptionsColumn.AllowEdit = false;
            this.colEDATE.OptionsColumn.ReadOnly = true;
            // 
            // colTOTVALUE
            // 
            this.colTOTVALUE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTVALUE.AppearanceCell.Options.UseFont = true;
            this.colTOTVALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colTOTVALUE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTVALUE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTVALUE.AppearanceHeader.Options.UseFont = true;
            this.colTOTVALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOTVALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOTVALUE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTVALUE.FieldName = "TOTVALUE";
            this.colTOTVALUE.Name = "colTOTVALUE";
            this.colTOTVALUE.OptionsColumn.AllowEdit = false;
            this.colTOTVALUE.OptionsColumn.ReadOnly = true;
            // 
            // colTOTITEMS
            // 
            this.colTOTITEMS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTITEMS.AppearanceCell.Options.UseFont = true;
            this.colTOTITEMS.AppearanceCell.Options.UseTextOptions = true;
            this.colTOTITEMS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTITEMS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTITEMS.AppearanceHeader.Options.UseFont = true;
            this.colTOTITEMS.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOTITEMS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOTITEMS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTITEMS.FieldName = "TOTITEMS";
            this.colTOTITEMS.Name = "colTOTITEMS";
            this.colTOTITEMS.OptionsColumn.AllowEdit = false;
            this.colTOTITEMS.OptionsColumn.ReadOnly = true;
            // 
            // colNOTE
            // 
            this.colNOTE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOTE.AppearanceCell.Options.UseFont = true;
            this.colNOTE.AppearanceCell.Options.UseTextOptions = true;
            this.colNOTE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOTE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOTE.AppearanceHeader.Options.UseFont = true;
            this.colNOTE.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOTE.FieldName = "NOTE";
            this.colNOTE.Name = "colNOTE";
            this.colNOTE.OptionsColumn.AllowEdit = false;
            this.colNOTE.OptionsColumn.ReadOnly = true;
            // 
            // colTTYPE
            // 
            this.colTTYPE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTTYPE.AppearanceCell.Options.UseFont = true;
            this.colTTYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colTTYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTTYPE.AppearanceHeader.Options.UseFont = true;
            this.colTTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTTYPE.Caption = "Type";
            this.colTTYPE.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colTTYPE.FieldName = "TTYPE";
            this.colTTYPE.Name = "colTTYPE";
            this.colTTYPE.OptionsColumn.AllowEdit = false;
            this.colTTYPE.OptionsColumn.ReadOnly = true;
            this.colTTYPE.Visible = true;
            this.colTTYPE.VisibleIndex = 2;
            this.colTTYPE.Width = 176;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.mastMoveTypesBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "MoveType";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "MoveTypeid";
            // 
            // mastMoveTypesBindingSource
            // 
            this.mastMoveTypesBindingSource.DataMember = "MastMoveTypes";
            this.mastMoveTypesBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceCell.Options.UseFont = true;
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceHeader.Options.UseFont = true;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.OptionsColumn.AllowEdit = false;
            this.colCOMPANY.OptionsColumn.ReadOnly = true;
            // 
            // colFRMSTOREID
            // 
            this.colFRMSTOREID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMSTOREID.AppearanceCell.Options.UseFont = true;
            this.colFRMSTOREID.AppearanceCell.Options.UseTextOptions = true;
            this.colFRMSTOREID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMSTOREID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMSTOREID.AppearanceHeader.Options.UseFont = true;
            this.colFRMSTOREID.AppearanceHeader.Options.UseTextOptions = true;
            this.colFRMSTOREID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFRMSTOREID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMSTOREID.FieldName = "FRMSTOREID";
            this.colFRMSTOREID.Name = "colFRMSTOREID";
            this.colFRMSTOREID.OptionsColumn.AllowEdit = false;
            this.colFRMSTOREID.OptionsColumn.ReadOnly = true;
            // 
            // colFRMNAME
            // 
            this.colFRMNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMNAME.AppearanceCell.Options.UseFont = true;
            this.colFRMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colFRMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFRMNAME.AppearanceHeader.Options.UseFont = true;
            this.colFRMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colFRMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFRMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFRMNAME.Caption = "From Location";
            this.colFRMNAME.FieldName = "FRMNAME";
            this.colFRMNAME.Name = "colFRMNAME";
            this.colFRMNAME.OptionsColumn.AllowEdit = false;
            this.colFRMNAME.OptionsColumn.ReadOnly = true;
            this.colFRMNAME.Visible = true;
            this.colFRMNAME.VisibleIndex = 3;
            this.colFRMNAME.Width = 176;
            // 
            // colTONAME
            // 
            this.colTONAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTONAME.AppearanceCell.Options.UseFont = true;
            this.colTONAME.AppearanceCell.Options.UseTextOptions = true;
            this.colTONAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTONAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTONAME.AppearanceHeader.Options.UseFont = true;
            this.colTONAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colTONAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTONAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTONAME.Caption = "To Location";
            this.colTONAME.FieldName = "TONAME";
            this.colTONAME.Name = "colTONAME";
            this.colTONAME.OptionsColumn.AllowEdit = false;
            this.colTONAME.OptionsColumn.ReadOnly = true;
            this.colTONAME.Visible = true;
            this.colTONAME.VisibleIndex = 4;
            this.colTONAME.Width = 182;
            // 
            // colISREC
            // 
            this.colISREC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISREC.AppearanceCell.Options.UseFont = true;
            this.colISREC.AppearanceCell.Options.UseTextOptions = true;
            this.colISREC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISREC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISREC.AppearanceHeader.Options.UseFont = true;
            this.colISREC.AppearanceHeader.Options.UseTextOptions = true;
            this.colISREC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colISREC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISREC.FieldName = "ISREC";
            this.colISREC.Name = "colISREC";
            this.colISREC.OptionsColumn.AllowEdit = false;
            this.colISREC.OptionsColumn.ReadOnly = true;
            // 
            // colDOWNFILENO
            // 
            this.colDOWNFILENO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDOWNFILENO.AppearanceCell.Options.UseFont = true;
            this.colDOWNFILENO.AppearanceCell.Options.UseTextOptions = true;
            this.colDOWNFILENO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOWNFILENO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDOWNFILENO.AppearanceHeader.Options.UseFont = true;
            this.colDOWNFILENO.AppearanceHeader.Options.UseTextOptions = true;
            this.colDOWNFILENO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDOWNFILENO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOWNFILENO.FieldName = "DOWNFILENO";
            this.colDOWNFILENO.Name = "colDOWNFILENO";
            this.colDOWNFILENO.OptionsColumn.AllowEdit = false;
            this.colDOWNFILENO.OptionsColumn.ReadOnly = true;
            // 
            // colAFILENO
            // 
            this.colAFILENO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAFILENO.AppearanceCell.Options.UseFont = true;
            this.colAFILENO.AppearanceCell.Options.UseTextOptions = true;
            this.colAFILENO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAFILENO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAFILENO.AppearanceHeader.Options.UseFont = true;
            this.colAFILENO.AppearanceHeader.Options.UseTextOptions = true;
            this.colAFILENO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAFILENO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAFILENO.FieldName = "AFILENO";
            this.colAFILENO.Name = "colAFILENO";
            this.colAFILENO.OptionsColumn.AllowEdit = false;
            this.colAFILENO.OptionsColumn.ReadOnly = true;
            // 
            // HoldItemMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 368);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoldItemMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hold Item Move List";
            this.Load += new System.EventHandler(this.HoldItemMove_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMTRANSFERMAINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastMoveTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource iTEMTRANSFERMAINBindingSource;
        private GridColumn colTRANID;
        private GridColumn colTOSTOREID;
        private GridColumn colTRANDATE;
        private GridColumn colUSERID;
        private GridColumn colUDATE;
        private GridColumn colHOLD;
        private GridColumn colEUSERID;
        private GridColumn colEDATE;
        private GridColumn colTOTVALUE;
        private GridColumn colTOTITEMS;
        private GridColumn colNOTE;
        private GridColumn colTTYPE;
        private GridColumn colCOMPANY;
        private GridColumn colFRMSTOREID;
        private GridColumn colFRMNAME;
        private GridColumn colTONAME;
        private GridColumn colISREC;
        private GridColumn colDOWNFILENO;
        private GridColumn colAFILENO;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BindingSource mastMoveTypesBindingSource;
    }
}