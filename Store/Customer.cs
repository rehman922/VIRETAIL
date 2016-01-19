using System;
using System.Data;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class Customer : BaseRibbonForm
    {
        public string _customerno = string.Empty;
        private BindingSource Bsnav = new BindingSource();
        public Customer()
        {
            InitializeComponent();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
           // customertype.SelectedIndex = 0;
            customertype.EditValue=0;
            RibbonPageMoreOptionsVisible = false;
            comboBoxEdit1.SelectedIndex = 0;
            ClearButtonVisibility = BarItemVisibility.Never;
            HoldButtonVisibility = BarItemVisibility.Never;
            ItemClick += RibbonButtonsClick;
            SetNavigation();
            Ribbonname = "Customer";
            bindingSource1.DataSource = typeof(CustomerError);
            try
            {
                custmobile.DataBindings.Add(new Binding("EditValue", bindingSource1, "CustomerId", true));
                customername.DataBindings.Add(new Binding("EditValue", bindingSource1, "CustomerName", true));
                customertype.DataBindings.Add(new Binding("EditValue", bindingSource1, "CustomerType", true));
                txtmemno.DataBindings.Add(new Binding("EditValue", bindingSource1, "MemberNo", true));
                dxErrorProvider1.DataSource = bindingSource1;
                dxErrorProvider1.ContainerControl = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dsMaster1.Merge(ClsGetData.GetInsuranceByCust("0"));
            Loginname = Utils.Username;

        }

        void SetNavigation()
        {
            dsMaster1.Merge(ClsGetData.GetCustomerList());
            Bsnav.DataSource = dsMaster1.CUSTOMER;
            
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
        bool ValidateCustomer()
        {
            var errl = new CustomerError
            {
                CustomerType = customertype.EditValue.ToString() ,
                CustomerName = customername.EditValue == null ? null : customername.EditValue.ToString(),
                CustomerId = custmobile.EditValue == null ? null : custmobile.EditValue.ToString(),
                CustomerNo = _customerno,
                MemberNo = txtmemno.EditValue == null ? null : txtmemno.EditValue.ToString()
            };
            bindingSource1.Add(errl);
            if(dxErrorProvider1.HasErrors)
            {
                XtraMessageBox.Show("Please check the error", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (customertype.EditValue.ToString() == "1" && iNSURANCEDISCBindingSource.Count == 0)
            {
                XtraMessageBox.Show("Please enter the insurance discount details","POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        void DoSave(string option)
        {
            if (ValidateCustomer()) return;
            var bl = new BlCustomer();
            var newrow =(DsMaster.CUSTOMERRow) new DsMaster().CUSTOMER.NewRow();
            newrow.CUSTNO = _customerno;
            newrow.CUSTOMERTYPE = int.Parse(customertype.EditValue.ToString());
            newrow.CUSTCOMP = custcomp.Text;
            newrow.CUSTOMERNAME = customername.Text;
            newrow.CUSTOMERID = custmobile.Text;
            newrow.EMAIL = custemail.Text;
            newrow.PHONE = custphone.Text;
            newrow.Mobile = custmobile.Text;
            newrow.NOTE = custnote.Text;
            newrow.FIXDISC = custfixdisc.Checked;
            newrow.PAYTYPE = comboBoxEdit1.SelectedIndex;
            if(customertype.EditValue.ToString() =="0")
                newrow.MEMBERNO = int.Parse(txtmemno.EditValue.ToString());
            if (custfixdiscperc.EditValue!=null)
                newrow.FIXDISCAMTPER = decimal.Parse(custfixdiscperc.EditValue.ToString());
            if (iNSURANCEDISCBindingSource.Count > 0 && customertype.EditValue.ToString() == "1")
            {
                bl.InsurancediscDataTable = dsMaster1.INSURANCEDISC;
            }
            bl.CustomerRow = newrow;
            try
            {
                var retval = bl.DoSave();
                if (retval == "1")
                {
                    _customerno = bl.Customerno;
                    XtraMessageBox.Show("Data Saved", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (iNSURANCEDISCBindingSource.Count > 0)
                    {
                        //var addedRows = from row in dsMaster1.INSURANCEDISC
                        //    where row.RowState == DataRowState.Added  select row;
                        //foreach (var row in addedRows.ToArray())
                        //{row.Delete();} dsMaster1.Merge(COMMON.ClsGetData.GetInsuranceByCust(_customerno));
                        //dsMaster1.AcceptChanges();
                    }
                    if(option=="1")
                    {Dispose(); }
                    if (option == "2")
                    {DoNew();}
                   // SetNavigation();
                }
                else
                {
                    XtraMessageBox.Show(retval, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DoNew()
        {
            if(iNSURANCEDISCBindingSource.Count >0)
                dsMaster1.INSURANCEDISC.Clear();

            custcomp.EditValue = null;
            customername.EditValue = null;
            customerid.EditValue = null;
            custnote.EditValue = null;
            custphone.EditValue = null;
            custmobile.EditValue = null;
            custemail.EditValue = null;
            custnote.EditValue = null;
            custfixdisc.Checked = false;
            custfixdiscperc.EditValue = 0;
           _customerno = string.Empty;
            customertype.Enabled = false;

            txtmemno.EditValue = null;

            customertype.EditValue = 0;

        }
        void DoSaveClose()
        {
            DoSave("1");
        }
        void DoSaveNew()
        {
            DoSave("2");
        }
        void DoDelete()
        {}
        void DoPrint()
        {}
        void DoMovePrev()
        {
            if (Bsnav.Position <= 0)
            {
                MoveNextEnable = true;
                MovePrevEnable = false;
                Bsnav.MoveFirst();
            }
            else
            {
                MovePrevEnable = true;
                Bsnav.MovePrevious();
            }
            
            MoveNextEnable = true;
            var current = (DataRowView)Bsnav.Current;
            _customerno = current["CUSTNO"].ToString();
            DoView();

        }
        void DoMoveNext()
        {
            if (Bsnav.Position == Bsnav.Count-1)
            {
                MoveNextEnable = false;
                MovePrevEnable = true;
                Bsnav.MoveLast();
            }
            else
            {
                MovePrevEnable = true;
                Bsnav.MoveNext();
            }
            
            var current = (DataRowView)Bsnav.Current;
            _customerno = current["CUSTNO"].ToString();
            DoView();
        }
        public void DoView()
        {
            if (!string.IsNullOrEmpty(_customerno))
            {
                var dr = dsMaster1.CUSTOMER.FindByCUSTNO(_customerno);
                dsMaster1.INSURANCEDISC.Clear();
                if (dr == null) return;

                if(dr.CUSTOMERTYPE==1)
                {
                   dsMaster1.Merge(ClsGetData.GetInsuranceByCust(_customerno));
                   grouplevels.Visible = true;
                }
                else if (dr.CUSTOMERTYPE == 0)
                {
                    customertype.Enabled = true;
                    if(!dr.IsMEMBERNONull())
                        txtmemno.EditValue = dr.MEMBERNO;
                }

                customertype.EditValue = dr.CUSTOMERTYPE;
                custcomp.Text = dr.CUSTCOMP;
                customername.Text = dr.CUSTOMERNAME;
                customerid.Text = dr.CUSTOMERID;
                custphone.Text = dr.PHONE;
                custmobile.Text = dr.Mobile;
                custemail.Text = dr.EMAIL;
                custnote.Text = dr.NOTE;
                custfixdisc.Checked = dr.FIXDISC;
                custfixdiscperc.EditValue = dr.FIXDISCAMTPER;
                comboBoxEdit1.SelectedIndex = dr.PAYTYPE;
            }
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
                    DoSave("0");
                    break;
                case "BSAVEANDCLOSE":
                    DoSaveClose();
                    break;
                case "BSAVEANDNEW":
                    DoSaveNew();
                    break;
                case "BDELETE":
                    DoDelete();
                    break;
                case "BPRINT":
                    DoPrint();
                    break;
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
            }
        }
        
        void ChkCustomerByMemNo(string memno)
        {
            var blc = new BlCustomer();
            blc.GetCustomerByMemno(int.Parse(memno));
            if (blc.CustomerRow == null) return;
            customertype.Enabled = true;
            _customerno = blc.CustomerRow.CUSTNO;
            customertype.EditValue = blc.CustomerRow.CUSTOMERTYPE;
            custcomp.Text = blc.CustomerRow.CUSTCOMP;
            customername.Text = blc.CustomerRow.CUSTOMERNAME;
            customerid.Text = blc.CustomerRow.CUSTOMERID;
            custphone.Text = blc.CustomerRow.PHONE;
            custmobile.Text = blc.CustomerRow.Mobile;
            custemail.Text = blc.CustomerRow.EMAIL;
            custnote.Text = blc.CustomerRow.NOTE;
            custfixdisc.Checked = blc.CustomerRow.FIXDISC;
            custfixdiscperc.EditValue = blc.CustomerRow.FIXDISCAMTPER;
            comboBoxEdit1.SelectedIndex = blc.CustomerRow.PAYTYPE;
        }
        private void txtmemno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || e.KeyCode != Keys.Tab) return;
            if (txtmemno.EditValue != null)
            {
                ChkCustomerByMemNo(txtmemno.Text);
            }
        }

        private void customertype_EditValueChanged(object sender, EventArgs e)
        {
            txtmemno.Enabled = false;   
            if(customertype.EditValue==null) return;
            
            if (customertype.EditValue.ToString() == "1")
            {
                grouplevels.Visible = true;
            }
            else
            {
                grouplevels.Visible = false;
            }
            if (customertype.EditValue.ToString() == "0")
            {
                txtmemno.Enabled = true;
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}
