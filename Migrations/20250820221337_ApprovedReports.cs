using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisasterResourceFinder.Migrations
{
    /// <inheritdoc />
    public partial class ApprovedReports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "ResourceReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "ResourceReports");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1f82ef-d9f6-4bf4-a431-0eb8730e0898", "AQAAAAIAAYagAAAAEP3Vk7P/2oVN8tQH9qXSe0/Tr0B39DLuDkYlHuqFx5OfWqijMx6k+ZI3dgluN6pOoQ==", "869cec50-508b-47f8-93e7-35358ab48d4d" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 21, 58, 2, 608, DateTimeKind.Utc).AddTicks(7743));
        }
    }
}
