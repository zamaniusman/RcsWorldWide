using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RcsWorldWide.Startup))]
namespace RcsWorldWide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
