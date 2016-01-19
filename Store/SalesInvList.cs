using System;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Store.BusinessLogic;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.Sales;

namespace Store
{
    // public delegate void GetSelecteditem(object sender, GetDataRowEventArgs e);
    public partial class SalesInvList : XtraForm
    {
        public event GetSelectedRow EventSelectedItems;
        //public event GetSelectedRow EventSelectedItem;
        public SalesInvList()
        {
            InitializeComponent();
        }

        private void KeyF8()
        {
            if (gridView1.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Please select the invoice ", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            else
            {
                var drs = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                Isreturn = true;
                var args = new GetDataRowEventArgs(drs);
                EventSelectedItems(this, args);
               // Close();
            }
        }

        public bool Isreturn { get; set; }

        private void SalesInvListLoad(object sender, EventArgs e)
        {
            //dateEdit1.EditValue = null;
            //dateEdit2.EditValue = null;
            //var bl = new VIRETAILDAL.Sales.SalesManger().GetSalesReport();
            //salesInvListBindingSource.DataSource = bl;
            dateEdit1.EditValue = DateTime.Now;
            dateEdit2.EditValue = DateTime.Now;
            var bl = new SalesManger().GetSalesReportByDate(dateEdit1.DateTime.Date, dateEdit2.DateTime.Date);
            salesInvListBindingSource.DataSource = bl;
            imageComboBoxEdit1.SelectedIndex = 0;
            Utils.PrintSlipPrinter = 0;
            //  salesInvListBindingSource.Sort = "SINVNO ASC";
        }

        private void SalesInvListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
               // KeyF8();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void SimpleButton4Click(object sender, EventArgs e)
        {
            //KeyF8();
        }
        private void SimpleButton1Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var bl = new BLSales();
                var dr = gridView1.GetFocusedDataRow();

                var sinv = dr["SINVNO"].ToString();
                if (dr["SALESTYPE"].ToString() == "I")
                {
                   // bl.DoPrint(sinv);  
                   bl.DoInsurancePrint(sinv);
                }
                else
                {
                    var tname = textEdit3.EditValue == null ? "" : textEdit3.EditValue.ToString();

                    if (Utils.PrintSlipPrinter==1)
                    {
                        bl.DoSlipPrint(sinv);
                    }
                   else
                    {
                        bl.DoPrint(sinv, tname);
                    }
                }
            }
        }
        private void SimpleButton2Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
            {
                XtraMessageBox.Show("Please select dates", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                return;
            }
            // gridView1.ApplyColumnsFilter();
            var bl = new SalesManger().GetSalesReportByDate(dateEdit1.DateTime.Date, dateEdit2.DateTime.Date);
            salesInvListBindingSource.DataSource = bl;
        }

        private decimal validRowCount;
        private decimal totalamt;
        private decimal returnamt = 0;
        private void gridView1_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            GridView view = sender as GridView;//if (Equals("Sum", item.Tag))
            //{
            if (e.SummaryProcess == CustomSummaryProcess.Start)
                validRowCount = 0;
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                // returnamt = decimal.Parse(view.GetRowCellValue(e.RowHandle, "RETURNAMT").ToString());
                validRowCount = decimal.Parse(view.GetRowCellValue(e.RowHandle, "SDISC").ToString());

                totalamt = decimal.Parse(view.GetRowCellValue(e.RowHandle, "NETAMT").ToString());

                //if (!Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "NETAMT"))) validRowCount = ++;
            }
             if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryID)
                {
                    case 1:
                        e.TotalValue = totalamt;
                        break;
                    case 2:
                        if (totalamt - validRowCount > 0)
                            e.TotalValue = "Discount Amount " + (validRowCount).ToString("n2");
                        break;
                }
            }
            //}
        }
        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit2.EditValue == null)
                salesInvListBindingSource.RemoveFilter();
            else
                salesInvListBindingSource.Filter = "SINVNO like  '" + textEdit2.EditValue + "'";
        }
        private void gridView1_CustomColumnSort(object sender,CustomColumnSortEventArgs e)
        {
            //try
            //{
            //    if (e.Column.FieldName == "colTRANDATE")
            //    {
            //        DataRowView dr1 = (gridView1.DataSource as DataView)[e.ListSourceRowIndex1];
            //        DataRowView dr2 = (gridView1.DataSource as DataView)[e.ListSourceRowIndex2];
            //        e.Handled = true;
            //        e.Result = System.Collections.Comparer.Default.Compare(dr1["TRANDATE"], dr2["TRANDATE"]);
            //    }
            //}
            //catch(Exception ex)
            //{
                
            //}
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageComboBoxEdit1.SelectedIndex < 0) return;
            Utils.PrintSlipPrinter = imageComboBoxEdit1.SelectedIndex;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var bl = new BLSales();
                var dr = gridView1.GetFocusedDataRow();
                var sinv = dr["SINVNO"].ToString();
                if (dr["SALESTYPE"].ToString() == "I")
                {
                    bl.DoUCAFPrint(sinv,checkBox1.Checked);
                }
            }
        }
    }
}