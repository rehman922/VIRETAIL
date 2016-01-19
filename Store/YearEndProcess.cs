using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class YearEndProcess : Form
    {
        private string _fname;
        private string _fMachineno;
        private string _fInventoryby;
        private int _fClosingperiod;
        private string _GridHeading;
        private string _SummaryText;
        DsInventory.YearEndInventoryDataTable _dsyearend = new DsInventory.YearEndInventoryDataTable();
        public YearEndProcess()
        {
            InitializeComponent();
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoUploadFile();
        }
        void DoUploadFile()
        {
            var itemlist = ClsGetData.GetItemMastList();
            var fname = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LookUpWithCode.txt";
            using (var file = new StreamWriter(@fname))
            {
                foreach (DataRow dr in itemlist.Rows)
                {
                    var line = dr["ITEMNO"] + "," + dr["BARCODE"];
                    file.WriteLine(line);
                }
            }
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.DoEvents();
            progressPanel1.Visible = true;
            var b = new YearEndClass();
            var ds = b.GetClosingYear();
            int cyear = 0;
            if (ds.Rows.Count == 0)
            {
                var f1 = new YearCloseProcess();
                f1.ShowDialog();
                cyear = f1._ClosingYear;
            }
            else
            {
                cyear = int.Parse(ds.Rows[0]["CYEAR"].ToString());
            }
            if(cyear==0) return;

            var f = new TxtFileRead();
            f.ValidateYearEnd(cyear);
            f.ShowDialog();
            if (f.iSvalid)
            {
              DownLoadFiles(f.Fname, f.Machineno, f.Inventoryby, f.Closingperiod);
             _fname=f.Fname;
            _fMachineno =f.Machineno;
            _fInventoryby= f.Inventoryby;
            _fClosingperiod = f.Closingperiod;
             SaveDataToInventoryYear(f.Closingperiod);
             barButtonItem4.Enabled = true;
            }
            progressPanel1.Visible =false;
        }
        void  SaveDataToInventoryYear(int clo)
        {
          var t =  new YearEndClass().SaveDataToInventoryYear(_dsyearend);
          if (t == "1")
          {
              var b = new YearEndClass();
             _dsyearend = b.LoadYearEndInventory(clo);
              yearEndInventoryBindingSource.DataSource = _dsyearend;
              //gridControl1.DataSource = _dsyearend;
          }
        }
        void DownLoadFiles(string fname, string machno, string inventoryby, int closingperiod)
        {
            string textline = "";
            int j = 0;
            var fReader = new StreamReader(fname);
            Application.DoEvents();
            do
            {
                barEditItem1.EditValue = j;
                textline = fReader.ReadLine();
                FindItem(textline, machno, inventoryby, closingperiod);
                j++;
                if (j == 100)
                    j = 0;
            }
            while (fReader.Peek() != -1);
            fReader.Close();
            barEditItem1.EditValue = 100;
           // DoReadItems(machno, inventoryby, closingperiod);
        }
        void FindItem(string line, string machno, string inventoryby,int Yearclosed)
        {
          var split =line.Split(',');
          var blf = new BlItemMaster().FindItemByBarCode(split[0]);
            try
            {
                if (blf.Rows.Count == 0)
                {
                    AppendDataToGrid(split[0], split[0], "*******", 0, int.Parse(split[1]), null, machno, inventoryby,
                        Yearclosed, true);
                }
                else
                {
                    foreach (DataRow dr in blf)
                    {
                        AppendDataToGrid(dr["ITEMNO"].ToString(), dr["BARCODE"].ToString(), dr["ITEMNAME"].ToString(),
                            int.Parse(dr["GROUPID"].ToString()), int.Parse(split[1]), null, machno, inventoryby,
                            Yearclosed);
                    }
                }
            }
            catch (Exception ex)
            {}
        }
        void AppendDataToGrid(string itemno,string barcode,string itemname, int grpid, int qty,string expdate,string machno,string inventoryby,int Yearclosed, bool  nostock=false)
        {
            try{
                var bl = new StockMaster();
                var stk = bl.GetAvgMaxQtySpCpExpDtFromStock(itemno, Yearclosed);//bl.GetLastSpriceCpriceExpByItemNo(itemno, Yearclosed);
            var dr = _dsyearend.NewRow();
            dr["ITEMNO"] = itemno;
            dr["BARCODE"] = barcode;
            dr["ITEMNAME"] = itemname;
            decimal cprice = 0;
            decimal sprice = 0;
            var d1 = stk.Tables[0].Rows[0]; // if (stk.Tables[0].Rows.Count > 0)
            if(int.Parse(d1[0].ToString()) > 0)
            {
                foreach (DataRow dss in stk.Tables[0].Rows)
                {
                    dr["INSTOCK"] = 0; // if (!string.IsNullOrEmpty(dss["QTY"].ToString()))
                    dr["INSTOCK"] = dss["QTY"];//bl.GetLastAvailableQty(itemno, Yearclosed);
                    dr["EXPDATE"] = dss["Expdate"]; // if (!string.IsNullOrEmpty(dss["Sprice"].ToString()))
                    if(decimal.Parse(dss["Sprice"].ToString())==0)
                        dr["SPRICE"] = new ItemMaster().GetItemSalesPrice(itemno);
                    else
                        dr["SPRICE"]  = decimal.Parse(dss["Sprice"].ToString()); // if (!string.IsNullOrEmpty(dss["Cprice"].ToString()))
                    if (decimal.Parse(dss["Cprice"].ToString()) == 0)
                    {
                        cprice = (decimal) bl.GetAvgMaxQtySpCpExpDtFromStock(itemno, Yearclosed,false).Tables[0].Rows[0]["CPRICE"];
                        if(cprice==0)
                             dr["CPRICE"] =  new ItemMaster().GetItemCostPrice(itemno);
                    }
                    else
                    {
                        dr["CPRICE"] = decimal.Parse(dss["Cprice"].ToString());
                    }
                }
             }
            else
            {
                dr["INSTOCK"] = 0;
                dr["SPRICE"] = new ItemMaster().GetItemSalesPrice(itemno);
                dr["CPRICE"] = new ItemMaster().GetItemCostPrice(itemno);
                if(sprice > 0 && cprice==0)
                {
                    var disc = new ItemMaster().GetPurchaseDist(itemno);
                    cprice = sprice - ((sprice*disc)/100);
                }
                dr["CPRICE"] = cprice;
            }
            dr["PHYSICALSTOCK"] = qty;
            dr["CDATE"] = DateTime.Now;
            dr["NOMASTER"] = nostock;
            dr["MACHINENO"] = machno;
            dr["MUSER"] = inventoryby;
            dr["GROUPID"] = grpid;
            dr["COMP"] = Utils.Company;
            dr["TRANSFERED"] = 0;
            dr["INVENTORYYEAR"] = Yearclosed;
           _dsyearend.Rows.Add(dr);
            }
            catch(Exception ex)
            {
            }
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.DoEvents();

            if (_dsyearend.Rows.Count > 0)
            {
                progressPanel1.Visible = true;
              if( DoValidateThePhysicalStock())
              {
                  barButtonItem5.Enabled = true;
              }
              else
              {
                  barButtonItem5.Enabled =false;
              }
              progressPanel1.Visible = false;
            }
            else
            {
                XtraMessageBox.Show("Data Not Found", "POS", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
         }
        private void YearEndProcess_Load(object sender, EventArgs e)
        {
            var ds = ClsGetData.GetItemGroup();
            repositoryItemLookUpEdit1.DataSource = ds;
            var dsW = ClsGetData.GetStoreList();
            var bsW = new BindingSource(dsW, "") { Filter = "COMPANY = '" + Utils.Company + "'" };
            lookupfrom.Properties.DataSource = bsW;
            var b = new YearEndClass();
            var ds1 = b.GetClosingYear();
            if (ds1.Rows.Count > 0)
            {
                if (_fClosingperiod == 0)
                    _fClosingperiod = int.Parse(ds1.Rows[0]["CYEAR"].ToString());
                _dsyearend = b.LoadYearEndInventory(int.Parse(ds1.Rows[0]["CYEAR"].ToString())); 
            }
            _GridHeading = "Physical Inventory Report";
            yearEndInventoryBindingSource.DataSource = _dsyearend;// gridControl1.DataSource = _dsyearend;
            txtstock.Properties.Mask.EditMask = "\\d+";
            txtstock.Properties.Mask.MaskType = MaskType.RegEx;
        }
        bool DoValidateThePhysicalStock()
        {
            int cntnomaster = 0;
            int cntnosprice = 0;
            int cntnocprice = 0;
            int stocknottally = 0;
            foreach (DsInventory.YearEndInventoryRow dr in _dsyearend.Rows)
            {
                if (dr.NOMASTER)
                {
                    cntnomaster++;
                }
                if (dr.SPRICE == 0)
                {
                    cntnosprice++;
                }
                if (dr.CPRICE == 0)
                {
                    cntnocprice++;
                }
                if (dr.INSTOCK != dr.PHYSICALSTOCK)
                {
                    stocknottally++;
                }
            }
            txtitemsnomaster.Caption = "Total Items with out master " + cntnomaster;
            txtitemsnosprice.Caption = "Total Items with out S.Price " + cntnosprice;
            txtitemsnocprice.Caption = "Total Items with out C.Price " + cntnocprice;
            txtstockdifference.Caption = "Total Stock differences " + stocknottally;
            if (cntnomaster > 0 || cntnosprice > 0 || cntnocprice > 0)
            {
                errorflg.Visibility =BarItemVisibility.Always;
            }
            return label1.Visible;
        }
        void UpLoadInventory()
        {
            var whid = lookupfrom.EditValue.ToString();
            var s = new StoreManager().GetStoreType(whid);
            string storetype = "S";
            if (s.IndexOf("S") == -1)
            {
                storetype = "P";
            }
            var s1 = new YearEndClass().DoUpdateInventory(_dsyearend, storetype, whid);
            if (s1 == "1")
            {

                XtraMessageBox.Show("Inventory Updated", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(s1, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = true;
            Application.DoEvents();
            foreach (DsInventory.YearEndInventoryRow dr in _dsyearend)
            {
                decimal sprice = 0;
                decimal cprice = 0;
                if (!string.IsNullOrEmpty(dr["Sprice"].ToString()))
                    sprice = decimal.Parse(dr["Sprice"].ToString());
                if (!string.IsNullOrEmpty(dr["Cprice"].ToString()))
                    cprice = decimal.Parse(dr["Cprice"].ToString());
                if (sprice == 0 || cprice == 0)
                {
                     var strspcp = new ItemMaster().GetSCpriceFromImportedPurchaseFile(false,dr["itemno"].ToString(), dr["barcode"].ToString()).Split(',');   
                     if (sprice == 0)
                    {
                         dr["Sprice"] = strspcp[0]; // new ItemMaster().GetSCpriceFromImportedPurchaseFile(false,dr["itemno"].ToString(), dr["barcode"].ToString());
                    }
                    if (cprice == 0)
                    {
                        cprice = Convert.ToDecimal(strspcp[1]);//Decimal.Round(new ItemMaster().GetSCpriceFromImportedPurchaseFile(true, dr["itemno"].ToString(), dr["barcode"].ToString()), 2);
                        if (cprice == 0)
                        {
                            var disc = new ItemMaster().GetPurchaseDist(dr["itemno"].ToString());
                            cprice = sprice - sprice*(disc/100);
                        }
                        dr["cprice"] = cprice;
                    }
                }
                barButtonItem4.Enabled = true;
            }
            progressPanel1.Visible = false;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
              //  if (!itemfoundingrid())
              //  {
                    var blf = new BlItemMaster().FindItemByBarCode(textBox1.Text);
                    if (blf.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Item not found", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        textBox1.Clear();
                    }
                    else
                    {
                        var dr = blf.Rows[0];
                        var drs = new ItemMaster().GetSPCPEXPDtFromsTOCKfILE(dr["itemno"].ToString(),dr["barcode"].ToString(), _fClosingperiod.ToString());
                        if (drs.Rows.Count > 0)
                            lookUpEdit1.EditValue = drs.Rows[0]["sprice"];
                        else
                        {
                           // drs = 
                            drs = new ItemMaster().GetSPCPEXPDtFromImportedPurchaseFile(dr["itemno"].ToString(), dr["barcode"].ToString());
                        }
                        sPCPRICEFROMHISTBindingSource.DataSource = drs;
                       txtstock.EditValue = 0;
                       textBox1.Text = dr["itemno"].ToString();
                       txtbarcode.Text = dr["barcode"].ToString();
                       // txtsprice.EditValue = new ItemMaster().GetItemSalesPrice(dr["itemno"].ToString());
                       //txtcprice.EditValue = new ItemMaster().GetItemCostPrice(dr["itemno"].ToString());

                       txxitemname.Text = dr["itemname"].ToString(); //textBox1.Tag  = drs["ITCD"]
                       txtgrpid.Text  = dr["GROUPID"].ToString();

                        string dt = new BLSales().GetExpiryDt(dr["ITEMNO"].ToString());
                        if(!String.IsNullOrEmpty(dt))
                        {
                         DateTime ndt = DateTime.Parse(dt);
                         txtexpdate.Text = ndt.Month + " - " + ndt.Year;
                        }
                        button1.Enabled = true;
                        txtstock.Focus();

                  //  }
                }
                //else
                //{
                //    button1.Enabled = false;
                //}
            }
            if (e.KeyCode == Keys.F10)
            {
                KeyF10();
            }
        }
        bool itemfoundingrid()
        {
            var str = "ITEMNO ='" + textBox1.Text + "' or  BARCODE = '" +textBox1.Text +"'";
            var tar = _dsyearend.Select(str);
            bool ts = false;
            foreach (DataRow dr  in tar)
            {
                ts = true;
                yearEndInventoryBindingSource.Filter = str;
            }
            return ts;
        }
        bool ItemNotTranasferInGrid()
        {
            var str =  "TRANSFERED=0 and NOMASTER=0";
            var tar = _dsyearend.Select(str);
            bool ts = false;
            foreach (DataRow dr in tar)
            {
                ts = true;
           }
            return ts;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DoClear();
        }
        void DoClear()
        {
            textBox1.Clear();
            txtbarcode.Clear();
            txtexpdate.EditValue = null;
            txtstock.EditValue = 0;
            txxitemname.Text = null;
            txtgrpid.EditValue = null;
            txtexpdate.EditValue = null;
            yearEndInventoryBindingSource.RemoveFilter();
            textBox1.Focus();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void KeyF10()
        {
            this.InvokeEx((lv => AddItems())); ;
        }
        void AddItems()
        {
            var frm = new FrmItemLookUp();
            frm.EventSelectedItem += AdditemsToList;
            frm.closeonselect = true;
            if (!String.IsNullOrEmpty(textBox1.Text))
                frm.filtertext = textBox1.Text;
            frm.ShowDialog();
        }
        void AdditemsToList(object sender, GetDataRowEventArgs g)
        {
            var current = g.SelectedRow;
            textBox1.Text = current["ITEMNO"].ToString();
            SendKeys.Send("{ENTER}");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yearEndInventoryBindingSource.RemoveFilter();
            //Add Item
            try
            {
                var dr = _dsyearend.NewRow();
                dr["ITEMNO"] = textBox1.Text;
                dr["BARCODE"] = txtbarcode.Text;
                dr["ITEMNAME"] = txxitemname.Text;
                dr["INSTOCK"] = new BLSales().GetStockByItemno(dr["ITEMNO"].ToString());
                dr["PHYSICALSTOCK"] = txtstock.EditValue;
                if (txtexpdate.EditValue != null)
                {
                    var dt = txtexpdate.EditValue.ToString().Split('-');
                    //if (dt[1].ToString().Length() != 4 || dt[1].ToString().Length() != 2)
                    //{
                    //    XtraMessageBox.Show("Please check the expiry date ", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    var d1 = new DateTime(int.Parse(dt[1]), int.Parse(dt[0]), 1);
                    dr["EXPDATE"] = d1;
                   
                }
                       //            txtsprice.EditValue  = new ItemMaster().GetItemSalesPrice(itemno);
                       //txtcprice.EditValue = new ItemMaster().GetItemCostPrice(itemno);

                dr["SPRICE"] = decimal.Parse(lookUpEdit1.EditValue.ToString());
                dr["CPRICE"] = decimal.Parse(lookUpEdit1.GetColumnValue("CPRICE").ToString()) ;
                dr["CDATE"] = DateTime.Now;
                dr["NOMASTER"] = 0;
                dr["MACHINENO"] = _fMachineno;
                dr["MUSER"] = _fname;
                dr["TRANSFERED"] = 0;
                dr["GROUPID"] = txtgrpid.Text;
                dr["INVENTORYYEAR"] = _fClosingperiod;
                dr["ISADDED"] = 1;
                dr["COMP"] = Utils.Company;
                _dsyearend.Rows.Add(dr);

                SaveDataToInventoryYear(_fClosingperiod);
                DoClear();
                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            yearEndInventoryBindingSource.RemoveFilter();


            if (!ItemNotTranasferInGrid())
            {
                XtraMessageBox.Show("No data to upload", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lookupfrom.EditValue == null)
            {
                XtraMessageBox.Show("Please select the store", "POS", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Information);
                return;
            }
            progressPanel1.Visible = true;
            Application.DoEvents();
            //var cnt = _dsyearend.Select("transfered=0 and nomaster=1");
            UpLoadInventory();
            barButtonItem8.Visibility= BarItemVisibility.Always;
            progressPanel1.Visible = false;
        }
        private void txtitemsnomaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = false;
            yearEndInventoryBindingSource.Filter = "NOMASTER=1";
            _GridHeading = "Physical Inventory Report Items Not Masters";
        }
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = false;
            yearEndInventoryBindingSource.RemoveFilter();
             _GridHeading = "Physical Inventory Report";
        }
        private void txtitemsnosprice_ItemClick(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = false;
            yearEndInventoryBindingSource.Filter = "SPRICE=0";
            _GridHeading = "Physical Inventory Report Items With Out S.Price";
        }
        private void txtitemsnocprice_ItemClick(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = false;
            yearEndInventoryBindingSource.Filter = "CPRICE=0";
            _GridHeading = "Physical Inventory Report Items With Out C.Price";
        }
        private void txtstockdifference_ItemClick(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = false;

            yearEndInventoryBindingSource.Filter = "INSTOCK <> PHYSICALSTOCK";
            _GridHeading = "Physical Inventory Report Items With Stock Differences";
        }
        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = false;
            yearEndInventoryBindingSource.Filter = "ISADDED=1";
            _GridHeading = "Physical Inventory Report Items Manually added";
        }
        private decimal totsprice;
        private decimal totcprice;
        private decimal phystock;
        private void gridView1_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            GridView view = sender as GridView;
            //if (Equals("Sum", item.Tag))
            //{
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                totsprice = 0;
                totcprice = 0;
                phystock = 0;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                phystock = decimal.Parse(view.GetRowCellValue(e.RowHandle, "PHYSICALSTOCK").ToString());
                totsprice += phystock * decimal.Parse(view.GetRowCellValue(e.RowHandle, "SPRICE").ToString());
                totcprice += phystock * decimal.Parse(view.GetRowCellValue(e.RowHandle, "CPRICE").ToString());
                //totsprice += decimal.Parse(view.GetRowCellValue(e.RowHandle, "SPRICE").ToString());
                //totcprice += decimal.Parse(view.GetRowCellValue(e.RowHandle, "CPRICE").ToString());
                //if (!Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "NETAMT"))) validRowCount = ++;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryID)
                {
                    case 1:
                        e.TotalValue = "Total Cost = " + (totcprice.ToString("#,#.00")) + " Total Sales = " + (totsprice.ToString("#,#.00")) + "";
                        _SummaryText = "Total Cost = " + (totcprice.ToString("#,#.00")) + " Total Sales = " + (totsprice.ToString("#,#.00")) + "";
                        break;
                }
            }
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = false;
            var pr = new GridPrintingClass();
            pr.Footer1 = _SummaryText;
            pr.Footer2 = DateTime.Now.ToString();
            pr.Heading1 = Utils.Companyname;
            pr.Heading2 = _GridHeading;
            pr.DoPrint(gridControl1);
        }
        private void YearEndProcess_Resize(object sender, EventArgs e)
        {
            progressPanel1.Top = (Height - progressPanel1.Height) / 2;
            progressPanel1.Left = (Width - progressPanel1.Width) / 2;
        }
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            yearEndInventoryBindingSource.RemoveFilter();
            if(dateEdit1.EditValue==null)
            {
                XtraMessageBox.Show("Please select the opening year" ,"POS",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           var bl = new YearEndClass();
           if(bl.GetCountNonTrasfered() > 0)
           {
               XtraMessageBox.Show("Some items not transfered please check and close the year", "POS",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               Application.DoEvents();
               progressPanel1.Visible = true;
               var ret = bl.DoUpdateOpeningStock(dateEdit1.DateTime, _fClosingperiod);
               if (ret == "1")
               {
                   XtraMessageBox.Show("Inventory updated", "POS",MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                XtraMessageBox.Show(ret, "POS",MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               progressPanel1.Visible = false;
           }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
        }
        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveDataToInventoryYear(_fClosingperiod);
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e){
            progressPanel1.Visible = true;
            foreach (DataRow dr in _dsyearend.Rows)
            {
                if (dr["ISADDED"].ToString()== bool.TrueString)
                {
                    dr["INSTOCK"] = new YearEndClass().GetInStockFromBackUp(dr["itemno"].ToString(), _fClosingperiod);
                    var dt = new YearEndClass().GetMaxExpirtyDt(dr["itemno"].ToString(), _fClosingperiod);
                    if (!String.IsNullOrEmpty(dt))
                    {
                        DateTime ndt = DateTime.Parse(dt);
                        dr["EXPDATE"] = ndt;
                      //  txtexpdate.Text = ndt.Month + " - " + ndt.Year;
                    }
                    
                }
            }
            progressPanel1.Visible = false;
        }
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            progressPanel1.Visible = false;
            yearEndInventoryBindingSource.Filter = "PHYSICALSTOCK=0";
            _GridHeading = "Physical Qty not found Report ";
        }
        private void errorflg_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //var cn = new SqlConnection(VIRETAILDAL.COMMON.Utils.Connectionstring);
                //string str = "select itemno,sum(qty) from salesinvdetail where tid > 368618 group by itemno";
                //var cmd = new SqlCommand();
                //cn.Open();
                //cmd.Connection = cn;
                //var dt = new DataTable();
                //var ta = new SqlDataAdapter(str, cn);
                //ta.Fill(dt);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    var t = GetStockid(dr[0].ToString());
                //    if (t > 0){
                //        cmd.CommandText = " update stockmaster  set qty =  qty - " + int.Parse(dr[1].ToString()) +  " where stockid = " + t + "";
                //        cmd.ExecuteNonQuery();
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Stock Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int GetStockid(string itemno)
        {
            var cn = new SqlConnection(Utils.Connectionstring);
            cn.Open();
            string str = "select top 1 stockid from stockmaster where itemno = '" + itemno + "'";
            var cmd = new SqlCommand(str,cn);
            return (int) (cmd.ExecuteScalar() ?? 0);
        }
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete all", "Inventory", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }
        private void txtstock_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            var f = new PriceDiff();
            f.Show();
        }
        
    }
}
 






















































