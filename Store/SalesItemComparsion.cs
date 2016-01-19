using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using VIRETAILENTITIES;

namespace Store
{
    public partial class SalesItemComparsion : XtraForm
    {
        DsReports.SalesByItemDataTable ds = new DsReports.SalesByItemDataTable();
        public SalesItemComparsion()
        {
            InitializeComponent();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {}
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ItemLookUp();
        }
        void ItemLookUp()
        {
            var f = new FrmItemLookUp();
            f.closeonselect = false;
            f.EventSelectedItem += AdditemsToList;
            f.ShowDialog();
        }
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            DataRow d = e.SelectedRow;
            var dr = ds.NewRow();
            dr[0] = d["ITEMNAME"];
            dr[1] =d["ITEMNO"];
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
                return;
            dr[2] = new BLSales().GetTotalSalesQty(d["ITEMNO"].ToString(), dateEdit1.DateTime, dateEdit2.DateTime);
            ds.Rows.Add(dr);
        }       
        private void SalesItemComparsion_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);//DateTime.Now.AddMonths(-1);
            dateEdit2.DateTime = DateTime.Now;
            salesByItemBindingSource.DataSource = ds;
        }
        private void SalesItemComparsion_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.F10)
                ItemLookUp();
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                ItemLookUp();
        }
    }
}