using System;
using System.Data;
using DevExpress.XtraEditors;
using Store.Reports;
using VIRETAILDAL.COMMON;

namespace Store
{
    public partial class RptFrmItemMoveDrillDown : XtraForm
    {
        public RptFrmItemMoveDrillDown()
        {
            InitializeComponent();
        }

        private void RptFrmItemMoveDrillDown_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(DataTable dt,DateTime d1 , DateTime d2)
        {
            getItemMoveDetailsBindingSource.DataSource = dt;
            dateEdit1.DateTime = d1;
            dateEdit2.DateTime = d2;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ( gridView1.DataRowCount == 0)
                return;
            var bl = new GridPrintingClass
            {
                Heading1 = Utils.Companyname,
                Heading2 =   
                    "Item Movement Report details From : " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " To : " +
                    dateEdit2.DateTime.ToString("dd-MM-yyyy") + ""
            };
            bl.DoPrint(gridControl1);
        }
    }
}
