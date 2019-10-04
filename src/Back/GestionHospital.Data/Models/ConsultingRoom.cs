using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHospital.Data.Models
{
    public class ConsultingRoom
    {
        public ConsultingRoom()
        {
            Appointments = new HashSet<Appointment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public string Area { get; set; }
        public string Comments { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
