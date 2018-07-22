using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBLab9.Startup))]
namespace DBLab9
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
