using System;
using System.Data;
using System.Data.SqlClient;
using VIRETAILDAL.COMMON;
using VIRETAILDAL.DsPurchaseTableAdapters;
using VIRETAILENTITIES;

namespace VIRETAILDAL.Purchasing
{
   public class PoDataManager
    {
       private readonly string _constr = Utils.Connectionstring;
       public DsPurchase.POMAINRow Drow;
       public DsPurchase.PODETAILDataTable Podetail;
       public DsPurchase.POMAINDataTable GetPoMast()
        {
           var ta = new POMAINTableAdapter {Connection = {ConnectionString = _constr}};
           var ds = new DsPurchase().POMAIN;
           ta.Fill(ds);
           return ds;
        }
       public DsPurchase.POMAINDataTable GetPoMastById(string pono)
       {
           var ta = new POMAINTableAdapter { Connection = { ConnectionString = _constr } };
           var ds = new DsPurchase().POMAIN;
           ta.FillBy(ds,pono);
           return ds;
       }
       public DsPurchase.PODETAILDataTable GetPoDetailById(string pono)
        {
            var ta = new PODETAILTableAdapter { Connection = { ConnectionString = _constr } };
            var ds = new DsPurchase().PODETAIL;
            ta.FillBy(ds,pono);
            return ds;
        }
       public string DoSave()
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
                var ds = new DsPurchase();
                var dt = ds.POMAIN;
                var taPurMain = new POMAINTableAdapter();
                var taPurDetail = new PODETAILTableAdapter();
                taPurMain.Connection.ConnectionString = _constr;

