using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INDIGOTESTE.Startup))]
namespace INDIGOTESTE
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
