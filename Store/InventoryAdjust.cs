using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace Store
{
    public partial class InventoryAdjust : Form
    {
        bool isexpiry = false;
        bool isupdateall = false;
        bool isaddnew = false;
        bool ischangeorder = false;
        int itemid = 0;
        decimal Asprice = 0m;
        decimal Acpirce = 0m;
        public InventoryAdjust()
        {
            InitializeComponent();
        }
        private void lookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        #region toolbar
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DoNew();
            lbltool.Text = btnnew.Text;
            DoToolBarButtons();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DoExpiry();
            lbltool.Text = toolStripButton2.Text;
            DoToolBarButtons();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            EditAll();
            lbltool.Text = toolStripButton3.Text;
            DoToolBarButtons();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        { 
            DoChangeOrder();
            lbltool.Text = toolStripButton4.Text;
            DoToolBarButtons();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        { 
            DoSave();
           // lbltool.Text = toolStripButton5.Text;
            DoToolBarButtons();
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        { DoStock(); }
        #endregion
        private void InventoryAdjust_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ADJREASONS' table. You can move, or remove it, as needed.
            this.aDJREASONSTableAdapter.Fill(this.dataSet1.ADJREASONS);
            // TODO: This line of code loads data into the 'dataSet1.ADJDETAIL' table. You can move, or remove it, as needed.
            this.aDJDETAILTableAdapter.Fill(this.dataSet1.ADJDETAIL);
           // TODO: This line of code loads data into the 'dataSet1.ADJDETAIL' table. You can move, or remove it, as needed.
           // TODO: This line of code loads data into the 'dataSet1.ITEMMAST1' table. You can move, or remove it, as needed.
            this.iTEMMAST1TableAdapter.Fill(this.dataSet1.ITEMMAST1);
            // TODO: This line of code loads data into the 'dataSet1.WAREHOUSEMAST' table. You can move, or remove it, as needed.
            this.wAREHOUSEMASTTableAdapter.Fill(this.dataSet1.WAREHOUSEMAST);
            invdate.EditValue = DateTime.Now;
        }
        private void c1TrueDBGrid2_DoubleClick(object sender, EventArgs e)
        {
           // AddItemsFromList();
        }
        private void c1TrueDBGrid2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // AddItemsFromList();
            }
        }
        void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            DataRow d = e.SelectedRow;
            AddItemsToList(d["sel"].ToString(), d);
        }
        void AddItemsToList(string selected, DataRow adr)
        {
                var  itemid =  adr["itemno"].ToString();
                var da = new DataSet1TableAdapters.GetItemBySupidTableAdapter();
                if (warehouse.EditValue != null)
                {
                    da.FillByWhid(this.dataSet1.GetItemBySupid, int.Parse(warehouse.EditValue.ToString()), itemid);
                }
                else
                {
                    da.FillByItemId(this.dataSet1.GetItemBySupid, itemid);
                }
                if (this.dataSet1.GetItemBySupid.Rows.Count == 0)
                {
                    XtraMessageBox.Show("This item has no stock", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (selected == bool.TrueString)
                {
                    foreach (DataRow d in this.dataSet1.GetItemBySupid)
                    {
                        var dr = dataSet1.ADJDETAIL.NewRow();
                        itemid = d["ITEMID"].ToString();
                        dr["STOCKID"] = d["STOCKID"];
                        dr["ITEMID"] = d["ITEMID"];
                        dr["ACTEXPDATE"] = d["EXPDATE"];
                        dr["ACTQTY"] = d["QTY"];
                        dr["ACTSPRICE"] = d["SPRICE"];
                        dr["ACTCPRICE"] = d["CPRICE"];
                        dr["MANBARCODE"] = d["BARCODE"];
                        dr["BARCODE"] = itemid; // d["BARCODE"];
                        dataSet1.ADJDETAIL.Rows.Add(dr);
                        textBox2.Text = d["ITEMNAME"].ToString();
                    }
                }
                else
                {
                    int i = 0;
                    foreach (DataRow d in dataSet1.PURINVDETAIL.Rows)
                    {

                        if (d.RowState != DataRowState.Deleted)
                            if (d["ITEMID"].ToString() == adr["itemno"].ToString())
                            {
                                dataSet1.ADJDETAIL.Rows.RemoveAt(i);
                                break;
                            }
                        i++;
                    }
                }
            //c1TrueDBGrid1.Focus();
        }
        #region doitems
        void DoNew()
        {
            isexpiry = false;
            isupdateall = false;
            isaddnew = true;
            ischangeorder = false;
        }
        void DoExpiry()
        {
            isexpiry = true;
            isupdateall = false;
            isaddnew = false;
            ischangeorder = false;
            expdate.Enabled = true;      
        }
        void EditAll()
        {
             isexpiry = false;
             isupdateall = true;
             isaddnew = false;
             ischangeorder = false;
             expdate.Enabled = true;
             cprice.Enabled = true;
             sprice.Enabled = true;
             qty.Enabled = true;
        }
        void DoChangeOrder()
        {
            isexpiry = false;
            isupdateall = false;
            isaddnew = false;
            ischangeorder = true;
        }
        void DoSave()
        {
            if (DoValidate())
            {
                UpdateGrid();
                if (isaddnew)
                {  AddNewRecord(); }
                var InsertQ = new DataSet1TableAdapters.ADJMASTTableAdapter();
                int purid = Convert.ToInt32(InsertQ.InsertQuery(COMMON.Utils.Userid,
                    int.Parse(warehouse.EditValue.ToString()),
                    isaddnew,
                    DateTime.Now,
                    int.Parse(c1TrueDBGrid1.Columns["itemid"].Value.ToString()),                           
                    reason.Text).ToString());
                foreach (DataRow d in this.dataSet1.ADJDETAIL.Rows)
                {
                    d["ADJID"] = purid;
                }
                this.aDJDETAILTableAdapter.Update(this.dataSet1.ADJDETAIL);
                UpdateStock();
            }
        }
        bool DoValidate()
        {
            bool ret =false;
            if (DateTime.Parse(expdate.EditValue.ToString()) < DateTime.Now)
            {
                XtraMessageBox.Show("Please check the expiry date", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ret=false;
            }
            return ret;
        }
        void UpdateGrid()
        {
            DateTime dtexp1 = DateTime.Parse(c1TrueDBGrid1.Columns["ACTEXPDATE"].Value.ToString());
            if(dtexp1!=DateTime.Parse(expdate.EditValue.ToString()))
            {
                c1TrueDBGrid1.Columns["ADJEXPDATE"].Value = expdate.EditValue;
            }
            decimal qty1 = decimal.Parse(c1TrueDBGrid1.Columns["ACTQTY"].Value.ToString());
            decimal qtya = qty.Value;
            if (qty1 != qtya)
            {
                c1TrueDBGrid1.Columns["ADJQTY"].Value = qtya;
            }
            decimal salep = decimal.Parse(c1TrueDBGrid1.Columns["ACTSPRICE"].Value.ToString());
            if (salep != decimal.Parse(sprice.EditValue.ToString()))
            {
                c1TrueDBGrid1.Columns["ADJSPRICE"].Value = qtya;
            }
            decimal costp = decimal.Parse(c1TrueDBGrid1.Columns["ACTCPRICE"].Value.ToString());
            if(costp!=decimal.Parse(cprice.EditValue.ToString()))
            {
                c1TrueDBGrid1.Columns["ADJCPRICE"].Value = qtya;
            }
            c1TrueDBGrid1.UpdateData();
        }
        void AddNewRecord()
        {}
        void UpdateStock()
        {
            var ta = new DataSet1TableAdapters.STOCKMASTERTableAdapter();
            ta.Fill(this.dataSet1.STOCKMASTER);
            foreach (DataRow d in this.dataSet1.ADJDETAIL)
            {
               var dr  =  this.dataSet1.STOCKMASTER.FindBySTOCKID(int.Parse(d["STOCKID"].ToString()));
               if (dr != null)
               {
                   if (!string.IsNullOrEmpty(d["ADJQTY"].ToString()))
                   {
                       dr["QTY"] = decimal.Parse(d["ADJQTY"].ToString());
                   }
                   if (!string.IsNullOrEmpty(d["ADJEXPDATE"].ToString()))
                   {
                       dr["EXPDATE"] = decimal.Parse(d["ADJEXPDATE"].ToString());
                   }
                   if (!string.IsNullOrEmpty(d["ADJSPRICE"].ToString()))
                   {
                       dr["SPRICE"] = decimal.Parse(d["ADJSPRICE"].ToString());
                   }
                   if (!string.IsNullOrEmpty(d["ADJSPRICE"].ToString()))
                   {
                       dr["CPRICE"] = decimal.Parse(d["ADJCPRICE"].ToString());
                   }
                   if (!string.IsNullOrEmpty(d["CHORDER"].ToString()))
                   {
                       dr["SALESORDER"] = decimal.Parse(d["CHORDER"].ToString());
                   }
                   ta.Update(this.dataSet1.STOCKMASTER);
               }
            }
        }
        void DoStock()
        {
            var f = new Stock();
            f.ShowDialog();
        }
        void DoDisplayItem()
        {
            Asprice = 0;
            Acpirce = 0;
            
            expdate.EditValue = c1TrueDBGrid1.Columns["ACTEXPDATE"].Value;
            qty.Value = decimal.Parse(c1TrueDBGrid1.Columns["ACTQTY"].Value.ToString());
            sprice.EditValue = c1TrueDBGrid1.Columns["ACTSPRICE"].Value.ToString();
            Asprice = (decimal) sprice.EditValue;
            cprice.EditValue = c1TrueDBGrid1.Columns["ACTCPRICE"].Value.ToString();
            Acpirce = (decimal)cprice.EditValue;
        }
        void AddItems()
        {
            if (warehouse.EditValue == null)
            {
                XtraMessageBox.Show("Please select the warehouse", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.dataSet1.ADJDETAIL.Rows.Count > 0)
            {
                foreach (DataRow d in this.dataSet1.ADJDETAIL.Rows)
                {
                    d.Delete();
                }
            }
            FrmItemLookUp frm = new FrmItemLookUp(dataSet1.PURINVDETAIL,string.Empty);
            frm.EventSelectedItem += AdditemsToList;
            frm.ShowDialog(); 
        }
        void DoToolBarButtons()
        {
            btnnew.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            toolStripButton5.Enabled = true;
        }
        #endregion
        private void InventoryAdjust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            { DoNew(); }
            if (e.KeyCode == Keys.F2)
            { DoExpiry(); }
            if (e.KeyCode == Keys.F3)
            { EditAll(); }
            if (e.KeyCode == Keys.F4)
            { DoChangeOrder(); }
            if (e.KeyCode == Keys.F6)
            {  DoSave();  }
            if (e.KeyCode == Keys.F10)
            {
                AddItems();
            }
        }
        private void warehouse_EditValueChanged(object sender, EventArgs e)
        {
            if (warehouse.EditValue != null)
            {    warehouse.Enabled = false;           }
            else
            {    warehouse.Enabled = true;            }
        }
        private void button1_Click(object sender, EventArgs e)
        { AddItems(); }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {           
           // DoShowItems();   
        }
        private void warehouse_Validating(object sender, CancelEventArgs e)
        {
            if (warehouse.EditValue != null)
            { warehouse.Enabled = false; }
            else
            { warehouse.Enabled = true; }
        }
        private void c1TrueDBGrid1_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            DoDisplayItem();
        }
        private void c1TrueDBGrid1_Click(object sender, EventArgs e)
        {
            DoDisplayItem();
        }
        private void c1TrueDBGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c1TrueDBGrid1.Splits[0].MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
                DoDisplayItem();
            }
        }
        private void sprice_EditValueChanged(object sender, EventArgs e)
        {
            if (decimal.Parse(sprice.EditValue.ToString()) < 0)
                sprice.EditValue = Asprice;
        }
        private void cprice_EditValueChanged(object sender, EventArgs e)
        {
            if (decimal.Parse(sprice.EditValue.ToString()) < 0)
                cprice.EditValue = Acpirce;
        }
    }
}
