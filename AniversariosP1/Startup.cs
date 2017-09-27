using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AniversariosP1.Startup))]
namespace AniversariosP1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
