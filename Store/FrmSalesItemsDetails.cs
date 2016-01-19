using System;
using DevExpress.XtraEditors;
using Store.Reports;

namespace Store
{
    public partial class FrmSalesItemsDetails : XtraForm
    {
        public string Promationname;
        public string strcnme;

        public FrmSalesItemsDetails()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
             var c = new GridPrintingClass
            {
                Heading1 = strcnme,
                Heading2 = "Sales Target item detail Report "
            };
            c.DoPrint(gridControl1);
        }

        private void FrmSalesItemsDetails_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadDetails(string commid, string itemno, int empid, bool useconstr = false, string newconstr = "p")
        {
          
            var ds = new BLReports().GetSalesTargetDetails(commid, itemno,empid,useconstr , newconstr);
            gridControl1.DataSource = ds;

        }
    }
}