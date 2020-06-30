using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartBookingApp.Startup))]
namespace SmartBookingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
