using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using VIRETAILENTITIES;

namespace Store
{
    partial class BasePurInvoice
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
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label cOMPNAMELabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label9;
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePurInvoice));
            this.colQTY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lookupwarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.lookuppo = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.LookuptoStore = new DevExpress.XtraEditors.LookUpEdit();
            this.spdisc = new DevExpress.XtraEditors.TextEdit();
            this.duedays = new DevExpress.XtraEditors.TextEdit();
            this.invdate = new DevExpress.XtraEditors.DateEdit();
            this.invno = new DevExpress.XtraEditors.TextEdit();
            this.LookupSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpurno = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totdisc = new DevExpress.XtraEditors.TextEdit();
            this.totvalue = new DevExpress.XtraEditors.TextEdit();
            this.totnetamt = new DevExpress.XtraEditors.TextEdit();
            this.totspecdisc = new DevExpress.XtraEditors.TextEdit();
            this.paneltotcost = new System.Windows.Forms.Panel();
            this.totprofit = new DevExpress.XtraEditors.TextEdit();
            this.totsalevalue = new DevExpress.XtraEditors.TextEdit();
            this.totcostvalue = new DevExpress.XtraEditors.TextEdit();
            this.adjustval = new DevExpress.XtraEditors.TextEdit();
            this.pURINVDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPurchase1 = new VIRETAILENTITIES.DsPurchase();
            this.dsInventory1 = new VIRETAILENTITIES.DsInventory();
            this.panel3 = new System.Windows.Forms.Panel();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.FindItem = new DevExpress.XtraBars.BarButtonItem();
            this.ItemHistory = new DevExpress.XtraBars.BarButtonItem();
            this.CopyRow = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteLine = new DevExpress.XtraBars.BarButtonItem();
            this.Autosalesbutton = new DevExpress.XtraBars.BarButtonItem();
            this.Unitconversionbutton = new DevExpress.XtraBars.BarCheckItem();
            this.bargift = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemPopupContainerEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rETURNDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelunit = new System.Windows.Forms.Panel();
            this.txttotunitvalue = new DevExpress.XtraEditors.TextEdit();
            this.label22 = new System.Windows.Forms.Label();
            this.txttotunits = new DevExpress.XtraEditors.TextEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.txtunitqty = new DevExpress.XtraEditors.TextEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.lookupunits = new DevExpress.XtraEditors.LookUpEdit();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelautosales = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBARCODE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBATCHNO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBONUSQTY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDISC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSPDISC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSPRICE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEXPDATE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colEXPDT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLINETOTAL = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dropitem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGROUPID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dropitemgroup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCPRICE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPROFIT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGROSSVALUE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPONO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPURINVID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEXPR = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTOSTORE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINVDISC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dropitem1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            label12 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cOMPNAMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookuppo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookuptoStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurno.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totdisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totvalue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totnetamt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totspecdisc.Properties)).BeginInit();
            this.paneltotcost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totprofit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totsalevalue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totcostvalue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURINVDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNDETAILBindingSource)).BeginInit();
            this.panelunit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotunitvalue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotunits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunitqty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupunits.Properties)).BeginInit();
            this.panelautosales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitemgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(807, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(235, 55);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(78, 14);
            label12.TabIndex = 85;
            label12.Text = "Spl.Disc (%):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(9, 54);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 14);
            label6.TabIndex = 84;
            label6.Text = "Due Days:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(235, 32);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 14);
            label4.TabIndex = 83;
            label4.Text = "Invoice Date: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(9, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 14);
            label3.TabIndex = 82;
            label3.Text = "Invoice #: ";
            // 
            // cOMPNAMELabel
            // 
            cOMPNAMELabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cOMPNAMELabel.AutoSize = true;
            cOMPNAMELabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOMPNAMELabel.Location = new System.Drawing.Point(9, 6);
            cOMPNAMELabel.Name = "cOMPNAMELabel";
            cOMPNAMELabel.Size = new System.Drawing.Size(88, 14);
            cOMPNAMELabel.TabIndex = 81;
            cOMPNAMELabel.Text = "Supplier name:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(437, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 14);
            label1.TabIndex = 24;
            label1.Text = "Doc #:";
            // 
            // label10
            // 
            label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(347, 73);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(121, 14);
            label10.TabIndex = 23;
            label10.Text = "Adjusted Value(F7): ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(7, 62);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(76, 14);
            label15.TabIndex = 38;
            label15.Text = "Total Profit: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(7, 19);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(103, 14);
            label8.TabIndex = 35;
            label8.Text = "Total Sale Value: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(7, 40);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(105, 14);
            label7.TabIndex = 34;
            label7.Text = "Total Cost Value: ";
            // 
            // label17
            // 
            label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(637, 7);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(44, 14);
            label17.TabIndex = 94;
            label17.Text = "P.O #:";
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(6, 29);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(102, 14);
            label14.TabIndex = 42;
            label14.Text = "Total  Disc Value: ";
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(6, 8);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(73, 14);
            label13.TabIndex = 41;
            label13.Text = "Total Value: ";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(6, 70);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(83, 14);
            label11.TabIndex = 40;
            label11.Text = "Net Amount : ";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(6, 50);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(88, 14);
            label9.TabIndex = 39;
            label9.Text = "Total Spl Disc.: ";
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colQTY.AppearanceCell.Options.UseFont = true;
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Qty.";
            this.colQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQTY.OptionsFilter.AllowAutoFilter = false;
            this.colQTY.OptionsFilter.AllowFilter = false;
            this.colQTY.Visible = true;
            this.colQTY.Width = 53;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lookupwarehouse);
            this.panel1.Controls.Add(this.lookuppo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(label17);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.LookuptoStore);
            this.panel1.Controls.Add(this.spdisc);
            this.panel1.Controls.Add(label12);
            this.panel1.Controls.Add(this.duedays);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.invdate);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.invno);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(cOMPNAMELabel);
            this.panel1.Controls.Add(this.LookupSupplier);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtpurno);
            this.panel1.Controls.Add(label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 75);
            this.panel1.TabIndex = 0;
            // 
            // Lookupwarehouse
            // 
            this.Lookupwarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lookupwarehouse.Location = new System.Drawing.Point(538, 29);
            this.Lookupwarehouse.Name = "Lookupwarehouse";
            this.Lookupwarehouse.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Lookupwarehouse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lookupwarehouse.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lookupwarehouse.Properties.Appearance.Options.UseBackColor = true;
            this.Lookupwarehouse.Properties.Appearance.Options.UseFont = true;
            this.Lookupwarehouse.Properties.Appearance.Options.UseForeColor = true;
            this.Lookupwarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lookupwarehouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "STORECODE", 92, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORETYPE", "STORETYPE")});
            this.Lookupwarehouse.Properties.DisplayMember = "STORENAME";
            this.Lookupwarehouse.Properties.NullText = "";
            this.Lookupwarehouse.Properties.ShowFooter = false;
            this.Lookupwarehouse.Properties.ShowHeader = false;
            this.Lookupwarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Lookupwarehouse.Properties.ValueMember = "STORECODE";
            this.Lookupwarehouse.Size = new System.Drawing.Size(266, 20);
            this.Lookupwarehouse.TabIndex = 5;
            // 
            // lookuppo
            // 
            this.lookuppo.Location = new System.Drawing.Point(679, 5);
            this.lookuppo.MenuManager = this.ribbon;
            this.lookuppo.Name = "lookuppo";
            this.lookuppo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookuppo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lookuppo.Properties.Appearance.Options.UseBackColor = true;
            this.lookuppo.Properties.Appearance.Options.UseForeColor = true;
            this.lookuppo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookuppo.Properties.DisplayMember = "PONO";
            this.lookuppo.Properties.NullText = "";
            this.lookuppo.Properties.ValueMember = "PONO";
            this.lookuppo.Size = new System.Drawing.Size(99, 20);
            this.lookuppo.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = "Allocation  Store:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton1.Image = global::Store.Properties.Resources.page_white_magnify;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(782, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(20, 19);
            this.simpleButton1.TabIndex = 92;
            // 
            // LookuptoStore
            // 
            this.LookuptoStore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookuptoStore.EnterMoveNextControl = true;
            this.LookuptoStore.Location = new System.Drawing.Point(538, 52);
            this.LookuptoStore.Name = "LookuptoStore";
            this.LookuptoStore.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.LookuptoStore.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookuptoStore.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LookuptoStore.Properties.Appearance.Options.UseBackColor = true;
            this.LookuptoStore.Properties.Appearance.Options.UseFont = true;
            this.LookuptoStore.Properties.Appearance.Options.UseForeColor = true;
            this.LookuptoStore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookuptoStore.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "STORECODE", 92, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LookuptoStore.Properties.DisplayMember = "STORENAME";
            this.LookuptoStore.Properties.NullText = "";
            this.LookuptoStore.Properties.ShowFooter = false;
            this.LookuptoStore.Properties.ShowHeader = false;
            this.LookuptoStore.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookuptoStore.Properties.ValueMember = "STORECODE";
            this.LookuptoStore.Size = new System.Drawing.Size(266, 20);
            this.LookuptoStore.TabIndex = 6;
            this.LookuptoStore.EditValueChanged += new System.EventHandler(this.LookuptoStore_EditValueChanged);
            this.LookuptoStore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LookuptoStoreKeyDown);
            // 
            // spdisc
            // 
            this.spdisc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spdisc.EnterMoveNextControl = true;
            this.spdisc.Location = new System.Drawing.Point(319, 52);
            this.spdisc.Name = "spdisc";
            this.spdisc.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.spdisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spdisc.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.spdisc.Properties.Appearance.Options.UseBackColor = true;
            this.spdisc.Properties.Appearance.Options.UseFont = true;
            this.spdisc.Properties.Appearance.Options.UseForeColor = true;
            this.spdisc.Properties.Appearance.Options.UseTextOptions = true;
            this.spdisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.spdisc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spdisc.Properties.NullText = "0";
            this.spdisc.Size = new System.Drawing.Size(103, 20);
            this.spdisc.TabIndex = 4;
            // 
            // duedays
            // 
            this.duedays.EnterMoveNextControl = true;
            this.duedays.Location = new System.Drawing.Point(98, 52);
            this.duedays.Name = "duedays";
            this.duedays.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.duedays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedays.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.duedays.Properties.Appearance.Options.UseBackColor = true;
            this.duedays.Properties.Appearance.Options.UseFont = true;
            this.duedays.Properties.Appearance.Options.UseForeColor = true;
            this.duedays.Properties.Appearance.Options.UseTextOptions = true;
            this.duedays.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.duedays.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.duedays.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.duedays.Properties.NullText = "0";
            this.duedays.Size = new System.Drawing.Size(113, 20);
            this.duedays.TabIndex = 3;
            // 
            // invdate
            // 
            this.invdate.EditValue = new System.DateTime(2012, 7, 17, 0, 0, 0, 0);
            this.invdate.EnterMoveNextControl = true;
            this.invdate.Location = new System.Drawing.Point(319, 29);
            this.invdate.Name = "invdate";
            this.invdate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.invdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invdate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.invdate.Properties.Appearance.Options.UseBackColor = true;
            this.invdate.Properties.Appearance.Options.UseFont = true;
            this.invdate.Properties.Appearance.Options.UseForeColor = true;
            this.invdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.invdate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.invdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.invdate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.invdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.invdate.Size = new System.Drawing.Size(104, 20);
            this.invdate.TabIndex = 2;
            // 
            // invno
            // 
            this.invno.EnterMoveNextControl = true;
            this.invno.Location = new System.Drawing.Point(98, 29);
            this.invno.Name = "invno";
            this.invno.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.invno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.invno.Properties.Appearance.Options.UseBackColor = true;
            this.invno.Properties.Appearance.Options.UseFont = true;
            this.invno.Properties.Appearance.Options.UseForeColor = true;
            this.invno.Properties.Appearance.Options.UseTextOptions = true;
            this.invno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.invno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.invno.Size = new System.Drawing.Size(113, 20);
            this.invno.TabIndex = 1;
            // 
            // LookupSupplier
            // 
            this.LookupSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookupSupplier.EnterMoveNextControl = true;
            this.LookupSupplier.Location = new System.Drawing.Point(98, 4);
            this.LookupSupplier.Name = "LookupSupplier";
            this.LookupSupplier.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.LookupSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LookupSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.LookupSupplier.Properties.Appearance.Options.UseFont = true;
            this.LookupSupplier.Properties.Appearance.Options.UseForeColor = true;
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
            this.LookupSupplier.Size = new System.Drawing.Size(324, 20);
            this.LookupSupplier.TabIndex = 0;
            this.LookupSupplier.EditValueChanged += new System.EventHandler(this.SupplierEditValueChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(437, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 14);
            this.label16.TabIndex = 75;
            this.label16.Text = "Warehouse:";
            // 
            // txtpurno
            // 
            this.txtpurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpurno.Location = new System.Drawing.Point(538, 5);
            this.txtpurno.Name = "txtpurno";
            this.txtpurno.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtpurno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtpurno.Properties.Appearance.Options.UseBackColor = true;
            this.txtpurno.Properties.Appearance.Options.UseFont = true;
            this.txtpurno.Properties.Appearance.Options.UseForeColor = true;
            this.txtpurno.Properties.Appearance.Options.UseTextOptions = true;
            this.txtpurno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtpurno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtpurno.Properties.ReadOnly = true;
            this.txtpurno.Size = new System.Drawing.Size(97, 20);
            this.txtpurno.TabIndex = 25;
            this.txtpurno.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.paneltotcost);
            this.panel2.Controls.Add(this.adjustval);
            this.panel2.Controls.Add(label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 99);
            this.panel2.TabIndex = 88;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(84)))));
            this.panel4.Controls.Add(this.totdisc);
            this.panel4.Controls.Add(this.totvalue);
            this.panel4.Controls.Add(this.totnetamt);
            this.panel4.Controls.Add(this.totspecdisc);
            this.panel4.Controls.Add(label14);
            this.panel4.Controls.Add(label13);
            this.panel4.Controls.Add(label11);
            this.panel4.Controls.Add(label9);
            this.panel4.Location = new System.Drawing.Point(567, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 90);
            this.panel4.TabIndex = 39;
            // 
            // totdisc
            // 
            this.totdisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totdisc.Location = new System.Drawing.Point(112, 23);
            this.totdisc.Name = "totdisc";
            this.totdisc.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.totdisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totdisc.Properties.Appearance.Options.UseBackColor = true;
            this.totdisc.Properties.Appearance.Options.UseFont = true;
            this.totdisc.Properties.Appearance.Options.UseTextOptions = true;
            this.totdisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totdisc.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totdisc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totdisc.Properties.NullText = "0";
            this.totdisc.Properties.ReadOnly = true;
            this.totdisc.Size = new System.Drawing.Size(118, 20);
            this.totdisc.TabIndex = 70;
            // 
            // totvalue
            // 
            this.totvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totvalue.Location = new System.Drawing.Point(112, 2);
            this.totvalue.Name = "totvalue";
            this.totvalue.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.totvalue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totvalue.Properties.Appearance.Options.UseBackColor = true;
            this.totvalue.Properties.Appearance.Options.UseFont = true;
            this.totvalue.Properties.Appearance.Options.UseTextOptions = true;
            this.totvalue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totvalue.Properties.DisplayFormat.FormatString = "###,###,###,###.00";
            this.totvalue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totvalue.Properties.NullText = "0";
            this.totvalue.Properties.ReadOnly = true;
            this.totvalue.Size = new System.Drawing.Size(118, 20);
            this.totvalue.TabIndex = 69;
            // 
            // totnetamt
            // 
            this.totnetamt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totnetamt.Location = new System.Drawing.Point(112, 65);
            this.totnetamt.Name = "totnetamt";
            this.totnetamt.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.totnetamt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totnetamt.Properties.Appearance.Options.UseBackColor = true;
            this.totnetamt.Properties.Appearance.Options.UseFont = true;
            this.totnetamt.Properties.Appearance.Options.UseTextOptions = true;
            this.totnetamt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totnetamt.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totnetamt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totnetamt.Properties.NullText = "0";
            this.totnetamt.Properties.ReadOnly = true;
            this.totnetamt.Size = new System.Drawing.Size(118, 20);
            this.totnetamt.TabIndex = 9;
            // 
            // totspecdisc
            // 
            this.totspecdisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totspecdisc.Location = new System.Drawing.Point(112, 44);
            this.totspecdisc.Name = "totspecdisc";
            this.totspecdisc.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.totspecdisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totspecdisc.Properties.Appearance.Options.UseBackColor = true;
            this.totspecdisc.Properties.Appearance.Options.UseFont = true;
            this.totspecdisc.Properties.Appearance.Options.UseTextOptions = true;
            this.totspecdisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totspecdisc.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totspecdisc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totspecdisc.Properties.NullText = "0";
            this.totspecdisc.Properties.ReadOnly = true;
            this.totspecdisc.Size = new System.Drawing.Size(118, 20);
            this.totspecdisc.TabIndex = 67;
            // 
            // paneltotcost
            // 
            this.paneltotcost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(84)))));
            this.paneltotcost.Controls.Add(this.totprofit);
            this.paneltotcost.Controls.Add(label15);
            this.paneltotcost.Controls.Add(this.totsalevalue);
            this.paneltotcost.Controls.Add(this.totcostvalue);
            this.paneltotcost.Controls.Add(label8);
            this.paneltotcost.Controls.Add(label7);
            this.paneltotcost.Location = new System.Drawing.Point(3, 5);
            this.paneltotcost.Name = "paneltotcost";
            this.paneltotcost.Size = new System.Drawing.Size(231, 83);
            this.paneltotcost.TabIndex = 34;
            // 
            // totprofit
            // 
            this.totprofit.Location = new System.Drawing.Point(109, 60);
            this.totprofit.Name = "totprofit";
            this.totprofit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.totprofit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totprofit.Properties.Appearance.Options.UseBackColor = true;
            this.totprofit.Properties.Appearance.Options.UseFont = true;
            this.totprofit.Properties.Appearance.Options.UseTextOptions = true;
            this.totprofit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totprofit.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totprofit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totprofit.Properties.NullText = "0";
            this.totprofit.Properties.ReadOnly = true;
            this.totprofit.Size = new System.Drawing.Size(118, 20);
            this.totprofit.TabIndex = 39;
            // 
            // totsalevalue
            // 
            this.totsalevalue.Location = new System.Drawing.Point(109, 17);
            this.totsalevalue.Name = "totsalevalue";
            this.totsalevalue.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.totsalevalue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totsalevalue.Properties.Appearance.Options.UseBackColor = true;
            this.totsalevalue.Properties.Appearance.Options.UseFont = true;
            this.totsalevalue.Properties.Appearance.Options.UseTextOptions = true;
            this.totsalevalue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totsalevalue.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totsalevalue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totsalevalue.Properties.NullText = "0";
            this.totsalevalue.Properties.ReadOnly = true;
            this.totsalevalue.Size = new System.Drawing.Size(118, 20);
            this.totsalevalue.TabIndex = 37;
            // 
            // totcostvalue
            // 
            this.totcostvalue.Location = new System.Drawing.Point(109, 38);
            this.totcostvalue.Name = "totcostvalue";
            this.totcostvalue.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.totcostvalue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totcostvalue.Properties.Appearance.Options.UseBackColor = true;
            this.totcostvalue.Properties.Appearance.Options.UseFont = true;
            this.totcostvalue.Properties.Appearance.Options.UseTextOptions = true;
            this.totcostvalue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totcostvalue.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totcostvalue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totcostvalue.Properties.NullText = "0";
            this.totcostvalue.Properties.ReadOnly = true;
            this.totcostvalue.Size = new System.Drawing.Size(118, 20);
            this.totcostvalue.TabIndex = 36;
            // 
            // adjustval
            // 
            this.adjustval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adjustval.EditValue = "0";
            this.adjustval.EnterMoveNextControl = true;
            this.adjustval.Location = new System.Drawing.Point(466, 70);
            this.adjustval.Name = "adjustval";
            this.adjustval.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustval.Properties.Appearance.Options.UseFont = true;
            this.adjustval.Properties.Appearance.Options.UseTextOptions = true;
            this.adjustval.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.adjustval.Properties.DisplayFormat.FormatString = "n2";
            this.adjustval.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.adjustval.Properties.EditFormat.FormatString = "n2";
            this.adjustval.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.adjustval.Properties.Mask.EditMask = "n2";
            this.adjustval.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.adjustval.Properties.NullText = "0";
            this.adjustval.Size = new System.Drawing.Size(67, 20);
            this.adjustval.TabIndex = 8;
            this.adjustval.TextChanged += new System.EventHandler(this.adjustval_EditValueChanged);
            this.adjustval.Enter += new System.EventHandler(this.adjustval_Enter);
            // 
            // pURINVDETAILBindingSource
            // 
            this.pURINVDETAILBindingSource.DataMember = "PURINVDETAIL";
            this.pURINVDETAILBindingSource.DataSource = this.dsPurchase1;
            this.pURINVDETAILBindingSource.CurrentChanged += new System.EventHandler(this.PUrinvdetailBindingSourceCurrentChanged);
            // 
            // dsPurchase1
            // 
            this.dsPurchase1.DataSetName = "DsPurchase";
            this.dsPurchase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsInventory1
            // 
            this.dsInventory1.DataSetName = "DsInventory";
            this.dsInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.standaloneBarDockControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 30);
            this.panel3.TabIndex = 4;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(807, 30);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.FindItem,
            this.CopyRow,
            this.DeleteLine,
            this.ItemHistory,
            this.barButtonItem7,
            this.barEditItem2,
            this.Autosalesbutton,
            this.Unitconversionbutton,
            this.bargift});
            this.barManager1.MaxItemId = 16;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemPopupContainerEdit2,
            this.repositoryItemLookUpEdit1});
            this.barManager1.UseF10KeyForMenu = false;
            this.barManager1.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.BarManager1EditorKeyDown);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(315, 342);
            this.bar1.FloatSize = new System.Drawing.Size(785, 31);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barEditItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.FindItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ItemHistory, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.CopyRow, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.DeleteLine, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Autosalesbutton, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Unitconversionbutton, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bargift, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // barEditItem2
            // 
            this.barEditItem2.AutoFillWidth = true;
            this.barEditItem2.Edit = this.repositoryItemTextEdit1;
            this.barEditItem2.Id = 8;
            this.barEditItem2.IEBehavior = true;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "Barcode / Name";
            this.repositoryItemTextEdit1.NullValuePrompt = "Barcode / Name";
            this.repositoryItemTextEdit1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemTextEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemTextEdit1_KeyDown);
            // 
            // FindItem
            // 
            this.FindItem.Caption = "Find Item - F10";
            this.FindItem.Glyph = global::Store.Properties.Resources.page_white_magnify;
            this.FindItem.Id = 0;
            this.FindItem.Name = "FindItem";
            this.FindItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemItemClick);
            // 
            // ItemHistory
            // 
            this.ItemHistory.Caption = "Item Histroy - F8";
            this.ItemHistory.Glyph = global::Store.Properties.Resources.date_magnify;
            this.ItemHistory.Id = 3;
            this.ItemHistory.Name = "ItemHistory";
            this.ItemHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemItemClick);
            // 
            // CopyRow
            // 
            this.CopyRow.Caption = "Copy Row - F5";
            this.CopyRow.Glyph = global::Store.Properties.Resources.page_copy;
            this.CopyRow.Id = 1;
            this.CopyRow.Name = "CopyRow";
            this.CopyRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemItemClick);
            // 
            // DeleteLine
            // 
            this.DeleteLine.Caption = "Delete Line - F4";
            this.DeleteLine.Glyph = global::Store.Properties.Resources.remove;
            this.DeleteLine.Id = 2;
            this.DeleteLine.Name = "DeleteLine";
            this.DeleteLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemItemClick);
            // 
            // Autosalesbutton
            // 
            this.Autosalesbutton.Caption = "Auto - F11";
            this.Autosalesbutton.Glyph = global::Store.Properties.Resources.run;
            this.Autosalesbutton.Hint = "Auto Sales Price - F3";
            this.Autosalesbutton.Id = 11;
            this.Autosalesbutton.Name = "Autosalesbutton";
            this.Autosalesbutton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Autosalesbutton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemItemClick);
            // 
            // Unitconversionbutton
            // 
            this.Unitconversionbutton.Caption = "Unit - F12";
            this.Unitconversionbutton.Glyph = global::Store.Properties.Resources.scales;
            this.Unitconversionbutton.Id = 12;
            this.Unitconversionbutton.Name = "Unitconversionbutton";
            this.Unitconversionbutton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bargift
            // 
            this.bargift.Caption = "Gift - F2";
            this.bargift.Glyph = global::Store.Properties.Resources.gifticon;
            this.bargift.Id = 15;
            this.bargift.Name = "bargift";
            this.bargift.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(807, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 571);
            this.barDockControlBottom.Size = new System.Drawing.Size(807, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 571);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(807, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 571);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Merge Rows";
            this.barButtonItem7.Id = 5;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemPopupContainerEdit2
            // 
            this.repositoryItemPopupContainerEdit2.AutoHeight = false;
            this.repositoryItemPopupContainerEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit2.Name = "repositoryItemPopupContainerEdit2";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // rETURNDETAILBindingSource
            // 
            this.rETURNDETAILBindingSource.DataMember = "RETURNDETAIL";
            this.rETURNDETAILBindingSource.DataSource = this.dsPurchase1;
            this.rETURNDETAILBindingSource.CurrentChanged += new System.EventHandler(this.REturndetailBindingSourceCurrentChanged);
            // 
            // panelunit
            // 
            this.panelunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelunit.Controls.Add(this.txttotunitvalue);
            this.panelunit.Controls.Add(this.label22);
            this.panelunit.Controls.Add(this.txttotunits);
            this.panelunit.Controls.Add(this.label21);
            this.panelunit.Controls.Add(this.txtunitqty);
            this.panelunit.Controls.Add(this.label20);
            this.panelunit.Controls.Add(this.lookupunits);
            this.panelunit.Controls.Add(this.label19);
            this.panelunit.Controls.Add(this.label18);
            this.panelunit.Controls.Add(this.label5);
            this.panelunit.Location = new System.Drawing.Point(62, 313);
            this.panelunit.Name = "panelunit";
            this.panelunit.Size = new System.Drawing.Size(436, 46);
            this.panelunit.TabIndex = 99;
            this.panelunit.Visible = false;
            // 
            // txttotunitvalue
            // 
            this.txttotunitvalue.Location = new System.Drawing.Point(361, 22);
            this.txttotunitvalue.Name = "txttotunitvalue";
            this.txttotunitvalue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txttotunitvalue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txttotunitvalue.Size = new System.Drawing.Size(71, 20);
            this.txttotunitvalue.TabIndex = 10;
            this.txttotunitvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxttotunitvalueKeyPress);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(300, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Unit Value: ";
            // 
            // txttotunits
            // 
            this.txttotunits.Location = new System.Drawing.Point(260, 22);
            this.txttotunits.Name = "txttotunits";
            this.txttotunits.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txttotunits.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txttotunits.Size = new System.Drawing.Size(37, 20);
            this.txttotunits.TabIndex = 9;
            this.txttotunits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxttotunitsKeyDown);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(197, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Total Units: ";
            // 
            // txtunitqty
            // 
            this.txtunitqty.Location = new System.Drawing.Point(156, 22);
            this.txtunitqty.Name = "txtunitqty";
            this.txtunitqty.Properties.ReadOnly = true;
            this.txtunitqty.Size = new System.Drawing.Size(37, 20);
            this.txtunitqty.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(138, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "=";
            // 
            // lookupunits
            // 
            this.lookupunits.Location = new System.Drawing.Point(34, 22);
            this.lookupunits.Name = "lookupunits";
            this.lookupunits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupunits.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITDESC", "Unit"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITVALUE", "Qty"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UNITID", "UNITID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UCODE", "UCODE", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookupunits.Properties.DisplayMember = "UNITDESC";
            this.lookupunits.Properties.NullText = "";
            this.lookupunits.Properties.ValueMember = "UNITDESC";
            this.lookupunits.Size = new System.Drawing.Size(100, 20);
            this.lookupunits.TabIndex = 8;
            this.lookupunits.EditValueChanged += new System.EventHandler(this.LookUpEdit1EditValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Unit: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Gray;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(418, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "X";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.Label18Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Unit Conversion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelautosales
            // 
            this.panelautosales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelautosales.Controls.Add(this.simpleButton3);
            this.panelautosales.Controls.Add(this.simpleButton2);
            this.panelautosales.Controls.Add(this.radioGroup1);
            this.panelautosales.Controls.Add(this.spinEdit1);
            this.panelautosales.Controls.Add(this.label25);
            this.panelautosales.Controls.Add(this.label24);
            this.panelautosales.Controls.Add(this.label23);
            this.panelautosales.Location = new System.Drawing.Point(63, 365);
            this.panelautosales.Name = "panelautosales";
            this.panelautosales.Size = new System.Drawing.Size(436, 56);
            this.panelautosales.TabIndex = 104;
            this.panelautosales.Visible = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(385, 35);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(47, 18);
            this.simpleButton3.TabIndex = 39;
            this.simpleButton3.Text = "Clear";
            this.simpleButton3.Click += new System.EventHandler(this.SimpleButton3Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(385, 17);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(47, 17);
            this.simpleButton2.TabIndex = 36;
            this.simpleButton2.Text = "Set";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2Click);
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = true;
            this.radioGroup1.Location = new System.Drawing.Point(177, 24);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "By Invoice Rate"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "By Cost Price")});
            this.radioGroup1.Size = new System.Drawing.Size(205, 21);
            this.radioGroup1.TabIndex = 35;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(121, 25);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Size = new System.Drawing.Size(52, 20);
            this.spinEdit1.TabIndex = 34;
            this.spinEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpinEdit1KeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(2, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "Profit Percentage: (%)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Gray;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(418, 1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 16);
            this.label24.TabIndex = 32;
            this.label24.Text = "X";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Click += new System.EventHandler(this.Label24Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Silver;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(434, 17);
            this.label23.TabIndex = 31;
            this.label23.Text = "Auto Sales Price Calculation";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 250);
            this.gridControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropitem,
            this.dropitem1,
            this.dropitemgroup,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.gridControl1.Size = new System.Drawing.Size(807, 190);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            this.gridControl1.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControl1EditorKeyDown);
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colTID,
            this.colBARCODE,
            this.colQTY,
            this.colBONUSQTY,
            this.colINVRATE,
            this.colDISC,
            this.colSPDISC,
            this.colSPRICE,
            this.colCPRICE,
            this.colEXPDT,
            this.colLINETOTAL,
            this.colGROSSVALUE,
            this.colPROFIT,
            this.colBATCHNO,
            this.colPONO,
            this.colPURINVID,
            this.colEXPR,
            this.colITEMNO,
            this.colGROUPID,
            this.colStock,
            this.colTOSTORE,
            this.colINVDISC,
            this.colEXPDATE});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colQTY;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = ((short)(0));
            this.advBandedGridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridView1.IndicatorWidth = 55;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.advBandedGridView1.OptionsCustomization.AllowFilter = false;
            this.advBandedGridView1.OptionsCustomization.AllowGroup = false;
            this.advBandedGridView1.OptionsCustomization.AllowSort = false;
            this.advBandedGridView1.OptionsMenu.EnableColumnMenu = false;
            this.advBandedGridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.advBandedGridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.advBandedGridView1.OptionsView.ShowBands = false;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.CustomDrawRowIndicator);
            this.advBandedGridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.advBandedGridView1_ShowingEditor);
            this.advBandedGridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.AdvBandedGridView1CellValueChanged);
            this.advBandedGridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.InvalidRowException);
            this.advBandedGridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ValidateRow);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colBARCODE);
            this.gridBand1.Columns.Add(this.colBATCHNO);
            this.gridBand1.Columns.Add(this.colStock);
            this.gridBand1.Columns.Add(this.colQTY);
            this.gridBand1.Columns.Add(this.colBONUSQTY);
            this.gridBand1.Columns.Add(this.colINVRATE);
            this.gridBand1.Columns.Add(this.colDISC);
            this.gridBand1.Columns.Add(this.colSPDISC);
            this.gridBand1.Columns.Add(this.colSPRICE);
            this.gridBand1.Columns.Add(this.colEXPDATE);
            this.gridBand1.Columns.Add(this.colEXPDT);
            this.gridBand1.Columns.Add(this.colLINETOTAL);
            this.gridBand1.Columns.Add(this.colITEMNO);
            this.gridBand1.Columns.Add(this.colGROUPID);
            this.gridBand1.Columns.Add(this.colCPRICE);
            this.gridBand1.Columns.Add(this.colPROFIT);
            this.gridBand1.Columns.Add(this.colGROSSVALUE);
            this.gridBand1.Columns.Add(this.colTID);
            this.gridBand1.Columns.Add(this.colPONO);
            this.gridBand1.Columns.Add(this.colPURINVID);
            this.gridBand1.Columns.Add(this.colEXPR);
            this.gridBand1.Columns.Add(this.colTOSTORE);
            this.gridBand1.Columns.Add(this.colINVDISC);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 758;
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colBARCODE.AppearanceCell.Options.UseFont = true;
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colBARCODE.AppearanceHeader.Options.UseFont = true;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.Caption = "Barcode";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBARCODE.OptionsFilter.AllowAutoFilter = false;
            this.colBARCODE.OptionsFilter.AllowFilter = false;
            this.colBARCODE.Visible = true;
            this.colBARCODE.Width = 172;
            // 
            // colBATCHNO
            // 
            this.colBATCHNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colBATCHNO.AppearanceCell.Options.UseFont = true;
            this.colBATCHNO.AppearanceCell.Options.UseTextOptions = true;
            this.colBATCHNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBATCHNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colBATCHNO.AppearanceHeader.Options.UseFont = true;
            this.colBATCHNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colBATCHNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBATCHNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBATCHNO.Caption = "Batch #";
            this.colBATCHNO.FieldName = "BATCHNO";
            this.colBATCHNO.Name = "colBATCHNO";
            this.colBATCHNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBATCHNO.OptionsFilter.AllowAutoFilter = false;
            this.colBATCHNO.OptionsFilter.AllowFilter = false;
            this.colBATCHNO.Visible = true;
            this.colBATCHNO.Width = 59;
            // 
            // colStock
            // 
            this.colStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colStock.AppearanceCell.Options.UseFont = true;
            this.colStock.AppearanceCell.Options.UseTextOptions = true;
            this.colStock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colStock.AppearanceHeader.Options.UseFont = true;
            this.colStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colStock.Caption = "Stock";
            this.colStock.FieldName = "STOCK";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            this.colStock.OptionsColumn.AllowFocus = false;
            this.colStock.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStock.OptionsFilter.AllowAutoFilter = false;
            this.colStock.OptionsFilter.AllowFilter = false;
            this.colStock.Visible = true;
            this.colStock.Width = 60;
            // 
            // colBONUSQTY
            // 
            this.colBONUSQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colBONUSQTY.AppearanceCell.Options.UseFont = true;
            this.colBONUSQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colBONUSQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBONUSQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colBONUSQTY.AppearanceHeader.Options.UseFont = true;
            this.colBONUSQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colBONUSQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBONUSQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBONUSQTY.Caption = "Bns.";
            this.colBONUSQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBONUSQTY.FieldName = "BONUSQTY";
            this.colBONUSQTY.Name = "colBONUSQTY";
            this.colBONUSQTY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBONUSQTY.OptionsFilter.AllowAutoFilter = false;
            this.colBONUSQTY.OptionsFilter.AllowFilter = false;
            this.colBONUSQTY.Visible = true;
            this.colBONUSQTY.Width = 43;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colINVRATE.AppearanceCell.Options.UseFont = true;
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colINVRATE.AppearanceHeader.Options.UseFont = true;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.Caption = "Price";
            this.colINVRATE.ColumnEdit = this.repositoryItemTextEdit4;
            this.colINVRATE.DisplayFormat.FormatString = "N2";
            this.colINVRATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVRATE.FieldName = "INVRATE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colINVRATE.OptionsFilter.AllowAutoFilter = false;
            this.colINVRATE.OptionsFilter.AllowFilter = false;
            this.colINVRATE.Visible = true;
            this.colINVRATE.Width = 70;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.DisplayFormat.FormatString = "N2";
            this.repositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit4.EditFormat.FormatString = "N2";
            this.repositoryItemTextEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // colDISC
            // 
            this.colDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colDISC.AppearanceCell.Options.UseFont = true;
            this.colDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colDISC.AppearanceHeader.Options.UseFont = true;
            this.colDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.Caption = "Disc.";
            this.colDISC.ColumnEdit = this.repositoryItemTextEdit3;
            this.colDISC.DisplayFormat.FormatString = "##.##";
            this.colDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDISC.FieldName = "DISC";
            this.colDISC.Name = "colDISC";
            this.colDISC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDISC.OptionsFilter.AllowAutoFilter = false;
            this.colDISC.OptionsFilter.AllowFilter = false;
            this.colDISC.Visible = true;
            this.colDISC.Width = 43;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.DisplayFormat.FormatString = "##.##";
            this.repositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit3.EditFormat.FormatString = "##.##";
            this.repositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // colSPDISC
            // 
            this.colSPDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSPDISC.AppearanceCell.Options.UseFont = true;
            this.colSPDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colSPDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSPDISC.AppearanceHeader.Options.UseFont = true;
            this.colSPDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPDISC.Caption = "Disc2";
            this.colSPDISC.ColumnEdit = this.repositoryItemTextEdit3;
            this.colSPDISC.DisplayFormat.FormatString = "N2";
            this.colSPDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPDISC.FieldName = "SPDISC";
            this.colSPDISC.Name = "colSPDISC";
            this.colSPDISC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSPDISC.OptionsFilter.AllowAutoFilter = false;
            this.colSPDISC.OptionsFilter.AllowFilter = false;
            this.colSPDISC.Visible = true;
            this.colSPDISC.Width = 45;
            // 
            // colSPRICE
            // 
            this.colSPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSPRICE.AppearanceCell.Options.UseFont = true;
            this.colSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSPRICE.AppearanceHeader.Options.UseFont = true;
            this.colSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSPRICE.Caption = "S.Price";
            this.colSPRICE.ColumnEdit = this.repositoryItemTextEdit4;
            this.colSPRICE.DisplayFormat.FormatString = "N2";
            this.colSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSPRICE.FieldName = "SPRICE";
            this.colSPRICE.Name = "colSPRICE";
            this.colSPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSPRICE.OptionsFilter.AllowAutoFilter = false;
            this.colSPRICE.OptionsFilter.AllowFilter = false;
            this.colSPRICE.Visible = true;
            this.colSPRICE.Width = 67;
            // 
            // colEXPDATE
            // 
            this.colEXPDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colEXPDATE.AppearanceCell.Options.UseFont = true;
            this.colEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colEXPDATE.AppearanceHeader.Options.UseFont = true;
            this.colEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDATE.Caption = "Exp.Dt.";
            this.colEXPDATE.ColumnEdit = this.repositoryItemTextEdit2;
            this.colEXPDATE.FieldName = "EXPDATE1";
            this.colEXPDATE.Name = "colEXPDATE";
            this.colEXPDATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPDATE.OptionsFilter.AllowAutoFilter = false;
            this.colEXPDATE.OptionsFilter.AllowFilter = false;
            this.colEXPDATE.Visible = true;
            this.colEXPDATE.Width = 71;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTextEdit2.Mask.EditMask = "0#-##";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // colEXPDT
            // 
            this.colEXPDT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colEXPDT.AppearanceCell.Options.UseFont = true;
            this.colEXPDT.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colEXPDT.AppearanceHeader.Options.UseFont = true;
            this.colEXPDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDT.FieldName = "EXPDATE";
            this.colEXPDT.Name = "colEXPDT";
            this.colEXPDT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPDT.OptionsFilter.AllowAutoFilter = false;
            this.colEXPDT.OptionsFilter.AllowFilter = false;
            this.colEXPDT.Width = 78;
            // 
            // colLINETOTAL
            // 
            this.colLINETOTAL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colLINETOTAL.AppearanceCell.Options.UseFont = true;
            this.colLINETOTAL.AppearanceCell.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colLINETOTAL.AppearanceHeader.Options.UseFont = true;
            this.colLINETOTAL.AppearanceHeader.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.Caption = "Total";
            this.colLINETOTAL.DisplayFormat.FormatString = "N2";
            this.colLINETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLINETOTAL.FieldName = "LINETOTAL";
            this.colLINETOTAL.Name = "colLINETOTAL";
            this.colLINETOTAL.OptionsColumn.AllowEdit = false;
            this.colLINETOTAL.OptionsColumn.AllowFocus = false;
            this.colLINETOTAL.OptionsColumn.AllowMove = false;
            this.colLINETOTAL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLINETOTAL.OptionsFilter.AllowAutoFilter = false;
            this.colLINETOTAL.OptionsFilter.AllowFilter = false;
            this.colLINETOTAL.Visible = true;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colITEMNO.AppearanceCell.Options.UseFont = true;
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colITEMNO.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Item name";
            this.colITEMNO.ColumnEdit = this.dropitem;
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.AllowFocus = false;
            this.colITEMNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNO.OptionsFilter.AllowAutoFilter = false;
            this.colITEMNO.OptionsFilter.AllowFilter = false;
            this.colITEMNO.RowIndex = 1;
            this.colITEMNO.Visible = true;
            this.colITEMNO.Width = 386;
            // 
            // dropitem
            // 
            this.dropitem.AutoHeight = false;
            this.dropitem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropitem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BARCODE", "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "ITEMNAME")});
            this.dropitem.DisplayMember = "ITEMNAME";
            this.dropitem.Name = "dropitem";
            this.dropitem.NullText = "";
            this.dropitem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.dropitem.ValueMember = "ITEMNO";
            // 
            // colGROUPID
            // 
            this.colGROUPID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colGROUPID.AppearanceCell.Options.UseFont = true;
            this.colGROUPID.AppearanceCell.Options.UseTextOptions = true;
            this.colGROUPID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colGROUPID.AppearanceHeader.Options.UseFont = true;
            this.colGROUPID.AppearanceHeader.Options.UseTextOptions = true;
            this.colGROUPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGROUPID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPID.Caption = "Category";
            this.colGROUPID.ColumnEdit = this.dropitemgroup;
            this.colGROUPID.FieldName = "GROUPID";
            this.colGROUPID.Name = "colGROUPID";
            this.colGROUPID.OptionsColumn.AllowEdit = false;
            this.colGROUPID.OptionsColumn.AllowFocus = false;
            this.colGROUPID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGROUPID.OptionsFilter.AllowAutoFilter = false;
            this.colGROUPID.OptionsFilter.AllowFilter = false;
            this.colGROUPID.RowIndex = 1;
            this.colGROUPID.Visible = true;
            this.colGROUPID.Width = 159;
            // 
            // dropitemgroup
            // 
            this.dropitemgroup.AutoHeight = false;
            this.dropitemgroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropitemgroup.DisplayMember = "GROUPNAME";
            this.dropitemgroup.Name = "dropitemgroup";
            this.dropitemgroup.NullText = "";
            this.dropitemgroup.ValueMember = "GROUPID";
            // 
            // colCPRICE
            // 
            this.colCPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colCPRICE.AppearanceCell.Options.UseFont = true;
            this.colCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colCPRICE.AppearanceHeader.Options.UseFont = true;
            this.colCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCPRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCPRICE.Caption = "Cost";
            this.colCPRICE.DisplayFormat.FormatString = "N2";
            this.colCPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCPRICE.FieldName = "CPRICE";
            this.colCPRICE.Name = "colCPRICE";
            this.colCPRICE.OptionsColumn.AllowEdit = false;
            this.colCPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCPRICE.OptionsFilter.AllowAutoFilter = false;
            this.colCPRICE.OptionsFilter.AllowFilter = false;
            this.colCPRICE.RowIndex = 1;
            this.colCPRICE.Visible = true;
            this.colCPRICE.Width = 67;
            // 
            // colPROFIT
            // 
            this.colPROFIT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPROFIT.AppearanceCell.Options.UseFont = true;
            this.colPROFIT.AppearanceCell.Options.UseTextOptions = true;
            this.colPROFIT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPROFIT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPROFIT.AppearanceHeader.Options.UseFont = true;
            this.colPROFIT.AppearanceHeader.Options.UseTextOptions = true;
            this.colPROFIT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPROFIT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPROFIT.Caption = "Profit";
            this.colPROFIT.DisplayFormat.FormatString = "n2";
            this.colPROFIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPROFIT.FieldName = "PROFIT";
            this.colPROFIT.Name = "colPROFIT";
            this.colPROFIT.OptionsColumn.AllowEdit = false;
            this.colPROFIT.OptionsColumn.AllowFocus = false;
            this.colPROFIT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPROFIT.OptionsFilter.AllowAutoFilter = false;
            this.colPROFIT.OptionsFilter.AllowFilter = false;
            this.colPROFIT.RowIndex = 1;
            this.colPROFIT.Visible = true;
            this.colPROFIT.Width = 71;
            // 
            // colGROSSVALUE
            // 
            this.colGROSSVALUE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colGROSSVALUE.AppearanceCell.Options.UseFont = true;
            this.colGROSSVALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colGROSSVALUE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROSSVALUE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colGROSSVALUE.AppearanceHeader.Options.UseFont = true;
            this.colGROSSVALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colGROSSVALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGROSSVALUE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROSSVALUE.Caption = "Gross";
            this.colGROSSVALUE.DisplayFormat.FormatString = "N2";
            this.colGROSSVALUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGROSSVALUE.FieldName = "GROSSVALUE";
            this.colGROSSVALUE.Name = "colGROSSVALUE";
            this.colGROSSVALUE.OptionsColumn.AllowFocus = false;
            this.colGROSSVALUE.OptionsColumn.AllowMove = false;
            this.colGROSSVALUE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGROSSVALUE.OptionsFilter.AllowAutoFilter = false;
            this.colGROSSVALUE.OptionsFilter.AllowFilter = false;
            this.colGROSSVALUE.RowIndex = 1;
            this.colGROSSVALUE.Visible = true;
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTID.AppearanceCell.Options.UseFont = true;
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTID.AppearanceHeader.Options.UseFont = true;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTID.OptionsColumn.ReadOnly = true;
            this.colTID.OptionsFilter.AllowAutoFilter = false;
            this.colTID.OptionsFilter.AllowFilter = false;
            this.colTID.RowIndex = 2;
            this.colTID.Width = 93;
            // 
            // colPONO
            // 
            this.colPONO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPONO.AppearanceCell.Options.UseFont = true;
            this.colPONO.AppearanceCell.Options.UseTextOptions = true;
            this.colPONO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPONO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPONO.AppearanceHeader.Options.UseFont = true;
            this.colPONO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPONO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPONO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPONO.FieldName = "PONO";
            this.colPONO.Name = "colPONO";
            this.colPONO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPONO.OptionsFilter.AllowAutoFilter = false;
            this.colPONO.OptionsFilter.AllowFilter = false;
            this.colPONO.RowIndex = 2;
            this.colPONO.Width = 93;
            // 
            // colPURINVID
            // 
            this.colPURINVID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPURINVID.AppearanceCell.Options.UseFont = true;
            this.colPURINVID.AppearanceCell.Options.UseTextOptions = true;
            this.colPURINVID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURINVID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPURINVID.AppearanceHeader.Options.UseFont = true;
            this.colPURINVID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPURINVID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPURINVID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURINVID.FieldName = "PURINVID";
            this.colPURINVID.Name = "colPURINVID";
            this.colPURINVID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPURINVID.OptionsFilter.AllowAutoFilter = false;
            this.colPURINVID.OptionsFilter.AllowFilter = false;
            this.colPURINVID.RowIndex = 2;
            this.colPURINVID.Width = 93;
            // 
            // colEXPR
            // 
            this.colEXPR.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colEXPR.AppearanceCell.Options.UseFont = true;
            this.colEXPR.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPR.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colEXPR.AppearanceHeader.Options.UseFont = true;
            this.colEXPR.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPR.FieldName = "EXPR";
            this.colEXPR.Name = "colEXPR";
            this.colEXPR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEXPR.OptionsFilter.AllowAutoFilter = false;
            this.colEXPR.OptionsFilter.AllowFilter = false;
            this.colEXPR.RowIndex = 2;
            this.colEXPR.Width = 93;
            // 
            // colTOSTORE
            // 
            this.colTOSTORE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTOSTORE.AppearanceCell.Options.UseFont = true;
            this.colTOSTORE.AppearanceCell.Options.UseTextOptions = true;
            this.colTOSTORE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOSTORE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTOSTORE.AppearanceHeader.Options.UseFont = true;
            this.colTOSTORE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOSTORE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOSTORE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOSTORE.FieldName = "TOSTORE";
            this.colTOSTORE.Name = "colTOSTORE";
            this.colTOSTORE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTOSTORE.OptionsFilter.AllowAutoFilter = false;
            this.colTOSTORE.OptionsFilter.AllowFilter = false;
            this.colTOSTORE.RowIndex = 2;
            this.colTOSTORE.Width = 70;
            // 
            // colINVDISC
            // 
            this.colINVDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colINVDISC.AppearanceCell.Options.UseFont = true;
            this.colINVDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colINVDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colINVDISC.AppearanceHeader.Options.UseFont = true;
            this.colINVDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVDISC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVDISC.FieldName = "INVDISC";
            this.colINVDISC.Name = "colINVDISC";
            this.colINVDISC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colINVDISC.OptionsFilter.AllowAutoFilter = false;
            this.colINVDISC.OptionsFilter.AllowFilter = false;
            this.colINVDISC.RowIndex = 2;
            this.colINVDISC.Width = 93;
            // 
            // dropitem1
            // 
            this.dropitem1.AutoHeight = false;
            this.dropitem1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropitem1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNO", "ITEMNO"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "ITEMNAME")});
            this.dropitem1.DisplayMember = "ITEMNAME";
            this.dropitem1.Name = "dropitem1";
            this.dropitem1.NullText = "";
            this.dropitem1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.dropitem1.ValueMember = "ITEMNO";
            // 
            // BasePurInvoice
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Controls.Add(this.panelautosales);
            this.Controls.Add(this.panelunit);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BasePurInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasePurInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BasePurInvoiceLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BasePurInvoiceKeyDown);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.panelunit, 0);
            this.Controls.SetChildIndex(this.panelautosales, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookuppo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookuptoStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurno.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.totdisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totvalue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totnetamt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totspecdisc.Properties)).EndInit();
            this.paneltotcost.ResumeLayout(false);
            this.paneltotcost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totprofit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totsalevalue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totcostvalue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURINVDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNDETAILBindingSource)).EndInit();
            this.panelunit.ResumeLayout(false);
            this.panelunit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotunitvalue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotunits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunitqty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupunits.Properties)).EndInit();
            this.panelautosales.ResumeLayout(false);
            this.panelautosales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitemgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        protected TextEdit spdisc;
        private Label label16;
        protected TextEdit txtpurno;
        private Panel panel2;
        protected LookUpEdit LookuptoStore;
        private Panel panel3;
        private StandaloneBarDockControl standaloneBarDockControl1;
        protected BarManager barManager1;
        private Bar bar1;
        protected BarEditItem barEditItem2;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem FindItem;
        private BarButtonItem CopyRow;
        private BarButtonItem DeleteLine;
        private BarButtonItem ItemHistory;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem7;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit2;
        private BarButtonItem Autosalesbutton;
        protected LookUpEdit LookupSupplier;
        protected TextEdit duedays;
        protected DateEdit invdate;
        protected TextEdit invno;
        protected TextEdit adjustval;
        private Label label18;
        private Label label5;
        private Label label19;
        private TextEdit txttotunitvalue;
        private Label label22;
        private TextEdit txttotunits;
        private Label label21;
        private TextEdit txtunitqty;
        private Label label20;
        protected LookUpEdit lookupunits;
        protected Panel panelunit;
        protected BarCheckItem Unitconversionbutton;
        private Panel panelautosales;
        private Label label24;
        private Label label23;
        private Label label25;
        private RadioGroup radioGroup1;
        private SpinEdit spinEdit1;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton2;
        protected Panel panel4;
        protected TextEdit totdisc;
        protected TextEdit totvalue;
        protected TextEdit totnetamt;
        protected TextEdit totspecdisc;
        protected BindingSource bindingSource1;
        protected DXErrorProvider dxErrorProvider1;
        protected Panel paneltotcost;
        private Label label2;
        protected DsInventory dsInventory1;
        protected BindingSource pURINVDETAILBindingSource;
        protected BindingSource rETURNDETAILBindingSource;
        protected GridControl gridControl1;
        protected RepositoryItemLookUpEdit dropitem;
        protected RepositoryItemLookUpEdit dropitem1;
        protected RepositoryItemLookUpEdit dropitemgroup;
        protected DsPurchase dsPurchase1;
        private RepositoryItemTextEdit repositoryItemTextEdit2;
        private RepositoryItemTextEdit repositoryItemTextEdit3;
        private RepositoryItemTextEdit repositoryItemTextEdit4;
        private GridBand gridBand1;
        private BandedGridColumn colBARCODE;
        private BandedGridColumn colStock;
        private BandedGridColumn colQTY;
        private BandedGridColumn colBONUSQTY;
        private BandedGridColumn colINVRATE;
        private BandedGridColumn colDISC;
        private BandedGridColumn colSPDISC;
        private BandedGridColumn colSPRICE;
        private BandedGridColumn colEXPDATE;
        private BandedGridColumn colEXPDT;
        private BandedGridColumn colLINETOTAL;
        private BandedGridColumn colITEMNO;
        private BandedGridColumn colGROUPID;
        private BandedGridColumn colCPRICE;
        private BandedGridColumn colPROFIT;
        private BandedGridColumn colGROSSVALUE;
        private BandedGridColumn colTID;
        private BandedGridColumn colPONO;
        private BandedGridColumn colPURINVID;
        private BandedGridColumn colEXPR;
        private BandedGridColumn colTOSTORE;
        private BandedGridColumn colINVDISC;
        protected AdvBandedGridView advBandedGridView1;
        protected BandedGridColumn colBATCHNO;
        protected SimpleButton simpleButton1;
        protected LookUpEdit lookuppo;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BarButtonItem bargift;
        protected LookUpEdit Lookupwarehouse;
        protected TextEdit totprofit;
        protected TextEdit totsalevalue;
        protected TextEdit totcostvalue;

    }
}