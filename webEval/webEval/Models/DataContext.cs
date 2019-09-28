
namespace webEval.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<webEval.Models.Estudiante> Estudiantes { get; set; }

        public System.Data.Entity.DbSet<webEval.Models.Nota> Notas { get; set; }
    }
}