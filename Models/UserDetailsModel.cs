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
        public DataTable CheckMail(string Email_id, string Mobile_number)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.CheckMail(Email_id, Mobile_number);
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
        public string RegisterUser(UserRegisterVO uVO)
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
        public DataTable PackageCupons(int user_id, int package_id, string cupon_code)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                DataTable dt = uObj.PackageCupons(user_id, package_id, cupon_code);
                if (uObj.status.errcode != 0)
                {
                    errorcode = uObj.status.errcode;
                    error = uObj.status.errmesg;
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
        public string InsertImage(ImageVO iVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.InsertImage(iVO);
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
        public DataTable GetPackage()
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetPackage();
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
        public DataTable GetPackageDetails(int pack_id)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetPackageDetails(pack_id);
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
        public DataTable GetPackCoupCalculation(int pack_id, string coupCode)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetPackCoupCalculation(pack_id, coupCode);
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
        public DataTable GeneralSearch(string gender, int age_from, int age_to, int religion)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GeneralSearch(gender, age_from, age_to, religion);
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
        public DataTable GetFamilyDetails(int user_id)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetFamilyDetails(user_id);
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
        public DataTable GetPersonalEducationalDetails(int user_id)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetPersonalEducationalDetails(user_id);
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
        public DataTable GetProfessionalDetails(int user_id)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetProfessionalDetails(user_id);
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
        public DataTable GetPartnerPreferencesDetails(int user_id)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetPartnerPreferencesDetails(user_id);
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
        public DataTable GetImages(int user_id)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetImages(user_id);
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
        public DataTable GetPackageCuponsDetails(int user_id)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.GetPackageCuponsDetails(user_id);
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
        public string UpdateFamily(FamilyVO fVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.UpdateFamily(fVO);
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
        public string UpdateProfessional(ProfessionalVo pVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.UpdateProfessional(pVO);
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
        public string UpdatePartnerPreference(PartnerPrefVO parVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.UpdatePartnerPreference(parVO);
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
        public string UpdatePersonalEdu(PersonalEduVO perEduVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.UpdatePersonalEdu(perEduVO);
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
        public string UpdateImage(ImageVO iVO)
        {
            UserInfo uInfo = new UserInfo();
            User uObj = new User(uInfo);
            try
            {
                string count = uObj.UpdateImage(iVO);
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
        public DataTable ViewProfile(int user_id)
        {
            UserInfo uinfo = new UserInfo();
            User objUser = new User(uinfo);
            try
            {
                DataTable dt = objUser.ViewProfile(user_id);
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
