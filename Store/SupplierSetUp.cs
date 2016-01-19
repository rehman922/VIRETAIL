using System;
using System.Data;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Store.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Supplier;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class SupplierSetUp : BaseRibbonForm
    {
        string supplierno = string.Empty;
        BindingSource Bsnav = new BindingSource();
        public bool isnew = true;
        public SupplierSetUp()
        {
            InitializeComponent();
            ItemClick += RibbonButtonsClick;
            RibbonPrintVisible = false;
            RibbonPageMoreOptionsVisible = false;
            DeleteButtonVisibility = BarItemVisibility.Never;
            HoldButtonVisibility = BarItemVisibility.Never;
            
        }
        void RibbonButtonsClick(object sender, ItemClickEventArgs name)
        {
            switch (name.Item.Name.ToUpper())
            {
                //BNew BSave BSaveandClose BSaveandNew BClear BDelete BPrint BNotes BHold BMovePrev BMoveNext
                case "BSAVE":
                    DoSave(isnew);
                    break;
                case "BSAVEANDCLOSE":
                    DoSave(isnew);
                    Dispose();
                    break;
                case "BSAVEANDNEW":
                    DoSave(isnew);
                    DoNew();
                    break;
                case "BCLEAR":
                    DoNew();
                    break;
                case "BDELETE":
                    //DoDelete();
                    break;
                case "BPRINT":
                    // DoPrint();
                    break;
                case "BNOTES":
                    //DoNotes();
                    break;
                case "BHOLD":
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
            }
        }
        private void gridView1_InitNewRow_1(object sender, InitNewRowEventArgs e)
        {
            var view = (GridView)sender;
            if (view.DataRowCount == 0)
                view.SetRowCellValue(e.RowHandle, view.Columns["ISPRIMARY"], true);
            else
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["ISPRIMARY"], false);
            }
        }
        private void SupplierSetUp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void SupplierSetUp_Load(object sender, EventArgs e)
        {
            dsMaster1.Merge(ClsGetData.GetSupplier());
            dsMaster1.Merge(new VIRETAILDAL.Masters.Terms().GetTermMast());
            dsMaster1.Merge(new VIRETAILDAL.Masters.Terms().GetPayTypeMast());
            dsMaster1.Merge(new VIRETAILDAL.Masters.Terms().GetShipping());
            dsMaster1.Merge(new VIRETAILDAL.Masters.Terms().GetGroups());
            SetNavigation();
            vendorno.Text = "NEW";
            
        }
        #region Navigation
        void SetNavigation()
        {
            Bsnav.DataSource = dsMaster1.SUPPLIER;
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
            var current = (DataRowView)Bsnav.Current;
            supplierno = current["SUPPLIERNO"].ToString();
            
            MoveRecord();
            
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
            supplierno = current["SUPPLIERNO"].ToString();
            MoveRecord();
             
        }
        void MoveRecord()
        {
            DataRow dr = dsMaster1.SUPPLIER.FindBySUPPLIERNO(supplierno);
            var sup = new Supplier(dr);
            dsMaster1.Merge(new Contacts().GetContact(2,supplierno));

  
            
            ViewData(sup);
        }
        void ViewData(Supplier sup)
        {
            isnew = false;
            //sup.DsContact = this.dSPOSSTORE.CONTACTMAST;
            vendorno.Text = sup.SUPPLIERNO;
            vendorname.Text = sup.SUPPLIERNAME;
            aliasname.Text = sup.ALTERNATENAME;
            address.Text = sup.ADDRESS; //1500,
            phoneno.Text = sup.PHONE;
            faxno.Text = sup.FAX;//15
            status.Checked = sup.ACTIVE;
            email.Text = sup.EMAILID;
            webpage.Text = sup.WEBPAGE; //60
            balanceasof.Enabled = false;
            balance.Enabled = false;
            contact.Text = sup.CONTACAT;
            duedays.EditValue = sup.DUEDAYS;

            if (sup.VENDORSINCE.Year <= 1900)
            {
                vendorsince.EditValue = null;
            }
            else
            {
                vendorsince.EditValue = sup.VENDORSINCE;
            }
            accountno.Text = sup.ACCOUNTNO;
            //if (!string.IsNullOrEmpty(balance.Text))
            if (sup.BALANCEASOF.Year <= 1900)
            {
                balanceasof.EditValue = null;
            }
            else
            {
                balanceasof.EditValue = sup.BALANCEASOF;
            }
            //if (!string.IsNullOrEmpty(balanceasof.Value.ToString()))
            balance.Value = sup.BALANCE;
            notes.Text = sup.NOTE;
            //if (!string.IsNullOrEmpty(c1Expense.SelectedText.ToString()))
            c1Expense.EditValue  = sup.EXPACCID;
            //if (!string.IsNullOrEmpty(c1Grouping.SelectedText.ToString()))
            c1Grouping.EditValue = sup.SUPGROUP;
            creditlimit.EditValue = sup.CREDITLIMIT;
            //if (!string.IsNullOrEmpty(c1Shipping.SelectedText.ToString()))
            c1Shipping.EditValue = sup.DEFSHIPPING;
            //if (!string.IsNullOrEmpty(c1Payment.SelectedText.ToString()))
            c1Payment.EditValue = sup.DEFPAYMENT;
            //if (!string.IsNullOrEmpty(c1Terms.SelectedText.ToString()))
            c1Terms.EditValue = sup.PAYTERMS;
           
            
            //var t = new SupplierManager();
            //string Returnval = t.AddSupplier(sup);
            //XtraMessageBox.Show(Returnval);
        }
        #endregion
        private void SupplierSetup_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }
        void DoSave(bool SaveEdit)
        {
            if (!DoValidate())
            {
                var sup = new Supplier();
                sup.DsContact = dsMaster1.CONTACTMAST;
                sup.SUPPLIERNAME = vendorname.Text.Replace("'", "");
                sup.ARSUPPLIERNAME = string.Empty;
                sup.ALTERNATENAME = aliasname.Text;
                sup.ADDRESS = address.Text; //1500,
                sup.PHONE = phoneno.Text;
                sup.FAX = faxno.Text;//15
                sup.ACTIVE = bool.Parse(status.Checked.ToString());
                sup.CONTACAT = contact.Text;
               
                sup.EMAILID = email.Text;
                sup.WEBPAGE = webpage.Text; //60
                if (duedays.EditValue != null)
                    sup.DUEDAYS = int.Parse(duedays.EditValue.ToString());

                sup.VENDORSINCE = vendorsince.EditValue != null ? DateTime.Parse(vendorsince.EditValue.ToString()) : new DateTime(1900, 1, 1);
                sup.ACCOUNTNO = accountno.Text;
                if (!string.IsNullOrEmpty(balanceasof.Text))
                    sup.BALANCE = decimal.Parse(balance.Value.ToString());
                if (balanceasof.EditValue != null)
                    sup.BALANCEASOF = DateTime.Parse(balanceasof.EditValue.ToString());
                else
                {
                    sup.BALANCEASOF = new DateTime(1900, 1, 1); //SqlDateTime.Null;  
                }
                sup.NOTE = notes.Text;

                if (c1Expense.EditValue!=null)
                    sup.EXPACCID = int.Parse(c1Expense.EditValue.ToString());
                if (c1Grouping.EditValue != null)
                    sup.SUPGROUP = int.Parse(c1Grouping.EditValue.ToString());
                if (creditlimit.EditValue!=null)
                    sup.CREDITLIMIT = decimal.Parse(creditlimit.EditValue.ToString());
                if (c1Shipping.EditValue != null)
                    sup.DEFSHIPPING = int.Parse(c1Shipping.EditValue.ToString());
                if (c1Payment.EditValue!=null)
                    sup.DEFPAYMENT = int.Parse(c1Payment.EditValue.ToString());
                if (c1Terms.EditValue!=null)
                    sup.PAYTERMS = int.Parse(c1Terms.EditValue.ToString());
                var t = new SupplierManager();
                if(string.IsNullOrEmpty(supplierno))
                {
                    string r = t.AddSupplier(sup);
                    if (r =="1")
                    {
                        supplierno = Utils.SupplierNo;
                        vendorno.Text = Utils.SupplierNo;
                        XtraMessageBox.Show("Supplier Created", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    sup.SUPPLIERNO = supplierno;
                    foreach (DataRow d in dsMaster1.CONTACTMAST.Rows)
                        {
                            d["REFID"] = supplierno;
                            d["CONTTYPE"] = 2;
                        }
                    sup.DsContact = dsMaster1.CONTACTMAST;
                    bool flag = t.UpdateSupplier(sup);
                    XtraMessageBox.Show("Supplier updated", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        bool DoValidate()
        {
            bool retval = false;
            if (string.IsNullOrEmpty(vendorname.Text))
            {
                XtraMessageBox.Show("Please enter vendor name","POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                retval = true;
            }
            foreach (DataRow d in dsMaster1.CONTACTMAST.Rows)
            {
                int i = 0;
                if (d["ISPRIMARY"].ToString() == bool.TrueString)
                {
                    i++;
                }
                if (i > 1)
                {
                    XtraMessageBox.Show("Not more than one primary address","POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            return retval;
        }
        void DoNew()
        {
            isnew = true;
            vendorno.Text = "NEW";
            supplierno = string.Empty;
            dsMaster1.CONTACTMAST.Clear();
            gridControl1.ResetBindings();

            vendorname.Text = "";
            aliasname.Text = "";
            address.Text = ""; //1500,
            phoneno.Text = "";
            faxno.Text = "";//15
            status.Checked = true;
            email.Text = "";
            webpage.Text = ""; //60
            vendorsince.EditValue = null;
            accountno.Text = "";
            balanceasof.Enabled = true;
            balance.Enabled = true;
            balanceasof.EditValue = null;
            balance.Value = 0;
            notes.Text = "";
            c1Expense.EditValue = null;
            c1Grouping.EditValue = null;
            creditlimit.EditValue = 0;
            c1Shipping.EditValue = null;
            c1Payment.EditValue = null;
            c1Terms.EditValue = null;
            duedays.EditValue = 30;
        }
    }

}