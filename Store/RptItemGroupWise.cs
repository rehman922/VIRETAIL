using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptItemGroupWise : XtraForm
    {
        public RptItemGroupWise()
        {
            InitializeComponent();
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
             if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
                {
                    XtraMessageBox.Show("Please check the period", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            if(lookUpEdit1.EditValue!=null)
            {
                gridControl1.DataSource =
                    ClsGetData.GetDataByItemGroup(int.Parse(lookUpEdit1.EditValue.ToString()), dateEdit1.DateTime,
                                                         dateEdit2.DateTime);
            }
            else
            {
               gridControl1.DataSource =ClsGetData.GetItemGroupAll(dateEdit1.DateTime,dateEdit2.DateTime);
            }
        }
        private void RptItemTypeWise_Load(object sender, EventArgs e)
        {
            iTEMGROUPBindingSource.DataSource = ClsGetData.GetItemGroup();
            var dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEdit1.EditValue = dt;
            dateEdit2.EditValue = dt.AddMonths(1).AddDays(-1);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                var cl = new GridPrintingClass();
                cl.Heading1 = Utils.Companyname;
                cl.Heading2 = "Item Group Wise Purchase Report from " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " to " + dateEdit2.DateTime.ToString("dd-MM-yyyy");

                cl.DoPrint(gridControl1);
            }
        }
    }
}