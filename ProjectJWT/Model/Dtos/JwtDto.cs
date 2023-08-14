using System;

namespace ProjectJWT.Model.Dtos
{
    
    public class JwtDto
    {
        public string Token { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}
