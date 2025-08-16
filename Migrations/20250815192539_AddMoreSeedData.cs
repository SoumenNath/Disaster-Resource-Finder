using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DisasterResourceFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "LastUpdated", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "123 King St W", new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(326), "Toronto Central Shelter", "123-456-7890", "M5H 1A1", "https://torontocentralshelter.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "456 Granville St", "Vancouver", new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(329), 49.282699999999998, -123.1207, "Vancouver Food Bank", "Mon–Fri 8 AM – 6 PM", "987-654-3210", "V6C 1T1", "https://vancouverfoodbank.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Capacity", "City", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "789 8 Ave SW", 80, "Calgary", new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(331), 51.044699999999999, -114.0719, "Calgary Emergency Clinic", "24/7", "555-555-5555", "T2P 1H5", "https://calgaryemergencyclinic.example.com" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Address", "Capacity", "City", "IsPetFriendly", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "Type", "WebsiteUrl" },
                values: new object[,]
                {
                    { 4, "101 Rue Sainte-Catherine O", 200, "Montreal", true, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(333), 45.5017, -73.567300000000003, "Montreal Relief Center", "24/7", "514-123-4567", "H2X 2Z6", "Shelter", "https://montrealrelief.example.com" },
                    { 5, "12 Barrington St", 120, "Halifax", true, false, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(335), 44.648800000000001, -63.575200000000002, "Halifax Aid Depot", "Tue–Sat 9 AM – 5 PM", "902-234-5678", "B3J 1Z1", "Food", "https://halifaxaid.example.com" },
                    { 6, "33 Elgin St", 90, "Ottawa", false, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(337), 45.421500000000002, -75.697199999999995, "Ottawa Medical Unit", "24/7", "613-789-1234", "K1P 5W1", "Medical", "https://ottawamedical.example.com" },
                    { 7, "75 Main St", 100, "Winnipeg", true, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(339), 49.895099999999999, -97.138400000000004, "Winnipeg Crisis Shelter", "24/7", "204-876-5432", "R3C 1A3", "Shelter", "https://winnipegshelter.example.com" },
                    { 8, "300 Douglas St", 350, "Victoria", true, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(341), 48.428400000000003, -123.3656, "Victoria Community Kitchen", "Mon–Fri 8 AM – 8 PM", "250-222-3333", "V8V 2N6", "Food", "https://victoriakitchen.example.com" },
                    { 9, "500 Broad St", 70, "Regina", false, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(342), 50.4452, -104.6189, "Regina Health Services", "24/7", "306-444-5555", "S4R 1X4", "Medical", "https://reginahealth.example.com" },
                    { 10, "123 Jasper Ave", 130, "Edmonton", true, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(344), 53.546100000000003, -113.49379999999999, "Edmonton Support Hub", "24/7", "780-111-2222", "T5J 1A1", "Shelter", "https://edmontonshelter.example.com" },
                    { 11, "45 Rue Saint-Jean", 220, "Quebec City", true, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(346), 46.813899999999997, -71.208200000000005, "Quebec City Food Assistance", "Mon–Fri 9 AM – 5 PM", "418-555-6666", "G1R 1S2", "Food", "https://quebeccityfood.example.com" },
                    { 12, "10 21st St E", 65, "Saskatoon", false, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(348), 52.133200000000002, -106.67, "Saskatoon Urgent Care", "24/7", "306-777-8888", "S7K 0A5", "Medical", "https://saskatoonmedical.example.com" },
                    { 13, "200 Bay St", 400, "Toronto", true, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(350), 43.655000000000001, -79.384, "Toronto Downtown Food Hub", "Mon–Sat 8 AM – 8 PM", "123-999-8888", "M5H 3T4", "Food", "https://torontofoodhub.example.com" },
                    { 14, "777 Granville St", 180, "Vancouver", false, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(351), 49.280000000000001, -123.117, "Vancouver Emergency Shelter", "24/7", "987-222-3333", "V6Z 1L2", "Shelter", "https://vancouvershelter.example.com" },
                    { 15, "333 Rue Sherbrooke O", 90, "Montreal", false, true, new DateTime(2025, 8, 15, 19, 25, 38, 861, DateTimeKind.Utc).AddTicks(353), 45.503999999999998, -73.576999999999998, "Montreal Medical Unit", "24/7", "514-777-4444", "H3A 1G5", "Medical", "https://montrealmedical.example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "LastUpdated", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "123 Main St", new DateTime(2025, 8, 15, 18, 33, 38, 819, DateTimeKind.Utc).AddTicks(5750), "Downtown Emergency Shelter", "416-555-1234", "M5H 2N2", "http://torontoshelter.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "456 Bloor St W", "Toronto", new DateTime(2025, 8, 15, 18, 33, 38, 819, DateTimeKind.Utc).AddTicks(5753), 43.664999999999999, -79.414000000000001, "Westside Food Bank", "Mon-Fri 9am–5pm", "416-555-5678", "M6G 1K9", "http://westsidefoodbank.org" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Capacity", "City", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "789 Queen St E", 100, "Toronto", new DateTime(2025, 8, 15, 18, 33, 38, 819, DateTimeKind.Utc).AddTicks(5755), 43.658999999999999, -79.346999999999994, "City Medical Aid Clinic", "Mon–Sat 8am–8pm", "416-555-9012", "M4M 1H3", "http://citymedclinic.ca" });
        }
    }
}
