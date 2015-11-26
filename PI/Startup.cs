using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PI.Startup))]
namespace PI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
