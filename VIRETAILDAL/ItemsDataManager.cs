using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VIRETAILDAL.DsInventoryTableAdapters;

namespace VIRETAILDAL
{
   public class ItemsDataManager
   {
       #region ItemType

       public VIRETAILENTITIES.DsInventory GetItemMast()
       {
           var ta = new VIRETAILDAL.DsInventoryTableAdapters.ITEMMASTTableAdapter();
           var catds = new VIRETAILENTITIES.DsInventory();
           ta.Fill(catds.ITEMMAST);
           return catds;
       }
       public VIRETAILENTITIES.DsInventory GetBOM()
       {
           var ta = new VIRETAILDAL.DsInventoryTableAdapters.BOMMASTTableAdapter();
           var catds = new VIRETAILENTITIES.DsInventory();
           ta.Fill(catds.BOMMAST);
           return catds;
       }
       public VIRETAILENTITIES.DsInventory GetItemMastList()
       {
           var ta = new VIRETAILDAL.DsInventoryTableAdapters.ITEMMAST1TableAdapter();
           var catds = new VIRETAILENTITIES.DsInventory();
           ta.Fill(catds.ITEMMAST1);
           return catds;
       }
       public VIRETAILENTITIES.DsInventory GetItemType()
       {
           var ta = new VIRETAILDAL.DsInventoryTableAdapters.ITEMTYPETableAdapter();
           var catds = new VIRETAILENTITIES.DsInventory();
           ta.Fill(catds.ITEMTYPE);
           return catds;
       }

       #endregion
       #region ItemCategory
       public bool SaveCategory(VIRETAILENTITIES.DsInventory itemCat)
        {
            bool saved = false;
           if (itemCat.HasChanges() && !itemCat.CATEGORY.HasErrors)
            {
                var manager = new VIRETAILDAL.DsInventoryTableAdapters.TableAdapterManager();
                manager.CATEGORYTableAdapter = new VIRETAILDAL.DsInventoryTableAdapters.CATEGORYTableAdapter();
                manager.BackupDataSetBeforeUpdate = true;
                saved = manager.UpdateAll(itemCat) > 0;
            }
            return saved;
        }
       public VIRETAILENTITIES.DsInventory GetCategory()
       {
           var ta = new VIRETAILDAL.DsInventoryTableAdapters.CATEGORYTableAdapter();
           var catds = new VIRETAILENTITIES.DsInventory();     
           ta.Fill(catds.CATEGORY);
           return catds;
        }
   #endregion
        #region ItemGroup
        public VIRETAILENTITIES.DsInventory GetItemGroup()
        {
            var ta = new VIRETAILDAL.DsInventoryTableAdapters.ITEMGROUPTableAdapter();
            var catds = new VIRETAILENTITIES.DsInventory();
            ta.Fill(catds.ITEMGROUP);
            return catds;
        }
        public bool SaveItemGroup(VIRETAILENTITIES.DsInventory itemgrp) 
       {
            bool saved = false;
         if (itemgrp.HasChanges() && !itemgrp.CATEGORY.HasErrors)
            {
                var manager = new VIRETAILDAL.DsInventoryTableAdapters.TableAdapterManager();
                manager.ITEMGROUPTableAdapter = new VIRETAILDAL.DsInventoryTableAdapters.ITEMGROUPTableAdapter();
                manager.BackupDataSetBeforeUpdate = true;
                saved = manager.UpdateAll(itemgrp) > 0;
            }
            return saved;
       }
        #endregion
        #region Generic 
        public VIRETAILENTITIES.DsInventory GetGeneric()
        {
            var ta = new VIRETAILDAL.DsInventoryTableAdapters.GENERICMASTTableAdapter();
            var catds = new VIRETAILENTITIES.DsInventory();
            ta.Fill(catds.GENERICMAST);
            return catds;
        }
        public bool SaveItemGenric(VIRETAILENTITIES.DsInventory genric)
        {
            bool saved = false;
            if (genric.HasChanges() && !genric.CATEGORY.HasErrors)
            {
                var manager = new VIRETAILDAL.DsInventoryTableAdapters.TableAdapterManager();
                manager.GENERICMASTTableAdapter = new VIRETAILDAL.DsInventoryTableAdapters.GENERICMASTTableAdapter();
                manager.BackupDataSetBeforeUpdate = true;
                saved = manager.UpdateAll(genric) > 0;
            }
            return saved;
        }
        #region UOM
        public VIRETAILENTITIES.DsInventory GetUOM()
        {
            var ta = new VIRETAILDAL.DsInventoryTableAdapters.UOMMASTTableAdapter();
            var catds = new VIRETAILENTITIES.DsInventory();
            ta.Fill(catds.UOMMAST);
            return catds;
        }
        public bool SaveUom(VIRETAILENTITIES.DsInventory uom)
        {
            bool saved = false;
            if (uom.HasChanges() && !uom.CATEGORY.HasErrors)
            {
                var manager = new VIRETAILDAL.DsInventoryTableAdapters.TableAdapterManager();
                manager.UOMMASTTableAdapter= new VIRETAILDAL.DsInventoryTableAdapters.UOMMASTTableAdapter();
                manager.BackupDataSetBeforeUpdate = true;
                saved = manager.UpdateAll(uom) > 0;
            }
            return saved;
        }
        #endregion

#endregion
        #region Supplier
        public VIRETAILENTITIES.DsInventory GetSupplier()
        {
            var ta = new VIRETAILDAL.DsInventoryTableAdapters.SUPPLIERTableAdapter();
            var catds = new VIRETAILENTITIES.DsInventory();
            ta.Fill(catds.SUPPLIER);
            return catds;
        }
        #endregion
    }
}
