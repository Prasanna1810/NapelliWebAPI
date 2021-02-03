using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NapelliVO;
using NapelliWebAPI.Models;

namespace NapelliWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // GET api/values  
        [HttpPost, Route("login")]
        public IActionResult Login(UserRegisterVO urVO)
        {
            String hostaddress = Request.Host.Value;
            if (urVO.UserName == null)
            {
                return BadRequest("Invalid request");
            }

            UserDetailsModel aobj = new UserDetailsModel();

            //List<AccountModel> objlist = aobj.UserLogin(/*user.UserName, user.Password, hostaddress*/);
            DataTable dt = aobj.UserLogin(urVO);
            if (aobj.errorcode != 0)
            {
                return BadRequest(aobj.error);
            }

            if (aobj.errorcode == 0 && dt.Rows.Count != 0)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("VcrNapelliWebsite@123456789"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);


                var tokeOptions = new JwtSecurityToken(
                    issuer: "https://dotnetdetail.net",
                    audience: "https://dotnetdetail.net",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddHours(5),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
