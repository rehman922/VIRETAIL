using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;

namespace Store
{
    public partial class PurchaseRequestList : Form
    {
        public PurchaseRequestList()
        {
            InitializeComponent();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var cl = new GridPrintingClass();
            //cl.Heading1 = Utils.Companyname;
            //cl.Heading2 = "Purchase Request List";
            //cl.DoPrint(gridControl1);
          //  gridView1.ShowPrintPreview();

            var bl = new GridPrintingClass();
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                 bl.Heading2 = "Material Request :'" + d1.DateTime.Date.ToString("dd-MMM-yy") + "' To : '" + d2.DateTime.Date.ToString("dd-MMM-yy") +
                              "'";
                bl.DoPrint(gridControl1);
            }
            if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                 bl.Heading2 = "Scheduled Material Request  From :'" + d1.DateTime.Date.ToString("dd-MMM-yy") + "' To : '" + d2.DateTime.Date.ToString("dd-MMM-yy") +
                              "'";
                bl.DoPrint(gridControl2);
            }
            if (xtraTabControl1.SelectedTabPageIndex == 2)
            {
                 bl.Heading2 = "Issued against Material Request From :'" + d1.DateTime.Date.ToString("dd-MMM-yy") + "' To : '" + d2.DateTime.Date.ToString("dd-MMM-yy") +
                              "'";
                bl.DoPrint(gridControl3, true);
            }


        }
        public void LoadPurchaseData(string ccode=null)
        {
            dsPurchase1.Merge(new PrDataManager().GetPurchaseRequestList(ccode));
           // pURCHASEREQUESTBindingSource.DataSource = ;
        }
        public void LoadPurhcaseDataNotInPr()
        {
            dsPurchase1.Merge(new PrDataManager().GetPurchaseRequestList(null,true));
        }
        private void PurchaseRequestList_Load(object sender, EventArgs e)
        {
             d1.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
             d2.EditValue = DateTime.Now.Date;
             BindingSource bsW = new BindingSource();
             var dsW = ClsGetData.GetAllSalesStore();
             bsW = new BindingSource(dsW, "") { Filter = "COMPANY <> '" + VIRETAILDAL.COMMON.Utils.Company + "'" };
             lookUpEdit1.Properties.DataSource = bsW;

              sTOREMASTBindingSource.DataSource = ClsGetData.GetStoreList();
              this.InvokeEx(x => LoadData());
        }
        void LoadData()
        {
            uSERINFOBindingSource.DataSource  = ClsGetData.GetUserInfo();
            iTEMMASTBindingSource.DataSource = ClsGetData.GetItemMast1List();
          //  sUPPLIERBindingSource.DataSource = ClsGetData.GetSupplier();
          // cOMPANYBindingSource.DataSource = ClsGetData.GetCompanies();
            var d  = new PrDataManager().GetPurchaseRequestAll(d1.DateTime,d2.DateTime);
            SetGrid1(d,0);
            SetGrid1(d,1);
            SetGrid1(d,2);
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new PurchaseOrder();
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            f.GeneratePOFrmPR(dsPurchase1.PURCHASEREQUEST);
            var dm = new PrDataManager { Purchaserequest = dsPurchase1.PURCHASEREQUEST };
            var changes = (DsPurchase.PURCHASEREQUESTDataTable)dsPurchase1.PURCHASEREQUEST.GetChanges();
            var retval = dm.DoSave();
            if (retval == "1")
            {
                var addedRows = from row in dsPurchase1.PURINVDETAIL
                                where row.RowState == DataRowState.Added
                                select row;
                foreach (var row in addedRows.ToArray())
                {
                    row.Delete();
                }
                if (changes != null) dsPurchase1.Merge(changes);
                dsPurchase1.AcceptChanges();
            }
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            foreach (DsPurchase.PURCHASEREQUESTRow dr in dsPurchase1.PURCHASEREQUEST)
            {
                if (!dr.IsISSUEDNull())
                {
                    if (dr.ISSUED > 0)
                    {
                        dr.UPLOAD = true;
                      //  dr.INORDER = true;
                    }
                }
            }
            var dm = new PrDataManager { Purchaserequest = dsPurchase1.PURCHASEREQUEST };
            var changes = (DsPurchase.PURCHASEREQUESTDataTable)dsPurchase1.PURCHASEREQUEST.GetChanges();
            var retval = dm.DoSave();
            if (retval == "1")
            {
                SetData(); 
                //var addedRows = from row in dsPurchase1.PURCHASEREQUEST
                //                where row.RowState == DataRowState.Added
                //                select row;
                //foreach (var row in addedRows.ToArray())
                //{
                //    row.Delete();
                //}
                //if (changes != null) dsPurchase1.Merge(changes);
                //dsPurchase1.AcceptChanges();
            }

           // dsPurchase1.Merge(new PrDataManager().GetPurchaseRequestList());
          //  var f = new ItemMove();
          // f.CreateItemMoveFrmPr(dsPurchase1.PURCHASEREQUEST, lookupfrom.EditValue.ToString());
           // f.Show();
        }
        private void lookupfrom_EditValueChanged(object sender, EventArgs e)
        {
          //dsPurchase1.Merge(new PrDataManager().GetPurchaseRequestList(lookupfrom.EditValue.ToString()));
            var ds = new PrDataManager().GetPurchaseRequestAll(d1.DateTime,d2.DateTime);


            //var t = ds.Select("isnull(issued ,0) = 0 and isnull(upload ,0)=0");
            //pURCHASEREQUESTBindingSource.DataSource = t;
            //var t1 = ds.Select("isnull(issued ,0) > 0 and isnull(upload ,0)=0");
            //pURCHASEREQUESTBindingSource.DataSource = t1;
           // var m1 = ds.Clone();
            // var d1 = from r1 in m1 where r1.ISSUED == 0 && r1.UPLOAD == false select r1 ;
            //pURCHASEREQUESTBindingSource1.DataSource = d1.CopyToDataTable();




        }
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (gridView1.FocusedColumn == ColIssued)
            {
                e.Cancel = GetInorderStatus(int.Parse(dr["TID"].ToString()));
                //if (dr["INORDER"].ToString() == bool.TrueString)
                //{
                //    e.Cancel = true;
                //}
            }
        }
        bool GetInorderStatus(int tid)
        {
          return new PrDataManager().GetInorderStatus(tid);
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SetData();
        }
        void SetData()
        {
            DsPurchase.PURCHASEREQUESTDataTable ds;
            if (lookUpEdit1.EditValue != null)
            {
                ds = new PrDataManager().GetPurchaseRequestAll(d1.DateTime, d2.DateTime, lookUpEdit1.EditValue.ToString());
            }
            else
            {
                ds = new PrDataManager().GetPurchaseRequestAll(d1.DateTime, d2.DateTime);
            }
            SetGrid1(ds, 0);
            SetGrid1(ds, 1);
            SetGrid1(ds, 2);
        }
        void SetGrid1(DsPurchase.PURCHASEREQUESTDataTable ds,int option)
        {
           //dsPurchase1.Clear();
            if (option == 0)
            {
                var d = ds.Select("ISSUED = 0 ");// var d = from r in ds where r.ISSUED == 0 && r.UPLOAD == false select r;
                dsPurchase1.Merge(d);
                pURCHASEREQUESTBindingSource.DataSource = dsPurchase1 ;
                pURCHASEREQUESTBindingSource.Filter = "ISSUED = 0 ";
            }
            if (option == 1)
            {
                var d = from r in ds where r.ISSUED > 0 && r.INORDER == false select r;
                pURCHASEREQUESTBindingSource1.DataSource = d.Any() ? d.CopyToDataTable() : null;
            }
            if (option == 2)
            {
                var d = from r in ds where r.INORDER   select r;
                pURCHASEREQUESTBindingSource2.DataSource = d.Any() ? d.CopyToDataTable() : null;
            }
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            DevExpress.XtraGrid.GridControl gc = (DevExpress.XtraGrid.GridControl)sender;

            GridView gv = (GridView)gc.KeyboardFocusView;



            if (!e.Shift && (e.KeyCode == Keys.Tab || e.KeyCode==Keys.Enter) && (gv.FocusedColumn == gv.GetVisibleColumn(gv.VisibleColumns.Count - 1)))
            {

                gv.FocusedColumn = gv.GetVisibleColumn(0);

                if (gv.FocusedRowHandle != gv.RowCount - 1)

                    gv.FocusedRowHandle += 1;
                gv.FocusedColumn = ColIssued;
                gv.ShowEditor();

                e.Handled = true;

            }

            if (e.Shift && (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter) && (gv.FocusedColumn == gv.GetVisibleColumn(0)))
            {

                gv.FocusedColumn = gv.GetVisibleColumn(gv.VisibleColumns.Count - 1);

                if (gv.FocusedRowHandle != 0)

                    gv.FocusedRowHandle -= 1;

                gv.ShowEditor();

                e.Handled = true;

            }
        }
        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            //GridView view = sender as GridView;
            //if (view.FocusedColumn== ColIssued)
            //{
            //    object oldEditValue = (sender as BaseView).ActiveEditor.OldEditValue;
            //    object newEditValue = (sender as BaseView).ActiveEditor.EditValue ?? 0;
            //    if ((int)(newEditValue) < 0)
            //    {
            //        e.Value = oldEditValue;
            //     }
            //}
        }
        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            gridView1.UpdateCurrentRow();

            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                if (e.Column == ColIssued)
                {
                    if (string.IsNullOrEmpty(dr["Issued"].ToString()))
                    {
                        if (int.Parse(dr["Issued"].ToString()) > 0)
                        {
                             
                            if (int.Parse(dr["Issued"].ToString()) > int.Parse(dr["QTY"].ToString()))
                            {
                                dr["Issued"] = dr["QTY"];
                            }
                        }
                    }
                }
            }

        }

    }
}
