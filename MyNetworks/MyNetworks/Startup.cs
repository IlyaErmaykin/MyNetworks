using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNetworks.Startup))]
namespace MyNetworks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
