using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class Drugdispatch : Form
    {
        private BindingSource Bsnav = new BindingSource();
        private readonly TextBox Tnav = new TextBox();
        private DsMaster dsMaster = new DsMaster();
        string _dosageno=string.Empty;
        bool IsNew = true;
        private string _defaulPrinter;
        private int _doctorid;
        public Drugdispatch()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            new InputLanguageHelper().LoadEnglishKeyboardLayout();
        }
        private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            new InputLanguageHelper().LoadArabicKeyboardLayout();
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new Dosages();
            f.ShowDialog();
            dsMaster1.Merge(new DrugDispatch().GetDosagesDataTable());


        }
        private void Drugdispatch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F10)
                KeyF10();
        }
        void KeyF10()
        {
            this.InvokeEx((lv => AddItems())); ;
        }
        private void AddItems()
        {

            var frm = new FrmItemLookUp();
            frm.EventSelectedItem += AdditemsToList;
            frm.closeonselect = false;
            if (txtbarcode.EditValue != null)
                frm.filtertext = txtbarcode.EditValue.ToString();
            frm.ShowDialog();
        }
        void AdditemsToList(object sender, GetDataRowEventArgs g)
        {
            var current = g.SelectedRow;
            txtbarcode.Text = current["ITEMNO"].ToString();
            txtbarcode.SendKey(new KeyEventArgs(Keys.Enter));
        }
        void AddLineItem()
        {
            DataRow current = null;
            if (txtbarcode.EditValue != null)
            {
                var blf = new BlItemMaster().FindItemByBarCode(txtbarcode.EditValue.ToString());
                if (blf.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Item master not found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbarcode.SelectAll();
                    return;
                }
                comboBoxEdit1.Properties.Items.Clear();
                foreach (DataRow dr in blf.Rows)
                {
                    if (int.Parse(dr["groupid"].ToString()) == 1)
                    {
                        FillDates(dr["ITEMNO"].ToString());
                        var drn = (DsMaster.DDDETAILSRow) dsMaster1.DDDETAILS.NewRow();
                        drn.ITEMNO = dr["ITEMNO"].ToString();
                        drn.ITEMNAME = dr["ITEMNAME"].ToString();

                        if(comboBoxEdit1.EditValue!=null)
                             drn.EXPDT =  comboBoxEdit1.EditValue.ToString();
                        dsMaster1.DDDETAILS.Rows.Add(drn);
                    }
                }
            }
            else
            {
                return;
            }
            txtbarcode.EditValue = string.Empty;
        }
        void FillDates(string itemno)
        {
            var drstock = new BLSales().GetStockItem(itemno, "S");
            var dt = new List<DateTime>();

            foreach (DsInventory.STOCKMASTERRow drstk in drstock.Rows)
            {
                if (!drstk.IsEXPDATENull())
                {
                    dt.Add(drstk.EXPDATE);
                }
            }

            var dis = dt.Distinct();

            var itemsCollection = comboBoxEdit1.Properties.Items;
            itemsCollection.BeginUpdate();
            try
            {
                foreach (DateTime item in dis)
                {
                    var ndt = item.Month + "-" + item.Year;
                    itemsCollection.Add(ndt);
                }
            }
            finally
            {
                itemsCollection.EndUpdate();
            }
            comboBoxEdit1.SelectedIndex = 0;
            //foreach (string s in dis)
            //{
            //    var sd = dis.ToString();
            //    comboBoxEdit1.Properties.Items.Add(sd);
            //}
        }
        private void txtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddLineItem();
            }
        }
        private void Drugdispatch_Load(object sender, EventArgs e)
        {
            dsMaster1.Merge(new DrugDispatch().GetDosagesDataTable());
            dsMaster1.Merge(new DrugDispatch().GetDdmastDataTable());
            dsMaster1.Merge(new VIRETAILDAL.Masters.UserInfo().GetUserInfo());
            repositoryItemLookUpEdit2.DataSource = dsMaster1.USERINFO;
            voudate.EditValue = DateTime.Now;
            SetNavigation();
           _doctorid = new BLSales().GetDoctorLogin();
            var d = dsMaster1.USERINFO.FindByUSERID(_doctorid);
            if (d != null)
            {
                if (lookupcashier.EditValue == null)
                    lookupcashier.EditValue = int.Parse(d["USERID"].ToString());
            }
            LoadBarCodePrinters();
        }
        void LoadBarCodePrinters()
        {
            string defp = null;
            var settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                {
                    defp = printer;
                }
                if (printer.IndexOf("SATO", StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    repositoryItemComboBox1.Items.Add(printer);
                }
                if (printer.IndexOf("ZDesigner", StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    repositoryItemComboBox1.Items.Add(printer);
                }
                if (printer.IndexOf("BIXOLON", StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    repositoryItemComboBox1.Items.Add(printer);
                }
                if (printer.IndexOf("SAMSUNG", StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    repositoryItemComboBox1.Items.Add(printer);
                }
                //barEditItem2.EditValue = printer;
            }
        }
        void SetNavigation()
        {
            Bsnav.DataSource = dsMaster1.DDMAST;// ClsGetData.GetItemMast1List();
            Tnav.DataBindings.Add(new Binding("Text", Bsnav, "DNO", true));
            if (Bsnav.Count == 0)
            {
                MovePrev.Enabled = false;
                MoveNext.Enabled = false;
            }
            else
            {
                Bsnav.MoveLast();
                MoveNext.Enabled = false;
            }
        }
        void DoMovePrev()
        {

            if (Bsnav.Position <= 0)
            {
                MoveNext.Enabled = true;
                MovePrev.Enabled = false;
            }
            else
            {
                MovePrev.Enabled = true;
            }
            Bsnav.MovePrevious();
            MoveNext.Enabled = true;
            var current = (DataRowView)Bsnav.Current;
            var scode = current["DNO"].ToString();
            DoView(scode);
            IsNew = false;
        }
        void DoMoveNext()
        {
            if (Bsnav.Position == Bsnav.Count - 1)
            {
                MoveNext.Enabled = false;
                MovePrev.Enabled = true;
            }
            else
            {
                MovePrev.Enabled = true;
            }
            Bsnav.MoveNext();
            IsNew = false;
            var current = (DataRowView)Bsnav.Current;
            var scode = current["DNO"].ToString();
            DoView(scode);
        }
        public void DoView(string itm)
        {
            if (string.IsNullOrEmpty(itm)) return;
            // DataRow d = this.dsInventory1.ITEMMAST.FindByITEMNO(itm);
            DataRow d =  dsMaster1.DDMAST.FindByDNO(itm);
            _dosageno = itm;

            voudate.EditValue = d["TDATE"].ToString();
            txtvocherno.EditValue = d["DNO"].ToString();
            patname.Text = d["PATNAME"].ToString();
            hospname.Text = d["HOSPITAL"].ToString();
            dsMaster1.DDDETAILS.Clear();
            dsMaster1.Merge(new DrugDispatch().GetDddetailsDataTable(_dosageno));
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            PreparePrinting();
        }
        void CreateFormatedString(string printername, string itemcode, string itemname, string priceandcode, string price)
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
        void PreparePrinting()
        {
            var settings = new PrinterSettings();

            if (barEditItem2.EditValue == null)
            {
                XtraMessageBox.Show("Please select printer", "POS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                printDialog1.ShowDialog();
                settings.PrinterName = printDialog1.PrinterSettings.PrinterName;
            }
            else
            {
                settings.PrinterName = barEditItem2.EditValue.ToString();
            }
            if (!settings.IsDefaultPrinter)
            {
                _defaulPrinter = MyDefaultPrinters.GetDefaultPrinter();
                MyDefaultPrinters.SetDefaultPrinter(settings.PrinterName);
            }
            if (settings.IsValid)
            {
                StartPrinting(settings.PrinterName);
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
        void StartPrinting(string pname)
        {
            Application.DoEvents();
            if(!string.IsNullOrEmpty(_dosageno))
             new BLReports().PrintDosageLable(_dosageno);

            //String output = String.Empty;
            //var sb = new StringBuilder();

            //sb.AppendLine();
            //sb.AppendLine("N");
            ////sb.AppendLine("q530");
            ////sb.AppendLine("Q250");


            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A1,10,50,1,1,1,N,\"{0}\"", "ميدلية رقص"));
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B26,25,80,1,2,2,38,N,\"{0}\"", "يدليةون الصتلف"));
            //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A1,70,0,2,1,1,N,\"{0}\"", "اسم المريض"));
            ////sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A1,90,0,3,1,1,N,\"{0}\"", priceandcode));
            //sb.AppendLine("P1,1");
            //output = sb.ToString();
            //DoPrinting(output, pname);

            //int i = 0;
            //foreach (DataRow dr in dsMaster1.DDDETAILS.Rows)
            //{
            //    if (!string.IsNullOrEmpty(dr["QTY"].ToString()))
            //    {
            //        for (int j = 0; j < int.Parse(dr["QTY"].ToString()); j++)
            //        {
            //            {
            //                string cp = dr["ITEMCODE"].ToString().Trim() + " SR" + Math.Round(decimal.Parse(dr["PRICE"].ToString()), 2);
            //                CreateFormatedString(pname, dr["ITEMCODE"].ToString(), dr["ITEMNAME"].ToString(), cp, Math.Round(decimal.Parse(dr["PRICE"].ToString()), 2).ToString());
            //                dr["PQTY"] = j + 1;
            //            }
            //        }
            //    }
            //}
        }
        private void MovePrev_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoMovePrev();
        }
        private void MoveNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoMoveNext();
        }
        void DoPrinting(string output, string pname)
        {
            RawPrinterHelper.UniSendStringToPrinter(pname, output);
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoSave();
        }
        void DoSave()
        {
            if (patname.EditValue == null)
            {
                XtraMessageBox.Show("Please enter the patient name", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (hospname.EditValue == null)
            {
                XtraMessageBox.Show("Please enter the hosipital name", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (lookupcashier.EditValue == null)
            {
                XtraMessageBox.Show("Please  doctor not found", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (voudate.EditValue == null)
            {
                XtraMessageBox.Show("Please enter the date", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return; 
            }
            if (dsMaster1.DDDETAILS.Rows.Count == 0)
            {
                XtraMessageBox.Show("Nothing to save", "POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            var dr = (DsMaster.DDMASTRow) dsMaster1.DDMAST.NewRow();
            dr.DNO = _dosageno;
            dr.PATNAME = patname.Text;
            dr.HOSPITAL = hospname.Text;
            dr.COMP = Utils.Company;
            dr.TDATE = voudate.DateTime.Date;
            if(lookupcashier.EditValue!=null)
                 dr.DOCTOR = int.Parse(lookupcashier.EditValue.ToString());
            var bhl = new DrugDispatch();
            dDDETAILSBindingSource.EndEdit();
            var changes = (DsMaster.DDDETAILSDataTable)dsMaster1.DDDETAILS.GetChanges(DataRowState.Modified | DataRowState.Added);
            try
            {
                var strstatus = bhl.DoSaveDrugDispatch(dr, dsMaster1.DDDETAILS);
                if (strstatus == "1")
                {
                    _dosageno = Utils.DosageNo;
                    txtvocherno.Text = _dosageno;
                    XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataRow d in dsMaster1.DDDETAILS.Rows)
                    {
                        if (d.RowState != DataRowState.Deleted)
                        {
                            d["DNO"] = _dosageno;
                        }
                    }
                    var addedRows = from row in dsMaster1.DDDETAILS
                                    where row.RowState == DataRowState.Added
                                    select row;
                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    if (changes != null) dsMaster1.Merge(changes);
                    dsMaster1.AcceptChanges();
                }
                else
                {
                    XtraMessageBox.Show(strstatus, "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.EditValue!=null)
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle,colEXPDT,comboBoxEdit1.EditValue.ToString());
        }
    }
}