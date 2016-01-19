using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.DsReportsTableAdapters;
using VIRETAILENTITIES;

namespace VIRETAILDAL.DALCOMMON
{
    public class ReportsDataManager
    {
        private static readonly string _constr = Utils.Connectionstring;
        public static DsReports.RptPurchaseInvDataTable PurchasingRpt(string purinvId)
        {
            var ta = new RptPurchaseInvTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports.RptPurchaseInvDataTable();
            ta.Fill(ds, purinvId);
            return ds;
        }
        public static DsReports.PurchaseBySupDataTable PurchasingRptBySup(string supid,DateTime fromdate,DateTime todate)
        {
            var ta = new PurchaseBySupTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports.PurchaseBySupDataTable();
            ta.Fill(ds, supid, fromdate, todate);
            return ds;
        }
        public static DsReports.PurchaseByInvDateDataTable  PurchasingRptByInvDate(DateTime fromdate, DateTime todate)
        {
            var ta = new PurchaseByInvDateTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports.PurchaseByInvDateDataTable();
            ta.Fill(ds,fromdate, todate);
            return ds;
        }
        public static DsReports.RptPurchaseReturnDataTable ReturnPurchasingRpt(string purinvId)
        {
            var ta = new RptPurchaseReturnTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports.RptPurchaseReturnDataTable();
            ta.Fill(ds, purinvId);
            return ds;
        }
        public static DsReports.PurchaseReturnBySupDataTable ReturnPurchasingRptBySup(string supid, DateTime fromdate, DateTime todate)
        {
            var ta = new PurchaseReturnBySupTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports.PurchaseReturnBySupDataTable();
            ta.Fill(ds, supid, fromdate, todate);
            return ds;
        }
        public static DsReports.PurchaseReturnByInvDateDataTable  ReturnPurchasingRptByDate(DateTime fromdate, DateTime todate)
        {
            var ta = new PurchaseReturnByInvDateTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports.PurchaseReturnByInvDateDataTable();
            ta.Fill(ds, fromdate, todate);
            return ds;
        }

        public static int GetCustomerCount(DateTime d1, DateTime d2, bool isclose, bool useconstr = false, string newconstr = "p")
        {
            var ret = 0;
            var ta = new SalesAmountDetailsTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
            if (!isclose)
                ret = (int) (ta.GetInvoiceCount()  ?? 0);
            else
                ret = (int) (ta.GetInvoiceCountByDate(d1, d2) ?? 0);
            return (int) ret;
        }
        public static DsReports.SalesAmountDetailsDataTable GetDailySalesReport(DateTime d1, DateTime d2, bool bydate = false, bool useconstr = false, string newconstr = "p")
        {
            var ta = new SalesAmountDetailsTableAdapter { Connection = { ConnectionString = useconstr ? newconstr:_constr } };
            var ds = new DsReports().SalesAmountDetails;
            if (!bydate)
            {
                ta.Fill(ds);
            }
            else
            {
                ta.FillByDate(ds, d1, d2);
                
            }
            return ds;
        }
        
        public static DsReports.SalesAmountDetailsCreditDataTable SalesAmountDetailsCredit(DateTime d1, DateTime d2, bool bydate = false, bool useconstr = false, string newconstr = "p")
        {
            var ta = new SalesAmountDetailsCreditTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
            var ds = new DsReports().SalesAmountDetailsCredit;
            if(!bydate)
            ta.Fill(ds);
            else
            {
                ta.FillByDate(ds, d1, d2);
            }
            return ds;
        }
        //SalesAmountDetailsCredit
        public static  DsReports.GetItemMoveDataTable  GetItemMove (string itemname,string itemno,DateTime d1,DateTime d2)
        {
            var ta = new GetItemMoveTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().GetItemMove;
            ta.Fill(ds, itemname, itemno, d1, d2, Utils.Company);
            return ds;
        }
        public static DsReports.GetItemMoveDetailsDataTable GetItemMoveDetails(string itemname, string itemno, DateTime d1, DateTime d2)
        {
            var ta = new GetItemMoveDetailsTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().GetItemMoveDetails;
            ta.Fill(ds, itemname, itemno, d1, d2, Utils.Company);
            return ds;
        }
        public static decimal GetSalesQty(string itemno, DateTime d1, DateTime d2,bool isreturn=false)
        {
            var ta = new GetSQtyTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().GetSQty;
            ta.FillSQty(ds, d1, d2, itemno, isreturn) ;
            decimal ret = 0m;
            foreach (DataRow d in ds.Rows)
            {
                ret = decimal.Parse(d[0].ToString());
            }
            return ret;
        }
        public static decimal GetTransferQty(string itemno, DateTime d1, DateTime d2)
        {
            var ta = new GetTQtyTableAdapter() { Connection = { ConnectionString = _constr } };
            var ds = new DsReports().GetTQty;
            ta.FillTQty(ds, d1, d2, itemno,Utils.Company);
            decimal ret = 0m;
            foreach (DataRow d in ds.Rows)
            {
                ret = decimal.Parse(d[0].ToString());
            }
            return ret;
        }

        public static DsReports.SalesTargetFrmDtToDtDataTable SalesTargetFrmDtToDate(DateTime d1, DateTime d2, int empid,
            string empno, string empname, string stye, string constr)
        {

            var ds = new DsReports().SalesTargetFrmDtToDt;
            var ta = new SalesTargetFrmDtToDtTableAdapter { Connection = { ConnectionString = constr } };
            ta.Fill(ds, empname, d1, d2, empid, stye, empno);
            return ds;  
        }

