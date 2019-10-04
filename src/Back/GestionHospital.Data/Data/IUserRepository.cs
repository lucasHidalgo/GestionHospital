using System.Collections.Generic;
using System.Threading.Tasks;
using GestionHospital.Data.Models;

namespace GestionHospital.Data.Data
{
    public interface IUserRepository
    {
        Task CreateNewUser(Users user);
        Task CreateNewUser(Doctors doctor);
        Task<List<Doctors>> GetDoctors();
    }
}