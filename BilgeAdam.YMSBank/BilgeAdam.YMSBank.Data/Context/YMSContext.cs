using BilgeAdam.YMSBank.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.YMSBank.Data.Context
{
    public class YMSContext : DbContext
    {
        public YMSContext(DbContextOptions<YMSContext> options) : base(options)
        {

        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountHistory> AccountHistories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GenericLookup> GenericLookups { get; set; }
        public virtual DbSet<GenericLookupType> GenericLookupTypes { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    }
}