        public static DsReports.GETSALESTARGETBYDATEDataTable GetSalestargetbyDate(string empno, int empid, DateTime d1, DateTime d2, string empname, string constr)
        {
            return new GETSALESTARGETBYDATETableAdapter { Connection = { ConnectionString = constr } }.GetData(empno,empid,d1,d2,empname)  ;
        }
        public static DsReports.GetSalesTargetDetFSelStoreDataTable GetSalesTargetDetFSelStore(string commid, int empid, bool useconstr = false, string newconstr = "p")
        {
            var ds = new DsReports().GetSalesTargetDetFSelStore ;
            var ta = new GetSalesTargetDetFSelStoreTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr  } };
            ta.Fill(ds, commid,empid);
            return ds;
        }
        public static DsReports.GetSalesTargetItemDetailsDataTable GetSalesTargetDetails(string commid, string itemno, int empid, bool useconstr = false, string newconstr = "p")
        {
            return new GetSalesTargetItemDetailsTableAdapter {Connection = {ConnectionString =  useconstr ? newconstr : _constr }}
                    .GetSalesTargetItemDetails(commid, empid,itemno);
        }
        public static DsReports.GetSupplierWiseShortageDataTable GetSupplierWiseShortage(string commid)
        {
            //var ds = new DsReports().GetSupplierWiseShortage;
           // var ta = 
            return  new GetSupplierWiseShortageTableAdapter { Connection = { ConnectionString = _constr } }.GetData(commid);
            //ta.Fill(ds, commid);
            //return ds;
        }
        public static DsReports.GetShortingbyCategoryDataTable GetShortingbyCategory(string catid)
        {
               return   new GetShortingbyCategoryTableAdapter { Connection = { ConnectionString = _constr } }.GetData(int.Parse(catid));
        }
        public static DsReports.SalesInvListDataTable GetSalesInvRpt(string sinvno,bool issale=true)
        {
            var ta = new taSalesInvList { Connection = { ConnectionString = _constr } }; 
            var ds = new DsReports.SalesInvListDataTable();
            ta.FillBySalesInv(ds,issale,false,sinvno);
            return ds;
        }
        public static DsReports.SalesReturnListDataTable SalesReturnListData(DateTime d1, DateTime d2)
        {
            var ta = new SalesReturnListTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsReports.SalesReturnListDataTable();
            ta.Fill(ds, d1, d2);
            return ds;
        }
        public static DsReports.ItemWiseSalesSummaryNewDataTable ItemWiseSalesSummaryData(DateTime d1, DateTime d2)
        {
         return new ItemWiseSalesSummaryNewTableAdapter {Connection = {ConnectionString = _constr}}.GetData(d1.Date, d2.Date);
        //    var ds = new DsReports.ItemWiseSalesSummaryDataTable();
        //    ta.Fill(ds, d1, d2,Utils.Company);
        //    return ds;
         }

        public static DsReports.SALESMAININSURANCEDataTable InsuranceSalesDetails(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
        {
            var ta = new SALESMAININSURANCETableAdapter
            {
                Connection =  { ConnectionString = useconstr ? newconstr : _constr } 
            };
            return ta.GetDataInsuranceDetails(d1, d2);
        }
        public static DsReports.GetCashSalesDataTable GetCashSalesDataTable(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
       {
           var ta = new GetCashSalesTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
           var ds = new DsReports.GetCashSalesDataTable();
           ta.Fill(ds, d1, d2,Utils.Company);
           return ds;
       }
        public static DsReports.GetCreditSalesDataTable GetCreditSalesDataTable(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
       {
           var ta = new GetCreditSalesTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
           var ds = new DsReports.GetCreditSalesDataTable();
           ta.Fill(ds, d1, d2, Utils.Company);
           return ds;
       }
        public static DsReports.GetInsuranceSalesDataTable GetInsuranceSalesDataTable(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
       {
           var ta = new GetInsuranceSalesTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } };
           return ta.GetData(d1, d2, Utils.Company);
           
       }

        public static DsReports.SalesByITEMGROUPDataTable SalesByItemGroup(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
        {
            return new DsReportsTableAdapters.SalesByITEMGROUPTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } }.GetData(d1, d2);
        }
        public static DsReports.ItemWiseExpiryReportDataTable ItemWiseExpiryReport(DateTime d1, bool useconstr = false, string newconstr = "p")
        {
            return new DsReportsTableAdapters.ItemWiseExpiryReportTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } }.GetData(d1);
        }
        public static DsReports.SalesRankDataTable SalesRank(DateTime d1, DateTime d2, int rnk, bool useconstr = false, string newconstr = "p")
        {
            return new DsReportsTableAdapters.SalesRankTableAdapter { Connection = { ConnectionString = useconstr ? newconstr : _constr } }.GetData(d1,d2,rnk);
        }

        public static DsReports.InsuranceSalesByItemWiseDataTable InsuranceSalesByItemWise(DateTime d1, DateTime d2, bool useconstr, string newconstr)
        {
          return  new InsuranceSalesByItemWiseTableAdapter
            {
                Connection = {ConnectionString = useconstr ? newconstr : _constr}
            }.GetData(d1, d2);
         }
    }
}
