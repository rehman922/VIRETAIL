using System;
using System.Data;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;

namespace Store
{
    public partial class UserInfo : BaseRibbonForm
    {
        private BindingSource Bsnav = new BindingSource();
        private readonly TextBox Tnav = new TextBox();
        private DsMaster.USERINFODataTable ds;
        private int Empid;
        public UserInfo()
        {
            InitializeComponent();
        }
        private void UserInfo_Load(object sender, EventArgs e)
        {
            ItemClick += RibbonButtonsClick;
            RibbonPageMoreOptionsVisible = false;
            RibbonPrintVisible = false;
            //SaveButtonVisibility = BarItemVisibility.Never;
            SaveandNewButtonVisibility = BarItemVisibility.Never;
            Tnav.DataBindings.Add(new Binding("Text", Bsnav, "USERID", true));
            pROFILENAMEMASTBindingSource.DataSource = new ProfileNames().LoadProfileNames();
            SetNavigation();
            bindingSource1.DataSource = typeof(UserInfoErr);
            try
            {
                txtEmpno.DataBindings.Add(new Binding("EditValue", bindingSource1, "Empno", true));
                txtFullname.DataBindings.Add(new Binding("EditValue", bindingSource1, "Fullname", true));
                txtLoginname.DataBindings.Add(new Binding("EditValue", bindingSource1, "Username", true));
                txtPassword.DataBindings.Add(new Binding("EditValue", bindingSource1, "Password", true));
                //cmbProfile.DataBindings.Add(new Binding("EditValue", bindingSource1, "Profileid", true));
                cmbRole.DataBindings.Add(new Binding("EditValue", bindingSource1, "Role", true));
                textpassword1.DataBindings.Add(new Binding("EditValue", bindingSource1, "Password1", true));
                dxErrorProvider1.DataSource = bindingSource1;
                dxErrorProvider1.ContainerControl = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void SetNavigation()
        {
            ds = ClsGetData.GetEmployees();
            Bsnav.DataSource = ds;
           
            if (Bsnav.Count == 0)
            {
                MovePrevEnable = false;
                MoveNextEnable = false;
            }
            else
            {
                Bsnav.MoveLast();
                MoveNextEnable = false;
            }
        }
        void DoMovePrev()
        {
            if (Bsnav.Position <= 0)
            {
                MoveNextEnable = true;
                MovePrevEnable = false;
            }
            else
            {
                MovePrevEnable = true;
            }
            
            MoveNextEnable = true;
            var current = (DataRowView)Bsnav.Current;
            Empid = Convert.ToInt32(current["USERID"].ToString());
            Bsnav.MovePrevious();
            DoView();
        }
        void DoMoveNext()
        {
            if (Bsnav.Position == Bsnav.Count - 1)
            {
                MoveNextEnable = false;
                MovePrevEnable = true;
            }
            else
            {
                MovePrevEnable = true;
            }
            var current = (DataRowView)Bsnav.Current;
            Empid = Convert.ToInt32(current["USERID"].ToString());
            Bsnav.MoveNext();
            DoView();
        }
        void DoView()
        {
            if (Empid > 0)
            {
                var current = ds.FindByUSERID(Empid);
                //foreach (DataRow current in drs)
                //{
                //Bsnav.Filter = " USERID =" + Empid + " ";
                //var current = (DataRowView)Bsnav.Current;
                txtEmpno.EditValue = current["EMPNO"];
                txtLoginname.EditValue= current["USERNAME"];
                txtFullname.EditValue= current["FULLNAME"];
                txtPassword.EditValue = Functions.Base64Decode(current["PASSWORD"].ToString());
                textpassword1.EditValue = txtPassword.EditValue;
                cmbRole.SelectedIndex = int.Parse(current["USERTYPE"].ToString());
                cmbProfile.EditValue = current["PROFILEID"] ?? null;
                checkEdit1.Checked = (bool) (current["ACTIVE"] = checkEdit1.Checked); 
                //}
            }
        }
        void DoNew()
        {
            Empid = 0;
            txtEmpno.EditValue = null;
            txtFullname.EditValue = null;
            txtLoginname.EditValue = null;
            txtPassword.EditValue = null;
            textpassword1.EditValue = null;
             checkEdit1.Checked = true;
            cmbProfile.EditValue = null;
            cmbRole.SelectedIndex = -1;
        }
        bool UserinfoHasErrors()
        {
            var retval = true;
            var errl = new UserInfoErr
            {
                Empno = txtEmpno.EditValue == null ? null : txtEmpno.EditValue.ToString(),
                Fullname = txtFullname.EditValue == null ? null : txtFullname.EditValue.ToString(),
                Username = txtLoginname.EditValue == null ? null : txtLoginname.EditValue.ToString(),
                Password = txtPassword.EditValue == null ? null : txtPassword.EditValue.ToString(),
            //  Profileid = cmbProfile.EditValue == null ? null : cmbProfile.EditValue.ToString(),
                Role = cmbRole.EditValue == null ? null : cmbRole.EditValue.ToString(),
                Password1 = textpassword1.EditValue == null ? null : textpassword1.EditValue.ToString()
            };
            bindingSource1.Add(errl);
           if (dxErrorProvider1.HasErrors)
            {
                retval = false;
            }
           if (txtPassword.EditValue.ToString() != textpassword1.EditValue.ToString())
           {
               XtraMessageBox.Show("Password and re-type password not matched", "POS", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
               retval = false;
           }
           return retval;
        }
        void DoSave(int op)
        {
            if (!UserinfoHasErrors()) return;
            var dt = new DsMaster.USERINFODataTable();
            var dr = (DsMaster.USERINFORow) dt.NewRow();
            dr.USERID = Empid;
            dr.EMPNO = txtEmpno.EditValue.ToString().ToUpper();
            dr.USERNAME = txtLoginname.EditValue.ToString().ToUpper();
            dr.FULLNAME = txtFullname.EditValue.ToString();
            dr.PASSWORD = Functions.Base64Encode(txtPassword.EditValue.ToString());
            dr.USERTYPE = cmbRole.SelectedIndex;
            dr.PROFILEID = cmbProfile.EditValue == null ? 0:int.Parse(cmbProfile.EditValue.ToString());
            dr.ACTIVE = checkEdit1.Checked;
            var bl = new BLUserinfo();
            bl.UserinfoRow = dr;
            try
            {
                var ret = bl.DoSave();
                if (ret == "1")
                {
                   //Empid = bl.Newuserid;
                    XtraMessageBox.Show("Data Saved", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetNavigation();
                    DoNew();
                }
                if(op==1 && ret=="1")
                 {
                    Dispose();
                 }
                //if (op == 1 && ret == "2")
                //{
                //   DoNew();
                //}
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        void DoSaveClose()
        {
            DoSave(1);
        }
        void DoSaveNew()
        {
            DoSave(2);
        }
        void RibbonButtonsClick(object sender, ItemClickEventArgs name)
        {
            switch (name.Item.Name.ToUpper())
            {
                //  BNew BSave BSaveandClose BSaveandNew BClear BDelete BPrint BNotes BHold BMovePrev BMoveNext
                case "BNEW":
                    DoNew();
                    break;
                case "BSAVE":
                    DoSave(0);
                    break;
                case "BSAVEANDCLOSE":
                    DoSaveClose();
                    break;
                case "BSAVEANDNEW":
                    DoSaveNew();
                    break;
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
            }
        }
        private void txtEmpno_Validated(object sender, EventArgs e)
        {
            //dr.EMPNO = txtEmpno.EditValue.ToString().ToUpper();
            //dr.USERNAME = txtLoginname.EditValue.ToString().ToUpper();
            if (txtEmpno.EditValue != null)
            {
                var bl = new BLUserinfo();
                bl.GetUserinfoByEmp(txtEmpno.EditValue.ToString().ToUpper());
                if(bl.UserinfoRow!=null)
                {
                    Empid = bl.UserinfoRow.USERID;
                    DoView();
                }
            }
        }
        private void txtLoginname_Validated(object sender, EventArgs e)
        {
            if (txtLoginname.EditValue != null)
            {
                var bl = new BLUserinfo();
                bl.GetUserinfoByUserName(txtLoginname.EditValue.ToString().ToUpper());
                if(bl.UserinfoRow!=null)
                {
                    Empid = bl.UserinfoRow.USERID;
                    DoView();
                }
            }
        }
    }
}