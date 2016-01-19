using System;
using System.Data;

namespace VIRETAILDAL.Supplier
{
    public class Supplier
    {
         public string SUPPLIERNO; //=nvarchar(6)
         public string SUPPLIERNAME ;
         public string ARSUPPLIERNAME;
         public string ALTERNATENAME;
         public string ADDRESS ; //1500,
         public string PHONE;// 15
         public string FAX ;//15
         public bool   ACTIVE;
         public string EMAILID;//50
         public string WEBPAGE; //60
         public DateTime  VENDORSINCE;
         public string  ACCOUNTNO;//=20
         public decimal  BALANCE=0m; // MONEY
         public DateTime   BALANCEASOF ;
         public string   NOTE ;//1500
         public int   EXPACCID =0; // INT
         public int SUPGROUP =0;// INT
         public decimal CREDITLIMIT = 0m;// MONEY
         public int DEFSHIPPING =0;// INT
         public int DEFPAYMENT =0;// INT
         public int PAYTERMS = 0;// int
         public DataTable DsContact;
         public string STREET;
         public string CITY;
         public string ZIPCODE;
         public string COUNTRY;
         public int DUEDAYS=0;
         public string CONTACAT;
         
         public Supplier()
         { }
         public Supplier(DataRow dr)
         {
            if (dr["SUPPLIERNO"] != DBNull.Value)
            {
                this.SUPPLIERNO = dr["SUPPLIERNO"].ToString();
            }
            if (dr["SUPPLIERNAME"] != DBNull.Value)
            {
                this.SUPPLIERNAME = dr["SUPPLIERNAME"].ToString();
            }
            if (dr["ALTERNATENAME"] != DBNull.Value)
            {
                this.ALTERNATENAME=dr["ALTERNATENAME"].ToString();
            }
            if (dr["ADDRESS"]!=DBNull.Value)
            {
                this.ADDRESS = dr["ADDRESS"].ToString();
            }
            if (dr["PHONE"]!=DBNull.Value)
            {
                this.PHONE = dr["PHONE"].ToString();
            }
            if (dr["FAX"]!=DBNull.Value)
            {
                this.FAX = dr["FAX"].ToString();
            }
            if(dr["ACTIVE"]!=DBNull.Value)
            {
                this.ACTIVE = Boolean.Parse(dr["ACTIVE"].ToString());
            }
            if (dr["EMAILID"] != DBNull.Value)
            {
                this.EMAILID = dr["EMAILID"].ToString();
            }
            if(dr["WEBPAGE"]!=DBNull.Value)
            {
               this.WEBPAGE = dr["WEBPAGE"].ToString();
            }
            if(dr["VENDORSINCE"]!=DBNull.Value)
            {
               this.VENDORSINCE = DateTime.Parse(dr["VENDORSINCE"].ToString());
            }  
            if(dr["ACCOUNTNO"]!=DBNull.Value)
            {
               this.ACCOUNTNO = dr["ACCOUNTNO"].ToString();
            }
            if(dr["BALANCE"]!=DBNull.Value)
            {
               this.BALANCE = decimal.Parse(dr["BALANCE"].ToString());
            }
            if(dr["BALANCEASOF"]!=DBNull.Value)
            {
               this.BALANCEASOF = DateTime.Parse(dr["BALANCEASOF"].ToString());
            }
           if(dr["NOTE"]!=DBNull.Value)
           {
               this.NOTE =dr["NOTE"].ToString() ;
           } 
           if(dr["EXPACCID"]!=DBNull.Value)
           {
              this.EXPACCID = int.Parse(dr["EXPACCID"].ToString());
           }
          if(dr["SUPGROUP"] !=DBNull.Value)
           {
              this.SUPGROUP = int.Parse(dr["SUPGROUP"].ToString());
           }
          if(dr["CREDITLIMIT"]!=DBNull.Value)
           {
              this.CREDITLIMIT  =decimal.Parse(dr["CREDITLIMIT"].ToString());
           }
         if(dr["DEFSHIPPING"]!=DBNull.Value)
           {
             this.DEFSHIPPING = int.Parse(dr["DEFSHIPPING"].ToString());
           }
         if(dr["DEFPAYMENT"]!=DBNull.Value)
           {
             this.DEFPAYMENT = int.Parse(dr["DEFPAYMENT"].ToString());
           }
         if(dr["PAYTERMS"]!=DBNull.Value)
           {
             this.PAYTERMS= int.Parse(dr["PAYTERMS"].ToString());
           }
         if (dr["duedays"] != DBNull.Value)
           {
               this.DUEDAYS = int.Parse(dr["duedays"].ToString());
           }
         if (dr["CONTACT"] != DBNull.Value)
           {
               this.CONTACAT = dr["CONTACT"].ToString();
           }
             
         }
         
    }
}
