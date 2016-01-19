using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using Store.COMMON;
using Store.Reports;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptDailySalesReport : XtraForm
    {
        public bool _usemultistore = false;
        string[] connew = Utils.Connectionstring.Split(';');
        public RptDailySalesReport()
        {
            InitializeComponent();
        }
        private void DailySalesReport_Load(object sender, EventArgs e)
        {
            try
            {

                if (!_usemultistore)
                {
                    var bl = new VIRETAILDAL.Masters.DailyClosing();
                    LoadDailyReport();
                    gridControl3.DataSource = bl.GetDailyClosingDates();
                }
                barEditItem1.EditValue =    DateTime.Now;
                barEditItem2.EditValue = DateTime.Now;
                if (_usemultistore)
                {
                    barstorecaption.Visibility = BarItemVisibility.Always;
                    barEditItem4.Visibility = BarItemVisibility.Always;
                   // var dt = COMMON.ClsGetData.GetStoresDataBases();
                    sTOREMASTDBBindingSource.DataSource = ClsGetData.GetAllStoresDbnames(true);

                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    repositoryItemComboBox1.Items.Add(dr[0]);
                    //}
                    //if (dt.Rows.Count > 0)
                    //{
                    //    barEditItem3.EditValue = dt.Rows[0][0];
                    //}
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void  LoadDailyReport()
        {
            var bl = new BLReports();
            var ds = bl.GetDailySales(ClosingDifference, DateTime.Now, DateTime.Now, false);
            dailySalesBindingSource.DataSource = ds;
            var dscredit = bl.GetCreditDetails(DateTime.Now, DateTime.Now, false);
            gridControl2.DataSource = dscredit;
        }
        public decimal ClosingDifference { get; set; }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateReport();
        }
        public string watermark { get; set; }
        public string aMonth
        {
            set { 
                   barEditItem1.EditValue = value; 
                }
        }
        void CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick;
            var dt = DateTime.Parse(barEditItem1.EditValue.ToString());
            string phead = "Daily Sales report " + dt.ToString("dd-MM-yyyy hh:mm:ss tt") + "                " + watermark;
            brick = e.Graph.DrawString(Utils.Companyname, Color.Black, new RectangleF(0, 20, e.Graph.ClientPageSize.Width, 100),
                                        BorderSide.None);
            brick.Font = new Font("Tahoma", 12, FontStyle.Bold);
            brick.StringFormat = new BrickStringFormat(StringAlignment.Center);

            TextBrick brick1;
            brick1 = e.Graph.DrawString(phead, Color.Black, new RectangleF(0, 40, e.Graph.ClientPageSize.Width, 100),
                                      BorderSide.None);
            brick1.Font = new Font("Tahoma", 10, FontStyle.Regular);
            brick1.StringFormat = new BrickStringFormat(StringAlignment.Center);

            //TextBrick brick2;
            //brick1 = e.Graph.DrawString(watermark, Color.Black, new RectangleF(0, 30, e.Graph.ClientPageSize.Width, 100),
            //                          BorderSide.None);
            //brick1.Font = new Font("Tahoma", 12, FontStyle.Bold);
            //brick1.StringFormat = new BrickStringFormat(StringAlignment.Far);

        }
        public void CreateReport()
        {
            var link = new CompositeLink(new PrintingSystem());

            var link1 = new PrintableComponentLink();
            var pcLink1 = new PrintableComponentLink();
            var footer = new PageFooterArea();
            footer.Content.Add("Printed on " + "[Date Printed]" + " by " + Utils.Username);
            footer.LineAlignment = BrickAlignment.Near;
            var header = new PageHeaderArea();
            link.CreateMarginalHeaderArea += CreateMarginalHeaderArea;
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
  


            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Document"].Visible = false;
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Background"].Visible =false;
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Zoom"].Visible =false;


            link.Margins.Left = 100;
            link.Margins.Right = 100;
            link.Margins.Top = 100;
            link.Margins.Bottom = 90;
            link.PaperKind = PaperKind.A4;

            var linkGrid1Report = new Link();
            linkGrid1Report.CreateDetailArea += linkGrid1Report_CreateDetailArea;


            var linkGrid2Report = new Link();

           // link.PrintingSystem.Document.AutoFitToPagesWidth = 1;

            link1.Component = gridControl1;
            

             
            link.Links.Add(link1);

            link.Links.Add(linkGrid1Report);
            pcLink1.Component = gridControl2;
            link.Links.Add(pcLink1);
            

            link.CreateDocument();

            //if (string.IsNullOrEmpty(watermark))
            //    link.PrintingSystemBase.Watermark.Text = "Draft";
            //else
            //{
            //    link.PrintingSystemBase.Watermark.Text = "watermark";
            //}
            link.ShowRibbonPreview(UserLookAndFeel.Default);


        }
        void linkGrid1Report_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            var tb = new TextBrick();
            tb.Text = "Credit sales";
            tb.Font = new Font("Tahoma", 12);
            tb.Rect = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            tb.HorzAlignment = HorzAlignment.Center;
            e.Graph.DrawBrick(tb);
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(barEditItem1.EditValue != null)
            {
                DateTime d1 = Convert.ToDateTime(barEditItem1.EditValue.ToString());
                DateTime d2 = Convert.ToDateTime(barEditItem2.EditValue.ToString());
                if(barEditItem4.EditValue==null )
                        LoadDailyReport(d1, d2);
                else
                {
                    var strcn = connew[0] + ";" + "Initial Catalog =" + barEditItem4.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                    LoadDailyReport(d1, d2, true, true, strcn);
                }
            }
        }
        private void gridView1_CalcRowHeight(object sender, RowHeightEventArgs e)
        {
            var dr = gridView1.GetDataRow(e.RowHandle);
            if(dr[0].ToString()=="1")
            {
               e.RowHeight = 10;
            }
        }
        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {
            var dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if(dr==null)
                return;
            DateTime d1 = Convert.ToDateTime(dr[0].ToString());
            barEditItem1.EditValue = d1;
            barEditItem2.EditValue = d1;
            if (_usemultistore)
            {
                   // var strcn = connew[0] + ";" + "Initial Catalog =" + barEditItem3.EditValue.ToString() + ";" + connew[2] + ";" ;
                var strcn = connew[0] + ";" + "Initial Catalog =" + barEditItem4.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                LoadDailyReport(d1, d1,true, true, strcn);
            }
            else
            LoadDailyReport(d1, d1);
            watermark = "Closed";
        }
        private void gridControl3_Click(object sender, EventArgs e)
        {}
        public void LoadDailyReport(DateTime d1,DateTime d2,bool t=true,bool useconstr=false,string newconstr="p")
        {
            var bl = new BLReports();
            var ds = bl.GetDailySales(ClosingDifference, d1.Date, d2.Date, t,useconstr,newconstr);
            dailySalesBindingSource.DataSource = ds;
            var dscredit = bl.GetCreditDetails(d1.Date, d2.Date, t, useconstr, newconstr);
            gridControl2.DataSource = dscredit;
        }
        private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            // LoadDates();
        }
        void LoadDates()
        {
            progressPanel1.Visible = true;
            var bl = new VIRETAILDAL.Masters.DailyClosing();
            // var str = connew[0] + ";" + "Initial Catalog =" + barEditItem3.EditValue + ";" + connew[2] + ";";
            var str = connew[0] + ";" + "Initial Catalog =" + barEditItem4.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
            gridControl3.DataSource = bl.GetDailyClosingDates(true, str);
            progressPanel1.Visible = false;
        }
        private void barstorecaption_ItemClick(object sender, ItemClickEventArgs e)
        {}
        private void barEditItem3_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void barEditItem4_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDates();
                var dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                if (dr != null)
                {
                    var strcn = connew[0] + ";" + "Initial Catalog =" + barEditItem4.EditValue + ";" + connew[2] + ";" + connew[3] + ";" + connew[4] + ";";
                    LoadDailyReport(DateTime.Parse(dr[0].ToString()), DateTime.Parse(dr[0].ToString()), true, true,strcn);
                }
                else
                {
                    dailySalesBindingSource.DataSource = null;
                    gridControl2.ResetBindings();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
           // LoadDailyReport(d1, d1, true, true, strcn);
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}