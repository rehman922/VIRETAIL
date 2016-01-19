namespace Store
{
    partial class MultiplePrice
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
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.iTEMMAST1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventory1 = new VIRETAILENTITIES.DsInventory();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sTOCKMASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMAST1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKMASTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNO", "ITEMNO", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "ITEMNAME", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.iTEMMAST1BindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ShowHeader = false;
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // iTEMMAST1BindingSource
            // 
            this.iTEMMAST1BindingSource.DataMember = "ITEMMAST1";
            this.iTEMMAST1BindingSource.DataSource = this.dsInventory1;
            // 
            // dsInventory1
            // 
            this.dsInventory1.DataSetName = "DsInventory";
            this.dsInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sTOCKMASTERBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(694, 244);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_EditorKeyDown);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // sTOCKMASTERBindingSource
            // 
            this.sTOCKMASTERBindingSource.DataMember = "STOCKMASTER";
            this.sTOCKMASTERBindingSource.DataSource = this.dsInventory1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEMNO,
            this.colITEMNO1,
            this.colSTOCKID,
            this.colQTY,
            this.colSPRICE,
            this.colCPRICE,
            this.colEXPDATE,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceCell.Options.UseFont = true;
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Barcode";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.AllowFocus = false;
            this.colITEMNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNO.OptionsColumn.ReadOnly = true;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 5;
            this.colITEMNO.Width = 160;
            // 
            // colITEMNO1
            // 
            this.colITEMNO1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO1.AppearanceCell.Options.UseFont = true;
            this.colITEMNO1.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO1.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO1.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.Caption = "Item name";
            this.colITEMNO1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colITEMNO1.FieldName = "ITEMNO";
            this.colITEMNO1.Name = "colITEMNO1";
            this.colITEMNO1.OptionsColumn.AllowEdit = false;
            this.colITEMNO1.OptionsColumn.AllowFocus = false;
            this.colITEMNO1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNO1.OptionsColumn.ReadOnly = true;
            this.colITEMNO1.Visible = true;
            this.colITEMNO1.VisibleIndex = 0;
            this.colITEMNO1.Width = 314;
            // 
            // colSTOCKID
            // 
            this.colSTOCKID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCKID.AppearanceCell.Options.UseFont = true;
            this.colSTOCKID.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTOCKID.AppearanceHeader.Options.UseFont = true;
            this.colSTOCKID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTOCKID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.FieldName = "STOCKID";
            this.colSTOCKID.Name = "colSTOCKID";
            this.colSTOCKID.OptionsColumn.AllowEdit = false;
            this.colSTOCKID.OptionsColumn.AllowFocus = false;
            this.colSTOCKID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCKID.OptionsColumn.ReadOnly = true;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceCell.Options.UseFont = true;
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Stock";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.AllowFocus = false;
            this.colQTY.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colQTY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 1;
            this.colQTY.Width = 53;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceCell.Options.UseFont = true;
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSPRICE.AppearanceHeader.Options.UseFont = true;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.Caption = "Price";
            this.colSPRICE.DisplayFormat.FormatString = "N2";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowEdit = false;
            this.colSPRICE.OptionsColumn.AllowFocus = false;
            this.colSPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSPRICE.OptionsColumn.ReadOnly = true;
            this.colSPRICE.Visible = true;
            this.colSPRICE.VisibleIndex = 3;
            this.colSPRICE.Width = 53;
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceCell.Options.UseFont = true;
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCPRICE.AppearanceHeader.Options.UseFont = true;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.OptionsColumn.AllowEdit = false;
            this.colCPRICE.OptionsColumn.AllowFocus = false;
            this.colCPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCPRICE.OptionsColumn.ReadOnly = true;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceCell.Options.UseFont = true;
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEXPDATE.AppearanceHeader.Options.UseFont = true;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.Caption = "Expiry";
            this.colEXPDATE.DisplayFormat.FormatString = "MM-yy";
            this.colEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXPDATE.FieldName = "EXPDATE";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.AllowEdit = false;
            this.colEXPDATE.OptionsColumn.AllowFocus = false;
            this.colEXPDATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPDATE.OptionsColumn.ReadOnly = true;
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.VisibleIndex = 4;
            this.colEXPDATE.Width = 45;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Qty.";
            this.gridColumn2.FieldName = "DQNTY";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 51;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.OK16;
            this.simpleButton2.Location = new System.Drawing.Point(250, 250);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(92, 27);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "F4 - OK ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.Delete16;
            this.simpleButton1.Location = new System.Drawing.Point(348, 250);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(92, 27);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "ESC - Cancel ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // MultiplePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 280);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiplePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Multiple Price / Expiry";
            this.Load += new System.EventHandler(this.MultiplePrice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MultiplePrice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMAST1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKMASTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource sTOCKMASTERBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colITEMNO;
        private DevExpress.XtraGrid.Columns.GridColumn colITEMNO1;
        private System.Windows.Forms.BindingSource iTEMMAST1BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKID;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colCPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colEXPDATE;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private VIRETAILENTITIES.DsInventory dsInventory1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}