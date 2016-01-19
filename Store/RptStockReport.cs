using System;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptStockReport : XtraForm
    {
        private string _heading = "Stock Report as of ";
        public RptStockReport()
        {
            InitializeComponent();
        }
        private void RptStockReportResize(object sender, EventArgs e)
        {
            progressPanel1.Left = (Width - progressPanel1.Width)/2;
        }
        public  void LoadStockAsOf()
        {
            stockReportAsOfBindingSource.DataSource = ClsGetData.GetStockAsOf();
            stockReportAsOfBindingSource.Filter = "Stock <> 0 ";
            progressPanel1.Visible = false;
        }
        public void LoadNegativeStockAsOf()
        {
           // iTEMGROUPBindingSource.DataSource = COMMON.ClsGetData.GetItemGroup();

            var ds = ClsGetData.NegativeStockAsOf();
            gridControl1.ResetBindings();
            gridControl1.DataSource = ds;
           // stockReportAsOfBindingSource.DataSource= ds.Select("Stock < 0");
            //stockReportAsOfBindingSource.DataSource = COMMON.ClsGetData.GetStockAsOf();
           // stockReportAsOfBindingSource.Filter = "Stock < 0 ";
            _heading = "Negative Stock Report as of  ";
            progressPanel1.Visible = false;
        }
        private void SimpleButton3Click(object sender, EventArgs e)
        {
            var c = new GridPrintingClass{
                            Heading1 = Utils.Companyname,
                            Heading2 = _heading + DateTime.Now.ToShortDateString()
                        };
            c.DoPrint(gridControl1);
        }
        private void LookupSupplier_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (Lookupwarehouse.EditValue != null)
            {
                stockReportAsOfBindingSource.DataSource = ClsGetData.GetStockAsOf(Lookupwarehouse.EditValue.ToString());
            }
            else
            {
                stockReportAsOfBindingSource.DataSource = ClsGetData.GetStockAsOf();
            }
        
            if(lookUpEdit1.EditValue!=null)
            stockReportAsOfBindingSource.Filter = " [Group name] = '" + lookUpEdit1.SelectedText + "'";
            btnshow.Visible = false;
            btnshowall.Visible = true;
        }
        private void RptStockReport_Load(object sender, EventArgs e)
        {
            iTEMGROUPBindingSource.DataSource =  ClsGetData.GetItemGroup();
            if (Utils.Company == "00")
            {
                Lookupwarehouse.Visible = true;
                labelControl1.Visible = true;
                Lookupwarehouse.Properties.DataSource = ClsGetData.GetMyWareHouses();
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            stockReportAsOfBindingSource.Filter = "";

            btnshow.Visible = true;
            btnshowall.Visible = false;
        }
    }
}
