using Microsoft.EntityFrameworkCore;

namespace BackendAPIs.DataModels
{
    public class LaxikonContext : DbContext
    {
        public LaxikonContext()
        {
        }

        public LaxikonContext(DbContextOptions<LaxikonContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public virtual DbSet<SignUpInfo> SignUpInfo { get; set; }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SignUpInfo>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
    }
}