using DevExpress.XtraEditors.DXErrorProvider;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;

namespace Store.BusinessLogic
{
    public class BlItemMaster
    {
        public DsMaster.ITEMMASTRow Itemmast;
        public string Itemno;
        public string DoSave()
        {
            var dm = new ItemMaster {ItemmastRow = Itemmast,Itemno = Itemno};
            var retval = dm.DoSave();
            if (retval == "1")
            {
                Itemno = Utils.Itemno;
            }
            return retval;
        }
        public DsMaster.ITEMMASTDataTable FindItemByBarCode(string barcode)
        {
          return  new ItemMaster().FindItemByBarCode(barcode);
        }
        public string GetItemname(string itemno)
        {
            return new ItemMaster().GetItemname(itemno);
        }
        public bool UpdateBarCode(string itemno)
        {
           return new ItemMaster().UpdateItemasBarcode(itemno);
        }
        public DsMaster.ITEMMASTDataTable GetItemMastList()
        {
          return  new ItemMaster().GetItemMastList();
        }
         public DsReports.ItemsListDataTable GetRptItemsList()
         {
             return new ItemMaster().GetRptItemsList();
         }
    }
    public class ItemMastError : IDXDataErrorInfo
    {
        public string Itemtype { get; set; }
        public string buom { get; set; }
        public string barcode { get; set; }
        public string itemname { get; set; }
        public string uom { get; set; }
        public string itemcat { get; set; }
        public string itemgroup { get; set; }
        public string supplier { get; set; }
        public int min { get; set;}
        public int max { get; set; }
        public int minpo { get; set; }
        public int maxpo { get; set; }
        public int reorder { get; set; }
        public bool ownbarcode { get; set; }
        
        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
           if (propertyName == "Itemtype" && string.IsNullOrEmpty(Itemtype) )
            {
                  info.ErrorText = "Please enter item type";
            }
            if(propertyName == "barcode" && string.IsNullOrEmpty(barcode) && ownbarcode==false )
            {
                  info.ErrorText = "Please enter barcode ";
            }
            if(propertyName == "itemname" && string.IsNullOrEmpty(itemname))
            {
                  info.ErrorText = "Please enter itemname ";
            }
            if(propertyName == "buom" && string.IsNullOrEmpty(buom))
            {
                  info.ErrorText = "Please enter base uom. ";
            }
            if (propertyName == "supplier" && string.IsNullOrEmpty(supplier))
            {
                info.ErrorText = "Please enter supplier";
            }
            if (propertyName == "uom" && string.IsNullOrEmpty(uom))
            {
                info.ErrorText = "Please enter uom. ";
            }
            if (propertyName == "itemcat" && string.IsNullOrEmpty(itemcat))
            {
                 info.ErrorText = "Please enter item category";
            }
            if(propertyName == "itemgroup" && string.IsNullOrEmpty(itemgroup))
            {
                 info.ErrorText = "Please enter item group";
            }
            if(propertyName=="min" && max > 0)
            {
                if(min > max)
                {
                    info.ErrorText = "Please check the min qty.";  
                }
            }
            if (propertyName == "max" && max > 0)
            {
                if (min > max)
                {
                    info.ErrorText = "Please check the max qty.";
                }
            }
            if (propertyName == "minpo" && maxpo > 0)
            {
                if (minpo > maxpo)
                {
                    info.ErrorText = "Please check the min qty.";
                }
            }
            if (propertyName == "maxpo" && maxpo > 0)
            {
                if (minpo > maxpo)
                {
                    info.ErrorText = "Please check the max qty.";
                }
            }

            if (propertyName == "reorder" && reorder == 0)
            {
                    info.ErrorText = "Please check the reorder qty.";
            }

        }
        public void GetError(ErrorInfo info)
        {
            // throw new NotImplementedException();
        }
    }
}
