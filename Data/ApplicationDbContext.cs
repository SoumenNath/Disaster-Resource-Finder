using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DisasterResourceFinder.Models;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;
namespace DisasterResourceFinder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

        public DbSet<Resource> Resources { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }
            );

            // Seed admin user
            var hasher = new PasswordHasher<IdentityUser>();
            var adminUser = new IdentityUser
            {
                Id = "100",
                UserName = "admin@demo.com",
                NormalizedUserName = "ADMIN@DEMO.COM",
                Email = "admin@demo.com",
                NormalizedEmail = "ADMIN@DEMO.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin123!");

            modelBuilder.Entity<IdentityUser>().HasData(adminUser);

            // Seed the UserRole relationship
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1", // Admin role
                    UserId = "100" // Admin user
                }
            );

            modelBuilder.Entity<Resource>().HasData(
                new Resource { Id = 1, Name = "City Hall Shelter", Type = "Shelter", Address = "100 Main St", City = "Toronto", PostalCode = "M1A1A1", Latitude = 43.6532, Longitude = -79.3832, Phone = "416-555-1000", WebsiteUrl = "http://cityshelter.ca", OpeningHours = "24/7", Capacity = 200, CurrentOccupancy = 120, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 2, Name = "Downtown Food Bank", Type = "Food", Address = "50 King St", City = "Toronto", PostalCode = "M1A1B2", Latitude = 43.6500, Longitude = -79.3800, Phone = "416-555-2000", WebsiteUrl = "http://foodbank.ca", OpeningHours = "9 AM – 5 PM", Capacity = 500, CurrentOccupancy = 300, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 3, Name = "General Hospital", Type = "Medical", Address = "123 Health Ave", City = "Ottawa", PostalCode = "K1A0B1", Latitude = 45.4215, Longitude = -75.6972, Phone = "613-555-3000", WebsiteUrl = "http://hospital.ca", OpeningHours = "24/7", Capacity = 1000, CurrentOccupancy = 750, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 4, Name = "Community Center Shelter", Type = "Shelter", Address = "400 Queen St", City = "Ottawa", PostalCode = "K1A0C2", Latitude = 45.4230, Longitude = -75.6900, Phone = "613-555-4000", WebsiteUrl = "http://communityshelter.ca", OpeningHours = "6 PM – 8 AM", Capacity = 150, CurrentOccupancy = 80, IsWheelchairAccessible = false, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 5, Name = "West End Food Support", Type = "Food", Address = "789 Market Rd", City = "Vancouver", PostalCode = "V5K0A1", Latitude = 49.2827, Longitude = -123.1207, Phone = "604-555-5000", WebsiteUrl = "http://westendfood.ca", OpeningHours = "10 AM – 6 PM", Capacity = 300, CurrentOccupancy = 220, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 6, Name = "Eastside Medical Clinic", Type = "Medical", Address = "321 Care Blvd", City = "Vancouver", PostalCode = "V5K0B2", Latitude = 49.2800, Longitude = -123.1100, Phone = "604-555-6000", WebsiteUrl = "http://eastmedical.ca", OpeningHours = "8 AM – 10 PM", Capacity = 400, CurrentOccupancy = 350, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 7, Name = "Harborview Shelter", Type = "Shelter", Address = "12 Dockside Ln", City = "Halifax", PostalCode = "B3H0A1", Latitude = 44.6488, Longitude = -63.5752, Phone = "902-555-7000", WebsiteUrl = "http://harborshelter.ca", OpeningHours = "24/7", Capacity = 120, CurrentOccupancy = 95, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 8, Name = "North End Food Pantry", Type = "Food", Address = "99 Gottingen St", City = "Halifax", PostalCode = "B3K3B5", Latitude = 44.6520, Longitude = -63.5800, Phone = "902-555-8000", WebsiteUrl = "http://northendfood.ca", OpeningHours = "11 AM – 7 PM", Capacity = 250, CurrentOccupancy = 180, IsWheelchairAccessible = false, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 9, Name = "St. Mary’s Clinic", Type = "Medical", Address = "77 Healthway", City = "Halifax", PostalCode = "B3K2R5", Latitude = 44.6505, Longitude = -63.5821, Phone = "902-555-9000", WebsiteUrl = "http://stmarysclinic.ca", OpeningHours = "7 AM – 11 PM", Capacity = 200, CurrentOccupancy = 150, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 10, Name = "Downtown Women’s Shelter", Type = "Shelter", Address = "345 Hope St", City = "Montreal", PostalCode = "H3A1A1", Latitude = 45.5017, Longitude = -73.5673, Phone = "514-555-1000", WebsiteUrl = "http://womenshelter.ca", OpeningHours = "24/7", Capacity = 180, CurrentOccupancy = 140, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 11, Name = "Plateau Food Collective", Type = "Food", Address = "222 Park Ave", City = "Montreal", PostalCode = "H2X1Y4", Latitude = 45.5150, Longitude = -73.5730, Phone = "514-555-1100", WebsiteUrl = "http://plateaufood.ca", OpeningHours = "12 PM – 8 PM", Capacity = 400, CurrentOccupancy = 260, IsWheelchairAccessible = true, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 12, Name = "Verdun Health Center", Type = "Medical", Address = "456 Care St", City = "Montreal", PostalCode = "H4G1N3", Latitude = 45.4500, Longitude = -73.5800, Phone = "514-555-1200", WebsiteUrl = "http://verdunhealth.ca", OpeningHours = "8 AM – 6 PM", Capacity = 350, CurrentOccupancy = 280, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 13, Name = "Prairie Haven Shelter", Type = "Shelter", Address = "101 Wheat Ln", City = "Winnipeg", PostalCode = "R3C0A1", Latitude = 49.8951, Longitude = -97.1384, Phone = "204-555-1300", WebsiteUrl = "http://prairieshelter.ca", OpeningHours = "24/7", Capacity = 160, CurrentOccupancy = 130, IsWheelchairAccessible = false, IsPetFriendly = true, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 14, Name = "West Winnipeg Food Hub", Type = "Food", Address = "88 Grain St", City = "Winnipeg", PostalCode = "R3C0B2", Latitude = 49.8900, Longitude = -97.1400, Phone = "204-555-1400", WebsiteUrl = "http://winnipegfood.ca", OpeningHours = "9 AM – 3 PM", Capacity = 280, CurrentOccupancy = 190, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow },
                new Resource { Id = 15, Name = "St. Boniface Clinic", Type = "Medical", Address = "300 River Rd", City = "Winnipeg", PostalCode = "R2H1A7", Latitude = 49.8840, Longitude = -97.1240, Phone = "204-555-1500", WebsiteUrl = "http://stbonifaceclinic.ca", OpeningHours = "7 AM – 9 PM", Capacity = 220, CurrentOccupancy = 160, IsWheelchairAccessible = true, IsPetFriendly = false, LastUpdated = DateTime.UtcNow }
            );
        }
    }

}
