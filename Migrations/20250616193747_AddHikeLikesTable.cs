using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddHikeLikesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HikeLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HikeId = table.Column<int>(type: "integer", nullable: false),
                    UserProfileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HikeLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HikeLikes_Hikes_HikeId",
                        column: x => x.HikeId,
                        principalTable: "Hikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HikeLikes_UserProfiles_UserProfileId",
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

            migrationBuilder.CreateIndex(
                name: "IX_HikeLikes_HikeId",
                table: "HikeLikes",
                column: "HikeId");

            migrationBuilder.CreateIndex(
                name: "IX_HikeLikes_UserProfileId",
                table: "HikeLikes",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HikeLikes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f877b37-3d6a-45ac-bccb-caaefaf131b2", "AQAAAAIAAYagAAAAEHh7U/HRfB9L7hpkptqENeAdTUzMWeVGvV2msmYINFmbmf9gKhgwB3IZH9bQaq48Bg==", "5a858707-f25f-452a-8dfd-789ad93494d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb833c6e-15af-4859-b5aa-8ae22213f714", "AQAAAAIAAYagAAAAEGnxOBV7ZHXr7Y/jfB+ce6YGKg6TAMkk2us28DJNj9DPr8wJT7T19GUYfvkeMZvQ7Q==", "a3acece8-3800-4df5-b531-846db3098c1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "297affdd-384c-4987-a6d5-6d20048eb4a5", "AQAAAAIAAYagAAAAEA3m1QYIuxa2NXixALxfkfbZqZi4FRU0sTAj7dQH6fskXi2lnTobyxVuC4IMTMoWjg==", "2999a55a-1ccd-4fc8-8414-cdec2e88079e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f34836a6-32ca-4135-af43-b3808544674d", "AQAAAAIAAYagAAAAEEMgoQRSsrz1DkxnxgQycWS3Uo8FciWRNn8cP5R31gUuUDhYqxb3QE0MRn8zvbj0Tw==", "b63ddd31-91f0-42f9-ac86-f4c639d8b802" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af7904d2-c6bd-4376-884f-ca1b661bf8d1", "AQAAAAIAAYagAAAAEOX9/HqqaRJt1/HvJ13OrheZondG+jb5ikXAliJiou+poMELx6LfjP3s5StsmGpzXg==", "a1df0316-fc9f-42c8-a0a0-135cee9e9672" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 6, 15, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 6, 14, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 6, 13, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2025, 6, 12, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2025, 6, 11, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2025, 6, 10, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2025, 6, 9, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2025, 6, 7, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2025, 6, 6, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2025, 6, 5, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2025, 6, 4, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2025, 6, 3, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2025, 6, 2, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2025, 6, 1, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2025, 5, 31, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2025, 5, 30, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2025, 5, 29, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2025, 5, 28, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2025, 5, 27, 14, 15, 36, 358, DateTimeKind.Local).AddTicks(9092));
        }
    }
}
