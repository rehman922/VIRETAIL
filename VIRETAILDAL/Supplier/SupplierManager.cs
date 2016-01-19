using System;
using System.Data.SqlClient;
using DAL;
using System.Data;
using System.Globalization;

namespace VIRETAILDAL.Supplier
{
   public class SupplierManager
    {
       readonly string _constr = COMMON.Utils.Connectionstring;
       public string AddSupplier(Supplier s)
        {
       //   TextBox1.Text =String.Format("{0,-10:D6}", autoid);
            var db = new SqlConnection(_constr);
            SqlTransaction transaction;
            db.Open();
            string retval = "1";
            transaction = db.BeginTransaction();
            try
            {
                    string sql = "";
                    sql = "select autono from AUTONOMAST where srcid=2";
                    Int64 autoid = Convert.ToInt64(DBTask.ExecuteScalar(_constr, CommandType.Text, sql, null));
                    autoid ++;
                    string supno = COMMON.Utils.Company + String.Format("{0,-4:D4}", autoid);
                    var myDTFI = new CultureInfo("en-US", false).DateTimeFormat;
                    DateTime dtpf = s.VENDORSINCE;
                    string d1 = dtpf.ToString("d", myDTFI);
                    DateTime asof = s.BALANCEASOF;
                    string d2 = asof.ToString("d", myDTFI);
                    sql=" insert into SUPPLIER(SUPPLIERNO, SUPPLIERNAME, ARSUPPLIERNAME, ALTERNATENAME, ADDRESS, PHONE, FAX, ACTIVE, EMAILID, WEBPAGE,  VENDORSINCE,";
                    sql += " ACCOUNTNO, BALANCE, BALANCEASOF, NOTE, EXPACCID, SUPGROUP, CREDITLIMIT, DEFSHIPPING, DEFPAYMENT, PAYTERMS,CREATEDBY,CONTACT,DUEDAYS) ";
                    sql+=" VALUES ('"+ supno + "','" + s.SUPPLIERNAME + "','"+ s.ARSUPPLIERNAME +"' ,'"+ s.ALTERNATENAME +"','"+ s.ADDRESS +"','"+ s.PHONE +"','" + s.FAX + "','"+ s.ACTIVE +"',";
                    sql += " '" + s.EMAILID + "','" + s.WEBPAGE + "','" + d1 + "' ,'" + s.ACCOUNTNO + "'," + s.BALANCE + ",'" + d2 + "','" + s.NOTE + "',";
                    sql+= " "+ s.EXPACCID + "," + s.SUPGROUP + ","+ s.CREDITLIMIT +"," + s.DEFSHIPPING + "," + s.DEFPAYMENT + ","+ s.PAYTERMS +","+  COMMON.Utils.Userid +",'" + s.CONTACAT +"',"+ s.DUEDAYS +")";
                    autoid = Convert.ToInt64(DBTask.ExecuteScalar(db, transaction, CommandType.Text, sql, null));
                    sql="";
                    foreach (DataRow d in s.DsContact.Rows)
                    { 
                        sql= " insert INTO   CONTACTMAST(REFID, ISPRIMARY, CONTNAME, TITLE, BUSINESSPHONE, EMAIL, CONTTYPE)";
                        sql+= " VALUES     ('"+ supno + "', '"+ bool.Parse(d["ISPRIMARY"].ToString()) +"' ,'" + d["CONTNAME"].ToString() + "','"+ d["TITLE"].ToString() +"','"+ d["BUSINESSPHONE"].ToString() +"','" + d["EMAIL"].ToString() + "',2)";
                        autoid = Convert.ToInt64(DBTask.ExecuteScalar(db,transaction, CommandType.Text, sql, null));
                    }
                    if (!string.IsNullOrEmpty(COMMON.Address.STREET) || !string.IsNullOrEmpty(COMMON.Address.ZIPCODE) || !string.IsNullOrEmpty(COMMON.Address.COUNTRY) || !string.IsNullOrEmpty(COMMON.Address.CITY))
                    { 
                        sql="INSERT INTO ADDRESSMAST(REFID, CONTYPE, STREET, CITY, ZIPCODE, COUNTRY)";
                        sql += " VALUES  ('" + supno + "',2,'" + COMMON.Address.STREET + "','" + COMMON.Address.CITY + "','" + COMMON.Address.ZIPCODE + "','" +   COMMON.Address.COUNTRY + "')";
                        autoid = Convert.ToInt64(DBTask.ExecuteScalar(db, transaction, CommandType.Text, sql, null));
                    }
                    sql = "update AUTONOMAST set autono = autono + 1 where srcid=2";
                    DBTask.ExecuteNonQuery(db, transaction, CommandType.Text, sql, null);

                    transaction.Commit();
                    COMMON.Utils.SupplierNo = supno;
                    COMMON.Address.Refid = supno;
                
            } 
            catch (SqlException sqlError) 
            {
                 transaction.Rollback();
                 COMMON.Address.Refid = string.Empty;
                 COMMON.Utils.SupplierNo = string.Empty;
                 retval = sqlError.ToString();
            }
            db.Close();
            return "1";
        }
       public bool UpdateSupplier(Supplier s)
       {
           bool retval=false;
        // string supno = String.Format("{0,-6:D6}", autoid);
       //   TextBox1.Text =String.Format("{0,-10:D6}", autoid);
           var db = new SqlConnection(_constr);
           db.Open();
           try
           {
               var myDTFI = new CultureInfo("en-US", false).DateTimeFormat;
               DateTime dtpf = s.VENDORSINCE;
               string d1 = dtpf.ToString("d", myDTFI);
               DateTime asof = s.BALANCEASOF;
               string d2 = asof.ToString("d", myDTFI);
               DateTime edate = System.DateTime.Now;
               string d3 = edate.ToString("d", myDTFI); ;
               string sql = " update SUPPLIER set SUPPLIERNAME = '" + s.SUPPLIERNAME + "' , ALTERNATENAME='" + s.ALTERNATENAME + "', ADDRESS ='" + s.ADDRESS + "',";
               sql += " PHONE = '" + s.PHONE + "', FAX = '" + s.FAX + "', ACTIVE='" + s.ACTIVE + "', EMAILID ='" + s.EMAILID + "', WEBPAGE = '" + s.WEBPAGE + "',  VENDORSINCE = '" + d1 + "',";
               sql += " ACCOUNTNO ='" + s.ACCOUNTNO + "', BALANCE =" + s.BALANCE + ", BALANCEASOF='" + d2 + "', NOTE ='" + s.NOTE + "', EXPACCID =" + s.EXPACCID + ", SUPGROUP = " + s.SUPGROUP + ", CREDITLIMIT= " + s.CREDITLIMIT + ", DEFSHIPPING = " + s.DEFSHIPPING + ", DEFPAYMENT= " + s.DEFPAYMENT + ", PAYTERMS =" + s.PAYTERMS + ",";
               sql += " EDITEDBY = "  + COMMON.Utils.Userid + ", EDITDATE = '" + d3 + "', EDITED='" + bool.TrueString + "', UPDATEREMOTE ='" + bool.TrueString + "'";
               sql += " DUEDAYS = " + s.DUEDAYS + " , CONTACT = '" + s.CONTACAT + "'";
               sql += " where SUPPLIERNO = '" + s.SUPPLIERNO + "'";
               DBTask.ExecuteNonQuery(db, CommandType.Text, sql, null);

               foreach (DataRow d in s.DsContact.Rows)
               {
                   sql = " update  CONTACTMAST SET  ISPRIMARY ='" + bool.Parse(d["ISPRIMARY"].ToString()) + "', CONTNAME '" + d["CONTNAME"].ToString() + "',";
                   sql +=  " TITLE = '" + d["TITLE"].ToString() + "', BUSINESSPHONE = '" + d["BUSINESSPHONE"].ToString() + "', EMAIL='" + d["EMAIL"].ToString() + "', CONTTYPE=2)";
                   sql += " where REFID = '" + s.SUPPLIERNO + "'";
                   DBTask.ExecuteNonQuery(db, CommandType.Text, sql, null);
               }
               retval =true;
           }
           catch (SqlException)
           {
               retval =false;
           }
           return retval;    
       }
    }
}
