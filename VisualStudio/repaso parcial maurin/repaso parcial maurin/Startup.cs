using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(repaso_parcial_maurin.Startup))]
namespace repaso_parcial_maurin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
