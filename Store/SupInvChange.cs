using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;

namespace Store
{
    public partial class SupInvChange : XtraForm
    {
        public string _purinv;
        public SupInvChange()
        {
            InitializeComponent();
        }

        private void SupInvChange_Load(object sender, EventArgs e)
        {
            //ClsGetData.GetSupplier();
            var dssup = ClsGetData.GetSupplier();
            var bs = new BindingSource("dssup", "");
            var bs1 = new BindingSource("dssup", "");
            lookUpEdit2.Properties.DataSource = dssup;
            looksupid.Properties.DataSource = dssup;
            //lookUpEdit2.Properties.PopulateColumns();
            //looksupid.Properties.PopulateColumns();
        }
        public void LoadDetails()
        {
            var bl = new Blpurinv { Purinvid = _purinv };
            bl.GetPurinv();
            lookUpEdit2.EditValue = bl.Supid;
            looksupid.EditValue = bl.Supid;
            txtinvno.EditValue = bl.Invno;
            invdate.EditValue = bl.Invdate;
            txtduedays.EditValue = bl.Duedays;
            txtinvamt.EditValue = bl.Netvalue;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Do you want to update","POS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
                return;
            if(!DoValidate()) return;
            var bl = new Blpurinv {Purinvid = _purinv};
            if(looksupid.EditValue==null)
            {
                bl.Supid = lookUpEdit2.EditValue.ToString();
                bl.Supname = lookUpEdit2.Text;
            }
            else
            {
                bl.Supid= looksupid.EditValue.ToString();
                bl.Supname = looksupid.Text;
            }
            bl.Invno = txtinvno.Text;
            bl.Invdate = invdate.DateTime;
            bl.Duedays = int.Parse(txtduedays.EditValue.ToString());
           if( bl.UpdatePurInv() == 0)
           {
               XtraMessageBox.Show("Update error please try again", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
        bool DoValidate()
        {
            if(txtinvno.EditValue==null)
            {
                XtraMessageBox.Show("Please enter the invoice number.", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return false;
            }
            if(invdate.EditValue==null)
            {
                XtraMessageBox.Show("Please enter the invoice date", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}