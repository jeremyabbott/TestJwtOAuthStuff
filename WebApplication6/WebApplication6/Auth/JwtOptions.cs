
using System;
using Microsoft.Owin.Security.Jwt;
namespace WebApplication6.Auth
{
    public class JwtOptions : JwtBearerAuthenticationOptions
    {
        public JwtOptions()
        {
            var issuer = "localhost";
            var audience = "all";
            var key = Convert.FromBase64String("pYlD9HMDCmESIKogUWlpWhx7Nt5YN/jvo6R8jtgkobo=");

            AllowedAudiences = new[] { audience };
            IssuerSecurityTokenProviders = new[]
            {
                new SymmetricKeyIssuerSecurityTokenProvider(issuer, key)
            };
        }
    }
}