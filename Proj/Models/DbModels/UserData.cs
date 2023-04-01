
using Proj.DomainService;

namespace Proj.Models.DbModels
{
    public class UserData : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PC> PcUsers { get; set; }
    }
}
