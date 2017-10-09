using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageNotificationsWebApp.Startup))]
namespace MessageNotificationsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
