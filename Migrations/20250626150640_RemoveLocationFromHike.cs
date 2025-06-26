using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLocationFromHike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Hikes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c18e4f6-565e-4759-8033-0df3526b68a8", "AQAAAAIAAYagAAAAENkD7TQslcDEWG+wsGceJrVTPArPZiHRBuz2+yIaCHj86H3s/iDyTnKXmOF6uCndlA==", "2d053337-d85a-4bc0-82ce-128c922231d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb77c632-82b0-4f6c-85ad-611237ebb313", "AQAAAAIAAYagAAAAEJ1c68yDd8RqHKWjsxdNWIjSYooN07zWR0aJ7G4rpMRzSyRDVTSz9yb/u2cw1mKz1g==", "9f9be683-7429-4840-91cf-465544ae2c14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51d2cf7e-21f7-4c43-9e4d-075b7500259e", "AQAAAAIAAYagAAAAEIIFBo9BXC+p2jbyUoR+AvyahTaoqlEyzV8hleqCL6A0CtimaSKFgeVJkWNUYZC6rQ==", "b056dd40-5414-43e9-afe2-55b572b9c5e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1c0035b-f6d1-4ad1-998d-943d793b9385", "AQAAAAIAAYagAAAAEJxg6Q8kBWHsRHoOUg1LQyahL7rEGe32QGAFtEDTrvNj+dyVmMTZepnzSquJRIO3Uw==", "c5400c01-a47c-4d63-b958-40b7e13a0746" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab95d83a-c1cd-4a4c-a26b-ae0d8933ae9f", "AQAAAAIAAYagAAAAEGKJuA/pEg7GxKJJvvqYJ2O+tEVTKrLB/w3I+R110hiNkLmzEQMUucvS9Plp+Rl6uQ==", "5bc16f9b-afa7-41da-ae5c-d60a84a28364" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 6, 25, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 6, 24, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 6, 23, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2025, 6, 22, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2025, 6, 21, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2025, 6, 20, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2025, 6, 19, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2025, 6, 18, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2025, 6, 17, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2025, 6, 16, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2025, 6, 15, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2025, 6, 14, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2025, 6, 13, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2025, 6, 12, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2025, 6, 11, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2025, 6, 10, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2025, 6, 9, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2025, 6, 7, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2025, 6, 6, 10, 6, 40, 398, DateTimeKind.Local).AddTicks(540));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Hikes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dab64f4-0aa6-4bb8-900b-b1dc7c160e74", "AQAAAAIAAYagAAAAEJEW5lvsTVReMIasVg6PMxDYL+f0AJG0I+h3s/AgoIhfIpYLKlNIK42B4IckMk9p/w==", "a967aeb8-2689-49ae-81a5-aae581ad3643" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f5fdf72-5355-42b1-bd3f-fc8f7ea3291a", "AQAAAAIAAYagAAAAEGuBvLVrrLXoLSLA/2Eqq1zrTevEFvJV/qHWX7VTyz+IeIXV3lTXraBLC+RwAM5yWw==", "4a2ad783-742b-44ec-a4a7-619194f21622" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ccb281c-e1aa-40b2-88d6-c3812c9c7c42", "AQAAAAIAAYagAAAAEIereXS848ua8bldKixWVc3JgR7RzspqE/Z4xpxZZT/OJ3rzeAOHjxhViDptfrCqSQ==", "bb528f48-93d5-4c63-90ea-3f1203fdd27d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97e1433-9fff-403f-861d-bc226521be98", "AQAAAAIAAYagAAAAEIDnkXU5HQ19w9TSH2QMofWiX9lp9dyQsrbK8TceGv7T5S6VdNH6GPCSQE/TJ2HL6Q==", "b901b8f0-54b2-4f27-9a78-7b3dc58a9c58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c9acaf2-c548-4d40-b894-40d0db4fbaa6", "AQAAAAIAAYagAAAAEJo8W2gORj1nClY4ZDgoz+Q/MTlQvK9Cfw7uBqY4Q5fNDLDVsZ5SSbTaLCH+U9urZw==", "12f857cd-1efa-42f4-8919-c246f1ab9210" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 18, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(6943), "Cedarwood Forest" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 17, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7039), "East River Park" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 16, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7045), "Bluff Point Reserve" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 15, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7048), "Lake Harmony Trails" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 14, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7052), "Summit Ridge View" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7061), "Crystal Falls Preserve" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 12, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7074), "Ironrock Trailhead" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 11, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7077), "Springwatch Preserve" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 10, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7080), "Pine Hollow Woods" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 9, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7083), "Creekstone Trail" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 8, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7099), "Meadowlark Trail" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 7, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7102), "Whispering Valley" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 6, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7106), "Canyon Staircase" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 5, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7109), "Maple Shade Woods" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 4, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7112), "Hilltop Ascent" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 3, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7131), "Shady Glen Trail" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 2, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7135), "Civil Ridge Trail" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 6, 1, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7139), "Sunrise Bluff Trail" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 5, 31, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7142), "Nature Education Loop" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2025, 5, 30, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7145), "Windcrest Hills" });
        }
    }
}
