using System;
using System.Data;
using DevExpress.XtraReports.UI;
using Store.BusinessLogic;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.DALCOMMON;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Sales;
using VIRETAILENTITIES;

namespace Store.Reports
{
    public class BLReports
    {
        decimal s1;
        decimal s2;
        decimal s3;
        decimal tot = 0m;

        public DsReports.DailySalesDataTable GetDailySales(decimal closingdiff,DateTime d1,DateTime d2,bool isdate,bool useconstr=false,string newconstr="p")
        {
            var ds = ReportsDataManager.GetDailySalesReport(d1,d2,isdate,useconstr,newconstr);
            var ds1 = new DsReports();
            var dt = ds1.DailySales;
            CreateFixDailySales(ref dt);
            
            foreach (DataRow dr1 in ds.Rows)
            {
              //  var tot = 0m;
                var drs = dt.Select("Ctype = " + int.Parse(dr1["amounttype"].ToString()) + "");
              //  tot += decimal.Parse(dr1["amount"].ToString());
                foreach (var dr in drs)
                {
                    var scode = int.Parse(dr1["shiftcode"].ToString());
                    
                    if (scode == 1 || scode == 0)
                    {
                        dr["Shift1"] = dr1["amount"];
                      //  dr["Total"] = tot;
                    }
                    if (scode == 2)
                    {
                        dr["Shift2"] = dr1["amount"];
                        //tot += decimal.Parse(dr1["amount"].ToString());
                       // dr["Total"] = tot;
                    }
                    if (scode == 3)
                    {
                        dr["Shift3"] = decimal.Parse(dr1["amount"].ToString()).ToString("N2");
                       // tot += decimal.Parse(dr1["amount"].ToString());
                       // dr["Total"] = tot;
                    }
                    
                }
            }

            InsertSummaryRow(ref dt);
            AddProfitPer(ref dt);
     

            //GetCustomerCount
            AddFooter(ref dt,d1,isdate,useconstr,newconstr);
            if (closingdiff > 0)
            {
                var ndr = dt.NewRow();
                ndr["Ctype"] = 16;
                ndr["Shift1"] = closingdiff;
                dt.Rows.Add(ndr);
            }


            var ndr1 = dt.NewRow();
            ndr1["Ctype"] = 20;
            ndr1["Shift1"] = ReportsDataManager.GetCustomerCount(d1, d2, isdate,useconstr,newconstr); 

            dt.Rows.Add(ndr1);

            return dt;
        }
        void  AddFooter(ref DsReports.DailySalesDataTable dt ,DateTime d1,bool isdate,bool useconstr=false,string newconstr="p")
        {
            var cprice = isdate ? GetSumCprice(d1, useconstr, newconstr) : GetSumCprice(useconstr, newconstr);
            var sprice = isdate ? GetSumSprice(d1, useconstr, newconstr) : GetSumSprice(useconstr, newconstr);
            var begcas = GetLastClosingAmt(d1,isdate);
            var cashonhand = 0m;
            foreach (DataRow d in dt.Rows)
            {
                if (d["Ctype"].ToString() == "1")
                    if(!string.IsNullOrEmpty(d["TOTAL"].ToString()))
                         cashonhand = decimal.Parse(d["TOTAL"].ToString());
            }
            var ndr = dt.NewRow();
            ndr["Ctype"] = 11;
            ndr["Shift1"] = cprice;
            ndr["Shift3"] = "Sale value";
            ndr["TOTAL"] = sprice;
            dt.Rows.Add(ndr);
            //dt.Rows.InsertAt(ndr, 12); 
            //ndr = dt.NewRow();
            //ndr["Ctype"] = 12;
            //ndr["Shift1"] = sprice;
            //dt.Rows.Add(ndr);
            //dt.Rows.InsertAt(ndr, 13);

            ndr = dt.NewRow();
            ndr["Ctype"] = 13;
            ndr["Shift1"] = begcas;
            ndr["Shift3"] = "Cash on hand";
            ndr["TOTAL"] = cashonhand + begcas;

            dt.Rows.Add(ndr);
            //dt.Rows.InsertAt(ndr, 14);
           //ndr = dt.NewRow();
           // ndr["Ctype"] = 14;
           // ndr["Shift1"] = cashonhand + begcas;
           // dt.Rows.Add(ndr);
           // dt.Rows.InsertAt(ndr, 15);
        }
        void InsertSummaryRow(ref DsReports.DailySalesDataTable dt )
        {
            //var ndr = dt.NewRow();
            //ndr["Ctype"] = 4;
            var tots = 0m;
            foreach (DataRow dr in dt.Rows)
            {
                if (int.Parse(dr["ctype"].ToString()) < 11)
                {
                    if (!string.IsNullOrEmpty(dr["Shift1"].ToString()))
                    {
                        tots += decimal.Parse(dr["Shift1"].ToString());
                    }
                    if (!string.IsNullOrEmpty(dr["Shift2"].ToString()))
                    {
                        tots += decimal.Parse(dr["Shift2"].ToString());
                    }
                    if (!string.IsNullOrEmpty(dr["Shift3"].ToString()))
                    {
                        tots += decimal.Parse(dr["Shift3"].ToString());
                    }
                    if(tots!=0)
                    dr["Total"] = tots;
                    tots = 0;
                    // if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                    //     tot += decimal.Parse(dr["Total"].ToString());

                }
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (int.Parse(dr["ctype"].ToString()) < 4)
                {
                    if (!string.IsNullOrEmpty(dr["Shift1"].ToString()))
                    {
                        s1 += decimal.Parse(dr["Shift1"].ToString());
                        //tots += decimal.Parse(dr["Shift1"].ToString());
                    }
                    if (!string.IsNullOrEmpty(dr["Shift2"].ToString()))
                    {
                        s2 += decimal.Parse(dr["Shift2"].ToString());
                        //tots += decimal.Parse(dr["Shift2"].ToString());
                    }
                    if (!string.IsNullOrEmpty(dr["Shift3"].ToString()))
                    {
                        s3 += decimal.Parse(dr["Shift3"].ToString());
                        //tots += decimal.Parse(dr["Shift3"].ToString());
                    }
                }
            }


            foreach (DataRow dr in dt.Rows)
            {
                if (int.Parse(dr["ctype"].ToString()) == 4)
                {
                    dr["Shift1"] = s1;
                    dr["Shift1"] = s1;
                    dr["Shift2"] = s2;
                    dr["Shift3"] = s3.ToString("N2");
                    dr["Total"] = s1 + s2 + s3;
                }
            }
           // ndr["Shift1"] = s1;
           // ndr["Shift2"] = s2;
           // ndr["Shift3"] = s3;
           // ndr["Total"] = tot;
           //// dt.Rows.Add(ndr);
           // dt.Rows.InsertAt(ndr,3);
        }
        void AddProfitPer(ref DsReports.DailySalesDataTable dt )
        {
            decimal p1 = 0m;
            decimal p2 = 0m;
            decimal p3 = 0m;
            decimal ptot = 0m;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Ctype"].ToString() == "9")
                {
                    if (!string.IsNullOrEmpty(dr["Shift1"].ToString()))
                        p1 += decimal.Parse(dr["Shift1"].ToString());
                    if (!string.IsNullOrEmpty(dr["Shift2"].ToString()))
                        p2 += decimal.Parse(dr["Shift2"].ToString());
                    if (!string.IsNullOrEmpty(dr["Shift3"].ToString()))
                        p3 += decimal.Parse(dr["Shift3"].ToString());
                    if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                        ptot += decimal.Parse(dr["Total"].ToString());
                }
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Ctype"].ToString() == "10")
                {
                    if (s1 != 0)
                    {
                        dr["Shift1"] = (p1/s1)*100;
                        ptot =(p1 / s1) * 100;
                    }
                    if (s2 != 0)
                    {
                        dr["Shift2"] = (p2/s2)*100;
                        ptot += (p2 / s2) * 100;

                    }
                    if (s3 != 0)
                    {
                        dr["Shift3"] = ((p3/s3)*100).ToString("N2");
                        ptot += (p3 / s3) * 100;
                    }
                    if (ptot != 0)
                    {
                        dr["Total"] = ptot;
                        if(p1 >0 && p2 > 0 && p3 >0)
                            dr["Total"] = ptot/3;
                        if (p1 > 0 && p2 > 0 && p3 == 0)
                            dr["Total"] = ptot / 2;

                        if (p1 > 0 && p2 == 0 && p3 == 0)
                            dr["Total"] = ptot ;
                        if (p1 == 0 && p2 > 0 && p3 == 0)
                            dr["Total"] = ptot;
                        if (p1 == 0 && p2 == 0 && p3 > 0)
                            dr["Total"] = ptot;

                    }
                }
            }

        }
        void CreateFixDailySales(ref DsReports.DailySalesDataTable dt)
        {
            for (int i = 1; i < 11; i++)
            {
                    var dr = dt.NewRow();
                    dr["Ctype"] = i;
                    dt.Rows.Add(dr);
              
            }
        }
        public DsReports.DailySalesDataTable GetCreditDetails(DateTime d1, DateTime d2, bool isdate, bool useconstr = false, string newconstr = "p")
        {
            var ds = ReportsDataManager.SalesAmountDetailsCredit(d1,d2,isdate,useconstr,newconstr);
            var ds1 = new DsReports();
            var dt = ds1.DailySales;
            //for (int i = 1; i < 4; i++)
            //{
            //    var dr = dt.NewRow();
            //    dr["Ctype"] = i;
            //    dt.Rows.Add(dr);
            //}
            var dr = dt.NewRow();
            dt.Rows.Add(GetDataRow(ds, "A", "2", dr, true));
            dr = dt.NewRow();
            dt.Rows.Add(GetDataRow(ds, "C", "3", dr));

            dr = dt.NewRow();
            dt.Rows.Add(GetDataRow(ds, "I", "3", dr));

           

            return dt;
        }
        DataRow GetDataRow(DataTable dt, string tp, string amttype, DataRow dr, bool getcard = false)
        {
            decimal cs1 = 0m;
            decimal cs2 = 0m;
            decimal cs3 = 0m;
            decimal ctot = 0m;
            int amtype = 0;
            if (tp == "A")
                amtype = 1;
            if (tp == "C")
                amtype = 2;
            if (tp == "I")
                amtype = 3;
            foreach (DataRow dr1 in dt.Rows)
            {
                if(getcard? dr1["AMOUNTTYPE"].ToString() == amttype :(dr1["CUSTTYPE"].ToString() == tp && dr1["AMOUNTTYPE"].ToString() == amttype))
                {
                    var scode = int.Parse(dr1["shiftcode"].ToString());
                   
                    if (scode == 1 || scode == 0)
                    {
                        cs1 += decimal.Parse(dr1["amount"].ToString()); 
                        ctot += decimal.Parse(dr1["amount"].ToString());
                    }
                    if (scode == 2)
                    {
                        cs2 += decimal.Parse(dr1["amount"].ToString());
                        ctot += decimal.Parse(dr1["amount"].ToString());
                    }
                    if (scode == 3)
                    {
                        cs3 += decimal.Parse(dr1["amount"].ToString());
                        ctot += decimal.Parse(dr1["amount"].ToString());
                    }
                    dr["Ctype"] = amtype;
                    dr["Shift1"] = cs1;
                    dr["Shift2"] = cs2;
                    dr["Shift3"] = cs3.ToString("N2");
                    dr["Total"] = ctot;
                }
            }
            return dr;
        }
        public decimal GetSumCprice(bool useconstr = false, string newconstr = "p")
        {
            return new StockMaster().SumCostPrice(useconstr,newconstr);
        }
        public decimal GetSumSprice(bool useconstr = false, string newconstr = "p")
        {
            return new StockMaster().SumSalePrice(useconstr, newconstr);
        }

