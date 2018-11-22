using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityInANutshell.Startup))]
namespace IdentityInANutshell
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
