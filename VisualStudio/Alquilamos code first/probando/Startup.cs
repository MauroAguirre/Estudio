using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(probando.Startup))]
namespace probando
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
