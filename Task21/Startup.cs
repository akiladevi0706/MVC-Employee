using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task21.Startup))]
namespace Task21
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
