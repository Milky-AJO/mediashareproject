using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaShare.Startup))]
namespace MediaShare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
