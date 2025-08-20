namespace DisasterResourceFinder.Models
{
    public class ResourceReportDto
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public string ReportType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string SubmittedBy { get; set; }   // username/email

        public bool IsApproved { get; set; }
    }
}
