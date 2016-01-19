using System;
using System.Data;
using System.Data.SqlClient;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.DsInventoryTableAdapters;
using VIRETAILENTITIES;

namespace VIRETAILDAL.Purchasing
{
    public class InventoryAjdDataManager
    {
        private readonly string _constr = Utils.Connectionstring;
        public  string DoSave(DsInventory.ADJMASTRow drow,
                            DsInventory.ADJDETAILDataTable adjdetailDataTable)
        {
            var dm = new DataManager();
            string retval;
            SqlTransaction tran = null;
            var isnew = false;
            try
            {
                var cn = new SqlConnection(_constr);
                cn.Open();
                tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
                var ds = new DsInventory();
                var dt = ds.ADJMAST;
                var taAdjMast = new ADJMASTTableAdapter();
                var taAdjDetail = new ADJDETAILTableAdapter();
                var taStockMaster = new STOCKMASTERTableAdapter();
                taStockMaster.Connection.ConnectionString = _constr;
                taAdjMast.Connection.ConnectionString = _constr;
                taStockMaster.Fill(ds.STOCKMASTER);
                taAdjMast.Fill(ds.ADJMAST);
                // Assaign Transaction
                taAdjMast.AssignConnection(cn, tran);
                taAdjDetail.AssignConnection(cn, tran);
                taStockMaster.AssignConnection(cn, tran);
                var dr = dt.FindByADJID(drow.ADJID);
                if (dr != null)
                {
                    dr.BeginEdit();
                }
                else
                {
                    dr = (DsInventory.ADJMASTRow )dt.NewRow();
                }
                if (string.IsNullOrEmpty(drow.ADJID))
                {
                    var autoid = dm.GetAutoId(10);
                    autoid++;
                    Utils.Adjid = dm.CreateFormatedAutoNo(autoid);
                    dr.ADJID = Utils.Adjid;
                    dr.USERID = Utils.Userid;
                    dr.COMPANY = Utils.Company;
                    isnew = true;
                }
                else
                {
                    Utils.Adjid = drow.ADJID;
                }
                dr.STORECODE = drow.STORECODE;
                dr.TRANDATE = drow.TRANDATE;
                dr.REASON = drow.REASON;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    taAdjMast.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    taAdjMast.Update(dr);
                }
                foreach (DataRow purd in adjdetailDataTable.Rows)
                {
                    if ((purd.RowState != DataRowState.Deleted))
                        purd["ADJID"] = Utils.Adjid;
                }
                taAdjDetail.Update(adjdetailDataTable);
                Masters.StockMaster.UpdateInventoryItem(ref ds, adjdetailDataTable);
                taStockMaster.Update(ds.STOCKMASTER);
                tran.Commit();
                dm.UpdateAutoNum(10);
                retval = "1";
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                if (isnew)
                    Utils.Adjid = string.Empty;
                retval = ex.ToString();
            }
            return retval;
        }

        public DsInventory.ADJMASTDataTable GetInventoryList()
        {
            var ta = new ADJMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory().ADJMAST;
            ta.Fill(ds);
            return ds;
        }
        public  DsInventory.ADJMASTDataTable GetAdjMastById(string  adjid)
        {
            var ta = new ADJMASTTableAdapter();
            ta.Connection.ConnectionString = _constr;
            var ds = new DsInventory().ADJMAST;
            ta.FillBy(ds, adjid, Utils.Company);
            return ds;
        }
        public DsInventory.ADJDETAILDataTable GetAdjDetailById(string adjid)
        {
            var ta = new ADJDETAILTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory().ADJDETAIL;
            ta.FillBy(ds, adjid);
            return ds;
        }

    }
}
