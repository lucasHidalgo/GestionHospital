using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHospital.Data.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
