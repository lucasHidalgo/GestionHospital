using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GestionHospital.Data.Models
{
    public class Specializations
    {
        public Specializations()
        {
            DoctorSpecializations = new HashSet<DoctorSpecialization>();
            Appointments = new HashSet<Appointment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<DoctorSpecialization> DoctorSpecializations { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
