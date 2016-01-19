using System;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;

namespace Store
{
    public partial class CustomerCenter : XtraForm
    {
        public CustomerCenter()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var f = new Customer();
            f.Show();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void CustomerCenter_Load(object sender, EventArgs e)
        {
            cUSTOMERBindingSource.DataSource = ClsGetData.GetCustomerList();

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                var f =new Customer();
                f._customerno = dr["CUSTNO"].ToString();
                f.Show();
                f.DoView();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            cUSTOMERBindingSource.DataSource = ClsGetData.GetCustomerList();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var cl = new GridPrintingClass();
            cl.Heading1 = "Customer List";
            cl.DoPrint(gridControl1);
        }
    }
}