using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webEval.Models
{
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
        [Range(1,100)]
        public int Calificacion { get; set; }
        [Required]
        public Estado estado { get; set; }
        [Required]
        public string Materia { get; set; }
        public Estudiante Estudiante { get; set; }

    }
}