using PrimeiroMVC.Models;
using SGE.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Id das Materias")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Título da Materias")]
        public string Titulo { get; set; } = string.Empty;

        [ForeignKey("Professor_FK")]
        [Display(Name = "Professores")]
        public int ProfessoresId { get; set; }
        public Professores? Professores { get; set; }

    }
}