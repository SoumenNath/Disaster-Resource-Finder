using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisasterResourceFinder.Migrations
{
    /// <inheritdoc />
    public partial class ExpandSeedDataWithCapacity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Address", "Capacity", "CurrentOccupancy", "LastUpdated", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "100 Main St", 200, 120, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1681), "City Hall Shelter", "416-555-1000", "M1A1A1", "http://cityshelter.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "50 King St", 500, "Toronto", 300, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1685), 43.649999999999999, -79.379999999999995, "Downtown Food Bank", "9 AM – 5 PM", "416-555-2000", "M1A1B2", "http://foodbank.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "123 Health Ave", 1000, "Ottawa", 750, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1688), 45.421500000000002, -75.697199999999995, "General Hospital", "613-555-3000", "K1A0B1", "http://hospital.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "400 Queen St", 150, "Ottawa", 80, false, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1690), 45.423000000000002, -75.689999999999998, "Community Center Shelter", "6 PM – 8 AM", "613-555-4000", "K1A0C2", "http://communityshelter.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsPetFriendly", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "789 Market Rd", 300, "Vancouver", 220, false, true, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1691), 49.282699999999998, -123.1207, "West End Food Support", "10 AM – 6 PM", "604-555-5000", "V5K0A1", "http://westendfood.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "321 Care Blvd", 400, "Vancouver", 350, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1693), 49.280000000000001, -123.11, "Eastside Medical Clinic", "8 AM – 10 PM", "604-555-6000", "V5K0B2", "http://eastmedical.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "12 Dockside Ln", 120, "Halifax", 95, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1695), 44.648800000000001, -63.575200000000002, "Harborview Shelter", "902-555-7000", "B3H0A1", "http://harborshelter.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsPetFriendly", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "99 Gottingen St", 250, "Halifax", 180, false, false, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1697), 44.652000000000001, -63.579999999999998, "North End Food Pantry", "11 AM – 7 PM", "902-555-8000", "B3K3B5", "http://northendfood.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "77 Healthway", 200, "Halifax", 150, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1699), 44.650500000000001, -63.582099999999997, "St. Mary’s Clinic", "7 AM – 11 PM", "902-555-9000", "B3K2R5", "http://stmarysclinic.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsPetFriendly", "LastUpdated", "Latitude", "Longitude", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "345 Hope St", 180, "Montreal", 140, false, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1701), 45.5017, -73.567300000000003, "Downtown Women’s Shelter", "514-555-1000", "H3A1A1", "http://womenshelter.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "222 Park Ave", 400, "Montreal", 260, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1703), 45.515000000000001, -73.572999999999993, "Plateau Food Collective", "12 PM – 8 PM", "514-555-1100", "H2X1Y4", "http://plateaufood.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "456 Care St", 350, "Montreal", 280, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1704), 45.450000000000003, -73.579999999999998, "Verdun Health Center", "8 AM – 6 PM", "514-555-1200", "H4G1N3", "http://verdunhealth.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "Type", "WebsiteUrl" },
                values: new object[] { "101 Wheat Ln", 160, "Winnipeg", 130, false, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1706), 49.895099999999999, -97.138400000000004, "Prairie Haven Shelter", "24/7", "204-555-1300", "R3C0A1", "Shelter", "http://prairieshelter.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "Type", "WebsiteUrl" },
                values: new object[] { "88 Grain St", 280, "Winnipeg", 190, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1708), 49.890000000000001, -97.140000000000001, "West Winnipeg Food Hub", "9 AM – 3 PM", "204-555-1400", "R3C0B2", "Food", "http://winnipegfood.ca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "300 River Rd", 220, "Winnipeg", 160, new DateTime(2025, 8, 20, 18, 32, 31, 689, DateTimeKind.Utc).AddTicks(1710), 49.884, -97.123999999999995, "St. Boniface Clinic", "7 AM – 9 PM", "204-555-1500", "R2H1A7", "http://stbonifaceclinic.ca" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Address", "Capacity", "CurrentOccupancy", "LastUpdated", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "123 King St W", 150, 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2324), "Toronto Central Shelter", "123-456-7890", "M5H 1A1", "https://torontocentralshelter.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "456 Granville St", 300, "Vancouver", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2329), 49.282699999999998, -123.1207, "Vancouver Food Bank", "Mon–Fri 8 AM – 6 PM", "987-654-3210", "V6C 1T1", "https://vancouverfoodbank.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "789 8 Ave SW", 80, "Calgary", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2331), 51.044699999999999, -114.0719, "Calgary Emergency Clinic", "555-555-5555", "T2P 1H5", "https://calgaryemergencyclinic.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "101 Rue Sainte-Catherine O", 200, "Montreal", 0, true, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2333), 45.5017, -73.567300000000003, "Montreal Relief Center", "24/7", "514-123-4567", "H2X 2Z6", "https://montrealrelief.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsPetFriendly", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "12 Barrington St", 120, "Halifax", 0, true, false, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2335), 44.648800000000001, -63.575200000000002, "Halifax Aid Depot", "Tue–Sat 9 AM – 5 PM", "902-234-5678", "B3J 1Z1", "https://halifaxaid.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "33 Elgin St", 90, "Ottawa", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2337), 45.421500000000002, -75.697199999999995, "Ottawa Medical Unit", "24/7", "613-789-1234", "K1P 5W1", "https://ottawamedical.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "75 Main St", 100, "Winnipeg", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2339), 49.895099999999999, -97.138400000000004, "Winnipeg Crisis Shelter", "204-876-5432", "R3C 1A3", "https://winnipegshelter.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsPetFriendly", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "300 Douglas St", 350, "Victoria", 0, true, true, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2340), 48.428400000000003, -123.3656, "Victoria Community Kitchen", "Mon–Fri 8 AM – 8 PM", "250-222-3333", "V8V 2N6", "https://victoriakitchen.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "500 Broad St", 70, "Regina", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2342), 50.4452, -104.6189, "Regina Health Services", "24/7", "306-444-5555", "S4R 1X4", "https://reginahealth.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsPetFriendly", "LastUpdated", "Latitude", "Longitude", "Name", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "123 Jasper Ave", 130, "Edmonton", 0, true, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2344), 53.546100000000003, -113.49379999999999, "Edmonton Support Hub", "780-111-2222", "T5J 1A1", "https://edmontonshelter.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "45 Rue Saint-Jean", 220, "Quebec City", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2346), 46.813899999999997, -71.208200000000005, "Quebec City Food Assistance", "Mon–Fri 9 AM – 5 PM", "418-555-6666", "G1R 1S2", "https://quebeccityfood.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "10 21st St E", 65, "Saskatoon", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2348), 52.133200000000002, -106.67, "Saskatoon Urgent Care", "24/7", "306-777-8888", "S7K 0A5", "https://saskatoonmedical.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "IsWheelchairAccessible", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "Type", "WebsiteUrl" },
                values: new object[] { "200 Bay St", 400, "Toronto", 0, true, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2349), 43.655000000000001, -79.384, "Toronto Downtown Food Hub", "Mon–Sat 8 AM – 8 PM", "123-999-8888", "M5H 3T4", "Food", "https://torontofoodhub.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "Type", "WebsiteUrl" },
                values: new object[] { "777 Granville St", 180, "Vancouver", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2351), 49.280000000000001, -123.117, "Vancouver Emergency Shelter", "24/7", "987-222-3333", "V6Z 1L2", "Shelter", "https://vancouvershelter.example.com" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Capacity", "City", "CurrentOccupancy", "LastUpdated", "Latitude", "Longitude", "Name", "OpeningHours", "Phone", "PostalCode", "WebsiteUrl" },
                values: new object[] { "333 Rue Sherbrooke O", 90, "Montreal", 0, new DateTime(2025, 8, 20, 18, 23, 7, 432, DateTimeKind.Utc).AddTicks(2353), 45.503999999999998, -73.576999999999998, "Montreal Medical Unit", "24/7", "514-777-4444", "H3A 1G5", "https://montrealmedical.example.com" });
        }
    }
}
