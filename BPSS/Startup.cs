using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BPSS.Startup))]
namespace BPSS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
