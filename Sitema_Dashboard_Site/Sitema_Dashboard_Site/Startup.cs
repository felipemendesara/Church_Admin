using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sitema_Dashboard_Site.Startup))]
namespace Sitema_Dashboard_Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
