using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class moreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "Usercomment", "Username", "VideoGameId" },
                values: new object[,]
                {
                    { 6, 0.0, "I would die for Kim Kitsuragi", "Bort", 1 },
                    { 20, 0.0, "Ruined my life. Five stars.", "Rob N", 5 },
                    { 19, 0.0, "side quests and the pretty environment keep me coming back. When you use mods the game can become a completely different game, so there's always something to check out.", "DrMiro", 5 },
                    { 18, 0.0, "Good game to play when you're having an existential crisis", "bug", 4 },
                    { 17, 0.0, "will make you think long and hard the next time you fail a captcha test", "Jacquee Mameet", 4 },
                    { 16, 0.0, "The Talos principle is a very good puzzle game. The gameplay is okay but the story is amazing. It's both challenging and engaging", "Sloppy Joe", 4 },
                    { 15, 0.0, "Fantastic puzzle game with a philosophy minigame hidden within", "YT_KameHameNah", 4 },
                    { 21, 0.0, "All these DLC's make me feel alive", "Pee Wee Herman", 5 },
                    { 14, 0.0, "Great game good puzzle solving and challenging", "Stellaris", 3 },
                    { 12, 0.0, "very neat! very cool! enjoyed every second despite the immense stress GLaDOS caused me in those last couple levels.", "VIC", 3 },
                    { 11, 0.0, "If this game was a guy, I'll marry him.", "Wracky <3 Y", 2 },
                    { 10, 0.0, "A mix between Skyrim & the newer Hitman games. Underrated masterpiece", "Vox", 2 },
                    { 9, 0.0, "A MUST-PLAY to fans of pretty much any genre of games. Anything more I'd wouldnt even begin to describe the magnificence of the gameplay, the environment, and all of the other elements", "MammadYmir", 2 },
                    { 8, 0.0, "Disco Elysium is genius, one of the best games ever. Must play this if you like good writing and tabletop RPGs", "Denky", 1 },
                    { 7, 0.0, "I don't think there are many,if any, other games where you can play as a communist, schizophrenic, disco, cop.", "anarky", 1 },
                    { 13, 0.0, "The cake is a lieee!!!!!", "AshDragon", 3 }
                });

            migrationBuilder.UpdateData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PlatformId", "VideoGameId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PlatformId", "VideoGameId" },
                values: new object[] { 2, 5 });
        }
    }
}
