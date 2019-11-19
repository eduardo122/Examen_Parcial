using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Segundo_Examen_Parcial.Startup))]
namespace Segundo_Examen_Parcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
