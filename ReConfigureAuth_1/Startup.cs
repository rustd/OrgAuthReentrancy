using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReConfigureAuth_1.Startup))]
namespace ReConfigureAuth_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
