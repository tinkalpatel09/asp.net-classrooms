using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppASPnet_MVC_Basics.Startup))]
namespace WebAppASPnet_MVC_Basics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
