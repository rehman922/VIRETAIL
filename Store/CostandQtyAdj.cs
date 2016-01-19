using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class CostandQtyAdj : BaseRibbonForm
    {
        BindingSource Bsnav = new BindingSource();
        private string _Adjid = string.Empty;
        private bool _disableshortcut;
        
        public CostandQtyAdj()
        {
            InitializeComponent();
        }
         
        private void CostandQtyAdj_Load(object sender, EventArgs e)
        {
            RibbonPageMoreOptionsVisible = false;
            RibbonPageEdit = false;
            Ribbonname = "Inventory Adjustment";
            var ds = ClsGetData.GetStoreList();
            
            var bs = new BindingSource(ds, "") {Filter = "COMPANY='" + Utils.Company + "'"};
            Lookupwarehouse.Properties.DataSource = bs;
            this.InvokeEx(x => dsInventory1.ITEMMAST1.Merge(ClsGetData.GetItemMastList()));
          //  dsInventory1.ITEMMAST1.Merge(ClsGetData.GetItemMastList());
            repositoryItemLookUpEdit1.DataSource = dsInventory1.ITEMMAST1;
            dsInventory1.STOCKMASTER.Merge(ClsGetData.GetStockMaster());
            ItemClick += RibbonButtonsClick;
            SetNavigation();
            invdate.DateTime = DateTime.Now;
            Loginname = Utils.Username;
            if (Utils.Username.ToUpper() == "ASHRAF" ||
                Utils.Username.ToUpper() == "MUSTAFA")
                gridBand2.Visible = true;
            else
            {
                gridBand2.Visible = false;
            }

        }
        private void barManager1_EditorKeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Return && e.KeyCode != Keys.Tab) return;
            if (e.KeyCode == Keys.Tab)
            {
                gridControl1.Focus();
                return;
            }
            if (Lookupwarehouse.EditValue == null)
            {
                XtraMessageBox.Show("Please select the warehouse / Store", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }

            barManager1.ActiveEditItemLink.PostEditor();
            if (barEditItem2.EditValue == null) return;
            var sitemno = barEditItem2.EditValue.ToString().ToUpper(CultureInfo.InvariantCulture);
            // Select Item From Inventory --- User has to select the store-----
            IEnumerable<DataRow> query;
            IEnumerable<DataRow> query1 = null;
            query = from p in dsInventory1.ITEMMAST1 where p.ITEMNO == sitemno || p.ITEMNAME.ToUpper() == sitemno select p;
            if (query.Count() > 0)
            {
               // sitemno = Functions.GetBarCodeFromQuery(query);
                var qry = "ITEMNO = '" + sitemno + "' AND  WHID = '" + Lookupwarehouse.EditValue + "' AND COMPANY = '" + Utils.Company + "'";
                query1 = dsInventory1.STOCKMASTER.Select(qry);
                if (query1.Count() > 0)
                {
                    var tb = query1.CopyToDataTable();
                    if (aDJDETAILBindingSource.Find("STOCKID", tb.Rows[0]["STOCKID"].ToString()) >= 0)
                    {
                        XtraMessageBox.Show("Item availble in list....!", "P.O.S", MessageBoxButtons.OK);
                        barEditItem2.EditValue = null;
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
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            DataRow d = e.SelectedRow;
            AddItemsToList(d["sel"].ToString(), d);
        }
        private void AddItemsToList(string selected, DataRow adr)
        {
            if (selected == bool.TrueString)
            {
                var dr = dsInventory1.ADJDETAIL.NewRow();
                dr["ADJID"] = String.Empty;
                dr["ITEMNO"] = adr["itemno"];
                dr["BARCODE"] = adr["barcode"];
                dr["STOCKID"] = adr["STOCKID"];
                dr["ACTQTY"] = adr["QTY"];
                dr["ACTCPRICE"] = adr["CPRICE"];
                dr["ACTSPRICE"] = adr["SPRICE"];
                dr["ACTEXPDATE"] = adr["EXPDATE"];
                dsInventory1.ADJDETAIL.Rows.Add(dr);
            }
            else
            {
                var i = 0;
                foreach (DataRow d in dsInventory1.ADJDETAIL.Rows)
                {
                    if (d.RowState != DataRowState.Deleted)
                        if (d["ITEMNO"].ToString() == adr["itemno"].ToString())
                        {
                            dsInventory1.ADJDETAIL.Rows.RemoveAt(i);
                            break;
                        }
                    i++;
                }
            }
            if (dsInventory1.ADJDETAIL.Rows.Count > 0)
                Lookupwarehouse.Enabled = false;
            else
            {
                Lookupwarehouse.Enabled = true;
            }
        }
        private void CostandQtyAdj_KeyDown(object sender, KeyEventArgs e)
        {
            if (_disableshortcut) return;
            
            if (e.KeyCode == Keys.F10)
            {  this.InvokeEx(x => AddItems(string.Empty)); }
            if (e.KeyCode == Keys.F4)
            { DoDelete(); }
        }
        void SetNavigation()
        {
            Bsnav.DataSource = BLInventoryAdj.GetInventoryList();
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
        void AddItems(string itemno)
        {
            if (Lookupwarehouse.EditValue == null)
            {
                XtraMessageBox.Show("Please select the warehouse", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //var frm = new FrmItemLookUp(dsPurchase1.PURINVDETAIL, itemno);
            //frm.EventSelectedItem += AdditemsToList;
            var fcd = advBandedGridView1.FocusedRowHandle;
            //frm.ShowDialog();
           var frm = new StockList(dsInventory1.ADJDETAIL, itemno, Lookupwarehouse.EditValue.ToString(), false,true);
           frm.EventSelectedItem += AdditemsToList;
           frm.ShowDialog();
            if (ActiveControl.Name != "gridControl1")
                gridControl1.Focus();
            if (advBandedGridView1.FocusedRowHandle >= 0)
            {
                advBandedGridView1.FocusedRowHandle = fcd;
            }
            else
            {
                advBandedGridView1.FocusedRowHandle = 0;
            }
        }
        void DoDelete()
        {
            if (advBandedGridView1.FocusedRowHandle < 0) return;
            string itname = "[ " + advBandedGridView1.FocusedRowHandle + 1 + " ] - " + advBandedGridView1.GetDisplayTextByColumnValue(colITEMNO, advBandedGridView1.GetFocusedRowCellValue("ITEMNO"));
            if (XtraMessageBox.Show("Do you want to delete the selected  row..?", itname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                advBandedGridView1.DeleteRow(advBandedGridView1.FocusedRowHandle);
            }
        }
        bool DoSave()
        {
            if(DoValidation())
                return false;
            var bl = new BLInventoryAdj();
            advBandedGridView1.UpdateCurrentRow();
            var dr = (DsInventory.ADJMASTRow)dsInventory1.ADJMAST.NewRow();
            dr.ADJID = _Adjid;
            dr.TRANDATE = invdate.DateTime;
            dr.STORECODE = Lookupwarehouse.EditValue.ToString();
            dr.REASON = reason.SelectedIndex;
            bl.AdjmastRow = dr;
            //bl.AdjdetailDataTable = dsInventory1.ADJDETAIL;
            var changes = (DsInventory.ADJDETAILDataTable)dsInventory1.ADJDETAIL.GetChanges(DataRowState.Modified | DataRowState.Added);
            bl.AdjdetailDataTable = changes;
            try
            {
                var saveStatus = bl.DoSave();
                if (saveStatus == "1")
                {
                    _Adjid = bl.Adjid;
                    textBox1.Text = _Adjid;
                    _disableshortcut = true;
                    XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataRow d in dsInventory1.ADJDETAIL.Rows)
                    {
                        if (d.RowState != DataRowState.Deleted)
                        {
                            d["ADJID"] = bl.Adjid;
                        }
                    }
                    var addedRows = from row in dsInventory1.ADJDETAIL
                                    where row.RowState == DataRowState.Added
                                    select row;
                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    if (changes != null) dsInventory1.Merge(changes);
                    dsInventory1.AcceptChanges();
                }
                else
                {
                    XtraMessageBox.Show(saveStatus, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           return true;
        }
        bool DoValidation()
       {
           bool retval = false;
          if(aDJDETAILBindingSource.Count==0)
          {
              XtraMessageBox.Show("No data to save "," POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
              retval = true;
          }
          if(reason.EditValue==null)
          {
              XtraMessageBox.Show("Please select the change reason", "POS", MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
              retval = true;
          }
           if(invdate.EditValue==null)
           {
               XtraMessageBox.Show("Please enter document date", "POS", MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
               retval = true;
           }
           foreach (DsInventory.ADJDETAILRow d in dsInventory1.ADJDETAIL.Rows)
           {
               if(!d.IsADJSPRICENull())
                   d.SetColumnError("ADJSPRICE", d.ADJSPRICE == 0 ? "Please check the sales price." : null);
               if (!d.IsADJCPRICENull())
                   d.SetColumnError("ADJCPRICE", d.ADJCPRICE == 0 ? "Please check the cost price." : null);
               if(!d.IsADJEXPDATENull())
                   d.SetColumnError("ADJEXPDATE", !Functions.CheckDate(d.ADJEXPDATE) ? "Please check expiry date" : null);
           }
           retval = dsInventory1.ADJDETAIL.HasErrors;
           return retval;
       }
        void DoSaveClose()
       {
         if(DoSave())
             Dispose();
       }
        void DoNew()
       {
           invdate.DateTime =  DateTime.Now;
           Lookupwarehouse.EditValue = null;
           reason.SelectedIndex = -1;
           dsInventory1.ADJDETAIL.Clear();
           gridControl1.ResetBindings();
           textBox1.Text = string.Empty;
           _Adjid = string.Empty;
           RibbonSaveEnable = true;
           Lookupwarehouse.Enabled = true;
            _disableshortcut = false;
       }
        void DoSaveNew()
        {
            if (DoSave())
                DoNew();
        }
        void DoClear()
            {}
        void DoPrint()
        {
            var gridprn = new GridPrintingClass();
            gridprn.Heading1 = "Inventory Adjustment Report";
            gridprn.Heading2 = "Location : " + Lookupwarehouse.Text + "            " + " Doc # :" + textBox1.Text;
            gridprn.DoPrint(gridControl1);
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
           _Adjid = current["ADJID"].ToString();
            DoView();
            RibbonSaveEnable = false;
        }
        void DoView()
        {
            if (!string.IsNullOrEmpty(_Adjid))
            {
                var bl = new BLInventoryAdj { Adjid = _Adjid };
                bl.GetInventoryByTranid();
                textBox1.Text =_Adjid;
                invdate.EditValue = bl.AdjmastRow.TRANDATE;
                Lookupwarehouse.EditValue = bl.AdjmastRow.STORECODE;
                reason.SelectedIndex = bl.AdjmastRow.REASON;
                if (dsInventory1.ADJDETAIL.Rows.Count > 0)
                {
                    dsInventory1.ADJDETAIL.Clear();
                    dsInventory1.Merge(bl.AdjdetailDataTable);
                }
                else
                {
                    dsInventory1.Merge(bl.AdjdetailDataTable);
                }
            }
            RibbonSaveEnable = false;
            _disableshortcut = true;
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
            _Adjid = current["ADJID"].ToString();
            RibbonSaveEnable = false;
            DoView();
            HoldButtonVisibility = BarItemVisibility.Never;
        }
        private void DeleteLine_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoDelete();
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
        private void advBandedGridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            var dr = advBandedGridView1.GetDataRow(advBandedGridView1.FocusedRowHandle);
            if (e.Column.FieldName == "ADJEXPDATE")
            {
                if (Functions.CheckDate(dr["ADJEXPDATE"].ToString()))
                {
                    var split = dr["EXPDATE1"].ToString().Split('-');
                    var dtn = Functions.CreateFirstDayOfMonth(int.Parse(split[1]), int.Parse(split[0]));
                    advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "ADJEXPDATE1", dtn);
                }
            }
        }
    }
}
