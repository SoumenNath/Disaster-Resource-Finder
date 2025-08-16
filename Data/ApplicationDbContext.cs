using Microsoft.EntityFrameworkCore;
using DisasterResourceFinder.Models;
namespace DisasterResourceFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

        public DbSet<Resource> Resources { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Resource>().HasData(
                new Resource { Id = 1, Name = "Toronto Central Shelter", Type = "Shelter", Address = "123 King St W", City = "Toronto", PostalCode = "M5H 1A1", Latitude = 43.6532, Longitude = -79.3832, Phone = "123-456-7890", WebsiteUrl = "https://torontocentralshelter.example.com", OpeningHours = "24/7", Capacity = 150, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 2, Name = "Vancouver Food Bank", Type = "Food", Address = "456 Granville St", City = "Vancouver", PostalCode = "V6C 1T1", Latitude = 49.2827, Longitude = -123.1207, Phone = "987-654-3210", WebsiteUrl = "https://vancouverfoodbank.example.com", OpeningHours = "Mon–Fri 8 AM – 6 PM", Capacity = 300, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 3, Name = "Calgary Emergency Clinic", Type = "Medical", Address = "789 8 Ave SW", City = "Calgary", PostalCode = "T2P 1H5", Latitude = 51.0447, Longitude = -114.0719, Phone = "555-555-5555", WebsiteUrl = "https://calgaryemergencyclinic.example.com", OpeningHours = "24/7", Capacity = 80, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 4, Name = "Montreal Relief Center", Type = "Shelter", Address = "101 Rue Sainte-Catherine O", City = "Montreal", PostalCode = "H2X 2Z6", Latitude = 45.5017, Longitude = -73.5673, Phone = "514-123-4567", WebsiteUrl = "https://montrealrelief.example.com", OpeningHours = "24/7", Capacity = 200, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 5, Name = "Halifax Aid Depot", Type = "Food", Address = "12 Barrington St", City = "Halifax", PostalCode = "B3J 1Z1", Latitude = 44.6488, Longitude = -63.5752, Phone = "902-234-5678", WebsiteUrl = "https://halifaxaid.example.com", OpeningHours = "Tue–Sat 9 AM – 5 PM", Capacity = 120, IsWheelchairAccessible = false, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 6, Name = "Ottawa Medical Unit", Type = "Medical", Address = "33 Elgin St", City = "Ottawa", PostalCode = "K1P 5W1", Latitude = 45.4215, Longitude = -75.6972, Phone = "613-789-1234", WebsiteUrl = "https://ottawamedical.example.com", OpeningHours = "24/7", Capacity = 90, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 7, Name = "Winnipeg Crisis Shelter", Type = "Shelter", Address = "75 Main St", City = "Winnipeg", PostalCode = "R3C 1A3", Latitude = 49.8951, Longitude = -97.1384, Phone = "204-876-5432", WebsiteUrl = "https://winnipegshelter.example.com", OpeningHours = "24/7", Capacity = 100, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 8, Name = "Victoria Community Kitchen", Type = "Food", Address = "300 Douglas St", City = "Victoria", PostalCode = "V8V 2N6", Latitude = 48.4284, Longitude = -123.3656, Phone = "250-222-3333", WebsiteUrl = "https://victoriakitchen.example.com", OpeningHours = "Mon–Fri 8 AM – 8 PM", Capacity = 350, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 9, Name = "Regina Health Services", Type = "Medical", Address = "500 Broad St", City = "Regina", PostalCode = "S4R 1X4", Latitude = 50.4452, Longitude = -104.6189, Phone = "306-444-5555", WebsiteUrl = "https://reginahealth.example.com", OpeningHours = "24/7", Capacity = 70, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 10, Name = "Edmonton Support Hub", Type = "Shelter", Address = "123 Jasper Ave", City = "Edmonton", PostalCode = "T5J 1A1", Latitude = 53.5461, Longitude = -113.4938, Phone = "780-111-2222", WebsiteUrl = "https://edmontonshelter.example.com", OpeningHours = "24/7", Capacity = 130, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 11, Name = "Quebec City Food Assistance", Type = "Food", Address = "45 Rue Saint-Jean", City = "Quebec City", PostalCode = "G1R 1S2", Latitude = 46.8139, Longitude = -71.2082, Phone = "418-555-6666", WebsiteUrl = "https://quebeccityfood.example.com", OpeningHours = "Mon–Fri 9 AM – 5 PM", Capacity = 220, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 12, Name = "Saskatoon Urgent Care", Type = "Medical", Address = "10 21st St E", City = "Saskatoon", PostalCode = "S7K 0A5", Latitude = 52.1332, Longitude = -106.6700, Phone = "306-777-8888", WebsiteUrl = "https://saskatoonmedical.example.com", OpeningHours = "24/7", Capacity = 65, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 13, Name = "Toronto Downtown Food Hub", Type = "Food", Address = "200 Bay St", City = "Toronto", PostalCode = "M5H 3T4", Latitude = 43.6550, Longitude = -79.3840, Phone = "123-999-8888", WebsiteUrl = "https://torontofoodhub.example.com", OpeningHours = "Mon–Sat 8 AM – 8 PM", Capacity = 400, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 14, Name = "Vancouver Emergency Shelter", Type = "Shelter", Address = "777 Granville St", City = "Vancouver", PostalCode = "V6Z 1L2", Latitude = 49.2800, Longitude = -123.1170, Phone = "987-222-3333", WebsiteUrl = "https://vancouvershelter.example.com", OpeningHours = "24/7", Capacity = 180, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 15, Name = "Montreal Medical Unit", Type = "Medical", Address = "333 Rue Sherbrooke O", City = "Montreal", PostalCode = "H3A 1G5", Latitude = 45.5040, Longitude = -73.5770, Phone = "514-777-4444", WebsiteUrl = "https://montrealmedical.example.com", OpeningHours = "24/7", Capacity = 90, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow }
            );
        }
    }

}
