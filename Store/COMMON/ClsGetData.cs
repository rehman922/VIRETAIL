using System;
using System.Data;
using VIRETAILDAL;
using VIRETAILDAL.DALCOMMON;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Purchasing;
using VIRETAILDAL.Sales;
using VIRETAILDAL.Transfers;
using VIRETAILENTITIES;

namespace Store.COMMON
{
    class ClsGetData
    {
        #region PurchaseOrder
        public  static  DsPurchase.POMAINDataTable GetPurchaseOrder()
        {
            return new PoDataManager().GetPoMast();
        }
        public static DsPurchase.POMAINDataTable GetPurchaseOrderById(string pono)
        {
            return new PoDataManager().GetPoMastById(pono);
        }
        public static DsPurchase.PODETAILDataTable GetPurchaseOrderDetailById(string pono)
        {
            return new PoDataManager().GetPoDetailById(pono);
        }
        public static DsPurchase.POMAIN1DataTable PosNotRecieved()
        {
           return new PoDataManager().PosNotRecieved();
        }
        #endregion
        #region PurchaseInvoice
        public static DsPurchase.PURINVMAINDataTable GetPurchaseInvByid(string purid)
        { return new PurInvDataManager().GetPurInvoiceMainById(purid); }
        public static DsPurchase.PurchaseAnalyseDataTable GetPurchaseAnalyseByItem(string itemno)
        { return new PurInvDataManager().GetItemAnalyse(itemno); }
        public static DsPurchase.PURINVMAINDataTable GetPurinvMast()
        {
            return new PurInvDataManager().GetPurInvoiceMain();
        }
        public static DsPurchase.PURINVMAINDataTable GetPurinvMastByHold()
        {
            return new PurInvDataManager().GetPurchaseInvoiceByHold();
        }
        public static int GetPurchaseHoldCount()
        {
            return new PurInvDataManager().GetPurchaseHoldCount();
        }
        #endregion
        #region PurchaseReturn
        public static DsPurchase.RETURNMASTDataTable GetPurReturninvMast()
        {
            return new  PurReturnDataManger().GetPurRetMain();
        }
        public static DsPurchase.RETURNMASTDataTable GetPurReturninvMastByHold()
        {
            return new PurReturnDataManger().GetPurRetMainByHold();
        }
        public static int GetPurchaseReturnHoldCount()
        {
            return new PurReturnDataManger().GetPurchaseReturnHoldCount();
        }
        public static DsPurchase.RETURNMASTDataTable GetPurReturnInvByid(string retid)
        {
            return new PurReturnDataManger().GetPurRetInvMainById(retid);
        }
        public static DsPurchase.RETURNDETAILDataTable GetPurRetInvDetailsById(string retid)
        {
            return new PurReturnDataManger().GetPurRetInvDetailsById(retid);
        }
        public static  DsReports.RptPurchaseReturnDataTable RptPurchaseInv(string retinvid)
        {
            return new PurReturnDataManger().RptPurchaseInv(retinvid, VIRETAILDAL.COMMON.Utils.Company);
        }
        #endregion
        #region Lists
         public static DsInventory.ITEMMAST1DataTable GetItemMast1List()
            { return new DataManager().GetItemMastList(); }
         public static DsInventory.ADJMASTDataTable GetInventoryList()
            {
                return new InventoryAjdDataManager().GetInventoryList();
            }
         public static DsInventory.SUPPLIERDataTable GetSupplier()
            { return new DataManager().GetSupplier(); }
         public static DsInventory.STOCKMASTERDataTable GetStockMaster()
                { return new DataManager().GetStockMaster(); }
         public static DsInventory.WAREHOUSEMAST1DataTable GetWareHouseNames()
        {
            return new DataManager().GetWareHouseNames();
        }
         public static DsInventory.NOTESMASTRow GetNotes(string supid,int soruceid)
        {
            var dm = new NotesDataManger();
            dm.GetNotes(supid, soruceid);
            return dm.DNotesmastRow;
        }
         public static DsMaster.STOREMASTDataTable GetMyWareHouses()
         {
            return new StoreManager().GetMyWareHouses();
         }
         public static DsMaster.STOREMASTDataTable GetAllSalesStore()
         {
             return new StoreManager().GetAllSalesStore();
         }
        #endregion
        #region Masters
        public static DsMaster.STOREMASTDataTable GetStoreList()
        {
            return new StoreManager().GetStoreList();
        }
        public static DsMaster.ITEMGROUPDataTable GetItemGroup()
        {
            return new DataManager().GetItemGroup().ITEMGROUP;
        }
        public static DsMaster.ITEMMASTDataTable GetItemMastList()
        {
            return new DataManager().GetItemMast();
        }
        public static DsMaster.UOMMASTDataTable GetUom()
        { return new DataManager().GetUom().UOMMAST; }
        public static DsMaster.MastMoveTypesDataTable GetMoveTypes()
        {
            return new DataManager().GetMoveTypes();
        }
        public static int GetNotesCount(string supid,int sourceid)
        {
            return new NotesDataManger().GetNotesCount(supid, sourceid);
        }
        public static DsMaster.PAYTYPEMASTDataTable GetPaymentTypes()
        {
            return new DataManager().GetPaymentTypes();
        }
        public static DsMaster.CUSTOMERDataTable GetCustomerList()
        {
            return new VIRETAILDAL.Masters.Customer().GetCustomerList();
        }
        public static DsMaster.INSURANCEDISCDataTable GetInsuranceByCust(string custno)
        {
            return new VIRETAILDAL.Masters.Customer().GetInsuranceByCust(custno);
        }
        #endregion
        #region  Item Transfer
        public static DsInventory.ITEMTRANSFERMAINDataTable GetItemTransfer()
        {
            return new ItemMoveDataManager().GetItemTransfer();
        }
        public static DsInventory.ITEMTRANSFERMAINDataTable GetItemTransferById(string tranid, bool othercomp = false, string concomp = "")
        {
            return new ItemMoveDataManager().GetItemTransferByid(tranid,othercomp,concomp);
        }
        public static DsInventory.ITEMTRANSFERDETAILDataTable GetItemTransferDetailById(string tranid, bool othercomp = false, string concomp = "")
        {
            return new ItemMoveDataManager().GetItemTransferDetailById(tranid, othercomp , concomp);
        }
        public static DsReports.TranferItemListWithItemnameDataTable TranferItemListWithItemname(string tranid)
        {
            return new ItemMoveDataManager().TranferItemListWithItemname(tranid);
        }
        public static DsReports.ITEMTRANSFERMAINLISTDataTable ItemTranferMainListForHist(bool frmstore, DateTime d1, DateTime d2, bool useothercomp = false, string concomp = "", string compcode = "")
        {
            return new ItemMoveDataManager().ItemTranferMainListForHist(frmstore,d1,d2,useothercomp,concomp,compcode);
        }

