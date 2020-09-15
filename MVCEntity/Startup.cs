using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEntity.Startup))]
namespace MVCEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
