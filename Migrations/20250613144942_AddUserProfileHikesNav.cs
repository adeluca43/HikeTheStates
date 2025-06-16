using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUserProfileHikesNav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7de5baec-69b4-463d-a49d-b80c788b78bf", "AQAAAAIAAYagAAAAEBraA49PCmK3II0+J8Z1e0WmyeyrTOMpHCcr61VDfmSKxcw7Jj1UniZqFTkfIgkYZA==", "9df027a5-b40e-4e36-8840-e14383142a3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5989b3da-3049-4519-aaee-00c2299099a6", "AQAAAAIAAYagAAAAEOyyfQD1cdHmEpV3ZMEt0vs0cZ79OJBv5DBI4EWEtI7szsZex3DppccEHh93BWFnsA==", "e53e7da9-5d90-43ad-bb66-ab4522587767" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc21ff21-bf58-4047-ae6e-f94dbf905035", "AQAAAAIAAYagAAAAEEyqJW7hMzMR52allAPQulxKk22zCOmgJEmGiYwC3rRrGngzmgj1gM5mZjY5SVV/WA==", "775e650b-262a-4fdb-bc4a-2f81e62a73b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "baa9328a-3bc3-45b6-bf80-83e2e968c76b", "AQAAAAIAAYagAAAAEEfx0Eu09JzmLR72T2073MkHrPRH4g8myMNbFvDqWG1tyqs181p7Le4EiyIiCrPxsw==", "87455ed9-802f-43b9-aba9-527160efc2d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "164186f2-d512-483d-8ce5-bcd8e2770b38", "AQAAAAIAAYagAAAAECLFcOcM2MzLKSSFZ1AIccLAyJPdsHIJYfLHMgBc6BR6f6RkJ/4gl5CqlMLp7LXTdQ==", "8a9fae6b-e8fb-4d6f-a0ed-0651b73bcf43" });
        }
    }
}
