using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TradeLoans.Web.Startup))]
namespace TradeLoans.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
