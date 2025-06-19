using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddLatLongToHike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Hikes",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Hikes",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

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
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 18, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(6943), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 17, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7039), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 16, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7045), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 15, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7048), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 14, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7052), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7061), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 12, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7074), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 11, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7077), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 10, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7080), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 9, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7083), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 8, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7099), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 7, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7102), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 6, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7106), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 5, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7109), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 4, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7112), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 3, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7131), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 2, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7135), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 6, 1, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7139), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 5, 31, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7142), 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "Latitude", "Longitude" },
                values: new object[] { new DateTime(2025, 5, 30, 11, 11, 7, 920, DateTimeKind.Local).AddTicks(7145), 0.0, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Hikes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f36e542d-fa6d-4ae0-a697-a94a856040cc", "AQAAAAIAAYagAAAAEIA5YpRAW167aq+WqR7a4DVlfuiBt/L08ZWeIsqXOYMQKXmVqxsXFkGBn0Hj6sk3EQ==", "1fea0bd9-3a65-4b48-913a-54bf1941c30b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a0d5cd5-bd09-4ab4-8bcc-ee25febbf117", "AQAAAAIAAYagAAAAEN8yAPOEsxBKXenL2PnfnngGkPst0JnDmQhr/FQCZ09v0SD8uN8ViqYYjDa3kbE/dQ==", "d5bf1c5a-1f5c-4b19-ac93-dbfc51bab978" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43cafb00-c585-423d-b50a-708e40587254", "AQAAAAIAAYagAAAAEBBAc9dQdGvb0OPWXrSZ7e+1jxjzOMDYylL3FDCh7toXGtAvAWXS3mUEit5ws7FJWA==", "ae9f918b-762b-491f-b66e-ac7e6b1f485f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0974ef3a-c7da-4a9e-8f11-59e662492355", "AQAAAAIAAYagAAAAENt1DGrOtsepIUaJXDhbukWgAKpaUX8yjeO3zxcatmKEnP8FFagbI4SNc/Ei8j8Y0g==", "4686c76c-1bc9-4842-a31a-03f6a4efa45a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b426c3bc-ef4f-4218-a75d-0ab409527679", "AQAAAAIAAYagAAAAEHIU4GAS0cyCuiRrvmxaIqMHeGaq1hoJbtvSWinSwte0IryVG7QDpwhiQNRvgyElmw==", "8f53deab-1077-429d-9381-2e37ec74cccf" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 6, 15, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 6, 14, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 6, 13, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2025, 6, 12, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2025, 6, 11, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2025, 6, 10, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2025, 6, 9, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2025, 6, 7, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2025, 6, 6, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2025, 6, 5, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2025, 6, 4, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2025, 6, 3, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2025, 6, 2, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2025, 6, 1, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2025, 5, 31, 14, 37, 47, 417, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2025, 5, 30, 14, 37, 47, 418, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2025, 5, 29, 14, 37, 47, 418, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2025, 5, 28, 14, 37, 47, 418, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2025, 5, 27, 14, 37, 47, 418, DateTimeKind.Local).AddTicks(12));
        }
    }
}
