using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace Store
{
    partial class FrmInventoryNotMatching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryNotMatching));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.inventoryVariationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPENING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPURCHASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRETURN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECEIVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANSFER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTUAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSTOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladjqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryVariationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.progressPanel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 48);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(851, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 28);
            this.button8.TabIndex = 8;
            this.button8.Text = "Get Stk";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(658, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "Show Multiple diff";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(763, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "Fix Multiple";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(411, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "Validate for muliple lines";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Fix Stock";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Stock diff";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(12, 6);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(143, 39);
            this.progressPanel1.TabIndex = 1;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.inventoryVariationBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(984, 415);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // inventoryVariationBindingSource
            // 
            this.inventoryVariationBindingSource.DataMember = "InventoryVariation";
            this.inventoryVariationBindingSource.DataSource = typeof(VIRETAILENTITIES.Ledgers);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoid,
            this.colITEMNO,
            this.colITEMNAME,
            this.colOPENING,
            this.colPURCHASE,
            this.colRETURN,
            this.colRECEIVE,
            this.colSALES,
            this.colTRANSFER,
            this.colACTUAL,
            this.colINSTOCK,
            this.gridColumn1,
            this.gridColumn2,
            this.coladjqty});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoid
            // 
            this.colAutoid.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAutoid.AppearanceCell.Options.UseFont = true;
            this.colAutoid.AppearanceCell.Options.UseTextOptions = true;
            this.colAutoid.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAutoid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAutoid.AppearanceHeader.Options.UseFont = true;
            this.colAutoid.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoid.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAutoid.FieldName = "Autoid";
            this.colAutoid.Name = "colAutoid";
            this.colAutoid.Visible = true;
            this.colAutoid.VisibleIndex = 0;
            this.colAutoid.Width = 37;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceCell.Options.UseFont = true;
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 1;
            this.colITEMNO.Width = 111;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNAME.AppearanceCell.Options.UseFont = true;
            this.colITEMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNAME.AppearanceHeader.Options.UseFont = true;
            this.colITEMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.FieldName = "ITEMNAME";
            this.colITEMNAME.Name = "colITEMNAME";
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 2;
            this.colITEMNAME.Width = 270;
            // 
            // colOPENING
            // 
            this.colOPENING.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colOPENING.AppearanceCell.Options.UseFont = true;
            this.colOPENING.AppearanceCell.Options.UseTextOptions = true;
            this.colOPENING.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOPENING.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colOPENING.AppearanceHeader.Options.UseFont = true;
            this.colOPENING.AppearanceHeader.Options.UseTextOptions = true;
            this.colOPENING.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOPENING.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colOPENING.FieldName = "OPENING";
            this.colOPENING.Name = "colOPENING";
            this.colOPENING.Visible = true;
            this.colOPENING.VisibleIndex = 3;
            this.colOPENING.Width = 52;
            // 
            // colPURCHASE
            // 
            this.colPURCHASE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPURCHASE.AppearanceCell.Options.UseFont = true;
            this.colPURCHASE.AppearanceCell.Options.UseTextOptions = true;
            this.colPURCHASE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURCHASE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPURCHASE.AppearanceHeader.Options.UseFont = true;
            this.colPURCHASE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPURCHASE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPURCHASE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURCHASE.FieldName = "PURCHASE";
            this.colPURCHASE.Name = "colPURCHASE";
            this.colPURCHASE.Visible = true;
            this.colPURCHASE.VisibleIndex = 5;
            this.colPURCHASE.Width = 56;
            // 
            // colRETURN
            // 
            this.colRETURN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRETURN.AppearanceCell.Options.UseFont = true;
            this.colRETURN.AppearanceCell.Options.UseTextOptions = true;
            this.colRETURN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRETURN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRETURN.AppearanceHeader.Options.UseFont = true;
            this.colRETURN.AppearanceHeader.Options.UseTextOptions = true;
            this.colRETURN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRETURN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRETURN.FieldName = "RETURN";
            this.colRETURN.Name = "colRETURN";
            this.colRETURN.Visible = true;
            this.colRETURN.VisibleIndex = 6;
            this.colRETURN.Width = 46;
            // 
            // colRECEIVE
            // 
            this.colRECEIVE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRECEIVE.AppearanceCell.Options.UseFont = true;
            this.colRECEIVE.AppearanceCell.Options.UseTextOptions = true;
            this.colRECEIVE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRECEIVE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRECEIVE.AppearanceHeader.Options.UseFont = true;
            this.colRECEIVE.AppearanceHeader.Options.UseTextOptions = true;
            this.colRECEIVE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRECEIVE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRECEIVE.FieldName = "RECEIVE";
            this.colRECEIVE.Name = "colRECEIVE";
            this.colRECEIVE.Visible = true;
            this.colRECEIVE.VisibleIndex = 7;
            this.colRECEIVE.Width = 47;
            // 
            // colSALES
            // 
            this.colSALES.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSALES.AppearanceCell.Options.UseFont = true;
            this.colSALES.AppearanceCell.Options.UseTextOptions = true;
            this.colSALES.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSALES.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSALES.AppearanceHeader.Options.UseFont = true;
            this.colSALES.AppearanceHeader.Options.UseTextOptions = true;
            this.colSALES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSALES.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSALES.FieldName = "SALES";
            this.colSALES.Name = "colSALES";
            this.colSALES.Visible = true;
            this.colSALES.VisibleIndex = 8;
            this.colSALES.Width = 37;
            // 
            // colTRANSFER
            // 
            this.colTRANSFER.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANSFER.AppearanceCell.Options.UseFont = true;
            this.colTRANSFER.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANSFER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANSFER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRANSFER.AppearanceHeader.Options.UseFont = true;
            this.colTRANSFER.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANSFER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANSFER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANSFER.FieldName = "TRANSFER";
            this.colTRANSFER.Name = "colTRANSFER";
            this.colTRANSFER.Visible = true;
            this.colTRANSFER.VisibleIndex = 9;
            this.colTRANSFER.Width = 56;
            // 
            // colACTUAL
            // 
            this.colACTUAL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colACTUAL.AppearanceCell.Options.UseFont = true;
            this.colACTUAL.AppearanceCell.Options.UseTextOptions = true;
            this.colACTUAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colACTUAL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colACTUAL.AppearanceHeader.Options.UseFont = true;
            this.colACTUAL.AppearanceHeader.Options.UseTextOptions = true;
            this.colACTUAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colACTUAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colACTUAL.FieldName = "ACTUAL";
            this.colACTUAL.Name = "colACTUAL";
            this.colACTUAL.Visible = true;
            this.colACTUAL.VisibleIndex = 10;
            this.colACTUAL.Width = 44;
            // 
            // colINSTOCK
            // 
            this.colINSTOCK.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINSTOCK.AppearanceCell.Options.UseFont = true;
            this.colINSTOCK.AppearanceCell.Options.UseTextOptions = true;
            this.colINSTOCK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINSTOCK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINSTOCK.AppearanceHeader.Options.UseFont = true;
            this.colINSTOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.colINSTOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINSTOCK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINSTOCK.FieldName = "INSTOCK";
            this.colINSTOCK.Name = "colINSTOCK";
            this.colINSTOCK.Visible = true;
            this.colINSTOCK.VisibleIndex = 11;
            this.colINSTOCK.Width = 53;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Muti";
            this.gridColumn1.FieldName = "MULTILINE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 12;
            this.gridColumn1.Width = 34;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Stockid";
            this.gridColumn2.FieldName = "STOCKID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 13;
            this.gridColumn2.Width = 79;
            // 
            // coladjqty
            // 
            this.coladjqty.Caption = "Adj Qty";
            this.coladjqty.FieldName = "ADJQTY";
            this.coladjqty.Name = "coladjqty";
            this.coladjqty.Visible = true;
            this.coladjqty.VisibleIndex = 4;
            this.coladjqty.Width = 44;
            // 
            // FrmInventoryNotMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 463);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventoryNotMatching";
            this.Text = "Inventory Not Matching";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryVariationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ProgressPanel progressPanel1;
        private Button button1;
        private Button button2;
        private GridControl gridControl1;
        private BindingSource inventoryVariationBindingSource;
        private GridView gridView1;
        private GridColumn colAutoid;
        private GridColumn colITEMNO;
        private GridColumn colITEMNAME;
        private GridColumn colOPENING;
        private GridColumn colPURCHASE;
        private GridColumn colRETURN;
        private GridColumn colRECEIVE;
        private GridColumn colSALES;
        private GridColumn colTRANSFER;
        private GridColumn colACTUAL;
        private GridColumn colINSTOCK;
        private Button button3;
        private Button button4;
        private GridColumn gridColumn1;
        private Button button5;
        private GridColumn gridColumn2;
        private Button button6;
        private Button button7;
        private Button button8;
        private GridColumn coladjqty;
    }
}