using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_ASP_NET_MVC_5.Startup))]
namespace App_ASP_NET_MVC_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
