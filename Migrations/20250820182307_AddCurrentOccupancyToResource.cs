using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisasterResourceFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddCurrentOccupancyToResource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentOccupancy",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f0810f9-d868-43da-89a0-7aba58756ac4", "AQAAAAIAAYagAAAAEKK5HhvrwFzIcYKH9f1ZT2JDhi+tT3qmxw+hvPg7t6a1j7AgDj0kY4zFs8/DOzQkqQ==", "b59032fa-a7cd-4dcc-a66e-3b31479f633f" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CurrentOccupancy", "LastUpdated" },
                values: new object[] { 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2353) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentOccupancy",
                table: "Resources");

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
    }
}
