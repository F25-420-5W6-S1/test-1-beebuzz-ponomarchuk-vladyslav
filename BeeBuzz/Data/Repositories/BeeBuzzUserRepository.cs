using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzUserRepository : BeeBuzzGenericGenericRepository<ApplicationUser>
    {
        public BeeBuzzUserRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<ApplicationUser>> logger) : base(db, logger)
        {

        }
    }
}
