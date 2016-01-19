using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using VIRETAILDAL;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;

namespace Store
{
  //public delegate void NewItemCreated();
  //public delegate void GetSelectedRow(object sender, GetDataRowEventArgs e);
    public partial class ItemMast : BaseRibbonForm
    {
        //public event NewItemCreated ItemCreated;
        private BindingSource Bsnav = new BindingSource();
        private readonly TextBox Tnav = new TextBox();
        private DsMaster dsMaster = new DsMaster();
        string  _itemno ;
        bool IsNew = true;
        public ItemMast()
        {
            InitializeComponent();
            ItemClick += RibbonButtonsClick;
            RibbonPageMoreOptionsVisible = false;
            RibbonPrintVisible = false;
            DeleteButtonVisibility = BarItemVisibility.Never;
        }
        void RibbonButtonsClick(object sender, ItemClickEventArgs name)
        {
            switch (name.Item.Name.ToUpper())
            {
                //  BNew BSave BSaveandClose BSaveandNew BClear BDelete BPrint BNotes BHold BMovePrev BMoveNext
                case "BNEW":
                    DoNew();
                    break;
                case "BSAVE":
                    DoSave();
                    break;
                case "BSAVEANDCLOSE":
                    DoSaveClose();
                    break;
                case "BSAVEANDNEW":
                    DoSaveNew();
                    break;
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
            }
        }
        void DoSaveClose()
        {
           if(DoSave())
           {
               Dispose();
           }
        }
        void DoSaveNew()
        {
            if(DoSave())
            {
                DoNew();
            }
        }
        void SetNavigation()
        {
            
            Bsnav.DataSource = dsMaster1.ITEMMAST;// ClsGetData.GetItemMast1List();
            Tnav.DataBindings.Add(new Binding("Text", Bsnav, "ITEMNO", true));
            if (Bsnav.Count == 0)
            {
                MovePrevEnable = false;
                MoveNextEnable = false;
            }
            else
            {
                Bsnav.MoveLast();
                MoveNextEnable = false;
            }
        }
        void DoMovePrev()
        {

            if (Bsnav.Position <= 0)
            {
                MoveNextEnable = true;
                MovePrevEnable = false;
            }
            else
            {
                MovePrevEnable = true;
            }
            Bsnav.MovePrevious();
            MoveNextEnable = true;
            var current = (DataRowView)Bsnav.Current;
            var scode = current["ITEMNO"].ToString();
            DoView(scode);
           
            HoldButtonVisibility = BarItemVisibility.Never;
            IsNew = false;
        }
        void DoMoveNext()
        {
            if (Bsnav.Position == Bsnav.Count - 1)
            {
                MoveNextEnable = false;
                MovePrevEnable = true;
            }
            else
            {
                MovePrevEnable = true;
            }
            Bsnav.MoveNext();
            IsNew = false;
            var current = (DataRowView)Bsnav.Current;
            var scode = current["ITEMNO"].ToString();
            DoView(scode);
            HoldButtonVisibility = BarItemVisibility.Never;
        }
        private void ItemMastLoad(object sender, EventArgs e)
        {
            Ribbonname = "Item Mast";
            bindingSource1.DataSource = typeof(ItemMastError);
            itemtype.DataBindings.Add(new Binding("EditValue", bindingSource1, "itemtype", true));
            ownbarcode.DataBindings.Add(new Binding("Checked", bindingSource1, "ownbarcode", true));
            barcode.DataBindings.Add(new Binding("EditValue", bindingSource1, "barcode", true));
            itemname.DataBindings.Add(new Binding("EditValue", bindingSource1, "itemname", true));
            buom.DataBindings.Add(new Binding("EditValue", bindingSource1, "buom", true));
            supplier.DataBindings.Add(new Binding("EditValue", bindingSource1, "supplier", true));
            uom.DataBindings.Add(new Binding("EditValue", bindingSource1, "uom", true));
            itemcat.DataBindings.Add(new Binding("EditValue", bindingSource1, "itemcat", true));
            itemgroup.DataBindings.Add(new Binding("EditValue", bindingSource1, "itemgroup", true));
            minqty.DataBindings.Add(new Binding("EditValue", bindingSource1, "min", true));
            maxqty.DataBindings.Add(new Binding("EditValue", bindingSource1, "max", true));
            minpoqty.DataBindings.Add(new Binding("EditValue", bindingSource1, "minpo", true));
            maxpoqty.DataBindings.Add(new Binding("EditValue", bindingSource1, "maxpo", true));
            dxErrorProvider1.DataSource = bindingSource1;
            dxErrorProvider1.ContainerControl = this;
            itemtype.EditValue = 1;
            this.InvokeEx(x => LoadDatas());
            Loginname = Utils.Username;

        }
        void  LoadDatas()
        {
            var proxy = new DataManager();
            dsMaster1.Merge(proxy.GetUom());
             
            uOMMASTBindingSource.DataSource = proxy.GetUom();
            cATEGORYBindingSource.DataSource = proxy.GetCategory();
            gENERICMASTBindingSource.DataSource = proxy.GetGeneric();
            iTEMTYPEBindingSource.DataSource = proxy.GetItemType();
            iTEMGROUPBindingSource.DataSource = proxy.GetItemGroup();
            sUPPLIERBindingSource.DataSource = proxy.GetSupplier();
            dsMaster1.Merge(new BlItemMaster().GetItemMastList());
            SetNavigation();
        }
        private void LookUpEdit4EditValueChanged(object sender, EventArgs e)
        {   
            //if (int.Parse(itemtype.EditValue.ToString()) == 4)
            //{
            //    groupControl1.Visible = true;
            //    if(this.WindowState!=System.Windows.Forms.FormWindowState.Maximized)
            //        this.Height = this.Height + groupControl1.Height ;
            //}
            //else
            //{
            //    groupControl1.Visible = false;
            //    this.Height = 434;
            //}
        }
        bool DoValidate()
        {
            var errl = new ItemMastError
            {
                Itemtype = itemtype.EditValue == null ? null : itemtype.EditValue.ToString(),
                ownbarcode = ownbarcode.Checked,
                barcode = barcode.EditValue == null ? null : barcode.EditValue.ToString(),
                itemname = itemname.EditValue == null ? null : itemname.EditValue.ToString(),
                buom = buom.EditValue == null ? null : buom.EditValue.ToString(),
                supplier = supplier.EditValue == null ? null : supplier.EditValue.ToString(),
                uom = uom.EditValue == null ? null : uom.EditValue.ToString(),
                itemcat = itemcat.EditValue == null ? null : itemcat.EditValue.ToString(),
                itemgroup = itemgroup.EditValue == null ? null : itemgroup.EditValue.ToString(),
                min = minqty.EditValue==null?0:int.Parse(minqty.EditValue.ToString()),
                max = maxqty.EditValue == null ? 0 : int.Parse(maxqty.EditValue.ToString()),
                minpo = minpoqty.EditValue==null?0:int.Parse(minpoqty.EditValue.ToString()),
                maxpo = maxpoqty.EditValue == null ? 0 : int.Parse(maxpoqty.EditValue.ToString())
            };
            bindingSource1.Add(errl);
            return !dxErrorProvider1.HasErrors;
        }
        bool DoSave()
        {
            bool retval = false;
            if (DoValidate())
            {
                var newrow =(DsMaster.ITEMMASTRow) new DsMaster().ITEMMAST.NewRow();
                    newrow.ITEMNO = _itemno;
                    newrow.ITEMTYPE = int.Parse(itemtype.EditValue.ToString());
                    newrow.OWNBARCODE = ownbarcode.Checked;
                    newrow.BARCODE = barcode.Text;
                    newrow.ITEMNAME = itemname.Text;
                    newrow.ARITEMNAME = aritemname.Text;
                    newrow.BASEUOM = int.Parse(buom.EditValue.ToString());
                    newrow.SUPPLIERNO = supplier.EditValue.ToString();
                    newrow.MANFNAME = manfact.Text;
                    newrow.REORDER = reorder.EditValue==null?0:int.Parse(reorder.Text);
                    newrow.UOM = int.Parse(uom.EditValue.ToString());
                    newrow.PRINTBARCODE = printbarcode.Checked;
                    newrow.EXPDATEREQ = expdatereq.Checked;
                    newrow.ACTIVE = active.Checked;
                    newrow.CATEGORY = int.Parse(itemcat.EditValue.ToString());
                    newrow.GROUPID = int.Parse(itemgroup.EditValue.ToString());
                    newrow.GENERICID = genname.EditValue == null ? 0 : int.Parse(genname.EditValue.ToString());
                    newrow.MARGIN = margin.EditValue==null?0:decimal.Parse(margin.EditValue.ToString());
                    newrow.MARKUP = markup.EditValue == null ? 0 : decimal.Parse(markup.EditValue.ToString());
                    newrow.DISCOUNT = discount.EditValue == null ? 0 : decimal.Parse(discount.EditValue.ToString());
                    newrow.FASTMOVING = fastmoving.Checked;
                    newrow.LOCATION = location.Text;
                    newrow.TEMPRATURE = temprature.Text;
                    newrow.MINQTY = minqty.EditValue == null ? 0 : int.Parse(minqty.EditValue.ToString());
                    newrow.MAXQTY = maxqty.EditValue == null ? 0 : int.Parse(maxqty.EditValue.ToString());
                    newrow.CPRICE = ORDERCOST.EditValue == null?0:decimal.Parse(ORDERCOST.EditValue.ToString());
                    newrow.SPRICE = REGULARPRICE.EditValue == null?0:decimal.Parse(REGULARPRICE.EditValue.ToString());
                    newrow.ITEMDEM = ITEMDEM.EditValue == null ? string.Empty : ITEMDEM.EditValue.ToString();
                    newrow.COLOR= COLOR.EditValue == null?string.Empty: COLOR.EditValue.ToString();
                    newrow.WEIGHT= WEIGHT.EditValue == null?string.Empty: WEIGHT.EditValue.ToString();
                    newrow.POMINQTY = minpoqty.EditValue == null ? 0 : int.Parse(minpoqty.EditValue.ToString());
                    newrow.POMAXQTY = maxpoqty.EditValue == null ? 0 : int.Parse(maxpoqty.EditValue.ToString());
                    newrow.DISCONSALE = checkBox1.Checked;
                    newrow.SALEDISCOUNTPER = SALEDISCOUNTPER.EditValue == null?0: decimal.Parse(SALEDISCOUNTPER.EditValue.ToString());
                    
                    var bl = new BlItemMaster {Itemmast = newrow,Itemno = _itemno};
                    var ret = bl.DoSave();
                    if(ret=="1")
                    {
                        retval = true;
                        XtraMessageBox.Show("Data Saved", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (string.IsNullOrEmpty(_itemno))
                        _itemno = bl.Itemno;
                        txtourcode.Text = _itemno;
                    }
                    else
                    {
                        retval = false;
                        XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //var proxy = new DataManager();
                   // this.dsInventory1.Merge(proxy.GetItemMast());
                    dsMaster.Merge(new BlItemMaster().GetItemMastList());
            }
            return retval;
        }
        void DoNew()
        {
            IsNew = true;
            _itemno = string.Empty;
            itemtype.EditValue =0;
            ownbarcode.Checked = false;
            barcode.Text = string.Empty;
            itemname.Text = string.Empty;
            aritemname.Text = string.Empty;
            buom.EditValue = null;
            supplier.EditValue = null;
            manfact.Text = string.Empty;
            reorder.Text = string.Empty;
            uom.EditValue = null;
            printbarcode.Checked = false;
            expdatereq.Checked = false;
            active.Checked = true;
            itemcat.EditValue = null;
            itemgroup.EditValue =   null;
            genname.EditValue =  null;
            margin.EditValue = null;
            markup.EditValue = null;
            discount.EditValue = null;
            location.Text = string.Empty;
            temprature.Text = string.Empty;
            fastmoving.Checked = false;
            SALEDISCOUNTPER.EditValue = null;
            itemtype.EditValue = 1;
            active.Checked = true;
            minqty.EditValue = 0;
            maxqty.EditValue = 0;
            ORDERCOST.EditValue = 0;
            REGULARPRICE.EditValue = 0;
            ITEMDEM.EditValue = null;
            COLOR.EditValue = null;
            WEIGHT.EditValue = null;
            minpoqty.EditValue = 0 ;
            maxpoqty.EditValue = 0 ;
            checkBox1.Checked=false;
            SALEDISCOUNTPER.EditValue =  0 ;
        }
        public void DoView(string itm)
        {
            if (string.IsNullOrEmpty(itm)) return;
           // DataRow d = this.dsInventory1.ITEMMAST.FindByITEMNO(itm);
            DataRow d = dsMaster1.ITEMMAST.FindByITEMNO(itm);
            _itemno = itm;
            txtourcode.Text = itm;
            if (!string.IsNullOrEmpty(d["ITEMTYPE"].ToString()))
            itemtype.EditValue = int.Parse(d["ITEMTYPE"].ToString());
            if (!string.IsNullOrEmpty(d["OWNBARCODE"].ToString()))
            ownbarcode.Checked = bool.Parse(d["OWNBARCODE"].ToString());
            barcode.Text = d["BARCODE"].ToString();
            itemname.Text = d["ITEMNAME"].ToString();
            if (!string.IsNullOrEmpty(d["BASEUOM"].ToString()))
                buom.EditValue = int.Parse(d["BASEUOM"].ToString());
            else
                buom.EditValue = 0;
            if (!string.IsNullOrEmpty(d["SUPPLIERNO"].ToString()))
                supplier.EditValue = d["SUPPLIERNO"].ToString();
            else
                supplier.EditValue = 0;
            manfact.Text= d["MANFNAME"].ToString();
            if (!string.IsNullOrEmpty(d["REORDER"].ToString()))
                reorder.EditValue =  int.Parse(d["REORDER"].ToString()) ;
            else
                reorder.Text = string.Empty;
            if (!string.IsNullOrEmpty(d["UOM"].ToString()))
                uom.EditValue = int.Parse(d["UOM"].ToString());
            else
                uom.EditValue = 0;
            if (!string.IsNullOrEmpty(d["PRINTBARCODE"].ToString()))
            printbarcode.Checked= bool.Parse(d["PRINTBARCODE"].ToString());
            expdatereq.Checked= bool.Parse(d["EXPDATEREQ"].ToString());
            active.Checked = true;
            if (!string.IsNullOrEmpty(d["ACTIVE"].ToString()))
               active.Checked=bool.Parse(d["ACTIVE"].ToString());
            if (!string.IsNullOrEmpty(d["CATEGORY"].ToString()))
                itemcat.EditValue = int.Parse(d["CATEGORY"].ToString());
            else
                itemcat.EditValue = null;
            if (!string.IsNullOrEmpty(d["GROUPID"].ToString()))
                itemgroup.EditValue = int.Parse(d["GROUPID"].ToString());
            else
                itemgroup.EditValue = null;
            if (!string.IsNullOrEmpty(d["GENERICID"].ToString()))
                genname.EditValue = int.Parse(d["GENERICID"].ToString());
            else
                genname.EditValue = null;
            if (!string.IsNullOrEmpty(d["MARGIN"].ToString()))
                margin.EditValue = decimal.Parse(d["MARGIN"].ToString());
            else
                margin.EditValue = 0d;
            if (!string.IsNullOrEmpty(d["MARKUP"].ToString()))
                markup.EditValue=decimal.Parse(d["MARKUP"].ToString());
            else
                markup.EditValue = 0d;
            if (!string.IsNullOrEmpty(d["DISCOUNT"].ToString()))
                discount.EditValue = d["DISCOUNT"].ToString();
            else
                discount.EditValue = 0d;
            if (!string.IsNullOrEmpty(d["LOCATION"].ToString()))
                location.Text = d["LOCATION"].ToString();
            else
                location.Text = string.Empty;
            if (!string.IsNullOrEmpty(d["TEMPRATURE"].ToString()))
                temprature.Text = d["TEMPRATURE"].ToString();
            else
                temprature.Text = string.Empty;
            if (!string.IsNullOrEmpty(d["ACTIVE"].ToString()))
                active.Checked = bool.Parse(d["ACTIVE"].ToString());
            else
                active.Checked = false;
            if (!string.IsNullOrEmpty(d["ACTIVE"].ToString()))
                fastmoving.Checked = bool.Parse(d["FASTMOVING"].ToString());
            else
                fastmoving.Checked = false;
            if (!string.IsNullOrEmpty(d["SALEDISCOUNTPER"].ToString()))
               SALEDISCOUNTPER.EditValue = d["SALEDISCOUNTPER"].ToString();
            lblstock.Text = "0";
            lblstock.Text = new BLSales().GetAvailableQty(_itemno).ToString();
            if (lblstock.Text != "0")
            {
                lblstock.Tag = Blpurinv.GetLastReceived(_itemno).ToString();
                barcode.Properties.ReadOnly = true;
            }
            else if (Blpurinv.GetLastReceived(_itemno) !=0)
            {
                barcode.Properties.ReadOnly = true;
            }
            else
            {
                barcode.Properties.ReadOnly = false;
            }
        }
        private void BuomEditValueChanged(object sender, EventArgs e)
        {
            uom.EditValue = buom.EditValue;
        }
        private void BarcodeValidating(object sender, CancelEventArgs e)
        {
            if(barcode.EditValue==null) return;
            var bl = new BlItemMaster().FindItemByBarCode(barcode.EditValue.ToString());
            if(bl.Rows.Count>0)
            {
                XtraMessageBox.Show("Duplicate bar code", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DataRow dr in bl.Rows)
            {
                _itemno = dr["ITEMNO"].ToString();
                DoView(_itemno);
            }
        }
        private void ownbarcode_CheckedChanged(object sender, EventArgs e)
        {
            barcode.Enabled = !ownbarcode.Checked;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
        private void minqty_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
