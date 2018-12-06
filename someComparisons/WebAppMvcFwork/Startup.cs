using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMvcFwork.Startup))]
namespace WebAppMvcFwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
