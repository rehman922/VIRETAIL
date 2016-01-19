using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Store.BusinessLogic;
using Store.Reports;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Sales;
using VIRETAILENTITIES;

namespace Store
{
    public partial class FrmInventoryNotMatching : Form
    {
        private bool fixstkdiff;
        Ledgers.InventoryVariationDataTable  dt = new Ledgers().InventoryVariation;
        public FrmInventoryNotMatching()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = true;
            Application.DoEvents();
            CreateInventoryReport();
            progressPanel1.Visible = false;
        }
        void CreateInventoryReport()
        {
            var ds = new StockMaster().GetDististinctItemsInStockMaster(); 
            int i = 0;
            var bl = new BlItemMaster();
            var stk = new StockMaster();
            var bls = new SalesManger();
            foreach (DataRow stockmasterRow in ds.Rows)
            {
                var dr = (Ledgers.InventoryVariationRow)  dt.NewRow();
                dr[0] = i++;
                var itm = stockmasterRow["ITEMNO"].ToString();
                dr.ITEMNO = itm;
                dr.ITEMNAME = bl.GetItemname(itm);
                dr.OPENING = bls.GetOpeningQty(itm);
                dr.RECEIVE = bls.GetReceivedQty(itm);
                dr.RETURN = bls.GetReturnQty(itm);
                dr.SALES = bls.GetSoldQty(itm);
                dr.TRANSFER = bls.GetTransferedQty(itm);
                dr.ADJQTY = bls.GetAdjQty(itm);
                dr.ACTUAL = (dr.OPENING + dr.ADJQTY  + dr.RECEIVE + (-1* dr.RETURN)) - (dr.SALES + dr.TRANSFER);
                dr.INSTOCK = stk.GetAvailableQty(itm);
              //  dr.STOCKID = int.Parse(stockmasterRow["STOCKID"].ToString());
                dt.Rows.Add(dr);
            }
            inventoryVariationBindingSource.DataSource = dt;
            fixstkdiff = false;
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            fixstkdiff = true;
            inventoryVariationBindingSource.Filter = "INSTOCK <> ACTUAL";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = false;
            var pr = new GridPrintingClass();
            pr.Footer2 = DateTime.Now.ToString();
            pr.Heading1 = Utils.Companyname;
            pr.Heading2 = "Inventory Status";
            pr.DoPrint(gridControl1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = true;
            Application.DoEvents();
            foreach (Ledgers.InventoryVariationRow dr in dt.Rows)
            {
                if (!dr.MULTILINE)
                {
                    if (dr.ACTUAL != dr.INSTOCK)
                    {
                        if (!dr.IsSTOCKIDNull())
                        {
                            if(dr.STOCKID > 0)
                            new StockMaster().UpdateStockQtyByStockid(dr.ACTUAL, dr.STOCKID);
                        }
                    }
                }
            }
            MessageBox.Show("Stock Updated");
            progressPanel1.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt.Rows)
            {
                var str = " itemno ='" + dr["ITEMNO"] +"'";
                var countrows = dt.Select(str);
                if (countrows.Count() > 1)
                {
                    foreach (DataRow dr1 in countrows)
                    {
                        dr["MULTILINE"] = 1;
                    }
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = true;
            int i = 0;
            Application.DoEvents();
            foreach (Ledgers.InventoryVariationRow dr in dt.Rows)
            {
                if (dr.MULTILINE)
                {
                    i++;
                    new StockMaster().UpdateStockQtyByStockid(dr.ACTUAL, dr.STOCKID);
                }

            }
            MessageBox.Show(i.ToString());
            progressPanel1.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            inventoryVariationBindingSource.Filter = "MULTILINE=1";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Ledgers.InventoryVariationRow dr in dt.Rows)
            {
                    dr.STOCKID = new StockMaster().GetStockid(dr.ITEMNO);
            }
        }
    }
}