                taPurMain.Fill(dt);
                // Assaign Transaction
                taPurMain.AssignConnection(cn, tran);
                taPurDetail.AssignConnection(cn, tran);
                var dr = dt.FindByPONO(Drow.PONO);
                if (dr != null)
                { dr.BeginEdit(); }
                else
                { dr = (DsPurchase.POMAINRow)dt.NewRow(); }
                if (string.IsNullOrEmpty(Drow.PONO))
                {
                    var autoid = dm.GetAutoId(11);
                    autoid++;
                    Utils.Pono = dm.CreateFormatedAutoNo(autoid);
                    dr.PONO = Utils.Pono;
                    dr.USERID = Utils.Userid;
                    dr.COMPANY = Utils.Company;
                    dr.UDATE = DateTime.Now;
                    isnew = true;
                }
                else
                {
                    Utils.Pono = Drow.PONO;
                    dr.EDATE = DateTime.Now;
                    dr.EUSERID = Utils.Userid;
                }
                dr.TRANDATE = Drow.TRANDATE; 
                dr.SUPID = Drow.SUPID;
                dr.SUPNAME = Drow.SUPNAME;
                dr.SUPADD = Drow.SUPADD;
                dr.DELADD = Drow.DELADD;
                dr.DUEDAYS = Drow.DUEDAYS;
                dr.STORECODE = Drow.STORECODE;
                dr.EXTRDISC = Drow.EXTRDISC;
                dr.NETVALUE = Drow.NETVALUE;
                dr.PAYTERMS = Drow.PAYTERMS;
                dr.supnote = Drow.supnote;
                if (isnew)
                {
                    dt.Rows.Add(dr);
                    taPurMain.Update(dt);
                }
                else
                {
                    dr.EndEdit();
                    taPurMain.Update(dr);
                }
                foreach (DataRow purd in Podetail.Rows)
                {
                    if ((purd.RowState != DataRowState.Deleted))
                        purd["PONO"] = Utils.Pono;
                }
                taPurDetail.Update(Podetail);
                tran.Commit();
                dm.UpdateAutoNum(11);
                retval = "1";
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                if (isnew)
                    Utils.Pono = string.Empty;
                retval = ex.ToString();
            }
            return retval;
        }
       public DsReports.RptPOMainDataTable DoPrint(string pono)
       {
           var ta = new DsReportsTableAdapters.RptPOMain {Connection = {ConnectionString = _constr}};
           var ds = new DsReports().RptPOMain;
           ta.Fill(ds, pono);
           return ds;
       }
       public  void UpdatePrint(string pono)
       {
           var ta = new POMAINTableAdapter();
           ta.UpdatePrint(true, pono);
       }
       public DsPurchase.POMAIN1DataTable PosNotRecieved()
       {
           var ta = new POMAIN1TableAdapter {Connection = {ConnectionString = _constr}};
           var ds = new DsPurchase.POMAIN1DataTable();
           ta.FillNotRecd(ds);
           return ds;
       }
    }
   public class PrDataManager
   {
       private readonly string _constr = Utils.Connectionstring;
       public DsPurchase.PURCHASEREQUESTDataTable Purchaserequest;
       public string DoSave()
       {
           string retval = "0";
           SqlTransaction tran = null;
           try
           {
               var cn = new SqlConnection(_constr);
               cn.Open();
               tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
               var ds = new DsPurchase();
               var dt = ds.PURCHASEREQUEST;
               var taPurMain = new  PURCHASEREQUESTTableAdapter();
               taPurMain.Connection.ConnectionString = _constr;
              // taPurMain.Fill(dt);
             //  taPurMain.AssignConnection(cn,tran);
               taPurMain.Update(Purchaserequest);
               tran.Commit();
               retval = "1";
           }
           catch (Exception ex)
           {
               if (tran != null)
                   tran.Rollback();
               retval = ex.ToString();
           }
           return retval;
       }
       public DsPurchase.PURCHASEREQUESTDataTable GetPurchaseRequest(string prno)
       {
           var ds = new DsPurchase().PURCHASEREQUEST;
           var ta = new PURCHASEREQUESTTableAdapter {Connection = {ConnectionString = _constr}};
           ta.FillByPRNO(ds, prno);
           return ds;
       }
       public DsPurchase.PURCHASEREQUESTDataTable GetPurchaseRequestAll(DateTime d1,DateTime d2,string store=null)
       {
           var ds = new DsPurchase().PURCHASEREQUEST;
           var ta = new PURCHASEREQUESTTableAdapter { Connection = { ConnectionString = _constr } };
           if (store != null)
           {
               ta.FillMRREQLISTBYCOMP(ds, d1, d2,store);
           }
           else
           {
               ta.FILLMRREQLIST(ds, d1, d2);
   
           }
           return ds;
       }

       public DsPurchase.PURCHASEREQUESTDataTable GetPurchaseRequestList(string company=null,bool inpo=false)
       {
           var ds = new DsPurchase().PURCHASEREQUEST;
           var ta = new PURCHASEREQUESTTableAdapter { Connection = { ConnectionString = _constr } };
           if (!inpo)
           {
               if (company == null)
               {
                   ta.Fill(ds);
               }
               else
               {
                   ta.FillByComp(ds, company);
               }
           }
           if (inpo)
               ta.FillByNotInPO(ds);
           return ds;
       }
       public void DoUpdateSync()
       {
          new PURCHASEREQUESTTableAdapter { Connection = { ConnectionString = _constr } }.UpdateSync();
       }
       public DsPurchase.PURCHASEREQUESTDataTable GetPurchaseRequstNotSync()
       {
          return new PURCHASEREQUESTTableAdapter { Connection = { ConnectionString = _constr } }.GetDataByNotUploaded();
       }
       public DsPurchase.PURCHASEREQUESTDataTable GetPurchaseRequestListForMMR(string store)
       {
           var ds = new DsPurchase().PURCHASEREQUEST;
           var ta = new PURCHASEREQUESTTableAdapter { Connection = { ConnectionString = _constr } };
               ta.FillByTOMMR(ds, store);
           return ds;
       }
       public void UpdateMaterialRequestTrans(DsPurchase.PURCHASEREQUESTDataTable dt,string tranid)
       {
           var ta = new PURCHASEREQUESTTableAdapter { Connection = { ConnectionString = _constr } };
           foreach (DsPurchase.PURCHASEREQUESTRow dr in dt.Rows)
           {
               ta.UpdateInOrder(tranid, dr.TID);
           }
       }

       public bool GetInorderStatus(int tid)
       {
           var ds = new DsPurchase.PURCHASEREQUESTDataTable();
           bool retval = false;
           var ta = new PURCHASEREQUESTTableAdapter {Connection = {ConnectionString = _constr}}.FillByTID(ds, tid);
           foreach (DsPurchase.PURCHASEREQUESTRow dr in ds.Rows)
           {
               if(!dr.IsISSUEDNull())
                   retval = dr.INORDER;
           }
           return retval;
       }
   }
}
