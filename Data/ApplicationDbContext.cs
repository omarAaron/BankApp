using BankingApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for your database tables
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Accounts> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
            builder.Entity<Accounts>()
                .HasOne(a => a.Person)
                .WithMany() // A person can have many accounts
                .HasForeignKey(a => a.PersonId) // Foreign key from Accounts to Persons
                .OnDelete(DeleteBehavior.Cascade); // If a person is deleted, delete associated accounts

            builder.Entity<Transactions>()
                .HasOne(t => t.Account)
                .WithMany() // An account can have many transactions
                .HasForeignKey(t => t.AccountId) // Foreign key from Transactions to Accounts
                .OnDelete(DeleteBehavior.Cascade); // If an account is deleted, delete associated transactions
        }
    }
}
