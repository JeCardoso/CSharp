using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVC_MvcCodeFirst.Startup))]
namespace DVC_MvcCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
