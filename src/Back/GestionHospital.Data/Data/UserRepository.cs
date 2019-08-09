using System.Threading.Tasks;
using GestionHospital.Data.Models;

namespace GestionHospital.Data.Data
{
    public class UserRepository: IUserRepository
    {
        public DataContext _context {get;set;}
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task CreateNewUser(Users user) 
        {
            await _context.Users.AddAsync(user);      
            await _context.SaveChangesAsync();      
        }
    }
}