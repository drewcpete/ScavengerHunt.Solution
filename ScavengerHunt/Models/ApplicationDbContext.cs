
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
                    ItemRules = "Feed a squirrel.",
                },
                 new Item {
                    ItemId = 2,
                    ItemName = "Dog",
                    ItemRules = "Pet a smol good boi.",
                },
                 new Item {
                    ItemId = 3,
                    ItemName = "Bird",
                    ItemRules = "Take a picture of a sidewalk with no bird poop.",
                },
                 new Item {
                    ItemId = 4,
                    ItemName = "Cat",
                    ItemRules = "Pet a huge fluffy cat.",
                },
                 new Item {
                    ItemId = 5,
                    ItemName = "Pony",
                    ItemRules = "Take a picture of a pony.",
                },
                 new Item {
                    ItemId = 6,
                    ItemName = "Goose",
                    ItemRules = "Narrowly escape death by goose.",
                },
                 new Item {
                    ItemId = 7,
                    ItemName = "Bee",
                    ItemRules = "Give a bee some water.",
                },
                 new Item {
                    ItemId = 8,
                    ItemName = "Any animal",
                    ItemRules = "Find an animal wearing clothes.",
                }
               
            );
             builder.Entity<QuestItem>().HasData(
                new QuestItem {
                    QuestItemId = 1,
                    QuestId = 1,
                    ItemId = 1,
                },
                new QuestItem {
                    QuestItemId = 2,
                    QuestId = 1,
                    ItemId = 2,
                },
                new QuestItem {
                    QuestItemId = 3,
                    QuestId = 1,
                    ItemId = 3,
                },
                new QuestItem {
                    QuestItemId = 4,
                    QuestId = 1,
                    ItemId = 4,
                },
                new QuestItem {
                    QuestItemId = 5,
                    QuestId = 1,
                    ItemId = 5,
                },
                new QuestItem {
                    QuestItemId = 6,
                    QuestId = 1,
                    ItemId = 6,
                },
                new QuestItem {
                    QuestItemId = 7,
                    QuestId = 1,
                    ItemId = 7,
                },
                new QuestItem {
                    QuestItemId = 8,
                    QuestId = 1,
                    ItemId = 8,
                }
            );
        }
    }
}