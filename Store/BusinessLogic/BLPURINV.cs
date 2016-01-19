using System;
using System.Data;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraReports.UI;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store.BusinessLogic
{
    public  class Blpurinv
    {
        public  string Purinvid {get; set;}
        public  string Supid {get; set;}
        public  string Supname {get; set;}
        public  string Invno {get; set;}
        public  DateTime Trandate = DateTime.Now;
        public  DateTime Invdate {get; set;}
        public  int Duedays {get; set;}
        public  decimal Spdiscount {get; set;}
        public  decimal Adjvalue {get; set;}
        public  bool Hold {get; set;}
        public  string Whid {get; set;}
        public  decimal Netvalue {get; set;}
        public  DsPurchase.PURINVDETAILDataTable Purinvdetail;
        private DsPurchase.PURINVMAINRow PurinvmainRow;
        public bool isforsale = false;
        public  Blpurinv(DataRow d)
        {
            var dr = (DsPurchase.PURINVMAINRow)d;
            PurinvmainRow = dr;
             if(!string.IsNullOrEmpty(dr.PURINVID))
                 Purinvid = dr.PURINVID;
            Supid = dr.SUPID;
            Supname = dr.SUPNAME;
            Invno = dr.INVNO;
            Invdate = dr.INVDATE;
            Duedays = dr.DUEDAYS;
            Spdiscount = dr.SPDISCOUNT;
            Adjvalue = dr.ADJVALUE;
            Hold = dr.HOLD;
            Whid = dr.WHID;
            Netvalue = dr.NETVALUE;
     
        }
        public  Blpurinv(){}
        public string DoSave()
        {
            var dm = new PurInvDataManager();

            var retval = dm.DoSave(PurinvmainRow, Purinvdetail,isforsale, Whid);
            if(retval=="1")
            {
                Purinvid = Utils.Purinvid;
            }
            return retval;
        }
        public void GetPurinv()
        {
            var dm = new PurInvDataManager();
            var ds = ClsGetData.GetPurchaseInvByid(Purinvid);
            foreach (DataRow d in ds.Rows)
            {
                Supid = d["SUPID"].ToString();
                Invno = d["INVNO"].ToString();
                Invdate = DateTime.Parse(d["INVDATE"].ToString());
                Duedays  = int.Parse(d["DUEDAYS"].ToString());
                Spdiscount =decimal.Parse(d["SPDISCOUNT"].ToString());
                Adjvalue = decimal.Parse(d["ADJVALUE"].ToString());
                Netvalue = decimal.Parse(d["NETVALUE"].ToString());
                Whid = d["WHID"].ToString();
                Hold = bool.Parse(d["HOLD"].ToString());
            }
            Purinvdetail  = dm.GetPurInvDetailsById(Purinvid);
          //Purinvdetail = ds1.PURINVDETAIL;
        }
        public DsMaster.TEMPBCODEPRINTDataTable CreateBarCodeTable(string purno)
        {
            var dt = new DsMaster().TEMPBCODEPRINT;
            var dm = new PurInvDataManager();
            Purinvdetail = dm.GetPurInvDetailsById(purno);
            foreach (DataRow dr in Purinvdetail.Rows)
            {
                var dnew = dt.NewRow();
                dnew["ITEMCODE"] = dr["itemno"];
                dnew["ITEMNAME"] = new BlItemMaster().GetItemname(dr["itemno"].ToString());
                var _qty = int.Parse(dr["qty"].ToString()) + (string.IsNullOrEmpty(dr["BONUSQTY"].ToString()) ? 0 : int.Parse(dr["BONUSQTY"].ToString()));
                dnew["QTY"] = _qty;
                dnew["PRICE"] = dr["SPRICE"];
                dt.Rows.Add(dnew);
            }
            return dt;
        }
        public static decimal GetCost(DsPurchase.PURINVDETAILRow dr)  
        {
            //cost = CostPrice(d.QTY, d.BONUSQTY, d.INVRATE, d.DISC, decimal.Parse(spdisc.EditValue.ToString()));
            var cost6 = 0m;
            if (dr.QTY != 0)
            {
                decimal cost1 = (dr.QTY + dr.BONUSQTY) ;
                var cost2 = dr.QTY * dr.INVRATE;
                var cost3 = cost2 / cost1;
                //var cost5 = 0m;
                //var cost4 = 0m;
                if (dr.DISC > 0)
                {
                    cost6 = cost3 - (cost3 * dr.DISC) / 100;
                    //cost6 = cost5;
                }
                else
                {
                    cost6 = cost3;
                }
                if (dr.SPDISC > 0)
                {
                    cost6 = cost6 - (cost6 * dr.SPDISC) / 100;
                    //cost6 = cost4;
                }
                if (dr.INVDISC > 0)
                {
                    cost6 = cost6 - (cost6 * dr.INVDISC) / 100;
                    //cost6 = cost4;
                }
                if (dr.DISC == 0 && dr.SPDISC==0 && dr.INVDISC == 0 && dr.BONUSQTY == 0)
                    cost6 = dr.INVRATE;
                //else if (dr.DISC == 0 && dr.INVDISC == 0 && dr.BONUSQTY != 0)
                //    cost6 = cost5;
            }
            return Math.Round(cost6,2);
        }
        public static decimal GetProfit(DsPurchase.PURINVDETAILRow dr)
        {
            decimal retval = 0;
            if(!dr.IsCPRICENull() && !dr.IsSPRICENull())    
               retval =  dr.SPRICE - dr.CPRICE  ;
            return retval;
        }
        public static DsPurchase.PURINVMAINDataTable GetPurinvMast() 
        {return ClsGetData.GetPurinvMast();}
        public static DsPurchase.PURINVMAINDataTable GetPurinvMastHold()
        {
            return ClsGetData.GetPurinvMastByHold();
        }
        public static int CountInvoiceNo(string invno, string supplier,string purid)
        {
            var dm = new PurInvDataManager();
            var t = !string.IsNullOrEmpty(purid) ? dm.GetInvoiceCountWithHold(supplier, invno, purid) : dm.GetInvoiceCount(supplier, invno);
            return t;
        }
        public static void DeletePurchaseInv(string purid)
        {
            var dm = new PurInvDataManager();
            dm.DeletePurchaseInv(purid, Utils.Company);
        }
        public static void DoPrint(string purid,decimal totalsale,decimal totalcost,decimal profit)
        {
            var dm = new PurInvDataManager();
            decimal pp = 0;
            if(totalcost > 0)
                pp = ((totalsale - totalcost) / totalsale) * 100;
            else
            {
                if (profit > 0)
                    pp = 100;
            }
            var rpt = new PurchaseRpt { Company = Utils.Companyname, Header = "Purchase Invocie", Docno = purid, TotalSale = totalsale, TotalCost = totalcost, Profit = profit, ProfitPer = pp };
            var ds = dm.RptPurchaseInv(purid, Utils.Company);
            rpt.DataSource = ds;
            var printTool = new ReportPrintTool(rpt);
            printTool.ShowPreview();
        }
        public static int GetLastReceived(string itemno)
        {
            var dm = new PurInvDataManager();
            return dm.GetLastReceivedPurchaseQtyWithBonus(itemno, Utils.Company); 
        }
        public int UpdatePurInv()
        {
            var dm = new PurInvDataManager();
            return dm.DoUpdateInv(Purinvid, Supid, Supname, Invno, Invdate, Duedays);
        } 
        public decimal PurchaseSaleValue(string purno)
        {
            return new PurInvDataManager().PurchaseSaleValue(purno);
        }
        public DsReports.APARMAIN1DataTable GetPurchaseLedger(string supid, int duedays, int option)
        {
            return new PurInvDataManager().GetPurchaseLedger(supid, duedays, option);
        }
    }
    public class BLPurchasePayment
    {
        public Ledgers.ARAPRECEIPTSRow dRow;
        public Ledgers.ARAPRECEIPTSDETAILSDataTable drTable;
        public string batchno = string.Empty;
        public string DoSave()
        {
            return new PurchasePayment().DoSave(dRow,drTable);
        }
        public void GetPurchasePayment()
        {
           drTable =  new PurchasePayment().GetArapreceiptsdetailsWithBatchno(batchno);
           dRow = (Ledgers.ARAPRECEIPTSRow) new PurchasePayment().GetArapReceiptWithBatchno(batchno).Rows[0];
        }
        public string DoPost()
        {
            return new PurchasePayment().DoPost(batchno,drTable);
        }
        public string DoDeleteInvoice(Ledgers.ARAPRECEIPTSDETAILSRow drdet)
        {
            return new PurchasePayment().DoDeleteInvoice(drdet);
        }

    }
    public class PurinvError : IDXDataErrorInfo
    {
        public string Supplier { get; set; }
        public string Invoiceno { get; set; }
        public string Invoicedate { get; set; }
        public string ToStore { get; set; }
        public string Purid { get; set; }
        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            if (propertyName == "Supplier" && string.IsNullOrEmpty(Supplier)
                || propertyName == "Invoiceno" && string.IsNullOrWhiteSpace(Invoiceno)
                || propertyName == "Invoicedate" && string.IsNullOrEmpty(Invoicedate)
                || propertyName == "ToStore" && string.IsNullOrEmpty(ToStore))
                info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
            if (propertyName == "Invoiceno" && !string.IsNullOrEmpty(Invoiceno))
            {
               if (!string.IsNullOrEmpty(Supplier))
               {
                   if (Blpurinv.CountInvoiceNo(Invoiceno, Supplier, Purid) > 0)
                   {
                       info.ErrorText = "Duplicate Invoice no."; 
                   }
               }
            }
            if (propertyName != "Supplier" || string.IsNullOrEmpty(Supplier)) return;
            if (string.IsNullOrEmpty(Invoiceno)) return;
            if (Blpurinv.CountInvoiceNo(Invoiceno, Supplier, Purid) > 0)
            {
                info.ErrorText = "Duplicate Invoice no.";
            }
        }
        public void GetError(ErrorInfo info)
        {
            // throw new NotImplementedException();
        }
    }
    

    
}
