using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(One_to_Many.Startup))]
namespace One_to_Many
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
