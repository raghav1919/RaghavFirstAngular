using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaghavFirstAngular.Startup))]
namespace RaghavFirstAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
