using NapelliServerFrameWork;
using NapelliVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static NapelliFrameWork.StatusInfo;

namespace NapelliWebAPI.Models
{
    public class UserDetailsModel
    {
        public int errorcode { get; set; }
        public string error { get; set; }
        public string Token { get; set; }

        public DataTable UserLogin(UserRegisterVO urVO)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.UserLogin(urVO);
                if (objUser.status.errcode != 0)
                {
                    errorcode = objUser.status.errcode;
                    error = objUser.status.errmesg;
                    return null;
                }
                else
                {
                    return dt;
                }
            }
            catch (Exception ex)
            {
                errorcode = -1;
                error = ex.Message;
                return null;
            }
        }
        public string CreateUser(UserRegisterVO uVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.RegisterUser(uVO);
                if (uObj.status.errcode != 0)
                {
                    errorcode = uObj.status.errcode;
                    error = uObj.status.errmesg;
                    return null;
                }
                else
                {
                    return count;
                }
            }
            catch (Exception ex)
            {
                errorcode = -1;
                error = ex.Message;
                return null;
            }
        }
    }
}
