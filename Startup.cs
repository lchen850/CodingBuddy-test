using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodingBuddy.Startup))]
namespace CodingBuddy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
