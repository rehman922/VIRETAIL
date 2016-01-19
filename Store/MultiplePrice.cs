using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Store
{
    public partial class MultiplePrice : DevExpress.XtraEditors.XtraForm
    {
        public bool isselected { get; set; }
    //  public event GetSelectedRow EventSelectedItem;
        public string itemno = string.Empty;
        public VIRETAILENTITIES.DsInventory.STOCKMASTERDataTable ds { get; set; }
        public MultiplePrice()
        {
            InitializeComponent();
        }
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
             
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (gridView1.FocusedRowHandle < 0) return;
            //    if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SEL").ToString() == bool.TrueString)
            //    {
            //        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", false);
            //    }
            //    else
            //    {
            //        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", true);
            //    }
            //}
        }
        private void DoSelectRow(object sender)
        {
           // if (gridView1.FocusedRowHandle < 0) return;
           // if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SEL").ToString() == bool.TrueString)
           // {
           //     gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", false);
           //     isselected = true;
           // }
           // else
           // {
           //     gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", true);
           //     isselected = false;
           // }
           // var drs = gridView1.GetDataRow(gridView1.FocusedRowHandle);
           // var args = new GetDataRowEventArgs(drs);
           // EventSelectedItem(sender, args);
        }
        private void MultiplePrice_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ds;
           // iTEMMAST1BindingSource.DataSource = COMMON.ClsGetData.GetItemMast1List();
            repositoryItemLookUpEdit1.DataSource = COMMON.ClsGetData.GetItemMast1List();
            gridControl1.Focus();
            if(gridView1.FocusedRowHandle > 0)
            {
               gridView1.FocusedColumn = gridColumn2;
            }
            //  dsInventory1.Merge(COMMON.ClsGetData.GetItemMast1List());
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr == null) return;
            if(e.Column.FieldName=="DQNTY")
            {
                if (!string.IsNullOrEmpty(dr["DQNTY"].ToString()))
                {
                  if (int.Parse(dr["QTY"].ToString()) < int.Parse(dr["DQNTY"].ToString()))
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DQTY", int.Parse(dr["QTY"].ToString()));
                    }
                }
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DoKeyF4();
        }
        void DoKeyF4()
        {
            isselected = true;
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            ds.AcceptChanges();
            Dispose();
        }
        private void MultiplePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F4)
            {
                DoKeyF4();
            }
            if(e.KeyCode==Keys.Escape)
            {
                Dispose();
            }
        }
         bool IsLastVisibleRow(DevExpress.XtraGrid.Views.Grid.GridView view, int rowHandle)
        {

            var viewInfo = view.GetViewInfo() as GridViewInfo;
            if (viewInfo == null || viewInfo.RowsInfo == null || viewInfo.RowsInfo.Count == 0)
                return false;
            return viewInfo.RowsInfo[viewInfo.RowsInfo.Count - 1].RowHandle == rowHandle;
        }

        private void gridControl1_EditorKeyDown(object sender, KeyEventArgs e)
        {
            //if (gridView1.FocusedColumn == null)
            //    return;
            //if (IsLastVisibleRow(gridView1, gridView1.FocusedRowHandle))
            //{
            //    gridView1.MovePrev();
            //    gridView1.UpdateCurrentRow();
            //    e.Handled = true;
            //    simpleButton2.Focus();
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}