using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionHospital.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionHospital.Data.Data
{
    public class UserRepository: IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task CreateNewUser(Users user) 
        {
            await _context.Users.AddAsync(user);      
            await _context.SaveChangesAsync();      
        }

        public async Task CreateNewUser(Doctors doctor)
        {
            await _context.Doctors.AddAsync(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Doctors>> GetDoctors()
        {
            var usuarios = await _context.Users.ToListAsync();
            var doctores = await _context.Users.Where(x => x.Doctor != null).ToListAsync();
            return await _context.Doctors.ToListAsync();
        }
    }
}