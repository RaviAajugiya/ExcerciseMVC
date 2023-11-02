using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExcerciseMVC.Startup))]
namespace ExcerciseMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
