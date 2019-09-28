
namespace webEval.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public enum Gender
    {
        Masculino,
        Femenino

    }
    public class Estudiante
    {
        [Key]
        [Required]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public Gender gender { get; set; }
        public virtual ICollection<Nota>Notas { get; set; }
    }
}