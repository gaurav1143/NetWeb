using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kuch_bhi.Startup))]
namespace kuch_bhi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
