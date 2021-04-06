using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LastLab.Startup))]
namespace LastLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
