using Microsoft.EntityFrameworkCore;

namespace PropertyTrackApi.Models
{
    public class PropertyTrackContext : DbContext
    {
        public PropertyTrackContext(DbContextOptions<PropertyTrackContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}