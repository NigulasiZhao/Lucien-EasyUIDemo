using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lucien_EasyUIDemo.Startup))]
namespace Lucien_EasyUIDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
