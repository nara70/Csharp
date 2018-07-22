using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseProjectDB.Startup))]
namespace CourseProjectDB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
