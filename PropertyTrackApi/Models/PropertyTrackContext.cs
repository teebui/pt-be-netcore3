using Microsoft.EntityFrameworkCore;

namespace PropertyTrackApi.Models
{
    public class PropertyTrackContext : DbContext
    {
        public PropertyTrackContext(DbContextOptions<PropertyTrackContext> options)
            : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlite("Data Source=propertytrackdb.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasOne(p => p.Category)
                .WithMany(b => b.Items);
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

    }
}