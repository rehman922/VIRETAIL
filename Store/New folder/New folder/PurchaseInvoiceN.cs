using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
//using DevExpress.XtraGrid.Views.BandedGrid;
 
namespace Store
{
    //public delegate Additems(DataRow d)
    public delegate void RefershGrid1(DataRow d);
    public partial class PurchaseInvoiceN :DevExpress.XtraEditors.XtraForm
    {
        bool isselected = false;
        int purid = 0;
        bool ishold = false;
        public int whid = 0;
        bool issaved = false;
        public PurchaseInvoiceN()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void PurchaseInvoice_Resize(object sender, EventArgs e)
        {
            //itemname always occupy 60
            //under allotment - storename
            //under sales price - costprice
            //under value -gross value 340


           // c1TrueDBGrid1.Top = 127;
           // c1TrueDBGrid1.Left = 4;

           // c1TrueDBGrid1.Width = this.Width - 20;
            int _totcolwidth = c1TrueDBGrid1.Splits[0].DisplayColumns[4].Width + c1TrueDBGrid1.Splits[0].DisplayColumns[5].Width + c1TrueDBGrid1.Splits[0].DisplayColumns[6].Width + c1TrueDBGrid1.Splits[0].DisplayColumns[7].Width + c1TrueDBGrid1.Splits[0].DisplayColumns[8].Width + c1TrueDBGrid1.Splits[0].DisplayColumns[9].Width;

            c1TrueDBGrid1.Splits[0].DisplayColumns[13].Width = c1TrueDBGrid1.Splits[0].DisplayColumns[1].Width;
            c1TrueDBGrid1.Splits[0].DisplayColumns[14].Width = c1TrueDBGrid1.Splits[0].DisplayColumns[3].Width;
            c1TrueDBGrid1.Splits[0].DisplayColumns[15].Width = _totcolwidth;
            c1TrueDBGrid1.Splits[0].DisplayColumns[16].Width = c1TrueDBGrid1.Splits[0].DisplayColumns[10].Width;
            c1TrueDBGrid1.Splits[0].DisplayColumns[17].Width = c1TrueDBGrid1.Splits[0].DisplayColumns[11].Width;
            c1TrueDBGrid1.Splits[0].DisplayColumns[18].Width = c1TrueDBGrid1.Splits[0].DisplayColumns[12].Width;
            // this.c1TrueDBGrid1.Height = this.Height - (panel2.Height + panel1.Height + posMenu1.Height + 70);
            // int _width = this.c1TrueDBGrid1.Width - 20;
            // //int _totcolwidth = 0;
            // //int _balwidth = 0;
            // c1TrueDBGrid1.Splits[0].DisplayColumns["SNAME"].Width = c1TrueDBGrid1.Splits[0].DisplayColumns["Allotment"].Width +c1TrueDBGrid1.Splits[0].DisplayColumns["QTY"].Width+c1TrueDBGrid1.Splits[0].DisplayColumns["BONUSQTY"].Width
            //     + c1TrueDBGrid1.Splits[0].DisplayColumns["INVRATE"].Width + c1TrueDBGrid1.Splits[0].DisplayColumns["DISC"].Width + c1TrueDBGrid1.Splits[0].DisplayColumns["SPDISC"].Width;
            //c1TrueDBGrid1.Splits[0].DisplayColumns["Item Type"].Width =c1TrueDBGrid1.Splits[0].DisplayColumns["Item Name"].Width -c1TrueDBGrid1.Splits[0].DisplayColumns["Barcode"].Width;
            /*
           _totcolwidth  = colSTOREID.Width +colQTY.Width + colBONUSQTY.Width + colINVRATE.Width + colDISC.Width + colSPDISC.Width + colSPRICE.Width + colEXPDATE.Width + colLINETOTAL.Width;
           _balwidth = this.Width - _totcolwidth;
            colITEMID.Width = this.Width - _balwidth;
            colBARCODE.Width =   (this.Width - _balwidth)/2;
            colITEMTYPEID.Width = (this.Width - _balwidth)/2;
            bandedGridColumn1.Width = colSTOREID.Width + colQTY.Width + colBONUSQTY.Width + colINVRATE.Width + colDISC.Width + colSPDISC.Width;
            colCPRICE.Width = colSPRICE.Width + colEXPDATE.Width;
            gridBand1.Width = gridControl1.Width - 20;
            */
        }
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            //this.Text = "Item Receipt";
            this.wAREHOUSEMASTTableAdapter.Fill(this.dataSet1.WAREHOUSEMAST);
            this.pURINVDETAILTableAdapter1.Fill(this.dataSet1.PURINVDETAIL);
            this.sTOREMASTTableAdapter.Fill(this.dataSet1.STOREMAST);
            this.iTEMGROUPTableAdapter.Fill(this.dataSet1.ITEMGROUP);
            this.iTEMMAST1TableAdapter.Fill(this.dataSet1.ITEMMAST1);
         //   this.sUPPLIERTableAdapter.Fill(this.dataSet1.SUPPLIER);
            comboBox1.SelectedIndex = 0;
            //var ds = new DataSet1();
            //var t = new DataSet1TableAdapters.PURINVMAINTableAdapter();
           // var dt = t.FillByHold(ds.PURINVMAIN);
            this.purinvmainTableAdapter1.FillByHold(this.dataSet1.PURINVMAIN);             
           
