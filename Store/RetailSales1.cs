using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RetailSales1 : RibbonForm
    {
        #region vars
        private bool isreturn;
        private int _doctorid;
        private bool _DISCONSALE;
        private bool validateoff;
        private List<string> NotifyItems;
        private int _rowhandle;
        private int prepcnt;
        private List<string> Listinvno = new List<string>();
        private bool _allowmandisc;
        private bool _disableshortcut;
        SerialPort ComPort = new SerialPort();
        AdoSync cls = new AdoSync();
        public bool _isRedim = false;
        #endregion
        #region Form Events
        public RetailSales1()
        {
            this.InvokeEx(lv => InitializeComponent());
        }
        private void RetailSales1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.V)
            //{
            //    IDataObject data = Clipboard.GetDataObject();
            //    foreach (var item in data.GetFormats(true))
            //    {
            //        object o = data.GetData(item);
            //        // do something with o
                    
            //    }
            //   // Console.WriteLine(data.GetFormats(true));
            //}

            if (e.Control && e.KeyCode == Keys.Enter)
            {
                KeyCtrlR();
                return;
            }
            if (e.Control && e.KeyCode == Keys.F2)
            {
                KeyCtrlP();
                return;
            }
            if (e.Control && e.KeyCode == Keys.F3)
            {
                KeyCtrlC();
                return;
            }
            if (e.Shift)
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    var str = dr["ITEMNAME"] + " " + "C.Price = " + dr["CPRICE"] ;
                    XtraMessageBox.Show(str, "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbarcode.Focus();
                }
            }

            switch (e.KeyCode)
            {
                case Keys.F1:
                    KeyF1();
                    break;
                case Keys.F2:
                    KeyF2();
                    break;
                case Keys.F3:
                    KeyF3();
                    break;
                case Keys.F4:
                    KeyF4();
                    break;
                case Keys.F5:
                    KeyF5();
                    break;
                case Keys.F6:
                    if (!_disableshortcut)
                    {
                        KeyF6();
                    }
                    break;
                case Keys.F7:
                    KeyF7();
                    break;
                case Keys.F8:
                    KeyF8();
                    break;
                case Keys.F9:
                    _disableshortcut = true;
                     KeyF9();
                    _disableshortcut = false;
                    break;
                case Keys.F10:
                    KeyF10();
                    break;
                case Keys.F11:
                    if (!_disableshortcut)
                    {
                        KeyF11();
                    }
                    break;
                case Keys.F12:
                    KeyCtrlR();
                    break;
            }
        }
        private void RetailSales_Load(object sender, EventArgs e)
        {
         
           try{
            if (Utils.Userid == 0)
            {
                var f = new Login();
                f.ShowDialog();
                if (!f.LoginSucess)
                    Close();
            }
            this.InvokeEx((lv => LoadDataSets()));
            barcomp.Caption = Utils.Company;
            if (ClsGetData.GetDailyClosing().Rows.Count == 0)
            {
                var frm = new InitialCash();
                frm.ShowDialog();
            }
            
            barButtonItem14.Caption  = "Shitf Code = " + new BLSales().GetShiftCode();
            // new BLSales().GetShiftCode("POINTS")
            gridControl1.Invalidate();
            validateoff = false;

            //repositoryItemTextEdit4.Mask.EditMask = "\\d+";
            //repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtfileno.Properties.Mask.EditMask = "\\d+";
            txtfileno.Properties.Mask.MaskType = MaskType.RegEx;

            txtvisitno.Properties.Mask.EditMask = "\\d+";
            txtvisitno.Properties.Mask.MaskType = MaskType.RegEx;

            //txtqty.Properties.Mask.EditMask = "\\d+";
            //txtvisitno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

           NotifyItems = new List<string>();
            //  dsMaster1.Merge(COMMON.ClsGetData.GetItemMastList());
            LoadSessionUsers();

            var bl = new BLSales();
            bl.GetNonSaleInv();
            if (bl.Salesinvdetail != null)
            {
            if (bl.Salesinvdetail.Rows.Count > 0)
            {
                bl.DoHold(bl.SalesmainRow.SINVNO, 1, bl.SalesmainRow.CUSTOMERID, bl.SalesmainRow.CUSTNAME,
                    bl.SalesmainRow.SDISC, bl.SalesmainRow.ROUNDOFF);
            }
            }
        if (LoadHoldedInvoices())
            {
                if (bl.SalesmainRow != null)
                {
                    if (!bl.SalesmainRow.IsSDISCNull())
                    {
                        if(!bl.SalesmainRow.IsCUSTOMERIDNull())
                        {
                            lookupcustomer.EditValue = bl.SalesmainRow.CUSTOMERID;
                            if(!bl.SalesmainRow.IsGRADENull())
                            {
                                cmbclass.EditValue = bl.SalesmainRow.GRADE;
                            }
                            if (!bl.SalesmainRow.IsCARDIDNull())
                            {
                               txtfileno.EditValue  = bl.SalesmainRow.CARDID;
                            }
                            if (!bl.SalesmainRow.IsCARDNONull())
                            {
                                txtvisitno.EditValue = bl.SalesmainRow.CARDNO;
                            }
                            if (!bl.SalesmainRow.IsCUSTNAMENull())
                            {
                                var sp = bl.SalesmainRow.CUSTNAME.Split('-');
                                if (sp.Length > 1)
                                {
                                    txtpatname.Text = sp[1];
                                }
                            }
                        }
                        txtdiscount.EditValue = bl.SalesmainRow.SDISC;
                        subtotal.EditValue = bl.SalesmainRow.TOTALAMT;
                        txtnetamt.EditValue = bl.SalesmainRow.NETAMT;
                    }

                    txtinvoiceno.Caption = bl.SalesmainRow[0].ToString().Trim();
                    dsInventory1.SALESINVDETAIL.Clear();
                    dsInventory1.Merge(bl.Salesinvdetail);
                    foreach (DsInventory.SALESINVDETAILRow dr in dsInventory1.SALESINVDETAIL.Rows)
                    {
                        if (!dr.IsEXPDATENull())
                            dr["EXPDATE1"] = dr.EXPDATE.ToString("MM-yy");
                    }
                    UpdateTotal();
                }
                else
                {
                    txtinvoiceno.Caption = new BLSales().GetInvoiceNo().Trim();
                    DoSave();
                }
            }
            }
            catch(Exception ext)
            {
                 XtraMessageBox.Show(ext.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          //  SetUpComm();
        }
        private void RetailSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sALESINVDETAILBindingSource.Count > 0)
            {

                XtraMessageBox.Show("Incomplete sales present in the counter\r\n Please complete the sales", "POS",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        #endregion
        #region TextBox Events
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
           if (txtbarcode.EditValue != null)
                if (e.Control && e.KeyCode == Keys.Enter)
                {
                    return;
                }
            if (e.KeyCode == Keys.Enter)
            {
                lblmutilpleprice.Visible = false;
                AddLineItem();
            }
            if (e.KeyCode == Keys.Down && gridView1.DataRowCount > 0)
            {
                gridControl1.Focus();
                if (lblmutilpleprice.Visible)
                {
                    //gridView1.FocusedColumn = colSPRICE;
                    Rectangle cellRect = GetCellRect(gridView1, gridView1.FocusedRowHandle, gridView1.FocusedColumn);
                    var p = new Point(cellRect.X, cellRect.Y);
                   // popupControlContainer1.Visible = true;
                    //popupControlContainer1.BringToFront();
                    popupControlContainer1.ShowPopup(gridControl1.PointToScreen(p));
                    popupControlContainer1.Focus();
                    gridControl2.Focus();
                }
            }
        }
        private void txtpatname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Tab)
            {
                txtbarcode.Focus();
            }
        }
        private void cutomerpayment_EditValueChanged(object sender, EventArgs e)
        {
            if (cutomerpayment.EditValue == null)
                return;
           
            if (txtnetamt.EditValue != null)
            {
                if (decimal.Parse(cutomerpayment.EditValue.ToString()) >= 0)
                {
                    labelControl20.Visible = true;
                    txtnetins.Visible = true;

                    var compdisc = decimal.Parse(cmbclass.GetColumnValue("COMPDISC").ToString());
                    txtnetins.EditValue = (decimal.Parse(txtnetamt.EditValue.ToString()) - (decimal.Parse(txtnetamt.EditValue.ToString()) * compdisc / 100)) * (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);

                    //var compdisc = decimal.Parse(cmbclass.GetColumnValue("COMPDISC").ToString());
                   // txtnetins.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) * (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);
                    //txtnetins.EditValue =  (decimal.Parse(txtnetamt.EditValue.ToString()) -(decimal.Parse(txtnetamt.EditValue.ToString()) * compdisc/100 )) * (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);
                }
            }
            //if (decimal.Parse(cutomerpayment.EditValue.ToString()) < 0)
            //{
            //    txtnetins.EditValue = 0;
            //    labelControl20.Visible = false;
            //    txtnetins.Visible = false;
            //}
        }
        private void lookupcustomer_EditValueChanged(object sender, EventArgs e)
        {
            txtcustomer.Text = null;
            if (lookupcustomer.EditValue == null)
                return;
            txtcustomer.Text = lookupcustomer.Text;
            var ctype = int.Parse(lookupcustomer.GetColumnValue("CUSTOMERTYPE").ToString());
            if (ctype == 1)
            {
                iNSURANCEDISCBindingSource.DataSource = ClsGetData.GetInsuranceByCust(lookupcustomer.EditValue.ToString());
                panelinsurance.Visible = true;
                panelnormalcustomer.Visible = false;
                ClearTxtBoxex();
                txtfileno.Focus();
            }
            else
            {
                panelinsurance.Visible = false;
                panelnormalcustomer.Visible = true;
                ClearTxtBoxex();
                txtavailble.EditValue = string.IsNullOrEmpty(lookupcustomer.GetColumnValue("SERVERPOINTS").ToString()) ? 0 : decimal.Parse(lookupcustomer.GetColumnValue("SERVERPOINTS").ToString());
                txtfixdis.EditValue = string.IsNullOrEmpty(lookupcustomer.GetColumnValue("FIXDISCAMTPER").ToString()) ? 0 : decimal.Parse(lookupcustomer.GetColumnValue("FIXDISCAMTPER").ToString());
                txtcrlimit.EditValue = string.IsNullOrEmpty(lookupcustomer.GetColumnValue("FIXDISCAMTPER").ToString()) ? 0 : decimal.Parse(lookupcustomer.GetColumnValue("CREDITLIMIT").ToString());
                txtbarcode.Focus();
            }
            if (ctype == 1)
            {
                if (txtdiscount.EditValue != null)
                {
                    if (decimal.Parse(txtdiscount.EditValue.ToString()) > 0)
                    {
                        XtraMessageBox.Show("Discount not applied for insurance customers", "POS", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        RecallDiscount();
                    }
                }
            }
        }
        private void cmbclass_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbclass.EditValue != null)
            {
                cutomerpayment.EditValue = cmbclass.GetColumnValue("DISC"); 
                txtnetins.EditValue = 0;
                labelControl20.Visible = true;
                txtnetins.Visible = true;
               // txtnetins.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) * (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);
                var compdisc = decimal.Parse(cmbclass.GetColumnValue("COMPDISC").ToString());
                txtnetins.EditValue = (decimal.Parse(txtnetamt.EditValue.ToString()) - (decimal.Parse(txtnetamt.EditValue.ToString()) * compdisc / 100)) * (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);

            }
        }
        private void lookupcustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (lookupcustomer.EditValue != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var ctype = int.Parse(lookupcustomer.GetColumnValue("CUSTOMERTYPE").ToString());
                    if (ctype == 1)
                    {
                        labelControl20.Visible = true;
                        txtnetins.Visible = true;
                        txtfileno.Focus();
                        //txtnetins.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) *
                        //                      (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);
                    }
                    else
                    {
                        txtbarcode.Focus();
                    }
                }
            }
        }
        private void txtnetamt_EditValueChanged(object sender, EventArgs e)
        {
            var ctype = 0;
            if (lookupcustomer.EditValue != null)
            {
                ctype = int.Parse(lookupcustomer.GetColumnValue("CUSTOMERTYPE").ToString());
            }
            if (ctype == 1)
            {
                if (txtnetamt.EditValue != null)
                {
                    if (cutomerpayment.EditValue!=null)
                    if (decimal.Parse(cutomerpayment.EditValue.ToString()) >= 0)
                    {
                        labelControl20.Visible = true;
                        txtnetins.Visible = true;
                      //var compdisc = decimal.Parse(cmbclass.GetColumnValue("COMPDISC").ToString());
                        var compdisc = decimal.Parse(cmbclass.GetColumnValue("COMPDISC").ToString());
                        txtnetins.EditValue = (decimal.Parse(txtnetamt.EditValue.ToString()) - (decimal.Parse(txtnetamt.EditValue.ToString()) * compdisc / 100)) * (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);

                        //txtnetins.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) *
                        //                      (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);
                    }
                }
            }
        }
        private void txtrounding_EditValueChanged(object sender, EventArgs e)
        {
            if (txtrounding.EditValue != null)
            {
                //var ret = decimal.Parse(txtnetamt.EditValue.ToString());
                //var re = Math.Round(ret, MidpointRounding.AwayFromZero);
                //txtnetamt.EditValue = re;

                var ret = decimal.Parse(subtotal.EditValue.ToString()) + decimal.Parse(txtreturnamt.EditValue.ToString()) - decimal.Parse(txtdiscount.EditValue.ToString());
                txtnetamt.EditValue = ret + (txtrounding.EditValue == null ? 0 : decimal.Parse(txtrounding.EditValue.ToString()));
            }
           else
           {
                 var ret = decimal.Parse(subtotal.EditValue.ToString()) +
                        decimal.Parse(txtreturnamt.EditValue.ToString())- decimal.Parse(txtdiscount.EditValue.ToString());
               txtnetamt.EditValue = ret;
           }
            //txtnetamt.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) +  decimal.Parse(txtrounding.EditValue.ToString());
        }
        #endregion
        #region BLLS
        void LoadDataSets()
        {
            //iTEMMASTBindingSource.DataSource = ClsGetData.GetItemMastList();
            dsMaster1.Merge(ClsGetData.GetCustomerList());
            dsMaster1.Merge(ClsGetData.GetEmployees());
            repositoryItemLookUpEdit1.DataSource = dsMaster1.USERINFO;
        }
        private void DoNew()
        {
            txtcustomer.EditValue = null;
            KeyF8(false);
            dsInventory1.SALESINVDETAIL.Clear();
            gridControl1.ResetBindings();
            UpdateTotal();
            lookupcustomer.EditValue = null;
            txtfileno.EditValue = null;
            txtvisitno.EditValue = null;
            cmbclass.EditValue = null;
            cutomerpayment.EditValue = null;
            txtpatname.EditValue = null;
            txtrounding.EditValue = 0;
            
            panelinsurance.Visible = false;
            panelnormalcustomer.Visible = false;
            txtreturnamt.EditValue = 0;
            
            subtotal.EditValue = 0;

            txtdiscount.EditValue = 0;
            txtnetamt.EditValue = 0;
            txtdiscper.EditValue = 0;
            txtnetins.EditValue = 0;
            cutomerpayment.EditValue = null;

            txtinvoiceno.Caption = new BLSales().GetInvoiceNo();
            LoadSessionUsers();
            DoSave();
            txtbarcode.Focus();
            txtbarcode.SelectAll();
            prepcnt = 0;
            dsMaster1.Merge(ClsGetData.GetCustomerList());


        //   _allowmandisc = false;
        }
        void DoSave()
        {
            var bl = new BLSales();
            var ret = bl.DoSave(txtinvoiceno.Caption.Trim(), false, lookupcashier.EditValue == null ? 0 : int.Parse(lookupcashier.EditValue.ToString()), _doctorid);
            if (ret != "1")
            {
                XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        void DoClear()
        {
            if (_disableshortcut)
            {
                XtraMessageBox.Show("Customer already re-dim his points please continue the sales");
                return;
            }
            KeyF8(false);
            var cln = dsInventory1.SALESINVDETAIL.Copy();
            foreach (DataRow dr in cln.Rows)
            {
                DoDeleteRow(dr);
            }
            txtcustomer.EditValue = null;
            lookupcustomer.EditValue = null;
            txtfileno.EditValue = null;
            txtvisitno.EditValue = null;
            cmbclass.EditValue = null;
           
            txtpatname.EditValue = null;
            txtrounding.EditValue = 0;
            txtdiscount.EditValue = 0;
            txtdiscper.EditValue = 0;
            txtreturnamt.EditValue = 0;
            txtnetins.EditValue = null;
            cutomerpayment.EditValue = null;
            UpdateTotal();
            lblmutilpleprice.Visible = false;
            txtbarcode.Focus();
        }
        void SetUpComm()
        {
            //var st = ClsGetData.GetSysCode("POLE");
            //if (string.IsNullOrEmpty(st)) return;
            //var stall = st.Split(new[] { ',' });
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
            //        XtraMessageBox.Show("Customer display not setup Please check", "POS", MessageBoxButtons.OK,
            //            MessageBoxIcon.Information);
            //        return;
            //    }
            //    ComPort.BaudRate = Convert.ToInt32(stall[1]);
            //    ComPort.DataBits = Convert.ToInt16(stall[2]);
            //    ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stall[3]);
            //    ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), stall[4]);
            //    ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), stall[5]);

            //    if (ComPort.IsOpen)
            //    {
            //        ComPort.Close();
            //    }

            //    ComPort.Open();
            //}
        }
        string SpaceswithString(string iname,bool isleft=true)
        {
            StringBuilder sb = new StringBuilder();
            if (isleft) sb.Append(iname);
            for (int i = 0; i < (20 - iname.Length); i++)
            {
                sb.Append(" ");
            }
            if (!isleft) sb.Append(iname);
            return sb.ToString();
        }
        void CustomerDisplay(string itemno, decimal price)
        {
           
            cls.DisplayComm(itemno, price.ToString("N"));
            //if (ComPort.IsOpen)
            //{
            //    ComPort.Write("\v");
            //    if (itemno.Length > 20)
            //    {
            //        ComPort.WriteLine(String.Format("{0}", itemno.Substring(1, 20)));
            //    }
            //    else
            //    {
            //        ComPort.WriteLine(SpaceswithString(itemno));
            //    }
            //    ComPort.Write("\r");
            //    ComPort.WriteLine(SpaceswithString(price.ToString("N"), false));
            //}
        }
        Rectangle GetCellRect(GridView view, int rowHandle, GridColumn column)
        {

            var info = (GridViewInfo)view.GetViewInfo();

            var cell = info.GetGridCellInfo(rowHandle, column);

            if (cell != null)

                return cell.Bounds;

            return Rectangle.Empty;

        }
        void AddMultipleItems(DsInventory.STOCKMASTERDataTable ds, string itemname, bool isblankrow = false)
        {
            validateoff = true;
             var dt = dsInventory1.SALESINVDETAIL;
            foreach (DsInventory.STOCKMASTERRow d in ds.Rows)
            {
                var qty = 1;
                var newrow = (DsInventory.SALESINVDETAILRow)dt.NewRow();
                if (!d.IsDQNTYNull())
                    if (d.DQNTY > 0)
                    {
                        if (isreturn)
                        {
                            qty = -d.DQNTY;
                        }
                        else
                        {
                            qty = d.DQNTY;
                        }
                        newrow.QTY = qty;
                        var tot = Math.Round((qty * d.SPRICE), 2);
                        newrow.ITEMNAME = itemname;
                        newrow.STOCKID = d.STOCKID;
                        newrow.ITEMNO = d.ITEMNO;
                        newrow.SINVNO = txtinvoiceno.Caption.Trim();
                        newrow.BARCODE = d.BARCODE;
                        var aQty = new BLSales().GetAvailableQty(d["ITEMNO"].ToString());
                        newrow.STOCK = aQty;
                        newrow.ASTOCK = d.IsSQTYNull() ? 0: d.SQTY;
                        newrow.INVRATE = d.SPRICE;
                        newrow.SPRICE = d.SPRICE;

                        newrow.CPRICE = d.CPRICE;
                        newrow.ISRETURN = isreturn;
                        if (!isreturn)
                            newrow.DISCONSALE = _DISCONSALE;

                        if (!d.IsEXPDATENull())
                        {
                            newrow.EXPDATE = d.EXPDATE;
                            newrow.EXPDATE1 = d.EXPDATE.ToString("MM-yy");
                        }
                        else
                        {
                            newrow["EXPDATE"] = DBNull.Value;
                            newrow.EXPDATE1 = string.Empty;
                        }
                        newrow.BONUS = 0;
                        newrow.LINETOTAL = tot;




                        if (!d.IsDISCNull())
                        {
                            if (d.DISC > 0)
                            {
                                newrow.LINETOTAL = tot - (tot * d.DISC) / 100;
                            }
                        }
                       
                        newrow.DOCTORID = _doctorid;
                        newrow.EXTDISC = 0;
                        dt.Rows.Add(newrow);
                        // customer display(

                      //  
                        CustomerDisplay(
                            newrow.ITEMNAME.Length > 20 ? newrow.ITEMNAME.Substring(1, 20) : newrow.ITEMNAME,
                            newrow.LINETOTAL);
                        //end customer display

                      //var bl = new BLSales().UpdateDetails(dsInventory1.SALESINVDETAIL);
                        var ret = "0";
                        var bl = new BLSales();
                        if (!isblankrow)
                        {
                            if (!isreturn)
                            {
                                ret = bl.UpdateQtyAndSalesTable(d.STOCKID, -d.DQNTY, dsInventory1.SALESINVDETAIL);
                                    // new BLSales().UpdateQty(d.STOCKID, -d.DQNTY);
                            }
                            else if (isreturn)
                            {
                                if (d.STOCKID > 0)
                                {
                                    ret = bl.UpdateQtyAndSalesTable(d.STOCKID, d.DQNTY, dsInventory1.SALESINVDETAIL);
                                        // new BLSales().UpdateQty(d.STOCKID, d.DQNTY);
                                }
                                else
                                {
                                    ret = bl.UpdateDetails(dsInventory1.SALESINVDETAIL); //ret = "1";
                                }
                            }
                        }
                        else
                        {
                            ret = bl.UpdateDetails(dsInventory1.SALESINVDETAIL);
                        }
                        if (ret != "1")
                             {
                               XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                dsInventory1.SALESINVDETAIL.AcceptChanges();
                 
            
               
              } 
            }
            sALESINVDETAILBindingSource.EndEdit();
            if (isreturn)
            {  
                UpdateTotal();
                gridControl1.Focus();
                gridView1.FocusedColumn = colINVRATE;
                colDISC.OptionsColumn.ReadOnly = false;
                colDISC.OptionsColumn.AllowEdit = true;
                gridView1.ShowEditor();
            }
            else
            {
                colDISC.OptionsColumn.AllowEdit = false;
            }
            validateoff = false;

        }
        void AdditemsToList(object sender, GetDataRowEventArgs g)
        {
            var current = g.SelectedRow;
            txtbarcode.Text = current["ITEMNO"].ToString();
            txtbarcode.SendKey(new KeyEventArgs(Keys.Enter));
        }
        void AdditemsToRetun(object sender, GetDataRowEventArgs g)
        {
            var t = (SalesInvList)sender;
            if (t.Isreturn)
            {
                KeyF8();
                DoReturn(g.SelectedRow, true);
            }
        }
        void AddItems()
        {
           
                    var frm = new FrmItemLookUp();
                    //frm.filtertext = GetLastRowText();
                    frm.EventSelectedItem += AdditemsToList;
                    frm.closeonselect = true;
                    if (txtbarcode.EditValue != null)
                        frm.filtertext = txtbarcode.EditValue.ToString();
                    frm.ShowDialog();
            
        }
        void AddLineItem()
        {
            DataRow current = null;
            if (txtbarcode.EditValue != null)
            {
                var blf = new BlItemMaster().FindItemByBarCode(txtbarcode.EditValue.ToString());
                if (blf.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Item master not found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbarcode.SelectAll();
                    return;
                }
                foreach (DataRow dr in blf.Rows)
                {
                    current = dr;
                }
            }
            else
            {
                return;
            }
            _DISCONSALE = false;
            var SPRICE = 0m;
            var CPRICE = 0m;
            var purdiscout = 0m;
            if (!string.IsNullOrEmpty(current["DISCOUNT"].ToString()))
                purdiscout = decimal.Parse(current["DISCOUNT"].ToString());
            if (!string.IsNullOrEmpty(current["SPRICE"].ToString()))
                SPRICE = decimal.Parse(current["SPRICE"].ToString());
            if (!string.IsNullOrEmpty(current["CPRICE"].ToString()))
            {
                CPRICE = decimal.Parse(current["CPRICE"].ToString());
            }
            txtbarcode.EditValue = string.Empty;
            if (isreturn)
            {
                DoReturn(current);
                return;
            }
            var bl = new BLSales();
            var aQty = bl.GetAvailableQty(current["ITEMNO"].ToString());
            if (aQty > 0)
            {
                CheckForMultiStock(current["ITEMNO"].ToString(), current["ITEMNAME"].ToString());
            }
            else
            {
                var drstock = new BLSales().GetStockItem(current["ITEMNO"].ToString(), "S");
                var dStockmasterRow = (DsInventory.STOCKMASTERRow)dsInventory1.STOCKMASTER.NewRow();
                if(drstock.Rows.Count==0)
                {
                 dStockmasterRow.ITEMNO = current["ITEMNO"].ToString();
                 dStockmasterRow.BARCODE = current["BARCODE"].ToString();
                 dStockmasterRow.DQNTY = 1;
                 dStockmasterRow.CPRICE = CPRICE;
                 dStockmasterRow.QTY = 0;
                 SPRICE = new BLSales().GetSalesPriceByItemno(current["ITEMNO"].ToString());
                 dStockmasterRow.SPRICE = SPRICE;
                }
                else
                {
                    var topRows = drstock.Rows.Cast<DataRow>().Take(1).CopyToDataTable();
                    foreach (DataRow drs in topRows.Rows)
                    {
                        dStockmasterRow.DQNTY = 1;
                        dStockmasterRow.ItemArray = drs.ItemArray;
                    }
                }
                //if (SPRICE == 0)
                //{
                //    SPRICE = new BLSales().GetSalesPriceByItemno(current["ITEMNO"].ToString());
                //}
                var f = LoadQtyMoreForm(current["ITEMNO"].ToString(), current["ITEMNAME"].ToString(), aQty, 1, 0, 1, dStockmasterRow.SPRICE, true, true, dStockmasterRow, purdiscout);
                if (f.iscontinue == 1)
                {
                    //GetStockItemBySprice
                    var dnewstock = new BLSales().GetStockItem(current["ITEMNO"].ToString(), "S");
                    if (f.salesprice != dStockmasterRow.SPRICE)
                    {
                        dnewstock = new BLSales().GetStockItemBySprice(current["ITEMNO"].ToString(), f.salesprice);
                    }

                    foreach (DsInventory.STOCKMASTERRow dr in dnewstock.Rows)
                    {
                        dr.DQNTY = f.enterqty;
                        dr.SPRICE = f.salesprice;
                    }
                    // var topRows = dnewstock.AsEnumerable().OrderBy(o => o.Field<int>("STOCKID")).Take(1).ToList().CopyToDataTable();
                    string itemno = current["ITEMNO"].ToString();
                    var t = NotifyItems.Find(match => match == itemno);
                    if (t != null)
                        NotifyItems.Add(itemno);
                    AddMultipleItems(dnewstock, current["ITEMNAME"].ToString(), f.isBlankStock);
                }
            }

            UpdateTotal();

            txtbarcode.EditValue = String.Empty;
            //}
        }
        void SelectCustomer(object sender, GetDataRowEventArgs g)
        {
            var current = g.SelectedRow;
            lookupcustomer.EditValue = current["CUSTNO"].ToString();
        }
        bool CheckForMultiStock(string itemno, string itemname)
        {
            var bl = new BLSales();
            var drstock = new BLSales().GetStockItem(itemno, "S");
            var dprice = bl.GetDisctinctSprices(drstock);
            int cnt = dprice.Count();
            var stk = new DsInventory.STOCKMASTERDataTable();// var topRows = drstock.AsEnumerable().OrderBy(o => o.Field<int>("STOCKID")).Take(1).ToList().CopyToDataTable();
            DataTable topRows = drstock.Rows.Cast<DataRow>().Take(1).CopyToDataTable();
            // object[] topRows = drstock.Select( * ", "EXPDATE ASC ");
            DataRow dr = stk.NewRow();
            foreach (DataRow drs in topRows.Rows)
            {
                drs["DQNTY"] = 1;
                dr.ItemArray = drs.ItemArray;
            }
            stk.Rows.Add(dr);
            AddMultipleItems(stk, itemname);
            if (cnt > 1)
            {
                onePing();
                lblmutilpleprice.Visible = true;
                gridControl2.DataSource = drstock;
            }
            else
            {
                gridControl2.DataSource = null;
            }
            return cnt > 0;
        }
        void LoadMultiLineItems(string itemno, string itemname, int aQty)
        {
            var bl = new BLSales();
            var drstock = new BLSales().GetStockItem(itemno, "S");
            AddMultipleItems(bl.GetQtyRows(drstock, aQty), itemname);
        }
        StockShow LoadQtyMoreForm(string itemno, string itemname, int stock, int qtyorder, int qtybalance, int enteredqty, decimal sprice, bool showsprice, bool isblankrow, DsInventory.STOCKMASTERRow dr, decimal purdiscout)
        {
            var f = new StockShow
            {
                itemno = itemno,
                itemname = itemname,
                qtyonhand = stock,
                qtyonorder = qtyorder,
                qtybalance = qtybalance,
                enterqty = enteredqty,
                salesprice = sprice,
                showsalesprice = showsprice,
                isBlankStock = isblankrow,
                cdisc = purdiscout,
                DStockmasterRow = dr
            };
            f.ShowDialog();
            return f;
        }
        void UpdateTotal()
        {
            decimal _subtotal = 0m;
            decimal _retamt = 0m;
            foreach (DsInventory.SALESINVDETAILRow dr in dsInventory1.SALESINVDETAIL.Rows)
            {
                if (dr.RowState != DataRowState.Deleted)
                {
                    if (!dr.IsLINETOTALNull())
                    {
                        if (dr.LINETOTAL > 0)
                            _subtotal += dr.LINETOTAL;
                        else
                            _retamt += dr.LINETOTAL;
                    }
                }
            }
            subtotal.EditValue = _subtotal;
            txtreturnamt.EditValue = _retamt;
            txtnetamt.EditValue = _subtotal + _retamt ;
            if (decimal.Parse(txtdiscount.EditValue.ToString()) != 0)
            {
                txtnetamt.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) - decimal.Parse(txtdiscount.EditValue.ToString());   
            }
            if (decimal.Parse(txtnetamt.EditValue.ToString()) == 0)
                txtrounding.EditValue = 0;
            if (txtrounding.EditValue != null)
                txtnetamt.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) + decimal.Parse(txtrounding.EditValue.ToString());
        }
        bool LoadHoldedInvoices()
        {
            Listinvno.Clear();
            var dt = new BLSales().GetHoldInvno();
            if (dt.Rows.Count > 1)
            {
                lblcustomeronhold.Visible = true;
                foreach (DataRow dataRow in dt.Rows)
                {
                    Listinvno.Add(dataRow[0].ToString());
                }
                if (Listinvno[0] == txtinvoiceno.Caption.Trim())
                    DoView(Listinvno[1]);
                else
                    DoView(Listinvno[0]);
                return false;
            }
            if (dt.Rows.Count == 1)
            {
                lblcustomeronhold.Visible = false;
                foreach (DataRow dr in dt.Rows)
                {
                    DoView(dr[0].ToString());
                }
                return false;
            }
            return true;
        }
        void DoView(string invno)
        {
             
            txtinvoiceno.Caption = invno;
            dsInventory1.Clear();

            var bl = new BLSales();
            bl.GetSalesInvDetail(invno);
            var salesdt = bl.GetSalesInvMainBySinvno(invno);

            dsInventory1.Merge(bl.Salesinvdetail);

            foreach(DsInventory.SALESMAINRow dr  in salesdt.Rows)
            {
               if(! dr.IsSDISCNull() )
               {
                  txtdiscount.EditValue = dr.SDISC;
               }
                if (!dr.IsCUSTOMERIDNull())
                {
                    lookupcustomer.EditValue = dr.CUSTOMERID;
                    if (!dr.IsCARDIDNull())
                        txtfileno.EditValue = dr.CARDID;
                    if(!dr.IsCARDDISCNull())
                         cutomerpayment.EditValue = dr.CARDDISC;
                    if (!dr.IsGRADENull())
                        cmbclass.EditValue = dr.GRADE;
                }
                else
                {
                    lookupcustomer.EditValue = null;
                    txtfileno.EditValue = null;
                    txtvisitno.EditValue = null;
                    cmbclass.EditValue = null;
                    cutomerpayment.EditValue = null;
                    txtpatname.EditValue = null;
                    txtrounding.EditValue = 0;
                    panelinsurance.Visible = false;
                    panelnormalcustomer.Visible = false; 
                }
            }
          

            foreach (DsInventory.SALESINVDETAILRow dr in dsInventory1.SALESINVDETAIL.Rows)
            {
                if (!dr.IsEXPDATENull())
                    dr["EXPDATE1"] = dr.EXPDATE.ToString("MM-yy");
            }
            bl.DoUnHold(invno);
            UpdateTotal();
        }
        void DoReturn(DataRow d, bool frmstock = false)
        {
            isreturn = true;
            var sprice = 0m;
            validateoff = true;
            var dt = new DsInventory.STOCKMASTERDataTable();
            var dr = (DsInventory.STOCKMASTERRow)dt.NewRow();
            dr.SPRICE = !string.IsNullOrEmpty(d["SPRICE"].ToString()) ? decimal.Parse(d["SPRICE"].ToString()) : 0; 
            dr.ITEMNO = d["ITEMNO"].ToString();
            dr.BARCODE = d["BARCODE"].ToString();
            dr.DISC = 0;
            if (frmstock)
            {
                dr.QTY = int.Parse(d["QTY"].ToString());
                dr.DQNTY = int.Parse(d["QTY"].ToString());
                if (!string.IsNullOrEmpty(d["DISC"].ToString()))
                {
                    if (decimal.Parse(d["DISC"].ToString()) > 0)
                    {
                        dr.DISC = decimal.Parse(d["DISC"].ToString());
                    }
                }
            }
            else
            {
                dr.DQNTY = 1;
                dr.QTY = 1;
            }
           // dr.INVRATE = sprice; // dr.SPRICE = sprice;
            dr.STOCKID = frmstock ? int.Parse(d["STOCKID"].ToString()) : 0;
            dr.CPRICE = !string.IsNullOrEmpty(d["CPRICE"].ToString()) ? decimal.Parse(d["CPRICE"].ToString()) : 0;
            dr.COMPANY = Utils.Company;
            dt.Rows.Add(dr);
            AddMultipleItems(dt, d["ITEMNAME"].ToString());
           // KeyF8();
        }
        void LoadSessionUsers()
        {
            lookupcashier.EditValue = Utils.Userid;
           _doctorid = new BLSales().GetDoctorLogin();
            var d = dsMaster1.USERINFO.FindByUSERID(_doctorid);
            if (d != null)
            {
                if (lookupcashier.EditValue == null)
                    lookupcashier.EditValue = int.Parse(d["USERID"].ToString());
                staticdoctor.Caption = d["FULLNAME"].ToString();
            }
        }
        void FetchDiscount()
        {
            if (lookupcustomer.EditValue != null)
            {
                int ctyp = int.Parse(lookupcustomer.GetColumnValue("CUSTOMERTYPE").ToString());
                int iscredit = int.Parse(lookupcustomer.GetColumnValue("PAYTYPE").ToString());
                if (ctyp == 1)
                {
                    XtraMessageBox.Show("No discount for insurance customers", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ctyp == 0)
                {
                    XtraMessageBox.Show("No discount for customers", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            foreach (DataRow dr in dsInventory1.SALESINVDETAIL.Rows)
            {
                decimal discount = 0m;
                if (!bool.Parse(dr["ISRETURN"].ToString()))
                {
                    if (decimal.Parse(txtfixdis.EditValue.ToString()) > 0)
                        discount = decimal.Parse(txtfixdis.EditValue.ToString());
                    else
                        discount = GetDiscount(dr["ITEMNO"].ToString());

                    var actval = decimal.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString());
                    var afterdisc = (decimal.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString())) * (discount / 100);
                    if (txtdiscount.EditValue != null)
                    {
                        txtdiscount.EditValue = decimal.Parse(txtdiscount.EditValue.ToString()) + Math.Round(afterdisc, 2);
                        txtdiscper.EditValue = decimal.Parse(txtdiscper.EditValue.ToString()) + discount;
                    }
                    dr["DISC"] = afterdisc;
                    dr["LINETOTAL"] = actval - afterdisc;
                }
                UpdateTotal();
            }
        }
        void RecallDiscount()
        {
            txtdiscount.EditValue = 0;
            foreach (DataRow dr in dsInventory1.SALESINVDETAIL.Rows)
            {
                if (!bool.Parse(dr["ISRETURN"].ToString()))
                {
                    var actval = decimal.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString());
                    dr["LINETOTAL"] = actval;
                }
            }
            UpdateTotal();
        }
        decimal GetDiscount(string itemno)
        {
            return new BLSales().GetDiscount(itemno);
        }
        private bool IsStockMore(GridView view, int row)
        {
            try
            {
                string val = Convert.ToString(view.GetRowCellValue(row, "STOCK"));
                string val1 = Convert.ToString(view.GetRowCellValue(row, "QTY"));
                string stockid = Convert.ToString(view.GetRowCellValue(row, "STOCKID"));
                if (int.Parse(stockid.ToUpper()) > 0)
                    return (int.Parse(val) < int.Parse(val1));
            }
            catch
            {
                return false;
            }
            return false;
        }
        void onePing()
        {
            // SystemSounds.Question.Play();
            SystemSounds.Beep.Play();
        }
        void ChangeCurrentRowSpriceAndUpdatetheExtingQty(DataRow dr)
        {
            var ds = new DsInventory().STOCKMASTER;
            var drnew = ds.NewRow();
            drnew.ItemArray = dr.ItemArray;
            drnew["DQNTY"] = 1;
            ds.Rows.Add(drnew);
            int cv = gridView1.FocusedRowHandle;
            if (cv < 0)
            {
                cv = _rowhandle;
                gridView1.FocusedRowHandle = cv;
            }
            var sname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colITEMNAME).ToString();
            DoDeleteRow(gridView1.GetDataRow(gridView1.FocusedRowHandle));
            AddMultipleItems(ds, sname);
            UpdateTotal();
        }
        void ClearTxtBoxex()
        {
            txtfileno.EditValue = null;
            txtvisitno.EditValue = null;
            cutomerpayment.EditValue = null;
            txtpatname.EditValue = null;
            txtavailble.EditValue = 0;
            txtfixdis.EditValue = 0;
            txtcrlimit.EditValue = 0;
        }
        void CreateNegativeNewRow(DataRow dr, int qty, bool showstock)
        {
            var dt = new DsInventory().STOCKMASTER;
            var dStockmasterRow = (DsInventory.STOCKMASTERRow)dt.NewRow();
            dStockmasterRow.ITEMNO = dr["ITEMNO"].ToString();
            dStockmasterRow.BARCODE = dr["BARCODE"].ToString();
            dStockmasterRow.SPRICE = decimal.Parse(dr["SPRICE"].ToString());
            dStockmasterRow.CPRICE = decimal.Parse(dr["CPRICE"].ToString());
            dStockmasterRow.DQNTY = qty;
            new BLSales().AddNewItemwithNegativeQty(dStockmasterRow);
            var dnewstock = new BLSales().GetStockItem(dStockmasterRow.ITEMNO, "S");
            foreach (DataRow drs in dnewstock.Rows)
            {
                drs["DQNTY"] = qty;
            }
            AddMultipleItems(dnewstock, dr["ITEMNAME"].ToString(), true);
            onePing();

        }
        void UpdateCurrentRow(string tid, int qty, int oldvalue)
        {
            var rs = dsInventory1.SALESINVDETAIL.FindByTID(int.Parse(tid));
            // if(qty > 0)
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "QTY", qty);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", Math.Round(qty * decimal.Parse(rs["INVRATE"].ToString()), 2));
            new BLSales().UpdateQty(int.Parse(rs["STOCKID"].ToString()), -(qty - oldvalue));
        }
        #endregion
        #region Shortcut keys
        void KeyF1()
        {
            if (txtnetamt.EditValue == null) 
            {
                return;
            }
            if (decimal.Parse(txtnetamt.EditValue.ToString()) ==0)
            {
                return;
            }
            if(lookupcustomer.EditValue!=null)
            {
                if(int.Parse(lookupcustomer.GetColumnValue("CUSTOMERTYPE").ToString())==0
                    || int.Parse(lookupcustomer.GetColumnValue("CUSTOMERTYPE").ToString()) == 1)
                        return;

            }
            if (Utils.ManualDiscount)
            {
                //txtdiscper.Properties.ReadOnly = false;
                //txtdiscper.Focus();
                _allowmandisc = true;
                var f = new GetDiscountNames();
                f.ShowDialog();
                if (f.ispercentage)
                {
                    txtdiscper.EditValue = f.Discval;
                }
            else
                {
                    txtdiscount.EditValue = f.Discval;
                    var dd = decimal.Parse(subtotal.EditValue.ToString()) + decimal.Parse(txtreturnamt.EditValue.ToString());
                    txtnetamt.EditValue = dd - f.Discval;
                }
            }
            else
            {
                FetchDiscount();
            }
        }
        void KeyF2()
        {
            var f = new SalesInvList();
            f.EventSelectedItems += AdditemsToRetun;
            f.ShowDialog();
        }
        void KeyF3()
        {
            if (XtraMessageBox.Show("Do you want to clear the data", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                DoClear();
        }
        void KeyF4()
        {
            var bl = new BLSales();
            bl.DoSlipPrint(txtinvoiceno.Caption,txtcustomer.Text,decimal.Parse(subtotal.EditValue.ToString()), decimal.Parse(txtdiscount.EditValue.ToString()),decimal.Parse(txtreturnamt.EditValue.ToString()),decimal.Parse(txtnetamt.EditValue.ToString()),true);
        }
        void KeyF5()
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                //txtqty.Focus();
                _rowhandle = gridView1.FocusedRowHandle;
                gridControl1.Focus();
                gridView1.FocusedColumn = colQTY;
                gridControl1.FocusedView.ShowEditor();
            }
        }
        void KeyF6()
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            string customerid = lookupcustomer.EditValue == null ? null : lookupcustomer.EditValue.ToString();
            string custname = lookupcustomer.EditValue == null ? string.Empty : lookupcustomer.Text;
            decimal sdisc = txtdiscount.EditValue == null ? 0 : decimal.Parse(txtdiscount.EditValue.ToString());
            decimal rounding = txtrounding.EditValue == null ? 0 : decimal.Parse(txtrounding.EditValue.ToString());
            txtcustomer.EditValue = null;
            
            KeyF8(false);
            lblmutilpleprice.Visible = false;
            if (lblcustomeronhold.Visible == false)
            {
                if (sALESINVDETAILBindingSource.Count > 0)
                {

                    new BLSales().DoHold(txtinvoiceno.Caption.Trim(), 1,customerid,custname,sdisc,rounding);
                    var bl = new BLSales();
                    
                    lookupcustomer.EditValue = null;
                    txtdiscount.EditValue = 0;

                  //  DoNew();
                    bl.GetNonSaleInv();

                    if (bl.SalesmainRow != null)
                    {
                        lookupcustomer.EditValue = null;
                        txtfileno.EditValue = null;
                        txtvisitno.EditValue = null;
                        cmbclass.EditValue = null;
                        cutomerpayment.EditValue = null;
                        txtpatname.EditValue = null;
                        txtrounding.EditValue = 0;
                        panelinsurance.Visible = false;
                        panelnormalcustomer.Visible = false;

                        txtinvoiceno.Caption = bl.SalesmainRow[0].ToString();
                        dsInventory1.SALESINVDETAIL.Clear();
                        dsInventory1.Merge(bl.Salesinvdetail);
                        foreach (DsInventory.SALESINVDETAILRow dr in dsInventory1.SALESINVDETAIL.Rows)
                        {
                            if (!dr.IsEXPDATENull())
                                dr["EXPDATE1"] = dr.EXPDATE.ToString("MM-yy");
                        }
                        UpdateTotal();
                        txtbarcode.Focus();
                    }
                    else
                    {
                        DoNew();
                    }
                    two.Visibility = BarItemVisibility.Always;
                    lblcustomeronhold.Visible = true;
                }
            }
            else if (lblcustomeronhold.Visible && sALESINVDETAILBindingSource.Count == 0)
            {
                LoadHoldedInvoices();
            }
            else if (lblcustomeronhold.Visible && sALESINVDETAILBindingSource.Count > 0)
            {
                new BLSales().DoHold(txtinvoiceno.Caption.Trim(), 1, customerid, custname, sdisc, rounding);
                LoadHoldedInvoices();
            }
            //{
            //    XtraMessageBox.Show("You can't hold more than one customer \r\n please finish the sales and call on hold invoice ",
            //                       "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  //LoadHoldedInvoices();
            //}
        }
        void KeyF7()
        {
            validateoff = true;
            var f = new PrepCharges();
            f.ShowDialog();
            if (f.charge == 0)
                return;
            var tot = f.charge;
            if (prepcnt == 0)
            {
                gridView1.AddNewRow();
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SINVNO", txtinvoiceno.Caption.Trim());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ITEMNO", "");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BARCODE", "");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ITEMNAME", "Preparation charages");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "STOCK", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "QTY", 1);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "INVRATE", tot);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SPRICE", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "CPRICE", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ISRETURN", isreturn);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "STOCKID", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DISCONSALE", _DISCONSALE);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "EXPDATE", null);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BONUS", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DOCTORID", _doctorid);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "EXTDISC", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", tot);
                gridView1.UpdateCurrentRow();
                new  BLSales().UpdateDetails(dsInventory1.SALESINVDETAIL);
                dsInventory1.SALESINVDETAIL.AcceptChanges();
            }
            validateoff = false;
            UpdateTotal();
        }
        void KeyF8(bool t = true)
        {
            if (isreturn)
            {
                t = false;
                txtbarcode.Focus();
            }
            if (!t)
            {
                gridControl1.LookAndFeel.Style = LookAndFeelStyle.Skin;
                gridControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            }
            else
            {
                gridControl1.LookAndFeel.Style = LookAndFeelStyle.Style3D;
                gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
                gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
                gridView1.Appearance.HeaderPanel.BackColor = Color.LightSalmon;
            }
            isreturn = t;
            colSPRICE.OptionsColumn.AllowFocus = t;
            colSPRICE.OptionsColumn.AllowEdit = t;
            colSPRICE.OptionsColumn.ReadOnly = t;

            colEXPDATE.OptionsColumn.ReadOnly = t;
            colEXPDATE.OptionsColumn.AllowEdit = t;
            colEXPDATE.OptionsColumn.AllowFocus = t;

        }
        void KeyF9()
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            UpdateTotal();
            int ctyp = 10;
            if (decimal.Parse(subtotal.EditValue.ToString()) == 0 && decimal.Parse(txtreturnamt.EditValue.ToString())==0)
            {
                onePing();
                txtbarcode.Focus();
                return;
            }

            if (lookupcustomer.EditValue != null)
            {
                ctyp = int.Parse(lookupcustomer.GetColumnValue("CUSTOMERTYPE").ToString());
            }

            if (ctyp == 1)
             {
                if(cmbclass.EditValue==null)
                {
                    onePing();
                    cmbclass.ErrorText = "Please select class";
                    cmbclass.Focus();
                    return;
                }
                 cmbclass.ErrorText = null;
                 var t = string.IsNullOrEmpty(cutomerpayment.EditValue.ToString())
                             ? 0
                             : decimal.Parse(cutomerpayment.EditValue.ToString());
                 if(t<0)
                    {
                        onePing();
                        cutomerpayment.ErrorText = "Please enter customer share";
                        cutomerpayment.Focus();
                        return;
                    }
                 cutomerpayment.ErrorText = null;
             }

            var _paytype = 0;
            //if (decimal.Parse(txtnetamt.EditValue.ToString()) == 0)
            //{
            //    _paytype = 0;
            //}
            //else if (decimal.Parse(txtnetamt.EditValue.ToString()) <= 0 && (ctyp == 0))
            //{
            //    _paytype = 0;
            //}
            //else
            //{

           // string di = String.Format("Total = {0} ", decimal.Parse(subtotal.Text).ToString("N"));
            CustomerDisplay("Total", decimal.Parse(subtotal.Text));
            //if (ComPort.IsOpen)
            // {
            //    ComPort.Write("\f");
            //    ComPort.Write("\v");
            //    ComPort.WriteLine(String.Format("Total = {0} ", decimal.Parse(subtotal.Text).ToString("N")));
            //  }
            //  if(ComPort.IsOpen)
            //      ComPort.Close();
                var frm = new CashCollected();
                frm.Netamount = decimal.Parse(txtnetamt.EditValue.ToString());
                frm.iscredit = ctyp == 2;
                frm.ShowDialog();
                if (!frm.issucess)
                {
                   // SetUpComm();
                   return;
                }
            _paytype = frm.paytype1;
            //}
            try
            {
                if (decimal.Parse(txtnetamt.EditValue.ToString()) != 0 || decimal.Parse(txtreturnamt.EditValue.ToString()) != 0)
                {
                    var f = new AmtCollection();

                    var dt = new BLSales().GetSalesInvMain(txtinvoiceno.Caption.Trim(), false, false);
                    DsInventory.SALESMAINRow dr = null;
                    sALESINVDETAILBindingSource.EndEdit();
                    f.Salesinvdetail = dsInventory1.SALESINVDETAIL;
                    f._isRedim = _isRedim;
                    if (dt.Rows.Count == 0)
                    {
                        dr = (DsInventory.SALESMAINRow)dt.NewRow();
                    }
                    else
                    {
                        dr = (DsInventory.SALESMAINRow)dt.Rows[0];
                    }
                    dr.SINVNO = txtinvoiceno.Caption.Trim();
                    dr.CUSTOMERID = lookupcustomer.EditValue == null ? null : lookupcustomer.EditValue.ToString();
                    dr.CUSTNAME = lookupcustomer.EditValue == null ? "Cash" : lookupcustomer.Text;
                    dr.SALESTYPE = "A";
                    if (ctyp == 0)
                    {
                        dr.SALESTYPE = "M";
                    }
                    if (ctyp == 1)
                    {
                        dr.SALESTYPE = "I";
                        dr.CUSTOMERFIXDISC = decimal.Parse(cmbclass.GetColumnValue("COMPDISC").ToString());//decimal.Parse(cutomerpayment.EditValue.ToString());
                        dr.CARDID = txtfileno.EditValue == null ? 0 : int.Parse(txtfileno.EditValue.ToString());
                        dr.CARDNO = txtvisitno.EditValue == null ? 0 : int.Parse(txtvisitno.EditValue.ToString());
                        
                            dr.CUSTNAME = lookupcustomer.Text + "-" + txtpatname.Text;
                    }
                    if (ctyp == 2)
                    {
                        dr.SALESTYPE = "C";
                        f.iscredit = true;
                    }
                    dr.SDISC = txtdiscount.EditValue == null ? 0 : decimal.Parse(txtdiscount.EditValue.ToString());
                    dr.TOTALAMT = subtotal.EditValue == null ? 0 : decimal.Parse(subtotal.EditValue.ToString());
                    dr.ROUNDOFF = 0;
                    dr.NETAMT = decimal.Parse(txtnetamt.EditValue.ToString());
                    dr.RECDAMT = 0;
                    dr.SALESMAN = lookupcashier.EditValue == null ? 0 : int.Parse(lookupcashier.EditValue.ToString());
                    dr.DOCTOR = _doctorid;
                    dr.COMPANY = Utils.Company;
                    dr.COMPNAME = Environment.MachineName;
                    dr.SHITFCODE = new BLSales().GetShiftCode();

                    dr.ISSALE = true;
                    if (cutomerpayment.EditValue != null)
                        dr.CARDDISC = decimal.Parse(cutomerpayment.EditValue.ToString());
                    if (txtrounding.EditValue != null)
                        dr.ROUNDOFF = decimal.Parse(txtrounding.EditValue.ToString());
                    else
                        dr.ROUNDOFF = 0;

                    if (txtreturnamt.EditValue != null)
                        dr.RETURNAMT = decimal.Parse(txtreturnamt.EditValue.ToString());
                    if (cmbclass.EditValue != null)
                        dr.GRADE = cmbclass.Text;
                    if (txtavailble.EditValue != null)
                        dr.AVAILBLEAMT = decimal.Parse(txtavailble.EditValue.ToString());
                    dr.TRANDATE = DateTime.Now;
                    if (cmbclass.EditValue != null)
                    {
                        f.NetAmount = decimal.Parse(txtnetins.EditValue.ToString());  //decimal.Parse(txtnetamt.EditValue.ToString()) * (decimal.Parse(cutomerpayment.EditValue.ToString()) / 100);
                    }
                    else
                    {
                        f.NetAmount = decimal.Parse(txtnetamt.EditValue.ToString());
                    }
                    f.RecdAmount = f.NetAmount;
                    f.SalesmainRow = dr;
                    f.Paytype = _paytype;

                    f.ShowDialog();
                    if (f._issucess)
                    {
                        _isRedim = false;
                        barButtonItem14.Caption = "Shitf Code = " + new BLSales().GetShiftCode();
                        if (ctyp == 0)
                        {
                            var p = new BLSales().GetShiftCode("POINTS");
                            if (!string.IsNullOrEmpty(p))
                            {
                                if (decimal.Parse(p) > 0)
                                {
                                    decimal epoints = Math.Round(dr.NETAMT/decimal.Parse(p), 2);
                                    new BlCustomer().UpdateCustomerPoints(dr.CUSTOMERID, epoints);
                                }
                            }
                        }
                        txtinvoiceno.Caption = string.Empty;
                        DoNew();
                        KeyF8(false);
                        lblmutilpleprice.Visible = false;
                        UpdateTotal();
                        LoadSessionUsers();
                        cls.DisplayComm("Next Customer", string.Empty);
                    }
                    else
                    {
                        XtraMessageBox.Show("Error Sale Not Completed ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception op)
            {
                XtraMessageBox.Show(op.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void KeyF10()
        {
            this.InvokeEx((lv => AddItems())); ;
        }
        void KeyF11()
        {
            var f = new Lookupcustomer();
            if (txtcustomer.EditValue != null)
            {
                f.iscustomername = true;
                f.filtertext = txtcustomer.Text;
            }
             lookupcustomer.Focus();
            f.EventSelectedItem += SelectCustomer;
            f.ShowDialog();
            if (lookupcustomer.EditValue == null)
                txtbarcode.Focus();
        }
        void KeyCtrlR()
        {
            if (txtnetamt.EditValue != null)
            {
                var ret = decimal.Parse(txtnetamt.EditValue.ToString());
                var re = Math.Round(ret, MidpointRounding.AwayFromZero);
                txtrounding.EditValue = re - ret;
                //if (ret > 0)
                //{
                //    if (re - ret > 0)
                //    {
                //        txtrounding.EditValue = re - ret;
                //    }
                //    else
                //    {
                //        txtrounding.EditValue = ret - re;
                //    }
                //}
                //if (ret < 0)
                //{
                //    if (re - ret > 0)
                //    {
                //        txtrounding.EditValue = ret - re;
                //    }
                //    else
                //    {
                //        txtrounding.EditValue = re - ret;
                //    }
                //}
            }
            txtrounding.Focus();
        }
        void KeyCtrlP()
        {
            var f = new PharmacistLogin();
            f.ShowDialog();
            if (f.isloginsucess)
            {
                LoadSessionUsers();
            }
            txtbarcode.Focus();
        }
        void KeyCtrlC()
        {
            var f = new CustomerPayment();
            f.shiftcode = new BLSales().GetShiftCode();
            f.userid = lookupcashier.EditValue == null ? 0 : int.Parse(lookupcashier.EditValue.ToString());
            f.ShowDialog();
        }
        private void FunctionKeys(object sender, ItemClickEventArgs e)
        {
            //XtraMessageBox.Show("This are keyboard key references,Use F1-F12", "POS", MessageBoxButtons.OK,
            //                    MessageBoxIcon.Information);

            var btn = e.Item.Caption;
            switch (btn)
            {
                case "Disc":
                    KeyF1();
                    break;
                case "Inv List":KeyF2();
                    break;
                case "Clear":
                    KeyF3();
                    break;
                case "Print":
                    KeyF4();
                    break;
                case "Qty":
                    KeyF5();
                    break;
                case "Hold":
                    KeyF6();
                    break;
                case "Charges":
                    KeyF7();
                    break;
                case "Return":
                    KeyF8();
                    break;
                case "Sale":
                    KeyF9();
                    break;
                case "Item List":
                    KeyF10();
                    break;
            }
        }
        #endregion
        #region grid
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            var view = sender as GridView;
            //if (gridView1.FocusedColumn == colQTY && CheckTheQty(view, gridView1.FocusedRowHandle))
            //{
            //    e.Cancel = true;
            //}
            if (gridView1.FocusedColumn == colQTY && dr["ISRETURN"].ToString() == bool.FalseString)
            {
                if (int.Parse(dr["STOCKID"].ToString()) != 0 && dr["ISRETURN"].ToString() == bool.FalseString)
                {
                    // e.Cancel = gridView1.FocusedRowHandle != _rowhandle;
                    if(gridView1.FocusedRowHandle!=gridView1.DataRowCount-1)
                        e.Cancel = true;
                }
            }
            else if (gridView1.FocusedColumn != colQTY && dr["ISRETURN"].ToString() == bool.FalseString)
            {
                e.Cancel = true;
            }
        }
        int CheckTheQty(int astock,int stockid)
        {
            int qty = 0;
          
            foreach (DataRow d in dsInventory1.SALESINVDETAIL.Rows)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    if (int.Parse(d["stockid"].ToString()) == stockid)
                    {
                        qty += int.Parse(d["qty"].ToString());
                    }
                }
            }
            var sqty = new BLSales().GetAvailableSQty(stockid);
            return qty;
        }
        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (IsStockMore(gridView1, e.RowHandle))
            {
                e.Appearance.BackColor = Color.LightCoral;
            }
        }
        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            gridView1.PostEditor();
            var bl = new BLSales();
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            int oldvalue = 0;
            int newval1 = 0;
            if (dr == null) return;
            if (validateoff) return;
            if (e.Column.FieldName.ToUpper() == "QTY" || e.Column.FieldName.ToUpper() == "INVRATE" || e.Column.FieldName.ToUpper() == "EXPDATE1" || e.Column.FieldName == "DISC")
            {
                if (e.Column.FieldName.ToUpper() == "QTY" && dr["ISRETURN"].ToString() == bool.FalseString)
                {
                    if (int.Parse(dr["STOCKID"].ToString()) == 0)
                        return;
                    if (((GridView)sender).ActiveEditor != null)
                        oldvalue = ((GridView)sender).ActiveEditor.EditValue == null
                                       ? oldvalue
                                       : int.Parse(((GridView)sender).ActiveEditor.OldEditValue.ToString());
                    if (string.IsNullOrEmpty(dr["QTY"].ToString()))
                        dr["QTY"] = oldvalue;
                    if (((GridView)sender).ActiveEditor != null)
                        newval1 = ((GridView)sender).ActiveEditor.EditValue == null
                                      ? oldvalue
                                      : int.Parse(((GridView)sender).ActiveEditor.EditValue.ToString());
                    if (int.Parse(dr["QTY"].ToString()) < 0)
                        dr["QTY"] = -1 * int.Parse(dr["QTY"].ToString());

                    //if (int.Parse(dr["QTY"].ToString()) == 0)
                    //{
                    //    dr["QTY"] = 1 * int.Parse(dr["QTY"].ToString());
                    //}
                    var tot = Math.Round(int.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString()), 2);
                    var linestock = int.Parse(dr["ASTOCK"].ToString());
                    //if(newval1 > oldvalue)
                    //     linestock = CheckTheQty(int.Parse(dr["ASTOCK"].ToString()), int.Parse(dr["stockid"].ToString()));
                    var totalstock = int.Parse(dr["STOCK"].ToString());

                    if (totalstock < 0)
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", tot);
                        if (oldvalue != newval1)
                        {
                            var qt = oldvalue - newval1;
                            UpdateCurrentRow(dr["TID"].ToString(), newval1, oldvalue);
                        }
                    }
                    else if (newval1 <= linestock)
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", tot);
                        if (oldvalue != newval1)
                        {
                            var qt = oldvalue - newval1;
                            new BLSales().UpdateQty(int.Parse(dr["STOCKID"].ToString()), qt);
                        }
                    }
                    else if (newval1 > linestock)
                    {
                        bool showstockwindow = false;
                        var itm = dr["itemname"].ToString();
                        string noti = "";
                        if (NotifyItems != null)
                            noti = NotifyItems.Find(item => item == itm);
                        if (noti != null)
                        {
                            showstockwindow = true;
                        }
                        else
                        {
                            NotifyItems.Add(itm);
                        }
                        validateoff = true;

                        UpdateCurrentRow(dr["TID"].ToString(), linestock, oldvalue);

                        if (totalstock >= newval1)
                        {
                            LoadMultiLineItems(dr["itemno"].ToString(), itm, newval1 - linestock);
                        }

                        if (newval1 - totalstock > 0)
                        {
                            LoadMultiLineItems(dr["itemno"].ToString(), itm, totalstock - linestock);
                            CreateNegativeNewRow(dr, newval1 - totalstock, showstockwindow);
                        }
                        validateoff = false;
                    }
                }
                if (e.Column.FieldName.ToUpper() == "QTY" && dr["ISRETURN"].ToString() == bool.TrueString)
                {
                    if (string.IsNullOrEmpty(dr["QTY"].ToString()))
                        dr["QTY"] = -1;
                    else
                    {
                        dr["QTY"] = int.Parse(dr["QTY"].ToString());
                    }
                    if (int.Parse(dr["QTY"].ToString()) > 0)
                        dr["QTY"] = -1 * int.Parse(dr["QTY"].ToString());

                    
                    if (int.Parse(dr["STOCKID"].ToString()) > 0)
                    {
                         
                        if (((GridView) sender).ActiveEditor != null)
                            oldvalue = ((GridView) sender).ActiveEditor.EditValue == null
                                ? oldvalue
                                : int.Parse(((GridView) sender).ActiveEditor.OldEditValue.ToString());
                        if (string.IsNullOrEmpty(dr["QTY"].ToString()))
                            dr["QTY"] = oldvalue;
                        if (((GridView) sender).ActiveEditor != null)
                            newval1 = ((GridView) sender).ActiveEditor.EditValue == null
                                ? oldvalue
                                : int.Parse(((GridView) sender).ActiveEditor.EditValue.ToString());
                        var qt =  - newval1 - oldvalue;
                        new BLSales().UpdateQty(int.Parse(dr["STOCKID"].ToString()), qt);

                    }
                    if (string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                        dr["INVRATE"] = 0;
                    var tot = Math.Round(int.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString()), 2);
                    if (!string.IsNullOrEmpty(dr["DISC"].ToString()))
                    {
                        if (decimal.Parse(dr["DISC"].ToString()) > 0)
                            tot = tot - tot * decimal.Parse(dr["DISC"].ToString()) / 100;
                    }
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", tot);
                }
                if (e.Column.FieldName == "INVRATE" && dr["ISRETURN"].ToString() == bool.TrueString)
                {
                    if (string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                        dr["INVRATE"] = 0;
                    if (string.IsNullOrEmpty(dr["QTY"].ToString()))
                        dr["QTY"] = -1;
                    else
                    {
                        dr["QTY"] = int.Parse(dr["QTY"].ToString());
                    }
                    if (int.Parse(dr["QTY"].ToString()) > 0)
                        dr["QTY"] = -1 * int.Parse(dr["QTY"].ToString());
                    //purdiscout
                    var tot = Math.Round(int.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString()), 2);
                    if (!string.IsNullOrEmpty(dr["DISC"].ToString()))
                    {
                        if (decimal.Parse(dr["DISC"].ToString()) > 0)
                            tot = tot - tot * decimal.Parse(dr["DISC"].ToString()) / 100;
                    }
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", tot);
                }
                if (e.Column.FieldName == "EXPDATE1" && dr["ISRETURN"].ToString() == bool.TrueString)
                {
                    if (!Functions.CheckDate(dr["EXPDATE1"].ToString()))
                    {
                        dr["EXPDATE1"] = null;
                    }
                    else
                    {
                        var split = dr["EXPDATE1"].ToString().Split('-');
                        var dtn = Functions.CreateFirstDayOfMonth(int.Parse(split[1]), int.Parse(split[0]));
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "EXPDATE", dtn);
                    }
                }
                if (e.Column.FieldName == "DISC" && dr["ISRETURN"].ToString() == bool.TrueString)
                {
                    var tot = Math.Round(int.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString()), 2);
                    if (!string.IsNullOrEmpty(dr["DISC"].ToString()))
                    {
                        if (decimal.Parse(dr["DISC"].ToString()) != 0)
                            tot = tot - tot * decimal.Parse(dr["DISC"].ToString()) / 100;
                    }
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", tot);
                }
            }
            gridView1.UpdateCurrentRow();

            if (bl.UpdateDetails(dsInventory1.SALESINVDETAIL) != "1")
            {
                XtraMessageBox.Show("Some problem in updating the data", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
            UpdateTotal();
            
           dsInventory1.SALESINVDETAIL.AcceptChanges();
           //if (ComPort.IsOpen)
           //{
                  CustomerDisplay(
                          dr["ITEMNAME"].ToString().Length > 20 ? dr["ITEMNAME"].ToString().Substring(1, 20) : dr["ITEMNAME"].ToString(),
                          decimal.Parse(dr["LINETOTAL"].ToString()));
             //  CustomerDisplay(dr["ITEMNAME"].ToString(), decimal.Parse(dr["LINETOTAL"].ToString()));
          // }
        }
        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0) return;
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (e.KeyCode == Keys.Delete)
            {
                string itname = "[ " + gridView1.FocusedRowHandle + 1 + " ] - " + gridView1.GetDisplayTextByColumnValue(colITEMNAME, gridView1.GetFocusedRowCellValue("ITEMNAME"));
                if (XtraMessageBox.Show("Do you want to delete the selected  row..?", itname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DoDeleteRow(dr);
                }
                txtbarcode.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (lblmutilpleprice.Visible)
                {
                    _rowhandle = gridView1.FocusedRowHandle;
                    gridControl2.Focus();
                }
            }
            else
            {
                lblmutilpleprice.Visible = false;
                popupControlContainer1.CloseOnLostFocus = true;
            }
        }
        private void gridView1_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "QTY")
            {
                object oldEditValue = (sender as BaseView).ActiveEditor.OldEditValue;
                object newEditValue = (sender as BaseView).ActiveEditor.EditValue??0;
                if ((int) (newEditValue) == 0)
                {
                    e.Value = oldEditValue;
                    onePing();
                } 
            }
        }
        void DoDeleteRow(DataRow dr)
        {
            var ret = new BLSales().DoSalesItemDelete((DsInventory.SALESINVDETAILRow)dr);
            if (ret != "1")
            {
                XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                new BLSales().UpdateDetails(dsInventory1.SALESINVDETAIL);
            }
            dsInventory1.SALESINVDETAIL.AcceptChanges();
            UpdateTotal();
        }
        private void GridView1CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;

            e.Info.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            e.Info.DisplayText = (1 + int.Parse(e.RowHandle.ToString())).ToString();
            e.Info.ImageIndex = -1;
        }
        private void GridView2CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;
            e.Info.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            e.Info.DisplayText = (1 + int.Parse(e.RowHandle.ToString())).ToString();
            e.Info.ImageIndex = -1;
        }
        private void gridControl2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                onePing();
                var dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                ChangeCurrentRowSpriceAndUpdatetheExtingQty(dr);
                //   popupControlContainer1.CloseOnLostFocus = true;
                popupControlContainer1.HidePopup();
                //   popupControlContainer1.Visible = false;
                lblmutilpleprice.Visible = false;
                txtbarcode.Focus();
            }
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridView1.FocusedRowHandle < 0) return;
                var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                if (gridView1.FocusedColumn == colQTY || gridView1.FocusedColumn == colDISC)
                {
                    if (dr["ISRETURN"].ToString() == bool.FalseString && gridView1.FocusedColumn == colQTY)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        txtbarcode.Focus();
                    }
                    //if (dr["ISRETURN"].ToString() == bool.TrueString && gridView1.FocusedColumn == colEXPDATE1)
                    //{
                    //    gridView1.PostEditor();
                    //    gridView1.UpdateCurrentRow();
                    //    if (!Functions.CheckDate(dr["EXPDATE1"].ToString()))
                    //    {
                    //        e.Handled = true;
                    //    }
                    //}
                    if (dr["ISRETURN"].ToString() == bool.TrueString && gridView1.FocusedColumn == colDISC)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        txtbarcode.Focus();
                    }
                }
            }
        }
        #endregion
        private void staticdoctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            KeyCtrlP();
        }
        private void txtrounding_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (decimal.Parse(e.NewValue.ToString()) > 1 || decimal.Parse(e.NewValue.ToString()) < -1)
            {
                e.Cancel = true;
                e.NewValue = 0;
            }
        }
        private void txtrounding_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                txtbarcode.Focus();
            }
        }
        private void txtdiscper_EditValueChanged(object sender, EventArgs e)
        {
            if(_allowmandisc)
            {
                if(subtotal.EditValue!=null)
                {
                    if (txtdiscper.EditValue==null)
                    {
                        txtdiscount.EditValue = 0;
                    }
                    else
                    {
                        if (Utils.MaximumDiscount < decimal.Parse(txtdiscper.EditValue.ToString()))
                        {
                            txtdiscper.EditValue = Utils.MaximumDiscount;
                        }
                        txtdiscount.EditValue = decimal.Parse(subtotal.EditValue.ToString()) * decimal.Parse(txtdiscper.EditValue.ToString()) / 100;
                        txtnetamt.EditValue = decimal.Parse(subtotal.EditValue.ToString()) - decimal.Parse(subtotal.EditValue.ToString()) * decimal.Parse(txtdiscper.EditValue.ToString()) / 100;
                        //if (txtnetins.EditValue != null)
                        //    txtnetins.EditValue = decimal.Parse(txtnetins.EditValue.ToString()) - decimal.Parse(txtnetins.EditValue.ToString()) * decimal.Parse(txtdiscper.EditValue.ToString()) / 100;     
                    }
                   
                }
            }
        }
        private void txtdiscper_EditValueChanging(object sender, ChangingEventArgs e)
        {
            //try
            //{
            //    if (VIRETAILDAL.COMMON.Utils.ManualDiscount)
            //    {
            //        if (txtdiscper.EditValue != null)
            //        {
            //            if (VIRETAILDAL.COMMON.Utils.MaximumDiscount < decimal.Parse(txtdiscper.EditValue.ToString()))
            //            {
            //                // e.Cancel = true;
            //                e.NewValue = VIRETAILDAL.COMMON.Utils.MaximumDiscount;
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
        }
        private void txtdiscper_KeyDown(object sender, KeyEventArgs e)
        {
   
        }
        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(txtqty.EditValue!=null)
                {
                    if(int.Parse(txtqty.EditValue.ToString()) > 0)
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle,colQTY,int.Parse(txtqty.EditValue.ToString()));
                        gridView1.PostEditor();
                        //gridView1.UpdateCurrentRow();
                    }
                }
            }
        }       
        private void cutomerpayment_Validated(object sender, EventArgs e)
        {
            decimal resulta;

            if (cutomerpayment.EditValue != null)
            {
                if (!decimal.TryParse(cutomerpayment.Text, out resulta))
                {
                    XtraMessageBox.Show("Please check the Customer Share % ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cutomerpayment.Focus();
                }
            }
        }
        private void labelControl16_Click(object sender, EventArgs e)
        {

        }
        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            KeyCtrlC();
        }
        private void barButtonItem14_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var frm = new ShiftCode();
            frm.ShowDialog();
            barButtonItem14.Caption = "Shitf Code = " + new BLSales().GetShiftCode();
        }
        private void txtbarcode_EditValueChanged(object sender, EventArgs e)
        {}
        private void txtvisitno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (txtvisitno.EditValue != null)
                {
                    var bl = new BlInsuranceCustomer();
                    bl.GetInscustomersRowByPolicyNo(txtvisitno.Text);
                    if (bl.dr != null)
                    {
                         if(!bl.dr.IsPATNAMENull())
                             txtpatname.Text = bl.dr.PATNAME;
                        if(!bl.dr.IsCUSTSHARENull())
                             cutomerpayment.EditValue = bl.dr.CUSTSHARE;
                    }
                }  
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var f = new FrmPatInfo
            {
                Fileno = txtfileno.Text,
                Memno = txtvisitno.Text
            };
            f.ShowDialog();
            if(f.Custno!=null)
            txtpatname.Text = f.Custno;
            if(f.Custpayment!=null)
            cutomerpayment.EditValue = f.Custpayment ;

        }
        private void txtfileno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (txtfileno.EditValue != null)
                {
                    var bl = new BlInsuranceCustomer();
                    bl.GetInscustomersRowByFileNo(txtfileno.Text);
                    if (bl.dr != null)
                    {
                        if(!bl.dr.IsPOLICYNONull())
                             txtvisitno.Text = bl.dr.POLICYNO.ToString();
                        if (!bl.dr.IsPATNAMENull())
                            txtpatname.Text = bl.dr.PATNAME;
                        if (!bl.dr.IsCUSTSHARENull())
                            cutomerpayment.EditValue = bl.dr.CUSTSHARE;
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lookupcustomer.EditValue == null) return;
            var f = new FrmChkAvailablePoints();
            f._customername = lookupcustomer.Text;
            f._custno = lookupcustomer.EditValue.ToString();
            f.GetCustomerPoints(lookupcustomer.EditValue.ToString());
            f.ShowDialog();
            if (f._redmipoints > 0)
            {
                
                txtavailble.EditValue = f._redmipoints;
                _disableshortcut = true;
                txtdiscount.EditValue = f._redmipoints;
                var dd = decimal.Parse(subtotal.EditValue.ToString()) + decimal.Parse(txtreturnamt.EditValue.ToString());
                txtnetamt.EditValue = dd - f._redmipoints;
                _isRedim = true;

            }

        }
    }
}