using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketV2.Startup))]
namespace TicketV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
