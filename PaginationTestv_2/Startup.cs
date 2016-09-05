using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaginationTestv_2.Startup))]
namespace PaginationTestv_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
