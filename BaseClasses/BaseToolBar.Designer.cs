namespace BaseClasses
{
    partial class BaseToolBar
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
            this.barManager10 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BSave = new DevExpress.XtraBars.BarButtonItem();
            this.BSaveandClose = new DevExpress.XtraBars.BarButtonItem();
            this.BDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.BHold = new DevExpress.XtraBars.BarButtonItem();
            this.Bholdlist = new DevExpress.XtraBars.BarButtonItem();
            this.BNotes = new DevExpress.XtraBars.BarButtonItem();
            this.BMovePrev = new DevExpress.XtraBars.BarButtonItem();
            this.barrecordcount = new DevExpress.XtraBars.BarButtonItem();
            this.BMoveNext = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.loginuser = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.fcusername = new DevExpress.XtraBars.BarStaticItem();
            this.bareditedby = new DevExpress.XtraBars.BarStaticItem();
            this.cediteduser = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager10)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager10
            // 
            this.barManager10.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager10.DockControls.Add(this.barDockControlTop);
            this.barManager10.DockControls.Add(this.barDockControlBottom);
            this.barManager10.DockControls.Add(this.barDockControlLeft);
            this.barManager10.DockControls.Add(this.barDockControlRight);
            this.barManager10.Form = this;
            this.barManager10.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.BSave,
            this.BSaveandClose,
            this.BDelete,
            this.barButtonItem5,
            this.BHold,
            this.Bholdlist,
            this.BNotes,
            this.BMovePrev,
            this.barrecordcount,
            this.BMoveNext,
            this.barStaticItem1,
            this.loginuser,
            this.barStaticItem2,
            this.fcusername,
            this.bareditedby,
            this.cediteduser});
            this.barManager10.MainMenu = this.bar2;
            this.barManager10.MaxItemId = 17;
            this.barManager10.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BSaveandClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BHold, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Bholdlist, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BNotes, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.BMovePrev, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barrecordcount),
            new DevExpress.XtraBars.LinkPersistInfo(this.BMoveNext)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "&New";
            this.barButtonItem1.Glyph = global::BaseClasses.Properties.Resources.page_white_star16;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // BSave
            // 
            this.BSave.Caption = "&Save";
            this.BSave.Glyph = global::BaseClasses.Properties.Resources.save16N1;
            this.BSave.Id = 1;
            this.BSave.Name = "BSave";
            // 
            // BSaveandClose
            // 
            this.BSaveandClose.Caption = "Save && Close";
            this.BSaveandClose.Glyph = global::BaseClasses.Properties.Resources.saveandclose16N;
            this.BSaveandClose.Id = 2;
            this.BSaveandClose.Name = "BSaveandClose";
            // 
            // BDelete
            // 
            this.BDelete.Caption = "&Delete";
            this.BDelete.Glyph = global::BaseClasses.Properties.Resources.Delete16;
            this.BDelete.Id = 3;
            this.BDelete.Name = "BDelete";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "&Print";
            this.barButtonItem5.Glyph = global::BaseClasses.Properties.Resources.printer1;
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // BHold
            // 
            this.BHold.Caption = "&Hold";
            this.BHold.Glyph = global::BaseClasses.Properties.Resources.hold16;
            this.BHold.Id = 5;
            this.BHold.Name = "BHold";
            // 
            // Bholdlist
            // 
            this.Bholdlist.Caption = "Hold &List";
            this.Bholdlist.Glyph = global::BaseClasses.Properties.Resources.viewlist16;
            this.Bholdlist.Id = 6;
            this.Bholdlist.Name = "Bholdlist";
            // 
            // BNotes
            // 
            this.BNotes.Caption = "&Notes";
            this.BNotes.Glyph = global::BaseClasses.Properties.Resources.stickynote;
            this.BNotes.Id = 7;
            this.BNotes.Name = "BNotes";
            // 
            // BMovePrev
            // 
            this.BMovePrev.Caption = "barButtonItem9";
            this.BMovePrev.Glyph = global::BaseClasses.Properties.Resources.arrow16left;
            this.BMovePrev.Id = 8;
            this.BMovePrev.Name = "BMovePrev";
            // 
            // barrecordcount
            // 
            this.barrecordcount.Id = 9;
            this.barrecordcount.Name = "barrecordcount";
            // 
            // BMoveNext
            // 
            this.BMoveNext.Caption = "barButtonItem11";
            this.BMoveNext.Glyph = global::BaseClasses.Properties.Resources.arrow16right;
            this.BMoveNext.Id = 10;
            this.BMoveNext.Name = "BMoveNext";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barStaticItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.loginuser),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barStaticItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.fcusername),
            new DevExpress.XtraBars.LinkPersistInfo(this.bareditedby),
            new DevExpress.XtraBars.LinkPersistInfo(this.cediteduser)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "User :";
            this.barStaticItem1.Glyph = global::BaseClasses.Properties.Resources.user_suit;
            this.barStaticItem1.Id = 11;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // loginuser
            // 
            this.loginuser.Id = 12;
            this.loginuser.Name = "loginuser";
            this.loginuser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Caption = "Created By:";
            this.barStaticItem2.Glyph = global::BaseClasses.Properties.Resources.user_add;
            this.barStaticItem2.Id = 13;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // fcusername
            // 
            this.fcusername.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.fcusername.Id = 14;
            this.fcusername.Name = "fcusername";
            this.fcusername.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bareditedby
            // 
            this.bareditedby.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bareditedby.Caption = "Edited By :";
            this.bareditedby.Id = 15;
            this.bareditedby.Name = "bareditedby";
            this.bareditedby.TextAlignment = System.Drawing.StringAlignment.Near;
            this.bareditedby.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // cediteduser
            // 
            this.cediteduser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.cediteduser.Id = 16;
            this.cediteduser.Name = "cediteduser";
            this.cediteduser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(876, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 539);
            this.barDockControlBottom.Size = new System.Drawing.Size(876, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 515);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(876, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 515);
            // 
            // BaseToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 566);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseToolBar";
            this.Text = "ToolBar";
            ((System.ComponentModel.ISupportInitialize)(this.barManager10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarStaticItem footercuser;
        private DevExpress.XtraBars.BarManager barManager10;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BSave;
        private DevExpress.XtraBars.BarButtonItem BSaveandClose;
        private DevExpress.XtraBars.BarButtonItem BDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem BHold;
        private DevExpress.XtraBars.BarButtonItem Bholdlist;
        private DevExpress.XtraBars.BarButtonItem BNotes;
        private DevExpress.XtraBars.BarButtonItem BMovePrev;
        private DevExpress.XtraBars.BarButtonItem barrecordcount;
        private DevExpress.XtraBars.BarButtonItem BMoveNext;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem loginuser;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem fcusername;
        private DevExpress.XtraBars.BarStaticItem bareditedby;
        private DevExpress.XtraBars.BarStaticItem cediteduser;
    }
}