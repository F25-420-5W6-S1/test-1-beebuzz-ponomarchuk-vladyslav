using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzOrganizationRepository : BeeBuzzGenericGenericRepository<Organization>
    {
        public BeeBuzzOrganizationRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Organization>> logger) : base(db, logger)
        {

        }
    }
}
