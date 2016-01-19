using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using VIRETAILDAL.Supplier;
using System.Collections;
using VIRETAILDAL.COMMON;
using System.Data.SqlTypes;
using BaseClasses;
namespace VIRETAILSTORE
{
    public partial class SupplierSetup : BaseRibbonForm
    {
        string supplierno="";
        BindingSource Bsnav = new BindingSource();
        public bool isnew = true;
        public SupplierSetup()
        {

            InitializeComponent();
            ItemClick += RibbonButtonsClick;
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
        private void SupplierSetup_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }
        private void SupplierSetup_Load(object sender, EventArgs e)
        {
            sHIPPINGMASTTableAdapter.Fill(dSPOSSTORE.SHIPPINGMAST);
            pAYTYPEMASTTableAdapter.Fill(dSPOSSTORE.PAYTYPEMAST);
            cUSTSUPGROUPSTableAdapter.FillBy(dSPOSSTORE.CUSTSUPGROUPS, 2);
            tERMSMASTTableAdapter.Fill(dSPOSSTORE.TERMSMAST);
            string c = "00000";//  this.cONTACTMASTTableAdapter.Fill(this.dSPOSSTORE.CONTACTMAST, '0',2);
            short s = 2;
            cONTACTMASTTableAdapter.Fill(dSPOSSTORE.CONTACTMAST,c,s);
            var supdataset = new DSPOSSTORETableAdapters.SUPPLIERTableAdapter();
            supdataset.Fill(dSPOSSTORE.SUPPLIER);
            SetNavigation();
        }
        #region BLL
        void DoSave(bool SaveEdit)
        {
            if (!DoValidate())
            {
                var sup = new Supplier();
                sup.DsContact = this.dSPOSSTORE.CONTACTMAST;
                sup.SUPPLIERNAME = vendorname.Text.Replace("'","") ;
                sup.ARSUPPLIERNAME=string.Empty;
                sup.ALTERNATENAME = aliasname.Text;
                sup.ADDRESS=address.Text   ; //1500,
                sup.PHONE=phoneno.Text;
                sup.FAX = faxno.Text ;//15
                sup.ACTIVE = bool.Parse(status.Checked.ToString());
                sup.CONTACAT = contact.Text;
                sup.DUEDAYS = (int) duedays.EditValue;
                sup.EMAILID = email.Text;
                sup.WEBPAGE= webpage.Text; //60
                if (duedays.EditValue != null)
                    sup.DUEDAYS = int.Parse(duedays.EditValue.ToString());
                if (vendorsince.EditValue != null)
                    //    if (!string.IsNullOrEmpty(vendorsince.EditValue.ToString()))
                    sup.VENDORSINCE =  DateTime.Parse(vendorsince.EditValue.ToString());
                else
                {

                    sup.VENDORSINCE = new DateTime(1900, 1, 1); //SqlDateTime.Null;  
                }
                //sup.VENDORSINCE =  vendorsince.Value.Date; 
                sup.ACCOUNTNO = accountno.Text;
                if(!string.IsNullOrEmpty(balanceasof.Text))
                        sup.BALANCE= decimal.Parse(balance.Value.ToString());
                //if(!string.IsNullOrEmpty(balanceasof.EditValue.ToString()))

                if (balanceasof.EditValue != null)
                    sup.BALANCEASOF = DateTime.Parse(balanceasof.EditValue.ToString());
                    
                else
                {

                    sup.BALANCEASOF = new DateTime(1900, 1, 1); //SqlDateTime.Null;  
                }
                sup.NOTE = notes.Text;

                if(!string.IsNullOrEmpty(c1Expense.SelectedText.ToString()))
                    sup.EXPACCID= int.Parse(c1Expense.SelectedValue.ToString()) ;
                if (!string.IsNullOrEmpty(c1Grouping.SelectedText.ToString()))
                    sup.SUPGROUP =int.Parse(c1Grouping.SelectedValue.ToString());
                sup.CREDITLIMIT = decimal.Parse(creditlimit.Value.ToString());
                if (!string.IsNullOrEmpty(c1Shipping.SelectedText.ToString()))
                     sup.DEFSHIPPING =  int.Parse(c1Shipping.SelectedValue.ToString()) ;
                if (!string.IsNullOrEmpty(c1Payment.SelectedText.ToString()))
                    sup.DEFPAYMENT = int.Parse(c1Payment.SelectedValue.ToString());
                if (!string.IsNullOrEmpty(c1Terms.SelectedText.ToString()))
                    sup.PAYTERMS = int.Parse(c1Terms.SelectedValue.ToString());
                var t = new SupplierManager();
                if (SaveEdit)
                {
                    string Returnval = t.AddSupplier(sup);
                    XtraMessageBox.Show(Returnval);
                }
                else
                {
                    sup.SUPPLIERNO = supplierno;
                    bool flag = t.UpdateSupplier(sup);
                    if (flag)
                    {
                        foreach (DataRow d in dSPOSSTORE.CONTACTMAST.Rows)
                        {
                            d["REFID"] = supplierno;
                            d["CONTTYPE"] = 2;
                        }
                        this.cONTACTMASTTableAdapter.Update(this.dSPOSSTORE.CONTACTMAST);
                        foreach (DataRow d in dSPOSSTORE.ADDRESSMAST.Rows)
                        {
                            d["REFID"] = supplierno;
                            d["CONTTYPE"] = 2;
                        }
                        this.addressmastTableAdapter1.Update(this.dSPOSSTORE.ADDRESSMAST);
                    }
                }
            }
        }
        bool DoValidate()
       {
           bool retval = false;
           if(string.IsNullOrEmpty(vendorname.Text))
           {
               XtraMessageBox.Show("Please enter vendor name");
               retval = true;
           }
           foreach(DataRow d in dSPOSSTORE.CONTACTMAST.Rows)
           {
               int i = 0;
               if(d["ISPRIMARY"].ToString()==bool.TrueString)
               {
                   i++;
               }
               if(i>1)
               {
                   XtraMessageBox.Show("Not more than one primary address");
               }
           }
           return retval;
       }
        void ViewData(Supplier sup)
        {
            isnew = false;
            //sup.DsContact = this.dSPOSSTORE.CONTACTMAST;
            vendorno.Text = sup.SUPPLIERNO;
            vendorname.Text = sup.SUPPLIERNAME;
            aliasname.Text = sup.ALTERNATENAME;
            address.Text=sup.ADDRESS; //1500,
            phoneno.Text=sup.PHONE;
            faxno.Text=sup.FAX;//15
            status.Checked = sup.ACTIVE;
            email.Text=sup.EMAILID ;
            webpage.Text=sup.WEBPAGE; //60
            balanceasof.Enabled = false;
            balance.Enabled = false;
            contact.Text = sup.CONTACAT;
            duedays.EditValue = sup.DUEDAYS;

            if (sup.VENDORSINCE.Year <= 1900 )
            {
                vendorsince.EditValue =null;
            }
            else
            {
                vendorsince.EditValue = sup.VENDORSINCE;
            }
            accountno.Text=sup.ACCOUNTNO;
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
            notes.Text=sup.NOTE ;
            //if (!string.IsNullOrEmpty(c1Expense.SelectedText.ToString()))
            c1Expense.SelectedValue=sup.EXPACCID;
            //if (!string.IsNullOrEmpty(c1Grouping.SelectedText.ToString()))
            c1Grouping.SelectedValue = sup.SUPGROUP;
            creditlimit.Value=  sup.CREDITLIMIT ;
            //if (!string.IsNullOrEmpty(c1Shipping.SelectedText.ToString()))
            c1Shipping.SelectedValue = sup.DEFSHIPPING;
            //if (!string.IsNullOrEmpty(c1Payment.SelectedText.ToString()))
            c1Payment.SelectedValue = sup.DEFPAYMENT;
            //if (!string.IsNullOrEmpty(c1Terms.SelectedText.ToString()))
            c1Terms.SelectedValue = sup.PAYTERMS;
            this.addressmastTableAdapter1.Fill(this.dSPOSSTORE.ADDRESSMAST, supplierno, 2);
            foreach (DataRow d in dSPOSSTORE.ADDRESSMAST.Rows)
            {
                Address.CITY = d["CITY"].ToString();
                Address.COUNTRY = d["COUNTRY"].ToString();
                Address.STREET = d["STREET"].ToString();
                Address.ZIPCODE = d["ZIPCODE"].ToString();
            }
            //var t = new SupplierManager();
            //string Returnval = t.AddSupplier(sup);
            //XtraMessageBox.Show(Returnval);
        }
        void DoNew()
        {
            isnew = true;
            this.supplierno = "000000";
            string c = "00000";
            short s = 2;
            this.cONTACTMASTTableAdapter.Fill(this.dSPOSSTORE.CONTACTMAST, c, s);
            vendorname.Text = "";
            aliasname.Text = "";
            address.Text = ""; //1500,
            phoneno.Text = "";
            faxno.Text = "";//15
            status.Checked = true ;
            email.Text = "";
            webpage.Text = ""; //60
            vendorsince.EditValue = null;
            accountno.Text ="";
            balanceasof.Enabled = true;
            balance.Enabled = true;
            balanceasof.EditValue = null;
            balance.Value = 0;
            notes.Text = "";
            c1Expense.SelectedValue = 0;
            c1Grouping.SelectedValue = 0;
            creditlimit.Value = 0;
            c1Shipping.SelectedValue = 0;
            c1Payment.SelectedValue =0;
            c1Terms.SelectedValue =0;
        }
        #endregion
        #region Navigation
        void SetNavigation()
        {
            Bsnav.DataSource = dSPOSSTORE.SUPPLIER;
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
            RibbonSaveEnable = false;
            MoveRecord();
            HoldButtonVisibility = BarItemVisibility.Never;
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
            RibbonSaveEnable = false;
        }
         void MoveRecord()
         {
             DataRow dr = dSPOSSTORE.SUPPLIER.FindBySUPPLIERNO(supplierno);
             var sup = new Supplier(dr);
             cONTACTMASTTableAdapter.Fill(dSPOSSTORE.CONTACTMAST, supplierno, 2);
             sup.DsContact = dSPOSSTORE.CONTACTMAST;
             addressmastTableAdapter1.Fill(dSPOSSTORE.ADDRESSMAST, supplierno, 2);
             foreach (DataRow d in dSPOSSTORE.ADDRESSMAST.Rows)
             {
                 Address.STREET = d["street"].ToString();
                 Address.ZIPCODE = d["ZIPCODE"].ToString();
                 Address.CITY = d["city"].ToString();
                 Address.COUNTRY = d["country"].ToString();
                 Address.REFID = supplierno;
             }
             ViewData(sup);
         }
        #endregion
       private void simpleButton1_Click(object sender, EventArgs e)
         {
             var f = new AddressDetails();

             f.ShowDialog();
             string add = Address.STREET + "\r\n" + "\r\n" + Address.CITY + Address.ZIPCODE + "\r\n" + Address.COUNTRY;
             if(!string.IsNullOrEmpty(Address.CITY) || !string.IsNullOrEmpty(Address.STREET) || !string.IsNullOrEmpty(Address.ZIPCODE) || !string.IsNullOrEmpty(Address.COUNTRY))
                address.Text = add;
         }
       private void notes_TextChanged(object sender, EventArgs e)
       {

       }

       private void gridView1_InitNewRow_1(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
       {
           var view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
           if (view.DataRowCount == 0)
               view.SetRowCellValue(e.RowHandle, view.Columns["ISPRIMARY"], true);
           else
           {
               view.SetRowCellValue(e.RowHandle, view.Columns["ISPRIMARY"], false);
           }
       }
    }
} 
