using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biblioteczka.Startup))]
namespace Biblioteczka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
