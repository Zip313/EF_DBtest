using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class BankContext :DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<BankAccountType> BankAccountTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>()
                .HasMany(c => c.BankAccounts)
                .WithOne(c => c.Client)
                .IsRequired();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connection = @"Host=192.168.88.194;Port=5442;Username=postgres;Password=postgres;Database=OtusHomeWork_DB2";
        //    //        optionsBuilder.UseNpgsql(connection);
        //    optionsBuilder.UseNpgsql(connection);

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}