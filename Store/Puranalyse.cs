using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;

namespace Store
{
    public partial class Puranalyse : XtraForm
    {
        public Puranalyse()
        {
            InitializeComponent();
        }
        public Puranalyse(string itemid, string itemname):this()
        {
            Text = itemname;
            purchaseAnalyseBindingSource.DataSource = ClsGetData.GetPurchaseAnalyseByItem(itemid);
 
             if (purchaseAnalyseBindingSource.Count == 0)
                 panel1.Visible = true;
             else
                panel1.Visible = false;
        }

        private void Puranalyse_Resize(object sender, EventArgs e)
        {
            panel1.Width = gridControl1.Width;
            label1.Left = (panel1.Width - label1.Width)/2;
        }

        private void Puranalyse_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Escape)
           {
               Close();
               
           }
        }
    }
}