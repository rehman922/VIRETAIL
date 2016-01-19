using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace VIRETAILDAL.Masters
{
    public class StoreManager
    {
        private readonly string _constr = Utils.Connectionstring;
        public string storecode { get; set; }
        public string storetype { get; set; }
        public string storename { get; set; }
        public string address { get; set; }
        public string phono { get; set; }
        public string fax { get; set; }
        public int communicationtype { get; set; }
        public string COMPANY { get; set; }
        // public DsMaster.STOREMASTRow StoremastRow;
        public string DoSave()
        {
            string retval="0";
            SqlTransaction tran = null;
            var isnew = false;
            try
            {
                var cn = new SqlConnection {ConnectionString = _constr};
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var dt = new DsMaster().STOREMAST;
                var ta = new DsMasterTableAdapters.STOREMASTTableAdapter();
                ta.Connection.ConnectionString = _constr;
                ta.Fill(dt);
                ta.AssignConnection(cn, tran);
                var dr = dt.FindBySTORECODE(storecode);
                if (dr != null)
                {
                    dr.BeginEdit();
                    dr.EditedBy = Utils.Userid;
                }
                else
                {
                    dr = (DsMaster.STOREMASTRow) dt.NewRow();
                    isnew = true;
                    var autoid = new DataManager().GetAutoId(9);
                    autoid++;
                    storecode = String.Format("{0,-2:D2}", autoid);
                    dr.CREATEDBY = Utils.Userid;
                    dr.CREATEDATE = System.DateTime.Now.Date;
                }
                dr.STORECODE = storecode;
                dr.STORETYPE = storetype;
                dr.STORENAME = storename;
                dr.ADDRESSS = address;
                dr.PHONENO = phono;
                dr.FAXNO = fax;
                dr.COMM = communicationtype;
                dr.COMPANY = COMPANY;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }
                new DataManager().UpdateAutoNum(9);
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
        public DsMaster.STOREMASTDataTable GetStoreList()
        {
            var dt = new DsMaster().STOREMAST;
            var ta = new DsMasterTableAdapters.STOREMASTTableAdapter {Connection = {ConnectionString = _constr}};
            ta.Fill(dt);
            return dt;
        }
        public DsMaster.STOREMASTDataTable GetMyWareHouses()
        {
            var dt = new DsMaster().STOREMAST;
            var ta = new DsMasterTableAdapters.STOREMASTTableAdapter { Connection = { ConnectionString = _constr } };
            ta.FillByMyWareHouse(dt,Utils.Company);
            return dt;
        }
        public DsMaster.STOREMASTDataTable GetAllSalesStore()
        {
            var dt = new DsMaster().STOREMAST;
            var ta = new DsMasterTableAdapters.STOREMASTTableAdapter { Connection = { ConnectionString = _constr } };
            ta.FillByALLSalesStore(dt);
            return dt;
        }
        public string GetSalesStore()
        {
            var retval = string.Empty;
            var ta = new DsMasterTableAdapters.STOREMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().STOREMAST;
            ta.FillBySalesStore(ds, Utils.Company);
            if (ds.Rows.Count > 0)
                retval = ds[0][0].ToString();
            return retval;
        }
        public string GetStoreType(string scode)
        {
            var ta = new DsMasterTableAdapters.STOREMASTTableAdapter {Connection = {ConnectionString = _constr}};
            return ta.GetStoreType(scode).ToString();
        }
        public DataTable GetAllDataBaseName()
        {
            var dt = new DataTable();
            var cmd = "SELECT name FROM master..sysdatabases";
            var cn = new SqlConnection(_constr);

            var ta = new SqlDataAdapter(cmd, cn);
            ta.Fill(dt);
            return dt;
        }
        public DsMaster.GetAllDataBasesDataTable GetAllDataBases()
        {
           return new DsMasterTableAdapters.GetAllDataBasesTableAdapter() { Connection = { ConnectionString = _constr } }.GetData();

        }
        public DataTable GetStoresDataBases()
        {
            var dt = new DsMaster().STOREDATABASES;
            var ds = GetAllDataBases();
            string[] connew = Utils.Connectionstring.Split(new[] { ';' });

            foreach (DataRow d in ds.Rows)
            {
                var dr = dt.NewRow();
                dr[0] = d[0];
              //  dr[1] = "Data Source=PHSERVER;Initial Catalog=" + d[0].ToString() + ";Persist Security Info=True;User ID=SA;Password=mutawa2011 ";
                dr[1] = connew[0] + ";" + "Initial Catalog =" + d[0].ToString() + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
    public class StockMaster
    {
        private readonly string _constr = Utils.Connectionstring;
        public void CreateStock(ref SqlConnection connection, ref SqlTransaction transaction, DataTable dataTable,
                                string wh, string storetype, bool isbonusqty, bool isreturn)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter();
            var ds = new DsInventory().STOCKMASTER;
            ta.Connection = connection;
            ta.Transaction = transaction;
            foreach (DataRow d in dataTable.Rows)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    int qty = 0;
                    if (isbonusqty)
                    {
                        if (!string.IsNullOrEmpty(d["BONUSQTY"].ToString()))
                        {
                            if (!string.IsNullOrEmpty(d["QTY"].ToString()))
                            {
                                qty = int.Parse(d["QTY"].ToString()) + int.Parse(d["BONUSQTY"].ToString());
                            }
                            else
                            {
                                qty = int.Parse(d["BONUSQTY"].ToString());
                            }
                        }
                        else
                        {
                            qty = int.Parse(d["QTY"].ToString());
                        }
                    }
                    else
                    {
                        qty = int.Parse(d["QTY"].ToString());
                    }
                    int cnt = 0;

                   // var avgcost = GetAvgCprice(d["ITEMNO"].ToString());

                    int negtivestock = ta.FillByItemcodeWithNegativeStock(ds, d["ITEMNO"].ToString(), storetype, wh, Utils.Company);

                    if (negtivestock == 0)
                    {
                        cnt = !string.IsNullOrEmpty(d["EXPDATE"].ToString())
                                  ? ta.FillByStockIDForUpdate(ds, d["ITEMNO"].ToString(),
                                                              DateTime.Parse(d["EXPDATE"].ToString()),
                                                              storetype,
                                                              wh, Utils.Company,decimal.Parse(d["SPRICE"].ToString()))
                                  : ta.FillByStockIDForUpdateNullDate(ds, d["ITEMNO"].ToString(), storetype, wh,
                                                                      Utils.Company,decimal.Parse(d["SPRICE"].ToString()));
                    }
                    else
                    {
                        cnt = negtivestock;
                    }
                    if (isreturn)
                    {
                        qty = -1 * qty;
                    }
                    if (cnt > 0)
                    {
                        var d1 = ds.Rows[0];
                        bool isneg = false;
                        foreach (DsInventory.STOCKMASTERRow d2 in ds.Rows)
                        {
                            if (d2.QTY < 0)
                            {
                                isneg = true;
                                d1 = d2;
                            }
                            if (d2.QTY > 0 && !isneg)
                                d1 = d2;
                        }
                        ta.UpdateQtyByStockID(qty, int.Parse(d1["STOCKID"].ToString()));
                        if(negtivestock > 0)
                        {
                            ta.UpdateSPRICE(decimal.Parse(d["SPRICE"].ToString()), int.Parse(d1["STOCKID"].ToString()));
                        }
                        ta.UpdateSaleQtyByStockid(qty, int.Parse(d1["STOCKID"].ToString()));
                        int qty2 = 0;
                        decimal cp1 = 0;
                        foreach (DataRow costrow in ds.Rows)
                        {
                            qty2 += int.Parse(costrow["QTY"].ToString());
                            if (!String.IsNullOrEmpty(costrow["CPRICE"].ToString()))
                                cp1 = decimal.Parse(costrow["CPRICE"].ToString());
                        }
                        if (qty2 < 0)
                            qty2 *= -1;
                        if ((qty + qty2) > 0)
                        {
                            var newavgcp = ((qty*decimal.Parse(d["CPRICE"].ToString())) + (qty2*cp1))/(qty + qty2);
                            foreach (DataRow costrow in ds.Rows)
                            {
                                ta.UpdateCPRICE(newavgcp, int.Parse(costrow["STOCKID"].ToString()));
                            }
                        }
                    }
                    else
                    {
                        if (!isreturn)
                        {
                            if (string.IsNullOrEmpty(d["EXPDATE"].ToString()))
                            {
                                ta.Insert(d["ITEMNO"].ToString(),
                                          d["BARCODE"].ToString(),
                                          qty,
                                          decimal.Parse(d["SPRICE"].ToString()),
                                          decimal.Parse(d["CPRICE"].ToString()),
                                          null,
                                          storetype,
                                          null,
                                          null,
                                          null,
                                          false, wh,Utils.Company, qty,null);
                            }
                            else
                            {
                                ta.Insert(d["ITEMNO"].ToString(),
                                         d["BARCODE"].ToString(),
                                         qty,
                                         decimal.Parse(d["SPRICE"].ToString()),
                                         decimal.Parse(d["CPRICE"].ToString()),
                                         DateTime.Parse(d["EXPDATE"].ToString()),
                                         storetype,
                                         null,
                                         null,
                                         null,
                                         false, wh, Utils.Company, qty, null);
                            }
                        }
                    }
                }
            }
        }
        public string  UpdateAvgCostprice()
        {
            string retval="0";
            SqlTransaction tran = null;
            string str = "SELECT itemno,AVG(CPRICE) FROM  STOCKMASTER group by ITEMNO ";
            var ta = new SqlDataAdapter(str, _constr);
            var ds = new DataSet();
            var cn1 = new SqlConnection { ConnectionString = _constr };
            cn1.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cn1;
            try
            {
                var cn = new SqlConnection { ConnectionString = _constr };
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                ta.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    str = " update stockmaster set cprice = " + GetAvgCprice(dr[0].ToString()) + " where itemno = '"+ dr[0] +"'";
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                }
                retval = "1";
            }
            catch(Exception ex)
            {
                retval = ex.ToString();
            }
           
            return retval;
        }
        public decimal GetAvgCprice(string itemno)
        {
            decimal retval = 0;
            var ta = new DsReportsTableAdapters.AvgCPFromStockMasterTableAdapter{ Connection = { ConnectionString = _constr } };
           // var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            var dt = new DsReports.AvgCPFromStockMasterDataTable();
            ta.FillAvgCPFromStockMaster(dt, itemno);
            foreach (DataRow dr in dt.Rows)
            {
                if(!string.IsNullOrEmpty(dr[0].ToString()))
                    retval = decimal.Parse(dr[0].ToString());
            }
            return retval;  
            // return (decimal)(ta.GetDataAvgCPFromStockMaster(itemno)?? 0);
            // return (decimal)(ta.SumCprice(Utils.Company) ?? 0);
        }
        public static void UpdateQtyInStockDataSet(ref SqlConnection connection, ref SqlTransaction transaction,DataTable dt, bool isbonusqty)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter();
            ta.Connection = connection;
            ta.Transaction = transaction;
            foreach (DataRow d in dt.Rows)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    int bonusqty = 0;
                    if (isbonusqty)
                    {
                        if (!string.IsNullOrEmpty(d["BONUSQTY"].ToString()))
                        {
                            bonusqty = int.Parse(d["BONUSQTY"].ToString());
                        }
                    }
                    int QTY = int.Parse(d["QTY"].ToString()) + bonusqty;
                    ta.UpdateQtyByStockID(-QTY, int.Parse(d["STOCKID"].ToString()));
                    ta.UpdateSaleQtyByStockid(-QTY, int.Parse(d["STOCKID"].ToString()));
                }
            }
        }
        public  void UpdateStockQtyByStockid( int qty,int stockid)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter{ Connection = { ConnectionString = _constr } };
            ta.UpdateStockQtyByStockid(qty, stockid);

        }
        public static void UpdateInventoryItem(ref DsInventory dsf, DataTable dt)
        {
            foreach (DsInventory.ADJDETAILRow d in dt.Rows)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    var dr = dsf.STOCKMASTER.FindBySTOCKID(d.STOCKID);
                    if (dr != null)
                    {
                        dr.BeginEdit();
                        if (!d.IsADJQTYNull())
                        {
                            dr.QTY = d.ADJQTY;
                            dr.SQTY = d.ADJQTY;
                        }
                        if (!d.IsADJSPRICENull())
                        {
                            dr.SPRICE = d.ADJSPRICE;
                        }
                        if (!d.IsADJCPRICENull())
                        {
                            dr.CPRICE = d.ADJCPRICE;
                        }
                        if (!d.IsADJEXPDATE1Null())
                        {
                            dr.EXPDATE = d.ADJEXPDATE1;
                        }
                        if (!d.IsADJORDERNull())
                        {
                            dr.SALESORDER = d.ADJORDER;
                        }
                        dr.EndEdit();
                    }
                }
            }
        }
        public string UpdateStockDataSet(DataTable dt)
        {

            SqlTransaction tran = null;
            string retval ="0";
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                //int autosed = int.Parse(Utils.Company)*1000000;
                //var str = " DBCC CHECKIDENT (STOCKMASTER , RESEED, + autosed +) ";
                //var cmd = new SqlCommand(str, cn);
                //cmd.ExecuteNonQuery();

                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter();
                ta.AssignConnection(cn, tran);
                if (ta.Update((DsInventory.STOCKMASTERDataTable) dt) > 0)
                    retval = "1";
                tran.Commit();
            }
            catch (Exception ex)
            {
                if (tran != null) tran.Rollback();
                retval = ex.ToString();
            }
            return retval;
        }
        public string UpdateOpeningStock(DataTable dt)
        {
            string retval =string.Empty;
            var tau = new  DsInventoryTableAdapters.STOCKOPENINGTableAdapter();
            tau.Connection.ConnectionString = _constr;
            try
            {
                tau.Update((DsInventory.STOCKOPENINGDataTable) dt);
            }
            catch(Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        public decimal SumCostPrice(bool useconstr = false, string newconstr = "p")
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter {Connection = {ConnectionString = useconstr?newconstr: _constr}};
            return (decimal) (ta.SumCprice(Utils.Company) ?? 0);
        }
        public decimal SumSalePrice(bool useconstr = false, string newconstr = "p")
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
            return (decimal) (ta.SumSPrice(Utils.Company) ?? 0);
        }
        public DsReports.GetStockListDataTable GetStockListDataTableProc()
        {
            var ds = new DsReports.GetStockListDataTable();
            var ta = new DsReportsTableAdapters.GetStockListTableAdapter {Connection = {ConnectionString = _constr}};
            ta.Fill(ds);
            return ds;
        }
        public DsReports.GetStockItemsForTransferDataTable GetStockItemsForTransferDataTable(string comp, string whid,bool iszeroqty=false)
        {
            var ds = new DsReports.GetStockItemsForTransferDataTable();
            var ta = new DsReportsTableAdapters.GetStockItemsForTransferTableAdapter { Connection = { ConnectionString = _constr } };
            if (iszeroqty)
                ta.FillByZeroQty(ds, comp, whid);
            else
            ta.Fill(ds, comp, whid);
            return ds;
        }
        public decimal GetSalesPriceByItemno(string itemno)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetSalesPriceByItemno(itemno, Utils.Company)??0;
        }
        public DsInventory.STOCKMASTERDataTable GetStockItem(string itemno, string storetype)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsInventory().STOCKMASTER;
            ta.FillByItemNo(ds, itemno, storetype, Utils.Company);
            return ds;
        }
        public DsInventory.STOCKMASTERDataTable GetStockItemBySprice(string itemno,string storetype,decimal sprice)
        {
             var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter() { Connection = { ConnectionString = _constr } };
            var ds = new DsInventory().STOCKMASTER;
            ta.FillByItemnoBySprice(ds, itemno,sprice,storetype, Utils.Company);
            return ds;
        }
        public void AddNewItemwithNegativeQty(DataRow d)
        {
            string wh = Utils.SalesStoreCode;
            const string storetype = "S";
            var ds = new DsInventory().STOCKMASTER;
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            //ta.FillByItemNo(ds, d["ITEMNO"].ToString(), "S", Utils.Company);
            ta.FillByItemNoAll(ds, d["ITEMNO"].ToString(), Utils.Company);

            if (ds.Rows.Count > 0)
            {
                foreach (DsInventory.STOCKMASTERRow dr in ds.Rows)
                {
                    if (dr.SPRICE == decimal.Parse(d["SPRICE"].ToString()))
                    {
                        ta.UpdateSaleQtyByStockid(-int.Parse(d["DQNTY"].ToString()), dr.STOCKID);
                        return;
                    }
                }
            }
             ta.Insert(d["ITEMNO"].ToString(),
                       d["BARCODE"].ToString(),
                       0,
                      decimal.Parse(d["SPRICE"].ToString()),
                      decimal.Parse(d["CPRICE"].ToString()),
                      null, storetype, null, null, null, false, wh, Utils.Company, -int.Parse(d["DQNTY"].ToString()),null);
        }
        public void AddNewItemItemInStock(ref SqlConnection cn, ref SqlTransaction tran, DataRow d,DsInventory.STOCKMASTERDataTable dsm)
        {
            string wh = Utils.SalesStoreCode;
            const string storetype = "S";
         // var ds = new DsInventory().STOCKMASTER;
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            var taup = new DsInventoryTableAdapters.STOCKMASTERTableAdapter {Connection = cn, Transaction = tran};
       //   ta.FillByItemNoAll(ds, d["ITEMNO"].ToString(), Utils.Company);
            DataRow[] ds =  dsm.Select( "ITEMNO='" + d["ITEMNO"].ToString() + "'");
            int qty = int.Parse(d["qty"].ToString()) * -1;
         // if (ds.Rows.Count > 0)
        //{
            foreach (DsInventory.STOCKMASTERRow dr in ds)
            {
                if (dr.SPRICE == decimal.Parse(d["INVRATE"].ToString()))
                {
                    taup.UpdateSaleQtyByStockid(qty, dr.STOCKID);
                    taup.UpdateQtyByStockID(qty, dr.STOCKID);
                    return;
                }
            }
         //}
            var cprice = new ItemMaster().GetItemCostPrice(d["itemno"].ToString());
            var sprice =  decimal.Parse(d["INVRATE"].ToString());
            var sdisc = new  ItemMaster().GetPurchaseDist(d["itemno"].ToString());
            if (cprice == 0)
            {
                sprice = decimal.Parse(d["INVRATE"].ToString());
                cprice = sprice -  sprice * sdisc / 100;
            }
            if(!string.IsNullOrEmpty(d["EXPDATE"].ToString()))
                 taup.Insert(d["ITEMNO"].ToString(),
                      d["BARCODE"].ToString(),
                      qty,
                      sprice,
                      cprice,
                      DateTime.Parse(d["EXPDATE"].ToString()),
                      storetype,
                      null, null, null, false, wh, Utils.Company, qty, null);
            else
                 taup.Insert(d["ITEMNO"].ToString(),
                      d["BARCODE"].ToString(),
                      qty,
                      sprice,
                      cprice,
                      null,
                      storetype,
                      null, null, null, false, wh, Utils.Company, qty, null);
        }
        public DsInventory.STOCKMASTERDataTable GetNegativeStock()
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory().STOCKMASTER;
            ta.FillByNegativeStock(ds, Utils.Company);
            return ds;
        }
        public int GetAvailableQty(int stockid)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            return Convert.ToInt32(ta.AvailableQty(stockid));
        }
        public int GetStockid(string itemno)
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            return Convert.ToInt32(ta.GetStockIdofItem(itemno));
        }
        public DsReports.StockReportAsOfDataTable GetStockAsOf(string sccode = "p")
        {
            var ds = new DsReports.StockReportAsOfDataTable();
            var ta = new DsReportsTableAdapters.StockReportAsOfTableAdapter { Connection = { ConnectionString = _constr } };
            if (sccode == "p")
            ta.Fill(ds,Utils.Company);
            else
            {
                ta.FillByWHID(ds, Utils.Company, sccode);
            }
            return ds;
        }
        public DsReports.NegativeStockAsOfDataTable NegativeStockAsOf()
        {
            var ds = new DsReports.NegativeStockAsOfDataTable();
            var ta = new DsReportsTableAdapters.NegativeStockAsOfTableAdapter { Connection = { ConnectionString = _constr } };
            ta.Fill(ds,Utils.Company);
            return ds;
        }
        public DataSet GetAvgMaxQtySpCpExpDtFromStock(string itemno,int year,bool isqtyzero=true){
            var cn = new SqlConnection(_constr);
            cn.Open();
            var queryString = " SELECT count(*), isnull(SUM(qty),0) AS Qty, isnull(MIn(sprice),0) AS Sprice,isnull(max(cprice),0) AS  Cprice , MAX(expdate) AS Expdate  from STOCKMASTER" +
                year + " where ITEMNO = '" + @itemno + "' and"  ;
            if(isqtyzero)
               queryString+= " QTY > 0 ";
            var ta = new SqlDataAdapter(queryString,cn);
            var ds = new DataSet();
            ta.Fill(ds,"StockMaster");
            return ds;
            //var ta = new DsInventoryTableAdapters.StockMasterQtyTableAdapter { Connection = { ConnectionString = _constr } };
            //return ta.GetData(itemno);
        }
        
        public int GetLastAvailableQty(string itemno, int year)
        {
            var cn = new SqlConnection(_constr);
            cn.Open();
            var queryString = " SELECT SUM(qty)  from STOCKMASTER" + year + " where ITEMNO = '" + @itemno + "'";
            var sqlcmd = new SqlCommand(queryString,cn);
            return Convert.ToInt32(sqlcmd.ExecuteScalar());
        }
        public DataSet GetLastSpriceCpriceExpByItemNo(string itemno, int year)
        {
            var cn = new SqlConnection(_constr);
            cn.Open();
            var queryString = " SELECT sprice,cprice ,expdate AS Expdate  from STOCKMASTER" +
                year + " where ITEMNO = '" + @itemno + "' and stockid = (select max(stockid) from STOCKMASTER" +
                year + " where ITEMNO = '" + @itemno + "' and qty > 0)";
            var ta = new SqlDataAdapter(queryString, cn);
            var ds = new DataSet();
            ta.Fill(ds, "StockMaster");
            return ds;
        }
        public DataTable GetAvgMaxQtySpCpExpDtFromStockNew(int year)
        {
            var cn = new SqlConnection(_constr);
            cn.Open();
            var queryString = " SELECT SUM(qty) AS Qty,MAX(sprice) AS Sprice,MAX(cprice) AS  Cprice , MAX(expdate) AS Expdate ,itemno  from STOCKMASTER" + year + " group by itemno ";
            var ta = new SqlDataAdapter(queryString, cn);
            var ds = new DataSet();
            ta.Fill(ds, "StockMaster");
            return ds.Tables["StockMaster"];
            //var ta = new DsInventoryTableAdapters.StockMasterQtyTableAdapter { Connection = { ConnectionString = _constr } };
            //return ta.GetData(itemno);
        }
        public DsInventory.STOCKMASTERDataTable GetStockMasterTabeDataTable()
        {
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetData();
        }
        public DataTable GetDististinctItemsInStockMaster()
        {
            var cn = new SqlConnection(_constr);
            cn.Open();
            var queryString = " SELECT distinct itemno  from STOCKMASTER  ";
            var ta = new SqlDataAdapter(queryString, cn);
            var ds = new DataTable();
            ta.Fill(ds);
            return ds;

        }
        public int GetAvailableQty(string itemno,string newcon="P",bool usenewcon=false)
        {var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter { Connection = { ConnectionString = usenewcon ?newcon: _constr } };
            return Convert.ToInt32(ta.GetAvailableQty(itemno));
        }
        public int SaveCosolidateInventoryRun(DsReports.CONSOLIDATEINVENTORYDataTable dt)
        {
          return   new DsReportsTableAdapters.CONSOLIDATEINVENTORYTableAdapter {Connection = {ConnectionString = _constr}}.Update(dt);
        }
        public DsReports.CONSOLIDATEINVENTORYDataTable GetConsolidateinventoryDataTable()
        {
            return
                new DsReportsTableAdapters.CONSOLIDATEINVENTORYTableAdapter {Connection = {ConnectionString = _constr}}
                    .GetData();
        }
        public DsReports.STOREMASTDBDataTable GetAllStoresDbnames(bool issales=false)
        {
            var ta = new DsReportsTableAdapters.STOREMASTDBTableAdapter {Connection = {ConnectionString = _constr}};
            return issales?ta.GetDataBySales() : ta.GetData();
        }
        //public int GetTotalAvialbleQty
       //create a datarow in stockmaster where return with out stock item
      //while creating new row get the sales price from item master and cost price calcuated by desp.
     // ta.Insert(d["ITEMNO"].ToString(),d["BARCODE"].ToString(),0,decimal.Parse(d["SPRICE"].ToString()),decimal.Parse(d["CPRICE"].ToString()),
    //null, storetype, null, null, null, false, wh, Utils.Company, -int.Parse(d["DQNTY"].ToString()),null);
        public void DelConsolidateinventoryDataTable()
        {
                new DsReportsTableAdapters.CONSOLIDATEINVENTORYTableAdapter {Connection = {ConnectionString = _constr}}
                    .DeleteQuery();
        }
        public void UpdateSpriceByItemno(string itemno, decimal sprice, ref SqlConnection connection,ref SqlTransaction transaction)
        {
           
            var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter
            {
                Connection = connection,
                Transaction = transaction
            };
            ta.UpdateSpriceByItemno(sprice, itemno);
        }public DsReports.MultiPriceDataTable GetMultiplePrice()
        {
            return
                new DsReportsTableAdapters.MultiPriceTableAdapter { Connection = { ConnectionString = _constr } }
                    .GetData();
        }

        public DsReports.GetSTOCKMASTERDataTable GetStockmasterByGroup(int grpid)
        {
            var ta = new DsReportsTableAdapters.GetSTOCKMASTERTableAdapter {Connection = {ConnectionString = _constr}};
            return grpid > 0 ? ta.GetDataBygROUPID(grpid) : ta.GetBy();
        }
    }
    public class ItemMaster
    {
        private readonly string _constr = Utils.Connectionstring;
        public DsMaster.ITEMMASTRow ItemmastRow;
        public string Itemno;

        public string DoSave()
        {
            string retval;
            SqlTransaction tran = null;
            var isnew = false;
            try
            {
                var cn = new SqlConnection {ConnectionString = _constr};
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var dt = new DsMaster().ITEMMAST;
                var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter();
                ta.Connection.ConnectionString = _constr;
                ta.Fill(dt);
                ta.AssignConnection(cn, tran);
                var dr = dt.FindByITEMNO(Itemno);
                if (dr != null)
                {
                    dr.BeginEdit();
                    dr.editedby = Utils.Userid;
                    dr.editeddate = DateTime.Now.Date;
                }
                else
                {
                    dr = (DsMaster.ITEMMASTRow) dt.NewRow();
                    isnew = true;
                    var autoid = new DataManager().GetAutoId(12);
                    autoid++;
                    Utils.Itemno = Utils.Company + autoid.ToString("D5");
                    dr.ITEMNO = Utils.Itemno;
                    dr.CREATEDBY = Utils.Userid;
                    dr.CDATE = DateTime.Now.Date;
                    if (ItemmastRow.OWNBARCODE && string.IsNullOrEmpty(ItemmastRow.BARCODE))
                        dr.BARCODE = Utils.Itemno;
                    else
                    {
                        dr.BARCODE = ItemmastRow.BARCODE;
                    }
                }
                dr.ITEMTYPE = ItemmastRow.ITEMTYPE;
                dr.OWNBARCODE = ItemmastRow.OWNBARCODE;

                dr.ITEMNAME = ItemmastRow.ITEMNAME;
                dr.ARITEMNAME = ItemmastRow.ARITEMNAME;
                dr.BASEUOM = ItemmastRow.BASEUOM;
                dr.SUPPLIERNO = ItemmastRow.SUPPLIERNO;
                dr.MANFNAME = ItemmastRow.MANFNAME;
                dr.REORDER = ItemmastRow.REORDER;
                dr.UOM = ItemmastRow.UOM;
                dr.PRINTBARCODE = ItemmastRow.PRINTBARCODE;
                dr.EXPDATEREQ = ItemmastRow.EXPDATEREQ;
                dr.ACTIVE = ItemmastRow.ACTIVE;
                dr.CATEGORY = ItemmastRow.CATEGORY;
                dr.GROUPID = ItemmastRow.GROUPID;
                dr.GENERICID = ItemmastRow.GENERICID;
                dr.MARGIN = ItemmastRow.MARGIN;
                dr.MARKUP = ItemmastRow.MARKUP;
                dr.DISCOUNT = ItemmastRow.DISCOUNT;
                dr.FASTMOVING = ItemmastRow.FASTMOVING;
                dr.LOCATION = ItemmastRow.LOCATION;
                dr.TEMPRATURE = ItemmastRow.TEMPRATURE;
                dr.MINQTY = ItemmastRow.MINQTY;
                dr.MAXQTY = ItemmastRow.MAXQTY;
                dr.COMPANY = Utils.Company;
                dr.SEL = false;
                dr.DISCONSALE = ItemmastRow.DISCONSALE;
                dr.CPRICE = ItemmastRow.CPRICE;
                dr.SPRICE = ItemmastRow.SPRICE;
                dr.ITEMDEM = ItemmastRow.ITEMDEM;
                dr.COLOR=ItemmastRow.COLOR;
                dr.WEIGHT=ItemmastRow.WEIGHT;
                dr.POMINQTY =ItemmastRow.POMINQTY;
                dr.POMAXQTY =ItemmastRow.POMAXQTY;
                dr.DISCONSALE = ItemmastRow.DISCONSALE;
                dr.SALEDISCOUNTPER = ItemmastRow.SALEDISCOUNTPER;

                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }
                new DataManager().UpdateAutoNum(12);
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

        public DsReports.ITEMLISTFORCONSOLIDATEINVDataTable ItemListForConsolidateInv(int option,string perm)
        {
            var ret = new DsReports().ITEMLISTFORCONSOLIDATEINV;
            if (option==0)
               new DsReportsTableAdapters.ITEMLISTFORCONSOLIDATEINVTableAdapter  { Connection = {ConnectionString = _constr}}.Fill(ret);
            if(option==1)
                new DsReportsTableAdapters.ITEMLISTFORCONSOLIDATEINVTableAdapter { Connection = { ConnectionString = _constr } }.FillByGroupId(ret, int.Parse(perm));
            if(option==2)
                new DsReportsTableAdapters.ITEMLISTFORCONSOLIDATEINVTableAdapter { Connection = { ConnectionString = _constr } }.FillByItemNo(ret,perm,perm);
            if (option == 3)
                new DsReportsTableAdapters.ITEMLISTFORCONSOLIDATEINVTableAdapter { Connection = { ConnectionString = _constr } }.FillBySupplier(ret, perm);

            return ret;
        }
        public DsMaster.ITEMMASTDataTable FindItemByBarCode(string barcode)
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().ITEMMAST;
            ta.FillByBarCode(ds, barcode);
            return ds;
        }
        public DsMaster.ITEMMASTDataTable GetItemMastList()
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().ITEMMAST;
            ta.Fill(ds);
            return ds;
        }
        public DsReports.ItemsListDataTable GetRptItemsList()
        {
            var ta = new DsReportsTableAdapters.ItemsListTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().ItemsList;
            ta.Fill(ds);
            return ds;
        }
        public bool UpdateItemasBarcode(string itemno)
        {
            var d = FindItemByBarCode(itemno);
            if (d.Count == 0)
            {
                var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter {Connection = {ConnectionString = _constr}};
                ta.UpdateQBarCode(itemno, itemno);
                return true;
            }
            return false;
        }
        public decimal GetItemCostPrice(string itemno)
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter {Connection = {ConnectionString = _constr}};
            return (decimal) (ta.GetCostPrice(itemno) ??0);
        }
        public decimal GetItemSalesPrice(string itemno)
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter {Connection = {ConnectionString = _constr}};
            return ta.GetSalesPrice(itemno) ?? 0;
        }
        public DataTable GetSPCPEXPDtFromImportedPurchaseFile(string itemno,string barcode)
        {
            
            var cmd = "select  SPRICE,CPRICE,EXPIRY as INVDT,DNAME  from invoice   where dcode = '" + itemno + "' and barcd = '" + barcode + "' order by serial  desc";
            var ta = new SqlDataAdapter(cmd, _constr);
            var ds = new DataSet();
            ta.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable GetSPCPEXPDtFromsTOCKfILE(string itemno, string barcode,string year)
        {
            var tblname = "StockMaster" + year;
           // string cmdstring = "select * into " + tblname + " from stockmaster ";
            var cmd = "select  SPRICE,CPRICE,EXPDATE as INVDT   from " + tblname + "   where itemno = '" + itemno + "' and barcode = '" + barcode + "' order by stockid  desc";
            var ta = new SqlDataAdapter(cmd, _constr);
            var ds = new DataSet();
            ta.Fill(ds);
            return ds.Tables[0];
        }
        
        public string GetSCpriceFromImportedPurchaseFile(bool iscp,string itemno,string barcode)
        {
            //select top 1 sprice,cprice from invoice where dcode = @itemno and barcd =@barcode  order by serial  desc
            var cmd = "select isnull(sprice,0) as sprice,isnull(cprice,0) as cprice from itemmast where itemno = '" + itemno + "' or barcode = '" + barcode + "' ";

          // var cmd = "select top 1 sprice,cprice as cprice from invoice where dcode = '" + itemno + "' or barcd = '" + barcode + "' order by serial  desc";
           var ta = new SqlDataAdapter(cmd, _constr);
           var ds = new DataSet();
           ta.Fill(ds);// var ds = DAL.DBTask.ExecuteDataset(_constr, cmd, CommandType.Text, null);
            decimal cp = 0;
            decimal sp = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
               // if (!string.IsNullOrEmpty(dr[0].ToString()))
                    sp = decimal.Parse(dr[0].ToString());
               // if (!string.IsNullOrEmpty(dr[1].ToString()))
                   cp = decimal.Parse(dr[1].ToString());
            }
            if (sp == 0 || cp==0)
            {
                cmd = "select top 1  isnull(sprice,0) as sprice,isnull(cprice,0) as cprice from stockmaster2015 where itemno = '" + itemno + "' or barcode = '" + barcode + "' ";
                // var cmd = "select top 1 sprice,cprice as cprice from invoice where dcode = '" + itemno + "' or barcd = '" + barcode + "' order by serial  desc";
                var ta11 = new SqlDataAdapter(cmd, _constr);
                var ds1 = new DataSet();
                ta.Fill(ds1);// var ds = DAL.DBTask.ExecuteDataset(_constr, cmd, CommandType.Text, null);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    // if (!string.IsNullOrEmpty(dr[0].ToString()))
                    sp = decimal.Parse(dr[0].ToString());
                    // if (!string.IsNullOrEmpty(dr[1].ToString()))
                    cp = decimal.Parse(dr[1].ToString());
                }
            }
            return (sp.ToString() + "," + cp.ToString()); //iscp ? cp : sp;
        }
        public bool UpdateItems(DataTable dt)
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter {Connection = {ConnectionString = _constr}};
            return ta.Update((DsMaster.ITEMMASTDataTable) dt) > 0;
        }
        public decimal GetDiscount(string itemno)
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter();
            ta.Connection.ConnectionString = _constr;
            return ta.GetDiscount(itemno) ?? 0;
        }
        public decimal GetPurchaseDist(string itemno)
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter {Connection = {ConnectionString = _constr}};
            return ta.GetPurDiscount(itemno) ?? 0;
        }
        public string GetItemname(string itemno)
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetItemName(itemno);
        }

        public string GetDefaultSupplier(string itemno)
        {
            var ta = new DsMasterTableAdapters.ITEMMASTTableAdapter { Connection = { ConnectionString = _constr } };
            return  ta.GetDefaultSupplier(itemno);
        }

        public void UpdateSpriceByItemno(string itemno, decimal sprice, ref SqlConnection connection,
            ref SqlTransaction transaction)
        {
            //var ta = new DsInventoryTableAdapters.STOCKMASTERTableAdapter();
            //ta.Connection = connection;
            //ta.Transaction = transaction;

            var ta =  new DsMasterTableAdapters.ITEMMASTTableAdapter
            {
                Connection = connection,
                Transaction = transaction
            };
            ta.UpdateSPrice(sprice, itemno);


        }
    }
    public class Customer
    {
        private readonly string _constr = Utils.Connectionstring;
        public DsMaster.CUSTOMERRow customerRow;
        public DsMaster.INSURANCEDISCDataTable insurancediscDataTable;

        public string DoSave()
        {
            string retval=string.Empty;
            SqlTransaction tran = null;
            var isnew = false;
            try
            {
                var cn = new SqlConnection {ConnectionString = _constr};
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var dt = new DsMaster().CUSTOMER;
                var ta = new DsMasterTableAdapters.CUSTOMERTableAdapter {Connection = {ConnectionString = _constr}};

                ta.Fill(dt);

                ta.AssignConnection(cn, tran);

                var tains = new DsMasterTableAdapters.INSURANCEDISCTableAdapter
                                {Connection = {ConnectionString = _constr}};
                tains.AssignConnection(cn, tran);
                var dr = dt.FindByCUSTNO(customerRow.CUSTNO);

                if (dr != null)
                {
                    dr.BeginEdit();
                    Utils.CustomerNo = customerRow.CUSTNO;
                    dr.EUSERID = Utils.Userid;
                    dr.EDATE = DateTime.Now.Date;

                }
                else
                {
                    dr = (DsMaster.CUSTOMERRow) dt.NewRow();
                    isnew = true;
                    var autoid = new DataManager().GetAutoId(13);
                    autoid++;
                    Utils.CustomerNo = new DataManager().CreateFormatedAutoNo(autoid);
                    dr.CUSTNO = Utils.CustomerNo;
                    dr.CUSERID = Utils.Userid;
                    dr.CDATE = DateTime.Now.Date;
                }
                dr.CUSTOMERTYPE = customerRow.CUSTOMERTYPE;
                dr.CUSTOMERNAME = customerRow.CUSTOMERNAME;
                dr.CUSTCOMP = customerRow.CUSTCOMP;
                dr.CUSTOMERID = customerRow.CUSTOMERID;
                dr.PHONE = customerRow.PHONE;
                dr.Mobile = customerRow.Mobile;
                dr.EMAIL = customerRow.EMAIL;
                dr.NOTE = customerRow.NOTE;
                dr.FIXDISC = customerRow.FIXDISC;
                dr.FIXDISCAMTPER = customerRow.FIXDISCAMTPER;
                dr.CREDITLIMIT = customerRow.CREDITLIMIT;
                dr.COMPANY = Utils.Company;
                dr.PAYTYPE = customerRow.PAYTYPE;
                if(!customerRow.IsMEMBERNONull())
                 dr.MEMBERNO = customerRow.MEMBERNO;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }

                if (insurancediscDataTable != null)
                {
                    foreach (DsMaster.INSURANCEDISCRow di in insurancediscDataTable.Rows)
                    {
                        di.CUSTNO = Utils.CustomerNo;
                    }
                    tains.Update(insurancediscDataTable);
                }
                tran.Commit();
                new DataManager().UpdateAutoNum(13);
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                if (tran != null) tran.Rollback();
            }
            return retval;
        }
        public DsMaster.CUSTOMERDataTable GetCustomerList()
        {
            var ta = new DsMasterTableAdapters.CUSTOMERTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().CUSTOMER;
            ta.Fill(ds);
            return ds;
        }
        public bool CheckCustomerId(string custid, string custno)
        {
            var ta = new DsMasterTableAdapters.CUSTOMERTableAdapter {Connection = {ConnectionString = _constr}};
            var ret = Convert.ToInt32(ta.CountCustomerId(custid, custno)) > 0;
            return ret;
        }
        public DsMaster.CUSTOMERDataTable GetCustomerByMemno(int memno)
        {
            return new DsMasterTableAdapters.CUSTOMERTableAdapter { Connection = { ConnectionString = _constr } }.GetDataByMEMBERNO(memno);
        }
        public DsMaster.INSURANCEDISCDataTable GetInsuranceByCust(string custid)
        {
            var ta = new DsMasterTableAdapters.INSURANCEDISCTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().INSURANCEDISC;
            ta.FillByCustNo(ds, custid);
            return ds;
        }
     // new BLSales().GetShiftCode("POINTS")
        public void UpdateCustomerPoints(string custid, decimal points, bool usenewcon = false, string newcon = "p")
        {
            var ta = new DsMasterTableAdapters.CUSTOMERTableAdapter { Connection = { ConnectionString = usenewcon ? newcon : _constr } }; 
            ta.UpdateCustomerPoints(points, custid);
            // CUSTOMERPOINT
        }
        public DsMaster.CUSTOMERDataTable GetCustomerMembersDataTable(bool usenewcon = false, string newcon = "p")
        {
           return new DsMasterTableAdapters.CUSTOMERTableAdapter { Connection = { ConnectionString = usenewcon ? newcon : _constr } }.GetDataByMembers(); 
        }
        public decimal GetAvailblePoints(string custid, bool usenewcon = false, string newcon = "p")
        {
            return new DsMasterTableAdapters.CUSTOMERTableAdapter { Connection = { ConnectionString = usenewcon ? newcon : _constr } }.GetAvailblePoints(custid) ??0; 
        }
        public string UpdateCustomerPoints(string custno, decimal points, string sqlsync)
        { 
            string retval = "1";
            SqlTransaction tran = null;
            try
            {
                var cn = new SqlConnection(sqlsync);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);

 
                var ta = new DsMasterTableAdapters.CUSTOMERTableAdapter();
                    ta.AssignConnection(cn, tran);
                    ta.UpdateCustomerPoints(points, custno);
                    tran.Commit();
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                    retval = ex.ToString();
            }
            return retval;
        }
        public DsMaster.CUSTOMERDataTable GetCustomerWithPoints()
        {
            return new DsMasterTableAdapters.CUSTOMERTableAdapter { Connection = { ConnectionString = _constr } }.GetDataByCustomerWithPoints(); 
        }
        public Ledgers.CUSTOMERPOINTSDataTable GetCustomerPointNotUploaded()
        {
            return new LedgersTableAdapters.CUSTOMERPOINTSTableAdapter { Connection = { ConnectionString = _constr } }.GetDataByNotUpLoad();
        }
        public void SetCustomerPointUploadStatus(int tid)
        {
            new LedgersTableAdapters.CUSTOMERPOINTSTableAdapter { Connection = { ConnectionString = _constr } }.UpdateUpload(tid);
        }
        public string UpdatePointsDetails(string custno, decimal points,string comp,DateTime dt,  string sinv, decimal redimamt, bool useother = false, string cnstr = "x")
        {
            string retval = string.Empty;
            try
            {
                var ta = new LedgersTableAdapters.CUSTOMERPOINTSTableAdapter
                {
                    Connection = { ConnectionString = useother ? cnstr : _constr }
                };
                ta.Insert(custno, points, comp,dt, Utils.Company, sinv, redimamt, false);
                retval = "1";
            }
            catch (Exception e)
            {
                retval = e.ToString();
            }
            return retval;
        }


    }
    public class PriceMaster
    {
        private readonly string _constr = Utils.Connectionstring;

        public DsMaster.PRICEMASTERDataTable UpdatePriceMaster(DsPurchase.PURINVDETAILDataTable dt, string suplierid)
        {
            var ds = new DsMaster().PRICEMASTER;
            var dsf = new DsMaster().PRICEMASTER;
            var ta = new DsMasterTableAdapters.PRICEMASTERTableAdapter();
            foreach (DsPurchase.PURINVDETAILRow d in dt.Rows)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    ta.Connection.ConnectionString = _constr;
                    ta.FillBySupNo(dsf, d["ITEMNO"].ToString(), suplierid);
                    if (dsf.Rows.Count > 0)
                    {
                        foreach (DsMaster.PRICEMASTERRow drf in dsf.Rows)
                        {
                            if (!d.IsEXPDATENull())
                            {
                                if (drf.LASTEXPDT != d.EXPDATE)
                                {
                                    drf.LASTEXPDT = d.EXPDATE;
                                }
                            }
                            if (drf.PPRICE != d.CPRICE || drf.SPRICE != d.SPRICE)
                            {
                                var dr = (DsMaster.PRICEMASTERRow) ds.NewRow();
                                dr.SUPPLIERNO = suplierid;
                                dr.PPRICE = d.CPRICE;
                                dr.SPRICE = d.SPRICE;
                                dr.PDATE = DateTime.Now.Date;
                                if (!d.IsEXPDATENull())
                                {
                                    dr.LASTEXPDT = d.EXPDATE;
                                }
                                ds.Rows.Add(dr);
                            }
                        }
                    }
                    else
                    {
                        var dr = (DsMaster.PRICEMASTERRow)ds.NewRow();
                        dr.SUPPLIERNO = suplierid;
                        dr.PPRICE = d.CPRICE;
                        dr.SPRICE = d.SPRICE;
                        dr.PDATE = DateTime.Now.Date;
                        if (!d.IsEXPDATENull())
                        {
                            dr.LASTEXPDT = d.EXPDATE;
                        }
                        ds.Rows.Add(dr);
                    }
                }
            }
            return ds;
        }
    }
    public class DefaultPrinters
    {
        private readonly string _constr = Utils.Connectionstring;
        public string DoSave(DsMaster.PRINTERSRow printersRow)
        {
            try
            {
                var dt = new DsMaster().PRINTERS;
                var ta = new DsMasterTableAdapters.PRINTERSTableAdapter() {Connection = {ConnectionString = _constr}};
                bool isnew = false;
                ta.Fill(dt);
                var drnew = dt.FindByTID(printersRow.TID);
                if (drnew != null)
                {
                    drnew.BeginEdit();
                }
                else
                {
                    drnew = (DsMaster.PRINTERSRow) dt.NewRow();
                    isnew = true;
                }
                drnew.BarcodePrinter = printersRow.BarcodePrinter;
                drnew.Invoiceprinter = printersRow.Invoiceprinter;
                drnew.Drugprinter = printersRow.Drugprinter;
                drnew.Computer = printersRow.Computer;
                drnew.Defaultprinter = printersRow.Defaultprinter;
                drnew.ISDEFAULT = printersRow.ISDEFAULT;
                if (isnew)
                {
                    dt.Rows.Add(drnew);
                    ta.Update(dt);
                }
                else
                {
                    drnew.EndEdit();

                    ta.Update(drnew);
                }
                return "1";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public DsMaster.PRINTERSDataTable GetPrinters()
        {
            var ds = new DsMaster().PRINTERS;
            var ta = new DsMasterTableAdapters.PRINTERSTableAdapter {Connection = {ConnectionString = _constr}};
            ta.Fill(ds);
            return ds;
        }

    }
    public class BarcodePrinting
    {
        private readonly string _constr = Utils.Connectionstring;
        public string DoSave(DsMaster.TEMPBCODEPRINTDataTable dt)
        {
            try
            {
                var ta = new DsMasterTableAdapters.TEMPBCODEPRINTTableAdapter
                             {Connection = {ConnectionString = _constr}};
                ta.Update(dt);
                return "1";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public void DoDeletePrinted()
        {
            var ta = new DsMasterTableAdapters.TEMPBCODEPRINTTableAdapter { Connection = { ConnectionString = _constr } };
            ta.DeletePrinted();
        }
        public DsMaster.TEMPBCODEPRINTDataTable SelectUnPrinted()
        {
            var ta = new DsMasterTableAdapters.TEMPBCODEPRINTTableAdapter { Connection = { ConnectionString = _constr } };
            var dt = new DsMaster.TEMPBCODEPRINTDataTable();
            ta.FillByNotPrinted(dt);
            return dt;
        }
        public DsMaster.TEMPBCODEPRINTDataTable CreateBarcodeList(string purinvno)
        {
            var d = new Purchasing.PurInvDataManager().GetPurInvDetailsById(purinvno);
            var im = new ItemMaster();
            var dt = new DsMaster.TEMPBCODEPRINTDataTable();
            foreach (DataRow dr  in d.Rows)
            {
               var ndr = dt.NewRow();
                ndr[1] = dr["itemno"];
                ndr[1] = im.GetItemname(dr["itemno"].ToString());
                ndr[2] = int.Parse(dr["Qty"].ToString()) + int.Parse((string.IsNullOrEmpty(dr["BONUSQTY"].ToString()) ? "0": dr["BONUSQTY"]).ToString());
                ndr[4] = 0;
                dt.Rows.Add(ndr);
            }
            return dt;
        }
        
    }
    public class UserInfo
    {
        private readonly string _constr = Utils.Connectionstring;
        public DsMaster.USERINFORow userinfoRow;
        public string DoSave()
        {
            string retval;
            //  SqlTransaction tran = null;
            try
            {
                var cn = new SqlConnection {ConnectionString = _constr};
                cn.Open();
                //tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var dt = new DsMaster().USERINFO;
                bool isnew = false;
                var ta = new DsMasterTableAdapters.USERINFOTableAdapter() {Connection = cn};
                ta.Fill(dt);
                //ta.AssignConnection(cn, tran);
                var dr = dt.FindByUSERID(userinfoRow.USERID);
                if (dr != null)
                {
                    dr.BeginEdit();
                    dr.EDATE = System.DateTime.Now.Date;
                    dr.EDITEDBY = Utils.Userid;
                }
                else
                {
                    dr = (DsMaster.USERINFORow) dt.NewRow();
                    isnew = true;
                    dr.CREATEDBY = Utils.Userid;
                    dr.CDATE = System.DateTime.Now.Date;
                }
                dr.USERNAME = userinfoRow.USERNAME;
                dr.FULLNAME = userinfoRow.FULLNAME;
                dr.EMPNO = userinfoRow.EMPNO;
                dr.PASSWORD = userinfoRow.PASSWORD;
                dr.ACTIVE = userinfoRow.ACTIVE;
                dr.PROFILEID = userinfoRow.PROFILEID;
                dr.USERTYPE = userinfoRow.USERTYPE;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }
                //Utils.NewUserid
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                // if (tran != null) tran.Rollback();
            }
            return retval;
        }
        public DsMaster.USERINFODataTable GetUserInfo(bool useconstr = false, string newconstr = "p")
        {
            var ta = new DsMasterTableAdapters.USERINFOTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
            var ds = new DsMaster().USERINFO;
            ta.Fill(ds);
            return ds;
        }
        public DsMaster.USERINFO1DataTable GetUserInfoCommission(bool useconstr = false, string newconstr = "p")
        {
            var ta = new DsMasterTableAdapters.USERINFO1TableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
            var ds = new DsMaster().USERINFO1;
            ta.Fill(ds);
            return ds;
        }
       
        public DsMaster.USERINFODataTable GetUserinfoByEmp(string empno)
        {
            var ta = new DsMasterTableAdapters.USERINFOTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().USERINFO;
            ta.FillByEMPNO(ds, empno);
            return ds;
        }
        public DsMaster.USERINFODataTable GetUserinfoByUserName(string username)
        {
            var ta = new DsMasterTableAdapters.USERINFOTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().USERINFO;
            ta.FillByUSERNAME(ds, username);
            return ds;
        }
        public string GetUserNameByUserid(int userid){
            var ta = new DsMasterTableAdapters.USERINFOTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().USERINFO;
            return ta.GetNameByUserid(userid).ToString();
        }
        public DsMaster.USERINFODataTable CheckLoginDetails(string username, string password)
        {
            var ta = new DsMasterTableAdapters.USERINFOTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().USERINFO;
            ta.FillByLogin(ds, username, password);
            return ds;
        }
        public int GetSessionUser(int utype)
        {
            var ta = new DsMasterTableAdapters.ACTIVESESSIONTableAdapter() {Connection = {ConnectionString = _constr}};
            var rt = ta.FillByActive(utype) ?? 0;
            return (int) rt;
        }
    }
    public class Company{
        private readonly string _constr = Utils.Connectionstring;
        public DsMaster.COMPANYRow CompanyRow;

        public string DoSave()
        {
            string retval;
            try
            {
                var cn = new SqlConnection {ConnectionString = _constr};
                cn.Open();
                var dt = new DsMaster().COMPANY;
                bool isnew = false;
                var ta = new DsMasterTableAdapters.COMPANYTableAdapter {Connection = cn};
                ta.Fill(dt);
                var dr = dt.FindByCCODE(CompanyRow.CCODE);
                if (dr != null)
                {
                    dr.BeginEdit();
                    dr.EUSERID = Utils.Userid;
                    dr.EDATE = DateTime.Now.Date;
                }
                else
                {
                    dr = (DsMaster.COMPANYRow) dt.NewRow();
                    isnew = true;
                    dr.CUSERID = Utils.Userid;
                    dr.CDATE = DateTime.Now.Date;
                }
                dr.COMPNAME = CompanyRow.COMPNAME;
                dr.COMPADD = CompanyRow.COMPADD;
                dr.CITY = CompanyRow.CITY;
                dr.COUNTRY = CompanyRow.COUNTRY;
                dr.TELEPHONE = CompanyRow.TELEPHONE;
                dr.FAX = CompanyRow.FAX;
                dr.EMAIL = CompanyRow.EMAIL;
                dr.WEB = CompanyRow.WEB;
                dr.BUSTYPEID = CompanyRow.BUSTYPEID;
                dr.CURRID = CompanyRow.CURRID;
                dr.CCODE = CompanyRow.CCODE;
                dr.ISDEFAULT = CompanyRow.ISDEFAULT;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }

        public DsMaster.COMPANYDataTable GetCompanies(bool isdefault = false,bool useothercomp=false,string othercon="p")
        {
            var ta = new DsMasterTableAdapters.COMPANYTableAdapter() {Connection = {ConnectionString = useothercomp? othercon: _constr}};
            var ds = new DsMaster().COMPANY;
            if (isdefault)
                ta.FillByISDEFAULT(ds);
            else
                ta.Fill(ds);
            return ds;
        }
    }
    public class Profiles
    {
        private readonly string _constr = Utils.Connectionstring;
        public DsMaster.PROFILESRow ProfilenamesRow;

        public string DoSave()
        {
            string retval;
            try
            {
                var cn = new SqlConnection {ConnectionString = _constr};
                cn.Open();
                var dt = new DsMaster().PROFILES;
                bool isnew = false;
                var ta = new DsMasterTableAdapters.PROFILESTableAdapter {Connection = cn};
                ta.Fill(dt);
                var dr = dt.FindByPROFILEID(ProfilenamesRow.PROFILEID);
                if (dr != null)
                {
                    dr.BeginEdit();
                    dr.EUSERID = Utils.Userid;
                    dr.EDATE = DateTime.Now.Date;
                }
                else
                {
                    dr = (DsMaster.PROFILESRow) dt.NewRow();
                    isnew = true;
                    dr.PROFILEID = ProfilenamesRow.PROFILEID;
                    dr.CUSERID = Utils.Userid;
                    dr.CDATE = DateTime.Now.Date;
                }
                dr.DETAILS = ProfilenamesRow.DETAILS;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        public DsMaster.PROFILESDataTable LoadProfiles(int profileid = 0)
        {
            var ta = new DsMasterTableAdapters.PROFILESTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster.PROFILESDataTable();
            if (profileid == 0)
                ta.Fill(ds);
            else
            {
                ta.FillByProfileId(ds, profileid);
            }
            return ds;
        }

       
    }
    public class BankNames
    {
        private readonly string _constr = Utils.Connectionstring;

        public string DoSave(string pname,int bankid=0)
        {
            string retval;
            try
            {
                var cn = new SqlConnection { ConnectionString = _constr };
                cn.Open();
                var dt = new DsMaster().BANKS;
                bool isnew = false;
                var ta = new DsMasterTableAdapters.BANKSTableAdapter() { Connection = cn };
                ta.Fill(dt);
                var dr = dt.FindByBANKID(bankid);
                if (dr != null)
                {
                    dr.BeginEdit();
                }
                else
                {
                    dr = (DsMaster.BANKSRow)dt.NewRow();
                    isnew = true;
                }
                dr.BANKNAME = pname;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }

        public DsMaster.BANKSDataTable GetBankName()
        {
          return  new DsMasterTableAdapters.BANKSTableAdapter {Connection = {ConnectionString = _constr}}.GetData();
        }
         
    }
    public class ProfileNames
    {
        private readonly string _constr = Utils.Connectionstring;

        public string DoSave(string pname)
        {
            string retval;
            try
            {
                var cn = new SqlConnection {ConnectionString = _constr};
                cn.Open();
                var dt = new DsMaster().PROFILENAMEMAST;
                bool isnew = false;
                var ta = new DsMasterTableAdapters.PROFILENAMEMASTTableAdapter {Connection = cn};
                ta.Fill(dt);
                var dr = dt.FindByPROFILENAME(pname);
                if (dr != null)
                {
                    dr.BeginEdit();
                }
                else
                {
                    dr = (DsMaster.PROFILENAMEMASTRow) dt.NewRow();
                    isnew = true;
                }
                dr.PROFILENAME = pname;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        
        public DsMaster.PROFILENAMEMASTDataTable LoadProfileNames()
        {
            var ta = new DsMasterTableAdapters.PROFILENAMEMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster.PROFILENAMEMASTDataTable();
            ta.Fill(ds);
            return ds;
        }
    }
    public class ActiveSession
    {
        private readonly string _constr = Utils.Connectionstring;

        public void DoSave(int USERID, int UTYPE)
        {
            var ta = new DsMasterTableAdapters.ACTIVESESSIONTableAdapter {Connection = {ConnectionString = _constr}};
            ta.UpdateLogOut(USERID);
            ta.Insert(USERID, UTYPE, DateTime.Now.Date, true);
        }
    }
    public class DOCTORSESSION
    {
        private readonly string _constr = Utils.Connectionstring;

        public void DoSave(int USERID, int UTYPE)
        {
            var ta = new DsMasterTableAdapters.DOCTORSESSIONTableAdapter() {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().DOCTORSESSION;
           // ta.Fill(ds);
            //if(ds.Rows.Count == 0 )
            //{
            //    ta.Insert(USERID, UTYPE, DateTime.Now.Date, true);
            //}
            //else
            //{
            //    foreach (DataRow  d in ds.Rows)
            //    {
            //        d["USERID"] = USERID;
            //        d["UTYPE"] = UTYPE;
            //        d["UDATE"] = DateTime.Now.Date;
            //        d["ISACTIVE"] = true;
            //        ta.Update(d);
            //    }
            //}
            ta.Logout();
            ta.Insert(USERID, UTYPE, DateTime.Now.Date, true);
        }
       public int GetDoctorLogin()
        {
            var ta = new DsMasterTableAdapters.DOCTORSESSIONTableAdapter() {Connection = {ConnectionString = _constr}};
            var ret = ta.GetActiveDoctor() ?? 0;
            return (int) ret;
        }
    }
    public class DailyClosing
    {
        private readonly string _constr = Utils.Connectionstring;

        public int DoSave(int ctype, string ctext, decimal cvalue, DateTime dt,bool isbeg)
        {
            var ta = new LedgersTableAdapters.DAILYCLOSINGTableAdapter {Connection = {ConnectionString = _constr}};

            var cn = new SqlConnection(_constr);
            var cmd = new SqlCommand();
            cn.Open();
            //"yyyy-MM-dd HH:mm:ss"
            var fg = isbeg ? 1 : 0;
            cmd.Connection = cn;
            string scmd = "  INSERT INTO DAILYCLOSING (CTYPE, CNAME, CVALUE, CDATE, USERID, COMPANY, ISBEG) ";
            scmd += " VALUES (" + ctype + ",'" + ctext + "'," + cvalue + ",'" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "', " + Utils.Userid + ",'" + Utils.Company + "'," + fg + ") ";
            cmd.CommandText = scmd;
            return cmd.ExecuteNonQuery();
            //return ta.Insert(ctype, ctext, cvalue, dt, Utils.Userid, Utils.Company,isbeg);
        }
        public Ledgers.DAILYCLOSINGDatesDataTable GetDailyClosingDates(bool usecn=false,string othercn="p")
        {
            var ta = new LedgersTableAdapters.DAILYCLOSINGDatesTableAdapter  {Connection = {ConnectionString = usecn?othercn:_constr}};
            var ds = new Ledgers().DAILYCLOSINGDates;
            ta.Fill(ds);
            return ds; 
        }
        public Ledgers.DAILYCLOSINGDataTable GetDailyClosing()
        {
            var ta = new LedgersTableAdapters.DAILYCLOSINGTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new Ledgers().DAILYCLOSING;
            ta.FillByCompany(ds, Utils.Company);
            return ds;
        }

        public Ledgers.DAILYCLOSINGDataTable GetLastClosing(DateTime d1, bool isdate)
        {
            var ta = new LedgersTableAdapters.DAILYCLOSINGTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new Ledgers().DAILYCLOSING;
            if (isdate)
                ta.FillByMaxdateToDate(ds, Utils.Company,d1);
            else
                ta.FillByMaxdate(ds, Utils.Company);
            
            return ds;
        }
        public Ledgers.DAILYCLOSINGDataTable GetSPCP(DateTime d1,int spcp,bool useconstr,string newconstr)
        {

            var ta = new LedgersTableAdapters.DAILYCLOSINGTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
            var ds = new Ledgers().DAILYCLOSING;

            if (spcp == 1)
                ta.FillBySPCP(ds, d1, 2);
            else if (spcp == 2)
                ta.FillBySPCP(ds, d1, 3);

            return ds;
        }


        public void CloseDailySales(DateTime dt)
        {
            var cn = new SqlConnection(_constr);
            var cmd = new SqlCommand();
            cn.Open();
            //"yyyy-MM-dd HH:mm:ss"
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE SALESAMOUNTDETAILS SET DAYCLOSE=1 ,CLOSEDATE = '" + dt.ToString("yyyy-MM-dd HH:mm:ss")  + "'  WHERE DAYCLOSE= 0 and COMPANY='" + Utils.Company + "'";

            cmd.ExecuteNonQuery();
            //String.Format("{0:g}", dt);
            cmd.CommandText = "UPDATE SALESMAIN SET DAILYCLOSED=1,CLOSEDATETIME= '" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE  DAILYCLOSED=0 AND COMPANY='" + Utils.Company + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select STEXT  FROM  Syscfg where  SOURCE='ISBACKUP' AND ISNULL(SOPTION,0)=1 ";
            var dbname= cmd.ExecuteScalar();

            if (dbname != null)
            {
                var connew = _constr.Split(new[] { ';' });
                var str = connew[0] + ";" + "Initial Catalog =" + dbname + ";" + connew[2] + ";";
                using (var cnnew = new SqlConnection(str))
                {
                    cnnew.Open();
                    var c = new SqlCommand();
                    c.Connection = cnnew;
                    c.CommandType = CommandType.StoredProcedure;
                    c.CommandText = "CREATEBACK";
                    c.ExecuteNonQuery();
                }
            }
            new PromotionPrice().ResetThePromotionPrice(dt);
            // var cnback = new SqlConnection()
        }
    }
    public class CommissionSetup
    {
        public Ledgers.COMMISIONMASTRow CommisionmastRow;
        public Ledgers.COMMISIONDETAILDataTable Commisiondetail;
        private readonly string _constr = Utils.Connectionstring;
        public string DoSave()
        {
            string retval = "0";
            SqlTransaction tran = null;
            var cn = new SqlConnection(_constr);
            try
            {
                cn.Open();
                var tadet = new LedgersTableAdapters.COMMISIONDETAILTableAdapter();
                var tam = new LedgersTableAdapters.COMMISIONMASTTableAdapter {Connection = {ConnectionString = _constr}};
                var dt = new Ledgers().COMMISIONMAST;
                tam.Fill(dt);
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                tam.AssignConnection(cn, tran);
                tadet.AssignConnection(cn, tran);
                bool isnew = false;
                var dr = dt.FindByCOMID(CommisionmastRow.COMID);
                if (dr != null)
                {
                    dr.BeginEdit();
                    Utils.CommissionNo = CommisionmastRow.COMID;
                    dr.EUSERID = Utils.Userid;
                    dr.EDATE = DateTime.Now.Date;
                }
                else
                {
                    isnew = true;
                    var autoid = new DataManager().GetAutoId(15);
                    autoid++;
                    Utils.CommissionNo = new DataManager().CreateFormatedAutoNo(autoid);
                    dr = (Ledgers.COMMISIONMASTRow) dt.NewRow();
                    dr.PRMOFRM = CommisionmastRow.PRMOFRM;
                    dr.PRMOTO = CommisionmastRow.PRMOTO;
                    dr.PROMONAME = CommisionmastRow.PROMONAME;
                    dr.STOREID = CommisionmastRow.STOREID;
                    dr.EMPNO = CommisionmastRow.EMPNO;
                    dr.STATUS = CommisionmastRow.STATUS;
                    dr.COMID = Utils.CommissionNo;
                    dr.USERID = Utils.Userid;
                    dr.UDATE = DateTime.Now.Date;
                }
                foreach (Ledgers.COMMISIONDETAILRow crow in Commisiondetail.Rows)
                {
                    crow.COMID = Utils.CommissionNo;
                }
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    tam.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    tam.Update(dt);
                }
                tadet.Update(Commisiondetail);
                new DataManager().UpdateAutoNum(15);
                
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                if (tran != null && cn.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
            }
            return retval;
        }
        public Ledgers.COMMISIONMASTDataTable GetCommissionMast(string commid = null, bool useconstr = false, string newconstr = "p")
        {
            var dt = new Ledgers().COMMISIONMAST;
            var ta = new LedgersTableAdapters.COMMISIONMASTTableAdapter
                         {
                             Connection = { ConnectionString = useconstr ? newconstr : _constr }
                         };
            if (commid == null)
            {
                ta.Fill(dt);
            }
            else
            {
                ta.FillByCOMID(dt, commid);
            }
            return dt;
        }
        public Ledgers.COMMISIONDETAILDataTable GetCommissionDetail(string commid = null,bool isRemote=false)
        {
            var dt = new Ledgers().COMMISIONDETAIL;
            string _sysnstr = Utils.ConnectionstringSync;
            if (isRemote)
            {
                if (Utils.Company != "01")
                {
                    _sysnstr = new SqlAsyncConnectionString(6, true);
                }
            }
            var ta = new LedgersTableAdapters.COMMISIONDETAILTableAdapter
                         {
                             Connection = { ConnectionString = isRemote ? _sysnstr : _constr }
                         };
            if (commid == null)
            {
                ta.Fill(dt);
            }
            else
            {
                ta.FillByCOMID(dt, commid);
            }
            return dt;
        }
        public Ledgers.COMMISIONMASTDataTable GetCommissionMastNotUploaded()
        {
           return new LedgersTableAdapters.COMMISIONMASTTableAdapter {Connection = {ConnectionString = _constr}}.GetDataByNotUpload();
        }
        public void UpdateSync(string commid,bool isRemote=false)
        {
            string _sysnstr = Utils.ConnectionstringSync;
            if (Utils.Company != "01")
            {
                _sysnstr = new SqlAsyncConnectionString(6, true);
            }
            new LedgersTableAdapters.COMMISIONMASTTableAdapter { Connection = { ConnectionString = isRemote ? _sysnstr : _constr } }.UpdateSync(commid);
        }
        public Ledgers.COMMISIONMASTDataTable GetCommissonMastNotReceived()
        {
            string storeids = new Masters.StoreManager().GetSalesStore() + ",";
            string _sysnstr = Utils.ConnectionstringSync;
                if (Utils.Company != "01")
                {
                    _sysnstr = new SqlAsyncConnectionString(6, true);
                }
                return new LedgersTableAdapters.COMMISIONMASTTableAdapter { Connection = { ConnectionString = _sysnstr } }.GetDataByNotReceived(storeids);
        }

    }

    public class PromotionPrice
    {
        public Ledgers.PROMOITEMSDataTable PromoitemsDataTable;
        private readonly string _constr = Utils.Connectionstring;
        public string DoSave(bool isdownload=false)
        {
            string retval = "0";
            SqlTransaction tran = null;
            var cn = new SqlConnection(_constr);
            try
            {
                cn.Open();

                var tam = new LedgersTableAdapters.PROMOITEMSTableAdapter();
                
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                tam.AssignConnection(cn, tran);
                var clstock = new StockMaster();
                var clitem = new ItemMaster();
                foreach (Ledgers.PROMOITEMSRow dr in PromoitemsDataTable.Rows)
                {
                    if (!isdownload)
                    {
                        if (!dr.POSTED)
                        {
                            dr.POSTED = true;
                            clstock.UpdateSpriceByItemno(dr.ITEMNO, dr.NEWPRICE, ref cn, ref tran);
                            clitem.UpdateSpriceByItemno(dr.ITEMNO, dr.NEWPRICE, ref cn, ref tran);
                        }
                    }
                    else
                    {
                        dr.POSTED = true;
                        clstock.UpdateSpriceByItemno(dr.ITEMNO, dr.NEWPRICE, ref cn, ref tran);
                        clitem.UpdateSpriceByItemno(dr.ITEMNO, dr.NEWPRICE, ref cn, ref tran);

                    }
                }
                tam.Update(PromoitemsDataTable);
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                if (tran != null && cn.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
            }
            return retval;
        }
        public Ledgers.PROMOITEMSDataTable GetDataForUpload()
        {
          return  new LedgersTableAdapters.PROMOITEMSTableAdapter {Connection = {ConnectionString = _constr}}
                .GetDataByNotUpload();
        }
        public Ledgers.PROMOITEMSDataTable GetDataByBatchNo(int batchno)
        {
            return new LedgersTableAdapters.PROMOITEMSTableAdapter { Connection = { ConnectionString = _constr } }.GetDataByBatchNo(batchno);
                // .GetDataByDownLoad(batchno);
        }
        public Ledgers.PROMOITEMSDataTable GetDataForDownload()
        {
            return new LedgersTableAdapters.PROMOITEMSTableAdapter {Connection = {ConnectionString = new SqlAsyncConnectionString(6, true)}}
                .GetDataByDownLoad(GetMaxBatchNo());
        }
        public Ledgers.PROMOITEMS1DataTable GetPromoBatchNos()
        {
            return new LedgersTableAdapters.PROMOITEMS1TableAdapter { Connection = { ConnectionString = _constr } }.GetDataDistinctBatch();
        }

        public int GetMaxBatchNo()
        {
            return (int) new LedgersTableAdapters.PROMOITEMS1TableAdapter() {Connection = {ConnectionString = _constr}}
                .GetMaxBatchNo();
        }
        public void UpdateSync(int tid )
        {
            new LedgersTableAdapters.PROMOITEMSTableAdapter() { Connection = { ConnectionString = _constr } }.UpdateSync(tid);
        }
        public void ResetThePromotionPrice(DateTime dt1)
        {
            string retval = "0";
            SqlTransaction tran = null;
            var cn = new SqlConnection(_constr);
            try
            {
                cn.Open();

                var t = new Ledgers.PROMOITEMSDataTable();
                var tam = new LedgersTableAdapters.PROMOITEMSTableAdapter().FillByToDate(t, dt1);
                PromoitemsDataTable = t;

                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
               // tam.AssignConnection(cn, tran);
                var clstock = new StockMaster();
                var clitem = new ItemMaster();
                foreach (Ledgers.PROMOITEMSRow dr in PromoitemsDataTable.Rows)
                {
                        //dr.POSTED = true;
                        clstock.UpdateSpriceByItemno(dr.ITEMNO, dr.OLDPRICE, ref cn, ref tran);
                        clitem.UpdateSpriceByItemno(dr.ITEMNO, dr.OLDPRICE, ref cn, ref tran);
                }
                tran.Commit();
              //  retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                if (tran != null && cn.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
            }
        }
    }
    public class Inscustomers
    {
        private readonly string _constr = Utils.Connectionstring;
        public DsMaster.INSCUSTOMERSRow InscustomersRow;
        public string DoSave()
        {
            string retval = "0";
            SqlTransaction tran = null;
            var cn = new SqlConnection(_constr);
            try
            {
                bool isnew = false;
                cn.Open();
                var ta = new DsMasterTableAdapters.INSCUSTOMERSTableAdapter { Connection = { ConnectionString = _constr } };
                var dt = new DsMaster().INSCUSTOMERS;
                ta.Fill(dt);
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                ta.AssignConnection(cn, tran);
                var dr = dt.FindByTID(InscustomersRow.TID);
                if (dr != null)
                {
                    dr.BeginEdit();
                }
                else
                {
                    isnew = true;
                    dr = (DsMaster.INSCUSTOMERSRow)dt.NewRow();
                    dr.FILENO = InscustomersRow.FILENO;
                    dr.POLICYNO = InscustomersRow.POLICYNO;
                    dr.CLASS = InscustomersRow.CLASS;
                    dr.CUSTSHARE = InscustomersRow.CUSTSHARE;
                    dr.PATNAME = InscustomersRow.PATNAME;
                    dr.CUSTNO = InscustomersRow.CUSTNO;
                }
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    ta.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    ta.Update(dt);
                }
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                if (tran != null && cn.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
            }
            return retval;
        }
    }
    public class Terms
    {
        private readonly string _constr = Utils.Connectionstring;
        public string DoSave(string scode,string sname,DsMaster.TERMSDETAILMASTDataTable Termsdetails)
        {
            string retval=string.Empty;
            SqlTransaction tran = null;
            var isnew = false;
            
            try
            {
                var cn = new SqlConnection { ConnectionString = _constr };
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);

                var dt = new DsMaster().TERMSMAST;
                var taMast = new DsMasterTableAdapters.TERMSMASTTableAdapter { Connection = { ConnectionString = _constr } };

                taMast.Fill(dt);

                taMast.AssignConnection(cn,tran);


                var taDetail = new DsMasterTableAdapters.TERMSDETAILMASTTableAdapter() ;
                taDetail.AssignConnection(cn,tran);

                var MastRow = dt.FindByTERMCODE(scode);
                if(MastRow!=null)
                {
                    MastRow.BeginEdit();
                }
                else
                {
                    MastRow = (DsMaster.TERMSMASTRow) dt.NewRow();
                    MastRow.TERMCODE = scode;
                    isnew = true;
                }
                MastRow.PAYNAME = sname;

                if (isnew)
                {
                    dt.Rows.Add(MastRow);
                    taMast.Update(dt);
                }
                else
                {
                    MastRow.EndEdit();
                    taMast.Update(dt);
                }
                taDetail.Update(Termsdetails);
                tran.Commit();
                retval = "1";
            }
            catch(Exception ex)
            {
                if (tran != null) tran.Rollback();
                retval = ex.ToString();
            }
            return retval;
        }
        public DsMaster.TERMSMASTDataTable GetTermMast(string tcode)
        {
            return new DsMasterTableAdapters.TERMSMASTTableAdapter { Connection = { ConnectionString = _constr } }.GetDataBy(tcode);
        }
        public DsMaster.TERMSMASTDataTable GetTermMast()
        {
            return new DsMasterTableAdapters.TERMSMASTTableAdapter { Connection = { ConnectionString = _constr } }.GetData();
        }
        public DsMaster.TERMSDETAILMASTDataTable GetTerms(string tcode)
        {
          return  new DsMasterTableAdapters.TERMSDETAILMASTTableAdapter { Connection = { ConnectionString = _constr } }.GetDataBy1(tcode);
        }
        public DsMaster.PAYTYPEMASTDataTable GetPayTypeMast()
        {
          return  new DsMasterTableAdapters.PAYTYPEMASTTableAdapter{ Connection = { ConnectionString = _constr } }.GetData();
        }
        public DsMaster.PAYMENTONMASTDataTable GetPayMentonMast()
        {
            return new DsMasterTableAdapters.PAYMENTONMASTTableAdapter { Connection = { ConnectionString = _constr } }.GetData();
        }
        public DsMaster.SHIPPINGMASTDataTable GetShipping()
        {
           return new DsMasterTableAdapters.SHIPPINGMASTTableAdapter { Connection = { ConnectionString = _constr } }.GetData();
        }
        public DsMaster.CUSTSUPGROUPSDataTable GetGroups()
        {
          return new DsMasterTableAdapters.CUSTSUPGROUPSTableAdapter {Connection = {ConnectionString = _constr}}.GetData();
        }

    }
    public class Contacts
    {
        private readonly string _constr = Utils.Connectionstring;
        public bool DoSave(DsMaster.CONTACTMASTDataTable contactmast)
        {
            var ta = new DsMasterTableAdapters.CONTACTMASTTableAdapter {Connection = {ConnectionString = _constr}};
            return  ta.Update(contactmast) > 1;
        }
        public DsMaster.CONTACTMASTDataTable GetContact(int stype,string refno)
        {
            return new DsMasterTableAdapters.CONTACTMASTTableAdapter { Connection = { ConnectionString = _constr } }.GetData(refno,(short?) stype);
        }
    }
    public class YearEndClass
    {
        private readonly string _constr = Utils.Connectionstring;
        public Ledgers.TEXTFILESDATADataTable GetItemsFromTextFileTable()
        {//TEXTFILESDATA
            var ta = new LedgersTableAdapters.TEXTFILESDATATableAdapter { Connection = { ConnectionString = _constr } };
           return ta.GetData();
        }
        public void updateGetItemsFromTextFileTable(Ledgers.TEXTFILESDATADataTable dsa)
        {//TEXTFILESDATA
            var ta = new LedgersTableAdapters.TEXTFILESDATATableAdapter { Connection = { ConnectionString = _constr } };
           ta.Update(dsa);
        }

        public void UpdateOpeningForManuallyAdded(int yearclosed)
        {
            var ta = new DsInventoryTableAdapters.YearEndInventoryTableAdapter();
            var dt = new DsInventory().YearEndInventory;
            ta.FillByISADDED(dt);
            var bl = new StockMaster();
            foreach (DsInventory.YearEndInventoryRow d in dt.Rows)
            {
                if(!d.IsINSTOCKNull())
                if (d.INSTOCK == 0)
                {
                    var stk = bl.GetAvgMaxQtySpCpExpDtFromStock(d.ITEMNO, yearclosed);
                    var dr = stk.Tables[0].Rows[0];
                    d.INSTOCK = int.Parse(dr["QTY"].ToString()); 
                }
            }
            ta.Update(dt);
        }
       
        public DataTable GetDisticntItemno()
        {
            var sql = "select 	distinct  ITEMNO,sum(QTy)as qty from TEXTFILESDATA group by itemno";
            var cn = new SqlConnection(_constr);
            cn.Open();
            var ds = new DataSet();
            var ta = new SqlDataAdapter(sql, cn);
            ta.Fill(ds);
            return ds.Tables[0];
        }
        public decimal CheckYearClosed(int year)
        {
            var ta = new LedgersTableAdapters.YEARENDPROCESSTableAdapter { Connection = { ConnectionString = _constr } };
            var ret = ta.CheckYearClosed(year, Utils.Company) ?? 0;
            return decimal.Parse(ret.ToString());
        }
        public bool CheckYearCloseProcessStart(int year)
        {
            var ta = new LedgersTableAdapters.YEARENDPROCESSTableAdapter { Connection = { ConnectionString = _constr } };
            
            var ret = ta.CheckYearClosedProcessStart(Utils.Company,year) ?? 0;
            return ret > 0;
        }
        public bool ValidateYearClosed(int s)
        {
            string qry = string.Empty;
            var cn = new SqlConnection(_constr);
            cn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            if(s==1)
            {
                qry = " SELECT COUNT(*) from SALESMAIN where HOLDNO > 0 ";
            }
            if (s == 2)
            {
                qry = " SELECT COUNT(*) FROM SALESMAIN WHERE POSTED =1 AND DAILYCLOSED=0 ";
            }
            if (s == 3)
            {
                qry = " SELECT COUNT(*) FROM PURINVMAIN WHERE HOLD = 1 ";
            }
            if (s == 4)
            {
                qry = " SELECT COUNT(*) FROM ITEMTRANSFERMAIN WHERE HOLD = 1 ";
            }
            cmd.CommandText = qry;
            var cnt =   cmd.ExecuteScalar() ?? 0;
            return (int) cnt > 0;
        }
        public string DoCreateYearClosed(int year)
        {
            SqlTransaction tran = null;
            string retval = string.Empty;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ta = new LedgersTableAdapters.YEARENDPROCESSTableAdapter();
                ta.AssignConnection(cn,tran);
                var tblname = "StockMaster" + year;
                ta.Insert(year, true, tblname,0,DateTime.Now.Date,null,Utils.Company);

                string cmdstring = "select * into " + tblname + " from stockmaster ";
                var cmd1 = new SqlCommand(cmdstring, cn, tran);
                cmd1.ExecuteNonQuery();

                cmdstring = " delete from stockmaster where COMPANY = " + Utils.Company;
                var cmd = new SqlCommand(cmdstring, cn, tran);
                cmd.ExecuteNonQuery();
               // tran.Commit();

                cmdstring = "CREATE TABLE TEXTFILES"+ year +
                            " ( ITEMNO nvarchar(50) NULL,QTY int NULL,MACNO nvarchar(12))  ON [PRIMARY] ";
                var cmd2 = new SqlCommand(cmdstring, cn, tran);
                cmd2.ExecuteNonQuery();
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
        public Ledgers.YEARENDPROCESSDataTable GetClosingYear()
        {
            var ta = new LedgersTableAdapters.YEARENDPROCESSTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetDataByYearCloseStart(Utils.Company);
        }
        private void CLoseYearEndProcess(int year)
        {
          var ta = new LedgersTableAdapters.YEARENDPROCESSTableAdapter { Connection = { ConnectionString = _constr } };
          ta.CLoseYearEndProcess(DateTime.Now.Date, year);
        }
        public DsInventory.YearEndInventoryDataTable  LoadYearEndInventory(int year)
        {
           var ta = new DsInventoryTableAdapters.YearEndInventoryTableAdapter { Connection = { ConnectionString = _constr } };
           return ta.GetDataByNonTrasferInventory(year, Utils.Company);
        }
        public decimal GetCountNonTrasfered()
        {
            var ta = new DsInventoryTableAdapters.YearEndInventoryTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.GetNonTrasfered() ?? 0;
        }
        public string SaveDataToInventoryYear(DsInventory.YearEndInventoryDataTable dt)
        {
            string retval = string.Empty;
            try
            {
                var ta = new DsInventoryTableAdapters.YearEndInventoryTableAdapter
                             {Connection = {ConnectionString = _constr}};
                ta.Update(dt);
            }
            catch(Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        public string DoUpdateInventory(DsInventory.YearEndInventoryDataTable dtyearend,string storetype,string whid)
        {
            SqlTransaction tran = null;
            string retval = string.Empty;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ta = new DsInventoryTableAdapters.YearEndInventoryTableAdapter();

                var dt = new DsInventory().STOCKMASTER;
                ta.AssignConnection(cn,tran);
                foreach (DsInventory.YearEndInventoryRow dr in dtyearend.Rows)
                {
                    if (dr.NOMASTER == false)
                    {
                        if (dr.PHYSICALSTOCK > 0 && !dr.TRANSFERED)
                        {
                            var drnew = (DsInventory.STOCKMASTERRow) dt.NewRow();
                            drnew.ITEMNO = dr.ITEMNO;
                            drnew.BARCODE = dr.BARCODE;
                           
                            drnew.SPRICE = dr.SPRICE;
                            drnew.CPRICE = dr.CPRICE;
                            if (!dr.IsEXPDATENull())
                                drnew.EXPDATE = dr.EXPDATE;
                            drnew.DQNTY = 0;
                            drnew.QTY = dr.PHYSICALSTOCK;
                            drnew.SQTY = dr.PHYSICALSTOCK;
                            drnew.STORETYPE = storetype;
                            drnew.WHID = Utils.SalesStoreCode;
                            drnew.COMPANY = Utils.Company;
                            drnew.DISC = 0;
                            if (!dr.NOMASTER)
                                 dr.TRANSFERED = true;
                            dt.Rows.Add(drnew);
                        }
                    }
                }
                new StockMaster().CreateStock(ref cn, ref tran, dt, whid, storetype, false, false);
             //   "SELECT DCODE,BARCD,SUM(BQNTY) AS QTY,MAX(SPRICE) as SPRICE,MIN(EXPIRY) as EXPIRY FROM STOCK  WHERE  BQNTY  > 0 GROUP BY DCODE,SPRICE,EXPIRY,BARCD ",
                ta.Update(dtyearend);
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
        public string DoUpdateOpeningStock(DateTime dt,int intyear)
        {
            string retval = string.Empty;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                string sql = "SELECT ITEMNO,BARCODE,SUM(PHYSICALSTOCK) AS QTY,MAX(SPRICE) as SPRICE,MIN(EXPDATE) as EXPIRY FROM YearEndInventory  WHERE TRANSFERED=1   GROUP BY ITEMNO,BARCODE,EXPdate  ";
                var ds = new DataSet();
                var ta = new SqlDataAdapter(sql, cn);
                ta.Fill(ds);
                var dsM = new DsInventory();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    var row = (DsInventory.STOCKOPENINGRow) dsM.STOCKOPENING.NewRow();
                    row.ITEMNO = dr["ITEMNO"].ToString();
                    row.BARCODE = dr["BARCODE"].ToString();
                    row["TYEAR"] = dt.Year;
                    row["TDATE"] = dt.ToString("yyyy-MM-dd");
                    row.BEGQTY = int.Parse(dr["QTY"].ToString());
                    if (!string.IsNullOrEmpty(dr["EXPIRY"].ToString()))
                        row.MINEXPDATE = DateTime.Parse(dr["EXPIRY"].ToString());
                    if (!string.IsNullOrEmpty(dr["SPRICE"].ToString()))
                        row.MAXSPRICE = decimal.Parse(dr["SPRICE"].ToString());
                    row["COMPANY"] = Utils.Company;
                    row["TDATETIME"] = DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss");
                    dsM.STOCKOPENING.Rows.Add(row);
                }
                var ret = new StockMaster().UpdateOpeningStock(dsM.STOCKOPENING);
                CLoseYearEndProcess(intyear);
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            
            return retval;
        }
        public int GetInStockFromBackUp(string itemno, int year)
        {
            var retval = 0;
            var sql = "select 	sum(QTy)as qty from stockmaster" + year + "  where itemno='" + itemno + "'";
            var cn = new SqlConnection(_constr);
            cn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            var retval1 = cmd.ExecuteScalar().ToString();
                try{
            if (!string.IsNullOrEmpty(retval1))
            {
                retval = int.Parse(retval1.ToString());
            }
               
            }      

            catch(Exception ex)
                {
                 retval =0;
            }

            return  retval;
        }
        public string GetMaxExpirtyDt(string itemno, int year)
        {
            var sql = "select 	max(EXPDATE) as EXPDATE from stockmaster"+ year + "  where itemno='" + itemno + "'";
            var cn = new SqlConnection(_constr);
            cn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            string retval =   cmd.ExecuteScalar().ToString();
            return retval;
        }
        public Ledgers.YearEndInventory1DataTable GetOpeningDataTable(int iyear)
        {
           // var ta = new Ledgers.YearEndInventory1DataTable { Connection = { ConnectionString = _constr } }
            var ta =
                new LedgersTableAdapters.YearEndInventory1TableAdapter {Connection = {ConnectionString = _constr}}
                    .GetData(iyear);
            foreach (Ledgers.YearEndInventory1Row dr in ta.Rows)
            {
                dr.STOCKVALUE = 0;
                dr.STOCKVALUE = dr.StkDiff * dr.Sprice;
                
            }
            return ta;
        }
        public Ledgers.OpeningvariationDataTable GetOpeningvariationDataTable(int year)
        {
            //var dt = new DataTable();
            var dt = new Ledgers.OpeningvariationDataTable();
            var sqlstr = " SELECT  dbo.StockMaster"+year+ ".ITEMNO, dbo.StockMaster"+year+".BARCODE, ";
            sqlstr += "    dbo.ITEMMAST.ITEMNAME,SUM(dbo.StockMaster" + year + ".QTY) AS QTY,MAX(dbo.StockMaster" + year + ".CPrice) AS Cprice,";
            sqlstr += "    SUM(dbo.StockMaster"+year+".QTY * dbo.StockMaster"+year+".cPRICE) AS Stockvalue,";
            sqlstr += "    dbo.ITEMGROUP.GROUPNAME as GroupName FROM   dbo.ITEMMAST INNER JOIN ";
            sqlstr += "    dbo.ITEMGROUP ON dbo.ITEMMAST.GROUPID = dbo.ITEMGROUP.GROUPID RIGHT OUTER JOIN ";
            sqlstr += "    dbo.StockMaster"+year+" ON dbo.ITEMMAST.ITEMNO = dbo.StockMaster"+year+".ITEMNO ";
            sqlstr += "    WHERE dbo.StockMaster"+year+".ITEMNO NOT IN (SELECT ITEMNO FROM YearEndInventory) ";
            sqlstr += "    GROUP BY dbo.StockMaster"+year+ ".ITEMNO, dbo.StockMaster"+year+ ".BARCODE,dbo.ITEMMAST.ITEMNAME,dbo.ITEMGROUP.GROUPNAME ";
            sqlstr += "    having  SUM(dbo.StockMaster" + year + ".QTY) > 0 ";
            sqlstr += "    order by dbo.ITEMMAST.ITEMNAME asc ";
            var ta = new SqlDataAdapter(sqlstr, _constr);
            ta.Fill(dt);
            return dt;
        }
    }
    public class DrugDispatch
    {
        private readonly string _constr = Utils.Connectionstring;
        public DsMaster.DOSAGESDataTable GetDosagesDataTable()
        {
            return new DsMasterTableAdapters.DOSAGESTableAdapter { Connection = { ConnectionString = _constr } }.GetData();
        }
        public void UpdateDosageTable(DsMaster.DOSAGESDataTable dsDosagesDataTable)
        {
            var ta = new DsMasterTableAdapters.DOSAGESTableAdapter {Connection = {ConnectionString = _constr}};
            ta.Update(dsDosagesDataTable);
        }
        public DsMaster.DDMASTDataTable GetDdmastDataTable()
        {
            return new DsMasterTableAdapters.DDMASTTableAdapter { Connection = { ConnectionString = _constr } }.GetData();
        }
        public DsMaster.DDDETAILSDataTable GetDddetailsDataTable(string dno)
        {
              return  new DsMasterTableAdapters.DDDETAILSTableAdapter { Connection = { ConnectionString = _constr } }.GetDataByDNO(dno);
        }
        public DsMaster.DDDETAILSDataTable GetDddetailsDataTable()
        {
            return new DsMasterTableAdapters.DDDETAILSTableAdapter { Connection = { ConnectionString = _constr } }.GetData() ;
        }
        public string DoSaveDrugDispatch(DsMaster.DDMASTRow drow,DsMaster.DDDETAILSDataTable dtTable)
        {
            string retval = string.Empty;
            SqlTransaction tran = null;
            var cn = new SqlConnection(_constr);
            try
            {
                cn.Open();
                var tadet = new  DsMasterTableAdapters.DDDETAILSTableAdapter() ;
                var tam = new DsMasterTableAdapters.DDMASTTableAdapter {Connection = {ConnectionString = _constr}};
                var dt = new DsMaster().DDMAST;
                tam.Fill(dt);
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                tam.AssignConnection(cn, tran);
                tadet.AssignConnection(cn, tran);
                bool isnew = false;
                var dr = dt.FindByDNO(drow.DNO);
                if (dr != null)
                {
                    dr.BeginEdit();
                    Utils.DosageNo = drow.DNO;
                }
                else
                {
                    isnew = true;
                    var autoid = new DataManager().GetAutoId(19);
                    autoid++;
                    Utils.DosageNo = new DataManager().CreateFormatedAutoNo(autoid);
                    dr = (DsMaster.DDMASTRow) dt.NewRow();
                    dr.DNO = Utils.DosageNo;
                    dr.PATNAME = drow.PATNAME;
                    dr.HOSPITAL = drow.HOSPITAL;
                    dr.DOCTOR = drow.DOCTOR;
                    dr.TDATE = drow.TDATE;
                    dr.COMP = drow.COMP;
                }
                foreach (DsMaster.DDDETAILSRow crow in dtTable.Rows)
                {
                    crow.DNO = Utils.DosageNo;
                }
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    tam.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    tam.Update(dt);
                }
                tadet.Update( dtTable);
                new DataManager().UpdateAutoNum(19);
                tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                if (tran != null && cn.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
            }
            return retval;
        }
        public DsMaster.DosageSlipDataTable GetDosageSlipDataTable(string dno)
        {
            return new DsMasterTableAdapters.DosageSlipTableAdapter {Connection = {ConnectionString = _constr}}.GetData(dno);
        }
    }

    public class InsuranceCustDetails
    {
        private readonly string _constr = Utils.Connectionstring;

        public string DoSaveInsuranceCustDatails(DsMaster.INSCUSTOMERSRow drow)
        {
            string retval = "0";
            //var cn = new SqlConnection(_constr);
            //SqlTransaction tran=null;
            try
            {

//                CUSTNO //FILENO,//CLASS //VISITNO //POLICYNO //PATNAME
               // cn.Open();
                var tam = new DsMasterTableAdapters.INSCUSTOMERSTableAdapter { Connection = { ConnectionString = _constr } };
                var dt = new DsMaster().INSCUSTOMERS;
                tam.Fill(dt);
                //tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                //tam.AssignConnection(cn, tran);
                bool isnew = false;
                var dr = dt.FindByTID(drow.TID);
                if (dr != null)
                {
                    dr.BeginEdit();
                }else
                {
                    isnew = true;
                    dr = (DsMaster.INSCUSTOMERSRow)dt.NewRow(); //  CUSTNO //FILENO,//CLASS //VISITNO //POLICYNO //PATNAME
                    dr.FILENO = drow.FILENO;
                    dr.PATNAME = drow.PATNAME;
                    dr.POLICYNO = drow.POLICYNO;
                    dr.PATNAME = drow.PATNAME;
                    dr.CUSTNO = drow.CUSTNO;
                }
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    tam.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    tam.Update(dt);
                }
              //  tran.Commit();
                retval = "1";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
                //if (tran != null && cn.State == ConnectionState.Open)
                //{
                //    tran.Rollback();
                //}
            }
            return retval;
        }
        public DsMaster.INSCUSTOMERSRow GetInscustomersRowByPolicyNo(string policyno)
        {
            var tam = new DsMasterTableAdapters.INSCUSTOMERSTableAdapter { Connection = { ConnectionString = _constr } };
            var dt = new DsMaster().INSCUSTOMERS;
            tam.FillByPOLICYNO(dt,int.Parse(policyno));
            DsMaster.INSCUSTOMERSRow dr=null;
            if (dt.Rows.Count > 0)
                dr = dt[0];
            return  dr;
        }
        public DsMaster.INSCUSTOMERSRow GetInscustomersRowByFileNo(string fileno)
        {
            var tam = new DsMasterTableAdapters.INSCUSTOMERSTableAdapter { Connection = { ConnectionString = _constr } };
            var dt = new DsMaster().INSCUSTOMERS;
            tam.FillByFILENO(dt,fileno);
            DsMaster.INSCUSTOMERSRow dr = null;
            if (dt.Rows.Count > 0)
                dr = dt[0];
            return dr;
        }


    }
 }

 
