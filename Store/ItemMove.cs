using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class ItemMove : BaseRibbonForm
    {
        public string _tranid = string.Empty;
        private bool _isHold;
        private bool _isStore = false;
        bool SaveRequired = true;
        bool ShorcutKeysDisbale;
        protected BindingSource Bsnav = new BindingSource();
        public TextBox Tnav = new TextBox();
        BindingSource bsS = new BindingSource();
        BindingSource bsW = new BindingSource();
        public bool OtherStore { get; set; }
        private DsPurchase.PURCHASEREQUESTDataTable dt;
        public ItemMove()
        {
            InitializeComponent();
            NoteButtonVisibility = BarItemVisibility.Never;
            repositoryItemLookUpEdit1.DataSource = ClsGetData.GetItemMastList();
            dateEdit1.DateTime = DateTime.Now;
          // CheckHoldItemMove();
        }
        void CheckHoldItemMove()
            {
               if(OtherStore)
                   return;
            
                var f = new HoldItemMove();
                if (f.RecCount > 0)
                {
                    f.ShowDialog();
                    if(!string.IsNullOrEmpty(f.Tranid))
                    {
                      _tranid = f.Tranid;
                       DoView();                        
                    }
                }
            }
        public int ItemMoveType { get; set; }
        private void ItemMoveLoad(object sender, EventArgs e){
            Ribbonname = "Inventory Transfer";
            ItemClick += RibbonButtonsClick;
            dateEdit1.DateTime = DateTime.Now;
            SetNavigation();
            var dsW = ClsGetData.GetStoreList();
            var dsS = ClsGetData.GetStoreList();
        //  var bsW = new BindingSource(dsW, "") {Filter = "STORETYPE='WH' And COMPANY = '" + Utils.Company + "'"};
  
            bsW = new BindingSource(dsW, "") { Filter =  "COMPANY = '" + Utils.Company + "'" };

            lookupfrom.Properties.DataSource = bsW;
            bsS = new BindingSource(dsS, "");
            lookupto.Properties.DataSource = bsS;
            DeleteButtonVisibility=BarItemVisibility.Never;
            Loginname = Utils.Username;
            CheckHoldItemMove();
            iTEMGROUPBindingSource.DataSource = ClsGetData.GetItemGroup();

        }
        void RibbonButtonsClick(object sender, ItemClickEventArgs name)
        {
            switch (name.Item.Name.ToUpper())
            {
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
                case "BCLEAR":
                    DoClear();
                    break;
                case "BDELETE":
                    DoDelete();
                    break;
                case "BPRINT":
                    DoPrint();
                    break;
                case "BNOTES":
                    DoNotes();
                    break;
                case "BHOLD":
                    DoHold();
                    break;
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
                case "BHOLDLIST":
                    CheckHoldItemMove();
                    break;
            }
        }
        private void BarManager1EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Return && e.KeyCode != Keys.Tab) return;
            if (e.KeyCode == Keys.Tab)
            {
                gridControl1.Focus();
                return;
            }
            if (lookupfrom.EditValue == null)
            {
                XtraMessageBox.Show("Please select from location", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            barManager1.ActiveEditItemLink.PostEditor();
            if (barEditItem1.EditValue == null) return;
            var sitemno = barEditItem1.EditValue.ToString().ToUpper(CultureInfo.InvariantCulture);
            IEnumerable<DataRow> query;
            IEnumerable<DataRow> query1 = null;
            query = from p in dsInventory1.ITEMMAST1 where p.ITEMNO  == sitemno ||   p.BARCODE == sitemno || p.ITEMNAME.ToUpper() == sitemno select p;
            if (query.Count() > 0)
            {
                string qry = string.Empty;
                sitemno = GetBarCodeFromQuery(query);
                if (!_isStore)
                {
                    qry = "ITEMNO = '" + sitemno + "' AND QTY > 0 AND WHID = " +
                          int.Parse(lookupfrom.EditValue.ToString()) + " AND COMPANY = '" + Utils.Company + "'";
                }
                else
                {
                    qry = "ITEMNO = '" + sitemno + "' AND QTY > 0 AND WHID = '" + lookupfrom.EditValue + "' AND COMPANY = '" + Utils.Company + "'";
                }
                query1 = dsInventory1.STOCKMASTER.Select(qry);
                if (query1.Count() > 0)
                {
                    var tb = query1.CopyToDataTable();
                    if (iTEMTRANSFERDETAILBindingSource.Find("STOCKID", tb.Rows[0]["STOCKID"].ToString()) >= 0)
                    {
                        XtraMessageBox.Show("Item availble in list....!", "P.O.S", MessageBoxButtons.OK);
                        barEditItem1.EditValue = null;
                        e.SuppressKeyPress = true;
                        return;
                    }
                    foreach (DataRow b in tb.Rows)
                    {
                        AddItemsToList(bool.TrueString, b);
                    }
                }
            }
            else
            {
                AddItems(sitemno);
            }
        }
        string GetBarCodeFromQuery(IEnumerable<DataRow> qry)
        {
            var tb = qry.CopyToDataTable();
            return tb.Rows[0]["ITEMNO"].ToString();
        }
        private void BarButtonItem1ItemClick(object sender, ItemClickEventArgs e)
        {
            AddItems(string.Empty);
        }
        private void GridView1CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            gridView1.PostEditor();
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (e.Column.FieldName == "QTY")
            {
                if (int.Parse(dr["QTY"].ToString()) > int.Parse(dr["STOCK"].ToString()))
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "QTY", int.Parse(dr["STOCK"].ToString()));
                }
                var tot = int.Parse(dr["QTY"].ToString()) * decimal.Parse(dr["SPRICE"].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", Math.Round(tot, 2));

                //if (!string.IsNullOrEmpty(dr["SPRICE"].ToString()))
                //{
                //    if (decimal.Parse(dr["SPRICE"].ToString()) > 0)
                //    {
                //        var ln = decimal.Parse(e.Value.ToString()) * decimal.Parse(dr["SPRICE"].ToString());
                //        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", Math.Round(ln, 2));
                //    }
                //}
                //}
            }
            gridView1.UpdateCurrentRow();
            UpDateTotal();
        }
        void UpDateTotal()
        {
            foreach (DsInventory.ITEMTRANSFERDETAILRow d  in dsInventory1.ITEMTRANSFERDETAIL)
            {
                d.LINETOTAL = d.QTY*d.SPRICE;
            }
        }
        #region BLL
        void AddItems(string itemno){
            if (lookupfrom.EditValue == null && lookupto.EditValue == null)
            {
                XtraMessageBox.Show("Please select correct locations", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lookupfrom.EditValue == lookupto.EditValue)
            {XtraMessageBox.Show("Please select correct locations", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lookupfrom.EditValue != null)
            {
                var frm = new StockList(dsInventory1.ITEMTRANSFERDETAIL, itemno, lookupfrom.EditValue.ToString(), _isStore);
                frm.EventSelectedItem += AdditemsToList;
                frm.ShowDialog();
            }
            if (ActiveControl.Name != "gridControl1")
                gridControl1.Focus();
        }
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            var d = e.SelectedRow;
            AddItemsToList(d["sel"].ToString(), d);
        }
        private void AddItemsToList(string selected, DataRow adr)
        {
            if (selected == bool.TrueString)
            {
                bool itemfound = false;
                foreach(DataRow fdr in dsInventory1.ITEMTRANSFERDETAIL.Rows)
                {
                    if (fdr.RowState != DataRowState.Deleted)
                    {
                        if (fdr["STOCKID"].ToString() == adr["STOCKID"].ToString())
                        {
                            itemfound = true;
                        }
                    }
                }
                if (!itemfound)
                {
                    var dr = dsInventory1.ITEMTRANSFERDETAIL.NewRow();
                    dr["TRANID"] = 0;
                    dr["ITEMNO"] = adr["itemno"];
                    dr["BARCODE"] = adr["BARCODE"];
                    dr["WHID"] = adr["WHID"];
                    dr["STOCKID"] = adr["STOCKID"];
                    dr["STOCK"] = adr["QTY"];
                    dr["CPRICE"] = adr["CPRICE"]; //ClsGetData.GetItemCostPrice(adr["ITEMNO"].ToString());
                    dr["SPRICE"] = adr["SPRICE"]; // ClsGetData.GetItemSalesPrice(adr["ITEMNO"].ToString());
                    dr["EXPDATE"] = adr["EXPDATE"]; //  dr["BATCHNO"] = adr["BATCHNO"]; // dr["PURINVID"] = adr["PURINVID"];
                    dsInventory1.ITEMTRANSFERDETAIL.Rows.Add(dr);
                }
            }
            else
            {
                var i = 0;
                foreach (DataRow d in dsInventory1.ITEMTRANSFERDETAIL.Rows)
                {
                    if (d.RowState != DataRowState.Deleted)
                        if (d["ITEMNO"].ToString() == adr["itemno"].ToString())
                        {
                            if (string.IsNullOrEmpty(d["QTY"].ToString()))
                                dsInventory1.ITEMTRANSFERDETAIL.Rows.RemoveAt(i);
                            break;
                        }
                    i++;
                }
            }
        }
        void DoSaveClose()
        {
            if (DoSave())
            {
                Dispose();
            }
        }
        void DoHold()
        {
            _isHold = true;
            DoSave();
        }
        void DoNotes()  {}
        void DoPrint()
        {
            DoBarCodePrinter();
            if(_tranid!=null)
                Blitemmove.DoPrint(_tranid);
        }
        void DoBarCodePrinter()
        {
            
        }
        void DoDelete() {}
        void DoClear()  {}
        void DoNew()
        {
             bsW.Filter=" COMPANY = '" + Utils.Company + "'";
            _tranid = string.Empty;
            lookupfrom.EditValue = null;
            lookupto.EditValue = null;
            txtpurno.Text = _tranid;
            memoEdit1.EditValue = string.Empty;
            dsInventory1.ITEMTRANSFERDETAIL.Clear();
            gridControl1.ResetBindings();
            RibbonSaveEnable = true;
            HoldButtonVisibility = BarItemVisibility.Always;
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
            _tranid = current["TRANID"].ToString();
            DoView();
            RibbonSaveEnable = false;
            HoldButtonVisibility = BarItemVisibility.Never;
        }
        public void DoView(bool hideribbon=false,bool useoother=false,string concomp = "")
        {
            if (!string.IsNullOrEmpty(_tranid))
            {
                var bl = new Blitemmove { Tranid = _tranid };
                bl.GetItemMoveByTranid(useoother,concomp);
                bsW.Filter = "";
                txtpurno.Text = _tranid;
                dateEdit1.EditValue = bl.Trandate;
                lookupfrom.EditValue = bl.FromId;
                lookupto.EditValue = bl.ToId;
                memoEdit1.EditValue = bl.Notes;
                ShorcutKeysDisbale =  !bl.Hold;
                if (dsInventory1.ITEMTRANSFERDETAIL.Rows.Count > 0)
                {
                    dsInventory1.ITEMTRANSFERDETAIL.Clear();
                    dsInventory1.Merge(bl.Itemtransferdetail);
                }
                else
                {
                    dsInventory1.Merge(bl.Itemtransferdetail);
                }
                if(!bl.Hold)
                {
                    SaveButtonEnable = false;
                    SaveandNewButtonEnable = false;
                    SaveandcloseButtonEnable = false;

                     HoldButtonVisibility = BarItemVisibility.Never;
                   //  ribbon.Hide = true;
                    //ribbon.Visible = false;
                }
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
            _tranid = current["TRANID"].ToString();
            RibbonSaveEnable = false;
            DoView();
            HoldButtonVisibility = BarItemVisibility.Never;
        }
        void SetNavigation()
        {
            Bsnav.DataSource = new Blitemmove().GetItemTransfer();
            Bsnav.Filter = " HOLD = 0 AND COMPANY = '" + Utils.Company + "' ";
            Tnav.DataBindings.Add(new Binding("Text", Bsnav, "TRANID", true));
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
        void DoSaveNew()
        {
          if(DoSave())
                DoNew();
        }
        bool DoSave()
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            bool retval = false;
            if (lookupfrom.EditValue == lookupto.EditValue)
            {
                XtraMessageBox.Show("Please select correct locations", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (dsInventory1.ITEMTRANSFERDETAIL.Count == 0)
            {
                XtraMessageBox.Show("Nothing to save", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!_isHold)
            {
                if (int.Parse(lookupto.GetColumnValue("COMM").ToString()) == 3)
                {
                    if (lookupto.GetColumnValue("COMPANY").ToString() != lookupfrom.GetColumnValue("COMPANY").ToString())
                    {
                        XtraMessageBox.Show("Internal transfer not possible for different companies", "POS",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                ItemMoveHasErrors();
                if (dsInventory1.ITEMTRANSFERDETAIL.HasErrors)
                {
                    XtraMessageBox.Show("Document not saved due to error, please check the errors", "POS",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //if (ValidateSalesHold())
                //    return false;
            }
            var dr = (DsInventory.ITEMTRANSFERMAINRow)dsInventory1.ITEMTRANSFERMAIN.NewRow();
            //if (!string.IsNullOrEmpty(_tranid))
            dr.TRANID = _tranid;
            dr.COMPANY = Utils.Company;
            dr.FRMSTOREID =lookupfrom.EditValue.ToString();
            dr.TOSTOREID  = lookupto.EditValue.ToString();
            dr.TRANDATE = dateEdit1.DateTime;
            dr.TOTVALUE = GetTotal();
            dr.HOLD = _isHold;
            dr.USERID = Utils.Userid;
            dr.FRMNAME = lookupfrom.Text;
            dr.TONAME = lookupto.Text;
            dr.TTYPE = int.Parse(lookupto.GetColumnValue("COMM").ToString());
            dr.TOCOMP = lookupto.GetColumnValue("COMPANY").ToString();
            var stype = lookupto.GetColumnValue("STORETYPE").ToString().Substring(0,1);
            var bhl = new Blitemmove {ItemtransfermainRow = dr,Stype = stype};
            ShorcutKeysDisbale = !_isHold;
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            iTEMTRANSFERDETAILBindingSource.EndEdit();
            var changes = (DsInventory.ITEMTRANSFERDETAILDataTable)dsInventory1.ITEMTRANSFERDETAIL.GetChanges(DataRowState.Modified | DataRowState.Added);
            bhl.Itemtransferdetail = dsInventory1.ITEMTRANSFERDETAIL;
            try
            {
                var strstatus = bhl.DoSave();
                if (strstatus == "1")
                {
                    _tranid = bhl.Tranid;
                    txtpurno.Text = _tranid;
                    RibbonSaveEnable = false;
                    HoldButtonVisibility = BarItemVisibility.Never; 
                    XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataRow d in dsInventory1.ITEMTRANSFERDETAIL.Rows)
                    {
                        if (d.RowState != DataRowState.Deleted)
                        {
                            d["TRANID"] = bhl.Tranid;
                        }
                    }
                    var addedRows = from row in dsInventory1.ITEMTRANSFERDETAIL
                                    where row.RowState == DataRowState.Added
                                    select row;
                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    if (changes != null) dsInventory1.Merge(changes);
                    dsInventory1.AcceptChanges(); 
                    retval = true;
                    if (dt != null)
                        new PrDataManager().UpdateMaterialRequestTrans(dt, _tranid);

                }
                else
                {
                    XtraMessageBox.Show(strstatus,"POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
            SaveRequired = !retval;
            return retval;
        }
        decimal GetTotal()
        {
            decimal tot = 0;
            foreach (DataRow d in dsInventory1.ITEMTRANSFERDETAIL.Rows)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    if (!string.IsNullOrEmpty(d["LINETOTAL"].ToString()))
                        tot += decimal.Parse(d["LINETOTAL"].ToString());
                }
            }
            return tot;
        }
        bool ItemMoveHasErrors()
        {
            ValidateStock();
            return dsInventory1.ITEMTRANSFERDETAIL.HasErrors;
        }
        void ValidateStock()
        {
            foreach (DsInventory.ITEMTRANSFERDETAILRow d in dsInventory1.ITEMTRANSFERDETAIL)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    if (d.IsQTYNull())
                    {
                        d.SetColumnError("QTY","Please enter the Quantity");
                    }
                    else if(d.QTY<= 0)
                    {
                        d.SetColumnError("QTY", "Please check the Quantity");
                    }
                    else
                    {
                        d.SetColumnError("QTY", null);
                    }
                    if (!d.IsQTYNull())
                    {
                        var stock = Functions.CheckStockAvailable(d.STOCKID);
                        d.SetColumnError("STOCK", (d.QTY) > stock ? "Qty. is more than the stock" : null);
                    }
                    //if (!d.IsQTYNull())
                    //{
                    //     var stock = Functions.CheckStockAvailable(d.STOCKID);
                    //     d.SetColumnError("STOCK", (d.QTY) > stock ? "Qty. is more than the stock" : null);
                    //}
                }
            }
        }
        public void CreateItemMoveFrmPr(string whid)
        {
            //var dsStore = ClsGetData.GetStoreList();
            //var dr1= dsStore.Select ("COMPANY = '" + Utils.Company + "'");
            //var dr = dr1[0];
            var bl = new Blitemmove();
          
           // lookupfrom.EditValue = dr[0].ToString();
           // lookupto.EditValue = whid;
            bl.CreateItemtransferdetailsFrmMr(dt, lookupfrom.EditValue.ToString());
            //foreach (DsInventory.ITEMTRANSFERDETAILRow drn in bl.Itemtransferdetail)
            //{
            //    var nr = dsInventory1.ITEMTRANSFERDETAIL.NewRow();
            //    dsInventory1.ITEMTRANSFERDETAIL.Rows.Add(nr);
            //}
           // gridControl1.DataSource = bl.Itemtransferdetail;
              dsInventory1.Merge(bl.Itemtransferdetail);
             // new PrDataManager().UpdateMaterialRequestTrans(dt);
        }
        #endregion
        private void ItemMoveKeyDown(object sender, KeyEventArgs e)
        {
            if (ShorcutKeysDisbale) return;
            if(e.KeyCode==Keys.F10)
            {
             this.InvokeEx(x=> AddItems(string.Empty));
            }
            if(e.KeyCode==Keys.F4)
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    if(XtraMessageBox.Show("Do you want to delete selected line items","POS",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    }
                }
            }
        }
        private void GridView1CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;
            e.Info.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            e.Info.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            e.Info.DisplayText = (1 + int.Parse(e.RowHandle.ToString(CultureInfo.InvariantCulture))).ToString(CultureInfo.InvariantCulture);
            e.Info.ImageIndex = -1;
        }
        private void GridControl1Click(object sender, EventArgs e)
        {

        }
        private void DateEdit1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                barManager1.Bars[0].ItemLinks[0].Focus();
            }
        }
        private void GridControl1EditorKeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab) return;
            ////if (gridView1.FocusedColumn.VisibleIndex == 1)
            ////{
            ////    gridView1.FocusedColumn = colQTY;
            ////    e.Handled = true;
            ////}
            //if (gridView1.FocusedColumn.VisibleIndex == 3)
            //{
            //    if (IsLastVisibleRow(gridView1, gridView1.FocusedRowHandle))
            //    {
            //        gridView1.FocusedColumn = colBATCHNO;
            //        gridView1.UpdateCurrentRow();
            //        e.Handled = true;
            //    }
            //    else
            //    {
            //        gridView1.MoveNext();
            //        gridView1.FocusedColumn = colBATCHNO;
            //        e.Handled = true;
            //    }
            //}
           

        }
        private void ItemMoveFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SaveRequired) return;
            if (string.IsNullOrEmpty(_tranid))
            {
                if (dsInventory1.ITEMTRANSFERDETAIL.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show("You are going to exit this program data is not saved, want to hold ? ", "P.O.S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _isHold = true;
                        DoSave();
                        Dispose();
                    }
                }
            }
            if (!string.IsNullOrEmpty(_tranid))
            {
                if (dsInventory1.HasChanges())
                {
                    if (XtraMessageBox.Show(" Do you want to save the changes ? ", "P.O.S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _isHold = false;
                        if (ItemMoveHasErrors())
                            if (DoSave())
                                Dispose();
                    }
                }
            }
        }
        private void LookupfromEditValueChanged(object sender, EventArgs e)
        {
            if (lookupfrom.EditValue != null)
            {
                bsS.Filter = "STORECODE <> '" + lookupfrom.EditValue + "'";
               //lookupto.Properties.DataSource = bsS;
            }
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lookupto.EditValue == null || lookupfrom.EditValue == null)
            {
                XtraMessageBox.Show("Please select from store and to store", "ITEM TRANSFER", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
             else
            {
                //var t = new PrDataManager().GetPurchaseRequestListForMMR(lookupto.EditValue.ToString());
                //CreateItemMoveFrmPr(t, lookupto.EditValue.ToString());
                DataRowView d;
                DsReports.GetSTOCKMASTERDataTable dt;
                if (barEditItem3.EditValue != null)
                {
                    d = (DataRowView) repositoryItemLookUpEdit3.GetDataSourceRowByKeyValue(barEditItem3.EditValue);
                    dt = ClsGetData.GetStockmasterByGroup(int.Parse(d[0].ToString()));
                }
                else
                {
                 dt = ClsGetData.GetStockmasterByGroup(0);
                }

                foreach (DsReports.GetSTOCKMASTERRow dr in dt.Rows)
                {
                    var newrow = (DsInventory.ITEMTRANSFERDETAILRow)dsInventory1.ITEMTRANSFERDETAIL.NewRow();
                    newrow.ITEMNO = dr.ITEMNO;
                    newrow.BARCODE = dr.BARCODE;
                    newrow.WHID = lookupfrom.EditValue.ToString();
                    newrow.STOCK = dr.QTY;
                    newrow.QTY = dr.QTY;
                    newrow.SPRICE = dr.SPRICE;
                    newrow.CPRICE = dr.CPRICE;
                    if (!dr.IsEXPDATENull())
                        newrow.EXPDATE = dr.EXPDATE;
                    newrow.LINETOTAL = dr.QTY * dr.SPRICE;
                    newrow.STOCKID = dr.STOCKID;
                    newrow.TOSTORE = lookupto.EditValue.ToString();
                    dsInventory1.ITEMTRANSFERDETAIL.Rows.Add(newrow);
                }
            }
        }
        private void lookupto_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tranid))
            {
                var t = new PrDataManager().GetPurchaseRequestListForMMR(lookupto.EditValue.ToString());
                if (t.Rows.Count > 0)
                {
                    simpleButton1.Visible = true;
                    //  XtraMessageBox.Show("Please select from  request", "ITEM TRANSFER", MessageBoxButtons.OK,MessageBoxIcon.Information);
                   // XtraMessageBox.Show("Pending material request ")
                }
                else
                {
                   simpleButton1.Visible = false;
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dt = new PrDataManager().GetPurchaseRequestListForMMR(lookupto.EditValue.ToString());
            CreateItemMoveFrmPr(lookupto.EditValue.ToString());
        }
        private void barEditItem3_EditValueChanged(object sender, EventArgs e)
        {}
    }
}
