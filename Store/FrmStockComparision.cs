using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class FrmStockComparision : XtraForm
    {
        private bool boolprno = true;
        public FrmStockComparision()
        {
            InitializeComponent();
        }
        void LoadCombos()
        {
            sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames();

            dsMaster1.Merge(ClsGetData.GetItemGroup());
            dsMaster1.Merge(ClsGetData.GetSupplier());
            dsMaster1.Merge(ClsGetData.GetItemMastList());
        }
        private void FrmStockComparision_Load(object sender, EventArgs e)
        {
            LoadCombos();
        }

        private void FrmStockComparision_KeyDown(object sender, KeyEventArgs e)
        {
       
            if (e.KeyCode == Keys.F8)
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    var frm = new Puranalyse(dr["itemno"].ToString(), dr["itemname"].ToString());
                    frm.Show();
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
             string qry ="";
            if (lookUpEdit1.EditValue == null || lookUpEdit2.EditValue == null)
            {
                MessageBox.Show("Please select the from store and compare store", "Stock compare", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (lookUpEdit1.EditValue != null && lookUpEdit2.EditValue != null)
            {
                if (lookUpEdit1.EditValue == lookUpEdit2.EditValue)
                {
                    MessageBox.Show("Please select the different stores to compare the store", "Stock compare", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    return;  
                }
            }
            var connew = Utils.Connectionstring.Split(';');

            
                qry =
                    "SELECT     SUM(dbo.STOCKMASTER.QTY) AS Qty , dbo.ITEMMAST.ITEMNO, dbo.ITEMMAST.BARCODE, dbo.ITEMMAST.ITEMNAME, dbo.ITEMGROUP.GROUPNAME,";
                qry += " dbo.SUPPLIER.SUPPLIERNAME , dbo.SUPPLIER.SUPPLIERNO FROM         dbo.ITEMMAST INNER JOIN ";
                qry += " dbo.SUPPLIER ON dbo.ITEMMAST.SUPPLIERNO = dbo.SUPPLIER.SUPPLIERNO INNER JOIN ";
                qry += " dbo.STOCKMASTER ON dbo.ITEMMAST.ITEMNO = dbo.STOCKMASTER.ITEMNO INNER JOIN ";
                qry += " dbo.ITEMGROUP ON dbo.ITEMMAST.GROUPID = dbo.ITEMGROUP.GROUPID ";
                qry += " WHERE dbo.STOCKMASTER.QTY > 0  AND dbo.ITEMMAST.ITEMNO NOT IN( ";
                qry += " SELECT ITEMNO FROM " + lookUpEdit2.EditValue +
                       ".DBO.STOCKMASTER WHERE dbo.STOCKMASTER.QTY > 0) ";
                qry +=
                    " GROUP BY dbo.ITEMMAST.ITEMNO, dbo.ITEMMAST.BARCODE, dbo.ITEMMAST.ITEMNAME, dbo.ITEMGROUP.GROUPNAME,dbo.SUPPLIER.SUPPLIERNAME , dbo.SUPPLIER.SUPPLIERNO ";
                qry += " order by groupname,itemname asc ";

                var strcon = connew[0] + ";" + "Initial Catalog =" + lookUpEdit1.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";

            var cn = new SqlConnection(strcon);
            var ds = new DataTable("");
            cn.Open();
            var ta = new SqlDataAdapter(qry, cn);
            ta.Fill(ds);
            gridControl1.DataSource = ds;
            gridControl1.ResetBindings();



        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView1.CollapseAllDetails();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var c = new GridPrintingClass();
            //dd-MMM-yy

            c.Heading1 = "Stock Comparision Inventory Report from Store " + lookUpEdit1.SelectedText + " To Store " + lookUpEdit2.SelectedText  ;
            c.DoPrint(gridControl1);
        }
        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.PostEditor();
            var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//gridView1.PostEditor();
            if (bool.Parse(dr["PRGEN"].ToString()))
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colPRGEN, true);
                LoadGrid(dr);
            }
            else
            {
                if (XtraMessageBox.Show("Already in list do you want remove", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteFromList(dr[0].ToString());
                }
            }
        }
        void LoadGrid(DataRow dr1)
        {
            if (boolprno)
            {
                var dm = new DataManager();
                int auto = dm.GetAutoId(16);
                dm.UpdateAutoNum(16);
                auto++;
                prno = dm.CreateFormatedAutoNo(auto);
                boolprno = false;

            }
            var dr = dsPurchase1.PURCHASEREQUEST.NewRow();
            dr["PRNO"] = prno;
            dr["COMPANY"] = Utils.Company;
            dr["SUPPLIERNO"] = dr1["SUPPLIERNO"].ToString();
            dr["ITEMNO"] = dr1["Itemno"];
            if (!string.IsNullOrEmpty(dr1["PURQTY"].ToString()))
            {
                if (int.Parse(dr1["PURQTY"].ToString()) == 0)
                    dr["QTY"] = 1;
                else
                    dr["QTY"] = dr1["PURQTY"];
            }
            else
            {
                dr["QTY"] = 1;
            }
            dr["USERID"] = Utils.Userid;
            dr["INORDER"] = 0;
            dsPurchase1.PURCHASEREQUEST.Rows.Add(dr);

        }
        void DeleteFromList(string itemno)
        {
            foreach (DataRow dr in dsPurchase1.PURCHASEREQUEST.Rows)
            {
                if (itemno == dr["itemno"].ToString())
                {
                    dr.Delete();
                    return;
                }
            }
        }
        string prno = string.Empty;

        void DoPurchaseSave()
        {
            var dm = new PrDataManager { Purchaserequest = dsPurchase1.PURCHASEREQUEST };
            var changes = (DsPurchase.PURCHASEREQUESTDataTable)dsPurchase1.PURCHASEREQUEST.GetChanges();
            var retval = dm.DoSave();
            if (retval == "1")
            {
                XtraMessageBox.Show("Purchase request created", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var addedRows = from row in dsPurchase1.PURINVDETAIL
                                where row.RowState == DataRowState.Added
                                select row;
                foreach (var row in addedRows.ToArray())
                {
                    row.Delete();
                }
                //dsPurchase1.PURCHASEREQUEST.Merge(dm.GetPurchaseRequest(prno));
                if (changes != null) dsPurchase1.Merge(changes);
                dsPurchase1.AcceptChanges();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoPurchaseSave();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            var cl = new GridPrintingClass();
            cl.Heading1 = "Purchase Request List";
            cl.DoPrint(gridControl2);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                var frm = new Puranalyse(dr["itemno"].ToString(), dr["itemname"].ToString());
                frm.Show();
            }
        }

    }

}