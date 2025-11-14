using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<Beehive> ManagedBeehives { get; set; }
    }
}
