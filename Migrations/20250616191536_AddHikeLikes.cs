using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HikingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddHikeLikes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "DateCreated",
                value: new DateTime(2025, 6, 15, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 6, 14, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 6, 13, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2025, 6, 12, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2025, 6, 11, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2025, 6, 10, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2025, 6, 9, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2025, 6, 7, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2025, 6, 6, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2025, 6, 5, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2025, 6, 4, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2025, 6, 3, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2025, 6, 2, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2025, 6, 1, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2025, 5, 31, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2025, 5, 30, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2025, 5, 29, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2025, 5, 28, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Hikes",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2025, 5, 27, 11, 18, 31, 137, DateTimeKind.Local).AddTicks(1310));
        }
    }
}
