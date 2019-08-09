using GestionHospital.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionHospital.Data.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }   

        public DbSet<Users> Users { get; set; }
        
    }
}