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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Properties;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class PurchaseOrder : BaseRibbonForm
    {
        BindingSource Bsnav = new BindingSource();
        private string _pono = string.Empty;
        private bool _shorcutKeysDisbale;
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrderLoad(object sender, EventArgs e)
        {
            Ribbonname = "Purchase Order";
            ItemClick += RibbonButtonsClick;
            this.InvokeEx(lv => LoadDataSets());
            Loginname = Utils.Username;

        }

        void LoadDataSets()
        {
            LookupSupplier.Properties.DataSource = ClsGetData.GetSupplier();
            lookUpEdit1.Properties.DataSource = ClsGetData.GetPaymentTypes();
            var dss = ClsGetData.GetStoreList();
            var bindws = new BindingSource(dss, "") { Filter = "STORETYPE='WH'" };
            Lookupwarehouse.Properties.DataSource = bindws;
            //var dsItem = ClsGetData.GetItemMast1List();
            var dsItem = ClsGetData.GetItemMastList();
            dsInventory1.ITEMMAST1.Merge(dsItem);
            repositoryItemLookUpEdit1.DataSource = dsItem;
            SetNavigation();
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
                case "BCLEAR":
                    DoClear();
                    break;
                case "BDELETE":
                    DoDelete();
                    break;
                case "BPRINT":
                    DoPrint(false);
                    break;
                case "BNOTES":
                    DoNotes();
                    break;
                case "BHOLD":
                    break;
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
                case "COPTIONSBUTTON4"://coptionsbutton4
                    DoPrint(true);
                    break;
            }
        }
        void DoNotes()
        {
            if (LookupSupplier.EditValue == null)
            {
                XtraMessageBox.Show("Please select the supplier", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }
            var f = new Notes(LookupSupplier.EditValue.ToString(), LookupSupplier.Text, 11);
            f.ShowDialog();
        }
        bool DoSave()
        {
                if (PurchaseOrderHasErrors())
                {
                    XtraMessageBox.Show("Purchase order  not saved due to error", "POS",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            UpdateTotals();
            bool retval = false;
            var dr = (DsPurchase.POMAINRow) dsPurchase1.POMAIN.NewRow();
            dr.PONO = _pono;
            dr.TRANDATE = invdate.DateTime;
            dr.SUPID = LookupSupplier.EditValue.ToString();
            dr.SUPNAME = string.IsNullOrWhiteSpace(LookupSupplier.Text) ? null : LookupSupplier.Text;
            dr.SUPADD = supadd.EditValue == null ? string.Empty : supadd.EditValue.ToString();
            dr.STORECODE = Lookupwarehouse.EditValue == null ? null : Lookupwarehouse.EditValue.ToString();
            dr.DELADD = deladd.EditValue == null ? string.Empty : deladd.EditValue.ToString();
            dr.NETVALUE = txtnetamt.EditValue == null ? 0 : decimal.Parse(txtnetamt.EditValue.ToString());
            dr.EXTRDISC = txtextradisc.EditValue == null ? 0 : decimal.Parse(txtextradisc.EditValue.ToString());
            dr.supnote = supnote.EditValue==null?null:supnote.EditValue.ToString();
            dr.PAYTERMS = lookUpEdit1.EditValue == null ? 0 : int.Parse(lookUpEdit1.EditValue.ToString());
            var bhl = new BLPO();
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            pODETAILBindingSource.EndEdit();
            bhl.PomainRow = dr;
            var changes = (DsPurchase.PODETAILDataTable)dsPurchase1.PODETAIL.GetChanges(DataRowState.Modified | DataRowState.Added);
            bhl.Podetail = changes ?? dsPurchase1.PODETAIL;
            try
            {
                var saveStatus = bhl.DoSave();
                if (saveStatus == "1")
                {
                    _pono = bhl.Pono;
                    txtpurno.Text = _pono;
                    RibbonSaveEnable = false;
                    HoldButtonVisibility = BarItemVisibility.Never;
                    XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataRow d in dsPurchase1.PODETAIL.Rows)
                    {
                        if (d.RowState != DataRowState.Deleted)
                        {
                            d["PONO"] = bhl.Pono;
                        }
                    }
                    var addedRows = from row in dsPurchase1.PODETAIL
                                    where row.RowState == DataRowState.Added
                                    select row;
                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    if (changes != null) dsPurchase1.Merge(changes);
                    dsInventory1.AcceptChanges();
                    retval = true;
                }
                else
                {
                    XtraMessageBox.Show(saveStatus, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
            SetNavigation();
            return retval;
        }
        void DoSaveNew()
        {
            DoSave();
            DoNew();
        }
        void DoNew()
        {
            _shorcutKeysDisbale = false;
            Functions.DeleteBackUp();
           dsPurchase1.PODETAIL.Clear();
            gridControl1.ResetBindings();
            _pono = string.Empty;
            txtpurno.EditValue = _pono;
            LookupSupplier.EditValue = null;
            Lookupwarehouse.EditValue = null;
            invdate.EditValue = DateTime.Now;
            RibbonSaveEnable = true;
            txtextradisc.EditValue = 0;
            txtnetamt.EditValue = 0;
            lookUpEdit1.EditValue = null;
            Coptionbutton4Visibility = BarItemVisibility.Never;
            BPrint.Visibility = BarItemVisibility.Always;
            lblreceived.Visible = false;
            SaveButtonEnable = true;
        }
        void DoSaveClose()
        {
            if (DoSave())
            {
                Dispose();
            }
            _shorcutKeysDisbale = false;

        }
        void DoClear() { }
        void DoDelete()
        {
            if (gridView1.FocusedRowHandle < 0) return;
            string itname = "[ " + gridView1.FocusedRowHandle + 1 + " ] - " + gridView1.GetDisplayTextByColumnValue(colITEMNO, gridView1.GetFocusedRowCellValue("ITEMNO"));
            if (XtraMessageBox.Show("Do you want to delete the selected  row..?", itname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }
        void DoPrint(bool t)
        {
            if(string.IsNullOrEmpty(_pono))
                return;
            
            if(t)
            {
                BLPO.DoPrint(_pono, true);   
            }
            else
            {
                var frm = new PrintOptions {_pono = _pono};
                frm.ShowDialog();
                if(frm.Isprint)
                {
                    Coptionbutton4Visibility = BarItemVisibility.Always;
                    Coptionbutton4Image = Resources.PrintOk;
                    Coptionbutton4Caption = "Re-Print";
                    SaveButtonEnable = false;
                    RibbonPrintVisible = false; 
                }
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
            _pono = current["PONO"].ToString();
            DoView();
            HoldButtonVisibility = BarItemVisibility.Never;
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
            _pono = current["PONO"].ToString();
            DoView();
            HoldButtonVisibility = BarItemVisibility.Never;

        }
        public void DoView()
        {
            if (!string.IsNullOrEmpty(_pono))
            {
                var bl = new BLPO { Pono = _pono };
                    bl.GetPo();
                var dr = bl.PomainRow;
                txtpurno.Text = _pono;
                
                LookupSupplier.EditValue = dr.SUPID;
                supadd.EditValue = dr.SUPADD;
                deladd.EditValue = dr.DELADD;
                invdate.EditValue = dr.TRANDATE;

                if (dr.isprint)
                {
                    Coptionbutton4Visibility = BarItemVisibility.Always;
                    Coptionbutton4Image = Resources.PrintOk;
                    Coptionbutton4Caption = "Re-Print";
                    RibbonSaveEnable = false;
                    BPrint.Visibility = BarItemVisibility.Never;
                    
                }
                else
                {
                   Coptionbutton4Visibility = BarItemVisibility.Never;
                   RibbonSaveEnable = true;
                   RibbonPrintVisible = true;
                   BPrint.Visibility = BarItemVisibility.Always;
                }
                if(!dr.IsflagrecNull())
                if(dr.flagrec=="R")
                {
                    lblreceived.Visible = true;
                    RibbonSaveEnable = false;
                }
                else
                {
                    RibbonPageEditVisible = true;
                }
                txtextradisc.EditValue = dr.EXTRDISC;
                txtnetamt.EditValue = dr.NETVALUE;
                Lookupwarehouse.EditValue = null;
                Lookupwarehouse.EditValue = dr.STORECODE;
                lookUpEdit1.EditValue = dr.PAYTERMS;

                if (dsPurchase1.PODETAIL.Rows.Count > 0)
                {
                    dsPurchase1.PODETAIL.Clear();
                    Functions.DeleteBackUp();
                    dsPurchase1.Merge(bl.Podetail);
                }
                else
                {
                    dsPurchase1.Merge(bl.Podetail);
                }
                UpdateTotals();
            }
        }
        bool PurchaseOrderHasErrors()
        {
            
            if(LookupSupplier.EditValue==null)
            {
                XtraMessageBox.Show("Please select the supplier", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return true;
            }
            if(lookUpEdit1.EditValue==null)
            {
                XtraMessageBox.Show("Please select the pay type", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return true;
            }
            foreach (DsPurchase.PODETAILRow dr in dsPurchase1.PODETAIL)
            {
                if(!string.IsNullOrEmpty(dr.QTY.ToString()))
                {
                    if(dr.QTY <=0)
                    {
                        dr.SetColumnError("QTY","Please check the Qty.");
                    }
                    else
                    {
                        dr.SetColumnError("QTY", null);
                    }
                }
                if (!string.IsNullOrEmpty(dr.INVRATE.ToString()))
                {
                    if (dr.QTY <= 0)
                    {
                        dr.SetColumnError("INVRATE", "Please check the price");
                    }
                    else
                    {
                        dr.SetColumnError("INVRATE", null);
                    }
                }
            }
            if (dsPurchase1.PODETAIL.HasErrors)
                return true;
            return false;
        }
        private void PurchaseOrderKeyDown(object sender, KeyEventArgs e)
        {
            if (_shorcutKeysDisbale) return;
            if (e.KeyCode == Keys.F10)
            { AddItems(string.Empty); }
            if (e.KeyCode == Keys.F5)
            { ItemClone(); }
            if (e.KeyCode == Keys.F4)
            { DoDelete(); }
            if (e.KeyCode == Keys.F8)
            {
                if (gridView1.DataRowCount > 0)
                {
                    var dr = gridView1.GetFocusedDataRow();
                    if (dr != null)
                    {
                        var frm = new Puranalyse(dr["ITEMNO"].ToString(),gridView1.GetFocusedRowCellDisplayText("ITEMNO"));
                        frm.ShowDialog();
                    }
                }
            }
        }
        void ItemClone()
        {
            if (gridView1.FocusedRowHandle < 0) return;
            var dr1 = gridView1.GetFocusedDataRow();
            var newRow = dsPurchase1.PODETAIL.NewRow();
            newRow.ItemArray = dr1.ItemArray;
            newRow["TID"] = Functions.GetAutoSeed(dsPurchase1.PODETAIL);
            dsPurchase1.PODETAIL.Rows.Add(newRow);
        }
        void AddItems(string itemno)
        {
            var frm = new FrmItemLookUp(dsPurchase1.PODETAIL, itemno);
            frm.EventSelectedItem += AdditemsToList;
            frm.ShowDialog();
            if (ActiveControl.Name != "gridControl1")
            {
                barEditItem2.EditValue = null;
                gridControl1.Focus();
                gridView1.FocusedRowHandle = 0;
            }
        }
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
         {
             DataRow d = e.SelectedRow;
             AddItemsToList(d["sel"].ToString(), d);
         }
        private void AddItemsToList(string selected, DataRow adr,int qty=0)
         {
             if (selected == bool.TrueString)
             {
                 var dr = dsPurchase1.PODETAIL.NewRow();
                 dr["GROUPID"] = adr["GROUPID"];
                 if (int.Parse(adr["groupid"].ToString()) == 1)
                 {
                     dr["DISC"] = adr["discount"];
                 }
                 dr["PONO"] = 0;
                 dr["ITEMNO"] = adr["ITEMNO"];
                 dr["BARCODE"] = adr["barcode"];
                 dr["INVRATE"] = adr["CPRICE"];
                 if(qty >0)
                     dr["QTY"] = qty;
                 dsPurchase1.PODETAIL.Rows.Add(dr);
             }
             else
             {
                 var i = 0;
                 foreach (DataRow d in dsPurchase1.PODETAIL.Rows)
                 {
                     if (d.RowState != DataRowState.Deleted)
                         if (d["itemno"].ToString() == adr["itemno"].ToString())
                         {
                             dsPurchase1.PODETAIL.Rows.RemoveAt(i);
                             break;
                         }
                     i++;
                 }
             }
         }
        private void  GridView1CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
          //  gridView1.UpdateCurrentRow();
             var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
             if (dr == null) return;
             if (e.Column.FieldName == "QTY" || e.Column.FieldName == "INVRATE"  || e.Column.FieldName == "DISC")
             {
                 var qty = 0;
                 var invrate = 0m;
                 var disc = 0m;
                 if (!string.IsNullOrWhiteSpace(dr["QTY"].ToString()))
                     qty = int.Parse(dr["QTY"].ToString());
                 if (!string.IsNullOrWhiteSpace(dr["DISC"].ToString()))
                     disc = decimal.Parse(dr["DISC"].ToString());
                 if (!string.IsNullOrWhiteSpace(dr["INVRATE"].ToString()))
                     invrate = decimal.Parse(dr["INVRATE"].ToString());
                 var linetot = (qty * invrate) - (qty * invrate) * disc / 100;
                 gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "LINETOTAL", linetot);
             }
             UpdateTotals();
         }
        private void CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;
            e.Info.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            //if(!iserroricon)
            e.Info.Appearance.TextOptions.VAlignment = VertAlignment.Center;

            e.Info.DisplayText = (1 + int.Parse(e.RowHandle.ToString(CultureInfo.InvariantCulture))).ToString(CultureInfo.InvariantCulture);
            e.Info.ImageIndex = -1;
        }
        void UpdateTotals()
         {
             try
             {
                 decimal vtotval = 0;
                 decimal vtotdisc = 0;
                 for (int i = 0; i < gridView1.DataRowCount; i++)
                 {
                     if (!string.IsNullOrEmpty(gridView1.GetRowCellValue(i, "INVRATE").ToString()) &&
                         !string.IsNullOrEmpty(gridView1.GetRowCellValue(i, "QTY").ToString()))
                     {
                         vtotval += decimal.Parse(gridView1.GetRowCellValue(i, "LINETOTAL").ToString());
                     }
                 }
                 if (txtextradisc.EditValue != null)
                     vtotdisc = decimal.Parse(txtextradisc.EditValue.ToString());
                 txtnetamt.EditValue = vtotval - vtotdisc;
             }
             catch(Exception)
             {
                 XtraMessageBox.Show("Please check the amount", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }
        private void SupplierEditValueChanged(object sender, EventArgs e)
        {
            if (LookupSupplier.EditValue != null)
            {
                var row = LookupSupplier.Properties.GetDataSourceRowByKeyValue(LookupSupplier.EditValue) as DataRowView;
                if (row == null) return;
                supadd.EditValue = row["ADDRESS"].ToString();
                var f = new Notes();
                if (f.CheckNotesAvailable(LookupSupplier.EditValue.ToString(),11))
                {
                    var f1 = new Notes(LookupSupplier.EditValue.ToString(), LookupSupplier.Text, 11);
                    f1.ShowDialog();
                }
            }
        }
        void SetNavigation()
        {
            Bsnav.DataSource = BLPO.GetPOMast();
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
        private void TxtextradiscEditValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }
        private void BarManager1EditorKeyDown(object sender, KeyEventArgs e)
        {
            barManager1.ActiveEditItemLink.PostEditor();
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Return && e.KeyCode != Keys.Tab) return;
            if (e.KeyCode == Keys.Tab)
            {
                gridControl1.Focus();
                return;
            }
            if (barEditItem2.EditValue == null && gridView1.DataRowCount != 0 && e.KeyCode == Keys.Enter)
            {
                gridControl1.Focus();
                gridView1.FocusedColumn = colQTY;
                return;
            }
            if (barEditItem2.EditValue == null)
                return;

            var sitemno = barEditItem2.EditValue.ToString().ToUpper(CultureInfo.InvariantCulture);
            IEnumerable<DataRow> query;
            query = from p in dsInventory1.ITEMMAST1 where p.BARCODE.ToUpper() == sitemno || p.ITEMNAME.ToUpper() == sitemno select p;
            var count = query.Count();
            if (count > 0)
            {
                var tb = query.CopyToDataTable();
                var bs = (BindingSource)gridControl1.DataSource;
                if (bs.Find("ITEMNO", tb.Rows[0]["ITEMNO"].ToString()) >= 0)
                {
                    if (XtraMessageBox.Show("Item availble in list do want add ?", "P.O.S", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        AddItemsToList(bool.TrueString, tb.Rows[0]);
                        barEditItem2.EditValue = null;
                        e.SuppressKeyPress = true;
                    }
                    else
                    {
                        barEditItem2.EditValue = null;
                        e.SuppressKeyPress = true;
                    }
                }
                else
                {
                    AddItemsToList(bool.TrueString, tb.Rows[0]);
                    barEditItem2.EditValue = null;
                    e.SuppressKeyPress = true;
                }
            }
            else
            {
                AddItems(sitemno);
            }
        }
        private void FindItemItemClick(object sender, ItemClickEventArgs e)
        {
            AddItems(string.Empty);
        }
        private void CopyRowItemClick(object sender, ItemClickEventArgs e)
        {
            ItemClone();
        }
        protected bool IsLastVisibleRow(GridView view, int rowHandle)
        {
            var viewInfo = view.GetViewInfo() as GridViewInfo;
            if (viewInfo == null || viewInfo.RowsInfo == null || viewInfo.RowsInfo.Count == 0)
                return false;
            return viewInfo.RowsInfo[viewInfo.RowsInfo.Count - 1].RowHandle == rowHandle;
        }
        private void GridControl1KeyDown(object sender, KeyEventArgs e)
        {
            if (IsLastVisibleRow(gridView1, gridView1.FocusedRowHandle))
            {
                gridView1.UpdateCurrentRow();
                txtextradisc.Focus();
            }
        }
        private void TxtextradiscEnter(object sender, EventArgs e)
        {
                txtextradisc.SelectAll();
        }

        public void GeneratePOFrmPR(DsPurchase.PURCHASEREQUESTDataTable dt)
        {
           // LookupSupplier.EditValue = supno;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["INORDER"].ToString() == bool.TrueString)
                {
                    LookupSupplier.EditValue = dr["SUPPLIERNO"].ToString();
                    var blf = new BlItemMaster().FindItemByBarCode(dr["ITEMNO"].ToString());
                    foreach (DataRow drt in blf.Rows)
                    {
                        AddItemsToList("True", drt, int.Parse(dr["QTY"].ToString()));
                    }
                }
            }
            ShowDialog();
        }
    }
}
