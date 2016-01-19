namespace BaseClasses
{
    partial class BaseRibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseRibbonForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BSave = new DevExpress.XtraBars.BarButtonItem();
            this.BSaveandClose = new DevExpress.XtraBars.BarButtonItem();
            this.BSaveandNew = new DevExpress.XtraBars.BarButtonItem();
            this.BDelete = new DevExpress.XtraBars.BarButtonItem();
            this.BClear = new DevExpress.XtraBars.BarButtonItem();
            this.BPrint = new DevExpress.XtraBars.BarButtonItem();
            this.BMovePrev = new DevExpress.XtraBars.BarButtonItem();
            this.BMoveNext = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.BNotes = new DevExpress.XtraBars.BarButtonItem();
            this.BHold = new DevExpress.XtraBars.BarButtonItem();
            this.BHoldList = new DevExpress.XtraBars.BarButtonItem();
            this.coptionsbutton2 = new DevExpress.XtraBars.BarButtonItem();
            this.coptionsbutton3 = new DevExpress.XtraBars.BarButtonItem();
            this.coptionsbutton4 = new DevExpress.XtraBars.BarButtonItem();
            this.coptionsbutton5 = new DevExpress.XtraBars.BarButtonItem();
            this.coptionsbutton6 = new DevExpress.XtraBars.BarButtonItem();
            this.coptionsbutton7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.footerusername = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.BNew = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.footerediteduser = new DevExpress.XtraBars.BarStaticItem();
            this.footercdate = new DevExpress.XtraBars.BarStaticItem();
            this.footeredate = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.txtloginname = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageCategory2 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pagesave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pagedit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageprint = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pagemoreoptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pagenavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pagecustome = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowKeyTips = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.BSave,
            this.BSaveandClose,
            this.BSaveandNew,
            this.BDelete,
            this.BClear,
            this.BPrint,
            this.BMovePrev,
            this.BMoveNext,
            this.barButtonItem9,
            this.barButtonItem10,
            this.BNotes,
            this.BHold,
            this.BHoldList,
            this.coptionsbutton2,
            this.coptionsbutton3,
            this.coptionsbutton4,
            this.coptionsbutton5,
            this.coptionsbutton6,
            this.coptionsbutton7,
            this.barButtonItem1,
            this.barStaticItem1,
            this.footerusername,
            this.barStaticItem3,
            this.BNew,
            this.barStaticItem2,
            this.footerediteduser,
            this.footercdate,
            this.footeredate,
            this.barStaticItem4,
            this.txtloginname});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 35;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1,
            this.ribbonPageCategory2});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(870, 145);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.BSave);
            this.ribbon.Toolbar.ItemLinks.Add(this.BSaveandClose);
            this.ribbon.Toolbar.ItemLinks.Add(this.BPrint);
            this.ribbon.Toolbar.ItemLinks.Add(this.BMovePrev);
            this.ribbon.Toolbar.ItemLinks.Add(this.BMoveNext);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // BSave
            // 
            this.BSave.Caption = "Save";
            this.BSave.Glyph = global::BaseClasses.Properties.Resources.page_white_save16;
            this.BSave.Id = 2;
            this.BSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.BSave.LargeGlyph = global::BaseClasses.Properties.Resources.page_white_save;
            this.BSave.Name = "BSave";
            this.BSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BSaveandClose
            // 
            this.BSaveandClose.Caption = "Save and Close";
            this.BSaveandClose.Glyph = global::BaseClasses.Properties.Resources.page_white_save_delete16;
            this.BSaveandClose.Id = 3;
            this.BSaveandClose.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.BSaveandClose.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.BSaveandClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.BSaveandClose.LargeGlyph = global::BaseClasses.Properties.Resources.page_white_save_close;
            this.BSaveandClose.Name = "BSaveandClose";
            this.BSaveandClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BSaveandNew
            // 
            this.BSaveandNew.Caption = "Save and New";
            this.BSaveandNew.Glyph = global::BaseClasses.Properties.Resources.page_white_save_new16;
            this.BSaveandNew.Id = 4;
            this.BSaveandNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.BSaveandNew.LargeGlyph = global::BaseClasses.Properties.Resources.page_white_save_new;
            this.BSaveandNew.Name = "BSaveandNew";
            this.BSaveandNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BDelete
            // 
            this.BDelete.Caption = "Delete";
            this.BDelete.Glyph = global::BaseClasses.Properties.Resources.page_white_delete16;
            this.BDelete.Id = 5;
            this.BDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.BDelete.LargeGlyph = global::BaseClasses.Properties.Resources.page_white_delete;
            this.BDelete.Name = "BDelete";
            this.BDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BClear
            // 
            this.BClear.Caption = "Clear";
            this.BClear.Glyph = global::BaseClasses.Properties.Resources.editclear16;
            this.BClear.Id = 6;
            this.BClear.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.BClear.LargeGlyph = global::BaseClasses.Properties.Resources.editclear;
            this.BClear.Name = "BClear";
            this.BClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BPrint
            // 
            this.BPrint.Caption = "Print";
            this.BPrint.Glyph = global::BaseClasses.Properties.Resources.printer1;
            this.BPrint.Id = 7;
            this.BPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.BPrint.LargeGlyph = global::BaseClasses.Properties.Resources.printer;
            this.BPrint.Name = "BPrint";
            this.BPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BMovePrev
            // 
            this.BMovePrev.Caption = "Move Prev.";
            this.BMovePrev.Glyph = global::BaseClasses.Properties.Resources.resultset_previous16;
            this.BMovePrev.Id = 8;
            this.BMovePrev.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.BMovePrev.LargeGlyph = global::BaseClasses.Properties.Resources.resultset_previous;
            this.BMovePrev.Name = "BMovePrev";
            this.BMovePrev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BMoveNext
            // 
            this.BMoveNext.Caption = "Move Next";
            this.BMoveNext.Glyph = global::BaseClasses.Properties.Resources.resultset_next16;
            this.BMoveNext.Id = 9;
            this.BMoveNext.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.BMoveNext.LargeGlyph = global::BaseClasses.Properties.Resources.resultset_next;
            this.BMoveNext.Name = "BMoveNext";
            this.BMoveNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 10;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // BNotes
            // 
            this.BNotes.Caption = "Notes";
            this.BNotes.Glyph = global::BaseClasses.Properties.Resources.stickynote;
            this.BNotes.Id = 13;
            this.BNotes.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.BNotes.Name = "BNotes";
            this.BNotes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BHold
            // 
            this.BHold.Caption = "Hold";
            this.BHold.Id = 14;
            this.BHold.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H));
            this.BHold.LargeGlyph = global::BaseClasses.Properties.Resources.hold;
            this.BHold.Name = "BHold";
            this.BHold.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // BHoldList
            // 
            this.BHoldList.Caption = "Hold List";
            this.BHoldList.Glyph = global::BaseClasses.Properties.Resources.viewlist16;
            this.BHoldList.Id = 15;
            this.BHoldList.Name = "BHoldList";
            this.BHoldList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // coptionsbutton2
            // 
            this.coptionsbutton2.Caption = "2";
            this.coptionsbutton2.Id = 16;
            this.coptionsbutton2.Name = "coptionsbutton2";
            this.coptionsbutton2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.coptionsbutton2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // coptionsbutton3
            // 
            this.coptionsbutton3.Caption = "3";
            this.coptionsbutton3.Id = 17;
            this.coptionsbutton3.Name = "coptionsbutton3";
            this.coptionsbutton3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.coptionsbutton3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // coptionsbutton4
            // 
            this.coptionsbutton4.Caption = "4";
            this.coptionsbutton4.Id = 18;
            this.coptionsbutton4.Name = "coptionsbutton4";
            this.coptionsbutton4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.coptionsbutton4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // coptionsbutton5
            // 
            this.coptionsbutton5.Caption = "5";
            this.coptionsbutton5.Id = 19;
            this.coptionsbutton5.Name = "coptionsbutton5";
            this.coptionsbutton5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.coptionsbutton5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // coptionsbutton6
            // 
            this.coptionsbutton6.Caption = "6";
            this.coptionsbutton6.Id = 20;
            this.coptionsbutton6.Name = "coptionsbutton6";
            this.coptionsbutton6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.coptionsbutton6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // coptionsbutton7
            // 
            this.coptionsbutton7.Caption = "7";
            this.coptionsbutton7.Id = 21;
            this.coptionsbutton7.Name = "coptionsbutton7";
            this.coptionsbutton7.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.coptionsbutton7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Table View";
            this.barButtonItem1.Id = 22;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Created by :";
            this.barStaticItem1.Id = 23;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // footerusername
            // 
            this.footerusername.Id = 24;
            this.footerusername.Name = "footerusername";
            this.footerusername.TextAlignment = System.Drawing.StringAlignment.Near;
            this.footerusername.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem3.Caption = "Copyright © Vision && Innovation 2012";
            this.barStaticItem3.Id = 26;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // BNew
            // 
            this.BNew.Caption = "New";
            this.BNew.Id = 27;
            this.BNew.LargeGlyph = global::BaseClasses.Properties.Resources.page_white_star;
            this.BNew.Name = "BNew";
            this.BNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnButtonClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Edited by :";
            this.barStaticItem2.Id = 28;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // footerediteduser
            // 
            this.footerediteduser.Id = 29;
            this.footerediteduser.Name = "footerediteduser";
            this.footerediteduser.TextAlignment = System.Drawing.StringAlignment.Near;
            this.footerediteduser.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // footercdate
            // 
            this.footercdate.Id = 30;
            this.footercdate.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footercdate.ItemAppearance.Normal.Options.UseFont = true;
            this.footercdate.Name = "footercdate";
            this.footercdate.TextAlignment = System.Drawing.StringAlignment.Near;
            this.footercdate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // footeredate
            // 
            this.footeredate.Id = 31;
            this.footeredate.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footeredate.ItemAppearance.Normal.Options.UseFont = true;
            this.footeredate.Name = "footeredate";
            this.footeredate.TextAlignment = System.Drawing.StringAlignment.Near;
            this.footeredate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = " User :";
            this.barStaticItem4.Glyph = global::BaseClasses.Properties.Resources.user_suit;
            this.barStaticItem4.Id = 33;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtloginname
            // 
            this.txtloginname.Id = 34;
            this.txtloginname.Name = "txtloginname";
            this.txtloginname.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPageCategory2
            // 
            this.ribbonPageCategory2.Name = "ribbonPageCategory2";
            this.ribbonPageCategory2.Text = "ribbonPageCategory2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.pagesave,
            this.pagedit,
            this.pageprint,
            this.pagemoreoptions,
            this.pagenavigation,
            this.pagecustome});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BNew);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "New";
            // 
            // pagesave
            // 
            this.pagesave.ItemLinks.Add(this.BSave);
            this.pagesave.ItemLinks.Add(this.BSaveandClose);
            this.pagesave.ItemLinks.Add(this.BSaveandNew);
            this.pagesave.Name = "pagesave";
            this.pagesave.ShowCaptionButton = false;
            this.pagesave.Text = "Save";
            // 
            // pagedit
            // 
            this.pagedit.ItemLinks.Add(this.BClear);
            this.pagedit.ItemLinks.Add(this.BDelete);
            this.pagedit.Name = "pagedit";
            this.pagedit.ShowCaptionButton = false;
            this.pagedit.Text = "Edit";
            // 
            // pageprint
            // 
            this.pageprint.AllowTextClipping = false;
            this.pageprint.ItemLinks.Add(this.BPrint);
            this.pageprint.ItemLinks.Add(this.coptionsbutton4);
            this.pageprint.Name = "pageprint";
            this.pageprint.ShowCaptionButton = false;
            this.pageprint.Text = "Print";
            // 
            // pagemoreoptions
            // 
            this.pagemoreoptions.AllowTextClipping = false;
            this.pagemoreoptions.ItemLinks.Add(this.BHold);
            this.pagemoreoptions.ItemLinks.Add(this.BHoldList);
            this.pagemoreoptions.ItemLinks.Add(this.BNotes);
            this.pagemoreoptions.ItemLinks.Add(this.coptionsbutton2);
            this.pagemoreoptions.ItemLinks.Add(this.coptionsbutton3);
            this.pagemoreoptions.Name = "pagemoreoptions";
            this.pagemoreoptions.ShowCaptionButton = false;
            this.pagemoreoptions.Text = "More Options";
            // 
            // pagenavigation
            // 
            this.pagenavigation.AllowTextClipping = false;
            this.pagenavigation.ItemLinks.Add(this.BMovePrev);
            this.pagenavigation.ItemLinks.Add(this.BMoveNext);
            this.pagenavigation.Name = "pagenavigation";
            this.pagenavigation.ShowCaptionButton = false;
            this.pagenavigation.Text = "Records Navigation";
            // 
            // pagecustome
            // 
            this.pagecustome.ItemLinks.Add(this.coptionsbutton5);
            this.pagecustome.ItemLinks.Add(this.coptionsbutton6);
            this.pagecustome.ItemLinks.Add(this.coptionsbutton7);
            this.pagecustome.Name = "pagecustome";
            this.pagecustome.ShowCaptionButton = false;
            this.pagecustome.Text = "ribbonPageGroup2";
            this.pagecustome.Visible = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.footerusername);
            this.ribbonStatusBar.ItemLinks.Add(this.footercdate, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem3);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2, true);
            this.ribbonStatusBar.ItemLinks.Add(this.footerediteduser);
            this.ribbonStatusBar.ItemLinks.Add(this.footeredate, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem4);
            this.ribbonStatusBar.ItemLinks.Add(this.txtloginname);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 571);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(870, 32);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // BaseRibbonForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 603);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseRibbonForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pagesave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pagedit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageprint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pagenavigation;
        private DevExpress.XtraBars.BarButtonItem BSave;
        private DevExpress.XtraBars.BarButtonItem BSaveandClose;
        private DevExpress.XtraBars.BarButtonItem BSaveandNew;
        private DevExpress.XtraBars.BarButtonItem BDelete;
        private DevExpress.XtraBars.BarButtonItem BClear;
        private DevExpress.XtraBars.BarButtonItem BMovePrev;
        private DevExpress.XtraBars.BarButtonItem BMoveNext;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem BNotes;
        private DevExpress.XtraBars.BarButtonItem BHold;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pagemoreoptions;
        private DevExpress.XtraBars.BarButtonItem BHoldList;
        private DevExpress.XtraBars.BarButtonItem coptionsbutton2;
        private DevExpress.XtraBars.BarButtonItem coptionsbutton3;
        private DevExpress.XtraBars.BarButtonItem coptionsbutton4;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pagecustome;
        private DevExpress.XtraBars.BarButtonItem coptionsbutton5;
        private DevExpress.XtraBars.BarButtonItem coptionsbutton6;
        private DevExpress.XtraBars.BarButtonItem coptionsbutton7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem footerusername;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem BNew;
        protected DevExpress.XtraBars.BarButtonItem BPrint;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem footerediteduser;
        private DevExpress.XtraBars.BarStaticItem footercdate;
        private DevExpress.XtraBars.BarStaticItem footeredate;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarStaticItem txtloginname;
    }
}