using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store.Infrastructure.WEbUI.Startup))]
namespace Store.Infrastructure.WEbUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
