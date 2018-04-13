using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NetCoreMultiPage.EntityFrameworkCore
{
    public static class NetCoreMultiPageDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NetCoreMultiPageDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NetCoreMultiPageDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
