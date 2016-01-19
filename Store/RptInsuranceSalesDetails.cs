using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptInsuranceSalesDetails : XtraForm
    {
        public bool _usemultistore = false;
        string[] connew = Utils.Connectionstring.Split(';');
        string strcnme = Utils.Companyname;
        public bool _usesecondgrid = false;
        public RptInsuranceSalesDetails()
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
            LoadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //if (gridView1.DataRowCount == 0)
            //{
            //    XtraMessageBox.Show("No data found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            if (lookUpEdit3.EditValue != null)
            {
                strcnme = lookUpEdit3.GetColumnValue("STORENAME").ToString();
            }

            string h2 = _usesecondgrid ? "Insurance Sales By Item wise :" : "Part Payment List From : ";
            var bl = new GridPrintingClass
            {
                Heading1 = strcnme,
                Heading2 = h2  
                      + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " To : " +
                    dateEdit2.DateTime.ToString("dd-MM-yyyy") + " "
            };
            if (_usesecondgrid)
            {
                bl.DoPrint(gridControl2,true);
            }
            else
            {
             bl.DoPrint(gridControl1);
            }
        }
        private void RptInsuranceSalesDetails_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
            dateEdit2.DateTime = DateTime.Now;
            if (Utils.Company == "01")
            {
                sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames();
                lblstore.Visible = true;
                lookUpEdit3.Visible = true;
            }
            if (_usesecondgrid)
            {
                gridControl1.Visible = false;
                gridControl2.Visible = true;
            }
            else
            {
                gridControl1.Visible = true;
                gridControl2.Visible = false;
            }
            LoadData();
        }

        void LoadData()
        {

            string othercon = string.Empty;
            bool useo = false;
            if (lookUpEdit3.EditValue != null)
            {
                othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit3.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                useo = true;
            }
            //
            if (_usesecondgrid)
            {
                var bl = new BLReports().InsuranceSalesByItemWise(dateEdit1.DateTime.Date, dateEdit2.DateTime.Date, useo, othercon);
                insuranceSalesByItemWiseBindingSource.DataSource = bl; 
            }
            else
            {
                var bl = new BLReports().InsuranceSalesDetails(dateEdit1.DateTime.Date, dateEdit2.DateTime.Date, useo, othercon);
                gridControl1.DataSource = bl; 
            }
          
        }
    }
}
