using Microsoft.EntityFrameworkCore;
using universityApiBackend.Models.DataModels;

namespace universityApiBackend.DataAccess
{
    public class UniversityContexts:DbContext
    {
        public UniversityContexts(DbContextOptions<UniversityContexts>options):base(options) { 
        
        }
        //TODO : ADD DBsets(Tables of our Date Base)

        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? courses { get; set; }
        public DbSet<Chapters> Chapters { get; set; }

        public DbSet<Category>? categories { get; set; }
        public DbSet<Student>? Students { get; set; }



    }
}
