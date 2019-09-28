

namespace apiEval.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum Estado
    {
        Aprobado,
        Reprobado

    }
    public class Nota
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [Range(1, 100)]
        public int Calificacion { get; set; }
        [Required]
        public Estado estado { get; set; }
        [Required]
        public string Materia { get; set; }
    }
}