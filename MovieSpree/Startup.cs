using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieSpree.Startup))]
namespace MovieSpree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
