using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.DALCOMMON;

namespace Store
{
    public partial class RptPurchase : XtraForm
    {
        public bool RptType = false;
        private string _rptheading1;
        public RptPurchase()
        {
            InitializeComponent();
        }
        public string Heding
        {
            set { Text = value; }
        }
        private void RptPurchase_Load(object sender, EventArgs e)
        {
            LookupSupplier.Properties.DataSource = ClsGetData.GetSupplier();
            dateEdit1.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month , 1);
            dateEdit2.DateTime = DateTime.Now;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string supid = string.Empty;
            var bs = new BindingSource();
            var ds = new DataTable();
            if(LookupSupplier.EditValue!=null)
            {
                supid = LookupSupplier.EditValue.ToString();
            }
            if(RptType)
            {
                if (!string.IsNullOrEmpty(supid))
                {
                    ds = ReportsDataManager.PurchasingRptBySup(supid, dateEdit1.DateTime,
                                                                                     dateEdit2.DateTime);
                    _rptheading1 = " Supplier name :" + LookupSupplier.Text;
                }
                else
                {
                    ds = ReportsDataManager.PurchasingRptByInvDate(dateEdit1.DateTime,
                                                                                         dateEdit2.DateTime);
                   
                    
                }
                colPURINVID.FieldName = "PURINVID";
            }
            else
            {
                if (!string.IsNullOrEmpty(supid))
                {
                    ds = ReportsDataManager.ReturnPurchasingRptBySup(supid, dateEdit1.DateTime,
                                                                                                  dateEdit2.DateTime);
                    _rptheading1 = " Supplier name :" + LookupSupplier.Text;
                }
                else
                {
                    ds = ReportsDataManager.ReturnPurchasingRptByDate(dateEdit1.DateTime,
                                                                                            dateEdit2.DateTime);
                 
                }
                colPURINVID.FieldName = "RETURNID";
            }
            bs.DataSource = ds;
            gridControl1.DataSource = bs;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var tranid = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if(RptType)
                {
                    var f = new NewPurInv {Purid = tranid["PURINVID"].ToString()};
                    f.Show();
                    f.DoView();
                }
                else
                {
                    var f = new NewPurReturn { Purid = tranid["RETURNID"].ToString() };
                    f.Show();
                    f.DoView();
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0) return;
            
            string heading1 = string.Empty;
            heading1 = RptType ? "Purchase Invoice Report" : "Purchase Return Report";
            _rptheading1 += " From Date : " + dateEdit1.DateTime.ToShortDateString() + "  To Date : " + dateEdit2.DateTime.ToShortDateString() ;
            var bl = new GridPrintingClass { Heading1 = heading1, Heading2 = _rptheading1 };
            bl.DoPrint(gridControl1);
        }
    }
}