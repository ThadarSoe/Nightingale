using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nightingale.Startup))]
namespace Nightingale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
