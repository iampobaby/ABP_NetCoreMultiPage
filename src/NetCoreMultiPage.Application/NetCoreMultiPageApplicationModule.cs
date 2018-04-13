using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NetCoreMultiPage.Authorization;

namespace NetCoreMultiPage
{
    [DependsOn(
        typeof(NetCoreMultiPageCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NetCoreMultiPageApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NetCoreMultiPageAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NetCoreMultiPageApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
