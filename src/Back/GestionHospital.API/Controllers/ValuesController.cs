using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionHospital.Data.Data;
using GestionHospital.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionHospital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext context;
        public ValuesController(DataContext context)
        {
            this.context = context;
        }
        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {            
            var usuarios = context.Usuarios.ToList();            
            return Ok(usuarios);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
