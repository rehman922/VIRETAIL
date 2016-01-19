using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace BaseClasses
{
    public partial class BaseRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public delegate void OnRibbonItemClick(object sender, ItemClickEventArgs e);
        public event OnRibbonItemClick ItemClick;
        protected void OnButtonClick(object sender, ItemClickEventArgs e)
        {
            if (ItemClick != null)
            {
                ItemClick(sender, e);
            }
        }
        public BaseRibbonForm()
        {
            InitializeComponent();
           
        }
        public BarItemVisibility SaveButtonVisibility
        {
            set { BSave.Visibility = value; }
        }
        public BarItemVisibility SaveandcloseButtonVisibility
        {
            set { BSaveandClose.Visibility = value; }
        }
        public BarItemVisibility SaveandNewButtonVisibility
        {
            set { BSaveandNew.Visibility = value; }
        }
        public BarItemVisibility ClearButtonVisibility
        {
            set { BClear.Visibility = value; }
        }
        public BarItemVisibility DeleteButtonVisibility
        {
            set { BDelete.Visibility = value; }
        }
        public BarItemVisibility HoldButtonVisibility
        {
            set { BHold.Visibility = value; }
        }
        public BarItemVisibility NoteButtonVisibility
        {
            set { BNotes.Visibility = value; }
        }
        public BarItemVisibility MovePrevButtonVisibility
        {
            set { BMovePrev.Visibility = value; }
        }
        public BarItemVisibility MoveNextButtonVisibility
        {
            set { BMoveNext.Visibility = value; }
        }

        public string Loginname
        {
            set { txtloginname.Caption = value; }
        }
        public string Ribbonname
        {
            set { ribbonPage1.Text = value; }
        }
        public bool SaveButtonEnable
        {
           set{BSave.Enabled = value;}
        }
        public bool SaveandNewButtonEnable
        {
            set { BSaveandNew.Enabled = value; }
        }
        public bool SaveandcloseButtonEnable
        {
            set { BSaveandClose.Enabled = value; }
        }
        public bool RibbonSaveEnable
        {
            set
            {
                SaveButtonEnable = value;
                SaveandNewButtonEnable = value;
                SaveandcloseButtonEnable = value;
            }
        }
        public bool MovePrevEnable
        {
            set { BMovePrev.Enabled = value; }
        }
        public bool MoveNextEnable
        {
            set { BMoveNext.Enabled = value; }
        }

        public bool RibbonPageMoreOptionsVisible
        {
            set { pagemoreoptions.Visible = value; }
        }
        public bool RibbonPageEditVisible
        {
            set { pagedit.Visible = value; }
        }
        public bool RibbonPrintVisible
        {
            set { pageprint.Visible = value; }
        }
        public bool RibbonNavigationVisble
        {
            set { pagenavigation.Visible = value; }
        }
        public bool RibbonPageEdit
        {
            set { pagedit.Visible = value; }
        }
        public string Username
        {
            set { footerusername.Caption = value; }
        }
        #region optionbuttons
        public BarItemVisibility Coptionbutton1Visibility
        {
            set { BHoldList.Visibility = value; }
        }
        public Image Coptionbutton1Image
        {
            set { BHoldList.LargeGlyph = value; }
        }
        public string Coptionbutton1Caption
        {
            set { BHoldList.Caption = value; }
        }
        public BarItemVisibility Coptionbutton2Visibility
        {
            set { coptionsbutton2.Visibility = value; }
        }
        public Image Coptionbutton2Image
        {
            set { coptionsbutton2.LargeGlyph = value; }
        }
        public string Coptionbutton2Caption
        {
            set { coptionsbutton2.Caption = value; }
        }
        public BarItemVisibility Coptionbutton3Visibility
        {
            set { coptionsbutton3.Visibility = value; }
        }
        public Image Coptionbutton3Image
        {
            set { coptionsbutton3.LargeGlyph = value; }
        }
        public string Coptionbutton3Caption
        {
            set { coptionsbutton3.Caption = value; }
        }
        public BarItemVisibility Coptionbutton4Visibility
        {
            set { coptionsbutton4.Visibility = value; }
        }
        public Image Coptionbutton4Image
        {
            set { coptionsbutton4.LargeGlyph = value; }
        }
        public string Coptionbutton4Caption
        {
            set { coptionsbutton4.Caption = value; }
        }
        public BarItemVisibility Coptionbutton5Visibility
        {
            set { coptionsbutton5.Visibility = value; }
        }
        public Image Coptionbutton5Image
        {
            set { coptionsbutton5.LargeGlyph = value; }
        }
        public string Coptionbutton5Caption
        {
            set { coptionsbutton5.Caption = value; }
        }
        public BarItemVisibility Coptionbutton6Visibility
        {
            set { coptionsbutton6.Visibility = value; }
        }
        public Image Coptionbutton6Image
        {
            set { coptionsbutton6.LargeGlyph = value; }
        }
        public string Coptionbutton6Caption
        {
            set { coptionsbutton6.Caption = value; }
        }
        public BarItemVisibility Coptionbutton7Visibility
        {
            set { coptionsbutton7.Visibility = value; }
        }
        public Image Coptionbutton7Image
        {
            set { coptionsbutton7.LargeGlyph = value; }
        }
        public string Coptionbutton7Caption
        {
            set { coptionsbutton7.Caption = value; }
        }
        public bool   Pagecustome
        {
            set { pagecustome.Visible = value; }
        }



        #endregion
        
        

    }
}