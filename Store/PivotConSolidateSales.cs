using System;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;

namespace Store
{
    public partial class PivotConSolidateSales : XtraForm
    {
        public PivotConSolidateSales()
        {
            InitializeComponent();
        }

        private void PivotConSolidateSales_Load(object sender, EventArgs e)
         {
            dateEdit1.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEdit2.EditValue = DateTime.Now;
            LoadPivotGrid(dateEdit1.DateTime, dateEdit2.DateTime);
         }
        public void LoadPivotGrid(DateTime d1, DateTime d2)
        {
            consolidatePivotDailySalesBindingSource.DataSource = ClsGetData.ConsolidateLoadPivotGrid(d1, d2);
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
                return;
            LoadPivotGrid(dateEdit1.DateTime, dateEdit2.DateTime);
        }

      
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var cl = new GridPrintingClass();
            //dd-MMM-yy
             
            cl.Heading1 = "Consolidated Sales Report From : " + dateEdit1.DateTime.ToString("dd-MMM-yy") + " To: " + dateEdit2.DateTime.ToString("dd-MMM-yy") + "";
            cl.DoPivoitPrint(pivotGridControl1);
        }
    }
}