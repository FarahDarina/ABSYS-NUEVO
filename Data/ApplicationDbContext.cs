using Microsoft.EntityFrameworkCore;
using ABSYS.Models; 

namespace ABSYS.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}

