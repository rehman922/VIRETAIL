using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Store
{
    partial class RptInsuranceSalesDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptInsuranceSalesDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.lblstore = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sALESMAININSURANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSINVNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNETAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECDAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREDITAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMERFIXDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARDDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sTOREMASTDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.insuranceSalesByItemWiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInv_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colP_S = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESMAININSURANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceSalesByItemWiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lookUpEdit3);
            this.panel1.Controls.Add(this.lblstore);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 33);
            this.panel1.TabIndex = 8;
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(53, 6);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBNAME", "DBNAME", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit3.Properties.DisplayMember = "STORENAME";
            this.lookUpEdit3.Properties.NullText = "";
            this.lookUpEdit3.Properties.ShowHeader = false;
            this.lookUpEdit3.Properties.ValueMember = "DBNAME";
            this.lookUpEdit3.Size = new System.Drawing.Size(189, 20);
            this.lookUpEdit3.TabIndex = 16;
            this.lookUpEdit3.Visible = false;
            // 
            // lblstore
            // 
            this.lblstore.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstore.Location = new System.Drawing.Point(9, 8);
            this.lblstore.Name = "lblstore";
            this.lblstore.Size = new System.Drawing.Size(38, 14);
            this.lblstore.TabIndex = 15;
            this.lblstore.Text = "Store :";
            this.lblstore.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(626, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(26, 22);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(658, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(26, 22);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(503, 6);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(117, 20);
            this.dateEdit2.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(444, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Date To :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(329, 6);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(110, 20);
            this.dateEdit1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(258, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Date From :";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sALESMAININSURANCEBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(754, 311);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sALESMAININSURANCEBindingSource
            // 
            this.sALESMAININSURANCEBindingSource.DataMember = "SALESMAININSURANCE";
            this.sALESMAININSURANCEBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSINVNO,
            this.colTRANDATE,
            this.colCUSTNAME,
            this.colCARDID,
            this.colNETAMT,
            this.colRECDAMT,
            this.colCREDITAMT,
            this.colCUSTOMERFIXDISC,
            this.colCARDDISC});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colSINVNO
            // 
            this.colSINVNO.AppearanceCell.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSINVNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSINVNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSINVNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSINVNO.Caption = "Invoice #";
            this.colSINVNO.FieldName = "SINVNO";
            this.colSINVNO.Name = "colSINVNO";
            this.colSINVNO.OptionsColumn.AllowEdit = false;
            this.colSINVNO.Visible = true;
            this.colSINVNO.VisibleIndex = 1;
            this.colSINVNO.Width = 110;
            // 
            // colTRANDATE
            // 
            this.colTRANDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANDATE.Caption = "Date";
            this.colTRANDATE.DisplayFormat.FormatString = "MMM dd, yyyy";
            this.colTRANDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANDATE.FieldName = "TRANDATE";
            this.colTRANDATE.Name = "colTRANDATE";
            this.colTRANDATE.OptionsColumn.AllowEdit = false;
            this.colTRANDATE.Visible = true;
            this.colTRANDATE.VisibleIndex = 0;
            this.colTRANDATE.Width = 90;
            // 
            // colCUSTNAME
            // 
            this.colCUSTNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTNAME.Caption = "Company";
            this.colCUSTNAME.FieldName = "CUSTNAME";
            this.colCUSTNAME.Name = "colCUSTNAME";
            this.colCUSTNAME.OptionsColumn.AllowEdit = false;
            this.colCUSTNAME.Visible = true;
            this.colCUSTNAME.VisibleIndex = 2;
            this.colCUSTNAME.Width = 160;
            // 
            // colCARDID
            // 
            this.colCARDID.AppearanceCell.Options.UseTextOptions = true;
            this.colCARDID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCARDID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCARDID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCARDID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCARDID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCARDID.Caption = "File No.";
            this.colCARDID.FieldName = "CARDID";
            this.colCARDID.Name = "colCARDID";
            this.colCARDID.OptionsColumn.AllowEdit = false;
            this.colCARDID.Visible = true;
            this.colCARDID.VisibleIndex = 5;
            this.colCARDID.Width = 51;
            // 
            // colNETAMT
            // 
            this.colNETAMT.AppearanceCell.Options.UseTextOptions = true;
            this.colNETAMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNETAMT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNETAMT.AppearanceHeader.Options.UseTextOptions = true;
            this.colNETAMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNETAMT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNETAMT.Caption = "Inv. Amt";
            this.colNETAMT.DisplayFormat.FormatString = "N2";
            this.colNETAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNETAMT.FieldName = "NETAMT";
            this.colNETAMT.Name = "colNETAMT";
            this.colNETAMT.OptionsColumn.AllowEdit = false;
            this.colNETAMT.Visible = true;
            this.colNETAMT.VisibleIndex = 6;
            this.colNETAMT.Width = 84;
            // 
            // colRECDAMT
            // 
            this.colRECDAMT.AppearanceCell.Options.UseTextOptions = true;
            this.colRECDAMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colRECDAMT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRECDAMT.AppearanceHeader.Options.UseTextOptions = true;
            this.colRECDAMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRECDAMT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRECDAMT.Caption = "Recd.Amt";
            this.colRECDAMT.DisplayFormat.FormatString = "N2";
            this.colRECDAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRECDAMT.FieldName = "RECDAMT";
            this.colRECDAMT.Name = "colRECDAMT";
            this.colRECDAMT.OptionsColumn.AllowEdit = false;
            this.colRECDAMT.Visible = true;
            this.colRECDAMT.VisibleIndex = 7;
            this.colRECDAMT.Width = 67;
            // 
            // colCREDITAMT
            // 
            this.colCREDITAMT.AppearanceCell.Options.UseTextOptions = true;
            this.colCREDITAMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCREDITAMT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCREDITAMT.AppearanceHeader.Options.UseTextOptions = true;
            this.colCREDITAMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCREDITAMT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCREDITAMT.Caption = "Credit Amt.";
            this.colCREDITAMT.DisplayFormat.FormatString = "N2";
            this.colCREDITAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCREDITAMT.FieldName = "CREDITAMT";
            this.colCREDITAMT.Name = "colCREDITAMT";
            this.colCREDITAMT.OptionsColumn.AllowEdit = false;
            this.colCREDITAMT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CREDITAMT", "{0:###,###.00}")});
            this.colCREDITAMT.Visible = true;
            this.colCREDITAMT.VisibleIndex = 8;
            this.colCREDITAMT.Width = 102;
            // 
            // colCUSTOMERFIXDISC
            // 
            this.colCUSTOMERFIXDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colCUSTOMERFIXDISC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCUSTOMERFIXDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERFIXDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colCUSTOMERFIXDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCUSTOMERFIXDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCUSTOMERFIXDISC.Caption = "% C";
            this.colCUSTOMERFIXDISC.DisplayFormat.FormatString = "##.00";
            this.colCUSTOMERFIXDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCUSTOMERFIXDISC.FieldName = "CUSTOMERFIXDISC";
            this.colCUSTOMERFIXDISC.MaxWidth = 45;
            this.colCUSTOMERFIXDISC.Name = "colCUSTOMERFIXDISC";
            this.colCUSTOMERFIXDISC.OptionsColumn.AllowEdit = false;
            this.colCUSTOMERFIXDISC.Visible = true;
            this.colCUSTOMERFIXDISC.VisibleIndex = 3;
            this.colCUSTOMERFIXDISC.Width = 33;
            // 
            // colCARDDISC
            // 
            this.colCARDDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colCARDDISC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCARDDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCARDDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colCARDDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCARDDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCARDDISC.Caption = "% P";
            this.colCARDDISC.DisplayFormat.FormatString = "##.00";
            this.colCARDDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCARDDISC.FieldName = "CARDDISC";
            this.colCARDDISC.MaxWidth = 45;
            this.colCARDDISC.Name = "colCARDDISC";
            this.colCARDDISC.OptionsColumn.AllowEdit = false;
            this.colCARDDISC.Visible = true;
            this.colCARDDISC.VisibleIndex = 4;
            this.colCARDDISC.Width = 35;
            // 
            // sTOREMASTDBBindingSource
            // 
            this.sTOREMASTDBBindingSource.DataMember = "STOREMASTDB";
            this.sTOREMASTDBBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.insuranceSalesByItemWiseBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 33);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(754, 311);
            this.gridControl2.TabIndex = 10;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // insuranceSalesByItemWiseBindingSource
            // 
            this.insuranceSalesByItemWiseBindingSource.DataMember = "InsuranceSalesByItemWise";
            this.insuranceSalesByItemWiseBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberNo,
            this.colFileNo,
            this.colPatientName,
            this.colCompanyName,
            this.colServiceDescription,
            this.colInv_No,
            this.colDate,
            this.colItemNo,
            this.colItemName,
            this.colQty,
            this.colTotal,
            this.gridColumn1,
            this.colP_S,
            this.colNetAmount});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // colMemberNo
            // 
            this.colMemberNo.AppearanceCell.Options.UseTextOptions = true;
            this.colMemberNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMemberNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMemberNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colMemberNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMemberNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMemberNo.FieldName = "Member No";
            this.colMemberNo.Name = "colMemberNo";
            this.colMemberNo.Visible = true;
            this.colMemberNo.VisibleIndex = 0;
            this.colMemberNo.Width = 52;
            // 
            // colFileNo
            // 
            this.colFileNo.AppearanceCell.Options.UseTextOptions = true;
            this.colFileNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFileNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFileNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colFileNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFileNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFileNo.FieldName = "File No";
            this.colFileNo.Name = "colFileNo";
            this.colFileNo.Visible = true;
            this.colFileNo.VisibleIndex = 1;
            this.colFileNo.Width = 52;
            // 
            // colPatientName
            // 
            this.colPatientName.AppearanceCell.Options.UseTextOptions = true;
            this.colPatientName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPatientName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPatientName.AppearanceHeader.Options.UseTextOptions = true;
            this.colPatientName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPatientName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPatientName.FieldName = "Patient Name";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.Visible = true;
            this.colPatientName.VisibleIndex = 2;
            this.colPatientName.Width = 52;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCompanyName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCompanyName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompanyName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompanyName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCompanyName.FieldName = "Company Name";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            this.colCompanyName.Width = 52;
            // 
            // colServiceDescription
            // 
            this.colServiceDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colServiceDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colServiceDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colServiceDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colServiceDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colServiceDescription.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colServiceDescription.FieldName = "Service Description";
            this.colServiceDescription.Name = "colServiceDescription";
            this.colServiceDescription.OptionsColumn.ReadOnly = true;
            this.colServiceDescription.Visible = true;
            this.colServiceDescription.VisibleIndex = 4;
            this.colServiceDescription.Width = 52;
            // 
            // colInv_No
            // 
            this.colInv_No.AppearanceCell.Options.UseTextOptions = true;
            this.colInv_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colInv_No.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colInv_No.AppearanceHeader.Options.UseTextOptions = true;
            this.colInv_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInv_No.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colInv_No.FieldName = "Inv_No";
            this.colInv_No.Name = "colInv_No";
            this.colInv_No.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colInv_No.Visible = true;
            this.colInv_No.VisibleIndex = 9;
            this.colInv_No.Width = 52;
            // 
            // colDate
            // 
            this.colDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDate.DisplayFormat.FormatString = "dd-MM-yy";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDate.FieldName = "Date";
            this.colDate.MaxWidth = 52;
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 8;
            this.colDate.Width = 52;
            // 
            // colItemNo
            // 
            this.colItemNo.AppearanceCell.Options.UseTextOptions = true;
            this.colItemNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItemNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemNo.FieldName = "Item No";
            this.colItemNo.Name = "colItemNo";
            this.colItemNo.Visible = true;
            this.colItemNo.VisibleIndex = 5;
            this.colItemNo.Width = 52;
            // 
            // colItemName
            // 
            this.colItemName.AppearanceCell.Options.UseTextOptions = true;
            this.colItemName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItemName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemName.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemName.FieldName = "Item Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 6;
            this.colItemName.Width = 77;
            // 
            // colQty
            // 
            this.colQty.AppearanceCell.Options.UseTextOptions = true;
            this.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQty.FieldName = "Qty";
            this.colQty.MaxWidth = 30;
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 7;
            this.colQty.Width = 30;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotal.DisplayFormat.FormatString = "n2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 10;
            this.colTotal.Width = 50;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.DisplayFormat.FormatString = "n2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "10 % Bupa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            this.gridColumn1.Width = 50;
            // 
            // colP_S
            // 
            this.colP_S.AppearanceCell.Options.UseTextOptions = true;
            this.colP_S.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colP_S.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colP_S.AppearanceHeader.Options.UseTextOptions = true;
            this.colP_S.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colP_S.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colP_S.DisplayFormat.FormatString = "n2";
            this.colP_S.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colP_S.FieldName = "P_S";
            this.colP_S.MaxWidth = 45;
            this.colP_S.Name = "colP_S";
            this.colP_S.OptionsColumn.ReadOnly = true;
            this.colP_S.Visible = true;
            this.colP_S.VisibleIndex = 12;
            this.colP_S.Width = 45;
            // 
            // colNetAmount
            // 
            this.colNetAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colNetAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNetAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNetAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colNetAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNetAmount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNetAmount.DisplayFormat.FormatString = "n2";
            this.colNetAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetAmount.FieldName = "Net Amount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.OptionsColumn.ReadOnly = true;
            this.colNetAmount.Visible = true;
            this.colNetAmount.VisibleIndex = 13;
            this.colNetAmount.Width = 64;
            // 
            // RptInsuranceSalesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 344);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptInsuranceSalesDetails";
            this.Text = "Part Payement List";
            this.Load += new System.EventHandler(this.RptInsuranceSalesDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESMAININSURANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceSalesByItemWiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private DateEdit dateEdit2;
        private LabelControl labelControl2;
        private DateEdit dateEdit1;
        private LabelControl labelControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource sALESMAININSURANCEBindingSource;
        private GridColumn colSINVNO;
        private GridColumn colTRANDATE;
        private GridColumn colCUSTNAME;
        private GridColumn colCARDID;
        private GridColumn colNETAMT;
        private GridColumn colRECDAMT;
        private GridColumn colCREDITAMT;
        private GridColumn colCUSTOMERFIXDISC;
        private GridColumn colCARDDISC;
        private LookUpEdit lookUpEdit3;
        private LabelControl lblstore;
        private BindingSource sTOREMASTDBBindingSource;
        private GridControl gridControl2;
        private GridView gridView2;
        private BindingSource insuranceSalesByItemWiseBindingSource;
        private GridColumn colMemberNo;
        private GridColumn colFileNo;
        private GridColumn colPatientName;
        private GridColumn colCompanyName;
        private GridColumn colServiceDescription;
        private GridColumn colInv_No;
        private GridColumn colDate;
        private GridColumn colItemNo;
        private GridColumn colItemName;
        private GridColumn colQty;
        private GridColumn colTotal;
        private GridColumn gridColumn1;
        private GridColumn colP_S;
        private GridColumn colNetAmount;
    }
}