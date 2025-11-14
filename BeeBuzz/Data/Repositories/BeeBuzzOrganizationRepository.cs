using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzOrganizationRepository : BeeBuzzGenericGenericRepository<BeeBuzzOrganization>
    {
        public BeeBuzzOrganizationRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<BeeBuzzOrganization>> logger) : base(db, logger)
        {

        }

        public Task<List<ApplicationUser>> GetAllUsersForOrganization()
        {
            return null;
        }
    }
}
