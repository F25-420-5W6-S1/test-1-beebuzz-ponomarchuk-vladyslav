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

        public List<Beehive> GetAllBeehivesForOrganization(string orgId)
        {
            var org = _context.BeeHiveOrganizations.Find(orgId);
            if (org == null)
            {
                return null;
            }

            List<Beehive> hives = new List<Beehive>();

            foreach (ApplicationUser user in org.Members) {
                var beehiveList = user.ManagedBeehives;
                foreach (Beehive hive in beehiveList)
                {
                    if (!hives.Contains(hive))
                    {
                        hives.Add(hive);
                    }
                }
            }

            return hives;
        }
    }
}
