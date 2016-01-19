using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Store
{
    public partial class PrepCharges : XtraForm
    {
        public PrepCharges()
        {
            InitializeComponent();
        }

        public decimal charge { get; set;}
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (textEdit1.EditValue == null)
                charge = 0;
            else
                charge = decimal.Parse(textEdit1.EditValue.ToString());
            Close();
        }

        private void PrepCharges_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            if(e.KeyCode==Keys.Escape)
            {
                charge = 0;
                Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            charge = 0;
            Close();
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textEdit1.EditValue == null)
                    charge = 0;
                else
                    charge = decimal.Parse(textEdit1.EditValue.ToString());
                Close();
            }
        }
    }
}