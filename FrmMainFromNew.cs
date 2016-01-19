using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using Store;
using VIRETAILDAL;

namespace VIRETAILSTORE
{

    public partial class FrmMainFromNew : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        private int opentab = 0;
        public FrmMainFromNew()
        {
           // SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
            if (Properties.Settings.Default.useposdata)
                VIRETAILDAL.COMMON.Utils.Connectionstring = Properties.Settings.Default.conmain;
            else
                VIRETAILDAL.COMMON.Utils.Connectionstring = Properties.Settings.Default.POSConnectionString;

            VIRETAILDAL.COMMON.Utils.ConnectionstringSync = Properties.Settings.Default.RemoteServer;
            //RemoteServer

            //AppDomain MyDomain = AppDomain.CurrentDomain;
            //Assembly[] AssembliesLoaded = MyDomain.GetAssemblies();
            ////int i = 0;
            ////AssembliesLoaded.Count()
            //foreach (Assembly MyAssembly in AssembliesLoaded)
            //{
            //    SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, MyAssembly.FullName);
                 Thread.Sleep(100);
            //    // }
            //    // // Close the Splash Screen.
            //}
           // SplashScreenManager.CloseForm(false);

            var frm = new Login();
            frm.ShowDialog();
            if (!frm.LoginSucess)
            {
                Close();
            }
            InitializeComponent();

            //if (VIRETAILDAL.COMMON.Utils.UserType == 1)
            //{
            //    purchasingReportsToolStripMenuItem.Enabled = false;
            //    purchasingToolStripMenuItem.Enabled = false;
            //    utilitiesToolStripMenuItem.Enabled = false;
            //    mastersToolStripMenuItem1.Enabled = false;
            //    inventoryToolStripMenuItem.Enabled = false;
            //}
            ribbonMain.Manager.UseF10KeyForMenu = false;
            //if(VIRETAILDAL.COMMON.Utils.Company =="01")
            //    barButtonItem77.Visibility = BarItemVisibility.Always;

        }

