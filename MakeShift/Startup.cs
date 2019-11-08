using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MakeShift.Startup))]
namespace MakeShift
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
