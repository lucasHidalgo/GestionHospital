using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHospital.Data.Models
{
    public class DoctorSpecialization
    {
        public int DoctorId { get; set; }
        public int SpecializationId { get; set; }
        public Users Doctor { get; set; }
        public Specializations Specialization { get; set; }
    }
}
