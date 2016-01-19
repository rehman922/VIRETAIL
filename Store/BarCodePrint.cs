using System;
using System.Data;
using System.Drawing.Printing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.Properties;
using VIRETAILENTITIES;

namespace Store
{
    public partial class BarCodePrint : XtraForm
    {
        private bool NotPaused = true;
        private bool IsItemmast;
        private string _defaulPrinter;
        private DsMaster.TEMPBCODEPRINTDataTable dsTemp = new DsMaster().TEMPBCODEPRINT;

        public BarCodePrint()
        {
            InitializeComponent();
        }

        private PrintDocument PDoc = new PrintDocument();

        private void BarCodePrint_Load(object sender, EventArgs e)
        {
            //PDoc.PrinterSettings.PrinterName = "ZDesigner LP 2844";
            //PDoc.OriginAtMargins = true;
            //PDoc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            //PDoc.PrintPage += PDoc_PrintPage;
            LoadBarCodePrinters();

        }

        private void LoadBarCodePrinters()
        {
            string defp = null;
            var settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (printer.IndexOf("SATO", StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    if (settings.IsDefaultPrinter)
                    {
                        defp = printer;
                    }
                    repositoryItemComboBox1.Items.Add(printer);
                }
                if (printer.IndexOf("ZDesigner", StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    repositoryItemComboBox1.Items.Add(printer);
                }
                if (defp != null)
                    barEditItem4.EditValue = defp;
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            StringBuilder sb;
            sb = new StringBuilder();
            //sb.AppendLine();
            //sb.AppendLine("N");
            //sb.AppendLine("q230");
            //sb.AppendLine("Q150");
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A26,10,0,1,1,1,N,\"{0}\"", itemname));
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B26,25,0,1,2,2,38,N,\"{0}\"", itemcode));
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A35,70,0,3,1,1,N,\"{0}\"", itemcode));
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A1,90,0,3,1,1,N,\"{0}\"", price));
            //sb.AppendLine("P1,1");
            //RawPrinterHelper.SendStringToPrinter("ZDesigner TLP 2844", sb.ToString());
            //sb.AppendLine("<A>");
            //sb.AppendLine("<V>100<H>50<L>0404<XB>1SATO");
            //sb.AppendLine("<V>350<H>100<B>104250*12345* ");
            //sb.AppendLine("<V>600<H>150<L>0101<XB> 1*12345*");
            //sb.AppendLine("<Q>1");
            //sb.AppendLine("<Z>");
            //RawPrinterHelper.SendStringToPrinter("ZDesigner TLP 2844", sb.ToString());
            //string   PrintCommand = "<STX><ESC>A<ESC>IG1<ESC>Z<ETX><STX><ESC>A<ESC>#E3<ESC>Z<ETX><STX><ESC>A<ESC>CS5<ESC>Z<ETX><STX><ESC>A<ESC>EX0<ESC>Z<ETX><STX><ESC>A<ESC>*&<ESC>Z<ETX><STX><ESC>A<ESC>A3H0001V0001<ESC>Z<ETX><STX><ESC>A<ESC>V0000<ESC>H0259<ESC>F001+002<ESC>D202099" + EmployeeNo + YearNumber + FirstTraceCode + "<ESC>L0203<ESC>H0247<ESC>V0114<ESC>F001+002<ESC>U" + EmployeeNo.Substring(0, 2) + "-" + EmployeeNo.Substring(2, 4) + "-" + YearNumber + "-" + FirstTraceCode + "<ESC>V0000<ESC>H0589<ESC>F001+002<ESC>D202099" + EmployeeNo + YearNumber + SecondTraceCode + "<ESC>L0203<ESC>H0577<ESC>V0114<ESC>F001+002<ESC>U" + EmployeeNo.Substring(0, 2) + "-" + EmployeeNo.Substring(2, 4) + "-" + YearNumber + "-" + SecondTraceCode + "<ESC>Q" + LabelQuantity + "<ESC>00<ESC>Z<ETX>";
            //PrintCommand = PrintCommand.Replace("<STX>", ((char)02).ToString());
            //PrintCommand = PrintCommand.Replace("<ETX>", ((char)03).ToString());
            //PrintCommand = PrintCommand.Replace("<ESC>", ((char)27).ToString());

        }

        public string itemname { get; set; }
        public int itemcode { get; set; }
        public string price { get; set; }

        public void PDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Rectangle R = new Rectangle(1, 1, 150, 55);
            //e.Graphics.DrawRectangle(Pens.Black, R);
            //StringFormat SF = StringFormat.GenericTypographic;
            //SF.Alignment = StringAlignment.Center;
            //SF.LineAlignment = StringAlignment.Center;

            //e.Graphics.DrawString("123345", new Font("Verdana", 10), Brushes.Black, R, SF);
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            if (barEditItem1.EditValue != null)
                LoadItemsFromPurchaseInvoice(barEditItem1.EditValue.ToString());
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            tEMPBCODEPRINTBindingSource.DataSource = dsTemp;
            var frm = new StockList(null, String.Empty, String.Empty, true);
            frm.EventSelectedItem += AdditemsToList;
            frm.ShowDialog();
            if (ActiveControl.Name != "gridControl1")
                gridControl1.Focus();
        }

        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            try
            {
                DataRow adr = e.SelectedRow;
                var dr = dsTemp.NewRow();
                dr["ITEMCODE"] = adr["itemno"];
                dr["ITEMNAME"] = adr["ITEMNAME"];
                if (IsItemmast)
                    dr["QTY"] = 1;
                else
                {
                    dr["QTY"] = adr["QTY"];
                }
                dr["PRICE"] = adr["SPRICE"];
                dsTemp.Rows.Add(dr);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (
                XtraMessageBox.Show("Do you want to print the barcode labels", "POS",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                gridView1.UpdateCurrentRow();
                PreparePrinting();
            }
            //StringBuilder sb;
            //sb = new StringBuilder();
            //sb.AppendLine();
            //sb.AppendLine("N");
            //sb.AppendLine("q230");
            //sb.AppendLine("Q150");
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A26,10,0,1,1,1,N,\"{0}\"", itemname));
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B26,25,0,1,2,2,38,N,\"{0}\"", itemcode));
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A35,70,0,3,1,1,N,\"{0}\"", itemcode));
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A1,90,0,3,1,1,N,\"{0}\"", price));
            //sb.AppendLine("P1,1");
            //RawPrinterHelper.SendStringToPrinter("ZDesigner TLP 2844", sb.ToString());
            //sb.AppendLine("<A>");

            //sb.AppendLine("<V>10<H>10<L>0101<XB>1SATO");
            //sb.AppendLine("<V>35<H>10<B>104250*12345* ");
            //sb.AppendLine("<V>60<H>10<L>0101<XB> 1*12345*");
            //sb.AppendLine("<Q>1");
            //sb.AppendLine("<Z>");

            //StringBuilder sb1 = new StringBuilder();
            //    sb.AppendLine();
            //    sb.AppendLine("<ESC>A");
            //    sb.AppendLine("H0050<ESC>V0100<ESC>L0303<ESC>XMSATO");
            //      String output = sb.ToString().Replace("<ESC>", "\x1B");
            //   string PrintCommand = "<ESC>AH0050<ESC>V0100<ESC>L0303<ESC>XMSATO";
            ////  string PrintCommand = "<STX><ESC>A<ESC>IG1<ESC>Z<ETX><STX><ESC>A<ESC>#E3<ESC>Z<ETX><STX><ESC>A<ESC>CS5<ESC>Z<ETX><STX><ESC>A<ESC>EX0<ESC>Z<ETX><STX><ESC>A<ESC>*&<ESC>Z<ETX><STX><ESC>A<ESC>A3H0001V0001<ESC>Z<ETX><STX><ESC>A<ESC>V0000<ESC>H0259<ESC>F001+002<ESC>D202099123455<ESC>L0203<ESC>H0247<ESC>V0114<ESC>F001+002<ESC>U33<ESC>V0000<ESC>H0589<ESC>F001+002<ESC>D202099 dd<ESC>L0203<ESC>H0577<ESC>V0114<ESC>F001+002<ESC>U333<ESC>Q33<ESC>00<ESC>Z<ETX>";
            //   PrintCommand = PrintCommand.Replace("<STX>", ((char)02).ToString());
            //   PrintCommand = PrintCommand.Replace("<ETX>", ((char)03).ToString());
            //   PrintCommand = PrintCommand.Replace("<ESC>", ((char)27).ToString());
            //  StringBuilder sb = new StringBuilder();
            //sb.AppendLine("<ESC>A");
            //sb.AppendLine("H0050<ESC>V0100<ESC>L0303<ESC>XMSATO");
            //  sb.AppendLine("<ESC>A<ESC>V10<ESC>H10<ESC>L0101<ESC>XB1SATO<ESC>V30<ESC>H30<ESC>B104250*12345*<ESC>V50<ESC>H50<ESC>L0101<ESC>XB 1*12345*<ESC>Q1<ESC>Z");
            //  sb.AppendLine("<ESC>A<ESC>V10<ESC>H20<ESC>P2<ESC>L0101<ESC>XMABCD<ESC>Q1<ESC>Z");
            //   PrintCommand = PrintCommand.Replace("<STX>", ((char)02).ToString());
            //   PrintCommand = PrintCommand.Replace("<ETX>", ((char)03).ToString());
            //   PrintCommand = PrintCommand.Replace("<ESC>", ((char)27).ToString());
            //    String output = sb.ToString().Replace("<ESC>", "\x1B");
            //  String output = sb.ToString().Replace("<ESC>", ((char) 27).ToString());
            //<ESC>A<ESC>V10<ESC>H250<ESC>XS  SATA120<ESC>V35<ESC>H150<ESC>B102060*12345678*<ESC>V100<ESC>H250<ESC>XS *12345*<ESC>Q1<ESC>Z

            //<ESC>A<ESC>V10<ESC>H250<ESC>XS  SATA120 <ESC>V35<ESC>H280<ESC>BG02050123456789<ESC>V100<ESC>H250<ESC>XS *123456789*<ESC>Q1<ESC>Z

            //  String output =textBox1.ToString().Replace("<ESC>", "\x1B");
            // RawPrinterHelper.SendStringToPrinter("SATO CT400", output);
        }

        private void PreparePrinting()
        {
            var settings = new PrinterSettings();

            if (barEditItem4.EditValue == null)
            {
                XtraMessageBox.Show("Printer not found", "POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                printDialog1.ShowDialog();
                settings.PrinterName = printDialog1.PrinterSettings.PrinterName;
            }
            else
            {
                settings.PrinterName = barEditItem4.EditValue.ToString();
            }
            if (!settings.IsDefaultPrinter)
            {
                _defaulPrinter = MyDefaultPrinters.GetDefaultPrinter();
                MyDefaultPrinters.SetDefaultPrinter(settings.PrinterName);
            }
            if (settings.IsValid)
            {
                //var pp = MyDefaultPrinters.GetPrinterProperties();
                StartPrinting(settings.PrinterName);
                barButtonItem2.Enabled = false;
                btnstopprinting.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Printer is not valid", "POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(_defaulPrinter))
            {
                MyDefaultPrinters.SetDefaultPrinter(_defaulPrinter);
            }
        }

        private void DoPrinting(string output, string pname)
        {
            RawPrinterHelper.SendStringToPrinter(pname, output);
        }

        private void StartPrinting(string pname)
        {
            Application.DoEvents();
            repositoryItemProgressBar1.Maximum = dsTemp.Rows.Count;
            int i = 0;
            foreach (DataRow dr in dsTemp.Rows)
            {
                barEditItem2.EditValue = i++;
                if (!string.IsNullOrEmpty(dr["QTY"].ToString()))
                {
                    for (int j = 0; j < int.Parse(dr["QTY"].ToString()); j++)
                    {
                        if (NotPaused)
                        {
                            string cp = dr["ITEMCODE"].ToString().Trim() + " SR" +
                                        Math.Round(decimal.Parse(dr["PRICE"].ToString()), 2);
                            CreateFormatedString(pname, dr["ITEMCODE"].ToString(), dr["ITEMNAME"].ToString(), cp,
                                Math.Round(decimal.Parse(dr["PRICE"].ToString()), 2).ToString());
                            dr["PQTY"] = j + 1;
                        }
                    }
                }
            }
        }

        private void CreateFormatedString(string printername, string itemcode, string itemname, string priceandcode,
            string price)
        {
            String output = String.Empty;
            var sb = new StringBuilder();
            if (printername.IndexOf("SATO", StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                var item = itemname.Length > 25 ? itemname.Substring(0, 22) : itemname;
                var sts = "<ESC>A<ESC>V12<ESC>H270<ESC>S" + item + "<ESC>V35<ESC>H280<ESC>BG02050" +
                          itemcode + "<ESC>V96<ESC>H256<ESC>M " + priceandcode + "<ESC>Q1<ESC>Z";
                //sb.AppendLine("<ESC>A<ESC>V10<ESC>H250<ESC>XS");
                //sb.AppendLine(itemname.Substring(0,10));
                //sb.AppendLine("<ESC>V35<ESC>H280<ESC>BG02050");
                //sb.AppendLine(itemcode);
                //sb.AppendLine("<ESC>V100<ESC>H250<ESC>XS ");
                //sb.AppendLine(price);
                //sb.AppendLine("<ESC>Q1<ESC>Z");
                output = sts.Replace("<ESC>", "\x1B");
                //<ESC>A<ESC>V10<ESC>H250<ESC>XS  SATA120 <ESC>V35<ESC>H280<ESC>BG02050123456789<ESC>V100<ESC>H250<ESC>XS *123456789*<ESC>Q1<ESC>Z 
            }
            else
            {
                var item = itemname.Length > 20 ? itemname.Substring(0, 20) : itemname;
                sb.AppendLine();
                sb.AppendLine("N");
                sb.AppendLine("q230");
                sb.AppendLine("Q150");
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A1,10,0,1,1,1,N,\"{0}\"", item));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B26,25,0,1,2,2,38,N,\"{0}\"", itemcode));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A1,70,0,2,1,1,N,\"{0}\"", priceandcode));
                //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A1,90,0,3,1,1,N,\"{0}\"", priceandcode));
                sb.AppendLine("P1,1");
                output = sb.ToString();
            }
            DoPrinting(output, printername);
        }

        private void LoadItemsFromPurchaseInvoice(string invoiceno)
        {
            dsTemp = new Blpurinv().CreateBarCodeTable(invoiceno);
            tEMPBCODEPRINTBindingSource.DataSource = dsTemp;
            if (dsTemp.Rows.Count == 0)
            {
                XtraMessageBox.Show("Document not found", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void LoadFromTransferInvoice(string docs)
        {
            dsTemp = new Blitemmove().CreateBarCode(docs);
            tEMPBCODEPRINTBindingSource.DataSource = dsTemp;
        }

        private void BarCodePrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyDefaultPrinters.SetDefaultPrinter(_defaulPrinter);
        }

        private void btnstopprinting_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (NotPaused)
            {
                NotPaused = false;
                btnstopprinting.LargeGlyph = Resources.printpause;
            }
            else
            {
                NotPaused = false;
                btnstopprinting.LargeGlyph = Resources.startprint;
            }
        }

        private void barEditItem3_EditValueChanged(object sender, EventArgs e)
        {
            if (barEditItem3.EditValue != null)
                LoadFromTransferInvoice(barEditItem3.EditValue.ToString());
            if (dsTemp.Rows.Count == 0)
            {
                XtraMessageBox.Show("Document not found", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            dsTemp.Clear();
            tEMPBCODEPRINTBindingSource.DataSource = dsTemp;
            barButtonItem2.Enabled = true;
            btnstopprinting.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            tEMPBCODEPRINTBindingSource.DataSource = dsTemp;

            {
                this.InvokeEx(x => AddItems());
            }

        }

        private void AddItems()
        {
            var frm = new FrmItemLookUp();
            frm.EventSelectedItem += AdditemsToList;
            IsItemmast = true;
            frm.closeonselect = true;
            frm.ShowDialog();
            IsItemmast = false;
        }
        

    }

}