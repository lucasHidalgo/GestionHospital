using System.Threading.Tasks;
using GestionHospital.Data.Models;

namespace GestionHospital.Data.Data
{
    public interface IUserRepository
    {
          Task CreateNewUser(Users user);
    }
}