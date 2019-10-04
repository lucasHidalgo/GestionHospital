using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHospital.Data.Models
{
    public class Patients
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SocialNumber { get; set; }
        public string MedicalPlan { get; set; }
        public Users User { get; set; }
    }
}
