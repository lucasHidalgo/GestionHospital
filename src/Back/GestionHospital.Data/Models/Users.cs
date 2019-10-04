using System.Collections.Generic;

namespace GestionHospital.Data.Models
{
    public class Users
    {
        public Users()
        {
            Schedules = new HashSet<Schedule>();
            DoctorSpecializations = new HashSet<DoctorSpecialization>();
            DoctorAppointments = new HashSet<Appointment>();
            PatientAppointments = new HashSet<Appointment>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string  Password { get; set; }
        public string Email { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public Doctors Doctor { get; set; }
        public Patients Patient { get; set; }
        public Employees Employee { get; set; }
        public ICollection<DoctorSpecialization> DoctorSpecializations { get; set; }
        public ICollection<Appointment> DoctorAppointments { get; set; }
        public ICollection<Appointment> PatientAppointments { get; set; }
    }
}