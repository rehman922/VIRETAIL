using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class StockList : XtraForm
    {
        public event GetSelectedRow EventSelectedItem;
        bool isselected;
        private bool isbarcode;
        private bool ismfbarcode;
        string filter = null;
        public StockList()
        {
            InitializeComponent();
        }
        public StockList(DataTable ds, string itemno, string whid, bool isstore = false,bool iszeroqty=false)
            : this()
        {
            var dsS = new DsReports().GetStockItemsForTransfer;
            if (!isstore)
            {
                dsS = ClsGetData.GetStockItemsForTransferDataTable(Utils.Company,
                                                                   whid,iszeroqty);
                getStockListBindingSource.DataSource = dsS;
            }
            else
            {
                dsS = ClsGetData.GetStockItemsForTransferDataTable(Utils.Company,
                                                                   Utils.SalesStoreCode,iszeroqty);
                getStockListBindingSource.DataSource = dsS;
            }
            if (ds != null)
            {
                foreach (DataRow d in ds.Rows)
                {
                    if (d.RowState != DataRowState.Deleted)
                    {
                        var rows = dsS.Select("STOCKID = " + int.Parse(d["STOCKID"].ToString()) + "");
                        foreach (DataRow dr in rows)
                        {
                            dr["SEL"] = bool.TrueString;
                        }
                    }
                }
            }
        }

        private void StockList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ITEMMAST1' table. You can move, or remove it, as needed.
            textEdit1.Focus(); 
        }
        private void StockListKeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
               
                case Keys.F1:
                    ismfbarcode = false;
                    F1Key();
                    break;
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Down:
                    gridControl1.Focus();
                    break;
                case Keys.Up:
                    if (gridView1.FocusedRowHandle == 0)
                    {
                        textEdit1.Focus();
                    }
                    break;
            }
        }
        void F1Key()
        {
            //if (!isbarcode)
            //{
            //    isbarcode = true;
            //    colBARCODE.VisibleIndex = 1;
            //    colITEMNAME.VisibleIndex = 2;
            // // gridView1.OptionsFind.FindFilterColumns = "BARCODE";
            //}
            //else
            //{
            //    isbarcode = false;
            //    colBARCODE.VisibleIndex = 2;
            //    colITEMNAME.VisibleIndex = 1;
            //  // gridView1.OptionsFind.FindFilterColumns = "ITEMNAME";  
            //}
            if (!isbarcode)
            {
                isbarcode = true;
                textEdit1.EditValue = null;
                textEdit1.Properties.NullText = "Enter Barcode";
                textEdit1.Properties.NullValuePrompt = "Enter Barcode";
                labelControl1.Text = "F1 For Item Selection";
                colBARCODE.VisibleIndex = 1;
                colITEMNAME.VisibleIndex = 2;
                // gridView1.OptionsFind.FindFilterColumns = "BARCODE";
            }
            else
            {
                isbarcode = false;
                labelControl1.Text = "F1 For Barcode Selection";
                textEdit1.EditValue = null;
                textEdit1.Properties.NullText = "Enter Item name";
                textEdit1.Properties.NullValuePrompt = "Enter Item name";
                //      barButtonItem1.Glyph = Properties.Resources.barcode;
                colBARCODE.VisibleIndex = 2;
                colITEMNAME.VisibleIndex = 1;
                // gridView1.OptionsFind.FindFilterColumns = "ITEMNAME";  
            }
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    DoSelectRow(this);
                    textEdit1.Focus();
                    textEdit1.EditValue = string.Empty;
                    ////if (gridView1.Columns[4])
                    //if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SEL").ToString() == bool.TrueString)
                    //{
                    //    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", false);
                    //    isselected = true;
                    //}
                    //else
                    //{
                    //    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", true);
                    //    isselected = false;
                    //}
                    //DataRow drs = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    //var args = new GetDataRowEventArgs(drs);
                    //EventSelectedItem(sender, args);
                    break;
            }
        }
        void DoSelectRow(object sender)
        {
            if (gridView1.FocusedRowHandle < 0) return;
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SEL").ToString() == bool.TrueString)
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", false);
                isselected = true;
            }
            else
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", true);
                isselected = false;
            }
            var drs = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            var args = new GetDataRowEventArgs(drs);
            EventSelectedItem(sender, args);
            gridView1.ApplyFindFilter("");
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DoSelectRow(this);
            textEdit1.Focus();
            textEdit1.EditValue = string.Empty;
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.EditValue == null) return;
            string searchstr;
            if (isbarcode)
                 searchstr = " ITEMNO  LiKE  '" + textEdit1.EditValue + "'   OR    BARCODE LiKE  '" + textEdit1.EditValue + "' ";
            else
                searchstr = "ITEMNAME LiKE  '" + textEdit1.EditValue + "%' ";
            getStockListBindingSource.Filter = searchstr;
        }
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (getStockListBindingSource.Count > 0)
                {
                    gridView1.FocusedRowHandle = 0;
                    DoSelectRow(this);
                    textEdit1.Focus();
                    textEdit1.EditValue = string.Empty;
                }
            }
        }
        /*
        private void GridView1KeyDown(object sender, KeyEventArgs e)
        {
           
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        DoSelectRow(this);
                        textEdit1.Focus();
                        textEdit1.EditValue = string.Empty;
                        break;
                   
                }
                
        }
        void DoSelectRow(object sender)
        {
            if (gridView1.FocusedRowHandle < 0) return;
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SEL").ToString() == bool.TrueString)
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", false);
                isselected = true;
            }
            else
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", true);
                isselected = false;
            }
            DataRow drs = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            var args = new GetDataRowEventArgs(drs);
            EventSelectedItem(sender, args);
            gridView1.ApplyFindFilter("");
           // gridView1.ActiveFilterString =  filter;  

        }
        //private void GridView1DoubleClick(object sender, EventArgs e)
        //{
        //    DoSelectRow(sender);
        //}
        private void GridView1CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.VisibleIndex == 0)
            {
                if (gridView1.ActiveEditor != null)
                    isselected = gridView1.ActiveEditor.OldEditValue.ToString() == bool.TrueString;
                else
                {
                    isselected = true;
                }
            }
        }
      
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           DoSelectRow(sender);
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.EditValue == null) return;
            string searchstr;
            if (isbarcode)
                searchstr = "BARCODE LiKE  '" + textEdit1.EditValue + "%' ";
            else
                searchstr = "ITEMNAME LiKE  '" + textEdit1.EditValue + "%' ";
            if(!string.IsNullOrEmpty(searchstr))
                getStockListBindingSource.Filter =    searchstr;

        }
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (getStockListBindingSource.Count > 0)
                {
                    gridView1.FocusedRowHandle = 0;
                    DoSelectRow(gridView1);
                    textEdit1.Focus();
                    textEdit1.EditValue = string.Empty;
                }
            }
        }
         */
    }
}
