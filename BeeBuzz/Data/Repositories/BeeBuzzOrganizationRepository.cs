using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzOrganizationRepository : BeeBuzzGenericGenericRepository<BeeBuzzOrganization>
    {
        public BeeBuzzOrganizationRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<BeeBuzzOrganization>> logger) : base(db, logger)
        {

        }

        public List<ApplicationUser> GetAllUsersForOrganization(string orgId)
        {
            var org = _context.BeeHiveOrganizations.Find(orgId);
            if (org == null)
            {
                return null;
            }
            return org.Members;
        }
    }
}
