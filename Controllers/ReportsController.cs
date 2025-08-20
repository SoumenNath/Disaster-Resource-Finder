using System.Security.Claims;
using DisasterResourceFinder.Data;
using DisasterResourceFinder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ReportsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public ReportsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // GET: api/reports?resourceId=5
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<ResourceReportDto>>> GetReports([FromQuery] int? resourceId)
    {
        var query = _context.ResourceReports
            .Include(r => r.User)
            .AsQueryable();

        // Filter by resourceId if provided
        if (resourceId.HasValue)
            query = query.Where(r => r.ResourceId == resourceId.Value);

        // Check admin role from JWT claims
        bool isAdmin = User.Claims.Any(c => c.Type == ClaimTypes.Role && c.Value == "Admin");

        // Only admins see all reports; everyone else sees only approved
        if (!isAdmin)
        {
            query = query.Where(r => r.IsApproved);
        }

        var reports = await query
            .OrderByDescending(r => r.CreatedAt)
            .Select(r => new ResourceReportDto
            {
                Id = r.Id,
                ResourceId = r.ResourceId,
                ReportType = r.ReportType,
                Description = r.Description,
                CreatedAt = r.CreatedAt,
                SubmittedBy = r.User.UserName,
                IsApproved = r.IsApproved
            })
            .ToListAsync();

        return reports;
    }


    // POST: api/reports
    [HttpPost]
    [Authorize] // must be logged-in user
    public async Task<ActionResult<ResourceReportDto>> PostReport(ResourceReportDto dto)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return Unauthorized();

        var report = new ResourceReport
        {
            ResourceId = dto.ResourceId,
            UserId = user.Id,
            ReportType = dto.ReportType,
            Description = dto.Description,
            CreatedAt = DateTime.UtcNow,
            IsApproved = false // reports require admin moderation
        };

        _context.ResourceReports.Add(report);
        await _context.SaveChangesAsync();

        dto.Id = report.Id;
        dto.CreatedAt = report.CreatedAt;
        dto.SubmittedBy = user.UserName;
        dto.IsApproved = false;

        return CreatedAtAction(nameof(GetReports), new { resourceId = dto.ResourceId }, dto);
    }

    // PUT: api/reports/approve/5
    [HttpPut("approve/{id}")]
    [Authorize(Roles = "Admin")] // only Admins can approve
    public async Task<IActionResult> ApproveReport(int id)
    {
        var report = await _context.ResourceReports.FindAsync(id);
        if (report == null)
            return NotFound();

        report.IsApproved = true;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/reports/5
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")] // only Admins can delete reports
    public async Task<IActionResult> DeleteReport(int id)
    {
        var report = await _context.ResourceReports.FindAsync(id);
        if (report == null)
            return NotFound();

        _context.ResourceReports.Remove(report);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
