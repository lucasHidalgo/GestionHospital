using GestionHospital.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionHospital.Data.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Employees> Employees{ get; set; }
        public DbSet<Specializations> Specialization{ get; set; }
        public DbSet<ConsultingRoom> ConsultingRomRooms { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Users with Doctors/Patients/Employees
            modelBuilder.Entity<Users>()
                .HasOne(a => a.Doctor)
                .WithOne(a => a.User)
                .HasForeignKey<Doctors>(c => c.UserId);

            modelBuilder.Entity<Users>()
                .HasOne(a => a.Patient)
                .WithOne(a => a.User)
                .HasForeignKey<Patients>(c => c.UserId);

            modelBuilder.Entity<Users>()
                .HasOne(a => a.Employee)
                .WithOne(a => a.User)
                .HasForeignKey<Employees>(c => c.UserId);
            // Appointments
            modelBuilder.Entity<Appointment>()
                .HasOne(e => e.Patient)
                .WithMany(e => e.PatientAppointments)
                .HasForeignKey(e => e.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasOne(e => e.Doctor)
                .WithMany(e => e.DoctorAppointments)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            // doctor specializations
            modelBuilder.Entity<DoctorSpecialization>()
                .HasKey(k => new { k.DoctorId, k.SpecializationId });
            modelBuilder.Entity<DoctorSpecialization>()
                .HasOne(u => u.Doctor)
                .WithMany(u => u.DoctorSpecializations)
                .HasForeignKey(u => u.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DoctorSpecialization>()
                .HasOne(u => u.Specialization)
                .WithMany(u => u.DoctorSpecializations)
                .HasForeignKey(u => u.SpecializationId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}