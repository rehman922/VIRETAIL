using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;

namespace Store
{
    public partial class AmtCollection : XtraForm
    {
       // public decimal roundingamt = 0;
        private decimal _NetAmount;
        private decimal _Recdamount;
        private Point txtloc = new Point(294, 97);
        Size txtwidth = new Size(179, 46);
        public int paytype1 = 0;
        public bool _issucess;
        private bool _isKeyF9Press;
        private Ledgers.SalesAmountDetailsDataTable dt = new Ledgers().SalesAmountDetails;
        public DsInventory.SALESMAINRow SalesmainRow;
        public DsInventory.SALESINVDETAILDataTable Salesinvdetail;
        public bool iscredit = false;
        public bool _isRedim = false;
        private int _paytype;
        private bool _enterkeypress;
        private string salestype = "A";
        SerialPort ComPort = new SerialPort();
        AdoSync cls = new AdoSync();

        public AmtCollection()
        {
            InitializeComponent();
        }
        private void AmtCollection_Load(object sender, EventArgs e)
        {

            
        }
        public decimal NetAmount
        {
            get
            {
                return _NetAmount;
            }
            set
            {
                _NetAmount = value;
                txtnetamt.EditValue = _NetAmount;
              
            }
        }
        public decimal RecdAmount
        { 
            get { return _Recdamount;}
            set
            {
                   _Recdamount = value;
                   if (_Recdamount == NetAmount)
                    {
                        Enablebuttons();  
                       // simpleButton1.Focus();
                        txtbal.Text = "0";
                    }
                   else if (_Recdamount >= NetAmount &&  NetAmount > 0)
                    {
                        //var bl = (_Recdamount - NetAmount).ToString("N2");
                        //txtbal.Text = bl;
                        Enablebuttons();
                      //  simpleButton1.Focus();
                    }
                   else if (_Recdamount < NetAmount && NetAmount > 0)
                    {
                        Enablebuttons(false);  
                      //simpleButton1.Focus();
                        //var bl = (_Recdamount - NetAmount).ToString("N2");
                        //txtbal.Text = bl;
                    }
                  if (NetAmount < 0 && _Recdamount != NetAmount)
                  {
                      Enablebuttons(false);   
                  }
               } 
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isKeyF9Press) return;
                if (RecdAmount >= NetAmount)
                {
                    var cashamt = txtcash.EditValue == null ? 0 : decimal.Parse(txtcash.EditValue.ToString());
                    var creditamt = txtaccount.EditValue == null ? 0 : decimal.Parse(txtaccount.EditValue.ToString());
                    var spancard = txtspan.EditValue == null ? 0 : decimal.Parse(txtspan.EditValue.ToString());
                    var creditcardamt = txtcredit.EditValue == null ? 0 : decimal.Parse(txtcredit.EditValue.ToString());
                    if (Paytype > 3)
                    {
                        if (cashamt + creditamt + spancard + creditcardamt > NetAmount)
                        {
                            XtraMessageBox.Show("Please check the amount", "POS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }
                    _isKeyF9Press = true;
                    DoTaKePayment();
                }
                else
                {
                    XtraMessageBox.Show("Please check the amount", "POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _isKeyF9Press = false;
                }
            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DoTaKePayment(bool isprintinv=false)
        {
            simpleButton1.Enabled = false;
            try
            {
                if (txtcard1.EditValue != null)
                {
                    if (decimal.Parse(txtcard1.EditValue.ToString()) > 0)
                        SalesmainRow.CREDICARDTNO = txtcard1.Text;
                }
                else
                {
                    SalesmainRow.CREDICARDTNO = "";
                }
 
                var cashamt = txtcash.EditValue == null ? 0: decimal.Parse(txtcash.EditValue.ToString()) - decimal.Parse(txtbal.EditValue.ToString());
                var creditamt = txtaccount.EditValue == null ? 0 : decimal.Parse(txtaccount.EditValue.ToString());
                var spancard = txtspan.EditValue == null ? 0 : decimal.Parse(txtspan.EditValue.ToString());
                var creditcardamt = txtcredit.EditValue == null ? 0 : decimal.Parse(txtcredit.EditValue.ToString());
                //var roundingamt = txtrounding.EditValue == null ? 0 : decimal.Parse(txtrounding.EditValue.ToString());

                SalesmainRow.CASHAMOUNT = cashamt;
                SalesmainRow.CARDAMOUNT = creditcardamt + spancard;
                SalesmainRow.CREDITAMT = creditamt; //SalesmainRow.ROUNDOFF = roundingamt;
                SalesmainRow.RECDAMT = cashamt;
                SalesmainRow.CREDICARDTYPE = paytype1;
                SalesmainRow.ISSALE = true;
                SalesmainRow.POSTED = true;
                SalesmainRow.HOLDDEFAULT = false;
                SalesmainRow.HOLDNO = 0;

                //dr.CUSTOMERID = lookupcustomer.EditValue == null ? null : lookupcustomer.EditValue.ToString();
                //dr.CUSTNAME = lookupcustomer.EditValue == null ? "Cash" : lookupcustomer.SelectedText;


                if (NetAmount == cashamt)
                {
                    SalesmainRow.INVAMTTYPE = 1;
                    // SalesmainRow.SALESTYPE = "A";
                }
                else if (NetAmount == creditamt)
                {
                    SalesmainRow.INVAMTTYPE = 2;
                    SalesmainRow.CARDNO = 0;
                }
                else if (NetAmount == spancard)
                    SalesmainRow.INVAMTTYPE = 3;
                else if (NetAmount == creditcardamt)
                    SalesmainRow.INVAMTTYPE = 3;
                else if (NetAmount < 0)
                {
                    SalesmainRow.INVAMTTYPE = 4;
                }
                else
                {
                    SalesmainRow.INVAMTTYPE = 5;
                }
                if (txtcard1.EditValue != null)
                {
                    SalesmainRow.CREDICARDTNO = txtcard1.Text;
                }
                ////
                if (cashamt > 0)
                {
                    AddRow(cashamt, 1);
                }
                if (cashamt < 0)
                {
                    AddRow(cashamt, 1);
                }

                if (creditcardamt > 0)
                {
                    AddRow(creditcardamt, 2);
                }
                if (creditcardamt < 0)
                {
                    AddRow(creditcardamt, 2);
                }
                if (spancard > 0)
                {
                    AddRow(spancard, 2);
                }
                if (spancard < 0)
                {
                    AddRow(spancard, 2);
                }
                if (creditamt > 0)
                {
                    AddRow(creditamt, 3);
                }
                if (creditamt < 0)
                {
                    AddRow(creditamt, 3);
                }

                if (SalesmainRow.SALESTYPE == "I")
                {
                    /* oLD cal
                     var companydisc = (SalesmainRow.NETAMT) * (Convert.ToDecimal(SalesmainRow.CARDDISC) / 100);
                     var companydisc = (SalesmainRow.NETAMT) * (SalesmainRow.CUSTOMERFIXDISC / 100);
                     var amt = companydisc - companydisc * (Convert.ToDecimal(SalesmainRow.CARDDISC) / 100); */
                   //var act = (SalesmainRow.NETAMT) * (Convert.ToDecimal(SalesmainRow.CARDDISC) / 100);
                  //var netamt = (SalesmainRow.NETAMT) * (SalesmainRow.CUSTOMERFIXDISC / 100);
                    var companydisc = (SalesmainRow.NETAMT)*(SalesmainRow.CUSTOMERFIXDISC/100);
                    // var amt = companydisc - companydisc * (Convert.ToDecimal(SalesmainRow.CARDDISC) / 100); 
                    // var amt = SalesmainRow.NETAMT - (act + netamt);
                    /* New cal
               var compdisc = SalesmainRow.NETAMT * (Convert.ToDecimal(SalesmainRow.CUSTOMERFIXDISC) / 100);*/
                    var customerdisc = (SalesmainRow.NETAMT - companydisc)*
                                       (Convert.ToDecimal(SalesmainRow.CARDDISC)/100);
                    var amt1 = SalesmainRow.NETAMT - companydisc - customerdisc;
                    AddRow(amt1, 3);
                    creditamt = amt1;
                }
                // RETURN
                if (cashamt < 0)
                {
                    AddRow(-1*(SalesmainRow.TOTALAMT + SalesmainRow.RETURNAMT), 5);
                }
                if (SalesmainRow.RETURNAMT < 0)
                {
                    AddRow(-1*SalesmainRow.RETURNAMT, 6);
                }
                // non calu
                if (SalesmainRow.SDISC > 0)
                {
                    if (_isRedim)
                    {
                        AddRow(SalesmainRow.SDISC, 7);
                    }
                    else
                    {
                        AddRow(SalesmainRow.SDISC, 7);
                    }
                }
                if (SalesmainRow.ROUNDOFF != 0)
                {
                    AddRow(SalesmainRow.ROUNDOFF, 8);
                }
                //Assign Cost value
                new BLSales().UpdateCostprice(ref Salesinvdetail);
                var profit = new BLSales().CaluculateProfitValue(Salesinvdetail);
                if (NetAmount > 0)
                {
                    AddRow(profit, 9);
                    // AddRow((profit / NetAmount *100), 10);
                }
                SalesmainRow.TRANDATE = DateTime.Now;
                SalesmainRow.CREDITAMT = creditamt;
                // SalesmainRow.ROUNDOFF = roundingamt;
                SalesmainRow.HOLDNO = 0;
                SalesmainRow.HOLDDEFAULT = false;
                var bl = new BLSales
                {
                    Salesinvdetail = Salesinvdetail,
                    SalesmainRow = SalesmainRow,
                    SalesAmount = dt
                };
                var ret = bl.DoSave();
                if (ret == "1")
                {
                    if (_isRedim)
                    {
                        bl.UpdatePointsDetails(SalesmainRow.CUSTOMERID,SalesmainRow.SDISC * 100,SalesmainRow.COMPANY,SalesmainRow.TRANDATE,SalesmainRow.SINVNO,SalesmainRow.SDISC);
                    }
                    _issucess = true;
                    panel2.Visible = false;
                    btnok.Focus();
                  if (Utils.DefaultPrinterRow["ISDEFAULT"].ToString() == bool.TrueString)
                            bl.DoSlipPrint(SalesmainRow.SINVNO);


                 }
                else
                {
                    _issucess = false;
                    XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void AddRow(decimal amt,int type)
        {
            var dr = (Ledgers.SalesAmountDetailsRow)dt.NewRow();

            dr.SALEINVNO = SalesmainRow.SINVNO;
            dr.SHIFTCODE = SalesmainRow.SHITFCODE;
            dr.TRANDATE = DateTime.Now;
            dr.CUSTOMERID = SalesmainRow.CUSTOMERID;
            dr.CUSTTYPE = SalesmainRow.SALESTYPE;
            dr.AMOUNT = amt;
            dr.AMOUNTTYPE = type;
            dr.COMPANY = Utils.Company;
            dr.USERID = Utils.Userid;
            dr.DAYCLOSE = false;
            dt.Rows.Add(dr);
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            _issucess = true;
            DoTaKePayment(true);
            try
            {
                 var bl = new BLSales();
                if (Utils.DefaultPrinterRow["ISDEFAULT"].ToString() == bool.TrueString)
                {

                    bl.DoSlipPrint(SalesmainRow.SINVNO);
                }
                 else
                    {
                        bl.DoPrint(SalesmainRow.SINVNO);
                    }
            }
            catch (Exception ex)
            { }
        }
        private void AmtCollection_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F3)
            //{
            //    txtrounding.EditValue = 0;
            //    txtcard1.EditValue = string.Empty;
            //    txtcredit.EditValue = 0;
            //    txtcash.EditValue = 0;
            //    txtrounding.EditValue = 0;
            //}
            if(e.KeyCode==Keys.Enter)
            {
                _enterkeypress = true;
            }
            if(e.KeyCode==Keys.Escape)
            {
                if(panel2.Visible)
                    Close();
            }
            if (!_isKeyF9Press)
            {
                if (e.KeyCode == Keys.F9)
                {
                    _isKeyF9Press = true;
                    if (panel2.Visible)
                    {
                        // if (RecdAmount >= NetAmount)
                        if (simpleButton1.Enabled)
                            DoTaKePayment();
                        else
                            XtraMessageBox.Show("Please check the amount", "POS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                }
                if (e.KeyCode == Keys.F4)
                {
                    _isKeyF9Press = true;
                    if (panel2.Visible)
                    {
                        //if (RecdAmount >= NetAmount)
                        if (simpleButton1.Enabled)
                            DoTaKePayment(true);
                        else
                            XtraMessageBox.Show("Please check the amount", "POS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                }
            }
        }
        #region keydowns
        /*
        private void txtcash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _enterkeypress = true;
                var rs = GetAmount();
                RecdAmount = rs;
            //    SendKeys.Send("{TAB}");
            }
            //if (e.KeyCode == Keys.Down && !_enterkeypress)
            //{
            //  //  SendKeys.Send("{TAB}");
            //    //txtcash.EditValue = 0;
            //    //txtcredit.EditValue = 0;
            //    //txtspan.EditValue = 0;
            //    //txtaccount.EditValue = 0;
            //    //txtcredit.EditValue = NetAmount;
            //    SendKeys.Send("{TAB}");
            //    //txtcredit.Focus();
            //}
            //else if (e.KeyCode == Keys.Down && _enterkeypress)
            //{
            //    SendKeys.Send("{TAB}");
            //  // e.Handled = true;
            //}
        }
        private void txtcredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _enterkeypress = true;
                var rs = GetAmount();
                RecdAmount = rs;
                txtcard1.Properties.ReadOnly = false;
                txtcard1.TabStop = true;
               // SendKeys.Send("{TAB}");
            }
            //if (e.KeyCode == Keys.Down && !_enterkeypress)
            //{
            //    //txtcash.EditValue = 0;
            //    //    txtcredit.EditValue = 0;
            //    //    txtspan.EditValue = 0;

            //    //txtaccount.EditValue = 0;
            //    //txtspan.EditValue = NetAmount;
            //    SendKeys.Send("{TAB}");
            //   // txtspan.Focus();
            //}
            //else if (e.KeyCode == Keys.Down && _enterkeypress)
            //{
            //    SendKeys.Send("{TAB}"); 
                
            //}
        }
        private void txtcard1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (simpleButton1.Enabled)
                {
                    simpleButton1.Focus();
                }
            }
            //else
            //{
            //    txtspan.Focus();
            //}
        }
        private void txtspan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _enterkeypress = true;
                var rs = GetAmount();
                RecdAmount = rs;
                //if (txtaccount.Visible)
                //{
                //    txtaccount.Focus();
                //}
            }
            //if (e.KeyCode == Keys.Down && !_enterkeypress)
            //{
            //    if (txtaccount.Visible)
            //    {
            //        txtcash.EditValue = 0;
            //        txtcredit.EditValue = 0;
            //        txtspan.EditValue = 0;
            //        txtaccount.EditValue = 0;
            //        txtaccount.EditValue = NetAmount;
            //        SendKeys.Send("{TAB}");
            //        txtaccount.Focus();
            //    }
            //    else if (e.KeyCode == Keys.Down && _enterkeypress)
            //    {
            //        SendKeys.Send("{TAB}");
            //    }
            //}
        }
        private void txtaccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _enterkeypress = true;
                var rs = GetAmount();
                RecdAmount = rs;
              //  SendKeys.Send("{TAB}");
            }
            //if (e.KeyCode == Keys.Down && !_enterkeypress)
            //{
            //    if (!txtaccount.Properties.ReadOnly)
            //    {
            //        txtcash.EditValue = 0;
            //        txtcredit.EditValue = 0;
            //        txtspan.EditValue = 0;
            //        txtaccount.EditValue = 0;
            //        txtcash.EditValue = NetAmount;
            //        txtcash.Focus();
            //    }
            //    else if (e.KeyCode == Keys.Down && _enterkeypress)
            //    {
            //        SendKeys.Send("{TAB}");
            //    }
            //}
        }
          */
        #endregion
        decimal GetAmount()
        {
            var v1 = txtcash.EditValue == null ? 0 : decimal.Parse(txtcash.EditValue.ToString());
            var v2 = txtcredit.EditValue == null ? 0 : decimal.Parse(txtcredit.EditValue.ToString());
            var v3 = txtspan.EditValue == null ? 0 : decimal.Parse(txtspan.EditValue.ToString());
            var v4 = txtaccount.EditValue == null ? 0 : decimal.Parse(txtaccount.EditValue.ToString());
            var v5 = txtrounding.EditValue   == null ? 0: decimal.Parse(txtrounding.EditValue.ToString());
            return v1 + v2 + v3 + v4 + v5;
        }
        void Enablebuttons(bool tr = true)
        {
            simpleButton1.Enabled = tr;
            simpleButton2.Enabled = tr;
            //if (tr)
            //    simpleButton1.Focus();
        }
        private void txtcredit_Enter(object sender, EventArgs e)
        {
            txtcredit.SelectAll();
        }
        private void txtspan_Enter(object sender, EventArgs e)
        {
            txtspan.SelectAll();
        }
        private void txtaccount_Enter(object sender, EventArgs e)
        {
            txtaccount.SelectAll();
        }
        private void txtcash_Enter(object sender, EventArgs e)
        {
            txtcash.SelectAll();
        }
        private void textEdit4_Enter(object sender, EventArgs e)
        {
            txtrounding.SelectAll();
        }
        private void txtcard1_Enter(object sender, EventArgs e)
        {
            txtcard1.SelectAll();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtrounding_EditValueChanged(object sender, EventArgs e)
        {
            if(txtrounding.EditValue!=null)
            {
                if (decimal.Parse(txtrounding.EditValue.ToString()) < 1 && decimal.Parse(txtrounding.EditValue.ToString()) < decimal.Parse(txtcash.EditValue.ToString()))
                {
                    if (decimal.Parse(txtcash.EditValue.ToString()) == NetAmount)
                    {
                        var vl = decimal.Parse(txtcash.EditValue.ToString()) -
                                            decimal.Parse(txtrounding.EditValue.ToString());
                        txtcash.EditValue = vl;
                                            
                        var rs = GetAmount();
                        RecdAmount = rs;
                    }
                    else
                    {
                        var rs = GetAmount();
                        RecdAmount = rs;
                    }
                }
            }
        }
        private void txtcash_EditValueChanged(object sender, EventArgs e)
        {
            var t = (TextEdit) sender;
            RecdAmount = GetAmount();
            var tval = GetAmount() - NetAmount;
            txtbal.EditValue = tval;
            if(tval < 0 )
            {
                t.EnterMoveNextControl = true;
            }


            //var t = (TextEdit) sender;
            //if(t.EditValue!=null)
            //{
            //    var tval =  decimal.Parse(t.EditValue.ToString()) - NetAmount;

            //    txtbal.EditValue = tval;

            //    RecdAmount = decimal.Parse(t.EditValue.ToString());
            //}
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public int Paytype
        {
            get { return _paytype; }
            set
            {
                      _paytype = value;
                    if(value==0)
                    {
                        RecdAmount = _NetAmount;
                        txtcash.EditValue = _NetAmount;
                        txtbal.Visible = true;
                        lblbalance.Visible = true;


                        lblspan.Visible = false;
                        txtspan.Visible = false;

                        lblcreditcard.Visible = false;
                        txtcredit.Visible = false;

                        lblaccount.Visible = false;
                        txtaccount.Visible = false;
                    }
                    if(value==1)
                     {
                         RecdAmount = _NetAmount;
                         lblcash.Text = "Card :";

                         lblcash.Visible = true;
                         txtcash.Visible = false;

                         txtspan.Visible = true;
                         txtspan.EditValue = _NetAmount;
                         txtspan.Enabled = false;

                         txtspan.Size =txtwidth;
                         txtaccount.Visible = false;

                         txtbal.Visible = false;

                         lblbalance.Visible = false;
                         txtspan.Location = txtloc;

                     }
                    if(value==2)
                    {
                        RecdAmount = _NetAmount;
                       lblcash.Text = "Card :";

                       // lblcash.Visible = false;

                        txtcash.Visible = false;
                        
                        txtspan.Visible = false;
                        
                        txtcredit.Visible = true;

                        txtaccount.Visible = false;

                        txtcredit.EditValue = _NetAmount;

                        txtcard1.Visible = true;
                        lblcardno.Visible = true;

                        txtbal.Visible = false;
                        lblbalance.Visible = false;

                        txtcredit.Size = txtwidth;
                        txtcredit.Location = txtloc;
                    }
                    if (value == 3)
                    {
                        RecdAmount = _NetAmount;
                        lblcash.Text = "Credit Amount:";

                        lblcash.Visible = false;

                        txtcash.Visible = false;
                        
                        txtspan.Visible = false;
                        txtcredit.Visible = false;

                        lblaccount.Visible = true ;

                        txtaccount.Visible = true;

                        txtaccount.EditValue = _NetAmount;
                        txtbal.Visible = false;
                        lblbalance.Visible = false;

                        txtaccount.Size = txtwidth;
                        txtaccount.Location = txtloc;
                        lblaccount.Location = new Point(109, 104);
                    }
                    if (value == 4)
                    {
                        //All  WITH OUT ACCOUNT";;

                        lblcash.Visible = true;
                        txtcash.Visible = true;

                        lblspan.Visible = true;
                        txtspan.Visible = true;

                        lblcreditcard.Visible = true;
                        txtcredit.Visible = true;

                        lblaccount.Visible = false;
                        txtaccount.Visible = false;
                        if(_NetAmount > 0 )
                            txtcash.EditValue = _NetAmount;
                        else
                        {
                            RecdAmount = 0;
                        }
                        txtbal.Visible = true;
                        lblbalance.Visible = true;

                        txtcard1.Visible = true;
                        lblcardno.Visible = true;

                        lblcardno.Location = new Point(526,177);
                        txtcard1.Location = new Point(494,205);
                    }
                    if (value == 5)
                    {
                        //lblcash.Text = "ALL WITH ACCOUNT";
                        lblcash.Visible = true;
                        txtcash.Visible = true;
                         


                        lblspan.Visible = true;
                        txtspan.Visible = true;

                        lblcreditcard.Visible = true;   
                        txtcredit.Visible = true;

                        lblaccount.Visible = true;
                        txtaccount.Visible = true;

                        txtbal.Visible = true;
                        lblbalance.Visible = true;
                        RecdAmount = 0;
                    }
                } 
             }
        private void txtcash_KeyDown(object sender, KeyEventArgs e)
        {
            var t = (TextEdit)sender;
            if(e.KeyCode==Keys.Enter)
            {
                RecdAmount = GetAmount();
                if (t.Name == "txtcredit")
                {
                    txtcard1.Focus(); 
                } 
                else if (t.Name == "txtcard1")
                {
                    FocusToButtons();
                }
                else if( RecdAmount>=NetAmount)
                {
                    txtcash.EnterMoveNextControl = false;
                    FocusToButtons();
                }
                CustDiplay();
            }
        }

        private void CustDiplay()
        {
            //var st = ClsGetData.GetSysCode("POLE");
            //if (string.IsNullOrEmpty(st)) return;
            //var stall = st.Split(new[] {','});
            //if (stall.Length > 0)
            //{
            //    ComPort.PortName = Convert.ToString(stall[0]);
            //    string[] ArrayComPortsNames = SerialPort.GetPortNames();
            //    bool comok = false;
            //    foreach (string cportname in ArrayComPortsNames)
            //    {
            //        if (cportname == Convert.ToString(stall[0]))
            //        {
            //            comok = true;
            //        }
            //    }
            //    if (!comok)
            //    {
            //        return;
            //    }
            //    ComPort.BaudRate = Convert.ToInt32(stall[1]);
            //    ComPort.DataBits = Convert.ToInt16(stall[2]);
            //    ComPort.StopBits = (StopBits) Enum.Parse(typeof (StopBits), stall[3]);
            //    ComPort.Handshake = (Handshake) Enum.Parse(typeof (Handshake), stall[4]);
            //    ComPort.Parity = (Parity) Enum.Parse(typeof (Parity), stall[5]);
            //    if (!ComPort.IsOpen)
            //    {
            //        ComPort.Open();
            //    }
            //    ComPort.Write("\f");
            //    ComPort.Write("\r");
            //    ComPort.WriteLine(String.Format("Balance = {0} ", decimal.Parse(txtbal.Text).ToString("N")));
                cls.DisplayComm("Change",decimal.Parse(txtbal.Text).ToString("N"));
          //  }
        }

        void  FocusToButtons()
         {
             if (simpleButton1.Enabled)
             {
                 simpleButton1.Focus();
             }
         }
        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void txtbal_EditValueChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}