using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptSummarySalesTarget : XtraForm
    {
        public bool _usemultistore = false;
        string[] connew = Utils.Connectionstring.Split(';');
        string strcnme = Utils.Companyname;

        public RptSummarySalesTarget()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
            {
                XtraMessageBox.Show("Please check the dates", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string othercon = string.Empty;
 
                othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit3.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
               string stype = "A";
     //            WHEN 'C' THEN 'Credit' 
     //WHEN 'I' THEN 'Insurance' 
     //WHEN 'A' THEN 'Cash' 
            if (comboBox1.SelectedIndex == 1)
                stype = "C";
            if (comboBox1.SelectedIndex == 2)
                stype = "I";
              var ds = new BLReports().SalesTargetFrmDtToDate(dateEdit2.DateTime, dateEdit1.DateTime,
                  int.Parse(lookUpEdit2.EditValue.ToString()),
                 lookUpEdit2.GetColumnValue("EMPNO").ToString(), lookUpEdit2.Text + '-' +lookUpEdit2.GetColumnValue("EMPNO"),
                  stype, othercon);
                //var ds = new Reports.BLReports().GetSalestargetbyDate(lookUpEdit2.GetColumnValue("EMPNO").ToString(), int.Parse(lookUpEdit2.EditValue.ToString()),
                //        dateEdit2.DateTime,
                //        dateEdit1.DateTime, lookUpEdit2.Text, othercon);
                gridControl1.DataSource = ds;

        }
        private void RptSummarySalesTarget_Load(object sender, EventArgs e)
        {
            sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames();
            comboBox1.SelectedIndex = 0;
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            string othercon = string.Empty;
            bool useo = false;
            lookUpEdit2.Enabled = true;
            if (lookUpEdit3.EditValue != null)
            {
                othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit3.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                useo = true;
            }
            uSERINFOBindingSource.DataSource = ClsGetData.GetUserInfoCommission(useo, othercon);
            //USERINFO1
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lookUpEdit3.EditValue != null)
            {
                strcnme = lookUpEdit3.GetColumnValue("STORENAME").ToString();
            }

            var c = new GridPrintingClass
            {
                Heading1 = strcnme,
                Heading2 = "Sales Target Report Period " + "From :" + dateEdit2.DateTime.ToString("d") + "  To :"  + dateEdit1.DateTime.ToString("d")

            };
            c.DoPrint(gridControl1);
        }
    }
}