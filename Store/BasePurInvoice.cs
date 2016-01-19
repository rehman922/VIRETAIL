using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Store.COMMON;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public delegate void LoadForm(int option, string frmid,bool usecon,string newcon);

    public partial class BasePurInvoice :BaseRibbonForm
    {
       // public event EventHandler SupplierValueChanged;
        public event KeyEventHandler BarKeyDown;
        public event ItemClickEventHandler BarItemClick;
        protected bool IsGiftItem;
        protected decimal Autosaleperc;
        protected bool Autosalecalon;
        public string Purid;
        protected bool IsBackUp;
        private bool _doctype;
        protected bool IsHold;
        protected string DocNo;
        protected bool SaveRequired = true;
        protected bool ShorcutKeysDisbale = false;
        protected BindingSource Bsnav = new BindingSource();
        protected readonly TextBox Tnav = new TextBox();
        public BasePurInvoice()
        {
            InitializeComponent();
            this.InvokeEx(lv => LoadDataSets());
            DeleteButtonVisibility = BarItemVisibility.Never;
            ClearButtonVisibility = BarItemVisibility.Never;
           
        }
        void LoadDataSets()
        {
            var dsitemgroup = ClsGetData.GetItemGroup();
            dsInventory1.ITEMMAST1.Merge(ClsGetData.GetItemMastList());

            Lookupwarehouse.Properties.DataSource = ClsGetData.GetMyWareHouses(); 

            LookuptoStore.Properties.DataSource = ClsGetData.GetAllSalesStore();
            

            dropitem.DataSource = dsInventory1.ITEMMAST1;
            dropitemgroup.DataSource = dsitemgroup;
            LookupSupplier.Properties.DataSource = ClsGetData.GetSupplier();
            lookupunits.Properties.DataSource = ClsGetData.GetUom();
        }
        private void BasePurInvoiceLoad(object sender, EventArgs e)
        {
            SetDataSource();
            RibbonPageEdit = false;
            invdate.DateTime = DateTime.Now;
            Loginname = Utils.Username;
        }
        protected void GetHoldList()
        {
            var cnt = !_doctype ? ClsGetData.GetPurchaseHoldCount() : ClsGetData.GetPurchaseReturnHoldCount();
            if (cnt > 0)
            {
                var f = new HoldPurchase(_doctype);
                f.ShowDialog();
                DocNo = f.Purid;
                HoldView();
            }
        }
        void SetDataSource()
        {
            if (!File.Exists(Functions.BackUpFileName)) return;
            IsBackUp = true;
            if (!_doctype)
            {
                if (Functions.GetTableNameFromXmlFile() == "PURINVDETAIL")
                {
                    if (dsPurchase1.PURINVDETAIL.Rows.Count == 0)
                        dsPurchase1.PURINVDETAIL.ReadXml(Functions.BackUpFileName);
                }
            }
            if (_doctype)
            {
                if (Functions.GetTableNameFromXmlFile() == "RETURNDETAIL")
                {
                    if (dsPurchase1.RETURNDETAIL.Rows.Count == 0)
                        dsPurchase1.RETURNDETAIL.ReadXml(Functions.BackUpFileName);
                }
            }
            IsBackUp = false;
        }
        private void BasePurInvoiceKeyDown(object sender, KeyEventArgs e)
        {
            if (ShorcutKeysDisbale) return;
            if (e.KeyCode == Keys.F10)
            {
                IsGiftItem = false;
                AddItems(string.Empty);
            }
            if (e.KeyCode == Keys.F5)
            { ItemClone(); }
            if (e.KeyCode == Keys.F4)
            { DoDelete(); }
            //if (e.KeyCode == Keys.F12 && !_doctype)
            //{
            //    Unitconversionbutton.Checked = !Unitconversionbutton.Checked;
            //}
            if (e.KeyCode == Keys.F2 && !_doctype)
            {
                IsGiftItem = true;
                AddItems(string.Empty);
            }
            //if (e.KeyCode == Keys.F11 && !_doctype)
            //{
            //    panelautosales.Visible = true;
            //    spinEdit1.Focus();
            //    panelautosales.Left = (Width - panelautosales.Width) / 2;
            //    panelautosales.Top = (Height - panelautosales.Height) / 2;
            //    gridControl1.Focus();
            //}
            if (e.KeyCode == Keys.Escape)
            {
                if (panelautosales.Visible || panelunit.Visible)
                {
                    panelautosales.Visible = false;
                    panelunit.Visible = false;
                    gridControl1.Focus();
                    advBandedGridView1.FocusedRowHandle = 0;
                }
            }
            if(e.KeyCode==Keys.F7)
            {
                if (decimal.Parse(totvalue.EditValue.ToString()) > 0)
                    adjustval.Focus();
            }
            if(e.KeyCode==Keys.F8)
            {
                if (advBandedGridView1.DataRowCount > 0 )
                {
                    var dr = advBandedGridView1.GetFocusedDataRow();
                    if(dr!=null)
                    {
                        var frm = new Puranalyse(dr["ITEMNO"].ToString(),
                                                 advBandedGridView1.GetFocusedRowCellDisplayText("ITEMNO"));
                        frm.ShowDialog();
                    }
                }
            }
        }
        protected void SetGridColumns(bool purinv)
        {
            _doctype = purinv;
            if(purinv)
            {
                colPURINVID.FieldName = "RETURNID";
                label2.Visible = false;
                LookuptoStore.Visible = false;
                //colSTOREID.Visible = false;
                //colstore.Visible = false;
                colStock.Visible = true;
                colStock.Caption = "Stock";
                colStock.FieldName = "STOCK";
                colGROSSVALUE.FieldName = "";
                colGROSSVALUE.Visible = false;
                colPROFIT.FieldName = "";
                colPROFIT.Visible = false;
                colEXPDATE.FieldName = "EXPDATE";
                colEXPDATE.DisplayFormat.FormatType = FormatType.DateTime;
                colEXPDATE.DisplayFormat.FormatString = "MM-yy";
                colSPDISC.Visible = false;
                colGROUPID.Visible = false;
                colSPRICE.OptionsColumn.AllowFocus = false;
                colCPRICE.OptionsColumn.AllowFocus = false;
                
                //colEXPDT.Visible = true;
                //colEXPDT.VisibleIndex = colEXPDATE.VisibleIndex;

                
                CopyRow.Visibility = BarItemVisibility.Never;
                Autosalesbutton.Visibility = BarItemVisibility.Never;
                Unitconversionbutton.Visibility = BarItemVisibility.Never;
            }
            else
            {
                colStock.Caption = "Lst.Recd.";
                bargift.Visibility = BarItemVisibility.Always;
            }
        }
        public bool Barvisible
        {
            set { bar1.Visible = value; }
        }
        #region Raised Control Events
        private void SupplierEditValueChanged(object sender, EventArgs e)
        {
            //if (SupplierValueChanged != null)
            //    SupplierValueChanged(sender, e);
            if (LookupSupplier.EditValue != null)
            {
                var row = LookupSupplier.Properties.GetDataSourceRowByKeyValue(LookupSupplier.EditValue) as DataRowView;
                if (row == null) return;
                var value = row["DUEDAYS"];
                if (!string.IsNullOrEmpty(value.ToString()))
                    duedays.EditValue = value.ToString();
                else
                    duedays.EditValue = 0;
                var f = new Notes();
                if (f.CheckNotesAvailable(LookupSupplier.EditValue.ToString(),_doctype?2:1))
                {
                    var f1 = new Notes(LookupSupplier.EditValue.ToString(), LookupSupplier.Text, _doctype ? 2 : 1);
                    f1.ShowDialog();
                }
            }

        }
        private void BarButtonItemItemClick(object sender, ItemClickEventArgs e)
        {
            if (BarItemClick != null)
                BarItemClick(sender, e);
        }
        private void BarManager1EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (BarKeyDown != null)
                BarKeyDown(sender, e);
        }
        #endregion
        #region  GridEvents
        private bool indicatorIcon = false;

        private void CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            //if (e.Info.IsRowIndicator)
            //{
            //    var row = advBandedGridView1.GetDataRow(e.RowHandle);
            //    if (row != null && row.RowError != String.Empty)
            //    {
            //        e.Info.ImageIndex = -1;
            //        e.Painter.DrawObject(e.Info);
            //        Rectangle r = e.Bounds;
            //        r.Inflate(-1, -1);
            //        int x = r.X + (r.Width - 24) / 2;
            //        int y = r.Y + (r.Height - 24) / 2;
            //        e.Graphics.DrawImageUnscaled(Properties.Resources.flagred, x, y);
            //        iserroricon = true;
            //        e.Handled = true;

            //    }
            //}
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;
            e.Info.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            //if(!iserroricon)
            e.Info.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            e.Info.DisplayText = (1 + int.Parse(e.RowHandle.ToString())).ToString();
            if (!indicatorIcon)
                e.Info.ImageIndex = -1;
        }
        private void ValidateRow(object sender, ValidateRowEventArgs e)
        {
            advBandedGridView1.UpdateCurrentRow();
            DataRow row = advBandedGridView1.GetDataRow(e.RowHandle);
            UpdateTotals();
            if (row.RowError != string.Empty)//if(e.ErrorText.Length > 0)
                e.Valid = false;
        }
        private void InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        #endregion
        #region protected methods
        protected virtual void AdvBandedGridView1CellValueChanged(object sender, CellValueChangedEventArgs e)
        {}
        protected virtual void GridControl1EditorKeyDown(object sender, KeyEventArgs e)
        {
            
        }
        protected virtual void AddItems(string itemno)
        {}
        protected virtual void HoldView()
        {} 
        protected virtual void advBandedGridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            
        }

        #endregion
        #region BLL
        private void ItemClone()
        {
            if (advBandedGridView1.FocusedRowHandle < 0) return;
            var dr1 = advBandedGridView1.GetFocusedDataRow();
            if (!_doctype)
            {
                var newRow = dsPurchase1.PURINVDETAIL.NewRow();
                newRow.ItemArray = dr1.ItemArray;
                newRow["TID"] = Functions.GetAutoSeed(dsPurchase1.PURINVDETAIL);
                dsPurchase1.PURINVDETAIL.Rows.Add(newRow);
            }
            //else
            //  {
            //        var newRow = dsInventory1.RETURNDETAIL.NewRow();
            //        newRow.ItemArray = dr1.ItemArray;
            //        newRow["TID"] = Functions.GetAutoSeed(dsInventory1.RETURNDETAIL);
            //        dsInventory1.RETURNDETAIL.Rows.Add(newRow);
            //  }
        }
        void UpdateRow()
        {
            if(txttotunits.EditValue!=null && txtunitqty.EditValue!=null && txttotunitvalue.EditValue!=null)
            {
                advBandedGridView1.GetDataRow(advBandedGridView1.FocusedRowHandle);
                var qty = int.Parse(txtunitqty.EditValue.ToString()) * int.Parse(txttotunits.EditValue.ToString());
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle,"QTY",qty);
                advBandedGridView1.SetRowCellValue(advBandedGridView1.FocusedRowHandle, "INVRATE", Math.Round(decimal.Parse(txttotunitvalue.EditValue.ToString()) / qty,2));
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
        protected void UpdateTotals()
        {
            decimal vtotval = 0;
            decimal vtotdisc = 0;
            decimal vtotcost = 0;
            decimal vtotsale = 0;
            decimal gtotcost = 0;
            decimal gtotsale = 0;
            decimal vtotprofit = 0;
            int  tqty = 0;
            int bqty = 0;
            if(!_doctype)
            {
                gridControl1.DataSource = pURINVDETAILBindingSource;
            }
            else
            {
                gridControl1.DataSource = rETURNDETAILBindingSource;
            }
            for (int i = 0; i < advBandedGridView1.DataRowCount; i++)
            {
                vtotsale = 0;
                vtotcost = 0;
              //if (!string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "INVRATE").ToString()) && !string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "QTY").ToString()))
                if (!string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "INVRATE").ToString()))
                {
                    tqty = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "QTY").ToString())
                        ? 0: int.Parse(advBandedGridView1.GetRowCellValue(i, "QTY").ToString());

                    bqty = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "BONUSQTY").ToString())
                       ? 0 : int.Parse(advBandedGridView1.GetRowCellValue(i, "BONUSQTY").ToString());

                    vtotval += string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "LINETOTAL").ToString()) 
                        ? 0
                        : decimal.Parse(advBandedGridView1.GetRowCellValue(i, "LINETOTAL").ToString());
                    vtotcost = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "CPRICE").ToString()) 
                        ? 0 
                        : decimal.Parse(advBandedGridView1.GetRowCellValue(i, "CPRICE").ToString());
                    vtotsale = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "SPRICE").ToString()) 
                        ? 0 
                        : decimal.Parse(advBandedGridView1.GetRowCellValue(i, "SPRICE").ToString());
                    var invrate = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "INVRATE").ToString()) 
                        ? 0 
                        : decimal.Parse(advBandedGridView1.GetRowCellValue(i, "INVRATE").ToString());
                   
                    if (!string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "DISC").ToString()))
                    {
                        var qty = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "QTY").ToString())
                                      ? 0
                                      : int.Parse(advBandedGridView1.GetRowCellValue(i, "QTY").ToString());
                        var disc = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "DISC").ToString())
                                       ? 0
                                       : decimal.Parse(advBandedGridView1.GetRowCellValue(i, "DISC").ToString());
                        vtotdisc += (invrate*qty) * disc/100;
                    }
                    if (!_doctype && !string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "SPDISC").ToString()))
                    {
                        var qty = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "QTY").ToString())
                                      ? 0
                                      : int.Parse(advBandedGridView1.GetRowCellValue(i, "QTY").ToString());
                        var disc = string.IsNullOrEmpty(advBandedGridView1.GetRowCellValue(i, "SPDISC").ToString())
                                       ? 0
                                       : decimal.Parse(advBandedGridView1.GetRowCellValue(i, "SPDISC").ToString());
                        if(vtotdisc > 0)
                            vtotdisc += (vtotdisc) * decimal.Parse(advBandedGridView1.GetRowCellValue(i, "SPDISC").ToString()) / 100;
                        else
                            vtotdisc += (invrate * qty) * disc / 100;
                    }

                }
                if (tqty == 0 && bqty > 0)
                {
                    gtotsale += vtotsale * bqty;
                }
                else
                {
                    gtotsale += vtotsale*tqty;
                }
                gtotcost += vtotcost * tqty;
            }
            totcostvalue.EditValue = gtotcost ;
            totsalevalue.EditValue = gtotsale ;
            totprofit.EditValue = gtotsale- gtotcost;//vtotprofit * tqty;
            totvalue.EditValue = vtotval;
            totdisc.EditValue = vtotdisc;
            if(spdisc.EditValue!=null)
                totspecdisc.EditValue = ((vtotval - vtotdisc) * decimal.Parse(spdisc.EditValue.ToString())) / 100;
            else
            {
                totspecdisc.EditValue = 0;
            }

            totnetamt.EditValue = vtotval - vtotdisc - decimal.Parse(totspecdisc.EditValue.ToString()) + decimal.Parse(adjustval.EditValue.ToString());
            totnetamt.Tag = totnetamt.EditValue.ToString() ;
        }
        protected bool IsLastVisibleRow(AdvBandedGridView view, int rowHandle)
        {

            var viewInfo = view.GetViewInfo() as GridViewInfo;
            if (viewInfo == null || viewInfo.RowsInfo == null || viewInfo.RowsInfo.Count == 0)
                return false;
            return viewInfo.RowsInfo[viewInfo.RowsInfo.Count - 1].RowHandle == rowHandle;
        }
        #endregion
        #region Panels
        private void LookUpEdit1EditValueChanged(object sender, EventArgs e)
        {
            if (lookupunits.EditValue != null)
            {
                txtunitqty.EditValue = lookupunits.GetColumnValue("UNITVALUE").ToString();
                txttotunits.Focus();
            }
        }
        private void Label18Click(object sender, EventArgs e)
        {
            panelunit.Visible = false;
            Unitconversionbutton.Checked = false;
        }
        private void TxttotunitvalueKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                UpdateRow();
                panelunit.Visible = false;
                gridControl1.Focus();
            }
        }
        private void TxttotunitsKeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    txttotunitvalue.Focus();
        }
        private void LookuptoStoreKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                barManager1.Bars[0].ItemLinks[0].Focus();
                gridControl1.Focus();
            }
        }
        private void Label24Click(object sender, EventArgs e)
        {
            panelautosales.Visible = false;
            //Autosaleperc = spinEdit1.Value;
            //Autosalecalon = bool.Parse(radioGroup1.EditValue.ToString());
        }
        private void SpinEdit1KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    simpleButton2.Focus();
            //}
        }
        private void SimpleButton2Click(object sender, EventArgs e)
        {
            panelautosales.Visible = false;
            Autosaleperc = spinEdit1.Value;
            Autosalecalon = bool.Parse(radioGroup1.EditValue.ToString());
            gridControl1.Focus();
        }
        private void SimpleButton3Click(object sender, EventArgs e)
        {
            panelautosales.Visible = false;
            Autosaleperc = 0;
            Autosalecalon = false;
            gridControl1.Focus();
        }
       #endregion
        protected void DoNotes()
        {
            if(LookupSupplier.EditValue==null)
            {
                XtraMessageBox.Show("Please select the supplier", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }
            var f = new Notes(LookupSupplier.EditValue.ToString(),LookupSupplier.Text,_doctype? 2:1);
            f.ShowDialog();
       }
        private void PUrinvdetailBindingSourceCurrentChanged(object sender, EventArgs e)
        {
            if(!IsBackUp)
                Functions.CreateBackUp(dsPurchase1.PURINVDETAIL);
        }
        private void REturndetailBindingSourceCurrentChanged(object sender, EventArgs e)
        {
            if (!IsBackUp)
                 Functions.CreateBackUp(dsPurchase1.RETURNDETAIL);
            try
            {
                var items = (DataRowView) rETURNDETAILBindingSource.List[0];
                Lookupwarehouse.EditValue = int.Parse(items["TOSTORE"].ToString());
                Lookupwarehouse.Enabled = rETURNDETAILBindingSource.Count <= 0;
            }
            catch(Exception)
            {
                
            }
        }
        private void LookuptoStore_EditValueChanged(object sender, EventArgs e)
        {
            if(pURINVDETAILBindingSource.Count > 0)
            {
                foreach (DataRow d in from DataRow d in dsPurchase1.PURINVDETAIL.Rows where LookuptoStore.EditValue != null select d)
                {
                        d["TOSTORE"] = LookuptoStore.EditValue.ToString();
                        if (Lookupwarehouse.EditValue != null)
                        {
                            var scomp = Lookupwarehouse.GetColumnValue("COMPANY").ToString();
                            var scomp1 = LookuptoStore.GetColumnValue("COMPANY").ToString();
                            if(scomp==scomp1)
                            {
                                d["ISSUEFORSALE"] = true;
                            }
                        }
                }
            }
        }
        private void adjustval_Enter(object sender, EventArgs e)
        {  
            //if(totnetamt.Tag!=null)
            //    totnetamt.EditValue = totnetamt.Tag;
        }
        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F10)
            {
                MessageBox.Show("d");
            }
        }
        protected virtual void adjustval_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}