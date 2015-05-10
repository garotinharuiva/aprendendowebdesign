using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Novo.Startup))]
namespace Novo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
