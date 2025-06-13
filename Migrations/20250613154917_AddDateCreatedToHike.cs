using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDateCreatedToHike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Hikes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Hikes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deebb8e9-fc29-4989-a9b7-26486f1a9d46", "AQAAAAIAAYagAAAAEA80KfYwHMjBeeVNqNBkKXqRR7K49oQeRpPVyl7QwC14o+cmvEQiWR70s4pmAn6RIA==", "e5ccbf46-3d64-4a4a-938f-42579697a3ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0875641-c860-4d9a-a9c6-144c3bde8481", "AQAAAAIAAYagAAAAEBE1P4HhoqDsE2u+J4l2AJF4YQPNd8uERRItLGWjXHgqH57VbFTb0lyJgNqf/QFZlQ==", "bda3d1e2-2150-463c-99ce-32024365f959" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e11e078-6020-4e95-b884-f98312c16566", "AQAAAAIAAYagAAAAEONenrEoBQnC7spXa6EAgrHi5bvIcURe7SCAiIz+hQJUN5C9Q4oD4WZoEAEqgZ2vTg==", "f2d97fac-f235-4ef7-840f-678ed8842bbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1542503a-ea8e-4add-8120-83b424062dc1", "AQAAAAIAAYagAAAAEDahMcQ3IWqEiFQufbldcDSaajm+An5QHplu9HHH3ct1leodRif/37hozWpcbvJoRQ==", "2a833ee1-3a0e-4c46-ac86-3490d6f6611f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f81e347f-df07-43d3-b0a7-e8cb14c7b310", "AQAAAAIAAYagAAAAEKzv+0Ywb4z/Y7cADmmMgqSjPCInBLReMp+h8PWQkVV+QulQJ2s9TiR9FhFsKgAKXw==", "c166d825-c407-4f21-acef-c8061c2a109a" });
        }
    }
}
