using Microsoft.EntityFrameworkCore.Migrations;

namespace ScavengerHunt.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "ItemName", "ItemRules" },
                values: new object[,]
                {
                    { 9, "IPA", "Befriend a homebrewer. Drink an IPA in their basement." },
                    { 32, "Angel's Donuts and Ice Cream", "Eat any donut topped with any flavor ice cream." },
                    { 31, "Top Pot", "Go to Top Pot and eat a Cronut." },
                    { 30, "Delicious Donuts", "Go to Delicious Donuts and eat a Maple Old-Fashioned donut." },
                    { 29, "Krispy Kreme", "Go to Krispy Kreme and eat a Raised Glazed." },
                    { 28, "Annie's Donuts", "Go to Annie's Donuts and eat a Lemon-Filled Glazed donut." },
                    { 27, "Sesame Donuts", "Go to Sesame Donuts and eat a Devil's Glaze donut." },
                    { 26, "Coco Donuts", "Go to Coco Donuts and eat a Heidi-Braided Apple Fritter." },
                    { 25, "Blue Star", "Go to Blue Star donut shop and eat a Lavender Fritter." },
                    { 24, "Redwood", "Redwood" },
                    { 23, "Magnolia Tree", "Magnolia Tree" },
                    { 21, "Kentucky Coffeetree", "Kentucky Coffeetree" },
                    { 22, "Crape Myrtle", "Crape Myrtle" },
                    { 19, "Judas Tree", "Judas Tree" },
                    { 18, "Japanese Maple", "Japanese Maple" },
                    { 17, "Monkey Puzzle", "Monkey Puzzle" },
                    { 16, "Breakside", "Go to breakside and try their Lemon Pepino" },
                    { 15, "Culmination", "Go to Culmination and try their chocolate milk stout" },
                    { 14, "Baerlic", "Got to Baerlic and try their Nice & Easy." },
                    { 13, "Level Beer", "Go to Level Beer and try the Game On!." },
                    { 12, "Wayfinder", "Go to Wayfinder and try their coffee pilsner." },
                    { 11, "Upright", "Go to Upright and try theid Engelberg Pilsner." },
                    { 10, "Ecliptic", "Go to Ecliptic and try their Orbiter IPA" },
                    { 20, "Pecan Tree", "Peacn Tree" }
                });

            migrationBuilder.InsertData(
                table: "Quests",
                columns: new[] { "QuestId", "Name", "QuestRules" },
                values: new object[,]
                {
                    { 3, "Trees", "Must be completed by sunset. Each quest item must be completed at a different location. Must take a selfie with each of the following trees:" },
                    { 2, "Beer", "Must be completed by sunrise. Each quest item must be completed at a different location." },
                    { 4, "Trees", "Must be completed by sunset. Each quest item must be completed at a different location." }
                });

            migrationBuilder.InsertData(
                table: "QuestItems",
                columns: new[] { "QuestItemId", "ItemId", "QuestId" },
                values: new object[,]
                {
                    { 9, 9, 2 },
                    { 30, 30, 4 },
                    { 29, 29, 4 },
                    { 28, 28, 4 },
                    { 27, 27, 4 },
                    { 26, 26, 4 },
                    { 25, 25, 4 },
                    { 24, 24, 3 },
                    { 23, 23, 3 },
                    { 22, 22, 3 },
                    { 21, 21, 3 },
                    { 20, 20, 3 },
                    { 19, 19, 3 },
                    { 18, 18, 3 },
                    { 17, 17, 3 },
                    { 16, 16, 2 },
                    { 15, 15, 2 },
                    { 14, 14, 2 },
                    { 13, 13, 2 },
                    { 12, 12, 2 },
                    { 11, 11, 2 },
                    { 10, 10, 2 },
                    { 31, 31, 4 },
                    { 32, 32, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Quests",
                keyColumn: "QuestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quests",
                keyColumn: "QuestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quests",
                keyColumn: "QuestId",
                keyValue: 4);
        }
    }
}
