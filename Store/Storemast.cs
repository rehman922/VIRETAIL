using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;

namespace Store
{
    public partial class Storemast : BaseRibbonForm
    {
        bool isnew = true;
        BindingSource Bsnav = new BindingSource();
        private TextBox Tnav = new TextBox();
        DsMaster.STOREMASTDataTable ds = new DsMaster.STOREMASTDataTable();
        public Storemast()
        {
            InitializeComponent();
            ItemClick += RibbonButtonsClick;
            RibbonPageMoreOptionsVisible = false;
            RibbonPrintVisible = false;
            DeleteButtonVisibility = BarItemVisibility.Never;
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
                    DoSave();
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
            Bsnav.MovePrevious();
            MoveNextEnable = true;
            var current = (DataRowView)Bsnav.Current;
            var scode = current["STORECODE"].ToString();
            DoView(scode);
            RibbonSaveEnable = false;
            HoldButtonVisibility = BarItemVisibility.Never;
            isnew = false;
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
            Bsnav.MoveNext();
            isnew = false;
            var current = (DataRowView)Bsnav.Current;
            var scode = current["STORECODE"].ToString();
            DoView(scode);
            RibbonSaveEnable = false;
            HoldButtonVisibility = BarItemVisibility.Never;

        }
        private void Storemast_Load(object sender, EventArgs e)
        {
            SetNavigation();
            cOMPANYBindingSource.DataSource = ClsGetData.GetCompanies();
          //storemastTableAdapter1.Fill(this.dsInventory1.STOREMAST);
        }
        void SetNavigation()
        {
            ds = ClsGetData.GetStoreList();
            Bsnav.DataSource = ds;
            Tnav.DataBindings.Add(new Binding("Text", Bsnav, "STORECODE", true));
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
        void DoSaveClose()
        {}
        void DoSaveNew()
        {}
        void DoSave()
        {
            if (DoValidate())return;
            var bl = new StoreManager
                         {
                             storecode = storecode.Text,
                             storetype = storetype.EditValue.ToString(),
                             storename = storename.Text,
                             address = address.Text,
                             phono = phoneno.Text,
                             fax = fax.Text,
                             communicationtype = int.Parse(radioGroup1.EditValue.ToString()),
                             COMPANY = lookupcompany.EditValue.ToString()
                         };
            var retval = bl.DoSave();
            if(retval=="1")
            {
                storecode.Text = bl.storecode;
                XtraMessageBox.Show("Data saved sucessfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RibbonSaveEnable = false;
                RibbonPageEdit = false;
            }
            else
            {
                XtraMessageBox.Show(retval, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        bool DoValidate()
        {
           // bool retval = false;
            //if (string.IsNullOrEmpty(storecode.Text))
            //{
            //    XtraMessageBox.Show("Please enter the store code");
            //    return true;
            //}
            if (lookupcompany.EditValue == null)
            {
                XtraMessageBox.Show("Please select the company ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (string.IsNullOrEmpty(storename.Text))
            {
                XtraMessageBox.Show("Please enter the store name","POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            if (storetype.EditValue==null)
            {
                XtraMessageBox.Show("Please select the store type", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if(radioGroup1.EditValue==null)
            {
                XtraMessageBox.Show("Please select the communication method", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
      
            //if (quotafrm.EditValue == null) 
            //{
            //    XtraMessageBox.Show("Please enter the from Quota");
            //    return true;
            //}
            //if (quotafrm.EditValue != null)
            //{ 
            //    if(int.Parse(quotafrm.EditValue.ToString())==0)
            //    {
            //        XtraMessageBox.Show("Value cannot be zero");
            //        return true;
            //    }
            //}
            //if (quotato.EditValue == null)
            //{
            //    XtraMessageBox.Show("Please enter the to Quota");
            //    return true;
            //}
            //if (quotato.EditValue != null)
            //{
            //    if (int.Parse(quotafrm.EditValue.ToString()) > int.Parse(quotato.EditValue.ToString()))
            //    {
            //        XtraMessageBox.Show("Quota to should be more than Quota from");
            //        return true;
            //    }
            //}
            //if (quotato.EditValue != null)
            //{
            //    if (int.Parse(quotafrm.EditValue.ToString()) == int.Parse(quotato.EditValue.ToString()))
            //    {
            //        XtraMessageBox.Show("Quota to should be more than Quota from");
            //        return true;
            //    }
            //}
            //int t = (int)this.storemastTableAdapter1.QuotaFrm(int.Parse(quotafrm.EditValue.ToString()), int.Parse(quotafrm.EditValue.ToString()));
            //if (t > 0)
            //{
            //    XtraMessageBox.Show("Duplicate Quota");
            //    return true;
            //}

            return false;
        }
        void DoNew()
        {
            storecode.Enabled = false;
            quotafrm.Enabled = true;
            quotato.Enabled = true;
            storecode.Text = "";
            storetype.Text = "";
            storename.Text = "";
            address.Text = "";
            phoneno.Text = "";
            fax.Text = "";
            radioGroup1.SelectedIndex = -1;
            checkEdit1.Checked = false;
            quotafrm.EditValue = "";
            quotato.EditValue = "";
           // RibbonSaveEnable = true;
            storetype.Enabled = true;
        }
        void DoView(string scode)
        { 
            isnew = false;//var dt = this.dsInventory1.STOREMAST;
            var dr = ds.FindBySTORECODE(scode);
            if (dr != null)
            {
                 
                storecode.Text = dr.STORECODE;
                storetype.Text = dr.STORETYPE;
                storename.Text = dr.STORENAME;
                address.Text = dr.IsADDRESSSNull() ? string.Empty : dr.ADDRESSS;
                phoneno.Text = dr.IsPHONENONull() ? string.Empty : dr.PHONENO;
                fax.Text = dr.IsFAXNONull() ? string.Empty : dr.FAXNO;
                radioGroup1.SelectedIndex = dr.COMM;
                storecode.Enabled = false;
                lookupcompany.EditValue = dr.COMPANY;
            }
            storetype.Enabled = false;
        }
        private void storecode_Validating(object sender, CancelEventArgs e)
        {
            //var dt = dsInventory1.STOREMAST;
            //var dr = dt.FindBySTORECODE(storecode.Text);
            //if (dr != null)
            //{
            //    DoView(storecode.Text);
            //}
        }

       
    }
}
 