using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.DsInventoryTableAdapters;
using VIRETAILDAL.DsReportsTableAdapters;
using VIRETAILDAL.DsPurchaseTableAdapters;
using VIRETAILDAL.LedgersTableAdapters;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;

namespace VIRETAILDAL.Purchasing
{
    public class PurInvDataManager
    {
        private readonly string _constr = Utils.Connectionstring;
        public string DoSave(DsPurchase.PURINVMAINRow drow, DsPurchase.PURINVDETAILDataTable purinvdetail,bool issale=false, string tostore = "")
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
                var dt = ds.PURINVMAIN;

                var taPurMain = new PURINVMAINTableAdapter();
                var taPurDetail = new PURINVDETAILTableAdapter();
                var taStockMaster = new STOCKMASTERTableAdapter();

                var taPriceMaster = new DsMasterTableAdapters.PRICEMASTERTableAdapter();

                var taItemMaster = new DsMasterTableAdapters.ITEMMASTTableAdapter();

                var taapar = new LedgersTableAdapters.APARMAINTableAdapter();
                var taledger = new LedgersTableAdapters.LEDGERSTableAdapter();

                taPurMain.Connection.ConnectionString = _constr;

                taPurMain.FillByPurid(ds.PURINVMAIN, drow.PURINVID);

            //  taPurMain.Fill(ds.PURINVMAIN);
           //   Assaign Transaction

                taPurMain.AssignConnection(cn, tran);
                taPurDetail.AssignConnection(cn, tran);
                taStockMaster.AssignConnection(cn, tran);
                taPriceMaster.AssignConnection(cn, tran);

                taItemMaster.AssignConnection(cn, tran);
                taapar.AssignConnection(cn, tran);
                taledger.AssignConnection(cn, tran);

                var dr = dt.FindByPURINVID(drow.PURINVID);
                if (dr != null)
                { dr.BeginEdit(); }
                else
                { dr = (DsPurchase.PURINVMAINRow)dt.NewRow(); }
                if (string.IsNullOrEmpty(drow.PURINVID))
                {
                    var autoid = dm.GetAutoId(1);
                    autoid++;
                    Utils.Purinvid = dm.CreateFormatedAutoNo(autoid);
                    dr.PURINVID = Utils.Purinvid;
                    dr.USERID = Utils.Userid;
                    dr.COMPANY = Utils.Company;
                    dr.UDATE = DateTime.Now;
                    isnew = true;
                }
                else
                {
                    Utils.Purinvid = drow.PURINVID;
                    dr.EDATE = DateTime.Now;
                    dr.EUSERID = Utils.Userid;
                }
                dr.SUPID = drow.SUPID;
                dr.SUPNAME = drow.SUPNAME;
                dr.INVDATE = drow.INVDATE;
                dr.INVNO = drow.INVNO;
                dr.DUEDAYS = drow.DUEDAYS;
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
                //bool issale = false;//string tostore = string.Empty;

                //STOCK
                if (!drow.HOLD)
                {
                    if (issale)
                    {
                        new StockMaster().CreateStock(ref cn, ref tran, purinvdetail, drow.WHID, "S", true, false);
                    }
                    else
                    {
                        new StockMaster().CreateStock(ref cn, ref tran, purinvdetail, drow.WHID, "P", true, false);
                    }
               //Price Master
                    taPriceMaster.Update(new PriceMaster().UpdatePriceMaster(purinvdetail, drow.SUPID));
               //UPDATE LASTPRICE,LASTEXPIRY,LASTCOSTPRICE 

                //LEDGER
                    taapar.Insert("S", dr.SUPID, DateTime.Now.Date, dr.INVDATE, Utils.Purinvid, dr.INVNO, dr.NETVALUE, 0,
                             dr.NETVALUE, Utils.Company, 1, Utils.Userid, 0);
                    taledger.Insert("S", dr.SUPID, DateTime.Now.Date, dr.INVDATE, Utils.Purinvid, dr.INVNO, 0,
                                dr.NETVALUE, 1, Utils.Company, Utils.Userid,"Purchase Invoice");
                }

