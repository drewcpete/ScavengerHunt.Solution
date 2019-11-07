using Microsoft.EntityFrameworkCore.Migrations;

namespace ScavengerHunt.Migrations
{
    public partial class FinishAnimalsQuestAndJoinSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "ItemRules",
                value: "Feed a squirrel.");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "ItemName", "ItemRules" },
                values: new object[,]
                {
                    { 2, "Dog", "Pet a smol good boi." },
                    { 3, "Bird", "Take a picture of a sidewalk with no bird poop." },
                    { 4, "Cat", "Pet a huge fluffy cat." },
                    { 5, "Pony", "Take a picture of a pony." },
                    { 6, "Goose", "Narrowly escape death by goose." },
                    { 7, "Bee", "Give a bee some water." },
                    { 8, "Any animal", "Find an animal wearing clothes." }
                });

            migrationBuilder.InsertData(
                table: "QuestItems",
                columns: new[] { "QuestItemId", "ItemId", "QuestId" },
                values: new object[,]
                {
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 8, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestItems",
                keyColumn: "QuestItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "ItemRules",
                value: "Feed ONE squirrel.");
        }
    }
}
