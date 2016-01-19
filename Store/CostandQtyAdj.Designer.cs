using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using VIRETAILENTITIES;

namespace Store
{
    partial class CostandQtyAdj
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
            System.Windows.Forms.Label label3;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostandQtyAdj));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reason = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Lookupwarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invdate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.FindItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteLine = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemPopupContainerEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.aDJDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventory1 = new VIRETAILENTITIES.DsInventory();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colADJID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSTOCKID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colITEMNO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colBARCODE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colADJQTY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colACTQTY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colADJSPRICE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colACTSPRICE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colADJCPRICE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colACTCPRICE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colADJEXPDATE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colACTEXPDATE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colADJORDER = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colACTORDER = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.dsPurchase1 = new VIRETAILENTITIES.DsPurchase();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(807, 145);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(621, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 14);
            label3.TabIndex = 87;
            label3.Text = "Doc #:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reason);
            this.panel1.Controls.Add(this.Lookupwarehouse);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.invdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 91);
            this.panel1.TabIndex = 0;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(121, 34);
            this.reason.MenuManager = this.ribbon;
            this.reason.Name = "reason";
            this.reason.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.reason.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.reason.Properties.Appearance.Options.UseBackColor = true;
            this.reason.Properties.Appearance.Options.UseFont = true;
            this.reason.Properties.Appearance.Options.UseForeColor = true;
            this.reason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reason.Properties.Items.AddRange(new object[] {
            "ENTRY MISTAKE",
            "MISCELLANEOUS SALES ADJ"});
            this.reason.Size = new System.Drawing.Size(334, 20);
            this.reason.TabIndex = 1;
            // 
            // Lookupwarehouse
            // 
            this.Lookupwarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lookupwarehouse.EnterMoveNextControl = true;
            this.Lookupwarehouse.Location = new System.Drawing.Point(121, 6);
            this.Lookupwarehouse.Name = "Lookupwarehouse";
            this.Lookupwarehouse.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Lookupwarehouse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lookupwarehouse.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lookupwarehouse.Properties.Appearance.Options.UseBackColor = true;
            this.Lookupwarehouse.Properties.Appearance.Options.UseFont = true;
            this.Lookupwarehouse.Properties.Appearance.Options.UseForeColor = true;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject2.Options.UseFont = true;
            this.Lookupwarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, true, false, false, DevExpress.XtraEditors.ImageLocation.Default, ((System.Drawing.Image)(resources.GetObject("Lookupwarehouse.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.Lookupwarehouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORECODE", "STORECODE", 51, DevExpress.Utils.FormatType.Custom, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORENAME", "STORENAME", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Lookupwarehouse.Properties.DisplayMember = "STORENAME";
            this.Lookupwarehouse.Properties.NullText = "";
            this.Lookupwarehouse.Properties.ShowFooter = false;
            this.Lookupwarehouse.Properties.ShowHeader = false;
            this.Lookupwarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Lookupwarehouse.Properties.ValueMember = "STORECODE";
            this.Lookupwarehouse.Size = new System.Drawing.Size(334, 20);
            this.Lookupwarehouse.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.standaloneBarDockControl1);
            this.panel2.Location = new System.Drawing.Point(3, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 32);
            this.panel2.TabIndex = 89;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(795, 32);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(672, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Reason:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date:";
            // 
            // invdate
            // 
            this.invdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.invdate.EditValue = null;
            this.invdate.Location = new System.Drawing.Point(672, 3);
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
            this.invdate.Size = new System.Drawing.Size(126, 20);
            this.invdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Warehouse / Store:";
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Tools";
            // 
            // bar5
            // 
            this.bar5.BarName = "Tools";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(315, 342);
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // bar6
            // 
            this.bar6.BarName = "Tools";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar6.FloatLocation = new System.Drawing.Point(315, 342);
            this.bar6.FloatSize = new System.Drawing.Size(785, 31);
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Tools";
            // 
            // bar7
            // 
            this.bar7.BarName = "Tools";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar7.FloatLocation = new System.Drawing.Point(315, 342);
            this.bar7.FloatSize = new System.Drawing.Size(785, 31);
            this.bar7.OptionsBar.AllowQuickCustomization = false;
            this.bar7.OptionsBar.DrawDragBorder = false;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar8});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.FindItem,
            this.DeleteLine,
            this.barEditItem2});
            this.barManager1.MaxItemId = 13;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemPopupContainerEdit2});
            this.barManager1.UseF10KeyForMenu = false;
            this.barManager1.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.barManager1_EditorKeyDown);
            // 
            // bar8
            // 
            this.bar8.BarName = "Tools";
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar8.FloatLocation = new System.Drawing.Point(315, 342);
            this.bar8.FloatSize = new System.Drawing.Size(785, 31);
            this.bar8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barEditItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.FindItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.DeleteLine, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar8.OptionsBar.AllowQuickCustomization = false;
            this.bar8.OptionsBar.DrawDragBorder = false;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar8.Text = "Tools";
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
            // 
            // DeleteLine
            // 
            this.DeleteLine.Caption = "Delete Line - F4";
            this.DeleteLine.Glyph = global::Store.Properties.Resources.remove;
            this.DeleteLine.Id = 2;
            this.DeleteLine.Name = "DeleteLine";
            this.DeleteLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteLine_ItemClick);
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
            this.gridControl1.DataSource = this.aDJDETAILBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 236);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(807, 303);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // aDJDETAILBindingSource
            // 
            this.aDJDETAILBindingSource.DataMember = "ADJDETAIL";
            this.aDJDETAILBindingSource.DataSource = this.dsInventory1;
            // 
            // dsInventory1
            // 
            this.dsInventory1.DataSetName = "DsInventory";
            this.dsInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colTID,
            this.colADJID,
            this.colSTOCKID,
            this.colITEMNO,
            this.colACTEXPDATE,
            this.colADJEXPDATE,
            this.colACTQTY,
            this.colADJQTY,
            this.colACTSPRICE,
            this.colADJSPRICE,
            this.colACTCPRICE,
            this.colADJCPRICE,
            this.colACTORDER,
            this.colADJORDER,
            this.colBARCODE});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.advBandedGridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.advBandedGridView1_CellValueChanging);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.Caption = "Item Details";
            this.gridBand1.Columns.Add(this.colTID);
            this.gridBand1.Columns.Add(this.colADJID);
            this.gridBand1.Columns.Add(this.colSTOCKID);
            this.gridBand1.Columns.Add(this.colITEMNO);
            this.gridBand1.Columns.Add(this.colBARCODE);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 501;
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTID.OptionsColumn.AllowIncrementalSearch = false;
            this.colTID.OptionsColumn.AllowMove = false;
            this.colTID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTID.OptionsColumn.ReadOnly = true;
            this.colTID.Width = 90;
            // 
            // colADJID
            // 
            this.colADJID.AppearanceCell.Options.UseTextOptions = true;
            this.colADJID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADJID.FieldName = "ADJID";
            this.colADJID.Name = "colADJID";
            this.colADJID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colADJID.OptionsColumn.AllowIncrementalSearch = false;
            this.colADJID.OptionsColumn.AllowMove = false;
            this.colADJID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colADJID.Width = 74;
            // 
            // colSTOCKID
            // 
            this.colSTOCKID.AppearanceCell.Options.UseTextOptions = true;
            this.colSTOCKID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTOCKID.FieldName = "STOCKID";
            this.colSTOCKID.Name = "colSTOCKID";
            this.colSTOCKID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCKID.OptionsColumn.AllowIncrementalSearch = false;
            this.colSTOCKID.OptionsColumn.AllowMove = false;
            this.colSTOCKID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOCKID.Width = 139;
            // 
            // colITEMNO
            // 
            this.colITEMNO.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO.Caption = "Item name";
            this.colITEMNO.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colITEMNO.FieldName = "ITEMNO";
            this.colITEMNO.Name = "colITEMNO";
            this.colITEMNO.OptionsColumn.AllowEdit = false;
            this.colITEMNO.OptionsColumn.AllowFocus = false;
            this.colITEMNO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNO.OptionsColumn.AllowIncrementalSearch = false;
            this.colITEMNO.OptionsColumn.AllowMove = false;
            this.colITEMNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEMNO.Visible = true;
            this.colITEMNO.Width = 501;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // colBARCODE
            // 
            this.colBARCODE.AppearanceCell.Options.UseTextOptions = true;
            this.colBARCODE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBARCODE.Caption = "Barcode";
            this.colBARCODE.FieldName = "ITEMNO";
            this.colBARCODE.Name = "colBARCODE";
            this.colBARCODE.OptionsColumn.AllowEdit = false;
            this.colBARCODE.OptionsColumn.AllowFocus = false;
            this.colBARCODE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBARCODE.OptionsColumn.AllowIncrementalSearch = false;
            this.colBARCODE.OptionsColumn.AllowMove = false;
            this.colBARCODE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBARCODE.RowIndex = 1;
            this.colBARCODE.Visible = true;
            this.colBARCODE.Width = 501;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Qty.";
            this.gridBand2.Columns.Add(this.colADJQTY);
            this.gridBand2.Columns.Add(this.colACTQTY);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 40;
            // 
            // colADJQTY
            // 
            this.colADJQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colADJQTY.AppearanceCell.Options.UseFont = true;
            this.colADJQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colADJQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colADJQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADJQTY.Caption = "New";
            this.colADJQTY.DisplayFormat.FormatString = "N";
            this.colADJQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colADJQTY.FieldName = "ADJQTY";
            this.colADJQTY.Name = "colADJQTY";
            this.colADJQTY.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colADJQTY.OptionsColumn.AllowIncrementalSearch = false;
            this.colADJQTY.OptionsColumn.AllowMove = false;
            this.colADJQTY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colADJQTY.Visible = true;
            this.colADJQTY.Width = 40;
            // 
            // colACTQTY
            // 
            this.colACTQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colACTQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colACTQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colACTQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTQTY.Caption = "Old";
            this.colACTQTY.DisplayFormat.FormatString = "N";
            this.colACTQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colACTQTY.FieldName = "ACTQTY";
            this.colACTQTY.Name = "colACTQTY";
            this.colACTQTY.OptionsColumn.AllowEdit = false;
            this.colACTQTY.OptionsColumn.AllowFocus = false;
            this.colACTQTY.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colACTQTY.OptionsColumn.AllowIncrementalSearch = false;
            this.colACTQTY.OptionsColumn.AllowMove = false;
            this.colACTQTY.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colACTQTY.RowIndex = 1;
            this.colACTQTY.Visible = true;
            this.colACTQTY.Width = 40;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.Caption = "Sales Price";
            this.gridBand3.Columns.Add(this.colADJSPRICE);
            this.gridBand3.Columns.Add(this.colACTSPRICE);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 66;
            // 
            // colADJSPRICE
            // 
            this.colADJSPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colADJSPRICE.AppearanceCell.Options.UseFont = true;
            this.colADJSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colADJSPRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colADJSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADJSPRICE.Caption = "New";
            this.colADJSPRICE.DisplayFormat.FormatString = "N2";
            this.colADJSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colADJSPRICE.FieldName = "ADJSPRICE";
            this.colADJSPRICE.Name = "colADJSPRICE";
            this.colADJSPRICE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colADJSPRICE.OptionsColumn.AllowIncrementalSearch = false;
            this.colADJSPRICE.OptionsColumn.AllowMove = false;
            this.colADJSPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colADJSPRICE.Visible = true;
            this.colADJSPRICE.Width = 66;
            // 
            // colACTSPRICE
            // 
            this.colACTSPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colACTSPRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTSPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colACTSPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colACTSPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTSPRICE.Caption = "Old";
            this.colACTSPRICE.DisplayFormat.FormatString = "N2";
            this.colACTSPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colACTSPRICE.FieldName = "ACTSPRICE";
            this.colACTSPRICE.Name = "colACTSPRICE";
            this.colACTSPRICE.OptionsColumn.AllowEdit = false;
            this.colACTSPRICE.OptionsColumn.AllowFocus = false;
            this.colACTSPRICE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colACTSPRICE.OptionsColumn.AllowIncrementalSearch = false;
            this.colACTSPRICE.OptionsColumn.AllowMove = false;
            this.colACTSPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colACTSPRICE.RowIndex = 1;
            this.colACTSPRICE.Visible = true;
            this.colACTSPRICE.Width = 66;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.Caption = "Cost Price";
            this.gridBand4.Columns.Add(this.colADJCPRICE);
            this.gridBand4.Columns.Add(this.colACTCPRICE);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 64;
            // 
            // colADJCPRICE
            // 
            this.colADJCPRICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colADJCPRICE.AppearanceCell.Options.UseFont = true;
            this.colADJCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colADJCPRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colADJCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADJCPRICE.Caption = "New";
            this.colADJCPRICE.DisplayFormat.FormatString = "N2";
            this.colADJCPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colADJCPRICE.FieldName = "ADJCPRICE";
            this.colADJCPRICE.Name = "colADJCPRICE";
            this.colADJCPRICE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colADJCPRICE.OptionsColumn.AllowIncrementalSearch = false;
            this.colADJCPRICE.OptionsColumn.AllowMove = false;
            this.colADJCPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colADJCPRICE.Visible = true;
            this.colADJCPRICE.Width = 64;
            // 
            // colACTCPRICE
            // 
            this.colACTCPRICE.AppearanceCell.Options.UseTextOptions = true;
            this.colACTCPRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTCPRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colACTCPRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.colACTCPRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTCPRICE.Caption = "Old";
            this.colACTCPRICE.DisplayFormat.FormatString = "N2";
            this.colACTCPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colACTCPRICE.FieldName = "ACTCPRICE";
            this.colACTCPRICE.Name = "colACTCPRICE";
            this.colACTCPRICE.OptionsColumn.AllowEdit = false;
            this.colACTCPRICE.OptionsColumn.AllowFocus = false;
            this.colACTCPRICE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colACTCPRICE.OptionsColumn.AllowIncrementalSearch = false;
            this.colACTCPRICE.OptionsColumn.AllowMove = false;
            this.colACTCPRICE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colACTCPRICE.RowIndex = 1;
            this.colACTCPRICE.Visible = true;
            this.colACTCPRICE.Width = 64;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Exp.Dt";
            this.gridBand5.Columns.Add(this.colADJEXPDATE);
            this.gridBand5.Columns.Add(this.colACTEXPDATE);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 49;
            // 
            // colADJEXPDATE
            // 
            this.colADJEXPDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colADJEXPDATE.AppearanceCell.Options.UseFont = true;
            this.colADJEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colADJEXPDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colADJEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADJEXPDATE.Caption = "New";
            this.colADJEXPDATE.FieldName = "ADJEXPDATE";
            this.colADJEXPDATE.Name = "colADJEXPDATE";
            this.colADJEXPDATE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colADJEXPDATE.OptionsColumn.AllowIncrementalSearch = false;
            this.colADJEXPDATE.OptionsColumn.AllowMove = false;
            this.colADJEXPDATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colADJEXPDATE.Visible = true;
            this.colADJEXPDATE.Width = 49;
            // 
            // colACTEXPDATE
            // 
            this.colACTEXPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colACTEXPDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTEXPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colACTEXPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colACTEXPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTEXPDATE.Caption = "Old";
            this.colACTEXPDATE.DisplayFormat.FormatString = "MM-yy";
            this.colACTEXPDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colACTEXPDATE.FieldName = "ACTEXPDATE";
            this.colACTEXPDATE.Name = "colACTEXPDATE";
            this.colACTEXPDATE.OptionsColumn.AllowEdit = false;
            this.colACTEXPDATE.OptionsColumn.AllowFocus = false;
            this.colACTEXPDATE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colACTEXPDATE.OptionsColumn.AllowIncrementalSearch = false;
            this.colACTEXPDATE.OptionsColumn.AllowMove = false;
            this.colACTEXPDATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colACTEXPDATE.RowIndex = 1;
            this.colACTEXPDATE.Visible = true;
            this.colACTEXPDATE.Width = 49;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Sale Order";
            this.gridBand6.Columns.Add(this.colADJORDER);
            this.gridBand6.Columns.Add(this.colACTORDER);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 64;
            // 
            // colADJORDER
            // 
            this.colADJORDER.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colADJORDER.AppearanceCell.Options.UseFont = true;
            this.colADJORDER.AppearanceCell.Options.UseTextOptions = true;
            this.colADJORDER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colADJORDER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADJORDER.Caption = "New";
            this.colADJORDER.FieldName = "ADJORDER";
            this.colADJORDER.Name = "colADJORDER";
            this.colADJORDER.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colADJORDER.OptionsColumn.AllowIncrementalSearch = false;
            this.colADJORDER.OptionsColumn.AllowMove = false;
            this.colADJORDER.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colADJORDER.Visible = true;
            this.colADJORDER.Width = 64;
            // 
            // colACTORDER
            // 
            this.colACTORDER.AppearanceCell.Options.UseTextOptions = true;
            this.colACTORDER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTORDER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colACTORDER.AppearanceHeader.Options.UseTextOptions = true;
            this.colACTORDER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colACTORDER.Caption = "Old";
            this.colACTORDER.DisplayFormat.FormatString = "N2";
            this.colACTORDER.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colACTORDER.FieldName = "ACTORDER";
            this.colACTORDER.Name = "colACTORDER";
            this.colACTORDER.OptionsColumn.AllowEdit = false;
            this.colACTORDER.OptionsColumn.AllowFocus = false;
            this.colACTORDER.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colACTORDER.OptionsColumn.AllowIncrementalSearch = false;
            this.colACTORDER.OptionsColumn.AllowMove = false;
            this.colACTORDER.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colACTORDER.RowIndex = 1;
            this.colACTORDER.Visible = true;
            this.colACTORDER.Width = 64;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "MM-yy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "MM-yy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // dsPurchase1
            // 
            this.dsPurchase1.DataSetName = "DsPurchase";
            this.dsPurchase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CostandQtyAdj
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CostandQtyAdj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Adjustment";
            this.Load += new System.EventHandler(this.CostandQtyAdj_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CostandQtyAdj_KeyDown);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DateEdit invdate;
        private Label label1;
        private Label label2;
        private Label label9;
        private TextBox textBox1;
        private Bar bar4;
        private Bar bar5;
        private Bar bar2;
        private Bar bar3;
        private Bar bar1;
        private Bar bar6;
        private Bar bar7;
        private Panel panel2;
        private StandaloneBarDockControl standaloneBarDockControl1;
        protected BarManager barManager1;
        private Bar bar8;
        protected BarEditItem barEditItem2;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem FindItem;
        private BarButtonItem DeleteLine;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit2;
        private GridControl gridControl1;
        private AdvBandedGridView advBandedGridView1;
        private BindingSource aDJDETAILBindingSource;
        private BandedGridColumn colTID;
        private BandedGridColumn colADJID;
        private BandedGridColumn colSTOCKID;
        private BandedGridColumn colITEMNO;
        private BandedGridColumn colACTEXPDATE;
        private BandedGridColumn colADJEXPDATE;
        private BandedGridColumn colACTQTY;
        private BandedGridColumn colADJQTY;
        private BandedGridColumn colACTSPRICE;
        private BandedGridColumn colADJSPRICE;
        private BandedGridColumn colACTCPRICE;
        private BandedGridColumn colADJCPRICE;
        private BandedGridColumn colACTORDER;
        private BandedGridColumn colADJORDER;
        private BandedGridColumn colBARCODE;
        private GridBand gridBand1;
        private GridBand gridBand2;
        private GridBand gridBand3;
        private GridBand gridBand4;
        private GridBand gridBand5;
        private GridBand gridBand6;
        private DsInventory dsInventory1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        protected LookUpEdit Lookupwarehouse;
        private ComboBoxEdit reason;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private DsPurchase dsPurchase1;
    }
}