using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cartfolo.Startup))]
namespace cartfolo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
