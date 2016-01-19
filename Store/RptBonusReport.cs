using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptBonusReport : XtraForm
    {
        public RptBonusReport()
        {
            InitializeComponent();
            //GetPurchaseBonus
            var dt= new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEdit1.EditValue = dt;
            dateEdit2.EditValue = dt.AddMonths(1).AddDays(-1);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
            {
                XtraMessageBox.Show("Please check the period", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            purchaseBonusBindingSource.DataSource = ClsGetData.GetPurchaseBonus(dateEdit1.DateTime, dateEdit2.DateTime);
            if(gridView1.DataRowCount == 0)
            {
               XtraMessageBox.Show("Data not availble for selected dates", "POS",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
          if(gridView1.DataRowCount > 0)
          {
              var cl = new GridPrintingClass();
              cl.Heading1 = Utils.Companyname;
              cl.Heading2 = "Bonus Report from " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " to " + dateEdit2.DateTime.ToString("dd-MM-yyyy");
              cl.DoPrint(gridControl1);
          }
        }
    }
}