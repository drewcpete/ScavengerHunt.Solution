
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
                        builder.Entity<Quest>().HasData(
                new Quest {
                    QuestId = 2,
                    Name = "Beer",
                    QuestRules = "Must be completed by sunrise. Each quest item must be completed at a different location.",
                }
            );
             builder.Entity<Item>().HasData(
                new Item {
                    ItemId = 9,
                    ItemName = "IPA",
                    ItemRules = "Befriend a homebrewer. Drink an IPA in their basement.",
                },
                 new Item {
                    ItemId = 10,
                    ItemName = "Ecliptic",
                    ItemRules = "Go to Ecliptic and try their Orbiter IPA",
                },
                 new Item {
                    ItemId = 11,
                    ItemName = "Upright",
                    ItemRules = "Go to Upright and try theid Engelberg Pilsner.",
                },
                 new Item {
                    ItemId = 12,
                    ItemName = "Wayfinder",
                    ItemRules = "Go to Wayfinder and try their coffee pilsner.",
                },
                 new Item {
                    ItemId = 13,
                    ItemName = "Level Beer",
                    ItemRules = "Go to Level Beer and try the Game On!.",
                },
                 new Item {
                    ItemId = 14,
                    ItemName = "Baerlic",
                    ItemRules = "Got to Baerlic and try their Nice & Easy.",
                },
                 new Item {
                    ItemId = 15,
                    ItemName = "Culmination",
                    ItemRules = "Go to Culmination and try their chocolate milk stout",
                },
                 new Item {
                    ItemId = 16,
                    ItemName = "Breakside",
                    ItemRules = "Go to breakside and try their Lemon Pepino",
                }
               
            );
             builder.Entity<QuestItem>().HasData(
                new QuestItem {
                    QuestItemId = 9,
                    QuestId = 2,
                    ItemId = 9,
                },
                new QuestItem {
                    QuestItemId = 10,
                    QuestId = 2,
                    ItemId = 10,
                },
                new QuestItem {
                    QuestItemId = 11,
                    QuestId = 2,
                    ItemId = 11,
                },
                new QuestItem {
                    QuestItemId = 12,
                    QuestId = 2,
                    ItemId = 12,
                },
                new QuestItem {
                    QuestItemId = 13,
                    QuestId = 2,
                    ItemId = 13,
                },
                new QuestItem {
                    QuestItemId = 14,
                    QuestId = 2,
                    ItemId = 14,
                },
                new QuestItem {
                    QuestItemId = 15,
                    QuestId = 2,
                    ItemId = 15,
                },
                new QuestItem {
                    QuestItemId = 16,
                    QuestId = 2,
                    ItemId = 16,
                }
            );
             builder.Entity<Quest>().HasData(
                new Quest {
                    QuestId = 3,
                    Name = "Trees",
                    QuestRules = "Must be completed by sunset. Each quest item must be completed at a different location. Must take a selfie with each of the following trees:",
                }
            );
             builder.Entity<Item>().HasData(
                new Item {
                    ItemId = 17,
                    ItemName = "Monkey Puzzle",
                    ItemRules = "Monkey Puzzle",
                },
                 new Item {
                    ItemId = 18,
                    ItemName = "Japanese Maple",
                    ItemRules = "Japanese Maple",
                },
                 new Item {
                    ItemId = 19,
                    ItemName = "Judas Tree",
                    ItemRules = "Judas Tree",
                },
                 new Item {
                    ItemId = 20,
                    ItemName = "Pecan Tree",
                    ItemRules = "Peacn Tree",
                },
                 new Item {
                    ItemId = 21,
                    ItemName = "Kentucky Coffeetree",
                    ItemRules = "Kentucky Coffeetree",
                },
                 new Item {
                    ItemId = 22,
                    ItemName = "Crape Myrtle",
                    ItemRules = "Crape Myrtle",
                },
                 new Item {
                    ItemId = 23,
                    ItemName = "Magnolia Tree",
                    ItemRules = "Magnolia Tree",
                },
                 new Item {
                    ItemId = 24,
                    ItemName = "Redwood",
                    ItemRules = "Redwood",
                }
               
            );
             builder.Entity<QuestItem>().HasData(
                new QuestItem {
                    QuestItemId = 17,
                    QuestId = 3,
                    ItemId = 17,
                },
                new QuestItem {
                    QuestItemId = 18,
                    QuestId = 3,
                    ItemId = 18,
                },
                new QuestItem {
                    QuestItemId = 19,
                    QuestId = 3,
                    ItemId = 19,
                },
                new QuestItem {
                    QuestItemId = 20,
                    QuestId = 3,
                    ItemId = 20,
                },
                new QuestItem {
                    QuestItemId = 21,
                    QuestId = 3,
                    ItemId = 21,
                },
                new QuestItem {
                    QuestItemId = 22,
                    QuestId = 3,
                    ItemId = 22,
                },
                new QuestItem {
                    QuestItemId = 23,
                    QuestId = 3,
                    ItemId = 23,
                },
                new QuestItem {
                    QuestItemId = 24,
                    QuestId = 3,
                    ItemId = 24,
                }
            );
             builder.Entity<Quest>().HasData(
                new Quest {
                    QuestId = 4,
                    Name = "Donuts",
                    QuestRules = "Must be completed by sunset. Each quest item must be completed at a different location.",
                }
            );
             builder.Entity<Item>().HasData(
                new Item {
                    ItemId = 25,
                    ItemName = "Blue Star",
                    ItemRules = "Go to Blue Star donut shop and eat a Lavender Fritter.",
                },
                 new Item {
                    ItemId = 26,
                    ItemName = "Coco Donuts",
                    ItemRules = "Go to Coco Donuts and eat a Heidi-Braided Apple Fritter.",
                },
                 new Item {
                    ItemId = 27,
                    ItemName = "Sesame Donuts",
                    ItemRules = "Go to Sesame Donuts and eat a Devil's Glaze donut.",
                },
                 new Item {
                    ItemId = 28,
                    ItemName = "Annie's Donuts",
                    ItemRules = "Go to Annie's Donuts and eat a Lemon-Filled Glazed donut.",
                },
                 new Item {
                    ItemId = 29,
                    ItemName = "Krispy Kreme",
                    ItemRules = "Go to Krispy Kreme and eat a Raised Glazed.",
                },
                 new Item {
                    ItemId = 30,
                    ItemName = "Delicious Donuts",
                    ItemRules = "Go to Delicious Donuts and eat a Maple Old-Fashioned donut.",
                },
                 new Item {
                    ItemId = 31,
                    ItemName = "Top Pot",
                    ItemRules = "Go to Top Pot and eat a Cronut.",
                },
                 new Item {
                    ItemId = 32,
                    ItemName = "Angel's Donuts and Ice Cream",
                    ItemRules = "Eat any donut topped with any flavor ice cream.",
                }
               
            );
             builder.Entity<QuestItem>().HasData(
                new QuestItem {
                    QuestItemId = 25,
                    QuestId = 4,
                    ItemId = 25,
                },
                new QuestItem {
                    QuestItemId = 26,
                    QuestId = 4,
                    ItemId = 26,
                },
                new QuestItem {
                    QuestItemId = 27,
                    QuestId = 4,
                    ItemId = 27,
                },
                new QuestItem {
                    QuestItemId = 28,
                    QuestId = 4,
                    ItemId = 28,
                },
                new QuestItem {
                    QuestItemId = 29,
                    QuestId = 4,
                    ItemId = 29,
                },
                new QuestItem {
                    QuestItemId = 30,
                    QuestId = 4,
                    ItemId = 30,
                },
                new QuestItem {
                    QuestItemId = 31,
                    QuestId = 4,
                    ItemId = 31,
                },
                new QuestItem {
                    QuestItemId = 32,
                    QuestId = 4,
                    ItemId = 32,
                }
            );

        }
    }
}