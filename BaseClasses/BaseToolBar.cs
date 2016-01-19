using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace BaseClasses
{
    public partial class BaseToolBar : DevExpress.XtraEditors.XtraForm
    {
        public delegate void OnItemClick(object sender, ToolStripItemClickedEventArgs e);
        public event OnItemClick ToolBarClick;
        public BaseToolBar()
        {
            InitializeComponent();
        }
        public bool SaveButtonEnable
        {
           set{BSave.Enabled = value;}
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
        public BarItemVisibility DeleteButtonVisibility
        {
            set { BDelete.Visibility= value; }
        }
        public bool HoldButtonVisibility
        {
            set { BHold.Enabled = value; }
        }
        public bool HoldGroupVisible
        {
            set 
            { 
              BHold.Enabled = value;
              Bholdlist.Enabled = value;
            }
        }
        protected void ToolStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (ToolBarClick != null)
            {
                ToolBarClick(sender, e);
                
            }
        }
        public string RecordCount
        {
            set { barrecordcount.Caption = value; }
        }
        public string FooterLogingUser
        {
            set { loginuser.Caption = value; }
        }

        public BarItemVisibility BarEditedByVisible
        {
            set
            {
                bareditedby.Visibility = value;
                cediteduser.Visibility = value;
            }
        }
        public string FooterEditedBy
        {
            set { cediteduser.Caption = value; }
        }
        public string FooterCreatedBy
        {
            set { fcusername.Caption = value; }
        }
    












    }
}