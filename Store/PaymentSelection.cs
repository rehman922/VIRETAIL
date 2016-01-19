using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;

namespace Store
{
    public partial class PaymentSelection : XtraForm
    {
        private string _Batchno = string.Empty;
        public PaymentSelection()
        {
            InitializeComponent();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void PaymentSelection_Load(object sender, EventArgs e)
        {
            LookupSupplier.Properties.DataSource = ClsGetData.GetSupplier();
            sUPPLIERBindingSource.DataSource = ClsGetData.GetSupplier();
            aRAPRECEIPTSBindingSource.DataSource = new PurchasePayment().GetArapReceiptMainPostUnPost(false);
            aRAPRECEIPTSBindingSource1.DataSource = new PurchasePayment().GetArapReceiptMainPostUnPost(true);
            lookupbatch.Properties.DataSource = aRAPRECEIPTSBindingSource;
            dsMaster1.Merge (new BlBanks().GetBankName());
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (gridView1.DataRowCount > 0 && string.IsNullOrEmpty(_Batchno))
            {
                
            }
            int i = 0;
            if (checkEdit1.Checked)
            {
                i = 1;
            }
            if (checkEdit2.Checked)
            {
                if (LookupSupplier.EditValue == null)
                {
                    XtraMessageBox.Show("Please check the supplier name", "POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                    
                }
                i=2;
            }
            if (checkEdit1.Checked && checkEdit2.Checked)
            {
                i = 3;
            }
            ledgers1.Merge(
                new PurchasePayment().CreatePayeMentList(
                    new Blpurinv().GetPurchaseLedger(
                        LookupSupplier.EditValue == null ? null : LookupSupplier.EditValue.ToString(),
                        int.Parse(textEdit1.EditValue.ToString()), i)));
            //   aRAPRECEIPTSDETAILSBindingSource.DataSource
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.EditValue == null)
            {
                textEdit1.EditValue = 90;
            }
            else
            {
                if (decimal.Parse(textEdit1.EditValue.ToString()) <= 0)
                {
                    textEdit1.EditValue = 90;
                }
            }
        }
        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                if (e.Column.Name == "SEL")
                {
                    if (dr["SEL"].ToString() == bool.TrueString)
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "AppliedAmt", decimal.Parse(dr["BALANCE"].ToString()));
                    }
                    else
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "AppliedAmt", 0);
                    }
                }
                //if (e.Column == colAppliedAmt)
                //{
                //    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colAppliedAmt, decimal.Parse(dr["BALANCE"].ToString()) - decimal.Parse(dr["AppliedAmt"].ToString()));
                //}
                if (string.IsNullOrEmpty(dr["AppliedAmt"].ToString()))
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", bool.FalseString);
                }
            }
        }
        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
           // gridView1.PostEditor();
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            var chk = sender as CheckEdit;
            if ((bool) chk.EditValue)
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "AppliedAmt",
                    decimal.Parse(dr["BALANCE"].ToString()));
               // gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "NewBalance", decimal.Parse(dr["BALANCE"].ToString()) - decimal.Parse(dr["AppliedAmt"].ToString()));

            }
            else
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "AppliedAmt", 0);
               // gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "NewBalance", 0);

            }
            gridView1.UpdateCurrentRow();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(_Batchno))
            {
                popupControlContainer1.ShowPopup(barManager1, Utils.GetCursorPosition());
            }
            else
            {
                DoSave(_Batchno,true);
            }
        }
        void DoSave(string batchno,bool isnew=false)
        {
            Ledgers.ARAPRECEIPTSRow newrow = null;
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            aRAPRECEIPTSDETAILSBindingSource.EndEdit();
            if (string.IsNullOrEmpty(batchno))
            {
                newrow = (Ledgers.ARAPRECEIPTSRow) new Ledgers.ARAPRECEIPTSDataTable().NewRow();
                newrow.AMOUNT = GetTotal();
                newrow.BANKID = lookupbankname.EditValue == null ? 0 : int.Parse(lookupbankname.EditValue.ToString());
                newrow.POSTED = false;
                newrow.TDATE = DateTime.Now.Date;
            }
            else
            {
              var dt =   new PurchasePayment().GetArapReceiptWithBatchno(batchno);
              newrow = (Ledgers.ARAPRECEIPTSRow) dt.Rows[0];
              if(!isnew)
                 newrow.AMOUNT = newrow.AMOUNT + GetTotal();
              else
              {
                  newrow.AMOUNT = GetTotal();  
              }
            }
            var bhl = new BLPurchasePayment();
            var changes = (Ledgers.ARAPRECEIPTSDETAILSDataTable)ledgers1.ARAPRECEIPTSDETAILS.GetChanges(DataRowState.Modified | DataRowState.Added);
           // var deleted = (Ledgers.ARAPRECEIPTSDETAILSDataTable)ledgers1.ARAPRECEIPTSDETAILS.GetChanges(DataRowState.Modified | DataRowState.Added);

            bhl.dRow = newrow;
            bhl.drTable = ledgers1.ARAPRECEIPTSDETAILS;
            try
            {
                var strstatus = bhl.DoSave();
                if (strstatus == "1")
                {
                    CheckAll();
                    aRAPRECEIPTSBindingSource.DataSource = new PurchasePayment().GetArapReceiptMainPostUnPost(false);
                    btnpost.Enabled = true;
                    btnsave.Enabled = false;
                    btndelete.Enabled = true;
                    _Batchno = VIRETAILDAL.COMMON.Utils.PurPayment;
                    btnpost.Enabled = false;
                    popupControlContainer1.Visible = false;
                    Application.DoEvents();

                    XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataRow d in ledgers1.ARAPRECEIPTSDETAILS.Rows)
                    {
                        if (d.RowState != DataRowState.Deleted)
                        {
                            d["ARAPTRANID"] = _Batchno;
                        }
                    }
                    var addedRows = from row in ledgers1.ARAPRECEIPTSDETAILS
                                    where row.RowState == DataRowState.Added
                                    select row;
                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    if (changes != null) ledgers1.Merge(changes);
                    ledgers1.AcceptChanges();
                }
                else
                {
                    XtraMessageBox.Show(strstatus, "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        decimal GetTotal()
        {
            var retval = 0m;
            foreach (Ledgers.ARAPRECEIPTSDETAILSRow  dr in ledgers1.ARAPRECEIPTSDETAILS.Rows)
            {
                retval += dr.AppliedAmt;
            }
            return retval;
        }
        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit4.Checked)
            {
                checkEdit3.Checked = false;
                lookupbatch.Enabled = true;
            }
            else
            {
                lookupbatch.Enabled = false;
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!checkEdit3.Checked && !checkEdit4.Checked)
            {
                XtraMessageBox.Show("Please select the batch option", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (checkEdit4.Checked && lookupbatch.EditValue == null)
            {
                
                    XtraMessageBox.Show("Please select the existing batch", "POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
            }
            if (string.IsNullOrEmpty(_Batchno))
                DoDeleteZeros();
            if (GetTotal() == 0)
            {
                XtraMessageBox.Show("Please select the invoices to pay", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkEdit4.Checked && lookupbatch.EditValue != null)
            {
                DoSave(lookupbatch.EditValue.ToString());
            }
            if (checkEdit3.Checked)
            {
                DoSave(string.Empty);
            }
        }
        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked)
            {
                checkEdit4.Checked = false;
            }
        }
        void DoDeleteZeros()
        {
           // ledgers1.ARAPRECEIPTSDETAILS.AsEnumerable().Where(r => r.Field<int>("AppliedAmt") ==0).ToList().ForEach(row => row.Delete());
            foreach (Ledgers.ARAPRECEIPTSDETAILSRow  dr in ledgers1.ARAPRECEIPTSDETAILS.Rows)
            {
               // if (!dr.IsAppliedAmtNull())
                //{
                //    if (dr.AppliedAmt == 0)
                //    {
                //        dr.AppliedAmt = 0;
                //       //ledgers1.ARAPRECEIPTSDETAILS.Rows.Remove(dr);
                //        dr.Delete();
                //    }
                //}
                if (dr.IsAppliedAmtNull())
                {
                    //ledgers1.ARAPRECEIPTSDETAILS.Rows.Remove(dr);
                    dr.AppliedAmt = 0;
                }
            }
            ledgers1.ARAPRECEIPTSDETAILS.AsEnumerable().Where(r => r.Field<decimal>("AppliedAmt") == 0).ToList().ForEach(row => row.Delete());
        }
        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
             
        }
        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            ledgers1.ARAPRECEIPTSDETAILS.Clear();
            _Batchno = string.Empty;
            gridControl1.ResetBindings();
            btnpost.Enabled = false;
            btnsave.Enabled = true;
            btndelete.Enabled = false;

        }
        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll(checkEdit5.Checked);
        }
        void CheckAll(bool chk=true)
        {
            foreach (Ledgers.ARAPRECEIPTSDETAILSRow dr in ledgers1.ARAPRECEIPTSDETAILS.Rows)
            {
                dr.SEL = chk;
            }
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {}
        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            //nonposted
            if (barEditItem1.EditValue != null)
            {
                ledgers1.ARAPRECEIPTSDETAILS.Clear();
                _Batchno = string.Empty;
                gridControl1.ResetBindings();
                _Batchno = barEditItem1.EditValue.ToString();
                GetPaymentDetails();
                CheckAll();
               //  btnsave.Glyph = Properties.Resources.save_new;
               // btnsave.Caption = "Save";
                btnpost.Enabled = true;
                btnsave.Enabled = false;
                btndelete.Enabled = true;

            }
        }
        private void barEditItem2_EditValueChanged(object sender, EventArgs e)
        {
            //posted
            if (barEditItem2.EditValue != null)
            {
                _Batchno = barEditItem2.EditValue.ToString();
                GetPaymentDetails();
                btnpost.Enabled = false;
                btnsave.Enabled = false;
            }
        }
        void GetPaymentDetails()
        {
            var bl = new BLPurchasePayment {batchno = _Batchno};
            bl.GetPurchasePayment();
            ledgers1.Merge(bl.drTable);
            lookupbankname.EditValue = bl.dRow.BANKID;
            CheckAll();
            if (bl.dRow.POSTED)
            {
                btnpost.Enabled = false;
            }
            else
            {
                btnpost.Enabled = true;
            }
        }
        private void btnprint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var bl = new GridPrintingClass();
            bl.Heading1 = VIRETAILDAL.COMMON.Utils.Companyname;
            bl.Heading1 = "Supplier Payement List                " + "Batch No: " +_Batchno;
            bl.DoPrint(gridControl1);
        }
        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            LookupSupplier.Enabled = checkEdit2.Checked;
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            textEdit1.Enabled = checkEdit1.Checked;
        }
        private void lookupbankname_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (string.IsNullOrEmpty(e.DisplayValue.ToString())) return;
            var bl = new BlBanks();
            if (bl.DoSave(lookupbankname.Text) == "1")
            {
                dsMaster1.Merge(bl.GetBankName());
            }
            e.Handled = true;
        }
        private void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void btnpost_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if(XtraMessageBox.Show("Do you want to reverse the selected batch","POS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    DoPost();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void DoPost()
        {
            if (!string.IsNullOrEmpty(_Batchno))
            {
               var bhl = new BLPurchasePayment();
                bhl.batchno = _Batchno;
                bhl.drTable = ledgers1.ARAPRECEIPTSDETAILS;
                var strstatus = bhl.DoPost();
                if (strstatus == "1")
                {
                    ledgers1.ARAPRECEIPTSDETAILS.Clear();
                    _Batchno = string.Empty;
                    gridControl1.ResetBindings();
                    aRAPRECEIPTSBindingSource.DataSource = new PurchasePayment().GetArapReceiptMainPostUnPost(false);
                   // aRAPRECEIPTSBindingSource1.DataSource = new PurchasePayment().GetArapReceiptMainPostUnPost(true);
                    lookupbatch.EditValue = null;
                    lookupbatch.Properties.DataSource = aRAPRECEIPTSBindingSource;
                }
                else
                {
                    XtraMessageBox.Show(strstatus, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void btndelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(_Batchno))
            {
                if (XtraMessageBox.Show("Do you want to delete selected invoices " , "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridView1.PostEditor();
                    foreach (Ledgers.ARAPRECEIPTSDETAILSRow drm in ledgers1.ARAPRECEIPTSDETAILS.Rows)
                    {
                        if (drm.SEL == false)
                        {
                            var bl = new BLPurchasePayment();
                            bl.DoDeleteInvoice(drm);
                        }
                     }
                    ledgers1.ARAPRECEIPTSDETAILS.Clear();
                    gridControl1.ResetBindings();
                    GetPaymentDetails();
                }
            }
        }
    }
}