        #region Sales Ribbon
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) 
        {
             opentab = 0;
            RetailSales1 frm = null;
            if ((frm = (RetailSales1)IsFormAlreadyOpen(typeof(RetailSales1))) == null)
            {
                frm = new RetailSales1();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
            //ribbonMain.SelectedPage = ribbonMain.MergedPages[0];
        }
        private void barButtonItem70_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            StockItemLookup frm = null;
            if ((frm = (StockItemLookup)IsFormAlreadyOpen(typeof(StockItemLookup))) == null)
            {
                frm = new StockItemLookup();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptDailySalesReport frm = null;
            if ((frm = (RptDailySalesReport)IsFormAlreadyOpen(typeof(RptDailySalesReport))) == null)
            {
                frm = new RptDailySalesReport();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;
            

            var frm = new DailyClosing();
            frm.ShowDialog();
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            CustomerPayment frm = null;
            if ((frm = (CustomerPayment)IsFormAlreadyOpen(typeof(CustomerPayment))) == null)
            {
                frm = new CustomerPayment();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }

        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            ShiftCode frm = null;
            if ((frm = (ShiftCode)IsFormAlreadyOpen(typeof(ShiftCode))) == null)
            {
                frm = new ShiftCode();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            CustomerCenter frm = null;
            if ((frm = (CustomerCenter)IsFormAlreadyOpen(typeof(CustomerCenter))) == null)
            {
                frm = new CustomerCenter();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }

        }
        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptItemMove frm = null;
            if ((frm = (RptItemMove)IsFormAlreadyOpen(typeof(RptItemMove))) == null)
            {
                frm = new RptItemMove();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            PivotSales frm = null;
            if ((frm = (PivotSales)IsFormAlreadyOpen(typeof(PivotSales))) == null)
            {
                frm = new PivotSales();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptGroupBySaleCat frm = null;
            if ((frm = (RptGroupBySaleCat)IsFormAlreadyOpen(typeof(RptGroupBySaleCat))) == null)
            {
                frm = new RptGroupBySaleCat();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }

            //RptItemWiseSales frm = null;
            //if ((frm = (RptItemWiseSales)IsFormAlreadyOpen(typeof(RptItemWiseSales))) == null)
            //{
            //    frm = new RptItemWiseSales();
            //    frm.MdiParent = this;
            //    frm.Show();
            //}
            //else
            //{
            //    frm.Select();
            //}

        }
        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptItemReturn frm = null;
            if ((frm = (RptItemReturn)IsFormAlreadyOpen(typeof(RptItemReturn))) == null)
            {
                frm = new RptItemReturn();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptCancelSale frm = null;
            if ((frm = (RptCancelSale)IsFormAlreadyOpen(typeof(RptCancelSale))) == null)
            {
                frm = new RptCancelSale();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;
            RptInsuranceSalesDetails frm = null;
            if ((frm = (RptInsuranceSalesDetails)IsFormAlreadyOpen(typeof(RptInsuranceSalesDetails))) == null)
            {
                frm = new RptInsuranceSalesDetails();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptCashCreditSales frm = null;
            if ((frm = (RptCashCreditSales)IsFormAlreadyOpen(typeof(RptCashCreditSales))) == null)
            {
                frm = new RptCashCreditSales();
                frm.LoadReport(3);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptCashCreditSales frm = null;
            if ((frm = (RptCashCreditSales)IsFormAlreadyOpen(typeof(RptCashCreditSales))) == null)
            {
                frm = new RptCashCreditSales();
                frm.LoadReport(1);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptCashCreditSales frm = null;
            if ((frm = (RptCashCreditSales)IsFormAlreadyOpen(typeof(RptCashCreditSales))) == null)
            {
                frm = new RptCashCreditSales();
                frm.LoadReport(2);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptPromotionSalesRpt frm = null;
            if ((frm = (RptPromotionSalesRpt)IsFormAlreadyOpen(typeof(RptPromotionSalesRpt))) == null)
            {
                frm = new RptPromotionSalesRpt();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem67_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            SalesItemComparsion frm = null;
            if ((frm = (SalesItemComparsion)IsFormAlreadyOpen(typeof(SalesItemComparsion))) == null)
            {
                frm = new SalesItemComparsion();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem81_ItemClick(object sender, ItemClickEventArgs e)
        {
                         opentab = 0;

            RptSalesRank frm = null;
            if ((frm = (RptSalesRank)IsFormAlreadyOpen(typeof(RptSalesRank))) == null)
            {
                frm = new RptSalesRank();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem82_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 0;
            RptInsuranceSalesDetails frm = null;
            if ((frm = (RptInsuranceSalesDetails)IsFormAlreadyOpen(typeof(RptInsuranceSalesDetails))) == null)
            {

                frm = new RptInsuranceSalesDetails();
                frm._usesecondgrid = true;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        #endregion
        #region Purchase Ribbon
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            PurchaseOrder frm = null;
            if ((frm = (PurchaseOrder)IsFormAlreadyOpen(typeof(PurchaseOrder))) == null)
            {
                frm = new PurchaseOrder();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;
 
            NewPurInv frm = null;
            if ((frm = (NewPurInv)IsFormAlreadyOpen(typeof(NewPurInv))) == null)
            {
                frm = new NewPurInv();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            NewPurReturn frm = null;
            if ((frm = (NewPurReturn)IsFormAlreadyOpen(typeof(NewPurReturn))) == null)
            {
                frm = new NewPurReturn();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
            opentab = 1;
        }
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            PurList frm = null;
            if ((frm = (PurList)IsFormAlreadyOpen(typeof(PurList))) == null)
            {
                frm = new PurList();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem58_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            PurchaseRequestList frm = null;
            if ((frm = (PurchaseRequestList)IsFormAlreadyOpen(typeof(PurchaseRequestList))) == null)
            {
                frm = new PurchaseRequestList();
              //  frm.LoadPurhcaseDataNotInPr();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            PaymentSelection frm = null;
            if ((frm = (PaymentSelection)IsFormAlreadyOpen(typeof(PaymentSelection))) == null)
            {
                frm = new PaymentSelection();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            SupplierSetUp frm = null;
            if ((frm = (SupplierSetUp)IsFormAlreadyOpen(typeof(SupplierSetUp))) == null)
            {
                frm = new SupplierSetUp();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem48_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            ItemList frm = null;
            if ((frm = (ItemList)IsFormAlreadyOpen(typeof(ItemList))) == null)
            {
                frm = new ItemList();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            RptPurchase frm = null;
            if ((frm = (RptPurchase)IsFormAlreadyOpen(typeof(RptPurchase))) == null)
            {
                frm = new RptPurchase();
                frm.RptType = true;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            RptPurchase frm = null;
            if ((frm = (RptPurchase)IsFormAlreadyOpen(typeof(RptPurchase))) == null)
            {
                frm = new RptPurchase();
                frm.RptType = false;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            PurchaseRequestList frm = null;
            if ((frm = (PurchaseRequestList)IsFormAlreadyOpen(typeof(PurchaseRequestList))) == null)
            {
                frm = new PurchaseRequestList();
                frm.LoadPurchaseData();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            RptBonusReport frm = null;
            if ((frm = (RptBonusReport)IsFormAlreadyOpen(typeof(RptBonusReport))) == null)
            {
                frm = new RptBonusReport();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            RptItemPurchaseDetails frm = null;
            if ((frm = (RptItemPurchaseDetails)IsFormAlreadyOpen(typeof(RptItemPurchaseDetails))) == null)
            {
                frm = new RptItemPurchaseDetails();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            RptItemGroupWise frm = null;
            if ((frm = (RptItemGroupWise)IsFormAlreadyOpen(typeof(RptItemGroupWise))) == null)
            {
                frm = new RptItemGroupWise();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem57_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 1;

            RptSupplierwiseshorting frm = null;
            if ((frm = (RptSupplierwiseshorting)IsFormAlreadyOpen(typeof(RptSupplierwiseshorting))) == null)
            {
                frm = new RptSupplierwiseshorting();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        #endregion
        #region Inventory Ribbon
        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            TransferList frm = null;
            if ((frm = (TransferList)IsFormAlreadyOpen(typeof(TransferList))) == null)
            {
                frm = new TransferList();
                frm.LoadInMainWindow += frm_LoadInMainWindow;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            ItemDownLoad frm = null;
            if ((frm = (ItemDownLoad)IsFormAlreadyOpen(typeof(ItemDownLoad))) == null)
            {
                frm = new ItemDownLoad();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
            opentab = 2;
        }
        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            CostandQtyAdj frm = null;
            if ((frm = (CostandQtyAdj)IsFormAlreadyOpen(typeof(CostandQtyAdj))) == null)
            {
                frm = new CostandQtyAdj();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
 
        }
        private void barButtonItem66_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            DataSyncForm frm = null;
            if ((frm = (DataSyncForm)IsFormAlreadyOpen(typeof(DataSyncForm))) == null)
            {
                frm = new DataSyncForm();
                frm.OnlyDataupload = true;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
            opentab = 2;
        }
        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;


            RptStockReport frm = null;
            if ((frm = (RptStockReport)IsFormAlreadyOpen(typeof(RptStockReport))) == null)
            {
                frm = new RptStockReport();
                frm.LoadStockAsOf();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
 
        }
        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            RptInventoryTransfer frm = null;
            if ((frm = (RptInventoryTransfer)IsFormAlreadyOpen(typeof(RptInventoryTransfer))) == null)
            {
                frm = new RptInventoryTransfer();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
 
        }
        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            RptSupplierwiseshorting frm = null;
            if ((frm = (RptSupplierwiseshorting)IsFormAlreadyOpen(typeof(RptSupplierwiseshorting))) == null)
            {
                frm = new RptSupplierwiseshorting();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            RptStockReport frm = null;
            if ((frm = (RptStockReport)IsFormAlreadyOpen(typeof(RptStockReport))) == null)
            {
                frm = new RptStockReport();
                frm.LoadNegativeStockAsOf();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            FrmInventoryNotMatching frm = null;
            if ((frm = (FrmInventoryNotMatching)IsFormAlreadyOpen(typeof(FrmInventoryNotMatching))) == null)
            {
                frm = new FrmInventoryNotMatching();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem79_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            RptMultiPrice frm = null;
            if ((frm = (RptMultiPrice)IsFormAlreadyOpen(typeof(RptMultiPrice))) == null)
            {
                frm = new RptMultiPrice();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem80_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            RptItemExpiry frm = null;
            if ((frm = (RptItemExpiry)IsFormAlreadyOpen(typeof(RptItemExpiry))) == null)
            {
                frm = new RptItemExpiry();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;
            YearEndProcess frm = null;
            if ((frm = (YearEndProcess)IsFormAlreadyOpen(typeof(YearEndProcess))) == null)
            {
                frm = new YearEndProcess();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 2;

            OpeningComp frm = null;
            if ((frm = (OpeningComp)IsFormAlreadyOpen(typeof(OpeningComp))) == null)
            {
                frm = new OpeningComp();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        #endregion
        #region Master Ribbon
        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 3;

            Storemast frm = null;
            if ((frm = (Storemast)IsFormAlreadyOpen(typeof(Storemast))) == null)
            {
                frm = new Storemast();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 3;

            ItemCategory frm = null;
            if ((frm = (ItemCategory)IsFormAlreadyOpen(typeof(ItemCategory))) == null)
            {
                frm = new ItemCategory();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 3;

            UserInfo frm = null;
            if ((frm = (UserInfo)IsFormAlreadyOpen(typeof(UserInfo))) == null)
            {
                frm = new UserInfo();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 3;

            UserProfiles frm = null;
            if ((frm = (UserProfiles)IsFormAlreadyOpen(typeof(UserProfiles))) == null)
            {
                frm = new UserProfiles();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 3;

            CommissionSetup frm = null;
            if ((frm = (CommissionSetup)IsFormAlreadyOpen(typeof(CommissionSetup))) == null)
            {
                frm = new CommissionSetup();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        #endregion
        #region Utilities - Ribbon
        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 4;
            DataDisk frm = null;
            if ((frm = (DataDisk)IsFormAlreadyOpen(typeof(DataDisk))) == null)
            {
                frm = new DataDisk();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.LoadGridList();
                frm.Select();
            }
           
        }
        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 4;
            BarCodePrint frm = null;
            if ((frm = (BarCodePrint)IsFormAlreadyOpen(typeof(BarCodePrint))) == null)
            {
                frm = new BarCodePrint();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem47_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 4;
            DataSyncForm frm = null;
            if ((frm = (DataSyncForm)IsFormAlreadyOpen(typeof(DataSyncForm))) == null)
            {
                frm = new DataSyncForm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
 
        }
        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 4;
            Drugdispatch frm = null;
            if ((frm = (Drugdispatch)IsFormAlreadyOpen(typeof(Drugdispatch))) == null)
            {
                frm = new Drugdispatch();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem68_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new SetPrinterSettings();
            frm.ShowDialog();
        }
        private void barButtonItem77_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 4;
            FrmPromotion frm = null;
            if ((frm = (FrmPromotion)IsFormAlreadyOpen(typeof(FrmPromotion))) == null)
            {
                frm = new FrmPromotion();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem78_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 4;
            CustomerDisplaySetup frm = null;
            if ((frm = (CustomerDisplaySetup)IsFormAlreadyOpen(typeof(CustomerDisplaySetup))) == null)
            {
                frm = new CustomerDisplaySetup();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        #endregion
        #region Admin - Ribbon
        private void barButtonItem50_ItemClick(object sender, ItemClickEventArgs e)
        {
            //PivotConSolidateSales frm1 = null;
            //if ((frm1 = (PivotConSolidateSales)IsFormAlreadyOpen(typeof(PivotConSolidateSales))) == null)
            //{
            //    frm1 = new PivotConSolidateSales();
            //    frm1.MdiParent = this;
            //    frm1.Show();
            //}
            //else
            //{
            //    frm1.Select();
            //}
            //opentab = 1;
            opentab = 5;
            RptDailySalesReport frm = null;
            if ((frm = (RptDailySalesReport)IsFormAlreadyOpen(typeof(RptDailySalesReport))) == null)
            {
                frm = new RptDailySalesReport();
                frm.MdiParent = this;
                frm._usemultistore = true;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
            

        }
        private void barButtonItem69_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 5;
            PivotSales frm = null;
            if ((frm = (PivotSales)IsFormAlreadyOpen(typeof(PivotSales))) == null)
            {
                frm = new PivotSales();
                frm.MdiParent = this;
                frm._usemultistore = true;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
        }
        private void barButtonItem73_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 5;
            RptInsuranceSalesDetails frm = null;
            if ((frm = (RptInsuranceSalesDetails)IsFormAlreadyOpen(typeof(RptInsuranceSalesDetails))) == null)
            {
                frm = new RptInsuranceSalesDetails();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem74_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 5;
            RptCashCreditSales frm = null;
            if ((frm = (RptCashCreditSales)IsFormAlreadyOpen(typeof(RptCashCreditSales))) == null)
            {
                frm = new RptCashCreditSales();
                frm.LoadReport(3);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem71_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 5;
            RptPromotionSalesRpt frm = null;
            if ((frm = (RptPromotionSalesRpt)IsFormAlreadyOpen(typeof(RptPromotionSalesRpt))) == null)
            {

                frm = new RptPromotionSalesRpt();
                frm._usemultistore = true;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem75_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 5;
            RptSummarySalesTarget frm = null;
            if ((frm = (RptSummarySalesTarget)IsFormAlreadyOpen(typeof(RptSummarySalesTarget))) == null)
            {
                frm = new RptSummarySalesTarget();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem51_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 5;
            ConsolidatedInventory frm = null;
            if ((frm = (ConsolidatedInventory)IsFormAlreadyOpen(typeof(ConsolidatedInventory))) == null)
            {
                frm = new ConsolidatedInventory();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem72_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 5;
            FrmStockComparision frm = null;
            if ((frm = (FrmStockComparision)IsFormAlreadyOpen(typeof(FrmStockComparision))) == null)
            {
                frm = new FrmStockComparision();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        private void barButtonItem54_ItemClick(object sender, ItemClickEventArgs e)
        {
            opentab = 5;
            TransferList frm = null;
            if ((frm = (TransferList)IsFormAlreadyOpen(typeof(TransferList))) == null)
            {
                frm = new TransferList();
                frm._usemultistore = true;
                frm.LoadInMainWindow += frm_LoadInMainWindow;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Select();
            }
         }
        #endregion


        public static Form IsFormAlreadyOpen(Type FormType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(OpenForm => OpenForm.GetType() == FormType);
        }
        private void FrmMainFromNew_Load(object sender, EventArgs e)
        {
            //ribbonPage6
            barcomp.Caption = VIRETAILDAL.COMMON.Utils.Companyname;
           if(VIRETAILDAL.COMMON.Utils.Username.ToUpper()=="REHMAN" )
               ribbonPage6.Visible = true;

            if (VIRETAILDAL.COMMON.Utils.Company == "01")
            {
                if(VIRETAILDAL.COMMON.Utils.Username.ToUpper()=="REHMAN" || VIRETAILDAL.COMMON.Utils.Username.ToUpper()=="ASHRAF" 
                    || VIRETAILDAL.COMMON.Utils.Username.ToUpper() =="ANARUL" 
                    || VIRETAILDAL.COMMON.Utils.Username.ToUpper()=="MUSTAFA")
                    ribbonPage6.Visible = true;

            }
            if (!string.IsNullOrEmpty(VIRETAILDAL.COMMON.Utils.Sync))
            {
                if (VIRETAILDAL.COMMON.Utils.Username.ToUpper() == "REHMAN" || VIRETAILDAL.COMMON.Utils.Username.ToUpper() =="ANARUL" ||
                    VIRETAILDAL.COMMON.Utils.Username.ToUpper() == "ASHRAF" ||
                    VIRETAILDAL.COMMON.Utils.Username.ToUpper() == "MUSTAFA")
                    barButtonItem64.Visibility = BarItemVisibility.Never;
                    ShowHide();
                  //  VIRETAILDAL.COMMON.Utils.Sync = new DataManager().GetSysCode("SYNC");
            }
            else
            {
               // ribbonPageGroup14.Visible = false;
            }
            if (VIRETAILDAL.COMMON.Utils.Username.ToUpper() == "TARIK")
            {
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage4.Visible = false;
            }
        }
        void ShowHide()
        {
            if (VIRETAILDAL.COMMON.Utils.Sync == "S")
                {
                    barButtonItem62.Visibility = BarItemVisibility.Never;
                }
                if (VIRETAILDAL.COMMON.Utils.Sync == "C")
                {
                    barButtonItem62.Visibility = BarItemVisibility.Never;
                    barButtonItem63.Visibility = BarItemVisibility.Never;
                }
                else
                {
                    barButtonItem62.Visibility = BarItemVisibility.Always;
                }
        }
        void frm_LoadInMainWindow(int option, string tranid,bool usecon,string con)
        {
            //var f = new ItemMove();
            //f.Show();
            if (option == 0)
            {
                ItemMove frm = null;
                if ((frm = (ItemMove)IsFormAlreadyOpen(typeof(ItemMove))) == null)
                {
                    frm = new ItemMove();
                    frm.OtherStore = usecon;
                    frm.MdiParent = this;
                   
                    frm.Show();
                    if (!string.IsNullOrEmpty(tranid))
                    {
                      frm._tranid = tranid;
                      frm.DoView(true,usecon,con); 
                    }
                }
                else
                {
                    frm.Select();
                }
            }
            opentab = 2;
        }
        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                ribbonMain.SelectedPage = ribbonMain.MergedPages[0];
            }
            catch (Exception ex)
            {
                ribbonMain.SelectedPage = ribbonMain.Pages[opentab];
            }
        }
        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (xtraTabbedMdiManager1.Pages.Count == 0)
            {
                ribbonMain.SelectedPage = ribbonMain.Pages[opentab];
            }
        }

        private void FrmMainFromNew_KeyDown(object sender, KeyEventArgs e)
        {
    
        }

        private void barButtonItem84_ItemClick(object sender, ItemClickEventArgs e)
        {
            var fr = new FrmImp();fr.ShowDialog();
        }
        
       

        
        
      
       
       
         
        
       
       
       
        
     
       
        
 
        
    }
}