using System;
using System.Data;
using System.Data.SqlClient;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;
using VIRETAILDAL.DsInventoryTableAdapters;
using VIRETAILDAL.DsReportsTableAdapters;
using VIRETAILDAL.DsPurchaseTableAdapters;
namespace VIRETAILDAL.Purchasing
{
    public class PurReturnDataManger
    {
        private readonly string _constr = Utils.Connectionstring;
        public string DoSave(DsPurchase.RETURNMASTRow drow, DsPurchase.RETURNDETAILDataTable returndetail)
        {
            var dm = new DataManager();
            string retval;
            SqlTransaction tran = null;
            var isnew = false;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsPurchase();
                var dsStock = new DsInventory();
                var dt = ds.RETURNMAST;
                var taPurMain = new RETURNMASTTableAdapter {Connection = {ConnectionString = _constr}};
                var taPurDetail = new RETURNDETAILTableAdapter();
     
    
                var taStockMaster = new STOCKMASTERTableAdapter {Connection = {ConnectionString = _constr}};
                var taapar = new LedgersTableAdapters.APARMAINTableAdapter();
                var taledger = new LedgersTableAdapters.LEDGERSTableAdapter();

                taStockMaster.Fill(dsStock.STOCKMASTER);

                taPurMain.Fill(ds.RETURNMAST);



                // Assaign Transaction
                taPurMain.AssignConnection(cn, tran);
                taPurDetail.AssignConnection(cn, tran);
                taStockMaster.AssignConnection(cn, tran);

                taapar.AssignConnection(cn, tran);
                taledger.AssignConnection(cn, tran);

                var dr = dt.FindByRETURNID(drow.RETURNID);
                if (dr != null)
                { dr.BeginEdit(); }
                else
                { dr = (DsPurchase.RETURNMASTRow)dt.NewRow(); }
                if (string.IsNullOrEmpty(drow.RETURNID))
                {
                    var autoid = dm.GetAutoId(2);
                    autoid++;
                    Utils.Retinvid = dm.CreateFormatedAutoNo(autoid);
                    dr.RETURNID = Utils.Retinvid;
                    dr.USERID = Utils.Userid;
                    dr.COMPANY = Utils.Company;
                    dr.TRANDATE = System.DateTime.Now;
                    isnew = true;
                }
                else
                {
                    Utils.Retinvid = drow.RETURNID;
                    dr.EDATE = DateTime.Now;
                    dr.EUSERID = Utils.Userid;
                }
                dr.SUPID = drow.SUPID;
                dr.SUPNAME = drow.SUPNAME;
                dr.INVDATE = drow.INVDATE;
                dr.INVNO = drow.INVNO;
                dr.SPDISCOUNT = drow.SPDISCOUNT;
                dr.WHID = drow.WHID;
                dr.ADJVALUE = drow.ADJVALUE;
                dr.NETVALUE = drow.NETVALUE;
                dr.HOLD = drow.HOLD;

                if (isnew)
                {
                    dt.Rows.Add(dr);
                    taPurMain.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    taPurMain.Update(dr);
                }
                foreach (DataRow purd in returndetail.Rows)
                {
                    if ((purd.RowState != DataRowState.Deleted))
                        purd["RETURNID"] = Utils.Retinvid;
                }
                taPurDetail.Update(returndetail);
                //STOCK
                if (!dr.HOLD)
                {
                   // Masters.StockMaster.UpdateQtyInStockDataSet(ref dsStock, returndetail, true);
                   // taStockMaster.Update(dsStock.STOCKMASTER);
                    Masters.StockMaster.UpdateQtyInStockDataSet(ref cn,ref tran, returndetail, true);
                //LEDGER
                    taapar.Insert("S", dr.SUPID, DateTime.Now.Date, dr.INVDATE, Utils.Retinvid, dr.INVNO, -dr.NETVALUE, 0, -dr.NETVALUE, Utils.Company, 2, Utils.Userid, 0);
                    taledger.Insert("S", dr.SUPID, DateTime.Now.Date, dr.INVDATE, Utils.Retinvid, dr.INVNO, dr.NETVALUE,0, 2, Utils.Company, Utils.Userid, "Purchase Retun");
                }
                dm.UpdateAutoNum(2);
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                if (isnew)
                    Utils.Retinvid = string.Empty;
                retval = ex.ToString();
            }
            return retval;
        }
        public void DeletePurRetInv(string purinv, string comp)
        {
            var ta = new RETURNDETAILTableAdapter {Connection = {ConnectionString = _constr}};
            ta.DeleteQueryByid(purinv);
            var ta1 = new RETURNMASTTableAdapter();
            ta1.Connection.ConnectionString = _constr;
            ta1.DeleteQuery(purinv);
        }
        public DsPurchase.RETURNMASTDataTable GetPurRetMain()
        {
            var ta = new RETURNMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase.RETURNMASTDataTable();
            ta.Fill(ds);
            return ds;
        }
        public DsPurchase.RETURNMASTDataTable GetPurRetMainByHold()
        {
            var ta = new RETURNMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase.RETURNMASTDataTable();
            ta.FillByHold(ds);
            return ds;
        }
        public DsPurchase.RETURNMASTDataTable GetPurRetInvMainById(string pkid)
        {
            var ta = new RETURNMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase().RETURNMAST;
            ta.FillByRetid(ds, pkid);
            return ds;
        }
        public DsPurchase.RETURNDETAILDataTable GetPurRetInvDetailsById(string pkid)
        {
            var ta = new RETURNDETAILTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase().RETURNDETAIL;
            ta.FillByRetid(ds, pkid);
            return ds;
        }
        public int GetPurchaseReturnHoldCount()
        {
            var ds = new DsPurchase.RETURNMASTDataTable();
            var ta = new RETURNMASTTableAdapter {Connection = {ConnectionString = _constr}};
            return ta.FillByHold(ds);
        }
        public DsReports.RptPurchaseReturnDataTable RptPurchaseInv(string purinv, string comp)
        {
            var ta = new RptPurchaseReturnTableAdapter{Connection = {ConnectionString = _constr}};
            var ds = new DsReports();
            ta.Fill(ds.RptPurchaseReturn, purinv);
             return ds.RptPurchaseReturn;
        }
        public DsPurchase.RETURNMASTDataTable GetPurchaseInvoiceReturnNotSync()
        {
            return new RETURNMASTTableAdapter { Connection = { ConnectionString = _constr } }.GetDataByNotSync();

        }
        public void UpdatedSynReturn(string purid)
        {
            var ta = new RETURNMASTTableAdapter { Connection = { ConnectionString = _constr } };
            ta.UpdatedSync(purid);
        }
    }
}
