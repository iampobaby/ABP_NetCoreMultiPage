using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NetCoreMultiPage.Configuration;

namespace NetCoreMultiPage.Web.Host.Startup
{
    [DependsOn(
       typeof(NetCoreMultiPageWebCoreModule))]
    public class NetCoreMultiPageWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NetCoreMultiPageWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NetCoreMultiPageWebHostModule).GetAssembly());
        }
    }
}
