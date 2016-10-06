using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScaleModeling.WebUI.Startup))]
namespace ScaleModeling.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
