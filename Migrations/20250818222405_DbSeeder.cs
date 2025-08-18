using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisasterResourceFinder.Migrations
{
    /// <inheritdoc />
    public partial class DbSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "009d92ff-daab-47e2-89cf-e7f8b35417ed", "AQAAAAIAAYagAAAAEMoVrCuLWQSntHQp6AGx8CrRqie7EU941GQRAHPi+UWfhBWsSrDf3l1679oliYVJ/Q==", "371e5146-05e8-41d0-a35c-fc81fb902580" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 18, 22, 24, 4, 878, DateTimeKind.Utc).AddTicks(8052));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6468d28-321b-4215-b665-7f5263779ca6", "AQAAAAIAAYagAAAAEJHZSInq3sXaYvVRZCEza7CStU6uAl2A6EXnGR/ov0rajzNvQXWai8gG4IdBtriNnA==", "d8497772-e0b0-4222-87c3-bb0c2d14de23" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 16, 2, 36, 28, 292, DateTimeKind.Utc).AddTicks(2172));
        }
    }
}
