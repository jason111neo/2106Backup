using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Xinema.Startup))]
namespace Xinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
