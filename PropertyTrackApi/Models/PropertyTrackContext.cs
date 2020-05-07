using Microsoft.EntityFrameworkCore;

namespace PropertyTrackApi.Models
{
    public class PropertyTrackContext : DbContext
    {
        public PropertyTrackContext(DbContextOptions<PropertyTrackContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasOne(p => p.Category)
                .WithMany(b => b.Items);
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}