using System;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptCancelSale : XtraForm
    {
        public RptCancelSale()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var c = new GridPrintingClass
            {
                Heading1 = Utils.Companyname,
                Heading2 = "Sales Cancel / Delete Report From " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + "  To " + dateEdit2.DateTime.ToString("dd-MM-yyyy") 
            };
            c.DoPrint(gridControl1);
        }
        private void RptCancelSale_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Now;
            dateEdit2.EditValue = DateTime.Now;
            uSERINFOBindingSource.DataSource = ClsGetData.GetUserInfo();
            LoadGrid();
        }
        void LoadGrid()
        {
            var bl = new BLSales();
            gridControl1.DataSource = bl.GetSalesDeletedItems(dateEdit1.DateTime.Date, dateEdit2.DateTime.Date);
        }
    }
}