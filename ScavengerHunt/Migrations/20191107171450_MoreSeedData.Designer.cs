﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScavengerHunt.Models;

namespace ScavengerHunt.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191107171450_MoreSeedData")]
    partial class MoreSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ScavengerHunt.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemName");

                    b.Property<string>("ItemRules");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            ItemName = "Squirrel",
                            ItemRules = "Feed a squirrel."
                        },
                        new
                        {
                            ItemId = 2,
                            ItemName = "Dog",
                            ItemRules = "Pet a smol good boi."
                        },
                        new
                        {
                            ItemId = 3,
                            ItemName = "Bird",
                            ItemRules = "Take a picture of a sidewalk with no bird poop."
                        },
                        new
                        {
                            ItemId = 4,
                            ItemName = "Cat",
                            ItemRules = "Pet a huge fluffy cat."
                        },
                        new
                        {
                            ItemId = 5,
                            ItemName = "Pony",
                            ItemRules = "Take a picture of a pony."
                        },
                        new
                        {
                            ItemId = 6,
                            ItemName = "Goose",
                            ItemRules = "Narrowly escape death by goose."
                        },
                        new
                        {
                            ItemId = 7,
                            ItemName = "Bee",
                            ItemRules = "Give a bee some water."
                        },
                        new
                        {
                            ItemId = 8,
                            ItemName = "Any animal",
                            ItemRules = "Find an animal wearing clothes."
                        },
                        new
                        {
                            ItemId = 9,
                            ItemName = "IPA",
                            ItemRules = "Befriend a homebrewer. Drink an IPA in their basement."
                        },
                        new
                        {
                            ItemId = 10,
                            ItemName = "Ecliptic",
                            ItemRules = "Go to Ecliptic and try their Orbiter IPA"
                        },
                        new
                        {
                            ItemId = 11,
                            ItemName = "Upright",
                            ItemRules = "Go to Upright and try theid Engelberg Pilsner."
                        },
                        new
                        {
                            ItemId = 12,
                            ItemName = "Wayfinder",
                            ItemRules = "Go to Wayfinder and try their coffee pilsner."
                        },
                        new
                        {
                            ItemId = 13,
                            ItemName = "Level Beer",
                            ItemRules = "Go to Level Beer and try the Game On!."
                        },
                        new
                        {
                            ItemId = 14,
                            ItemName = "Baerlic",
                            ItemRules = "Got to Baerlic and try their Nice & Easy."
                        },
                        new
                        {
                            ItemId = 15,
                            ItemName = "Culmination",
                            ItemRules = "Go to Culmination and try their chocolate milk stout"
                        },
                        new
                        {
                            ItemId = 16,
                            ItemName = "Breakside",
                            ItemRules = "Go to breakside and try their Lemon Pepino"
                        },
                        new
                        {
                            ItemId = 17,
                            ItemName = "Monkey Puzzle",
                            ItemRules = "Monkey Puzzle"
                        },
                        new
                        {
                            ItemId = 18,
                            ItemName = "Japanese Maple",
                            ItemRules = "Japanese Maple"
                        },
                        new
                        {
                            ItemId = 19,
                            ItemName = "Judas Tree",
                            ItemRules = "Judas Tree"
                        },
                        new
                        {
                            ItemId = 20,
                            ItemName = "Pecan Tree",
                            ItemRules = "Peacn Tree"
                        },
                        new
                        {
                            ItemId = 21,
                            ItemName = "Kentucky Coffeetree",
                            ItemRules = "Kentucky Coffeetree"
                        },
                        new
                        {
                            ItemId = 22,
                            ItemName = "Crape Myrtle",
                            ItemRules = "Crape Myrtle"
                        },
                        new
                        {
                            ItemId = 23,
                            ItemName = "Magnolia Tree",
                            ItemRules = "Magnolia Tree"
                        },
                        new
                        {
                            ItemId = 24,
                            ItemName = "Redwood",
                            ItemRules = "Redwood"
                        },
                        new
                        {
                            ItemId = 25,
                            ItemName = "Blue Star",
                            ItemRules = "Go to Blue Star donut shop and eat a Lavender Fritter."
                        },
                        new
                        {
                            ItemId = 26,
                            ItemName = "Coco Donuts",
                            ItemRules = "Go to Coco Donuts and eat a Heidi-Braided Apple Fritter."
                        },
                        new
                        {
                            ItemId = 27,
                            ItemName = "Sesame Donuts",
                            ItemRules = "Go to Sesame Donuts and eat a Devil's Glaze donut."
                        },
                        new
                        {
                            ItemId = 28,
                            ItemName = "Annie's Donuts",
                            ItemRules = "Go to Annie's Donuts and eat a Lemon-Filled Glazed donut."
                        },
                        new
                        {
                            ItemId = 29,
                            ItemName = "Krispy Kreme",
                            ItemRules = "Go to Krispy Kreme and eat a Raised Glazed."
                        },
                        new
                        {
                            ItemId = 30,
                            ItemName = "Delicious Donuts",
                            ItemRules = "Go to Delicious Donuts and eat a Maple Old-Fashioned donut."
                        },
                        new
                        {
                            ItemId = 31,
                            ItemName = "Top Pot",
                            ItemRules = "Go to Top Pot and eat a Cronut."
                        },
                        new
                        {
                            ItemId = 32,
                            ItemName = "Angel's Donuts and Ice Cream",
                            ItemRules = "Eat any donut topped with any flavor ice cream."
                        });
                });

            modelBuilder.Entity("ScavengerHunt.Models.Quest", b =>
                {
                    b.Property<int>("QuestId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("QuestRules");

                    b.HasKey("QuestId");

                    b.ToTable("Quests");

                    b.HasData(
                        new
                        {
                            QuestId = 1,
                            Name = "Animals",
                            QuestRules = "Must be completed by sunset."
                        },
                        new
                        {
                            QuestId = 2,
                            Name = "Beer",
                            QuestRules = "Must be completed by sunrise. Each quest item must be completed at a different location."
                        },
                        new
                        {
                            QuestId = 3,
                            Name = "Trees",
                            QuestRules = "Must be completed by sunset. Each quest item must be completed at a different location. Must take a selfie with each of the following trees:"
                        },
                        new
                        {
                            QuestId = 4,
                            Name = "Trees",
                            QuestRules = "Must be completed by sunset. Each quest item must be completed at a different location."
                        });
                });

            modelBuilder.Entity("ScavengerHunt.Models.QuestItem", b =>
                {
                    b.Property<int>("QuestItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemId");

                    b.Property<int>("QuestId");

                    b.HasKey("QuestItemId");

                    b.HasIndex("ItemId");

                    b.HasIndex("QuestId");

                    b.ToTable("QuestItems");

                    b.HasData(
                        new
                        {
                            QuestItemId = 1,
                            ItemId = 1,
                            QuestId = 1
                        },
                        new
                        {
                            QuestItemId = 2,
                            ItemId = 2,
                            QuestId = 1
                        },
                        new
                        {
                            QuestItemId = 3,
                            ItemId = 3,
                            QuestId = 1
                        },
                        new
                        {
                            QuestItemId = 4,
                            ItemId = 4,
                            QuestId = 1
                        },
                        new
                        {
                            QuestItemId = 5,
                            ItemId = 5,
                            QuestId = 1
                        },
                        new
                        {
                            QuestItemId = 6,
                            ItemId = 6,
                            QuestId = 1
                        },
                        new
                        {
                            QuestItemId = 7,
                            ItemId = 7,
                            QuestId = 1
                        },
                        new
                        {
                            QuestItemId = 8,
                            ItemId = 8,
                            QuestId = 1
                        },
                        new
                        {
                            QuestItemId = 9,
                            ItemId = 9,
                            QuestId = 2
                        },
                        new
                        {
                            QuestItemId = 10,
                            ItemId = 10,
                            QuestId = 2
                        },
                        new
                        {
                            QuestItemId = 11,
                            ItemId = 11,
                            QuestId = 2
                        },
                        new
                        {
                            QuestItemId = 12,
                            ItemId = 12,
                            QuestId = 2
                        },
                        new
                        {
                            QuestItemId = 13,
                            ItemId = 13,
                            QuestId = 2
                        },
                        new
                        {
                            QuestItemId = 14,
                            ItemId = 14,
                            QuestId = 2
                        },
                        new
                        {
                            QuestItemId = 15,
                            ItemId = 15,
                            QuestId = 2
                        },
                        new
                        {
                            QuestItemId = 16,
                            ItemId = 16,
                            QuestId = 2
                        },
                        new
                        {
                            QuestItemId = 17,
                            ItemId = 17,
                            QuestId = 3
                        },
                        new
                        {
                            QuestItemId = 18,
                            ItemId = 18,
                            QuestId = 3
                        },
                        new
                        {
                            QuestItemId = 19,
                            ItemId = 19,
                            QuestId = 3
                        },
                        new
                        {
                            QuestItemId = 20,
                            ItemId = 20,
                            QuestId = 3
                        },
                        new
                        {
                            QuestItemId = 21,
                            ItemId = 21,
                            QuestId = 3
                        },
                        new
                        {
                            QuestItemId = 22,
                            ItemId = 22,
                            QuestId = 3
                        },
                        new
                        {
                            QuestItemId = 23,
                            ItemId = 23,
                            QuestId = 3
                        },
                        new
                        {
                            QuestItemId = 24,
                            ItemId = 24,
                            QuestId = 3
                        },
                        new
                        {
                            QuestItemId = 25,
                            ItemId = 25,
                            QuestId = 4
                        },
                        new
                        {
                            QuestItemId = 26,
                            ItemId = 26,
                            QuestId = 4
                        },
                        new
                        {
                            QuestItemId = 27,
                            ItemId = 27,
                            QuestId = 4
                        },
                        new
                        {
                            QuestItemId = 28,
                            ItemId = 28,
                            QuestId = 4
                        },
                        new
                        {
                            QuestItemId = 29,
                            ItemId = 29,
                            QuestId = 4
                        },
                        new
                        {
                            QuestItemId = 30,
                            ItemId = 30,
                            QuestId = 4
                        },
                        new
                        {
                            QuestItemId = 31,
                            ItemId = 31,
                            QuestId = 4
                        },
                        new
                        {
                            QuestItemId = 32,
                            ItemId = 32,
                            QuestId = 4
                        });
                });

            modelBuilder.Entity("ScavengerHunt.Models.QuestItem", b =>
                {
                    b.HasOne("ScavengerHunt.Models.Item", "Item")
                        .WithMany("Quests")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ScavengerHunt.Models.Quest", "Quest")
                        .WithMany("Item")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
