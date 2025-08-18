using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DisasterResourceFinder.Data;
using DisasterResourceFinder.Models;
using Microsoft.AspNetCore.Authorization;

namespace DisasterResourceFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  //This attribute enables automatic model validation, binding, and 400 responses
    public class ResourcesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ResourcesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/resources?city=Tor&type=shelt&page=1&pageSize=5&sort=city&order=desc
        // ✅ Anyone can search/list
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<object>> GetResources(
            [FromQuery] string? city,
            [FromQuery] string? type,
            [FromQuery] string? name,   // new partial name filter
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? sort = "city",
            [FromQuery] string? order = "asc")
        {
            if (page <= 0) page = 1;
            if (pageSize <= 0 || pageSize > 100) pageSize = 10;

            var query = _context.Resources.AsQueryable();

            // Partial match filtering
            if (!string.IsNullOrWhiteSpace(city))
                query = query.Where(r => r.City.ToLower().Contains(city.ToLower()));

            if (!string.IsNullOrWhiteSpace(type))
                query = query.Where(r => r.Type.ToLower().Contains(type.ToLower()));

            if (!string.IsNullOrWhiteSpace(name))   // partial name search
                query = query.Where(r => r.Name.ToLower().Contains(name.ToLower()));

            // Sorting
            sort = sort?.ToLower();
            order = order?.ToLower();
            query = (sort, order) switch
            {
                ("name", "desc") => query.OrderByDescending(r => r.Name),
                ("name", _) => query.OrderBy(r => r.Name),
                ("type", "desc") => query.OrderByDescending(r => r.Type),
                ("type", _) => query.OrderBy(r => r.Type),
                ("city", "desc") => query.OrderByDescending(r => r.City),
                ("city", _) => query.OrderBy(r => r.City),
                _ => query.OrderBy(r => r.City)
            };

            // Pagination
            var totalCount = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var resources = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Response with metadata
            return Ok(new
            {
                Page = page,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = totalPages,
                SortBy = sort,
                SortOrder = order,
                Data = resources
            });
        }

        // GET: api/resources/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Resource>> GetResource(int id)
        {
            var resource = await _context.Resources.FindAsync(id);
            if (resource == null) return NotFound();
            return resource;
        }

        // POST: api/resources
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Resource>> CreateResource(Resource resource)
        {
            resource.LastUpdated = DateTime.UtcNow;
            _context.Resources.Add(resource);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetResource), new { id = resource.Id }, resource);
        }

        // PUT: api/resources/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateResource(int id, Resource updatedResource)
        {
            if (id != updatedResource.Id) return BadRequest();
            var resource = await _context.Resources.FindAsync(id);
            if (resource == null) return NotFound();

            // Update fields
            resource.Name = updatedResource.Name;
            resource.Type = updatedResource.Type;
            resource.Address = updatedResource.Address;
            resource.City = updatedResource.City;
            resource.PostalCode = updatedResource.PostalCode;
            resource.Latitude = updatedResource.Latitude;
            resource.Longitude = updatedResource.Longitude;
            resource.Phone = updatedResource.Phone;
            resource.WebsiteUrl = updatedResource.WebsiteUrl;
            resource.OpeningHours = updatedResource.OpeningHours;
            resource.Capacity = updatedResource.Capacity;
            resource.IsWheelchairAccessible = updatedResource.IsWheelchairAccessible;
            resource.IsPetFriendly = updatedResource.IsPetFriendly;
            resource.LastUpdated = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/resources/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteResource(int id)
        {
            var resource = await _context.Resources.FindAsync(id);
            if (resource == null) return NotFound();

            _context.Resources.Remove(resource);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
