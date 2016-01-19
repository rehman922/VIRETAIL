using System.Drawing;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store.BusinessLogic
{
    public class BLPO
    {
        public DsPurchase.POMAINRow PomainRow;
        public DsPurchase.PODETAILDataTable Podetail;
        public string Pono;
        public  string DoSave()
        {
            var dm = new PoDataManager { Drow = PomainRow, Podetail = Podetail };
            var retval = dm.DoSave();
            if (retval == "1")
            {
                Pono = Utils.Pono;
            }
            return retval;
        }
        public void GetPo()
        {
            var dm = new PoDataManager();
            var ds = ClsGetData.GetPurchaseOrderById(Pono);
            PomainRow = ds.Rows[0] as DsPurchase.POMAINRow;
            Podetail = ClsGetData.GetPurchaseOrderDetailById(Pono);
       }
        public static void DoPrint(string pono,bool t)
        {
            var dm = new PoDataManager();
            var rpt = new RptPO();
            if (t)
            {
                rpt.Watermark.Text = "Internal Copy";
            }
            else
            {
                rpt.Watermark.Text = "Supplier Copy";
                dm.UpdatePrint(pono);
            }
            rpt.Watermark.TextDirection = DirectionMode.ForwardDiagonal;
            rpt.Watermark.Font = new Font(rpt.Watermark.Font.FontFamily, 50);
            rpt.Watermark.ForeColor = Color.Gray;
            rpt.Watermark.TextTransparency = 150;
            rpt.Watermark.ShowBehind = false;
            rpt.Company = Utils.Companyname;
            var ds = dm.DoPrint(pono);
            rpt.DataSource = ds;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
           // printTool.ShowPreviewDialog();
            printTool.ShowPreview();

           // rpt.Print();
        }
        public static DsPurchase.POMAINDataTable GetPOMast()
        { return ClsGetData.GetPurchaseOrder(); }
    }
}
