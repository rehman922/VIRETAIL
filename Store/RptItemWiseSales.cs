using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.Reports;
using VIRETAILDAL.COMMON;

namespace Store
{
    public partial class RptItemWiseSales : XtraForm
    {
        public RptItemWiseSales()
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

            itemWiseSalesSummaryNewBindingSource.DataSource = new BLReports().ItemWiseSalesSummaryData(dateEdit1.DateTime, dateEdit2.DateTime) ;
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
            bl.Heading2 = "Item Wise Sales Report From : " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " To : " + dateEdit2.DateTime.ToString("dd-MM-yyyy") + " ";
            bl.DoPrint(gridControl1);
        }
        private void RptItemWiseSales_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now.Date;
            dateEdit2.DateTime = DateTime.Now.Date;
            itemWiseSalesSummaryNewBindingSource.DataSource   = new BLReports().ItemWiseSalesSummaryData(dateEdit1.DateTime, dateEdit2.DateTime);
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {  }
        public void ShowData(string flt)
        {
            itemWiseSalesSummaryNewBindingSource.Filter = "GROUPNAME ='" + flt +"'";
        } 
    }
}
