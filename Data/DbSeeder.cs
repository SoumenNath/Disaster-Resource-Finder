using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DisasterResourceFinder.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminUserAsync(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            using var scope = serviceProvider.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            string adminRole = "Admin";
            string userRole = "User";

            // Ensure roles exist
            if (!await roleManager.RoleExistsAsync(adminRole))
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
            }
            if (!await roleManager.RoleExistsAsync(userRole))
            {
                await roleManager.CreateAsync(new IdentityRole(userRole));
            }

            // Get admin credentials from appsettings.json
            string adminEmail = configuration["AdminUser:Email"] ?? "admin@disasterfinder.com";
            string adminPassword = configuration["AdminUser:Password"] ?? "Admin@123";

            // Ensure Admin user exists
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, adminRole);
                }
            }
            else
            {
                if (!await userManager.IsInRoleAsync(adminUser, adminRole))
                {
                    await userManager.AddToRoleAsync(adminUser, adminRole);
                }
            }

            // Ensure at least one normal user exists for testing reports
            string normalUserEmail = configuration["NormalUser:Email"] ?? "user@disasterfinder.com";
            string normalUserPassword = configuration["NormalUser:Password"] ?? "User@123";

            var normalUser = await userManager.FindByEmailAsync(normalUserEmail);
            if (normalUser == null)
            {
                normalUser = new IdentityUser
                {
                    UserName = normalUserEmail,
                    Email = normalUserEmail,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(normalUser, normalUserPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(normalUser, userRole);
                }
            }

            // ------------------------------
            // Seed 15 ResourceReports
            // ------------------------------
            if (!context.ResourceReports.Any())
            {
                var random = new Random();
                var reportTypes = new[] { "Availability", "Supplies", "Accessibility", "Staffing", "Other" };

                var reports = new List<ResourceReport>();

                for (int i = 1; i <= 15; i++)
                {
                    // Pick a random resource (assuming you have at least 10 resources)
                    int resourceId = random.Next(1, 11);

                    // Randomly assign to admin or normal user
                    var user = random.Next(0, 2) == 0 ? normalUser : adminUser;

                    // Random report type
                    string type = reportTypes[random.Next(reportTypes.Length)];

                    // Random description
                    string description = type switch
                    {
                        "Availability" => "Shelter occupancy is high",
                        "Supplies" => "Running low on essential supplies",
                        "Accessibility" => "Wheelchair ramp temporarily blocked",
                        "Staffing" => "Medical staff unavailable at the moment",
                        _ => "General update from user"
                    };

                    // Random approval status
                    bool isApproved = random.Next(0, 2) == 0; // 50% chance approved

                    // Random created timestamp in past 7 days
                    var createdAt = DateTime.UtcNow.AddDays(-random.Next(0, 7)).AddHours(-random.Next(0, 24));

                    reports.Add(new ResourceReport
                    {
                        ResourceId = resourceId,
                        UserId = user.Id,
                        ReportType = type,
                        Description = description,
                        CreatedAt = createdAt,
                        IsApproved = isApproved
                    });
                }

                context.ResourceReports.AddRange(reports);
                await context.SaveChangesAsync();
            }
        }
    }
}
