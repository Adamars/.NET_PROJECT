using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bachloretteApp.Web.Startup))]
namespace bachloretteApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
