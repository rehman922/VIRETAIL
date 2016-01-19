using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class CustomerPayment : XtraForm
    {
        public int userid { get; set; }
        public string shiftcode { get; set; }
        public int paytype = 1;
        bool F2keypress;
        public CustomerPayment()
        {
            InitializeComponent();
        }
        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            //lookupcustomer.Properties.DataSource 
            cUSTOMERBindingSource.DataSource = ClsGetData.GetCustomerList();
            cUSTOMERBindingSource.Filter = " CUSTOMERTYPE <> 1 ";
            dateEdit1.EditValue = DateTime.Now;
            shiftcode = new BLSales().GetShiftCode();
        }
        private void lookupcustomer_EditValueChanged(object sender, EventArgs e)
        {
            if(lookupcustomer.EditValue!=null)
            {
                GetCustomerDetails();
            }
        }
        void GetCustomerDetails()
        {
            var ds = new BLSales().GetSupCustUnPaidInvoices(lookupcustomer.EditValue.ToString());
            if(ds.Rows.Count > 0)
            {
                var bal = ds.Compute("SUM(balance)","");
                txtoutstanding.EditValue = bal;
                ledgers1.Merge(ds);
            }
            else
            {
                XtraMessageBox.Show("Data Not found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void AutoDistrubuteAmount(decimal appliedamt)
        {
            foreach (DataRow dr in ledgers1.APARMAIN.Rows)
            {
                if(appliedamt > decimal.Parse(dr["BALANCE"].ToString()))
                {
                    appliedamt = appliedamt - decimal.Parse(dr["BALANCE"].ToString());
                    dr["AmtApplied"] = dr["BALANCE"];
                }
                else if(appliedamt!=0)
                {
                    dr["AmtApplied"] = appliedamt;
                    appliedamt = 0;
                }
            }
        }
        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoApplyAutoAmt();
            }
        }
        void DoApplyAutoAmt()
        {
            if (txtappliedamt.EditValue != null)
            {
                if (decimal.Parse(txtappliedamt.EditValue.ToString()) >
                    decimal.Parse(txtoutstanding.EditValue.ToString()))
                {
                    XtraMessageBox.Show("Applied amount is more than the out standing amount", "POS",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtappliedamt.ErrorText = "Please check the amount";
                    txtappliedamt.ErrorIconAlignment = ErrorIconAlignment.MiddleLeft;
                }
                else
                {
                    AutoDistrubuteAmount(decimal.Parse(txtappliedamt.EditValue.ToString()));
                }
            }
        }
        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName=="AmtApplied")
            {
                var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if(decimal.Parse(dr["AmtApplied"].ToString()) > decimal.Parse(dr["BALANCE"].ToString()))
                {
                    dr["AmtApplied"] = decimal.Parse(dr["BALANCE"].ToString());
                }
                if (decimal.Parse(dr["AmtApplied"].ToString()) < 0)
                {
                    dr["AmtApplied"] = 0;
                }
            }
        }
        decimal GetTotalAppliedAmount()
        {
            var retamt = 0m;
            foreach (DataRow dr in ledgers1.APARMAIN.Rows)
            {
                if(!string.IsNullOrEmpty(dr["AmtApplied"].ToString()))
                    retamt += decimal.Parse(dr["AmtApplied"].ToString());
            }
            return retamt;
        }
       
        private void CustomerPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.F1)
            {
                KeyF9();
            }
            if (e.KeyCode == Keys.F2)
            {
                KeyF2();
            }
            if (e.KeyCode == Keys.D1)
            {
                paytype = 2;
                KeyF9();
            }
            //if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4)
            if (e.KeyCode == Keys.NumPad1 | e.KeyCode == Keys.D1 | e.KeyCode == Keys.NumPad2 | e.KeyCode == Keys.D2 | e.KeyCode == Keys.NumPad3| e.KeyCode == Keys.D3)
            {
                if (F2keypress)
                {
                    paytype = 2;
                    KeyCards();
                    textEdit1.Focus();
                }
            }
            if (e.KeyCode == Keys.D1)
            {
                paytype = 2;
                KeyF9();
            }
            if (e.KeyCode == Keys.F9)
            {
                F2keypress = true;
                if (textEdit1.EditValue == null)
                {
                    XtraMessageBox.Show("Please enter the card No.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                else
                {
                    paytype = 2;
                    KeyF9();
                }
            }


        }
        void KeyCards()
        {
            panel3.Visible = true;
            textEdit1.Focus();

        }

        void KeyF3()
        {
            lookupcustomer.EditValue = null;
            txtoutstanding.EditValue = 0;
            txtappliedamt.EditValue = 0;
            ledgers1.APARMAIN.Clear();
            textEdit3.EditValue = null;
            txtbalance.EditValue = null;
            
        }
        void KeyF9()
        {
            if (XtraMessageBox.Show("Do you want to save", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (GetTotalAppliedAmount() != decimal.Parse(txtappliedamt.EditValue.ToString()))
                {
                    XtraMessageBox.Show("Recevied amount is not matching with applied amount", "POS",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var bl = new BlCustomerPayments
                    {
                        customerno = lookupcustomer.EditValue.ToString(),
                        trandate = dateEdit1.DateTime.Date,
                        outstanding = decimal.Parse(txtoutstanding.EditValue.ToString()),
                        AppliedAmt = decimal.Parse(txtappliedamt.EditValue.ToString()),
                        AparmainDataTable = ledgers1.APARMAIN,
                        userid = userid,
                        shiftcode =shiftcode,
                        amountype = paytype
                    };

                    var ret = bl.DoSave();
                    txtbalance.EditValue = decimal.Parse(txtoutstanding.EditValue.ToString()) - decimal.Parse(txtbalance.EditValue.ToString());
                    if (ret == "1")
                    {
                        textEdit3.EditValue = Utils.CustomerReceipt;
                        XtraMessageBox.Show("Data Saved", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var blp = new GridPrintingClass();
                        blp.Heading1 = Utils.Companyname;
                        blp.Heading2 = "Customer Receipt  for  " + lookupcustomer.GetColumnValue("CUSTOMERNAME") + "";
                        blp.useHeading3 = true;
                        blp.Heading3 = " Date  = " +
                                       dateEdit1.DateTime.ToString("dd-MM-yyyy") + "   Paid Amount = " + txtappliedamt.EditValue + "";
                        blp.DoPrint(gridControl1);
                        button1.Visible = true;
                        button2.Visible = true;
                        panelcards.Visible = false;
                        panelcards.SendToBack();
                        lookupcustomer.EditValue = null;
                        txtoutstanding.EditValue = 0;
                        txtappliedamt.EditValue = 0;
                        Close();
                    }
                }
            }
        }
        void KeyF1()
        {
            KeyF9();
        }
        void KeyF2()
        {
            F2keypress = true;
            button1.Visible = false;
            button2.Visible = false;
            panelcards.Visible = true;
            panelcards.BringToFront();
            button5.Focus();

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void txtappliedamt_EditValueChanged(object sender, EventArgs e)
        {
           // textEdit1.EditValue = txtappliedamt.EditValue;
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KeyF9();
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (textEdit1.EditValue == null)
                {
                    XtraMessageBox.Show("Please enter the card No.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                else
                {
                    paytype = 2;
                    KeyF9();
                }
            }
        }

        private void txtappliedamt_Validated(object sender, EventArgs e)
        {
            DoApplyAutoAmt();
        }
        
    }

}