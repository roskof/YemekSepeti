using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjeYemekSepeti.Startup))]
namespace ProjeYemekSepeti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
