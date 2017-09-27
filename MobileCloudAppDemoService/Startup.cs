using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MobileCloudAppDemoService.Startup))]

namespace MobileCloudAppDemoService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}