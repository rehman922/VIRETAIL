using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL.Masters;

namespace Store
{
    public partial class YearCloseProcess : XtraForm
    {
        public int _ClosingYear { get; set; }
        public YearCloseProcess()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //1.Check for sales Closing
            //2.Check holded sales,purchase
            //3.check for holded transfers
            //4.Check for dayclose
            //5.Check for inventory adjusted

            _ClosingYear = 0;
            if (spinEdit1.EditValue == null)
            {
                XtraMessageBox.Show("Please enter the year", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (spinEdit1.EditValue.ToString().Length < 4)
                {
                    XtraMessageBox.Show("Please enter the year in yyyy format", "POS", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    return;
                }
             var cl = new YearEndClass();
             var cnt = cl.CheckYearClosed(int.Parse(spinEdit1.EditValue.ToString()));
             if(cnt > 0)
                {
                    XtraMessageBox.Show("Year Closed already", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            //SELECT COUNT(*) from SALESMAIN where HOLDNO > 0
            //SELECT COUNT(*) FROM SALESMAIN WHERE POSTED =1 AND DAILYCLOSED=0
            //SELECT COUNT(*) FROM PURINVMAIN WHERE HOLD = 1 
            //SELECT COUNT(*) FROM ITEMTRANSFERMAIN WHERE HOLD = 1
            if(new YearEndClass().ValidateYearClosed(1))
            {
                XtraMessageBox.Show("Please un-hold sales before processing year end", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return; 
            }
            if(cl.ValidateYearClosed(2))
            {
                XtraMessageBox.Show("Please do daily close before processing year end", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return; 
            }
            if (cl.ValidateYearClosed(3))
            {
                XtraMessageBox.Show("Please un-hold the purhcase invoice before processing year end", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }
            if (cl.ValidateYearClosed(4))
            {
                XtraMessageBox.Show("Please un-hold the transfers before processing year end", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show("Are you sure to close the year","POS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (cl.CheckYearCloseProcessStart(int.Parse(spinEdit1.EditValue.ToString())))
                {
                    _ClosingYear = int.Parse(spinEdit1.EditValue.ToString());
                    Dispose();
                }
                if (cl.DoCreateYearClosed(int.Parse(spinEdit1.EditValue.ToString())) == "1")
                {
                    //cREATA TABLE TO READ THE TEXTFILES
                    XtraMessageBox.Show("System ready for physical inventory", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                   _ClosingYear = int.Parse(spinEdit1.EditValue.ToString());
                   Dispose();
               }
               else
               {
                   XtraMessageBox.Show("Error", "POS", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
               }
            }
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void YearCloseProcess_Load(object sender, EventArgs e)
        {
            spinEdit1.Properties.MinValue = 2015;
            spinEdit1.EditValue = DateTime.Now.Year;
        }
    }
}