using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2_Cupcake.Startup))]
namespace Assignment2_Cupcake
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