            if (this.dataSet1.PURINVMAIN.Rows.Count > 0)
            {
                var f = new HoldPurchase();
                f.ShowDialog();
                if (Utils.purid > 0)
                {
                    purid = Utils.purid;
                    DoViewData();
                }
            }
            invdate.EditValue = DateTime.Now;
        }
        /*
        internal void BestFitBands(AdvBandedGridView view)
        {
            view.BeginUpdate();
            view.OptionsView.ShowColumnHeaders = true;
            foreach (BandedGridColumn col in view.Columns)
                col.Caption = col.OwnerBand.Caption;
            view.BestFitColumns();
            //view.OptionsView.ShowColumnHeaders = false;
            view.EndUpdate();
        }
        */
        private void PurchaseInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {   AddItems(); }
            if (e.KeyCode == Keys.F5)
            {
                     ItemClone();  
            }
        }
        private void c1TrueDBDropdown3_DropDownClose(object sender, EventArgs e)
        {
            //c1TrueDBGrid1.Columns[10].Value = 10;
        //    c1TrueDBGrid1.Columns["SNAME"].Value = c1TrueDBDropdown3.Columns[1].Value;
            //c1TrueDBGrid1.Columns[15].Value = 10;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());
            if (comboBox1.SelectedIndex.ToString() == "1")
            {
                c1TrueDBGrid1.Splits[0].DisplayColumns[3].AllowFocus = true;
                lookUpEdit1.Enabled = true;
            }
            else
            {
                c1TrueDBGrid1.Splits[0].DisplayColumns[3].AllowFocus = false;
                lookUpEdit1.Enabled = false;
            }
        }
        private void totsalvalue_EditValueChanged(object sender, EventArgs e)
        {
            totprofit.EditValue = decimal.Parse(totsalvalue.EditValue.ToString()) - decimal.Parse(totcostvalue.EditValue.ToString());
        }
        private void adjustval_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void adjustval_Validating(object sender, CancelEventArgs e)
        {
            netamt.EditValue = decimal.Parse(netamt.EditValue.ToString()) + decimal.Parse(adjustval.EditValue.ToString());
 
        }
        private void adjustval_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            netamt.EditValue = decimal.Parse(netamt.EditValue.ToString()) + decimal.Parse(adjustval.EditValue.ToString());
       }
        #region toolbar 
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
            //    DeleteItem();
            //}
            //if (posMenu1.ToolClicked == "Hold")
            //{
            //    DoHold();
                
            //}
            //if (posMenu1.ToolClicked == "Analyse")
            //{
            //    DoAnalyse();
            //    ishold = true;
            //}
            //if (posMenu1.ToolClicked == "Notes")
            //{
            //    DoNotes();
            //}
        }
        #endregion
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
            var f = new Notes(supid,supname,"PO");
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
            if(!string.IsNullOrEmpty(itemid))
            { 
                string itemnm = c1TrueDBGrid1.Columns["Item Name"].Text;
                var f = new Puranalyse(int.Parse(itemid), itemnm);
                f.ShowDialog();

            }
        }
        void DoSave()
        {
            c1TrueDBGrid1.UpdateData();
            if (supplier.EditValue==null)
            {
                ishold = false;
                XtraMessageBox.Show("Please select the supplier","P.O.S",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (warehouse.EditValue == null)
            {
                ishold = false;
                XtraMessageBox.Show("Please select  the warehouse name", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime? dtinv = null;
            if (invdate.EditValue == null || invdate.EditValue.ToString()==string.Empty)
                dtinv = null;
            else
                dtinv = (DateTime?)invdate.EditValue;
            ArrayList Errorlist = new ArrayList();
            string Inv="";
            if (invno.EditValue == null) 
                 Inv=string.Empty;
             else
                Inv = (string)invno.EditValue;
            if (!ishold)
            {
                if (invno.EditValue==null)
                {
                    XtraMessageBox.Show("Please enter the invoice no", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (invdate.EditValue == null) 
                {
                    XtraMessageBox.Show("Please enter the invoice date", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            
                foreach (DataRow d in this.dataSet1.PURINVDETAIL)
                {

                    string t = "";
                    if (int.Parse(d["qty"].ToString()) == 0)
                    {
                        t = "Quantity not found for item :" + GetItemname(int.Parse(d["ITEMID"].ToString()));
                        Errorlist.Add(t);
                    }
                    if (decimal.Parse(d["invrate"].ToString()) == 0)
                    {
                        t = "Inv.Rate not found for item :" + GetItemname(int.Parse(d["ITEMID"].ToString()));
                        Errorlist.Add(t);
                    }
                    if (decimal.Parse(d["sprice"].ToString()) == 0)
                    {
                        t = "Sales price not found for item : " + GetItemname(int.Parse(d["ITEMID"].ToString()));
                        Errorlist.Add(t);
                    }
                    if (bool.Parse(d["expr"].ToString()) == true && string.IsNullOrEmpty(d["expdate"].ToString()))
                    {
                        t = "Expiry date not found for item :" + GetItemname(int.Parse(d["ITEMID"].ToString()));
                        Errorlist.Add(t);
                    }
                }
            }
            if (invno.EditValue != null)
            {
                int t = 0;
                var ta = new DataSet1TableAdapters.PURINVMAINTableAdapter();
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
            if(warehouse.EditValue==null)
                whid=0;
            else
                whid = int.Parse(warehouse.EditValue.ToString());
            try
            {
                if (purid > 0)
                {
                    issaved = true;
                    var dr = this.dataSet1.PURINVMAIN.FindByPURINVID(purid);
                    if (dr != null)
                    {
                        dr.BeginEdit();
                        dr.SUPID = supplier.EditValue.ToString();
                        dr.SUPNAME = supplier.Text;
                        dr.INVNO = Inv;
                        if(dtinv==null)
                            dr["INVDATE"] = DBNull.Value;
                        else
                            dr["INVDATE"] = dtinv;
                        dr.DUEDAYS = int.Parse(duedays.EditValue.ToString());
                        dr.SPDISCOUNT = decimal.Parse(spdisc.EditValue.ToString());
                        dr.ADJVALUE = decimal.Parse(adjustval.EditValue.ToString());
                        dr.HOLD = ishold;
                        dr.WHID = whid;
                        dr.EUSERID = Utils.userid;
                        dr.EDATE = DateTime.Now;
                        dr.NETVALUE = decimal.Parse(netamt.EditValue.ToString());
                        
                        dr.EndEdit();
                        this.purinvmainTableAdapter1.Update(dr);
                    }
                }
                else
                {
                    var InsertQ = new DataSet1TableAdapters.PURINVMAINTableAdapter();
                    purid = Convert.ToInt32(InsertQ.InsertQuery(DateTime.Today.Date,
                        supplier.EditValue.ToString(),
                        supplier.Text,
                        Inv,
                        dtinv,
                        int.Parse(duedays.EditValue.ToString()),
                        decimal.Parse(spdisc.EditValue.ToString()),
                        decimal.Parse(adjustval.EditValue.ToString()),
                        ishold,
                        whid,
                        comboBox1.SelectedIndex,
                        Utils.userid,
                        DateTime.Now,
                        0,
                        null,decimal.Parse(netamt.EditValue.ToString())).ToString());
                }
                if (purid > 0)
                {
                    purno.EditValue = purid;
                    issaved = true;
                    foreach (DataRow d in this.dataSet1.PURINVDETAIL.Rows)
                    {
                        d["PURINVID"] = purid;
                    }
                    pURINVDETAILTableAdapter1.Update(this.dataSet1.PURINVDETAIL);
                    if (ishold)
                    {
                        XtraMessageBox.Show("Invoice holded sucessfully", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        UpdateStock();
                        XtraMessageBox.Show("Invoice recorded sucessfully", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                   // this.posMenu1.SaveButtonEnabled = false;
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
        void UpdateStock()
        {
            //var ta = new DataSet1TableAdapters.STOCKMASTERTableAdapter();
            
            DataTable dt = this.dataSet1.STOCKMASTER;
            foreach (DataRow d in this.dataSet1.PURINVDETAIL)
            {
                DataRow dr = dt.NewRow();
                dr["PURINVID"]=purid;
                dr["ITEMID"]= d["ITEMID"];
                dr["BARCODE"] =d["BARCODE"];
                dr["ITEMTYPEID"]=d["ITEMTYPEID"];
                dr["STOREID"]=d["STOREID"];
                dr["QTY"]= decimal.Parse(d["QTY"].ToString()) + decimal.Parse(d["BONUSQTY"].ToString());
                dr["INVRATE"]=d["INVRATE"];
                dr["SPRICE"]=d["SPRICE"];
                dr["CPRICE"] =d["CPRICE"];
                dr["EXPDATE"]=d["EXPDATE"];
                dr["STORETYPE"]="P";
                dr["ALLOTTYPE"]=comboBox1.SelectedIndex;
                dr["EMODE"] ="A";
                dr["DQNTY"]=decimal.Parse(d["QTY"].ToString()) + decimal.Parse(d["BONUSQTY"].ToString());
                dr["SALESORDER"]=0;
                dr["SEL"]=false;
                dr["BALSTK"]=0;
                dr["PRNQTY"]=0;
                dr["PRNPR"]=false;
                dr["PRNSEL"] = false;
                dr["WHID"] = whid;
                dr["DISC"] = d["DISC"];
                dr["SUPID"] = supplier.EditValue.ToString();
                this.dataSet1.STOCKMASTER.Rows.Add(dr);
            }
            this.stockmasterTableAdapter1.Update(this.dataSet1.STOCKMASTER);
        }
        void DoNew()
        {
          //  posMenu1.SaveButtonEnabled = true;
            if (purid == 0 && this.dataSet1.PURINVDETAIL.Rows.Count > 0)
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
            supplier.EditValue = "";
            invdate.EditValue = null;
            duedays.EditValue = null;
            purno.EditValue = null;
            purid = 0;
            invno.EditValue = null;
            warehouse.EditValue = null;
            this.pURINVDETAILTableAdapter1.Fill(this.dataSet1.PURINVDETAIL);
            this.iTEMMAST1TableAdapter.Fill(this.dataSet1.ITEMMAST1);
            invdate.EditValue = DateTime.Now;
            supplier.Focus();
        }
        //void DeSelectFromList()
        //{
        //    foreach (DataRow d in this.dataSet1.ITEMMAST1)
        //    {
        //        if (c1TrueDBGrid1.Columns["ITEMID"].Value.ToString() == d["itemno"].ToString())
        //        {
        //            d["SEL"] = false;
        //        }
        //    }
        //}
        void  DoViewData()
        {
            this.purinvmainTableAdapter1.FillByPurid (this.dataSet1.PURINVMAIN,purid);

            this.pURINVDETAILTableAdapter1.FillByPurid(this.dataSet1.PURINVDETAIL,purid);
            Gtotal();
            issaved = false;
            ishold = true;
            foreach (DataRow d in this.dataSet1.PURINVMAIN.Rows)
            {

                        supplier.EditValue = d["SUPID"].ToString();
                        invno.EditValue = d["INVNO"].ToString();
                        invdate.EditValue = d["INVDATE"].ToString();
                        duedays.EditValue=d["DUEDAYS"].ToString();
                        spdisc.EditValue=d["SPDISCOUNT"].ToString();
                        adjustval.EditValue =d["ADJVALUE"].ToString();
                        if (!string.IsNullOrEmpty(d["WHID"].ToString()))
                        {
                            warehouse.EditValue = int.Parse(d["WHID"].ToString());    
                        }
                        
                        if(!string.IsNullOrEmpty(d["TRANSTYPE"].ToString()))
                                comboBox1.SelectedIndex=  int.Parse(d["TRANSTYPE"].ToString());
            }
        }
        #endregion
        #region BLLS
        void DeleteItem()
        {
            if (this.dataSet1.PURINVDETAIL.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Do you want to delete the selected  row..?", c1TrueDBGrid1.Columns["ITEMID"].Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c1TrueDBGrid1.Delete();
                }
            }
        }
        void AddItems()
        {
            FrmItemLookUp frm = new FrmItemLookUp(dataSet1.PURINVDETAIL);
            frm.Itemadded += new RefershGrid(AdditemsToList);
            frm.ShowDialog();
        }
        void ItemClone()
        {
            if (this.dataSet1.PURINVDETAIL.Rows.Count > 0)
            {
            var dr = dataSet1.PURINVDETAIL.NewRow();
            dr["ITEMID"] = c1TrueDBGrid1.Columns["Item Name"].Value;
            dr["BARCODE"] = c1TrueDBGrid1.Columns["Barcode"].Value;
            dr["ITEMTYPEID"] = c1TrueDBGrid1.Columns["Item Type"].Value;
            if (c1TrueDBGrid1.Columns["Item Type"].Value.ToString() == "1")
            {
                dr["DISC"] = c1TrueDBGrid1.Columns["DISCOUNT"].Value; //dr["DISC"] = 14.5;
            }
            dr["PURINVID"] = 0;
            dr["INVRATE"] = 0;
            dr["SPRICE"] = 0;
            dr["CPRICE"] = 0;
            dr["EXPR"] = c1TrueDBGrid1.Columns["EXPR"].Value;
            dataSet1.PURINVDETAIL.Rows.Add(dr);
        }
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
            decimal Dis3 = 0m;
            decimal cost = 0m;
            decimal Tcost1 = 0m;
            decimal Tcost2 = 0m;
            decimal Tsale1 = 0m;
            decimal Tsale2 = 0m;
            decimal Gcost = 0m;
            decimal Gsale = 0m;
            decimal Tgdis = 0m;
            //Dim bk Dim bk1 Dim Rcs As Recordset
            decimal Grs = 0m;
            decimal Ecost = 0m;
            decimal Edisc = 0m;
            foreach (DataRow d in this.dataSet1.PURINVDETAIL)
            {
                if (decimal.Parse(d["qty"].ToString()) > 0 || decimal.Parse(d["BONUSQTY"].ToString()) > 0)
                {
                    Tctr++;
                }
                if (d["ITEMTYPEID"].ToString() == "1" && decimal.Parse(d["SPRICE"].ToString()) == 0)
                {
                    d["SPRICE"] = d["invrate"];
                }
                //else if(d["ITEMTYPEID"].ToString() == "1" && decimal.Parse(d["SPRICE"].ToString()) != 0)
                //{
                //    d["SPRICE"] = d["invrate"];
                //}
                cost = CostPrice(decimal.Parse(d["qty"].ToString()),
                                 decimal.Parse(d["BONUSQTY"].ToString()),
                                 decimal.Parse(d["INVRATE"].ToString()),
                                 decimal.Parse(d["DISC"].ToString()),
                                 decimal.Parse(spdisc.EditValue.ToString()));

                Grs = (decimal.Parse(d["qty"].ToString()) * decimal.Parse(d["invrate"].ToString())) - (decimal.Parse(d["invrate"].ToString()) * decimal.Parse(d["DISC"].ToString()) / 100);
                d["GROSSVALUE"] = Grs;
                if (decimal.Parse(d["SPDISC"].ToString()) > 0)
                {
                    Edisc = Grs - (Grs * decimal.Parse(d["SPDISC"].ToString()) / 100);
                    d["GROSSVALUE"] = Edisc;
                }
                d["LINETOTAL"] = decimal.Parse(d["qty"].ToString()) * decimal.Parse(d["invrate"].ToString());
                if (decimal.Parse(d["SPDISC"].ToString()) > 0)
                {
                    Ecost = cost - (cost * decimal.Parse(d["SPDISC"].ToString())) / 100;
                    d["cprice"] = Ecost;
                }
                else
                {
                    Ecost = cost;
                    d["cprice"] = Ecost;
                }

                d["PROFIT"] = decimal.Parse(d["SPRICE"].ToString()) - Ecost;

                Tvalue += decimal.Parse(d["LINETOTAL"].ToString());

                Dval1 = decimal.Parse(d["disc"].ToString());
                Dval = decimal.Parse(d["qty"].ToString());
                dval2 = decimal.Parse(d["invrate"].ToString());
                Dis1 = (Dval * dval2) * Dval1 / 100;
                if (decimal.Parse(d["SPDISC"].ToString()) > 0)
                {
                    Dis3 = ((Dval * dval2) - Dis1) * decimal.Parse(d["SPDISC"].ToString()) / 100;
                }
                else
                {
                    Dis3 = 0;
                }
                Dis2 += Dis1 + Dis3;
                Gcost = decimal.Parse(d["cprice"].ToString());
                Tcost1 = (decimal.Parse(d["qty"].ToString()) + decimal.Parse(d["BONUSQTY"].ToString())) * Gcost;
                Tcost2 = Tcost2 + Tcost1;
                Gsale = decimal.Parse(d["sprice"].ToString());
                Tsale1 = (decimal.Parse(d["qty"].ToString()) + decimal.Parse(d["BONUSQTY"].ToString())) * Gsale;
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
            if (Tcost2 != 0)
                totcostvalue.EditValue = Tcost2;
            if (Tsale2 != 0)
                totsalvalue.EditValue = Tsale2;
            c1TrueDBGrid1.Refresh();
        }
        decimal CostPrice(decimal qty, decimal bns, decimal rate, decimal dis1, decimal dis2)
        {
            decimal cost1 = 0m;
            decimal cost2 = 0m;
            decimal cost3 = 0m;
            decimal cost4 = 0m;
            decimal cost5 = 0m;
            decimal cost6 = 0m;
            if (qty > 0)
            {
                cost1 = qty + bns;
                cost2 = qty * rate;
                cost3 = cost2 / cost1;
                if (dis1 > 0)
                {
                    cost5 = cost3 - (cost3 * dis1) / 100;
                    cost6 = cost5;
                }
                else
                {
                    cost5 = cost3;
                }
                if (dis2 > 0)
                {
                    cost4 = cost5 - (cost5 * dis2) / 100;
                    cost6 = cost4;
                }
                if (dis1 == 0 && dis2 == 0 && bns == 0)
                    cost6 = rate;
                else if (dis1 == 0 && dis2 == 0 && bns != 0)
                    cost6 = cost5;
            }
            return cost6;
        }
        void AdditemsToList(DataRow d)
        {
            AddItemsToList(d["sel"].ToString(), d);
        }
        void AddItemsToList(string selected,DataRow adr )
        {
            //int itemid, string barcode, int groupid, bool expdtreq, decimal discount
            if (selected==bool.TrueString)
            {
                var dr = dataSet1.PURINVDETAIL.NewRow();
                dr["ITEMID"] = adr["itemno"];
                dr["BARCODE"] = adr["barcode"];
                dr["ITEMTYPEID"] = adr["groupid"];
                if (int.Parse( adr["groupid"].ToString())  == 1)
                {
                    dr["DISC"] = adr["discount"];
                }
                dr["PURINVID"] = 0;
                dr["INVRATE"] = 0;
                dr["SPRICE"] = 0;
                dr["CPRICE"] = 0;
                dr["EXPR"] = adr["EXPDATEREQ"];
                dataSet1.PURINVDETAIL.Rows.Add(dr);
            }
            else 
            {
                int i = 0;
                foreach (DataRow d in dataSet1.PURINVDETAIL.Rows)
                {

                    if (d.RowState != DataRowState.Deleted)
                        if (d["ITEMID"].ToString() == adr["itemno"].ToString())
                        {
                            dataSet1.PURINVDETAIL.Rows.RemoveAt(i);
                            break;
                        }
                    i++;
                }
            }
        }
        string GetItemname(int itemid)
        {
            DataRow dr = this.dataSet1.ITEMMAST1.FindByITEMNO(itemid);
            return dr[0].ToString();

        }
        #endregion
        #region c1TrueDBGrid1
        private void c1TrueDBGrid1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (c1TrueDBGrid1.Col == 9 && c1TrueDBGrid1.Columns["EXPR"].Value.ToString() == bool.FalseString && (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab))
            {
                if (c1TrueDBGrid1.Splits[0].Rows.Count == c1TrueDBGrid1.Row)
                {
                    e.Handled = true;
                }
                else
                {
                    c1TrueDBGrid1.Row = c1TrueDBGrid1.Row + 1;
                    c1TrueDBGrid1.Col = 4;
                    e.Handled = true;
                }
            }
            if (c1TrueDBGrid1.Col == 10 && (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab))
            {
                if (c1TrueDBGrid1.Splits[0].Rows.Count == c1TrueDBGrid1.Row)
                {
                    e.Handled = true;
                }
                else
                {
                    c1TrueDBGrid1.Row = c1TrueDBGrid1.Row + 1;
                    c1TrueDBGrid1.Col = 4;
                    e.Handled = true;
                }
            }
        }
        private void c1TrueDBGrid1_BeforeColEdit(object sender, C1.Win.C1TrueDBGrid.BeforeColEditEventArgs e)
        {

            if (c1TrueDBGrid1.Columns["EXPR"].Value.ToString() == bool.TrueString)
            {
                c1TrueDBGrid1.Splits[0].DisplayColumns[10].Locked = false;
            }
            else
            {
                c1TrueDBGrid1.Splits[0].DisplayColumns[10].Locked = true;
            }
        }
        private void c1TrueDBGrid1_BeforeColUpdate(object sender, C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs e)
        {
            if (e.ColIndex == 4 || e.ColIndex == 6 || e.ColIndex == 7 || e.ColIndex == 8 || e.ColIndex == 9)
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
                    DateTime d1 = DateTime.Now;
                    if (int.Parse(split[1]) < 2000)
                        d1 = new DateTime(2000 + int.Parse(split[1]), int.Parse(split[0]), 1);
                    else
                        d1 = new DateTime(int.Parse(split[1]), int.Parse(split[0]), 1);
                   // DateTime d1 = new DateTime(2000+int.Parse(split[1]), int.Parse(split[0]), 1);
                    c1TrueDBGrid1.Columns["Exp.Dt"].Value = d1;
                    // DateTime d1 = DateTime.Parse(c1TrueDBGrid1.Columns["Exp.Dt"].Value.ToString());
                    DateTime d2 = DateTime.Today;
                    if (d1 <= d2)
                    {
                        XtraMessageBox.Show("Please check the expiry date", "P.O.S", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
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
            {
                e.Cancel = false;
               // DeSelectFromList();
            }
            else
            {
                e.Cancel = true; 
            }
        }
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
                        {}
                        else
                        { c1TrueDBGrid1.Columns["SPRICE"].Value = c1TrueDBGrid1.Columns["INVRATE"].Value; }
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
        {            Gtotal();        }
        private void c1TrueDBGrid1_AfterUpdate(object sender, EventArgs e)
        {            Gtotal();        }
        #endregion
        private void supplier_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView row = supplier.Properties.GetDataSourceRowByKeyValue(supplier.EditValue) as DataRowView;
            if (row != null)
            {
                var value = row["DUEDAYS"];
                if (!string.IsNullOrEmpty(value.ToString()))
                    duedays.EditValue = value.ToString();
                else
                    duedays.EditValue = 0;
                var f = new Notes();
                if (f.CheckNotesAvailable(supplier.EditValue.ToString(),"PO"))
                {
                    var f1 = new Notes(supplier.EditValue.ToString(), supplier.Text,"PO");
                    f1.ShowDialog();
                }
            }
        }
        private void lookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                var fr = new Warehousemast();
                fr.ShowDialog();
                this.wAREHOUSEMASTTableAdapter.Fill(this.dataSet1.WAREHOUSEMAST);
                
            }
        }
        private void PurchaseInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (purid == 0)
            {
                if (this.dataSet1.PURINVDETAIL.Rows.Count > 0)
                { 
                   if(XtraMessageBox.Show( "You are going to exit this program Data is not saved, Want to hold the data ?","P.O.S",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        ishold = true;
                        DoSave();
                        if (ishold == true)
                            this.Dispose();
                        else
                            e.Cancel = true;
                    }
                }
            }
            if (purid > 0 && issaved == false && ishold == true)
                {
                    if (this.dataSet1.PURINVDETAIL.Rows.Count > 0)
                    {
                        if (XtraMessageBox.Show("You are going to exit this program Data is not saved, Want to hold the data ?", "P.O.S", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ishold = true;
                            DoSave();
                            if (ishold == true)
                                this.Dispose();
                            else
                                e.Cancel = true;
                        }
                    }
                }
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItems();
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemClone();  
        }
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }

        
    }
}