using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class ConsolidatedInventory : XtraForm
    {
      // DataTable dt = new DataTable();
        DsReports.CONSOLIDATEINVENTORYDataTable dtcon = new DsReports().CONSOLIDATEINVENTORY;
        private bool boolprno = true;
        public ConsolidatedInventory()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        void LoadCombos()
        {
            sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames();

            
            //foreach (DataRow dr in dt.Rows)
            //{
            //    checkedComboBoxEdit1.Properties.Items.Add(dr[0], CheckState.Checked, true);
            //    //.SetEditValue(dr[0]);
            //}
           // iTEMGROUPBindingSource.DataSource = COMMON.ClsGetData.GetItemGroup();
            dsMaster1.Merge(ClsGetData.GetItemGroup());
            dsMaster1.Merge(ClsGetData.GetSupplier());
           // LookupSupplier.Properties.DataSource = COMMON.ClsGetData.GetSupplier();
            dsMaster1.Merge(ClsGetData.GetItemMastList());
           // iTEMMASTBindingSource.DataSource = COMMON.ClsGetData.GetItemMastList();
        }
        private void ConsolidatedInventory_Load(object sender, EventArgs e)
        {
            LoadCombos();
            gridControl1.UseEmbeddedNavigator = true;
            comboBoxEdit1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now.Date;
            dtcon = ClsGetData.GetConsolidateinventoryDataTable();
            cONSOLIDATEINVENTORYBindingSource.DataSource = dtcon;
            if (cONSOLIDATEINVENTORYBindingSource.Count > 0)
            {
                 simpleButton4.Text = "Re-Create";
                var storecnt = dtcon[0]["COLNAMES"].ToString().Split(',');
                SetGridVisibleIndex(storecnt);
                //int i = 6;
                //foreach (var s in storecnt)
                //{
                //    gridView1.Columns[i + 4].VisibleIndex = i;
                //    gridView1.Columns[i + 4].Visible = true;
                //    gridView1.Columns[i + 4].Caption = s;
                //    i++;
                //}
                dateTimePicker1.Value = Convert.ToDateTime(dtcon[0]["RUNDATE"].ToString());

            }
            dsPurchase1.Merge(new PrDataManager().GetPurchaseRequestList(null, true));
        }
        void KeyF10()
        {
            this.InvokeEx((lv => AddItems())); ;
        }
        private void  AddItems()
        {

            var frm = new FrmItemLookUp();
            frm.EventSelectedItem += AdditemsToList;
            frm.closeonselect = true;
            if (txtbarcode.EditValue != null)
                frm.filtertext = txtbarcode.EditValue.ToString();
            frm.ShowDialog();
        }
        void AdditemsToList(object sender, GetDataRowEventArgs g)
        {
            var current = g.SelectedRow;
            txtbarcode.Text = current["ITEMNO"].ToString();
        }
        private void ConsolidatedInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F10)
                KeyF10();
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
            string clnm = string.Empty;
            ClsGetData.DelConsolidateinventoryDataTable();

            dtcon = ClsGetData.GetConsolidateinventoryDataTable();
            cONSOLIDATEINVENTORYBindingSource.DataSource = dtcon;
            gridControl1.ResetBindings();

            var storecnt = checkedComboBoxEdit1.Properties.GetCheckedItems().ToString().Split(',');
            clnm = GetStorenames(storecnt);
            SetGridVisibleIndex(storecnt);
            //colPRGEN.VisibleIndex = 0;
            //colItemname.VisibleIndex = 1;
            //colItemno.VisibleIndex = 2;
            //colbarcode.VisibleIndex = 3;
            //colTOTAL.VisibleIndex = 4;
            //colPURQTY.VisibleIndex = 5;
             
            
            //foreach (var s in storecnt)
            //{
            //    clnm += s + ",";
            //    gridView1.Columns[i+4].VisibleIndex = i;
            //    gridView1.Columns[i+4].Visible = true;
            //    gridView1.Columns[i+4].Caption = s;
            //    i++;
            //}
            var i = 0;
            DsReports.ITEMLISTFORCONSOLIDATEINVDataTable dsitems = null;
            if (lookUpEdit2.EditValue == null && txtbarcode.EditValue == null && LookupSupplier.EditValue ==null)
            {
                dsitems = ClsGetData.ItemListForConsolidateInv(0,string.Empty);
            }
            if (comboBoxEdit1.SelectedIndex == 0 && lookUpEdit2.EditValue!=null)
            {
                dsitems = ClsGetData.ItemListForConsolidateInv(1,lookUpEdit2.EditValue.ToString());
            }
            if (comboBoxEdit1.SelectedIndex == 1 && txtbarcode.EditValue != null)
            {
                dsitems = ClsGetData.ItemListForConsolidateInv(2, txtbarcode.Text);
            }
            if (comboBoxEdit1.SelectedIndex == 2 && LookupSupplier.EditValue != null)
            {
                dsitems = ClsGetData.ItemListForConsolidateInv(3, txtbarcode.Text);
            }
            repositoryItemProgressBar1.Maximum = dsitems.Count;

            int k = 1;
            var connew = Utils.Connectionstring.Split(';');
            var bl = new StockMaster();
            
            if (dsitems != null)
                foreach (DsReports.ITEMLISTFORCONSOLIDATEINVRow  d in dsitems.Rows)
                {
                    progressBar1.EditValue = k;
                    Application.DoEvents();

                    k++;
                    i = 10;
                    var dr =(DsReports.CONSOLIDATEINVENTORYRow) dtcon.NewRow();
                    if(!d.IsSUPPLIERNAMENull())
                     dr.Suppliername = d.SUPPLIERNAME;
                    else
                    {
                        dr.Suppliername = "---";
                    }
                    dr.Itemname = d.ITEMNAME;
                    dr.Itemno = d.ITEMNO;

                    dr.ItemCategory = d.GROUPNAME;
                    dr.barcode = d.BARCODE;
                    dr.PURQTY = 0;
                    dr.RUNDATE = DateTime.Now.Date;
                    dr.PRGEN = false; 
                    dr.COLNAMES = clnm;
                    var toqty = 0;
                    foreach (string ss in storecnt)
                    {
                        var str = connew[0] + ";" + "Initial Catalog =" + ss + ";" + connew[2] + ";"   + connew[3] + ";" + connew[4] + ";";
                        var qty = bl.GetAvailableQty(d.ITEMNO, str, true);
                        toqty += qty;
                        dr[i] = qty;
                        dr.TOTAL = toqty;
                        i++;
                    }
                    dtcon.Rows.Add(dr);
                }
            cONSOLIDATEINVENTORYBindingSource.DataSource = dtcon;
           // COMMON.ClsGetData.SaveCosolidateInventoryRun(dtcon); 
        }
        private void ConsolidatedInventory_Resize(object sender, EventArgs e)
        {
            //progressBar1.Left = (Left - progressBar1.Left)/2;
        }
        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        
        }
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 1)
            {
                txtbarcode.Visible = true;
                txtbarcode.Left = lookUpEdit2.Left;
                txtbarcode.Width = lookUpEdit2.Width;
                lookUpEdit2.Visible = false;
                KeyF10();
            }
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                lookUpEdit2.Visible = true;
                LookupSupplier.Visible = false;
                txtbarcode.Visible = false;
            }
            if(comboBoxEdit1.SelectedIndex==2)
            {
                lookUpEdit2.Visible = true;
                txtbarcode.Visible = false;
                LookupSupplier.Visible = true;
                LookupSupplier.Left = lookUpEdit2.Left;
                LookupSupplier.Width = lookUpEdit2.Width;
            }
        }
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView1.CollapseAllDetails();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
             ClsGetData.SaveCosolidateInventoryRun(dtcon); 
        }
        private void ConsolidatedInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClsGetData.SaveCosolidateInventoryRun(dtcon);
            if (dsPurchase1.PURCHASEREQUEST.HasErrors)
            {
                if (
                    XtraMessageBox.Show("Purchase request not saved do you want to save", "POS", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DoPurchaseSave();
                }
            }
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
        void SetGridVisibleIndex(string[] sname)
        {
            colPRGEN.VisibleIndex = 0;
            colItemname.VisibleIndex = 1;
            colItemno.VisibleIndex = 2;
            colbarcode.VisibleIndex = 3;
            colTOTAL.VisibleIndex = 4;
            colPURQTY.VisibleIndex = 5;
            int i = 6;

            foreach (var s in sname)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    gridView1.Columns[i + 4].VisibleIndex = i;
                    gridView1.Columns[i + 4].Visible = true;
                    gridView1.Columns[i + 4].Caption = s.IndexOf("BACKUP") > 0
                        ? s.Remove(s.IndexOf("BACKUP"), "BACKUP".Length)
                        : s;
                    //if (s.ToString().Length > 4)
                    //{
                    //    gridView1.Columns[i + 4].Caption = s.Trim().Substring(0,5);
                    //}
                    //else
                    //{
                    //    gridView1.Columns[i + 4].Caption = s;

                    //}
                }
                i++;
            }
        }
        string GetStorenames(string[] sname)
        {
            return sname.Aggregate(string.Empty, (current, s) => current + (s + ","));
        }
        void LoadGrid(DataRow dr1)
        {
            if (boolprno )
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
            dr["SUPPLIERNO"] = Suppliername(dr1["Suppliername"].ToString());
            dr["ITEMNO"] = dr1["Itemno"];
            if (!string.IsNullOrEmpty(dr1["PURQTY"].ToString()))
            {
                if (int.Parse(dr1["PURQTY"].ToString()) ==0)
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
        string Suppliername(string supname)
        {
            string retval = string.Empty;
            foreach (DataRow dr in dsMaster1.SUPPLIER  )
            {
                if (supname == dr[1].ToString())
                    retval = dr[0].ToString();
            }
            return retval;
        }
        void DoPurchaseSave()
         {
                var dm = new PrDataManager {Purchaserequest = dsPurchase1.PURCHASEREQUEST};
                var changes = (DsPurchase.PURCHASEREQUESTDataTable)dsPurchase1.PURCHASEREQUEST.GetChanges();
                var retval =   dm.DoSave();
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
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            var cl = new GridPrintingClass();
            cl.Heading1 = "Purchase Request List";
            cl.DoPrint(gridControl2);

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var c= new GridPrintingClass();
            //dd-MMM-yy

            c.Heading1 = "Consolidated Inventory Report for " + checkedComboBoxEdit1.Properties.GetCheckedItems();
            c.DoPrint(gridControl1);
            //cl.DoPivoitPrint(pivotGridControl1);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

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