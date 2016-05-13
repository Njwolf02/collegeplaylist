using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(collegeplaylist.WebUI.Startup))]
namespace collegeplaylist.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
