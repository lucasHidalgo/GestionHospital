using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHospital.Data.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public double Salary { get; set; }
        public Users User { get; set; }
        public Role Role { get; set; }
    }
}
