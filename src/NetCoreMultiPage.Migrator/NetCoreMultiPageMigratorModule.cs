using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NetCoreMultiPage.Configuration;
using NetCoreMultiPage.EntityFrameworkCore;
using NetCoreMultiPage.Migrator.DependencyInjection;

namespace NetCoreMultiPage.Migrator
{
    [DependsOn(typeof(NetCoreMultiPageEntityFrameworkModule))]
    public class NetCoreMultiPageMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public NetCoreMultiPageMigratorModule(NetCoreMultiPageEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(NetCoreMultiPageMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                NetCoreMultiPageConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NetCoreMultiPageMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
