using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisasterResourceFinder.Migrations
{
    /// <inheritdoc />
    public partial class SeededReports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce3a21b1-acbb-46cb-a86b-b3c587f5a6eb", "AQAAAAIAAYagAAAAEJY6jBOES20NvMCoXHqo3TSuxEJ0SwEh0owmgpFDPDBE0vi/+1SQ/N9dg5ri2x8MNg==", "3d04dfcc-a6ed-476a-899f-81532e6a06b8" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 28, 9, 0, DateTimeKind.Utc).AddTicks(3493));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d8d4def-ad94-4aed-836a-49d26857bfe4", "AQAAAAIAAYagAAAAEH6ZvqYGErkRdlfvNXOR7DFEkj/QsJByEssGZ/AxeO6FJsDE3trH8QnwSxrca0PDCw==", "4f9d2bc2-401f-4cde-afc8-873cca04874a" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 22, 13, 36, 920, DateTimeKind.Utc).AddTicks(9348));
        }
    }
}
