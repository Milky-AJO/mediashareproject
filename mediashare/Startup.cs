using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mediashare.Startup))]
namespace mediashare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
