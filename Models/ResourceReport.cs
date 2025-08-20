using DisasterResourceFinder.Models;
using Microsoft.AspNetCore.Identity;

public class ResourceReport
{
    public int Id { get; set; }                     // Primary key
    public int ResourceId { get; set; }             // FK to Resource
    public string UserId { get; set; }              // FK to AspNetUsers
    public string ReportType { get; set; }          // e.g., "Availability", "Supplies", "Accessibility"
    public string Description { get; set; }         // Free text details
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsApproved { get; set; }

    // Navigation properties
    public Resource Resource { get; set; }
    public IdentityUser User { get; set; }   // use built-in IdentityUser
}
