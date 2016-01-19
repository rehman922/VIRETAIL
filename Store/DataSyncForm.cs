using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Purchasing;
using VIRETAILDAL.Transfers;
using VIRETAILENTITIES;

namespace Store
{
    public partial class DataSyncForm : RibbonForm
    {
        private DsInventory _ds = new DsInventory();
        private DsReports.DataDownLoadsDataTable _dsdownload = new DsReports().DataDownLoads;
        private string _Purinvids = string.Empty;
        private string _Transids = string.Empty;
        public DataSyncForm()
        {InitializeComponent(); }
        private void DoSync()
        {
            CheckFiles();
        }
        private void CheckFiles()
        {
            var files = Utils.GetFiles();
            if (files.Count != 0)
            { 
                    _ds.Clear();
                    GetDataFromUSB(files);
            }
            else
            {
                GetDataFromNet();
            }
        }
        void GetDataFromNet()
        {
            if (Utils.PingServer())
            {
                DoStartSync();
            }
            else
            {
             XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void GetDataFromUSB(List<String> files)
        {
            var ds = new DsInventory();
            foreach (string strDrive in files)
            {
                var s = strDrive.Split('-');
                if (s[0].IndexOf(VIRETAILDAL.COMMON.Utils.Company, StringComparison.Ordinal) == -1)
                {
                    try
                    {
                         
                        ds.ReadXml(strDrive);
                        if (_ds.ITEMTRANSFERMAIN.Rows.Count == 0 && _ds.GetItemsForRemoteUpdate.Rows.Count == 0 && _ds.SUPPLIER.Rows.Count == 0)
                        {
                            var dr = _dsdownload.NewRow();
                            dr[0] = strDrive;
                            dr[1] = DateTime.Now.Date;
                            dr[3] = "Nothing to download";
                            _dsdownload.Rows.Add(dr);
                        }
                        else
                        {
                            _ds.Merge(ds); 
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
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utils.PingServer())
            {
                DoDownLoadPromotions();
                DoDownLoadCustomers();
                //DoUploadItemsPrices(true);
            }
            else
            {
                XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Settings();
            frm.ShowDialog();
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.DoEvents();
            progressPanel1.Visible = true;
            try
            {
               // if (Utils.PingServer())
               // {
                    var dtw = ClsGetData.GetMyWareHouses();
                    if (dtw.Rows.Count > 0)
                    {
                         progressPanel1.Visible = true;
                         DoUploadPurchases();
                         progressPanel1.Visible = false;
                         progressPanel1.Visible = true;
                         DoUploadPurchaseReturn();
                         progressPanel1.Visible = false;
                         progressPanel1.Visible = true;
                         DoUpLoadSuppliers();
                         progressPanel1.Visible = false;
                         progressPanel1.Visible = true;
                         DoUpLoadPromotions();
                         progressPanel1.Visible = false;
                    }

                    progressPanel1.Visible = true;
                    // if company =01 then no 
                    // uploadPurchaseRequest()
                    if (!Utils.PingServer())
                    {
                        DoUploadMaterialRequest();
                        DoUploadCustomerPoints();
                        DouploadCustomerRedimPoints();
                    }

                    DoUploadItemTransfers();
                    progressPanel1.Visible = false;
                //}
                //else
                //{
                //    XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        //Application.DoEvents();
                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
            progressPanel1.Visible = false;
        }
        void DoStartSync()
        {
            try
            {
                var t = ClsGetData.GetMyWareHouses();
                if (t.Rows.Count > 0)
                {
                    DoUploadPurchases();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DoUploadPurchases()
        {
            txtstatus.Caption = "Uploading Purchases";
            Application.DoEvents();
            try
            {
                var dm = new PurInvDataManager();
                var dt = dm.GetPurchaseInvoiceNotSync();
                var syc = new RemoteSync();
                // GetMasters(dt, true);
                // syc.DoUpLoadItems(_Purinvids, true);
                if (dt.Rows.Count == 0)
                {
                    var drd = _dsdownload.NewRow();
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Purchase Invoice";
                    drd[3] = "Nothing to Upload ";
                    _dsdownload.Rows.Add(drd);
                }
                foreach (DsPurchase.PURINVMAINRow dr in dt.Rows)
                {
                    if (Utils.PingServer())
                    {
                        //syc.DoUpLoadItems(dr.PURINVID, true);

                        var drd1 = _dsdownload.NewRow();
                        var retval = syc.DoUpLoadItems(dr.PURINVID, true);
                        if (retval == "1")
                        {
                            drd1[0] = dr.PURINVID;
                            drd1[1] = DateTime.Now.Date;
                            drd1[2] = "Item Master - Purchase Invoice ";
                            drd1[3] = "Upload ";
                        }
                        else
                        {
                            drd1[0] = dr.PURINVID;
                            drd1[1] = DateTime.Now.Date;
                            drd1[2] = "Item Master  - Purchase Invoice ";
                            drd1[3] = "Error   '" + retval + "'";
                        }
                        _dsdownload.Rows.Add(drd1);
// Purchase invoice
                        var drd = _dsdownload.NewRow();
                        drd[0] = dr.PURINVID;
                        drd[1] = DateTime.Now.Date;
                        drd[2] = "Purchase Invoice";

                        var ret = syc.DoSavePurchaseInvoiceInRemote(dr, dm.GetPurInvDetailsById(dr.PURINVID));
                        if (ret == "1")
                        {
                            dm.UpdatedSyn(dr.PURINVID);
                            drd[3] = "Uploaded";
                        }
                        else
                        {
                            drd[3] = "Error " + ret;
                        }
                        _dsdownload.Rows.Add(drd);
 // Purchase invoice
                    }
                    else
                    {
                        XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
        }
        void DoUploadPurchaseReturn()
        {
            txtstatus.Caption = "Uploading Purchase Return";
            try
            {
                var dm = new PurReturnDataManger();
                var dt = dm.GetPurchaseInvoiceReturnNotSync();
                var syc = new RemoteSync();
                if (dt.Rows.Count == 0)
                {
                    var drd = _dsdownload.NewRow();
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Purchase Return";
                    drd[3] = "Nothing to Upload ";
                    _dsdownload.Rows.Add(drd);
                }

                foreach (DsPurchase.RETURNMASTRow dr in dt.Rows)
                {
                    if (Utils.PingServer())
                    {
                        var drd = _dsdownload.NewRow();
                        drd[0] = dr.RETURNID;
                        drd[1] = DateTime.Now.Date;
                        drd[2] = "Purchase Return";
                        var ret = syc.DoSavePurchaseInvoiceReturnInRemote(dr, dm.GetPurRetInvDetailsById(dr.RETURNID));
                        if (ret == "1")
                        {
                            dm.UpdatedSynReturn(dr.RETURNID);
                            drd[3] = "Uploaded";
                        }
                        else
                        {
                            drd[3] = "Error " + ret;
                        }
                        _dsdownload.Rows.Add(drd);
                    }
                    else
                    {
                        XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void DoUploadItemsPrices(bool upload)
        {
            txtstatus.Caption = "Uploading Sales Price";
            Application.DoEvents();
            try
            {
                var dm = new PromotionPrice() ;
                var dt = upload ? dm.GetDataForDownload() : dm.GetDataForUpload();
                var syc = new RemoteSync();
                if (dt.Rows.Count == 0)
                {
                    var drd = _dsdownload.NewRow();
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Promotion Items";
                    drd[3] = "Nothing to Upload ";
                    _dsdownload.Rows.Add(drd);
                }
                else
                {
                        var drd = _dsdownload.NewRow();
                        drd[1] = DateTime.Now.Date;
                        drd[2] = "Promotion Items";
                        var ret = syc.DoUploadPromotionItems(dt, upload);
                        if (ret == "1")
                        {
                            foreach (DataRow dri in dt.Rows)
                            {
                                dm.UpdateSync(int.Parse(dri[0].ToString()));
                            }
                            drd[3] = "Uploaded";
                        }
                        else
                        {
                            drd[3] = "Error  " + ret;
                        }
                        _dsdownload.Rows.Add(drd);
                    }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void DoUploadMaterialRequest()
        {
            txtstatus.Caption = "Uploading Material Request";
            Application.DoEvents();
            try
            {
                var dm = new PrDataManager();
                var dt = dm.GetPurchaseRequstNotSync();
                var syc = new RemoteSync();
                var drd = _dsdownload.NewRow();

                if (dt.Rows.Count == 0)
                {
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Material Request";
                    drd[3] = "Nothing to Upload ";
                    _dsdownload.Rows.Add(drd);
                }
                else
                    {
                        var ret = syc.DoSavePurchaseRequestInRemote(dm.GetPurchaseRequstNotSync());
                        if (ret == "1")
                        {
                            dm.DoUpdateSync();
                            drd[2] = "Material Request";
                            drd[3] = "Uploaded";
                        }
                        else
                        {
                            drd[3] = "Error " + ret;
                        }
                        _dsdownload.Rows.Add(drd);
                }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
        }
        void DoUploadItemTransfers()
        {
            txtstatus.Caption = "Uploading Item Transfer";
            Application.DoEvents();
            progressPanel1.Visible = true;
            try
            {
                var dm = new ItemMoveDataManager();
                var dt = dm.GetItemTranferToTransfer();
                var syc = new RemoteSync();
                var dtw = ClsGetData.GetMyWareHouses();
                bool isStore = dtw.Rows.Count > 0;
                if (dt.Rows.Count == 0)
                {
                    var drd = _dsdownload.NewRow();
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Item transfer";
                    drd[3] = "Nothing to Upload ";
                    _dsdownload.Rows.Add(drd);
                    return;
                }
                foreach (DsInventory.ITEMTRANSFERMAINRow dr in dt.Rows)
                {
                    //if (Utils.PingServer())
                    //{
                        if (isStore)
                        {
                            var drd1 = _dsdownload.NewRow();
                            var retval = syc.DoUpLoadItems(dr.TRANID, false);
                            if (retval == "1")
                            {
                                drd1[0] = dr.TRANID;
                                drd1[1] = DateTime.Now.Date;
                                drd1[2] = "Item Master - Item Transfer";
                                drd1[3] = "Upload ";
                            }
                            else
                            {
                                drd1[0] = dr.TRANID;
                                drd1[1] = DateTime.Now.Date;
                                drd1[2] = "Item Master - Item Transfer";
                                drd1[3] = "Error   '" + retval + "'";
                            }
                            _dsdownload.Rows.Add(drd1);
                        }
                        var drd = _dsdownload.NewRow();
                        drd[0] = dr.TRANID;
                        drd[1] = DateTime.Now.Date;
                        drd[2] = "Item transfer";
                        var ret = syc.DoSaveItemTranferInRemote(dr, dm.GetItemTransferDetailById(dr.TRANID));
                        if (ret == "1")
                        {
                            dm.UpdatedSyn(dr.TRANID);
                            drd[3] = "Uploaded";
                        }
                        else
                        {
                            drd[3] = "Error  " + ret;
                        }
                        _dsdownload.Rows.Add(drd);
                    }
                    //else
                    //{
                    //    XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK,
                    //        MessageBoxIcon.Information);
                    //}
                // }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        void GetMasters(DataTable dt,bool ispur)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (ispur)
                {
                   _Purinvids += dr[0] + ",";
                }
                else
                {
                    _Transids += dr[0] + ",";
                }
            }
        }
        void DoUpLoadSuppliers()
        {
            if (Utils.PingServer())
                {
                     var syc = new RemoteSync();
                     var ret =  syc.DoUpLoadSuppliers();
                    if (ret != "1")
                    {
                        XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    {
                       XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
        }
        void DoUpLoadPromotions()
        {
            txtstatus.Caption = "Uploading Commission";
            Application.DoEvents();
            try
            {
                var dm = new BlCommissionSetup();
                var dt = dm.GetCommissionMastNotUploaded();
                var syc = new RemoteSync();
                if (dt.Rows.Count == 0)
                {
                    var drd = _dsdownload.NewRow();
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Commission Invoice";
                    drd[3] = "Nothing to Upload ";
                    _dsdownload.Rows.Add(drd);
                }
                if (Utils.PingServer())
                {
                    foreach (Ledgers.COMMISIONMASTRow  dr in dt.Rows)
                    {
                        var drd = _dsdownload.NewRow();
                        drd[0] = dr.COMID;
                        drd[1] = DateTime.Now.Date;
                        drd[2] = "Commission Invoice";
                        var ret = syc.DoUpLoadPromotions(dr, dm.GetCommissionDetail(dr.COMID));
                        if (ret == "1")
                        {
                            dm.UpdateSync(dr.COMID);
                            drd[3] = "Uploaded";
                        }
                        else
                        {
                            drd[3] = "Error  " + ret;
                        }
                        _dsdownload.Rows.Add(drd);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        void DoDownLoadPromotions()
        {
            txtstatus.Caption = "Downloading Promotions";
            Application.DoEvents();
            try
            {
                var dm = new BlCommissionSetup();
                var dt = dm.GetCommissonMastNotReceived();
                var syc = new RemoteSync();

                if (Utils.PingServer() )
                {

                    if (dt.Rows.Count == 0)
                    {
                        var drd = _dsdownload.NewRow();
                        drd[0] = "";
                        drd[1] = DateTime.Now.Date;
                        drd[2] = "Commission Invoice";
                        drd[3] = "Nothing to Download";
                        _dsdownload.Rows.Add(drd);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                foreach (Ledgers.COMMISIONMASTRow dr in dt.Rows)
                {
                    if (Utils.PingServer())
                    {
                        var drd = _dsdownload.NewRow();
                        drd[0] = dr.COMID;
                        drd[1] = DateTime.Now.Date;
                        drd[2] = "Commission Invoice";
                        var ret = syc.DoUpLoadPromotions(dr, dm.GetCommissionDetail(dr.COMID, true), true);
                        if (ret == "1")
                        {
                            drd[3] = "Downloaded";
                        }
                        else
                        {
                            drd[3] = "Error  " + ret;
                        }
                        _dsdownload.Rows.Add(drd);
                    }
                    else
                    {
                        XtraMessageBox.Show("Failed to connect server ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        void DoDownLoadCustomers()
        {
            txtstatus.Caption = "Uploading Customer Price";
            Application.DoEvents();
            try
            {
                var syc = new RemoteSync();
                var drd = _dsdownload.NewRow();
                if(syc.DoDownLoadCustomer()=="1")
                 {
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Customer";
                    drd[3] = "Customer Download";
                 }
                else
                 {
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Customer";
                    drd[3] = "Error Downloading";
                 }
                _dsdownload.Rows.Add(drd);
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void DoUploadCustomerPoints()
        {
            txtstatus.Caption = "Uploading Customer Points";
            Application.DoEvents();
            try
            {
                var dm = new VIRETAILDAL.Masters.Customer();
                var dt = dm.GetCustomerWithPoints();
                
                var syc = new RemoteSync();

                if (dt.Rows.Count == 0)
                {
                    var drd = _dsdownload.NewRow();
                    drd[0] = "";
                    drd[1] = DateTime.Now.Date;
                    drd[2] = "Customer Points";
                    drd[3] = "Nothing to Upload ";
                    _dsdownload.Rows.Add(drd);
                }
                else
                {
                    foreach (DsMaster.CUSTOMERRow dr in dt.Rows)
                    {
                        var drd1 = _dsdownload.NewRow();

                        var ret = syc.SetAvailablePoints(dr.CUSTNO, dr.CUSTOMERPOINT); //syc.DoSavePurchaseRequestInRemote(dm.GetPurchaseRequstNotSync());
                        if (ret == "1")
                        {

                            dm.UpdateCustomerPoints(dr.CUSTNO, -dr.CUSTOMERPOINT);
                            drd1[1] = DateTime.Now.Date;
                            drd1[2] = "Customer Points";
                            drd1[3] = "Points Updated";
                        }
                        else
                        {
                            drd1[3] = "Error " + ret;
                        }
                        _dsdownload.Rows.Add(drd1);
                    }
                }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
        }

        void DouploadCustomerRedimPoints()
        {
            txtstatus.Caption = "Uploading Customer Points";
            Application.DoEvents();
            try
            {
                var dm = new VIRETAILDAL.Masters.Customer();
                var dt = dm.GetCustomerPointNotUploaded();
                var syc = new RemoteSync();
                if (dt.Rows.Count <= 0) return;
                foreach (Ledgers.CUSTOMERPOINTSRow dr in dt.Rows)
                {
                    var drd1 = _dsdownload.NewRow();
                    var ret = syc.UpdatePointsDetails(dr); //syc.DoSavePurchaseRequestInRemote(dm.GetPurchaseRequstNotSync());
                    if (ret == "1")
                    {
                        dm.SetCustomerPointUploadStatus(dr.TID);
                        drd1[1] = DateTime.Now.Date;
                        drd1[2] = "Customer Points re-dim details";
                        drd1[3] = "Re-dim Updated";
                    }
                    else
                    {
                        drd1[3] = "Error " + ret;
                    }
                    _dsdownload.Rows.Add(drd1);
                }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.ToString(), "POS", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }


        }
        private void DataSyncForm_Load(object sender, EventArgs e)
        {
            dataDownLoadsBindingSource.DataSource = _dsdownload;
            if (VIRETAILDAL.COMMON.Utils.Company == "01")
            {
                BtnUploadPromotions.Visibility = BarItemVisibility.Always;
                BtnDownloadPromotions.Visibility = BarItemVisibility.Never;
            }
            else
            {
                BtnUploadPromotions.Visibility = BarItemVisibility.Never;
                BtnDownloadPromotions.Visibility = BarItemVisibility.Always;
            }
        }
        public bool OnlyDataupload
        {
            set
            {
                if (value)
                {
                    barButtonItem2.Visibility = BarItemVisibility.Never;
                }
            }
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoUploadItemsPrices(false);
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoUploadItemsPrices(true);
        }
    }
}