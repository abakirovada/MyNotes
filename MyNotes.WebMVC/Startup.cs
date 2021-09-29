using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNotes.WebMVC.Startup))]
namespace MyNotes.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
