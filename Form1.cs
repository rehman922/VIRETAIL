using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Store;
using DevExpress.XtraSplashScreen;
using System.Threading;
namespace VIRETAILSTORE
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void businessTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmBusinessTypes();
            f.Show();
        }
        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frmcurrency();
            f.Show();
        }
        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmCompany();
            f.Show();
        }
        private void posTool1_Load(object sender, EventArgs e)
        {
        }
        private void anToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Store.ItemCategory();
             f.Show();
        }
        private void purinvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var f = new Store.PurchaseInvoice();
           // f.Show();
        }
        private void termsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Terms();
            f.Show();
        }
        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var f = new Groups();
            //f.Show();
        }
        private void itemMastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Store.ItemMast();
            f.Show();
        }
        private void storemasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void storemasterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new Storemast();
            f.Show();
        }
        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ItemMast();
            f.Show();
        }
        private void genericToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Genericmast();
            f.Show();
        }
        private void uOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new UOMMAST();
            f.Show();
        }
        private void itemGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ItemGroup();
            f.Show();
        }
        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var f = new Warehouselist();
            //var f = new Store.PurchaseInvoiceN();
            //f.Show();
        }
        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var f = new PurchaseReturn();
            var f = new NewPurReturn();
            f.Show();
        }
        private void inventoryTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
        private void inventoryAdjustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var f = new InventoryAdjust();
            //f.ShowDialog();
        }
        private void mastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void purchaseInvoiceNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new NewPurInv();
            f.Show();
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new UserInfo();
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
           //// The splash screen will be opened in a separate thread. To interact with it, use the SendCommand method.
           // for (int i = 1; i <= 100; i++)
           // {
           //     SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, i);
           //     Thread.Sleep(25);
           // }
           // // Close the Splash Screen.
           // SplashScreenManager.CloseForm(false);
           // var frm = new Login();
           // frm.ShowDialog();
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
            if(Properties.Settings.Default.useposdata)
                VIRETAILDAL.COMMON.Utils.Connectionstring = Properties.Settings.Default.conmain;
            else
                VIRETAILDAL.COMMON.Utils.Connectionstring = Properties.Settings.Default.POSConnectionString;

            VIRETAILDAL.COMMON.Utils.ConnectionstringSync = Properties.Settings.Default.RemoteServer;
            //RemoteServer

            AppDomain MyDomain = AppDomain.CurrentDomain;
            Assembly[] AssembliesLoaded = MyDomain.GetAssemblies();
            //int i = 0;
            //AssembliesLoaded.Count()
            foreach (Assembly MyAssembly in AssembliesLoaded)
            {
                SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, MyAssembly.FullName);
                Thread.Sleep(100);
                // }
                // // Close the Splash Screen.
            }
            SplashScreenManager.CloseForm(false);
            var frm = new Login();
            frm.ShowDialog();
           if(!frm.LoginSucess)
           {
               Close();
           }
            if(VIRETAILDAL.COMMON.Utils.UserType==1)
            {
                purchasingReportsToolStripMenuItem.Enabled = false;
                purchasingToolStripMenuItem.Enabled = false;
                utilitiesToolStripMenuItem.Enabled = false;
                mastersToolStripMenuItem1.Enabled = false;
                inventoryToolStripMenuItem.Enabled = false;
            }
        }
        private void baseFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new BasePurInvoice();
            f.ShowDialog();
        }
        private void itemTrasnferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ItemMove();
            f.ShowDialog();
        }
        private void dataDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DataDisk();
            f.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new NewPurInv();
            f.Show();
        }
        private void purchaseReturnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new NewPurReturn();
            f.ShowDialog();
        }
        private void inventoryTransferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new TransferList();
            f.Show();
            //var f = new ItemMove();
            //f.ShowDialog();
        }
        private void diskCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DataDisk();
            f.Show();
        }
        private void supplierSetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new Store.SupplierSetUp();
            f.Show();
        }
        private void itemMastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new ItemList();
            f.Show();
         
        }
        private void itemReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ItemDownLoad();
            f.ShowDialog();
        }
        private void storeMastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Storemast();
            f.ShowDialog();
        }
        private void purchaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new PurList();
            f.Show();
        }
        private void inventoryAdjustToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new CostandQtyAdj();
            f.Show();
        }
        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptPurchase();
            f.RptType = true;
            f.Show();
        }
        private void purchaseReturnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var f = new RptPurchase();
            f.RptType = false;
            f.Show();
        }
        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new PurchaseOrder();
            f.ShowDialog();
        }
        private void itemCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ItemCategory();
            f.Show();
        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new BarCodePrint();
            f.Show();
        }
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Customer();
            f.Show();
        }
        private void setPrintersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SetPrinterSettings();
            f.Show();
        }
        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new UserInfo();
            f.Show();
        }
        private void permissionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new UserProfiles();
            f.Show();
        }
        private void barcodePrintTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new BarCodePrint();
            f.Show();
        }
        private void dailySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptDailySalesReport();
            f.ShowDialog();
        }
        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var f = new RetailSales1();
            f.Show();
        }
        private void shiftCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ShiftCode();
            f.ShowDialog();
        }
        private void dataConvertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FetchData();
            f.ShowDialog();
        }
        private void closeShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DailyClosing();
            f.ShowDialog();
        }
        private void teToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // Server=PHSERVER\SQLPOS;Database=POS;User ID=SA;Password=mutawa2011 
            var cstr ="Data Source=78.93.190.90,1433;Network Library=DBMSSOCN;;Database=POS;User ID=SA;Password=mutawa2011";
            var sql = "select count(*) from stockmaster";
            var ta = new System.Data.SqlClient.SqlDataAdapter();
            var cmd = new System.Data.SqlClient.SqlCommand();
            var cn = new System.Data.SqlClient.SqlConnection();
        }
        private void commisionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CommissionSetup(); //  var frm = new CommionSetup()
            frm.ShowDialog();
        }
        private void supplierWiseShortingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new RptSupplierwiseshorting();
            frm.Show();
        }
        private void purchaseRequestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new PurchaseRequestList();
            frm.LoadPurchaseData();
            frm.Show();
        }
        private void itemMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new RptItemMove();
            frm.Show();
        }
        private void returnSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new RptItemReturn();
            frm.Show();
        }
        private void itemWiseSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new RptItemWiseSales();
            frm.Show();
        }
        private void customerReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new CustomerPayment();
            f.ShowDialog();
        }
        private void creditSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptCashCreditSales();
            f.LoadReport(2);
            f.Show();
        }
        private void cashSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptCashCreditSales();
            f.LoadReport(1);
            f.Show();
        }
        private void printerSetupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SetPrinterSettings();
            f.ShowDialog();
        }
        private void syncornizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DataSyncForm();
            f.Show();
        }
        private void bonusReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptBonusReport();
            f.Show();
        }
        private void itemWisePurchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptItemPurchaseDetails();
            f.Show();
        }
        private void supplierWisePurchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptItemGroupWise();
            f.ShowDialog();
        }

        private void inventoryTransferReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptInventoryTransfer();
            f.ShowDialog();
        }
        private void smartDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SmartDevices();
            f.ShowDialog();
        }
        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptStockReport();
            f.LoadStockAsOf();
            f.Show();
        }
        private void negativeStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptStockReport();
            f.LoadNegativeStockAsOf();
            f.Show();
        }
        private void cancelSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptCancelSale();
            f.Show();
        }

        private void itemHisoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detailHistroyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseProfitReprotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void itemInventoryTransfterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new PivotSales();
            f.Show();
        }

        private void setupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new MainMenu();
            f.ShowDialog();
        }

        private void openingStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new YearEndProcess();
            f.ShowDialog();
        }

        private void insuranceSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptCashCreditSales();
            f.LoadReport(3);
            f.Show();
        }

        private void inventoryRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmInventoryNotMatching();
            f.Show();
        }

        private void openingComparisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new OpeningComp();
            f.Show();
        }

        private void partPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptInsuranceSalesDetails();
            f.Show();
        }

        private void paymentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new PaymentSelection();
            f.Show();
        }

        private void salesTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new RptPromotionSalesRpt();
            f.Show();
        }

        private void drugDispatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Drugdispatch();
            f.Show();
        }
    }
    public static class FormUtility
    {
        public static FormType GetInstance<FormType>() where FormType : Form, new()
        {
            FormType output = Application.OpenForms.OfType<FormType>().FirstOrDefault();
            if (output == null)
            {
                output = new FormType();
            }
            //you could add the show/bring to front here if you wanted to, or have the more general method
            //that just gives a form that you can do whatever you want with (or have one of each).
            return output;
        }
    }
}
