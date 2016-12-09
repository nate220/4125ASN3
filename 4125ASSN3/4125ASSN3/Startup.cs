using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_4125ASSN3.Startup))]
namespace _4125ASSN3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
