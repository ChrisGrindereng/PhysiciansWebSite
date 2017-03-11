using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllergistSite.Startup))]
namespace AllergistSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
