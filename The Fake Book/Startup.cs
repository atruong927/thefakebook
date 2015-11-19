using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(The_Fake_Book.Startup))]
namespace The_Fake_Book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
