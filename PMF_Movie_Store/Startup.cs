using Microsoft.Owin;
using Owin;
using PMF_Movie_Store;

[assembly: OwinStartup(typeof(Startup))]
namespace PMF_Movie_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
