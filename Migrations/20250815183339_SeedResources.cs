using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DisasterResourceFinder.Migrations
{
    /// <inheritdoc />
    public partial class SeedResources : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Address", "Capacity", "City", "IsPetFriendly", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "Type", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "123 Main St", 150, "Toronto", false, true, new DateTime(2025, 8, 15, 18, 33, 38, 819, DateTimeKind.Utc).AddTicks(5750), 43.653199999999998, -79.383200000000002, "Downtown Emergency Shelter", "24/7", "416-555-1234", "M5H 2N2", "Shelter", "http://torontoshelter.ca" },
                    { 2, "456 Bloor St W", 300, "Toronto", true, true, new DateTime(2025, 8, 15, 18, 33, 38, 819, DateTimeKind.Utc).AddTicks(5753), 43.664999999999999, -79.414000000000001, "Westside Food Bank", "Mon-Fri 9am–5pm", "416-555-5678", "M6G 1K9", "Food", "http://westsidefoodbank.org" },
                    { 3, "789 Queen St E", 100, "Toronto", false, true, new DateTime(2025, 8, 15, 18, 33, 38, 819, DateTimeKind.Utc).AddTicks(5755), 43.658999999999999, -79.346999999999994, "City Medical Aid Clinic", "Mon–Sat 8am–8pm", "416-555-9012", "M4M 1H3", "Medical", "http://citymedclinic.ca" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
