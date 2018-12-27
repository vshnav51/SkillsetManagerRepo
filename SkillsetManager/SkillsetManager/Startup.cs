using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkillsetManager.Startup))]
namespace SkillsetManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
