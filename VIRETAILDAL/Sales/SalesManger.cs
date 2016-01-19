using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;

namespace VIRETAILDAL.Sales
{
    public class SalesManger
    {
        private readonly string _constr = Utils.Connectionstring;
        public DsInventory.SALESMAINRow salesmainRow;
        public DsInventory.SALESINVDETAILDataTable salesinvdetailData;
        public Ledgers.SalesAmountDetailsDataTable SalesAmount;
        public string DoSave()
        {
            SqlTransaction tran = null;
            var retval = "0";
            try
            {
                var dsStockWithItemcodes = GetStockTableWithItemCodes(salesinvdetailData);
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsInventory();

                var dt = ds.SALESMAIN;
                var tasalMain = new DsInventoryTableAdapters.SALESMAINTableAdapter();
                var tasalDetail = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter();
                var tasalesamtdetails = new LedgersTableAdapters.SalesAmountDetailsTableAdapter();

                tasalesamtdetails.AssignConnection(cn, tran);
                tasalMain.Connection.ConnectionString = _constr;

               // tasalMain.Fill(dt);
                tasalMain.FillBySINVNO(dt,salesmainRow.SINVNO);
                tasalMain.AssignConnection(cn, tran);
                tasalDetail.AssignConnection(cn, tran);

                var dr = dt.FindBySINVNO(salesmainRow.SINVNO);
                bool isnew = false;
                if (dr != null)
                {
                    dr.BeginEdit();
                    dr.EndEdit();
                }
                else
                {
                    dr = (DsInventory.SALESMAINRow) dt.NewRow();
                    dr.ItemArray = salesmainRow.ItemArray;
                    isnew = true;
                }
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    tasalMain.Update(dt);
                }
                else
                {
                    tasalMain.Update(salesmainRow);
                }
                //salesmainRow.SALESTYPE 
            
                if (salesmainRow.SALESTYPE == "I" || salesmainRow.SALESTYPE == "C")
                {
                    var taaparleder = new LedgersTableAdapters.APARMAINTableAdapter();
                    var taledger = new LedgersTableAdapters.LEDGERSTableAdapter();
                    taledger.AssignConnection(cn, tran);
                    taaparleder.AssignConnection(cn, tran);
                    var netamt = 0m;
                    var totaldiscper = 0m;
                    if (salesmainRow.SALESTYPE == "I")
                    {
                        totaldiscper = salesmainRow.CUSTOMERFIXDISC ;
                        netamt = salesmainRow.CREDITAMT;
                    }
                    else
                    {
                        netamt = salesmainRow.CREDITAMT;
                        totaldiscper = salesmainRow.CUSTOMERFIXDISC ;
                    }
                    if (netamt > 0)
                    {
                        string cdno = "";
                        if (!salesmainRow.IsCARDNONull())
                            cdno = salesmainRow.CARDNO.ToString();
                        taaparleder.Insert("C", salesmainRow.CUSTOMERID, salesmainRow.TRANDATE,
                                           salesmainRow.TRANDATE,
                                           cdno, salesmainRow.SINVNO, netamt, 0, netamt,
                                           salesmainRow.COMPANY,
                                           3, salesmainRow.SALESMAN, totaldiscper);

                        taledger.Insert("C", salesmainRow.CUSTOMERID, salesmainRow.TRANDATE,
                                        salesmainRow.TRANDATE, cdno,
                                        salesmainRow.SINVNO, netamt, 0, 3, salesmainRow.COMPANY,
                                        Utils.Userid, "Sales Invoice");
                    }
                }
                foreach (DsInventory.SALESINVDETAILRow  drstk in salesinvdetailData.Rows)
                {
                    if(!drstk.IsSTOCKIDNull())
                    {
                        if(drstk.STOCKID > 0)
                        {
                            if (drstk.ISRETURN)
                            {
                                 UpdateStockQty(ref cn, ref tran, drstk.STOCKID, (drstk.QTY * -1), drstk);
                            }
                            else
                            {
                                 UpdateStockQty(ref cn, ref tran, drstk.STOCKID, -drstk.QTY, drstk);
                            }
                        }
                        else
                        {
                            if (drstk.ISRETURN)
                            {
                                AddNewItemItemInStock(ref cn, ref tran, drstk, dsStockWithItemcodes);
                            }
                        }
                    }
                }
                tasalDetail.Update(salesinvdetailData);
                tasalesamtdetails.Update(SalesAmount);

                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                tran.Rollback();
            }
            return retval;
        }
        public DsInventory.STOCKMASTERDataTable GetStockTableWithItemCodes(DsInventory.SALESINVDETAILDataTable salesinvdetail)
        {
            var dsItemCodes = new DsInventory().STOCKMASTER;
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            string itemcodes = string.Empty;
            foreach (DsInventory.SALESINVDETAILRow drts in salesinvdetail.Rows)
            {
                if (drts.ISRETURN)
                {
                    itemcodes += drts.ITEMNO + ",";
                }
            }
            ta.FillByItemcodes(dsItemCodes, itemcodes);
            return dsItemCodes;
        }
        public string DoSave(string sinvo, bool hold, int salesman, int doctorid, string shiftcode, string compname,decimal totamt=0,decimal netamt=0)
        {
            string retval = "1";
            try
            {
                var ta = new DsInventoryTableAdapters.SALESMAINTableAdapter {Connection = {ConnectionString = _constr}};
                var t = ta.Insert(sinvo, null, null, null, null,totamt, null, netamt, null, salesman, doctorid,
                                  Utils.Company,
                                  shiftcode, null, null, hold, compname, null, false, DateTime.Now, null, null, null,
                                  null, null, null, 0, 0, 0, 0, false, 0, 0, 0, false, false,null) > 0;
         
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        public string DeleteSalesInvDetail(string salesinv)
        {
            SqlTransaction tran = null;
            var retval = "0";
            try
            {
                var cn = new SqlConnection(_constr);
                var salesinvdet = new DsInventory.SALESINVDETAILDataTable();
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ta = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter();

                var ta1 = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter();
                ta1.Connection.ConnectionString = _constr;
                ta1.FillBySINVNO(salesinvdet, salesinv);
                

                ta.AssignConnection(cn, tran);

                foreach (DsInventory.SALESINVDETAILRow dRow in salesinvdet.Rows)
                {
                    DoSalesItemDelete(dRow, ref cn, ref tran);
                }
                ta.DeleteSalesInvDetail(salesinv);
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                tran.Rollback();
            }
            return retval;
        }
        public string UpdateSalesInvDetail(DsInventory.SALESINVDETAILDataTable sales)
        {
            string retval = "1";
            try
            {
                var ta = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter();
                ta.Connection.ConnectionString = _constr;
                ta.Update(sales);
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        public void UpdateQty(int stockid, int qty)
        {
            try
            {
                var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter
                {
                    Connection = {ConnectionString = _constr}
                };
                ta.UpdateSaleQtyByStockid(qty, stockid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string UpdateQtyAndSalesTable(int stockid,int qty,DsInventory.SALESINVDETAILDataTable salesinvdetail)
        {
            string retval = "0";
            SqlTransaction tran = null;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsInventory();
                var tasalDetail = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter();
                var tastock = new DsInventoryTableAdapters.STOCKMASTERTableAdapter();
                tasalDetail.AssignConnection(cn, tran);
                tastock.AssignConnection(cn, tran);
                tastock.UpdateSaleQtyByStockid(qty, stockid);
                tasalDetail.Update(salesinvdetail);
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                tran.Rollback();
            }
            return retval;
        }
        public void UpdateStockQty(ref SqlConnection cn, ref SqlTransaction tran, int stockid, int qty,DataRow d)
        {
            string wh = Utils.SalesStoreCode;
            const string storetype = "S";
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = cn, Transaction = tran };
            if(stockid==0)
            {
             ta.Insert(d["ITEMNO"].ToString(),
                      d["BARCODE"].ToString(),
                      int.Parse(d["QTY"].ToString()),
                      decimal.Parse(d["SPRICE"].ToString()),
                      decimal.Parse(d["CPRICE"].ToString()),
                      !string.IsNullOrEmpty(d["EXPDATE"].ToString()) ? DateTime.Parse(d["EXPDATE"].ToString()) : (DateTime?)null,
                      storetype, null, null, null,false, 
                      wh, Utils.Company,int.Parse(d["QTY"].ToString()),null); 
            }
            else
            {
                ta.UpdateQtyByStockID(qty, stockid);
            }
        }
        public void UpdateSprice(decimal sprice,int stockid)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter {Connection = {ConnectionString = _constr}};
            ta.UpdateSPRICE(sprice, stockid);
        }
        public string GetInvoiceNo(int srcid=14)
        {
            var dm = new DataManager();
            var autoid = dm.GetAutoId(srcid);
            autoid++;
            string retval =  Utils.Company +  autoid.ToString("D8"); // dm.CreateFormatedAutoNo(autoid);
            dm.UpdateAutoNum(srcid);
            return retval;
        }
        public DsInventory.STOCKMASTERDataTable GetStockItem(string itemno, string storetype)
        {
           return new Masters.StockMaster().GetStockItem(itemno, storetype);
        }
        public DsInventory.STOCKMASTERDataTable GetStockItemBySprice(string itemno, string storetype,decimal sprice)
        {
            return new Masters.StockMaster().GetStockItemBySprice(itemno, storetype, sprice);
        }
        public void AddNewItemwithNegativeQty(DataRow d)
        {
            new Masters.StockMaster().AddNewItemwithNegativeQty(d);
        }
        void AddNewItemItemInStock(ref SqlConnection cn, ref SqlTransaction tran, DataRow dr, DsInventory.STOCKMASTERDataTable ds)
        {
            new Masters.StockMaster().AddNewItemItemInStock(ref cn,ref tran, dr,ds);
        }
        public void DoSalesItemDelete(DsInventory.SALESINVDETAILRow dRow, ref SqlConnection cn, ref SqlTransaction tran)
        {
        // tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);

            var dt = new DsInventory.SALESINVDETAIL_DELDataTable();
            var tastock = new DsInventoryTableAdapters.STOCKMASTERTableAdapter();
            var tasalede = new DsInventoryTableAdapters.SALESINVDETAIL_DELTableAdapter();
            tastock.AssignConnection(cn, tran);
            tasalede.AssignConnection(cn, tran);
            var dr = (DsInventory.SALESINVDETAIL_DELRow) dt.NewRow();
            dr.SINVNO = dRow.SINVNO;
            dr.ITEMNO = dRow.ITEMNO;
            dr.BARCODE = dRow.BARCODE;
            dr.QTY = dRow.QTY;
            dr.INVRATE = dRow.INVRATE;
            dr.SPRICE = dRow.SPRICE;
            dr.CPRICE = dRow.CPRICE;
            if(!dRow.IsEXPDATENull())
                dr.EXPDATE =  dRow.EXPDATE;
            dr.STOCKID = dRow.STOCKID;
            dr.STOCK = dRow.STOCK;
            dr.DOCTORID = dRow.DOCTORID;
            dr.ITEMNAME = dRow.ITEMNAME;
            dr.COMPANY = Utils.Company;
            dr.TRANDATE = DateTime.Now;
            dr.USERID = Utils.Userid;
            tasalede.Update(dr);
            if (dr.STOCKID > 0)
            {
                if (dr.ISRETURN)
                    tastock.UpdateSaleQtyByStockid(-dr.QTY, dr.STOCKID);
                else
                    tastock.UpdateSaleQtyByStockid(dr.QTY, dr.STOCKID);
            }
            //if (dRow.STOCKID > 0)
            //{
            //   // tastock.UpdateQtyByStockID(dRow.QTY, dRow.STOCKID);
            //    tastock.UpdateSaleQtyByStockid(dRow.QTY, dRow.STOCKID);
            //}
        }
        public string DoSalesItemDelete(DsInventory.SALESINVDETAILRow dr)
        {
            SqlTransaction tran = null;
            var retval = "0";
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var dt = new DsInventory.SALESINVDETAIL_DELDataTable();

                var tastock = new DsInventoryTableAdapters.STOCKMASTERTableAdapter();
                var tasalede = new DsInventoryTableAdapters.SALESINVDETAIL_DELTableAdapter();
               // var tasales = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter();


                tastock.AssignConnection(cn, tran);
                tasalede.AssignConnection(cn, tran);
              //  tasales.AssignConnection(cn,tran);

                var dr1 = (DsInventory.SALESINVDETAIL_DELRow)dt.NewRow();
                dr1.SINVNO = dr.SINVNO;
                dr1.ITEMNO = dr.ITEMNO;
                dr1.BARCODE = dr.BARCODE;
                dr1.QTY = dr.QTY;
                dr1.INVRATE = dr.INVRATE;
                dr1.SPRICE = dr.SPRICE;
                dr1.CPRICE = dr.CPRICE;
                if (!dr.IsEXPDATENull())
                    dr1.EXPDATE = dr.EXPDATE;
                dr1.STOCKID = dr.STOCKID;
                dr1.STOCK = dr.STOCK;
                dr1.DOCTORID = dr.DOCTORID;
                dr1.ITEMNAME = dr.ITEMNAME;
                dr1.COMPANY = Utils.Company;
                dr1.TRANDATE = DateTime.Now;
                dr1.USERID = Utils.Userid;
                dr1.ISRETURN = dr.ISRETURN;
                dt.Rows.Add(dr1);
                //tasalede.Insert(dr.SINVNO, dr.ITEMNO, dr.BARCODE, dr.QTY, dr.INVRATE, dr.SPRICE, dr.CPRICE, dr.EXPDATE,
                //                dr.STOCKID, dr.STOCK, dr.DOCTORID, dr.ITEMNAME, Utils.Company, DateTime.Now, Utils.Userid,dr.ISRETURN);
                tasalede.Update(dr1);
                if (dr.STOCKID > 0)
                {
                   if(dr.ISRETURN)
                        tastock.UpdateSaleQtyByStockid((-1* dr.QTY), dr.STOCKID);
                    else
                        tastock.UpdateSaleQtyByStockid(dr.QTY, dr.STOCKID);
                }
               // tasales.Update(salesinvdetail);
                
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                tran.Rollback();
            }
            return retval;
        }
        public DsInventory.SALESMAINDataTable GetSalesInvMain(string invno, bool issale = false, bool hold = false)
        {
            var ds = new DsInventory.SALESMAINDataTable();
            var ta = new DsInventoryTableAdapters.SALESMAINTableAdapter {Connection = {ConnectionString = _constr}};
            ta.FillByInvno(ds, invno, issale, hold);
            return ds;
        }
        public void GetNonSaleInv()
        {
            var tasalMain = new DsInventoryTableAdapters.SALESMAINTableAdapter
                                {Connection = {ConnectionString = _constr}};

            var tasaldetail = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter
                                  {Connection = {ConnectionString = _constr}};

            var ds = new DsInventory();
            tasalMain.FillByNonPost(ds.SALESMAIN, Environment.MachineName);
            if (ds.SALESMAIN.Rows.Count > 0)
            {
                salesmainRow = ds.SALESMAIN[0];
                var sinvno = salesmainRow[0].ToString();
                try
                {
                    tasaldetail.FillBySINVNO(ds.SALESINVDETAIL, sinvno);
                    salesinvdetailData = ds.SALESINVDETAIL;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }

            }
        }
        public void GetSalesInvDetails(string invno)
        {
            var tasaldetail = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter();
            tasaldetail.Connection.ConnectionString = _constr;
            salesinvdetailData = new DsInventory.SALESINVDETAILDataTable();
            tasaldetail.FillBySINVNO(salesinvdetailData, invno);
        }
        public void DeleteSalesInvMain(string sinvno)
        {
            var ta = new DsInventoryTableAdapters.SALESMAINTableAdapter() {Connection = {ConnectionString = _constr}};
            ta.DeleteSalesInvMainOnly(sinvno);
        }
        public void DoHold(string sino, string customerid, string customername, decimal sdisc, decimal rounding)
        {
            var ta = new DsInventoryTableAdapters.SALESMAIN1TableAdapter {Connection = {ConnectionString = _constr}};
            ta.DoHold(customerid,customername,sdisc ,rounding,sino);
        }
        public DsInventory.SALESMAINDataTable GetHoldedInvoices(string compname)
        {
            var ta = new DsInventoryTableAdapters.SALESMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory();
            ta.FillByHold(ds.SALESMAIN, compname);
            return ds.SALESMAIN;
        }
        public void DoUnHold(string invno)
        {
            var ta = new DsInventoryTableAdapters.SALESMAIN1TableAdapter {Connection = {ConnectionString = _constr}};
            ta.DoUnHold(invno);
        }
        public DsReports.SalesInvListDataTable GetSalesReport(string invno = null)
        {
            var ta = new DsReportsTableAdapters.taSalesInvList {Connection = {ConnectionString = _constr}};
            var ds = new DsReports().SalesInvList;
            if (invno == null)
                ta.Fill(ds, false);
            else
            {
                ta.FillBySalesInv(ds, true, false, invno);
            }
            return ds;
        }
        public DsReports.SalesInvListDataTable GetSalesReportByDate(DateTime d1,DateTime d2)
        {
            var ds = new DsReports().SalesInvList;

            try
            {
                var ta = new DsReportsTableAdapters.taSalesInvList { Connection = { ConnectionString = _constr } };
            ta.FillByTrandate(ds, false, d1, d2);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        public DsInventory.SALESMAINDataTable GetSalesInvMainBySinvno(string sinvno)
        {
            var ta = new DsInventoryTableAdapters.SALESMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory().SALESMAIN;
            ta.FillBySINVNO(ds,sinvno);
            return ds;

        }
        public void UpdateSalesMain(DataRow dr)
        {
            //string retval = "1";
            //try
            //{
                var ta = new DsInventoryTableAdapters.SALESMAINTableAdapter { Connection = { ConnectionString = _constr } };
                ta.Update(dr);
            //    var t = ta.Insert(sinvo, null, null, null, null, null, null, null, null, salesman, doctorid,
            //                      Utils.Company,
            //                      shiftcode, null, null, hold, compname, null, false, DateTime.Now, null, null, null,
            //                      null, null, null, 0, 0, 0, 0, false, 0, 0, 0, false, false) > 0;
            //}
            //catch (Exception ex)
            //{
            //    retval = ex.ToString();
            //}
            //return retval;

        }
        public IEnumerable<decimal> GetDisctinctSprices(DataTable dt)
        {
            var sprice = new List<decimal>();
            foreach (DsInventory.STOCKMASTERRow dr  in dt.Rows)
            {
              sprice.Add(dr.SPRICE);
            }
           // sprice.AddRange(from DsInventory.STOCKMASTERRow dr in dt.Rows select dr.SPRICE);

            IEnumerable<decimal> dprice = sprice.Distinct();
            return dprice;
            //int cnt = dprice.Count();
            //return cnt > 1;
        }
        public string GetExpiryDt(string itemno)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetExpiryDt(itemno, Utils.Company).ToString();

        }
        public int GetAvailableQty(string itemno)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter {Connection = {ConnectionString = _constr}};
            return ta.GetSaleStockByItemNo(itemno, Utils.Company) ?? 0;
        }
        public int GetStockByItemno(string itemno)
        {
            return Convert.ToInt32( new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } }.GetAvailableQty(itemno));
            //var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = usenewcon ? newcon : _constr } };
            //return Convert.ToInt32(ta.GetAvailableQty(itemno));
        }
        public DataTable GetStock(string itemno)
        {
            var str = "Select sum(qty) as QTY,sprice ,avg(cprice) as CPRICE from stockmaster where itemno ='" + itemno + "' group by sprice  ";
            var ta = new SqlDataAdapter(str, _constr);
            var dt = new DataTable();
            ta.Fill(dt);
            return dt;

        }
        public int GetAvailableSQty(int itemid)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetAvailableSQty(itemid) ?? 0;
        }
        public int GetSoldQty(string itemno)
        {
            var ta = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter { Connection = { ConnectionString = _constr } };
           return   ta.GetSoldQtyByItemNo(itemno) ?? 0;
        }
        public int GetReturnQty(string itemno)
        {
            var ta = new DsInventoryTableAdapters.SALESINVDETAILTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetReturnQty(itemno) ?? 0;
        }
        public int GetAdjQty(string itemno)
        {
            var cn = new SqlConnection(_constr);
            cn.Open();
            var strcmd = "SELECT isnull(SUM(ADJQTY-ACTQTY),0) AS ADJQTY FROM ADJMAST INNER JOIN ADJDETAIL ON ADJMAST.ADJID= ADJDETAIL.ADJID ";
            strcmd += " WHERE   ITEMNO = '" + itemno + "' AND ADJQTY >= 0 ";
            var cmd = new SqlCommand(strcmd, cn);
            var retval = Convert.ToInt32(cmd.ExecuteScalar());
            return retval;
        }
        public int GetTransferedQty(string itemno)
        {
            var cn = new SqlConnection(_constr);
            cn.Open();
            var strcmd =
                " SELECT     isnull(SUM( ITEMTRANSFERDETAIL.QTY),0) FROM   ITEMTRANSFERMAIN INNER JOIN ITEMTRANSFERDETAIL ON ITEMTRANSFERMAIN.TRANID = ITEMTRANSFERDETAIL.TRANID ";
            strcmd += " WHERE ITEMNO ='" + itemno + "' and  ITEMTRANSFERMAIN.COMPANY = '" + Utils.Company + "'";
            var cmd = new SqlCommand(strcmd, cn);
            var retval = Convert.ToInt32(cmd.ExecuteScalar());
            return retval;
        }
        public int GetReceivedQty(string itemno)
        {
            var cn = new SqlConnection(_constr);
            cn.Open();
            var strcmd =
                " SELECT     isnull(SUM( ITEMTRANSFERDETAIL.QTY),0) FROM   ITEMTRANSFERMAIN INNER JOIN ITEMTRANSFERDETAIL ON ITEMTRANSFERMAIN.TRANID = ITEMTRANSFERDETAIL.TRANID ";
            strcmd += " WHERE ITEMNO ='" + itemno + "' and  ITEMTRANSFERMAIN.TOCOMP = '" + Utils.Company + "'";
            var cmd = new SqlCommand(strcmd, cn);
            var retval = Convert.ToInt32(cmd.ExecuteScalar());
            return retval;
        }
        public int GetOpeningQty(string itemno)
        {
            var ta = new DsInventoryTableAdapters.YearEndInventoryTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetOpeningQty(itemno) ?? 0;
        }
        public int CheckSalesHoldByStockid(int stockid)
        {
            var cn = new SqlConnection(_constr);
            cn.Open();
            var strcmd =
                " SELECT     COUNT(*) FROM     dbo.SALESMAIN INNER JOIN dbo.SALESINVDETAIL ON dbo.SALESMAIN.SINVNO = dbo.SALESINVDETAIL.SINVNO ";
            strcmd += " where dbo.SALESMAIN.POSTED =0   and STOCKID = " + stockid + "";
            var cmd = new SqlCommand(strcmd, cn);
            var retval = Convert.ToInt32(cmd.ExecuteScalar());
            return retval;
        }
       //GetAvailableSQty
        public int GetTotalSalesQty(string itemno,DateTime d1,DateTime d2)
        {
          var cn = new SqlConnection(_constr);
            cn.Open();
            var strcmd =
                "select isnull(sum(QTY) ,0) from SALESMAIN inner join SALESINVDETAIL on SALESMAIN.SINVNO = SALESINVDETAIL.SINVNO ";
            strcmd += " where (TRANDATE BETWEEN '" + d1.ToString("yyyy-MM-dd") + "' AND DATEADD(s,-1,DATEADD(d,1,'" + d2.ToString("yyyy-MM-dd") + "'))) and (ITEMNO = '" + itemno + "') and (POSTED=1)  ";
            var cmd = new SqlCommand(strcmd, cn);
            var retval = Convert.ToInt32(cmd.ExecuteScalar());
            return retval;
        }
        public Ledgers.APARMAINDataTable GetSupCustUnPaidInvoices(string refno, string ctype)
        {
            var ta = new LedgersTableAdapters.APARMAINTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new Ledgers().APARMAIN;
            ta.FillByCustSup(ds, ctype, refno, Utils.Company);
            return ds;
        }
        public DsInventory.SALESINVDETAIL_DELDataTable GetSalesDeletedItems(DateTime d1,DateTime d2)
        {
            var ta = new DsInventoryTableAdapters.SALESINVDETAIL_DELTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsInventory().SALESINVDETAIL_DEL;
            ta.FillBy(ds, d1 , d2);
            return ds;
        }
        public DsReports.PivotDailySalesDataTable LoadPivotGrid(DateTime d1, DateTime d2, bool useother = false,string cnstr = "x")
        {
            return
                new DsReportsTableAdapters.PivotDailySalesTableAdapter
                {
                    Connection = { ConnectionString = useother ? cnstr : _constr }
                }.GetData(d1, d2);
        }
        public DsReports.ConsolidatePivotDailySalesDataTable ConsolidateLoadPivotGrid(DateTime d1, DateTime d2)
        {
            return new DsReportsTableAdapters.ConsolidatePivotDailySalesTableAdapter{ Connection = { ConnectionString = _constr } }.GetData(d1, d2);
        }

       

    }
    public class CustomerPayment
    {
        public Ledgers.APARMAINDataTable AparmainData;
        private readonly string _constr = Utils.Connectionstring;
        public string customerno;
        public decimal AppliedAmt;
        public decimal outstanding;
        public DateTime trandate;
        public string customertype;
        public int amountype;
        public string shiftcode;
        public int userid;
        public string DoSave()
        {
            string retval = "0";
            SqlTransaction tran = null;
            try
            {
                var cn = new SqlConnection { ConnectionString = _constr };
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var dm = new DataManager();
                var dt = new Ledgers.APARMAINDataTable();
                var ta = new LedgersTableAdapters.APARMAINTableAdapter {Connection = {ConnectionString = _constr}};
                ta.Fill(dt);
                var taleder = new LedgersTableAdapters.LEDGERSTableAdapter();
                taleder.AssignConnection(cn,tran);
                ta.AssignConnection(cn, tran);

                var tasalesamtdetails = new LedgersTableAdapters.SalesAmountDetailsTableAdapter();

                tasalesamtdetails.AssignConnection(cn, tran);

                
                var autoid =  dm.GetAutoId(17);
                autoid++;
                Utils.CustomerReceipt = dm.CreateFormatedAutoNo(autoid);
                ta.Update(AparmainData);
                var bl = new SalesManger().GetInvoiceNo(17);
                taleder.Insert("C", customerno, trandate,
                                    trandate, Utils.CustomerReceipt,
                                    Utils.CustomerReceipt,0 , AppliedAmt, 17, Utils.Company,
                                    Utils.Userid, "Customer Receipt");
                tasalesamtdetails.Insert(trandate, null, customerno, "C", amountype, AppliedAmt, shiftcode, false, Utils.Company,userid, false, null);

                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                if (tran != null) tran.Rollback();
            }
            return retval;

        }
    }
}
