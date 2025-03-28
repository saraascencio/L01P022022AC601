using System.ComponentModel.DataAnnotations;

namespace L01P022022AC601.Models
{
    public class materias
    {
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Materia")]
        [Required(ErrorMessage ="El nombre de la materia NO es opcional")]
        public string? materia { get; set; }

        [Display(Name = "Unidades Valorativas")]
        public int? unidades_valorativas { get; set; }

        [Display(Name = "Estado")]
        public char? estado { get; set; }
    }
}
