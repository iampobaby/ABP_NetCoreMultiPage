using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NetCoreMultiPage.Authorization.Roles;
using NetCoreMultiPage.Authorization.Users;
using NetCoreMultiPage.MultiTenancy;
using NetCoreMultiPage.PhoneBooks.Persons;
using NetCoreMultiPage.PhoneBooks.PhoneNumbers;
using Abp.Events.Bus.Entities;
using System.Collections.Generic;

namespace NetCoreMultiPage.EntityFrameworkCore
{
    public class NetCoreMultiPageDbContext : AbpZeroDbContext<Tenant, Role, User, NetCoreMultiPageDbContext>
    {
        /* Define a DbSet for each entity of the application */


        public NetCoreMultiPageDbContext(DbContextOptions<NetCoreMultiPageDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber","PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
