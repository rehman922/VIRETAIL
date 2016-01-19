using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;

namespace Store
{
    public partial class HoldPurchase : XtraForm
    {
        bool _doctype;
        public HoldPurchase()
        {
            InitializeComponent();
        }
        public HoldPurchase(bool doctype):this()
        {
            _doctype = doctype;
            wAREHOUSEMASTBindingSource.DataSource = ClsGetData.GetWareHouseNames();
            if (!doctype)
            {
                pURINVMAINBindingSource.DataSource = Blpurinv.GetPurinvMastHold();
                gridControl1.DataSource = pURINVMAINBindingSource;
            }
            else
            {
                colPURINVID.FieldName = "RETURNID";
                rETURNMASTBindingSource.DataSource = Blpurretinv.GetPurReturnHold();
                gridControl1.DataSource = rETURNMASTBindingSource;
            }
        }
        private void HoldPurchaseLoad(object sender, EventArgs e)
        {
           Purid = null;
        }
        private void DeleteToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (
                XtraMessageBox.Show("Do you want to delete the selected  row..?", "P.O.S", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    if(!_doctype)
                    {
                        Blpurinv.DeletePurchaseInv(gridView1.GetFocusedRowCellDisplayText(colPURINVID));
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    }
                    else
                    {
                        Blpurretinv.DeletePurRetInv(gridView1.GetFocusedRowCellDisplayText(colPURINVID));
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    }
                }
            }
            catch (Exception ex){
                XtraMessageBox.Show(ex.ToString());
            }
        }
        
        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
                Purid = gridView1.GetFocusedRowCellDisplayText(colPURINVID);
          Dispose();
        }
        public string Purid { get; set;}
    }
}