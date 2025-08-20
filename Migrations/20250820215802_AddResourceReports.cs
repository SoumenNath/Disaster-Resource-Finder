using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisasterResourceFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddResourceReports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResourceReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceReports_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResourceReports_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ResourceReports_ResourceId",
                table: "ResourceReports",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceReports_UserId",
                table: "ResourceReports",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResourceReports");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3beeafca-c2fa-4654-8f52-6e0963ef651c", "AQAAAAIAAYagAAAAEJedwnH5ny6+LDXhqSR2ecOSqUlS4KWt9EvBgtNwolSHJ6ZyDG1N1/CIYUxNyjAH5A==", "694b8c41-895c-4211-9bb3-7890e50936f6" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastUpdated",
                value: new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1710));
        }
    }
}
