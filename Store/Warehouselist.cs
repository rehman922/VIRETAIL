using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace Store
{
    public partial class Warehouselist : Form
    {
        public int whid=0;
        bool flag = false;
        public Warehouselist()
        {
            InitializeComponent();
        }
        private void Warehouselist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.WAREHOUSEMAST' table. You can move, or remove it, as needed.
            this.wAREHOUSEMASTTableAdapter.Fill(this.dataSet1.WAREHOUSEMAST);
            if (this.dataSet1.WAREHOUSEMAST.Rows.Count == 0)
            {
                XtraMessageBox.Show("Please setup warehouses", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = true;
                this.Close();
            }
        }
        private void c1TrueDBGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataSet1.WAREHOUSEMAST.Rows.Count > 0)
            {
                this.whid = int.Parse(c1TrueDBGrid1.Columns["whid"].Value.ToString());
                flag = false;
                this.Close();
            }
        }
        private void Warehouselist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                var frm = new PurchaseInvoiceN();
                frm.Whid = this.whid;
                frm.Show();
            }
        }
    }
}
