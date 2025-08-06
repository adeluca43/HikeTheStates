using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
