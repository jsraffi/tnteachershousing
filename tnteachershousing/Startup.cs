using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tnteachershousing.Startup))]
namespace tnteachershousing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
