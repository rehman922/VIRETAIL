using System;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using DevExpress.Utils.OAuth.Provider;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.DsInventoryTableAdapters;
using VIRETAILDAL.DsReportsTableAdapters;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;

namespace VIRETAILDAL.Transfers
{
    public class ItemMoveDataManager
    {
        private readonly string _constr = Utils.Connectionstring;

        public string DoSave(DsInventory.ITEMTRANSFERMAINRow drow,
            DsInventory.ITEMTRANSFERDETAILDataTable itemtransferdetail, string Stype)
        {
            var dm = new DataManager();
            string retval = "0";
            SqlTransaction tran = null;
            var isnew = false;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsInventory();
                var dt = ds.ITEMTRANSFERMAIN;
                var taItemTransMain = new ITEMTRANSFERMAINTableAdapter();
                var taItremTransDetail = new ITEMTRANSFERDETAILTableAdapter();
                var taStockMaster = new STOCKMASTERTableAdapter {Connection = {ConnectionString = _constr}};
                taItemTransMain.Connection.ConnectionString = _constr;
                taStockMaster.Fill(ds.STOCKMASTER);
                taItemTransMain.FillByTranid(dt, drow.TRANID);
                // Assaign Transaction
                taItemTransMain.AssignConnection(cn, tran);
                taItremTransDetail.AssignConnection(cn, tran);
                taStockMaster.AssignConnection(cn, tran);
                var dr = dt.FindByTRANID(drow.TRANID);

                if (dr != null)
                {
                    dr.BeginEdit();
                }
                else
                {
                    dr = (DsInventory.ITEMTRANSFERMAINRow) dt.NewRow();
                    isnew = true;
                }
                if (isnew)
                {
                    var autoid = dm.GetAutoId(3);
                    autoid++;
                    Utils.Tranid = dm.CreateFormatedAutoNo(autoid);
                    dr.TRANID = Utils.Tranid;
                    dr.COMPANY = Utils.Company;
                }
                else
                {
                    Utils.Tranid = drow.TRANID;
                    dr.EDATE = DateTime.Now;
                    dr.EUSERID = Utils.Userid;
                }
                dr.FRMSTOREID = drow.FRMSTOREID;
                dr.TOSTOREID = drow.TOSTOREID;
                dr.TRANDATE = drow.TRANDATE;
                dr.TOTVALUE = drow.TOTVALUE;
                dr.TOTITEMS = itemtransferdetail.Count;
                dr.HOLD = drow.HOLD;
                dr.FRMNAME = drow.FRMNAME;
                dr.TONAME = drow.TONAME;
                dr.TTYPE = drow.TTYPE;
                dr.TOCOMP = drow.TOCOMP;
                dr.USERID = drow.USERID;
                var taa = new DataManager();
                dr.DOWNFILENO = drow.DOWNFILENO;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    taItemTransMain.Update(dt);
                    if (dr.TTYPE == 3)
                    {
                        dr.AFILENO = Utils.Tranid; // taa.CreateFormatedAutoNo(taa.GetAutoId(5));
                        dr.FLAGFILE = true;
                    }
                }
                else
                {
                    dr.EndEdit();
                    taItemTransMain.Update(dr);
                }
                foreach (DataRow purd in itemtransferdetail.Rows)
                {
                    if ((purd.RowState != DataRowState.Deleted))
                    {
                        purd["TRANID"] = Utils.Tranid;
                        purd["TOSTORE"] = drow.TOSTOREID;
                    }
                }
                taItremTransDetail.Update(itemtransferdetail);
                if (!dr.HOLD)
                {
                    Masters.StockMaster.UpdateQtyInStockDataSet(ref cn, ref tran, itemtransferdetail, false);
                    if (dr.TTYPE == 3)
                    {
                        new Masters.StockMaster().CreateStock(ref cn, ref tran, itemtransferdetail, drow.TOSTOREID,
                            Stype, false, false);
                    }
                    dm.UpdateAutoNum(3);
                }
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                if (isnew)
                    Utils.Tranid = string.Empty;
                retval = ex.ToString();
            }
            return retval;
        }

        public DsReports.RptItemMoveDataTable RptItemMove(string purinv, string comp)
        {
            var ta = new RptItemMoveTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsReports().RptItemMove;
            ta.Fill(ds, purinv);
            return ds;
        }

        public DsInventory.ITEMTRANSFERMAINDataTable GetItemTransfer()
        {
            var ta = new ITEMTRANSFERMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory.ITEMTRANSFERMAINDataTable();
            ta.Fill(ds);
            return ds;
        }

        public DsInventory.ITEMTRANSFERMAINDataTable GetItemTransferByid(string tranid, bool userothercomp = false,
            string concomp = "")
        {
            var ta = new ITEMTRANSFERMAINTableAdapter
            {
                Connection = {ConnectionString = userothercomp ? concomp : _constr}
            };
            var ds = new DsInventory.ITEMTRANSFERMAINDataTable();
            ta.FillByTranid(ds, tranid);
            return ds;
        }

        public DsInventory.ITEMTRANSFERDETAILDataTable GetItemTransferDetailById(string tranid, bool othercomp = false,
            string concomp = "")
        {
            var ta = new ITEMTRANSFERDETAILTableAdapter
            {
                Connection = {ConnectionString = othercomp ? concomp : _constr}
            };
            var ds = new DsInventory.ITEMTRANSFERDETAILDataTable();
            ta.FillByTranid(ds, tranid);
            return ds;
        }

        public DsReports.TranferItemListWithItemnameDataTable TranferItemListWithItemname(string tranid)
        {
            var ta = new TranferItemListWithItemnameTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsReports().TranferItemListWithItemname;
            ta.Fill(ds, tranid);
            return ds;
        }

        public DsReports.ITEMTRANSFERMAINLISTDataTable ItemTranferMainListForHist(bool frmstore)
        {
            var ta = new ITEMTRANSFERMAINLISTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsReports().ITEMTRANSFERMAINLIST;
            if (frmstore)
            {

                ta.FillByTransfer(ds, Utils.Company);
            }
            else
            {

                ta.Fill(ds, Utils.Company);
            }
            return ds;
        }

        public DsReports.ITEMTRANSFERMAINLISTDataTable ItemTranferMainListForHist(bool frmstore, DateTime d1,
            DateTime d2, bool useothercomp = false, string concomp = "P", string concode = "")
        {
            var ta = new ITEMTRANSFERMAINLISTTableAdapter
            {
                Connection = {ConnectionString = useothercomp ? concomp : _constr}
            };
            var ds = new DsReports().ITEMTRANSFERMAINLIST;
            if (frmstore)
            {
                ta.FillByTransferByDate(ds, useothercomp ? concode : Utils.Company, d1, d2);
            }
            else
            {
                ta.FillByReceivedByDate(ds, useothercomp ? concode : Utils.Company, d1, d2);
            }
            return ds;
        }

        public decimal GetTranferCostValue(string tranid, bool useothercomp = false, string concomp = "P")
        {
            decimal retval = 0;
            var ta = new GetTranferCostValueTableAdapter
            {
                Connection = {ConnectionString = useothercomp ? concomp : _constr}
            };
            var ds = new DsReports().GetTranferCostValue;
            ta.Fill(ds, tranid);
            foreach (DataRow dr in ds.Rows)
            {
                retval = decimal.Parse(dr[0].ToString());
            }
            return retval;
        }

        public DsInventory.ITEMTRANSFERMAINDataTable GetItemTransferByHold()
        {
            var ta = new ITEMTRANSFERMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory.ITEMTRANSFERMAINDataTable();
            ta.FillByHold(ds);
            return ds;
        }

        public DsInventory.ITEMTRANSFERMAINDataTable GetItemTransferFileNotGenereted()
        {
            var ta = new ITEMTRANSFERMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory().ITEMTRANSFERMAIN;
            ta.FillByNoFileNo(ds, Utils.Company);
            return ds;
        }

        public string GetMaxTranid()
        {
            var ta = new ITEMTRANSFERMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var dt = new DsInventory.ITEMTRANSFERMAINDataTable();
            ta.FillByDonwlodedTranids(dt, Utils.Company);
            string _ret = string.Empty;
            foreach (DataRow dr  in dt.Rows)
            {
                _ret += dr["TRANID"].ToString() + ",";
            }
            // return (string) ta.GetMaxTranid(Utils.Company) ?? null;
            return _ret;
        }

        public DsInventory CreateDataSetForXmlFile(string tranids)
        {
            var dsxml = new DsInventory();
            var ta = new ITEMTRANSFERMAINTableAdapter {Connection = {ConnectionString = _constr}};
            ta.FillByTranid(dsxml.ITEMTRANSFERMAIN, tranids);
            var tadet = new ITEMTRANSFERDETAILTableAdapter {Connection = {ConnectionString = _constr}};
            ;
            tadet.FillByTranid(dsxml.ITEMTRANSFERDETAIL, tranids);
            var taItems = new GetItemsForRemoteUpdateTableAdapter {Connection = {ConnectionString = _constr}};
            ;
            taItems.Fill(dsxml.GetItemsForRemoteUpdate, tranids);
            var taSuppliers = new GetSupplierForRemoteUpdateTableAdapter {Connection = {ConnectionString = _constr}};
            ;
            taSuppliers.Fill(dsxml.GetSupplierForRemoteUpdate, tranids);
            return dsxml;
        }

        public string GetSalesStore()
        {
            var ta = new DsMasterTableAdapters.STOREMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().STOREMAST;
            ta.FillBySalesStore(ds, Utils.Company);
            string scode = string.Empty;
            foreach (DataRow dr in ds.Rows)
            {
                scode = dr["STORECODE"].ToString();
            }
            return scode;
        }

        public void DeleteItemMove(string tranid)
        {
            var ta = new ITEMTRANSFERMAINTableAdapter();
            var tadel = new ITEMTRANSFERDETAILTableAdapter();
            ta.Connection.ConnectionString = _constr;
            tadel.Connection.ConnectionString = _constr;
            tadel.DeleteQuery(tranid);
            ta.DeleteQuery(tranid);
        }

        public DsInventory.ITEMTRANSFERMAINDataTable GetItemTranferToTransfer()
        {
            return
                new ITEMTRANSFERMAINTableAdapter {Connection = {ConnectionString = _constr}}.GetDataByUpLoadItemTransfer
                    (Utils.Company);
        }
        public void UpdatedSyn(string tranid)
        {
            new ITEMTRANSFERMAINTableAdapter {Connection = {ConnectionString = _constr}}.UpdateSync(tranid);
        }

        public DsReports.InventoryTransferDetailsDataTable GetInventoryTransferDetails(bool frmstore, DateTime d1,
            DateTime d2, string comp, bool useothercomp = false, string concomp = "")
        {
            var ta = new InventoryTransferDetailsTableAdapter
            {
                Connection = {ConnectionString = useothercomp ? concomp : _constr}
            };
            return frmstore ? ta.GetDataByTransfer(comp, d1, d2) : ta.GetData(comp, d1, d2);
            //if(frmstore)    
            //  return new InventoryTransferDetailsTableAdapter {Connection = {ConnectionString = useothercomp? concomp: _constr}}.GetData(comp,d1, d2);
        }

        public DsInventory.ITEMTRANSFERDETAILDataTable CreateItemtransferdetailsFrmMR(DsPurchase.PURCHASEREQUESTDataTable dst, string whid)
        {
            var ret = new DsInventory.ITEMTRANSFERDETAILDataTable();
            var dsS = new StockMaster().GetStockItemsForTransferDataTable(Utils.Company, whid);
            foreach (DsPurchase.PURCHASEREQUESTRow dr in dst.Rows)
            {
                if (!dr.IsISSUEDNull())
                {
                    if (dr.ISSUED > 0)
                    {
                        var q = from p in dsS where p.ITEMNO == dr.ITEMNO  orderby p.QTY ascending select p ;
                        var tb = q.CopyToDataTable();
                        if (tb.Rows.Count > 0)
                        {
                            AddItemsToItemMoveDetails(tb, ref ret, dr.ITEMNO, dr.ISSUED,dr.COMPANY);
                        }
                    }
                }
            }
            return ret;
        }
        public void AddItemsToItemMoveDetails(DataTable dt, ref DsInventory.ITEMTRANSFERDETAILDataTable dtitems,string itemno,int reqqty,string tostore)
        {
            int newqty = reqqty;
            bool _add = false;
            foreach (DataRow adr in dt.Rows)
            {
                if (int.Parse(adr["QTY"].ToString()) < newqty && newqty  > 0 )
                {
                   newqty = reqqty - int.Parse(adr["QTY"].ToString());
                   reqqty = int.Parse(adr["QTY"].ToString());
                    _add = true;
                }
                else if (newqty > 0)
                {
                    reqqty = newqty;
                    newqty -= reqqty;
                    _add = true;
                }
                if (_add)
                {
                    if (newqty == 0)
                        _add = false;
                    var dr = dtitems.NewRow();
                    dr["TRANID"] = 0;
                    dr["ITEMNO"] = adr["itemno"];
                    dr["BARCODE"] = adr["BARCODE"];
                    dr["WHID"] = adr["WHID"];
                    dr["STOCK"] = adr["QTY"];
                    dr["QTY"] = reqqty;
                    dr["CPRICE"] = adr["CPRICE"];
                    dr["SPRICE"] = adr["SPRICE"];
                    dr["EXPDATE"] = adr["EXPDATE"];
                    dr["STOCKID"] = adr["STOCKID"];
                    dr["LINETOTAL"] = decimal.Parse(adr["SPRICE"].ToString())*reqqty;
                    dr["TOSTORE"] = tostore;
                    dtitems.Rows.Add(dr);
                }
            }
            }
    }

    public class ItemDownLoadDataManager
    {
        private readonly string _constr = Utils.Connectionstring;
        public string whid { set; get; }
        public string storecode { set; get; }
        private DsInventory dslocalcopy;

        public string DoSave(DsInventory xInventory, string tranid, bool allitems = false)
        {
            string retval = "0";
            SqlTransaction tran = null;
            var isnew = false;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsInventory();

                //var dt = ds.ITEMTRANSFERMAIN;
                var taTranmain = new ITEMTRANSFERMAINTableAdapter();
                var taTranetail = new ITEMTRANSFERDETAILTableAdapter();
                var taStockMaster = new STOCKMASTERTableAdapter();
                var taSupplier = new SUPPLIERTableAdapter();

                // var taSupplier = new DsMasterTableAdapters.SUPPLIERTableAdapter();
                // var taItem = new DsMasterTableAdapters.ITEMMASTTableAdapter();

                var taItem = new ITEMMAST1TableAdapter();

                // tas
                taTranmain.Connection.ConnectionString = _constr;
                taTranetail.Connection.ConnectionString = _constr;
                taStockMaster.Connection.ConnectionString = _constr;
                taSupplier.Connection.ConnectionString = _constr;
                taItem.Connection.ConnectionString = _constr;

                taTranmain.Fill(ds.ITEMTRANSFERMAIN);
                taTranetail.Fill(ds.ITEMTRANSFERDETAIL);

                taSupplier.Fill(ds.SUPPLIER);
                taItem.Fill(ds.ITEMMAST1);

                //taStockMaster.Fill(ds.STOCKMASTER);

                taTranmain.AssignConnection(cn, tran);
                taTranetail.AssignConnection(cn, tran);
                taItem.AssignConnection(cn, tran);
                taSupplier.AssignConnection(cn, tran);
                taStockMaster.AssignConnection(cn, tran); //tas   bool isnew =false;
                DataTable dtsupplier;
                DataTable dtitems;
                if (!allitems)
                {
                    dtsupplier = xInventory.GetSupplierForRemoteUpdate;
                    dtitems = xInventory.GetItemsForRemoteUpdate;
                }
                else
                {
                    dtsupplier = xInventory.SUPPLIER;
                    dtitems = xInventory.ITEMMAST1;
                }
                var dtitemtrans = xInventory.ITEMTRANSFERMAIN;
                var dtitemtrandetails = xInventory.ITEMTRANSFERDETAIL;
                foreach (DataRow dr in dtsupplier.Rows)
                {
                    isnew = false;
                    var dsup = ds.SUPPLIER.FindBySUPPLIERNO(dr["SUPPLIERNO"].ToString());
                    if (dsup != null)
                    {
                        dsup.BeginEdit();
                    }
                    else
                    {
                        dsup = (DsInventory.SUPPLIERRow) ds.SUPPLIER.NewRow();
                        isnew = true;
                        foreach (DataColumn dc in dtsupplier.Columns)
                        {
                            dsup[dc.ColumnName] = dr[dc.ColumnName];
                        }
                    }
                    bool update = true;
                    if (!isnew)
                    {
                        update = Equals(dr, dsup);
                    }
                    if (!update)
                    {
                        foreach (DataColumn dc in dtsupplier.Columns)
                        {
                            if (!dc.ReadOnly)
                                dsup[dc.ColumnName] = dr[dc.ColumnName];
                        }
                    }
                    if (isnew)
                    {
                        ds.SUPPLIER.Rows.Add(dr.ItemArray);
                        var t = taSupplier.Update(ds.SUPPLIER);
                        if (t == 0)
                            retval += " Supplier master not created";
                    }
                    else
                    {
                        dsup.EndEdit();
                        taSupplier.Update(dsup);
                    }
                }
                foreach (DataRow dr in dtitems.Rows)
                {
                    isnew = false;
                    var dsup = ds.ITEMMAST1.FindByITEMNO(dr["ITEMNO"].ToString());
                    if (dsup != null)
                    {
                        dsup.BeginEdit();
                    }
                    else
                    {
                        dsup = (DsInventory.ITEMMAST1Row) ds.ITEMMAST1.NewRow();
                        isnew = true;
                    }
                    bool update = true;

                    if (!isnew)
                    {
                        update = Equals(dr, dsup);
                    }
                    if (!update)
                    {
                        foreach (DataColumn dc in dtitems.Columns)
                        {
                            if (!dc.ReadOnly)
                                dsup[dc.ColumnName] = dr[dc.ColumnName];
                        }
                    }
                    if (isnew)
                    {

                        ds.ITEMMAST1.Rows.Add(dr.ItemArray);
                        var t = taItem.Update(ds.ITEMMAST1);
                        if (t == 0)
                            retval += "item mast not created";
                    }
                    else
                    {
                        dsup.EndEdit();
                        taItem.Update(dsup);
                    }
                }
// first find the file No and then update
                bool download = false;
                var ItemsToAddStockMaster = new DsInventory.ITEMTRANSFERDETAILDataTable();
                //var dsup = ds.ITEMTRANSFERMAIN.FindByTRANID(ditemrow["TRANID"].ToString());
                var tranmaster = dtitemtrans.Select("tranid= '" + tranid + "'");
                foreach (DataRow ditemrow in tranmaster)
                {
                    var dsup = ds.ITEMTRANSFERMAIN.FindByTRANID(ditemrow["TRANID"].ToString());
                    if (dsup == null)
                    {
                        download = true;
                        var fno = ditemrow["AFILENO"].ToString();
                        ditemrow["ISREC"] = 1;
                        ditemrow["DOWNFILENO"] = fno;
                        ditemrow["AFILENO"] = string.Empty;
                        ds.ITEMTRANSFERMAIN.Rows.Add(ditemrow.ItemArray);
                        var t = ditemrow["TRANID"].ToString();
                        var drdetrows = dtitemtrandetails.Select("tranid= '" + t + "'");
                        foreach (DataRow ditemdetarow in drdetrows)
                        {
                            var newdetrow = ds.ITEMTRANSFERDETAIL.NewRow();
                            var newdettransrow = ItemsToAddStockMaster.NewRow();
                            foreach (DataColumn dc in dtitemtrandetails.Columns)
                            {
                                if (!dc.ReadOnly)
                                {
                                    newdetrow[dc.ColumnName] = ditemdetarow[dc.ColumnName];
                                    newdettransrow[dc.ColumnName] = ditemdetarow[dc.ColumnName];
                                }
                            }
                            ds.ITEMTRANSFERDETAIL.Rows.Add(newdetrow);
                            ItemsToAddStockMaster.Rows.Add(newdettransrow);
                        }
                    }
                }
                var bl = new Masters.StockMaster(); // send to stock only donwloading data only.
                var s = new Masters.StoreManager().GetStoreType(whid);
                string storetype = "S";
                if (s.IndexOf("S") == -1)
                {
                    storetype = "P";
                }
                if (download)
                {
                    bl.CreateStock(ref cn, ref tran, ItemsToAddStockMaster, whid, storetype, false, false);
                }
                taTranmain.Update(ds.ITEMTRANSFERMAIN);
                taTranetail.Update(ds.ITEMTRANSFERDETAIL);
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                retval = ex.ToString();
            }
            return retval;
        }

        public void GetServerData(ref DsInventory xInventory, string servercon, string tranid)
        {
            dslocalcopy = xInventory;
            //  servercon = new SqlAsyncConnectionString(@"78.93.190.90\SQLPOS;Initial Catalog=POS;User ID=SA;Password=mutawa2011");
            //servercon = new SqlAsyncConnectionString();
            string sqlstr = "";
            var cn = new SqlConnection(servercon);
            cn.Open();

            //  1.Items
            //////// sqlstr = "Select * from itemmast ";
            ////////var asynccmd = new SqlCommand(sqlstr,cn);
            ////////AsyncCallback callback = HandleCallback;
            ////////asynccmd.BeginExecuteReader(callback, asynccmd);
            ////////ta.Fill(xInventory.ITEMMAST1);

            //// 2.Supplier
            //cmd = "Select * from supplier FOR XML raw ,  ELEMENTS XSINIL ";
            //command = new SqlCommand(cmd, cn);
            //command.BeginExecuteXmlReader(callback, command);
            ////////ta = new SqlDataAdapter(cmd, cn);
            ////////ta.Fill(xInventory.SUPPLIER);

            // 3.ITEMTRANSFERMAIN

            // Fetch the data from server where transfer = 0 and tostoreid

            // if (string.IsNullOrEmpty(tranid))
            //  {
            sqlstr = "select * from ITEMTRANSFERMAIN where  isnull(upload,0)= 0 and  TOSTOREID  = '" + Utils.Company +
                     "'";
            // }
            //else
            //{
            //    sqlstr = "select * from ITEMTRANSFERMAIN where TOSTOREID = '" + Utils.Company + "' " +
            //             " and TRANID  not in (SELECT  value  FROM dbo.fn_Split( '" + tranid + "', ',')) ";
            //}

            var ta = new SqlDataAdapter(sqlstr, cn);
            ta.Fill(xInventory.ITEMTRANSFERMAIN);

            if (xInventory.ITEMTRANSFERMAIN.Rows.Count > 0)
            {
                string tranids = xInventory.ITEMTRANSFERMAIN.Rows.Cast<DataRow>().Aggregate<DataRow, string>(null,
                    (current,
                        dr)
                        =>
                        current +
                        (dr["TRANID"].ToString() + ","));
                ////  4.ItemDownDetail

                if (xInventory.ITEMTRANSFERMAIN.Rows.Count > 0)
                {
                    sqlstr = "select * from ITEMTRANSFERDETAIL where TRANID IN (SELECT  value  FROM dbo.fn_Split ( '" +
                             tranids + "', ',')) ";
                    ta = new SqlDataAdapter(sqlstr, cn);
                    ta.Fill(xInventory.ITEMTRANSFERDETAIL);
                }

                //////////  4.Item Master

                sqlstr = " Select distinct ITEMMAST.*  FROM    ITEMMAST INNER JOIN " +
                         " ITEMTRANSFERDETAIL ON ITEMMAST.ITEMNO = ITEMTRANSFERDETAIL.ITEMNO WHERE   " +
                         " (ITEMTRANSFERDETAIL.TRANID IN (SELECT  value FROM  dbo.fn_Split('" + tranids +
                         "', ',') AS fn_Split_1)) ";

                ta = new SqlDataAdapter(sqlstr, cn);
                ta.Fill(xInventory.ITEMMAST1);
            }
        }

        public DsInventory.STOCKMASTERDataTable GetNegativeStock()
        {
            return new Masters.StockMaster().GetNegativeStock();
        }

         
    }

    public class DiskDataManager
    {
        private readonly string _constr = Utils.Connectionstring;
        public string Tranid { get; set; }
        public int ftype { get; set; }
        public string fileno { get; set; }

        public bool DoSave()
        {
            bool retval = false;
            var ta = new DISKDETAILSTableAdapter {Connection = {ConnectionString = _constr}};
            var taitemove = new ItemMoveDataManager();
            var taitemtran = new ITEMTRANSFERMAINTableAdapter {Connection = {ConnectionString = _constr}};
            taitemtran.DiskCreated(Tranid);
            var taauto = new DataManager();
            retval = ta.Insert(fileno, DateTime.Now, Utils.Userid, Tranid, Utils.Company, ftype) > 0;
            //   taitemove.UpdateFileNo(fileno, Tranid);
            taauto.UpdateAutoNum(5);
            return retval;
        }
    }
}
     

