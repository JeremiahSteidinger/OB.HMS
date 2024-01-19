using Microsoft.EntityFrameworkCore;
using OB.HMS.Enities.Users.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB.HMS.Enities.Users
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasCharSet(null, DelegationModes.ApplyToDatabases);

            modelBuilder.Entity<EmailAddress>()
                .HasOne(u => u.User)
                .WithMany(e => e.EmailAddresses)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<Address>()
                .HasOne(u => u.User)
                .WithMany(a => a.Addresses)
                .HasForeignKey(a => a.UserId);
        }
    }
}
