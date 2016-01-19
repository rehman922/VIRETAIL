using DevExpress.XtraReports.UI;

namespace Store.Reports
{
    public partial class RptItemMove : XtraReport
    {
        public RptItemMove()
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
    }
}
