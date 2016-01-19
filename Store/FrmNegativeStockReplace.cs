using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;

namespace Store
{
    public partial class FrmNegativeStockReplace : XtraForm
    {
        public FrmNegativeStockReplace()
        {
            InitializeComponent();
        }

        private void FrmNegativeStockReplace_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
                Close();
        }

        public DsInventory.STOCKMASTERDataTable GetDsInventory { get; set;}

        private void FrmNegativeStockReplace_Load(object sender, EventArgs e)
        {
            var n = new DsReports.NegativeStockDataTable();
            foreach(DataRow d  in GetDsInventory.Rows)
            {
                var newrow = n.NewRow();
                var qty = string.IsNullOrEmpty(d["QTY"].ToString()) ? 0 : int.Parse(d["QTY"].ToString());
                var stk = new StockMaster().GetAvailableQty(int.Parse(d[0].ToString()));
                newrow[0] = ClsGetData.GetItemname(d["ITEMNO"].ToString());
                newrow[1] = qty;
                newrow[2] = stk - qty;
                newrow[3] = stk ;
                n.Rows.Add(newrow);
            }
            gridControl1.DataSource = n;

        }
    }
}