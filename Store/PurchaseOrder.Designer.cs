using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class PurchaseOrder
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label cOMPNAMELabel;
            System.Windows.Forms.Label label1;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblreceived = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtextradisc = new DevExpress.XtraEditors.TextEdit();
            this.txtnetamt = new DevExpress.XtraEditors.TextEdit();
            this.supnote = new DevExpress.XtraEditors.MemoEdit();
            this.pODETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPurchase1 = new VIRETAILENTITIES.DsPurchase();
            this.dsInventory1 = new VIRETAILENTITIES.DsInventory();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.label6 = new System.Windows.Forms.Label();
            this.deladd = new DevExpress.XtraEditors.MemoEdit();
            this.supadd = new DevExpress.XtraEditors.MemoEdit();
            this.invdate = new DevExpress.XtraEditors.DateEdit();
            this.LookupSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpurno = new DevExpress.XtraEditors.TextEdit();
            this.Lookupwarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.FindItem = new DevExpress.XtraBars.BarButtonItem();
            this.ItemHistory = new DevExpress.XtraBars.BarButtonItem();
            this.CopyRow = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteLine = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemPopupContainerEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPONO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colBARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGROUPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBONUSQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLINETOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cOMPNAMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtextradisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnetamt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supnote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deladd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supadd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(811, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(7, 6);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 14);
            label5.TabIndex = 87;
            label5.Text = "Note :";
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(34, 9);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(90, 14);
            label8.TabIndex = 96;
            label8.Text = "Extra Discount:";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(34, 31);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 14);
            label7.TabIndex = 95;
            label7.Text = "Net Amount:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(426, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 14);
            label3.TabIndex = 87;
            label3.Text = "Delivery  Address:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(7, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 14);
            label2.TabIndex = 86;
            label2.Text = "Suppler Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(426, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 14);
            label4.TabIndex = 85;
            label4.Text = "Date: ";
            // 
            // cOMPNAMELabel
            // 
            cOMPNAMELabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cOMPNAMELabel.AutoSize = true;
            cOMPNAMELabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOMPNAMELabel.Location = new System.Drawing.Point(7, 8);
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
            label1.Location = new System.Drawing.Point(645, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 14);
            label1.TabIndex = 24;
            label1.Text = "Doc #:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblreceived);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.supnote);
            this.panel3.Controls.Add(label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 54);
            this.panel3.TabIndex = 7;
            // 
            // lblreceived
            // 
            this.lblreceived.BackColor = System.Drawing.Color.Transparent;
            this.lblreceived.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceived.Image = global::Store.Properties.Resources.delivered;
            this.lblreceived.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblreceived.Location = new System.Drawing.Point(327, 6);
            this.lblreceived.Name = "lblreceived";
            this.lblreceived.Size = new System.Drawing.Size(221, 42);
            this.lblreceived.TabIndex = 97;
            this.lblreceived.Text = "RECEIVED";
            this.lblreceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblreceived.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtextradisc);
            this.panel4.Controls.Add(this.txtnetamt);
            this.panel4.Controls.Add(label8);
            this.panel4.Controls.Add(label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(570, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 54);
            this.panel4.TabIndex = 95;
            // 
            // txtextradisc
            // 
            this.txtextradisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtextradisc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtextradisc.EnterMoveNextControl = true;
            this.txtextradisc.Location = new System.Drawing.Point(130, 3);
            this.txtextradisc.Name = "txtextradisc";
            this.txtextradisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtextradisc.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtextradisc.Properties.Appearance.Options.UseFont = true;
            this.txtextradisc.Properties.Appearance.Options.UseForeColor = true;
            this.txtextradisc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtextradisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtextradisc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtextradisc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtextradisc.Properties.NullText = "0";
            this.txtextradisc.Size = new System.Drawing.Size(103, 20);
            this.txtextradisc.TabIndex = 6;
            this.txtextradisc.EditValueChanged += new System.EventHandler(this.TxtextradiscEditValueChanged);
            this.txtextradisc.Enter += new System.EventHandler(this.TxtextradiscEnter);
            // 
            // txtnetamt
            // 
            this.txtnetamt.Location = new System.Drawing.Point(130, 26);
            this.txtnetamt.MenuManager = this.ribbon;
            this.txtnetamt.Name = "txtnetamt";
            this.txtnetamt.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtnetamt.Properties.Appearance.Options.UseForeColor = true;
            this.txtnetamt.Properties.Appearance.Options.UseTextOptions = true;
            this.txtnetamt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtnetamt.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtnetamt.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.txtnetamt.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtnetamt.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtnetamt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.txtnetamt.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White;
            this.txtnetamt.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtnetamt.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtnetamt.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtnetamt.Properties.DisplayFormat.FormatString = "N2";
            this.txtnetamt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnetamt.Properties.ReadOnly = true;
            this.txtnetamt.Size = new System.Drawing.Size(103, 20);
            this.txtnetamt.TabIndex = 98;
            this.txtnetamt.TabStop = false;
            // 
            // supnote
            // 
            this.supnote.Location = new System.Drawing.Point(53, 5);
            this.supnote.MenuManager = this.ribbon;
            this.supnote.Name = "supnote";
            this.supnote.Properties.MaxLength = 1500;
            this.supnote.Size = new System.Drawing.Size(268, 41);
            this.supnote.TabIndex = 7;
            // 
            // pODETAILBindingSource
            // 
            this.pODETAILBindingSource.DataMember = "PODETAIL";
            this.pODETAILBindingSource.DataSource = this.dsPurchase1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.deladd);
            this.panel1.Controls.Add(this.supadd);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.invdate);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(cOMPNAMELabel);
            this.panel1.Controls.Add(this.LookupSupplier);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtpurno);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.Lookupwarehouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 128);
            this.panel1.TabIndex = 13;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpEdit1.EnterMoveNextControl = true;
            this.lookUpEdit1.Location = new System.Drawing.Point(108, 72);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject2.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, true, false, false, DevExpress.XtraEditors.ImageLocation.Default, ((System.Drawing.Image)(resources.GetObject("lookUpEdit1.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYTYPE", "PAYTYPE", 51, DevExpress.Utils.FormatType.Custom, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PAYNAME", "PAYNAME", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DisplayMember = "PAYNAME";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ShowFooter = false;
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "PAYTYPE";
            this.lookUpEdit1.Size = new System.Drawing.Size(295, 20);
            this.lookUpEdit1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.standaloneBarDockControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 32);
            this.panel2.TabIndex = 93;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(811, 32);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 91;
            this.label6.Text = "Payment Type:";
            // 
            // deladd
            // 
            this.deladd.Location = new System.Drawing.Point(536, 30);
            this.deladd.MenuManager = this.ribbon;
            this.deladd.Name = "deladd";
            this.deladd.Properties.MaxLength = 1500;
            this.deladd.Size = new System.Drawing.Size(268, 36);
            this.deladd.TabIndex = 3;
            // 
            // supadd
            // 
            this.supadd.Location = new System.Drawing.Point(108, 30);
            this.supadd.MenuManager = this.ribbon;
            this.supadd.Name = "supadd";
            this.supadd.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.supadd.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.supadd.Properties.Appearance.Options.UseBackColor = true;
            this.supadd.Properties.Appearance.Options.UseForeColor = true;
            this.supadd.Properties.MaxLength = 1500;
            this.supadd.Size = new System.Drawing.Size(295, 36);
            this.supadd.TabIndex = 1;
            // 
            // invdate
            // 
            this.invdate.EditValue = new System.DateTime(2012, 7, 17, 0, 0, 0, 0);
            this.invdate.EnterMoveNextControl = true;
            this.invdate.Location = new System.Drawing.Point(536, 6);
            this.invdate.Name = "invdate";
            this.invdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invdate.Properties.Appearance.Options.UseFont = true;
            this.invdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.invdate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.invdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.invdate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.invdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.invdate.Size = new System.Drawing.Size(104, 20);
            this.invdate.TabIndex = 84;
            // 
            // LookupSupplier
            // 
            this.LookupSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookupSupplier.EnterMoveNextControl = true;
            this.LookupSupplier.Location = new System.Drawing.Point(108, 6);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUEDAYS", "DUEDAYS", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADDRESS", "ADDRESS", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.LookupSupplier.Properties.DisplayMember = "SUPPLIERNAME";
            this.LookupSupplier.Properties.NullText = "";
            this.LookupSupplier.Properties.ShowHeader = false;
            this.LookupSupplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupSupplier.Properties.ValueMember = "SUPPLIERNO";
            this.LookupSupplier.Size = new System.Drawing.Size(295, 20);
            this.LookupSupplier.TabIndex = 0;
            this.LookupSupplier.EditValueChanged += new System.EventHandler(this.SupplierEditValueChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(426, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 14);
            this.label16.TabIndex = 75;
            this.label16.Text = "Warehouse:";
            // 
            // txtpurno
            // 
            this.txtpurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpurno.Location = new System.Drawing.Point(696, 5);
            this.txtpurno.Name = "txtpurno";
            this.txtpurno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurno.Properties.Appearance.Options.UseFont = true;
            this.txtpurno.Properties.Appearance.Options.UseTextOptions = true;
            this.txtpurno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtpurno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtpurno.Properties.ReadOnly = true;
            this.txtpurno.Size = new System.Drawing.Size(107, 20);
            this.txtpurno.TabIndex = 25;
            this.txtpurno.TabStop = false;
            // 
            // Lookupwarehouse
            // 
            this.Lookupwarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lookupwarehouse.EnterMoveNextControl = true;
            this.Lookupwarehouse.Location = new System.Drawing.Point(535, 72);
            this.Lookupwarehouse.Name = "Lookupwarehouse";
            this.Lookupwarehouse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lookupwarehouse.Properties.Appearance.Options.UseFont = true;
            serializableAppearanceObject4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject4.Options.UseFont = true;
            this.Lookupwarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, true, false, false, DevExpress.XtraEditors.ImageLocation.Default, ((System.Drawing.Image)(resources.GetObject("Lookupwarehouse.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.Lookupwarehouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "STORECODE", 51, DevExpress.Utils.FormatType.Custom, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Lookupwarehouse.Properties.DisplayMember = "STORENAME";
            this.Lookupwarehouse.Properties.NullText = "";
            this.Lookupwarehouse.Properties.ShowFooter = false;
            this.Lookupwarehouse.Properties.ShowHeader = false;
            this.Lookupwarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Lookupwarehouse.Properties.ValueMember = "STORECODE";
            this.Lookupwarehouse.Size = new System.Drawing.Size(268, 20);
            this.Lookupwarehouse.TabIndex = 4;
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
            this.barEditItem2});
            this.barManager1.MaxItemId = 13;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemPopupContainerEdit2});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.DeleteLine, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "Barcode / Name";
            this.repositoryItemTextEdit1.NullValuePrompt = "Barcode / Name";
            this.repositoryItemTextEdit1.NullValuePromptShowForEmptyValue = true;
            // 
            // FindItem
            // 
            this.FindItem.Caption = "Find Item - F10";
            this.FindItem.Glyph = global::Store.Properties.Resources.page_white_magnify;
            this.FindItem.Id = 0;
            this.FindItem.Name = "FindItem";
            this.FindItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FindItemItemClick);
            // 
            // ItemHistory
            // 
            this.ItemHistory.Caption = "Item Histroy - F8";
            this.ItemHistory.Glyph = global::Store.Properties.Resources.date_magnify;
            this.ItemHistory.Id = 3;
            this.ItemHistory.Name = "ItemHistory";
            // 
            // CopyRow
            // 
            this.CopyRow.Caption = "Copy Row - F5";
            this.CopyRow.Glyph = global::Store.Properties.Resources.page_copy;
            this.CopyRow.Id = 1;
            this.CopyRow.Name = "CopyRow";
            this.CopyRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CopyRowItemClick);
            // 
            // DeleteLine
            // 
            this.DeleteLine.Caption = "Delete Line - F4";
            this.DeleteLine.Glyph = global::Store.Properties.Resources.remove;
            this.DeleteLine.Id = 2;
            this.DeleteLine.Name = "DeleteLine";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(811, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 571);
            this.barDockControlBottom.Size = new System.Drawing.Size(811, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(811, 0);
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pODETAILBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 273);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(811, 212);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControl1KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colPONO,
            this.colITEMNO,
            this.colBARCODE,
            this.colGROUPID,
            this.colQTY,
            this.colBONUSQTY,
            this.colINVRATE,
            this.colDISC,
            this.colLINETOTAL,
            this.colRECQTY});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 25;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.CustomDrawRowIndicator);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridView1CellValueChanged);
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceCell.Options.UseFont = true;
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceHeader.Options.UseFont = true;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.ReadOnly = true;
            // 
            // colPONO
            // 
            this.colPONO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPONO.AppearanceCell.Options.UseFont = true;
            this.colPONO.AppearanceCell.Options.UseTextOptions = true;
            this.colPONO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPONO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPONO.AppearanceHeader.Options.UseFont = true;
            this.colPONO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPONO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPONO.FieldName = "PONO";
            this.colPONO.Name = "colPONO";
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceCell.Options.UseFont = true;
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.Caption = "Item name";
            this.colITEMNO.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.AllowFocus = false;
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 0;
            this.colITEMNO.Width = 426;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNO", "ITEMNO"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEMNAME", "ITEMNO")});
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceCell.Options.UseFont = true;
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBARCODE.AppearanceHeader.Options.UseFont = true;
            this.colBARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBARCODE.Caption = "Barcode";
            this.colBARCODE.FieldName = "BARCODE";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.AllowFocus = false;
            this.colBARCODE.Visible = true;
            this.colBARCODE.VisibleIndex = 1;
            this.colBARCODE.Width = 99;
            // 
            // colGROUPID
            // 
            this.colGROUPID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGROUPID.AppearanceCell.Options.UseFont = true;
            this.colGROUPID.AppearanceCell.Options.UseTextOptions = true;
            this.colGROUPID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGROUPID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGROUPID.AppearanceHeader.Options.UseFont = true;
            this.colGROUPID.AppearanceHeader.Options.UseTextOptions = true;
            this.colGROUPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGROUPID.FieldName = "GROUPID";
            this.colGROUPID.Name = "colGROUPID";
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceCell.Options.UseFont = true;
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.Caption = "Qty";
            this.colQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 2;
            this.colQTY.Width = 43;
            // 
            // colBONUSQTY
            // 
            this.colBONUSQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBONUSQTY.AppearanceCell.Options.UseFont = true;
            this.colBONUSQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colBONUSQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBONUSQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBONUSQTY.AppearanceHeader.Options.UseFont = true;
            this.colBONUSQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colBONUSQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBONUSQTY.Caption = "Bonus";
            this.colBONUSQTY.FieldName = "BONUSQTY";
            this.colBONUSQTY.Name = "colBONUSQTY";
            this.colBONUSQTY.Visible = true;
            this.colBONUSQTY.VisibleIndex = 3;
            this.colBONUSQTY.Width = 43;
            // 
            // colINVRATE
            // 
            this.colINVRATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceCell.Options.UseFont = true;
            this.colINVRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINVRATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINVRATE.AppearanceHeader.Options.UseFont = true;
            this.colINVRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colINVRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINVRATE.Caption = "Price";
            this.colINVRATE.DisplayFormat.FormatString = "N2";
            this.colINVRATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINVRATE.FieldName = "INVRATE";
            this.colINVRATE.Name = "colINVRATE";
            this.colINVRATE.Visible = true;
            this.colINVRATE.VisibleIndex = 4;
            this.colINVRATE.Width = 46;
            // 
            // colDISC
            // 
            this.colDISC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceCell.Options.UseFont = true;
            this.colDISC.AppearanceCell.Options.UseTextOptions = true;
            this.colDISC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDISC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDISC.AppearanceHeader.Options.UseFont = true;
            this.colDISC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDISC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDISC.Caption = "Disc %";
            this.colDISC.DisplayFormat.FormatString = "N2";
            this.colDISC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDISC.FieldName = "DISC";
            this.colDISC.Name = "colDISC";
            this.colDISC.Visible = true;
            this.colDISC.VisibleIndex = 5;
            this.colDISC.Width = 50;
            // 
            // colLINETOTAL
            // 
            this.colLINETOTAL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLINETOTAL.AppearanceCell.Options.UseFont = true;
            this.colLINETOTAL.AppearanceCell.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLINETOTAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLINETOTAL.AppearanceHeader.Options.UseFont = true;
            this.colLINETOTAL.AppearanceHeader.Options.UseTextOptions = true;
            this.colLINETOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINETOTAL.Caption = "Total";
            this.colLINETOTAL.DisplayFormat.FormatString = "N2";
            this.colLINETOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLINETOTAL.FieldName = "LINETOTAL";
            this.colLINETOTAL.Name = "colLINETOTAL";
            this.colLINETOTAL.OptionsColumn.AllowEdit = false;
            this.colLINETOTAL.Visible = true;
            this.colLINETOTAL.VisibleIndex = 6;
            this.colLINETOTAL.Width = 77;
            // 
            // colRECQTY
            // 
            this.colRECQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRECQTY.AppearanceCell.Options.UseFont = true;
            this.colRECQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colRECQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRECQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRECQTY.AppearanceHeader.Options.UseFont = true;
            this.colRECQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRECQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRECQTY.Caption = "Rec.Qty";
            this.colRECQTY.FieldName = "RECQTY";
            this.colRECQTY.Name = "colRECQTY";
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 571);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.PurchaseOrderLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchaseOrderKeyDown);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtextradisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnetamt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supnote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deladd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supadd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel3;
        private BindingSource pODETAILBindingSource;
        private MemoEdit supnote;
        private DsInventory dsInventory1;
        private Panel panel4;
        private TextEdit txtnetamt;
        private Panel panel1;
        private Label label6;
        private MemoEdit deladd;
        private MemoEdit supadd;
        protected DateEdit invdate;
        protected LookUpEdit LookupSupplier;
        private Label label16;
        protected TextEdit txtpurno;
        protected LookUpEdit Lookupwarehouse;
        private Panel panel2;
        private StandaloneBarDockControl standaloneBarDockControl1;
        protected BarManager barManager1;
        private Bar bar1;
        protected BarEditItem barEditItem2;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem FindItem;
        private BarButtonItem ItemHistory;
        private BarButtonItem CopyRow;
        private BarButtonItem DeleteLine;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private GridControl gridControl1;
        private GridView gridView1;
        private BarButtonItem barButtonItem7;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private Label lblreceived;
        private GridColumn colTID;
        private GridColumn colPONO;
        private GridColumn colITEMNO;
        private GridColumn colBARCODE;
        private GridColumn colGROUPID;
        private GridColumn colQTY;
        private GridColumn colBONUSQTY;
        private GridColumn colINVRATE;
        private GridColumn colDISC;
        private GridColumn colLINETOTAL;
        private GridColumn colRECQTY;
        protected LookUpEdit lookUpEdit1;
        protected TextEdit txtextradisc;
        private DsPurchase dsPurchase1;
    }
}