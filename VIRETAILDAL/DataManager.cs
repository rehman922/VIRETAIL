using System.Data;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.DsInventoryTableAdapters;
using VIRETAILDAL.DsMasterTableAdapters;
using VIRETAILENTITIES;
using SUPPLIERTableAdapter = VIRETAILDAL.DsInventoryTableAdapters.SUPPLIERTableAdapter;

namespace VIRETAILDAL
{
    public class DataManager
    {
        private readonly string _constr = Utils.Connectionstring;
        public string CreateFormatedAutoNo(int autoid)
        {
            return Utils.Company + "-" + autoid.ToString("D5");
        }
        public string GetFormatedAutoNo(int srcid)
        {
            return CreateFormatedAutoNo(GetAutoId(srcid));
        }
        public DsMaster.PAYTYPEMASTDataTable GetPaymentTypes()
        {
            var ta = new PAYTYPEMASTTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsMaster().PAYTYPEMAST;
            ta.Fill(ds);
            return ds;
        }
        public DsMaster.WAREHOUSEMASTDataTable GetWareHouse()
        {
            
            var ta = new WAREHOUSEMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster();
            ta.Fill(ds.WAREHOUSEMAST);
            return ds.WAREHOUSEMAST;
        }
        public DsMaster.ITEMMASTDataTable GetItemMast()
        {
           return new Masters.ItemMaster().GetItemMastList();
        }
        public DsMaster GetBom()
        {
            var ta = new BOMMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var catds = new DsMaster();
            ta.Fill(catds.BOMMAST);
            return catds;
        }
        public DsInventory.ITEMMAST1DataTable GetItemMastList()
        {
            var ta = new ITEMMAST1TableAdapter {Connection = {ConnectionString = _constr}};
            var catds = new DsInventory();
            ta.Fill(catds.ITEMMAST1);
            return catds.ITEMMAST1;
        }
        public DsMaster GetItemType()
        {
            var ta = new ITEMTYPETableAdapter {Connection = {ConnectionString = _constr}};
            var catds = new DsMaster();
            ta.Fill(catds.ITEMTYPE);
            return catds;
        }
        public DsMaster.STOREMASTDataTable GetStores()
        {
            var ta = new STOREMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var storeds = new DsMaster();
            ta.Fill(storeds.STOREMAST);
            return storeds.STOREMAST;
        }
        public DsInventory.STOCKMASTERDataTable GetStockMaster()
        {
            var ta = new STOCKMASTERTableAdapter {Connection = {ConnectionString = _constr}};
            var stkds = new DsInventory();
            ta.Fill(stkds.STOCKMASTER);
            return stkds.STOCKMASTER;
        }
        public int GetAutoId(int srcid)
        {
            var ta = new AUTONOSTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory();
            ta.FillBy(ds.AUTONOS, srcid);
            return int.Parse(ds.AUTONOS[0][1].ToString());
        }
        public void UpdateAutoNum(int srcid)
        {
            var ta = new AUTONOSTableAdapter {Connection = {ConnectionString = _constr}};
            ta.UpdateQuery(srcid);
        }
            
        public bool SaveCategory(DsMaster itemCat)
        {
            bool saved = false;
           if (itemCat.HasChanges() && !itemCat.CATEGORY.HasErrors)
           {
               var manager = new DsMasterTableAdapters.TableAdapterManager  
                                 {
                                     Connection = {ConnectionString = _constr},
                                     BackupDataSetBeforeUpdate = true,
                                     CATEGORYTableAdapter = new CATEGORYTableAdapter()
                                 };
            saved = manager.UpdateAll(itemCat) > 0;
            }
            return saved;
        }
        public DsMaster GetCategory()
       {
           var ta = new CATEGORYTableAdapter {Connection = {ConnectionString = _constr}};
            var catds = new DsMaster();     
           ta.Fill(catds.CATEGORY);
           return catds;
        }
        public DsMaster GetItemGroup()
        {
            var ta = new ITEMGROUPTableAdapter {Connection = {ConnectionString = _constr}};
            var catds = new DsMaster();
            ta.Fill(catds.ITEMGROUP);
            return catds;
        }
        public bool SaveItemGroup(DsMaster itemgrp) 
       {
            bool saved = false;
         if (itemgrp.HasChanges() && !itemgrp.CATEGORY.HasErrors)
            {
                var manager = new DsMasterTableAdapters.TableAdapterManager
                                  {   Connection = {ConnectionString = _constr},
                                      ITEMGROUPTableAdapter = new ITEMGROUPTableAdapter(),
                                      BackupDataSetBeforeUpdate = true
                                  };
                saved = manager.UpdateAll(itemgrp) > 0;
            }
            return saved;
       }
        public DsMaster GetGeneric()
        {
            var ta = new GENERICMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var catds = new DsMaster();
            ta.Fill(catds.GENERICMAST);
            return catds;
        }
        public bool SaveItemGenric(DsMaster genric)
        {
            bool saved = false;
            if (genric.HasChanges() && !genric.CATEGORY.HasErrors)
            {
                var manager = new DsMasterTableAdapters.TableAdapterManager
                                  {
                                      Connection = {ConnectionString = _constr},
                                      GENERICMASTTableAdapter = new GENERICMASTTableAdapter(),
                                      BackupDataSetBeforeUpdate = true
                                  };
                saved = manager.UpdateAll(genric) > 0;
            }
            return saved;
        }
        public DsMaster GetUom()
        {
            var ta = new UOMMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var catds = new DsMaster();
            ta.Fill(catds.UOMMAST);
            return catds;
        }
        public bool SaveUom(DsMaster uom)
        {
            bool saved = false;
            if (uom.HasChanges() && !uom.CATEGORY.HasErrors)
            {
                var manager = new DsMasterTableAdapters.TableAdapterManager
                                  {   Connection = {ConnectionString = _constr},
                                      UOMMASTTableAdapter = new UOMMASTTableAdapter(), BackupDataSetBeforeUpdate = true
                                  };
                saved = manager.UpdateAll(uom) > 0;
            }
            return saved;
        }
        public DsInventory.SUPPLIERDataTable GetSupplier()
        {
            var ta = new SUPPLIERTableAdapter {Connection = {ConnectionString = _constr}};
            var catds = new DsInventory();
            ta.Fill(catds.SUPPLIER);
            return catds.SUPPLIER;
        }
        
