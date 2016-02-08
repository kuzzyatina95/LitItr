using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LitItr.Startup))]
namespace LitItr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
