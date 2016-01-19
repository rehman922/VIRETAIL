using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Sales;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store.BusinessLogic
{
    public class BLSales
    {
        public string _rptdet = string.Empty;
        public string _tot = string.Empty;
        public string _disc = string.Empty;
        public string _nettot = string.Empty;
        public DsInventory.SALESINVDETAILDataTable Salesinvdetail;
        public DsInventory.SALESMAINRow SalesmainRow;
        public Ledgers.SalesAmountDetailsDataTable SalesAmount;
        public string DoSave()
        {
            var bl = new SalesManger { salesinvdetailData = Salesinvdetail, salesmainRow = SalesmainRow, SalesAmount = SalesAmount };
            return bl.DoSave();
        }
        public string GetInvoiceNo()
        {
            return new SalesManger().GetInvoiceNo();
        }
        public DsInventory.STOCKMASTERDataTable GetStockItem(string itemno, string storetype)
        {
          return  new SalesManger().GetStockItem(itemno, "S");
        }
        public DsInventory.STOCKMASTERDataTable GetStockItemBySprice(string itemno,decimal sprice)
        {
            return new SalesManger().GetStockItemBySprice(itemno, "S",sprice);
        }
        public void UpdateQty(int stockid ,int qty)
        {
           new SalesManger().UpdateQty(stockid,qty);
        }
        public string UpdateQtyAndSalesTable(int stockid, int qty, DsInventory.SALESINVDETAILDataTable salesinvdetail)
        {
            return new SalesManger().UpdateQtyAndSalesTable(stockid, qty, salesinvdetail);
        }
        public void AddNewItemwithNegativeQty(DsInventory.STOCKMASTERRow dr)
        {
            new SalesManger().AddNewItemwithNegativeQty(dr);
        }
        public void UpdateSprice(decimal sprice,int stockid)
        {
            new SalesManger().UpdateSprice(sprice, stockid);
        }
        public string DoSave(string sinvo, bool hold, int salesman, int doctorid, decimal totamt = 0, decimal netamt = 0)
        {
            return new SalesManger().DoSave(sinvo, hold, salesman, doctorid, GetShiftCode(),Environment.MachineName,totamt,netamt);
        }
        public DsInventory.SALESMAINDataTable GetSalesInvMainBySinvno(string sinvno)
        {
            return new SalesManger().GetSalesInvMainBySinvno(sinvno);
        }
        public string GetShiftCode(string s="SHIFT")
        {
            return  ClsGetData.GetSysCode(s);
        }
        public void UpdateShitCode(string scode)
        {
            ClsGetData.UpdateSysCode(scode);
        }
        public string UpdateDetails(DsInventory.SALESINVDETAILDataTable salesinvdetail)
        {
            var retval = new SalesManger().UpdateSalesInvDetail(salesinvdetail);
            return retval;
        }
        public int GetDoctorLogin()
        {
            return new DOCTORSESSION().GetDoctorLogin();
        }
        public string DoSalesItemDelete(DsInventory.SALESINVDETAILRow dRow)
        {
            return new SalesManger().DoSalesItemDelete(dRow);
        }
        public int CheckSalesHoldByStockid(int stockid)
        {
            return new SalesManger().CheckSalesHoldByStockid(stockid);
        }
        public void UpdatePointsDetails(string custno, decimal points, string comp, DateTime dt, string sinv, decimal redimamt)
        {
            var bl = new BlCustomer();
            bl.UpdatePointsDetails(custno, points, comp,dt,sinv, redimamt);
        }
        public int GetTotalSalesQty(string itemno,DateTime d1,DateTime d2)
        {
          return  new SalesManger().GetTotalSalesQty(itemno, d1, d2);
        }
        public string DeleteSalesInvDetail(string sinvno)
        {
           return new SalesManger().DeleteSalesInvDetail(sinvno);
        }
        public void DeleteSalesInvMain(string sinvno)
        {
            new SalesManger().DeleteSalesInvMain(sinvno);
        }
        public void DoHold(string sinvno, int lineno, string customerid, string customername, decimal sdisc, decimal rounding)
        {
            new SalesManger().DoHold(sinvno,customerid, customername,sdisc,rounding);
        }
        public void DoPrint(string sinvno,string customern = "")
        {
            //DoSlipPrint(sinvno);
            //var rpt = new Reports.RptSalesInvoice();
            //var ds = new Reports.BLReports().GetRptSalesInv(sinvno);
            //rpt.Company = VIRETAILDAL.COMMON.Utils.Companyname;
            //rpt.DataSource = ds;
            //var printTool = new ReportPrintTool(rpt);
            //printTool.ShowPreview();
            var ds = new BLReports().GetRptSalesInv(sinvno);
            var rpt = new RptSalesInvoice();
            rpt.Customername = customern;
            rpt.DataSource = ds;

            rpt.Company = Utils.Companyname;
            if (!string.IsNullOrEmpty(ds[0]["SDISC"].ToString()))
            {
                rpt.patshare = decimal.Parse(ds[0]["SDISC"].ToString()).ToString("n2");
            }
            rpt.NetAmount = decimal.Parse(ds[0]["NETAMT"].ToString()).ToString("n2"); //netamoount.ToString("n2");
            rpt.Print();
        }
        public void DoInsurancePrint(string sinvno)
        {
            var bl = new BLReports();
            bl.PrintInsuranceSalesInvioce(sinvno);
        }
        public DsInventory.SALESMAINDataTable GetSalesInvMain(string invno,bool ff,bool hold)
        {
          return  new SalesManger().GetSalesInvMain(invno, ff,hold);
        }
        public void DoUCAFPrint(string sinvno,bool chk)
        {
              new BLReports().PrintUCF(sinvno,chk);
        }
        public void DoSlipPrint(string sinvno)
        {
            var ds = new BLReports().GetRptSalesInv(sinvno);
            var sp = new SlipPrinting();
            sp._InvoiceNo = sinvno;
           
            sp.ds = ds;
            sp.print();
        }
        public void DoSlipPrint(string sinvno,string customer, decimal subtotal = 0, decimal discount = 0, decimal retamt = 0, decimal netamoount = 0,bool screenprint=false)
        {
            var ds = new BLReports().GetRptSalesInv(sinvno,false);
            var rpt = new RptSalesInvoice();
            rpt.DataSource = ds;

            rpt.Company = Utils.Companyname;
            rpt.patshare = discount.ToString("n2");
            rpt.NetAmount = netamoount.ToString("n2");
            rpt.ScreenPrint = screenprint;
            rpt.Customername = customer;
            rpt.Print();
            //var sp = new SlipPrinting();
            //sp._InvoiceNo = sinvno;
            //sp._tot = subtotal.ToString();
            //sp._disc = discount.ToString();
            //sp._ReturnAmt = retamt.ToString();
            //sp._NetAmount = netamoount.ToString();
            //sp.ds = ds;
            //sp.print();
        }
        public DsInventory.SALESMAINDataTable GetHoldInvno()
        {
            return  ClsGetData.GetHoldedSalesInvoices(Environment.MachineName);
        }
        public void GetSalesInvDetail(string sinvno)
        {
            var bl = new SalesManger();
            bl.GetSalesInvDetails(sinvno);
            Salesinvdetail = bl.salesinvdetailData;
        }
        public void GetNonSaleInv()
        {
            var bl = new SalesManger();
            bl.GetNonSaleInv();
            SalesmainRow = bl.salesmainRow;
            Salesinvdetail = bl.salesinvdetailData;
        }
        public void DoUnHold(string sinvono)
        {
            new SalesManger().DoUnHold(sinvono);
        }

        public int GetStockByItemno(string itemno)
        {
            return new SalesManger().GetStockByItemno(itemno);   
  
        }
        public int GetAvailableQty(string itemno)
        {
            return new SalesManger().GetAvailableQty(itemno);   
        }
        public string GetExpiryDt(string itemno)
        {
            return new SalesManger().GetExpiryDt(itemno);   
        }
        public DataTable GetStock(string itemno)
        {
            return new SalesManger().GetStock(itemno);   

        }
        public int  GetAvailableSQty(int itemid)
        {
            return new SalesManger().GetAvailableSQty(itemid);   
        }
        public decimal GetSalesPriceByItemno(string itemno)
        {
            return new StockMaster().GetSalesPriceByItemno(itemno);
        }
        public decimal GetDiscount(string itemno)
        {
            return new ItemMaster().GetDiscount(itemno);
        }
        public IEnumerable<decimal> GetDisctinctSprices(DsInventory.STOCKMASTERDataTable dt)
        {
            return new SalesManger().GetDisctinctSprices(dt);
        }
        public DsInventory.STOCKMASTERDataTable GetQtyRows(DsInventory.STOCKMASTERDataTable drstock,int reqqty)
        {
            var dt = new DsInventory().STOCKMASTER;
            int balqty = reqqty;
            foreach (DsInventory.STOCKMASTERRow dr in drstock.Rows)
            {
                if (dr.SQTY != 0)
                {
                    var drnew = (DsInventory.STOCKMASTERRow) dt.NewRow();
                    if (dr.SQTY - reqqty >= 0)
                    {
                        drnew.ItemArray = dr.ItemArray;
                        drnew.DQNTY = reqqty;
                        balqty -= reqqty;
                    }
                    else if (dr.SQTY - reqqty < 0)
                    {
                        drnew.ItemArray = dr.ItemArray;
                        balqty -= dr.SQTY;
                        drnew.DQNTY = dr.SQTY; // balqty;
                    }
                    dt.Rows.Add(drnew);
                    if (balqty == 0)
                        break;
                }
            }
            return dt;
        }
        public void UpdateCostprice(ref DsInventory.SALESINVDETAILDataTable sinvdetail)
        {
            foreach (DsInventory.SALESINVDETAILRow dr in sinvdetail)
            {
                 if(dr.CPRICE==0)
                    {
                        var di = GetPurDiscount(dr.ITEMNO);
                        dr.CPRICE = dr.INVRATE * (di / 100);
                    }
            }
        }
        private decimal GetPurDiscount(string itemno)
        {
            return new ItemMaster().GetPurchaseDist(itemno);
        }
        public  decimal CaluculateProfitValue(DsInventory.SALESINVDETAILDataTable sinvdetail)
        {
            decimal retval = 0m;
            decimal dis = 0;
            foreach (DsInventory.SALESINVDETAILRow dr in sinvdetail)
            {
                if (!dr.IsDISCNull())
                    if (dr.DISC > 0)
                    {
                          dis = dr.DISC;
                    }
                if(!dr.ISRETURN)
                {
                    retval += dr.QTY * (dr.INVRATE - (dr.INVRATE * (dis / 100)) - dr.CPRICE);
                }
            }
            return retval;
        }
        public  Ledgers.APARMAINDataTable GetSupCustUnPaidInvoices(string refno)
        {
            return new SalesManger().GetSupCustUnPaidInvoices(refno, "C");
        }
        public DsInventory.SALESINVDETAIL_DELDataTable GetSalesDeletedItems(DateTime d1,DateTime d2)
        {
           return new SalesManger().GetSalesDeletedItems(d1, d2);
        }
    }
    public class SlipPrinting
    {
 
        public DataTable ds { get; set; }
        public string _tot = "0";
        public string _disc = "0";
        public     string _ReturnAmt = "0";
        public string _NetAmount = "0";
        public string _InvoiceNo = string.Empty;
        string _Cashier = string.Empty;
        string _Doctorname;
        public string _CustomerName = string.Empty;
        string _Patientname = string.Empty;
        string _stype = "R";
        string _FileNo;
        string _PolicyNo;
        string _CardDisc;
        string _CustomerFixDisc;
        string _Grade;
         
        static int rowcount;
        int pageheight;
        private bool firsrtpage = true;
        PrinterSettings settings = new PrinterSettings();
        void SetHeaderAndFooterData()
        {
            DataRow Hrow = ds.Rows[0];
            //DOCTOR
            //SALESMAN
             _Cashier = new BLUserinfo().GetUserinfoByUserid(int.Parse(Hrow["SALESMAN"].ToString()));
             if (int.Parse(Hrow["DOCTOR"].ToString()) > 0)
                 _Doctorname = new BLUserinfo().GetUserinfoByUserid(int.Parse(Hrow["DOCTOR"].ToString()));

                 _stype = Hrow["SALESTYPE"].ToString();
            if(string.IsNullOrEmpty(_stype))
                _stype = "R";
            if (_stype == "C")
            {
                 _CustomerName = Hrow["CUSTNAME"].ToString();
            }
            if (_stype == "I")
            {
                _FileNo = Hrow["CARDID"].ToString();
                _PolicyNo = Hrow["CARDNO"].ToString();
                _CardDisc = Hrow["CARDDISC"].ToString();
                _CustomerFixDisc = Hrow["CUSTOMERFIXDISC"].ToString();
                _Grade = Hrow["GRADE"].ToString();
                var sp = Hrow["CUSTNAME"].ToString().Split('-');
                _CustomerName = sp[0];
                 if (sp.Length > 1)
                 {
                     _Patientname = sp[1];
                 }
             }
            if(_tot=="0")
                _tot = Hrow["TOTALAMT"].ToString();
            if (_disc == "0")
              _disc = string.IsNullOrEmpty(Hrow["SDISC"].ToString()) ? "0" : Hrow["SDISC"].ToString();
            if (_NetAmount == "0")
             _NetAmount = Hrow["NETAMT"].ToString();
            if (_ReturnAmt == "0")
               _ReturnAmt = Hrow["RETURNAMT"].ToString();
            if (string.IsNullOrEmpty(_ReturnAmt))
                _ReturnAmt = "0";
        }
        public void DoDrugPrint()
        {
            PrintDocument pdoc = null;
            var pd = new PrintDialog();
            pdoc = new PrintDocument();

            //pdoc.PrinterSettings.DefaultPageSettings.PaperSize.Height = 120;
            //pdoc.PrinterSettings.DefaultPageSettings.PaperSize.Width = 330;
            

            pd.Document = pdoc;
            string pname = string.Empty;
            pd.Document = pdoc;

            var pv = new PrintPreviewDialog();

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                {
                    pd.PrinterSettings.PrinterName = printer;
                    //pageheight = pd.PrinterSettings.DefaultPageSettings.PaperSize.Height - pd.PrinterSettings.DefaultPageSettings.Margins.Top -
                    //pd.PrinterSettings.DefaultPageSettings.Margins.Bottom;
                    //pdoc.DefaultPageSettings.PaperSize.Height = 1120;
                    //pdoc.DefaultPageSettings.PaperSize.Width = 2730;
                    pdoc.PrintPage += PrintDrugDosage;// pd.ShowDialog();
                    pv.Document = pdoc;
                     pv.ShowDialog();
                    // pdoc.Print();
                }
            }
        }
        public void print()
        {
            PrintDocument pdoc = null;
            var pd = new PrintDialog();
            pdoc = new PrintDocument();
            pd.Document = pdoc;
            string pname = string.Empty;
            pd.Document = pdoc;
            var pv = new PrintPreviewDialog();
            SetHeaderAndFooterData();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                {
                    pd.PrinterSettings.PrinterName = printer;
                    pageheight = pd.PrinterSettings.DefaultPageSettings.PaperSize.Height -
                    pd.PrinterSettings.DefaultPageSettings.Margins.Top -
                    pd.PrinterSettings.DefaultPageSettings.Margins.Bottom;
                 //   if (string.IsNullOrEmpty(VIRETAILDAL.COMMON.Utils.DefaultPrinterRow["Invoiceprinter"].ToString()))
                 //// if (pd.PrinterSettings.DefaultPageSettings.PaperSize.RawKind == 1 || pd.PrinterSettings.DefaultPageSettings.PaperSize.RawKind == 4)
                 //   {
                 //       pdoc.PrintPage += PrintForA4;// pd.ShowDialog();
                 //       pv.Document = pdoc;
                 //      // pv.ShowDialog();
                 //        pdoc.Print();
                 //   }
                 //   else
                 //   {
                        pdoc.PrintPage += PrintReceipt;
                        pdoc.Print();
         //           }
                   //  return;
                }
            }
        }
        void PrintForA4(object sender, PrintPageEventArgs e)
        {

            Graphics graphics = e.Graphics;
            int rpp;
            var startX = 40;
            var startY = 100;
            var Offset = 10;
            float width = 275 + 275 + 220;
            float height = 40.0F;
            var drawBrush = new SolidBrush(Color.Black);
            RectangleF drawRect;
            var drawFormat = new StringFormat();
            var pen = new Pen(Color.Black, 1.5F);
            pen.DashStyle = DashStyle.Dot;
            var drawString = Utils.Companyname;
            var drawFont1 = new Font("Arial", 10, FontStyle.Bold);
            var drawFont2 = new Font("Arial", 9, FontStyle.Bold);
            var drawFont = new Font("Arial", 9);
            if (firsrtpage)
            {
                drawRect = new RectangleF(startX, startY, width, height);
                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                Offset += 10;
                //Address
                drawString = Utils.CompanyAddress;
                drawRect = new RectangleF(startX, startY + Offset, width, height);
                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                Offset += 15;

                if (_stype == "I" || _stype == "C")
                {
                    drawString = "Credit Invoice";
                    drawRect = new RectangleF(startX, startY + Offset, width, height);
                    drawFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
                    Offset += 15;
                }
                e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);
                Offset += 10;
                //Invoice No.

                drawString = "Invoice No.: " + _InvoiceNo;
                drawRect = new RectangleF(startX, startY + Offset, width, height);
                drawFormat.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
                //Offset += 15;

                //Date Time
                drawString = "Date Time : " + DateTime.Now;
                drawRect = new RectangleF(startX, startY + Offset, width-90, height);
                drawFormat.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                Offset += 15;
                //Cashier 
                drawString = "Cashier : " + _Cashier;
                drawRect = new RectangleF(startX, startY + Offset, width, height);
                drawFormat.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                if (_Doctorname != null)
                {
                    drawString = "Sales : " + _Doctorname;
                    drawRect = new RectangleF(startX, startY + Offset, width-90, height);
                    drawFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                   
                }
                Offset += 15;
                if ( _stype == "C")
                {
                    drawString = "Customer : " + _CustomerName;
                    drawRect = new RectangleF(startX, startY + Offset, width, height);
                    drawFormat.Alignment = StringAlignment.Near;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                    Offset += 15;
                }
                if (_stype == "I")
                {
                    drawString = "Customer : " + _CustomerName;
                    drawRect = new RectangleF(startX, startY + Offset, width, height);
                    drawFormat.Alignment = StringAlignment.Near;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

                    drawString ="Patient name : " + _Patientname;
                    drawRect = new RectangleF(startX, startY + Offset, width-90, height);
                    drawFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);


                    Offset += 15;
                    drawString = "Policy No :" + _PolicyNo;
                    drawRect = new RectangleF(startX, startY + Offset, width, height);
                    drawFormat.Alignment = StringAlignment.Near;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
         
                    drawString = "Member Id :" + _FileNo;
                    drawRect = new RectangleF(startX, startY + Offset, width-90, height);
                    drawFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

                    drawString = "Class :" + _Grade;
                    drawRect = new RectangleF(startX, startY + Offset, width - 90, height);
                    drawFormat.Alignment = StringAlignment.Far;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                    //Offset += 15;
                }
                firsrtpage = false;
            }
            Offset += 15;
            e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);
            Offset += 10;
            drawString = "Item name";
            drawRect = new RectangleF(startX, startY + Offset, width, height);
            drawFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
            //rpp = (int)(0.65 * ((pageheight - (int)(e.Graphics.MeasureString(drawString, drawFont2).Height)) / (int)(drawFont.Height + 10)));
            rpp = 16;
            drawString = "Qty";
            drawRect = new RectangleF(startX + 360, startY + Offset, width, height);
            drawFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
            
            drawString = "Price";
            drawRect = new RectangleF(startX + 510, startY + Offset, width, height);
            drawFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);

            drawString = " Total";
            drawRect = new RectangleF(startX + 650, startY + Offset, width, height);
            drawFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
            Offset += 20;
            e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);
            decimal _qty = 0;
            Offset += 10;

            for (int j = rowcount; j < Math.Min(rpp + rowcount, ds.Rows.Count) ; j++)
            {
                var d = ds.Rows[j];
                graphics.DrawString(d["ITEMNAME"].ToString(),
                                    new Font("Arial", 8),
                                    new SolidBrush(Color.Black), startX, startY + Offset);
            //     Offset += 18;
                _qty += decimal.Parse(d["QTY"].ToString());

                drawString = d["QTY"].ToString();
                drawRect = new RectangleF(startX + 350, startY + Offset, 50, height);

                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                drawRect = new RectangleF(startX + 500, startY + Offset, 50, height);
                drawString = Math.Round(decimal.Parse(d["INVRATE"].ToString()), 2).ToString();
                drawFormat.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

                drawRect = new RectangleF(startX + 630, startY + Offset, 60, height);
                drawString = Math.Round(decimal.Parse(d["LINETOTAL"].ToString()), 2).ToString();
                drawFormat.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
            //    Offset += 12;
                Offset += 10;
                e.Graphics.DrawLine(new Pen(Color.Gainsboro, 0.2F), startX, startY + Offset + 3, width, startY + Offset + 3);
              //  Offset += 12;
                Offset += 10;
            }
            rowcount += rpp - 1;
            if (rowcount >= rpp)
            {
                drawRect = new RectangleF(20,10, width, height);
                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString("..continued", drawFont1, drawBrush, drawRect, drawFormat);
            }
            if (rowcount >= ds.Rows.Count)
            {
                e.Graphics.DrawLine(pen, startX, startY + Offset , width, startY + Offset);
                Offset += 10;
                //Total Qty
                drawString = "Qty : " + _qty;
                drawRect = new RectangleF(startX, startY + Offset, width, height);
                drawFormat.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                Offset += 20;
                // Discount
                if ((decimal.Parse(_disc) > 0 || decimal.Parse(_ReturnAmt) > 0) && _stype != "I")
                {
                    drawString = "Sub-Total :" + Math.Round(decimal.Parse(_tot), 2); // Create font and brush.
                    drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                    drawFormat.Alignment = StringAlignment.Far;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

                    Offset += 20;
                    if (decimal.Parse(_disc) > 0)
                    {
                        drawString = "Disount  : " + Math.Round(decimal.Parse(_disc), 2); // Create font and brush.
                        drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;
                    }
                    if (decimal.Parse(_ReturnAmt) > 0)
                    {
                        drawString = "Return  : " + Math.Round(decimal.Parse(_ReturnAmt), 2);  // Create font and brush.
                        drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;
                    }
                    drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                    drawString = "Net Amount :" + Math.Round(decimal.Parse(_NetAmount), 2); // Create font and brush.
                    drawFormat.Alignment = StringAlignment.Far;
                    e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
                }
                else
                {
                    if (_stype != "I")
                    {
                        drawString = "Total : " + Math.Round(decimal.Parse(_NetAmount), 2); // Create font and brush.
                        drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
                    }

                    if (_stype == "I")
                    {

                        drawString = "Total : " + Math.Round(decimal.Parse(_NetAmount), 2); // Create font and brush.
                        drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;

                        decimal amtaf = 0;
                        amtaf = decimal.Parse(_NetAmount) * (decimal.Parse(_CustomerFixDisc) / 100);

                        drawString = Math.Round(decimal.Parse(_CustomerFixDisc), 2) + "% Discount : " + Math.Round(amtaf, 2); // Create font and brush.
                        drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;

                        var psh = (decimal.Parse(_NetAmount) - amtaf) * (decimal.Parse(_CardDisc) / 100);
                        drawString = Math.Round(decimal.Parse(_CardDisc), 2) + "% Patient Share : " + Math.Round(psh, 2); // Create font and brush.
                        drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;

                        var pnet = (decimal.Parse(_NetAmount) - amtaf) - psh;
                        drawString = "Net Amount : " + Math.Round(pnet, 2); // Create font and brush.
                        drawRect = new RectangleF(startX + 550, startY + Offset, 180, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
                    }
                }
                ////
                Offset += 20;
                //Pay Type
                e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);

               //graphics.DrawString(underLine, new Font("Courier New", 10, FontStyle.Bold),new SolidBrush(Color.Black), startX, startY + Offset+5);
                Offset += 12;
                drawString = "Keep Orginal Bills For Exchange/ Returns";
                drawRect = new RectangleF(startX, startY + Offset, width, height);
                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                Offset += 20;
                drawString = "THANKS FOR VISIT";
                drawRect = new RectangleF(startX, startY + Offset , width, height);
                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
            }
                if (rowcount >= ds.Rows.Count)
                {
                    //  pageCount++;
                    e.HasMorePages = false;
                    rowcount = 0;
                }
                else
                {
                    e.HasMorePages = true;
                }
            pen.Dispose();
        }
        public DsMaster.DosageSlipDataTable dr { set; get; }
        void PrintDrugDosage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int rpp;
            int startX = 1;
            int startY = 5;
            int Offset = 10;
            float width = 300;
            float height = 10.0F;
            var drawBrush = new SolidBrush(Color.Black);
            RectangleF drawRect;
            var drawFormat = new StringFormat();
            var pen = new Pen(Color.Black, 1.0F);
            pen.DashStyle = DashStyle.Dash;
            String drawString ;
            // Create font and brush.
            var drawFont1 = new Font("Arial", 7, FontStyle.Bold);
            foreach (DataRow dr in ds.Rows)
            {                
                rowcount++;
                drawString = dr["ARNAME"].ToString() + ' ' +  dr["CCODE"] + ":صيدلية رقم";
                drawRect = new RectangleF(startX, startY, width, height);
                drawFormat.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                startY += 10;

                drawString = dr["COMPNAME"].ToString() + ' ' + dr["TELEPHONE"] + ":تلفون الصيدلية";
                drawRect = new RectangleF(startX, startY, width, height);
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                startY += 10;

                drawString = dr["PATNAME"] + ":اسم المريض ";
                drawRect = new RectangleF(startX, startY, width, height);
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                startY += 10;

                drawString = dr["ITEMNAME"] + ":اسم الدواء ";
                drawRect = new RectangleF(startX, startY, width, height);
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                startY += 10;

                drawString = dr["DDNAMEAR"].ToString() +  dr["CCODE"] + ":الجرعة";
                drawRect = new RectangleF(startX, startY, width, height);
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                startY += 150;

                drawString = dr["PRECA"].ToString() + dr["CCODE"] + ":موانع اﻻستعمال";
                drawRect = new RectangleF(startX, startY, width, height);
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                startY += 10;

                drawString = dr["TDATE"] + " : تاريخ صرف الدواء" + ' ' + dr["EXPDT"] + ":تاريخ الصلاحية";
                drawRect = new RectangleF(startX, startY, width, height);
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                startY += 10;

                drawString = dr["USERNAME"] + ":توقيع الصيدلي";
                drawRect = new RectangleF(startX, startY, width, height);
                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
                startY += 10;
            }
            if (rowcount >0)
            {
                e.HasMorePages = false;
                rowcount = 0;
            }
            else
            {
                e.HasMorePages = true;
            }
            pen.Dispose();
        }
        void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int rpp;
            int startX = 5;
            int startY = 15;
            int Offset = 10;
            float width = 275;
            float height = 40.0F;
            var drawBrush = new SolidBrush(Color.Black);
            RectangleF drawRect;
            var drawFormat = new StringFormat();

            var pen = new Pen(Color.Black, 1.0F);
            pen.DashStyle = DashStyle.Dash;
            String drawString = Utils.Companyname ;
             // Create font and brush.
             var drawFont1 = new Font("Arial", 10,FontStyle.Bold);
             var drawFont2 = new Font("Arial", 9, FontStyle.Bold);
             var drawFont = new Font("Arial", 9);

             drawRect = new RectangleF(startX, startY, width, height);
             drawFormat.Alignment = StringAlignment.Center;
             e.Graphics.DrawString(drawString, drawFont1, drawBrush, drawRect, drawFormat);
             Offset += 10;
           //Address
             drawString = Utils.CompanyAddress;
             drawRect = new RectangleF(startX, startY + Offset, width, height);
             drawFormat.Alignment = StringAlignment.Center;
             e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
             Offset += 15;
           //Invoice No.
             if(_stype=="I")
             {
                 drawString = "Credit Invoice - Insurance";
                 drawRect = new RectangleF(startX, startY + Offset, width, height);
                 drawFormat.Alignment = StringAlignment.Center;
                 e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                 Offset += 15;
             }
             drawString = "Invoice No.: " + _InvoiceNo;
             drawRect = new RectangleF(startX, startY + Offset, width, height);
             drawFormat.Alignment = StringAlignment.Near;
             e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
             Offset += 15;
           //Date Time
             drawString = "Date Time : " + DateTime.Now;
             drawRect = new RectangleF(startX, startY + Offset, width, height);
             drawFormat.Alignment = StringAlignment.Near;
             e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
             Offset += 15;
           //Cashier 
             drawString = "Cashier : " + _Cashier;
             drawRect = new RectangleF(startX, startY + Offset, width, height);
             drawFormat.Alignment = StringAlignment.Near;
             e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
             Offset += 15;
           // 
             if (_Doctorname != null)
             {
                 drawString = "Sales : " + _Doctorname;
                 drawRect = new RectangleF(startX, startY + Offset, width, height);
                 drawFormat.Alignment = StringAlignment.Near;
                 e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                 Offset += 15;
             }
             if (_stype == "I" || _stype == "C")
             {
                 drawString = "Customer : " + _CustomerName;
                 drawRect = new RectangleF(startX, startY + Offset, width, height);
                 drawFormat.Alignment = StringAlignment.Near;
                 e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                 Offset += 15;
             }
             if (_stype == "I")
             {
                 drawString = "Patient name : " + _Patientname;
                 drawRect = new RectangleF(startX, startY + Offset, width, height);
                 drawFormat.Alignment = StringAlignment.Near;
                 e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

                 Offset += 15;
                 drawString = "Policy No :" + _PolicyNo;//+ "     Class :" + _Grade;
                 drawRect = new RectangleF(startX, startY + Offset, width, height);
                 drawFormat.Alignment = StringAlignment.Near;
                 e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                 Offset += 15;

                 drawString = "Member Id :" + _FileNo;
                 drawRect = new RectangleF(startX, startY + Offset, width, height);
                 drawFormat.Alignment = StringAlignment.Near;
                 e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                 Offset += 15;
             }

            e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);

             Offset += 20;
             drawString = "Item name";
             drawRect = new RectangleF(startX, startY + Offset, width, height);
             drawFormat.Alignment = StringAlignment.Near;
             e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);

            drawString = "Qty";
            drawRect = new RectangleF(startX+140, startY + Offset, width, height);
            drawFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);


            drawString = "Price";
            drawRect = new RectangleF(startX + 180, startY + Offset, width, height);
            drawFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);

            drawString = " Total";
            drawRect = new RectangleF(startX + 240, startY + Offset, width, height);
            drawFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(drawString, drawFont2, drawBrush, drawRect, drawFormat);
            Offset += 20;
            e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);
            decimal _qty = 0;

            Offset += 10;
            foreach (DataRow d in ds.Rows)
            {
                    graphics.DrawString(d["ITEMNAME"].ToString(),
                                        new Font("Arial", 8),
                                        new SolidBrush(Color.Black), startX, startY + Offset);
                     Offset += 10;
                    _qty += decimal.Parse(d["QTY"].ToString());

                    drawString = d["QTY"].ToString();
                    drawRect = new RectangleF(startX, startY + Offset, width, height);
                    drawFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

                    drawRect = new RectangleF(startX, startY + Offset, width - 70, height);
                    drawString = Math.Round(decimal.Parse(d["INVRATE"].ToString()), 2).ToString();
                    drawFormat.Alignment = StringAlignment.Far;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

                    drawRect = new RectangleF(startX, startY + Offset, width, height);
                    drawString = Math.Round(decimal.Parse(d["LINETOTAL"].ToString()), 2).ToString();
                    drawFormat.Alignment = StringAlignment.Far;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);


                    Offset += 12;
                    e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);
                    Offset += 12;
             }
               // e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);
                Offset += 10;
                //Total Qty
                drawString = "Qty : " + _qty;
                drawRect = new RectangleF(startX, startY + Offset, width, height);
                drawFormat.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
              //  Offset += 20;
                // Discount

                
                if ((decimal.Parse(_disc) > 0 || decimal.Parse(_ReturnAmt) > 0) && _stype!="I")
                {
                    drawString = "Sub-Total :" + Math.Round(decimal.Parse(_tot), 2); // Create font and brush.
                    drawRect = new RectangleF(startX, startY + Offset, width, height);
                    drawFormat.Alignment = StringAlignment.Far;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                    Offset += 20;

                    if (decimal.Parse(_disc) > 0)
                    {
                     
                        drawString = "Disount  : " + Math.Round(decimal.Parse(_disc), 2); // Create font and brush.
                        drawRect = new RectangleF(startX, startY + Offset, width, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;
                    }
                    if (decimal.Parse(_ReturnAmt) > 0)
                    {

                        drawString = "Return  : " + Math.Round(decimal.Parse(_ReturnAmt), 2); // Create font and brush.
                        drawRect = new RectangleF(startX, startY + Offset, width, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;
                    }



                    drawRect = new RectangleF(startX, startY + Offset, width, height);
                    drawString = "Net Amount :" + Math.Round(decimal.Parse(_NetAmount), 2); // Create font and brush.
                    drawFormat.Alignment = StringAlignment.Far;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                }
                else
                {
                    if (_stype != "I")
                    {
                        drawString = "Total : " + Math.Round(decimal.Parse(_NetAmount), 2); // Create font and brush.
                        drawRect = new RectangleF(startX, startY + Offset, width, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                    }
                    if(_stype=="I")
                    {

                        drawString = "Total : " + Math.Round(decimal.Parse(_NetAmount), 2); // Create font and brush.
                        drawRect = new RectangleF(startX, startY + Offset, width, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;

                        decimal amtaf = 0;
                        amtaf = decimal.Parse(_NetAmount)  * (decimal.Parse(_CustomerFixDisc) / 100);

                        drawString = Math.Round(decimal.Parse(_CustomerFixDisc), 2) + "% Discount : " + Math.Round(amtaf, 2); // Create font and brush.
                        drawRect = new RectangleF(startX, startY + Offset, width, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;
                        
                        var psh = (decimal.Parse(_NetAmount) - amtaf) * (decimal.Parse(_CardDisc)/100);

                        drawString = Math.Round(decimal.Parse(_CardDisc), 2) + "% Patient Share : " + Math.Round(psh, 2); // Create font and brush.
                        drawRect = new RectangleF(startX, startY + Offset, width, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                        Offset += 20;

                        var pnet = (decimal.Parse(_NetAmount) - amtaf) - psh;
                        drawString = "Net Amount : " + Math.Round(pnet, 2); // Create font and brush.
                        drawRect = new RectangleF(startX, startY + Offset+5, width, height);
                        drawFormat.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                    }
                }
                ////
              //  Offset += 20;
                e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);

                //graphics.DrawString(underLine, new Font("Courier New", 10, FontStyle.Bold),new SolidBrush(Color.Black), startX, startY + Offset+5);
                Offset += 20;
                drawString = "Keep Orginal Bills For Exchange/ Returns";
                drawRect = new RectangleF(startX, startY + Offset + 10, width, height);
                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                Offset += 10;
                e.Graphics.DrawLine(pen, startX, startY + Offset, width, startY + Offset);

                Offset += 20;
                drawString = "THANKS FOR VISIT";
                drawRect = new RectangleF(startX, startY + Offset + 10, width, height);
                drawFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                pen.Dispose();
        }
    }
     
}