                foreach (DsPurchase.PURINVDETAILRow purd in purinvdetail.Rows)
                {
                    if ((purd.RowState != DataRowState.Deleted))
                    {
                        purd.PURINVID = Utils.Purinvid;
                        if (!purd.IsISSUEFORSALENull())
                        {
                            issale = purd.ISSUEFORSALE;
                            tostore = purd.TOSTORE;
                        }
                        // Item Master Price
                        if (!drow.HOLD)
                        {
                            taItemMaster.UpdateCPSP(purd.SPRICE, purd.CPRICE, purd.ITEMNO);
                        }
                    }
                }
                taPurDetail.Update(purinvdetail);
                tran.Commit();
                dm.UpdateAutoNum(1);
                retval = "1";
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                if (isnew)
                    Utils.Purinvid = string.Empty;
                retval = ex.ToString();
            }
            return retval;
        }
        public void DeletePurchaseInv(string purinv, string comp)
        {
            var ta = new PURINVDETAILTableAdapter {Connection = {ConnectionString = _constr}};
            ta.DeleteQuery(purinv);
            var ta1 = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            ta1.DeleteQuery(purinv);
        }
        //public DsInventory.RptPurchaseInvDataTable RptPurchaseInv(string purinv, string comp)
        //{
        //    var ta = new RptPurchaseInvTableAdapter {Connection = {ConnectionString = _constr}};
        //    var ds = new DsInventory();
        //    ta.Fill(ds.RptPurchaseInv, purinv);
        //    return ds.RptPurchaseInv;
        //}
        public DsReports.RptPurchaseInvDataTable RptPurchaseInv(string purinv, string comp)
        {
            var ta = new RptPurchaseInvTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports();
            ta.Fill(ds.RptPurchaseInv, purinv);
            return ds.RptPurchaseInv;  
        }
        public DsPurchase.PURINVMAINDataTable GetPurInvoiceMain()
        {
            var ta = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase.PURINVMAINDataTable();
            ta.Fill(ds);
            return ds;
        }
        public decimal PurchaseSaleValue(string purid)
        {
            var ta = new PurchaseSaleValueTableAdapter { Connection = { ConnectionString = _constr } }; 
            var ds = new DsReports.PurchaseSaleValueDataTable();
            ta.FillByPurchaseSaleValue(ds, purid);
            decimal sval = 0;
            foreach (DataRow d in ds.Rows)
            {
                sval = decimal.Parse(d[0].ToString());
                if (sval == 0)
                    sval = decimal.Parse(d[1].ToString());
            }
            return sval;
        }
        public DsPurchase.PURINVMAINDataTable GetPurInvoiceMainById(string pkid)
        {
            var ta = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase().PURINVMAIN;
            ta.FillByPurid(ds, pkid);
            return ds;
        }
        public DsPurchase.PURINVMAINDataTable GetPurchaseInvoiceByHold()
        {
            var ta = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase.PURINVMAINDataTable();
            ta.FillByHold(ds);
            return ds;
        }
        public DsPurchase.PURINVDETAILDataTable GetPurInvDetailsById(string pkid)
        {
            var ta = new PURINVDETAILTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase().PURINVDETAIL;
            ta.FillBypurid(ds, pkid);
            return ds;
        }
        public int GetPurchaseHoldCount()
        {
            var ds = new DsPurchase.PURINVMAINDataTable();
            var ta = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            return ta.FillByHold(ds);
        }
        public int GetLastReceivedPurchaseQtyWithBonus(string itemno, string comp)
        {
            var ta = new PURINVDETAILTableAdapter {Connection = {ConnectionString = _constr}};
            var lastReceivedQtyWithBonus = ta.LastReceivedQtyWithBonus(itemno) ?? 0;
            return (int)lastReceivedQtyWithBonus;
        }
        public DsPurchase.PurchaseAnalyseDataTable GetItemAnalyse(string itemno)
        {
            var ta = new PurchaseAnalyseTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsPurchase().PurchaseAnalyse;
            ta.Fill(ds, itemno);
            return ds;
        }
        public int GetInvoiceCountWithHold(string invno, string supplier, string purid)
        {
            var ta = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var invoiceCountWithHold = ta.GetInvoiceCountWithHold(supplier, invno, purid)??0;
            return invoiceCountWithHold;
        }
        public int GetInvoiceCount(string invno, string supplier)
        {
            var ta = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var invoiceCountWithHold = ta.GetInvoiceCount(supplier, invno) ?? 0;
            return invoiceCountWithHold;
        }
        public int DoUpdateInv(string pur,string supid,string supname,string invno,DateTime invdate,int duedays)
        {
            var ta = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var taapar = new LedgersTableAdapters.APARMAINTableAdapter { Connection = { ConnectionString = _constr } };
            var taled = new LedgersTableAdapters.LEDGERSTableAdapter { Connection = { ConnectionString = _constr } };
            taapar.UpdateInvoiceDet(supid, invdate, invno, Utils.Company, pur);
            taled.UpdateInvoiceDet(supid, invdate, invno, Utils.Company, pur);
          return  ta.UpdateInvDetails(supid, supname, invno, invdate, duedays, Utils.Userid, DateTime.Now, pur);
        }
        public DsReports.PurchaseBonusDataTable  GetPurchaseBonus(DateTime d1,DateTime d2)
        {
            var ta = new PurchaseBonusTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().PurchaseBonus;
            ta.FillByBonus(ds, d1, d2);
            return ds;
        }
        public DsReports.RptItemPurchaseDetailsDataTable GetRptItemPurchaseDetails(string itemno,DateTime d1,DateTime d2)
        {
            var ta = new RptItemPurchaseDetailsTableAdapter   { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().RptItemPurchaseDetails;
            ta.FillRptItemPurchaseDetails(ds, itemno, d1, d2);
            return ds;
        }
        public DsReports.GetDataByItemGroupDataTable GetDataByItemGroup(int groupid,DateTime d1,DateTime d2)
        {
            var ta = new GetDataByItemGroupTableAdapter   { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().GetDataByItemGroup;
            ta.FillByItemGroup(ds, groupid, d1, d2);
            return ds;
        }
        public DsReports.GetItemGroupAllDataTable GetItemGroupAll(DateTime d1,DateTime d2)
         {
            var ta = new GetItemGroupAllTableAdapter   { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().GetItemGroupAll;
            ta.FillByItemGroupAll(ds, d1, d2);
            return ds;
         }
        public DsPurchase.PURINVMAINDataTable GetPurchaseInvoiceNotSync()
        {
           return new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}}.GetDataByNotUpLoad();
        }
        public void UpdatedSyn(string purid)
        {
            var ta = new PURINVMAINTableAdapter {Connection = {ConnectionString = _constr}};
            ta.UpdatedSyn(purid);
        }
        public DataTable GetItemMasterInPurchase(string purids)
        {
          return  new GetITEMsInPurChaseTableAdapter {Connection = {ConnectionString = _constr}}.GetData(purids);
        }
        public DataTable GetITEMsInTransfer(string tranids)
        {
            return new GetITEMsInTransferTableAdapter { Connection = { ConnectionString = _constr } }.GetData(tranids);
        }
        public DsReports.APARMAIN1DataTable GetPurchaseLedger(string supid, int duedays, int option)
        {
            var ta = new APARMAIN1TableAdapter {Connection = {ConnectionString = _constr}};
            var dt = new DsReports().APARMAIN1;
            if (option==0)
            {
                ta.Fill(dt);
            }
            if(option ==1)
            {
                ta.FillByOnlyDueDays(dt, duedays);
            }
            if (option == 2)
            {
                ta.FillByOnlySuplier(dt, supid);
            }
            if (option == 3)
            {
                ta.FillByDueAndSup(dt, duedays, supid);
            }
            return dt;
        }
        public string GetLastSupplierForItem(string itemno)
        {
            return string.Empty;
        }
    }
    public class PurchasePayment
    {
        private readonly string _constr = Utils.Connectionstring;
        public string DoPost(string batchno,Ledgers.ARAPRECEIPTSDETAILSDataTable dt)
        {
            string retval = string.Empty;
            SqlTransaction tran = null;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);

                var ta = new ARAPRECEIPTSTableAdapter();
                var tadet = new ARAPRECEIPTSDETAILSTableAdapter();

                var taLedger = new LEDGERSTableAdapter();
                 ta.AssignConnection(cn,tran);// tadet.AssignConnection(cn,tran);
               
                taLedger.AssignConnection(cn,tran);
                string arapno = string.Empty;
                foreach (Ledgers.ARAPRECEIPTSDETAILSRow drdet in dt.Rows)
                {
                            if (drdet.RowState != DataRowState.Deleted)
                            {
                                arapno = drdet.ARAPTRANID;
                                var cmdtxt = "update APARMAIN set PAIDAMOUNT = 0 , BALANCE =  INVAMOUNT where  TRANID = " + drdet.TRANID;
                                var cmd = new SqlCommand(cmdtxt, cn, tran);
                                cmd.ExecuteNonQuery();
                                taLedger.Insert("S", drdet.REFNO, DateTime.Now.Date, drdet.INVOICEDATE, batchno,
                                drdet.INVOICENO, - drdet.INVAMOUNT, 0, 18, Utils.Company, Utils.Userid,"Payment Reverse");
                            }
                 }
                tran.Commit();
                //tadet.DeleteByARAPTRANID(batchno);
                //ta.DeleteByARAPTRANID(batchno);
                 ta.DoPost(batchno);
                
                retval = "1";
               
                
            }
            catch (Exception ex)
            {
                if (tran != null) tran.Rollback();
                retval = ex.ToString();
            }
            return retval;
        }
        public string DoSave(Ledgers.ARAPRECEIPTSRow drmain,Ledgers.ARAPRECEIPTSDETAILSDataTable dt)
        {
            SqlTransaction tran = null;
            var isnew = false;
            string retval = string.Empty;
            try
            {
                var cn = new SqlConnection (_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);

                var taPurPaid = new ARAPRECEIPTSTableAdapter {Connection = {ConnectionString = _constr}};

                var dtmain = new Ledgers.ARAPRECEIPTSDataTable();
                var ds = taPurPaid.Fill(dtmain);

                var taPurPaidDet = new ARAPRECEIPTSDETAILSTableAdapter();

                var taApAr = new LedgersTableAdapters.APARMAINTableAdapter();

                var taLedger = new LedgersTableAdapters.LEDGERSTableAdapter();
                taLedger.AssignConnection(cn, tran);

                taPurPaid.AssignConnection(cn,tran);
                var dm = new DataManager();
                taPurPaidDet.AssignConnection(cn,tran);
                  

                var dr = dtmain.FindByARAPTRANID(drmain.ARAPTRANID);
                if (dr != null)
                {
                    dr.BeginEdit();
                }
                else
                {
                    dr = (Ledgers.ARAPRECEIPTSRow) dtmain.NewRow();
                    Utils.PurPayment = dm.GetAutoId(19).ToString("D6");
                    drmain.ARAPTRANID =Utils.PurPayment;
                    dr.ARAPTRANID = Utils.PurPayment;
                    isnew = true;
                }
                dr.AMOUNT = drmain.AMOUNT;
                dr.TDATE = drmain.TDATE;
                dr.BANKID = drmain.BANKID;
                dr.POSTED = false;
                string cmdtxt = string.Empty;
                foreach (Ledgers.ARAPRECEIPTSDETAILSRow drdet in dt.Rows)
                {
                    if (drdet.RowState != DataRowState.Deleted)
                    {
                        drdet.ARAPTRANID = dr.ARAPTRANID;
                        cmdtxt = "update APARMAIN set PAIDAMOUNT = " + drdet.AppliedAmt +
                                     ", BALANCE = 0 where  TRANID = " + drdet.TRANID;
                            var cmd = new SqlCommand(cmdtxt, cn, tran);
                            cmd.ExecuteNonQuery();
                           taLedger.Insert("S", drdet.REFNO, DateTime.Now.Date, drdet.INVOICEDATE, dr.ARAPTRANID,drdet.INVOICENO, drdet.INVAMOUNT,0, 18, Utils.Company, Utils.Userid, "Purchase Payment");
                    }
                }
                if (isnew)
                {
                    dtmain.Rows.Add(dr);
                    taPurPaid.Update(dtmain);
                }
                else
                {
                    dr.EndEdit();
                    taPurPaid.Update(dr); 
                }
                taPurPaidDet.Update(dt);
                tran.Commit();
                dm.UpdateAutoNum(19);

                retval = "1";
            }
            catch (Exception ex)
            {
                tran.Rollback();
                retval = ex.ToString();
            }
            return retval;
        }
        public Ledgers.ARAPRECEIPTSDETAILSDataTable CreatePayeMentList(DsReports.APARMAIN1DataTable dt)
        {
            var ret = new Ledgers.ARAPRECEIPTSDETAILSDataTable ();
            foreach (DsReports.APARMAIN1Row dr in dt.Rows)
            {
                var newrow = (Ledgers.ARAPRECEIPTSDETAILSRow) ret.NewRow();
                newrow.DUEDAYS = dr.DUEDAYS;
                newrow.REFNO = dr.REFNO;
                newrow.TRANID = dr.TRANID;
                newrow.INVOICEDATE = dr.INVOICEDATE;
                newrow.INVOICENO = dr.INVOICENO;
                newrow.INVAMOUNT = dr.INVAMOUNT;
  	            newrow.PAIDAMOUNT = dr.PAIDAMOUNT;
                newrow.BALANCE = dr.BALANCE;
                newrow.DISCOUNT = dr.DISCOUNT;
                ret.Rows.Add(newrow);
            }
            return ret;
        }
        public Ledgers.ARAPRECEIPTSDataTable GetArapReceiptMainPostUnPost(bool isposted)
        {
          return  new ARAPRECEIPTSTableAdapter {Connection = {ConnectionString = _constr}}.GetDataByPOSTED(isposted);
        }
        public Ledgers.ARAPRECEIPTSDataTable GetArapReceiptWithBatchno(string tid)
        {
           return new ARAPRECEIPTSTableAdapter {Connection = {ConnectionString = _constr}}.GetDataByARAPTRANID(tid);
        }
        public Ledgers.ARAPRECEIPTSDETAILSDataTable GetArapreceiptsdetailsWithBatchno(string tid)
        {
           return new ARAPRECEIPTSDETAILSTableAdapter {Connection = {ConnectionString = _constr}}.GetDataByARAPTRANID(tid);
        }
        public string DoDeleteInvoice(Ledgers.ARAPRECEIPTSDETAILSRow dr)
        {
            SqlTransaction tran = null;
            var isnew = false;
            string retval = string.Empty;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);

                var taLedger = new LEDGERSTableAdapter();

                taLedger.AssignConnection(cn, tran);

                //ARAPRECEIPTSDETAILS
                            //    var cmd = new SqlCommand(cmdtxt, cn, tran);
                var cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.Transaction = tran;


                var cmdtxt = "delete from  ARAPRECEIPTSDETAILS where tranid  = " + dr.TRANID + "";

                cmd.CommandText = cmdtxt;
                cmd.ExecuteNonQuery();

                cmdtxt = "update ARAPRECEIPTS set AMOUNT = AMOUNT - " + dr.INVAMOUNT + " where   ARAPTRANID =" + dr.ARAPTRANID;

                                cmd.CommandText = cmdtxt;
                cmd.ExecuteNonQuery();

                cmdtxt = "update APARMAIN set BALANCE = " + dr.INVAMOUNT + " , PAIDAMOUNT = 0 where  tranid = " + dr.TRANID;

                cmd.CommandText = cmdtxt;
                cmd.ExecuteNonQuery();


                taLedger.Insert("S", dr.REFNO, DateTime.Now.Date, dr.INVOICEDATE, dr.ARAPTRANID, dr.INVOICENO,
                    - dr.INVAMOUNT, 0, 18, Utils.Company, Utils.Userid, "Purchase Reverse");
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                tran.Rollback();
                retval = ex.ToString();
            }
            return retval;
        }
    }
     
    public class RemoteSync
    {
        private string _constr = new SqlAsyncConnectionString();
        private string _syncConstr = new SqlAsyncConnectionString(6, true);
        public RemoteSync()
        {
            //if (Utils.Company == "01" || Utils.Company == "00")
            //{
            //   // _constr = Utils.Connectionstring;
            //    _syncConstr = Utils.ConnectionstringSync;
            //}
            //if ( )
            //{
            //    _constr = "Data Source=10.0.0.2;Initial Catalog=POSSTORE;User ID=SA;Password=mutawa2011";
            //    _syncConstr = "Data Source=10.0.0.2;Initial Catalog=SYNC;User ID=SA;Password=mutawa2011"; ;
            //}
        }
        public string DoSavePurchaseRequestInRemote(DsPurchase.PURCHASEREQUESTDataTable  dt)
        {
            var dm = new DataManager();
            string retval="0";
            SqlTransaction tran = null;
            var cn = new SqlConnection(_constr);
            try
            {
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsPurchase();
                var dtdetail = ds.PURCHASEREQUEST;


 
                var taPurDetail = new  PURCHASEREQUESTTableAdapter();

                taPurDetail.AssignConnection(cn, tran);

                foreach (DsPurchase.PURCHASEREQUESTRow ditemdetarow in dt)
                {
                    var newdetrow = dtdetail.NewRow();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (!dc.ReadOnly)
                        {
                            newdetrow[dc.ColumnName] = ditemdetarow[dc.ColumnName];
                        }
                    }
                    dtdetail.Rows.Add(newdetrow);
                }
                taPurDetail.Update(dtdetail);
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                if (cn != null)
                {
                    if (tran != null)
                        tran.Rollback();
                }
                retval = ex.ToString();
            }
            return retval; 
        }
        public string DoSavePurchaseInvoiceInRemote(DsPurchase.PURINVMAINRow mainrow, DsPurchase.PURINVDETAILDataTable purinvdetail)
        {
            var dm = new DataManager();
            string retval="0";
            SqlTransaction tran = null;
          //var possql = new SqlAsyncConnectionString();
            var cn = new SqlConnection(_constr);
            try
            {
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsPurchase();
                var dt = ds.PURINVMAIN;
                var dtdetail = ds.PURINVDETAIL;

                

                var taPurMain = new PURINVMAINTableAdapter();

                var taPurDetail = new PURINVDETAILTableAdapter();

                var taapar = new LedgersTableAdapters.APARMAINTableAdapter();
                var taledger = new LedgersTableAdapters.LEDGERSTableAdapter();

                taPurMain.Connection.ConnectionString = _constr;
                taPurMain.FillByPurid(dt, mainrow.PURINVID);

                   // Assaign Transaction
                taPurMain.AssignConnection(cn, tran);
                taPurDetail.AssignConnection(cn, tran);
                
                taapar.AssignConnection(cn, tran);
                taledger.AssignConnection(cn, tran);
                DsPurchase.PURINVMAINRow dr = null;
               
                if (dt.Rows.Count == 0)
                {
                    dr = (DsPurchase.PURINVMAINRow) dt.NewRow();
                    dr.PURINVID = mainrow.PURINVID;
                    dr.USERID = mainrow.USERID;
                    dr.COMPANY = mainrow.COMPANY;
                    dr.UDATE = mainrow.UDATE;
                    if (!mainrow.IsEDATENull())
                        dr.EDATE = mainrow.EDATE;
                    if (!mainrow.IsEUSERIDNull())
                        dr.EUSERID = mainrow.EUSERID;
                    dr.SUPID = mainrow.SUPID;
                    dr.SUPNAME = mainrow.SUPNAME;
                    dr.INVDATE = mainrow.INVDATE;
                    dr.INVNO = mainrow.INVNO;
                    dr.DUEDAYS = mainrow.DUEDAYS;
                    dr.SPDISCOUNT = mainrow.SPDISCOUNT;
                    dr.WHID = mainrow.WHID;
                    dr.ADJVALUE = mainrow.ADJVALUE;
                    dr.NETVALUE = mainrow.NETVALUE;
                    dr.HOLD = mainrow.HOLD;
                    dt.Rows.Add(dr);
                    taPurMain.Update(dt);
                    //LEDGER
                    taapar.Insert("S", dr.SUPID, mainrow.UDATE, dr.INVDATE, mainrow.PURINVID, dr.INVNO, dr.NETVALUE, 0, dr.NETVALUE, Utils.Company, 1, Utils.Userid, 0);
                    taledger.Insert("S", dr.SUPID, DateTime.Now.Date, dr.INVDATE, mainrow.PURINVID, dr.INVNO, 0,dr.NETVALUE, 1, Utils.Company, Utils.Userid, "Purchase Invoice");
                    foreach (DsPurchase.PURINVDETAILRow ditemdetarow in purinvdetail)
                    {
                        var newdetrow = dtdetail.NewRow();
                        foreach (DataColumn dc in purinvdetail.Columns)
                        {
                            if (!dc.ReadOnly)
                            {
                                newdetrow[dc.ColumnName] = ditemdetarow[dc.ColumnName];
                            }
                        }
                        dtdetail.Rows.Add(newdetrow);
                    }
                    taPurDetail.Update(dtdetail);
                }
                else
                {
               
                    dr = dt.FindByPURINVID(mainrow.PURINVID);
                    var cmd = "UPDATE [PURINVMAIN] SET  SUPID = '" + dr.SUPID + "' ,SUPNAME = '" + dr.SUPNAME +
                              "', INVNO = '" + dr.INVNO + "' ,INVDATE  = '" + dr.INVDATE.ToString("yyyy-MM-dd HH:mm:ss") + "', DUEDAYS] = " + dr.DUEDAYS + " WHERE  PURINVID ='" + dr.PURINVID + "'";
                var sqlcmd2 = new SqlCommand();
                    sqlcmd2.Connection = cn;
                    sqlcmd2.Transaction = tran;
                    sqlcmd2.CommandText = cmd;


                    cmd = "update APARMAIN set REFNO = '" + dr.SUPID + "',INVOICEDATE ='" + dr.INVDATE.ToString("yyyy-MM-dd HH:mm:ss") + "',invoiceno= '" + dr.INVNO + "'  where SOURCEID=1 and  TYPE='S' AND VOUCHERNO='" + dr.PURINVID + "'";
                    var sqlcmd = new SqlCommand();
                    sqlcmd.Connection = cn;
                    sqlcmd.Transaction = tran;
                    sqlcmd.CommandText = cmd;
                    
                    sqlcmd.ExecuteNonQuery();
                    cmd = "update LEDGERS set REFNO = '" + dr.SUPID + "',INVOICEDATE = '" + dr.INVDATE.ToString("yyyy-MM-dd HH:mm:ss") + "' ,invoiceno= '" + dr.INVNO + "'   where  SORUCE =1 and LEDGERTYPE='S' AND VOUCHERNO= '" + dr.PURINVID + "'";
                    var sqlcmd1 = new SqlCommand();
                    sqlcmd1.Connection = cn;
                    sqlcmd1.Transaction = tran;
                    sqlcmd1.CommandText = cmd;
                    sqlcmd1.ExecuteNonQuery();
                }
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                if (cn != null)
                {
                    if (tran != null)
                        tran.Rollback();
                }
                retval = ex.ToString();
            }
            return retval; 
        }
        public string DoSavePurchaseInvoiceReturnInRemote(DsPurchase.RETURNMASTRow drow, DsPurchase.RETURNDETAILDataTable returndetail)
        {
            var dm = new DataManager();
            string retval="0";
            SqlTransaction tran = null;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsPurchase();
                var dt = ds.RETURNMAST;
                var dtdetail = ds.RETURNDETAIL;

                var taPurMain = new RETURNMASTTableAdapter ();
                var taPurDetail = new RETURNDETAILTableAdapter();
                var taapar = new LedgersTableAdapters.APARMAINTableAdapter();
                var taledger = new LedgersTableAdapters.LEDGERSTableAdapter();
  
                // Assaign Transaction
                taPurMain.AssignConnection(cn, tran);
                taPurDetail.AssignConnection(cn, tran);
                taapar.AssignConnection(cn, tran);
                taledger.AssignConnection(cn, tran);
               var  dr = (DsPurchase.RETURNMASTRow)dt.NewRow();  
                    dr.RETURNID = drow.RETURNID;
                    dr.USERID = drow.USERID;
                    dr.COMPANY = drow.COMPANY;
                    dr.TRANDATE = drow.TRANDATE;
                if(!dr.IsEDATENull())
                    dr.EDATE =  dr.EDATE;
                if(!dr.IsEUSERIDNull())
                    dr.EUSERID = dr.EUSERID;
                    dr.SUPID = drow.SUPID;
                    dr.SUPNAME = drow.SUPNAME;
                    dr.INVDATE = drow.INVDATE;
                    dr.INVNO = drow.INVNO;
                    dr.SPDISCOUNT = drow.SPDISCOUNT;
                    dr.WHID = drow.WHID;
                    dr.ADJVALUE = drow.ADJVALUE;
                    dr.NETVALUE = drow.NETVALUE;
                    dr.HOLD = drow.HOLD;
                    dt.Rows.Add(dr);
                    taPurMain.Update(dt);
                //LEDGER
                    taapar.Insert("S", dr.SUPID, drow.TRANDATE, dr.INVDATE, drow.RETURNID, dr.INVNO, -dr.NETVALUE, 0, -dr.NETVALUE, Utils.Company, 2, Utils.Userid, 0);
                    taledger.Insert("S", dr.SUPID, drow.TRANDATE, dr.INVDATE, drow.RETURNID, dr.INVNO, dr.NETVALUE, 0, 2, Utils.Company, Utils.Userid, "Purchase Retun");

                    foreach (DsPurchase.RETURNDETAILRow ditemdetarow in returndetail)
                    {
                        var newdetrow = dtdetail.NewRow();
                        foreach (DataColumn dc in returndetail.Columns)
                        {
                            if (!dc.ReadOnly)
                            {
                                newdetrow[dc.ColumnName] = ditemdetarow[dc.ColumnName];
                            }
                        }
                        dtdetail.Rows.Add(newdetrow);
                    }
                    taPurDetail.Update(dtdetail);
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
        public string DoSaveItemTranferInRemote(DsInventory.ITEMTRANSFERMAINRow drow,DsInventory.ITEMTRANSFERDETAILDataTable itemtransferdetail)
        {
            var dm = new DataManager();
            string retval=string.Empty;
            SqlTransaction tran = null;
            try
            {
                var cn = new SqlConnection(_syncConstr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);

                var ds = new DsInventory();
                var dtdetail = ds.ITEMTRANSFERDETAIL;
                var dt = ds.ITEMTRANSFERMAIN;

                var taPurMain = new ITEMTRANSFERMAINTableAdapter();

                var taPurDetail = new ITEMTRANSFERDETAILTableAdapter();

                taPurMain.Connection.ConnectionString = _syncConstr;

            //   taPurMain.Fill(ds.ITEMTRANSFERMAIN);

                taPurMain.FillByTranid(dt, drow.TRANID);

                // Assaign Transaction
                taPurMain.AssignConnection(cn, tran);
                taPurDetail.AssignConnection(cn, tran);
                
                var dr = dt.FindByTRANID(drow.TRANID);

                if (dr == null)
                {
                    dr = (DsInventory.ITEMTRANSFERMAINRow) dt.NewRow();
                    dr.TRANID = drow.TRANID;
                    dr.COMPANY = drow.COMPANY;
                    if (!drow.IsEDATENull())
                    dr.EDATE = drow.EDATE;
                    if (!drow.IsEUSERIDNull())
                    dr.EUSERID = drow.EUSERID;
                    dr.FRMSTOREID = drow.FRMSTOREID;
                    dr.TOSTOREID = drow.TOSTOREID;
                    dr.TRANDATE = drow.TRANDATE;
                    dr.TOTVALUE = drow.TOTVALUE;
                    dr.TOTITEMS = drow.TOTITEMS;
                    dr.HOLD = drow.HOLD;
                    dr.FRMNAME = drow.FRMNAME;
                    dr.TONAME = drow.TONAME;
                    dr.TTYPE = drow.TTYPE;
                    dr.TOCOMP = drow.TOCOMP;
                    dr.USERID = drow.USERID;
                    dr.DOWNFILENO = drow.DOWNFILENO;
                    dt.Rows.Add(dr);
                    taPurMain.Update(dt);
                    foreach (DsInventory.ITEMTRANSFERDETAILRow  ditemdetarow in itemtransferdetail)
                    {
                        var newdetrow = dtdetail.NewRow();
                        foreach (DataColumn dc in itemtransferdetail.Columns)
                        {
                            if (!dc.ReadOnly)
                            {
                                newdetrow[dc.ColumnName] = ditemdetarow[dc.ColumnName];
                            }
                        }
                        dtdetail.Rows.Add(newdetrow);
                    }
                    taPurDetail.Update(dtdetail);
                    tran.Commit();
                    retval = "1";
                }
                else
                {
                    retval = "1"; 
                }
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                retval = ex.ToString();
            }
            return retval;
        }
        public string DoUpLoadItems(string purid,bool ispurchase)
        {
            string retval = "1";
            var taItem = new DsMasterTableAdapters.ITEMMASTTableAdapter();
            var ds = new DsMaster().ITEMMAST;
            taItem.Connection.ConnectionString = _constr;
            
           // taItem.FillByBarCode()
            DataTable dtitems = null;
            dtitems = ispurchase ? new PurInvDataManager().GetItemMasterInPurchase(purid) : new PurInvDataManager().GetITEMsInTransfer(purid);
            string itemnos = dtitems.Rows.Cast<DataRow>().Aggregate("", (current, dr) => current + (dr["ITEMNO"].ToString() + ","));
           // taItem.FillByItemnos(ds, itemnos);
            bool isnew = false;
            foreach (DataRow dr in dtitems.Rows)
            {
                bool update = true;

                taItem.FillByITEMNO(ds, dr["ITEMNO"].ToString());
                var dsup = ds.FindByITEMNO(dr["ITEMNO"].ToString());
                if (dsup != null)
                {
                    isnew = false;
                    dsup.BeginEdit();
                    update = Equals(dr, dsup);
                }
                else
                {
                    dsup = (DsMaster.ITEMMASTRow)ds.NewRow();
                    isnew = true;
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
                    ds.Rows.Add(dr.ItemArray);
                    var t = taItem.Update(ds);
                    if (t == 0)
                        retval += "item mast not created";
                }
                else
                {
                    dsup.EndEdit();
                    taItem.Update(dsup);
                }
                isnew = false;
            }
            return retval;
        }
        public string DoUpLoadSuppliers()
        {
            string retval = "1";
            var dtsupplier = new DataManager().GetSupplier();
            var ds = new DsMaster().SUPPLIER;
            var taSupplier = new DsMasterTableAdapters.SUPPLIERTableAdapter {Connection = {ConnectionString = _constr}};
            taSupplier.Fill(ds);
            foreach (DataRow dr in dtsupplier.Rows)
            {
                var isnew = false;
                var dsup = ds.FindBySUPPLIERNO(dr["SUPPLIERNO"].ToString());
                if (dsup != null)
                {
                    dsup.BeginEdit();
                }
                else
                {
                    dsup = (DsMaster.SUPPLIERRow)ds.NewRow();
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
                    ds.Rows.Add(dr.ItemArray);
                    var t = taSupplier.Update(ds);
                    if (t == 0)
                        retval += " Supplier master not created";
                }
                else
                {
                    dsup.EndEdit();
                    taSupplier.Update(dsup);
                }
            }
            return retval;
        }
        public string DoUpLoadPromotions(Ledgers.COMMISIONMASTRow CommisionmastRow, Ledgers.COMMISIONDETAILDataTable commisiondetail,bool isRemote=false)
        {
            var dm = new DataManager();
            string retval;
            SqlTransaction tran = null;
            try
            {
                if (isRemote)
                    _syncConstr = Utils.Connectionstring;
                var cn = new SqlConnection(_syncConstr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new Ledgers();
                var dt = ds.COMMISIONMAST;
                var dtdetail = ds.COMMISIONDETAIL;

                var taCommMain = new COMMISIONMASTTableAdapter();
                var taCommDetail = new COMMISIONDETAILTableAdapter();

               

                // Assaign Transaction
                taCommMain.AssignConnection(cn, tran);
                taCommDetail.AssignConnection(cn, tran);

                

                var dr = (Ledgers.COMMISIONMASTRow)dt.NewRow();

                dr.PRMOFRM = CommisionmastRow.PRMOFRM;
                dr.PRMOTO = CommisionmastRow.PRMOTO;
                dr.PROMONAME = CommisionmastRow.PROMONAME;
                dr.STOREID = CommisionmastRow.STOREID;
                dr.EMPNO = CommisionmastRow.EMPNO;
                dr.STATUS = CommisionmastRow.STATUS;
                dr.COMID = CommisionmastRow.COMID;
                dr.USERID = CommisionmastRow.USERID;
                dr.UDATE = DateTime.Now;

                dt.Rows.Add(dr);
                taCommMain.Update(dt);
                //LEDGER
                foreach (Ledgers.COMMISIONDETAILRow ditemdetarow in commisiondetail)
                {
                    var newdetrow = dtdetail.NewRow();
                    foreach (DataColumn dc in commisiondetail.Columns)
                    {
                        if (!dc.ReadOnly)
                        {
                            newdetrow[dc.ColumnName] = ditemdetarow[dc.ColumnName];
                        }
                    }
                    dtdetail.Rows.Add(newdetrow);
                }
                taCommDetail.Update(dtdetail);
                if (isRemote)
                {
                    var dmu = new CommissionSetup();
                    dmu.UpdateSync(dr.COMID, true);
                }
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
        public string UpDateRemoteTransferMain(DsInventory.ITEMTRANSFERMAINDataTable dt)
        {
            string retval = "0";
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var taPurMain = new ITEMTRANSFERMAINTableAdapter();
                    taPurMain.Connection.ConnectionString = _syncConstr;
                    taPurMain.UpdateSync(dr["TRANID"].ToString());
                }
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        public string UpDateRemoteTransferMain(string tranid)
        {
            string retval = "0";
            try
            {
                    var taPurMain = new ITEMTRANSFERMAINTableAdapter();
                    taPurMain.Connection.ConnectionString = _syncConstr;
                    taPurMain.UpdateSync(tranid);
                    retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        public string DoUploadPromotionItems(Ledgers.PROMOITEMSDataTable dtp,bool isRemote)
        {
            string retval;
            SqlTransaction tran = null;
            try
            {
                //isRemote true mean data downloading in local machine , isremote false mean data uploading in sync
                if (isRemote)
                    _syncConstr = Utils.Connectionstring;

                var cn = new SqlConnection(_syncConstr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new Ledgers();

                //var dt = ds.COMMISIONMAST;
                var dtdetail = ds.PROMOITEMS;

                var taCommMain = new PROMOITEMSTableAdapter();
                taCommMain.AssignConnection(cn, tran);
                
                    var clstock = new StockMaster();
                    var clitem = new ItemMaster();
                
                foreach (Ledgers.PROMOITEMSRow ditemdetarow in dtp.Rows)
                {
                    var newdetrow = dtdetail.NewRow();


                    //dtdetail.TIDColumn.AutoIncrement = false;
                    //dtdetail.TIDColumn.ReadOnly = false;

                    if (isRemote)
                    {
                        clstock.UpdateSpriceByItemno(ditemdetarow.ITEMNO, ditemdetarow.NEWPRICE, ref cn, ref tran);
                        clitem.UpdateSpriceByItemno(ditemdetarow.ITEMNO, ditemdetarow.NEWPRICE, ref cn, ref tran);
                    }
                    foreach (DataColumn dc in dtp.Columns)
                    {
                        //if (!dc.ReadOnly)
                        //{
                        
                            newdetrow[dc.ColumnName] = ditemdetarow[dc.ColumnName];
                       // }
                    }
                    dtdetail.Rows.Add(newdetrow);
                }
                taCommMain.Update(dtdetail);
                 
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
        public string DoDownLoadCustomer()
        {
            string retval = "1";
            var _remotecustomer = new Customer().GetCustomerMembersDataTable(true, _syncConstr);
            var ds = new DsMaster().CUSTOMER;
            var taCustomer = new DsMasterTableAdapters.CUSTOMERTableAdapter{Connection = { ConnectionString = Utils.Connectionstring } };
            taCustomer.Fill(ds);
            foreach (DataRow dr in _remotecustomer.Rows)
            {
                var isnew = false;
                var dsup = ds.FindByCUSTNO(dr["CUSTNO"].ToString());
                if (dsup != null)
                {
                    dsup.BeginEdit();
                }
                else
                {
                    dsup = (DsMaster.CUSTOMERRow)ds.NewRow();
                    isnew = true;
                    foreach (DataColumn dc in _remotecustomer.Columns)
                    {
                        if (dc.ColumnName == "CUSTOMERPOINT")
                        {
                            dsup[dc.ColumnName] = 0;
                        }
                        else
                        {
                            dsup[dc.ColumnName] = dr[dc.ColumnName];
                        }
                    }
                }
                bool update = true;
                if (!isnew)
                {
                    update = Equals(dr, dsup);
                }
                if (!update)
                {
                    foreach (DataColumn dc in _remotecustomer.Columns)
                    {
                        if (dc.ColumnName == "CUSTOMERPOINT")
                        {
                            dsup[dc.ColumnName] = 0;
                        }
                        else
                        {
                            dsup[dc.ColumnName] = dr[dc.ColumnName];
                        }
                    }
                }
                if (isnew)
                {
                    ds.Rows.Add(dsup);
                    var t = taCustomer.Update(ds);
                    if (t == 0)
                        retval += "Customer master not created";
                }
                else
                {
                    dsup.EndEdit();
                    taCustomer.Update(dsup);
                }
            }
            return retval;
        }
        public decimal GetAvailablePoints(string custno)
        {
            return new Customer().GetAvailblePoints(custno, true, _syncConstr);
        }
        public string  SetAvailablePoints(string custno,decimal points)
        {
            return new Customer().UpdateCustomerPoints(custno, points, _syncConstr);
        }

        public string UpdatePointsDetails(Ledgers.CUSTOMERPOINTSRow dr)
        {
          return  new Customer().UpdatePointsDetails(dr.CUSTNO,dr.POINTS,dr.COMP,dr.REDIMDT, dr.REDMIVOU,dr.REDIMAMT, true, _syncConstr);
        }
        //public string SetRedimPoints(string custno,decimal actpoints,decimal redimpoints,string invno)
        //{
        //    return "p";
        //}
        
    }
}
