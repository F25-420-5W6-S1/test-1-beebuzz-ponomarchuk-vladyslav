using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzBeehiveRepository : BeeBuzzGenericGenericRepository<Beehive>
    {
        public BeeBuzzBeehiveRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Beehive>> logger) : base(db, logger) 
        {
        
        }
    }
}
