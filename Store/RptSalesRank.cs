using System;
using DevExpress.XtraEditors;
using Store.Reports;

namespace Store
{
    public partial class RptSalesRank : XtraForm
    {
        public RptSalesRank()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            salesRankBindingSource.DataSource = new BLReports().SalesRank(dateEdit1.DateTime, dateEdit2.DateTime, int.Parse(spinEdit1.EditValue.ToString()));
        }
        private void RptSalesRank_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now.Date;
            dateEdit2.DateTime = DateTime.Now.Date;
            spinEdit1.EditValue = 3;
            salesRankBindingSource.DataSource = new BLReports().SalesRank(dateEdit1.DateTime, dateEdit2.DateTime,int.Parse(spinEdit1.EditValue.ToString()));
        }
    }
}