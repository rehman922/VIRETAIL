using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class Lookupcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lookupcustomer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCUSTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMERTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCUSTOMERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTCOMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIXDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIXDISCAMTPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREDITLIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBINID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMERPOINT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLASTREDIMINV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAYTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Image = global::Store.Properties.Resources.customers;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(134, 22);
            this.toolStripLabel1.Text = "F1 - Customer name";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = global::Store.Properties.Resources.Phone16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton1.Text = "F2 - Mobile";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton2.Image = global::Store.Properties.Resources.Delete16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton2.Text = "ESC - Close";
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit1.Location = new System.Drawing.Point(0, 25);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.NullText = "Enter Item name";
            this.textEdit1.Properties.NullValuePrompt = "Enter Item name";
            this.textEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit1.Size = new System.Drawing.Size(663, 22);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.cUSTOMERBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(663, 316);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCUSTNO,
            this.colCUSTOMERTYPE,
            this.colCUSTOMERID,
            this.colCUSTCOMP,
            this.colPHONE,
            this.colMobile,
            this.colEMAIL,
            this.colNOTE,
            this.colFIXDISC,
            this.colFIXDISCAMTPER,
            this.colCREDITLIMIT,
            this.colCOMPANY,
            this.colBINID,
            this.colCUSERID,
            this.colCDATE,
            this.colEUSERID,
            this.colEDATE,
            this.colCUSTOMERPOINT,
            this.colLASTREDIMINV,
            this.colPAYTYPE,
            this.colCUSTOMERNAME,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCUSTOMERNAME, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colCUSTNO
            // 
            this.colCUSTNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNO.FieldName = "CUSTNO";
            this.colCUSTNO.Name = "colCUSTNO";
            this.colCUSTNO.OptionsColumn.AllowEdit = false;
            // 
            // colCUSTOMERTYPE
            // 
            this.colCUSTOMERTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERTYPE.Caption = "Type";
            this.colCUSTOMERTYPE.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colCUSTOMERTYPE.FieldName = "CUSTOMERTYPE";
            this.colCUSTOMERTYPE.Name = "colCUSTOMERTYPE";
            this.colCUSTOMERTYPE.OptionsColumn.AllowEdit = false;
            this.colCUSTOMERTYPE.Visible = true;
            this.colCUSTOMERTYPE.VisibleIndex = 1;
            this.colCUSTOMERTYPE.Width = 110;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Members", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Insurance", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Credit", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Al Mutawa Family", 3, -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colCUSTOMERID
            // 
            this.colCUSTOMERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERID.FieldName = "CUSTOMERID";
            this.colCUSTOMERID.Name = "colCUSTOMERID";
            this.colCUSTOMERID.OptionsColumn.AllowEdit = false;
            // 
            // colCUSTCOMP
            // 
            this.colCUSTCOMP.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTCOMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTCOMP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTCOMP.FieldName = "CUSTCOMP";
            this.colCUSTCOMP.Name = "colCUSTCOMP";
            this.colCUSTCOMP.OptionsColumn.AllowEdit = false;
            // 
            // colPHONE
            // 
            this.colPHONE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPHONE.FieldName = "PHONE";
            this.colPHONE.Name = "colPHONE";
            this.colPHONE.OptionsColumn.AllowEdit = false;
            // 
            // colMobile
            // 
            this.colMobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMobile.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.OptionsColumn.AllowEdit = false;
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 2;
            this.colMobile.Width = 141;
            // 
            // colEMAIL
            // 
            this.colEMAIL.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMAIL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.OptionsColumn.AllowEdit = false;
            // 
            // colNOTE
            // 
            this.colNOTE.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOTE.FieldName = "NOTE";
            this.colNOTE.Name = "colNOTE";
            this.colNOTE.OptionsColumn.AllowEdit = false;
            // 
            // colFIXDISC
            // 
            this.colFIXDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colFIXDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFIXDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFIXDISC.FieldName = "FIXDISC";
            this.colFIXDISC.Name = "colFIXDISC";
            this.colFIXDISC.OptionsColumn.AllowEdit = false;
            // 
            // colFIXDISCAMTPER
            // 
            this.colFIXDISCAMTPER.AppearanceHeader.Options.UseTextOptions = true;
            this.colFIXDISCAMTPER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFIXDISCAMTPER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFIXDISCAMTPER.FieldName = "FIXDISCAMTPER";
            this.colFIXDISCAMTPER.Name = "colFIXDISCAMTPER";
            this.colFIXDISCAMTPER.OptionsColumn.AllowEdit = false;
            // 
            // colCREDITLIMIT
            // 
            this.colCREDITLIMIT.AppearanceHeader.Options.UseTextOptions = true;
            this.colCREDITLIMIT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCREDITLIMIT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCREDITLIMIT.FieldName = "CREDITLIMIT";
            this.colCREDITLIMIT.Name = "colCREDITLIMIT";
            this.colCREDITLIMIT.OptionsColumn.AllowEdit = false;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.OptionsColumn.AllowEdit = false;
            // 
            // colBINID
            // 
            this.colBINID.AppearanceHeader.Options.UseTextOptions = true;
            this.colBINID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBINID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBINID.FieldName = "BINID";
            this.colBINID.Name = "colBINID";
            this.colBINID.OptionsColumn.AllowEdit = false;
            this.colBINID.OptionsColumn.ReadOnly = true;
            // 
            // colCUSERID
            // 
            this.colCUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSERID.FieldName = "CUSERID";
            this.colCUSERID.Name = "colCUSERID";
            this.colCUSERID.OptionsColumn.AllowEdit = false;
            // 
            // colCDATE
            // 
            this.colCDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCDATE.FieldName = "CDATE";
            this.colCDATE.Name = "colCDATE";
            this.colCDATE.OptionsColumn.AllowEdit = false;
            // 
            // colEUSERID
            // 
            this.colEUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEUSERID.FieldName = "EUSERID";
            this.colEUSERID.Name = "colEUSERID";
            this.colEUSERID.OptionsColumn.AllowEdit = false;
            // 
            // colEDATE
            // 
            this.colEDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEDATE.FieldName = "EDATE";
            this.colEDATE.Name = "colEDATE";
            this.colEDATE.OptionsColumn.AllowEdit = false;
            // 
            // colCUSTOMERPOINT
            // 
            this.colCUSTOMERPOINT.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERPOINT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERPOINT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERPOINT.FieldName = "CUSTOMERPOINT";
            this.colCUSTOMERPOINT.Name = "colCUSTOMERPOINT";
            this.colCUSTOMERPOINT.OptionsColumn.AllowEdit = false;
            // 
            // colLASTREDIMINV
            // 
            this.colLASTREDIMINV.AppearanceHeader.Options.UseTextOptions = true;
            this.colLASTREDIMINV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLASTREDIMINV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLASTREDIMINV.FieldName = "LASTREDIMINV";
            this.colLASTREDIMINV.Name = "colLASTREDIMINV";
            this.colLASTREDIMINV.OptionsColumn.AllowEdit = false;
            // 
            // colPAYTYPE
            // 
            this.colPAYTYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPAYTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPAYTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPAYTYPE.FieldName = "PAYTYPE";
            this.colPAYTYPE.Name = "colPAYTYPE";
            this.colPAYTYPE.OptionsColumn.AllowEdit = false;
            // 
            // colCUSTOMERNAME
            // 
            this.colCUSTOMERNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERNAME.Caption = "Customer name";
            this.colCUSTOMERNAME.FieldName = "CUSTOMERNAME";
            this.colCUSTOMERNAME.Name = "colCUSTOMERNAME";
            this.colCUSTOMERNAME.OptionsColumn.AllowEdit = false;
            this.colCUSTOMERNAME.Visible = true;
            this.colCUSTOMERNAME.VisibleIndex = 0;
            this.colCUSTOMERNAME.Width = 252;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "MEMBERNO";
            this.gridColumn1.FieldName = "MEMBERNO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 130;
            // 
            // Lookupcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 363);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2013";
            this.MaximizeBox = false;
            this.Name = "Lookupcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.Lookupcustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lookupcustomer_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton2;
        private TextEdit textEdit1;
        private BindingSource cUSTOMERBindingSource;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colCUSTNO;
        private GridColumn colCUSTOMERTYPE;
        private RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private GridColumn colCUSTOMERID;
        private GridColumn colCUSTCOMP;
        private GridColumn colPHONE;
        private GridColumn colMobile;
        private GridColumn colEMAIL;
        private GridColumn colNOTE;
        private GridColumn colFIXDISC;
        private GridColumn colFIXDISCAMTPER;
        private GridColumn colCREDITLIMIT;
        private GridColumn colCOMPANY;
        private GridColumn colBINID;
        private GridColumn colCUSERID;
        private GridColumn colCDATE;
        private GridColumn colEUSERID;
        private GridColumn colEDATE;
        private GridColumn colCUSTOMERPOINT;
        private GridColumn colLASTREDIMINV;
        private GridColumn colPAYTYPE;
        private GridColumn colCUSTOMERNAME;
        private GridColumn gridColumn1;
    }
}