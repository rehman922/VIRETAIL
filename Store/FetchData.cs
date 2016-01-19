using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using VIRETAILDAL;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class FetchData : XtraForm
    {
        private static string patha = "";
        public FetchData()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = textEdit1.EditValue == null ? textEdit2.EditValue.ToString() : textEdit1.EditValue.ToString();
            string provider = "Provider=Microsoft.Jet.OLEDB.4.0 ; Data Source= " + path  + "";
            // string provider= "Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Arehman-lptp\Desktop\CPHMAS.MDB
            var con = new OleDbConnection(provider);
            con.Open();
            if (textEdit1.EditValue != null)
            {
                if (!DoUpdateSupplier("select * from mast where ACCTYPE='SU'", con))
                {
                    progressPanel1.Visible = false; 
                    XtraMessageBox.Show("Some problem in supplier master creating");
                }
                else
                {
                    progressPanel1.Visible = false; 
                    XtraMessageBox.Show("Supplier master created");
                }
            }
            if (textEdit1.EditValue != null)
            {
                if (!DoCreateItemMast("select * from item", con))
                {
                    progressPanel1.Visible = false; 
                    XtraMessageBox.Show("Some problem in item master creating");
                }
                else
                {
                    progressPanel1.Visible = false; 
                    XtraMessageBox.Show("Item master created");
                }
            }
            if (textEdit2.EditValue != null)
            {
                if (ClsGetData.GetSysCode("DT") == "3")
                {
                    XtraMessageBox.Show("Stock transfered alaready", "POS");
                    return;
                }
                if (!DoCreateStockMast("SELECT DCODE,BARCD,SUM(BQNTY) AS QTY,SPRICE,AVG(CPRICE) AS CPRICE,EXPIRY  FROM STOCK  WHERE  BQNTY  > 0 GROUP BY DCODE,BARCD,SPRICE,EXPIRY ", con))
                {
                    progressPanel1.Visible = false; 
                }
                else
                {
                    progressPanel1.Visible = false; 
                    XtraMessageBox.Show("stock master created","POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClsGetData.UpdateSysCode("3", "DT");
                    DoCreateOpeningStockMast(
                        "SELECT DCODE,BARCD,SUM(BQNTY) AS QTY,MAX(SPRICE) as SPRICE,MIN(EXPIRY) as EXPIRY FROM STOCK  WHERE  BQNTY  > 0 GROUP BY DCODE,SPRICE,EXPIRY,BARCD ",
                        con);
                }
            }
            if(con.State==ConnectionState.Open)
                con.Close();
        }
        void DoCreateOpeningStockMast(string sql, OleDbConnection con)
        {
            progressPanel1.Visible = true;
            try
            {
                var ds = new DataSet();
                var ta = new OleDbDataAdapter(sql, con);
                ta.Fill(ds);
                var dsM = new DsInventory();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Application.DoEvents();
                    var row = (DsInventory.STOCKOPENINGRow)dsM.STOCKOPENING.NewRow();
                    row.ITEMNO = dr["DCODE"].ToString();
                    row.BARCODE = dr["BARCD"].ToString();
                    row["TYEAR"] = DateTime.Now.Year;
                    row["TDATE"] = DateTime.Now.ToString("yyyy-MM-dd");
                    row.BEGQTY = int.Parse(dr["QTY"].ToString());
                    if (!string.IsNullOrEmpty(dr["EXPIRY"].ToString()))
                        row.MINEXPDATE = DateTime.Parse(dr["EXPIRY"].ToString());
                    if (!string.IsNullOrEmpty(dr["SPRICE"].ToString()))
                        row.MAXSPRICE = decimal.Parse(dr["SPRICE"].ToString());
                    row["COMPANY"] = Utils.Company;
                    row["TDATETIME"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dsM.STOCKOPENING.Rows.Add(row);
                }
                var ret = new StockMaster().UpdateOpeningStock(dsM.STOCKOPENING);
                if (ret == "1")
                {
                    return;
                }
                if (ret != "1")
                {
                    XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool DoCreateStockMast(string sql, OleDbConnection con)
        {
            progressPanel1.Visible = true;
            try
            {
                var ds = new DataSet();
                var ta = new OleDbDataAdapter(sql, con);
                ta.Fill(ds);
                var dsM = new DsInventory();
                var whid = new Functions().GetSalesStore();
                //dsMaster.Merge(new VIRETAILDAL.Masters.StockMaster().UpdateStockDataSet();
                int cnt = 0;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cnt++;
                    Application.DoEvents();
                    var row = (DsInventory.STOCKMASTERRow) dsM.STOCKMASTER.NewRow();
                    row.ITEMNO= dr["DCODE"].ToString();
                    row.BARCODE= dr["BARCD"].ToString();
                    row.QTY = int.Parse(dr["QTY"].ToString());
                    if (!string.IsNullOrEmpty(dr["EXPIRY"].ToString()))
                        row.EXPDATE = DateTime.Parse(dr["EXPIRY"].ToString());
                    if (!string.IsNullOrEmpty(dr["SPRICE"].ToString()))
                        row.SPRICE = decimal.Parse(dr["SPRICE"].ToString());
                    row.CPRICE= Math.Round(decimal.Parse(dr["CPRICE"].ToString()),2);
                    row["STORETYPE"] = "S";
                    row.SQTY = int.Parse(dr["QTY"].ToString());
                    row["WHID"] = whid;
                    row["COMPANY"] = Utils.Company;
                    dsM.STOCKMASTER.Rows.Add(row);
                    label1.Text = cnt.ToString();
                }
               label1.Text = cnt.ToString();
               var ret = new StockMaster().UpdateStockDataSet(dsM.STOCKMASTER);
               if (ret == "1")
               {
                   return true;
               }
               if (ret != "1")
               {
                   XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(),"POS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return true;
        }
        bool DoCreateItemMast(string sql,OleDbConnection con)
        {
            progressPanel1.Visible = true;
            
             try
            {
         var ds = new DataSet();
        var ta = new OleDbDataAdapter(sql, con);
        ta.Fill(ds);
        var dsMaster = new DsMaster();

        dsMaster.Merge(new ItemMaster().GetItemMastList());
        int cnt = 0;
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            cnt++;
            var nrow = dsMaster.ITEMMAST.FindByITEMNO(dr["DCODE"].ToString());
            if (nrow == null)
            {
                Application.DoEvents();
                var row = dsMaster.ITEMMAST.NewRow();
                row["Itemno"] = dr["DCODE"];
                row["ITEMTYPE"]=1;
                row["SUPPLIERNO"] = dr["ACCNO"];
                row["BARCODE"] = dr["BARCD"];
                row["ITEMNAME"] = dr["DNAME"];
                row["GROUPID"] = int.Parse(dr["ITYPE"].ToString());
                row["DISCOUNT"] = dr["STAX"] ?? 0;  
                row["EXPDATEREQ"] = dr["EXPIRY"];
                row["sPRICE"] = dr["SPRICE"];
                row["CPRICE"] = dr["CPRICE"];
                row["MINQTY"] = dr["MINQTY"];
                row["REORDER"] = dr["MINQTY"];
                row["SEL"] = 0;
                row["DISCONSALE"] = 0;
                dsMaster.ITEMMAST.Rows.Add(row);
            }
            else
            {
                nrow["SUPPLIERNO"] = dr["ACCNO"];
                nrow["ITEMTYPE"] = 1;
                nrow["DISCOUNT"] = dr["STAX"] ?? 0;
            }
          }
            label1.Text = cnt.ToString();
            return new ItemMaster().UpdateItems(dsMaster.ITEMMAST);
            }
             catch (Exception ex)
             {
                 XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             return false;
        }
        bool DoUpdateSupplier(string sql, OleDbConnection con)
        {
            progressPanel1.Visible = true;
           
            try
            {
                var ds = new DataSet();
                var ta = new OleDbDataAdapter(sql, con);
                ta.Fill(ds);
                var dsMaster = new DsMaster();

                dsMaster.Merge(new DataManager().GetSupplierList());
                int cnt = 0;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cnt++;


                    var row = dsMaster.SUPPLIER.FindBySUPPLIERNO(dr["ACCNO"].ToString());
                    if (row == null)
                    {
                        Application.DoEvents();
                        var newrow = dsMaster.SUPPLIER.NewRow();

                        newrow["SUPPLIERNO"] = dr["ACCNO"].ToString();
                        newrow["SUPPLIERNAME"] = dr["ACCNAME"].ToString();
                        // newrow["ALTERNATENAME"] = dr["ALTERNATENAME"].ToString();
                        newrow["CONTACT"] = dr["CONTACT"].ToString();
                        newrow["ADDRESS"] = dr["ADDRESS"].ToString();
                        newrow["PHONE"] = dr["TEL1"].ToString();
                        // newrow["FAX"] = dr["FAX"].ToString();
                        newrow["CREDITLIMIT"] = dr["CRLMT"] ?? 0;
                        newrow["DUEDAYS"] = dr["DDAY"] ?? 0;
                        dsMaster.SUPPLIER.Rows.Add(newrow);
                    }
                }
                label1.Text = cnt.ToString();
                return new DataManager().UpdateSupplier(dsMaster.SUPPLIER);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textEdit2.EditValue = openFileDialog1.FileName;
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
             openFileDialog1.ShowDialog();
             textEdit1.EditValue = openFileDialog1.FileName;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           // string str = "SELECT itemno,AVG(CPRICE) FROM  STOCKMASTER group by ITEMNO ";
            var ret = new StockMaster().UpdateAvgCostprice();
            if(ret=="1")
            {
                MessageBox.Show("Average Cost Updated");
            }
            else
            {
                MessageBox.Show(ret);
            }
        }
    }
}