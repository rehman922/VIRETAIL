using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL.COMMON;

namespace Store
{
    public partial class PriceDiff : Form
    {
        List<ItemsWithPriceDiff> items = new List<ItemsWithPriceDiff>();

        public PriceDiff()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            items.Clear();
            var txt =
                "SELECT M.ITEMNO,M.SPRICE as SPRICE,M.CPRICE   FROM STOCKMASTER M  WHERE ITEMNO NOT IN ( SELECT dbo.STOCKMASTER2015.ITEMNO FROM dbo.STOCKMASTER2015 INNER JOIN  ";
            txt += " dbo.ITEMMAST ON dbo.STOCKMASTER2015.ITEMNO = dbo.ITEMMAST.ITEMNO INNER JOIN  ";
            txt +=
                "dbo.ITEMGROUP ON dbo.ITEMMAST.GROUPID = dbo.ITEMGROUP.GROUPID WHERE     (dbo.STOCKMASTER2015.QTY > 0) AND (dbo.STOCKMASTER2015.ITEMNO IN ";
            txt +=
                "  (SELECT     ITEMNO FROM          (SELECT DISTINCT ITEMNO, SPRICE FROM          dbo.STOCKMASTER2015 AS STOCKMASTER2015_1 ";
            txt += "  WHERE      (QTY > 0)) AS t  GROUP BY ITEMNO HAVING      (COUNT(*) > 1)))  ";
            txt += "       group by     dbo.STOCKMASTER2015.ITEMNO )     order by  M.ITEMNO asc  ";
          
            var cn = new SqlConnection(Utils.Connectionstring);
            cn.Open();

            var ta = new SqlDataAdapter(txt, cn);
            var dt = new DataTable();
            ta.Fill((dt));
            progressBarControl1.Properties.Maximum = dt.Rows.Count;
            Application.DoEvents();
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                progressBarControl1.EditValue = i;
                var osp = CompareItemPrice(dr["itemno"].ToString(), dr["SPRICE"].ToString(), cn);
                if (!string.IsNullOrWhiteSpace(osp))
                {
                    var sp = osp.Split(',');
                    if (decimal.Parse(sp[0]) != decimal.Parse(dr["SPRICE"].ToString()))
                    {
                        var d = new ItemsWithPriceDiff();
                        var qty = GetSumQty(dr["itemno"].ToString(), cn);
                        d.itemno = dr["itemno"].ToString();
                        d.oldsp = decimal.Parse(sp[0]);
                        d.oldcp = decimal.Parse(sp[1]);
                        d.newsp = decimal.Parse(dr["SPRICE"].ToString());
                        d.newcp = decimal.Parse(dr["CPRICE"].ToString());
                        d.newqty = qty;
                      //  d.newcptot = decimal.Parse(dr["CPRICE"].ToString())*qty;
                       // d.newsptot = decimal.Parse(dr["SPRICE"].ToString()) * qty;
                        d.newcptot = qty*(decimal.Parse(dr["CPRICE"].ToString()) - decimal.Parse(sp[1]));
                        d.ischk = false;
                        items.Add(d);
                        i++;
                    }
                   }
                }
            
            gridControl1.DataSource = items;
           // gridControl1.ResetBindings();
        }
        int GetSumQty(string itemno,  SqlConnection cn)
        {
            var txt = "select sum(qty) from dbo.STOCKMASTER where ITEMNO = '" + itemno + "' ";
            var cmd = new SqlCommand(txt, cn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        string CompareItemPrice(string itemno,string sprice,SqlConnection cn)
        {
            string retval =String.Empty;
            var txt = "select top 1  sprice ,cprice from dbo.STOCKMASTER2015 where ITEMNO = '" + itemno + "' and qty > 0 ";
            var cmd = new SqlCommand(txt, cn);
            var res = Convert.ToDecimal(cmd.ExecuteScalar());
            using (var reader = cmd.ExecuteReader())
            {
                 if (reader.Read())
                 {
                     retval = reader.GetValue(0).ToString();
                     retval += "," + reader.GetValue(1).ToString(); 
                 }
            }
           return retval;
        }

        private void PriceDiff_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("do you want to update","POS",MessageBoxButtons.YesNo)==DialogResult.No) return;
            var cn = new SqlConnection(Utils.Connectionstring);
            cn.Open();
            foreach (var d in items)
            {
                if (!d.ischk)
                {
                    try
                    {
                        var txt = "update STOCKMASTER set  sprice = " + d.oldsp + " where ITEMNO = '" + d.itemno + "' ";
                        var cmd = new SqlCommand(txt, cn);
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        XtraMessageBox.Show(ex.ToString());
                    }
                }
            }
            XtraMessageBox.Show(" update", "POS");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }
    }

    public class ItemsWithPriceDiff
    {
        public string itemno { get; set; }

        public decimal oldsp { get; set; }
        public decimal newsp { get; set; }

        public decimal oldcp { get; set; }
        public decimal newcp { get; set; }
        public decimal newqty { get; set; }
        public decimal newsptot { get; set; }
        public decimal newcptot { get; set; }
        public bool ischk { get; set; }




    }
}
