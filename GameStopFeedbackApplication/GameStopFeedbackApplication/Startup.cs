using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameStopFeedbackApplication.Startup))]
namespace GameStopFeedbackApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
