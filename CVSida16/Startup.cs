using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVSida16.Startup))]
namespace CVSida16
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
