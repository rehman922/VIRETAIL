using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.Purchasing;
using VIRETAILDAL.Transfers;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class ItemDownLoad : XtraForm
    {
        private DsInventory _ds = new DsInventory();
        private DsInventory.STOCKMASTERDataTable _negativestockmaster  = new DsInventory.STOCKMASTERDataTable();
        private string whid = null;
        private string storecode = null;
        private string tranids = string.Empty;
        private DsReports.DataDownLoadsDataTable _dsdownload = new DsReports().DataDownLoads;
        public ItemDownLoad()
        {
            InitializeComponent();
        }
        private List<string> GetFiles()
        {
            string[] _files = {};
            List<string> files = new List<string>();
            List<string> drives = new List<string>(); //Environment.GetLogicalDrives();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady)
                {
                    drives.Add(d.Name);
                }
            }
            foreach (string strDrive in drives)
            {
                _files = Directory.GetFiles(strDrive, "*.pml");
                foreach (string f in _files)
                {
                    files.Add(f);
                }
            }
            return files;
        }
        private void DoBrowse()
        {
            tranids = string.Empty;
            progressPanel1.Visible = true;
            Application.DoEvents();
            _dsdownload.Clear();
            var files = GetFiles();
            if (files.Count == 0)
            {
                XtraMessageBox.Show("File not found", "POS", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Information);
                return;
            }
            foreach (string strDrive in files)
            {
                var s = strDrive.Split('-');
                if (s[0].IndexOf(Utils.Company) == -1)
                {
                    try
                    {
                        _ds.Clear();
                        _ds.ReadXml(strDrive);
                        if (_ds.ITEMTRANSFERMAIN.Rows.Count == 0 && _ds.GetItemsForRemoteUpdate.Rows.Count == 0 &&
                            _ds.SUPPLIER.Rows.Count == 0)
                        {
                            var dr = _dsdownload.NewRow();
                            dr[0] = strDrive;
                            dr[1] = DateTime.Now.Date;
                            dr[3] = "Nothing to download";
                            _dsdownload.Rows.Add(dr);
                        }
                        else
                        {
                            DoStartPusingData();
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK,
                                                                   MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool DoStartPusingData(bool downall = false)
        {
            if (_ds.ITEMTRANSFERMAIN.Rows.Count > 0)
            {
                bool retval = false;
                var frms = _ds.ITEMTRANSFERMAIN[0]["FRMSTOREID"];
                var ts = _ds.ITEMTRANSFERMAIN[0]["TOSTOREID"];
                lookupfrom.EditValue = frms;
                lookupto.EditValue = ts;
                memoEdit1.EditValue = _ds.ITEMTRANSFERMAIN[0]["NOTE"].ToString();
                DoSave(downall);
                progressPanel1.Visible = false;
                dockPanel1.Show();
                dockPanel1.Visibility = DockVisibility.Visible;
                if (!string.IsNullOrEmpty(tranids))
                {
                   // var tadet = new ITEMTRANSFERDETAILTableAdapter();
                   // tadet.FillByTranid(_ds.ITEMTRANSFERDETAIL, tranids);gridControl1.DataSource = _ds.ITEMTRANSFERDETAIL;
                    gridControl1.DataSource = ClsGetData.TranferItemListWithItemname(tranids);
                }
            }
            else
            {
                XtraMessageBox.Show("Nothing to download", "POS", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Information);
               progressPanel1.Visible = false;
               return false;
            }
            return true;
        }
        private void ItemDownLoad_Load(object sender, EventArgs e)
        {
           // repositoryItemLookUpEdit1.DataSource = ClsGetData.GetItemMast1List();
            var dsW = ClsGetData.GetStoreList();
            lookupfrom.Properties.DataSource = dsW;
            lookupto.Properties.DataSource = dsW;
            barEditItem1.EditValue = "Remote server";
            gridControl2.DataSource = _dsdownload;
        }
        private void DoSave(bool downall = false)
        {
            if (lookupto.GetColumnValue("COMPANY").ToString() != Utils.Company)
            {
                var dr = _dsdownload.NewRow();
                dr[0] = _ds.ITEMTRANSFERMAIN[0]["TRANID"].ToString();
                dr[1] = _ds.ITEMTRANSFERMAIN[0]["TRANDATE"].ToString();
                dr[2] = _ds.ITEMTRANSFERMAIN[0]["FRMNAME"].ToString();
                dr[3] = "File not belongs your store";
                _dsdownload.Rows.Add(dr);
                return;
            }
            btnbrowse.Enabled = false;
            btnsave.Enabled = false;
            var blitemmove = new Blitemmove();
            foreach (DataRow d in _ds.ITEMTRANSFERMAIN.Rows)
            {
                blitemmove.Tranid = d["TRANID"].ToString();
                if (d["TOCOMP"].ToString() != Utils.Company)
                {
                    var dr = _dsdownload.NewRow();
                    //dr[0] = _ds.ITEMTRANSFERMAIN[0]["TRANID"].ToString();
                    //dr[1] = _ds.ITEMTRANSFERMAIN[0]["TRANDATE"].ToString();
                    //dr[2] = _ds.ITEMTRANSFERMAIN[0]["FRMNAME"].ToString();
                    dr[0] = d["TRANID"].ToString();
                    dr[1] = d["TRANDATE"].ToString();
                    dr[2] = d["FRMNAME"].ToString();
                    dr[3] = "File not belongs your store";
                    _dsdownload.Rows.Add(dr);
                }
                else
                {
                    blitemmove.GetItemMoveByTranid();
                    if (blitemmove.Itemtransferdetail.Rows.Count > 0)
                    {
                        var dr = _dsdownload.NewRow();
                        dr[0] = d["TRANID"].ToString();
                        dr[1] = d["TRANDATE"].ToString();
                        dr[2] = d["FRMNAME"].ToString();
                        dr[3] = "File already download";
                        _dsdownload.Rows.Add(dr);
                    }
                    else
                    {
                        var dr = _dsdownload.NewRow();
                        dr[0] = d["TRANID"].ToString();
                        dr[1] = d["TRANDATE"].ToString();
                        dr[2] = d["FRMNAME"].ToString();
                        var bl = new ItemDownLoadDataManager {whid = lookupto.EditValue.ToString()};
                        var retval = bl.DoSave(_ds, dr[0].ToString(), downall);
                        if (retval == "1")
                        {
                            new RemoteSync().UpDateRemoteTransferMain(dr[0].ToString());
                            tranids += dr[0] + ","; //  SetUpdateFlagInServer()
                            dr[3] = "Data Download Sucessfully";
                            if (_negativestockmaster.Rows.Count > 0)
                            {
                                var f = new FrmNegativeStockReplace {GetDsInventory = _negativestockmaster};
                                f.Show();
                            }
                        }
                        else
                        {
                            dr[3] = "Error" + retval;
                            btnbrowse.Enabled = true;
                            btnsave.Enabled = true;
                        }
                        _dsdownload.Rows.Add(dr);
                    }
                }
            }
        }
        private void ItemDownLoad_Resize(object sender, EventArgs e)
        {
            progressPanel1.Left = (Width - progressPanel1.Width)/2;
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Remote Server From File
            if (barEditItem1.EditValue.ToString() == "Remote Server" || barEditItem1.EditValue==null)
            {
                progressPanel1.Visible = true;
                FetchServerData();
                progressPanel1.Visible = false;
            }
            if (barEditItem1.EditValue.ToString() == "From File")
            {
                DoBrowse();
            }
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoSave();
        }
        private void FetchServerData()
        {
            tranids = string.Empty;
            progressPanel1.Visible = true;
            Application.DoEvents();
           _dsdownload.Clear();
           string cnstr = new SqlAsyncConnectionString(6, true);
       //  string _syncConstr = new SqlAsyncConnectionString(6, true);
           if (Utils.Company == "01" || Utils.Company == "00")
           {
               cnstr = Utils.ConnectionstringSync;//_constr = VIRETAILDAL.COMMON.Utils.Connectionstring;
           }
           var bl = new ItemDownLoadDataManager();
            try
            {
                string maxtran = new Blitemmove().GetMaxTranid();
               _negativestockmaster = bl.GetNegativeStock();

                bl.GetServerData(ref _ds, cnstr, maxtran);
                if (DoStartPusingData(true))
                {
                   ////////new RemoteSync().UpDateRemoteTransferMain(_ds.ITEMTRANSFERMAIN);
                   XtraMessageBox.Show("Down load finish", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        private void NewFetchServerData()
        {
            
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                var bl = new GridPrintingClass();
                bl.Heading1 = Utils.CompanyAddress;
                bl.Heading1 = "Stock Receving Report";
                bl.DoPrint(gridControl1);
               // gridView1.ShowPrintPreview();
            }
        }
        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            hideContainerTop.Visible = true;
            var ds = ClsGetData.ItemTranferMainListForHist();
            gridControl3.DataSource = ds;
            hideContainerTop.Dock=DockStyle.Top;
            dockPanel4.Refresh();
            dockPanel4.Show();
            dockPanel4.Visibility = DockVisibility.Visible;
        }
        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {
            if (gridView3.FocusedRowHandle >= 0)
            {
                var dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
      
                gridControl1.DataSource = ClsGetData.TranferItemListWithItemname(dr[0].ToString());
            }
        }
        private void hideContainerTop_Click(object sender, EventArgs e)
        {}
        void GetPromotions()
        {
            //select the promotions from Sync database

        }
    }
}
    
