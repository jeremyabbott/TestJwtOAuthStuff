using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApplication6.Startup))]

namespace WebApplication6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseOAuthAuthorizationServer
            ConfigureAuth(app);
        }
    }
}
