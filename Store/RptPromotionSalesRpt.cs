using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptPromotionSalesRpt : XtraForm
    {

        public bool _usemultistore = false;
        string[] connew = Utils.Connectionstring.Split(';');
        string strcnme = Utils.Companyname;

        public RptPromotionSalesRpt()
        { InitializeComponent(); }
        public string Empno { get; set; }
        private void PromotionSalesRpt_Load(object sender, EventArgs e)
        {
            uSERINFOBindingSource.DataSource = ClsGetData.GetUserInfo();
            txtpassword.Properties.UseSystemPasswordChar = true;
            if (_usemultistore)
            {
                lookUpEdit2.Enabled = false; //  var dt = COMMON.ClsGetData.GetStoresDataBases();
                sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames();
                lookUpEdit2.Enabled = false;
                lblpwd.Visible = false;
                lookUpEdit3.Visible = true;
                labelControl5.Visible = true;
                txtpassword.Visible = false;
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lookUpEdit3.EditValue != null)
            {
                strcnme = lookUpEdit3.GetColumnValue("STORENAME").ToString();
            }
           
           var c = new GridPrintingClass
            {
                Heading1 = strcnme,
                Heading2 = "Sales Target Report Period " + lookUpEdit1.GetColumnValue("PROMONAME")
            };
            c.DoPrint(gridControl1);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string othercon = string.Empty;
            bool useo = false;
            if (lookUpEdit3.EditValue != null)
            {
                othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit3.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                useo = true;
            }

            if (lookUpEdit1.EditValue != null)
            {
                var ds = new BLReports().GetSalesTargetDetFSelStore(lookUpEdit1.EditValue.ToString(), int.Parse(lookUpEdit2.EditValue.ToString()),useo,othercon);
                gridControl1.DataSource = ds;
            }
        }
        private void txtpassword_Validated(object sender, EventArgs e)
        {
            if(txtpassword.EditValue==null) return;
            txtpassword.EnterMoveNextControl = true;

            if (_usemultistore)
            {
                LoadPromos();
                return;
            }
            var ds1 = Functions.CheckLoginDetails(lookUpEdit2.Text, txtpassword.EditValue.ToString());
            if (ds1.Rows.Count == 1)
            {
                LoadPromos();
            }
            else
            {
                XtraMessageBox.Show("Please check the password", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpassword.EnterMoveNextControl = false;

            }
        }
        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (_usemultistore)
            {
                LoadPromos();
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            if(gridView1.FocusedRowHandle>=0)
            {
                string othercon = string.Empty;
                bool useo = false;
                if (lookUpEdit3.EditValue != null)
                {
                    othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit3.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                    useo = true;
                }

                var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                var f = new FrmSalesItemsDetails();
                f.strcnme = strcnme;
                f.LoadDetails(lookUpEdit1.EditValue.ToString(), dr[0].ToString(), int.Parse(lookUpEdit2.EditValue.ToString()), useo, othercon);
                f.ShowDialog();
            }
        }

        void LoadPromos()
        {
                simpleButton1.Enabled = true;
                BindingSource bsW;
                string othercon = string.Empty;
                bool useo = false;
                if (lookUpEdit3.EditValue != null)
                {
                    othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit3.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                    useo = true;
                }

                var ds = ClsGetData.GetCommissionMast(null, useo, othercon);

                Empno = lookUpEdit2.GetColumnValue("EMPNO").ToString();
                bsW = !string.IsNullOrEmpty(Empno) ? new BindingSource(ds, "") { Filter = "EMPNO= '" + Empno + "'" } : new BindingSource(ds, "");
                bsW.Sort = " comid asc";
                lookUpEdit1.Properties.DataSource = bsW;
        }
        private void txtpassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {

            string othercon = string.Empty;
            bool useo = false;
            lookUpEdit2.Enabled = true;
            if (lookUpEdit3.EditValue != null)
            {
                othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit3.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                useo = true;
            }
            

            uSERINFOBindingSource.DataSource = ClsGetData.GetUserInfo(useo,othercon);
            uSERINFOBindingSource.ResetBindings(false);
        }
    }
}