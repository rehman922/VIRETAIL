using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class PivotSales : XtraForm
    {
        string[] connew = Utils.Connectionstring.Split(';');
        public bool _usemultistore = false;

        public PivotSales()
        {
            InitializeComponent();
        }
        private void PivotSales_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dateEdit2.EditValue = DateTime.Now.Date;
            if (_usemultistore)
            {
                labelControl3.Visible = true;
                lookUpEdit1.Visible = true;
                simpleButton3.Visible = false;
                sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames(true);
            }
            else
            {
                LoadPivotGrid(dateEdit1.DateTime, dateEdit2.DateTime);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(dateEdit1.EditValue==null || dateEdit2.EditValue==null)
                return;
            string othercon = string.Empty;
            bool useo = false;
            if (lookUpEdit1.EditValue != null)
            {
               othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit1.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
               useo = true;
            }
           // LoadInMainWindow(0, tranid, useo, othercon);

            LoadPivotGrid(dateEdit1.DateTime, dateEdit2.DateTime,useo,othercon);
            simpleButton1.Enabled = true;
        }
        public void LoadPivotGrid(DateTime d1,DateTime d2,bool userother=false,string cnstr="x")
        {
            pivotDailySalesBindingSource.DataSource =  ClsGetData.LoadPivotGrid(d1,d2, userother,cnstr); 
        }
        private void pivotGridControl1_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
        {}
        private void pivotGridControl1_CustomCellValue(object sender, PivotCellValueEventArgs e)
        {
            //if (fieldAMOUNT1.Equals(e.DataField))
            //{
            //    if (e.ColumnCustomTotal == null && e.RowCustomTotal == null) return;

            //    // Obtains a list of summary values against which
            //    // the Custom Total will be calculated.
            //    ArrayList summaryValues = GetSummaryValues(e);

            //    // Obtains the name of the Custom Total that should be calculated.
            //    string customTotalName = GetCustomTotalName(e);

            //    // Calculates the Custom Total value and assigns it to the Value event parameter.
            //    e.Value = GetCustomTotalValue(summaryValues, customTotalName);


                //PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
                //decimal summary = 0;
                //decimal dval = 0;
                //decimal cval = 0;
                //for (int i = 0; i < ds.RowCount; i++)
                //{
                //    string name = Convert.ToString(ds[i][fieldCashName1]);
                //    decimal value = Convert.ToDecimal(ds[i][fieldAMOUNT1]);
                //    if (name.Substring(0, name.Length) == "1" || name.Substring(0, name.Length) == "2" || name.Substring(0, name.Length) == "3" || name.Substring(0, name.Length) == "5")
                //        dval += value;
                //    else
                //        cval += value;
                //}
                //if (cval == 0)
                //    e.Value = -1 * dval;
            //}
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var cl = new GridPrintingClass();
            //dd-MMM-yy
            if (lookUpEdit1.EditValue != null)
            {
                cl.Heading1 = lookUpEdit1.GetColumnValue("STORENAME").ToString();
            }
            else
            cl.Heading1 = Utils.Companyname;
            cl.Heading2 = "Sales Report From : " + dateEdit1.DateTime.ToString("dd-MMM-yy") + " To: " + dateEdit2.DateTime.ToString("dd-MMM-yy") + "";
            cl.DoPivoitPrint(pivotGridControl1);
           // pivotGridControl1.ShowPrintPreview();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                PivotDrillDownDataSource ds;
                ds = pivotGridControl1.Cells.GetFocusedCellInfo().CreateDrillDownDataSource();
                if (!string.IsNullOrEmpty(ds[0][fieldCLOSEDATE1].ToString()))
                {
                    var d1 = Convert.ToDateTime(ds[0][fieldCLOSEDATE1]);
                    var f = new RptDailySalesReport();
                    f.aMonth = d1.ToString();
                    f.LoadDailyReport(d1, d1);
                    f.CreateReport();
                }
                else
                {
                    XtraMessageBox.Show("Closed date not found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
        }
    }
}