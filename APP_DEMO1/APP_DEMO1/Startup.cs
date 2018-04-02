using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APP_DEMO1.Startup))]
namespace APP_DEMO1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
