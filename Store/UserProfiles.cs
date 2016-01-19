using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILENTITIES;

namespace Store
{
    public partial class UserProfiles : XtraForm
    {
        private bool isClear;   
        public UserProfiles()
        {
            InitializeComponent();
        }
        private void lookUpEdit1_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if(string.IsNullOrEmpty(e.DisplayValue.ToString())) return;
            var bl = new BlProfileNames();
            if(bl.DoSave(lookUpEdit1.Text)=="1")
            {
                dsMaster1.Merge(ClsGetData.LoadProfileNameMast());
            }
            e.Handled = true;
        }
        private void UserProfiles_Load(object sender, EventArgs e)
        {
            dsMaster1.Merge(ClsGetData.LoadMenu("1,2,3,4,5,"));
            dsMaster1.Merge(ClsGetData.LoadProfiles());
            dsMaster1.Merge(ClsGetData.LoadProfileNameMast());
           // mAINMENUBindingSource.Filter = " PARENTID > 0 ";
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(lookUpEdit1.EditValue==null)
            {
                XtraMessageBox.Show("Please select the profile name", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }
            var strperms = GetSelectedItems();
            var newrow = (DsMaster.PROFILESRow) new DsMaster().PROFILES.NewRow();
            newrow.PROFILEID = int.Parse(lookUpEdit1.EditValue.ToString());
            newrow.DETAILS = strperms;
            var bl = new BlProfiles {ProfilenamesRow = newrow};
            var retval = bl.DoSave();
        }
        string GetSelectedItems()
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            string retval = string.Empty;
            retval = checkEdit1.Checked ? "1" : "0";
            if (checkEdit2.Checked)
                retval += "1";
            else
                retval += "0";
            if (checkEdit3.Checked)
                retval += "1";
            else
                retval += "0";
            if (checkEdit4.Checked)
                retval += "1";
            else
                retval += "0";
            retval += "111";
            foreach (DsMaster.MENUNEWRow d in dsMaster1.MENUNEW.Rows)
            {
                if (d.SEL)
                    retval += "1";
                else
                {
                    retval += "0";
                }
            }
            return retval;
        }
        void ClearSelection()
        {
            foreach (DataRow dr in dsMaster1.MENUNEW.Rows)
            {
                dr["SEL"] = isClear;
            }
        }
        void SetSelected(string perms)
        {
            
            checkEdit1.Checked = perms.Substring(0,1)=="1";
            checkEdit2.Checked = perms.Substring(1,1)=="1";
            checkEdit3.Checked =  perms.Substring(2,1)=="1";
            checkEdit4.Checked = perms.Substring(3, 1) == "1";
            checkEdit5.Checked = perms.Substring(4, 1) == "1";
             int i = 0;
            foreach (DataRow dr in dsMaster1.MENUNEW.Rows)
            {
                if (perms.Substring(i, 1) == "1")
                {
                    if (int.Parse(dr["MENUID"].ToString()) == (i+8))
                    {
                        dr["SEL"] = true;
                    }
                    else
                    {
                        dr["SEL"] = false;
                    }
                }
                i++;
            }
        }
        private void LookUpEdit1EditValueChanged(object sender, EventArgs e)
        {
            if(lookUpEdit1.EditValue!=null)
            {
                isClear = false;
                checkEdit1.Checked = isClear;
                checkEdit2.Checked = isClear;
                checkEdit3.Checked = isClear;
                checkEdit4.Checked = isClear;
                checkEdit5.Checked = isClear;
                ClearSelection();
                foreach (DataRow dr in dsMaster1.PROFILES.Rows)
                {
                    if(dr["PROFILEID"].ToString()==lookUpEdit1.EditValue.ToString())
                    {
                        SetSelected(dr["DETAIlS"].ToString());
                    }
                }
            }
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        { RemoveandUncheck(1);}
        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        { RemoveandUncheck(2);}
        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {

            RemoveandUncheck(3);
        }
        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            RemoveandUncheck(4);
        }
        void RemoveandUncheck(int pid)
        {
            try
            {
                var rows = dsMaster1.MENUNEW.Select("MPARENTID=" + pid + "");
                foreach (var dataRow in rows)
                {
                    dataRow["sel"] = false;
                }
                //if (GetFilter().Length > 0)
                //{
                //    var filter = "MPARENTID IN ( '" + GetFilter() + "' )  ";
                //    mENUNEWBindingSource.Filter = filter;
                //}
            }
            catch(Exception ex)
            {
                var e1 = ex.ToString();
            }
        }
        string GetFilter()
        {
            string p = "";
            if(checkEdit1.Checked)
            {
                p = "1,";
            }
            if(checkEdit2.Checked)
            {
                p += "2,";
            }
            if(checkEdit3.Checked)
            {
                p += "3,";
            }
            if(checkEdit4.Checked)
            {
                p += "4,";
            } 
            if (checkEdit5.Checked)
            {
                p += "5,";
            }
            
            return p.Substring(p.Length-1,1);
        }
        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            RemoveandUncheck(5);
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            isClear = true;
            ClearSelection();
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            isClear = false;
            ClearSelection();
        }
    }
}