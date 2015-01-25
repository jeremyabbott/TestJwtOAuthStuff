using System;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;

/// <summary>
/// S
/// </summary>
namespace WebApplication6.Auth
{
    public class OAuthOptions : OAuthAuthorizationServerOptions
    {
        public OAuthOptions()
        {
            TokenEndpointPath = new PathString("/Token");
            AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(60);
            AccessTokenFormat = new JwtFormat(this);
            Provider = new OAuthProvider();
            AllowInsecureHttp = true;
            //AccessTokenFormat = new JwtOptions
        }
    }
}