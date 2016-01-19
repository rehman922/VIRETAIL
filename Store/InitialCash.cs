using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;

namespace Store
{
    public partial class InitialCash : XtraForm
    {
        public InitialCash()
        {
            InitializeComponent();
        }

        private void InitialCash_Load(object sender, EventArgs e)
        {
            var t =  ClsGetData.GetSysCode("OPBAL");
            if(!string.IsNullOrEmpty(t))
            {
                if(decimal.Parse(t) > 0)
                {
                    
                }
            }
            dateEdit1.EditValue = DateTime.Now;
            textEdit1.Properties.Mask.EditMask = "\\d+";
            textEdit1.Properties.Mask.MaskType = MaskType.RegEx;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(dateEdit1.EditValue==null)
            {
                XtraMessageBox.Show("Please enter the date ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(textEdit1.EditValue==null)
            {
                XtraMessageBox.Show("Please enter the initial amount ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEdit1.Focus();
                return;
            }
            int ret = 0; //1 - OPENING CASH 2 - SALE VALUE 3 - COST VALUE 4 - TRANSFER AMOUNT 5 - END CASH
            var bl = new BlDailySales();
            var sprice = new BLReports().GetSumSprice();
            var cprice = new BLReports().GetSumCprice();
            var dtc = dateEdit1.DateTime;
            if(bl.DoSave(1,"Opening Cash",decimal.Parse(textEdit1.EditValue.ToString()),dtc,true)!=0)
            {
                ret = 1;
                if (bl.DoSave(2, "Opening Sprice", sprice, dtc, true) != 0)
                    bl.DoSave(3, "Opening Cprice", cprice, dtc, true); 
            }
            if (ret == 1)
                Close();
            else
                XtraMessageBox.Show("Data not saved contact to system administrator", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);



        }
    }
}