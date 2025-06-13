using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedTwentyHikes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "377383f9-ca14-452a-8847-39601f5ba164", "AQAAAAIAAYagAAAAEC6tO76VuJwgmFouzPq+FfI51OrQl+WMDvstrGrMnom8DCi4j48qgCW/kVydt1n6gA==", "fa7c15d2-b7e1-4e06-a099-f9838b7d9b27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a28233c-0f81-4110-9ebb-29d92bbe2ffc", "AQAAAAIAAYagAAAAEEqU119Z7GEl9T2WENVVhEDedmGyrCpv2Pi51hR20VAGrY43MgYh6wEaqDhiWiWMww==", "a4b4d791-f64e-4265-8fc1-5d52af938053" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9214327a-70c6-4c4d-ac5c-bb7540fa52da", "AQAAAAIAAYagAAAAEJIEEQlS3AqkdkytkONVeMGMSglLZe7/7KutPzRKKjEslnmROOaXIFjQvxK3YYW7NQ==", "a18f1328-13e6-4783-ac12-f7c993569f9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8b3dbe9-632b-417a-8acb-d4010061b689", "AQAAAAIAAYagAAAAEA09jVXBHhgYWrw1gKK7RgnynTl4HgBN4pJhdC1CJ6Sls+r6sqhv92ufO8ngFiB35g==", "7a01c65d-238e-4aa6-9da8-1b9785d17159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f64a627-4b23-4e1b-8f17-28a2d7a713e2", "AQAAAAIAAYagAAAAEBU+uPDTrO8quala3fa9X1zfKtV/E2JJLxWYyOlRf2xiuEZcwTYuLUo6Zgwort233w==", "d40f4133-7505-44ad-9cd4-602b9481eed2" });

            migrationBuilder.InsertData(
                table: "Hikes",
                columns: new[] { "Id", "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsGravel", "IsHandicapAccessible", "IsKidFriendly", "IsPaved", "Location", "Title", "UserProfileId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 29, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9052), "Peaceful loop through tall trees.", 1, 3.5, true, true, true, false, true, false, "123 Forest Ln, Nashville, TN 37011", "Forest Loop", 3 },
                    { 2, new DateTime(2025, 5, 24, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9148), "Trail running alongside the riverbank.", 2, 4.2000000000000002, false, true, true, false, false, false, "456 River Rd, Knoxville, TN 37901", "River Edge Trail", 4 },
                    { 3, new DateTime(2025, 6, 3, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9152), "Scenic view from the bluff.", 3, 5.0999999999999996, true, false, false, false, false, false, "789 Bluff Dr, Chattanooga, TN 37401", "Bluff Overlook", 5 },
                    { 4, new DateTime(2025, 6, 8, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9155), "Flat path around the lake, great for families.", 1, 2.7999999999999998, true, true, false, true, true, true, "321 Lakeview Ave, Clarksville, TN 37040", "Lakeside Path", 3 },
                    { 5, new DateTime(2025, 6, 5, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9158), "Challenging hike with rewarding sunset views.", 4, 6.7000000000000002, false, false, false, false, false, false, "654 Ridge Rd, Cookeville, TN 38501", "Sunset Ridge", 4 },
                    { 6, new DateTime(2025, 6, 10, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9167), "Short hike to a beautiful waterfall.", 1, 1.8999999999999999, true, true, true, false, true, false, "987 Falls Blvd, Sparta, TN 38583", "Waterfall Trail", 5 },
                    { 7, new DateTime(2025, 5, 19, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9180), "Steep, rocky trail not for beginners.", 4, 5.9000000000000004, false, false, false, false, false, false, "159 Rock Ln, Tullahoma, TN 37388", "Rocky Path", 3 },
                    { 8, new DateTime(2025, 5, 31, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9228), "Great spot for birdwatching in spring.", 2, 3.2000000000000002, true, true, false, true, true, true, "753 Birdsong Ct, Columbia, TN 38401", "Birdwatch Loop", 4 },
                    { 9, new DateTime(2025, 5, 27, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9231), "Quiet trail through pine woods.", 2, 4.5, false, true, true, false, true, false, "111 Pine Ln, Jackson, TN 38301", "Pine Hollow", 5 },
                    { 10, new DateTime(2025, 6, 6, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9235), "Cross several shallow creeks.", 3, 3.7000000000000002, false, true, true, false, false, false, "222 Creek Rd, Murfreesboro, TN 37130", "Creek Crossing", 3 },
                    { 11, new DateTime(2025, 6, 11, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9250), "Flat and open with wildflowers.", 1, 2.2000000000000002, true, true, false, true, true, true, "333 Meadow Pkwy, Brentwood, TN 37027", "Meadow Breeze", 4 },
                    { 12, new DateTime(2025, 6, 7, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9253), "Walk through a shady valley.", 2, 3.8999999999999999, true, false, true, false, true, false, "444 Valley Ln, Gallatin, TN 37066", "Valley Hike", 5 },
                    { 13, new DateTime(2025, 6, 1, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9256), "Hard stair climb through the canyon.", 4, 4.0, true, false, false, false, false, false, "555 Step Hill Rd, Johnson City, TN 37601", "Steep Steps", 3 },
                    { 14, new DateTime(2025, 5, 30, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9259), "Colorful in the fall with maples.", 2, 3.2999999999999998, false, true, true, false, true, false, "666 Maple St, Lebanon, TN 37087", "Maple Grove", 4 },
                    { 15, new DateTime(2025, 6, 2, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9262), "Open climb with big views.", 3, 6.0, true, false, false, false, false, false, "777 Hilltop Dr, Dickson, TN 37055", "Big Hill", 5 },
                    { 16, new DateTime(2025, 5, 26, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9282), "Cooling shade and shallow water.", 1, 2.6000000000000001, true, true, true, true, true, false, "888 Shady Trl, McMinnville, TN 37110", "Shady Creek", 3 },
                    { 17, new DateTime(2025, 5, 25, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9285), "Passes Civil War sites.", 2, 3.7999999999999998, true, false, false, false, true, true, "999 Heritage Way, Franklin, TN 37064", "Historic Trail", 4 },
                    { 18, new DateTime(2025, 6, 9, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9288), "Best at dawn, steep but short.", 3, 2.3999999999999999, false, false, true, false, false, false, "1010 Dawn Dr, Oak Ridge, TN 37830", "Sunrise Summit", 5 },
                    { 19, new DateTime(2025, 6, 12, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9291), "Educational signs along the path.", 1, 2.0, true, true, false, true, true, true, "1111 Nature Ln, Smyrna, TN 37167", "Nature Walk", 3 },
                    { 20, new DateTime(2025, 6, 4, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9295), "Breezy and open, moderate challenge.", 3, 5.4000000000000004, false, true, true, false, false, false, "1212 Ridgecrest Rd, Spring Hill, TN 37174", "Windy Ridge", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a849e6a-89b8-4ba0-9ac9-53726a4f0cc5", "AQAAAAIAAYagAAAAECV267GiCWY9RHmG1v6u9snmkTzhOcjztt00aF7MBJ9nkAHcrlYw7LaWkRgjbQFKfA==", "0da9bf07-1908-49fa-9f0b-68349862d567" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27c58eb8-efc2-4fba-ab77-f0d36af74cf4", "AQAAAAIAAYagAAAAEOdL7OMACk5Iwdn1vv3qmoShBPuViBcNPTVYNLux+tokf6FosxFYdUmEEtGZwmojYQ==", "277c1720-019c-4ebe-8b9d-641336b531fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ee2730a-dc24-4238-affa-c7801a46edca", "AQAAAAIAAYagAAAAEI8yCRjJVA2m13s0T4r+jlTeoY8zetFLTY2Wzxtk5a04ddKxGtNpgLXsXFKxhHpLQQ==", "fb3bf452-49e5-41ec-affc-4837205b1f8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73b657d9-1b74-45a2-b245-4c907bc2d322", "AQAAAAIAAYagAAAAEDdZ70ilgCX/nuUTsfjhafDtm+OZz8g19PYlyz7ONAxyfg3/OdzG8d5RV8RHNcp1Wg==", "1f9cd5d1-67bc-4bcc-b59e-0bc837e19956" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30634618-f93d-421b-8ba8-e5618faad221", "AQAAAAIAAYagAAAAEDvoW0ZxR2Fh670xxmFdKr6dkPYrFbQpxG3C6OaDQzP7/A6MT37of06N+P6aK1XV2w==", "032fe07e-d24c-46ce-bb8f-ebcc88aa967a" });
        }
    }
}
