using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCDemo.Startup))]
namespace TCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
