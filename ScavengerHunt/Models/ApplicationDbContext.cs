
using Microsoft.EntityFrameworkCore;


namespace ScavengerHunt.Models
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Quest> Quests { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<QuestItem> QuestItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Quest>().HasData(
                new Quest {
                    QuestId = 1,
                    Name = "Animals",
                    QuestRules = "Must be completed by sunset.",
                }
            );
             builder.Entity<Item>().HasData(
                new Item {
                    ItemId = 1,
                    ItemName = "Squirrel",
                    ItemRules = "Feed ONE squirrel.",
                }
            );
             builder.Entity<QuestItem>().HasData(
                new QuestItem {
                    QuestItemId = 1,
                    QuestId = 1,
                    ItemId = 1,
                }
            );
        }
    }
}