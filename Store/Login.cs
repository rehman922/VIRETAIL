using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using VIRETAILDAL.Masters;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class Login : XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Utils.Userid = 0;

            txtusername.Text = COMMON.Utils.ReadandWritetoregistry("Username", string.Empty, true);
            string chck = COMMON.Utils.ReadandWritetoregistry("Rem", string.Empty, true);
            if (chck != "")
            {
                if (chck == "1")
                {
                    checkEdit1.Checked = true;
                    txtpassword.Text = COMMON.Utils.ReadandWritetoregistry("Password", string.Empty, true);
                }
            }
        }
        private void textEdit2_Enter(object sender, EventArgs e)
        {}
        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtpassword.Properties.UseSystemPasswordChar = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoginSucess = false;
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusername.EditValue==null || txtpassword.EditValue==null)
            {
                labelControl1.Visible = true;
            }
            else
            {
                labelControl1.Visible =false;
                
                var ds = Functions.CheckLoginDetails(txtusername.EditValue.ToString(), txtpassword.EditValue.ToString());
                if(ds.Rows.Count==1)
                {
                    if (checkEdit1.Checked)
                    {
                        COMMON.Utils.ReadandWritetoregistry("rem", "1");
                        COMMON.Utils.ReadandWritetoregistry("Password", txtpassword.Text);
                    }
                    else
                    {
                        COMMON.Utils.ReadandWritetoregistry("rem", "0");
                        COMMON.Utils.ReadandWritetoregistry("Password", "");
                    }
                    COMMON.Utils.ReadandWritetoregistry("Username", txtusername.Text.ToUpper());


                    foreach(DataRow dr in ds.Rows)
                    {
                        Utils.Userid = int.Parse(dr["USERID"].ToString());
                        Utils.Profileid = int.Parse(dr["PROFILEID"].ToString());
                        Utils.UserType = int.Parse(dr["USERTYPE"].ToString());
                        var dst = ClsGetData.GetCompanies(true);
                        foreach (DataRow dr1 in dst.Rows)
                        {
                            Utils.Company = dr1["CCODE"].ToString();
                            Utils.Companyname = dr1["COMPNAME"].ToString();
                            Utils.CompanyAddress = dr1["COMPADD"].ToString();
                            Utils.StaticIp = dr1["WEB"].ToString();
                            Utils.Username =
                                new VIRETAILDAL.Masters.UserInfo().GetUserNameByUserid(Utils.Userid);
                        }
                        Utils.SalesStoreCode = new StoreManager().GetSalesStore();
                        Utils.PERM = ClsGetData.GetSysCode("PERM");
                        if (Utils.PERM != null)
                        {
                            var mainstring = Utils.PERM.Split('-');
                            var stall = mainstring[0].Split(',');
                            if (!string.IsNullOrEmpty(stall[0]))
                            {
                                Utils.ManualDiscount = stall[0] == "1";
                                Utils.MaximumDiscount = decimal.Parse(stall[stall.Length - 2]);
                            }
                        }
                        Utils.Sync = ClsGetData.GetSysCode("SYNC");

                        //LoadPrinter Settings
                        var dsPrinters = new DefaultPrinters().GetPrinters();
                        foreach (DataRow drPrinter in dsPrinters.Rows)
                        {
                            Utils.DefaultPrinterRow = drPrinter;
                        }
                        var dsMenu = (DataTable)new Profiles().LoadProfiles(Utils.Profileid);
                        foreach (DataRow drp in dsMenu.Rows)
                        {
                            Utils.Permissions = drp["DETAILS"].ToString();
                        }
                    }
                    LoginSucess = true;
                    Hide();
                }
                else
                {
                    labelControl1.Visible = true;
                }
            }
        }
        public bool LoginSucess { get; set; }
        
        
    }
}
