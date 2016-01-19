using System;
using System.Data;
using DevExpress.XtraEditors.DXErrorProvider;
using Store.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store.BusinessLogic
{
    public class BlCustomer
    {
        public DsMaster.CUSTOMERRow CustomerRow;
        public DsMaster.INSURANCEDISCDataTable InsurancediscDataTable;
        public string Customerno = string.Empty;
        public bool CheckCustomerId(string custid, string custno)
            {
              return  new VIRETAILDAL.Masters.Customer().CheckCustomerId(custid,custno) ;
            }
        public string DoSave()
        {
            var dm = new VIRETAILDAL.Masters.Customer();
            dm.customerRow = CustomerRow;
            dm.insurancediscDataTable = InsurancediscDataTable;
            var retval = dm.DoSave();
            if(retval=="1")
            {
                Customerno = Utils.CustomerNo;
            }
            return retval;
        }
        public void UpdateCustomerPoints(string custid, decimal points)
        {
             new VIRETAILDAL.Masters.Customer().UpdateCustomerPoints(custid,points);
        }
        public decimal GetAvailblePoints(string custid)
        {
            return new VIRETAILDAL.Masters.Customer().GetAvailblePoints(custid);
        }
        public void GetCustomerByMemno(int custno)
        {
            var t = new VIRETAILDAL.Masters.Customer().GetCustomerByMemno(custno);
            if(t.Rows.Count > 0)
            CustomerRow = t[0];
        }
        public void UpdateCustomrePointsInServer(string custid, decimal points)
        {
            new RemoteSync().SetAvailablePoints(custid, points);
        }
        public decimal GetAvailablePointsInServer(string custid)
        {
            return new RemoteSync().GetAvailablePoints(custid);
        }
        public string UpdatePointsDetails(string custno, decimal points, string comp, DateTime dt, string sinv, decimal redimamt, bool useother = false, string cnstr = "x")
        {
            var bl = new VIRETAILDAL.Masters.Customer();
            return bl.UpdatePointsDetails(custno, points,comp,dt, sinv,redimamt,useother,cnstr);
        }
    }
    public class CustomerError : IDXDataErrorInfo
    {
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerNo { get; set; }
        public string MemberNo { get; set; }
         
        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            if (propertyName == "CustomerType" && string.IsNullOrEmpty(CustomerType))
            {
                info.ErrorText = "Please enter customer type";
            }
            if (propertyName == "CustomerName" && string.IsNullOrEmpty(CustomerName))
            {
                info.ErrorText = "Please enter customer name ";
            }
            if(propertyName=="MemberNo" && !string.IsNullOrEmpty(CustomerType))
            {
                if (CustomerType == "0")
                {
                     if(string.IsNullOrEmpty(MemberNo))
                    {
                        info.ErrorText = "Please enter member no ";  
                    }
                }
            }
            if (propertyName == "CustomerId" && string.IsNullOrEmpty(CustomerId))
            {
                info.ErrorText = "Please enter mobile no ";
            }
            else if (propertyName == "CustomerId" && !string.IsNullOrEmpty(CustomerId))
            {
               if (new BlCustomer().CheckCustomerId(CustomerId, CustomerNo))
               {
                   info.ErrorText = "Duplicate mobile no ";
               }
            }
            


        }
        public void GetError(ErrorInfo info)
        {
            // throw new NotImplementedException();
        }
    }
    public class BlProfiles
    {
        public DsMaster.PROFILESRow ProfilenamesRow;
        public string DoSave()
        {
            var dm = new Profiles {ProfilenamesRow = ProfilenamesRow};
            return  dm.DoSave();
        }
    }
    public class BlProfileNames
    {
        public string DoSave(string pname)
        {
            return new ProfileNames().DoSave(pname);
        }
    }
    public class BlBanks
    {
        public string DoSave(string bankname)
        {
            return new BankNames().DoSave(bankname);
        }

        public DsMaster.BANKSDataTable GetBankName()
        {
            return new BankNames().GetBankName();
        }
    }
    public class BlDailySales
    {
        public int DoSave(int ctype, string ctext, decimal cvalue, DateTime dt,bool isbeg=false)
        {
            var dl = new VIRETAILDAL.Masters.DailyClosing();
            return  dl.DoSave(ctype, ctext, cvalue, dt,isbeg);
        }
        public Ledgers.DAILYCLOSINGDataTable GetLastClosing(DateTime d1, bool isdate)
        {
           return new VIRETAILDAL.Masters.DailyClosing().GetLastClosing(d1,isdate);
        }
        public Ledgers.DAILYCLOSINGDataTable GetSPCP(DateTime d1, int spcp, bool useconstr = false, string newconstr = "p")
        {
            return new VIRETAILDAL.Masters.DailyClosing().GetSPCP(d1, spcp,useconstr,newconstr);
        }
    }
    public class BlCommissionSetup
    {
        public Ledgers.COMMISIONMASTRow CommisionmastRow;
        public Ledgers.COMMISIONDETAILDataTable Commisiondetail;
        public string tranid  = string.Empty;
        public string DoSave()
        {
       
            var dl = new VIRETAILDAL.Masters.CommissionSetup
                {CommisionmastRow = CommisionmastRow, Commisiondetail = Commisiondetail};
            var retval = dl.DoSave();
            if (retval == "1")
            {
                tranid = Utils.CommissionNo;
            }
            return retval;
        }
        public Ledgers.COMMISIONMASTDataTable GetCommissionMast(string commid = null)
        {
            return ClsGetData.GetCommissionMast(commid);
            
        }
        public  Ledgers.COMMISIONDETAILDataTable GetCommissionDetail(string commid = null,bool isRemote=false)
        {
            return ClsGetData.GetCommissionDetail(commid,isRemote);
           // return new VIRETAILDAL.Masters.CommissionSetup().GetCommissionDetail(commid);
        }

        public Ledgers.COMMISIONMASTDataTable GetCommissionMastNotUploaded()
        {
          return  new VIRETAILDAL.Masters.CommissionSetup().GetCommissionMastNotUploaded();
        }

        public Ledgers.COMMISIONMASTDataTable GetCommissonMastNotReceived()
        {
            return new VIRETAILDAL.Masters.CommissionSetup().GetCommissonMastNotReceived();
        }

        public void UpdateSync(string commid,bool isRemote=false)
        {
            new VIRETAILDAL.Masters.CommissionSetup().UpdateSync(commid,isRemote);
        }
    }
    public class BlCustomerPayments
    {
        public Ledgers.APARMAINDataTable AparmainDataTable;
        public string customerno;
        public decimal AppliedAmt;
        public decimal outstanding;
        public DateTime trandate;
        public string customertype;
        public int amountype;
        public string shiftcode;
        public int userid;
        
        public string DoSave()
        {
            var dm = new VIRETAILDAL.Sales.CustomerPayment();
            foreach (DataRow dr in AparmainDataTable.Rows)
            {
                if (!string.IsNullOrEmpty(dr["AmtApplied"].ToString()))
                {
                    dr["PAIDAMOUNT"] = decimal.Parse(dr["PAIDAMOUNT"].ToString()) + decimal.Parse(dr["AmtApplied"].ToString());
                    dr["BALANCE"] = decimal.Parse(dr["BALANCE"].ToString()) - decimal.Parse(dr["AmtApplied"].ToString());
                }
            }
            dm.AparmainData = AparmainDataTable;
            dm.customerno = customerno;
            dm.AppliedAmt = AppliedAmt;
            dm.outstanding = outstanding;
            dm.trandate = trandate;
            dm.customertype = customertype;
            dm.amountype = amountype;
            dm.shiftcode = shiftcode;
            dm.userid = userid;

            return dm.DoSave(); 
        }
    }
    public class BlInsuranceCustomer
    {
        public DsMaster.INSCUSTOMERSRow dr;
        public string DoSave()
        {
            return new InsuranceCustDetails().DoSaveInsuranceCustDatails(dr);
        }
        public void GetInscustomersRowByPolicyNo(string policyno)
        {
            dr = new InsuranceCustDetails().GetInscustomersRowByPolicyNo(policyno);
        }   
        public void GetInscustomersRowByFileNo(string fileno)
        {
            dr = new InsuranceCustDetails().GetInscustomersRowByFileNo(fileno);
        }
    

    }
}


