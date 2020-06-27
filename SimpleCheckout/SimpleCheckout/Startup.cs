using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleCheckout.Startup))]
namespace SimpleCheckout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
