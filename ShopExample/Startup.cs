using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopExample.Startup))]
namespace ShopExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
