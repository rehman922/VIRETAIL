using System;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
     
    public partial class PurList : XtraForm
    {
        public PurList()
        {
            InitializeComponent();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var p = new NewPurInv();
            p.ShowHoldList = false;
            p.ShowDialog();
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(gridView1.FocusedRowHandle >= 0)
            {
                var f = new SupInvChange();
                f._purinv = gridView1.GetFocusedRowCellValue("PURINVID").ToString();
                f.LoadDetails();
                f.ShowDialog();
                LoadGrid();
            }
        }
        private void PurList_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = true;
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            PrintInvList();
        }
        void CreateMarginalDetailHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string phead = "Purchase Invoice List";  
            TextBrick brick1;
            brick1 = e.Graph.DrawString(phead, Color.Black, new RectangleF(0, 20, e.Graph.ClientPageSize.Width, 20),BorderSide.None);
            brick1.Font = new Font("Tahoma", 10, FontStyle.Bold);
            brick1.StringFormat = new BrickStringFormat(StringAlignment.Center);
        }
        private void PrintInvList()
        {
            var cl = new GridPrintingClass();
            cl.Heading1 = Utils.Companyname;
            cl.Heading2 = "Purchase Invoice List";
            cl.DoPrint(gridControl1);
            //var link = new PrintableComponentLink(new PrintingSystem())
            //               {
            //                   Margins = {Left = 10, Right = 10, Top = 100, Bottom = 90},
            //                   Landscape = false,
            //                   PaperKind = PaperKind.A4,
            //                   Component = gridControl1
            //               };

            //var footer = new PageFooterArea();
            //footer.Content.Add("Printed on " + "[Date Printed]" + " by " + VIRETAILDAL.COMMON.Utils.Username);
            //footer.Content.Add("Page " + "[Page #]");
            //footer.LineAlignment = BrickAlignment.Near;
            //var header = new PageHeaderArea();
            //link.CreateMarginalHeaderArea += CreateMarginalDetailHeaderArea;
            //link.PageHeaderFooter = new PageHeaderFooter(header, footer);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Open, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Customize, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Scale, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Parameters, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SubmitParameters, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.None, CommandVisibility.None);
            //link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.DocumentMap, CommandVisibility.None);
            //link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Document"].Visible =false;
            //link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Background"].Visible =false;
            //link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Zoom"].Visible =false;
            //link.CreateDocument();
            //link.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //link.ShowRibbonPreview(UserLookAndFeel.Default);
        }
        void LoadGrid()
        {
            var ds = ClsGetData.GetPurinvMast();
            pURINVMAINBindingSource.DataSource = ds;
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var f = new NewPurInv();
                f.ShowHoldList = false;
                f.Purid = gridView1.GetFocusedRowCellValue("PURINVID").ToString();
                f.DoView();
                f.ShowDialog();
              //  f.Parent = this.Parent;
                LoadGrid();
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "gridColumn1" && e.IsGetData) e.Value =
              getTotalValue(view, e.ListSourceRowIndex);
        }
        decimal getTotalValue(GridView view, int listSourceRowIndex)
        {
            {
                string purno = view.GetListSourceRowCellValue(listSourceRowIndex, "PURINVID").ToString();
                return new Blpurinv().PurchaseSaleValue(purno);
            }
        }
    }
}