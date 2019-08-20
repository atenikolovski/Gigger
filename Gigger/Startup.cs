using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gigger.Startup))]
namespace Gigger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
