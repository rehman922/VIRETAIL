using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.Properties;

namespace Store
{
    public partial class ShiftCode : XtraForm
    {
        public ShiftCode()
        {
            InitializeComponent();
        }
        private string SCode { get; set; }
        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkButton1.Checked)
            {
                checkButton1.Image = Resources.tick32;
                checkButton2.Image = null;
                checkButton3.Image = null;
                checkButton2.Checked=false;
                checkButton3.Checked =false ;
                SCode = "1";
            }
        }
        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton2.Checked)
            {
                checkButton2.Image = Resources.tick32;
                checkButton1.Image = null;
                checkButton3.Image = null;
                checkButton1.Checked = false;
                checkButton3.Checked = false;
                SCode = "2";
            }
        }
        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton3.Checked)
            {
                checkButton3.Image = Resources.tick32;
                checkButton1.Image = null;
                checkButton2.Image = null;
                checkButton1.Checked = false;
                checkButton2.Checked = false;
                SCode = "3";
            }
        }
        private void ShiftCode_Load(object sender, EventArgs e)
        {
            var bl = new BLSales();
            labelControl1.Text = "Current Shift = " + bl.GetShiftCode();
        }
        private void ShiftCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            var bl = new BLSales();
            if(!string.IsNullOrWhiteSpace(SCode))
              bl.UpdateShitCode(SCode);
        }
         
    }
}