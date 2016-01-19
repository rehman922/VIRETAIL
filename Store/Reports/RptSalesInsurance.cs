using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace Store.Reports
{
    public class RptSalesInsurance : XtraReport
    {
        private TopMarginBand topMarginBand1;
        private XRLabel xrLabel1;
        private DetailBand detailBand1;
        private XRCrossBandBox xrCrossBandBox1;
        private XRLabel patdisc;
        private XRLabel compdiscamt;
        private XRLabel xrLabel23;
        private XRLabel xrLabel22;
        private XRLabel lbldoctor;
        private XRLabel xrLabel32;
        private XRLabel xrLabel34;
        private XRLabel xrLabel33;
        private XRLine xrLine2;
        private XRLine xrLine1;
        private XRLine xrLine3;
        private BottomMarginBand bottomMarginBand1;
    
        public RptSalesInsurance()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            XRSummary xrSummary1 = new XRSummary();
            XRSummary xrSummary2 = new XRSummary();
            Detail = new DetailBand();
            xrLabel21 = new XRLabel();
            xrLabel20 = new XRLabel();
            xrLabel19 = new XRLabel();
            xrLabel18 = new XRLabel();
            xrLabel26 = new XRLabel();
            TopMargin = new TopMarginBand();
            labelcompany = new XRLabel();
            xrLabel1 = new XRLabel();
            BottomMargin = new BottomMarginBand();
            xrLabel2 = new XRLabel();
            xrLabel3 = new XRLabel();
            xrLabel4 = new XRLabel();
            xrLabel5 = new XRLabel();
            PageHeader = new PageHeaderBand();
            xrLine2 = new XRLine();
            xrLine1 = new XRLine();
            xrLabel32 = new XRLabel();
            lbldoctor = new XRLabel();
            xrLabel23 = new XRLabel();
            xrLabel22 = new XRLabel();
            xrLabel15 = new XRLabel();
            xrLabel29 = new XRLabel();
            xrLabel30 = new XRLabel();
            xrLabel31 = new XRLabel();
            xrLabel16 = new XRLabel();
            xrLabel17 = new XRLabel();
            xrLabel10 = new XRLabel();
            xrLabel9 = new XRLabel();
            xrLabel6 = new XRLabel();
            xrLabel8 = new XRLabel();
            xrLabel7 = new XRLabel();
            ReportFooter = new ReportFooterBand();
            xrLine3 = new XRLine();
            xrLabel34 = new XRLabel();
            xrLabel33 = new XRLabel();
            patdisc = new XRLabel();
            compdiscamt = new XRLabel();
            xrLabel25 = new XRLabel();
            lbldiscount = new XRLabel();
            xrLabel13 = new XRLabel();
            lblpatshare = new XRLabel();
            xrLabel11 = new XRLabel();
            xrLabel24 = new XRLabel();
            xrCrossBandBox1 = new XRCrossBandBox();
            ((ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            Detail.Controls.AddRange(new XRControl[] {
            xrLabel21,
            xrLabel20,
            xrLabel19,
            xrLabel18,
            xrLabel26});
            Detail.HeightF = 20F;
            Detail.KeepTogether = true;
            Detail.Name = "Detail";
            Detail.Padding = new PaddingInfo(0, 0, 0, 0, 100F);
            Detail.TextAlignment = TextAlignment.TopLeft;
            // 
            // xrLabel21
            // 
            xrLabel21.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.LINETOTAL", "{0:n2}")});
            xrLabel21.LocationFloat = new PointFloat(625.0834F, 0F);
            xrLabel21.Name = "xrLabel21";
            xrLabel21.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel21.SizeF = new SizeF(72.91669F, 20F);
            xrLabel21.StylePriority.UseTextAlignment = false;
            xrLabel21.Text = "xrLabel21";
            xrLabel21.TextAlignment = TextAlignment.MiddleRight;
            // 
            // xrLabel20
            // 
            xrLabel20.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.INVRATE", "{0:n2}")});
            xrLabel20.LocationFloat = new PointFloat(566.1246F, 0F);
            xrLabel20.Name = "xrLabel20";
            xrLabel20.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel20.SizeF = new SizeF(54.16656F, 20F);
            xrLabel20.StylePriority.UseTextAlignment = false;
            xrLabel20.Text = "xrLabel20";
            xrLabel20.TextAlignment = TextAlignment.MiddleRight;
            // 
            // xrLabel19
            // 
            xrLabel19.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.QTY", "{0:#,#}")});
            xrLabel19.LocationFloat = new PointFloat(515.2913F, 0F);
            xrLabel19.Name = "xrLabel19";
            xrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel19.SizeF = new SizeF(46.62515F, 20F);
            xrLabel19.StylePriority.UseTextAlignment = false;
            xrLabel19.Text = "[SalesInvList.QTY]";
            xrLabel19.TextAlignment = TextAlignment.MiddleCenter;
            // 
            // xrLabel18
            // 
            xrLabel18.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.ITEMNAME")});
            xrLabel18.LocationFloat = new PointFloat(31.54163F, 0F);
            xrLabel18.Name = "xrLabel18";
            xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel18.SizeF = new SizeF(470.0833F, 20F);
            xrLabel18.StylePriority.UseTextAlignment = false;
            xrLabel18.Text = "xrLabel18";
            xrLabel18.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel26
            // 
            xrLabel26.LocationFloat = new PointFloat(2.083333F, 0F);
            xrLabel26.Name = "xrLabel26";
            xrLabel26.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel26.SizeF = new SizeF(26.33333F, 20F);
            xrLabel26.StylePriority.UseTextAlignment = false;
            xrSummary1.Func = SummaryFunc.RecordNumber;
            xrSummary1.Running = SummaryRunning.Report;
            xrLabel26.Summary = xrSummary1;
            xrLabel26.Text = "xrLabel26";
            xrLabel26.TextAlignment = TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            TopMargin.Controls.AddRange(new XRControl[] {
            labelcompany,
            xrLabel1});
            TopMargin.HeightF = 69F;
            TopMargin.Name = "TopMargin";
            TopMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100F);
            TopMargin.TextAlignment = TextAlignment.TopLeft;
            // 
            // labelcompany
            // 
            labelcompany.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelcompany.LocationFloat = new PointFloat(85.41666F, 15.25F);
            labelcompany.Name = "labelcompany";
            labelcompany.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            labelcompany.SizeF = new SizeF(534.8745F, 25.5F);
            labelcompany.StylePriority.UseFont = false;
            labelcompany.StylePriority.UseTextAlignment = false;
            labelcompany.Text = "labelcompany";
            labelcompany.TextAlignment = TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            xrLabel1.Borders = ((BorderSide.Left | BorderSide.Top) 
                                | BorderSide.Right) 
                               | BorderSide.Bottom;
            xrLabel1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xrLabel1.LocationFloat = new PointFloat(256.1667F, 43.75F);
            xrLabel1.Name = "xrLabel1";
            xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel1.SizeF = new SizeF(182.7082F, 23.75F);
            xrLabel1.StylePriority.UseBorders = false;
            xrLabel1.StylePriority.UseFont = false;
            xrLabel1.StylePriority.UseTextAlignment = false;
            xrLabel1.Text = "Sales Invoice";
            xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            BottomMargin.HeightF = 25F;
            BottomMargin.Name = "BottomMargin";
            BottomMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100F);
            BottomMargin.TextAlignment = TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            xrLabel2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel2.LocationFloat = new PointFloat(455.6246F, 6F);
            xrLabel2.Name = "xrLabel2";
            xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel2.SizeF = new SizeF(87.5F, 18F);
            xrLabel2.StylePriority.UseFont = false;
            xrLabel2.StylePriority.UseTextAlignment = false;
            xrLabel2.Text = "Invoice No. :";
            xrLabel2.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            xrLabel3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel3.LocationFloat = new PointFloat(455.6246F, 30.00002F);
            xrLabel3.Name = "xrLabel3";
            xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel3.SizeF = new SizeF(87.5F, 18F);
            xrLabel3.StylePriority.UseFont = false;
            xrLabel3.StylePriority.UseTextAlignment = false;
            xrLabel3.Text = "Date :";
            xrLabel3.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            xrLabel4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel4.LocationFloat = new PointFloat(5.124998F, 6.00001F);
            xrLabel4.Name = "xrLabel4";
            xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel4.SizeF = new SizeF(129.4583F, 18F);
            xrLabel4.StylePriority.UseFont = false;
            xrLabel4.StylePriority.UseTextAlignment = false;
            xrLabel4.Text = "Customer name :";
            xrLabel4.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            xrLabel5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel5.LocationFloat = new PointFloat(5.000003F, 30.00002F);
            xrLabel5.Name = "xrLabel5";
            xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel5.SizeF = new SizeF(129.5833F, 18F);
            xrLabel5.StylePriority.UseFont = false;
            xrLabel5.StylePriority.UseTextAlignment = false;
            xrLabel5.Text = "Doctor :";
            xrLabel5.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // PageHeader
            // 
            PageHeader.Controls.AddRange(new XRControl[] {
            xrLine2,
            xrLine1,
            xrLabel32,
            lbldoctor,
            xrLabel23,
            xrLabel22,
            xrLabel4,
            xrLabel15,
            xrLabel5,
            xrLabel29,
            xrLabel30,
            xrLabel31,
            xrLabel3,
            xrLabel2,
            xrLabel16,
            xrLabel17,
            xrLabel10,
            xrLabel9,
            xrLabel6,
            xrLabel8,
            xrLabel7});
            PageHeader.HeightF = 112.4167F;
            PageHeader.Name = "PageHeader";
            // 
            // xrLine2
            // 
            xrLine2.LocationFloat = new PointFloat(3.208333F, 110.4167F);
            xrLine2.Name = "xrLine2";
            xrLine2.SizeF = new SizeF(700.6667F, 2F);
            // 
            // xrLine1
            // 
            xrLine1.LocationFloat = new PointFloat(3.333333F, 86.54166F);
            xrLine1.Name = "xrLine1";
            xrLine1.SizeF = new SizeF(699.3334F, 2F);
            // 
            // xrLabel32
            // 
            xrLabel32.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.CARDNO")});
            xrLabel32.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel32.LocationFloat = new PointFloat(543.1246F, 54.00003F);
            xrLabel32.Name = "xrLabel32";
            xrLabel32.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel32.SizeF = new SizeF(154.9586F, 18F);
            xrLabel32.StylePriority.UseFont = false;
            xrLabel32.StylePriority.UseTextAlignment = false;
            xrLabel32.Text = "xrLabel32";
            xrLabel32.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // lbldoctor
            // 
            lbldoctor.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldoctor.LocationFloat = new PointFloat(134.5833F, 30F);
            lbldoctor.Name = "lbldoctor";
            lbldoctor.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            lbldoctor.SizeF = new SizeF(291.6667F, 18F);
            lbldoctor.StylePriority.UseFont = false;
            lbldoctor.StylePriority.UseTextAlignment = false;
            lbldoctor.Text = "lbldoctorname";
            lbldoctor.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel23
            // 
            xrLabel23.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.GRADE")});
            xrLabel23.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel23.LocationFloat = new PointFloat(327.3748F, 54.00003F);
            xrLabel23.Name = "xrLabel23";
            xrLabel23.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel23.SizeF = new SizeF(122.2498F, 18F);
            xrLabel23.StylePriority.UseFont = false;
            xrLabel23.StylePriority.UseTextAlignment = false;
            xrLabel23.Text = "xrLabel23";
            xrLabel23.TextAlignment = TextAlignment.MiddleLeft;
            xrLabel23.Visible = false;
            // 
            // xrLabel22
            // 
            xrLabel22.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.CARDID")});
            xrLabel22.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel22.LocationFloat = new PointFloat(134.5833F, 54.00001F);
            xrLabel22.Name = "xrLabel22";
            xrLabel22.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel22.SizeF = new SizeF(142.9167F, 18F);
            xrLabel22.StylePriority.UseFont = false;
            xrLabel22.StylePriority.UseTextAlignment = false;
            xrLabel22.Text = "xrLabel22";
            xrLabel22.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            xrLabel15.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.CUSTNAME")});
            xrLabel15.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel15.LocationFloat = new PointFloat(134.5833F, 5.999994F);
            xrLabel15.Name = "xrLabel15";
            xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel15.SizeF = new SizeF(291.6667F, 18F);
            xrLabel15.StylePriority.UseFont = false;
            xrLabel15.StylePriority.UseTextAlignment = false;
            xrLabel15.Text = "xrLabel15";
            xrLabel15.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel29
            // 
            xrLabel29.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel29.LocationFloat = new PointFloat(455.6246F, 54.00003F);
            xrLabel29.Name = "xrLabel29";
            xrLabel29.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel29.SizeF = new SizeF(87.5F, 18F);
            xrLabel29.StylePriority.UseFont = false;
            xrLabel29.StylePriority.UseTextAlignment = false;
            xrLabel29.Text = "Policy No. :";
            xrLabel29.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel30
            // 
            xrLabel30.Font = new Font("Tahoma", 9.75F);
            xrLabel30.LocationFloat = new PointFloat(280.5832F, 54.00003F);
            xrLabel30.Name = "xrLabel30";
            xrLabel30.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel30.SizeF = new SizeF(46.79153F, 18F);
            xrLabel30.StylePriority.UseFont = false;
            xrLabel30.StylePriority.UseTextAlignment = false;
            xrLabel30.Text = "Class :";
            xrLabel30.TextAlignment = TextAlignment.MiddleLeft;
            xrLabel30.Visible = false;
            // 
            // xrLabel31
            // 
            xrLabel31.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel31.LocationFloat = new PointFloat(4.166667F, 54.00003F);
            xrLabel31.Name = "xrLabel31";
            xrLabel31.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel31.SizeF = new SizeF(130.4166F, 18F);
            xrLabel31.StylePriority.UseFont = false;
            xrLabel31.StylePriority.UseTextAlignment = false;
            xrLabel31.Text = "Member Id / File No. :";
            xrLabel31.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            xrLabel16.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.SINVNO")});
            xrLabel16.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xrLabel16.LocationFloat = new PointFloat(543.1246F, 6.00001F);
            xrLabel16.Name = "xrLabel16";
            xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel16.SizeF = new SizeF(154.8755F, 18F);
            xrLabel16.StylePriority.UseFont = false;
            xrLabel16.StylePriority.UseTextAlignment = false;
            xrLabel16.Text = "xrLabel16";
            xrLabel16.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            xrLabel17.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.TRANDATE")});
            xrLabel17.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xrLabel17.LocationFloat = new PointFloat(543.1246F, 30.00002F);
            xrLabel17.Name = "xrLabel17";
            xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel17.SizeF = new SizeF(153.8754F, 18F);
            xrLabel17.StylePriority.UseFont = false;
            xrLabel17.StylePriority.UseTextAlignment = false;
            xrLabel17.Text = "xrLabel17";
            xrLabel17.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            xrLabel10.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            xrLabel10.LocationFloat = new PointFloat(625.0833F, 88.54166F);
            xrLabel10.Name = "xrLabel10";
            xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel10.SizeF = new SizeF(72.91669F, 19.79166F);
            xrLabel10.StylePriority.UseFont = false;
            xrLabel10.StylePriority.UseTextAlignment = false;
            xrLabel10.Text = "Total";
            xrLabel10.TextAlignment = TextAlignment.MiddleCenter;
            // 
            // xrLabel9
            // 
            xrLabel9.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            xrLabel9.LocationFloat = new PointFloat(568.1246F, 88.54166F);
            xrLabel9.Name = "xrLabel9";
            xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel9.SizeF = new SizeF(52.16663F, 19.79166F);
            xrLabel9.StylePriority.UseFont = false;
            xrLabel9.StylePriority.UseTextAlignment = false;
            xrLabel9.Text = "Price";
            xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            xrLabel6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            xrLabel6.LocationFloat = new PointFloat(4.083333F, 88.62505F);
            xrLabel6.Name = "xrLabel6";
            xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel6.SizeF = new SizeF(26.33333F, 19.79166F);
            xrLabel6.StylePriority.UseFont = false;
            xrLabel6.StylePriority.UseTextAlignment = false;
            xrLabel6.Text = "S #";
            xrLabel6.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            xrLabel8.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            xrLabel8.LocationFloat = new PointFloat(518.1666F, 88.54166F);
            xrLabel8.Name = "xrLabel8";
            xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel8.SizeF = new SizeF(43.75009F, 19.79166F);
            xrLabel8.StylePriority.UseFont = false;
            xrLabel8.StylePriority.UseTextAlignment = false;
            xrLabel8.Text = "Qty";
            xrLabel8.TextAlignment = TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            xrLabel7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            xrLabel7.LocationFloat = new PointFloat(31.54163F, 88.62505F);
            xrLabel7.Name = "xrLabel7";
            xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel7.SizeF = new SizeF(470.0833F, 19.79167F);
            xrLabel7.StylePriority.UseFont = false;
            xrLabel7.StylePriority.UseTextAlignment = false;
            xrLabel7.Text = "Item name";
            xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            ReportFooter.Controls.AddRange(new XRControl[] {
            xrLine3,
            xrLabel34,
            xrLabel33,
            patdisc,
            compdiscamt,
            xrLabel25,
            lbldiscount,
            xrLabel13,
            lblpatshare,
            xrLabel11,
            xrLabel24});
            ReportFooter.Font = new Font("Tahoma", 9F);
            ReportFooter.HeightF = 81.25003F;
            ReportFooter.KeepTogether = true;
            ReportFooter.Name = "ReportFooter";
            ReportFooter.StylePriority.UseFont = false;
            // 
            // xrLine3
            // 
            xrLine3.LocationFloat = new PointFloat(3.25F, 0F);
            xrLine3.Name = "xrLine3";
            xrLine3.SizeF = new SizeF(699.5833F, 2.083333F);
            // 
            // xrLabel34
            // 
            xrLabel34.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.CUSTOMERFIXDISC", "{0:#.00}")});
            xrLabel34.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xrLabel34.LocationFloat = new PointFloat(451.5833F, 20.83333F);
            xrLabel34.Name = "xrLabel34";
            xrLabel34.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel34.SizeF = new SizeF(60.25003F, 18F);
            xrLabel34.StylePriority.UseFont = false;
            xrLabel34.StylePriority.UseTextAlignment = false;
            xrLabel34.Text = "xrLabel34";
            xrLabel34.TextAlignment = TextAlignment.MiddleRight;
            // 
            // xrLabel33
            // 
            xrLabel33.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.CARDDISC", "{0:n2}")});
            xrLabel33.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xrLabel33.LocationFloat = new PointFloat(420.9164F, 41.41665F);
            xrLabel33.Name = "xrLabel33";
            xrLabel33.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel33.SizeF = new SizeF(60.25003F, 18F);
            xrLabel33.StylePriority.UseFont = false;
            xrLabel33.StylePriority.UseTextAlignment = false;
            xrLabel33.Text = "xrLabel33";
            xrLabel33.TextAlignment = TextAlignment.MiddleRight;
            // 
            // patdisc
            // 
            patdisc.LocationFloat = new PointFloat(598.75F, 41.62499F);
            patdisc.Name = "patdisc";
            patdisc.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            patdisc.SizeF = new SizeF(95.37476F, 17.79165F);
            patdisc.StylePriority.UseTextAlignment = false;
            patdisc.TextAlignment = TextAlignment.MiddleRight;
            // 
            // compdiscamt
            // 
            compdiscamt.LocationFloat = new PointFloat(598.75F, 20.62499F);
            compdiscamt.Name = "compdiscamt";
            compdiscamt.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            compdiscamt.SizeF = new SizeF(96.24994F, 21F);
            compdiscamt.StylePriority.UseTextAlignment = false;
            compdiscamt.TextAlignment = TextAlignment.MiddleRight;
            // 
            // xrLabel25
            // 
            xrLabel25.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.NETAMT", "{0:n2}")});
            xrLabel25.LocationFloat = new PointFloat(598.7499F, 0F);
            xrLabel25.Name = "xrLabel25";
            xrLabel25.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel25.SizeF = new SizeF(98.24994F, 20F);
            xrLabel25.StylePriority.UseTextAlignment = false;
            xrLabel25.Text = "xrLabel25";
            xrLabel25.TextAlignment = TextAlignment.MiddleRight;
            // 
            // lbldiscount
            // 
            lbldiscount.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lbldiscount.LocationFloat = new PointFloat(511.8333F, 20.83333F);
            lbldiscount.Name = "lbldiscount";
            lbldiscount.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            lbldiscount.SizeF = new SizeF(86.91678F, 21F);
            lbldiscount.StylePriority.UseFont = false;
            lbldiscount.StylePriority.UseTextAlignment = false;
            lbldiscount.Text = "% Discount : ";
            lbldiscount.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            xrLabel13.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            xrLabel13.LocationFloat = new PointFloat(509.8332F, 60.41667F);
            xrLabel13.Name = "xrLabel13";
            xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel13.SizeF = new SizeF(87.91675F, 18.79166F);
            xrLabel13.StylePriority.UseFont = false;
            xrLabel13.StylePriority.UseTextAlignment = false;
            xrLabel13.Text = "Net Amount :";
            xrLabel13.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // lblpatshare
            // 
            lblpatshare.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblpatshare.LocationFloat = new PointFloat(481.9999F, 40.625F);
            lblpatshare.Name = "lblpatshare";
            lblpatshare.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            lblpatshare.SizeF = new SizeF(116.7501F, 19.79167F);
            lblpatshare.StylePriority.UseFont = false;
            lblpatshare.StylePriority.UseTextAlignment = false;
            lblpatshare.Text = "% Patient Share :";
            lblpatshare.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel11
            // 
            xrLabel11.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            xrLabel11.LocationFloat = new PointFloat(528.5831F, 0.2083461F);
            xrLabel11.Name = "xrLabel11";
            xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel11.SizeF = new SizeF(70.16687F, 19.79166F);
            xrLabel11.StylePriority.UseFont = false;
            xrLabel11.StylePriority.UseTextAlignment = false;
            xrLabel11.Text = "Sub total :";
            xrLabel11.TextAlignment = TextAlignment.MiddleLeft;
            // 
            // xrLabel24
            // 
            xrLabel24.DataBindings.AddRange(new[] {
            new XRBinding("Text", null, "SalesInvList.CREDITAMT", "{0:#.00}")});
            xrLabel24.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xrLabel24.LocationFloat = new PointFloat(598.7499F, 59.54167F);
            xrLabel24.Name = "xrLabel24";
            xrLabel24.Padding = new PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel24.SizeF = new SizeF(94.24994F, 19.625F);
            xrLabel24.StylePriority.UseFont = false;
            xrLabel24.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrLabel24.Summary = xrSummary2;
            xrLabel24.Text = "xrLabel24";
            xrLabel24.TextAlignment = TextAlignment.MiddleRight;
            // 
            // xrCrossBandBox1
            // 
            xrCrossBandBox1.BorderWidth = 1F;
            xrCrossBandBox1.EndBand = PageHeader;
            xrCrossBandBox1.EndPointFloat = new PointFloat(2.083333F, 82.29166F);
            xrCrossBandBox1.LocationFloat = new PointFloat(2.083333F, 0F);
            xrCrossBandBox1.Name = "xrCrossBandBox1";
            xrCrossBandBox1.StartBand = PageHeader;
            xrCrossBandBox1.StartPointFloat = new PointFloat(2.083333F, 0F);
            xrCrossBandBox1.WidthF = 704.1667F;
            // 
            // RptSalesInsurance
            // 
            Bands.AddRange(new Band[] {
            Detail,
            TopMargin,
            BottomMargin,
            PageHeader,
            ReportFooter});
            CrossBandControls.AddRange(new XRCrossBandControl[] {
            xrCrossBandBox1});
            Margins = new Margins(54, 66, 69, 25);
            PageHeight = 1169;
            PageWidth = 827;
            PaperKind = PaperKind.A4;
            ShowPrintMarginsWarning = false;
            SnapToGrid = false;
            Version = "14.1";
            ((ISupportInitialize)(this)).EndInit();

        }

        public string compshare
        {
            set { compdiscamt.Text = value; }
        }

        public string patshare
        {
            set { patdisc.Text = value; }
        }

        public string company
        {
            set { labelcompany.Text = value; }
        }
        public string doctorname
        {
          set { lbldoctor.Text = value; }
        }

        private DetailBand Detail;
        private TopMarginBand TopMargin;
        private BottomMarginBand BottomMargin;
        private XRLabel xrLabel3;
        private XRLabel xrLabel2;
        private XRLabel labelcompany;
        private XRLabel xrLabel4;
        private XRLabel xrLabel5;
        private PageHeaderBand PageHeader;
        private XRLabel xrLabel10;
        private XRLabel xrLabel9;
        private XRLabel xrLabel8;
        private XRLabel xrLabel7;
        private XRLabel xrLabel6;
        private ReportFooterBand ReportFooter;
        private XRLabel xrLabel13;
        private XRLabel lblpatshare;
        private  XRLabel xrLabel11;
        private XRLabel lbldiscount;
        private  XRLabel xrLabel19;
        private XRLabel xrLabel18;
        private XRLabel xrLabel17;
        private XRLabel xrLabel16;
        private XRLabel xrLabel15;
        private XRLabel xrLabel21;
        private XRLabel xrLabel20;
        private XRLabel xrLabel25;
        private XRLabel xrLabel24;
        private XRLabel xrLabel26;
        private XRLabel xrLabel31;
        private XRLabel xrLabel30;
        private XRLabel xrLabel29;
    }
}
