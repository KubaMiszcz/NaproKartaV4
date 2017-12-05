using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NaproKarta.Client.Startup))]
namespace NaproKarta.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
