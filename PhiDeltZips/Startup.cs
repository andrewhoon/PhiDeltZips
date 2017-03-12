using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhiDeltZips.Startup))]
namespace PhiDeltZips
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
