using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Control.Startup))]
namespace Control
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
