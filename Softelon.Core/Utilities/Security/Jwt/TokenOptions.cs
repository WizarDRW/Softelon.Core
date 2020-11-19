using System;
namespace Softelon.Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        /// <summary>
        /// Kullanacak kitle icin
        /// </summary>
        public string Audience { get; set; }
        /// <summary>
        /// Imzalayan
        /// </summary>
        public string Issuer { get; set; }
        /// <summary>
        /// Token gecerlilik suresi
        /// </summary>
        public int AccessTokenExpiration { get; set; }
        /// <summary>
        /// Anahtar
        /// </summary>
        public string SecurityKey { get; set; }
    }
}
