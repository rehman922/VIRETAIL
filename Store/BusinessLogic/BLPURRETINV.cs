using System;
using System.Data;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraReports.UI;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store.BusinessLogic
{
     public class Blpurretinv
     {
        public string Retinvid { get; set; }
        public string Supid { get; set; }
        public string Supname { get; set; }
        public string Invno { get; set; }
        public DateTime Trandate = DateTime.Now;
        public DateTime Invdate { get; set; }
        public int Duedays { get; set; }
        public decimal Spdiscount { get; set; }
        public decimal Adjvalue { get; set; }
        public bool Hold { get; set; }
        public string Whid { get; set; }
        public decimal Netvalue { get; set; }
        public DsPurchase.RETURNDETAILDataTable Retinvdetail;
        public DsPurchase.RETURNMASTRow RetinvmainRow;
        public  Blpurretinv(DataRow d)
        {
            var dr = (DsPurchase.RETURNMASTRow)d;
            RetinvmainRow = dr;
             if(!string.IsNullOrEmpty(dr.RETURNID))
                 Retinvid = dr.RETURNID;
            Supid = dr.SUPID;
            Supname = dr.SUPNAME;
            Invno = dr.INVNO;
            Invdate = dr.INVDATE;
            Spdiscount = dr.SPDISCOUNT;
            Adjvalue = dr.ADJVALUE;
            Hold = dr.HOLD;
            Whid = dr.WHID;
            Netvalue = dr.NETVALUE;
         // COMMON.Utils.Company;
        //  COMMON.Utils.Userid;
        }
        public  Blpurretinv(){}
        public string DoSave()
        {
            var dm = new PurReturnDataManger();
             
            var retval = dm.DoSave(RetinvmainRow, Retinvdetail);
            if (retval == "1")
            {
                Retinvid = Utils.Retinvid;
            }
           return retval;
          //string retval;
          //  SqlTransaction tran = null;
          //  var isnew = false;
          //  try
          //  {
          //      var cn = new SqlConnection(Properties.Settings.Default.POSConnectionString);
          //      cn.Open();
          //      tran = cn.BeginTransaction(IsolationLevel.ReadUncommitted);
          //      var ds = new DsInventory();
          //      var dt = ds.RETURNMAST;
          //      var dm = new DataManager();
          //      var taPurMain = new RETURNMASTTableAdapter();
          //      var taPurDetail = new RETURNDETAILTableAdapter();
          //      var taStockMaster = new STOCKMASTERTableAdapter();
          //      taStockMaster.Fill(ds.STOCKMASTER);
          //      taPurMain.Fill(ds.RETURNMAST);
          //      // Assaign Transaction
          //      taPurMain.AssignConnection(cn, tran);
          //      taPurDetail.AssignConnection(cn, tran);
          //      taStockMaster.AssignConnection(cn, tran);
          //      var dr = dt.FindByRETURNID(Retinvid);
          //      if (dr != null)
          //      { dr.BeginEdit(); }
          //      else
          //      { dr = (DsInventory.RETURNMASTRow)dt.NewRow(); }
          //      if (string.IsNullOrEmpty(Retinvid))
          //      {
          //          var autoid = dm.GetAutoId(2);
          //          autoid++;
          //          Retinvid = COMMON.Functions.CreateFormatedAutoNo(autoid);
          //          dr.RETURNID = Retinvid;
          //          dr.USERID = COMMON.Utils.Userid;
          //          dr.COMPANY = COMMON.Utils.Company;
          //          isnew = true;
          //      }
          //      else
          //      {
          //          dr.EDATE = DateTime.Now;
          //          dr.EUSERID = COMMON.Utils.Userid;
          //      }
          //      dr.SUPID = Supid;
          //      dr.SUPNAME = Supname;
          //      dr.INVDATE = Invdate;
          //      dr.INVNO = Invno;
          //      dr.SPDISCOUNT = Spdiscount;
          //      dr.WHID = Whid;
          //      dr.ADJVALUE = Adjvalue;
          //      dr.NETVALUE = Netvalue;
          //      dr.HOLD = Hold;

          //      if (isnew)
          //      {
          //          dt.Rows.Add(dr);
          //          taPurMain.Update(dt);
          //      }
          //      else
          //      {
          //          dr.EndEdit();
          //          taPurMain.Update(dr);
          //      }
          //      foreach (DataRow purd in Retinvdetail.Rows)
          //      {
          //          if ((purd.RowState != DataRowState.Deleted))
          //              purd["RETURNID"] = Retinvid;
          //      }
          //      taPurDetail.Update(Retinvdetail);
          //      if (!dr.HOLD)
          //      {
          //          COMMON.Functions.UpdateQtyInStockDataSet(ref ds, Retinvdetail,true);
          //          taStockMaster.Update(ds.STOCKMASTER);
          //      }
          //      tran.Commit();
          //      dm.UpdateAutoNum(2);
          //      retval = "1";
          //  }
          //  catch (Exception ex)
          //  {
          //      if (tran != null)
          //          tran.Rollback();
          //      if (isnew)
          //          Retinvid = string.Empty;
          //      retval = ex.ToString();
          //  }
          //  return retval;
       
        }

         public static DsPurchase.RETURNMASTDataTable GetPurRetruninvMast()
        {
            return ClsGetData.GetPurReturninvMast();
        }
        public static DsPurchase.RETURNMASTDataTable GetPurReturnHold()
        {
            return ClsGetData.GetPurReturninvMastByHold();
        }
        public static void DeletePurRetInv(string purid)
        {
            var dm = new PurReturnDataManger();
            dm.DeletePurRetInv(purid, Utils.Company);
        }
        public void GetPurRetinv()
        {
            var ds = ClsGetData.GetPurReturnInvByid(Retinvid);
            foreach (DataRow d in ds.Rows )
            {
                Supid = d["SUPID"].ToString();
                Invno = d["INVNO"].ToString();
                Invdate = DateTime.Parse(d["INVDATE"].ToString());
                //Duedays = int.Parse(d["DUEDAYS"].ToString());
                Spdiscount = decimal.Parse(d["SPDISCOUNT"].ToString());
                Adjvalue = decimal.Parse(d["ADJVALUE"].ToString());
                Netvalue = decimal.Parse(d["NETVALUE"].ToString());
                Whid = d["WHID"].ToString();
            }
            Retinvdetail = ClsGetData.GetPurRetInvDetailsById(Retinvid);
        }
        public static void DoPrint(string retinvid)
        {
            var rpt = new PurchaseRpt {Company = Utils.Companyname, Header = "Purchase Return Invoice",DueDays = false,Docno = retinvid};
            var ds = ClsGetData.RptPurchaseInv(retinvid);
            rpt.DataSource = ds;
            var  printTool = new ReportPrintTool(rpt);
            printTool.ShowPreview();

        }
    }
     public class PurRetinvError : IDXDataErrorInfo
     {
         public string Supplier { get; set; }
         public string Invoiceno { get; set; }
         public string Invoicedate { get; set; }
         public string ToStore { get; set; }
         public string Purid { get; set; }

         public void GetPropertyError(string propertyName, ErrorInfo info)
         {
             if (propertyName == "Supplier" && string.IsNullOrEmpty(Supplier)
                 || propertyName == "Invoiceno" && string.IsNullOrWhiteSpace(Invoiceno)
                 || propertyName == "Invoicedate" && string.IsNullOrEmpty(Invoicedate)
                 || propertyName == "ToStore" && string.IsNullOrEmpty(ToStore))
                 info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
         }
         public void GetError(ErrorInfo info)
         {
             // throw new NotImplementedException();
         }
     }
}
