using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEAF_CONAP.Startup))]
namespace SEAF_CONAP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
