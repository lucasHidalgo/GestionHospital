using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHospital.Data.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int SpecializationId { get; set; }
        public int ConsultingRoomId { get; set; }
        public DateTime DateAppointment { get; set; }
        public Users Doctor { get; set; }
        public Users Patient { get; set; }
        public Specializations Specialization { get; set; }
        public ConsultingRoom ConsultingRoom { get; set; }
        

    }
}
