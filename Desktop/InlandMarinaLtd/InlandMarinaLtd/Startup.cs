using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InlandMarinaLtd.Startup))]
namespace InlandMarinaLtd
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
