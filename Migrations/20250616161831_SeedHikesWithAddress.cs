using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedHikesWithAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Hikes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hikes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Hikes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "Hikes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab563685-2111-454b-88eb-89614613e04a", "AQAAAAIAAYagAAAAECUyXwN3OSNKMGnJ8W2dlOXin7xfjXYHs3rFHWkVeVZDuN1gBlq2WcZmBem6VRsVIA==", "448e6e7c-d786-4178-a9ef-080be9356a03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6faf4e36-83aa-486f-add7-256f87e68721", "AQAAAAIAAYagAAAAENCZ7ERnBn3R+sRFLVCaEN/Fk1+un6BWnJV+zfCc2Te90Ed+mv/fAcq1pW3f9BNRhQ==", "926eaf5c-2ca1-4f63-8204-3e20685c3829" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdec6be8-a5e4-4ec9-a8bf-2858788a5617", "AQAAAAIAAYagAAAAENeUgmdb6tbBATo5kqhsCglXBjOgv8DYHGgHRxekGMERNhPrJIXKfaCkCEpJ3sdVfg==", "f51cd4a7-9102-4efe-a634-b954b6a2fe2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c5d9f21-4287-478b-b634-8ed367fc78c5", "AQAAAAIAAYagAAAAEONWwFSWUC8snA1XHo6zspTOhW4VQos828tG1AKGw7IUNHXUa5QLU8ipaG8nOQnrcw==", "8a321213-ca70-4b87-9558-5a742440bad9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da68d73d-4090-41c2-8dc0-180987f90967", "AQAAAAIAAYagAAAAEPpJ/KEzQvfM3GSt96WgkBeAO0dVpxHgTlbUcTHcapJKKRvI5Y/7jYxAqbrCE9LyRw==", "57ee9374-36eb-4fe5-a593-b2951a3723ec" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "Distance", "HasRestrooms", "IsGravel", "IsHandicapAccessible", "IsKidFriendly", "IsPaved", "Location", "State", "Zip" },
                values: new object[] { "123 Forest Ln", "Nashville", new DateTime(2025, 6, 15, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1067), "Peaceful loop through tall trees", 1.8, false, false, true, false, true, "Cedarwood Forest", "TN", "37011" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Distance", "HasRestrooms", "IsDogFriendly", "IsKidFriendly", "Location", "State", "Zip" },
                values: new object[] { "456 River Rd", "Knoxville", new DateTime(2025, 6, 14, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1159), 2.7000000000000002, true, false, true, "East River Park", "TN", "37901" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "Distance", "IsDogFriendly", "IsKidFriendly", "Location", "State", "Zip" },
                values: new object[] { "789 Bluff Dr", "Chattanooga", new DateTime(2025, 6, 13, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1164), "Scenic view from the bluff", 3.6000000000000001, true, true, "Bluff Point Reserve", "TN", "37401" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "IsDogFriendly", "IsGravel", "IsHandicapAccessible", "IsKidFriendly", "Location", "State", "Zip" },
                values: new object[] { "321 Lakeview Ave", "Clarksville", new DateTime(2025, 6, 12, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1168), "Goes all the way around the lake!Lots of ducks!", 4, 4.5, false, true, false, false, "Lake Harmony Trails", "TN", "37040" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddressLine1", "City", "DateCreated", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsHandicapAccessible", "IsKidFriendly", "Location", "State", "Zip" },
                values: new object[] { "654 Ridge Rd", "Cookeville", new DateTime(2025, 6, 11, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1172), 1, 5.4000000000000004, true, true, true, true, "Summit Ridge View", "TN", "38501" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "IsDogFriendly", "Location", "State", "Zip" },
                values: new object[] { "987 Falls Blvd", "Sparta", new DateTime(2025, 6, 10, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1183), "steep, rocky trail, not for beginners.", 2, 2.7000000000000002, false, "Crystal Falls Preserve", "TN", "38583" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "IsDogFriendly", "Location", "State", "Zip" },
                values: new object[] { "159 Rock Ln", "Tullahoma", new DateTime(2025, 6, 9, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1195), "Lots of rocks and boulders on this trail", 3, 3.6000000000000001, true, "Ironrock Trailhead", "TN", "37388" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsGravel", "IsHandicapAccessible", "IsPaved", "Location", "State", "Zip" },
                values: new object[] { "753 Birdsong Ct", "Columbia", new DateTime(2025, 6, 8, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1199), "Great nature watching along the trail, lots of birds.", 4, 4.5, false, true, false, false, "Springwatch Preserve", "TN", "38401" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "IsDogFriendly", "IsGravel", "Location", "State", "Zip" },
                values: new object[] { "111 Pine Ln", "Jackson", new DateTime(2025, 6, 7, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1203), "short path, great for kids, can be muddy.", 1, 1.8, false, false, "Pine Hollow Woods", "TN", "38301" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "Location", "State", "Zip" },
                values: new object[] { "222 Creek Rd", "Murfreesboro", new DateTime(2025, 6, 6, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1206), "multiple creek crossings on path, water comes up to knee height.", 2, 2.7000000000000002, "Creekstone Trail", "TN", "37130" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "IsHandicapAccessible", "IsPaved", "Location", "State", "Zip" },
                values: new object[] { "333 Meadow Pkwy", "Brentwood", new DateTime(2025, 6, 5, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1225), "Beautiful views of wild flowers!", 3, 3.6000000000000001, false, false, "Meadowlark Trail", "TN", "37027" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "Location", "State", "Zip" },
                values: new object[] { "444 Valley Ln", "Gallatin", new DateTime(2025, 6, 4, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1229), "Steep hills, not very busy early in the morning.", 4, 4.5, "Whispering Valley", "TN", "37066" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsHandicapAccessible", "IsPaved", "Location", "State", "Zip" },
                values: new object[] { "555 Step Hill Rd", "Johnson City", new DateTime(2025, 6, 3, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1232), "Trail has tons of steps!!", 1, 1.8, false, true, true, true, "Canyon Staircase", "TN", "37601" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "Distance", "HasRestrooms", "IsDogFriendly", "Location", "State", "Zip" },
                values: new object[] { "666 Maple St", "Lebanon", new DateTime(2025, 6, 2, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1274), "big trees, lots of shade, great for a day hike!", 2.7000000000000002, true, false, "Maple Shade Woods", "TN", "37087" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "Distance", "HasRestrooms", "IsDogFriendly", "Location", "State", "Zip" },
                values: new object[] { "777 Hilltop Dr", "Dickson", new DateTime(2025, 6, 1, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1278), "Open climb with big views", 3.6000000000000001, false, true, "Hilltop Ascent", "TN", "37055" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddressLine1", "City", "DateCreated", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsHandicapAccessible", "Location", "State", "Zip" },
                values: new object[] { "888 Shady Trl", "McMinnville", new DateTime(2025, 5, 31, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1293), 4, 4.5, false, false, false, "Shady Glen Trail", "TN", "37110" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsHandicapAccessible", "IsKidFriendly", "Location", "State", "Zip" },
                values: new object[] { "999 Heritage Way", "Franklin", new DateTime(2025, 5, 30, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1299), "Passes Civil War Sites", 1, 1.8, false, true, true, false, "Civil Ridge Trail", "TN", "37064" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddressLine1", "City", "DateCreated", "DifficultyId", "Distance", "HasRestrooms", "IsKidFriendly", "Location", "State", "Zip" },
                values: new object[] { "1010 Dawn Dr", "Oak Ridge", new DateTime(2025, 5, 29, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1303), 2, 2.7000000000000002, true, true, "Sunrise Bluff Trail", "TN", "37830" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "IsHandicapAccessible", "IsPaved", "Location", "State", "Zip" },
                values: new object[] { "1111 Nature Ln", "Smyrna", new DateTime(2025, 5, 28, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1307), "Educational signs along the way.", 3, 3.6000000000000001, false, false, "Nature Education Loop", "TN", "37167" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddressLine1", "City", "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsKidFriendly", "Location", "State", "Zip" },
                values: new object[] { "1212 Ridgecrest Rd", "Spring Hill", new DateTime(2025, 5, 27, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1310), "Breezy and open, moderate challenge", 4, 4.5, true, false, true, "Windcrest Hills", "TN", "37174" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Hikes");

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

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Description", "Distance", "HasRestrooms", "IsGravel", "IsHandicapAccessible", "IsKidFriendly", "IsPaved", "Location" },
                values: new object[] { new DateTime(2025, 5, 29, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9052), "Peaceful loop through tall trees.", 3.5, true, true, false, true, false, "123 Forest Ln, Nashville, TN 37011" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Distance", "HasRestrooms", "IsDogFriendly", "IsKidFriendly", "Location" },
                values: new object[] { new DateTime(2025, 5, 24, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9148), 4.2000000000000002, false, true, false, "456 River Rd, Knoxville, TN 37901" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Description", "Distance", "IsDogFriendly", "IsKidFriendly", "Location" },
                values: new object[] { new DateTime(2025, 6, 3, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9152), "Scenic view from the bluff.", 5.0999999999999996, false, false, "789 Bluff Dr, Chattanooga, TN 37401" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "IsDogFriendly", "IsGravel", "IsHandicapAccessible", "IsKidFriendly", "Location" },
                values: new object[] { new DateTime(2025, 6, 8, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9155), "Flat path around the lake, great for families.", 1, 2.7999999999999998, true, false, true, true, "321 Lakeview Ave, Clarksville, TN 37040" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsHandicapAccessible", "IsKidFriendly", "Location" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9158), 4, 6.7000000000000002, false, false, false, false, "654 Ridge Rd, Cookeville, TN 38501" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "IsDogFriendly", "Location" },
                values: new object[] { new DateTime(2025, 6, 10, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9167), "Short hike to a beautiful waterfall.", 1, 1.8999999999999999, true, "987 Falls Blvd, Sparta, TN 38583" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "IsDogFriendly", "Location" },
                values: new object[] { new DateTime(2025, 5, 19, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9180), "Steep, rocky trail not for beginners.", 4, 5.9000000000000004, false, "159 Rock Ln, Tullahoma, TN 37388" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsGravel", "IsHandicapAccessible", "IsPaved", "Location" },
                values: new object[] { new DateTime(2025, 5, 31, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9228), "Great spot for birdwatching in spring.", 2, 3.2000000000000002, true, false, true, true, "753 Birdsong Ct, Columbia, TN 38401" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "IsDogFriendly", "IsGravel", "Location" },
                values: new object[] { new DateTime(2025, 5, 27, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9231), "Quiet trail through pine woods.", 2, 4.5, true, true, "111 Pine Ln, Jackson, TN 38301" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "Location" },
                values: new object[] { new DateTime(2025, 6, 6, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9235), "Cross several shallow creeks.", 3, 3.7000000000000002, "222 Creek Rd, Murfreesboro, TN 37130" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "IsHandicapAccessible", "IsPaved", "Location" },
                values: new object[] { new DateTime(2025, 6, 11, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9250), "Flat and open with wildflowers.", 1, 2.2000000000000002, true, true, "333 Meadow Pkwy, Brentwood, TN 37027" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "Location" },
                values: new object[] { new DateTime(2025, 6, 7, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9253), "Walk through a shady valley.", 2, 3.8999999999999999, "444 Valley Ln, Gallatin, TN 37066" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsHandicapAccessible", "IsPaved", "Location" },
                values: new object[] { new DateTime(2025, 6, 1, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9256), "Hard stair climb through the canyon.", 4, 4.0, true, false, false, false, "555 Step Hill Rd, Johnson City, TN 37601" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Description", "Distance", "HasRestrooms", "IsDogFriendly", "Location" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9259), "Colorful in the fall with maples.", 3.2999999999999998, false, true, "666 Maple St, Lebanon, TN 37087" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Description", "Distance", "HasRestrooms", "IsDogFriendly", "Location" },
                values: new object[] { new DateTime(2025, 6, 2, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9262), "Open climb with big views.", 6.0, true, false, "777 Hilltop Dr, Dickson, TN 37055" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsHandicapAccessible", "Location" },
                values: new object[] { new DateTime(2025, 5, 26, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9282), 1, 2.6000000000000001, true, true, true, "888 Shady Trl, McMinnville, TN 37110" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsHandicapAccessible", "IsKidFriendly", "Location" },
                values: new object[] { new DateTime(2025, 5, 25, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9285), "Passes Civil War sites.", 2, 3.7999999999999998, true, false, false, true, "999 Heritage Way, Franklin, TN 37064" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DifficultyId", "Distance", "HasRestrooms", "IsKidFriendly", "Location" },
                values: new object[] { new DateTime(2025, 6, 9, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9288), 3, 2.3999999999999999, false, false, "1010 Dawn Dr, Oak Ridge, TN 37830" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "IsHandicapAccessible", "IsPaved", "Location" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9291), "Educational signs along the path.", 1, 2.0, true, true, "1111 Nature Ln, Smyrna, TN 37167" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "Description", "DifficultyId", "Distance", "HasRestrooms", "IsDogFriendly", "IsKidFriendly", "Location" },
                values: new object[] { new DateTime(2025, 6, 4, 13, 58, 47, 189, DateTimeKind.Local).AddTicks(9295), "Breezy and open, moderate challenge.", 3, 5.4000000000000004, false, true, false, "1212 Ridgecrest Rd, Spring Hill, TN 37174" });
        }
    }
}
