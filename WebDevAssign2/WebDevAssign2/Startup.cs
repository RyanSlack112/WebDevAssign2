using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDevAssign2.Startup))]
namespace WebDevAssign2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
