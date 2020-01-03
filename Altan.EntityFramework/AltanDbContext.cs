using System;
using Altan.Core.Organizations;
using Altan.Core.Transactions;
using Altan.Core.Users;
using Microsoft.EntityFrameworkCore;

namespace Altan.EntityFramework
{
    public class AltanDbContext : DbContext
    {
        public AltanDbContext(DbContextOptions<AltanDbContext> options) : base(options)
        {
        }

        #region Users

        public DbSet<User> Users { get; set; }

        #endregion

        #region Transactions

        public DbSet<Transaction> Transactions { get; set; }

        #endregion

        #region Organizations

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<OrganizationSubscription> OrganizationSubscriptions { get; set; }
        
        #endregion
    }
}