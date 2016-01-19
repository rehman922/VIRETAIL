using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.Reports;
using VIRETAILDAL.COMMON;

namespace Store
{
    public partial class RptItemReturn : XtraForm
    {
        public RptItemReturn()
        {
            InitializeComponent();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(dateEdit1.EditValue==null || dateEdit2.EditValue==null)
            {
                XtraMessageBox.Show("Please check the dates", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var bl = new BLReports().SalesReturnListData(dateEdit1.DateTime, dateEdit2.DateTime);
            gridControl1.DataSource = bl;
        }
        private void RptItemReturn_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Now;
            dateEdit2.EditValue = DateTime.Now;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(gridView1.DataRowCount==0)
            {
                XtraMessageBox.Show("No data found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var bl = new GridPrintingClass();
            bl.Heading1 = Utils.Companyname;
            bl.Heading2 = "Sales Return List From : " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " To : " + dateEdit2.DateTime.ToString("dd-MM-yyyy") + " ";
            bl.DoPrint(gridControl1);

        }
    }
}