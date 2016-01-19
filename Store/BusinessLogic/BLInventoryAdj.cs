using Store.COMMON;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store.BusinessLogic
{
    public class BLInventoryAdj
    {
        public string Adjid { get; set;}
        public DsInventory.ADJMASTRow AdjmastRow {get; set;}
        public DsInventory.ADJDETAILDataTable AdjdetailDataTable {get; set; }
        public string DoSave()
        {
          var t = new InventoryAjdDataManager().DoSave(AdjmastRow, AdjdetailDataTable);
          if(t=="1")
          {
              Adjid = Utils.Adjid;
          }
          return t;
        }
        public static DsInventory.ADJMASTDataTable  GetInventoryList()
        {
            { return ClsGetData.GetInventoryList(); }
        }
        public void GetInventoryByTranid()
        {
            var ds = ClsGetData.GetAdjMastById(Adjid);
            foreach (DsInventory.ADJMASTRow d in ds.Rows)
            {
                AdjmastRow = d;
                Adjid = d["ADJID"].ToString();
            }
            AdjdetailDataTable = ClsGetData.GetAdjDetailById(Adjid);
        }

    }
}
