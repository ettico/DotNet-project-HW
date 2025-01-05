using Microsoft.EntityFrameworkCore;
using שב_4.Controllers.properties;

namespace CarsVolunteer.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Volunteer> volunteers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // כאן תוסיף את ההגדרה
            modelBuilder.Entity<Application>()
                .HasKey(a => a.appId); // מפתח ראשי

            // לחלופין: אם היישות היא Keyless
            // modelBuilder.Entity<Application>().HasNoKey();
            modelBuilder.Entity<Customer>()
               .HasKey(a => a.castId);
            modelBuilder.Entity<Volunteer>()
               .HasKey(a => a.volId);
        }

    }
}
