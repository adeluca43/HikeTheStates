using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFavorite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserProfileId = table.Column<int>(type: "integer", nullable: false),
                    HikeId = table.Column<int>(type: "integer", nullable: false),
                    DateFavorited = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_Hikes_HikeId",
                        column: x => x.HikeId,
                        principalTable: "Hikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_UserProfiles_UserProfileId",
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
                values: new object[] { "9981eceb-4101-44e0-8aff-a05fab2c9154", "AQAAAAIAAYagAAAAEPpTT//5mYTA2tVc4kV9mXK0TzT4phApBjqhfjJfN/Yy4UACQzDy25+t6iTvM08ctg==", "f47f10f7-1a23-4f63-88f3-c430255ad7b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a8e3438-d7a2-438f-8a23-48c10e52d092", "AQAAAAIAAYagAAAAEOnD0Bzyh0Oly90pZHGFYJ+hw0cGiNbQ7sJFNVoGnC57hJwcP4wTFP6ynlLlDckyVA==", "b937d90f-f3df-4134-ad12-c5c407013267" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51eff849-cce3-433f-a53d-790f34c61f83", "AQAAAAIAAYagAAAAEOpTDQFVBnGdkRkuRj1MABv/YOyPXCvFOAZ34Lg/BboMdBYHK9Olj3MqAp49j5OxHg==", "56d38c61-a656-4b29-806f-9d1a1e3f8972" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f87fb24e-2a29-45df-93c6-00b5bc081d14", "AQAAAAIAAYagAAAAEMuCof9nvNfw019n06hey9MDlFp14E3fUmmwU/HlJeCjaG6pR+vretcvrSDTAsrwUA==", "15e3c3b2-48c7-4a7b-9389-60b97005609d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "183fca14-a235-42f0-9636-380f221740f7", "AQAAAAIAAYagAAAAEONcvK2UenML2FEuYGSdbpx1lHtvXJLWTNUmQbAcsOHP0cFJ61jFrKwUWVHZnr55jA==", "c08fa234-14f8-4d64-89cd-6723959cedad" });

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 6, 30, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 6, 29, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 6, 28, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2025, 6, 27, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2025, 6, 26, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2025, 6, 25, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2025, 6, 24, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2025, 6, 23, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2025, 6, 22, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2025, 6, 21, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2025, 6, 20, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2025, 6, 19, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2025, 6, 18, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2025, 6, 17, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2025, 6, 16, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2025, 6, 15, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2025, 6, 14, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2025, 6, 13, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2025, 6, 12, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2025, 6, 11, 12, 9, 42, 440, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_HikeId",
                table: "Favorites",
                column: "HikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserProfileId",
                table: "Favorites",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

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
    }
}
