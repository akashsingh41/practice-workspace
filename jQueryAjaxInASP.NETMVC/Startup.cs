using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQueryAjaxInASP.NETMVC.Startup))]
namespace jQueryAjaxInASP.NETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
