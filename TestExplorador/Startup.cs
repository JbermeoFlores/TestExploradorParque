using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestExplorador.Startup))]
namespace TestExplorador
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
