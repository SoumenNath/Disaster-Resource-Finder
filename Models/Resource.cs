namespace DisasterResourceFinder.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Phone { get; set; }
        public string WebsiteUrl { get; set; }
        public string OpeningHours { get; set; }
        public int? Capacity { get; set; }
        public bool IsWheelchairAccessible { get; set; }
        public bool IsPetFriendly { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
