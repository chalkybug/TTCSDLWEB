using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTCSDLWeb.Startup))]
namespace TTCSDLWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
