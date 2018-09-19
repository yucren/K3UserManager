using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LonkingK3UserManager.Startup))]
namespace LonkingK3UserManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
