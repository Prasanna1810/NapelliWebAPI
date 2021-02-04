using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NapelliVO;
using NapelliWebAPI.Models;

namespace NapelliWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost, Route("UserLogin")]
        [Authorize(AuthenticationSchemes = "Bearer")]        
        public IActionResult UserLogin(UserRegisterVO urVO)
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.UserLogin(urVO);
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }

        [HttpPost, Route("RegisterUser")]
        //[Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult RegisterUser(UserRegisterVO uVO)
        {
            UserDetailsModel umodel = new UserDetailsModel();
            try
            {
                string count = umodel.CreateUser(uVO);
                if (umodel.errorcode != 0)
                {
                    return Ok(new { Error = umodel.error });
                }
                else if (count == "Inserted")
                {
                    return Ok(new { sucess = "Inserted Successfully" });
                }
                else
                {
                    return Ok(new { error = "Not inserted" });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpPost, Route("FamilyDetails")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult FamilyDetails(FamilyVO fVO)
        {
            UserDetailsModel umodel = new UserDetailsModel();
            try
            {
                string count = umodel.FamilyDetails(fVO);
                if (umodel.errorcode != 0)
                {
                    return Ok(new { Error = umodel.error });
                }
                else if (count == "Inserted")
                {
                    return Ok(new { sucess = "Inserted Successfully" });
                }
                else
                {
                    return Ok(new { error = "Not inserted" });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpPost, Route("ProfessionalDetails")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult ProfessionalDetails(ProfessionalVo pVO)
        {
            UserDetailsModel umodel = new UserDetailsModel();
            try
            {
                string count = umodel.ProfessionalDetails(pVO);
                if (umodel.errorcode != 0)
                {
                    return Ok(new { Error = umodel.error });
                }
                else if (count == "Inserted")
                {
                    return Ok(new { sucess = "Inserted Successfully" });
                }
                else
                {
                    return Ok(new { error = "Not inserted" });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpPost, Route("PartnerPreference")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult PartnerPreference(PartnerPrefVO parVO)
        {
            UserDetailsModel umodel = new UserDetailsModel();
            try
            {
                string count = umodel.PartnerPreference(parVO);
                if (umodel.errorcode != 0)
                {
                    return Ok(new { Error = umodel.error });
                }
                else if (count == "Inserted")
                {
                    return Ok(new { sucess = "Inserted Successfully" });
                }
                else
                {
                    return Ok(new { error = "Not inserted" });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpPost, Route("PersonalEducation")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult PersonalEducation(PersonalEduVO perEduVO)
        {
            UserDetailsModel umodel = new UserDetailsModel();
            try
            {
                string count = umodel.PersonalEducation(perEduVO);
                if (umodel.errorcode != 0)
                {
                    return Ok(new { Error = umodel.error });
                }
                else if (count == "Inserted")
                {
                    return Ok(new { sucess = "Inserted Successfully" });
                }
                else
                {
                    return Ok(new { error = "Not inserted" });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetCaste")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetCaste()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetCaste();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetCities")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetCities()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetCities();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetCountries")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetCountries()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetCountries();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetDesgination")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetDesgination()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetDesgination();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetLanguage")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetLanguage()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetLanguage();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetQualification")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetQualification()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetQualification();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetRasi")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetRasi()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetRasi();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetReligion")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetReligion()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetReligion();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetStar")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetStar()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetStar();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
       
        [HttpGet, Route("GetStates")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetStates()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetStates();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
        [HttpGet, Route("GetSubCast")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public IActionResult GetSubCast()
        {
            UserDetailsModel objUserMol = new UserDetailsModel();
            DataTable dt = new DataTable();
            try
            {
                dt = objUserMol.GetSubCast();
                if (objUserMol.errorcode != 0)
                {
                    return Ok(new { Error = objUserMol.error });
                }
                else if (dt.Rows.Count == 0)
                {
                    return Ok(new { info = "No Record found" });
                }
                else
                {
                    return Ok(dt);
                }
            }
            catch (Exception ex)
            {
                return Ok(new { Error = ex.Message });
            }
        }
    }
}
