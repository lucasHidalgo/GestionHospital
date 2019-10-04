using System.Collections.Generic;
using System.Threading.Tasks;
using GestionHospital.Data.Data;
using GestionHospital.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionHospital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _UserRepository;

        public UsersController(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        [HttpPost("CreateNewUser")]
        public async Task<IActionResult> CreateNewUser(Users user)
        {
            var doctors = new List<Doctors>();
            try
            {
                await _UserRepository.CreateNewUser(user);
                var doctor = new Doctors { UserId = user.Id, Salary = 5000 };
                await _UserRepository.CreateNewUser(doctor);
                doctors = await _UserRepository.GetDoctors();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());
            }

            return Ok(doctors);
        }
    }
}