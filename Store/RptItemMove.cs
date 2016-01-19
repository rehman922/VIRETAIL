using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Store.Reports;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;

namespace Store
{
    public partial class RptItemMove : XtraForm
    {
        public RptItemMove()
        {
            InitializeComponent();
        }
        DsReports dsReports = new DsReports();
        private void RptItemMove_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F10)
            {
                if(dateEdit1.EditValue==null || dateEdit2.EditValue==null)
                {
                    XtraMessageBox.Show("Please selecte the period", "POS", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    return;
                }
                var frm = new FrmItemLookUp();
                frm.EventSelectedItem += AdditemsToList;
                frm.ShowDialog();
            }
        }
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            DataRow dr = e.SelectedRow;
            GetData(dr["itemno"].ToString(), dr["ITEMNAME"].ToString(), dr["sel"].ToString());
        }
        void GetData(string itemno,string itemname,string sel)
        {
            if(sel==bool.TrueString)
            {
                var bl = new BLReports().GetItemMove(itemname, itemno, dateEdit1.DateTime, dateEdit2.DateTime);
                dsReports.Merge(bl);
                gridControl2.DataSource =  dsReports.GetItemMove;
            }
            //else
            //{
            ////    RemoveFromGrid(itemname);
            //}
        }
        void RemoveFromGrid(string itemname)
        {
            var rows = dsReports.GetItemMove.Select("Column1='" + itemname + "'");
            foreach (var dataRow in rows)
            {
                dataRow.Delete();
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(bandedGridView1.DataRowCount==0)
                return;
            var bl = new GridPrintingClass
            {
                Heading1 = Utils.Companyname,
                Heading2 =
                    "Item Movement Report From : " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " To : " +
                    dateEdit2.DateTime.ToString("dd-MM-yyyy") + ""
            };
            bl.DoPrint(gridControl2);
        }
        private void RptItemMove_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
            dateEdit2.DateTime = DateTime.Now;
        }
        private void bandedGridView1_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
          decimal validRowCount = 0;
          decimal totalamt = 0;
          decimal opening = 0;
          bool isfrist = true;
            GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
             GridView view = sender as GridView;
            ////if (Equals("Sum", item.Tag))
            ////{
            //if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            //    validRowCount = 0;
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                validRowCount = decimal.Parse(view.GetRowCellValue(e.RowHandle, "Available").ToString());
                if (opening == 0 && isfrist)
                {
                    opening = decimal.Parse(view.GetRowCellValue(e.RowHandle, "Opening").ToString());
                    isfrist = false;
                }
                //if (!Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "NETAMT"))) validRowCount = ++;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryID)
                {
                    case 1:
                        e.TotalValue =  (validRowCount).ToString("n2");;
                        break;
                    case 4:
                         e.TotalValue =  (opening).ToString("n2");;
                    //    if(totalamt -validRowCount > 0)
                    //        e.TotalValue = "Discount Amount " + (totalamt - validRowCount).ToString("n2");
                        break;
                }
            }
        }
        private void bandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!bandedGridView1.IsGroupRow(bandedGridView1.FocusedRowHandle))
            {
                var dr = bandedGridView1.GetDataRow(bandedGridView1.FocusedRowHandle);

                var bl = new BLReports().GetItemMoveDetails(dr["itemname"].ToString(), dr["itemno"].ToString(),DateTime.Parse(dr["trandate"].ToString()), dateEdit2.DateTime);
                var f = new RptFrmItemMoveDrillDown();
                f.LoadData(bl, DateTime.Parse(dr["trandate"].ToString()), dateEdit2.DateTime);
                f.ShowDialog();
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}