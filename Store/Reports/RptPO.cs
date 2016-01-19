using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace Store.Reports
{
    public partial class RptPO : XtraReport
    {
        public RptPO()
        {
            InitializeComponent();
        }

        private void xrLabel4_BeforePrint(object sender, PrintEventArgs e)
        {

        }
        public string Company
        {
            set { labelcompany.Text = value; }
        }
    }
}
