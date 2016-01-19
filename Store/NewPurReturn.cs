using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class NewPurReturn : BasePurInvoice
    {
     // public int Whid;
        public NewPurReturn()
        {
            InitializeComponent();
            //SupplierValueChanged += NewPurInvSupplierValueChanged;
            BarKeyDown += NewPurInvBarKeyDown;
            ItemClick += RibbonButtonsClick;
            BarItemClick += NewBarItemClick;
            SetGridColumns(true);
            dsInventory1.STOCKMASTER.Merge(ClsGetData.GetStockMaster());
            Ribbonname = "Purchase Return";

        }
        private void NewPurInvBarKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Return && e.KeyCode != Keys.Tab) return;
            if (e.KeyCode == Keys.Tab)
            {
                gridControl1.Focus();
                return;
            }
            if (Lookupwarehouse.EditValue == null)
            {
                XtraMessageBox.Show("Please select the warehouse", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }

            barManager1.ActiveEditItemLink.PostEditor();
            if (barEditItem2.EditValue == null) return;
            var sitemno = barEditItem2.EditValue.ToString().ToUpper(CultureInfo.InvariantCulture);
         // Select Item From Inventory --- User has to select the store-----
            IEnumerable<DataRow> query;
            IEnumerable<DataRow> query1 = null;
            query = from p in dsInventory1.ITEMMAST1 where p.BARCODE == sitemno || p.ITEMNAME.ToUpper() == sitemno select p;
            if (query.Count() > 0)
            {
                sitemno = Functions.GetBarCodeFromQuery(query);
              //query1 = from p in dsInventory1.STOCKMASTER where p.BARCODE == sitemno && p.QTY > 0 && p.COMPANY = COMMON.Utils.Company select p;
                var qry = "BARCODE = '" + sitemno + "' AND QTY > 0 AND WHID = " + int.Parse(Lookupwarehouse.EditValue.ToString()) + " AND COMPANY = '" + Utils.Company + "'";
                query1 = dsInventory1.STOCKMASTER.Select(qry);
                if (query1.Count() > 0)
                {
                    var tb = query1.CopyToDataTable();
                    if (rETURNDETAILBindingSource.Find("STOCKID", tb.Rows[0]["STOCKID"].ToString()) >= 0)
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
                case "BHOLDLIST":
                    GetHoldList();
                    break;
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
            }
        }
        private void NewBarItemClick(object sender, ItemClickEventArgs e)
        {
            // throw new NotImplementedException();
            if (e.Item.Name == "FindItem")
            {
                AddItems(string.Empty);
            }
        }
        private void NewPurReturnLoad(object sender, EventArgs e)
        {
            Text = "Purchase Return";
            gridControl1.DataSource = rETURNDETAILBindingSource;
            paneltotcost.Visible = false;
            SetNavigation();
            GetHoldList();
            bindingSource1.DataSource = typeof(PurRetinvError);
            try
            {
                invno.DataBindings.Add(new Binding("EditValue", bindingSource1, "Invoiceno", true));
                LookupSupplier.DataBindings.Add(new Binding("EditValue", bindingSource1, "Supplier", true));
                invdate.DataBindings.Add(new Binding("EditValue", bindingSource1, "Invoicedate", true));
                Lookupwarehouse.DataBindings.Add(new Binding("EditValue", bindingSource1, "ToStore", true));
                dxErrorProvider1.DataSource = bindingSource1;
                dxErrorProvider1.ContainerControl = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
       }
        protected override void AddItems(string itemno)
        {
            if (Lookupwarehouse.EditValue==null)
            {
                XtraMessageBox.Show("Please select the warehouse","POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            var frm = new StockList(dsPurchase1.RETURNDETAIL, itemno,Lookupwarehouse.EditValue.ToString(),false);
            frm.EventSelectedItem += AdditemsToList;
            frm.ShowDialog();
            if (ActiveControl.Name != "gridControl1")
                gridControl1.Focus();
        }
        #region BLL
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            DataRow d = e.SelectedRow;
            AddItemsToList(d["sel"].ToString(), d);
        }
        private void AddItemsToList(string selected, DataRow adr)
        {
            if (selected == bool.TrueString)
            {
                var dr = dsPurchase1.RETURNDETAIL.NewRow();
                dr["RETURNID"] = 0;
               // dr["GROUPID"] = adr["GROUPID"];
                dr["ITEMNO"] = adr["itemno"];
                dr["BARCODE"] = adr["barcode"];
              //  dr["DISC"] = adr["DISC"];
                dr["STOCKID"] = adr["STOCKID"];
                dr["STOCK"] = adr["QTY"];
                dr["INVRATE"] = adr["CPRICE"];
                dr["CPRICE"] = adr["CPRICE"];
                dr["SPRICE"] = adr["SPRICE"];
             //   dr["BATCHNO"] = adr["BATCHNO"];
             //   dr["TOSTORE"] = int.Parse(Lookupwarehouse.EditValue.ToString());
                if (spdisc.EditValue != null)
                    dr["INVDISC"] = decimal.Parse(spdisc.EditValue.ToString());
                dr["EXPDATE"] = adr["EXPDATE"];
                dsPurchase1.RETURNDETAIL.Rows.Add(dr);
            }
            else
            {
                var i = 0;
                foreach (DataRow d in dsPurchase1.RETURNDETAIL.Rows)
                {
                    if (d.RowState != DataRowState.Deleted)
                        if (d["ITEMNO"].ToString() == adr["itemno"].ToString())
                        {
                            dsPurchase1.RETURNDETAIL.Rows.RemoveAt(i);
                            break;
                        }
                    i++;
                }
            }
            //IsHold = true;
            //DoSave();
            //ShorcutKeysDisbale = false;
            if (!IsBackUp)
                Functions.CreateBackUp(dsPurchase1.RETURNDETAIL);
        }
        //string GetBarCodeFromQuery(IEnumerable<DataRow> qry)
        //{
        //    DataTable tb = qry.CopyToDataTable<DataRow>();
        //    return tb.Rows[0]["BARCODE"].ToString();
        //}
        bool DoSave()
        {
            bool retval = false;
            if (!IsHold)
            {
                PurchaseInvoceHasErrors();
                ValidateStock();
                if(dsPurchase1.PURINVDETAIL.HasErrors)
                {
                    XtraMessageBox.Show("Invoice not saved due to error, please check the errors", "POS",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            UpdateTotals();
            var dr = (DsPurchase.RETURNMASTRow)dsPurchase1.RETURNMAST.NewRow();
            if (!string.IsNullOrEmpty(Purid))
                dr.RETURNID = Purid;
            dr.COMPANY = Utils.Company;
            dr.SUPID = LookupSupplier.EditValue == null ? null : LookupSupplier.EditValue.ToString();
            dr.SUPNAME = string.IsNullOrWhiteSpace(LookupSupplier.Text) ? null : LookupSupplier.Text;
            dr.INVNO = invno.EditValue == null ? null : invno.EditValue.ToString();
            dr.INVDATE = invdate.DateTime;
            dr.SPDISCOUNT = spdisc.EditValue == null ? 0 : decimal.Parse(spdisc.EditValue.ToString());
            dr.ADJVALUE = adjustval.EditValue == null ? 0 : decimal.Parse(adjustval.EditValue.ToString());
            dr.NETVALUE = totnetamt.EditValue == null ? 0 : decimal.Parse(totnetamt.EditValue.ToString());
            dr.WHID = Lookupwarehouse.EditValue == null ? string.Empty : Lookupwarehouse.EditValue.ToString();
            dr.HOLD = IsHold;
            dr.USERID = Utils.Userid;
            var bhl = new Blpurretinv(dr);
            advBandedGridView1.PostEditor();
            advBandedGridView1.UpdateCurrentRow();
            rETURNDETAILBindingSource.EndEdit();
            var changes = (DsPurchase.RETURNDETAILDataTable)dsPurchase1.RETURNDETAIL.GetChanges(DataRowState.Modified | DataRowState.Added);
            bhl.Retinvdetail =  dsPurchase1.RETURNDETAIL; 
            try
            {
                var strstatus = bhl.DoSave();
                if (strstatus == "1")
                {
                    Purid = bhl.Retinvid;
                    txtpurno.Text = Purid;
                    RibbonSaveEnable = false;
                    HoldButtonVisibility = BarItemVisibility.Never;
                    XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    foreach (DataRow d in dsPurchase1.RETURNDETAIL.Rows)
                    {
                        if (d.RowState != DataRowState.Deleted)
                        {
                            d["RETURNID"] = bhl.Retinvid;
                        }
                    }
                    var addedRows = from row in dsPurchase1.RETURNDETAIL
                                    where row.RowState == DataRowState.Added
                                    select row;
                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    if (changes != null) dsPurchase1.Merge(changes);
                    dsInventory1.AcceptChanges();
                    Functions.DeleteBackUp();
                    retval = true;
                }
                else
                {
                    XtraMessageBox.Show(strstatus);
                }
            }
            catch (Exception ex)
            {
                Functions.CreateBackUp(dsPurchase1.RETURNDETAIL);
                XtraMessageBox.Show(ex.ToString());
            }
            SaveRequired = !retval;
            return retval;
        }
        void DoSaveNew()
        {
            DoSave();
            DoNew();
        }
        void DoNew()
        {
            SaveRequired = false;
            IsBackUp = true;
            ShorcutKeysDisbale = false;
            Functions.DeleteBackUp();
            dsPurchase1.RETURNDETAIL.Clear();
            gridControl1.ResetBindings();
            
            Purid = string.Empty;
            IsHold = false;
            LookupSupplier.EditValue = null;
            Lookupwarehouse.EditValue = null;
         
            invdate.EditValue = DateTime.Now;
            invno.EditValue = string.Empty;
            duedays.EditValue = 0;
            spdisc.EditValue = 0;
            txtpurno.Text = Purid;
            UpdateTotals();
            RibbonSaveEnable = true;
            HoldButtonVisibility = BarItemVisibility.Always;
        }
        void DoSaveClose()
        {
            if(!DoSave())
            {
                Dispose();
            }
        }
        void DoClear() {}
        void DoDelete() {}
        void DoPrint()
        {
            Blpurretinv.DoPrint(Purid);
        }
        void DoHold()
        {
            IsHold = true;
            DoSave();
        }
        void DoMovePrev()
        {
            IsBackUp = true;
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
            Purid = current["RETURNID"].ToString();
            SaveRequired = false;
            DoView();
            RibbonSaveEnable = false;
            HoldButtonVisibility = BarItemVisibility.Never;
        }
        void DoMoveNext()
        {
            IsBackUp = true;
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
            Purid = current["RETURNID"].ToString();
            SaveRequired = false;
            DoView();
            RibbonSaveEnable = false;
            HoldButtonVisibility = BarItemVisibility.Never;

        }
        protected override void HoldView()
        {
            Purid = DocNo;
            SaveRequired = true;
            DoView();
        }
        public void DoView()
        {
            if (string.IsNullOrEmpty(Purid)) return;
            var bl = new Blpurretinv { Retinvid = Purid };
            bl.GetPurRetinv();
            txtpurno.Text = Purid;
            LookupSupplier.EditValue = bl.Supid == "0" ? null : bl.Supid;
            invno.EditValue = bl.Invno;
            invdate.EditValue = bl.Invdate;
            duedays.EditValue = bl.Duedays;
            spdisc.EditValue = bl.Spdiscount;
            adjustval.EditValue = bl.Adjvalue;
            ShorcutKeysDisbale = !bl.Hold;
            Lookupwarehouse.EditValue = null;
            Lookupwarehouse.EditValue = bl.Whid;
            if (dsPurchase1.RETURNDETAIL.Rows.Count > 0)
            {
                dsPurchase1.RETURNDETAIL.Clear();
                Functions.DeleteBackUp();
                dsPurchase1.Merge(bl.Retinvdetail);
            }
            else
            {
                dsPurchase1.Merge(bl.Retinvdetail);
            }
            UpdateTotals();
        }
        bool PurchaseInvoceHasErrors()
        {
            var retval = true;
            var errl = new PurRetinvError
            {
                Supplier = LookupSupplier.EditValue == null ? null : LookupSupplier.EditValue.ToString(),
                Invoiceno = invno.EditValue == null ? null : invno.EditValue.ToString(),
                Invoicedate = invdate.EditValue == null ? null : invdate.EditValue.ToString(),
                ToStore = Lookupwarehouse.EditValue == null ? null : Lookupwarehouse.EditValue.ToString(),
                Purid = Purid
            };
            bindingSource1.Add(errl);
            ValidateLineItems();
            if (dsPurchase1.RETURNDETAIL.HasErrors || dxErrorProvider1.HasErrors)
                retval = false;
            return retval;
        }
        void ValidateLineItems()
        {
            foreach (var d in dsPurchase1.RETURNDETAIL)
            {
                
                if (d.RowState != DataRowState.Deleted)
                {
                    if (string.IsNullOrEmpty(d["qty"].ToString()))
                    {
                        d.SetColumnError("QTY", "Quantity not found");
                    }
                    else if (!string.IsNullOrEmpty(d["qty"].ToString()) && int.Parse(d["qty"].ToString()) == 0)
                    {
                        d.SetColumnError("QTY", "Quantity not found");
                    }
                    else
                    {
                        d.SetColumnError("QTY", null);
                    }
                    if (string.IsNullOrEmpty(d["INVRATE"].ToString()))
                    {
                        d.SetColumnError("INVRATE", "Inv.Rate not found");
                    }
                    else if (!string.IsNullOrEmpty(d["INVRATE"].ToString()) && decimal.Parse(d["INVRATE"].ToString()) == 0)
                    {
                        d.SetColumnError("INVRATE", "Inv.Rate not found");
                    }
                    else
                    {
                        d.SetColumnError("INVRATE", null);
                    }
                }
            }
        }
        void ValidateStock()
        {
            foreach (DsPurchase.RETURNDETAILRow d in dsPurchase1.RETURNDETAIL)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    var stock = Functions.CheckStockAvailable(d.STOCKID);
                    var bonus = d.IsBONUSQTYNull() ? 0 : d.BONUSQTY;
                    d.SetColumnError("STOCK", (d.QTY + bonus) > stock ? "Qty. is more than the stock" : null);
                }
            }
        }
        void SetNavigation()
        {
            Bsnav.DataSource = Blpurretinv.GetPurRetruninvMast();
            Tnav.DataBindings.Add(new Binding("Text", Bsnav, "PURINVID", true));
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
#endregion    
        protected override void AdvBandedGridView1CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var dr = advBandedGridView1.GetDataRow(advBandedGridView1.FocusedRowHandle);
            if (dr == null) return;
            if (e.Column.FieldName == "QTY")
            {
                if (int.Parse(dr["QTY"].ToString()) > int.Parse(dr["STOCK"].ToString()))
                {
                    advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "QTY", int.Parse(dr["STOCK"].ToString()));
                }

                if (!string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                {
                    if (decimal.Parse(dr["INVRATE"].ToString()) > 0)
                    {
                        var ln = decimal.Parse(e.Value.ToString()) * decimal.Parse(dr["INVRATE"].ToString());
                        advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "LINETOTAL", Math.Round(ln, 2));
                    }
                }
            }
            if (e.Column.FieldName == "BONUSQTY")
            {
                if (int.Parse(dr["QTY"].ToString()) == int.Parse(dr["STOCK"].ToString()))
                {
                    advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "BONUSQTY", 0);
                }
                if (int.Parse(dr["QTY"].ToString()) + int.Parse(dr["BONUSQTY"].ToString()) > int.Parse(dr["STOCK"].ToString()))
                {
                    advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "BONUSQTY", 0);
                }
            }

            if (e.Column.FieldName == "INVRATE")
            {
                if (!string.IsNullOrEmpty(dr["QTY"].ToString()) && !string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                {
                    var ln = decimal.Parse(e.Value.ToString()) * decimal.Parse(dr["QTY"].ToString());
                    advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "LINETOTAL", Math.Round(ln, 2));
                }

            }
            //if (e.Column.FieldName == "QTY" || e.Column.FieldName == "INVRATE" || e.Column.FieldName == "BONUSQTY" || e.Column.FieldName == "INVRATE" ||
            //    e.Column.FieldName == "DISC" || e.Column.FieldName == "SPDISC" || e.Column.FieldName == "INVDISC")
            //{
            //    var costp = Blpurinv.GetCost((DsInventory.PURINVDETAILRow)dr);
            //    advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "CPRICE", costp);
            //    if (Autosaleperc != 0)
            //    {
            //        decimal asp = 0;
            //        if (Autosalecalon)
            //        {
            //            if (!string.IsNullOrEmpty(dr["INVRATE"].ToString()))
            //                asp = (decimal.Parse(dr["INVRATE"].ToString()) * Autosaleperc) / 100;      //invrate
            //        }
            //        else
            //        {
            //            asp = (costp * Autosaleperc) / 100;
            //        }
            //        advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "SPRICE", Math.Round((costp + asp), 2));
            //    }
            //}
            if (e.Column.FieldName == "EXPDATE1")
            {
                if (Functions.CheckDate(dr["EXPDATE1"].ToString()))
                {
                    var split = dr["EXPDATE1"].ToString().Split('-');
                    var dtn = Functions.CreateFirstDayOfMonth(int.Parse(split[1]), int.Parse(split[0]));
                    advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "EXPDATE", dtn);
                }
            }

            UpdateTotals();
        }
        private void NewPurReturnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SaveRequired) return;
            if (string.IsNullOrEmpty(Purid))
            {
                if (dsPurchase1.RETURNDETAIL.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show("You are going to exit this program data is not saved, want to hold ? ", "P.O.S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IsHold = true;
                       if(DoSave())
                            Dispose();
                    }
                    else
                    {
                        Functions.DeleteBackUp();
                    }
                }
            }
            if (!string.IsNullOrEmpty(Purid))
            {
                if (dsInventory1.HasChanges())
                {
                    if (XtraMessageBox.Show(" Do you want to save the changes ? ", "P.O.S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IsHold = false;
                        if (PurchaseInvoceHasErrors())
                           if(DoSave())
                             Dispose();
                    }
                }
                else
                {   Functions.DeleteBackUp(); }
            }
        }
    }
}
