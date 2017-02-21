using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Churrasco.Startup))]
namespace Churrasco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
