using Microsoft.EntityFrameworkCore;
namespace Cars.Models
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Company> Сompanies { get; set; } = null!;
        public DbSet<Dealer> Dealers { get; set; }= null!;
        public DbSet<Detail> Details { get; set; } = null!;
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                 .HasMany(x => x.Details)
                 .WithMany(x => x.Cars)
                 .UsingEntity(x => x.ToTable("CarDetails"));

            modelBuilder.Entity<Company>()
                .HasMany(x => x.Cars)
                .WithOne(x => x.Company);

            modelBuilder.Entity<Dealer>()
                .HasMany(x => x.Cars)
                .WithOne(x => x.Dealer);

            modelBuilder.Entity<Dealer>()
                .HasMany(x => x.Companies)
                .WithMany(x => x.Dealers)
                .UsingEntity(x => x.ToTable("DealerCompanies"));
            
        }
    }
}
