using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControleDeTarefasUNIP.Startup))]
namespace ControleDeTarefasUNIP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
