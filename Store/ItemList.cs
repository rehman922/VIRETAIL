using System;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.Reports;
using VIRETAILDAL.COMMON;

namespace Store
{
    public partial class ItemList : XtraForm
    {
        public ItemList()
        {
            InitializeComponent();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            var ds = new BlItemMaster().GetRptItemsList();
            //foreach (DataRow dr in ds.Rows)
            //{
            //    dr["Stock"] = new BLSales().GetAvailableQty(dr["ITEMNO"].ToString());
            //}
            itemsListBindingSource.DataSource = ds;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var f = new ItemMast();
            f.ShowDialog();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if(gridView1.FocusedRowHandle < 0)
                return;
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            var f = new ItemMast();
            f.Show();
            f.DoView(dr["itemno"].ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var gr = new GridPrintingClass();
            gr.Heading1 = Utils.Companyname;
            gr.Heading2 = "Items List";
            gr.DoPrint(gridControl1);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}