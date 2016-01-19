using System;
using DevExpress.XtraReports.UI;

namespace Store.Reports
{
    public partial class PurchaseRpt : XtraReport
    {
        public PurchaseRpt()
        {
            InitializeComponent();
            
        }
        public string Company
        {
            set { labelcompany.Text = value; }
        }
        public string Header
        {
            set { labelrtphead.Text = value; }
        }
        public bool DueDays
        {
            set 
            {   xrLabel8.Visible = value;
                xrLabel9.Visible = value;
            }
        }
        public string Docno
        {
            set { docno.Text = value; }
        }
        public decimal TotalCost
        {
            set { lblcost.Text = value.ToString("#,##0.00"); }
        }
        public  decimal TotalSale
        {
            set { lblsale.Text = value.ToString("#,##0.00"); }
        }
        public decimal Profit
        {
            set { lblprofit.Text = value.ToString("#,##0.00"); }
            //{0:#.00}
        }
        public decimal ProfitPer
        {
            set { lblprofitper.Text = value.ToString("#,##0.00"); }
            //{0:#.00}
        }
        private void xrLabel31_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void xrCheckBox1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
             
               
       
        }
    }
}
