using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using VIRETAILDAL.Masters;

namespace Store
{
    public partial class PharmacistLogin : XtraForm
    {
        public PharmacistLogin()
        { InitializeComponent(); }
        public bool isloginsucess;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtusername.EditValue == null || txtpassword.EditValue == null)
            {
                labelControl1.Visible = true;
            }
            else
            {
                var ds = Functions.CheckLoginDetails(txtusername.EditValue.ToString(),
                                                            txtpassword.EditValue.ToString());
                if (ds != null)
                {
                    foreach (DataRow dr in ds.Rows)
                    {
                        var save = new DOCTORSESSION();
                        save.DoSave(int.Parse(dr["USERID"].ToString()), int.Parse(dr["USERTYPE"].ToString()));
                    }
                }
                isloginsucess = true;
                Dispose();
            }
        }
        private void PharmacistLogin_Load(object sender, EventArgs e)
        {txtpassword.Properties.UseSystemPasswordChar = true;}
        private void simpleButton2_Click(object sender, EventArgs e)
        {Close();}
        private void PharmacistLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}