using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LazyKitty.Startup))]
namespace LazyKitty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
