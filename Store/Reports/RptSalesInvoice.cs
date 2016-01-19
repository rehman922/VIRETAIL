using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace Store.Reports
{
    public partial class RptSalesInvoice : XtraReport
    {
        public RptSalesInvoice()
        {
            InitializeComponent();
        }
        public string Company
        {
            set { labelcompany.Text = value; }
        }
        public string patshare
        {
            set { lbldiscount.Text = value; }
        }
        public string NetAmount
        {
            set { lblnetamt.Text = value; }
        }

        public string Customername { get; set; }
        public bool ScreenPrint
        {
            set
            {
                xrLine3.Visible = value;
                labelcompany.BackColor = Color.DarkGray;
            }
        }

        private void xrLabel15_BeforePrint(object sender, PrintEventArgs e)
        {
            if(!string.IsNullOrEmpty(Customername))
                xrLabel15.Text = Customername;

        }
    }
}
