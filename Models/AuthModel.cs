using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NapelliWebAPI.Models
{
    public class AuthModel
    {
        public class User
        {
            public string Name { get; set; }
            public string JwtToken { get; set; }
            public string UserName { get; set; }
        }

        public interface IJwtToken
        {
            string CreateToken(User uobj);
        }
    }
}
