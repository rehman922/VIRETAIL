using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptMultiPrice : XtraForm
    {
        public RptMultiPrice()
        {
            InitializeComponent();
        }

        private void RptMultiPrice_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ClsGetData.GetMultiplePrice();

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                var cl = new GridPrintingClass();
                cl.Heading1 = Utils.Companyname;
                cl.Heading2 = "Multiple Price Items List " ;
                cl.DoPrint(gridControl1);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}