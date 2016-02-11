using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMovie_V1._3.Startup))]
namespace MvcMovie_V1._3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
