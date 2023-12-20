using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplikacijaWEB.Startup))]
namespace AplikacijaWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
