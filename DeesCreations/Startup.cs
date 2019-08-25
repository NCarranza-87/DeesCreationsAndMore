using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeesCreations.Startup))]
namespace DeesCreations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
