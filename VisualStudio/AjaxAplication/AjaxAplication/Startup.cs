using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxAplication.Startup))]
namespace AjaxAplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
