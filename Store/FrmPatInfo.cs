using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using VIRETAILENTITIES;

namespace Store
{
    public partial class FrmPatInfo : XtraForm
    {
        public string Custno;
        public string Custpayment;
        public string Fileno
        {
            set { txtfno.Text = value; }
        }
        public string Memno
        {
            set { txtmemno.Text = value; }
        }
        
        public int Tid = 0;
        
        public FrmPatInfo()
        {
            InitializeComponent();
        }
        private void txtfno_KeyDown(object sender, KeyEventArgs e)
        {
            var bl = new BlInsuranceCustomer();
            bl.GetInscustomersRowByFileNo(txtfno.Text);
            if (bl.dr != null)
            {
                txtmemno.Text = bl.dr.POLICYNO.ToString();
                txtname.Text = bl.dr.PATNAME;
                txtcompname.Text = bl.dr.CUSTNO;
                cutomerpayment.Text = bl.dr.CUSTSHARE.ToString();
                Tid = bl.dr.TID;
            }
        }
        private void txtmemno_KeyDown(object sender, KeyEventArgs e)
        {
            var bl = new BlInsuranceCustomer();
            bl.GetInscustomersRowByPolicyNo(txtfno.Text);
            if (bl.dr != null)
            {
                txtfno.Text = bl.dr.FILENO;
                txtname.Text = bl.dr.PATNAME;
                txtcompname.Text = bl.dr.CUSTNO;
                cutomerpayment.Text = bl.dr.CUSTSHARE.ToString();
                Tid = bl.dr.TID;
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            bool isvalid = false;
            if (txtfno.EditValue== null)
            {
                txtfno.ErrorText = "Enter File No";
                isvalid = true;
            }
            if (txtmemno.EditValue == null)
            {
                txtmemno.ErrorText = "Enter Member No";
                isvalid = true;
            }
            if (txtcompname.EditValue == null)
            {
                txtcompname.ErrorText = "Enter Company name";
                isvalid = true;
            }
            if (txtname.EditValue == null)
            {
                txtname.ErrorText = "Enter Patient name";
                isvalid = true;
            }
            if (!isvalid )
            {
                var bl = new BlInsuranceCustomer();
                var tb = new DsMaster().INSCUSTOMERS;
                var dr = (DsMaster.INSCUSTOMERSRow) tb.NewRow();
                dr.TID = Tid;
                dr.FILENO = txtfno.Text;
                dr.POLICYNO =int.Parse(txtmemno.EditValue.ToString());
                dr.CUSTNO = txtcompname.Text;
                dr.PATNAME = txtname.Text;
                bl.dr = dr;
                var msg = bl.DoSave();
                if (msg  == "1")
                {
                    if (
                        XtraMessageBox.Show("Saved do you want to add more", "Patient Details", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        Tid = 0;
                        txtfno.Text = string.Empty;
                        txtfno.Text = string.Empty;
                        txtmemno.Text = string.Empty;
                        txtcompname.Text = string.Empty;
                        txtname.Text = string.Empty;
                    }
                    else
                    {
                        Custno = txtname.Text;
                        Custpayment = cutomerpayment.EditValue.ToString();
                        Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show(msg, "Patient Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}