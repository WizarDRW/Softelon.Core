using System;
using Softelon.Core.Entities.Concrete;

namespace Softelon.Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public User User { get; set; }
    }
}
