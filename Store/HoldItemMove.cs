using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;

namespace Store
{
    public partial class HoldItemMove : XtraForm
    {
        public int RecCount { get; set; }
        public HoldItemMove()
        {
            InitializeComponent();
            mastMoveTypesBindingSource.DataSource = ClsGetData.GetMoveTypes();
            iTEMTRANSFERMAINBindingSource.DataSource = ClsGetData.GetItemTransferByHold();
            RecCount = iTEMTRANSFERMAINBindingSource.Count;
        }
        private void HoldItemMove_Load(object sender, EventArgs e)
        {}
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
                Tranid = gridView1.GetFocusedRowCellDisplayText(colTRANID);
            Dispose();
        }
        public string Tranid { get; set; }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gridView1.FocusedRowHandle >=0)
            {
                if(XtraMessageBox.Show("Do you want to delete","POS", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var tid = gridView1.GetFocusedRowCellDisplayText(colTRANID);
                     new Blitemmove().DeleteItemMove(tid);
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
            }
        }
    }
}