using Proj.Models;
using Proj.Models.DbModels;

namespace Proj.DomainService
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List <UserData> getAllUsers()
        {
            var users = _context.User.ToList();
            return users;
        }
    }
}
