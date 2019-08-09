using System.Threading.Tasks;
using GestionHospital.Data.Data;
using GestionHospital.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionHospital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private readonly IUserRepository _UserRepository;

        public UsersController(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        [HttpPost("CreateNewUser")]
        public async Task<IActionResult> CreateNewUser(Users user)
        {
            try
            {
                await _UserRepository.CreateNewUser(user);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());                
            }

            return Ok();
        }
    }
}