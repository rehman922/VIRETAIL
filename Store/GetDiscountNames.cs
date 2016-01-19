using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL.COMMON;

namespace Store
{
    public partial class GetDiscountNames : XtraForm
    {
        public bool ispercentage;
        public GetDiscountNames()
        {
            InitializeComponent();
            if (Utils.MaximumDiscount != 0)
            {
                label2.Text = "Maximum discount allowed " + Utils.MaximumDiscount + " % ";
                label2.Visible = false;
            }
        }

        public decimal Discval { get; set; }
        private void GetDiscountNames_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                Discval = 0;
                Close();   
            }
            if(e.KeyCode==Keys.Enter)
            {
                if (txtcash.EditValue != null && txtcash.EditValue != "")
                {
                    
                        //if(VIRETAILDAL.COMMON.Utils.MaximumDiscount!=0)
                        //{
                        label2.Visible = false;
                        if (decimal.Parse(txtcash.EditValue.ToString()) > Utils.MaximumDiscount)
                        {
                            label2.Visible = true;
                            return;
                        }
                        //}
                        Discval = decimal.Parse(txtcash.EditValue.ToString());
                        if (Discval > 0)
                            Close();
                    
                }
                else
                {
                    txtdiscount.Focus();
                }
                if (txtdiscount.EditValue != null && txtdiscount.EditValue != "")
                {
                     
                        Discval = decimal.Parse(txtdiscount.EditValue.ToString());
                        if (Discval > 0)
                            Close();
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
                txtcash.EditValue = ((Button)sender).TabIndex +1;
                Discval = decimal.Parse(txtcash.EditValue.ToString()) ;
                Close();
        }

        private void GetDiscountNames_Load(object sender, EventArgs e)
        {

        }

        private void txtcash_EditValueChanged(object sender, EventArgs e)
        {
            ispercentage = true;
            if(!ispercentage)
            {
                txtcash.EditValue = 0;
            }
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ispercentage = false;
            if (ispercentage)
            {
                txtdiscount.EditValue = 0;
            }
        }
    }
}