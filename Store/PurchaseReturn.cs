using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using BaseClasses;
namespace Store
{

    public partial class PurchaseReturn : BaseRibbonForm
    {
        bool isselected = false;
        int purid = 0;
        bool ishold = false;
        public int whid = 0;
        bool issaved = false;
        public PurchaseReturn()
        {
            InitializeComponent();
        }
      
        private void lookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {  }
        private void PurchaseReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ITEMGROUP' table. You can move, or remove it, as needed.
            this.iTEMGROUPTableAdapter.Fill(this.dataSet1.ITEMGROUP);
            // TODO: This line of code loads data into the 'dataSet1.WAREHOUSEMAST' table. You can move, or remove it, as needed.
            this.wAREHOUSEMASTTableAdapter.Fill(this.dataSet1.WAREHOUSEMAST);
            // TODO: This line of code loads data into the 'dataSet1.ITEMMAST1' table. You can move, or remove it, as needed.
            this.iTEMMAST1TableAdapter.Fill(this.dataSet1.ITEMMAST1);
            // TODO: This line of code loads data into the 'dataSet1.RETURNDETAIL' table. You can move, or remove it, as needed.
            this.rETURNDETAILTableAdapter.Fill(this.dataSet1.RETURNDETAIL);
            // TODO: This line of code loads data into the 'dataSet1.SUPPLIER' table. You can move, or remove it, as needed.
            this.sUPPLIERTableAdapter.Fill(this.dataSet1.SUPPLIER);
            invdate.EditValue = DateTime.Now;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
      /*  #region  c1TrueDBGrid2
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
        private void c1TrueDBGrid2_Click(object sender, EventArgs e)
        {
        }
        private void c1TrueDBGrid2_MouseDoubleClick(object sender, MouseEventArgs e)
        {  
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
       */
        #region c1truedbgrid1
        private void c1TrueDBGrid1_AfterColEdit(object sender, C1.Win.C1TrueDBGrid.ColEventArgs e)
        {
            if (e.ColIndex > 3)
            {
                string cval = c1TrueDBGrid1.Columns[e.ColIndex].ToString();
                if (string.IsNullOrEmpty(cval))
                {
                    c1TrueDBGrid1.Columns[e.ColIndex].Value = 0;
                }
                if (int.Parse(c1TrueDBGrid1.Columns["itemtypeid"].Value.ToString()) == 1)
                {
                    if (!string.IsNullOrEmpty(c1TrueDBGrid1.Columns["INVRATE"].Value.ToString()))
                        if (decimal.Parse(c1TrueDBGrid1.Columns["SPRICE"].Value.ToString()) > 0)
                        { }
                        else
                        { c1TrueDBGrid1.Columns["SPRICE"].Value = c1TrueDBGrid1.Columns["INVRATE"].Value; }
                }
                c1TrueDBGrid1.Update();
                if(!string.IsNullOrEmpty(c1TrueDBGrid1.Columns["QTY"].Value.ToString()))
                {
                    if (int.Parse(c1TrueDBGrid1.Columns["qty"].Value.ToString()) > int.Parse(c1TrueDBGrid1.Columns["Stock"].Value.ToString()))
                    {
                        c1TrueDBGrid1.Columns["qty"].Value = c1TrueDBGrid1.Columns["Stock"].Value;
                    }
                }
                if (!string.IsNullOrEmpty(c1TrueDBGrid1.Columns["BONUSQTY"].Value.ToString()) && !string.IsNullOrEmpty(c1TrueDBGrid1.Columns["QTY"].Value.ToString()))
                {
                    int reqty  = int.Parse(c1TrueDBGrid1.Columns["BONUSQTY"].Value.ToString()) + int.Parse(c1TrueDBGrid1.Columns["QTY"].Value.ToString());
                    if (reqty > int.Parse(c1TrueDBGrid1.Columns["Stock"].Value.ToString()))
                    {
                        c1TrueDBGrid1.Columns["BONUSQTY"].Value =0;
                    }
                }
                if (!string.IsNullOrEmpty(c1TrueDBGrid1.Columns["QTY"].Value.ToString()) && !string.IsNullOrEmpty(c1TrueDBGrid1.Columns["INVRATE"].Value.ToString()))
                {
                    if (decimal.Parse(c1TrueDBGrid1.Columns["QTY"].Value.ToString()) > 0 && decimal.Parse(c1TrueDBGrid1.Columns["INVRATE"].Value.ToString()) > 0)
                        c1TrueDBGrid1.Columns["LINETOTAL"].Value = decimal.Parse(c1TrueDBGrid1.Columns["QTY"].Value.ToString()) * decimal.Parse(c1TrueDBGrid1.Columns["INVRATE"].Value.ToString());
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
        private void c1TrueDBGrid1_BeforeColUpdate(object sender, C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs e)
        {
            if (e.ColIndex == 5 || e.ColIndex == 6 || e.ColIndex == 7 || e.ColIndex == 8 || e.ColIndex == 9)
            {
                if (string.IsNullOrEmpty(c1TrueDBGrid1.Columns[e.Column.Name].Value.ToString()))
                {
                    c1TrueDBGrid1.Columns[e.Column.Name].Value = 0;
                }
            }
            if (e.ColIndex == 10)
            {
                try
                {
                    string[] split = c1TrueDBGrid1.Columns["Exp.Dt"].Value.ToString().Split(new Char[] { '-' });
                    if (c1TrueDBGrid1.Columns["Exp.Dt"].Value.ToString().Length < 4)
                    {
                        XtraMessageBox.Show("Please enter the valid date", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    DateTime d1 =DateTime.Now;
                    if(int.Parse(split[1]) < 2000)
                         d1 = new DateTime(2000 + int.Parse(split[1]), int.Parse(split[0]), 1);
                    else
                        d1 = new DateTime(int.Parse(split[1]), int.Parse(split[0]), 1);
                    c1TrueDBGrid1.Columns["Exp.Dt"].Value = d1;
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Please check the expiry date", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
        private void c1TrueDBGrid1_BeforeDelete(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete the selected  row..?", c1TrueDBGrid1.Columns["ITEMID"].Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {   DeSelectFromList();}
            else
            { e.Cancel = true; }
        }
        #endregion
        private void PurchaseReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (warehouse.EditValue != null)
                {
                    if (e.KeyCode == Keys.F10)
                    {
                        AddItems();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Please select the warehouse", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void AddItems()
        {
            FrmItemLookUp frm = new FrmItemLookUp(dataSet1.PURINVDETAIL,string.Empty);
            //  frm.Itemadded += new RefershGrid(AdditemsToList);
            frm.EventSelectedItem += AdditemsToList;
            frm.ShowDialog();
        }
        void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            DataRow d = e.SelectedRow;
            AddItemsToList(d["sel"].ToString(), d);
        }
        private void warehouse_EditValueChanged(object sender, EventArgs e)
        {
            if (warehouse.EditValue != null)
                warehouse.Enabled = false;
        }
        private void c1TrueDBGrid1_Click(object sender, EventArgs e)
        { }
        #region BLL
        bool CheckStock(int stkid,int qty)
        {
            bool ret = false;
            var d = new DataSet1TableAdapters.GetItemBySupidTableAdapter();
            int q = (int) d.GetQtyByStkId(stkid);
            if (qty > q)
                ret = true;
            return ret;
        }
        void Gtotal()
        {
           
             
            int Tctr = 0;
            decimal Tvalue = 0m;
            decimal Ntot1 = 0m;
            decimal Ntot2 = 0m;
            decimal Ntot3 = 0m;
            decimal Ntot4 = 0m;
            decimal Ntot5 = 0m;
            decimal Dval = 0m;
            decimal Dval1 = 0m;
            decimal dval2 = 0m;
            decimal Dis1 = 0m;
            decimal Dis2 = 0m;
            decimal Tcost1 = 0m;
            decimal Tcost2 = 0m;
            decimal Tsale1 = 0m;
            decimal Tsale2 = 0m;
            decimal Gcost = 0m;
            decimal Gsale = 0m;
            decimal Tgdis = 0m;
            foreach (DataRow d in this.dataSet1.RETURNDETAIL)
            {
                
                if (string.IsNullOrEmpty(d["BONUSQTY"].ToString()))
                {
                    d["BONUSQTY"] = 0;
                }
                if (int.Parse(d["QTY"].ToString()) > 0 || int.Parse(d["BONUSQTY"].ToString()) > 0)
                {
                    Tctr++;
                }
                d["LINETOTAL"] = int.Parse(d["QTY"].ToString()) * decimal.Parse(d["invrate"].ToString());
                Tvalue += decimal.Parse(d["LINETOTAL"].ToString());

                Dval1 = decimal.Parse(d["disc"].ToString());
                Dval = decimal.Parse(d["qty"].ToString());
                dval2 = decimal.Parse(d["invrate"].ToString());
                Dis1 = (Dval * dval2) * Dval1 / 100;
                Dis2 += Dis1 + Dis1;
                Gcost = decimal.Parse(d["cprice"].ToString());
                Tcost1 = (int.Parse(d["QTY"].ToString()) + int.Parse(d["BONUSQTY"].ToString())) * Gcost;
                Tcost2 = Tcost2 + Tcost1;
                Gsale = decimal.Parse(d["sprice"].ToString());
                Tsale1 = (int.Parse(d["QTY"].ToString()) + int.Parse(d["BONUSQTY"].ToString())) * Gsale;
                Tsale2 = Tsale2 + Tsale1;
            }
            // this.dataSet1.PURINVDETAIL.AcceptChanges();
            if (Tvalue > 0)
                totvalue.EditValue = Tvalue;
            else
                totvalue.EditValue = 0;
            if (Dis2 > 0)
                totdisc.EditValue = Dis2;
            else
                totdisc.EditValue = 0;
            Tgdis = (Tvalue - Dis2) * decimal.Parse(spdisc.EditValue.ToString()) / 100;
            specdisc.EditValue = Tgdis;

            if (decimal.Parse(totdisc.EditValue.ToString()) > 0)
                Ntot1 = Dis2;
            else
                Ntot1 = 0;
            if (decimal.Parse(specdisc.EditValue.ToString()) > 0)
                Ntot2 = Tgdis;
            else
                Ntot2 = 0;
            if (decimal.Parse(adjustval.EditValue.ToString()) > 0)
                Ntot3 = (decimal)adjustval.EditValue;
            else
                Ntot3 = 0;
            if (decimal.Parse(totvalue.EditValue.ToString()) > 0)
                Ntot4 = decimal.Parse(totvalue.EditValue.ToString()) - decimal.Parse(totdisc.EditValue.ToString()) - decimal.Parse(specdisc.EditValue.ToString());
            Ntot5 = Ntot4 + Ntot3;
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
                    if(GetTotalCount(c1TrueDBGrid1.Columns["ITEMID"].Value.ToString()) ==1 )
                            d["SEL"] = false;
                }
            }
        }
        int GetTotalCount(string itemid)
        {
            int cnt=0;
            foreach (DataRow d in this.dataSet1.RETURNDETAIL)
            {
                if (d["itemid"].ToString() == itemid)
                    cnt++;
            }
            return cnt;
        }
        void AddItemsToList(string selected, DataRow adr)
        {
            if (selected == bool.TrueString)
            {
                var itemid = adr["itemno"].ToString();
                var da = new DataSet1TableAdapters.GetItemBySupidTableAdapter();
                if (supplier.EditValue != null)
                {
                    da.FillBySuPandWhid(this.dataSet1.GetItemBySupid, int.Parse(warehouse.EditValue.ToString()), itemid, supplier.EditValue.ToString());
                }
                else
                {
                    da.FillByWhid(this.dataSet1.GetItemBySupid, int.Parse(warehouse.EditValue.ToString()), itemid);
                }
                foreach (DataRow d in this.dataSet1.GetItemBySupid)
                {
                    var dr = dataSet1.RETURNDETAIL.NewRow();
                    dr["ITEMID"] = d["ITEMID"];
                    dr["BARCODE"] = d["BARCODE"];
                    dr["ITEMTYPEID"] = d["ITEMTYPEID"];
                    dr["DISC"] = d["DISC"];
                    //if (d["itemtypeid"].ToString() == "1")
                    //   { 
                    //    //dr["DISC"] = 14.5;  
                    //       dr["DISC"] = c1TrueDBGrid2.Columns["DISCOUNT"].Value;
                    //   }
                    dr["STOCK"] = d["QTY"];
                    dr["INVRATE"] = d["INVRATE"];
                    dr["SPRICE"] = d["SPRICE"];
                    dr["CPRICE"] = d["CPRICE"];
                    dr["EXPDATE"] = d["EXPDATE"];
                    dr["STOCKID"] = d["STOCKID"];
                    dataSet1.RETURNDETAIL.Rows.Add(dr);
                }
            }
            else if (isselected)
            {
                int i = 0;
                foreach (DataRow d in dataSet1.RETURNDETAIL.Rows)
                {

                    if (d.RowState != DataRowState.Deleted)
                        if (d["ITEMID"].ToString() == adr["itemno"].ToString())
                        {
                            dataSet1.RETURNDETAIL.Rows.RemoveAt(i);
                            break;
                        }
                    i++;
                }
            }
        }
        #endregion
        private void posMenu1_ToolbarClick(object sender, EventArgs e)
        {
            //if (posMenu1.ToolClicked == "Save")
            //{
            //    DoSave();
            //}
            //if (posMenu1.ToolClicked == "New")
            //{
            //    DoNew();
            //}
            //if (posMenu1.ToolClicked == "Delete")
            //{
            //    if (this.dataSet1.RETURNDETAIL.Rows.Count > 0)
            //    {
            //        if (XtraMessageBox.Show("Do you want to delete the selected  row..?", c1TrueDBGrid1.Columns["ITEMID"].Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            DeSelectFromList();
            //            c1TrueDBGrid1.Delete();
            //        }
            //    }
            //}
            //if (posMenu1.ToolClicked == "Hold")
            //{   DoHold(); }
            //if (posMenu1.ToolClicked == "Analyse")
            //{
            //    DoAnalyse();
            //    ishold = true;
            //}
            //if (posMenu1.ToolClicked == "Notes")
            //{   DoNotes(); }
            //if (posMenu1.ToolClicked == "Document")
            //{
            //    var f = new Stock();
            //    f.ShowDialog();
            //}
        }
        #region do items
        private void DoNotes()
        {
            string supid = "0";
            string supname = string.Empty;
            if (supplier.EditValue != null)
            {
                supid = supplier.EditValue.ToString();
                supname = supplier.Text;
            }
            var f = new Notes(supid, supname,"RP");
            f.ShowDialog();
        }
        private void DoHold()
        {
            ishold = true;
            DoSave();
        }
        private void DoAnalyse()
        {
            string itemid = c1TrueDBGrid1.Columns["Item Name"].Value.ToString();
            if (!string.IsNullOrEmpty(itemid))
            {
                string itemnm = c1TrueDBGrid1.Columns["Item Name"].Text;
                var f = new Puranalyse(itemid, itemnm);
                f.ShowDialog();
            }
        }
        void DoSave()
        {
            c1TrueDBGrid1.UpdateData();
            if (supplier.EditValue == null)
            {
                ishold = false;
                XtraMessageBox.Show("Please select the supplier", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (warehouse.EditValue == null)
            {
                ishold = false;
                XtraMessageBox.Show("Please select  the warehouse name", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime? dtinv = null;
            if (invdate.EditValue == null)
                dtinv = null;
            else
                dtinv = (DateTime?)invdate.EditValue;
            ArrayList Errorlist = new ArrayList();
            string Inv = "";
            if (invno.EditValue == null)
                Inv = string.Empty;
            else
                Inv = (string)invno.EditValue;
            if (!ishold)
            {
                if (invno.EditValue == null)
                {
                    XtraMessageBox.Show("Please enter the invoice no", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (invdate.EditValue == null)
                {
                    XtraMessageBox.Show("Please enter the invoice date", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DataRow d in this.dataSet1.RETURNDETAIL)
                {
                    string t = "";
                    if (int.Parse(d["qty"].ToString()) == 0)
                    {
                        t = "Quantity not found for item :" + GetItemname(d["ITEMID"].ToString());
                        Errorlist.Add(t);
                    }
                    if (string.IsNullOrEmpty(d["bonusqty"].ToString()))
                    {
                        d["bonusqty"] = 0;
                    }
                    if (int.Parse(d["qty"].ToString()) > 0)
                    {
                        if (int.Parse(d["bonusqty"].ToString()) == 0)
                        {
                                if (CheckStock(int.Parse(d["stockid"].ToString()), int.Parse(d["qty"].ToString())))
                                {
                                    t = "Sufficent stock not found for item :" + GetItemname(d["ITEMID"].ToString());
                                    Errorlist.Add(t);
                                }
                        }
                        else if(int.Parse(d["bonusqty"].ToString())> 0) 
                        {
                            if (CheckStock(int.Parse(d["stockid"].ToString()), (int.Parse(d["qty"].ToString())) + int.Parse(d["bonusqty"].ToString())))
                            {
                                t = "Sufficent stock not found for item :" + GetItemname(d["ITEMID"].ToString());
                                Errorlist.Add(t);
                            }
                        }
                    }
                    if (decimal.Parse(d["invrate"].ToString()) == 0)
                    {
                        t = "Inv.Rate not found for item :" + GetItemname((d["ITEMID"].ToString()));
                        Errorlist.Add(t);
                    }
                    if (decimal.Parse(d["sprice"].ToString()) == 0)
                    {
                        t = "Sales price not found for item : " + GetItemname(d["ITEMID"].ToString());
                        Errorlist.Add(t);
                    }
                }
            }
            if (invno.EditValue != null)
            {
                int t = 0;
                var ta = new DataSet1TableAdapters.RETURNMASTTableAdapter();
                if (purid > 0)
                {
                    t = (int)ta.GetInvoiceCountWithHold(supplier.EditValue.ToString(), invno.EditValue.ToString(), purid);
                }
                else
                {
                    t = (int)ta.GetInvoiceCount(supplier.EditValue.ToString(), invno.EditValue.ToString());
                }
                if (t > 0)
                {
                    XtraMessageBox.Show("Duplicate invoice no found..!,please check the invoice no", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (Errorlist.Count > 0)
            {
                var f = new Testing(Errorlist);
                f.ShowDialog();
                return;
            }
            if (warehouse.EditValue == null)
                whid = 0;
            else
                whid = int.Parse(warehouse.EditValue.ToString());
            try
            {
                if (purid > 0)
                {
                    issaved = true;
                    var dr = this.dataSet1.RETURNMAST.FindByRETURNID(purid);
                    if (dr != null)
                    {
                        dr.BeginEdit();
                        dr.SUPID = supplier.EditValue.ToString();
                        dr.SUPNAME = supplier.Text;
                        dr.INVNO = Inv;
                        if (dtinv == null)
                            dr["INVDATE"] = DBNull.Value;
                        else
                            dr["INVDATE"] = dtinv;
                        dr.SPDISCOUNT = decimal.Parse(spdisc.EditValue.ToString());
                        dr.ADJVALUE = decimal.Parse(adjustval.EditValue.ToString());
                        dr.HOLD = ishold;
                        dr.WHID = whid;
                        dr.EUSERID = COMMON.Utils.Userid; 
                        dr.EDATE = DateTime.Now;
                        dr.EndEdit();
                        this.rETURNDETAILTableAdapter.Update(dr);
                    }
                }
                else
                {
                    var InsertQ = new DataSet1TableAdapters.RETURNMASTTableAdapter();
                    purid = Convert.ToInt32(InsertQ.InsertQuery(DateTime.Today.Date,
                        supplier.EditValue.ToString(),
                        supplier.Text,
                        Inv,
                        dtinv,
                        decimal.Parse(spdisc.EditValue.ToString()),
                        decimal.Parse(adjustval.EditValue.ToString()),
                        decimal.Parse(netamt.EditValue.ToString()),
                        ishold,
                        whid,
                        COMMON.Utils.Userid,
                        DateTime.Now).ToString()); 
                }
                if (purid > 0)
                {
                    purno.EditValue = purid;
                    issaved = true;
                    foreach (DataRow d in this.dataSet1.RETURNDETAIL)
                    {
                        d["RETURNID"] = purid;
                    }
                    rETURNDETAILTableAdapter.Update(this.dataSet1.RETURNDETAIL);
                    if (ishold)
                    {
                        XtraMessageBox.Show("Invoice holded sucessfully", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        UpdateStock();
                        XtraMessageBox.Show("Invoice recorded sucessfully", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                  //  this.posMenu1.SaveButtonEnabled = false;
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
        void UpdateStock()
        {
            var ta = new DataSet1TableAdapters.STOCKMASTERTableAdapter();
            ta.Fill(this.dataSet1.STOCKMASTER);
            foreach (DataRow d in this.dataSet1.RETURNDETAIL)
            {
               var dr  =  this.dataSet1.STOCKMASTER.FindBySTOCKID(int.Parse(d["STOCKID"].ToString()));
              // var d1 = this.dataSet1.STOCKMASTER.Rows.Find(int.Parse(d["STOCKID"].ToString()));
               if (dr != null)
               {
                   dr["QTY"] = decimal.Parse(dr["QTY"].ToString()) - decimal.Parse(d["QTY"].ToString()) + decimal.Parse(d["BONUSQTY"].ToString());
                   ta.Update(this.dataSet1.STOCKMASTER);
               }
                //foreach(DataRow dr in this.dataSet1.STOCKMASTER)
                //{
                //    dr["QTY"] =  decimal.Parse(dr["QTY"].ToString()) -  decimal.Parse(d["QTY"].ToString()) + decimal.Parse(d["BONUSQTY"].ToString());
                //   ta.Update(this.dataSet1.STOCKMASTER);
                //}
            }
           // this.stockmasterTableAdapter1.Update(this.dataSet1.STOCKMASTER);
        }
        void DoNew()
        {
           // posMenu1.SaveButtonEnabled = true;
            if (purid == 0 && this.dataSet1.RETURNDETAIL.Rows.Count > 0)
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
            supplier.EditValue = null;
            invdate.EditValue = null;
            purno.EditValue = null;
            purid = 0;
            invno.EditValue = null;
            warehouse.EditValue = null;
            this.rETURNDETAILTableAdapter.Fill(this.dataSet1.RETURNDETAIL);
            this.iTEMMAST1TableAdapter.Fill(this.dataSet1.ITEMMAST1);
            invdate.EditValue = DateTime.Now;
            warehouse.Enabled = true;
            supplier.Focus();
        }
        void DoViewData()
        {
            this.rETURNDETAILTableAdapter.FillByPurid(this.dataSet1.RETURNDETAIL, purid);
       //   this.pURINVDETAILTableAdapter.FillByPurid(this.dataSet1.PURINVDETAIL, purid);
            Gtotal();
            issaved = false;
            ishold = true;
            foreach (DataRow d in this.dataSet1.RETURNMAST.Rows)
            {

                supplier.EditValue = d["SUPID"].ToString();
                invno.EditValue = d["INVNO"].ToString();
                invdate.EditValue = d["INVDATE"].ToString();
                spdisc.EditValue = d["SPDISCOUNT"].ToString();
                adjustval.EditValue = d["ADJVALUE"].ToString();
                if (!string.IsNullOrEmpty(d["WHID"].ToString()))
                {
                    warehouse.EditValue = int.Parse(d["WHID"].ToString());
                }

            }
        }
#endregion
        private void supplier_EditValueChanged(object sender, EventArgs e)
        {
               
                if (supplier.EditValue != null)
                {
                    var f = new Notes();
                    if (f.CheckNotesAvailable(supplier.EditValue.ToString(), "PO"))
                    {
                        var f1 = new Notes(supplier.EditValue.ToString(), supplier.Text, "PO");
                        f1.ShowDialog();
                    }
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

       
      
    }
}
