using System;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptInventoryTransfer : XtraForm
    {
        public RptInventoryTransfer()
        {
            InitializeComponent();

        }

        private void LookuptoStore_EditValueChanged(object sender, EventArgs e)
        {
            var dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEdit1.EditValue = dt;
            dateEdit2.EditValue = dt.AddMonths(1).AddDays(-1);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void RptInventoryTransfer_Load(object sender, EventArgs e)
        {
            LookuptoStore.Properties.DataSource = ClsGetData.GetAllSalesStore();

            var dsW = ClsGetData.GetStoreList();
           // LookuptoStore.Properties.DataSource = dsW;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var cl = new GridPrintingClass();
            cl.Heading1 = Utils.Companyname;
            cl.Heading2 = "Stock Transfer to " + LookuptoStore.Text + "Date From :" +
                          dateEdit1.DateTime.ToString("dd-MM-yyyy") + " To " + dateEdit2.DateTime.ToString("dd-MM-yyyy");
            cl.DoPrint(gridControl1);
        }
    }
}