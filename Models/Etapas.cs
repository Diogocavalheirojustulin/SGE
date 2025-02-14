using PrimeiroMVC.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models

{ 
   [Table("Etapas")]
    public class Etapas
    {
    [Column("Id")]
    [Display(Name = "Id das Materias")]
    public int Id { get; set; }

    [Column("titulo")]
    [Display(Name = "Título da Materias")]
    public string Titulo { get; set; } = string.Empty;

    [Column("Ano")]
    [Display(Name = "Ano")]
    public int Ano { get; set; }
    }
}
