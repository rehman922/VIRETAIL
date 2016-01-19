using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace Store
{
    public partial class ItemTransfer : DevExpress.XtraEditors.XtraForm
    {
        bool isselected = false;
        int purid = 0;
        bool ishold = false;
        bool issaved = true;
        public int whid = 0;
        public ItemTransfer()
        {
            InitializeComponent();
        }
        private void lookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }
        private void ItemTransfer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ITEMGROUP' table. You can move, or remove it, as needed.
            this.iTEMGROUPTableAdapter.Fill(this.dataSet1.ITEMGROUP);
            // TODO: This line of code loads data into the 'dataSet1.STOREMAST' table. You can move, or remove it, as needed.
            this.sTOREMASTTableAdapter.Fill(this.dataSet1.STOREMAST);
            // TODO: This line of code loads data into the 'dataSet1.STOREMAST' table. You can move, or remove it, as needed.
             
            // TODO: This line of code loads data into the 'dataSet1.ITEMMAST1' table. You can move, or remove it, as needed.
            this.iTEMMAST1TableAdapter.Fill(this.dataSet1.ITEMMAST1);
            // TODO: This line of code loads data into the 'dataSet1.ITEMTRANSFERDETAIL' table. You can move, or remove it, as needed.
            this.iTEMTRANSFERDETAILTableAdapter.Fill(this.dataSet1.ITEMTRANSFERDETAIL);
            // TODO: This line of code loads data into the 'dataSet1.STOREMAST' table. You can move, or remove it, as needed.
             
            // TODO: This line of code loads data into the 'dataSet1.WAREHOUSEMAST' table. You can move, or remove it, as needed.
            this.wAREHOUSEMASTTableAdapter.Fill(this.dataSet1.WAREHOUSEMAST);
            var dr = dataSet1.WAREHOUSEMAST.NewRow();
            dr["whid"]=0;
            dr["WHNAME"]="All";
            this.dataSet1.WAREHOUSEMAST.Rows.InsertAt(dr,0);
            invdate.EditValue = DateTime.Now;

        }
        #region  c1TrueDBGrid2
        private void c1TrueDBGrid2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (c1TrueDBGrid2.Columns[4].Value.ToString() == bool.TrueString)
                {
                    c1TrueDBGrid2.Columns[4].Value = false;
                    isselected = true;
                }
                else
                {
                    c1TrueDBGrid2.Columns[4].Value = true;
                    isselected = false;
                }
                AddItemsFromList();
            }
        }
        private void c1TrueDBGrid2_AfterColUpdate(object sender, C1.Win.C1TrueDBGrid.ColEventArgs e)
        {

            // if (e.ColIndex == 0)
            // {
            AddItemsFromList();
            // }
        }
        private void c1TrueDBGrid2_BeforeColUpdate(object sender, C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs e)
        {
            if (e.ColIndex == 0)
            {
                if (e.OldValue.ToString() == bool.TrueString)
                    isselected = true;
                else
                    isselected = false;
            }
        }
        private void c1TrueDBGrid2_DoubleClick(object sender, EventArgs e)
        {
            if (c1TrueDBGrid2.Columns[4].Value.ToString() == bool.TrueString)
            {
                c1TrueDBGrid2.Columns[4].Value = false;
                isselected = true;
            }
            else
            {
                c1TrueDBGrid2.Columns[4].Value = true;
                isselected = false;
            }
            AddItemsFromList();
        }
        #endregion
        #region c1truedbgrid1
        private void c1TrueDBGrid1_AfterColEdit(object sender, C1.Win.C1TrueDBGrid.ColEventArgs e)
        {
            if (e.ColIndex > 3 )
            {
                string cval = c1TrueDBGrid1.Columns[e.ColIndex].ToString();
                if (string.IsNullOrEmpty(cval))
                {
                    c1TrueDBGrid1.Columns[e.ColIndex].Value = 0;
                }
                if (!string.IsNullOrEmpty(c1TrueDBGrid1.Columns["QTY"].Value.ToString()))
                {
                    if (int.Parse(c1TrueDBGrid1.Columns["qty"].Value.ToString()) > int.Parse(c1TrueDBGrid1.Columns["Stock"].Value.ToString()))
                    {
                        c1TrueDBGrid1.Columns["qty"].Value = c1TrueDBGrid1.Columns["Stock"].Value;
                    }
                }
                if (!string.IsNullOrEmpty(c1TrueDBGrid1.Columns["QTY"].Value.ToString()) && !string.IsNullOrEmpty(c1TrueDBGrid1.Columns["SPRICE"].Value.ToString()))
                {
                    if (decimal.Parse(c1TrueDBGrid1.Columns["QTY"].Value.ToString()) > 0 && decimal.Parse(c1TrueDBGrid1.Columns["SPRICE"].Value.ToString()) > 0)
                        c1TrueDBGrid1.Columns["LINETOTAL"].Value = decimal.Parse(c1TrueDBGrid1.Columns["QTY"].Value.ToString()) * decimal.Parse(c1TrueDBGrid1.Columns["SPRICE"].Value.ToString());
                }
                c1TrueDBGrid1.Update();
            }
        }
        private void c1TrueDBGrid1_AfterColUpdate(object sender, C1.Win.C1TrueDBGrid.ColEventArgs e)
        {
            c1TrueDBGrid1.Update();
            Gtotal();
        }
        private void c1TrueDBGrid1_AfterUpdate(object sender, EventArgs e)
        {
            c1TrueDBGrid1.Update();
            Gtotal();
        }
        private void c1TrueDBGrid1_BeforeDelete(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete the selected  row..?", c1TrueDBGrid1.Columns["ITEMID"].Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { DeSelectFromList(); }
            else
            { e.Cancel = true; }
        }
        #endregion
        private void posMenu1_ToolbarClick(object sender, EventArgs e)
        {
            if (posMenu1.ToolClicked == "Save")
            {
                DoSave();
            }
            if (posMenu1.ToolClicked == "New")
            {
                DoNew();
            }
            if (posMenu1.ToolClicked == "Delete")
            {
                if (this.dataSet1.ITEMTRANSFERDETAIL.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show("Do you want to delete the selected  row..?", c1TrueDBGrid1.Columns["ITEMID"].Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeSelectFromList();
                        c1TrueDBGrid1.Delete();
                    }
                }
            }
            if (posMenu1.ToolClicked == "Notes")
            { DoNotes(); }
            if (posMenu1.ToolClicked == "Stock")
            {
                var f = new Stock();
                f.ShowDialog();
            }
        }
        #region do items
        void DoNotes()
        {
            string supid = "0";
            string supname = string.Empty;
            if (warehouse.EditValue != null)
            {
                supid = warehouse.EditValue.ToString();
                supname = warehouse.Text;
            }
            var f = new Notes(supid, supname, 3);
            f.ShowDialog();
        }
        void DoSave()
        {
            c1TrueDBGrid1.UpdateData();
            if (warehouse.EditValue == null)
            {
                XtraMessageBox.Show("Please select the from warehouse", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tostoreid.EditValue == null)
            {
                XtraMessageBox.Show("Please select the to store", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime dtinv = DateTime.Parse(invdate.EditValue.ToString());
            ArrayList Errorlist = new ArrayList();
            if (!ishold)
            {
                if (warehouse.EditValue == null)
                {
                    XtraMessageBox.Show("Please select the from warehouse", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (tostoreid.EditValue == null)
                {
                    XtraMessageBox.Show("Please select the to store", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                foreach (DataRow d in this.dataSet1.ITEMTRANSFERDETAIL)
                {
                    string t = "";
                    if (int.Parse(d["qty"].ToString()) > 0)
                    {
                        if (CheckStock(int.Parse(d["stockid"].ToString()), int.Parse(d["qty"].ToString())))
                        {
                            t = "Sufficent stock not found for item :" + GetItemname((d["ITEMID"].ToString()));
                            Errorlist.Add(t);
                        }
                    }
                    if (decimal.Parse(d["sprice"].ToString()) == 0)
                    {
                        t = "Sales price not found for item : " + GetItemname((d["ITEMID"].ToString()));
                        Errorlist.Add(t);
                    }
                }
            }
            if (Errorlist.Count > 0)
            {
                var f = new Testing(Errorlist);
                f.ShowDialog();
                return;
            }
            try
            {
                if (purid > 0)
                {
                    issaved = true;
                    var dr = this.dataSet1.ITEMTRANSFERMAIN.FindByTRANID(purid);
                    if (dr != null)
                    {
                        dr.BeginEdit();
                        dr.FRMSTOREID = int.Parse(warehouse.EditValue.ToString());
                        dr.TOSTOREID =tostoreid.EditValue.ToString();
                        dr.HOLD = ishold;
                        dr.EUSERID = COMMON.Utils.Userid;
                        dr.EDATE = DateTime.Now;
                        dr.TOTVALUE = decimal.Parse(netamt.EditValue.ToString());
                        dr.TOTITEMS = this.dataSet1.ITEMTRANSFERDETAIL.Rows.Count;
                        dr.EndEdit();
                        this.iTEMTRANSFERDETAILTableAdapter.Update(dr);
                    }
                }
                else
                {
                    var InsertQ = new DataSet1TableAdapters.ITEMTRANSFERMAINTableAdapter();
                    purid = Convert.ToInt32(InsertQ.InsertQuery(int.Parse(warehouse.EditValue.ToString()),
                        tostoreid.EditValue.ToString(),
                        DateTime.Today.Date,
                        COMMON.Utils.Userid,
                        DateTime.Now,
                        ishold,         
                        0,
                        null , decimal.Parse(netamt.EditValue.ToString()),this.dataSet1.ITEMTRANSFERDETAIL.Rows.Count).ToString());
                }
                if (purid > 0)
                {
                    textBox1.Text = purid.ToString();
                    issaved = true;
                    foreach (DataRow d in this.dataSet1.ITEMTRANSFERDETAIL)
                    {
                        d["TRANID"] = purid;
                    }
                    iTEMTRANSFERDETAILTableAdapter.Update(this.dataSet1.ITEMTRANSFERDETAIL);
                    if (ishold)
                    {
                        XtraMessageBox.Show("Invoice holded sucessfully", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        UpdateStock();
                        GenerateFiles();
                        XtraMessageBox.Show("Invoice recorded sucessfully", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.posMenu1.SaveButtonEnabled = false;
                }
                else
                {
                    XtraMessageBox.Show("Error while saving please try again", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        string GetItemname(string itemid)
        {
            DataRow dr = this.dataSet1.ITEMMAST1.FindByITEMNO(itemid);
            return dr[0].ToString();
        }
        void DoNew()
        {
            posMenu1.SaveButtonEnabled = true;
            if (purid == 0 && this.dataSet1.ITEMTRANSFERDETAIL.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Do you want to clear all", "P.O.S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clear();
                }
            }
            else
            {
                Clear();
            }
        }
        void Clear()
        {
            warehouse.EditValue = null;
            invdate.EditValue = null;
            purid = 0;
            tostoreid.EditValue = null;
            this.iTEMTRANSFERDETAILTableAdapter.Fill(this.dataSet1.ITEMTRANSFERDETAIL);
            invdate.EditValue = DateTime.Now;
            warehouse.Focus();
        }
        #endregion
        #region BLL
        void GenerateFiles()
        {
            var da1 = new DataSet1TableAdapters.ITEMTRANSFERMAINTableAdapter();
            var da2 = new DataSet1TableAdapters.ITEMTRANSFERDETAILTableAdapter();
            var ds = new DataSet();
            da1.FillByTranid(this.dataSet1.ITEMTRANSFERMAIN, purid);
            da2.FillByTranid(this.dataSet1.ITEMTRANSFERDETAIL, purid);
            
            string filename = Application.StartupPath + "\\ " + "HED" +  purid.ToString() + ".xml";
            string filename1 = Application.StartupPath + "\\" + "DET" + purid.ToString() + ".xml";

            this.dataSet1.ITEMTRANSFERMAIN.WriteXml(filename);
             this.dataSet1.ITEMTRANSFERDETAIL.WriteXml(filename1);
        }
        bool CheckStock(int stkid, int qty)
        {
            bool ret = false;
            var d = new DataSet1TableAdapters.GetItemBySupidTableAdapter();
            int q = (int)d.GetQtyByStkId(stkid);
            if (qty > q)
                ret = true;
            return ret;
        }
        void Gtotal()
        {
            decimal Ntot5 = 0m;
            foreach (DataRow d in this.dataSet1.ITEMTRANSFERDETAIL)
            {
                d["LINETOTAL"] = int.Parse(d["QTY"].ToString()) * decimal.Parse(d["invrate"].ToString());
                Ntot5 += decimal.Parse(d["LINETOTAL"].ToString());
            }
            if (Ntot5 > 0)
                netamt.EditValue = Ntot5;
            c1TrueDBGrid1.Refresh();
        }
        void DeSelectFromList()
        {
            foreach (DataRow d in this.dataSet1.ITEMMAST1)
            {
                if (c1TrueDBGrid1.Columns["ITEMID"].Value.ToString() == d["itemno"].ToString())
                {
                    if (GetTotalCount(c1TrueDBGrid1.Columns["ITEMID"].Value.ToString()) == 1)
                        d["SEL"] = false;
                }
            }
        }
        int GetTotalCount(string itemid)
        {
            int cnt = 0;
            foreach (DataRow d in this.dataSet1.RETURNDETAIL)
            {
                if (d["itemno"].ToString() == itemid)
                    cnt++;
            }
            return cnt;
        }
        void AddItemsFromList()
        {
            if (c1TrueDBGrid2.Columns[4].Value.ToString() == bool.TrueString)
            {
               var itemid = c1TrueDBGrid2.Columns["itemno"].Value.ToString();
                var da = new DataSet1TableAdapters.GetItemBySupidTableAdapter();
                if (warehouse.EditValue != null)
                {
                    da.FillByWhid(this.dataSet1.GetItemBySupid, int.Parse(warehouse.EditValue.ToString()), itemid);
                }
                else
                {
                    da.FillByItemId(this.dataSet1.GetItemBySupid, itemid);
                }
                foreach (var d in this.dataSet1.GetItemBySupid)
                {
                    var dr = dataSet1.ITEMTRANSFERDETAIL.NewRow();
                    dr["ITEMID"] = d["ITEMID"];
                    dr["BARCODE"] = d["BARCODE"];
                    dr["GROUPID"] = d["GROUPID"];
                    dr["STOCK"] = d["QTY"];
                    dr["INVRATE"] = d["INVRATE"];
                    dr["SPRICE"] = d["SPRICE"];
                    dr["CPRICE"] = d["CPRICE"];
                    dr["EXPDATE"] = d["EXPDATE"];
                    dr["STOCKID"] = d["STOCKID"];
                    dr["SUPID"] = d["SUPID"];
                    dataSet1.ITEMTRANSFERDETAIL.Rows.Add(dr);
                }
            }
            else if (isselected)
            {
                int i = 0;
                foreach (DataRow d in dataSet1.ITEMTRANSFERDETAIL.Rows)
                {

                    if (d.RowState != DataRowState.Deleted)
                        if (d["ITEMID"].ToString() == c1TrueDBGrid2.Columns["itemno"].Value.ToString())
                        {
                            dataSet1.ITEMTRANSFERDETAIL.Rows.RemoveAt(i);
                            break;
                        }
                    i++;
                }
            }
        }
        void UpdateStock()
        {
            var ta = new DataSet1TableAdapters.STOCKMASTERTableAdapter();
            ta.Fill(this.dataSet1.STOCKMASTER);
            foreach (DataRow d in this.dataSet1.ITEMTRANSFERDETAIL)
            {
                var dr = this.dataSet1.STOCKMASTER.FindBySTOCKID(int.Parse(d["STOCKID"].ToString()));
                if (dr != null)
                {
                    dr["QTY"] = decimal.Parse(dr["QTY"].ToString()) - decimal.Parse(d["QTY"].ToString());
                    ta.Update(this.dataSet1.STOCKMASTER);
                }
            }
        }
        #endregion

        private void ItemTransfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (warehouse.EditValue != null)
                {
                    groupControl1.Visible = true;
                }
                else
                {
                    XtraMessageBox.Show("Please select the warehouse", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupControl1.Visible = false;
        }

        private void posMenu1_ToolbarClick_1(object sender, EventArgs e)
        {
            if (posMenu1.ToolClicked == "Save")
                {    DoSave(); }
            if (posMenu1.ToolClicked == "New")
                {   DoNew();      }
            if (posMenu1.ToolClicked == "Delete")
            {
                if (this.dataSet1.RETURNDETAIL.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show("Do you want to delete the selected  row..?", c1TrueDBGrid1.Columns["ITEMID"].Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeSelectFromList();
                        c1TrueDBGrid1.Delete();
                    }
                }
            }
            if (posMenu1.ToolClicked == "Notes")
            {
                DoNotes(); 
            }
            if (posMenu1.ToolClicked == "Stock")
            {
                var f = new Stock();
                f.ShowDialog();
            }
        }
        private void c1TrueDBGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}