        //public DsInventory.NOTESMASTDataTable GetNotes(string supid,string docno)
        //{
        //    var ta = new NOTESMASTTableAdapter();
        //    var ds = new DsInventory().NOTESMAST;
        //    ta.FillByID(ds, supid, docno);
        //    //ta.Fill(ds,supid,docno);
        //    return ds;
        //}
        public DsMaster.MastMoveTypesDataTable GetMoveTypes()
        {
            var ta = new MastMoveTypesTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsMaster().MastMoveTypes;
            ta.Fill(ds);
            return ds;
        }
        public DsInventory.WAREHOUSEMAST1DataTable  GetWareHouseNames()
        {
            var ta = new  WAREHOUSEMAST1TableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory().WAREHOUSEMAST1;
            ta.Fill(ds);
            return ds;
        }

        public string GetSysCode(string scode)
        {
            var ta = new Syscfg1TableAdapter {Connection = {ConnectionString = _constr}};
            return (string) ta.GetShiftCode(scode, Utils.Company);
        }
        public void UpdateSysCode(string scode,string source="SHIFT")
        {
            var ta = new Syscfg1TableAdapter { Connection = { ConnectionString = _constr } };
            ta.UpdateQuery(scode,source, Utils.Company);
        }

        public void CheckSysCode(string source)
        {            var ta = new Syscfg1TableAdapter { Connection = { ConnectionString = _constr } };

           var tt =  ta.CheckSourceAvailable(source);
            if (tt == 0)
            {
                ta.Insert(source, string.Empty,null, Utils.Company);
            }
        }
        
        public DsMaster.MENUNEWDataTable LoadMenu(string ids)
        {
           return new MENUNEWTableAdapter { Connection = { ConnectionString = _constr } }.GetDataBy(ids);
            //var ta = new MAINMENUTableAdapter { Connection = { ConnectionString = _constr } };
            //var ds = new DsMaster().MAINMENU;
            //ta.Fill(ds);
            //return ds;
        }
        public DataTable LoadMenu(string ids,bool t=false)
        {
            return new MENUNEWTableAdapter { Connection = { ConnectionString = _constr } }.GetDataBy(ids);
            //var ta = new MAINMENUTableAdapter { Connection = { ConnectionString = _constr } };
            //var ds = new DsMaster().MAINMENU;
            //ta.Fill(ds);
            //return ds;
        }

        public DataTable LoadDataSetMenu()
        {
            return new MENUNEWTableAdapter { Connection = { ConnectionString = _constr } }.GetData();
        }
        public DsMaster.SUPPLIERDataTable GetSupplierList()
        {
            var ta = new DsMasterTableAdapters.SUPPLIERTableAdapter();
            ta.Connection.ConnectionString = _constr;
            var ds = new DsMaster().SUPPLIER;
            ta.Fill(ds);
            return ds;
        }
        public bool UpdateSupplier(DataTable sTable)
        {
            var ta = new DsMasterTableAdapters.SUPPLIERTableAdapter();
            ta.Connection.ConnectionString = _constr;
            return ta.Update(sTable as DsMaster.SUPPLIERDataTable) > 0;
        }
        public  DsMaster.DISCOUNTNAMESDataTable  GetDiscountNames()
        {
            var ta = new DISCOUNTNAMESTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsMaster().DISCOUNTNAMES;
            ta.Fill(ds);
            return ds;
        }
        
    }
}
