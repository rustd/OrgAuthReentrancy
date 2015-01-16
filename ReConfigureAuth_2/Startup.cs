using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReConfigureAuth_2.Startup))]
namespace ReConfigureAuth_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
