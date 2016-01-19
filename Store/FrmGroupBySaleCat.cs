using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.Reports;
using VIRETAILDAL.COMMON;

namespace Store
{
    public partial class RptGroupBySaleCat : XtraForm
    {
        public RptGroupBySaleCat()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
            {
                XtraMessageBox.Show("Please check the dates", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            salesByITEMGROUPBindingSource.DataSource = new BLReports().SalesByItemGroup(dateEdit1.DateTime, dateEdit2.DateTime);
        }

        private void RptGroupBySaleCat_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now.Date;
            dateEdit2.DateTime = DateTime.Now.Date;
            salesByITEMGROUPBindingSource.DataSource = new BLReports().SalesByItemGroup(dateEdit1.DateTime, dateEdit2.DateTime);

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
            bl.Heading2 = "Category wise Sales Report From : " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " To : " + dateEdit2.DateTime.ToString("dd-MM-yyyy") + " ";
            bl.DoPrint(gridControl1);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var frm = new RptItemWiseSales();
                frm.ShowData(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,colGROUPNAME).ToString());
                frm.Show();
            }
        }
    }
}