        public static DsReports.InventoryTransferDetailsDataTable GetInventoryTransferDetails(bool frmstore, DateTime d1, DateTime d2, string store, bool useothercomp = false, string concomp = "")
        {
            return new ItemMoveDataManager().GetInventoryTransferDetails(frmstore, d1, d2, store,useothercomp,concomp);
        }
        public static DsReports.ITEMTRANSFERMAINLISTDataTable  ItemTranferMainListForHist(bool frmstore=false)
        {
            return new ItemMoveDataManager().ItemTranferMainListForHist(frmstore);
        }


        public static DsInventory.ITEMTRANSFERMAINDataTable GetItemTransferByHold()
        {
            return new ItemMoveDataManager().GetItemTransferByHold();
        }
        public static DsInventory.ITEMTRANSFERMAINDataTable GetItemTransferFileNotGenereted()
        {
            return new ItemMoveDataManager().GetItemTransferFileNotGenereted();
        }
        public static string GetItemname(string itemno)
        {
            return new ItemMaster().GetItemname(itemno);
        }
        #endregion
        public static string GetDefaultSupplier(string itemno)
        {
          return   new ItemMaster().GetDefaultSupplier(itemno);
        }
        public static DsInventory.ADJMASTDataTable GetAdjMastById(string adjid)
        {
            return new InventoryAjdDataManager().GetAdjMastById(adjid);
        }
        public static DsInventory.ADJDETAILDataTable GetAdjDetailById(string adjid)
        {
            return new InventoryAjdDataManager().GetAdjDetailById(adjid);
        }
        public static DsMaster.PRINTERSDataTable GetPrinters()
        {
           return new DefaultPrinters().GetPrinters();
        }
        public static DsMaster.USERINFODataTable GetEmployees()
        {
            return new VIRETAILDAL.Masters.UserInfo().GetUserInfo();
        }
        public static int GetSessionUser(int utype)
        {
           return new VIRETAILDAL.Masters.UserInfo().GetSessionUser(utype);
        }
        public static DsMaster.COMPANYDataTable GetCompanies(bool isdefault=false)
        {
            return new Company().GetCompanies(isdefault);
        }
        public static DsMaster.MENUNEWDataTable LoadMenu(string ids)
        {
          return new  DataManager().LoadMenu(ids);
        }
        public static DsMaster.PROFILESDataTable LoadProfiles()
        {
           return new Profiles().LoadProfiles();
        }
        public static DsMaster.PROFILENAMEMASTDataTable LoadProfileNameMast()
        {
           return new ProfileNames().LoadProfileNames();
        }
        public static DsInventory.SALESMAINDataTable GetHoldedSalesInvoices(string compname)
        {
           return new SalesManger().GetHoldedInvoices(compname);
        }
        public static string GetSysCode(string scode)
        {
            return new DataManager().GetSysCode(scode);
        }
        public static void UpdateSysCode(string scode,string source="SHIFT")
        {
            new DataManager().UpdateSysCode(scode,source);
        }

