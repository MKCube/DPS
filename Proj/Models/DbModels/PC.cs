using System.ComponentModel.DataAnnotations;

namespace Proj.Models.DbModels
{
    public class PC : BaseEntity
    {
        public bool Acctive { get; set; }

        [Required]
        [StringLength(80)]
        public string SerialNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string Model { get; set; }

        public UserData AssignedUser { get; set; }
    }


}
