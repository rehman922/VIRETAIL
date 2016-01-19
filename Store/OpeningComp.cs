using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Masters;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class OpeningComp : XtraForm
    {
        public OpeningComp()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            marqueeProgressBarControl1.Visible = true;
            Application.DoEvents();
            var year = int.Parse(textBox1.Text);
            new YearEndClass().UpdateOpeningForManuallyAdded(year);
            LoadStock();
            LoadNotFound();
            marqueeProgressBarControl1.Visible = false;
        }
        void LoadStock()
        {
            yearEndInventory1BindingSource.DataSource = new YearEndClass().GetOpeningDataTable(int.Parse(textBox1.Text));
            yearEndInventory1BindingSource.Filter = "StkDiff <> 0";
        }
        void LoadNotFound()
        {
            var year = int.Parse(textBox1.Text);
            openingvariationBindingSource1.DataSource= new YearEndClass().GetOpeningvariationDataTable(year);
           // openingvariationBindingSource1.Filter = "Qty <> 0";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var pr = new GridPrintingClass
            {
                Footer2 = DateTime.Now.ToString(),
                Heading1 = Utils.Companyname,
                Heading2 = "STOCK DIFFRENCE REPORT"
            };

            pr.DoPrint(gridControl1);
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var pr = new GridPrintingClass  
            {
                Footer2 = DateTime.Now.ToString(),
                Heading1 = Utils.Companyname,
                Heading2 = "ITEMS NOT SCANNED"
            };
            pr.DoPrint(gridControl2);
        }
        private void OpeningComp_Load(object sender, EventArgs e)
        {
            textBox1.Text = (DateTime.Now.Year-1).ToString();
            iTEMGROUPBindingSource1.DataSource = ClsGetData.GetItemGroup();
        }
    }
}