        public static void CheckSysCode(string source)
        {
            new DataManager().CheckSysCode(source);
        }
        public static Ledgers.DAILYCLOSINGDataTable GetDailyClosing()
        {  return new VIRETAILDAL.Masters.DailyClosing().GetDailyClosing();}
        public static Ledgers.COMMISIONMASTDataTable GetCommissionMast(string commid = null, bool useconstr = false, string newconstr = "p")
        {return new VIRETAILDAL.Masters.CommissionSetup().GetCommissionMast(commid, useconstr, newconstr);}
        public static Ledgers.COMMISIONDETAILDataTable GetCommissionDetail(string commid=null,bool isRemote=false)
        { return new VIRETAILDAL.Masters.CommissionSetup().GetCommissionDetail(commid,isRemote); }
        public static DsMaster.USERINFODataTable GetUserInfo(bool useremote=false,string constr="N")
        {
               return new VIRETAILDAL.Masters.UserInfo().GetUserInfo(useremote,constr);
        }
        public static DsMaster.USERINFO1DataTable GetUserInfoCommission(bool useremote = false, string constr = "N")
        {
            return new VIRETAILDAL.Masters.UserInfo().GetUserInfoCommission(useremote, constr);
        }
        public static DsReports.GetStockListDataTable GetStockListDataTableProc()
        {
            return new StockMaster().GetStockListDataTableProc();
        }
        public static DsReports.GetStockItemsForTransferDataTable GetStockItemsForTransferDataTable (string comp, string whid,bool iszeroqty=false)
        {
            return new StockMaster().GetStockItemsForTransferDataTable(comp, whid, iszeroqty);
        }
        public static DsMaster.DISCOUNTNAMESDataTable GetDiscountNames()
        {
            return new DataManager().GetDiscountNames();
        }
        public static DsReports.PurchaseBonusDataTable GetPurchaseBonus(DateTime d1, DateTime d2)
        {
           return new  PurInvDataManager().GetPurchaseBonus(d1, d2);
        }
        public static DsReports.RptItemPurchaseDetailsDataTable GetRptItemPurchaseDetails(string itemno, DateTime d1, DateTime d2)
         {
             return new PurInvDataManager().GetRptItemPurchaseDetails(itemno, d1, d2);  
         }
        public static DsReports.GetDataByItemGroupDataTable GetDataByItemGroup(int groupid, DateTime d1, DateTime d2)
        {
            return new PurInvDataManager().GetDataByItemGroup(groupid, d1, d2);
        }
        public static DsReports.GetItemGroupAllDataTable GetItemGroupAll(DateTime d1, DateTime d2)
         {
             return new PurInvDataManager().GetItemGroupAll(d1, d2);
         }
        public static DsReports.MultiPriceDataTable GetMultiplePrice()
        {
            return new StockMaster().GetMultiplePrice();
        }
        public static DsMaster.TEMPBCODEPRINTDataTable GetTempBcodePrint()
        {
           return new BarcodePrinting().SelectUnPrinted();
        }
        public static  void DoDeletePrinted()
        {
            new BarcodePrinting().DoDeletePrinted();
        }
        public DsMaster.TEMPBCODEPRINTDataTable CreateBarcodeList(string purinvno)
        {
            return new BarcodePrinting().CreateBarcodeList(purinvno);
        }
        public static DsReports.StockReportAsOfDataTable GetStockAsOf(string sccode="p")
        {
            return new StockMaster().GetStockAsOf(sccode);
        }

