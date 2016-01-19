using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using VIRETAILENTITIES;

namespace Store
{
    public partial class StockShow : XtraForm
    {
        public string itemno;
        public string itemname;
        public string barcode;
        public int qtyonhand = 0;
        public int qtyonorder = 0;
        public int qtybalance = 0;
        public int enterqty { get; set; }
        public int iscontinue;
        public bool showsalesprice = false;
        public decimal salesprice { get; set; }
        public decimal nsalesprice;
        public decimal cdisc = 0;
        public bool _isblank;
        public DsInventory.STOCKMASTERRow DStockmasterRow { get; set;}
        public bool isBlankStock 
        {
            get { return _isblank; }
            set
            {
                    _isblank = value;
                    if (value)
                        {
                            simpleButton2.Text = "Remove Item";
                        }
                } 
        }
        public StockShow()
        {
            InitializeComponent();
        }
        private void StockShow_Load(object sender, EventArgs e)
        {
            lblbarcode.Text = itemno;
            lblname.Text = itemname;
            lblqtyonhand.Text = qtyonhand.ToString();
            txtentered.EditValue = qtyonorder;
            lblqtyonorder.Text = qtyonorder.ToString();
            lblqtyavailable.Text = qtybalance.ToString();
            nsalesprice = salesprice;
            if (showsalesprice)
            {
                txtsalesprice.Enabled = true; 
                txtsalesprice.EditValue = salesprice;
            }
            else
            {
                txtsalesprice.EditValue = salesprice;
                txtsalesprice.Enabled = false;
            }
        }
        private void StockShow_KeyDown(object sender, KeyEventArgs e)
        {
           
            if(e.KeyCode==Keys.Escape)
            {
                iscontinue = 0;
                Close();
            }
            if(e.KeyCode==Keys.F4)
            {
                KeyF4();
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e) 
        {
           
            Dispose();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KeyF4();
            //if (txtentered.EditValue != null)
            //{
            //    iscontinue = 1;
            //    enterqty = int.Parse(txtentered.EditValue.ToString());
            //    DStockmasterRow.DQNTY = enterqty;
            //    DStockmasterRow.SPRICE = salesprice;
            //    if(salesprice==0)
            //    {
            //        XtraMessageBox.Show("Please enter the sales price", "POS", MessageBoxButtons.OK,
            //                            MessageBoxIcon.Error);
            //        return;
            //    }
            //    if(isBlankStock)
            //    {
            //        new BusinessLogic.BLSales().AddNewItemwithNegativeQty(DStockmasterRow);
            //    }
            //}
            //Dispose();
        }
        private void txtsalesprice_EditValueChanged(object sender, EventArgs e)
        {
            if (txtsalesprice.EditValue != null)
            {
                salesprice = decimal.Parse(txtsalesprice.EditValue.ToString());
            }
        }
        
        void KeyF4()
        {
            if (txtentered.EditValue != null)
            {
                iscontinue = 1;
                enterqty = int.Parse(txtentered.EditValue.ToString());
                DStockmasterRow.DQNTY = enterqty;
                //var sp = DStockmasterRow.SPRICE;
                DStockmasterRow.SPRICE = salesprice;
                
                if (enterqty == 0)
                {
                    XtraMessageBox.Show("Please enter the Qty", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtentered.Focus();
                    return;
                }
                if (salesprice == 0)
                {
                    XtraMessageBox.Show("Please enter the sales price", "POS", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtsalesprice.Focus();
                    return;
                }
                if(DStockmasterRow.STOCKID < 0) // if (isBlankStock)
                {
                    if(DStockmasterRow.CPRICE == 0)
                    {
                        DStockmasterRow.CPRICE = (salesprice) - (salesprice * cdisc) / 100;
                    }
                    new BLSales().AddNewItemwithNegativeQty(DStockmasterRow);
                }
                else
                {
                    if (nsalesprice != salesprice)
                    {
                        new BLSales().UpdateSprice(DStockmasterRow.SPRICE,DStockmasterRow.STOCKID);
                    }
                    isBlankStock = false;
                }
            }
            Dispose();
        }
    }

}