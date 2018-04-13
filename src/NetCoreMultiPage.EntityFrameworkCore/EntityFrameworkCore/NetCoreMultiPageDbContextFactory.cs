using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NetCoreMultiPage.Configuration;
using NetCoreMultiPage.Web;

namespace NetCoreMultiPage.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NetCoreMultiPageDbContextFactory : IDesignTimeDbContextFactory<NetCoreMultiPageDbContext>
    {
        public NetCoreMultiPageDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NetCoreMultiPageDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NetCoreMultiPageDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NetCoreMultiPageConsts.ConnectionStringName));

            return new NetCoreMultiPageDbContext(builder.Options);
        }
    }
}
