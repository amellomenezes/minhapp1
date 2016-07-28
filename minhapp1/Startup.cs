using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(minhapp1.Startup))]
namespace minhapp1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
