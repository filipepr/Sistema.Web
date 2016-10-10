using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema.web.prototipo.Startup))]
namespace Sistema.web.prototipo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
