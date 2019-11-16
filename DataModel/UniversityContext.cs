////////DbConnection
////////    : base("name=UniversityContext")
using System.Data.Entity;

namespace University.DataModel
{
    class UniversityContext : DbContext
    {
        public UniversityContext()
            : base("DefaultConnection")
        {
        }
        public DbSet <Enrollee> Enrollees { get; set; }
        public DbSet <ExamSheet> ExamSheets { get; set; }
        public DbSet <Specialty> Specialties { get; set; }
        public DbSet <Discipline> Disciplines { get; set; }

    }
}