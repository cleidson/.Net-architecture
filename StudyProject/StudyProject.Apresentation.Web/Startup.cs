using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyProject.Apresentation.Web.Startup))]
namespace StudyProject.Apresentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
