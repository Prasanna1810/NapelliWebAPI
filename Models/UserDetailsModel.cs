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
        public string FamilyDetails(FamilyVO fVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.FamilyDetails(fVO);
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
        public string ProfessionalDetails(ProfessionalVo pVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.ProfessionalDetails(pVO);
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
        public string PartnerPreference(PartnerPrefVO parVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.PartnerPreference(parVO);
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
        public string PersonalEducation(PersonalEduVO perEduVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.PersonalEducation(perEduVO);
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
        public DataTable GetCaste()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetCaste();
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
        public DataTable GetCities()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetCities();
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
        public DataTable GetCountries()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetCountries();
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
        public DataTable GetDesgination()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetDesgination();
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
        public DataTable GetLanguage()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetLanguage();
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
        public DataTable GetQualification()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetQualification();
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
        public DataTable GetRasi()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetRasi();
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
        public DataTable GetReligion()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetReligion();
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
        public DataTable GetStar()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetStar();
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
        public DataTable GetStates()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetStates();
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
        public DataTable GetSubCast()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetSubCast();
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
    }
}
