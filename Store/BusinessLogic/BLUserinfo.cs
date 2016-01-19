using System;
using System.Data;
using DevExpress.XtraEditors.DXErrorProvider;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;

namespace Store.BusinessLogic
{
    public class BLUserinfo
    {
        public DsMaster.USERINFORow UserinfoRow;
        public int Newuserid;
        public string DoSave()
        {
            var dm = new VIRETAILDAL.Masters.UserInfo();
            dm.userinfoRow = UserinfoRow;
            var retval = dm.DoSave();
            if (retval == "1")
            {
                Newuserid = Utils.NewUserid;
            }
            return retval;
        }
        public void GetUserinfoByEmp(string empno)
        {
            var dt = new VIRETAILDAL.Masters.UserInfo().GetUserinfoByEmp(empno);
            if(dt.Rows.Count > 0 )
            {
                foreach (DataRow dr in dt.Rows)
                {
                    UserinfoRow = (DsMaster.USERINFORow) dr;
                }
            }
        }
        public void GetUserinfoByUserName(string username)
        {
            var dt = new VIRETAILDAL.Masters.UserInfo().GetUserinfoByUserName(username);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    UserinfoRow = (DsMaster.USERINFORow)dr;
                }
            }
        }
        public string GetUserinfoByUserid(int userid)
        {
           return new VIRETAILDAL.Masters.UserInfo().GetUserNameByUserid(userid);
        }


    }
    public class UserInfoErr : IDXDataErrorInfo
    {
          public string Username { get; set; }
          public string Fullname { get; set; }
          public string Empno { get; set; }
          public string Password { get; set; }
          public string Profileid { get; set; }
          public string Role { get; set; }
          public string Password1 { get; set; }
        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            if (propertyName == "Username" && string.IsNullOrEmpty(Username)
                || propertyName == "Fullname" && string.IsNullOrWhiteSpace(Fullname)
                || propertyName == "Empno" && string.IsNullOrEmpty(Empno)
                || propertyName == "Password" && string.IsNullOrEmpty(Password)
                || propertyName == "Role" && string.IsNullOrEmpty(Role)
                || propertyName == "Password1" && string.IsNullOrEmpty(Password1)
                || propertyName == "Profileid" && string.IsNullOrEmpty(Profileid))
                info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
        }
        public void GetError(ErrorInfo info)
        {
            // throw new NotImplementedException();
        }
    }
}
