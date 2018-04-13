using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NetCoreMultiPage.Authorization.Roles;
using NetCoreMultiPage.Authorization.Users;
using NetCoreMultiPage.MultiTenancy;

namespace NetCoreMultiPage.EntityFrameworkCore
{
    public class NetCoreMultiPageDbContext : AbpZeroDbContext<Tenant, Role, User, NetCoreMultiPageDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NetCoreMultiPageDbContext(DbContextOptions<NetCoreMultiPageDbContext> options)
            : base(options)
        {
        }
    }
}
