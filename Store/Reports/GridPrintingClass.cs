using System.Drawing;
using System.Drawing.Printing;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using VIRETAILDAL.COMMON;

namespace Store.Reports
{
    public class GridPrintingClass
    {
        public string Heading1;
        public string Heading2;
        public string Heading3;
        public bool useHeading3;
        public string Footer1;
        public string Footer2;
        public string Footer3;
        void CreateMarginalDetailHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick = e.Graph.DrawString(Heading1, Color.Black, new RectangleF(0, 30, e.Graph.ClientPageSize.Width, 20),
                                                 BorderSide.None);
            brick.Font = new Font("Tahoma", 12, FontStyle.Bold);

            brick.StringFormat = new BrickStringFormat(StringAlignment.Center);

            TextBrick brick1 = e.Graph.DrawString(Heading2, Color.Black, new RectangleF(0, 50, e.Graph.ClientPageSize.Width, 20),
                                                 BorderSide.None);
            brick1.Font = new Font("Tahoma", 10, FontStyle.Bold);
            brick1.StringFormat = new BrickStringFormat(StringAlignment.Center);
            if(useHeading3)
            {
            TextBrick brick2 = e.Graph.DrawString(Heading3, Color.Black, new RectangleF(60, 80, e.Graph.ClientPageSize.Width, 20),
                                                  BorderSide.None);
            brick2.Font = new Font("Tahoma", 10, FontStyle.Bold);
            brick2.StringFormat = new BrickStringFormat(StringAlignment.Center);
            }
        }
        void CreateMarginalFooterArea(object sender, CreateAreaEventArgs e)
       {
           TextBrick brick = e.Graph.DrawString(Footer1, Color.Black, new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20),
                                                  BorderSide.None);
           brick.Font = new Font("Tahoma", 12, FontStyle.Bold);

           brick.StringFormat = new BrickStringFormat(StringAlignment.Center);
           if (string.IsNullOrEmpty(Footer2))
           {
               TextBrick brick1 = e.Graph.DrawString(Footer2, Color.Black,
                                                     new RectangleF(0, 40, e.Graph.ClientPageSize.Width, 20),
                                                     BorderSide.None);
               brick1.Font = new Font("Tahoma", 10, FontStyle.Bold);
               brick1.StringFormat = new BrickStringFormat(StringAlignment.Center);
           }

           if (string.IsNullOrEmpty(Footer3))
           {
               TextBrick brick2 = e.Graph.DrawString(Heading3, Color.Black,
                                                     new RectangleF(50, 80, e.Graph.ClientPageSize.Width, 20),
                                                     BorderSide.None);
               brick2.Font = new Font("Tahoma", 10, FontStyle.Bold);
               brick2.StringFormat = new BrickStringFormat(StringAlignment.Center);
           }
       }

        public void DoPivoitPrint(PivotGridControl pivotGridControl, bool landscape = true)
        {
            var link = new PrintableComponentLink(new PrintingSystem())
            {
                Margins = { Left = 10, Right = 10, Top = 110, Bottom = 90 },
                Landscape = landscape,
                PaperKind = PaperKind.A4,
                Component = pivotGridControl
            };

            var footer = new PageFooterArea();
            footer.Content.Add("Printed on " + "[Date Printed]" + " by " + Utils.Username);
            footer.Content.Add("Page " + "[Page #]");
            footer.LineAlignment = BrickAlignment.Near;
            var header = new PageHeaderArea();

            link.CreateMarginalHeaderArea += CreateMarginalDetailHeaderArea;
            link.CreateMarginalFooterArea += CreateMarginalFooterArea;

            link.PageHeaderFooter = new PageHeaderFooter(header, footer);

            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Open, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Customize, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Scale, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Parameters, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SubmitParameters, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.None, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.DocumentMap, CommandVisibility.None);
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Document"].Visible =
                false;
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Background"].Visible =
                false;
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Zoom"].Visible =
                false;


            link.CreateDocument();

            link.PrintingSystem.Document.AutoFitToPagesWidth = 1;

            link.ShowRibbonPreview(UserLookAndFeel.Default);
        }
        
        public void DoPrint(GridControl gridControl1,bool landscape=false)
        {
            var link = new PrintableComponentLink(new PrintingSystem())
            {
                Margins = { Left = 10, Right = 10, Top = 110, Bottom = 90 },
                Landscape = landscape,
                PaperKind = PaperKind.A4,
                Component = gridControl1
            };

            var footer = new PageFooterArea();
            footer.Content.Add("Printed on " + "[Date Printed]" + " by " + Utils.Username);
            footer.Content.Add("Page " + "[Page #]");
            footer.LineAlignment = BrickAlignment.Near;
            var header = new PageHeaderArea();

            link.CreateMarginalHeaderArea += CreateMarginalDetailHeaderArea;
            link.CreateMarginalFooterArea+= CreateMarginalFooterArea;

            link.PageHeaderFooter = new PageHeaderFooter(header, footer);

            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Open, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Customize, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Scale, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Parameters, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SubmitParameters, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.None, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.DocumentMap, CommandVisibility.None);
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Document"].Visible =
                false;
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Background"].Visible =
                false;
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Zoom"].Visible =
                false;


            link.CreateDocument();

            link.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            
            link.ShowRibbonPreview(UserLookAndFeel.Default);
        }
        
    }
}
