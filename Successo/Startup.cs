using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Successo.Startup))]
namespace Successo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
