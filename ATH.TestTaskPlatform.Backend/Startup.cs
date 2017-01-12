using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ATH.TestTaskPlatform.Backend.Startup))]

namespace ATH.TestTaskPlatform.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
