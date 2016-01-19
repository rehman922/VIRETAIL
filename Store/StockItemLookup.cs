using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;

namespace Store
{
    public partial class StockItemLookup : Form
    {
        private DataTable dtn = new DsInventory.STOCKMASTERDataTable();

        public StockItemLookup()
        {
            InitializeComponent();
        }


        private void StockFixtb_Load(object sender, EventArgs e)
        {
            sTOCKMASTERBindingSource.DataSource = dtn;
            sTOCKMASTERBindingSource.Filter = "qty > 0";
            //  gridControl1.DataSource = dtn;
        }

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
            
        }
        void KeyF10()
        {
            this.InvokeEx((lv => AddItems())); ;
        }
        void AddItems()
        {

            var frm = new FrmItemLookUp();
            frm.EventSelectedItem += AdditemsToList;
            frm.closeonselect = true;
            if (txtbarcode.EditValue != null)
                frm.filtertext = txtbarcode.EditValue.ToString();
            frm.ShowDialog();

        }
        void AdditemsToList(object sender, GetDataRowEventArgs g)
        {
            var current = g.SelectedRow;
            txtbarcode.Text = current["ITEMNO"].ToString();
            txtbarcode.SendKey(new KeyEventArgs(Keys.Enter));
        }
        private void AddLineItem()
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
            
            txtbarcode.EditValue = string.Empty;
            var bl = new BLSales();
         //   var aQty = bl.GetStockByItemno(current["ITEMNO"].ToString());
            textEdit2.Text = current["ITEMNAME"].ToString();



            //if (aQty > 0)
            //{
                var dt = bl.GetStock(current["ITEMNO"].ToString());

                foreach (DataRow dr in dt.Rows)
                {
                    
                        DataRow newRow = dtn.NewRow();
                        newRow["QTY"] = dr[0];
                        newRow["SPRICE"] = dr[1];
                        newRow["CPRICE"] = dr[2];
                        newRow["ITEMNO"] = current["ITEMNO"];
                        newRow["BARCODE"] =   current["BARCODE"];


                        newRow["COMPANY"] = Utils.Company;
                        dtn.Rows.Add(newRow);
          //      }

                
            //    CheckForMultiStock(current["ITEMNO"].ToString(), current["ITEMNAME"].ToString());
            }
        }

        private void CheckForMultiStock(string itemno, string itemname)
        {
            var bl = new BLSales();
            var drstock = new BLSales().GetStockItem(itemno, "S");
            var dprice = bl.GetDisctinctSprices(drstock);
            gridControl1.DataSource = drstock;
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dtn.Clear();
            txtbarcode.EditValue = string.Empty;
            textEdit2.Text =  string.Empty;
            txtbarcode.Focus();
        }

        private void StockItemLookup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                KeyF10();
            }
        }
    }
}
