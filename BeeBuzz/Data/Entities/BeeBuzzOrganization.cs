using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    public class BeeBuzzOrganization
    {
        [Key]
        [Required]
        public string OrganizationId { get; set; }
        public List<ApplicationUser> Members { get; set; }
    }
}
