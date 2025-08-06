using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class FixCommentUserProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    HikeId = table.Column<int>(type: "integer", nullable: false),
                    UserProfileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Hikes_HikeId",
                        column: x => x.HikeId,
                        principalTable: "Hikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c36aea2b-2052-4788-b403-e469775a0d1a", "AQAAAAIAAYagAAAAEO5E0lUDcU7496VQH1sGvAdrT6X3zEknWdJGbfxLl9mTqxjrtvPRbUd6OHWJg/TFTQ==", "c7d7771e-7f3e-41a2-9987-34f7c556513d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9f6ec3a-799a-44e9-b367-f2dc9008bfe5", "AQAAAAIAAYagAAAAEFzadljRqqLLY+ZCiWHfm0+ajR4iQBegBNfGlyJ25RWhC7aPBrZFb8lijT/c77b4HQ==", "e897781f-2d97-4040-a759-63a916b7ad8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1845a358-ee53-4e48-b8df-dc700e0e9630", "AQAAAAIAAYagAAAAEJHJGgG3ZDiGdwzsuyvxWXRm98cnP/kMBAO3QEnhalroJH8/LYUBME0Y2FQN/yvI1Q==", "9ae8c9c7-ad1f-400f-bf90-7649509ccefc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90246f70-0046-4c43-b494-05dd644fad82", "AQAAAAIAAYagAAAAEKwuDw19LWyxojToELvgbATetIUKM6GeiSAa2suuynvBS6sstZ3nZ8pAUQoDdz4igw==", "0ba99aa5-ac19-445c-8b06-4feb7bc24e8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2cf4dce-8ca1-446c-b5c8-d140192c8a56", "AQAAAAIAAYagAAAAEMixQ7iAQscsnkbuoHWNLaKh8m9abSb5RqiOvfjveSXIneHPlnxT580JhQcC4iz4Ng==", "a26e1d74-b568-472b-bf3f-d3dc563f0b50" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 8, 5, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 8, 4, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 8, 3, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2025, 8, 2, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2025, 8, 1, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2025, 7, 31, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2025, 7, 30, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2025, 7, 29, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2025, 7, 28, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2025, 7, 27, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2025, 7, 26, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2025, 7, 25, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2025, 7, 24, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2025, 7, 23, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2025, 7, 22, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2025, 7, 21, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2025, 7, 20, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2025, 7, 19, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2025, 7, 18, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2025, 7, 17, 12, 52, 44, 184, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_HikeId",
                table: "Comments",
                column: "HikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserProfileId",
                table: "Comments",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ccf356a-b0cd-4b29-b8ed-9369db203b6e", "AQAAAAIAAYagAAAAEHvStkYpDLS0YXdz/Y8YfFncs/6zexyQp3juFN7Ft0UcEVX8JYApe+vysEMOIvpx9Q==", "ac00a2b2-2ee0-421f-928c-c955e888b135" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa011864-e638-4971-9172-c0e7b6b3d726", "AQAAAAIAAYagAAAAEMk1Otopw9HaXWs2GzMAiQORyXZpHIGy/qBH70tbXy4MyzS2DWAhBDbblGEGx1vVYQ==", "3bcaafdb-bd88-423e-9202-b82f45e61cae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af6fe05b-8829-46c7-846e-2a9d234a4368", "AQAAAAIAAYagAAAAEJFMg6AlJ7tNcrnSZ/YcLlZLM9JQi2bF2ytbDXcviHSmewzGYFjE9OMGpXmcKP8DmQ==", "6c429408-f785-4c77-9e2f-0906d5cc97fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e48808b-0912-4948-9058-5d8056a37f6b", "AQAAAAIAAYagAAAAECBdPs2dSm81u+J29q2eNLh26v21oYfgsA142NxOd5SuUbYF7saFRwWVhatXSBINmg==", "8128e5fd-2f72-4aa6-a177-70ca8ce25e90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acde978b-613a-4e84-9676-f6d4f10354a0", "AQAAAAIAAYagAAAAEHTkEdpLSEiC6iQXOOUvpizw7IlpF4EUaWg6O5TQ/Utab3FlM+2j/wiTLsdScZ1cvA==", "29bc9208-e8df-4492-a7b1-3a82f6f21e00" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 8, 5, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 8, 4, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 8, 3, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2025, 8, 2, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2025, 8, 1, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2025, 7, 31, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2025, 7, 30, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2025, 7, 29, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2025, 7, 28, 11, 57, 6, 749, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2025, 7, 27, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2025, 7, 26, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2025, 7, 25, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2025, 7, 24, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2025, 7, 23, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2025, 7, 22, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2025, 7, 21, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2025, 7, 20, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2025, 7, 19, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2025, 7, 18, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2025, 7, 17, 11, 57, 6, 750, DateTimeKind.Local).AddTicks(114));
        }
    }
}
