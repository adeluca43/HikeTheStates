using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTrailFeatureFieldsToHike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasRestrooms",
                table: "Hikes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsGravel",
                table: "Hikes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHandicapAccessible",
                table: "Hikes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsKidFriendly",
                table: "Hikes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaved",
                table: "Hikes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasRestrooms",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "IsGravel",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "IsHandicapAccessible",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "IsKidFriendly",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "IsPaved",
                table: "Hikes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20dd84f2-8f82-44e1-a24e-4deb4511621c", "AQAAAAIAAYagAAAAEK5zB5oq4ca0iptggdzPQacsqjfTDR3wta/uqdUls4hhsExaOJyu4ySiT9gXnkwENg==", "1aa7b51c-0489-415d-9404-89fa456c2db2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99f593f5-3701-42d9-90d5-40c86633e216", "AQAAAAIAAYagAAAAEJI1H5GtrJrZHvSAgXk3SD6y3FLKaE4nh9rwDzb29S8ScdrsutYZjEmnCg7e4CLtZQ==", "b01adb0f-3ff4-4449-b702-88d70896f152" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22fbb6f9-248b-4f4c-9ea5-79bae3bca78f", "AQAAAAIAAYagAAAAELTcpkBzWR+2I0Wxs+b4TsmHzgRqw+7JuzKncUE57wR21q68LKliM7Ew1a0yUGj1Jg==", "0a8830de-7e7e-4d43-beb6-751595e49851" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5c961b4-fbf7-4a07-b72d-26c1cc728a2b", "AQAAAAIAAYagAAAAEGhPKLWjAya4Pw7FNfIYqvqtpTGQDpBn0Usj/2PfKSQtQAkBHRp5o3Ls/iZBYq9AaQ==", "eac3085f-8433-46e6-9b26-047a1833cfe4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d885688-13b6-42e1-9ea3-50c78b57e3d8", "AQAAAAIAAYagAAAAENWrHzdTJ/G/lv8MIYFHthFBcUD/qAA8bDYy8uDjt359gm+8gOalALqCIn2L4nBvkw==", "544ccbe7-b9cd-4918-bbff-ae7a8e36b105" });
        }
    }
}