        public static DsReports.GetSTOCKMASTERDataTable GetStockmasterByGroup(int grpid)
        {
            return new StockMaster().GetStockmasterByGroup(grpid);
        }
        public static DsReports.NegativeStockAsOfDataTable NegativeStockAsOf()
        {
            return new StockMaster().NegativeStockAsOf();
        }
        public static  DsReports.PivotDailySalesDataTable LoadPivotGrid(DateTime d1,DateTime d2,bool userother=false,string cnstr="x")
        {
          return  new SalesManger().LoadPivotGrid(d1, d2,userother,cnstr);
        }
        public static DsReports.ConsolidatePivotDailySalesDataTable ConsolidateLoadPivotGrid(DateTime d1, DateTime d2)
        {
            return new SalesManger().ConsolidateLoadPivotGrid(d1, d2);
        }
        //public static DsMaster.GetAllDataBasesDataTable GetAllDataBases()
        //{
        //  return  new VIRETAILDAL.Masters.StoreManager().GetAllDataBases();
        //}

        public static DataTable GetStoresDataBases()
        {
            return new StoreManager().GetStoresDataBases();
        }

        public static  DsReports.ITEMLISTFORCONSOLIDATEINVDataTable ItemListForConsolidateInv(int option,string perm)
        {
          return  new ItemMaster().ItemListForConsolidateInv(option,perm);
        }

        public static DsReports.CONSOLIDATEINVENTORYDataTable GetConsolidateinventoryDataTable()
        {
            return  new StockMaster().GetConsolidateinventoryDataTable();
        }
        public static void DelConsolidateinventoryDataTable()
        {
              new StockMaster().DelConsolidateinventoryDataTable();
        }
        public static int SaveCosolidateInventoryRun(DsReports.CONSOLIDATEINVENTORYDataTable dt)
        {
          return new StockMaster().SaveCosolidateInventoryRun(dt);
        }
        //NegativeStockAsOf
        public static DsReports.STOREMASTDBDataTable GetAllStoresDbnames(bool issales=false)
        {
          return  new StockMaster().GetAllStoresDbnames(issales);
        }
        
    }
}
