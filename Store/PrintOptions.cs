using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;

namespace Store
{
    public partial class PrintOptions : XtraForm
    {
        public string _pono = string.Empty;
        public PrintOptions()
        {
            InitializeComponent();
        }

        public bool Isprint { get; set; }
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
              
            Dispose();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (checkEdit1.CheckState == CheckState.Unchecked && checkEdit2.CheckState == CheckState.Unchecked)
            {

                MessageBox.Show("Please select the copy", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkEdit2.Checked)
            {
                BLPO.DoPrint(_pono, true);
            }
            if (checkEdit1.Checked)
            {
                BLPO.DoPrint(_pono, false);
                Isprint = true;
            }
        }
    }
}