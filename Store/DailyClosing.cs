using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.Reports;
using VIRETAILDAL.Masters;

namespace Store
{
    public partial class DailyClosing : XtraForm
    {
        public DailyClosing()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //var ds = new Reports.BLReports().GetDailySales(0m);

            //ds.Select("ctype=1");
            //foreach (DataRow d in ds.Rows)
            //{
            //    txtcash.EditValue = decimal.Parse(d["TOTAL"].ToString());
            //}
            //var d1 = new BusinessLogic.BLDailySales().GetLastClosing();
            //foreach (DataRow dr in d1.Rows)
            //{
            //    if (dr["CTYPE"].ToString() == "1")
            //    {
            //        txttotalcash.EditValue = decimal.Parse(dr["CVALUE"].ToString()) + decimal.Parse(txtcash.EditValue.ToString());
            //    }
            //}
            if (dateEdit2.EditValue != null)
            {
                if (dateEdit1.DateTime.Date < dateEdit2.DateTime.Date)
                {
                    XtraMessageBox.Show("Please check the closing date", "POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDateTime(dateEdit1.DateTime.Date) == Convert.ToDateTime(dateEdit2.DateTime.Date))
                {
                    XtraMessageBox.Show("Please check the closing date" + Environment.NewLine + "Sales already closed for the selected date" , "POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return; 
                }
                //  if(DateTime.Compare(dateEdit1.DateTime.Date,dateEdit2.DateTime.Date))
            }
            simpleButton1.Enabled = false;
            DoCloseSale();
            try
            {

                var cls = new PromotionPrice();
                cls.ResetThePromotionPrice(dateEdit1.DateTime.Date);
            }
            catch (Exception et)
            {
              //  XtraMessageBox.Show()
            }
            //Adjust the price change

            //
        }
        bool validateform()
        {
            bool retval = false;
            if (decimal.Parse(txtcashtrans.EditValue.ToString()) < 0)
            {
                XtraMessageBox.Show("Please check the transfer amount", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return true;
            }
            if(decimal.Parse(txtcashdiff.EditValue.ToString()) < 0)
            {
                XtraMessageBox.Show("Please check the cash diffrence amount", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return true;
            }
            if (decimal.Parse(txtclosing.EditValue.ToString()) < 0)
            {
                XtraMessageBox.Show("Please check the closing amount", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return true;
            }
            if(dateEdit1.DateTime > DateTime.Now)
            {
                XtraMessageBox.Show("Please check the closing date", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return true;
            }
          //check hold sales invoices....
            var dt = new BLSales().GetHoldInvno();
            if (dt.Rows.Count > 1)
            {
                XtraMessageBox.Show("Holded invoices found , please complete the sale and proceed", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return true;
            }
            return retval;
        }
        private void DailyClosing_Load(object sender, EventArgs e)
        {
            var tfrom = new TimeSpan(3, 10, 0);
           // dateEdit1.DateTime = System.DateTime.Now.AddDays(-1);
            dateEdit1.DateTime = DateTime.Now;
            var ds = new BLReports().GetDailySales(0m,DateTime.Now,DateTime.Now,false);
            var srows =  ds.Select("ctype=1");
            foreach (DataRow d in srows)
            {
                txtcash.EditValue = decimal.Parse(d["TOTAL"].ToString());
            }
            var d1 = new BlDailySales().GetLastClosing(DateTime.Now, false);
            foreach (DataRow dr in d1.Rows)
            {
                if (dr["CTYPE"].ToString() == "1")
                {
                    txttotalcash.EditValue = decimal.Parse(dr["CVALUE"].ToString()) + decimal.Parse(txtcash.EditValue.ToString());
                    txtclosing.EditValue = txttotalcash.EditValue;
                    txtlastclosing.EditValue = decimal.Parse(dr["CVALUE"].ToString());
                    dateEdit2.EditValue = dr["CDATE"].ToString();
                }
            }
            //txtcashtrans.Properties.Mask.EditMask = "\\c+";
            //txtcashtrans.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            //if(System.DateTime.Now)
        }
        private void DailyClosing_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F4)
            {
                DoCloseSale();
            }
            if(e.KeyCode==Keys.Escape)
            {
                Close();
            }
        }
        void DoCloseSale()
        {
            if (!validateform())
            {
               
                var bl = new BlDailySales();
                var sprice = new BLReports().GetSumSprice();
                var cprice = new BLReports().GetSumCprice();
                int ret = 0;
                var f = new RptDailySalesReport {ClosingDifference = decimal.Parse(txtcashdiff.EditValue.ToString())};
                f.LoadDailyReport();
                    f.watermark = "Closed";
                    //if ((DateTime.Now.TimeOfDay > new TimeSpan(0, 1, 0)) && (DateTime.Now.TimeOfDay <= new TimeSpan(2, 50, 0)))
                    //{
                    //    f.aMonth = dateEdit1.DateTime.AddDays(-1).ToShortTimeString();
                    //}
                    //else
                    //{
                        f.aMonth = dateEdit1.DateTime.ToShortDateString();
                  //  }
                //  f.Show();
                    f.CreateReport();
                    f.Hide();
                    simpleButton1.Enabled = false;
                    var dtc = dateEdit1.DateTime;
                    if (bl.DoSave(1, "Opening Cash", decimal.Parse(txtclosing.EditValue.ToString()), dtc) != 0)
                    {
                       var blP = new BLSales();
                            blP.UpdateShitCode(1.ToString());
                    if (bl.DoSave(2, "Opening Sprice", sprice, dtc) != 0)
                        if (bl.DoSave(3, "Opening Cprice", cprice, dtc) != 0)
                            if (decimal.Parse(txtcashtrans.EditValue.ToString()) > 0)
                                bl.DoSave(4, "Transfer Amt", decimal.Parse(txtcashtrans.EditValue.ToString()), dtc);
                    if (decimal.Parse(txtcashdiff.EditValue.ToString()) > 0)
                        bl.DoSave(5, "Difference Amt", decimal.Parse(txtcashdiff.EditValue.ToString()), dtc);
                    bl.DoSave(6, "Last Opening", decimal.Parse(txtlastclosing.EditValue.ToString()), dtc);
                    new VIRETAILDAL.Masters.DailyClosing().CloseDailySales(dtc);
                   
                    }
            }
            else
            {
                simpleButton1.Enabled = true;
            }
        }
        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            txtclosing.EditValue = decimal.Parse(txttotalcash.EditValue.ToString()) -
                                  decimal.Parse(txtcashtrans.EditValue.ToString()) -  decimal.Parse(txtcashdiff.EditValue.ToString()); 
        }
        private void txtcashtrans_EditValueChanged(object sender, EventArgs e)
        {
            txtclosing.EditValue = decimal.Parse(txttotalcash.EditValue.ToString()) -
                                   decimal.Parse(txtcashtrans.EditValue.ToString());
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}