        public decimal GetSumCprice(DateTime d1, bool useconstr = false, string newconstr = "p")
        {
            decimal retval = 0m;
            var bl = new BlDailySales().GetSPCP(d1,2,useconstr,newconstr);
            foreach (DataRow dr in bl.Rows)
            {
                retval = decimal.Parse(dr["CVALUE"].ToString());
            }
            return retval;
        }
        public decimal GetSumSprice(DateTime d1, bool useconstr = false, string newconstr = "p")
        {
            decimal retval = 0m;
            var bl = new BlDailySales().GetSPCP(d1, 1,useconstr,newconstr);
            foreach (DataRow dr in bl.Rows)
            {
                retval = decimal.Parse(dr["CVALUE"].ToString());
            }
            return retval;
        }
        public decimal GetLastClosingAmt(DateTime d1, bool isdate)
        {
            decimal retval = 0m;
            var bl = new BlDailySales().GetLastClosing(d1,isdate);
            foreach (DataRow dr in bl.Rows)
            {
                if(dr["CTYPE"].ToString()=="1")
                {
                    retval = decimal.Parse(dr["CVALUE"].ToString());
                }
            }
            return retval;
        }

        public  DsReports.GETSALESTARGETBYDATEDataTable GetSalestargetbyDate(string empno, int empid, DateTime d1,
            DateTime d2, string empname, string constr)
        {
            return ReportsDataManager.GetSalestargetbyDate(empno, empid, d1, d2, empname, constr);
        }
        public DsReports.SalesTargetFrmDtToDtDataTable SalesTargetFrmDtToDate(DateTime d1,DateTime d2,int empid,string empno,string empname,string stye,string constr)
        {
            return ReportsDataManager.SalesTargetFrmDtToDate(d1, d2, empid, empno, empname, stye, constr);
        }
        public DsReports.GetSalesTargetDetFSelStoreDataTable GetSalesTargetDetFSelStore(string comid, int empid, bool useconstr = false, string newconstr = "p")
        {
            return ReportsDataManager.GetSalesTargetDetFSelStore(comid, empid, useconstr, newconstr);
        }
        public DsReports.GetSalesTargetItemDetailsDataTable GetSalesTargetDetails(string commid, string itemno, int empid, bool useconstr = false, string newconstr = "p")
        {
            return ReportsDataManager.GetSalesTargetDetails(commid, itemno,empid,useconstr ,  newconstr );
        }
        public DsReports.GetSupplierWiseShortageDataTable GetSupplierWiseShortage(string supid)
        {
            return ReportsDataManager.GetSupplierWiseShortage(supid);
        }
        public DsReports.GetShortingbyCategoryDataTable GetShortingbyCategory(string supid)
        {
            return ReportsDataManager.GetShortingbyCategory(supid);
        }
        public DsReports.SalesInvListDataTable GetRptSalesInv(string invno,bool issale=true)
        {
            return ReportsDataManager.GetSalesInvRpt(invno, issale);
        }
        public decimal GetSalesQty(string itemno,DateTime d1,DateTime d2)
        {
          return ReportsDataManager.GetSalesQty(itemno,d1, d2);
        }
        public decimal GetReturnQty(string itemno,DateTime d1,DateTime d2)
        {
            return ReportsDataManager.GetSalesQty(itemno, d1, d2,true);
        }
        public decimal GetTransferQty(string itemno,DateTime d1,DateTime d2)
        {
            return ReportsDataManager.GetTransferQty(itemno, d1, d2);
        }
        public DsReports.GetItemMoveDataTable GetItemMove (string itemname,string itemno,DateTime d1,DateTime d2)
        {
            return ReportsDataManager.GetItemMove(itemname, itemno, d1, d2);
        }
        public DsReports.GetItemMoveDetailsDataTable GetItemMoveDetails(string itemname, string itemno, DateTime d1, DateTime d2)
        {
            return ReportsDataManager.GetItemMoveDetails(itemname, itemno, d1, d2);
        }
        public  DsReports.SalesReturnListDataTable SalesReturnListData(DateTime d1,DateTime d2)
        {
            return ReportsDataManager.SalesReturnListData(d1, d2);
        }
        public DsReports.ItemWiseSalesSummaryNewDataTable ItemWiseSalesSummaryData(DateTime d1, DateTime d2)
        {
           return ReportsDataManager.ItemWiseSalesSummaryData(d1, d2);
        }
        public DsReports.SalesRankDataTable  SalesRank(DateTime d1, DateTime d2,int rnk,bool useconstr = false, string newconstr = "p")
        {
            return ReportsDataManager.SalesRank(d1, d2,rnk,  useconstr , newconstr);
        }
        public DsReports.SalesByITEMGROUPDataTable SalesByItemGroup(DateTime d1, DateTime d2)
        {
            return ReportsDataManager.SalesByItemGroup(d1, d2);
        }
        public DsReports.ItemWiseExpiryReportDataTable ItemWiseExpiryReport(DateTime d1)
        {
            return ReportsDataManager.ItemWiseExpiryReport(d1);
        }
        public DsReports.SALESMAININSURANCEDataTable InsuranceSalesDetails(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
        {
            return ReportsDataManager.InsuranceSalesDetails(d1, d2,useconstr ,  newconstr);
        }

        public DsReports.InsuranceSalesByItemWiseDataTable InsuranceSalesByItemWise(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
        {
            return ReportsDataManager.InsuranceSalesByItemWise(d1, d2, useconstr, newconstr);
        }
  
        public DsReports.GetCashSalesDataTable GetCashSalesDataTable(DateTime d1,DateTime d2, bool useconstr = false, string newconstr = "p")
        {
            return ReportsDataManager.GetCashSalesDataTable(d1, d2, useconstr, newconstr);
        }
        public DsReports.GetCreditSalesDataTable GetCreditSalesDataTable(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
        {
            return ReportsDataManager.GetCreditSalesDataTable(d1, d2, useconstr, newconstr);
        }
        public DsReports.GetInsuranceSalesDataTable GetInsuranceSalesDataTable(DateTime d1, DateTime d2, bool useconstr = false, string newconstr = "p")
        {
            return ReportsDataManager.GetInsuranceSalesDataTable(d1, d2, useconstr, newconstr);
        }
        public void PrintUCF(string sinvno,bool bgimag=false){
            var bl = new SalesManger().GetSalesReport(sinvno);
            var rpt = new RptUcfa();
         //   var dssal =   bl.Copy();
            if (bl.Rows.Count < 5)
            {
                for (int i = 0; i < 4 - bl.Rows.Count; i++)
                {
                    var dr = bl.NewRow();
                    bl.Rows.Add(dr);
                }
            }


            rpt.DataSource = bl;
            try
            {
                if (bgimag)
                {
                    rpt.Watermark.ImageTransparency = 1500;
                 //   rpt.Watermark.Image = Bitmap.FromFile("watermark.gif");
                  
                }

                rpt.Print();
            }
            catch (Exception ex)
            {
                var stri = ex.ToString();
                rpt.Print();
            }

        }
        public void PrintInsuranceSalesInvioce(string sinvno)
        {
            var bl = new SalesManger().GetSalesReport(sinvno);
            var rpt = new RptSalesInsurance();
            decimal compshare = 0;
            decimal patshare = 0;
            decimal netamt = 0;
            string _Cashier = string.Empty;
            string _Doctorname = string.Empty;
            string cmpname = Utils.Companyname;
            foreach (DsReports.SalesInvListRow dr in bl.Rows)
            {
                netamt = dr.NETAMT;
                patshare = dr.CARDDISC;
                compshare = dr.CUSTOMERFIXDISC;
                _Cashier = new BLUserinfo().GetUserinfoByUserid(dr.SALESMAN);
                if (dr.DOCTOR > 0)
                    _Doctorname = new BLUserinfo().GetUserinfoByUserid(dr.DOCTOR);
                if (dr.CUSTNAME.ToUpper().IndexOf("BUPA") != -1)
                {
                    cmpname = "Exceer";
                }
	
            }
            var amtaf = netamt * (compshare / 100);
            var psh = (netamt - amtaf) * (patshare / 100);
            rpt.compshare = amtaf.ToString("##.##");
            rpt.patshare = psh.ToString("N2");
            if (Utils.Company=="01")
                rpt.company = cmpname;
            else
                rpt.company = Utils.Companyname;
            rpt.doctorname = _Doctorname;
            rpt.DataSource = bl;
            try
            {
                rpt.Print();
            }
            catch (Exception ex)
            {
                var stri = ex.ToString();
            }
        }
        public void PrintDosageLable(string dno)
        {
            //SlipPrinting sp = new SlipPrinting();
            //sp.ds = new VIRETAILDAL.Masters.DrugDispatch().GetDosageSlipDataTable(dno);
            //sp.DoDrugPrint();

            var rpt = new RptSlipPrinter();
            rpt.DataSource = new DrugDispatch().GetDosageSlipDataTable(dno);
            rpt.ShowPreview();
           // rpt.Print();
        }


        
       
     
    }
   


}
