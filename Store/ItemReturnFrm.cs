using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Store
{
    public partial class ItemReturnFrm : XtraForm
    {
        public ItemReturnFrm()
        {
            InitializeComponent();
        }
        public DataTable DataTable { get; set; }
        public string itemname { get; set; }
        public string barcode { get; set; }
        public string itemno { get; set;}
        public int stockid;
        private void ItemReturnFrm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataRow dr in DataTable.Rows)
            {
               if(i==0)
               {
                   lblbarcode.Text= dr["BARCODE"].ToString();
                   stockid = int.Parse(dr["STOCKID"].ToString());
                   lblname.Text = itemname;
                   txtsalesprice.EditValue = decimal.Parse(dr["SPRICE"].ToString());
                   if (!string.IsNullOrEmpty(dr["EXPDATE"].ToString()))
                       txtexpdate.EditValue = DateTime.Parse(dr["EXPDATE"].ToString()).ToString("MM-yy");
               }
               i++;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }
        private void ItemReturnFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F4)
            {
                KeyF4();
            }
        }
        void KeyF4()
        {
               
        }
    }
}