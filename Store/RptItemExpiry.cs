using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.Reports;
using VIRETAILDAL.COMMON;

namespace Store
{
    public partial class RptItemExpiry : XtraForm
    {
        public RptItemExpiry()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null)
            {
                XtraMessageBox.Show("Please check the dates", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var dt = new DateTime(dateEdit1.DateTime.Year, dateEdit1.DateTime.Month, 1);
            itemWiseExpiryReportBindingSource.DataSource = new BLReports().ItemWiseExpiryReport(dt);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
            {
                XtraMessageBox.Show("No data found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var bl = new GridPrintingClass();
            bl.Heading1 = Utils.Companyname;
            bl.Heading2 = "Expiry Report On : " + dateEdit1.DateTime.ToString("dd-MM-yyyy")   + " ";
            bl.DoPrint(gridControl1);
        }

        private void RptItemExpiry_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Today;
            var dt = new DateTime(dateEdit1.DateTime.Year, dateEdit1.DateTime.Month, 1);
            itemWiseExpiryReportBindingSource.DataSource = new BLReports().ItemWiseExpiryReport(dt);
        }
    }
}