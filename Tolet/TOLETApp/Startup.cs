using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TOLETApp.Startup))]
namespace TOLETApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
