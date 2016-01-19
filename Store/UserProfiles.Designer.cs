using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class UserProfiles
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfiles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkEdit5 = new DevExpress.XtraEditors.CheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.pROFILENAMEMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.mENUNEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMENUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMENUNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMGIND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMPARENTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISLARGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBGIMGINDX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFILENAMEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUNEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkEdit5);
            this.panel1.Controls.Add(this.checkEdit4);
            this.panel1.Controls.Add(this.checkEdit3);
            this.panel1.Controls.Add(this.checkEdit2);
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 62);
            this.panel1.TabIndex = 0;
            // 
            // checkEdit5
            // 
            this.checkEdit5.EditValue = true;
            this.checkEdit5.Location = new System.Drawing.Point(385, 37);
            this.checkEdit5.MenuManager = this.barManager1;
            this.checkEdit5.Name = "checkEdit5";
            this.checkEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Gray;
            this.checkEdit5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.checkEdit5.Properties.Appearance.Options.UseFont = true;
            this.checkEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit5.Properties.Caption = "Communication";
            this.checkEdit5.Size = new System.Drawing.Size(127, 19);
            this.checkEdit5.TabIndex = 6;
            this.checkEdit5.CheckedChanged += new System.EventHandler(this.checkEdit5_CheckedChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barCheckItem1,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.Save16;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Glyph = global::Store.Properties.Resources.Delete16;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Check all";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.tickwhite;
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Un Check";
            this.barButtonItem4.Glyph = global::Store.Properties.Resources.grayball;
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(709, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
            this.barDockControlBottom.Size = new System.Drawing.Size(709, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(709, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 2;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // checkEdit4
            // 
            this.checkEdit4.EditValue = true;
            this.checkEdit4.Location = new System.Drawing.Point(518, 37);
            this.checkEdit4.MenuManager = this.barManager1;
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.checkEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.checkEdit4.Properties.Appearance.Options.UseFont = true;
            this.checkEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit4.Properties.Caption = "Admintration";
            this.checkEdit4.Size = new System.Drawing.Size(110, 19);
            this.checkEdit4.TabIndex = 5;
            this.checkEdit4.CheckedChanged += new System.EventHandler(this.checkEdit4_CheckedChanged);
            // 
            // checkEdit3
            // 
            this.checkEdit3.EditValue = true;
            this.checkEdit3.Location = new System.Drawing.Point(278, 37);
            this.checkEdit3.MenuManager = this.barManager1;
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.checkEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.checkEdit3.Properties.Appearance.Options.UseFont = true;
            this.checkEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit3.Properties.Caption = "Inventory";
            this.checkEdit3.Size = new System.Drawing.Size(101, 19);
            this.checkEdit3.TabIndex = 4;
            this.checkEdit3.CheckedChanged += new System.EventHandler(this.checkEdit3_CheckedChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(200, 37);
            this.checkEdit2.MenuManager = this.barManager1;
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Teal;
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit2.Properties.Caption = "Sales";
            this.checkEdit2.Size = new System.Drawing.Size(72, 19);
            this.checkEdit2.TabIndex = 3;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(96, 37);
            this.checkEdit1.MenuManager = this.barManager1;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "Purchasing";
            this.checkEdit1.Size = new System.Drawing.Size(98, 19);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(236, 7);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PROFILEID", "PROFILEID", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PROFILENAME", "PROFILENAME", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.pROFILENAMEMASTBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "PROFILENAME";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ShowFooter = false;
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "PROFILEID";
            this.lookUpEdit1.Size = new System.Drawing.Size(303, 20);
            this.lookUpEdit1.TabIndex = 1;
            this.lookUpEdit1.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.lookUpEdit1_ProcessNewValue);
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.LookUpEdit1EditValueChanged);
            // 
            // pROFILENAMEMASTBindingSource
            // 
            this.pROFILENAMEMASTBindingSource.DataMember = "PROFILENAMEMAST";
            this.pROFILENAMEMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(156, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Profile name: ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.mENUNEWBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(709, 380);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // mENUNEWBindingSource
            // 
            this.mENUNEWBindingSource.DataMember = "MENUNEW";
            this.mENUNEWBindingSource.DataSource = this.dsMaster1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMENUID,
            this.colMENUNAME,
            this.colPARENTID,
            this.colIMGIND,
            this.colMPARENTID,
            this.colDESCP,
            this.colSEL,
            this.colISLARGE,
            this.colBGIMGINDX});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Value1 = "0";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMENUID
            // 
            this.colMENUID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMENUID.AppearanceCell.Options.UseFont = true;
            this.colMENUID.AppearanceCell.Options.UseTextOptions = true;
            this.colMENUID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMENUID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMENUID.AppearanceHeader.Options.UseFont = true;
            this.colMENUID.AppearanceHeader.Options.UseTextOptions = true;
            this.colMENUID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMENUID.FieldName = "MENUID";
            this.colMENUID.Name = "colMENUID";
            // 
            // colMENUNAME
            // 
            this.colMENUNAME.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMENUNAME.AppearanceCell.Options.UseFont = true;
            this.colMENUNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colMENUNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMENUNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMENUNAME.AppearanceHeader.Options.UseFont = true;
            this.colMENUNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colMENUNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMENUNAME.Caption = "Menu name";
            this.colMENUNAME.FieldName = "MENUNAME";
            this.colMENUNAME.Name = "colMENUNAME";
            this.colMENUNAME.Visible = true;
            this.colMENUNAME.VisibleIndex = 1;
            this.colMENUNAME.Width = 656;
            // 
            // colPARENTID
            // 
            this.colPARENTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPARENTID.AppearanceCell.Options.UseFont = true;
            this.colPARENTID.AppearanceCell.Options.UseTextOptions = true;
            this.colPARENTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPARENTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPARENTID.AppearanceHeader.Options.UseFont = true;
            this.colPARENTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPARENTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPARENTID.FieldName = "PARENTID";
            this.colPARENTID.Name = "colPARENTID";
            // 
            // colIMGIND
            // 
            this.colIMGIND.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIMGIND.AppearanceCell.Options.UseFont = true;
            this.colIMGIND.AppearanceCell.Options.UseTextOptions = true;
            this.colIMGIND.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colIMGIND.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIMGIND.AppearanceHeader.Options.UseFont = true;
            this.colIMGIND.AppearanceHeader.Options.UseTextOptions = true;
            this.colIMGIND.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colIMGIND.FieldName = "IMGIND";
            this.colIMGIND.Name = "colIMGIND";
            // 
            // colMPARENTID
            // 
            this.colMPARENTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMPARENTID.AppearanceCell.Options.UseFont = true;
            this.colMPARENTID.AppearanceCell.Options.UseTextOptions = true;
            this.colMPARENTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMPARENTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMPARENTID.AppearanceHeader.Options.UseFont = true;
            this.colMPARENTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colMPARENTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMPARENTID.FieldName = "MPARENTID";
            this.colMPARENTID.Name = "colMPARENTID";
            // 
            // colDESCP
            // 
            this.colDESCP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDESCP.AppearanceCell.Options.UseFont = true;
            this.colDESCP.AppearanceCell.Options.UseTextOptions = true;
            this.colDESCP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDESCP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDESCP.AppearanceHeader.Options.UseFont = true;
            this.colDESCP.AppearanceHeader.Options.UseTextOptions = true;
            this.colDESCP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDESCP.FieldName = "DESCP";
            this.colDESCP.Name = "colDESCP";
            // 
            // colSEL
            // 
            this.colSEL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSEL.AppearanceCell.Options.UseFont = true;
            this.colSEL.AppearanceCell.Options.UseTextOptions = true;
            this.colSEL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSEL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSEL.AppearanceHeader.Options.UseFont = true;
            this.colSEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colSEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSEL.FieldName = "SEL";
            this.colSEL.Name = "colSEL";
            this.colSEL.OptionsColumn.ShowCaption = false;
            this.colSEL.Visible = true;
            this.colSEL.VisibleIndex = 0;
            this.colSEL.Width = 35;
            // 
            // colISLARGE
            // 
            this.colISLARGE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISLARGE.AppearanceCell.Options.UseFont = true;
            this.colISLARGE.AppearanceCell.Options.UseTextOptions = true;
            this.colISLARGE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISLARGE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISLARGE.AppearanceHeader.Options.UseFont = true;
            this.colISLARGE.AppearanceHeader.Options.UseTextOptions = true;
            this.colISLARGE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colISLARGE.FieldName = "ISLARGE";
            this.colISLARGE.Name = "colISLARGE";
            // 
            // colBGIMGINDX
            // 
            this.colBGIMGINDX.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBGIMGINDX.AppearanceCell.Options.UseFont = true;
            this.colBGIMGINDX.AppearanceCell.Options.UseTextOptions = true;
            this.colBGIMGINDX.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBGIMGINDX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBGIMGINDX.AppearanceHeader.Options.UseFont = true;
            this.colBGIMGINDX.AppearanceHeader.Options.UseTextOptions = true;
            this.colBGIMGINDX.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBGIMGINDX.FieldName = "BGIMGINDX";
            this.colBGIMGINDX.Name = "colBGIMGINDX";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // UserProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 495);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProfiles";
            this.Text = "Profiles";
            this.Load += new System.EventHandler(this.UserProfiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFILENAMEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUNEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private LabelControl labelControl1;
        private LookUpEdit lookUpEdit1;
        private GridControl gridControl1;
        private GridView gridView1;
        private Bar bar3;
        private BarManager barManager1;
        private Bar bar2;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private Bar bar4;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private CheckEdit checkEdit4;
        private CheckEdit checkEdit3;
        private CheckEdit checkEdit2;
        private CheckEdit checkEdit1;
        private DsMaster dsMaster1;
        private BindingSource pROFILENAMEMASTBindingSource;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem4;
        private BarCheckItem barCheckItem1;
        private CheckEdit checkEdit5;
        private BindingSource mENUNEWBindingSource;
        private GridColumn colMENUID;
        private GridColumn colMENUNAME;
        private GridColumn colPARENTID;
        private GridColumn colIMGIND;
        private GridColumn colMPARENTID;
        private GridColumn colDESCP;
        private GridColumn colSEL;
        private GridColumn colISLARGE;
        private GridColumn colBGIMGINDX;
    }
}