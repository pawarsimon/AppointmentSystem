using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppointmentSystem.Startup))]
namespace AppointmentSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
