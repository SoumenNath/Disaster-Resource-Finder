using System.ComponentModel.DataAnnotations;

namespace DisasterResourceFinder.Models
{
    public class Resource
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public string Type { get; set; } = null!; // Can be enum if preferred

        [Required, MaxLength(200)]
        public string Address { get; set; } = null!;

        [Required, MaxLength(50)]
        public string City { get; set; } = null!;

        [Required, MaxLength(10)]
        public string PostalCode { get; set; } = null!;

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [Phone]
        public string? Phone { get; set; }

        [Url]
        public string? WebsiteUrl { get; set; }

        [MaxLength(50)]
        public string? OpeningHours { get; set; }

        public int? Capacity { get; set; }
        public bool IsWheelchairAccessible { get; set; }
        public bool IsPetFriendly { get; set; }

        public DateTime LastUpdated { get; set; }

        public int CurrentOccupancy { get; set; } = 0;

        public int? AvailableSpots => Capacity.HasValue ? Capacity - CurrentOccupancy : null;
    }
}
