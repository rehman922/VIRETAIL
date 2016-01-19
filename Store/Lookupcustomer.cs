using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;

namespace Store
{
    public partial class Lookupcustomer : XtraForm
    {
        public event GetSelectedRow EventSelectedItem;
        public bool iscustomername = true;
        public Lookupcustomer()
        {
            InitializeComponent();
        }
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cUSTOMERBindingSource.Count > 0)
                {
                    gridView1.FocusedRowHandle = 0;
                    DoSelectRow(this);
                    Close();
                }
            }
            if(e.KeyCode==Keys.Down)
            {
                gridControl1.Focus();
            }
            if(e.KeyCode==Keys.Escape)
            {
                Close();
            }
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.EditValue == null) return;
            string searchstr;
            if (!iscustomername || Functions.IsNumeric(textEdit1.EditValue.ToString()))
                searchstr = " Mobile LiKE  '" + textEdit1.EditValue + "%' or MEMBERNO like '" + textEdit1.EditValue + "%' ";
            else
                searchstr = " CUSTOMERNAME LiKE  '" + textEdit1.EditValue + "%' ";
            cUSTOMERBindingSource.Filter = searchstr;
        }
        public string filtertext
        {
            set
            {
                textEdit1.EditValue = value;
            }
        }
        private void Lookupcustomer_Load(object sender, EventArgs e)
        {
            
            cUSTOMERBindingSource.DataSource = ClsGetData.GetCustomerList();
           // cUSTOMERBindingSource.Filter = " COMPANY = '" + VIRETAILDAL.COMMON.Utils.Company + "'";
           // cUSTOMERBindingSource.Sort = " CUSTOMERNAME "; 
        }
        void F1Key()
        {
                iscustomername = true;
        }
        void F2Key()
        {
                iscustomername = false;
        }
        private void Lookupcustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F1)
            {
                iscustomername = true;
                F1Key();  
            }
            if(e.KeyCode==Keys.F2)
            {
                iscustomername = false;
                F2Key();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if(e.KeyCode==Keys.Down)
            {
                gridControl1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gridView1.FocusedRowHandle == 0)
                {
                    textEdit1.Focus();
                }
            }
        }
        void DoSelectRow(object sender)
        {
            if (gridView1.FocusedRowHandle < 0) return;
            var drs = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            var args = new GetDataRowEventArgs(drs);
            EventSelectedItem(sender, args);
            gridView1.ApplyFindFilter("");
            Close();
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                     DoSelectRow(this);
                    break;
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DoSelectRow(this);
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}