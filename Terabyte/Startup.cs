using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Terabyte.Startup))]
namespace Terabyte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
