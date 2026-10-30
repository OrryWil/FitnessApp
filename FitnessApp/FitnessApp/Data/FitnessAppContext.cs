

using FitnessApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Data
{
    public class FitnessAppContext : DbContext
    {
        public FitnessAppContext(DbContextOptions<FitnessAppContext> options) : base(options){ }
        
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Coaches> Coaches { get; set; }
        public DbSet<Athletes> athletes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // This forces the global map to drop "Coachescoachid" completely
            modelBuilder.Entity<Coaches>()
                .HasMany(c => c.Athletes)       // Maps to your public List<Athletes> Athletes property
                .WithOne()                      // Indicates an athlete has one coach
                .HasForeignKey(a => a.coachid); // Explicitly maps relationship to your existing lowercase column
        }
    }
    
    }
