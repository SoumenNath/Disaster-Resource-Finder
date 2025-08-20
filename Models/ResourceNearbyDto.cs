namespace DisasterResourceFinder.Models
{
    public class ResourceNearbyDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Phone { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? OpeningHours { get; set; }
        public int? Capacity { get; set; }
        public bool IsWheelchairAccessible { get; set; }
        public bool IsPetFriendly { get; set; }
        public DateTime LastUpdated { get; set; }
        public double DistanceKm { get; set; }
        public int CurrentOccupancy { get; set; }
        public int? AvailableSpots { get; set; }
    }
}
