using System;
using System.Data;
using System.Security.Policy;

namespace VIRETAILDAL.COMMON
{
    public static class Utils
    {
        public static int Userid { get; set; }
        public static int Profileid { get; set; }
        public static string Permissions { get; set; }
        public static string Username { get; set; }
        public static string Company { get; set; }
        public static string Companyname { get; set; }
        public static string CompanyAddress { get; set; }
        public static string StaticIp { get; set; }
        public static string Sync { get; set; }
        public static string Purinvid { get; set; }
        public static string Retinvid { get; set; }
        public static string Tranid { get; set; }
        public static string Adjid { get; set; }
        public static string Pono { get; set; }
        public static string PurPayment { get; set; }

        public static string Itemno { get; set; }
        public static string CustomerNo { get; set; }
        public static string SupplierNo { get; set; }
        public static string CommissionNo { get; set; }
        public static string Connectionstring { get; set; }
        public static string ConnectionstringSync { get; set; }

        public static int NewUserid { get; set; }
        public static int UserType { get; set; }
        public static string SalesStoreCode { get; set; }
        public static string CustomerReceipt { get; set; }
        public static bool ManualDiscount { get; set; }
        public static decimal MaximumDiscount { get; set; }
        public static DataRow DefaultPrinterRow { get; set; }
        public static bool PrintInvoice { get; set; }
        public static string DosageNo { get; set;}
        public static string PERM { get;set; }
        public static int PrintSlipPrinter { get; set; }
        public static bool UsePoleDisplay { get; set; }
        public static string PortName { get; set; }
        public static Int32 BaudRate  { get; set; }
        public static Int16 DataBits { get; set; }
        public static string StopBits { get; set; }
        public static string Handshake { get; set; }
        public static string Parity { get; set; }

                //ComPort.PortName = Convert.ToString(cboPorts.Text);
                //ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
                //ComPort.DataBits = Convert.ToInt16(cboDataBits.Text);
                //ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                //ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                //ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
        

       
    }
}
