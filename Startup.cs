using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignaturePad.Startup))]
namespace SignaturePad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
