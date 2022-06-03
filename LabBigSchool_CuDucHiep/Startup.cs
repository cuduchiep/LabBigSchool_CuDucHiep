using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabBigSchool_CuDucHiep.Startup))]
namespace LabBigSchool_CuDucHiep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
