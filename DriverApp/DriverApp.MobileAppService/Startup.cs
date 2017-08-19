using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DriverApp.MobileAppService.Startup))]

namespace DriverApp.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}