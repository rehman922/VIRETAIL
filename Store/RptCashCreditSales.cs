using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptCashCreditSales : XtraForm
    {
        string[] connew = Utils.Connectionstring.Split(';');
        string strcnme = Utils.Companyname;
        public RptCashCreditSales()
        {
            InitializeComponent();
        }

         private int _rtype = 1;
        //public string ReportType
        //{
        //    set { Text = value; }
        //}
        public void LoadReport(int rtype)
        {
            _rtype = rtype;
            if(rtype==1)
            {
                Text = "Cash Sale Report";
            }
            if(rtype==2)
            {
                Text = "Credit Sale Report";
            }
            if (rtype == 3)
            {
                Text = "Insurance Sale Report";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
            {
                XtraMessageBox.Show("Please check the dates", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string newconstr = string.Empty;
            bool useconstr = false;
            if (lookUpEdit3.EditValue != null)
            {
                newconstr = connew[0] + ";" + "Initial Catalog =" + lookUpEdit3.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                useconstr = true;
            }

            if(_rtype==1)
            {
                var bl = new BLReports().GetCashSalesDataTable(dateEdit1.DateTime.Date, dateEdit2.DateTime.Date, useconstr, newconstr);
                colCUSTNAME.Visible = false;
                gridControl1.DataSource = bl;
            }
            if (_rtype == 2)
            {
                var bl = new BLReports().GetCreditSalesDataTable(dateEdit1.DateTime.Date, dateEdit2.DateTime.Date);
                colCUSTNAME.Visible = true;
                gridControl1.DataSource = bl;
            }
            if (_rtype == 3)
            {
                var bl = new BLReports().GetInsuranceSalesDataTable(dateEdit1.DateTime.Date, dateEdit2.DateTime.Date);
                colCUSTNAME.Visible = true;
                gridControl1.DataSource = bl;
            }

        }

        private void RptCashCreditSales_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
            dateEdit2.DateTime = DateTime.Now;
            if (Utils.Company == "01")
            {
                sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames();
                lblstore.Visible = true;
                lookUpEdit3.Visible = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

                if (lookUpEdit3.EditValue != null)
                {
                    strcnme = lookUpEdit3.GetColumnValue("STORENAME").ToString();
                }
                var cl = new GridPrintingClass {Heading1 = strcnme, Heading2 = Text};
              cl.DoPrint(gridControl1);
            
        }
    }
}