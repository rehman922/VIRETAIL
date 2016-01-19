using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILENTITIES;

namespace Store
{
    public partial class RetailSales : XtraForm
    {
        #region vars

        private static readonly RetailSales MInstance = new RetailSales();
        private bool _isreturn = false;
        private int _doctorid = 0;
        private int _stockid = 0;
        private bool _DISCONSALE = false;
        private decimal _discount = 0m;
        private bool _validateoff = false;
        private List<string> NotifyItems = null;
        private string _compname = Environment.MachineName;
        private int _rowhandle = 0;
        private int prepcnt = 0;
        private bool isprep = false;
        private List<string> Listinvno = new List<string>();
        public BindingList<DataClass> Data { get; private set;}
        #endregion
        public RetailSales()
        {
            this.InvokeEx(lv => InitializeComponent());
          //InitializeComponent();
        }
        public static RetailSales Instance
        {
            get { return MInstance; }
        }
        #region Form Events
        private void RetailSales_KeyDown(object sender, KeyEventArgs e)
        {
                if(e.Control && e.KeyCode == Keys.Enter)
                {
                    KeyCtrlR();
                    return;
                }
                if (e.Control && e.KeyCode == Keys.F2)
                {
                    KeyCtrlP();
                    return;
                }
                if(e.Control &&  e.KeyCode == Keys.F3)
                {
                    KeyCtrlC();
                    return;
                }
           switch (e.KeyCode)
           {
               case Keys.F1 :
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
                   KeyF6();
                   break;
               case Keys.F7:
                   KeyF7();
                   break;
               case Keys.F8:
                   KeyF8();
                   break;
               case Keys.F9:
                    KeyF9();
                   break;
               case Keys.F10:
                   KeyF10();
                   break;
               case Keys.F11:
                   KeyF11();
                   break;
               case Keys.F12:
                   KeyF12();
                   break;
           }
       }
        private void RetailSales_Load(object sender, EventArgs e)
        {
            if (VIRETAILDAL.COMMON.Utils.Userid==0)
            {
                var f = new Login();
                
                f.ShowDialog();
                if(!f.LoginSucess)
                    Close();
                 
            }
           this.InvokeEx((lv => LoadDataSets()));
           barcomp1.Caption = VIRETAILDAL.COMMON.Utils.Company;
           if (ClsGetData.GetDailyClosing().Rows.Count == 0)
           {
               var frm = new InitialCash();
               frm.ShowDialog();
           }
           gridControl1.Invalidate();
           _validateoff =false;

           repositoryItemTextEdit4.Mask.EditMask = "\\d+";
           repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

           txtfileno.Properties.Mask.EditMask = "\\d+";
           txtfileno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

           txtvisitno.Properties.Mask.EditMask = "\\d+";
           txtvisitno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;


           NotifyItems = new List<string>();
       //  dsMaster1.Merge(COMMON.ClsGetData.GetItemMastList());
           LoadSessionUsers();
          if (LoadHoldedInvoices())
          {
              var bl = new BLSales();
              bl.GetNonSaleInv();
              if (bl.SalesmainRow != null)
              {
                  txtinvoiceno.Text = bl.SalesmainRow[0].ToString();
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
                  txtinvoiceno.Text = new BLSales().GetInvoiceNo();
                  DoSave();
              }
          }
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
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbarcode.EditValue != null)
                if (e.Control && e.KeyCode == Keys.Enter)
                {
                    return;
                }
                if (e.KeyCode == Keys.Enter)
                {
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
                    popupControlContainer1.ShowPopup(gridControl1.PointToScreen(p));
                    popupControlContainer1.Focus();
                    gridControl2.Focus();
                }
            }
        }
        #region BLLS
        void LoadDataSets() 
        {
            //iTEMMASTBindingSource.DataSource = ClsGetData.GetItemMastList();
            dsMaster1.Merge(ClsGetData.GetCustomerList());
            dsMaster1.Merge(ClsGetData.GetEmployees());
            lookupcashier.Properties.DataSource = dsMaster1.USERINFO;
            
        }
        private void DoNew()
        {
            dsInventory1.SALESINVDETAIL.Clear();
            gridControl1.ResetBindings();
            UpdateTotal();
            cmbclass.EditValue = null;
            lookupcustomer.EditValue = null;
            txtfileno.EditValue = null;
            txtvisitno.EditValue = null;
            txtavailble.EditValue = null;
            txtnetins.EditValue = 0;

            txtreturnamt.EditValue = null;
            txtrounding.EditValue = null;
            subtotal.EditValue = null;
            txtdiscount.EditValue = null;
            cutomerpayment.EditValue = 0;
            txtinvoiceno.Text = new BLSales().GetInvoiceNo();
           
            LoadSessionUsers();
            DoSave();
            txtbarcode.Focus();
            txtbarcode.SelectAll();
            prepcnt = 0;
        }
        void DoSave() 
        {
            var bl = new BLSales();
            var ret =  bl.DoSave(txtinvoiceno.Text, false,lookupcashier.EditValue==null?0:int.Parse(lookupcashier.EditValue.ToString()), _doctorid);
            if(ret!="1")
            {
                XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        void DoClear()
        {
            var bls = new BLSales();

            var str = bls.DeleteSalesInvDetail(txtinvoiceno.Text);
            if(str!="1")
            {
                XtraMessageBox.Show(str, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dsInventory1.SALESINVDETAIL.Clear();
                gridControl1.ResetBindings();
            }
            lblmutilpleprice.Visible = false;
        }
        Rectangle GetCellRect(GridView view, int rowHandle, GridColumn column)
        {

            var info = (GridViewInfo)view.GetViewInfo();

            GridCellInfo cell = info.GetGridCellInfo(rowHandle,column);

            if (cell != null)

                return cell.Bounds;

            return Rectangle.Empty;

        } 
        void AddMultipleItems(DsInventory.STOCKMASTERDataTable ds, string itemname, bool isblankrow = false)
        {
            _validateoff = true;
            var dt = dsInventory1.SALESINVDETAIL;
            foreach (DsInventory.STOCKMASTERRow d in ds.Rows)
            {
                var newrow = (DsInventory.SALESINVDETAILRow) dt.NewRow();
                if (!d.IsDQNTYNull())
                      if (d.DQNTY > 0)
                    {
                         var tot = Math.Round((d.DQNTY * d.SPRICE), 2);
                         newrow.ITEMNAME = itemname;
                         newrow.STOCKID = d.STOCKID;
                         newrow.ITEMNO=  d.ITEMNO;
                         newrow.SINVNO = txtinvoiceno.Text;
                         newrow.BARCODE =  d.BARCODE;
                         var aQty = new BLSales().GetAvailableQty(d["ITEMNO"].ToString());
                         newrow.STOCK =  aQty;
                         newrow.ASTOCK = d.SQTY;
                         newrow.INVRATE= d.SPRICE;
                         newrow.SPRICE= d.SPRICE;
                         newrow.CPRICE= d.CPRICE;
                         newrow.ISRETURN= _isreturn; 
                         if (!_isreturn)
                            newrow.DISCONSALE = _DISCONSALE;
                         
                         if (!d.IsEXPDATENull())
                         {
                             newrow.EXPDATE = d.EXPDATE;
                             newrow.EXPDATE1= d.EXPDATE.ToString("MM-yy");
                         }
                        else
                          {
                              newrow["EXPDATE"] = DBNull.Value ;
                              newrow.EXPDATE1 = string.Empty;
                          }
                          newrow.BONUS= 0;
                          newrow.LINETOTAL = tot;
                          if(!d.IsDISCNull())
                          {
                              if(d.DISC  > 0)
                              {
                                  newrow.LINETOTAL = tot - (tot * d.DISC) / 100;
                              }
                          }
                          newrow.DOCTORID = _doctorid;
                          newrow.EXTDISC = 0;
                           if (_isreturn)
                               newrow.QTY = -d.DQNTY;
                           else
                           {
                               newrow.QTY = d.DQNTY;
                           }
                           dt.Rows.Add(newrow);
                   }
                        if (!isblankrow)
                        {
                            if (!_isreturn)
                                new BLSales().UpdateQty(d.STOCKID, -d.DQNTY);
                            else if (_isreturn)
                            {
                                if(d.STOCKID > 0)
                                {
                                    new BLSales().UpdateQty(d.STOCKID, d.DQNTY);
                                }
                            }
                        }
                        var bl = new BLSales().UpdateDetails(dsInventory1.SALESINVDETAIL);
            }
            sALESINVDETAILBindingSource.EndEdit();
            if (_isreturn)
            {
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
            _validateoff = false;
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
            frm.EventSelectedItem += AdditemsToList;
            frm.closeonselect = true;
            if(txtbarcode.EditValue!=null)
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
                _discount = 0m;
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
                if (_isreturn)
                {
                    DoReturn(current);
                    return;
                }
                var bl = new BLSales();
                var aQty = bl.GetAvailableQty(current["ITEMNO"].ToString());
                if(aQty > 0)
                {
                    CheckForMultiStock(current["ITEMNO"].ToString(),current["ITEMNAME"].ToString());
                }
                else
                {
                    var dStockmasterRow = (DsInventory.STOCKMASTERRow)dsInventory1.STOCKMASTER.NewRow();
                    dStockmasterRow.ITEMNO = current["ITEMNO"].ToString();
                    dStockmasterRow.BARCODE = current["BARCODE"].ToString();
                    dStockmasterRow.DQNTY = 1;
                    dStockmasterRow.CPRICE = CPRICE;
                    dStockmasterRow.QTY = 0;
                    if (SPRICE == 0)
                    {
                        SPRICE = new BLSales().GetSalesPriceByItemno(current["ITEMNO"].ToString());
                    }
                    var f = LoadQtyMoreForm(current["ITEMNO"].ToString(), current["ITEMNAME"].ToString(), aQty, 1, 0, 1, SPRICE, true, true, dStockmasterRow, purdiscout);
                    if (f.iscontinue == 1)
                    {
                        //GetStockItemBySprice
                        var dnewstock = new BLSales().GetStockItem(current["ITEMNO"].ToString(), "S");
                        if(f.salesprice !=SPRICE)
                        {
                            dnewstock = new BLSales().GetStockItemBySprice(current["ITEMNO"].ToString(),f.salesprice);
                        }
                        
                        foreach(DsInventory.STOCKMASTERRow dr in dnewstock.Rows)
                        {
                            dr.DQNTY = f.enterqty;
                        }
                     // var topRows = dnewstock.AsEnumerable().OrderBy(o => o.Field<int>("STOCKID")).Take(1).ToList().CopyToDataTable();
                        string itemno = current["ITEMNO"].ToString();
                        var t = NotifyItems.Find(match => match == itemno);
                        if(t!=null)
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
        bool CheckForMultiStock(string itemno,string itemname)
        {
            var bl = new BLSales();
            var drstock = new BLSales().GetStockItem(itemno, "S");
            var dprice = bl.GetDisctinctSprices(drstock);
            int cnt = dprice.Count();
            var stk = new DsInventory.STOCKMASTERDataTable();
               // var topRows = drstock.AsEnumerable().OrderBy(o => o.Field<int>("STOCKID")).Take(1).ToList().CopyToDataTable();
                DataTable topRows = drstock.Rows.Cast<DataRow>().Take(1).CopyToDataTable();
               // object[] topRows = drstock.Select( * ", "EXPDATE ASC ");
                DataRow dr = stk.NewRow();
                foreach (DataRow drs  in topRows.Rows) 
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
                return cnt > 0;
        }
        void LoadMultiLineItems(string itemno,string itemname, int aQty)
        {
            var bl = new BLSales();
            var drstock = new BLSales().GetStockItem(itemno, "S");
            AddMultipleItems(bl.GetQtyRows(drstock, aQty), itemname);
        }
        StockShow LoadQtyMoreForm(string itemno,string itemname,int stock,int qtyorder, int qtybalance,int enteredqty,decimal sprice,bool showsprice,bool isblankrow,DsInventory.STOCKMASTERRow dr,decimal purdiscout)
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
                DStockmasterRow =dr
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
                        if(dr.LINETOTAL > 0)
                            _subtotal += dr.LINETOTAL;
                        else
                            _retamt += dr.LINETOTAL;
                    }
                }
            }
            subtotal.EditValue = _subtotal;
            txtreturnamt.EditValue = _retamt;
            txtnetamt.EditValue = _subtotal + _retamt;
            if (decimal.Parse(txtnetamt.EditValue.ToString()) == 0)
                txtrounding.EditValue = 0;
             if(txtrounding.EditValue!=null)
                 txtnetamt.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) + decimal.Parse(txtrounding.EditValue.ToString());
        }
        void KeyF1()
        {
            FetchDiscount();
        }
        void KeyF2()
        {
            var f = new SalesInvList();
            f.EventSelectedItems  += AdditemsToRetun;
            f.ShowDialog();
        }
        void KeyF3()
        {
            if(XtraMessageBox.Show("Do you want to clear the data","POS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) 
                DoClear();
        }
        void KeyF4()
        {
            
        }
        void KeyF5()
        {
             
            if(gridView1.FocusedRowHandle >=0)
            {
               _rowhandle= gridView1.FocusedRowHandle ;
                gridControl1.Focus();
                gridView1.FocusedColumn = colQTY;
                gridControl1.FocusedView.ShowEditor();
            }
        }
        void KeyF6()
        {
            KeyF8(false);
            lblmutilpleprice.Visible = false;
            if (lblcustomeronhold.Visible == false)
            {
                if (sALESINVDETAILBindingSource.Count > 0)
                {
                    new BLSales().DoHold(txtinvoiceno.Text, 1);
                    var bl = new BLSales();
                    bl.GetNonSaleInv();
                    if (bl.SalesmainRow != null)
                    {
                        txtinvoiceno.Text= bl.SalesmainRow[0].ToString();
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
                        DoNew();
                    }
                    two.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    lblcustomeronhold.Visible = true;
                }
            }
            else if (lblcustomeronhold.Visible && sALESINVDETAILBindingSource.Count == 0)
            {
                
                LoadHoldedInvoices();
            }
            else if (lblcustomeronhold.Visible && sALESINVDETAILBindingSource.Count > 0)
            {
                new BLSales().DoHold(txtinvoiceno.Text, 1);
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
            _validateoff = true;
            var f = new PrepCharges();
            f.ShowDialog();
            if(f.charge == 0)
                return;
            var tot = f.charge;
            if (prepcnt == 0)
            {
                gridView1.AddNewRow(); 
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SINVNO", txtinvoiceno.Text);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ITEMNO", "");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BARCODE", "");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ITEMNAME", "Preparation charages");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "STOCK", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "QTY", 1);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "INVRATE", tot);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SPRICE", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "CPRICE", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ISRETURN", _isreturn);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "STOCKID", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DISCONSALE", _DISCONSALE);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "EXPDATE", null);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BONUS", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DOCTORID", _doctorid);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "EXTDISC", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", tot);
                gridView1.UpdateCurrentRow();
                var bl = new BusinessLogic.BLSales().UpdateDetails(dsInventory1.SALESINVDETAIL);
            }
            _validateoff = false;
            UpdateTotal();
        }
        void KeyF8(bool t=true)
        {
            if (_isreturn)
            {
                t = false;
                txtbarcode.Focus();
            }
            if (!t)
            {
                gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
                gridControl1.LookAndFeel.UseDefaultLookAndFeel = true;  
            }
            else
            {
                gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
                gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;  
                gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
                gridView1.Appearance.HeaderPanel.BackColor = Color.LightSalmon;

            }
            _isreturn = t;
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
            int ctyp = 0;
            if (lookupcustomer.EditValue != null)
            {
                 ctyp = int.Parse(lookupcustomer.GetColumnValue("CUSTOMERTYPE").ToString());
            }
            var frm = new CashCollected();
            frm.iscredit = ctyp == 2;
            frm.ShowDialog();

            if (!frm.issucess)
                return;
            var _paytype = frm.paytype1;
            try
            {
                if (decimal.Parse(txtnetamt.EditValue.ToString()) != 0 || decimal.Parse(txtreturnamt.EditValue.ToString())!= 0)
                {
                    var f = new AmtCollection();
                    var dt = new BLSales().GetSalesInvMain(txtinvoiceno.Text, false, false);
                    DsInventory.SALESMAINRow dr = null;
                    sALESINVDETAILBindingSource.EndEdit();
                    f.Salesinvdetail = dsInventory1.SALESINVDETAIL;
                    if (dt.Rows.Count == 0)
                    {
                        dr = (DsInventory.SALESMAINRow)dt.NewRow();
                    }
                    else
                    {
                        dr = (DsInventory.SALESMAINRow)dt.Rows[0];
                    }
                    dr.SINVNO = txtinvoiceno.Text;
                    dr.CUSTOMERID = lookupcustomer.EditValue == null ? null : lookupcustomer.EditValue.ToString();
                    dr.CUSTNAME = lookupcustomer.EditValue == null ? "Cash" : lookupcustomer.Text;
                    dr.SALESTYPE = "A";
                    if (ctyp == 1)
                        {
                            dr.SALESTYPE = "I";
                            dr.CUSTOMERFIXDISC = int.Parse(cmbclass.GetColumnValue("COMPDISC").ToString());
                            dr.CARDID = txtfileno.EditValue == null? 0: int.Parse(txtfileno.EditValue.ToString());
                            dr.CARDNO = txtvisitno.EditValue == null?0: int.Parse(txtvisitno.EditValue.ToString());
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
                    dr.COMPANY = VIRETAILDAL.COMMON.Utils.Company;
                    dr.COMPNAME = Environment.MachineName;
                    dr.SHITFCODE = new BLSales().GetShiftCode();
                    
                    dr.ISSALE = true;
                    if (cutomerpayment.EditValue != null)
                        dr.CARDDISC = int.Parse(cutomerpayment.EditValue.ToString());
                    if (txtrounding.EditValue != null)
                        dr.ROUNDOFF = decimal.Parse(txtrounding.EditValue.ToString()) ;
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
                        f.NetAmount = decimal.Parse(txtnetamt.EditValue.ToString()) *
                                      (decimal.Parse(cutomerpayment.EditValue.ToString())/100);
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
                        var bls = new BLSales();
                        bls.GetNonSaleInv();
                        lookupcustomer.EditValue = null;
                        if (bls.SalesmainRow != null)
                        {
                            txtinvoiceno.Text = bls.SalesmainRow[0].ToString();
                            dsInventory1.SALESINVDETAIL.Clear();
                            dsInventory1.Merge(bls.Salesinvdetail);
                            foreach (DsInventory.SALESINVDETAILRow drs in dsInventory1.SALESINVDETAIL.Rows)
                            {
                                if (!drs.IsEXPDATENull())
                                    drs["EXPDATE1"] = drs.EXPDATE.ToString("MM-yy");
                            }
                            UpdateTotal();
                        }
                        else
                        {
                            DoNew();    
                        }
                        KeyF8(false);
                        LoadSessionUsers();
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
            lookupcustomer.Focus();
            f.EventSelectedItem += SelectCustomer;
            f.ShowDialog();
        }
        void KeyF12()
        {
            txtbarcode.Focus();
        }
        void KeyCtrlR()
        {
           if(txtnetamt.EditValue!=null)
           {
               var ret = decimal.Parse(txtnetamt.EditValue.ToString());


               var re = Math.Round(ret, MidpointRounding.AwayFromZero);

               if (ret > 0)
               {
                   if (re - ret > 0)
                   {
                       txtrounding.EditValue = re - ret;
                   }
                   else
                   {
                       txtrounding.EditValue = ret - re;
                   }
               }
               if (ret < 0)
               {
                   if (re - ret > 0)
                   {
                       txtrounding.EditValue = ret - re;
                   }
                   else
                   {
                       txtrounding.EditValue = re - ret;
                   }
               }
           }
        }
        void KeyCtrlE()
        { }
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
            f.ShowDialog();
        }
        bool LoadHoldedInvoices()
        {
            Listinvno.Clear();
            var dt = new BLSales().GetHoldInvno();
            if (dt.Rows.Count > 1)
            {
               // var dr = dt.Select("HOLDNO = 0");
                foreach (DataRow dataRow in dt.Rows)
                {
                    Listinvno.Add(dataRow[0].ToString());
                }
                if (Listinvno[0] == txtinvoiceno.Text)
                    DoView(Listinvno[1]);
                else
                    DoView(Listinvno[0]);
                lblcustomeronhold.Visible = true;
                return false;
            }
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    DoView(dr[0].ToString());
                }
                lblcustomeronhold.Visible = false;
                return false;
            }
            return true;
        }
        void DoView(string invno)
        {
            txtinvoiceno.Text= invno;
            var bl = new BusinessLogic.BLSales();
            bl.GetSalesInvDetail(invno);
            dsInventory1.Clear();
            dsInventory1.Merge(bl.Salesinvdetail);
            foreach(DsInventory.SALESINVDETAILRow dr in dsInventory1.SALESINVDETAIL.Rows)
            {
                if (!dr.IsEXPDATENull())
                    dr["EXPDATE1"] = dr.EXPDATE.ToString("MM-yy");
            }
            bl.DoUnHold(invno);
            UpdateTotal();
        }
        void DoReturn(DataRow  d,bool frmstock=false)
        {
            _isreturn = true;
           // var sprice = 0m;
            _validateoff = true;
            var dt = new DsInventory.STOCKMASTERDataTable();
            var dr = (DsInventory.STOCKMASTERRow)  dt.NewRow();
            dr.SPRICE =  decimal.Parse(d["SPRICE"].ToString());
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
            dr.COMPANY = VIRETAILDAL.COMMON.Utils.Company;
            dt.Rows.Add(dr);
            AddMultipleItems(dt,d["ITEMNAME"].ToString());
            _isreturn = false;
        }
        void LoadSessionUsers()
        {
            lookupcashier.EditValue = VIRETAILDAL.COMMON.Utils.Userid;
            int _doctorid = new BLSales().GetDoctorLogin();
            var d = dsMaster1.USERINFO.FindByUSERID(_doctorid);
            if (d != null)
            {
                if (lookupcashier.EditValue == null)
                    lookupcashier.EditValue = int.Parse(d["USERID"].ToString());
                staticdoctor.Text =  d["FULLNAME"].ToString() ;

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
                    XtraMessageBox.Show("No discount for insurance cutomers", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            foreach (DataRow dr in dsInventory1.SALESINVDETAIL.Rows)
            {
                decimal  discount =0m;
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
                        txtdiscount.EditValue = decimal.Parse(txtdiscount.EditValue.ToString()) +  Math.Round(afterdisc, 2);
                    }
                    dr["DISC"] = discount;
                    dr["LINETOTAL"] = actval - afterdisc;
                }
            }
        }
        void RecallDiscount()
        {
            txtdiscount.EditValue = null;
            foreach (DataRow dr in dsInventory1.SALESINVDETAIL.Rows)
            {
                if (!bool.Parse(dr["ISRETURN"].ToString()))
                {
                    var actval = decimal.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString());
                    dr["LINETOTAL"] = actval;
                }
            }
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
        #endregion
        #region menu buttons click events
        private void BarButtonItem11ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KeyF11();
        }
        private void BarButtonItem2ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) 
        {
            KeyF2();
        }
        private void BarButtonItem3ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) 
        {
            KeyF3();
        }
        private void BarButtonItem4ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) 
        {
            KeyF4();
        }
        private void BarButtonItem5ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) 
        {
            KeyF5();
        }
        private void BarButtonItem6ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) 
        {
            KeyF6();
        }
        private void BarButtonItem7ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) 
        {
            KeyF7();
        }
        private void BarButtonItem8ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) 
        {
            KeyF8();
        }
        private void BarButtonItem9ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  XtraMessageBox.Show("Please use F9 key ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
           KeyF9();
        }
        private void BarButtonItem10ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KeyF10();
        }
        
        #endregion
        #region grid
        private void gridView1_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (gridView1.FocusedColumn == colQTY && dr["ISRETURN"].ToString() == bool.FalseString)
            {
                if (int.Parse(dr["STOCKID"].ToString()) != 0 && dr["ISRETURN"].ToString() == bool.FalseString)
                {
                    e.Cancel = gridView1.FocusedRowHandle != _rowhandle;
                }
            }
             
            else if (gridView1.FocusedColumn != colQTY && dr["ISRETURN"].ToString() == bool.FalseString)
            {
                e.Cancel = true;
            }
        }
        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (IsStockMore(gridView1, e.RowHandle))
            {
                e.Appearance.BackColor = Color.LightCoral;
            }
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView1.PostEditor();
            var bl = new BusinessLogic.BLSales();
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            int oldvalue = 0;
            int newval1 = 0;
            if (dr == null) return;
            if (_validateoff) return;
            if (e.Column.FieldName.ToUpper() == "QTY" || e.Column.FieldName.ToUpper() == "INVRATE" || e.Column.FieldName.ToUpper() == "EXPDATE1")
            {
                if (e.Column.FieldName.ToUpper() == "QTY" && dr["ISRETURN"].ToString() == bool.FalseString)
                {
                    if (int.Parse(dr["STOCKID"].ToString()) == 0)
                        return;
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
                    if (int.Parse(dr["QTY"].ToString()) < 0)
                        dr["QTY"] = -1 * int.Parse(dr["QTY"].ToString());
                    var tot = Math.Round(int.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString()), 2);
                    var linestock = int.Parse(dr["ASTOCK"].ToString());
                    var totalstock = int.Parse(dr["STOCK"].ToString());
                    if(totalstock < 0)
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
                        if(NotifyItems!=null)
                         noti = NotifyItems.Find(item => item == itm);
                        if (noti!=null)
                        {
                            showstockwindow = true;
                        }
                        else
                        {
                            NotifyItems.Add(itm);
                        }
                        _validateoff = true;
                        UpdateCurrentRow(dr["TID"].ToString(), linestock, oldvalue);

                        if (newval1 - totalstock > 0)
                        {
                           LoadMultiLineItems(dr["itemno"].ToString(),  itm, totalstock - linestock);
                           CreateNegativeNewRow(dr, newval1 - totalstock,showstockwindow);
                        }
                        _validateoff = false;
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
                        dr["QTY"] = -1*int.Parse(dr["QTY"].ToString());

                    if (string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                        dr["INVRATE"] = 0;
                    var tot = Math.Round(int.Parse(dr["QTY"].ToString())*decimal.Parse(dr["INVRATE"].ToString()), 2);
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
                        dr["QTY"] = -1*int.Parse(dr["QTY"].ToString());
                  //purdiscout
                    var tot = Math.Round(int.Parse(dr["QTY"].ToString())*decimal.Parse(dr["INVRATE"].ToString()), 2);
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
                            dr["EXPDATE1"]= null;
                        }
                        else
                        {
                            var split = dr["EXPDATE1"].ToString().Split(new[] { '-' });
                            var dtn = Functions.CreateFirstDayOfMonth(int.Parse(split[1]), int.Parse(split[0]));
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "EXPDATE", dtn);
                        }
                 }
                 if (e.Column.FieldName == "DISC" && dr["ISRETURN"].ToString() == bool.TrueString)
                 {
                     var tot = Math.Round(int.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["INVRATE"].ToString()), 2);
                     if (!string.IsNullOrEmpty(dr["DISC"].ToString()))
                     {
                          if(decimal.Parse(dr["DISC"].ToString()) > 0)
                               tot  = tot -  tot * decimal.Parse(dr["DISC"].ToString()) / 100;
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
        }
        void CreateNegativeNewRow(DataRow dr,int qty,bool showstock)
        {
            var dt = new DsInventory().STOCKMASTER;
            var dStockmasterRow = (DsInventory.STOCKMASTERRow) dt.NewRow();
            dStockmasterRow.ITEMNO = dr["ITEMNO"].ToString();
            dStockmasterRow.BARCODE = dr["BARCODE"].ToString();
            dStockmasterRow.SPRICE =decimal.Parse(dr["SPRICE"].ToString());
            dStockmasterRow.CPRICE = decimal.Parse(dr["CPRICE"].ToString());
            dStockmasterRow.DQNTY = qty;
            new BusinessLogic.BLSales().AddNewItemwithNegativeQty(dStockmasterRow);
            var dnewstock = new BusinessLogic.BLSales().GetStockItem(dStockmasterRow.ITEMNO, "S");
            foreach (DataRow drs  in dnewstock.Rows)
            {
                drs["DQNTY"] = qty;
            }
            AddMultipleItems(dnewstock,dr["ITEMNAME"].ToString(),true);
            onePing();

        }
        void UpdateCurrentRow(string tid, int qty,int oldvalue)
        {
            var rs = dsInventory1.SALESINVDETAIL.FindByTID(int.Parse(tid));
           // if(qty > 0)
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "QTY", qty);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", Math.Round(qty * decimal.Parse(rs["INVRATE"].ToString()), 2));
            new BLSales().UpdateQty(int.Parse(rs["STOCKID"].ToString()), - (qty - oldvalue));
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
                var bl = new BLSales().UpdateDetails(dsInventory1.SALESINVDETAIL);
            }
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
        #endregion
        private void cutomerpayment_EditValueChanged(object sender, EventArgs e)
        {
            if (cutomerpayment.EditValue==null)
                return;
            if (txtnetamt.EditValue != null)
            {
                if (decimal.Parse(cutomerpayment.EditValue.ToString()) > 0)
                {
                    labelControl20.Visible = true;
                    txtnetins.Visible = true;
                    txtnetins.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) *
                                          (decimal.Parse(cutomerpayment.EditValue.ToString())/100);
                }
            }
            if (decimal.Parse(cutomerpayment.EditValue.ToString()) == 0)
            {
                txtnetins.EditValue = 0;
                labelControl20.Visible = false;
                txtnetins.Visible = false;
            }
        }
        private void lookupcustomer_EditValueChanged(object sender, EventArgs e)
        {
            if(lookupcustomer.EditValue==null)
                return;
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
                txtavailble.EditValue = string.IsNullOrEmpty(lookupcustomer.GetColumnValue("CUSTOMERPOINT").ToString()) ? 0 : decimal.Parse(lookupcustomer.GetColumnValue("CUSTOMERPOINT").ToString());
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
            }
        }
        private void gridControl2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
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
        private void gridView1_KeyDown  (object sender, KeyEventArgs e)
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
                    if (dr["ISRETURN"].ToString() == bool.TrueString && gridView1.FocusedColumn ==colDISC)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        txtbarcode.Focus();
                    }
               }
            }    
        }
        private void txtrounding_EditValueChanged(object sender, EventArgs e)
        {
            if (txtrounding.EditValue != null)
            {
                var ret = decimal.Parse(txtnetamt.EditValue.ToString());
                var re = Math.Round(ret, MidpointRounding.AwayFromZero);
                txtnetamt.EditValue = re;
            }
            else
            {
 
            }
            //txtnetamt.EditValue = decimal.Parse(txtnetamt.EditValue.ToString()) +  decimal.Parse(txtrounding.EditValue.ToString());
        }
        private void FunctionKeys(object sender, EventArgs e)
        {
            XtraMessageBox.Show("This are keyboard key references,Use F1-F12", "POS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            var btn = (ToolStripButton) sender;
            switch (btn.Text)
            {
                case "Disc":
                    KeyF1();
                    break;
                case "Inv List":
                    KeyF2();
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
        private void pharmacistLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {   KeyCtrlP(); }
        private void customerReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {   KeyCtrlC(); }
        private void txtpatname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbarcode.Focus();
            }
        }
        private void lookupcustomer_KeyDown_1(object sender, KeyEventArgs e)
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
                     if (decimal.Parse(cutomerpayment.EditValue.ToString()) > 0)
                     {
                         labelControl20.Visible = true;
                         txtnetins.Visible = true;
                         txtnetins.EditValue = decimal.Parse(txtnetamt.EditValue.ToString())*
                                               (decimal.Parse(cutomerpayment.EditValue.ToString())/100);
                     }
                 }
             }
        }
    }
    public class DataClass
    {
        public DataClass(decimal p,int i)
        {
            price = p;
            seed=i;
        }
        public DataClass()
        {}
        public decimal price { get; set; }
        public int seed { get; set; }
    }
    
} 