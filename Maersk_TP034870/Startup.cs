using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maersk_TP034870.Startup))]
namespace Maersk_TP034870
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
