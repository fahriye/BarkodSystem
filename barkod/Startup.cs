using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(barkod.Startup))]
namespace barkod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
