using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(petroleum_website.Startup))]
namespace petroleum_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
