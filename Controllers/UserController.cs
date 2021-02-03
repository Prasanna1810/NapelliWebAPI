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
    }
}
