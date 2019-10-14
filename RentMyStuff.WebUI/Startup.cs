using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentMyStuff.WebUI.Startup))]
namespace RentMyStuff.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
