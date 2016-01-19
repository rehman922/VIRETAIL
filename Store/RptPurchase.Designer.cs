using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptPurchase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LookupSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPURINVID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUEDAYS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNETVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LookupSupplier);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 69);
            this.panel1.TabIndex = 0;
            // 
            // LookupSupplier
            // 
            this.LookupSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookupSupplier.EnterMoveNextControl = true;
            this.LookupSupplier.Location = new System.Drawing.Point(89, 15);
            this.LookupSupplier.Name = "LookupSupplier";
            this.LookupSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupSupplier.Properties.Appearance.Options.UseFont = true;
            this.LookupSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNAME", "SUPPLIERNAME", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUEDAYS", "DUEDAYS", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.LookupSupplier.Properties.DisplayMember = "SUPPLIERNAME";
            this.LookupSupplier.Properties.NullText = "";
            this.LookupSupplier.Properties.ShowHeader = false;
            this.LookupSupplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupSupplier.Properties.ValueMember = "SUPPLIERNO";
            this.LookupSupplier.Size = new System.Drawing.Size(355, 20);
            this.LookupSupplier.TabIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Store.Properties.Resources.run;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(450, 39);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(28, 23);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Store.Properties.Resources.printer1;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(483, 39);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(28, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(16, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Supplier :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(264, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "To Date :";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(324, 40);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(120, 20);
            this.dateEdit2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(16, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "From Date :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(89, 40);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(125, 20);
            this.dateEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(544, 457);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPURINVID,
            this.colSUPNAME,
            this.colINVNO,
            this.colINVDATE,
            this.colDUEDAYS,
            this.colNETVALUE,
            this.colUSERID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETVALUE", this.colNETVALUE, "{0:###,###,###,###.##}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSUPNAME, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colPURINVID
            // 
            this.colPURINVID.AppearanceCell.Options.UseTextOptions = true;
            this.colPURINVID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURINVID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPURINVID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPURINVID.FieldName = "ID";
            this.colPURINVID.Name = "colPURINVID";
            this.colPURINVID.OptionsColumn.AllowEdit = false;
            this.colPURINVID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETVALUE", "{0:###,###,###,###.##}")});
            // 
            // colSUPNAME
            // 
            this.colSUPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPNAME.Caption = "Supplier";
            this.colSUPNAME.FieldName = "SUPNAME";
            this.colSUPNAME.Name = "colSUPNAME";
            this.colSUPNAME.OptionsColumn.AllowEdit = false;
            this.colSUPNAME.Visible = true;
            this.colSUPNAME.VisibleIndex = 1;
            // 
            // colINVNO
            // 
            this.colINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVNO.Caption = "Invoice No.";
            this.colINVNO.FieldName = "INVNO";
            this.colINVNO.Name = "colINVNO";
            this.colINVNO.OptionsColumn.AllowEdit = false;
            this.colINVNO.Visible = true;
            this.colINVNO.VisibleIndex = 0;
            this.colINVNO.Width = 116;
            // 
            // colINVDATE
            // 
            this.colINVDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVDATE.Caption = "Inv Date";
            this.colINVDATE.DisplayFormat.FormatString = "dd MMM ,yyyy";
            this.colINVDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colINVDATE.FieldName = "INVDATE";
            this.colINVDATE.Name = "colINVDATE";
            this.colINVDATE.OptionsColumn.AllowEdit = false;
            this.colINVDATE.Visible = true;
            this.colINVDATE.VisibleIndex = 1;
            this.colINVDATE.Width = 177;
            // 
            // colDUEDAYS
            // 
            this.colDUEDAYS.AppearanceCell.Options.UseTextOptions = true;
            this.colDUEDAYS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDUEDAYS.AppearanceHeader.Options.UseTextOptions = true;
            this.colDUEDAYS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDUEDAYS.Caption = "Due Days";
            this.colDUEDAYS.FieldName = "DUEDAYS";
            this.colDUEDAYS.Name = "colDUEDAYS";
            this.colDUEDAYS.OptionsColumn.AllowEdit = false;
            this.colDUEDAYS.Visible = true;
            this.colDUEDAYS.VisibleIndex = 2;
            this.colDUEDAYS.Width = 77;
            // 
            // colNETVALUE
            // 
            this.colNETVALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colNETVALUE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNETVALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colNETVALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNETVALUE.Caption = "Amount";
            this.colNETVALUE.DisplayFormat.FormatString = "N2";
            this.colNETVALUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNETVALUE.FieldName = "NETVALUE";
            this.colNETVALUE.Name = "colNETVALUE";
            this.colNETVALUE.OptionsColumn.AllowEdit = false;
            this.colNETVALUE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETVALUE", "{0:###,###,###,###.##}")});
            this.colNETVALUE.Visible = true;
            this.colNETVALUE.VisibleIndex = 3;
            this.colNETVALUE.Width = 156;
            // 
            // colUSERID
            // 
            this.colUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            this.colUSERID.OptionsColumn.AllowEdit = false;
            // 
            // RptPurchase
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Report";
            this.Load += new System.EventHandler(this.RptPurchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private DateEdit dateEdit2;
        private LabelControl labelControl1;
        private DateEdit dateEdit1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colPURINVID;
        private GridColumn colSUPNAME;
        private GridColumn colINVNO;
        private GridColumn colINVDATE;
        private GridColumn colDUEDAYS;
        private GridColumn colNETVALUE;
        private GridColumn colUSERID;
        protected LookUpEdit LookupSupplier;
    }
}