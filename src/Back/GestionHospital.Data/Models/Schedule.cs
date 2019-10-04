using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHospital.Data.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public Users User { get; set; }

    }
}
