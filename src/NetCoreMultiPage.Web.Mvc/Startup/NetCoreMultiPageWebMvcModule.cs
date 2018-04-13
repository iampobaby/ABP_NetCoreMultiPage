using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NetCoreMultiPage.Configuration;

namespace NetCoreMultiPage.Web.Startup
{
    [DependsOn(typeof(NetCoreMultiPageWebCoreModule))]
    public class NetCoreMultiPageWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NetCoreMultiPageWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<NetCoreMultiPageNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NetCoreMultiPageWebMvcModule).GetAssembly());
        }
    }
}
