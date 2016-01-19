 using System;
 using System.Collections.Generic;
 using System.ComponentModel;
 using System.Data;
 using System.Globalization;
 using System.Linq;
 using System.Windows.Forms;
 using DevExpress.XtraBars;
 using DevExpress.XtraEditors;
 using DevExpress.XtraGrid.Views.BandedGrid;
 using DevExpress.XtraGrid.Views.Base;
 using Store.BusinessLogic;
 using Store.COMMON;
 using VIRETAILENTITIES;
 using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
 {
     public partial class NewPurInv : BasePurInvoice
     {
        // public int Whid;
         public bool ShowHoldList = true;
         public NewPurInv()
         {
             InitializeComponent();
             // SupplierValueChanged += NewPurInvSupplierValueChanged;
             BarKeyDown += NewPurInvBarKeyDown;
             ItemClick += RibbonButtonsClick;
             BarItemClick += NewBarItemClick;
             SetGridColumns(false);
             Ribbonname = "Purchase Invoice";
         }
         private void NewPurInvBarKeyDown(object sender, KeyEventArgs e)
         {
             barManager1.ActiveEditItemLink.PostEditor();
             if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Return && e.KeyCode != Keys.Tab) return;
             if (e.KeyCode == Keys.Tab)
             {
                 gridControl1.Focus();
                 return;
             }
             if (barEditItem2.EditValue == null && advBandedGridView1.DataRowCount != 0 && e.KeyCode == Keys.Enter)
             {
                 gridControl1.Focus();
                 advBandedGridView1.FocusedColumn = colBATCHNO;
                 return;
             }
             if (barEditItem2.EditValue == null)
                 return;

             var sitemno = barEditItem2.EditValue.ToString().ToUpper(CultureInfo.InvariantCulture);
             IEnumerable<DataRow> query;
             query = from p in dsInventory1.ITEMMAST1
                     where p.BARCODE.ToUpper() == sitemno || p.ITEMNAME.ToUpper() == sitemno
                     select p;
             var count = query.Count();
             if (count > 0)
             {
                 var tb = query.CopyToDataTable();
                 var bs = (BindingSource) gridControl1.DataSource;
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
         private void RibbonButtonsClick(object sender, ItemClickEventArgs name)
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
             if (e.Item.Name == "FindItem")
             {
                 AddItems(string.Empty);
             }
         }
         #region BLLS
         private void AdditemsToList(object sender, GetDataRowEventArgs e)
         {
             DataRow d = e.SelectedRow;
             AddItemsToList(d["sel"].ToString(), d);
         }
         private void AddItemsToList(string selected, DataRow adr)
         {
             if (selected == bool.TrueString)
             {
                 var dr = dsPurchase1.PURINVDETAIL.NewRow();
                 dr["GROUPID"] = adr["GROUPID"];
                 if (int.Parse(adr["groupid"].ToString()) == 1)
                 {
                     dr["DISC"] = adr["discount"];
                 }if (!string.IsNullOrEmpty(Purid))
                     dr["PURINVID"] = Purid;
                 else
                     dr["PURINVID"] = 0;
                 if (spdisc.EditValue != null)
                     dr["INVDISC"] = decimal.Parse(spdisc.EditValue.ToString());
                 if (LookuptoStore.EditValue != null)
                 {
                     dr["TOSTORE"] = LookuptoStore.EditValue;
                 }
                 dr["STOCK"] = Blpurinv.GetLastReceived(adr["itemno"].ToString());
                 dr["EXPR"] = adr["EXPDATEREQ"];
                 dr["itemno"] = adr["itemno"];
                 dr["BARCODE"] = adr["barcode"];
                 if (int.Parse(adr["groupid"].ToString()) == 1)
                 {
                     if (adr["discount"] != null)
                     {
                         dr["SPRICE"] = adr["CPRICE"];
                     }
                 }
                 else
                 {
                     dr["SPRICE"] = adr["SPRICE"];
                 }
                 dr["INVRATE"] = adr["CPRICE"];
                 dr["ISGIFTITEM"] = IsGiftItem;

                 if (IsGiftItem)
                 {
                     dr["BONUSQTY"] = 1;
                     dr["CPRICE"] = 0;
                 }
                 dsPurchase1.PURINVDETAIL.Rows.Add(dr);
                // IsGiftItem = false;
             }
             else
             {
                 var i = 0;
                 foreach (DataRow d in dsPurchase1.PURINVDETAIL.Rows)
                 {
                     if (d.RowState != DataRowState.Deleted)
                         if (d["itemno"].ToString() == adr["itemno"].ToString())
                         {
                             dsPurchase1.PURINVDETAIL.Rows.RemoveAt(i);
                             break;
                         }
                     i++;
                 }
             }

             if (!IsBackUp)
                 Functions.CreateBackUp(dsPurchase1.PURINVDETAIL);
         }
         private bool DoSave()
         {
             if (!IsHold)
             {
                 if (
                     XtraMessageBox.Show("Do you want to save..? \r\n Please check the invoice details before save",
                                         "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                     return false;
                 if (!PurchaseInvoceHasErrors())
                 {
                     XtraMessageBox.Show("Invoice not saved due to errors \r\n please check the errors", "POS",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return false;
                 }
             }

             UpdateTotals();
             bool retval = false;
             var dr = (DsPurchase.PURINVMAINRow) dsPurchase1.PURINVMAIN.NewRow();
             if (!string.IsNullOrEmpty(Purid))
              
             dr.PURINVID = Purid;
             dr.COMPANY = Utils.Company;
             dr.SUPID = LookupSupplier.EditValue == null ? null : LookupSupplier.EditValue.ToString();
             dr.SUPNAME = string.IsNullOrWhiteSpace(LookupSupplier.Text) ? null : LookupSupplier.Text;
             dr.INVNO = invno.EditValue == null ? null : invno.EditValue.ToString();
             dr.INVDATE = invdate.DateTime;
             dr.DUEDAYS = duedays.EditValue == null ? 0 : int.Parse(duedays.EditValue.ToString());
             dr.SPDISCOUNT = spdisc.EditValue == null ? 0 : decimal.Parse(spdisc.EditValue.ToString());
             dr.ADJVALUE = adjustval.EditValue == null ? 0 : decimal.Parse(adjustval.EditValue.ToString());
             dr.NETVALUE = totnetamt.EditValue == null ? 0 : decimal.Parse(totnetamt.EditValue.ToString());
             if (string.IsNullOrEmpty(Lookupwarehouse.Text))
                 dr.WHID = null;
             else
                 dr.WHID = Lookupwarehouse.EditValue == null ? null : Lookupwarehouse.EditValue.ToString();
             dr.TRANSTYPE = LookuptoStore.EditValue == null ? null : LookuptoStore.EditValue.ToString();
             // dr.TRANDATE = DateTime.Now;
             dr.HOLD = IsHold;
             dr.USERID = Utils.Userid;
             var bhl = new Blpurinv(dr);
             if (!dr.IsWHIDNull())
             {
                 if (Lookupwarehouse.GetColumnValue("STORETYPE").ToString() == "PS")
                 {
                     bhl.isforsale = true;
                 }
             }
             //if (Lookupwarehouse.Text == "PS")
             //    bhl.isforsale = true;
             advBandedGridView1.PostEditor();
             advBandedGridView1.UpdateCurrentRow();
             //pURINVDETAILBindingSource.ResetBindings(true);
             pURINVDETAILBindingSource.EndEdit();
             var changes = (DsPurchase.PURINVDETAILDataTable) dsPurchase1.PURINVDETAIL.GetChanges();
             bhl.Purinvdetail = dsPurchase1.PURINVDETAIL;
             try
             {
                 var saveStatus = bhl.DoSave();
                 if (saveStatus == "1")
                 {
                     Purid = bhl.Purinvid;
                     txtpurno.Text = Purid;
                     RibbonSaveEnable = false;
                     HoldButtonVisibility = BarItemVisibility.Never;
                     XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                     foreach (DataRow d in dsPurchase1.PURINVDETAIL.Rows)
                     {
                         if (d.RowState != DataRowState.Deleted)
                         {
                             d["PURINVID"] = bhl.Purinvid;
                         }
                     }
                     var addedRows = from row in dsPurchase1.PURINVDETAIL
                                     where row.RowState == DataRowState.Added
                                     select row;
                     foreach (var row in addedRows.ToArray())
                     {
                         row.Delete();
                     }
                     if (changes != null) dsPurchase1.Merge(changes);
                     dsInventory1.AcceptChanges();
                     retval = true;
                     ShorcutKeysDisbale = true;
                     Functions.DeleteBackUp();
                 }
                 else
                 {
                     XtraMessageBox.Show(saveStatus, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             catch (Exception ex)
             {
                 Functions.CreateBackUp(dsPurchase1.PURINVDETAIL);
                 XtraMessageBox.Show(ex.ToString());
             }
             SaveRequired = !retval;
             return retval;
         }
         private void DoSaveNew()
         {
             if (DoSave())
                 DoNew();
         }
         private void DoNew()
         {
             SaveRequired = false;
             IsBackUp = true;
             ShorcutKeysDisbale = false;
             Functions.DeleteBackUp();
             dsPurchase1.PURINVDETAIL.Clear();
             gridControl1.ResetBindings();
       
             Purid = null;
             IsHold = false;
             LookupSupplier.EditValue = null;
             Lookupwarehouse.EditValue = null;
             LookuptoStore.EditValue = null;
             invdate.EditValue = DateTime.Now;
             invno.EditValue = string.Empty;
             duedays.EditValue = 0;
             spdisc.EditValue = 0;
             adjustval.EditValue = 0;
             txtpurno.Text = Purid;
             UpdateTotals();
             RibbonSaveEnable = true;
             HoldButtonVisibility = BarItemVisibility.Always;
         }
         private void DoSaveClose()
         {
             if (DoSave())
             {
                 Dispose();
             }
             // ShorcutKeysDisbale = false;
         }
         private void DoClear()
         {
         }
         private void DoDelete()
         {
         }
         private void DoPrint()
         {
             Blpurinv.DoPrint(Purid, decimal.Parse(totsalevalue.EditValue.ToString()),
                              decimal.Parse(totcostvalue.EditValue.ToString()),
                              decimal.Parse(totprofit.EditValue.ToString()));
         }
         private void DoHold()
         {
             IsHold = true;
             DoSave();
             ShorcutKeysDisbale = false;
         }
         private void DoMovePrev()
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
             var current = (DataRowView) Bsnav.Current;
             Purid = current["PURINVID"].ToString();
             SaveRequired = false;
             DoView();
             RibbonSaveEnable = false;
             HoldButtonVisibility = BarItemVisibility.Never;

         }
         private void DoMoveNext()
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
             var current = (DataRowView) Bsnav.Current;
             Purid = current["PURINVID"].ToString();
             SaveRequired = false;
             DoView();
             RibbonSaveEnable = false;
             HoldButtonVisibility = BarItemVisibility.Never;
         }
         public void  DoView()
         {
             if (!string.IsNullOrEmpty(Purid))
             {
                 var bl = new Blpurinv {Purinvid = Purid};
                 bl.GetPurinv();
                 //dsPurchase1.Merge(bl.Purinvdetail);
                 //pURINVDETAILBindingSource.DataSource = bl.Purinvdetail;
                 txtpurno.Text = Purid;
                 LookupSupplier.EditValue = bl.Supid == "0" ? null : bl.Supid;
                 invno.EditValue = bl.Invno;
                 invdate.EditValue = bl.Invdate;
                 duedays.EditValue = bl.Duedays;
                 spdisc.EditValue = bl.Spdiscount;
                 adjustval.EditValue = bl.Adjvalue;
                 ShorcutKeysDisbale = !bl.Hold;
                 // SaveButtonEnable = !bl.Hold;
                 RibbonSaveEnable = bl.Hold;
                 if (!bl.Hold)
                     HoldButtonVisibility = BarItemVisibility.Never;

                 Lookupwarehouse.EditValue = null;
                 Lookupwarehouse.EditValue = bl.Whid;
                 if (dsPurchase1.PURINVDETAIL.Rows.Count > 0)
                 {
                     dsPurchase1.PURINVDETAIL.Clear();
                     Functions.DeleteBackUp();
                     dsPurchase1.Merge(bl.Purinvdetail);
                     Functions.CreateBackUp(bl.Purinvdetail);
                 }
                 else
                 {
                     dsPurchase1.Merge(bl.Purinvdetail);
                 }
                 UpdateTotals();
                 totnetamt.Tag = bl.Netvalue;
                 totnetamt.EditValue = bl.Netvalue;
                 totspecdisc.EditValue = bl.Spdiscount;
                 foreach (DsPurchase.PURINVDETAILRow d in dsPurchase1.PURINVDETAIL.Rows)
                 {
                     try
                     {
                         if (!d.IsEXPDATENull())
                         {
                             var st = d.EXPDATE.ToString("MM-yy");
                             d.EXPDATE1 = st;
                         }
                     }
                     catch (Exception ex1)
                     {

                         XtraMessageBox.Show(ex1.ToString());
                     }

                 }
             }
         }
         private bool PurchaseInvoceHasErrors()
         {
             var retval = true;
             var errl = new PurinvError
                            {
                                Supplier = LookupSupplier.EditValue == null ? null : LookupSupplier.EditValue.ToString(),
                                Invoiceno = invno.EditValue == null ? null : invno.EditValue.ToString(),
                                Invoicedate = invdate.EditValue == null ? null : invdate.EditValue.ToString(),
                                ToStore =
                                    Lookupwarehouse.EditValue == null ? null : Lookupwarehouse.EditValue.ToString(),
                                Purid = Purid
                            };
             bindingSource1.Add(errl);
             pURINVDETAILBindingSource.EndEdit();
             ValidateLineItems();

             if (dsPurchase1.PURINVDETAIL.Count == 0)
                 retval = false;
             if (dsPurchase1.PURINVDETAIL.HasErrors || dxErrorProvider1.HasErrors)
             {
                 retval = false;
                 PrintRowErrs(dsPurchase1);
             }

             return retval;
         }
         private void PrintRowErrs(DsPurchase dataSet)
         {
             foreach (DataTable table in dataSet.Tables)
             {
                 foreach (DataRow row in table.Rows)
                 {
                     if (row.HasErrors)
                     {
                         Console.WriteLine(row.RowError);
                     }
                 }
             }
         }
         private void ValidateLineItems()
         {
             foreach (var d1 in dsPurchase1.PURINVDETAIL)
             {
                 d1.ClearErrors();
             }
             foreach (var d in dsPurchase1.PURINVDETAIL)
             {
                 var errmsg = "";
                 //  var rowerror = "";
                 if (d.RowState != DataRowState.Deleted)
                 {
                     if (!d.ISGIFTITEM)
                     {
                         if (string.IsNullOrEmpty(d.QTY.ToString()))
                         {
                             errmsg = "Quantity not found"; //rowerror += errmsg;
                             d.SetColumnError("QTY", errmsg);
                         }
                         else if (!string.IsNullOrEmpty(d.QTY.ToString()) && d.QTY == 0)
                         {
                             errmsg = "Quantity not found"; // rowerror += errmsg;
                             d.SetColumnError("QTY", errmsg);
                         }
                         else
                         {
                             d.SetColumnError("QTY", null);
                         }
                     }
                     else
                     {
                         if (!string.IsNullOrEmpty(d.QTY.ToString()) && d.QTY > 0)
                         {
                             d.BONUSQTY = d.QTY;
                         }
                         if (string.IsNullOrEmpty(d.BONUSQTY.ToString()))
                         {
                             errmsg = "Bonus Quantity not found";
                             //rowerror += errmsg;
                             d.SetColumnError("BONUSQTY", errmsg);
                         }
                         else if (!string.IsNullOrEmpty(d.BONUSQTY.ToString()) && d.BONUSQTY == 0)
                         {
                             errmsg = "Bonus Quantity not found";
                             // rowerror += errmsg;
                             d.SetColumnError("BONUSQTY", errmsg);
                         }
                         else
                         {
                             d.SetColumnError("BONUSQTY", null);
                         }
                     }
                     if (string.IsNullOrEmpty(d.INVRATE.ToString()))
                         {
                             //if (errmsg.Length > 0)
                             //    rowerror += "<br>Inv.Rate not found for item<br>";
                             //else
                             errmsg = "Rate not found";
                             d.SetColumnError("INVRATE", errmsg);
                         }
                         else if (!string.IsNullOrEmpty(d.INVRATE.ToString()) && d.INVRATE == 0)
                         {
                             //if (errmsg.Length > 0)
                             //    rowerror += "<br>Inv.Rate not found for item<br>";
                             //else
                             errmsg = "Rate not found";
                             d.SetColumnError("INVRATE", errmsg);
                         }
                         else
                         {
                             d.SetColumnError("INVRATE", null);
                         }
                         //if (!string.IsNullOrEmpty(d.QTY.ToString()) && d.QTY != 0)
                         //{
                             if (!string.IsNullOrEmpty(d.CPRICE.ToString()) && d.CPRICE == 0)
                             {
                                 errmsg = "Cost price not found";
                                 d.SetColumnError("CPRICE", errmsg);
                             }
                             else
                             {
                                 d.SetColumnError("CPRICE", null);
                             }
                        // }
                         if (string.IsNullOrEmpty(d.SPRICE.ToString()))
                         {
                             errmsg = "Sales price not found";
                             d.SetColumnError("SPRICE", errmsg);
                         }
                         else if (!string.IsNullOrEmpty(d.SPRICE.ToString()) && d.SPRICE == 0)
                         {
                             errmsg = "Sales price not found";
                             d.SetColumnError("SPRICE", errmsg);
                         }
                         else if (!string.IsNullOrEmpty(d.SPRICE.ToString()))
                         {
                             if(d.SPRICE < d.CPRICE)
                             {
                                 errmsg = "Sales price less than cost price";
                                 d.SetColumnError("SPRICE", errmsg);
                             }
                         }
                         else
                         {
                             d.SetColumnError("SPRICE", null);
                         }
                         if (d.EXPR && string.IsNullOrEmpty(d.EXPDATE1))
                         {
                             //if (errmsg.Length > 0)
                             //    rowerror += "<br>Expiry date not found for item<br>";
                             //else
                             errmsg = "Expiry date not found for item";
                             d.SetColumnError("EXPDATE1", errmsg);
                             // d.RowError = errmsg;
                         }
                         else
                         {
                             d.SetColumnError("EXPDATE1", null);
                         }

                         if (d.EXPR && !string.IsNullOrEmpty(d.EXPDATE1))
                         {
                             if (!Functions.CheckDate(d["EXPDATE1"].ToString()))
                             {
                                 //if (errmsg.Length > 0)
                                 //    rowerror += "<br>Please check expiry date<br>";
                                 //else
                                 errmsg = "Please check expiry date";
                                 d.SetColumnError("EXPDATE1", errmsg);
                             }
                             else
                             {
                                 d.SetColumnError("EXPDATE1", null);
                             }
                         }
                     }
                     //else
                     //{
                     //    if (!string.IsNullOrEmpty(d.QTY.ToString()) && d.QTY > 0)
                     //    {
                     //        d.BONUSQTY = d.QTY;
                     //    }
                     //    if (string.IsNullOrEmpty(d.BONUSQTY.ToString()))
                     //    {
                     //        errmsg = "Bonus Quantity not found";
                     //        //rowerror += errmsg;
                     //        d.SetColumnError("BONUSQTY", errmsg);
                     //    }
                     //    else if (!string.IsNullOrEmpty(d.BONUSQTY.ToString()) && d.BONUSQTY == 0)
                     //    {
                     //        errmsg = "Bonus Quantity not found";
                     //        // rowerror += errmsg;
                     //        d.SetColumnError("BONUSQTY", errmsg);
                     //    }
                     //    else
                     //    {
                     //        d.SetColumnError("BONUSQTY", null);
                     //    }
                     //    if (d.EXPR && string.IsNullOrEmpty(d.EXPDATE1))
                     //    {
                     //        //if (errmsg.Length > 0)
                     //        //    rowerror += "<br>Expiry date not found for item<br>";
                     //        //else
                     //        errmsg = "Expiry date not found for item";
                     //        d.SetColumnError("EXPDATE1", errmsg);
                     //        // d.RowError = errmsg;
                     //    }
                     //    else
                     //    {
                     //        d.SetColumnError("EXPDATE1", null);
                     //    }
                     //    if (d.EXPR && !string.IsNullOrEmpty(d.EXPDATE1))
                     //    {
                     //        if (!Functions.CheckDate(d["EXPDATE1"].ToString()))
                     //        {
                     //            errmsg = "Please check expiry date";
                     //            d.SetColumnError("EXPDATE1", errmsg);
                     //        }
                     //        else
                     //        {
                     //            d.SetColumnError("EXPDATE1", null);
                     //        }
                     //    }
                     // }
                // }
             }
             //duplicates = dsPurchase1.PURINVDETAIL.AsEnumerable().GroupBy(r => r[2]).Where(gr => gr.Count() > 1).ToList();
             //if (duplicates.Any())
             //{
             //    XtraMessageBox.Show("Duplicate found for : {0}", String.Join(", ", duplicates.Select(dupl => dupl.Key)));
             //    dsPurchase1.PURINVDETAIL.Rows[0].HasErrors = true;
             //}


         }
         private void SetNavigation()
         {
             Bsnav.DataSource = Blpurinv.GetPurinvMast();
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
         private void NewPurInvLoad(object sender, EventArgs e)
         {
             if (ShowHoldList) GetHoldList();
             gridControl1.DataSource = pURINVDETAILBindingSource;
             SetNavigation();
             bindingSource1.DataSource = typeof (PurinvError);
             var ds = ClsGetData.PosNotRecieved();
             lookuppo.Properties.DataSource = ds;
             lookuppo.Properties.PopulateColumns();

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
         protected override void HoldView()
         {
             Purid = DocNo;
             SaveRequired = true;
             DoView();
         }
         protected override void AdvBandedGridView1CellValueChanged(object sender,CellValueChangedEventArgs e)
         {
             var dr = advBandedGridView1.GetDataRow(advBandedGridView1.FocusedRowHandle);
             if (dr == null) return;
             if (e.Column.FieldName == "QTY")
             {
                 if (!string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                 {
                     if (decimal.Parse(dr["INVRATE"].ToString()) > 0)
                     {
                         var ln = decimal.Parse(e.Value.ToString())*decimal.Parse(dr["INVRATE"].ToString());
                         advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "LINETOTAL",
                                                            Math.Round(ln, 2));
                     }
                 }
             }
             if (e.Column.FieldName == "INVRATE")
             {
                 if (!string.IsNullOrEmpty(dr["QTY"].ToString()) && !string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                 {
                     var ln = decimal.Parse(e.Value.ToString())*decimal.Parse(dr["QTY"].ToString());
                     advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "LINETOTAL",
                                                        Math.Round(ln, 2));

                 }
                 if (int.Parse(dr["GROUPID"].ToString()) == 1)
                 {
                     if (!string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                         if (!string.IsNullOrEmpty(dr["SPRICE"].ToString()))
                         {
                             advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "SPRICE",
                                                                decimal.Parse(dr["INVRATE"].ToString()));
                         }
                 }
             }
             if (e.Column.FieldName == "QTY" || e.Column.FieldName == "INVRATE" || e.Column.FieldName == "BONUSQTY" ||
                 e.Column.FieldName == "DISC" || e.Column.FieldName == "SPDISC" || e.Column.FieldName == "INVDISC")
             {
                 var costp = Blpurinv.GetCost((DsPurchase.PURINVDETAILRow) dr);
                 if (costp == 0)
                 {
                     decimal invr = 0;
                     if (!string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                         invr = (decimal.Parse(dr["INVRATE"].ToString()));
                     costp = FindTheCostPrice(dr["ITEMNO"].ToString(), invr);
                 }
           
                 advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "CPRICE", costp);
                 int qty = 0;
                 int bqty = 0;
                 if (!string.IsNullOrWhiteSpace(dr["QTY"].ToString()))
                     qty = int.Parse(dr["QTY"].ToString());
                 if (!string.IsNullOrWhiteSpace(dr["BONUSQTY"].ToString()))
                     bqty = int.Parse(dr["BONUSQTY"].ToString());
                 advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "GROSSVALUE",
                                                    costp*(qty + bqty));
                 if (Autosaleperc != 0)
                 {
                     decimal asp = 0;
                     if (Autosalecalon)
                     {
                         if (!string.IsNullOrEmpty(dr["INVRATE"].ToString()))
                             asp = (decimal.Parse(dr["INVRATE"].ToString())*Autosaleperc)/100; //invrate
                     }
                     else
                     {
                         asp = (costp*Autosaleperc)/100;
                     }

                     advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "SPRICE",
                                                        Math.Round((costp + asp), 2));
                 }

                 advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "PROFIT",
                                                    Blpurinv.GetProfit((DsPurchase.PURINVDETAILRow) dr));
             }
             if (e.Column.FieldName == "SPRICE")
             {
                 advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "PROFIT",
                                                    Blpurinv.GetProfit((DsPurchase.PURINVDETAILRow) dr));
                 if (FindSalesPrice(dr["ITEMNO"].ToString(), decimal.Parse(e.Value.ToString())))
                     XtraMessageBox.Show("Sales price changed", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             UpdateTotals();
             if (e.Column.FieldName != "EXPDATE1") return;
             if (!Functions.CheckDate(dr["EXPDATE1"].ToString())) return;
             int first = dr["EXPDATE1"].ToString().IndexOf("-", StringComparison.Ordinal);
             DateTime dtn = DateTime.Now;
             if (first == 0)
             {
                 var d1 = Functions.ToDateTime(int.Parse(dr["EXPDATE1"].ToString()));
                 if (d1 != null)
                 {
                     var st = d1.ToString();
                     DateTime dd = Convert.ToDateTime(st);
                     dtn = Functions.CreateFirstDayOfMonth(dd.Month, dd.Year);
                 }
             }
             else
             {
                 var split = dr["EXPDATE1"].ToString().Split('-');
                 dtn = Functions.CreateFirstDayOfMonth(int.Parse(split[1]), int.Parse(split[0]));
             }
             advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "EXPDATE", dtn);
         }
         protected override void GridControl1EditorKeyDown(object sender, KeyEventArgs e)
         {
             if (advBandedGridView1.FocusedColumn == null)
                 return;
             if (advBandedGridView1.FocusedColumn.FieldName == "QTY" && Unitconversionbutton.Checked)
             {
                 panelunit.Left = (Width - panelunit.Width)/2;
                 panelunit.Top = (panelunit.Height + Height)/2;
                 panelunit.Visible = true;
                 lookupunits.Focus();
             }
             if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
             {
                 if (advBandedGridView1.FocusedColumn.VisibleIndex == 8)
                 {
                     var dr = advBandedGridView1.GetDataRow(advBandedGridView1.FocusedRowHandle);
                     if (dr["EXPR"].ToString() == bool.FalseString)
                     {
                         if (IsLastVisibleRow(advBandedGridView1, advBandedGridView1.FocusedRowHandle))
                         {
                             advBandedGridView1.FocusedColumn = colBATCHNO;
                             advBandedGridView1.UpdateCurrentRow();
                             e.Handled = true;
                         }
                         else
                         {
                             advBandedGridView1.MoveNext();
                             advBandedGridView1.FocusedColumn = colBATCHNO;
                             e.Handled = true;
                         }
                     }
                 }
                 if (advBandedGridView1.FocusedColumn.VisibleIndex == 9)
                 {
                     if (IsLastVisibleRow(advBandedGridView1, advBandedGridView1.FocusedRowHandle))
                     {
                         advBandedGridView1.FocusedColumn = colBATCHNO;
                         e.Handled = true;
                     }
                     else
                     {
                         advBandedGridView1.MoveNext();
                         advBandedGridView1.FocusedColumn = colBATCHNO;
                         e.Handled = true;
                     }
                 }
             }
         }
         protected override void advBandedGridView1_ShowingEditor(object sender, CancelEventArgs e)
         {
             var aview = sender as AdvBandedGridView;
             var dr = advBandedGridView1.GetDataRow(advBandedGridView1.FocusedRowHandle);
             if (dr == null) return;
             //var flg = bool.Parse(dr["ISGIFTITEM"].ToString());
             //if (!flg) return;
             //if (aview.FocusedColumn.FieldName == "CPRICE" || aview.FocusedColumn.FieldName == "SPRICE")
             //{
             //    e.Cancel = true;
             //}
         }
         protected override void AddItems(string itemno)
         {
             var frm = new FrmItemLookUp(dsPurchase1.PURINVDETAIL, itemno);
             frm.EventSelectedItem += AdditemsToList;
             var fcd = advBandedGridView1.FocusedRowHandle;
             frm.ShowDialog();
             //IsHold = true;
             //DoSave();
             //ShorcutKeysDisbale = false;
             if (ActiveControl.Name != "gridControl1")
             {
                 gridControl1.Focus();
                 barEditItem2.EditValue = null;
                 if (advBandedGridView1.FocusedRowHandle >= 0)
                 {
                     advBandedGridView1.FocusedRowHandle = fcd;
                 }
                 else
                 {
                     advBandedGridView1.FocusedRowHandle = 0;
                 }
             }
         }
         private void SpdiscValidated(object sender, EventArgs e)
         {
             for (int i = 0; i < advBandedGridView1.DataRowCount; i++)
             {
                 advBandedGridView1.SetRowCellValue(i, "INVDISC", spdisc.EditValue);
             }
         }
         private void NewPurInvFormClosing(object sender, FormClosingEventArgs e)
         {
             if (!SaveRequired) return;
             if (string.IsNullOrEmpty(Purid))
             {
                 if (dsPurchase1.PURINVDETAIL.Rows.Count > 0)
                 {
                     if (
                         XtraMessageBox.Show("You are going to exit this program data is not saved, want to hold ? ",
                                             "P.O.S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                         DialogResult.Yes)
                     {
                         IsHold = true;
                         DoSave();
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
                     if (
                         XtraMessageBox.Show(" Do you want to save the changes ? ", "P.O.S", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question) == DialogResult.Yes)
                     {
                         IsHold = false;
                         if (PurchaseInvoceHasErrors())
                             if (DoSave())
                                 Dispose();
                     }
                 }
                 else
                 {
                     Functions.DeleteBackUp();
                 }
             }
         }
         private void LookuptoStore_EditValueChanged(object sender, EventArgs e)
         {
             foreach (DataRow d in dsPurchase1.PURINVDETAIL.Rows)
             {
                 if (LookuptoStore.EditValue != null)
                     d["TOSTORE"] = LookuptoStore.EditValue.ToString();
                 else
                 {
                     d["TOSTORE"] = null;
                 }

             }
         }
         private decimal FindTheCostPrice(string itemno, decimal invrate)
         {
             var dr = dsInventory1.ITEMMAST1.FindByITEMNO(itemno);
             decimal retval = 0;
             if (!dr.IsCPRICENull())
             {
                 retval = dr.CPRICE;
             }
             if(retval==0)
             {
                 retval = invrate - (invrate*dr.DISCOUNT)/100;
             }
                 
             return retval;
         }
         private bool FindSalesPrice(string itemno, decimal sprice)
         {
             var dr = dsInventory1.ITEMMAST1.FindByITEMNO(itemno);
             if (dr.IsSPRICENull())
                 return false;
             return dr.SPRICE != sprice;
         }
         protected override void adjustval_EditValueChanged(object sender, EventArgs e)
         {

             if (totnetamt.EditValue != null)
             {
                 if (decimal.Parse(adjustval.EditValue.ToString()) > 1)
                 {
                     adjustval.EditValue = 0;
                 }
                 else
                 {
                     var tt = decimal.Parse(totvalue.EditValue.ToString()) - decimal.Parse(totdisc.EditValue.ToString()) -
                              decimal.Parse(totspecdisc.EditValue.ToString());
                     totnetamt.EditValue = tt + decimal.Parse(adjustval.EditValue.ToString());
                     //totnetamt.EditValue = decimal.Parse(totnetamt.Tag.ToString()) + decimal.Parse(adjustval.EditValue.ToString());
                 }
                 //else
                 //{
                 //    totnetamt.EditValue = decimal.Parse(totnetamt.EditValue.ToString()) -
                 //                          decimal.Parse(adjustval.EditValue.ToString());
                 //}
             }
         }
     }
 }
  