using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptItemPurchaseDetails : XtraForm
    {
        public RptItemPurchaseDetails()
        {
            InitializeComponent();
            var dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEdit1.EditValue = dt;
            dateEdit2.EditValue = dt.AddMonths(1).AddDays(-1);
        }
        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                ItemLookUp();
            }
        }
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            DataRow d = e.SelectedRow;
            textEdit2.EditValue = d["ITEMNAME"];
            textEdit1.EditValue = d["ITEMNO"];
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if(textEdit1.EditValue!=null || textEdit2.EditValue!=null)
            {
                GetData();
            }
            
           // GetRptItemPurchaseDetails
        }
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textEdit1.EditValue != null)
                {
                    var blf = new BlItemMaster().FindItemByBarCode(textEdit1.EditValue.ToString());
                    if (blf.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Item master not found", "POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        textEdit1.SelectAll();
                    }
                    else
                    {
                        foreach (DataRow dr in blf.Rows)
                        {
                            textEdit2.EditValue = dr["ITEMNAME"].ToString();
                        }
                        GetData();
                    }
                }
            }
        }
        void GetData()
        {
            rptItemPurchaseDetailsBindingSource.DataSource = null;

            if(dateEdit1.EditValue==null || dateEdit2.EditValue==null)
            {
                XtraMessageBox.Show("Please check the period", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
              rptItemPurchaseDetailsBindingSource.DataSource =
                ClsGetData.GetRptItemPurchaseDetails(textEdit1.EditValue.ToString(), dateEdit1.DateTime.Date,
                                                            dateEdit2.DateTime.Date);
            if(gridView1.DataRowCount==0)
            {
                XtraMessageBox.Show("Data not found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RptItemPurchaseDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F10)
            {
                ItemLookUp();
            }
        }
        void ItemLookUp()
        {

            var f = new FrmItemLookUp();

            //if (textEdit1.EditValue != null)
            //{
            //    f.filtertext = textEdit2.EditValue.ToString();
            //}
            f.closeonselect = true;
            f.EventSelectedItem += AdditemsToList;
            f.ShowDialog();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                var cl = new GridPrintingClass();
                cl.Heading1 = Utils.Companyname;
                cl.Heading2 = "Item name / Code :" + textEdit2.Text  +  "   " + textEdit1.Text;
                cl.useHeading3 = true;
                cl.Heading3 = "Itemwise Purchasing Report from " + dateEdit1.DateTime.ToString("dd-MM-yyyy") + " to " + dateEdit2.DateTime.ToString("dd-MM-yyyy");
                cl.Footer1 = "Total Qty = " + colQTY.SummaryText;
                cl.Footer2 = "Total Bonus =" + colBONUSQTY.SummaryText;
                cl.DoPrint(gridControl1);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ItemLookUp();
        }
        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textEdit2.EditValue==null)
                 ItemLookUp();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //PURINVID
            if (gridView1.FocusedRowHandle >= 0)
            {
                var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    var f = new NewPurInv();
                    f.ShowHoldList = false;
                    f.Purid = dr["PURINVID"].ToString();
                    f.DoView();
                    f.ShowDialog();
                }
            }
        }
    }
}