using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Repositories.Helpers;
using Microsoft.AspNetCore.Identity;

namespace BeeBuzz.Data
{
    public class BeeBuzzSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _hosting;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public BeeBuzzSeeder(
            ApplicationDbContext context, 
            IWebHostEnvironment hosting, 
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<int>> roleManager
            )
        {
            _db = context;
            _hosting = hosting;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            _db.Database.EnsureDeleted();
            _db.Database.EnsureCreated();

            if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await _roleManager.CreateAsync(new IdentityRole<int>(UserRoles.Admin));
            }

            if (!await _roleManager.RoleExistsAsync(UserRoles.Default))
            {
                await _roleManager.CreateAsync(new IdentityRole<int>(UserRoles.Default));
            }

            var admins = await _userManager.GetUsersInRoleAsync(UserRoles.Admin);


            ApplicationUser newAdmin = null;

            if (admins.Count == 0)
            {
                newAdmin = new ApplicationUser()
                {
                    UserName = "DefaultAdmin",
                    Email = "admin@default.com",
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                var result = await _userManager.CreateAsync(newAdmin, "Admin.123");

                if (!result.Succeeded)
                {
                    throw new Exception(result.ToString());
                }

                result = await _userManager.AddToRoleAsync(newAdmin, UserRoles.Admin);

                if (!result.Succeeded)
                {
                    throw new Exception(result.ToString());
                }
            }

            if (!_db.BeeHiveOrganizations.Any())
            {
                BeeBuzzOrganization defaultOrg =
                    new BeeBuzzOrganization()
                    {
                        OrganizationId = "0000-0000-0000-0000",
                        Members = new List<ApplicationUser>([
                            newAdmin
                            ])
                    };

                _db.BeeHiveOrganizations.Add(defaultOrg);

                _db.SaveChanges();
            }
        }
    }
}
