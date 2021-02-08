using Microsoft.EntityFrameworkCore;

public class ItemContext : DbContext
    {
        public ItemContext (DbContextOptions<ItemContext> options)
            : base(options)
        {
        }

        public DbSet<LostAndFound.Models.Item> Item { get; set; }
    }
