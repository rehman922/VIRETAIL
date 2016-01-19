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
    partial class Drugdispatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drugdispatch));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.MovePrev = new DevExpress.XtraBars.BarButtonItem();
            this.MoveNext = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lookupcashier = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbarcode = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.hospname = new DevExpress.XtraEditors.TextEdit();
            this.patname = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvocherno = new DevExpress.XtraEditors.TextEdit();
            this.voudate = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dDDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOSAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dOSAGESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPRECA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvocherno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voudate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voudate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSAGESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.MovePrev,
            this.MoveNext,
            this.barButtonItem6,
            this.barCheckItem1,
            this.barCheckItem2,
            this.barButtonItem7,
            this.lookupcashier,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barEditItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 17;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemComboBox1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.MovePrev, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.MoveNext, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem7, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "New";
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.page_white_star16;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Save";
            this.barButtonItem2.Glyph = global::Store.Properties.Resources.Save16;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Print";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.printer1;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // MovePrev
            // 
            this.MovePrev.Caption = "Move Prev";
            this.MovePrev.Glyph = global::Store.Properties.Resources.resultset_previous16;
            this.MovePrev.Id = 3;
            this.MovePrev.Name = "MovePrev";
            this.MovePrev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MovePrev_ItemClick);
            // 
            // MoveNext
            // 
            this.MoveNext.Caption = "Move Next";
            this.MoveNext.Glyph = global::Store.Properties.Resources.resultset_next16;
            this.MoveNext.Id = 4;
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MoveNext_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Setup";
            this.barButtonItem7.Glyph = global::Store.Properties.Resources.run;
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.lookupcashier),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Keyboard";
            this.barButtonItem6.Glyph = global::Store.Properties.Resources.keyboard;
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "English";
            this.barCheckItem1.Id = 8;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "Arabic";
            this.barCheckItem2.Id = 9;
            this.barCheckItem2.Name = "barCheckItem2";
            this.barCheckItem2.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem2_CheckedChanged);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Doctor :";
            this.barStaticItem1.Id = 12;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lookupcashier
            // 
            this.lookupcashier.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lookupcashier.Caption = "barEditItem1";
            this.lookupcashier.Edit = this.repositoryItemLookUpEdit2;
            this.lookupcashier.Id = 11;
            this.lookupcashier.Name = "lookupcashier";
            this.lookupcashier.Width = 150;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERID", "USERID", 60, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERNAME", "USERNAME", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNO", "EMPNO", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PASSWORD", "PASSWORD", 67, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACTIVE", "ACTIVE", 46, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LASTLOGIN", "LASTLOGIN", 65, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LASTLOGOUT", "LASTLOGOUT", 75, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CREATEDBY", "CREATEDBY", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PROFILEID", "PROFILEID", 63, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERTYPE", "USERTYPE", 60, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CDATE", "CDATE", 43, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EDITEDBY", "EDITEDBY", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EDATE", "EDATE", 42, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.uSERINFOBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "USERNAME";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "USERID";
            // 
            // uSERINFOBindingSource
            // 
            this.uSERINFOBindingSource.DataMember = "USERINFO";
            this.uSERINFOBindingSource.DataSource = typeof(VIRETAILENTITIES.DsMaster);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Printers";
            this.barStaticItem2.Id = 13;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemComboBox1;
            this.barEditItem2.Id = 15;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 180;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(800, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 387);
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 363);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 363);
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxEdit1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtbarcode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.hospname);
            this.panel1.Controls.Add(this.patname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtvocherno);
            this.panel1.Controls.Add(this.voudate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 91);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(518, 60);
            this.comboBoxEdit1.MenuManager = this.barManager1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(111, 20);
            this.comboBoxEdit1.TabIndex = 3;
            this.comboBoxEdit1.EditValueChanged += new System.EventHandler(this.comboBoxEdit1_EditValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Expiry :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "[F10]";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(105, 61);
            this.txtbarcode.MenuManager = this.barManager1;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Properties.Appearance.Options.UseFont = true;
            this.txtbarcode.Size = new System.Drawing.Size(243, 20);
            this.txtbarcode.TabIndex = 2;
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarcode_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Item no :";
            // 
            // hospname
            // 
            this.hospname.EnterMoveNextControl = true;
            this.hospname.Location = new System.Drawing.Point(518, 34);
            this.hospname.MenuManager = this.barManager1;
            this.hospname.Name = "hospname";
            this.hospname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospname.Properties.Appearance.Options.UseFont = true;
            this.hospname.Size = new System.Drawing.Size(270, 20);
            this.hospname.TabIndex = 1;
            // 
            // patname
            // 
            this.patname.EnterMoveNextControl = true;
            this.patname.Location = new System.Drawing.Point(105, 33);
            this.patname.MenuManager = this.barManager1;
            this.patname.Name = "patname";
            this.patname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patname.Properties.Appearance.Options.UseFont = true;
            this.patname.Size = new System.Drawing.Size(243, 20);
            this.patname.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hospital name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Patient name :";
            // 
            // txtvocherno
            // 
            this.txtvocherno.Location = new System.Drawing.Point(518, 8);
            this.txtvocherno.MenuManager = this.barManager1;
            this.txtvocherno.Name = "txtvocherno";
            this.txtvocherno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvocherno.Properties.Appearance.Options.UseFont = true;
            this.txtvocherno.Properties.ReadOnly = true;
            this.txtvocherno.Size = new System.Drawing.Size(111, 20);
            this.txtvocherno.TabIndex = 3;
            // 
            // voudate
            // 
            this.voudate.EditValue = null;
            this.voudate.Location = new System.Drawing.Point(677, 6);
            this.voudate.MenuManager = this.barManager1;
            this.voudate.Name = "voudate";
            this.voudate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.voudate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.voudate.Size = new System.Drawing.Size(111, 20);
            this.voudate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voucher No. :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dDDETAILSBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 115);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(800, 272);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dDDETAILSBindingSource
            // 
            this.dDDETAILSBindingSource.DataMember = "DDDETAILS";
            this.dDDETAILSBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colDNO,
            this.colITEMNO,
            this.colITEMNAME,
            this.colDOSAGE,
            this.colPRECA,
            this.colEXPDT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.ReadOnly = true;
            // 
            // colDNO
            // 
            this.colDNO.AppearanceCell.Options.UseTextOptions = true;
            this.colDNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colDNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDNO.FieldName = "DNO";
            this.colDNO.Name = "colDNO";
            this.colDNO.Width = 116;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Item No.";
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.Visible = true;
            this.colITEMNO.VisibleIndex = 0;
            this.colITEMNO.Width = 142;
            // 
            // colITEMNAME
            // 
            this.colITEMNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNAME.Caption = "Item name";
            this.colITEMNAME.FieldName = "ITEMNAME";
            this.colITEMNAME.Name = "colITEMNAME";
            this.colITEMNAME.Visible = true;
            this.colITEMNAME.VisibleIndex = 1;
            this.colITEMNAME.Width = 259;
            // 
            // colDOSAGE
            // 
            this.colDOSAGE.AppearanceCell.Options.UseTextOptions = true;
            this.colDOSAGE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOSAGE.AppearanceHeader.Options.UseTextOptions = true;
            this.colDOSAGE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDOSAGE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDOSAGE.Caption = "Dosage";
            this.colDOSAGE.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colDOSAGE.FieldName = "DOSAGE";
            this.colDOSAGE.Name = "colDOSAGE";
            this.colDOSAGE.Visible = true;
            this.colDOSAGE.VisibleIndex = 2;
            this.colDOSAGE.Width = 183;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.dOSAGESBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "DDNAMEAR";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "TID";
            // 
            // dOSAGESBindingSource
            // 
            this.dOSAGESBindingSource.DataMember = "DOSAGES";
            this.dOSAGESBindingSource.DataSource = this.dsMaster1;
            // 
            // colPRECA
            // 
            this.colPRECA.AppearanceCell.Options.UseTextOptions = true;
            this.colPRECA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRECA.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRECA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRECA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRECA.Caption = "Precaution";
            this.colPRECA.FieldName = "PRECA";
            this.colPRECA.Name = "colPRECA";
            this.colPRECA.Visible = true;
            this.colPRECA.VisibleIndex = 3;
            this.colPRECA.Width = 146;
            // 
            // colEXPDT
            // 
            this.colEXPDT.AppearanceCell.Options.UseTextOptions = true;
            this.colEXPDT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPDT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEXPDT.Caption = "Exp.Dt";
            this.colEXPDT.FieldName = "EXPDT";
            this.colEXPDT.Name = "colEXPDT";
            this.colEXPDT.Visible = true;
            this.colEXPDT.VisibleIndex = 4;
            this.colEXPDT.Width = 52;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Drugdispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Drugdispatch";
            this.Text = "Drug Dispatch";
            this.Load += new System.EventHandler(this.Drugdispatch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Drugdispatch_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvocherno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voudate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voudate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSAGESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BarManager barManager1;
        private Bar bar2;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private BarButtonItem MovePrev;
        private BarButtonItem MoveNext;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private DateEdit voudate;
        private TextEdit txtvocherno;
        private BarButtonItem barButtonItem6;
        private BarCheckItem barCheckItem1;
        private BarCheckItem barCheckItem2;
        private BarButtonItem barButtonItem7;
        private Label label6;
        private TextEdit txtbarcode;
        private Label label5;
        private TextEdit hospname;
        private TextEdit patname;
        private Label label4;
        private Label label3;
        private GridControl gridControl1;
        private GridView gridView1;
        private Label label7;
        private ComboBoxEdit comboBoxEdit1;
        private BindingSource dDDETAILSBindingSource;
        private GridColumn colTID;
        private GridColumn colDNO;
        private GridColumn colITEMNO;
        private GridColumn colITEMNAME;
        private GridColumn colDOSAGE;
        private GridColumn colPRECA;
        private GridColumn colEXPDT;
        private DsMaster dsMaster1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BindingSource dOSAGESBindingSource;
        private BarStaticItem barStaticItem1;
        private BarEditItem lookupcashier;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private BindingSource uSERINFOBindingSource;
        private BarStaticItem barStaticItem2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private BarEditItem barEditItem2;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private PrintDialog printDialog1;
    }
}