using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Store.COMMON;
using VIRETAILDAL.LedgersTableAdapters;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;

//using System.Data.DataTableExtensions;


namespace Store
{
    public partial class TxtFileRead : XtraForm
    {
        public TxtFileRead()
        {
            InitializeComponent();
        }

        public string Fname { get; set; }
        public string Machineno { get; set; }
        public string Inventoryby { get; set; }
        public int Closingperiod { get; set; }
        public bool iSvalid { get; set; }
        private DsMaster.ITEMMASTDataTable dtIems = new DsMaster.ITEMMASTDataTable();
        private DataTable dsStkItems ;
        public DataTable _dtphy;


        private void simpleButton1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            txtfile.EditValue = openFileDialog1.FileName;
            txtmachineno.EditValue = openFileDialog1.SafeFileName;
        ////    if (txtmachineno.EditValue == null) return;
        ////    // ProcessReadFile();
        ////     if (!validateFileReading())
        ////         ProcessReadFile();
        }
        private void ReadEachLine(string line, int j)
         {
            var split = line.Split(',');
            var t = (Ledgers.PHYINVDATARow) ledgers1.PHYINVDATA.NewRow();
            bool qty = false;
            t.FILENO = txtmachineno.EditValue.ToString();
            var d = from p in dtIems where p.ITEMNO == split[0] || p.BARCODE == split[0] select p;
            if (!d.Any())
            {
                t.ErrorMsg = "Error Item not found";
                t.HasError = true;
                t.ITEMNO = split[0];
            }
            else
            {
                var dts = DataTableExtensions.CopyToDataTable(d);
                foreach (DataRow dataRow in dts.Rows)
                {
                    t.ITEMNO = split[0];
                    if (dataRow["ITEMNO"].ToString() != dataRow["BARCODE"].ToString() &&
                        dataRow["ITEMNO"].ToString() != split[0])
                    {
                        t.ITEMNO = dataRow["ITEMNO"].ToString();
                        t.ErrorMsg = "Item No change --" + split[0];
                    }
                }
                var cps = from p in dsStkItems.AsEnumerable() where p.Field<string>("ITEMNO") == t.ITEMNO select p;

                foreach (DataRow dsk in cps)
                {
                    t.CPRICE = decimal.Parse(dsk[1].ToString());
                    t.SPRICE = decimal.Parse(dsk[2].ToString());
                    if (string.IsNullOrEmpty(dsk[3].ToString()))
                      t.EXPDATE = DateTime.Parse(dsk[3].ToString());
                }


                /*  var query = from p in dsStkItems.AsEnumerable()
                            where p.Field<string>("ITEMNO") == t.ITEMNO
                            select new
                            {
                                name = p.Field<string>("CPRICE"),
                                age = p.Field<int>("SPRICE")
                            };
               * */

            }
            if (string.IsNullOrEmpty(split[1].Trim()))
            {
                t.ErrorMsg = "Error in Qty" + "- Qty - " + split[1];
                t.HasError = true;
                qty = true;
            }
            if (!Functions.IsNumeric(split[1]))
            {
                t.ErrorMsg = "Error in Qty" + " - " + split[1];
                t.HasError = true;
                qty = true;
            }
            if (split[1].Length > 4)
            {
                t.ErrorMsg = "Error in Qty" + " - " + split[1];
                t.HasError = true;
                qty = true;
            }
            if (!qty)
                t.QTY = int.Parse(split[1].ToString());
            t.SNO = (short) ++j;
            ledgers1.PHYINVDATA.Rows.Add(t);
  

        }
        void ReadingTextFileByParallelMethod(string filename)
        {
            try
            {
                var sw = Stopwatch.StartNew();
                var AllLines = new string[1000000];    //only allocate memory here
                AllLines = File.ReadAllLines(filename);
                repositoryItemProgressBar1.Maximum = AllLines.Length;
                Parallel.For(0, AllLines.Length, x =>
                {
                    ReadEachLine(AllLines[x],x); //to simulate work
                    barEditItem1.EditValue = x;
                });
                long hundredths = (sw.ElapsedMilliseconds + 5)/10;
                long seconds = hundredths/100;
                long minutes = seconds/60;
                txttime.Caption = minutes + ":" + seconds % 60 + ":" + hundredths % 100;;
                sw.Stop();
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Not enough memory. Couldn't perform this test.");
            }
              GC.Collect();
        }
        bool ReadInGrid(string txtmachineno)
        { 
            var dr = from p in ledgers1.PHYINVDATA where p.FILENO == txtmachineno select p;
            return (dr.Any());
        }
        private void ReadFileLines(string fname)
        {
            var textline = "";
            var j = 0;
            var fReader = new StreamReader(fname);
            var allLines = File.ReadAllLines(fname);
            repositoryItemProgressBar1.Maximum = allLines.Length;
            if (allLines.Length == 0)
            {
                XtraMessageBox.Show("Nothing to read the file", "File Read", MessageBoxButtons.OK);
                return;
            }
            Application.DoEvents(); // var cls = new DataInTextFile();
            bool qty = false;
            int i = 0;
            var sw = Stopwatch.StartNew();
            do
            {
                barEditItem1.EditValue = j;
                Application.DoEvents();
                textline = fReader.ReadLine(); //string[] items = allLines[i].Split(new char[] { ' ' });
                var split = textline.Split(',');
                var t = (Ledgers.PHYINVDATARow) ledgers1.PHYINVDATA.NewRow();
                //  var t = (DsInventory.YearEndInventoryRow) 
                t.FILENO = txtmachineno.EditValue.ToString();
                t.SNO = ++i;
                var d = from p in dtIems where p.ITEMNO == split[0] || p.BARCODE == split[0] select p;
                if (!d.Any())
                {
                    t.ErrorMsg = "Error Item not found";
                    t.HasError = true;
                    t.ITEMNO = split[0];
                }
                else
                {
                    var dts = DataTableExtensions.CopyToDataTable(d);
                    foreach (DataRow dataRow in dts.Rows)
                    {
                        t.ITEMNO = split[0];
                        if (dataRow["ITEMNO"].ToString() != dataRow["BARCODE"].ToString() &&
                            dataRow["ITEMNO"].ToString() != split[0])
                        {
                            t.ITEMNO = dataRow["ITEMNO"].ToString();
                            t.ErrorMsg = "Item No change --" + split[0];
                        }
                    }

                    //var cps = from p in dsStkItems.AsEnumerable() where p.Field<string>("ITEMNO") == t.ITEMNO select p;
                    //if (cps.Any())
                    //{
                    //    foreach (DataRow dsk in cps)
                    //    {
                    //        t.INSTOCK = int.Parse(dsk[0].ToString());
                    //        t.SPRICE = decimal.Parse(dsk[1].ToString());
                    //        t.CPRICE = decimal.Parse(dsk[2].ToString());
                    //        if (!string.IsNullOrEmpty(dsk[3].ToString()))
                    //            t.EXPDATE = DateTime.Parse(dsk[3].ToString());
                    //    }
                    //}
                    //else
                    //{
                    //    decimal cprice = 0;
                    //    decimal sprice = 0;
                    //    t.INSTOCK = 0;
                    //    t.SPRICE = new ItemMaster().GetItemSalesPrice(t.ITEMNO);
                    //    t.CPRICE = new ItemMaster().GetItemCostPrice(t.ITEMNO);
                    //    if (sprice > 0 && cprice == 0)
                    //    {
                    //        var disc = new ItemMaster().GetPurchaseDist(t.ITEMNO);
                    //        cprice = sprice - ((sprice * disc) / 100);
                    //    }
                    //    t.CPRICE = cprice;
                    //}
                    if (string.IsNullOrEmpty(split[1].Trim()))
                    {
                        t.ErrorMsg = "Error in Qty" + "- Qty - " + split[1];
                        t.HasError = true;
                        qty = true;
                    }
                    if (!Functions.IsNumeric(split[1]))
                    {
                        t.ErrorMsg = "Error in Qty" + " - " + split[1];
                        t.HasError = true;
                        qty = true;
                    }
                    if (split[1].Length > 4)
                    {
                        t.ErrorMsg = "Error in Qty" + " - " + split[1];
                        t.HasError = true;
                        qty = true;
                    }
                    if (!qty)
                        t.QTY = int.Parse(split[1].ToString());
                  
                    ledgers1.PHYINVDATA.Rows.Add(t);
                }
            } 
            while (fReader.Peek() != -1);
            long hundredths = (sw.ElapsedMilliseconds + 5)/10;
                long seconds = hundredths/100;
                long minutes = seconds/60;
                txttime.Caption = minutes + ":" + seconds%60 + ":" + hundredths%100;
                sw.Stop();
                fReader.Close();
            }
        private void TxtFileRead_Load(object sender, EventArgs e)   
         {
           // txtclosingperiod.EditValue = cyear;
            dtIems = new  ItemMaster().GetItemMastList();
            iTEMMASTBindingSource.DataSource = dtIems;
            dsStkItems = new StockMaster().GetAvgMaxQtySpCpExpDtFromStockNew(int.Parse(txtclosingperiod.EditValue.ToString()));
         }
        public void ValidateYearEnd(int cyear)
        {
            txtclosingperiod.EditValue = cyear;
            //var b = new VIRETAILDAL.Masters.YearEndClass();
            //var ds = b.GetClosingYear();
            //if (ds.Rows.Count == 0)
            //{
            //    var f1 = new YearCloseProcess();
            //    f1.ShowDialog();
            //    txtclosingperiod.EditValue = f1._ClosingYear;
            //}
            //else
            //{
            //    txtclosingperiod.EditValue = ds.Rows[0]["CYEAR"];
            //}
        }
        private void txtfile_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClickOK();
        }
        void ClickOK()
        {
            if (txtfile.EditValue == null)
            {
                XtraMessageBox.Show("Please select the file", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtinventory.EditValue == null)
            {
                XtraMessageBox.Show("Please enter machine no", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmachineno.EditValue == null)
            {
                XtraMessageBox.Show("Please enter inventory by", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtclosingperiod.EditValue == null)
            {
                XtraMessageBox.Show("Please enter inventory period", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            decimal m;
            var d = decimal.TryParse(txtclosingperiod.EditValue.ToString(), out m);
            if (!d)
            {
                XtraMessageBox.Show("Please enter inventory period", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Fname = txtfile.EditValue.ToString();
            Machineno = txtmachineno.EditValue.ToString();
            Inventoryby = txtinventory.EditValue.ToString();
            Closingperiod = int.Parse(txtclosingperiod.EditValue.ToString());
            _dtphy = ledgers1.PHYINVDATA;
            iSvalid = true;
            Close();
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
        private void gridView2_CellValueChanged(object sender,CellValueChangedEventArgs e)
        {
            gridView2.UpdateCurrentRow();
            var dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (e.Column.FieldName == "ITEMNO")
            {
               // Parallel.For(<DataRow>)

                var d = from p in dtIems.AsParallel() where p.ITEMNO == dr["ITEMNO"].ToString() || p.BARCODE == dr["ITEMNO"].ToString() select p;
                if (d.Any())
                {
                    var dts = DataTableExtensions.CopyToDataTable(d);
                    foreach (DataRow dataRow in dts.Rows)
                    {
                        dr["ITEMNO"] = dataRow["ITEMNO"].ToString();
                        if (dataRow["ITEMNO"].ToString() != dataRow["BARCODE"].ToString() &&
                            dataRow["ITEMNO"].ToString() != dr["ITEMNO"].ToString())
                        {
                            dr["ITEMNO"] = dataRow["ITEMNO"].ToString();
                            dr["HasError"] = false;
                        }
                    }

                     // var prc = from t in DataTableExtensions.AsEnumerable(dsStkItems).AsParallel() where "ITEMNO" == dr["ITEMNO"].ToString() || t.BARCODE == dr["ITEMNO"].ToString() select p;
                }
                else
                {
                    dr["ErrorMsg"] = "Error Item not found";
                    dr["HasError"] = true;
                }
            }
        }
        bool validateFileReading()
        {
            int cnt = 0;
            bool retval = false;
            var ta = new PHYINVDATATableAdapter();
            var cn1 = ta.GetCountByFileNoByRead(txtmachineno.EditValue.ToString(), int.Parse(txtclosingperiod.EditValue.ToString())) ?? 0;
            var cn2 = ta.GetCountByFileNo(txtmachineno.EditValue.ToString(), int.Parse(txtclosingperiod.EditValue.ToString())) ?? 0;

            if (int.Parse(cn1.ToString()) > 0)
            {
                XtraMessageBox.Show("This File already read and pushed for update", "File Reading", MessageBoxButtons.OK);
                retval = true;
            }
            if (int.Parse(cn2.ToString()) > 0 || ReadInGrid(txtmachineno.EditValue.ToString()))
            {
                if (XtraMessageBox.Show("This File already read do you want to read again", "File Reading", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ta.DeleteByFileNo(txtmachineno.EditValue.ToString(), int.Parse(txtclosingperiod.EditValue.ToString()));
                    ledgers1.PHYINVDATA.Rows.Cast<DataRow>().Where(r => r.ItemArray[3] == txtmachineno.EditValue.ToString()).ToList().ForEach(r => r.Delete());
                }
                else
                {
                    retval = true;
                }
            }
            return retval;
        }
        private void ProcessReadFile()
        {

            if (txtmachineno.EditValue != null)
            {
                ReadFileLines(txtfile.EditValue.ToString());
                MergeDuplicate();
                bool t = true;
                var cnt1 = from rows in ledgers1.PHYINVDATA where rows.HasError == t select rows;
                if (cnt1.Any())
                {
                    gridControl2.DataSource = pHYINVDATABindingSource;
                    gridView2.ActiveFilterString = "[HasError] = true ";
                }
            } 
        }
        void MergeDuplicate()
        {
            List<Duplicateitems> cnt = (from c in ledgers1.PHYINVDATA
                                 group c by new { c.ITEMNO, c.QTY } into g
                                  where g.Count() > 1
                                select new Duplicateitems()
                                            {
                                                itemno = g.First().ITEMNO,
                                                qty = g.Sum(x => x.QTY)
                                            }).ToList();
            if (cnt.Any())
            {
                foreach (var c in cnt)
                {
                    var rows = ledgers1.PHYINVDATA.Select("ITEMNO='" + c.itemno +"' and HasError = 0");
                    foreach (var row in rows)
                        row.Delete();
                }
            }
            foreach (var c in cnt)
            {
              var nr =   ledgers1.PHYINVDATA.NewRow();
                nr["ITEMNO"] = c.itemno;
                nr["QTY"] = c.qty;
                ledgers1.PHYINVDATA.Rows.Add(nr);
            }   
           }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            var cl = new CsvBulkCopyDataIntoSqlServer();
            //foreach (var files in openFileDialog1.SafeFileNames)
            //{
            XtraMessageBox.Show(cl.ReadCsvFile(txtfile.Text, "TEXTFILES" + txtclosingperiod.Text, txtmachineno.Text), "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);  
           // }
        }
   }

    public class Duplicateitems
    {
        public string itemno { get; set; }
        public int qty { get; set; }
    }

   }

    

