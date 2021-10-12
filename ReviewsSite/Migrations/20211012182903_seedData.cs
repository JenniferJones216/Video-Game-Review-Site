using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Xbox" },
                    { 3, "PS4" },
                    { 4, "Switch" }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Description", "Name", "PictureURL", "ReleaseDate", "VideoURL" },
                values: new object[,]
                {
                    { 1, "A non-traditional roleplaying game set in Revachol, a large city still recovering from a war decades prior to the game's start, with players taking the role of an amnesiac detective who has been tasked with solving a murder mystery.", "Disco Elysium: The Final Cut", "https://upload.wikimedia.org/wikipedia/en/thumb/0/0d/Disco_Elysium_Poster.jpeg/220px-Disco_Elysium_Poster.jpeg", "30 March 2021", "https://www.youtube.com/watch?v=YV2lp6p_gXw" },
                    { 2, "A first-person immersive stealth sim set in the fictional, plague-ridden industrial city of Dunwall, Dishonored follows the story of Corvo Attano, bodyguard to the Empress of the Isles. He is framed for her murder and forced to become an assassin, seeking revenge on those who conspired against him.", "Dishonored", "https://upload.wikimedia.org/wikipedia/en/thumb/6/65/Dishonored_box_art_Bethesda.jpg/220px-Dishonored_box_art_Bethesda.jpg", "9 October 2012", "https://www.youtube.com/watch?v=-XbQgdSlsd0" },
                    { 3, "A critically acclaimed, unique first-person puzzle platformer Portal consists primarily of a series of puzzles that must be solved by teleporting the player's character and simple objects using \"the Aperture Science Handheld Portal Device\", a device that can create inter-spatial portals between two flat planes. The player-character, Chell, is challenged and taunted by an artificial intelligence named GLaDOS (Genetic Lifeform and Disk Operating System) to complete each puzzle in the Aperture Science Enrichment Center using the portal gun with the promise of receiving cake when all the puzzles are completed.", "Portal", "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Portal_standalonebox.jpg/220px-Portal_standalonebox.jpg", "10 October, 2007", "https://www.youtube.com/watch?v=TluRVBhmf8w" },
                    { 4, "The Talos Principle is a narrative-based puzzle game, played from a first- or third-person perspective. The player takes the role of a robot with a seemingly human consciousness as they explore a number of environments that include over 120 puzzles. These environments interlock greenery, desert, and stone ruins with futuristic technology.", "The Talos Principle", "https://upload.wikimedia.org/wikipedia/en/thumb/a/ac/The_Talos_Principle.jpg/220px-The_Talos_Principle.jpg", "11 December 2014", "https://www.youtube.com/watch?v=iAVh4_wnOIw" },
                    { 5, "This famed open-world action role-playing game takes place in the titular Skyrim province of Tamriel. The game's main story revolves around the player's character, the Dragonborn, on their quest to defeat Alduin the World-Eater, a dragon who is prophesied to destroy the world.", "The Elder Scrolls V: Skyrim", "https://upload.wikimedia.org/wikipedia/en/thumb/1/15/The_Elder_Scrolls_V_Skyrim_cover.png/220px-The_Elder_Scrolls_V_Skyrim_cover.png", "11 November 2011", "https://www.youtube.com/watch?v=JSRtYpNRoN0" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "Usercomment", "Username", "VideoGameId" },
                values: new object[,]
                {
                    { 1, 4.2000000000000002, "I don't think there are many,if any, other games where you can play as a communist,schizophrenic,disco,cop.", "AweSome495", 1 },
                    { 2, 4.5, "let's just say i finished this game in every way possible & i'm about to play it again on pc", "SINA - VF - 02", 2 },
                    { 3, 3.7999999999999998, "there was no cake :((((((((((((((((((((((((((((((((((((", "Barack Obama", 3 },
                    { 4, 4.5, "I wish I could erase my memory and play this game again.", "J. Jonah. Jameson", 4 },
                    { 5, 5.0, "Best game to ever be created, must play, starting off almost getting ur head chopped off to then have guards distracted by a fu@!*ng dragon, then go on to become the dragon born and go on so many amazing quest and side quest into this huge open world map w DLC's of vampires its just, PERFECTION!!", "1Jhovany", 5 }
                });

            migrationBuilder.InsertData(
                table: "VideoGamePlatforms",
                columns: new[] { "Id", "PlatformId", "VideoGameId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 4, 3 },
                    { 4, 4, 4 },
                    { 5, 1, 5 },
                    { 6, 2, 5 },
                    { 7, 3, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
