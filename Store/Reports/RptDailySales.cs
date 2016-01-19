using System;
using System.Globalization;
using DevExpress.XtraReports.UI;
using VIRETAILDAL.COMMON;

namespace Store.Reports
{
    public partial class RptDailySales : XtraReport
    {
        public RptDailySales()
        {
            InitializeComponent();
            xrLabel1.Text = Utils.Companyname;
        }
        public DateTime closedate
        {
            set { lblclosedate.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

    }
}
