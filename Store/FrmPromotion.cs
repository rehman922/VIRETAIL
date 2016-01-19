using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class FrmPromotion : XtraForm
    {
        private int _Batchno;
        public FrmPromotion()
        {
            InitializeComponent();
        }

        private void FrmPromotion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                this.InvokeEx(x => AddItems(string.Empty));
            }
        }
        void AddItems(string itemno)
        {
            var frm = new FrmItemLookUp();
            frm.EventSelectedItem += AdditemsToList;
            frm.closeonselect = false;
            frm.ShowDialog();
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
                foreach (DataRow fdr in  ledgers1.PROMOITEMS.Rows)
                {
                    if (fdr.RowState != DataRowState.Deleted)
                    {
                        if (fdr["ITEMNO"].ToString() == adr["ITEMNO"].ToString())
                        {
                            itemfound = true;
                        }
                    }
                }
                if (!itemfound)
                {
                    var dr = ledgers1.PROMOITEMS.NewRow();
                    dr["BATCHNO"] = 0;
                    dr["ITEMNO"] = adr["itemno"];
                    dr["OLDPRICE"] = adr["SPRICE"];
                    ledgers1.PROMOITEMS.Rows.Add(dr);
                }
            }
            else
            {
                var i = 0;
                foreach (DataRow d in ledgers1.PROMOITEMS.Rows)
                {
                    if (d.RowState != DataRowState.Deleted)
                        if (d["ITEMNO"].ToString() == adr["itemno"].ToString())
                        {
                            //if (string.IsNullOrEmpty(d["QTY"].ToString()))
                                ledgers1.PROMOITEMS.Rows.RemoveAt(i);
                            break;
                        }
                    i++;
                }
            }
        }

        private void FrmPromotion_Load(object sender, EventArgs e)
        {
            var cls = new PromotionPrice();
            iTEMMASTBindingSource.DataSource =  ClsGetData.GetItemMastList();
            if (Utils.Company == "00" || Utils.Company == "01")
            {
                pROMOITEMS1BindingSource.DataSource = cls.GetPromoBatchNos();
                _Batchno = cls.GetMaxBatchNo();
                _Batchno = _Batchno + 1;
                textEdit1.Text = _Batchno.ToString();
                simpleButton3.Visible = true;
            }
            else
            {
                simpleButton3.Visible = false;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.InvokeEx(x => AddItems(string.Empty));
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
            {
                XtraMessageBox.Show("Please select the promotion dates", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
          //  XtraMessageBox.Show("Please check the price of items before updating", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (
                XtraMessageBox.Show("Are you sure to update the price", "POS", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!GridValidate())
                {
                    pROMOITEMSBindingSource.EndEdit();
                    var changes = (Ledgers.PROMOITEMSDataTable) ledgers1.PROMOITEMS.GetChanges();
                    var cls = new PromotionPrice();
                    cls.PromoitemsDataTable = ledgers1.PROMOITEMS;

                    var savestatus = cls.DoSave();

                    if (savestatus == "1")
                    {
                        simpleButton3.Enabled = false;
                        XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        var addedRows = from row in ledgers1.PROMOITEMS
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
                        XtraMessageBox.Show(savestatus, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        bool GridValidate()
        {
            foreach (Ledgers.PROMOITEMSRow dr in ledgers1.PROMOITEMS.Rows)
            {
                dr.STDATE = dateEdit1.DateTime.Date;
                dr.TODATE = dateEdit2.DateTime.Date;
                dr.BATCHNO = _Batchno;
                dr.RowError = dr.IsNEWPRICENull() ? "Please enter the price" : null;
                if (!dr.IsNEWPRICENull())
                {
                    dr.RowError = dr.NEWPRICE <= 0 ? "Please check the price" : null;
                }
            }
           return ledgers1.PROMOITEMS.HasErrors ;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var cls = new GridPrintingClass();
            cls.Heading1 = "Promotion Items" + "                Batch No :" + textEdit1.Text;
            cls.Heading2 = "Date From  : " + 
            dateEdit1.DateTime.Date.ToShortDateString() + "  " +
            dateEdit2.DateTime.Date.ToShortDateString();
            cls.DoPrint(gridControl1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
        void GetData(string sno)
        {
            ledgers1.PROMOITEMS.Clear();
            var cls = new PromotionPrice();
            var dt = cls.GetDataByBatchNo(int.Parse(sno));
            
            ledgers1.Merge(dt);
            foreach (Ledgers.PROMOITEMSRow dr in ledgers1.PROMOITEMS.Rows)
            {
                dateEdit1.EditValue = dr.STDATE;
                dateEdit2.EditValue = dr.TODATE;
                textEdit1.Text = dr.BATCHNO.ToString();
            }
            
            simpleButton3.Enabled = false;
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if(lookUpEdit1.EditValue!=null)
            GetData(lookUpEdit1.EditValue.ToString());
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (XtraMessageBox.Show("Do you want to delete the selected row","Promotion Price",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                     gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
            }
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (XtraMessageBox.Show("Do you want to apply the value ", "Promotion Items", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    foreach (Ledgers.PROMOITEMSRow dr in ledgers1.PROMOITEMS.Rows)
                    {
                        if (!dr.IsOLDPRICENull())
                        {
                            if(textEdit2.EditValue != null)
                            {
                                decimal np    = dr.OLDPRICE - dr.OLDPRICE * (decimal.Parse(textEdit2.EditValue.ToString()) / 100);
                                dr.NEWPRICE  = Math.Round(np,2);
                            }
                        }
                    }
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            Ledgers.PROMOITEMSRow dr = (Ledgers.PROMOITEMSRow) gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr == null)
                return;
            if (e.Column.FieldName == "PERC")
            { 
                if(dr["OLDPRICE"].ToString() != null)
                {
                    if(decimal.Parse(dr["OLDPRICE"].ToString()) >0)
                    {
                        decimal np    = dr.OLDPRICE - dr.OLDPRICE * (decimal.Parse(dr.PERC.ToString()) / 100);
                        dr.NEWPRICE  = Math.Round(np,2);
                    }
                }
            }
        }
    }
}