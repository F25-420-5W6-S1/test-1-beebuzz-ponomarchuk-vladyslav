using BeeBuzz.Data.enums;
using System.ComponentModel.DataAnnotations;

namespace BeeBuzz.Data.Entities
{
    public class Beehive
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public Status Status { get; set; }
        public DeactivationReason DeactivationReason { get; set; }
    }
}
