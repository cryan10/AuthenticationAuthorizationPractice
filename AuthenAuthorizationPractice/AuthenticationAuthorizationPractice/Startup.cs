using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenticationAuthorizationPractice.Startup))]
namespace AuthenticationAuthorizationPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
