using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraTab;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Transfers;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class TransferList : XtraForm
    {
        public event LoadForm LoadInMainWindow;
        public bool _usemultistore = false;
        string[] connew = Utils.Connectionstring.Split(';');
        private string cmpname = Utils.Companyname;
        private string _compcode = Utils.Company;
        private string _localconstr = "";
        public TransferList()
        {InitializeComponent();}
        private void TransferList_Load(object sender, EventArgs e)
        {
            d1.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            d2.EditValue = DateTime.Now.Date;
            CreateUnboundColumn();
            if(!_usemultistore)
                LoadData();
            if (_usemultistore)
            {
                simpleButton1.Visible = false;
                labelControl3.Visible = true;
                lookUpEdit1.Visible = true;
              //  var dt = COMMON.ClsGetData.GetStoresDataBases();
                sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames();
            }
        }private void CreateUnboundColumn()
        {
            GridColumn col = gridView1.Columns.AddField("Total C.Price");

            col.FieldName = "TotCprice";
            col.Caption = "Total C.Price";

            col.SummaryItem.DisplayFormat = "{0:N2}";

            col.UnboundType = UnboundColumnType.Decimal;


            col.DisplayFormat.FormatType = FormatType.Numeric;

            col.DisplayFormat.FormatString = "N2";
            col.OptionsColumn.AllowEdit = false;
            col.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            col.DisplayFormat.FormatType = FormatType.Numeric;
            col.SummaryItem.SummaryType  = SummaryItemType.Sum;
            col.VisibleIndex = 4;

            GridColumn col1 = gridView2.Columns.AddField("Total C.Price");
            col1.UnboundType = UnboundColumnType.Decimal;
            col1.DisplayFormat.FormatType = FormatType.Numeric;
            col1.DisplayFormat.FormatString = "N2";
            col1.SummaryItem.DisplayFormat = "{0:N2}";
            col1.FieldName = "TotCprice1";
            col1.Caption = "Total C.Price";

            col1.OptionsColumn.AllowEdit = false;
            col1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            col1.SummaryItem.SummaryType = SummaryItemType.Sum;

            col1.VisibleIndex = 4;

        }
        void LoadData()
        {
            Application.DoEvents();
            try
            {
                progressPanel1.Visible = true;
                var dsTrasfer = ClsGetData.ItemTranferMainListForHist(true, d1.DateTime, d2.DateTime,
                    _usemultistore, _localconstr, _compcode);
                var dsRecv = ClsGetData.ItemTranferMainListForHist(false, d1.DateTime, d2.DateTime,
                    _usemultistore, _localconstr, _compcode);
                gridControl1.DataSource = dsTrasfer;
                gridControl2.DataSource = dsRecv;

                var dsTrasnferDet = ClsGetData.GetInventoryTransferDetails(true, d1.DateTime, d2.DateTime,
                    _compcode, _usemultistore, _localconstr);

                var dsRecvDet = ClsGetData.GetInventoryTransferDetails(false, d1.DateTime, d2.DateTime, _compcode,
                    _usemultistore, _localconstr);

                gridControl4.DataSource = dsTrasnferDet;

                gridControl3.DataSource = dsRecvDet;

                progressPanel1.Visible = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressPanel1.Visible = false;
  
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                LoadTransDetails(dr[0].ToString());
            }
        }
        void LoadTransDetails(string tranid,bool useo=false,string othercon="P")
        {
            //ItemMove f = new ItemMove();
            //f._tranid = tranid;
            
            //f.Show();
            //f.DoView(true);
            if (lookUpEdit1.EditValue != null)
            {
                othercon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit1.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                useo = true;
            }
            LoadInMainWindow(0, tranid, useo, othercon);

            //f.WindowState = FormWindowState.Normal;
            //f.StartPosition = FormStartPosition.CenterScreen;
        }
        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.FocusedRowHandle >= 0)
            {
                var dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
               
                    LoadTransDetails(dr[0].ToString());
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadInMainWindow(0, string.Empty,false,"P");
            //var f = new ItemMove();
            //f.Show();
            //LoadData();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void simpleButton3_Click(object sender, EventArgs e)
         {
             var bl = new GridPrintingClass();
             if (xtraTabControl1.SelectedTabPageIndex == 0)
             {
                 bl.Heading1 = cmpname;
                 bl.Heading2 = "Out going inventory report From :'" + d1.DateTime.Date.ToString("dd-MMM-yy") + "' To : '" + d2.DateTime.Date.ToString("dd-MMM-yy") +
                               "'";
                 bl.DoPrint(gridControl1);
             }
             if (xtraTabControl1.SelectedTabPageIndex == 1)
             {
                 bl.Heading1 = cmpname;
                 bl.Heading2 = "Incomming inventory report From :'" + d1.DateTime.Date.ToString("dd-MMM-yy") + "' To : '" + d2.DateTime.Date.ToString("dd-MMM-yy") +
                               "'";
                 bl.DoPrint(gridControl2);
             }
             if (xtraTabControl1.SelectedTabPageIndex == 2)
             {
                 bl.Heading1 = cmpname;
                 bl.Heading2 = "Out going inventory details report From :'" + d1.DateTime.Date.ToString("dd-MMM-yy") + "' To : '" + d2.DateTime.Date.ToString("dd-MMM-yy") +
                               "'";
                 bl.DoPrint(gridControl3,true);
             }
             if (xtraTabControl1.SelectedTabPageIndex == 3)
             {
                 bl.Heading1 = cmpname;
                 bl.Heading2 = "Incomming inventory details report From :'" + d1.DateTime.Date.ToString("dd-MMM-yy") + "' To : '" + d2.DateTime.Date.ToString("dd-MMM-yy") +
                               "'";
                 bl.DoPrint(gridControl4, true);
             }    
         }
        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = GetCost(e.Row);
           
            //if (e.IsSetData)
            //    _Cache.SetValue(e.Row, e.Value);
        }
        private decimal GetCost(object p)
        {
            decimal retval = 0m;
            try
            
            {
            var d = (DataRowView)p;
            retval= new ItemMoveDataManager().GetTranferCostValue(d[0].ToString(),_usemultistore,_localconstr);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
            return retval;
        }
        private void xtraTabControl1_Selected(object sender, TabPageEventArgs e)
        {
            if (e.PageIndex == 1)
            {
                gridView2.Columns["TotCprice1"].VisibleIndex = 5;
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  var dt = new VIRETAILDAL.Masters.Company().GetCompanies(false, true, comboBoxEdit1.EditValue.ToString());
          //  cmpname = dt[0][1].ToString();
          //  _compcode = dt[0]["CCODE"].ToString();
          ////  _localconstr = connew[0] + ";" + "Initial Catalog =" + comboBoxEdit1.EditValue + ";" + connew[2] + ";";
          //  _localconstr = connew[0] + ";" + "Initial Catalog =" + comboBoxEdit1.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[3] + ";";
        }
        private void gridView2_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = GetCost(e.Row);
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            _localconstr = connew[0] + ";" + "Initial Catalog =" + lookUpEdit1.EditValue + ";" + connew[2] +";" + connew[3] + ";" + connew[4] + ";";

            var dt = new Company().GetCompanies(false, true, _localconstr);
            cmpname = dt[0][1].ToString();
           _compcode = dt[0]["CCODE"].ToString();
            LoadData();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void d1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void d2_EditValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}