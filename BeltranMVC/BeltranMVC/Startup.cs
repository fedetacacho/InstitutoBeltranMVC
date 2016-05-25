using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeltranMVC.Startup))]
namespace BeltranMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
